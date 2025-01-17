//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated by a T4 template. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System.CodeDom.Compiler;
using System.Collections.Generic;

using AutoMapper;

using Services.Core;
using Services.Dto;
namespace Services.Schema
{
    public partial class UserRequestMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityUserRequest,UserRequest> _EntityToDto;
        protected IMappingExpression<UserRequest,DocEntityUserRequest> _DtoToEntity;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public UserRequestMapper()
        {
            CreateMap<DocEntitySet<DocEntityUserRequest>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityUserRequest,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityUserRequest>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityUserRequest.Get(c));
            _EntityToDto = CreateMap<DocEntityUserRequest,UserRequest>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UserRequest>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UserRequest>(c, "Updated")))
                .ForMember(dest => dest.App, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UserRequest>(c, nameof(DocEntityUserRequest.App))))
                .ForMember(dest => dest.AppId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UserRequest>(c, nameof(DocEntityUserRequest.AppId))))
                .ForMember(dest => dest.Method, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UserRequest>(c, nameof(DocEntityUserRequest.Method))))
                .ForMember(dest => dest.Page, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UserRequest>(c, nameof(DocEntityUserRequest.Page))))
                .ForMember(dest => dest.PageId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UserRequest>(c, nameof(DocEntityUserRequest.PageId))))
                .ForMember(dest => dest.Path, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UserRequest>(c, nameof(DocEntityUserRequest.Path))))
                .ForMember(dest => dest.URL, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UserRequest>(c, nameof(DocEntityUserRequest.URL))))
                .ForMember(dest => dest.UserSession, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UserRequest>(c, nameof(DocEntityUserRequest.UserSession))))
                .ForMember(dest => dest.UserSessionId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UserRequest>(c, nameof(DocEntityUserRequest.UserSessionId))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<UserRequest,DocEntityUserRequest>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
