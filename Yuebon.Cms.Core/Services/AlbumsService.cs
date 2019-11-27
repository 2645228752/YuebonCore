using System;
using Yuebon.Commons.Services;
using Yuebon.CMS.IRepositories;
using Yuebon.CMS.IServices;
using Yuebon.CMS.Models;
using Yuebon.Security.IServices;

namespace Yuebon.CMS.Services
{
    public class AlbumsService : BaseService<Albums, string>, IAlbumsService
    {
		private readonly IAlbumsRepository _repository;
        private readonly ILogService _logService;
        public AlbumsService(IAlbumsRepository repository,ILogService logService) : base(repository)
        {
			_repository=repository;
			_logService=logService;
            _repository.OnOperationLog += _logService.OnOperationLog;
        }
    }
}