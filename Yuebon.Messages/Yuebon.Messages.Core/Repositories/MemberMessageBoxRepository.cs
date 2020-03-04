﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Data.Common;
using Yuebon.Commons.Repositories;
using Yuebon.Messages.Dtos;
using Yuebon.Messages.IRepositories;
using Yuebon.Messages.Models;

namespace Yuebon.Messages.Repositories
{
    public class MemberMessageBoxRepository : BaseRepository<MemberMessageBox, string>, IMemberMessageBoxRepository
    {
        public MemberMessageBoxRepository()
        {
            this.tableName = "Sys_MemberMessageBox";
            this.primaryKey = "Id";
        }

        /// <summary>
        /// 更新已读状态
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool UpdateIsReadStatus(string id, int isread,string userid)
        {
            string strwhere = " Accepter='"+userid+"' ";
            if (!string.IsNullOrEmpty(id))
            {
                strwhere += " and Id='" + id + "' ";
            }

            string sql = @"update Sys_MemberMessageBox set IsRead=" + isread +
                ", ReadDate='" + DateTime.Now.ToShortDateString() + "' ";
            if (strwhere != "")
            {
                sql += sql + " where " + strwhere;
            }

            using (DbConnection conn = OpenSharedConnection())
            {
                return conn.Execute(sql) > 0 ? true : false;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="isread">2:全部，0：未读，1：已读</param>
        /// <param name="userid"></param>
        /// <returns></returns>
        public int GetTotalCounts(int isread, string userid)
        {
            string strwhere = " Accepter='" + userid + "' ";
            if (isread!=2)
            {
                strwhere += " and IsRead=" + isread;
            }

            string sql = @"select * from Sys_MemberMessageBox ";
            if (strwhere != "")
            {
                sql = sql + " where " + strwhere;
            }

            using (DbConnection conn = OpenSharedConnection())
            {
                IEnumerable<MemberMessageBox> list =
                    conn.Query<MemberMessageBox>(sql);

                if(list!=null)
                {
                    return list.AsList().Count;
                }
                else
                {
                    return 0;
                }

            }
        }
    }
}
