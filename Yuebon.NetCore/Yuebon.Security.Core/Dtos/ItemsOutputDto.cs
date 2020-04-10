using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Yuebon.Security.Dtos
{
    /// <summary>
    /// 输出对象模型
    /// </summary>
    [Serializable]
    public class ItemsOutputDto
    {
        /// <summary>
        /// 设置或获取 
        /// </summary>
        [MaxLength(50)]
        public string Id { get; set; }

        /// 设置或获取 
        /// </summary>
        [MaxLength(50)]
        public string ParentId { get; set; }

        /// 设置或获取 
        /// </summary>
        [MaxLength(50)]
        public string EnCode { get; set; }

        /// 设置或获取 
        /// </summary>
        [MaxLength(50)]
        public string FullName { get; set; }

        /// 设置或获取 
        /// </summary>
        public bool? IsTree { get; set; }

        /// 设置或获取 
        /// </summary>
        public int? Layers { get; set; }

        /// 设置或获取 
        /// </summary>
        public int? SortCode { get; set; }

        /// 设置或获取 
        /// </summary>
        public bool? DeleteMark { get; set; }

        /// 设置或获取 
        /// </summary>
        public bool? EnabledMark { get; set; }

        /// 设置或获取 
        /// </summary>
        [MaxLength(500)]
        public string Description { get; set; }

        /// 设置或获取 
        /// </summary>
        public DateTime? CreatorTime { get; set; }

        /// 设置或获取 
        /// </summary>
        [MaxLength(50)]
        public string CreatorUserId { get; set; }

        /// 设置或获取 
        /// </summary>
        public DateTime? LastModifyTime { get; set; }

        /// 设置或获取 
        /// </summary>
        [MaxLength(50)]
        public string LastModifyUserId { get; set; }

        /// 设置或获取 
        /// </summary>
        public DateTime? DeleteTime { get; set; }

        /// 设置或获取 
        /// </summary>
        [MaxLength(50)]
        public string DeleteUserId { get; set; }

    }
}