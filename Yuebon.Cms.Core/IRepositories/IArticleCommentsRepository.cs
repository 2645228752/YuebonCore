using System;
using Yuebon.Commons.IRepositories;
using Yuebon.CMS.Models;
using System.Collections.Generic;
using Yuebon.CMS.Dtos;
using Yuebon.Commons.Pages;
using System.Data;

namespace Yuebon.CMS.IRepositories
{
    public interface IArticleCommentsRepository : IRepository<ArticleComments,string>
    {
        /// <summary>
        /// �õ������б�
        /// </summary>
        /// <param name="articleid">�ĵ����</param>
        /// <param name="userId">�����û����</param>
        /// <returns></returns>
       IEnumerable<ArticleCommentsOntputDto> GetArticleCommentsListInfo(string articleid, string userId);

        /// <summary>
        /// ��ҳ��ѯ�����û���Ϣ
        /// ��ѯ�������Ϊt1,�û������Ϊt2���ڲ�ѯ�ֶ���Ҫע��ʹ��t1.xxx��ʽ��xx��ʾ�����ֶ�
        /// �û���Ϣ��Ҫ���û��˺ţ�Account���ǳƣ�NickName����ʵ������RealName��ͷ��HeadIcon���ֻ��ţ�MobilePhone
        /// �����������Dtos�н������з�װ��������ʹ��ʵ��Model��
        /// </summary>
        /// <param name="condition">��ѯ�����ֶ���Ҫ�ӱ����</param>
        /// <param name="info">��ҳ��Ϣ</param>
        /// <param name="fieldToSort">�����ֶΣ�Ҳ��Ҫ�ӱ����</param>
        /// <param name="desc">����ʽ</param>
        /// <param name="trans">����</param>
        /// <returns></returns>
        List<ArticleCommentsOntputDto> FindWithPagerRelationUserNoCheck(string condition, PagerInfo info, string fieldToSort, bool desc, IDbTransaction trans = null);
    }


}