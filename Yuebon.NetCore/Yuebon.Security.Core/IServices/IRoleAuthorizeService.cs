using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Yuebon.Commons.IServices;
using Yuebon.Security.Dtos;
using Yuebon.Security.Models;

namespace Yuebon.Security.IServices
{
    /// <summary>
    /// 
    /// </summary>
    public interface IRoleAuthorizeService:IService<RoleAuthorize, RoleAuthorizeOutputDto, string>
    {
        /// <summary>
        /// ���ݽ�ɫ����Ŀ���Ͳ�ѯȨ��
        /// </summary>
        /// <param name="roleIds"></param>
        /// <param name="itemType"></param>
        /// <returns></returns>
        IEnumerable<RoleAuthorize> GetListRoleAuthorizeByRoleId(string roleIds, int itemType);


        /// <summary>
        /// ��ȡ���ܲ˵�������Vue Tree����
        /// </summary>
        /// <returns></returns>
        Task<List<ModuleFunctionOutputDto>> GetAllFunctionTree();
    }
}
