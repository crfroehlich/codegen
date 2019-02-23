﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when
//    the code is regenerated.
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
using System.Runtime.Serialization;

using Services.Core;
using Services.Db;
using Services.Dto;
using Services.Dto.internals;
using Services.Enums;
using Services.Models;

using ServiceStack;

using Typed.Notifications;
using Typed.Settings;

using Xtensive.Orm;
using Xtensive.Orm.Model;

using Attribute = Services.Dto.Attribute;
using ValueType = Services.Dto.ValueType;

namespace Services.Schema
{
    [TableMapping(DocConstantModelName.LOOKUPCATEGORY)]
    public partial class DocEntityLookupCategory : DocEntityBase
    {
        private const string LOOKUPCATEGORY_CACHE = "LookupCategoryCache";
        public const string TABLE_NAME = DocConstantModelName.LOOKUPCATEGORY;
        
        #region Constructor
        public DocEntityLookupCategory(Session session) : base(session) {}

        public DocEntityLookupCategory() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        #region VisibleFields

        protected override List<string> _visibleFields
        {
            get
            {
                if(null == __vf)
                {
                    __vf = DocWebSession.GetTypeVisibleFields(new LookupCategory());
                }
                return __vf;
            }
        }

        #endregion VisibleFields

        #region Static Members
        public static DocEntityLookupCategory GetLookupCategory(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetLookupCategory(reference.Id) : null;
        }

        public static DocEntityLookupCategory GetLookupCategory(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityLookupCategory>.GetFromCache(primaryKey, LOOKUPCATEGORY_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityLookupCategory>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityLookupCategory>.UpdateCache(ret.Id, ret, LOOKUPCATEGORY_CACHE);
                    DocEntityThreadCache<DocEntityLookupCategory>.UpdateCache(ret.Hash, ret, LOOKUPCATEGORY_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityLookupCategory GetLookupCategory(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityLookupCategory>.GetFromCache(hash, LOOKUPCATEGORY_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityLookupCategory>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityLookupCategory>.UpdateCache(ret.Id, ret, LOOKUPCATEGORY_CACHE);
                    DocEntityThreadCache<DocEntityLookupCategory>.UpdateCache(ret.Hash, ret, LOOKUPCATEGORY_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field(Nullable = false)]
        [FieldMapping(nameof(Category))]
        public string Category { get; set; }


        [Field(Nullable = false)]
        [FieldMapping(nameof(Enum))]
        public DocEntityLookupTableEnum Enum { get; set; }
        public int? EnumId { get { return Enum?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Lookups))]
        [Association(PairTo = nameof(DocEntityLookupTable.Categories), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityLookupTable> Lookups { get; private set; }


        public int? LookupsCount { get { return Lookups.Count(); } private set { var noid = value; } }



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

        public const string CACHE_KEY_PREFIX = "FindLookupCategorys";


        public override T ToModel<T>() =>  null;

        #endregion Overrides of DocEntity

        #region Entity overrides
        /// <summary>
        ///    Called when entity is about to be removed.
        /// </summary>
        protected override void OnRemoving()
        {
            base.OnRemoving();
        }

        /// <summary>
        ///    Called when entity should be validated. Override this method to perform custom object validation.
        /// </summary>
        protected override void OnValidate()
        {
            if (false == ValidationMessage.IsValid)
            {
                throw new HttpError(HttpStatusCode.Conflict, $"LookupCategory requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();

            FlushCache();

            _validated = true;


        }

        public override IDocEntity SaveChanges(DocConstantPermission permission = null)
        {
            Category = Category?.TrimAndPruneSpaces();
            return base.SaveChanges(permission);
        }

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

                if(DocTools.IsNullOrEmpty(Category))
                {
                    isValid = false;
                    message += " Category is a required property.";
                }
                if(DocTools.IsNullOrEmpty(Enum))
                {
                    isValid = false;
                    message += " Enum is a required property.";
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Converters

        public LookupCategory ToDto() => Mapper.Map<DocEntityLookupCategory, LookupCategory>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }

    public static partial class UniqueConstraintFilter
    {
        public static Expression<Func<DocEntityLookupCategory, bool>> LookupCategoryIgnoreArchived() => d => d.Archived == false;
    }

    public partial class LookupCategoryMapper : DocMapperBase
    {
        private IMappingExpression<DocEntityLookupCategory,LookupCategory> _EntityToDto;
        private IMappingExpression<LookupCategory,DocEntityLookupCategory> _DtoToEntity;
        public LookupCategoryMapper()
        {
            CreateMap<DocEntitySet<DocEntityLookupCategory>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityLookupCategory,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityLookupCategory>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityLookupCategory.GetLookupCategory(c));
            _EntityToDto = CreateMap<DocEntityLookupCategory,LookupCategory>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LookupCategory>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LookupCategory>(c, "Updated")))
                .ForMember(dest => dest.Category, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LookupCategory>(c, nameof(DocEntityLookupCategory.Category))))
                .ForMember(dest => dest.Enum, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LookupCategory>(c, nameof(DocEntityLookupCategory.Enum))))
                .ForMember(dest => dest.EnumId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LookupCategory>(c, nameof(DocEntityLookupCategory.EnumId))))
                .ForMember(dest => dest.Lookups, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LookupCategory>(c, nameof(DocEntityLookupCategory.Lookups))))
                .ForMember(dest => dest.LookupsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LookupCategory>(c, nameof(DocEntityLookupCategory.LookupsCount))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<LookupCategory,DocEntityLookupCategory>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}