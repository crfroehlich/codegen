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
    [TableMapping(DocConstantModelName.DEFAULT)]
    public partial class DocEntityDefault : DocEntityBase
    {
        private const string DEFAULT_CACHE = "DefaultCache";
        public const string TABLE_NAME = DocConstantModelName.DEFAULT;
        
        #region Constructor
        public DocEntityDefault(Session session) : base(session) {}

        public DocEntityDefault() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        #region VisibleFields

        protected override List<string> _visibleFields
        {
            get
            {
                if(null == __vf)
                {
                    __vf = DocWebSession.GetTypeVisibleFields(new Default());
                }
                return __vf;
            }
        }

        #endregion VisibleFields

        #region Static Members
        public static DocEntityDefault GetDefault(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetDefault(reference.Id) : null;
        }

        public static DocEntityDefault GetDefault(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityDefault>.GetFromCache(primaryKey, DEFAULT_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityDefault>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityDefault>.UpdateCache(ret.Id, ret, DEFAULT_CACHE);
                    DocEntityThreadCache<DocEntityDefault>.UpdateCache(ret.Hash, ret, DEFAULT_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityDefault GetDefault(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityDefault>.GetFromCache(hash, DEFAULT_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityDefault>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityDefault>.UpdateCache(ret.Id, ret, DEFAULT_CACHE);
                    DocEntityThreadCache<DocEntityDefault>.UpdateCache(ret.Hash, ret, DEFAULT_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field(Nullable = false)]
        [FieldMapping(nameof(DiseaseState))]
        public DocEntityDocumentSet DiseaseState { get; set; }
        public int? DiseaseStateId { get { return DiseaseState?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Role))]
        public DocEntityRole Role { get; set; }
        public int? RoleId { get { return Role?.Id; } private set { var noid = value; } }


        [Field(Nullable = false)]
        [FieldMapping(nameof(Scope))]
        public DocEntityScope Scope { get; set; }
        public int? ScopeId { get { return Scope?.Id; } private set { var noid = value; } }


        [Field(Nullable = false)]
        [FieldMapping(nameof(TherapeuticArea))]
        public DocEntityDocumentSet TherapeuticArea { get; set; }
        public int? TherapeuticAreaId { get { return TherapeuticArea?.Id; } private set { var noid = value; } }



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

        public const string CACHE_KEY_PREFIX = "FindDefaults";

        #endregion Overrides of DocEntity

        #region Entity overrides
        /// <summary>
        ///    Called when entity is about to be removed.
        /// </summary>
        protected override void OnRemoving()
        {

            base.OnRemoving();
            FlushCache();
        }

        /// <summary>
        ///    Called when entity should be validated. Override this method to perform custom object validation.
        /// </summary>
        protected override void OnValidate()
        {
            if (false == ValidationMessage.IsValid)
            {
                throw new HttpError(HttpStatusCode.Conflict, $"Default requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();
            _validated = true;
        }

        public override IDocEntity SaveChanges(bool ignoreCache, DocConstantPermission permission)
        {

            return base.SaveChanges(ignoreCache, permission);
        }

        public override IDocEntity SaveChanges(bool ignoreCache) => SaveChanges(ignoreCache, DocConstantPermission.EDIT);
        public override IDocEntity SaveChanges(DocConstantPermission permission) => SaveChanges(false, DocConstantPermission.EDIT);
        public override IDocEntity SaveChanges() => SaveChanges(DocConstantPermission.EDIT);

        public override void FlushCache()
        {
            base.FlushCache();
            DocCacheClient.RemoveById(Id);
        }
        #endregion Entity overrides

        #region Validation
        public DocValidationMessage ValidationMessage
        {
            get
            {
                var isValid = true;
                var message = string.Empty;

                if(DocTools.IsNullOrEmpty(DiseaseState))
                {
                    isValid = false;
                    message += " DiseaseState is a required property.";
                }
                if(DocTools.IsNullOrEmpty(Scope))
                {
                    isValid = false;
                    message += " Scope is a required property.";
                }
                if(DocTools.IsNullOrEmpty(TherapeuticArea))
                {
                    isValid = false;
                    message += " TherapeuticArea is a required property.";
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Converters

        public Default ToDto() => Mapper.Map<DocEntityDefault, Default>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }

    public static partial class UniqueConstraintFilter
    {
        public static Expression<Func<DocEntityDefault, bool>> DefaultIgnoreArchived() => d => d.Archived == false;
    }

    public partial class DefaultMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityDefault,Default> _EntityToDto;
        protected IMappingExpression<Default,DocEntityDefault> _DtoToEntity;

        public DefaultMapper()
        {
            CreateMap<DocEntitySet<DocEntityDefault>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityDefault,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityDefault>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityDefault.GetDefault(c));
            _EntityToDto = CreateMap<DocEntityDefault,Default>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Default>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Default>(c, "Updated")))
                .ForMember(dest => dest.DiseaseState, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Default>(c, nameof(DocEntityDefault.DiseaseState))))
                .ForMember(dest => dest.DiseaseStateId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Default>(c, nameof(DocEntityDefault.DiseaseStateId))))
                .ForMember(dest => dest.Role, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Default>(c, nameof(DocEntityDefault.Role))))
                .ForMember(dest => dest.RoleId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Default>(c, nameof(DocEntityDefault.RoleId))))
                .ForMember(dest => dest.Scope, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Default>(c, nameof(DocEntityDefault.Scope))))
                .ForMember(dest => dest.ScopeId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Default>(c, nameof(DocEntityDefault.ScopeId))))
                .ForMember(dest => dest.TherapeuticArea, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Default>(c, nameof(DocEntityDefault.TherapeuticArea))))
                .ForMember(dest => dest.TherapeuticAreaId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Default>(c, nameof(DocEntityDefault.TherapeuticAreaId))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<Default,DocEntityDefault>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
