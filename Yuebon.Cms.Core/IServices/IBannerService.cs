using System;
using Yuebon.Commons.IServices;
using Yuebon.CMS.Models;
using System.Collections.Generic;
using Yuebon.CMS.Dtos;

namespace Yuebon.CMS.IServices
{
    public interface IBannerService : IService<Banner, BannerOutputDto,string>
    {
        /// <summary>
        /// ���ݹ��λ�����ȡ�ù��λ�Ĺ������
        /// </summary>
        /// <param name="enCode">���λΨһ����</param>
        /// <returns></returns>
        IEnumerable<Banner> GetListByAdEnCode(string enCode);
    }
}