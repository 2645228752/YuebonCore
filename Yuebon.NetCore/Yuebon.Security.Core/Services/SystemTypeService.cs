using System;
using System.Collections.Generic;
using System.Linq;
using Yuebon.Commons.Mapping;
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
    public class SystemTypeService : BaseService<SystemType, SystemTypeOutputDto, string>, ISystemTypeService
    {
        private readonly ISystemTypeRepository _repository;
        private readonly IRoleAuthorizeService roleAuthorizeService;
        private readonly ILogService _logService;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="repository"></param>
        /// <param name="logService"></param>
        public SystemTypeService(ISystemTypeRepository repository, ILogService logService, IRoleAuthorizeService _roleAuthorizeService) : base(repository)
        {
            _repository = repository;
            _logService = logService;
            roleAuthorizeService = _roleAuthorizeService;
            _repository.OnOperationLog += _logService.OnOperationLog;
        }

        /// <summary>
        /// ����ϵͳ�����ѯϵͳ����
        /// </summary>
        /// <param name="appkey">ϵͳ����</param>
        /// <returns></returns>
        public SystemType GetByCode(string appkey)
        {
            return _repository.GetByCode(appkey);

        }

        /// <summary>
        /// ���ݽ�ɫ��ȡ���Է�����ϵͳ
        /// </summary>
        /// <param name="roleIds">��ɫId����','����</param>
        /// <returns></returns>
        public List<SystemTypeOutputDto> GetSubSystemList(string roleIds)
        {
            string roleIDsStr = string.Empty;
            if (roleIds.IndexOf(',')>0)
            {
                roleIDsStr=string.Format("'{0}'", roleIds.Replace(",", "','"));
            }
            else
            {
                roleIDsStr = string.Format("'{0}'", roleIds); 
            }
            
            IEnumerable<RoleAuthorize> roleAuthorizes = roleAuthorizeService.GetListRoleAuthorizeByRoleId(roleIDsStr, 0);

            string strWhere = " Id in (";
            foreach (RoleAuthorize item in roleAuthorizes)
            {
                strWhere += "'" + item.ItemId + "',";
            }
            strWhere = strWhere.Substring(0, strWhere.Length - 1) + ")";
            List<SystemTypeOutputDto> list = _repository.GetAllByIsNotDeleteAndEnabledMark(strWhere).OrderBy(t => t.SortCode).ToList().MapTo<SystemTypeOutputDto>();
            return list;        
        }
    }
}