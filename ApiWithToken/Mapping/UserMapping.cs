﻿using AutoMapper;
using UdemyApiWithToken.Domain;
using UdemyApiWithToken.Resources;

namespace UdemyApiWithToken.Mapping
{
    public class UserMapping : Profile
    {
        public UserMapping()
        {
            CreateMap<UserResource, User>();
            CreateMap<User, UserResource>();
        }
    }
}