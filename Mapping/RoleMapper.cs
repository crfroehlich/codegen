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
    public partial class RoleMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityRole,Role> _EntityToDto;
        protected IMappingExpression<Role,DocEntityRole> _DtoToEntity;

        public RoleMapper()
        {
            CreateMap<DocEntitySet<DocEntityRole>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityRole,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityRole>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityRole.GetRole(c));
            _EntityToDto = CreateMap<DocEntityRole,Role>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Role>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Role>(c, "Updated")))
                .ForMember(dest => dest.AdminTeam, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Role>(c, nameof(DocEntityRole.AdminTeam))))
                .ForMember(dest => dest.AdminTeamId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Role>(c, nameof(DocEntityRole.AdminTeamId))))
                .ForMember(dest => dest.Apps, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Role>(c, nameof(DocEntityRole.Apps))))
                .ForMember(dest => dest.AppsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Role>(c, nameof(DocEntityRole.AppsCount))))
                .ForMember(dest => dest.Description, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Role>(c, nameof(DocEntityRole.Description))))
                .ForMember(dest => dest.Features, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Role>(c, nameof(DocEntityRole.Features))))
                .ForMember(dest => dest.FeatureSets, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Role>(c, nameof(DocEntityRole.FeatureSets))))
                .ForMember(dest => dest.FeatureSetsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Role>(c, nameof(DocEntityRole.FeatureSetsCount))))
                .ForMember(dest => dest.IsInternal, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Role>(c, nameof(DocEntityRole.IsInternal))))
                .ForMember(dest => dest.IsSuperAdmin, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Role>(c, nameof(DocEntityRole.IsSuperAdmin))))
                .ForMember(dest => dest.Name, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Role>(c, nameof(DocEntityRole.Name))))
                .ForMember(dest => dest.Pages, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Role>(c, nameof(DocEntityRole.Pages))))
                .ForMember(dest => dest.PagesCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Role>(c, nameof(DocEntityRole.PagesCount))))
                .ForMember(dest => dest.Permissions, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Role>(c, nameof(DocEntityRole.Permissions))))
                .ForMember(dest => dest.Users, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Role>(c, nameof(DocEntityRole.Users))))
                .ForMember(dest => dest.UsersCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Role>(c, nameof(DocEntityRole.UsersCount))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<Role,DocEntityRole>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
