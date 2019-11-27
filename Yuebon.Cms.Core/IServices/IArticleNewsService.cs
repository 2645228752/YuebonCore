using System;
using Yuebon.Commons.IServices;
using Yuebon.CMS.Models;
using System.Collections.Generic;
using Yuebon.CMS.Dtos;

namespace Yuebon.CMS.IServices
{
    public interface IArticleNewsService : IService<ArticleNews,string>
    {
        /// <summary>
        /// �õ������б�idΪ�������ȫ��
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