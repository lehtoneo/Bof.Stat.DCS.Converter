﻿using AutoMapper;
using Bof.Stat.DCS.Converter.Model.CSV;
using Bof.Stat.DCS.Converter.Model.XML.SAVE;

namespace Bof.Stat.DCS.Converter.Model.Mappings
{
    public class SAVEAutoMapping : AutoMappingBase
    {
        protected override void GetMappings(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<Header, HeaderType>()
                .ForAllMembers(opts => opts.Condition(GetNotNullOrEmptyCondition<Header, HeaderType>()));

            cfg.CreateMap<SAVE_SBS, SbsType>()
                .ForAllMembers(opts => opts.Condition(GetNotNullOrEmptyCondition<SAVE_SBS, SbsType>()));
        }
    }
}
