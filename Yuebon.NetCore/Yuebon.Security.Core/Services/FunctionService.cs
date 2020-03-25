using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yuebon.Commons.Mapping;
using Yuebon.Commons.Services;
using Yuebon.Security.Dtos;
using Yuebon.Security.IRepositories;
using Yuebon.Security.IServices;
using Yuebon.Security.Models;

namespace Yuebon.Security.Services
{
    public class FunctionService: BaseService<Function, FunctionOutputDto, string>, IFunctionService
    {
        private readonly IFunctionRepository functionRepository;
        private readonly ILogService _logService;
        public FunctionService(IFunctionRepository repository, ILogService logService) : base(repository)
        {
            functionRepository = repository;
            _logService = logService;
            functionRepository.OnOperationLog += _logService.OnOperationLog;
        }

        /// <summary>
        /// ���ݽ�ɫID�ַ��������ŷֿ�)��ϵͳ����ID����ȡ��Ӧ�Ĳ��������б�
        /// </summary>
        /// <param name="roleIDs">��ɫID</param>
        /// <param name="typeID">ϵͳ����ID</param>
        /// <returns></returns>
        public IEnumerable<Function> GetFunctions(string roleIDs, string typeID)
        {
            return functionRepository.GetFunctions(roleIDs, typeID);
        }

        /// <summary>
        /// ���ݸ������ܱ����ѯ�����Ӽ����ܣ���Ҫ����ҳ�������ťȨ��
        /// </summary>
        /// <param name="enCode">�˵����ܱ���</param>
        /// <returns></returns>
        public async Task<IEnumerable<FunctionOutputDto>> GetListByParentEnCode(string enCode)
        {
            string where = string.Format("EnCode='{0}'",enCode);
            Function function = await functionRepository.GetWhereAsync(where);
            where = string.Format("ParentId='{0}'", function.ParentId);
            IEnumerable<Function> list = await functionRepository.GetAllByIsNotEnabledMarkAsync(where);
            return list.MapTo<FunctionOutputDto>().ToList();
        }
    }
}