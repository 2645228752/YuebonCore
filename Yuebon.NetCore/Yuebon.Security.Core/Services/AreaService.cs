using System;
using Yuebon.Commons.Services;
using Yuebon.Security.Dtos;
using Yuebon.Security.IRepositories;
using Yuebon.Security.IServices;
using Yuebon.Security.Models;

namespace Yuebon.Security.Services
{
    /// <summary>
    /// ������Ϣ
    /// </summary>
    public class AreaService: BaseService<Area, AreaOutputDto, string>, IAreaService
    {
        private readonly IAreaRepository _repository;
        private readonly ILogService _logService;
        public AreaService(IAreaRepository repository, ILogService logService) : base(repository)
        {
            _repository = repository;
            _logService = logService;
            _repository.OnOperationLog += _logService.OnOperationLog;
        }
    }
}