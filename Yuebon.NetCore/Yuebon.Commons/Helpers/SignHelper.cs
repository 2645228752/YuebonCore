﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Yuebon.Commons.Cache;
using Yuebon.Commons.Encrypt;
using Yuebon.Commons.Extensions;
using Yuebon.Commons.Json;
using Yuebon.Commons.Models;

namespace Yuebon.Commons.Helpers
{
    /// <summary>
    /// 签名验证自定义类
    /// </summary>
    public class SignHelper
    {
        /// <summary>
        /// 全局过滤器验证签名
        /// </summary>
        /// <param name="httpContext"></param>
        /// <returns></returns>
        public static CommonResult CheckSign(HttpContext httpContext)
        {
            CommonResult result = new CommonResult();
            //从http请求的头里面获取参数
            var request = httpContext.Request;
            var method = request.Method;
            var appId = ""; //客户端应用唯一标识
            string nonce = "";//随机字符串
            var signature = ""; //参数签名，去除空参数,按字母倒序排序进行Md5签名 为了提高传参过程中，防止参数被恶意修改，在请求接口的时候加上sign可以有效防止参数被篡改
            long timeStamp; //时间戳， 校验5分钟内有效
            try
            {
                appId = request.Headers["appId"].SingleOrDefault();
                nonce = request.Headers["nonce"].SingleOrDefault();
                timeStamp = Convert.ToInt64(request.Headers["timeStamp"].SingleOrDefault());
                signature = request.Headers["signature"].SingleOrDefault();
            }
            catch (Exception ex)
            {
                result.ErrCode = "40004";
                result.ErrMsg = "签名参数异常:" + ex.Message;
                return result;
            }

            //appId是否为可用的
            if (!VerifyAppId(appId))
            {
                result.ErrCode = "40004";
                result.ErrMsg = "AppId不被允许访问:" + appId;
                return result;
            }

            //判断timespan是否有效，请求是否超时
            DateTime tonow= timeStamp.UnixTimeToDateTime();
            var expires_minute = tonow.Minute - DateTime.Now.Minute;
            if (expires_minute > 5 || expires_minute < -5)
            {
                result.ErrCode = "40004";
                result.ErrMsg = "接口请求超时";
                return result;
            }

            //根据请求类型拼接参数
            NameValueCollection form = HttpUtility.ParseQueryString(request.QueryString.ToString());

            var data = string.Empty;
            switch (method)
            {
                case "POST":
                    request.EnableBuffering();
                    Stream stream =request.Body;
                    StreamReader streamReader = new StreamReader(stream);
                    data = streamReader.ReadToEnd();
                    request.Body.Position = 0;
                    break;
                case "GET":
                    data = GetQueryString(form);
                    break;
            }
            bool blValidate = Validate(timeStamp.ToString(), nonce, appId, data, signature);
            if (!blValidate)
            {
                result.ErrCode = "40004";
                result.ErrMsg = "无效签名";
                return result;
            }
            else
            {
                result.ErrCode = "0";
                result.Success = true;
                return result;
            }
        }
        /// <summary>
        /// 查询参数， url上直接接参数时,通过此方法获取
        /// </summary>
        /// <param name="form"></param>
        /// <returns></returns>
        public static string GetQueryString(NameValueCollection form)
        {
            //第一步：取出所有get参数
            Dictionary<string, string> parames = new Dictionary<string, string>();
            for (int f = 0; f < form.Count; f++)
            {
                var key = form.Keys[f];
                if(key!=null)
                parames.Add(key, form[key]);
            }
            // 第二步：把字典按Key的字母顺序排序
            IDictionary<string, string> sortedParams = new SortedDictionary<string, string>(parames);
            IEnumerator<KeyValuePair<string, string>> dem = sortedParams.GetEnumerator();

            // 第三步：把所有参数名和参数值串在一起
            StringBuilder query = new StringBuilder("");  //签名字符串
            StringBuilder queryStr = new StringBuilder(""); //url参数
            if (parames == null || parames.Count == 0)
                return query.ToString();
            while (dem.MoveNext())
            {
                string key = dem.Current.Key;
                string value = dem.Current.Value;
                if (!string.IsNullOrEmpty(key))
                {
                    query.Append(key).Append(value);
                    queryStr.Append("&").Append(key).Append("=").Append(value);
                }
            }
            return query.ToString();
        }
        /// <summary>
        /// 签名验证
        /// </summary>
        /// <param name="timeStamp">时间戳</param>
        /// <param name="nonce">随机数</param>
        /// <param name="appId">客户端应用唯一标识</param>
        /// <param name="data">接口参数内容</param>
        /// <param name="signature">当前请求内容的数字签名</param>
        /// <returns></returns>
        public static bool Validate(string timeStamp,string nonce,string appId,string data,string signature)
        {
            var signStr = timeStamp + nonce  +  data + appId;
            string signMd5 = MD5Util.GetMD5_32(signStr);
            return signMd5 == signature;
        }


        /// <summary>
        /// 验证appId是否被允许
        /// </summary>
        /// <param name="appId"></param>
        /// <returns></returns>
        private static bool VerifyAppId(string appId)
        {
            if (string.IsNullOrEmpty(appId)) return false;
            YuebonCacheHelper yuebonCacheHelper = new YuebonCacheHelper();
            return yuebonCacheHelper.Get("AllowAppId").ToJson().Contains(appId);
        }
    }
}