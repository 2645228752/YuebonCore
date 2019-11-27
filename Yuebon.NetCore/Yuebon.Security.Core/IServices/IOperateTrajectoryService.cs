using System;
using System.Collections.Generic;
using Yuebon.Commons.IServices;
using Yuebon.Security.Dtos;
using Yuebon.Security.Models;

namespace Yuebon.Security.IServices
{
    /// <summary>
    /// 
    /// </summary>
    public interface IOperateTrajectoryService : IService<OperateTrajectory, string>
    {
        /// <summary>
        /// ��ҳ�õ��б�
        /// </summary>
        /// <param name="currentpage"></param>
        /// <param name="pagesize"></param>
        /// <param name="filter"></param>
        /// <param name="userid"></param>
        /// <param name="authorid"></param>
        /// <returns></returns>
        IEnumerable<OperateTrajectoryOutputDto> GetTrajectoryListByPage(string filter, string currentpage,
            string pagesize, string userid, string authorid);
        /// <summary>
        /// �õ�����
        /// </summary>
        /// <param name="userid"></param>
        /// <param name="authorid"></param>
        /// <returns></returns>
        OperateTrajectorySumInfoTypeOutputDto GetSum(string userid, string authorid);
    }
}
