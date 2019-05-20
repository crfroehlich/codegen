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
    public partial class UserSessionMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityUserSession,UserSession> _EntityToDto;
        protected IMappingExpression<UserSession,DocEntityUserSession> _DtoToEntity;

        public UserSessionMapper()
        {
            CreateMap<DocEntitySet<DocEntityUserSession>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityUserSession,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityUserSession>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityUserSession.Get(c));
            _EntityToDto = CreateMap<DocEntityUserSession,UserSession>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UserSession>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UserSession>(c, "Updated")))
                .ForMember(dest => dest.ClientId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UserSession>(c, nameof(DocEntityUserSession.ClientId))))
                .ForMember(dest => dest.Hits, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UserSession>(c, nameof(DocEntityUserSession.Hits))))
                .ForMember(dest => dest.Impersonations, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UserSession>(c, nameof(DocEntityUserSession.Impersonations))))
                .ForMember(dest => dest.ImpersonationsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UserSession>(c, nameof(DocEntityUserSession.ImpersonationsCount))))
                .ForMember(dest => dest.IpAddress, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UserSession>(c, nameof(DocEntityUserSession.IpAddress))))
                .ForMember(dest => dest.Requests, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UserSession>(c, nameof(DocEntityUserSession.Requests))))
                .ForMember(dest => dest.RequestsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UserSession>(c, nameof(DocEntityUserSession.RequestsCount))))
                .ForMember(dest => dest.SessionId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UserSession>(c, nameof(DocEntityUserSession.SessionId))))
                .ForMember(dest => dest.TemporarySessionId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UserSession>(c, nameof(DocEntityUserSession.TemporarySessionId))))
                .ForMember(dest => dest.User, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UserSession>(c, nameof(DocEntityUserSession.User))))
                .ForMember(dest => dest.UserId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UserSession>(c, nameof(DocEntityUserSession.UserId))))
                .ForMember(dest => dest.UserHistory, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UserSession>(c, nameof(DocEntityUserSession.UserHistory))))
                .ForMember(dest => dest.UserHistoryCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UserSession>(c, nameof(DocEntityUserSession.UserHistoryCount))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<UserSession,DocEntityUserSession>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
