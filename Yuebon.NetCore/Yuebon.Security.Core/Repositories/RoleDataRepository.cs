using Dapper;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using Yuebon.Commons.IDbContext;
using Yuebon.Commons.Repositories;
using Yuebon.Security.IRepositories;
using Yuebon.Security.Models;

namespace Yuebon.Security.Repositories
{
    public class RoleDataRepository : BaseRepository<RoleData, string>, IRoleDataRepository
    {
		public RoleDataRepository()
        {
        }

        public RoleDataRepository(IDbContextCore dbContext) : base(dbContext)
        {
        }

        /// <summary>
        /// 根据角色返回授权访问部门数据
        /// </summary>
        /// <param name="roleIds"></param>
        /// <returns></returns>
        public List<string> GetListDeptByRole(string roleIds)
        {
            string roleIDsStr = string.Format("'{0}'", roleIds.Replace(",", "','"));
            string where = " RoleId in(" + roleIDsStr + ") and DType='dept'";
            string sql = $"select AuthorizeData from { tableName} ";
            if (!string.IsNullOrWhiteSpace(where))
            {
                sql += " where " + where;
            }
            using (DbConnection conn = OpenSharedConnection())
            {
                IEnumerable<String> resultList= conn.Query<String>(sql);
                return resultList.ToList();
            }
        }

    }
}