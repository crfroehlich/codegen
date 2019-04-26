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
    public partial class FeatureSetMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityFeatureSet,FeatureSet> _EntityToDto;
        protected IMappingExpression<FeatureSet,DocEntityFeatureSet> _DtoToEntity;

        public FeatureSetMapper()
        {
            CreateMap<DocEntitySet<DocEntityFeatureSet>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityFeatureSet,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityFeatureSet>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityFeatureSet.Get(c));
            _EntityToDto = CreateMap<DocEntityFeatureSet,FeatureSet>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<FeatureSet>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<FeatureSet>(c, "Updated")))
                .ForMember(dest => dest.Description, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<FeatureSet>(c, nameof(DocEntityFeatureSet.Description))))
                .ForMember(dest => dest.Name, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<FeatureSet>(c, nameof(DocEntityFeatureSet.Name))))
                .ForMember(dest => dest.PermissionTemplate, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<FeatureSet>(c, nameof(DocEntityFeatureSet.PermissionTemplate))))
                .ForMember(dest => dest.Roles, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<FeatureSet>(c, nameof(DocEntityFeatureSet.Roles))))
                .ForMember(dest => dest.RolesCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<FeatureSet>(c, nameof(DocEntityFeatureSet.RolesCount))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<FeatureSet,DocEntityFeatureSet>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}