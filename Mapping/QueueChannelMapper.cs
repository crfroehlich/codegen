
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
    public partial class QueueChannelMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityQueueChannel,QueueChannel> _EntityToDto;
        protected IMappingExpression<QueueChannel,DocEntityQueueChannel> _DtoToEntity;

        public QueueChannelMapper()
        {
            CreateMap<DocEntitySet<DocEntityQueueChannel>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityQueueChannel,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityQueueChannel>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityQueueChannel.Get(c));
            _EntityToDto = CreateMap<DocEntityQueueChannel,QueueChannel>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<QueueChannel>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<QueueChannel>(c, "Updated")))
                .ForMember(dest => dest.AutoDelete, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<QueueChannel>(c, nameof(DocEntityQueueChannel.AutoDelete))))
                .ForMember(dest => dest.BackgroundTask, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<QueueChannel>(c, nameof(DocEntityQueueChannel.BackgroundTask))))
                .ForMember(dest => dest.BackgroundTaskId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<QueueChannel>(c, nameof(DocEntityQueueChannel.BackgroundTaskId))))
                .ForMember(dest => dest.Description, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<QueueChannel>(c, nameof(DocEntityQueueChannel.Description))))
                .ForMember(dest => dest.Durable, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<QueueChannel>(c, nameof(DocEntityQueueChannel.Durable))))
                .ForMember(dest => dest.Enabled, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<QueueChannel>(c, nameof(DocEntityQueueChannel.Enabled))))
                .ForMember(dest => dest.Exclusive, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<QueueChannel>(c, nameof(DocEntityQueueChannel.Exclusive))))
                .ForMember(dest => dest.Name, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<QueueChannel>(c, nameof(DocEntityQueueChannel.Name))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<QueueChannel,DocEntityQueueChannel>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
