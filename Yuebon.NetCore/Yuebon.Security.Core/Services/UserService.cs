using System;
using System.Data.Common;
using Yuebon.Commons.Encrypt;
using Yuebon.Commons.Repositories;
using Yuebon.Commons.Services;
using Yuebon.Security.IRepositories;
using Yuebon.Security.IServices;
using Yuebon.Security.Models;
using System.Data;
using Yuebon.Security.Dtos;
using System.Collections.Generic;

namespace Yuebon.Security.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class UserService : BaseService<User, string>, IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IUserLogOnRepository _userSigninRepository;
        private readonly ILogService _logService;
        public UserService(IUserRepository repository, IUserLogOnRepository userLogOnRepository, ILogService logService) : base(repository)
        {
            _userRepository = repository;
            _userSigninRepository = userLogOnRepository;
            _logService = logService;
            _userRepository.OnOperationLog += _logService.OnOperationLog;
        }



        /// <summary>
        /// �û���½��֤��
        /// </summary>
        /// <param name="userName">�û���</param>
        /// <param name="password">���루��һ��md5���ܺ�</param>
        /// <returns>��֤�ɹ������û�ʵ�壬��֤ʧ�ܷ���null|��ʾ��Ϣ</returns>
        public Tuple<User, string> Validate(string userName, string password)
        {
            var userEntity = _userRepository.GetByUserName(userName);

            if (userEntity == null)
            {
                return new Tuple<User, string>(null, "ϵͳ�����ڸ��û���������ȷ�ϡ�");
            }

            if (!userEntity.EnabledMark)
            {
                return new Tuple<User, string>(null, "���û��ѱ����ã�����ϵ����Ա��");
            }

            var userSinginEntity = _userSigninRepository.GetByUserId(userEntity.Id);

            string inputPassword = MD5Util.GetMD5_32(DEncrypt.Encrypt(MD5Util.GetMD5_32(password).ToLower(), userSinginEntity.UserSecretkey).ToLower()).ToLower();

            if (inputPassword != userSinginEntity.UserPassword)
            {
                return new Tuple<User, string>(null, "����������������롣");
            }
            else
            {
                return new Tuple<User, string>(userEntity, "");
            }
        }
        /// <summary>
        /// �����û��˺Ų�ѯ�û���Ϣ
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public User GetByUserName(string userName)
        {
            return _userRepository.GetByUserName(userName);
        }
        /// <summary>
        /// �����û��ֻ������ѯ�û���Ϣ
        /// </summary>
        /// <param name="mobilephone">�ֻ�����</param>
        /// <returns></returns>
        public User GetUserByMobilePhone(string mobilephone)
        {
            return _userRepository.GetUserByMobilePhone(mobilephone);
        }
        /// <summary>
        /// ע���û�
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="userLogOnEntity"></param>
        /// <param name="trans"></param>
        public bool Insert(User entity, UserLogOn userLogOnEntity, IDbTransaction trans = null)
        {
            return _userRepository.Insert(entity, userLogOnEntity, trans);
        }
        /// <summary>
        /// ע���û�,������ƽ̨
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="userLogOnEntity"></param>
        /// <param name="trans"></param>
        public bool Insert(User entity, UserLogOn userLogOnEntity, UserOpenIds userOpenIds, IDbTransaction trans = null)
        {
            return _userRepository.Insert(entity, userLogOnEntity, userOpenIds, trans);
        }

        /// <summary>
        /// ���ݵ�����OpenId��ѯ�û���Ϣ
        /// </summary>
        /// <param name="openIdType">����������</param>
        /// <param name="openId">OpenIdֵ</param>
        /// <returns></returns>
        public User GetUserByOpenId(string openIdType, string openId)
        {
            return _userRepository.GetUserByOpenId(openIdType, openId);
        }
        /// <summary>
        /// ����userId��ѯ�û���Ϣ
        /// </summary>
        /// <param name="openIdType">����������</param>
        /// <param name="userId">userId</param>
        /// <returns></returns>
        public UserOpenIds GetUserOpenIdByuserId(string openIdType, string userId)
        {
            return _userRepository.GetUserOpenIdByuserId(openIdType, userId);
        }
        /// <summary>
        /// �����û���Ϣ,������ƽ̨
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="userLogOnEntity"></param>
        /// <param name="trans"></param>
        public bool UpdateUserByOpenId(User entity, UserLogOn userLogOnEntity, UserOpenIds userOpenIds, IDbTransaction trans = null)
        {
            return _userRepository.UpdateUserByOpenId(entity, userLogOnEntity, userOpenIds, trans);
        }

        /// <summary>
        /// ����΢��UnionId��ѯ�û���Ϣ
        /// </summary>
        /// <param name="unionId">UnionIdֵ</param>
        /// <returns></returns>
        public User GetUserByUnionId(string unionId)
        {
            return _userRepository.GetUserByUnionId(unionId);
        }
        /// <summary>
        /// �����û�ID�õ���Ƭ��Ϣ
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public UserNameCardOutPutDto GetUserNameCardInfo(string userid)
        {
            return _userRepository.GetUserNameCardInfo(userid);
        }

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
        public bool SaveNameCard(string userid, string headicon, string nickName, string name, string company, string position,
            string weburl, string mobile, string email, string wx, string wximg,
            string industry, string area, string address, int openflag)
        {
            return _userRepository.SaveNameCard(userid, headicon, nickName, name, company, position, weburl,
                mobile, email, wx, wximg, industry, area, address, openflag);
        }


        /// <summary>
        /// ��ҳ�õ������û����ڹ�ע
        /// </summary>
        /// <param name="currentpage"></param>
        /// <param name="pagesize"></param>
        /// <param name="userid"></param>
        /// <returns></returns>
        public IEnumerable<UserAllListFocusOutPutDto> GetUserAllListFocusByPage(string currentpage,
            string pagesize, string userid)
        {
            return _userRepository.GetUserAllListFocusByPage(currentpage, pagesize, userid);
        }
    }
}