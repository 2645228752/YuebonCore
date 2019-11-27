using System;
using System.Collections.Generic;
using Yuebon.Commons.Services;
using Yuebon.Security.IRepositories;
using Yuebon.Security.IServices;
using Yuebon.Security.Models;

namespace Yuebon.Security.Services
{
    public class FunctionService: BaseService<Function, string>, IFunctionService
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
    }
}