using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Yuebon.Commons.Models;
using Yuebon.Security.Models;

namespace Yuebon.Security.Dtos
{
    /// <summary>
    /// 输入对象模型
    /// </summary>
    [AutoMap(typeof(RoleAuthorize))]
    [Serializable]
    public class RoleAuthorizeInputDto: IInputDto<string>
    {
        /// <summary>
        /// 设置或获取 
        /// </summary>
        public string Id { get; set; }

        /// 设置或获取 
        /// </summary>
        public int? ItemType { get; set; }

        /// 设置或获取 
        /// </summary>
        public string ItemId { get; set; }

        /// 设置或获取 
        /// </summary>
        public int? ObjectType { get; set; }

        /// 设置或获取 
        /// </summary>
        public string ObjectId { get; set; }

        /// 设置或获取 
        /// </summary>
        public int? SortCode { get; set; }

    }
}