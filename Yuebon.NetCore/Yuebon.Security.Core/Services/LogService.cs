using Microsoft.AspNetCore.Http;
using System;
using Yuebon.Commons.Helpers;
using Yuebon.Commons.Log;
using Yuebon.Commons.IRepositories;
using Yuebon.Commons.Services;
using Yuebon.Security.Dtos;
using Yuebon.Security.IRepositories;
using Yuebon.Security.IServices;
using Yuebon.Security.Models;

namespace Yuebon.Security.Services
{
    public class LogService: BaseService<Log, string>, ILogService
    {
        private readonly ILogRepository _iLogRepository;
        private readonly IUserRepository _iuserRepository;

        public LogService(ILogRepository repository, IUserRepository userRepository) : base(repository)
        {
            _iLogRepository = repository;
            _iuserRepository = userRepository;
        }

        /// <summary>
        /// ���������Ϣ��д���û��Ĳ�����־��¼
        /// </summary>
        /// <param name="userId">�����û�</param>
        /// <param name="tableName">����������</param>
        /// <param name="operationType">��������</param>
        /// <param name="note">������ϸ����</param>
        /// <returns></returns>
        public  bool OnOperationLog(string userId, string tableName, string operationType, string note)
        {
            //��Ȼʵ��������¼����������ǻ���Ҫ�жϸñ��Ƿ������ñ����棬������ڣ��򲻼�¼������־��
            //OperationLogSettingInfo settingInfo = BLLFactory<OperationLogSetting>.Instance.FindByTableName(tableName, trans);
            //if (settingInfo != null)
            //{
            //UserLoginDto CurrentUser = SessionHelper.GetSession<UserLoginDto>("CurrentUser");
            //if (CurrentUser!=null) {
                bool insert = operationType == DbLogType.Create.ToString(); ;//&& settingInfo.InsertLog;
                bool update = operationType == DbLogType.Update.ToString();// && settingInfo.UpdateLog;
                bool delete = operationType == DbLogType.Delete.ToString();// && settingInfo.DeleteLog;
                bool deletesoft = operationType == DbLogType.DeleteSoft.ToString();// && settingInfo.DeleteLog;
                bool exception = operationType == DbLogType.Exception.ToString();// && settingInfo.DeleteLog;
                if (insert || update || delete || deletesoft || exception)
                {
                    Log info = new Log();

                    info.ModuleName = tableName;
                    info.Type = operationType;
                    info.Description = note;
                    info.Date = info.CreatorTime = DateTime.Now;

                    if (!string.IsNullOrEmpty(userId))
                    {
                        User userInfo = _iuserRepository.Get(userId);
                        if (userInfo != null)
                        {
                            info.CreatorUserId = userId;
                            info.Account = userInfo.Account;
                            info.NickName = userInfo.RealName;
                            info.OrganizeId = userInfo.OrganizeId;
                            //info.IPAddress = userInfo.CurrentLoginIP;
                        }
                    }
                    long lg = _iLogRepository.Insert(info);
                    if (lg > 0)
                    {
                        return true;
                    }
                }
            //}
            return false;
        }
    }
}