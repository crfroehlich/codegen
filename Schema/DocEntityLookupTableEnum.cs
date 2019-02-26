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
    [TableMapping(DocConstantModelName.LOOKUPTABLEENUM)]
    public partial class DocEntityLookupTableEnum : DocEntityBase
    {
        private const string LOOKUPTABLEENUM_CACHE = "LookupTableEnumCache";
        public const string TABLE_NAME = DocConstantModelName.LOOKUPTABLEENUM;
        
        #region Constructor
        public DocEntityLookupTableEnum(Session session) : base(session) {}

        public DocEntityLookupTableEnum() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        #region VisibleFields

        protected override List<string> _visibleFields
        {
            get
            {
                if(null == __vf)
                {
                    __vf = DocWebSession.GetTypeVisibleFields(new LookupTableEnum());
                }
                return __vf;
            }
        }

        #endregion VisibleFields

        #region Static Members
        public static DocEntityLookupTableEnum GetLookupTableEnum(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetLookupTableEnum(reference.Id) : null;
        }

        public static DocEntityLookupTableEnum GetLookupTableEnum(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityLookupTableEnum>.GetFromCache(primaryKey, LOOKUPTABLEENUM_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityLookupTableEnum>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityLookupTableEnum>.UpdateCache(ret.Id, ret, LOOKUPTABLEENUM_CACHE);
                    DocEntityThreadCache<DocEntityLookupTableEnum>.UpdateCache(ret.Hash, ret, LOOKUPTABLEENUM_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityLookupTableEnum GetLookupTableEnum(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityLookupTableEnum>.GetFromCache(hash, LOOKUPTABLEENUM_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityLookupTableEnum>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityLookupTableEnum>.UpdateCache(ret.Id, ret, LOOKUPTABLEENUM_CACHE);
                    DocEntityThreadCache<DocEntityLookupTableEnum>.UpdateCache(ret.Hash, ret, LOOKUPTABLEENUM_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field(Nullable = false, DefaultValue = true)]
        [FieldMapping(nameof(IsBindable))]
        public bool IsBindable { get; set; }


        [Field(Nullable = false, DefaultValue = true)]
        [FieldMapping(nameof(IsGlobal))]
        public bool IsGlobal { get; set; }


        [Field(Nullable = false)]
        [FieldMapping(nameof(Name))]
        public string Name { get; set; }



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

        public const string CACHE_KEY_PREFIX = "FindLookupTableEnums";


        private DocLookupTableEnum _model = null;

        public DocLookupTableEnum ToLookupTableEnum()
        {
            if(null == _model)
            {
                _model = DocLookupTableEnum.GetLookupTableEnum(this);
            }
            return _model;
        }

        public override T ToModel<T>() =>  (T) ((IDocModel) ToLookupTableEnum());

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
                throw new HttpError(HttpStatusCode.Conflict, $"LookupTableEnum requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();

            FlushCache();

            _validated = true;


        }

        public override IDocEntity SaveChanges(DocConstantPermission permission = null)
        {
            Name = Name?.TrimAndPruneSpaces();
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

                if(DocTools.IsNullOrEmpty(IsBindable))
                {
                    isValid = false;
                    message += " IsBindable is a required property.";
                }
                if(DocTools.IsNullOrEmpty(IsGlobal))
                {
                    isValid = false;
                    message += " IsGlobal is a required property.";
                }
                if(DocTools.IsNullOrEmpty(Name))
                {
                    isValid = false;
                    message += " Name is a required property.";
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Converters

        public LookupTableEnum ToDto() => Mapper.Map<DocEntityLookupTableEnum, LookupTableEnum>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }

    public static partial class UniqueConstraintFilter
    {
        public static Expression<Func<DocEntityLookupTableEnum, bool>> LookupTableEnumIgnoreArchived() => d => d.Archived == false;
    }

    public partial class LookupTableEnumMapper : DocMapperBase
    {
        private IMappingExpression<DocEntityLookupTableEnum,LookupTableEnum> _EntityToDto;
        private IMappingExpression<LookupTableEnum,DocEntityLookupTableEnum> _DtoToEntity;
        private IMappingExpression<DocLookupTableEnum,LookupTableEnum> _ModelToDto;
        public LookupTableEnumMapper()
        {
            CreateMap<DocEntitySet<DocEntityLookupTableEnum>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityLookupTableEnum,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityLookupTableEnum>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityLookupTableEnum.GetLookupTableEnum(c));
            _EntityToDto = CreateMap<DocEntityLookupTableEnum,LookupTableEnum>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LookupTableEnum>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LookupTableEnum>(c, "Updated")))
                .ForMember(dest => dest.IsBindable, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LookupTableEnum>(c, nameof(DocEntityLookupTableEnum.IsBindable))))
                .ForMember(dest => dest.IsGlobal, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LookupTableEnum>(c, nameof(DocEntityLookupTableEnum.IsGlobal))))
                .ForMember(dest => dest.Name, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LookupTableEnum>(c, nameof(DocEntityLookupTableEnum.Name))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<LookupTableEnum,DocEntityLookupTableEnum>()
                .MaxDepth(2);
            _ModelToDto = CreateMap<DocLookupTableEnum,LookupTableEnum>()
                .ForMember(dest => dest.IsBindable, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LookupTableEnum>(c, nameof(DocEntityLookupTableEnum.IsBindable))))
                .ForMember(dest => dest.IsGlobal, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LookupTableEnum>(c, nameof(DocEntityLookupTableEnum.IsGlobal))))
                .ForMember(dest => dest.Name, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LookupTableEnum>(c, nameof(DocEntityLookupTableEnum.Name))))
.MaxDepth(2);
            CreateMap<DocLookupTableEnum, Reference>()
                .ForMember(dest => dest.Name, opt => opt.Ignore() );
            CreateMap<Reference, DocLookupTableEnum>()
                .ForAllMembers(opt => opt.Ignore() );
            ApplyCustomMaps();
        }
    }
}