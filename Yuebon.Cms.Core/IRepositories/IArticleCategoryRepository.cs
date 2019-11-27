using System;
using Yuebon.Commons.IRepositories;
using Yuebon.CMS.Models;
using System.Collections.Generic;
using Yuebon.CMS.Dtos;

namespace Yuebon.CMS.IRepositories
{
    public interface IArticleCategoryRepository : IRepository<ArticleCategory,string>
    {
        /// <summary>
        /// �õ������б�
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        IEnumerable<ArticleSimpleCategoryOutputDto> GetArticleCategoryListInfo(string id);


        /// <summary>
        /// �õ������б�(������ҳ)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        IEnumerable<ArticleIndexCategoryOutputDto> GetArticleIndexCategoryListInfo(string id);

        /// <summary>
        /// �õ������б�(������ҳ)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        IEnumerable<ArticleIndexCategoryOutputDto> GetUserArticleCategoryListInfo(string userid);


        /// <summary>
        /// �õ������б�(������ҳ)����
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        IEnumerable<ArticleIndexCategoryOutputDto> GetUserArticleCategoryListInfoNew(string userid);

        /// <summary>
        /// �õ�δѡ��ķ����б�(������ҳ):��
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        IEnumerable<ArticleIndexCategoryOutputDto> GetUserUnSelArticleCategoryListInfoNew(string userid);

        /// <summary>
        /// �õ�δѡ��ķ����б�(������ҳ)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        IEnumerable<ArticleIndexCategoryOutputDto> GetUserUnSelArticleCategoryListInfo(string userid);

        /// <summary>
        /// �����û��Զ������
        /// </summary>
        /// <param name="userid"></param>
        /// <param name="selstr"></param>
        /// <param name="unselstr"></param>
        /// <returns></returns>
        bool SaveUserArticleCategoryList(string userid, string selstr, string unselstr);

    }
}