using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoMapperTest.Bll
{
    public class MyProfile: Profile,IProfile
    {
        public MyProfile()
        {
            CreateMap<UserInfo, UserInfoDTO>();
            CreateMap<UserInfoDTO, UserInfo>();
        }

    }
}