using Dapper;
using Dapper.Contrib.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Yuebon.Commons.EfDbContext;
using Yuebon.Commons.Helpers;
using Yuebon.Commons.Log;
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
        }

        public LogRepository(BaseDbContext dbContext) : base(dbContext)
        {
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
        /// �������ܣ�����ɾ��
        /// </summary>
        /// <param name="len"></param>
        /// <returns></returns>
        public async Task<long> InsertTset(int len)
        {
            int n = 0;
            List<Log> logList = new List<Log>();
            while (n < len)
            {
                Log logEntity = new Log()
                {
                    Id = GuidUtils.GuId(),
                    Date = DateTime.Now,
                    Account = "admin",
                    NickName = "��������Ա",
                    OrganizeId = "2020101619392209546893",
                    Type = "SQL",
                    IPAddress = "171.110.40.191",
                    IPAddressName = "�й�����׳��������������",
                    ModuleName = "Log",
                    Result = true,
                    Description = "SQL���:update Sys_Role set EnabledMark=1 ,LastModifyUserId='2020100517554098226223',LastModifyTime=@LastModifyTime where id in ('2019091721053342871332')",
                    DeleteMark=false,
                    EnabledMark=true,
                    CreatorTime = DateTime.Now,
                    CreatorUserId= "9f2ec079-7d0f-4fe2-90ab-8b09a8302aba"
                };
                logList.Add(logEntity);
                n++;
            }

            //string sql = "insert into Sys_Log ([Date], [Account], [NickName], [OrganizeId], [Type], [IPAddress], [IPAddressName], [ModuleId], [ModuleName], [Result], [Description], [DeleteMark], [EnabledMark], [CreatorTime], [CreatorUserId], [LastModifyTime], [LastModifyUserId], [DeleteTime], [DeleteUserId], [Id]) values (@Date, @Account, @NickName, @OrganizeId, @Type, @IPAddress, @IPAddressName, @ModuleId, @ModuleName, @Result, @Description, @DeleteMark, @EnabledMark, @CreatorTime, @CreatorUserId, @LastModifyTime, @LastModifyUserId, @DeleteTime, @DeleteUserId, @Id)";

            var sb = new StringBuilder(n+" �����ݲ��� �� \n");
            Stopwatch stopwatch = new Stopwatch();
            using (IDbConnection conn = OpenSharedConnection())
            {
                stopwatch.Start();
                await conn.InsertAsync(logList);
                stopwatch.Stop();
                sb.Append("Dapper InsertAsync��ʱ:" + (stopwatch.ElapsedMilliseconds + "  ����\n"));
                //using (var transaction = conn.BeginTransaction())
                //{
                //    stopwatch.Start();
                //    await conn.InsertAsync(logList, transaction);
                //    transaction.Commit();
                //    stopwatch.Stop();
                //    sb.Append("Dapper InsertAsync �����ύ��ʱ:" + (stopwatch.ElapsedMilliseconds + "  ����\n"));
                //}

                //stopwatch.Start();
                //await conn.ExecuteAsync(sql, logList);
                //stopwatch.Stop();
                //sb.Append("Dapper ExecuteAsync��ʱ:" + (stopwatch.ElapsedMilliseconds + "  ����\n"));
            }
            //var param = new List<Tuple<string, object>>();
            //Tuple<string, object> tupel = new Tuple<string, object>(sql, logList);
            //param.Add(tupel);
            //stopwatch.Start();
            //await ExecuteTransactionAsync(param);
            //stopwatch.Stop();
            //sb.Append("Dapper ExecuteTransactionAsync��ʱ:" + (stopwatch.ElapsedMilliseconds + "  ����\n"));

            //stopwatch.Start();
            //_dbContext.Set<Log>().AddRange(logList);
            //Save();
            //stopwatch.Stop();
            //sb.Append("Ef Core AddRange��ʱ:" + (stopwatch.ElapsedMilliseconds + "  ����\n"));
            //stopwatch.Start();
            //_dbContext.Set<Log>().FromSqlRaw(sql,logList);
            //Save();
            //stopwatch.Stop();
            //sb.Append("Ef Core FromSqlRaw��ʱ:" + (stopwatch.ElapsedMilliseconds + "  ����\n"));
            Log4NetHelper.Info(sb.ToString());

            return 100;
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