using System;
using Yuebon.Commons.Services;
using Yuebon.CMS.IRepositories;
using Yuebon.CMS.IServices;
using Yuebon.CMS.Models;
using Yuebon.Security.IServices;
using System.Collections.Generic;
using Yuebon.CMS.Dtos;
using Yuebon.Commons.Pages;
using System.Data;

namespace Yuebon.CMS.Services
{
    public class ArticleCommentsService : BaseService<ArticleComments, string>, IArticleCommentsService
    {
		private readonly IArticleCommentsRepository _repository;
        private readonly ILogService _logService;
        public ArticleCommentsService(IArticleCommentsRepository repository,ILogService logService) : base(repository)
        {
			_repository=repository;
			_logService=logService;
            _repository.OnOperationLog += _logService.OnOperationLog;
        }

        /// <summary>
        /// �õ������б�
        /// </summary>
        /// <param name="articleid">�ĵ����</param>
        /// <param name="userId">�����û����</param>
        /// <returns></returns>
        public IEnumerable<ArticleCommentsOntputDto> GetArticleCommentsListInfo(string articleid, string userId)
        {
            return _repository.GetArticleCommentsListInfo(articleid, userId);
        }


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
        public List<ArticleCommentsOntputDto> FindWithPagerRelationUserNoCheck(string condition, PagerInfo info, string fieldToSort, bool desc, IDbTransaction trans = null)
        {
            return _repository.FindWithPagerRelationUserNoCheck(condition, info, fieldToSort, desc, trans);
        }
    }
}