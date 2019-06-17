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
    public partial class RoleMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityRole,Role> _EntityToDto;
        protected IMappingExpression<Role,DocEntityRole> _DtoToEntity;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public RoleMapper()
        {
            CreateMap<DocEntitySet<DocEntityRole>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityRole,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityRole>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityRole.Get(c));
            _EntityToDto = CreateMap<DocEntityRole,Role>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Role>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Role>(c, "Updated")))
                .ForMember(dest => dest.AdminTeam, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Role>(c, nameof(DocEntityRole.AdminTeam))))
                .ForMember(dest => dest.AdminTeamId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Role>(c, nameof(DocEntityRole.AdminTeamId))))
                .ForMember(dest => dest.Apps, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Role>(c, nameof(DocEntityRole.Apps))))
                .ForMember(dest => dest.AppsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Role>(c, nameof(DocEntityRole.AppsCount))))
                .ForMember(dest => dest.AppsIds, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Role>(c, nameof(DocEntityRole.AppsIds))))
                .ForMember(dest => dest.Description, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Role>(c, nameof(DocEntityRole.Description))))
                .ForMember(dest => dest.Features, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Role>(c, nameof(DocEntityRole.Features))))
                .ForMember(dest => dest.FeatureSets, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Role>(c, nameof(DocEntityRole.FeatureSets))))
                .ForMember(dest => dest.FeatureSetsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Role>(c, nameof(DocEntityRole.FeatureSetsCount))))
                .ForMember(dest => dest.FeatureSetsIds, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Role>(c, nameof(DocEntityRole.FeatureSetsIds))))
                .ForMember(dest => dest.IsInternal, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Role>(c, nameof(DocEntityRole.IsInternal))))
                .ForMember(dest => dest.IsSuperAdmin, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Role>(c, nameof(DocEntityRole.IsSuperAdmin))))
                .ForMember(dest => dest.Name, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Role>(c, nameof(DocEntityRole.Name))))
                .ForMember(dest => dest.Pages, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Role>(c, nameof(DocEntityRole.Pages))))
                .ForMember(dest => dest.PagesCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Role>(c, nameof(DocEntityRole.PagesCount))))
                .ForMember(dest => dest.PagesIds, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Role>(c, nameof(DocEntityRole.PagesIds))))
                .ForMember(dest => dest.Permissions, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Role>(c, nameof(DocEntityRole.Permissions))))
                .ForMember(dest => dest.Users, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Role>(c, nameof(DocEntityRole.Users))))
                .ForMember(dest => dest.UsersCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Role>(c, nameof(DocEntityRole.UsersCount))))
                .ForMember(dest => dest.UsersIds, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Role>(c, nameof(DocEntityRole.UsersIds))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<Role,DocEntityRole>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
