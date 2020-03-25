using System;
using Yuebon.Commons.Services;
using Yuebon.CMS.IRepositories;
using Yuebon.CMS.IServices;
using Yuebon.CMS.Models;
using Yuebon.Security.IServices;
using System.Collections.Generic;
using Yuebon.CMS.Dtos;
using System.Linq;

namespace Yuebon.CMS.Services
{
    public class ArticleCategoryService : BaseService<ArticleCategory, ArticleCategoryOutputDto, string>, IArticleCategoryService
    {
        private readonly IArticleCategoryRepository _repository;
        private readonly ILogService _logService;
        public ArticleCategoryService(IArticleCategoryRepository repository, ILogService logService) : base(repository)
        {
            _repository = repository;
            _logService = logService;
            _repository.OnOperationLog += _logService.OnOperationLog;
        }

        /// <summary>
        /// �õ������б�
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IEnumerable<ArticleSimpleCategoryOutputDto> GetArticleCategoryListInfo(string id)
        {
            return _repository.GetArticleCategoryListInfo(id);
        }


        /// <summary>
        /// �õ������б�
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IEnumerable<ArticleIndexCategoryOutputDto> GetArticleIndexCategoryListInfo(string id)
        {
            return _repository.GetArticleIndexCategoryListInfo(id);
        }

        /// <summary>
        /// �õ������б�(������ҳ)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IEnumerable<ArticleIndexCategoryOutputDto> GetUserArticleCategoryListInfo(string userid)
        {
            return _repository.GetUserArticleCategoryListInfo(userid);
        }

        /// <summary>
        /// �õ������б�(������ҳ)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IEnumerable<ArticleIndexCategoryOutputDto> GetUserArticleCategoryListInfoNew(string userid)
        {
            return _repository.GetUserArticleCategoryListInfoNew(userid);
        }

        /// <summary>
        /// �õ�δѡ������б�(������ҳ)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IEnumerable<ArticleIndexCategoryOutputDto> GetUserUnSelArticleCategoryListInfoNew(string userid)
        {
            return _repository.GetUserUnSelArticleCategoryListInfoNew(userid);
        }

        /// <summary>
        /// �õ�δѡ������б�(������ҳ)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IEnumerable<ArticleIndexCategoryOutputDto> GetUserUnSelArticleCategoryListInfo(string userid)
        {
            return _repository.GetUserUnSelArticleCategoryListInfo(userid);
        }

        /// <summary>
        /// �����û��Զ������
        /// </summary>
        /// <param name="userid"></param>
        /// <param name="selstr"></param>
        /// <param name="unselstr"></param>
        /// <returns></returns>
        public bool SaveUserArticleCategoryList(string userid, string selstr, string unselstr)
        {
            return _repository.SaveUserArticleCategoryList(userid, selstr, unselstr);
        }

        /// <summary>
        /// ���ݷ���D��ȡ��������
        /// </summary>
        /// <param name="ids">����ID�ַ������á�,���ָ�</param>
        /// <returns></returns>
        public string GetCategoryNameStr(string ids)
        {
            string roleIDsStr = string.Format("'{0}'", ids.Replace(",", "','"));
            string sqlWhere = string.Format("Id in({0})", roleIDsStr);
            List<ArticleCategory> listCategories = _repository.GetListWhere(sqlWhere).ToList();
            string strEnCode = string.Empty;
            foreach (ArticleCategory item in listCategories)
            {
                strEnCode += item.Title + ",";
            }
            return strEnCode.TrimEnd(',');
        }
    }
}