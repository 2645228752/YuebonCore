using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text.Json;
using Yuebon.Commons.Cache;
using Yuebon.Commons.Json;
using Yuebon.Commons.Log;
using Yuebon.Commons.Net;
using Yuebon.Commons.Services;
using Yuebon.Security.Dtos;
using Yuebon.Security.IRepositories;
using Yuebon.Security.IServices;
using Yuebon.Security.Models;

namespace Yuebon.Security.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class LogService: BaseService<Log, LogOutputDto, string>, ILogService
    {
        private readonly ILogRepository _iLogRepository;
        private readonly IUserRepository _iuserRepository;
        IHttpContextAccessor _httpContextAccessor;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="repository"></param>
        /// <param name="userRepository"></param>
        /// <param name="httpContextAccessor"></param>
        public LogService(ILogRepository repository, IUserRepository userRepository, IHttpContextAccessor httpContextAccessor) : base(repository)
        {
            _iLogRepository = repository;
            _iuserRepository = userRepository;
            _httpContextAccessor = httpContextAccessor;
        }


        /// <summary>
        /// ���������Ϣ��д���û��Ĳ�����־��¼
        /// </summary>
        /// <param name="tableName">����������</param>
        /// <param name="operationType">��������</param>
        /// <param name="note">������ϸ����</param>
        /// <returns></returns>
        public bool OnOperationLog(string tableName, string operationType, string note)
        {
            try
            {
                //��Ȼʵ��������¼����������ǻ���Ҫ�жϸñ��Ƿ������ñ����棬������ڣ��򲻼�¼������־��
                var identities = _httpContextAccessor.HttpContext.User.Identities;
                var claimsIdentity = identities.First<ClaimsIdentity>();
                List<Claim> claimlist = claimsIdentity.Claims as List<Claim>;
                string userId = claimlist[0].Value;
                YuebonCacheHelper yuebonCacheHelper = new YuebonCacheHelper();
                YuebonCurrentUser CurrentUser = new YuebonCurrentUser();
                var user = JsonSerializer.Deserialize<YuebonCurrentUser>(yuebonCacheHelper.Get("login_user_" + userId).ToJson());
                if (user != null)
                {
                    CurrentUser = user;
                    bool insert = operationType == DbLogType.Create.ToString(); ;//&& settingInfo.InsertLog;
                    bool update = operationType == DbLogType.Update.ToString();// && settingInfo.UpdateLog;
                    bool delete = operationType == DbLogType.Delete.ToString();// && settingInfo.DeleteLog;
                    bool deletesoft = operationType == DbLogType.DeleteSoft.ToString();// && settingInfo.DeleteLog;
                    bool exception = operationType == DbLogType.Exception.ToString();// && settingInfo.DeleteLog;
                    bool sql = operationType == DbLogType.SQL.ToString();// && settingInfo.DeleteLog;

                    if (insert || update || delete || deletesoft || exception || sql)
                    {
                        Log info = new Log();
                        info.ModuleName = tableName;
                        info.Type = operationType;
                        info.Description = note;
                        info.Date = info.CreatorTime = DateTime.Now;
                        info.CreatorUserId = CurrentUser.UserId;
                        info.Account = CurrentUser.Account;
                        info.NickName = CurrentUser.NickName;
                        info.OrganizeId = CurrentUser.OrganizeId;
                        info.IPAddress = CurrentUser.CurrentLoginIP;
                        info.IPAddressName = CurrentUser.IPAddressName;
                        info.Result = true;
                        long lg = _iLogRepository.Insert(info);
                        if (lg > 0)
                        {
                            return true;
                        }
                    }
                }
            }catch(Exception ex)
            {
                Log4NetHelper.Error("",ex);
                return false;
            }
            return false;
        }


        /// <summary>
        /// ���������Ϣ��д���û��Ĳ�����־��¼
        /// ��Ҫ����д����ģ����־
        /// </summary>
        /// <param name="module">����ģ������</param>
        /// <param name="operationType">��������</param>
        /// <param name="note">������ϸ����</param>
        /// <param name="currentUser">�����û�</param>
        /// <returns></returns>
        public bool OnOperationLog(string module, string operationType, string note, YuebonCurrentUser currentUser)
        {
            //��Ȼʵ��������¼����������ǻ���Ҫ�жϸñ��Ƿ������ñ����棬������ڣ��򲻼�¼������־��
            //OperationLogSettingInfo settingInfo = BLLFactory<OperationLogSetting>.Instance.FindByTableName(tableName, trans);
            
            if (currentUser != null)
            {
                bool login = operationType == DbLogType.Login.ToString();
                bool visit = operationType == DbLogType.Visit.ToString();
                bool exit = operationType == DbLogType.Exit.ToString();
                bool other = operationType == DbLogType.Other.ToString();
                bool insert = operationType == DbLogType.Create.ToString();
                bool update = operationType == DbLogType.Update.ToString();
                bool delete = operationType == DbLogType.Delete.ToString();
                bool deletesoft = operationType == DbLogType.DeleteSoft.ToString();
                bool exception = operationType == DbLogType.Exception.ToString();
                if (login|| visit|| exit|| other||insert || update || delete || deletesoft || exception)
                {
                    Log info = new Log();
                    info.ModuleName = module;
                    info.Type = operationType;
                    info.Description = note;
                    info.Date = info.CreatorTime = DateTime.Now;
                    info.CreatorUserId = currentUser.UserId;
                    info.Account = currentUser.Account;
                    info.NickName = currentUser.NickName;
                    info.OrganizeId = currentUser.OrganizeId;
                    info.IPAddress = currentUser.CurrentLoginIP;
                    info.IPAddressName = IpAddressUtil.GetCityByIp(currentUser.CurrentLoginIP);
                    info.Result = true;
                    long lg = _iLogRepository.Insert(info);
                    if (lg > 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}