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
    public partial class LocaleLookupMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityLocaleLookup,LocaleLookup> _EntityToDto;
        protected IMappingExpression<LocaleLookup,DocEntityLocaleLookup> _DtoToEntity;

        public LocaleLookupMapper()
        {
            CreateMap<DocEntitySet<DocEntityLocaleLookup>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityLocaleLookup,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityLocaleLookup>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityLocaleLookup.Get(c));
            _EntityToDto = CreateMap<DocEntityLocaleLookup,LocaleLookup>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LocaleLookup>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LocaleLookup>(c, "Updated")))
                .ForMember(dest => dest.Data, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LocaleLookup>(c, nameof(DocEntityLocaleLookup.Data))))
                .ForMember(dest => dest.IpAddress, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LocaleLookup>(c, nameof(DocEntityLocaleLookup.IpAddress))))
                .ForMember(dest => dest.Locale, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LocaleLookup>(c, nameof(DocEntityLocaleLookup.Locale))))
                .ForMember(dest => dest.LocaleId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LocaleLookup>(c, nameof(DocEntityLocaleLookup.LocaleId))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<LocaleLookup,DocEntityLocaleLookup>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}