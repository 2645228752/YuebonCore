using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using Yuebon.Commons.Options;
using Yuebon.Commons.Repositories;
using Yuebon.Security.IRepositories;
using Yuebon.Security.Models;

namespace Yuebon.Security.Repositories
{
    public class FunctionRepository : BaseRepository<Function, string>, IFunctionRepository
    {
        public FunctionRepository()
        {
            this.tableName = "Sys_Function";
            this.primaryKey = "Id";
        }
        /// <summary>
        /// ���ݽ�ɫID�ַ��������ŷֿ�)��ϵͳ����ID����ȡ��Ӧ�Ĳ��������б�
        /// </summary>
        /// <param name="roleIDs">��ɫID</param>
        /// <param name="typeID">ϵͳ����ID</param>
        /// <returns></returns>
        public IEnumerable<Function> GetFunctions(string roleIds, string typeID)
        {
            string sql = $"SELECT * FROM Sys_Function INNER JOIN Sys_RoleAuthorize On Sys_Function.Id = Sys_RoleAuthorize.ItemId WHERE ObjectId IN ("+roleIds+")";
            if (typeID.Length > 0)
            {
                sql = sql + string.Format(" AND SystemTypeId='{0}' ", typeID);
            }
            using (IDbConnection conn = OpenSharedConnection())
            {
                return conn.Query<Function>(sql);
            }
        }
    }
}