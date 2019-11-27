using System;
using Yuebon.Commons.IRepositories;
using Yuebon.CMS.Models;
using System.Collections.Generic;
using Yuebon.CMS.Dtos;

namespace Yuebon.CMS.IRepositories
{
    public interface IArticleNewsRepository : IRepository<ArticleNews,string>
    {
        /// <summary>
        /// �õ������б�
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ArticleNewsOutputDto GetArticleNewsListInfo(string id);
        /// <summary>
        /// ��ȡ��ͬ��ʶ���б��¼����ҳ��
        /// </summary>
        /// <param name="currentpage"></param>
        /// <param name="pagesize"></param>
        /// <param name="flag"></param>
        /// <param name="userid"></param>
        /// <returns></returns>
        IEnumerable<ArticleNewsOutputDto> GetArticleListByPageWithFlag(string currentpage,
    string pagesize, int flag, string userid);
    }
}