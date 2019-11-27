using System;
using Yuebon.Commons.Repositories;
using Yuebon.CMS.IRepositories;
using Yuebon.CMS.Models;
using System.Collections.Generic;
using Yuebon.CMS.Dtos;
using System.Data;
using Dapper;
using System.Linq;
using System.Reflection;
using System.Data.Common;
using System.Text;
using Yuebon.Commons.Pages;

namespace Yuebon.CMS.Repositories
{
    public class ArticleCommentsRepository : BaseRepository<ArticleComments, string>, IArticleCommentsRepository
    {
		public ArticleCommentsRepository()
        {
            this.tableName = "CMS_ArticleComments";
            this.primaryKey = "Id";
        }

        /// <summary>
        /// �õ������б�
        /// </summary>
        /// <param name="articleid">�ĵ����</param>
        /// <param name="userId">�����û����</param>
        /// <returns></returns>
        public IEnumerable<ArticleCommentsOntputDto> GetArticleCommentsListInfo(string articleid,string userId)
        {
            string strWhere = "";
            if (!String.IsNullOrEmpty(articleid))
            {
                strWhere = " and t1.ArticleNewsId='" + articleid + "' ";
            }

            using (IDbConnection conn = OpenSharedConnection())
            {
                string sql = @"select t1.*,t2.NickName as RealName,t2.HeadIcon as UserIcon,
case when t3.Id is null then 'n' else 'y' end as ifGood  
from CMS_ArticleComments t1 left join 
sys_user t2 on t1.CreatorUserId=t2.Id  
left join CMS_ArticleCommentsGood t3 on t1.id = t3.CommentsId  and t3.CreatorUserId='" + userId + "' where t1.EnabledMark=1 ";

                if (strWhere != "")
                {
                    sql = sql + strWhere;
                }

                sql += " order by t1.CreatorTime asc ";

                IEnumerable<ArticleCommentsOntputDto> commentsOutputDto = conn.Query<ArticleCommentsOntputDto>(sql);

                //***********��״***************

                List<ArticleCommentsOntputDto> chapterlist = commentsOutputDto.ToList();
                var dic = new Dictionary<string, ArticleCommentsOntputDto>(chapterlist.Count);
                foreach (ArticleCommentsOntputDto chapter in chapterlist)
                {
                    dic.Add(chapter.Id, chapter);
                }
                foreach (ArticleCommentsOntputDto chapter in dic.Values)
                {
                    if (dic.ContainsKey(chapter.ParentID))
                    {
                        if (dic[chapter.ParentID] == null)
                            dic[chapter.ParentID].Children = new List<ArticleCommentsOntputDto>();

                        if (dic[chapter.ParentID].Children == null)
                            dic[chapter.ParentID].Children = new List<ArticleCommentsOntputDto>();

                        dic[chapter.ParentID].Children.Add(chapter);
                    }
                }
                return dic.Values.Where(t => t.ParentID == "0").ToList().AsEnumerable();

                //******************************
            }
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
            var type = MethodBase.GetCurrentMethod().DeclaringType;
            
            if (string.IsNullOrEmpty(condition))
            {
                condition = "1=1";
            }
            using (DbConnection conn = OpenSharedConnection())
            {
                StringBuilder sb = new StringBuilder();
                int startRows = (info.CurrenetPageIndex - 1) * info.PageSize + 1;//��ʼ��¼
                int endNum = info.CurrenetPageIndex * info.PageSize;//������¼
                string strOrder = string.Format(" {0} {1}", fieldToSort, desc ? "DESC" : "ASC");
                sb.AppendFormat("SELECT count(*) as RecordCount FROM (select t1.{0} FROM {1} t1 inner join Sys_User t2 on t1.CreatorUserId = t2.Id where {2})  AS main_temp;", primaryKey, tableName, condition);
                sb.AppendFormat("SELECT * FROM (SELECT ROW_NUMBER() OVER (order by  {0}) AS rows ,t1.{1},t2.Account as Account,t2.NickName as NickName,t2.RealName as RealName,t2.HeadIcon as HeadIcon ,t2.MobilePhone as MobilePhone  FROM {2} t1 inner join Sys_User t2 on t1.CreatorUserId = t2.Id " +
                    "where {3}) AS main_temp where rows BETWEEN {4} and {5}", strOrder, selectedFields, tableName, condition, startRows, endNum);

                var reader = conn.QueryMultiple(sb.ToString());
                info.RecordCount = reader.ReadFirst<int>();
                List<ArticleCommentsOntputDto> list = reader.Read<ArticleCommentsOntputDto>().AsList();
                return list;
            }
        }


    }
}