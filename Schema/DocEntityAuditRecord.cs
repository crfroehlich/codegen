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
    [TableMapping(DocConstantModelName.AUDITRECORD)]
    public partial class DocEntityAuditRecord : DocEntityBase
    {
        private const string AUDITRECORD_CACHE = "AuditRecordCache";
        public const string TABLE_NAME = DocConstantModelName.AUDITRECORD;
        
        #region Constructor
        public DocEntityAuditRecord(Session session) : base(session) {}

        public DocEntityAuditRecord() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        #region VisibleFields

        protected override List<string> _visibleFields
        {
            get
            {
                if(null == __vf)
                {
                    __vf = DocWebSession.GetTypeVisibleFields(new AuditRecord());
                }
                return __vf;
            }
        }

        #endregion VisibleFields

        #region Static Members
        public static DocEntityAuditRecord GetAuditRecord(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetAuditRecord(reference.Id) : null;
        }

        public static DocEntityAuditRecord GetAuditRecord(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityAuditRecord>.GetFromCache(primaryKey, AUDITRECORD_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityAuditRecord>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityAuditRecord>.UpdateCache(ret.Id, ret, AUDITRECORD_CACHE);
                    DocEntityThreadCache<DocEntityAuditRecord>.UpdateCache(ret.Hash, ret, AUDITRECORD_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityAuditRecord GetAuditRecord(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityAuditRecord>.GetFromCache(hash, AUDITRECORD_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityAuditRecord>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityAuditRecord>.UpdateCache(ret.Id, ret, AUDITRECORD_CACHE);
                    DocEntityThreadCache<DocEntityAuditRecord>.UpdateCache(ret.Hash, ret, AUDITRECORD_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field()]
        [FieldMapping(nameof(Action))]
        public string Action { get; set; }


        [Field()]
        [FieldMapping(nameof(BackgroundTask))]
        public DocEntityBackgroundTask BackgroundTask { get; set; }
        public int? BackgroundTaskId { get { return BackgroundTask?.Id; } private set { var noid = value; } }


        [Field(Nullable = false)]
        [FieldMapping(nameof(ChangedOnDate))]
        public DateTime ChangedOnDate { get; set; }


        [Field(Length = int.MaxValue)]
        [FieldMapping(nameof(Data))]
        public string Data { get; set; }


        [Field()]
        [FieldMapping(nameof(DatabaseSessionId))]
        public string DatabaseSessionId { get; set; }


        [Field()]
        [FieldMapping(nameof(Deltas))]
        [Association(PairTo = nameof(DocEntityAuditDelta.Audit), OnOwnerRemove = OnRemoveAction.Deny, OnTargetRemove = OnRemoveAction.Deny)]
        public DocEntitySet<DocEntityAuditDelta> Deltas { get; private set; }


        public int? DeltasCount { get { return Deltas.Count(); } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(EntityId))]
        public int EntityId { get; set; }


        [Field()]
        [FieldMapping(nameof(EntityType))]
        public string EntityType { get; set; }


        [Field()]
        [FieldMapping(nameof(EntityVersion))]
        public int? EntityVersion { get; set; }


        [Field()]
        [FieldMapping(nameof(Impersonation))]
        public DocEntityImpersonation Impersonation { get; set; }
        public int? ImpersonationId { get { return Impersonation?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(TargetId))]
        public int? TargetId { get; set; }


        [Field()]
        [FieldMapping(nameof(TargetType))]
        public string TargetType { get; set; }


        [Field()]
        [FieldMapping(nameof(TargetVersion))]
        public int? TargetVersion { get; set; }


        [Field()]
        [FieldMapping(nameof(User))]
        public DocEntityUser User { get; set; }
        public int? UserId { get { return User?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(UserSession))]
        public DocEntityUserSession UserSession { get; set; }
        public int? UserSessionId { get { return UserSession?.Id; } private set { var noid = value; } }



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

        public const string CACHE_KEY_PREFIX = "FindAuditRecords";

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
                throw new HttpError(HttpStatusCode.Conflict, $"AuditRecord requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();

            FlushCache();

            _validated = true;


        }

        public override IDocEntity SaveChanges(DocConstantPermission permission = null)
        {
            Action = Action?.TrimAndPruneSpaces();
            DatabaseSessionId = DatabaseSessionId?.TrimAndPruneSpaces();
            EntityType = EntityType?.TrimAndPruneSpaces();
            TargetType = TargetType?.TrimAndPruneSpaces();
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

                if(DocTools.IsNullOrEmpty(ChangedOnDate))
                {
                    isValid = false;
                    message += " ChangedOnDate is a required property.";
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Converters

        public AuditRecord ToDto() => Mapper.Map<DocEntityAuditRecord, AuditRecord>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }

    public static partial class UniqueConstraintFilter
    {
        public static Expression<Func<DocEntityAuditRecord, bool>> AuditRecordIgnoreArchived() => d => d.Archived == false;
    }

    public partial class AuditRecordMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityAuditRecord,AuditRecord> _EntityToDto;
        protected IMappingExpression<AuditRecord,DocEntityAuditRecord> _DtoToEntity;

        public AuditRecordMapper()
        {
            CreateMap<DocEntitySet<DocEntityAuditRecord>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityAuditRecord,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityAuditRecord>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityAuditRecord.GetAuditRecord(c));
            _EntityToDto = CreateMap<DocEntityAuditRecord,AuditRecord>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<AuditRecord>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<AuditRecord>(c, "Updated")))
                .ForMember(dest => dest.Action, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<AuditRecord>(c, nameof(DocEntityAuditRecord.Action))))
                .ForMember(dest => dest.BackgroundTask, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<AuditRecord>(c, nameof(DocEntityAuditRecord.BackgroundTask))))
                .ForMember(dest => dest.BackgroundTaskId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<AuditRecord>(c, nameof(DocEntityAuditRecord.BackgroundTaskId))))
                .ForMember(dest => dest.ChangedOnDate, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<AuditRecord>(c, nameof(DocEntityAuditRecord.ChangedOnDate))))
                .ForMember(dest => dest.Data, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<AuditRecord>(c, nameof(DocEntityAuditRecord.Data))))
                .ForMember(dest => dest.DatabaseSessionId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<AuditRecord>(c, nameof(DocEntityAuditRecord.DatabaseSessionId))))
                .ForMember(dest => dest.Deltas, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<AuditRecord>(c, nameof(DocEntityAuditRecord.Deltas))))
                .ForMember(dest => dest.DeltasCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<AuditRecord>(c, nameof(DocEntityAuditRecord.DeltasCount))))
                .ForMember(dest => dest.EntityId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<AuditRecord>(c, nameof(DocEntityAuditRecord.EntityId))))
                .ForMember(dest => dest.EntityType, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<AuditRecord>(c, nameof(DocEntityAuditRecord.EntityType))))
                .ForMember(dest => dest.EntityVersion, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<AuditRecord>(c, nameof(DocEntityAuditRecord.EntityVersion))))
                .ForMember(dest => dest.Impersonation, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<AuditRecord>(c, nameof(DocEntityAuditRecord.Impersonation))))
                .ForMember(dest => dest.ImpersonationId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<AuditRecord>(c, nameof(DocEntityAuditRecord.ImpersonationId))))
                .ForMember(dest => dest.TargetId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<AuditRecord>(c, nameof(DocEntityAuditRecord.TargetId))))
                .ForMember(dest => dest.TargetType, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<AuditRecord>(c, nameof(DocEntityAuditRecord.TargetType))))
                .ForMember(dest => dest.TargetVersion, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<AuditRecord>(c, nameof(DocEntityAuditRecord.TargetVersion))))
                .ForMember(dest => dest.User, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<AuditRecord>(c, nameof(DocEntityAuditRecord.User))))
                .ForMember(dest => dest.UserId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<AuditRecord>(c, nameof(DocEntityAuditRecord.UserId))))
                .ForMember(dest => dest.UserSession, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<AuditRecord>(c, nameof(DocEntityAuditRecord.UserSession))))
                .ForMember(dest => dest.UserSessionId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<AuditRecord>(c, nameof(DocEntityAuditRecord.UserSessionId))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<AuditRecord,DocEntityAuditRecord>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
