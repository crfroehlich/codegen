
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
    public partial class TaskMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityTask,Task> _EntityToDto;
        protected IMappingExpression<Task,DocEntityTask> _DtoToEntity;

        public TaskMapper()
        {
            CreateMap<DocEntitySet<DocEntityTask>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityTask,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityTask>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityTask.Get(c));
            _EntityToDto = CreateMap<DocEntityTask,Task>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Task>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Task>(c, "Updated")))
                .ForMember(dest => dest.Assignee, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Task>(c, nameof(DocEntityTask.Assignee))))
                .ForMember(dest => dest.AssigneeId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Task>(c, nameof(DocEntityTask.AssigneeId))))
                .ForMember(dest => dest.Data, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Task>(c, nameof(DocEntityTask.Data))))
                .ForMember(dest => dest.Description, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Task>(c, nameof(DocEntityTask.Description))))
                .ForMember(dest => dest.DueDate, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Task>(c, nameof(DocEntityTask.DueDate))))
                .ForMember(dest => dest.Reporter, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Task>(c, nameof(DocEntityTask.Reporter))))
                .ForMember(dest => dest.ReporterId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Task>(c, nameof(DocEntityTask.ReporterId))))
                .ForMember(dest => dest.Type, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Task>(c, nameof(DocEntityTask.Type))))
                .ForMember(dest => dest.Workflow, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Task>(c, nameof(DocEntityTask.Workflow))))
                .ForMember(dest => dest.WorkflowId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Task>(c, nameof(DocEntityTask.WorkflowId))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<Task,DocEntityTask>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
