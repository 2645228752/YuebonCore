﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using Yuebon.AspNetCore.Controllers;
using Yuebon.AspNetCore.Models;
using Yuebon.AspNetCore.Mvc;
using Yuebon.AspNetCore.SSO;
using Yuebon.Commons.Cache;
using Yuebon.Commons.IoC;
using Yuebon.Commons.Json;
using Yuebon.Commons.Log;
using Yuebon.Commons.Models;
using Yuebon.Commons.Options;
using Yuebon.Security.Application;
using Yuebon.Security.Dtos;
using Yuebon.Security.IServices;
using Yuebon.Security.Models;

namespace Yuebon.WebApi.Areas.Security.Controllers
{
    /// <summary>
    /// 用户接口控制器
    /// </summary>
    [Route("api/Security/[controller]")]
    public class UserController: AreaApiController<User, IUserService>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_iService"></param>
        public UserController(IUserService _iService) : base(_iService)
        {
        }

        /// <summary>
        /// 获取所有用户信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            CommonResult result = new CommonResult();
            try
            {
                result = CheckToken();
                if (result.ErrCode == ErrCode.successCode)
                {
                    IEnumerable<User> list = await iService.GetAllAsync();
                    List<UserOutPutDto> resultlist = new List<UserOutPutDto>();
                    foreach (User user in list)
                    {
                        UserOutPutDto model = new UserOutPutDto();
                        model.Account = user.Account;
                        model.Birthday = user.Birthday;
                        model.Email = user.Email;
                        model.Gender = user.Gender;
                        model.HeadIcon = user.HeadIcon;
                        model.Id = user.Id;
                        model.IsAdministrator = user.IsAdministrator;
                        model.ManagerId = user.ManagerId;
                        model.MobilePhone = user.MobilePhone;
                        model.NickName = user.NickName;
                        model.OrganizeId = user.OrganizeId;
                        model.RealName = user.RealName;
                        model.RoleId = user.RoleId;
                        model.SecurityLevel = user.SecurityLevel;
                        model.Signature = user.Signature;
                        model.WeChat = user.WeChat;
                        resultlist.Add(model);
                    }
                    return ToJsonContent(resultlist);
                }
            }catch(Exception ex)
            {
                var type = MethodBase.GetCurrentMethod().DeclaringType;
                Log4NetHelper.WriteError(type, ex);
            }
            return ToJsonContent(result);
        }
        /// <summary>
        /// 根据用户Id获取用户信息
        /// </summary>
        /// <param name="id">主键Id</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            CommonResult result = new CommonResult();
            
            result = CheckToken();
            if (result.ErrCode == ErrCode.successCode)
            {
                User user = await iService.GetAsync(id);
                if (user != null)
                {
                    UserOutPutDto model = new UserOutPutDto();
                    model.Account = user.Account;
                    model.Birthday = user.Birthday;
                    model.Email = user.Email;
                    model.Gender = user.Gender;
                    model.HeadIcon = user.HeadIcon;
                    model.Id = user.Id;
                    model.IsAdministrator = user.IsAdministrator;
                    model.ManagerId = user.ManagerId;
                    model.MobilePhone = user.MobilePhone;
                    model.NickName = user.NickName;
                    model.OrganizeId = user.OrganizeId;
                    model.RealName = user.RealName;
                    model.RoleId = user.RoleId;
                    model.SecurityLevel = user.SecurityLevel;
                    model.Signature = user.Signature;
                    model.WeChat = user.WeChat;
                    return ToJsonContent(model);
                }
                else
                {
                    result.ErrMsg = ErrCode.err50001;
                    result.ErrCode = "50001";
                }
            }
            return ToJsonContent(result);
        }

        /// <summary>
        /// 获取用户扩展信息
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        [HttpGet("GetUserNameCardInfo")]
        public IActionResult GetUserNameCardInfo(string userid)
        {
            CommonResult result = new CommonResult();
            result = CheckToken();
            if (result.ErrCode == ErrCode.successCode)
            {
                UserApp app = new UserApp();
                if (String.IsNullOrEmpty(userid))
                {
                    userid = CurrentUser.UserId;
                }
                UserNameCardOutPutDto outPutDto = app.GetUserNameCardInfo(userid);
                if (outPutDto != null)
                {
                    result.ResData = outPutDto;
                    result.Success = true;
                }
                else
                {
                    result.ErrMsg = ErrCode.err50001;
                    result.ErrCode = "50001";
                }
            }
            return ToJsonContent(result);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="userid"></param>
        /// <param name="headicon"></param>
        /// <param name="nickName"></param>
        /// <param name="name"></param>
        /// <param name="company"></param>
        /// <param name="position"></param>
        /// <param name="weburl"></param>
        /// <param name="mobile"></param>
        /// <param name="email"></param>
        /// <param name="wx"></param>
        /// <param name="wximg"></param>
        /// <param name="industry"></param>
        /// <param name="area"></param>
        /// <param name="address"></param>
        /// <param name="openflag"></param>
        /// <returns></returns>
        [HttpGet("SaveNameCard")]
        public IActionResult SaveNameCard(string userid, string headicon, string nickName, string name, string company, string position,
            string weburl, string mobile, string email, string wx, string wximg,
            string industry, string area, string address, int openflag)
        {
            CommonResult result = new CommonResult();
            result = CheckToken();
            if (result.ErrCode == ErrCode.successCode)
            {
                UserApp app = new UserApp();
                if (String.IsNullOrEmpty(userid))
                {
                    userid = CurrentUser.UserId;
                }
                bool saveresult = app.SaveNameCard(userid, headicon, nickName, name, company, position, weburl,
                    mobile, email, wx, wximg, industry, area, address, openflag);
                if (saveresult)
                {
                    YuebonCacheHelper yuebonCacheHelper = new YuebonCacheHelper();
                    var currentSession = JsonConvert.DeserializeObject<UserAuthSession>(yuebonCacheHelper.Get("login_user_" + userid).ToJson());
                    yuebonCacheHelper.Remove("login_user_" + userid);
                    result.ResData = true;
                    result.Success = true;
                }
                else
                {
                    result.ErrMsg = ErrCode.err50001;
                    result.ErrCode = "50001";
                }
            }
            return ToJsonContent(result);
        }


        /// <summary>
        /// 分页得到所有用户用于关注
        /// </summary>
        /// <param name="currentpage"></param>
        /// <param name="pagesize"></param>
        /// <returns></returns>
        [HttpGet("GetUserAllListFocusByPage")]
        public IActionResult GetUserAllListFocusByPage(string currentpage,
            string pagesize)
        {

            CommonResult result = new CommonResult();
            result = CheckToken();
            if (result.ErrCode == ErrCode.successCode)
            {

                UserApp app = new UserApp();
                IEnumerable<UserAllListFocusOutPutDto> outputDto = app.GetUserAllListFocusByPage(currentpage,
                    pagesize, CurrentUser.UserId);
                if (outputDto != null)
                {

                    result.ResData = outputDto;
                    result.Success = true;
                }
                else
                {
                    result.ErrMsg = ErrCode.err50001;
                    result.ErrCode = "50001";
                }
            }
            return ToJsonContent(result);
        }
    }
}