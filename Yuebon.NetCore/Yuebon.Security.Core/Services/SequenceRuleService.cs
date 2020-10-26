using System;
using Yuebon.Commons.Services;
using Yuebon.Security.IServices;
using Yuebon.Security.IRepositories;
using Yuebon.Security.IServices;
using Yuebon.Security.Dtos;
using Yuebon.Security.Models;
using System.Threading.Tasks;
using Yuebon.Commons.Pages;
using Yuebon.Commons.Dtos;
using System.Collections.Generic;
using Yuebon.Commons.Mapping;

namespace Yuebon.Security.Services
{
    /// <summary>
    /// 序号编码规则表服务接口实现
    /// </summary>
    public class SequenceRuleService: BaseService<SequenceRule,SequenceRuleOutputDto, string>, ISequenceRuleService
    {
		private readonly ISequenceRuleRepository _repository;
        private readonly ILogService _logService;
        public SequenceRuleService(ISequenceRuleRepository repository,ILogService logService) : base(repository)
        {
			_repository=repository;
			_logService=logService;
            _repository.OnOperationLog += _logService.OnOperationLog;
        }


        /// <summary>
        /// 根据条件查询数据库,并返回对象集合(用于分页数据显示)
        /// </summary>
        /// <param name="search">查询的条件</param>
        /// <returns>指定对象的集合</returns>
        public override async Task<PageResult<SequenceRuleOutputDto>> FindWithPagerAsync(SearchInputDto<SequenceRule> search)
        {
            bool order = search.Order == "asc" ? false : true;
            string where = GetDataPrivilege(false);
            if (!string.IsNullOrEmpty(search.Keywords))
            {
                where += string.Format(" and SequenceName like '%{0}%' ", search.Keywords);
            };
            PagerInfo pagerInfo = new PagerInfo
            {
                CurrenetPageIndex = search.CurrenetPageIndex,
                PageSize = search.PageSize
            };
            List<SequenceRule> list = await repository.FindWithPagerAsync(where, pagerInfo, search.Sort, order);
            PageResult<SequenceRuleOutputDto> pageResult = new PageResult<SequenceRuleOutputDto>
            {
                CurrentPage = pagerInfo.CurrenetPageIndex,
                Items = list.MapTo<SequenceRuleOutputDto>(),
                ItemsPerPage = pagerInfo.PageSize,
                TotalItems = pagerInfo.RecordCount
            };
            return pageResult;
        }
    }
}