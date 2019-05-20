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
    public partial class EventMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityEvent,Event> _EntityToDto;
        protected IMappingExpression<Event,DocEntityEvent> _DtoToEntity;

        public EventMapper()
        {
            CreateMap<DocEntitySet<DocEntityEvent>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityEvent,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityEvent>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityEvent.Get(c));
            _EntityToDto = CreateMap<DocEntityEvent,Event>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Event>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Event>(c, "Updated")))
                .ForMember(dest => dest.AuditRecord, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Event>(c, nameof(DocEntityEvent.AuditRecord))))
                .ForMember(dest => dest.AuditRecordId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Event>(c, nameof(DocEntityEvent.AuditRecordId))))
                .ForMember(dest => dest.Description, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Event>(c, nameof(DocEntityEvent.Description))))
                .ForMember(dest => dest.Processed, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Event>(c, nameof(DocEntityEvent.Processed))))
                .ForMember(dest => dest.Status, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Event>(c, nameof(DocEntityEvent.Status))))
                .ForMember(dest => dest.Teams, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Event>(c, nameof(DocEntityEvent.Teams))))
                .ForMember(dest => dest.TeamsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Event>(c, nameof(DocEntityEvent.TeamsCount))))
                .ForMember(dest => dest.Updates, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Event>(c, nameof(DocEntityEvent.Updates))))
                .ForMember(dest => dest.UpdatesCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Event>(c, nameof(DocEntityEvent.UpdatesCount))))
                .ForMember(dest => dest.Users, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Event>(c, nameof(DocEntityEvent.Users))))
                .ForMember(dest => dest.UsersCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Event>(c, nameof(DocEntityEvent.UsersCount))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<Event,DocEntityEvent>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
