
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
    public partial class AuditDeltaMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityAuditDelta,AuditDelta> _EntityToDto;
        protected IMappingExpression<AuditDelta,DocEntityAuditDelta> _DtoToEntity;

        public AuditDeltaMapper()
        {
            CreateMap<DocEntitySet<DocEntityAuditDelta>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityAuditDelta,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityAuditDelta>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityAuditDelta.Get(c));
            _EntityToDto = CreateMap<DocEntityAuditDelta,AuditDelta>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<AuditDelta>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<AuditDelta>(c, "Updated")))
                .ForMember(dest => dest.Audit, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<AuditDelta>(c, nameof(DocEntityAuditDelta.Audit))))
                .ForMember(dest => dest.AuditId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<AuditDelta>(c, nameof(DocEntityAuditDelta.AuditId))))
                .ForMember(dest => dest.Delta, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<AuditDelta>(c, nameof(DocEntityAuditDelta.Delta))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<AuditDelta,DocEntityAuditDelta>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
