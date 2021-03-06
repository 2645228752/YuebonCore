using System;
using Yuebon.Commons.IDbContext;
using Yuebon.Commons.Repositories;
using Yuebon.Security.IRepositories;
using Yuebon.Security.Models;

namespace Yuebon.Security.Repositories
{
    /// <summary>
    /// 单据编码仓储接口的实现
    /// </summary>
    public class SequenceRepository : BaseRepository<Sequence, string>, ISequenceRepository
    {
		public SequenceRepository()
        {
        }

        public SequenceRepository(IDbContextCore dbContext) : base(dbContext)
        {
        }
    }
}