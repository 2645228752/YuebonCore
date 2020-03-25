using System;
using Yuebon.Commons.IServices;
using Yuebon.Security.Dtos;
using Yuebon.Security.Models;

namespace Yuebon.Security.IServices
{
    /// <summary>
    /// ��־��¼
    /// </summary>
    public interface ILogService:IService<Log, LogOutputDto, string>
    {
        /// <summary>
        /// ���������Ϣ��д���û��Ĳ�����־��¼
        /// </summary>
        /// <param name="tableName">����������</param>
        /// <param name="operationType">��������</param>
        /// <param name="note">������ϸ����</param>
        /// <returns></returns>
         bool OnOperationLog(string tableName, string operationType, string note);
    }
}
