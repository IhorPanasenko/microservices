﻿using AutoMapper;
using PlatformServices.Dtos;
using PlatformServices.Models;

namespace PlatformServices.Profiles
{
    public class PlatformProfile:Profile
    {
        public PlatformProfile()
        {
            // Source --> Target
            CreateMap<Platform, PlatformReadDto>();
            CreateMap<PlatformCreateDto, Platform>();
        }

    }
}
