//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated by a T4 template. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System.CodeDom.Compiler;
using System.Collections.Generic;

using AutoMapper;

using Services.Core;
using Services.Dto;
namespace Services.Schema
{
    public partial class ImpersonationMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityImpersonation,Impersonation> _EntityToDto;
        protected IMappingExpression<Impersonation,DocEntityImpersonation> _DtoToEntity;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public ImpersonationMapper()
        {
            CreateMap<DocEntitySet<DocEntityImpersonation>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityImpersonation,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityImpersonation>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityImpersonation.Get(c));
            _EntityToDto = CreateMap<DocEntityImpersonation,Impersonation>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Impersonation>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Impersonation>(c, "Updated")))
                .ForMember(dest => dest.AuthenticatedUser, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Impersonation>(c, nameof(DocEntityImpersonation.AuthenticatedUser))))
                .ForMember(dest => dest.AuthenticatedUserId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Impersonation>(c, nameof(DocEntityImpersonation.AuthenticatedUserId))))
                .ForMember(dest => dest.ImpersonatedUser, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Impersonation>(c, nameof(DocEntityImpersonation.ImpersonatedUser))))
                .ForMember(dest => dest.ImpersonatedUserId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Impersonation>(c, nameof(DocEntityImpersonation.ImpersonatedUserId))))
                .ForMember(dest => dest.UserSession, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Impersonation>(c, nameof(DocEntityImpersonation.UserSession))))
                .ForMember(dest => dest.UserSessionId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Impersonation>(c, nameof(DocEntityImpersonation.UserSessionId))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<Impersonation,DocEntityImpersonation>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
