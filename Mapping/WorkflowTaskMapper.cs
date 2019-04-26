//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated by a T4 template. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using AutoMapper;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Dynamic;
using System.Linq.Expressions;
using System.Net;
using System.Reflection;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using Services.Core;
using Services.Db;
using Services.Dto;
using Services.Dto.internals;
using Services.Dto.Security;
using Services.Enums;
using Services.Models;
using Services.Schema;

using ServiceStack;
using ServiceStack.Text;

using Typed;
using Typed.Bindings;
using Typed.Notifications;
using Typed.Settings;

using Xtensive.Orm;
using Xtensive.Orm.Model;

using Attribute = Services.Dto.Attribute;
using ValueType = Services.Dto.ValueType;
using Version = Services.Dto.Version;
namespace Services.Schema
{
    public partial class WorkflowTaskMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityWorkflowTask,WorkflowTask> _EntityToDto;
        protected IMappingExpression<WorkflowTask,DocEntityWorkflowTask> _DtoToEntity;

        public WorkflowTaskMapper()
        {
            CreateMap<DocEntitySet<DocEntityWorkflowTask>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityWorkflowTask,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityWorkflowTask>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityWorkflowTask.GetWorkflowTask(c));
            _EntityToDto = CreateMap<DocEntityWorkflowTask,WorkflowTask>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<WorkflowTask>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<WorkflowTask>(c, "Updated")))
                .ForMember(dest => dest.Assignee, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<WorkflowTask>(c, nameof(DocEntityWorkflowTask.Assignee))))
                .ForMember(dest => dest.AssigneeId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<WorkflowTask>(c, nameof(DocEntityWorkflowTask.AssigneeId))))
                .ForMember(dest => dest.Data, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<WorkflowTask>(c, nameof(DocEntityWorkflowTask.Data))))
                .ForMember(dest => dest.Description, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<WorkflowTask>(c, nameof(DocEntityWorkflowTask.Description))))
                .ForMember(dest => dest.DueDate, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<WorkflowTask>(c, nameof(DocEntityWorkflowTask.DueDate))))
                .ForMember(dest => dest.Reporter, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<WorkflowTask>(c, nameof(DocEntityWorkflowTask.Reporter))))
                .ForMember(dest => dest.ReporterId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<WorkflowTask>(c, nameof(DocEntityWorkflowTask.ReporterId))))
                .ForMember(dest => dest.Status, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<WorkflowTask>(c, nameof(DocEntityWorkflowTask.Status))))
                .ForMember(dest => dest.StatusId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<WorkflowTask>(c, nameof(DocEntityWorkflowTask.StatusId))))
                .ForMember(dest => dest.Type, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<WorkflowTask>(c, nameof(DocEntityWorkflowTask.Type))))
                .ForMember(dest => dest.TypeId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<WorkflowTask>(c, nameof(DocEntityWorkflowTask.TypeId))))
                .ForMember(dest => dest.Workflow, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<WorkflowTask>(c, nameof(DocEntityWorkflowTask.Workflow))))
                .ForMember(dest => dest.WorkflowId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<WorkflowTask>(c, nameof(DocEntityWorkflowTask.WorkflowId))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<WorkflowTask,DocEntityWorkflowTask>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
