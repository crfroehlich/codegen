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
    [TableMapping(DocConstantModelName.TERMSYNONYM)]
    public partial class DocEntityTermSynonym : DocEntityBase
    {
        private const string TERMSYNONYM_CACHE = "TermSynonymCache";
        public const string TABLE_NAME = DocConstantModelName.TERMSYNONYM;
        
        #region Constructor
        public DocEntityTermSynonym(Session session) : base(session) {}

        public DocEntityTermSynonym() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        #region VisibleFields

        protected override List<string> _visibleFields
        {
            get
            {
                if(null == __vf)
                {
                    __vf = DocWebSession.GetTypeVisibleFields(new TermSynonym());
                }
                return __vf;
            }
        }

        #endregion VisibleFields

        #region Static Members
        public static DocEntityTermSynonym GetTermSynonym(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetTermSynonym(reference.Id) : null;
        }

        public static DocEntityTermSynonym GetTermSynonym(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityTermSynonym>.GetFromCache(primaryKey, TERMSYNONYM_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityTermSynonym>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityTermSynonym>.UpdateCache(ret.Id, ret, TERMSYNONYM_CACHE);
                    DocEntityThreadCache<DocEntityTermSynonym>.UpdateCache(ret.Hash, ret, TERMSYNONYM_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityTermSynonym GetTermSynonym(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityTermSynonym>.GetFromCache(hash, TERMSYNONYM_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityTermSynonym>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityTermSynonym>.UpdateCache(ret.Id, ret, TERMSYNONYM_CACHE);
                    DocEntityThreadCache<DocEntityTermSynonym>.UpdateCache(ret.Hash, ret, TERMSYNONYM_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field()]
        [FieldMapping(nameof(Approved))]
        public bool Approved { get; set; }


        [Field()]
        [FieldMapping(nameof(Bindings))]
        public DocEntitySet<DocEntityLookupTableBinding> Bindings { get; private set; }


        public int? BindingsCount { get { return Bindings.Count(); } private set { var noid = value; } }


        [Field(Nullable = false)]
        [FieldMapping(nameof(Master))]
        public DocEntityTermMaster Master { get; set; }
        public int? MasterId { get { return Master?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Preferred))]
        public bool Preferred { get; set; }


        [Field()]
        [FieldMapping(nameof(Scope))]
        public DocEntityScope Scope { get; set; }
        public int? ScopeId { get { return Scope?.Id; } private set { var noid = value; } }


        [Field(Nullable = false)]
        [FieldMapping(nameof(Synonym))]
        public string Synonym { get; set; }



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

        public const string CACHE_KEY_PREFIX = "FindTermSynonyms";

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
                throw new HttpError(HttpStatusCode.Conflict, $"TermSynonym requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();

            FlushCache();

            _validated = true;


        }

        public override IDocEntity SaveChanges(DocConstantPermission permission = null)
        {
            Synonym = Synonym?.TrimAndPruneSpaces();
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

                if(DocTools.IsNullOrEmpty(Master))
                {
                    isValid = false;
                    message += " Master is a required property.";
                }
                if(DocTools.IsNullOrEmpty(Synonym))
                {
                    isValid = false;
                    message += " Synonym is a required property.";
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Converters

        public TermSynonym ToDto() => Mapper.Map<DocEntityTermSynonym, TermSynonym>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }

    public static partial class UniqueConstraintFilter
    {
        public static Expression<Func<DocEntityTermSynonym, bool>> TermSynonymIgnoreArchived() => d => d.Archived == false;
    }

    public partial class TermSynonymMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityTermSynonym,TermSynonym> _EntityToDto;
        protected IMappingExpression<TermSynonym,DocEntityTermSynonym> _DtoToEntity;

        public TermSynonymMapper()
        {
            CreateMap<DocEntitySet<DocEntityTermSynonym>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityTermSynonym,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityTermSynonym>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityTermSynonym.GetTermSynonym(c));
            _EntityToDto = CreateMap<DocEntityTermSynonym,TermSynonym>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TermSynonym>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TermSynonym>(c, "Updated")))
                .ForMember(dest => dest.Approved, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TermSynonym>(c, nameof(DocEntityTermSynonym.Approved))))
                .ForMember(dest => dest.Bindings, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TermSynonym>(c, nameof(DocEntityTermSynonym.Bindings))))
                .ForMember(dest => dest.BindingsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TermSynonym>(c, nameof(DocEntityTermSynonym.BindingsCount))))
                .ForMember(dest => dest.Master, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TermSynonym>(c, nameof(DocEntityTermSynonym.Master))))
                .ForMember(dest => dest.MasterId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TermSynonym>(c, nameof(DocEntityTermSynonym.MasterId))))
                .ForMember(dest => dest.Preferred, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TermSynonym>(c, nameof(DocEntityTermSynonym.Preferred))))
                .ForMember(dest => dest.Scope, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TermSynonym>(c, nameof(DocEntityTermSynonym.Scope))))
                .ForMember(dest => dest.ScopeId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TermSynonym>(c, nameof(DocEntityTermSynonym.ScopeId))))
                .ForMember(dest => dest.Synonym, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TermSynonym>(c, nameof(DocEntityTermSynonym.Synonym))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<TermSynonym,DocEntityTermSynonym>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}