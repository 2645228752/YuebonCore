using System;
using Yuebon.Commons.Services;
using Yuebon.Security.IRepositories;
using Yuebon.Security.IServices;
using Yuebon.Security.Models;

namespace Yuebon.Security.Services
{
    public class SystemTypeService : BaseService<SystemType, string>, ISystemTypeService
    {
        private readonly ISystemTypeRepository _repository;
        private readonly ILogService _logService;
        public SystemTypeService(ISystemTypeRepository repository, ILogService logService) : base(repository)
        {
            _repository = repository;
            _logService = logService;
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
    }
}