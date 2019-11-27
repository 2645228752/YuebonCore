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
        /// 根据角色ID字符串（逗号分开)和系统类型ID，获取对应的操作功能列表
        /// </summary>
        /// <param name="roleIDs">角色ID</param>
        /// <param name="typeID">系统类型ID</param>
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