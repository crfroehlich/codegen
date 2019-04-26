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
    public partial class HelpMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityHelp,Help> _EntityToDto;
        protected IMappingExpression<Help,DocEntityHelp> _DtoToEntity;

        public HelpMapper()
        {
            CreateMap<DocEntitySet<DocEntityHelp>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityHelp,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityHelp>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityHelp.GetHelp(c));
            _EntityToDto = CreateMap<DocEntityHelp,Help>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Help>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Help>(c, "Updated")))
                .ForMember(dest => dest.ConfluenceId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Help>(c, nameof(DocEntityHelp.ConfluenceId))))
                .ForMember(dest => dest.Description, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Help>(c, nameof(DocEntityHelp.Description))))
                .ForMember(dest => dest.Icon, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Help>(c, nameof(DocEntityHelp.Icon))))
                .ForMember(dest => dest.Order, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Help>(c, nameof(DocEntityHelp.Order))))
                .ForMember(dest => dest.Pages, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Help>(c, nameof(DocEntityHelp.Pages))))
                .ForMember(dest => dest.PagesCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Help>(c, nameof(DocEntityHelp.PagesCount))))
                .ForMember(dest => dest.Scopes, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Help>(c, nameof(DocEntityHelp.Scopes))))
                .ForMember(dest => dest.ScopesCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Help>(c, nameof(DocEntityHelp.ScopesCount))))
                .ForMember(dest => dest.Title, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Help>(c, nameof(DocEntityHelp.Title))))
                .ForMember(dest => dest.Type, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Help>(c, nameof(DocEntityHelp.Type))))
                .ForMember(dest => dest.TypeId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Help>(c, nameof(DocEntityHelp.TypeId))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<Help,DocEntityHelp>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
