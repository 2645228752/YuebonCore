using System;
using System.Collections.Generic;
using Yuebon.Commons.Services;
using Yuebon.Security.Dtos;
using Yuebon.Security.IRepositories;
using Yuebon.Security.IServices;
using Yuebon.Security.Models;

namespace Yuebon.Security.Services
{
    public class APPService: BaseService<APP,string>, IAPPService
    {
        private readonly IAPPRepository _appRepository;
        private readonly ILogService _logService;
        public APPService(IAPPRepository repository, ILogService logService) : base(repository)
        {
            _appRepository = repository;
            _logService = logService;
            _appRepository.OnOperationLog += _logService.OnOperationLog;
        }
        /// <summary>
        /// ��ȡapp����
        /// </summary>
        /// <param name="appid">Ӧ��ID</param>
        /// <param name="secret">Ӧ����ԿAppSecret</param>
        /// <returns></returns>
        public APP GetAPP(string appid, string secret)
        {
            return _appRepository.GetAPP(appid, secret);
        }
        /// <summary>
        /// ��ȡapp����
        /// </summary>
        /// <param name="appid">Ӧ��ID</param>
        /// <returns></returns>
        public APP GetAPP(string appid)
        {
            return _appRepository.GetAPP(appid);
        }
        public IList<AppOutputDto> SelectApp()
        {
            return _appRepository.SelectApp();
        }
    }
}