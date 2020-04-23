using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Threading.Tasks;
using Yuebon.Commons.IServices;
using Yuebon.Security.Dtos;
using Yuebon.Security.Models;

namespace Yuebon.Security.IServices
{
    /// <summary>
    /// �û�����ӿ�
    /// </summary>
    public interface IUserService:IService<User, UserOutputDto, string>
    {
        /// <summary>
        /// �û���½��֤��
        /// </summary>
        /// <param name="userName">�û���</param>
        /// <param name="password">���루��һ��md5���ܺ�</param>
        /// <returns>��֤�ɹ������û�ʵ�壬��֤ʧ�ܷ���null|��ʾ��Ϣ</returns>
        Tuple<User,string> Validate(string userName, string password);

        /// <summary>
        /// �����û��˺Ų�ѯ�û���Ϣ
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        User GetByUserName(string userName);
        /// <summary>
        /// �����û��ֻ������ѯ�û���Ϣ
        /// </summary>
        /// <param name="mobilePhone">�ֻ�����</param>
        /// <returns></returns>
        User GetUserByMobilePhone(string mobilePhone);


        /// <summary>
        /// ע���û�
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="userLogOnEntity"></param>
        /// <param name="trans"></param>
        bool Insert(User entity, UserLogOn userLogOnEntity, IDbTransaction trans = null);
        /// <summary>
        /// ע���û�
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="userLogOnEntity"></param>
        /// <param name="trans"></param>
        Task<bool> InsertAsync(User entity, UserLogOn userLogOnEntity, IDbTransaction trans = null);
        /// <summary>
        /// ע���û�,������ƽ̨
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="userLogOnEntity"></param>
        /// <param name="userOpenIds"></param>
        /// <param name="trans"></param>
        bool Insert(User entity, UserLogOn userLogOnEntity, UserOpenIds userOpenIds,IDbTransaction trans = null);
        /// <summary>
        /// ���ݵ�����OpenId��ѯ�û���Ϣ
        /// </summary>
        /// <param name="openIdType">����������</param>
        /// <param name="openId">OpenIdֵ</param>
        /// <returns></returns>
        User GetUserByOpenId(string openIdType, string openId);

        /// <summary>
        /// ����΢��UnionId��ѯ�û���Ϣ
        /// </summary>
        /// <param name="unionId">UnionIdֵ</param>
        /// <returns></returns>
        User GetUserByUnionId(string unionId);
        /// <summary>
        /// ����userId��ѯ�û���Ϣ
        /// </summary>
        /// <param name="openIdType">����������</param>
        /// <param name="userId">userId</param>
        /// <returns></returns>
        UserOpenIds GetUserOpenIdByuserId(string openIdType, string userId);
        /// <summary>
        /// �����û���Ϣ,������ƽ̨
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="userLogOnEntity"></param>
        /// <param name="trans"></param>
        bool UpdateUserByOpenId(User entity, UserLogOn userLogOnEntity, UserOpenIds userOpenIds, IDbTransaction trans = null);

        /// <summary>
        /// �����û�ID�õ���Ƭ��Ϣ
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        //UserNameCardOutPutDto GetUserNameCardInfo(string userid);

        /// <summary>
        /// ������Ƭ
        /// </summary>
        /// <param name="userid"></param>
        /// <param name="headicon"></param>
        /// <param name="nickName"></param>
        /// <param name="name"></param>
        /// <param name="company"></param>
        /// <param name="position"></param>
        /// <param name="weburl"></param>
        /// <param name="mobile"></param>
        /// <param name="email"></param>
        /// <param name="wx"></param>
        /// <param name="wximg"></param>
        /// <param name="industry"></param>
        /// <param name="area"></param>
        /// <param name="address"></param>
        /// <param name="openflag"></param>
        /// <returns></returns>
        //bool SaveNameCard(string userid, string headicon, string nickName, string name, string company, string position,
        //    string weburl, string mobile, string email, string wx, string wximg,
        //    string industry, string area, string address, int openflag);


        /// <summary>
        /// �����û���Ϣ���ڹ�ע
        /// </summary>
        /// <param name="currentpage"></param>
        /// <param name="pagesize"></param>
        /// <param name="userid"></param>
        /// <returns></returns>
        IEnumerable<UserAllListFocusOutPutDto> GetUserAllListFocusByPage(string currentpage,
            string pagesize, string userid);


        /// <summary>
        /// ΢��ע����ͨ��Ա�û�
        /// </summary>
        /// <param name="userInPut">����������</param>
        /// <returns></returns>
       bool CreateUserByWxOpenId(UserInputDto userInPut);
        /// <summary>
        /// �����û�
        /// </summary>
        /// <param name="userInPut"></param>
        /// <returns></returns>
        bool UpdateUserByOpenId(UserInputDto userInPut);
    }
}
