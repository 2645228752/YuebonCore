using Dapper;
using System;
using System.Data;

using Yuebon.Commons.Options;
using Yuebon.Commons.Repositories;
using Yuebon.Security.IRepositories;
using Yuebon.Security.Models;

namespace Yuebon.Security.Repositories
{
    public class UserLogOnRepository : BaseRepository<UserLogOn, string>, IUserLogOnRepository
    {
        public UserLogOnRepository()
        {
            this.tableName = "Sys_UserLogOn";
            this.primaryKey = "Id";
        }



        /// <summary>
        /// ���ݻ�ԱID��ȡ�û���¼��Ϣʵ��
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public UserLogOn GetByUserId(string userId)
        {
            using (IDbConnection conn = OpenSharedConnection())
            {
                string sql = @"SELECT * FROM Sys_UserLogOn t WHERE t.UserId = @UserId";
                return conn.QueryFirst<UserLogOn>(sql, new { UserId = userId });
            }
        }
    }
}