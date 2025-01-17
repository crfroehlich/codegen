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
    public partial class UpdateMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityUpdate,Update> _EntityToDto;
        protected IMappingExpression<Update,DocEntityUpdate> _DtoToEntity;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public UpdateMapper()
        {
            CreateMap<DocEntitySet<DocEntityUpdate>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityUpdate,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityUpdate>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityUpdate.Get(c));
            _EntityToDto = CreateMap<DocEntityUpdate,Update>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Update>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Update>(c, "Updated")))
                .ForMember(dest => dest.Body, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Update>(c, nameof(DocEntityUpdate.Body))))
                .ForMember(dest => dest.DeliveryStatus, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Update>(c, nameof(DocEntityUpdate.DeliveryStatus))))
                .ForMember(dest => dest.EmailAttempts, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Update>(c, nameof(DocEntityUpdate.EmailAttempts))))
                .ForMember(dest => dest.EmailSent, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Update>(c, nameof(DocEntityUpdate.EmailSent))))
                .ForMember(dest => dest.Events, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Update>(c, nameof(DocEntityUpdate.Events))))
                .ForMember(dest => dest.EventsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Update>(c, nameof(DocEntityUpdate.EventsCount))))
                .ForMember(dest => dest.EventsIds, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Update>(c, nameof(DocEntityUpdate.EventsIds))))
                .ForMember(dest => dest.Link, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Update>(c, nameof(DocEntityUpdate.Link))))
                .ForMember(dest => dest.Priority, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Update>(c, nameof(DocEntityUpdate.Priority))))
                .ForMember(dest => dest.Read, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Update>(c, nameof(DocEntityUpdate.Read))))
                .ForMember(dest => dest.SlackSent, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Update>(c, nameof(DocEntityUpdate.SlackSent))))
                .ForMember(dest => dest.Subject, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Update>(c, nameof(DocEntityUpdate.Subject))))
                .ForMember(dest => dest.Team, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Update>(c, nameof(DocEntityUpdate.Team))))
                .ForMember(dest => dest.TeamId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Update>(c, nameof(DocEntityUpdate.TeamId))))
                .ForMember(dest => dest.User, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Update>(c, nameof(DocEntityUpdate.User))))
                .ForMember(dest => dest.UserId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Update>(c, nameof(DocEntityUpdate.UserId))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<Update,DocEntityUpdate>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
