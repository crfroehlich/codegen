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
    public partial class JunctionMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityJunction,Junction> _EntityToDto;
        protected IMappingExpression<Junction,DocEntityJunction> _DtoToEntity;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public JunctionMapper()
        {
            CreateMap<DocEntitySet<DocEntityJunction>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityJunction,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityJunction>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityJunction.Get(c));
            _EntityToDto = CreateMap<DocEntityJunction,Junction>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Junction>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Junction>(c, "Updated")))
                .ForMember(dest => dest.Children, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Junction>(c, nameof(DocEntityJunction.Children))))
                .ForMember(dest => dest.ChildrenCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Junction>(c, nameof(DocEntityJunction.ChildrenCount))))
                .ForMember(dest => dest.ChildrenIds, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Junction>(c, nameof(DocEntityJunction.ChildrenIds))))
                .ForMember(dest => dest.Data, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Junction>(c, nameof(DocEntityJunction.Data))))
                .ForMember(dest => dest.OwnerId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Junction>(c, nameof(DocEntityJunction.OwnerId))))
                .ForMember(dest => dest.OwnerType, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Junction>(c, nameof(DocEntityJunction.OwnerType))))
                .ForMember(dest => dest.Parent, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Junction>(c, nameof(DocEntityJunction.Parent))))
                .ForMember(dest => dest.ParentId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Junction>(c, nameof(DocEntityJunction.ParentId))))
                .ForMember(dest => dest.TargetId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Junction>(c, nameof(DocEntityJunction.TargetId))))
                .ForMember(dest => dest.TargetType, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Junction>(c, nameof(DocEntityJunction.TargetType))))
                .ForMember(dest => dest.Type, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Junction>(c, nameof(DocEntityJunction.Type))))
                .ForMember(dest => dest.Type_Id, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Junction>(c, nameof(DocEntityJunction.Type_Id))))
                .ForMember(dest => dest.User, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Junction>(c, nameof(DocEntityJunction.User))))
                .ForMember(dest => dest.UserId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Junction>(c, nameof(DocEntityJunction.UserId))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<Junction,DocEntityJunction>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
