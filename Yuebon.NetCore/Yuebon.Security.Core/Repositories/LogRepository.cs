using Dapper;
using Dapper.Contrib.Extensions;
using System;
using System.Data;
using System.Data.Common;
using Yuebon.Commons.Options;
using Yuebon.Commons.Repositories;
using Yuebon.Security.IRepositories;
using Yuebon.Security.Models;

namespace Yuebon.Security.Repositories
{
    /// <summary>
    /// ��־�ִ�ʵ��
    /// </summary>
    public class LogRepository : BaseRepository<Log, string>, ILogRepository
    {
        /// <summary>
        /// 
        /// </summary>
        public LogRepository()
        {
            this.tableName = "Sys_Log";
            this.primaryKey = "Id";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="trans"></param>
        /// <returns></returns>
        public override long Insert(Log entity, IDbTransaction trans = null)
        {
            using (IDbConnection conn = OpenSharedConnection())
            {
                return conn.Insert(entity, trans);
            }
        }

        /// <summary>
        /// ����ɾ����Ϣ
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public override bool Delete(string id, IDbTransaction trans = null)
        {
            using (IDbConnection conn = OpenSharedConnection())
            {
                int row = conn.Execute($"delete from {tableName} where Id=@id", new { @id = id }, trans);
                return row > 0 ? true : false;
            }
        }
    }
}