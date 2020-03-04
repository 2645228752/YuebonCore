﻿using Senparc.Weixin.Entities;
using Yuebon.Commons.Helpers;
using Yuebon.Commons.IoC;
using Yuebon.Commons.Json;
using Yuebon.Commons.Models;
using Yuebon.Messages.IServices;
using Yuebon.Messages.Models;
using Yuebon.Messages.Services;
using Yuebon.Security.Application;
using Yuebon.Security.Models;
using Yuebon.WeChat.CommonService.SubscribeMessage.WxApplet;

namespace Yuebon.Messages.Application
{
    public static class Messenger
    {
        static IMessageTemplatesService messageTemplatesService = IoCContainer.Resolve<MessageTemplatesService>();
        static IMemberMessageBoxService memberMessageBoxService = IoCContainer.Resolve<MemberMessageBoxService>();
        static IMemberSubscribeMsgService memberSubscribeMsgService = IoCContainer.Resolve<IMemberSubscribeMsgService>();

        /// <summary>
        /// 留言提醒
        /// </summary>
        /// <param name="userId">接收者（用户）的 userId</param>
        /// <param name="text">留言内容,20个以内字符</param>
        /// <param name="date">留言时间,4小时制时间格式（支持+年月日）	例如：15:01，或：2019年10月1日 15:01</param>
        /// <param name="page">点击模板卡片后的跳转页面，仅限本小程序内的页面。支持带参数,（示例index?foo=bar）。该字段不填则模板无跳转。</param>
        public static CommonResult SendCommentNotice(string userId, string text,string date,string page="")
        {
            CommonResult result = new CommonResult();
            User user = new UserApp().GetUserById(userId);
            if (user != null && !string.IsNullOrEmpty(text))
            {
                MessageTemplates template = messageTemplatesService.GetByMessageType("CommentNotice");
                if (!string.IsNullOrEmpty(template.InnerMessageSubject) && !string.IsNullOrEmpty(template.InnerMessageBody) && template.SendInnerMessage)
                {
                    MemberMessageBox memberMessageBox = new MemberMessageBox();
                    memberMessageBox.Id = GuidUtils.CreateNo();
                    memberMessageBox.IsRead = false;
                    memberMessageBox.Sernder = "系统消息";
                    memberMessageBox.Accepter = userId;
                    memberMessageBox.MsgContent = string.Format(template.InnerMessageBody, text, date);
                    memberMessageBoxService.Insert(memberMessageBox);
                }
                if (!string.IsNullOrEmpty(template.WxAppletSubscribeTemplateId) && template.UseInWxApplet)
                {
                    MemberSubscribeMsg memberSubscribeMsg=new MemberSubscribeMsgApp().GetByMessageTemplateIdAndUser(template.Id,userId, "WxApplet");
                    if(memberSubscribeMsg.SubscribeStatus == "accept") { 
                        UserOpenIds userOpenIds = new UserApp().GetUserOpenIdById(userId, "yuebon.openid.wxapplet");
                        if (userOpenIds != null )
                        {
                            WxJsonResult wxJsonResult = WxAppletSubscribeMessage.SendCommentNotice(userOpenIds.OpenId, template.WxAppletSubscribeTemplateId, text, date, page);
                            result.ErrCode = wxJsonResult.errcode.ToString();
                            result.ErrMsg = wxJsonResult.errmsg;
                        }
                    }
                    else
                    {
                        result.Success = true;
                        result.ErrCode = "用户拒绝订阅";
                    }
                }
                else
                {
                    result.Success = true;
                    result.ErrCode = "用户未订阅";
                }

            }
            return result;
        }
        /// <summary>
        /// 新的评论提醒
        /// </summary>
        /// <param name="userId">接收者（用户）的 userId</param>
        /// <param name="title">文章标题,20个以内字符</param>
        /// <param name="desc">评论内容,20个以内字符</param>
        /// <param name="date">评论时间，4小时制时间格式（支持+年月日）	例如：15:01，或：2019年10月1日 15:01</param>
        /// <param name="remarkUserId">评论者（用户）的 userId</param>
        /// <param name="page"></param>
        public static CommonResult SendRemarkNotice(string userId, string title, string desc, string date,string remarkUserId, string page)
        {
            CommonResult result = new CommonResult();
            UserApp userApp = new UserApp();
            User user = userApp.GetUserById(userId);
            User remarkUser = userApp.GetUserById(remarkUserId);

            if (user != null && !string.IsNullOrEmpty(title))
            {
                MessageTemplates template = messageTemplatesService.GetByMessageType("RemarkNotice");
                if (!string.IsNullOrEmpty(template.InnerMessageSubject) && !string.IsNullOrEmpty(template.InnerMessageBody) && template.SendInnerMessage)
                {
                    MemberMessageBox memberMessageBox = new MemberMessageBox();
                    memberMessageBox.Id = GuidUtils.CreateNo();
                    memberMessageBox.IsRead = false;
                    memberMessageBox.Sernder = "系统消息";
                    memberMessageBox.Accepter = userId;
                    memberMessageBox.MsgContent = string.Format(template.InnerMessageBody, user.NickName,date, title);
                    memberMessageBoxService.Insert(memberMessageBox);
                }
                if (!string.IsNullOrEmpty(template.WxAppletSubscribeTemplateId) && template.UseInWxApplet )
                {
                    MemberSubscribeMsg memberSubscribeMsg = new MemberSubscribeMsgApp().GetByMessageTemplateIdAndUser(template.Id, userId, "WxApplet");
                    if (memberSubscribeMsg.SubscribeStatus == "accept")
                    {
                        UserOpenIds userOpenIds = new UserApp().GetUserOpenIdById(userId, "yuebon.openid.wxapplet");
                        if (userOpenIds != null)
                        {
                            WxJsonResult wxJsonResult = WxAppletSubscribeMessage.SendRemarkNotice(userOpenIds.OpenId, template.WxAppletSubscribeTemplateId, title, desc, date, remarkUser.NickName, page);
                            result.ErrCode = wxJsonResult.errcode.ToString();
                            result.ErrMsg = wxJsonResult.errmsg;
                        }
                    }
                }
                else
                {
                    result.Success = true;
                    result.ErrCode = "用户拒绝或未订阅";
                }
            }
            return result;
        }

        /// <summary>
        /// 动态点赞通知
        /// </summary>
        /// <param name="userId">接收者（用户）的 userId</param>
        /// <param name="date">点赞时间,4小时制时间格式（支持+年月日）	例如：15:01，或：2019年10月1日 15:01</param>
        /// <param name="page"></param>
        public static CommonResult SendGoodNotice(string userId, string date, string page)
        {
            CommonResult result = new CommonResult();
            User user = new UserApp().GetUserById(userId);
            if (user != null && !string.IsNullOrEmpty(date))
            {
                MessageTemplates template = messageTemplatesService.GetByMessageType("RemarkNotice");

                if (!string.IsNullOrEmpty(template.WxAppletSubscribeTemplateId) && template.UseInWxApplet)
                {
                    MemberSubscribeMsg memberSubscribeMsg = new MemberSubscribeMsgApp().GetByMessageTemplateIdAndUser(template.Id, userId, "WxApplet");
                    if (memberSubscribeMsg.SubscribeStatus == "accept")
                    {
                        UserOpenIds userOpenIds = new UserApp().GetUserOpenIdById(userId, "yuebon.openid.wxapplet");
                        if (userOpenIds != null)
                        {
                            WxJsonResult wxJsonResult = WxAppletSubscribeMessage.SendGoodNotice(userOpenIds.OpenId, template.WxAppletTemplateId, user.NickName, date, page);
                            result.ErrCode = wxJsonResult.errcode.ToString();
                            result.ErrMsg = wxJsonResult.errmsg;
                        }
                    }
                }
                else
                {
                    result.Success = true;
                    result.ErrCode = "用户拒绝或未订阅";
                }
            }
            return result;
        }
        /// <summary>
        /// 资讯早报提醒
        /// </summary>
        /// <param name="userId">接收者（用户）的 userId</param>
        /// <param name="title">更新内容,20个以内字符</param>
        /// <param name="remark">备注,20个以内字符</param>
        /// <param name="page"></param>
        /// <returns></returns>
        public static CommonResult SendNewsMorningNotice(string userId, string title, string remark, string page = "")
        {
            CommonResult result = new CommonResult();
            User user = new UserApp().GetUserById(userId);
            if (user != null && !string.IsNullOrEmpty(title))
            {
                MessageTemplates template = messageTemplatesService.GetByMessageType("NewsMorningNotice");
                if (!string.IsNullOrEmpty(template.InnerMessageSubject) && !string.IsNullOrEmpty(template.InnerMessageBody) && template.SendInnerMessage)
                {
                    MemberMessageBox memberMessageBox = new MemberMessageBox();
                    memberMessageBox.Id = GuidUtils.CreateNo();
                    memberMessageBox.IsRead = false;
                    memberMessageBox.Sernder = "资讯早报";
                    memberMessageBox.Accepter = userId;
                    memberMessageBox.MsgContent = string.Format(template.InnerMessageBody, title, remark);
                    memberMessageBoxService.Insert(memberMessageBox);
                }

                if (!string.IsNullOrEmpty(template.WxAppletSubscribeTemplateId) && template.UseInWxApplet)
                {
                    MemberSubscribeMsg memberSubscribeMsg = new MemberSubscribeMsgApp().GetByMessageTemplateIdAndUser(template.Id, userId, "WxApplet");
                    if (memberSubscribeMsg!=null)
                    {
                        if (memberSubscribeMsg.SubscribeStatus == "accept")
                        {
                            UserOpenIds userOpenIds = new UserApp().GetUserOpenIdById(userId, "yuebon.openid.wxapplet");
                            if (userOpenIds != null)
                            {
                                WxJsonResult wxJsonResult = WxAppletSubscribeMessage.SendNewsMorningNotice(userOpenIds.OpenId, template.WxAppletSubscribeTemplateId, title, remark, page);
                                if (wxJsonResult.errcode.ToString() == "请求成功" || wxJsonResult.errcode.ToString() == "用户拒绝接受消息")
                                {
                                    result.ErrCode = "0";
                                    result.ErrMsg = wxJsonResult.errcode.ToString();
                                }
                                else
                                {
                                    result.ErrCode = "0";
                                    result.ErrMsg = wxJsonResult.errcode.ToString() + wxJsonResult.ToJson();
                                }
                            }
                        }
                        else
                        {
                            result.ErrCode = "0";
                            result.ErrMsg = "用户拒绝";
                        }
                    }
                    else
                    {
                        result.ErrCode = "0";
                        result.ErrMsg = "用户未订阅";
                    }
                }
                else
                {
                    result.ErrCode = "0";
                    result.ErrMsg = "用户拒绝";
                }

            }
            return result;
        }
    }
}