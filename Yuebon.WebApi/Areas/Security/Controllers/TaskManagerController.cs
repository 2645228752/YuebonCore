using Microsoft.AspNetCore.Mvc;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Yuebon.AspNetCore.Controllers;
using Yuebon.AspNetCore.Models;
using Yuebon.AspNetCore.Mvc;
using Yuebon.Commons.Helpers;
using Yuebon.Commons.Log;
using Yuebon.Commons.Mapping;
using Yuebon.Commons.Models;
using Yuebon.Commons.Pages;
using Yuebon.Quartz.Jobs;
using Yuebon.Security.Application;
using Yuebon.Security.Dtos;
using Yuebon.Security.IServices;
using Yuebon.Security.Models;
using Yuebon.WebApi.Areas.Security.Models;

namespace Yuebon.WebApi.Areas.Security.Controllers
{
    /// <summary>
    /// 定时任务接口
    /// </summary>
    [ApiController]
    [Route("api/Security/[controller]")]
    public class TaskManagerController : AreaApiController<TaskManager, TaskManagerOutputDto,TaskManagerInputDto,ITaskManagerService,string>
    {
        /// <summary>
        /// 
        /// </summary>
        private ISchedulerFactory schedulerFactory;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="_iService"></param>
        /// <param name="_scheduler"></param>
        public TaskManagerController(ITaskManagerService _iService, ISchedulerFactory _schedulerFactory) : base(_iService)
        {
            iService = _iService;
            schedulerFactory = _schedulerFactory;
            AuthorizeKey.ListKey = "TaskManager/List";
            AuthorizeKey.InsertKey = "TaskManager/Add";
            AuthorizeKey.UpdateKey = "TaskManager/Edit";
            AuthorizeKey.UpdateEnableKey = "TaskManager/Enable";
            AuthorizeKey.DeleteKey = "TaskManager/Delete";
            AuthorizeKey.DeleteSoftKey = "TaskManager/DeleteSoft";
            AuthorizeKey.ViewKey = "TaskManager/View";
        }
        /// <summary>
        /// 新增前处理数据
        /// </summary>
        /// <param name="info"></param>
        protected override void OnBeforeInsert(TaskManager info)
        {
            info.Id = new SequenceApp().GetSequenceNext("TaskManager");
            info.DeleteMark = false;
            info.RunCount = 0;
            info.Status = 0;
            info.CreatorTime =info.NextRunTime=info.LastRunTime=info.LastModifyTime= DateTime.Now;
            info.CreatorUserId =info.LastModifyUserId= CurrentUser.UserId;
        }
        
        /// <summary>
        /// 在更新数据前对数据的修改操作
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        protected override void OnBeforeUpdate(TaskManager info)
        {
            info.LastModifyUserId = CurrentUser.UserId;
            info.LastModifyTime = DateTime.Now;
        }

        /// <summary>
        /// 在软删除数据前对数据的修改操作
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        protected override void OnBeforeSoftDelete(TaskManager info)
        {
            info.DeleteMark = true;
            info.DeleteTime = DateTime.Now;
            info.DeleteUserId = CurrentUser.UserId;
        }
        /// <summary>
        /// 异步更新数据
        /// </summary>
        /// <param name="tinfo"></param>
        /// <param name="id">主键Id</param>
        /// <returns></returns>
        [HttpPost("Update")]
        [YuebonAuthorize("Edit")]
        public override async Task<IActionResult> UpdateAsync(TaskManagerInputDto tinfo, string id)
        {
            CommonResult result = new CommonResult();

            TaskManager info = iService.Get(id);
            info.TaskName = tinfo.TaskName;
            info.GroupName = tinfo.GroupName;
            info.JobCallAddress = tinfo.JobCallAddress;
            info.JobCallParams = tinfo.JobCallParams;
            info.Cron = tinfo.Cron;
            info.EnabledMark = tinfo.EnabledMark;
            info.Description = tinfo.Description;
            info.IsLocal = tinfo.IsLocal;


            OnBeforeUpdate(info);
            bool bl = await iService.UpdateAsync(info, id).ConfigureAwait(false);
            if (bl)
            {
                result.ErrCode = ErrCode.successCode;
                result.ErrMsg = ErrCode.err0;
            }
            else
            {
                result.ErrMsg = ErrCode.err43002;
                result.ErrCode = "43002";
            }
            return ToJsonContent(result);
        }

        /// <summary>
        /// 获取本地可执行的任务列表
        /// </summary>
        [HttpGet("GetLocalHandlers")]
        [YuebonAuthorize("List")]
        public IActionResult GetLocalHandlers()
        {
            CommonResult result = new CommonResult();
            try
            {
                result.ResData = QueryLocalHandlers();
                result.ErrCode = ErrCode.successCode;
            }
            catch (Exception ex)
            {
                result.ErrCode ="500";
                result.ErrMsg = ex.InnerException?.Message ?? ex.Message;
            }
            return ToJsonContent(result);
        }
        /// <summary>
        /// 改变任务状态，启动/停止
        /// </summary>
        [HttpPost("ChangeStatus")]
        [YuebonAuthorize("ChangeStatus")]
        public async Task<IActionResult> ChangeStatus(ChangeJobStatusReq req)
        {
            CommonResult result = new CommonResult();
            try
            {
                TaskManager job = iService.Get(req.Id);
               
                if (job == null)
                {
                    throw new Exception("任务不存在");
                }
                OnBeforeUpdate(job);
                job.Status = req.Status;
                IScheduler scheduler =await  schedulerFactory.GetScheduler();
                if (job.Status == 0) //停止
                {
                    TriggerKey triggerKey = new TriggerKey(job.Id,job.GroupName);
                    // 停止触发器
                    await scheduler.PauseTrigger(triggerKey);
                    // 移除触发器
                    await scheduler.UnscheduleJob(triggerKey);
                    // 删除任务
                    await scheduler.DeleteJob(new JobKey(job.Id));
                }
                else  //启动
                {
                    IJobDetail jobDetail;
                    if (job.IsLocal)
                    {
                        var implementationAssembly = Assembly.Load("Yuebon.Quartz.Jobs");
                        var implementationTypes = implementationAssembly.DefinedTypes.Where(t => t.GetInterfaces().Contains(typeof(IJob)));
                        var tyeinfo = implementationTypes.Where(x => x.FullName == job.JobCallAddress).FirstOrDefault();
                        jobDetail = JobBuilder.Create(tyeinfo).WithIdentity(job.Id, job.GroupName).Build();
                    }
                    else
                    {
                        jobDetail = JobBuilder.Create<HttpResultfulJob>().WithIdentity(job.Id, job.GroupName).Build();
                    }
                    jobDetail.JobDataMap["OpenJob"] = job.Id;  //传递job信息
                    ITrigger trigger = TriggerBuilder.Create()
                        .WithCronSchedule(job.Cron)
                        .WithIdentity(job.Id, job.GroupName)
                        .WithDescription(job.Description)
                        .ForJob(job.Id, job.GroupName) //给任务指定一个分组
                        .StartNow()
                        .Build();
                    await scheduler.ScheduleJob(jobDetail, trigger);
                }
                if (job.Status == 1)
                {
                  await scheduler.Start();
                }
                iService.Update(job,job.Id);
                result.ErrCode = ErrCode.successCode;
                result.ErrMsg = "切换成功，可以在系统日志中查看运行结果";

            }
            catch (Exception ex)
            {
                result.ErrCode = "500";
                result.ErrMsg = ex.InnerException?.Message ?? ex.Message;
            }

            return ToJsonContent(result);
        }

        /// <summary>
        /// 返回系统的job接口
        /// </summary>
        /// <returns></returns>
        private List<LocalTaskModel> QueryLocalHandlers()
        {
            var implementationAssembly = Assembly.Load("Yuebon.Quartz.Jobs");
            var implementationTypes =implementationAssembly.DefinedTypes.Where(t =>t.GetInterfaces().Contains(typeof(IJob))).ToArray(); 
            List<string> list= implementationTypes.Select(u => u.FullName).ToList();
            List<LocalTaskModel> resulList = new List<LocalTaskModel>();
            foreach(var item in list)
            {
                LocalTaskModel localTaskModel = new LocalTaskModel();
                localTaskModel.FullName = item;
                resulList.Add(localTaskModel);
            }
            return resulList;
        }
    }
}