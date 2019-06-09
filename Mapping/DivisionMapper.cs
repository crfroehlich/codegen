
//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated by a T4 template. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System.Collections.Generic;

using AutoMapper;

using Services.Core;
using Services.Dto;
namespace Services.Schema
{
    public partial class DivisionMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityDivision,Division> _EntityToDto;
        protected IMappingExpression<Division,DocEntityDivision> _DtoToEntity;

        public DivisionMapper()
        {
            CreateMap<DocEntitySet<DocEntityDivision>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityDivision,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityDivision>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityDivision.Get(c));
            _EntityToDto = CreateMap<DocEntityDivision,Division>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Division>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Division>(c, "Updated")))
                .ForMember(dest => dest.Client, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Division>(c, nameof(DocEntityDivision.Client))))
                .ForMember(dest => dest.ClientId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Division>(c, nameof(DocEntityDivision.ClientId))))
                .ForMember(dest => dest.DefaultLocale, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Division>(c, nameof(DocEntityDivision.DefaultLocale))))
                .ForMember(dest => dest.DefaultLocaleId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Division>(c, nameof(DocEntityDivision.DefaultLocaleId))))
                .ForMember(dest => dest.DocumentSets, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Division>(c, nameof(DocEntityDivision.DocumentSets))))
                .ForMember(dest => dest.DocumentSetsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Division>(c, nameof(DocEntityDivision.DocumentSetsCount))))
                .ForMember(dest => dest.DocumentSetsIds, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Division>(c, nameof(DocEntityDivision.DocumentSetsIds))))
                .ForMember(dest => dest.Name, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Division>(c, nameof(DocEntityDivision.Name))))
                .ForMember(dest => dest.Role, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Division>(c, nameof(DocEntityDivision.Role))))
                .ForMember(dest => dest.RoleId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Division>(c, nameof(DocEntityDivision.RoleId))))
                .ForMember(dest => dest.Settings, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Division>(c, nameof(DocEntityDivision.Settings))))
                .ForMember(dest => dest.Users, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Division>(c, nameof(DocEntityDivision.Users))))
                .ForMember(dest => dest.UsersCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Division>(c, nameof(DocEntityDivision.UsersCount))))
                .ForMember(dest => dest.UsersIds, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Division>(c, nameof(DocEntityDivision.UsersIds))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<Division,DocEntityDivision>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
