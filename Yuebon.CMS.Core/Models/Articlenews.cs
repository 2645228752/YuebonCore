using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using Yuebon.Commons.Models;

namespace Yuebon.CMS.Models
{
    /// <summary>
    /// 文章，通知公告，数据实体对象
    /// </summary>
    [Table("cms_articlenews")]
    [Serializable]
    public class Articlenews:BaseEntity<string>, ICreationAudited, IModificationAudited, IDeleteAudited
    {
        /// <summary>
        /// 设置或获取文章分类
        /// </summary>
        public string CategoryId { get; set; }

        /// 设置或获取分类名称
        /// </summary>
        public string CategoryName { get; set; }

        /// 设置或获取文章标题
        /// </summary>
        public string Title { get; set; }

        /// 设置或获取副标题
        /// </summary>
        public string SubTitle { get; set; }

        /// 设置或获取外链
        /// </summary>
        public string LinkUrl { get; set; }

        /// 设置或获取主图
        /// </summary>
        public string ImgUrl { get; set; }

        /// 设置或获取SEO标题
        /// </summary>
        public string SeoTitle { get; set; }

        /// 设置或获取SEO关键词
        /// </summary>
        public string SeoKeywords { get; set; }

        /// 设置或获取SEO描述
        /// </summary>
        public string SeoDescription { get; set; }

        /// 设置或获取标签，多个用逗号隔开
        /// </summary>
        public string Tags { get; set; }

        /// 设置或获取摘要
        /// </summary>
        public string Zhaiyao { get; set; }

        /// 设置或获取详情
        /// </summary>
        public string Description { get; set; }

        /// 设置或获取排序
        /// </summary>
        public int? SortCode { get; set; }

        /// 设置或获取开启评论
        /// </summary>
        public bool? IsMsg { get; set; }

        /// 设置或获取是否置顶，默认不置顶
        /// </summary>
        public bool? IsTop { get; set; }

        /// 设置或获取是否推荐
        /// </summary>
        public bool? IsRed { get; set; }

        /// 设置或获取是否热门，默认否
        /// </summary>
        public bool? IsHot { get; set; }

        /// 设置或获取是否是系统预置文章，不可删除
        /// </summary>
        public bool? IsSys { get; set; }

        /// 设置或获取是否推荐到最新
        /// </summary>
        public bool? IsNew { get; set; }

        /// 设置或获取是否推荐到幻灯
        /// </summary>
        public bool? IsSlide { get; set; }

        /// 设置或获取点击量
        /// </summary>
        public int? Click { get; set; }

        /// 设置或获取喜欢量
        /// </summary>
        public int? LikeCount { get; set; }

        /// 设置或获取浏览量
        /// </summary>
        public int? TotalBrowse { get; set; }

        /// 设置或获取来源
        /// </summary>
        public string Source { get; set; }

        /// 设置或获取作者
        /// </summary>
        public string Author { get; set; }

        /// 设置或获取是否发布
        /// </summary>
        public bool? EnabledMark { get; set; }

        /// 设置或获取逻辑删除标志
        /// </summary>
        public bool? DeleteMark { get; set; }

        /// 设置或获取创建时间
        /// </summary>
        public DateTime? CreatorTime { get; set; }

        /// 设置或获取创建人
        /// </summary>
        public string CreatorUserId { get; set; }

        /// 设置或获取所属公司
        /// </summary>
        public string CompanyId { get; set; }

        /// 设置或获取所属部门
        /// </summary>
        public string DeptId { get; set; }

        /// 设置或获取最近修改时间
        /// </summary>
        public DateTime? LastModifyTime { get; set; }

        /// 设置或获取最近修改人
        /// </summary>
        public string LastModifyUserId { get; set; }

        /// 设置或获取删除时间
        /// </summary>
        public DateTime? DeleteTime { get; set; }

        /// 设置或获取删除人
        /// </summary>
        public string DeleteUserId { get; set; }

    }
}