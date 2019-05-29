
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
    [TableMapping(DocConstantModelName.JUNCTION)]
    public partial class DocEntityJunction : DocEntityBase
    {
        private const string JUNCTION_CACHE = "JunctionCache";
        public const string TABLE_NAME = DocConstantModelName.JUNCTION;
        
        #region Constructor
        public DocEntityJunction(Session session) : base(session) {}

        public DocEntityJunction() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        #region VisibleFields

        protected override List<string> _visibleFields
        {
            get
            {
                if(null == __vf)
                {
                    __vf = DocWebSession.GetTypeVisibleFields(new Junction());
                }
                return __vf;
            }
        }

        #endregion VisibleFields

        #region Static Members
        public static DocEntityJunction GetJunction(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetJunction(reference.Id) : null;
        }

        public static DocEntityJunction GetJunction(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityJunction>.GetFromCache(primaryKey, JUNCTION_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityJunction>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityJunction>.UpdateCache(ret.Id, ret, JUNCTION_CACHE);
                    DocEntityThreadCache<DocEntityJunction>.UpdateCache(ret.Hash, ret, JUNCTION_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityJunction GetJunction(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityJunction>.GetFromCache(hash, JUNCTION_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityJunction>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityJunction>.UpdateCache(ret.Id, ret, JUNCTION_CACHE);
                    DocEntityThreadCache<DocEntityJunction>.UpdateCache(ret.Hash, ret, JUNCTION_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field()]
        [FieldMapping(nameof(Children))]
        [Association(PairTo = nameof(DocEntityJunction.Parent), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityJunction> Children { get; private set; }
        public List<int> ChildrenIds => Children.Select(e => e.Id).ToList();




        public int? ChildrenCount { get { return Children.Count(); } private set { var noid = value; } }


        [Field(Length = int.MaxValue)]
        [FieldMapping(nameof(Data))]
        public string Data { get; set; }


        [Field()]
        [FieldMapping(nameof(OwnerId))]
        public int? OwnerId { get; set; }


        [Field()]
        [FieldMapping(nameof(OwnerType))]
        public string OwnerType { get; set; }


        [Field()]
        [FieldMapping(nameof(Parent))]
        public DocEntityJunction Parent { get; set; }
        public int? ParentId { get { return Parent?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(TargetId))]
        public int? TargetId { get; set; }


        [Field()]
        [FieldMapping(nameof(TargetType))]
        public string TargetType { get; set; }


        [Field(Nullable = false)]
        [FieldMapping(nameof(Type))]
        public DocEntityLookupTable Type { get; set; }
        public int? TypeId { get { return Type?.Id; } private set { var noid = value; } }


        [Field(Nullable = false)]
        [FieldMapping(nameof(User))]
        public DocEntityUser User { get; set; }
        public int? UserId { get { return User?.Id; } private set { var noid = value; } }



        [Field(LazyLoad = false, Length = Int32.MaxValue)]
        public override string Gestalt { get; set; }

        [Field(DefaultValue = 0), Version(VersionMode.Manual)]
        public override int VersionNo { get; set; }

        [Field]
        public override DateTime? Created { get; set; }

        [Field]
        public override DateTime? Updated { get; set; }

        [Field(DefaultValue = false)]
        [FieldMapping(nameof(Locked))]
        public override bool Locked { get; set; }

        [Field(DefaultValue = false)]
        [FieldMapping(nameof(Archived))]
        public override bool Archived { get; set; }

        #endregion Properties

        #region Overrides of DocEntity

        public override DocConstantModelName TableName => TABLE_NAME;

        public const string CACHE_KEY_PREFIX = "FindJunctions";

        #endregion Overrides of DocEntity

        #region Entity overrides
        /// <summary>
        ///    Called when entity is about to be removed.
        /// </summary>
        protected override void OnRemoving()
        {
            base.OnRemoving();
            try
            {
                Children.Clear(); //foreach thing in Children en.Remove();
            }
            catch(Exception ex)
            {
                throw new DocException("Failed to delete Junction in Children delete", ex);
            }
            FlushCache();
        }

        /// <summary>
        ///    Called when entity should be validated. Override this method to perform custom object validation.
        /// </summary>
        protected override void OnValidate()
        {
            if (false == ValidationMessage.IsValid)
            {
                throw new HttpError(HttpStatusCode.Conflict, $"Junction requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();
            _validated = true;
        }

        public override IDocEntity SaveChanges(bool ignoreCache, DocConstantPermission permission)
        {
            OwnerType = OwnerType?.TrimAndPruneSpaces();
            TargetType = TargetType?.TrimAndPruneSpaces();
            return base.SaveChanges(ignoreCache, permission);
        }

        public override IDocEntity SaveChanges(bool ignoreCache) => SaveChanges(ignoreCache, DocConstantPermission.EDIT);
        public override IDocEntity SaveChanges(DocConstantPermission permission) => SaveChanges(false, DocConstantPermission.EDIT);
        public override IDocEntity SaveChanges() => SaveChanges(DocConstantPermission.EDIT);

        public override void FlushCache()
        {
            base.FlushCache();

        }
        #endregion Entity overrides

        #region Validation
        public DocValidationMessage ValidationMessage
        {
            get
            {
                var isValid = true;
                var message = string.Empty;

                if(DocTools.IsNullOrEmpty(Type))
                {
                    isValid = false;
                    message += " Type is a required property.";
                }
                else
                {
                    if(Type.Enum?.Name != "JunctionType")
                    {
                        isValid = false;
                        message += " Type is a " + Type.Enum.Name + ", but must be a JunctionType.";
                    }
                }
                if(DocTools.IsNullOrEmpty(User))
                {
                    isValid = false;
                    message += " User is a required property.";
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Converters

        public Junction ToDto() => Mapper.Map<DocEntityJunction, Junction>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }

    public static partial class UniqueConstraintFilter
    {
        public static Expression<Func<DocEntityJunction, bool>> JunctionIgnoreArchived() => d => d.Archived == false;
    }

    public partial class JunctionMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityJunction,Junction> _EntityToDto;
        protected IMappingExpression<Junction,DocEntityJunction> _DtoToEntity;

        public JunctionMapper()
        {
            CreateMap<DocEntitySet<DocEntityJunction>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityJunction,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityJunction>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityJunction.GetJunction(c));
            _EntityToDto = CreateMap<DocEntityJunction,Junction>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Junction>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Junction>(c, "Updated")))
                .ForMember(dest => dest.Children, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Junction>(c, nameof(DocEntityJunction.Children))))
                .ForMember(dest => dest.ChildrenCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Junction>(c, nameof(DocEntityJunction.ChildrenCount))))
                .ForMember(dest => dest.Data, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Junction>(c, nameof(DocEntityJunction.Data))))
                .ForMember(dest => dest.OwnerId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Junction>(c, nameof(DocEntityJunction.OwnerId))))
                .ForMember(dest => dest.OwnerType, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Junction>(c, nameof(DocEntityJunction.OwnerType))))
                .ForMember(dest => dest.Parent, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Junction>(c, nameof(DocEntityJunction.Parent))))
                .ForMember(dest => dest.ParentId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Junction>(c, nameof(DocEntityJunction.ParentId))))
                .ForMember(dest => dest.TargetId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Junction>(c, nameof(DocEntityJunction.TargetId))))
                .ForMember(dest => dest.TargetType, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Junction>(c, nameof(DocEntityJunction.TargetType))))
                .ForMember(dest => dest.Type, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Junction>(c, nameof(DocEntityJunction.Type))))
                .ForMember(dest => dest.TypeId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Junction>(c, nameof(DocEntityJunction.TypeId))))
                .ForMember(dest => dest.User, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Junction>(c, nameof(DocEntityJunction.User))))
                .ForMember(dest => dest.UserId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Junction>(c, nameof(DocEntityJunction.UserId))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<Junction,DocEntityJunction>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
