using System;
using System.Collections.Generic;
using Yuebon.Commons.IServices;
using Yuebon.Security.Models;

namespace Yuebon.Security.IServices
{
    public interface IMenuService:IService<Menu, string>
    {

        /// <summary>
        /// �����û���ȡ���ܲ˵�
        /// </summary>
        /// <param name="userId">�û�ID</param>
        /// <returns></returns>
        List<Menu> GetMenuByUser(string userId);
    }
}
