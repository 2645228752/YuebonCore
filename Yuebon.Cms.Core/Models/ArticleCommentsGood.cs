﻿using Dapper.Contrib.Extensions;
using System;
using System.Runtime.Serialization;
using Yuebon.Commons.Models;

namespace Yuebon.CMS.Models
{
    /// <summary>
    /// 文章评论点赞表
    /// </summary>
    [DataContract]
    [Table("CMS_ArticleCommentsGood")]
    [Serializable]
    public class ArticleCommentsGood : BaseEntity<string>, ICreationAudited
    { 
        /// <summary>
        /// 默认构造函数（需要初始化属性的在此处理）
        /// </summary>
	    public ArticleCommentsGood()
		{
            this.Id = System.Guid.NewGuid().ToString();
        }

        #region Property Members

        /// <summary>
        /// 文章ID
        /// </summary>
		[DataMember]
        public virtual string CommentsId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
		[DataMember]
        public virtual DateTime? CreatorTime { get; set; }

        /// <summary>
        /// 创建用户ID
        /// </summary>
		[DataMember]
        public virtual string CreatorUserId { get; set; }


        #endregion

    }
}