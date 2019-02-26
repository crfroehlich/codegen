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
    [TableMapping(DocConstantModelName.AUDITDELTA)]
    public partial class DocEntityAuditDelta : DocEntityBase
    {
        private const string AUDITDELTA_CACHE = "AuditDeltaCache";
        public const string TABLE_NAME = DocConstantModelName.AUDITDELTA;
        
        #region Constructor
        public DocEntityAuditDelta(Session session) : base(session) {}

        public DocEntityAuditDelta() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        #region VisibleFields

        protected override List<string> _visibleFields
        {
            get
            {
                if(null == __vf)
                {
                    __vf = DocWebSession.GetTypeVisibleFields(new AuditDelta());
                }
                return __vf;
            }
        }

        #endregion VisibleFields

        #region Static Members
        public static DocEntityAuditDelta GetAuditDelta(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetAuditDelta(reference.Id) : null;
        }

        public static DocEntityAuditDelta GetAuditDelta(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityAuditDelta>.GetFromCache(primaryKey, AUDITDELTA_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityAuditDelta>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityAuditDelta>.UpdateCache(ret.Id, ret, AUDITDELTA_CACHE);
                    DocEntityThreadCache<DocEntityAuditDelta>.UpdateCache(ret.Hash, ret, AUDITDELTA_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityAuditDelta GetAuditDelta(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityAuditDelta>.GetFromCache(hash, AUDITDELTA_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityAuditDelta>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityAuditDelta>.UpdateCache(ret.Id, ret, AUDITDELTA_CACHE);
                    DocEntityThreadCache<DocEntityAuditDelta>.UpdateCache(ret.Hash, ret, AUDITDELTA_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field(Nullable = false)]
        [FieldMapping(nameof(Audit))]
        public DocEntityAuditRecord Audit { get; set; }
        public int? AuditId { get { return Audit?.Id; } private set { var noid = value; } }


        [Field(Nullable = false, Length = int.MaxValue)]
        [FieldMapping(nameof(Delta))]
        public string Delta { get; set; }



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

        public const string CACHE_KEY_PREFIX = "FindAuditDeltas";

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
                throw new HttpError(HttpStatusCode.Conflict, $"AuditDelta requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();

            FlushCache();

            _validated = true;

        }

        public override IDocEntity SaveChanges(DocConstantPermission permission = null)
        {
            return base.SaveChanges(permission);
        }

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

                if(DocTools.IsNullOrEmpty(Audit))
                {
                    isValid = false;
                    message += " Audit is a required property.";
                }
                if(DocTools.IsNullOrEmpty(Delta))
                {
                    isValid = false;
                    message += " Delta is a required property.";
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Converters

        public AuditDelta ToDto() => Mapper.Map<DocEntityAuditDelta, AuditDelta>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }

    public static partial class UniqueConstraintFilter
    {
        public static Expression<Func<DocEntityAuditDelta, bool>> AuditDeltaIgnoreArchived() => d => d.Archived == false;
    }

    public partial class AuditDeltaMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityAuditDelta,AuditDelta> _EntityToDto;
        protected IMappingExpression<AuditDelta,DocEntityAuditDelta> _DtoToEntity;

        public AuditDeltaMapper()
        {
            CreateMap<DocEntitySet<DocEntityAuditDelta>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityAuditDelta,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityAuditDelta>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityAuditDelta.GetAuditDelta(c));
            _EntityToDto = CreateMap<DocEntityAuditDelta,AuditDelta>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<AuditDelta>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<AuditDelta>(c, "Updated")))
                .ForMember(dest => dest.Audit, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<AuditDelta>(c, nameof(DocEntityAuditDelta.Audit))))
                .ForMember(dest => dest.AuditId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<AuditDelta>(c, nameof(DocEntityAuditDelta.AuditId))))
                .ForMember(dest => dest.Delta, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<AuditDelta>(c, nameof(DocEntityAuditDelta.Delta))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<AuditDelta,DocEntityAuditDelta>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}