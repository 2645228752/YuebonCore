using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Yuebon.Authorizer.Dtos
{
    /// <summary>
    /// 输出对象模型
    /// </summary>
    [Serializable]
    public class RegistryCodeOutputDto
    {
        /// <summary>
        /// 设置或获取 
        /// </summary>
        [MaxLength(50)]
        public string Id { get; set; }

        /// 设置或获取公司名称
        /// </summary>
        [MaxLength(500)]
        public string CompanyName { get; set; }

        /// 设置或获取联系人
        /// </summary>
        [MaxLength(50)]
        public string LinkMan { get; set; }

        /// 设置或获取电话
        /// </summary>
        [MaxLength(50)]
        public string TelPhone { get; set; }

        /// 设置或获取软件名称
        /// </summary>
        [MaxLength(50)]
        public string SoftName { get; set; }

        /// 设置或获取版本号
        /// </summary>
        [MaxLength(50)]
        public string Version { get; set; }

        /// 设置或获取机器码
        /// </summary>
        [MaxLength(200)]
        public string MachineCode { get; set; }

        /// 设置或获取开始日期
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// 设置或获取到期日期
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// 设置或获取注册码
        /// </summary>
        [MaxLength(600)]
        public string RegistryCode { get; set; }

        /// 设置或获取公钥
        /// </summary>
        [MaxLength(600)]
        public string PublicKey { get; set; }

        /// 设置或获取私钥
        /// </summary>
        [MaxLength(600)]
        public string PrivateKey { get; set; }

        /// 设置或获取备注
        /// </summary>
        [MaxLength(600)]
        public string Remark { get; set; }

        /// 设置或获取授权状态
        /// </summary>
        [MaxLength(20)]
        public string AuthorizeStatus { get; set; }

        /// 设置或获取是否可用
        /// </summary>
        public bool EnabledMark { get; set; }

        /// 设置或获取是否删除
        /// </summary>
        public bool DeleteMark { get; set; }

        /// 设置或获取创建时间
        /// </summary>
        public DateTime? CreatorTime { get; set; }

        /// 设置或获取创建人
        /// </summary>
        [MaxLength(50)]
        public string CreatorUserId { get; set; }

        /// 设置或获取公司
        /// </summary>
        [MaxLength(50)]
        public string CompanyId { get; set; }

        /// 设置或获取部门
        /// </summary>
        [MaxLength(50)]
        public string DeptId { get; set; }

        /// 设置或获取最后修改时间
        /// </summary>
        public DateTime? LastModifyTime { get; set; }

        /// 设置或获取最后修改人
        /// </summary>
        [MaxLength(50)]
        public string LastModifyUserId { get; set; }

        /// 设置或获取删除时间
        /// </summary>
        public DateTime? DeleteTime { get; set; }

        /// 设置或获取删除人
        /// </summary>
        [MaxLength(50)]
        public string DeleteUserId { get; set; }

    }
}