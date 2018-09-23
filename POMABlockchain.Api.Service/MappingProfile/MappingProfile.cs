using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace POMABlockchain.Api.Service
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Model.Block, Modules.RPC.DTOs.Block>();
            CreateMap<Modules.RPC.DTOs.Block, Model.Block>();
        }
    }
}
