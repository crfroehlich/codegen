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
    public partial class OutcomeMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityOutcome,Outcome> _EntityToDto;
        protected IMappingExpression<Outcome,DocEntityOutcome> _DtoToEntity;

        public OutcomeMapper()
        {
            CreateMap<DocEntitySet<DocEntityOutcome>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityOutcome,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityOutcome>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityOutcome.GetOutcome(c));
            _EntityToDto = CreateMap<DocEntityOutcome,Outcome>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Outcome>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Outcome>(c, "Updated")))
                .ForMember(dest => dest.DocumentSets, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Outcome>(c, nameof(DocEntityOutcome.DocumentSets))))
                .ForMember(dest => dest.DocumentSetsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Outcome>(c, nameof(DocEntityOutcome.DocumentSetsCount))))
                .ForMember(dest => dest.Name, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Outcome>(c, nameof(DocEntityOutcome.Name))))
                .ForMember(dest => dest.URI, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Outcome>(c, nameof(DocEntityOutcome.URI))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<Outcome,DocEntityOutcome>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
