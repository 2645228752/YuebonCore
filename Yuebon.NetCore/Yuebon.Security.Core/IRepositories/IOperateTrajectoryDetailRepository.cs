using System;
using System.Collections.Generic;
using Yuebon.Commons.IRepositories;
using Yuebon.Security.Dtos;
using Yuebon.Security.Models;

namespace Yuebon.Security.IRepositories
{
   /// <summary>
   /// 
   /// </summary>
    public interface IOperateTrajectoryDetailRepository : IRepository<OperateTrajectoryDetail,string>
    {
        /// <summary>
        /// ��ҳ�õ��б�
        /// </summary>
        /// <param name="currentpage"></param>
        /// <param name="pagesize"></param>
        /// <param name="filter"></param>
        /// <param name="userid"></param>
        /// <returns></returns>
        IEnumerable<OperateTrajectoryDetailOutputDto> GetTrajectoryListByPage(string filter,string currentpage,
            string pagesize, string userid);
        /// <summary>
        /// �õ�����Ϣ��
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        int GetTotalCounts(string userid);
        /// <summary>
        /// �õ�ɸѡ������
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="userid"></param>
        /// <returns></returns>
        int GetTotalCountsByFilter(string filter, string userid);

        /// <summary>
        /// ���û�����ͳ��δ���͵ķ��ʹ켣����
        /// </summary>
        /// <param name="userId">�û����</param>
        /// <returns></returns>
       List<OperateTrajectoryDetailTotalNoIsSendOutput> GetTotalNoIsSendList(string userId);


        /// <summary>
        /// �����ݷ����߷����ѯδ���͵���Ϣ������켣
        /// </summary>
        /// <returns></returns>
        List<OperateTrajectoryDetailAuthorUserId> GetNoIsSendListGroupByAuthorUserId();
        /// <summary>
        /// �������ݷ����߸��·���״̬
        /// </summary>
        /// <param name="AuthorUserId"></param>
        /// <returns></returns>
        bool UpdateIsSendByAuthorUserId(string AuthorUserId);
    }
}