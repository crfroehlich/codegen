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
    public partial class BackgroundTaskHistoryMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityBackgroundTaskHistory,BackgroundTaskHistory> _EntityToDto;
        protected IMappingExpression<BackgroundTaskHistory,DocEntityBackgroundTaskHistory> _DtoToEntity;

        public BackgroundTaskHistoryMapper()
        {
            CreateMap<DocEntitySet<DocEntityBackgroundTaskHistory>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityBackgroundTaskHistory,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityBackgroundTaskHistory>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityBackgroundTaskHistory.GetBackgroundTaskHistory(c));
            _EntityToDto = CreateMap<DocEntityBackgroundTaskHistory,BackgroundTaskHistory>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTaskHistory>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTaskHistory>(c, "Updated")))
                .ForMember(dest => dest.Completed, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTaskHistory>(c, nameof(DocEntityBackgroundTaskHistory.Completed))))
                .ForMember(dest => dest.Data, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTaskHistory>(c, nameof(DocEntityBackgroundTaskHistory.Data))))
                .ForMember(dest => dest.Ended, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTaskHistory>(c, nameof(DocEntityBackgroundTaskHistory.Ended))))
                .ForMember(dest => dest.Errors, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTaskHistory>(c, nameof(DocEntityBackgroundTaskHistory.Errors))))
                .ForMember(dest => dest.Failed, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTaskHistory>(c, nameof(DocEntityBackgroundTaskHistory.Failed))))
                .ForMember(dest => dest.Items, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTaskHistory>(c, nameof(DocEntityBackgroundTaskHistory.Items))))
                .ForMember(dest => dest.ItemsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTaskHistory>(c, nameof(DocEntityBackgroundTaskHistory.ItemsCount))))
                .ForMember(dest => dest.Logs, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTaskHistory>(c, nameof(DocEntityBackgroundTaskHistory.Logs))))
                .ForMember(dest => dest.Succeeded, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTaskHistory>(c, nameof(DocEntityBackgroundTaskHistory.Succeeded))))
                .ForMember(dest => dest.Summary, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTaskHistory>(c, nameof(DocEntityBackgroundTaskHistory.Summary))))
                .ForMember(dest => dest.Task, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTaskHistory>(c, nameof(DocEntityBackgroundTaskHistory.Task))))
                .ForMember(dest => dest.TaskId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTaskHistory>(c, nameof(DocEntityBackgroundTaskHistory.TaskId))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<BackgroundTaskHistory,DocEntityBackgroundTaskHistory>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
