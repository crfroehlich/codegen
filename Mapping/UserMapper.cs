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
    public partial class UserMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityUser,User> _EntityToDto;
        protected IMappingExpression<User,DocEntityUser> _DtoToEntity;

        public UserMapper()
        {
            CreateMap<DocEntitySet<DocEntityUser>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityUser,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityUser>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityUser.Get(c));
            _EntityToDto = CreateMap<DocEntityUser,User>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, "Updated")))
                .ForMember(dest => dest.ClientDepartment, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.ClientDepartment))))
                .ForMember(dest => dest.Division, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.Division))))
                .ForMember(dest => dest.DivisionId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.DivisionId))))
                .ForMember(dest => dest.DocumentSets, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.DocumentSets))))
                .ForMember(dest => dest.DocumentSetsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.DocumentSetsCount))))
                .ForMember(dest => dest.Email, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.Email))))
                .ForMember(dest => dest.ExpireDate, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.ExpireDate))))
                .ForMember(dest => dest.FailedLoginCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.FailedLoginCount))))
                .ForMember(dest => dest.FirstName, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.FirstName))))
                .ForMember(dest => dest.Gravatar, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.Gravatar))))
                .ForMember(dest => dest.History, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.History))))
                .ForMember(dest => dest.HistoryCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.HistoryCount))))
                .ForMember(dest => dest.Impersonated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.Impersonated))))
                .ForMember(dest => dest.ImpersonatedCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.ImpersonatedCount))))
                .ForMember(dest => dest.Impersonating, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.Impersonating))))
                .ForMember(dest => dest.ImpersonatingCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.ImpersonatingCount))))
                .ForMember(dest => dest.IsSystemUser, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.IsSystemUser))))
                .ForMember(dest => dest.JobTitle, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.JobTitle))))
                .ForMember(dest => dest.LastLogin, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.LastLogin))))
                .ForMember(dest => dest.LastName, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.LastName))))
                .ForMember(dest => dest.LegacyUsername, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.LegacyUsername))))
                .ForMember(dest => dest.Locale, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.Locale))))
                .ForMember(dest => dest.LocaleId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.LocaleId))))
                .ForMember(dest => dest.LoginCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.LoginCount))))
                .ForMember(dest => dest.Name, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.Name))))
                .ForMember(dest => dest.Roles, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.Roles))))
                .ForMember(dest => dest.RolesCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.RolesCount))))
                .ForMember(dest => dest.Scopes, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.Scopes))))
                .ForMember(dest => dest.ScopesCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.ScopesCount))))
                .ForMember(dest => dest.Sessions, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.Sessions))))
                .ForMember(dest => dest.SessionsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.SessionsCount))))
                .ForMember(dest => dest.Settings, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.Settings))))
                .ForMember(dest => dest.Slack, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.Slack))))
                .ForMember(dest => dest.StartDate, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.StartDate))))
                .ForMember(dest => dest.Status, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.Status))))
                .ForMember(dest => dest.StatusId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.StatusId))))
                .ForMember(dest => dest.Teams, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.Teams))))
                .ForMember(dest => dest.TeamsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.TeamsCount))))
                .ForMember(dest => dest.TimeCards, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.TimeCards))))
                .ForMember(dest => dest.TimeCardsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.TimeCardsCount))))
                .ForMember(dest => dest.Updates, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.Updates))))
                .ForMember(dest => dest.UpdatesCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.UpdatesCount))))
                .ForMember(dest => dest.UserType, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.UserType))))
                .ForMember(dest => dest.UserTypeId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.UserTypeId))))
                .ForMember(dest => dest.Workflows, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.Workflows))))
                .ForMember(dest => dest.WorkflowsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.WorkflowsCount))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<User,DocEntityUser>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
