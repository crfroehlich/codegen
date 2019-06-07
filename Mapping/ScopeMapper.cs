
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
    public partial class ScopeMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityScope,Scope> _EntityToDto;
        protected IMappingExpression<Scope,DocEntityScope> _DtoToEntity;

        public ScopeMapper()
        {
            CreateMap<DocEntitySet<DocEntityScope>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityScope,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityScope>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityScope.Get(c));
            _EntityToDto = CreateMap<DocEntityScope,Scope>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, "Updated")))
                .ForMember(dest => dest.App, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.App))))
                .ForMember(dest => dest.AppId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.AppId))))
                .ForMember(dest => dest.Bindings, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.Bindings))))
                .ForMember(dest => dest.BindingsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.BindingsCount))))
                .ForMember(dest => dest.BindingsIds, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.BindingsIds))))
                .ForMember(dest => dest.Broadcasts, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.Broadcasts))))
                .ForMember(dest => dest.BroadcastsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.BroadcastsCount))))
                .ForMember(dest => dest.BroadcastsIds, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.BroadcastsIds))))
                .ForMember(dest => dest.Client, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.Client))))
                .ForMember(dest => dest.ClientId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.ClientId))))
                .ForMember(dest => dest.Delete, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.Delete))))
                .ForMember(dest => dest.DocumentSet, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.DocumentSet))))
                .ForMember(dest => dest.DocumentSetId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.DocumentSetId))))
                .ForMember(dest => dest.Edit, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.Edit))))
                .ForMember(dest => dest.Help, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.Help))))
                .ForMember(dest => dest.HelpCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.HelpCount))))
                .ForMember(dest => dest.HelpIds, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.HelpIds))))
                .ForMember(dest => dest.IsGlobal, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.IsGlobal))))
                .ForMember(dest => dest.ScopedComments, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.ScopedComments))))
                .ForMember(dest => dest.ScopedCommentsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.ScopedCommentsCount))))
                .ForMember(dest => dest.ScopedCommentsIds, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.ScopedCommentsIds))))
                .ForMember(dest => dest.ScopedTags, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.ScopedTags))))
                .ForMember(dest => dest.ScopedTagsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.ScopedTagsCount))))
                .ForMember(dest => dest.ScopedTagsIds, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.ScopedTagsIds))))
                .ForMember(dest => dest.Synonyms, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.Synonyms))))
                .ForMember(dest => dest.SynonymsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.SynonymsCount))))
                .ForMember(dest => dest.SynonymsIds, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.SynonymsIds))))
                .ForMember(dest => dest.Team, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.Team))))
                .ForMember(dest => dest.TeamId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.TeamId))))
                .ForMember(dest => dest.Type, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.Type))))
                .ForMember(dest => dest.User, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.User))))
                .ForMember(dest => dest.UserId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.UserId))))
                .ForMember(dest => dest.VariableRules, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.VariableRules))))
                .ForMember(dest => dest.VariableRulesCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.VariableRulesCount))))
                .ForMember(dest => dest.VariableRulesIds, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.VariableRulesIds))))
                .ForMember(dest => dest.View, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.View))))
                .ForMember(dest => dest.Workflows, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.Workflows))))
                .ForMember(dest => dest.WorkflowsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.WorkflowsCount))))
                .ForMember(dest => dest.WorkflowsIds, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.WorkflowsIds))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<Scope,DocEntityScope>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
