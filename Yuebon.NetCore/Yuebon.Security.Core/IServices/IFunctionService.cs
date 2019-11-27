using System;
using System.Collections.Generic;
using Yuebon.Commons.IServices;
using Yuebon.Security.Models;

namespace Yuebon.Security.IServices
{
    public interface IFunctionService: IService<Function, string>
    {

        /// <summary>
        /// ���ݽ�ɫID�ַ��������ŷֿ�)��ϵͳ����ID����ȡ��Ӧ�Ĳ��������б�
        /// </summary>
        /// <param name="roleIDs">��ɫID</param>
        /// <param name="typeID">ϵͳ����ID</param>
        /// <returns></returns>
        IEnumerable<Function> GetFunctions(string roleIDs, string typeID);
    }
}
