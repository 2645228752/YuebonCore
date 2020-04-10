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
    [AutoMap(typeof(DbBackup))]
    [Serializable]
    public class DbBackupInputDto: IInputDto<string>
    {
        /// <summary>
        /// 设置或获取 
        /// </summary>
        public string Id { get; set; }

        /// 设置或获取 
        /// </summary>
        public string BackupType { get; set; }

        /// 设置或获取 
        /// </summary>
        public string DbName { get; set; }

        /// 设置或获取 
        /// </summary>
        public string FileName { get; set; }

        /// 设置或获取 
        /// </summary>
        public string FileSize { get; set; }

        /// 设置或获取 
        /// </summary>
        public string FilePath { get; set; }

        /// 设置或获取 
        /// </summary>
        public DateTime? BackupTime { get; set; }

        /// 设置或获取 
        /// </summary>
        public int? SortCode { get; set; }

        /// 设置或获取 
        /// </summary>
        public bool? EnabledMark { get; set; }

        /// 设置或获取 
        /// </summary>
        public string Description { get; set; }

    }
}