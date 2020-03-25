using System;
using Yuebon.Commons.Services;
using Yuebon.CMS.IRepositories;
using Yuebon.CMS.IServices;
using Yuebon.CMS.Models;
using Yuebon.Security.IServices;
using System.Collections.Generic;
using Yuebon.CMS.Dtos;

namespace Yuebon.CMS.Services
{
    public class ArticleNewsService : BaseService<ArticleNews, ArticleNewsOutputDto, string>, IArticleNewsService
    {
        private readonly IArticleNewsRepository _repository;
        private readonly ILogService _logService;
        public ArticleNewsService(IArticleNewsRepository repository, ILogService logService) : base(repository)
        {
            _repository = repository;
            _logService = logService;
            _repository.OnOperationLog += _logService.OnOperationLog;
        }

        /// <summary>
        /// �õ������б�idΪ�������ȫ��
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ArticleNewsOutputDto GetArticleNewsListInfo(string id)
        {
            return _repository.GetArticleNewsListInfo(id);
        }

        /// <summary>
        /// ��ҳ�õ��̻��б�
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IEnumerable<ArticleNewsOutputDto> GetArticleListByPageWithFlag(string currentpage,
            string pagesize, int flag, string userid)
        {
            return _repository.GetArticleListByPageWithFlag(currentpage, pagesize, flag, userid);
                 
        }
    }
}