using System;
using Yuebon.Commons.IServices;
using Yuebon.Security.Models;

namespace Yuebon.Security.IServices
{
    public interface ILogService:IService<Log, string>
    {
        /// <summary>
        /// ���������Ϣ��д���û��Ĳ�����־��¼
        /// </summary>
        /// <param name="userId">�����û�</param>
        /// <param name="tableName">����������</param>
        /// <param name="operationType">��������</param>
        /// <param name="note">������ϸ����</param>
        /// <returns></returns>
         bool OnOperationLog(string userId, string tableName, string operationType, string note);
    }
}
