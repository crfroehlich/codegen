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
    [TableMapping(DocConstantModelName.TERMCATEGORY)]
    public partial class DocEntityTermCategory : DocEntityBase
    {
        private const string TERMCATEGORY_CACHE = "TermCategoryCache";
        public const string TABLE_NAME = DocConstantModelName.TERMCATEGORY;
        
        #region Constructor
        public DocEntityTermCategory(Session session) : base(session) {}

        public DocEntityTermCategory() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        #region VisibleFields

        protected override List<string> _visibleFields
        {
            get
            {
                if(null == __vf)
                {
                    __vf = DocWebSession.GetTypeVisibleFields(new TermCategory());
                }
                return __vf;
            }
        }

        #endregion VisibleFields

        #region Static Members
        public static DocEntityTermCategory GetTermCategory(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetTermCategory(reference.Id) : null;
        }

        public static DocEntityTermCategory GetTermCategory(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityTermCategory>.GetFromCache(primaryKey, TERMCATEGORY_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityTermCategory>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityTermCategory>.UpdateCache(ret.Id, ret, TERMCATEGORY_CACHE);
                    DocEntityThreadCache<DocEntityTermCategory>.UpdateCache(ret.Hash, ret, TERMCATEGORY_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityTermCategory GetTermCategory(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityTermCategory>.GetFromCache(hash, TERMCATEGORY_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityTermCategory>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityTermCategory>.UpdateCache(ret.Id, ret, TERMCATEGORY_CACHE);
                    DocEntityThreadCache<DocEntityTermCategory>.UpdateCache(ret.Hash, ret, TERMCATEGORY_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field(Nullable = false)]
        [FieldMapping(nameof(Name))]
        public DocEntityLookupTable Name { get; set; }
        public int? NameId { get { return Name?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(ParentCategory))]
        public DocEntityTermCategory ParentCategory { get; set; }
        public int? ParentCategoryId { get { return ParentCategory?.Id; } private set { var noid = value; } }


        [Field(NullableOnUpgrade = true)]
        [FieldMapping(nameof(Scope))]
        public DocEntityScope Scope { get; set; }
        public int? ScopeId { get { return Scope?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Terms))]
        [Association(PairTo = nameof(DocEntityTermMaster.Categories), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityTermMaster> Terms { get; private set; }


        public int? TermsCount { get { return Terms.Count(); } private set { var noid = value; } }



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

        public const string CACHE_KEY_PREFIX = "FindTermCategorys";

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
                throw new HttpError(HttpStatusCode.Conflict, $"TermCategory requires: {ValidationMessage.Message}.");
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

                if(DocTools.IsNullOrEmpty(Name))
                {
                    isValid = false;
                    message += " Name is a required property.";
                }
                else
                {
                    if(Name.Enum?.Name != "TermCategory")
                    {
                        isValid = false;
                        message += " Name is a " + Name.Enum.Name + ", but must be a TermCategory.";
                    }
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Converters

        public TermCategory ToDto() => Mapper.Map<DocEntityTermCategory, TermCategory>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }

    public static partial class UniqueConstraintFilter
    {
        public static Expression<Func<DocEntityTermCategory, bool>> TermCategoryIgnoreArchived() => d => d.Archived == false;
    }

    public partial class TermCategoryMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityTermCategory,TermCategory> _EntityToDto;
        protected IMappingExpression<TermCategory,DocEntityTermCategory> _DtoToEntity;

        public TermCategoryMapper()
        {
            CreateMap<DocEntitySet<DocEntityTermCategory>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityTermCategory,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityTermCategory>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityTermCategory.GetTermCategory(c));
            _EntityToDto = CreateMap<DocEntityTermCategory,TermCategory>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TermCategory>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TermCategory>(c, "Updated")))
                .ForMember(dest => dest.Name, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TermCategory>(c, nameof(DocEntityTermCategory.Name))))
                .ForMember(dest => dest.NameId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TermCategory>(c, nameof(DocEntityTermCategory.NameId))))
                .ForMember(dest => dest.ParentCategory, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TermCategory>(c, nameof(DocEntityTermCategory.ParentCategory))))
                .ForMember(dest => dest.ParentCategoryId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TermCategory>(c, nameof(DocEntityTermCategory.ParentCategoryId))))
                .ForMember(dest => dest.Scope, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TermCategory>(c, nameof(DocEntityTermCategory.Scope))))
                .ForMember(dest => dest.ScopeId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TermCategory>(c, nameof(DocEntityTermCategory.ScopeId))))
                .ForMember(dest => dest.Terms, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TermCategory>(c, nameof(DocEntityTermCategory.Terms))))
                .ForMember(dest => dest.TermsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TermCategory>(c, nameof(DocEntityTermCategory.TermsCount))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<TermCategory,DocEntityTermCategory>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
