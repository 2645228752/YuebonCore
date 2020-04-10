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
    public class UserLogOnOutputDto
    {
        /// <summary>
        /// 设置或获取 
        /// </summary>
        [MaxLength(50)]
        public string Id { get; set; }

        /// 设置或获取 
        /// </summary>
        [MaxLength(50)]
        public string UserId { get; set; }

        /// 设置或获取 
        /// </summary>
        [MaxLength(50)]
        public string UserPassword { get; set; }

        /// 设置或获取 
        /// </summary>
        [MaxLength(50)]
        public string UserSecretkey { get; set; }

        /// 设置或获取 
        /// </summary>
        public DateTime? AllowStartTime { get; set; }

        /// 设置或获取 
        /// </summary>
        public DateTime? AllowEndTime { get; set; }

        /// 设置或获取 
        /// </summary>
        public DateTime? LockStartDate { get; set; }

        /// 设置或获取 
        /// </summary>
        public DateTime? LockEndDate { get; set; }

        /// 设置或获取 
        /// </summary>
        public DateTime? FirstVisitTime { get; set; }

        /// 设置或获取 
        /// </summary>
        public DateTime? PreviousVisitTime { get; set; }

        /// 设置或获取 
        /// </summary>
        public DateTime? LastVisitTime { get; set; }

        /// 设置或获取 
        /// </summary>
        public DateTime? ChangePasswordDate { get; set; }

        /// 设置或获取 
        /// </summary>
        public bool? MultiUserLogin { get; set; }

        /// 设置或获取 
        /// </summary>
        public int? LogOnCount { get; set; }

        /// 设置或获取 
        /// </summary>
        public bool? UserOnLine { get; set; }

        /// 设置或获取 
        /// </summary>
        [MaxLength(50)]
        public string Question { get; set; }

        /// 设置或获取 
        /// </summary>
        [MaxLength(500)]
        public string AnswerQuestion { get; set; }

        /// 设置或获取 
        /// </summary>
        public bool? CheckIPAddress { get; set; }

        /// 设置或获取 
        /// </summary>
        [MaxLength(50)]
        public string Language { get; set; }

        /// 设置或获取 
        /// </summary>
        [MaxLength(50)]
        public string Theme { get; set; }

    }
}