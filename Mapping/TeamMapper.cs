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
    public partial class TeamMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityTeam,Team> _EntityToDto;
        protected IMappingExpression<Team,DocEntityTeam> _DtoToEntity;

        public TeamMapper()
        {
            CreateMap<DocEntitySet<DocEntityTeam>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityTeam,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityTeam>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityTeam.Get(c));
            _EntityToDto = CreateMap<DocEntityTeam,Team>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Team>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Team>(c, "Updated")))
                .ForMember(dest => dest.AdminRoles, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Team>(c, nameof(DocEntityTeam.AdminRoles))))
                .ForMember(dest => dest.AdminRolesCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Team>(c, nameof(DocEntityTeam.AdminRolesCount))))
                .ForMember(dest => dest.Description, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Team>(c, nameof(DocEntityTeam.Description))))
                .ForMember(dest => dest.Email, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Team>(c, nameof(DocEntityTeam.Email))))
                .ForMember(dest => dest.IsInternal, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Team>(c, nameof(DocEntityTeam.IsInternal))))
                .ForMember(dest => dest.Name, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Team>(c, nameof(DocEntityTeam.Name))))
                .ForMember(dest => dest.Owner, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Team>(c, nameof(DocEntityTeam.Owner))))
                .ForMember(dest => dest.OwnerId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Team>(c, nameof(DocEntityTeam.OwnerId))))
                .ForMember(dest => dest.Scopes, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Team>(c, nameof(DocEntityTeam.Scopes))))
                .ForMember(dest => dest.ScopesCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Team>(c, nameof(DocEntityTeam.ScopesCount))))
                .ForMember(dest => dest.Settings, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Team>(c, nameof(DocEntityTeam.Settings))))
                .ForMember(dest => dest.Slack, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Team>(c, nameof(DocEntityTeam.Slack))))
                .ForMember(dest => dest.Updates, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Team>(c, nameof(DocEntityTeam.Updates))))
                .ForMember(dest => dest.UpdatesCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Team>(c, nameof(DocEntityTeam.UpdatesCount))))
                .ForMember(dest => dest.Users, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Team>(c, nameof(DocEntityTeam.Users))))
                .ForMember(dest => dest.UsersCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Team>(c, nameof(DocEntityTeam.UsersCount))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<Team,DocEntityTeam>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
