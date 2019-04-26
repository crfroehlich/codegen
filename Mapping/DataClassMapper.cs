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
    public partial class DataClassMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityDataClass,DataClass> _EntityToDto;
        protected IMappingExpression<DataClass,DocEntityDataClass> _DtoToEntity;

        public DataClassMapper()
        {
            CreateMap<DocEntitySet<DocEntityDataClass>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityDataClass,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityDataClass>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityDataClass.GetDataClass(c));
            _EntityToDto = CreateMap<DocEntityDataClass,DataClass>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataClass>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataClass>(c, "Updated")))
                .ForMember(dest => dest.AllowDelete, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataClass>(c, nameof(DocEntityDataClass.AllowDelete))))
                .ForMember(dest => dest.AllVisibleFieldsByDefault, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataClass>(c, nameof(DocEntityDataClass.AllVisibleFieldsByDefault))))
                .ForMember(dest => dest.CacheDuration, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataClass>(c, nameof(DocEntityDataClass.CacheDuration))))
                .ForMember(dest => dest.ClassId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataClass>(c, nameof(DocEntityDataClass.ClassId))))
                .ForMember(dest => dest.CustomCollections, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataClass>(c, nameof(DocEntityDataClass.CustomCollections))))
                .ForMember(dest => dest.CustomCollectionsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataClass>(c, nameof(DocEntityDataClass.CustomCollectionsCount))))
                .ForMember(dest => dest.DELETE, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataClass>(c, nameof(DocEntityDataClass.DELETE))))
                .ForMember(dest => dest.Description, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataClass>(c, nameof(DocEntityDataClass.Description))))
                .ForMember(dest => dest.DontFlattenProperties, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataClass>(c, nameof(DocEntityDataClass.DontFlattenProperties))))
                .ForMember(dest => dest.DontFlattenPropertiesCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataClass>(c, nameof(DocEntityDataClass.DontFlattenPropertiesCount))))
                .ForMember(dest => dest.DtoSuffix, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataClass>(c, nameof(DocEntityDataClass.DtoSuffix))))
                .ForMember(dest => dest.FlattenReferences, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataClass>(c, nameof(DocEntityDataClass.FlattenReferences))))
                .ForMember(dest => dest.GET, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataClass>(c, nameof(DocEntityDataClass.GET))))
                .ForMember(dest => dest.IgnoreProps, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataClass>(c, nameof(DocEntityDataClass.IgnoreProps))))
                .ForMember(dest => dest.IgnorePropsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataClass>(c, nameof(DocEntityDataClass.IgnorePropsCount))))
                .ForMember(dest => dest.IsInsertOnly, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataClass>(c, nameof(DocEntityDataClass.IsInsertOnly))))
                .ForMember(dest => dest.IsReadOnly, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataClass>(c, nameof(DocEntityDataClass.IsReadOnly))))
                .ForMember(dest => dest.Name, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataClass>(c, nameof(DocEntityDataClass.Name))))
                .ForMember(dest => dest.PATCH, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataClass>(c, nameof(DocEntityDataClass.PATCH))))
                .ForMember(dest => dest.POST, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataClass>(c, nameof(DocEntityDataClass.POST))))
                .ForMember(dest => dest.Properties, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataClass>(c, nameof(DocEntityDataClass.Properties))))
                .ForMember(dest => dest.PropertiesCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataClass>(c, nameof(DocEntityDataClass.PropertiesCount))))
                .ForMember(dest => dest.PUT, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataClass>(c, nameof(DocEntityDataClass.PUT))))
                .ForMember(dest => dest.Tabs, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataClass>(c, nameof(DocEntityDataClass.Tabs))))
                .ForMember(dest => dest.TabsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataClass>(c, nameof(DocEntityDataClass.TabsCount))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<DataClass,DocEntityDataClass>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
