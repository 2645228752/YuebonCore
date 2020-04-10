using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Yuebon.AspNetCore.Controllers;
using Yuebon.AspNetCore.Models;
using Yuebon.Commons.Helpers;
using Yuebon.Commons.Log;
using Yuebon.Commons.Mapping;
using Yuebon.Commons.Models;
using Yuebon.Commons.Pages;
using Yuebon.Security.Dtos;
using Yuebon.Security.Models;
using Yuebon.Security.IServices;
using Yuebon.AspNetCore.Mvc.Filter;

namespace Yuebon.WebApi.Areas.Security.Controllers
{
    /// <summary>
    /// 模块功能接口
    /// </summary>
    [ApiController]
    [Route("api/Security/[controller]")]
    public class FunctionController : AreaApiController<Function, FunctionOutputDto, IFunctionService,string>
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="_iService"></param>
        public FunctionController(IFunctionService _iService) : base(_iService)
        {
            iService = _iService;
            AuthorizeKey.ListKey = "Function/List";
            AuthorizeKey.InsertKey = "Function/Add";
            AuthorizeKey.UpdateKey = "Function/Edit";
            AuthorizeKey.UpdateEnableKey = "Function/Enable";
            AuthorizeKey.DeleteKey = "Function/Delete";
            AuthorizeKey.DeleteSoftKey = "Function/DeleteSoft";
            AuthorizeKey.ViewKey = "Function/View";
        }
        /// <summary>
        /// 新增前处理数据
        /// </summary>
        /// <param name="info"></param>
        protected override void OnBeforeInsert(Function info)
        {
            info.Id = GuidUtils.CreateNo();
            info.CreatorTime = DateTime.Now;
            info.CreatorUserId = CurrentUser.UserId;
            info.DeleteMark = false;
            if (info.SortCode == null)
            {
                info.SortCode = 99;
            }
        }
        
        /// <summary>
        /// 在更新数据前对数据的修改操作
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        protected override void OnBeforeUpdate(Function info)
        {
            info.LastModifyUserId = CurrentUser.UserId;
            info.LastModifyTime = DateTime.Now;
        }

        /// <summary>
        /// 在软删除数据前对数据的修改操作
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        protected override void OnBeforeSoftDelete(Function info)
        {
            info.DeleteMark = true;
            info.DeleteTime = DateTime.Now;
            info.DeleteUserId = CurrentUser.UserId;
        }


        /// <summary>
        /// 根据父级功能编码查询所有子集功能，主要用于页面操作按钮权限
        /// </summary>
        /// <param name="enCode">菜单功能编码</param>
        /// <returns></returns>
        [HttpGet("GetListByItemCode")]
        [NoPermissionRequired]
        public async Task<IActionResult> GetListByItemCode(string enCode)
        {
            CommonResult result = new CommonResult();
            try
            {

                IEnumerable<FunctionOutputDto> list = await iService.GetListByParentEnCode(enCode);
                result.ErrCode = ErrCode.successCode;
                result.ResData = list;
            }
            catch(Exception ex)
            {

            }
            return ToJsonContent(result);
        }
    }
}