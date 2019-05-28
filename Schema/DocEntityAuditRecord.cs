//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated by a T4 template. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Net;

using AutoMapper;

using Services.Core;
using Services.Db;
using Services.Dto;
using Services.Dto.internals;
using Services.Enums;

using ServiceStack;

using Xtensive.Orm;
namespace Services.Schema
{
    [TableMapping(DocConstantModelName.AUDITRECORD)]
    public partial class DocEntityAuditRecord : DocEntityBase
    {
        private const string AUDITRECORD_CACHE = "AuditRecordCache";
        public const ModelNameEnm CLASS_NAME = ModelNameEnm.AUDITRECORD;
        
        #region Constructor
        public DocEntityAuditRecord(Session session) : base(session) {}

        public DocEntityAuditRecord() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        protected override List<string> _select => __vf ?? (__vf = DocWebSession.GetTypeSelect(new AuditRecord()));

        #region Static Members
        public static DocEntityAuditRecord Get(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? Get(reference.Id) : null;
        }

        public static DocEntityAuditRecord Get(int? primaryKey)
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

        public static DocEntityAuditRecord Get(Guid hash)
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
        [Field]
        public string Action { get; set; }


        [Field]
        public DocEntityBackgroundTask BackgroundTask { get; set; }
        public int? BackgroundTaskId { get { return BackgroundTask?.Id; } private set { var noid = value; } }


        [Field(Nullable = false)]
        public DateTime ChangedOnDate { get; set; }


        [Field(Length = int.MaxValue)]
        public byte[] DataCompressed { get; set; }

        private string _Data;
        public string Data
        {
            get => _Data ?? (_Data = DocZip.Unzip(DataCompressed));
            set
            {
                _Data = value;
                DataCompressed = DocZip.Zip(_Data);
            }
        }


        [Field]
        public string DatabaseSessionId { get; set; }


        [Field]
        [Association(PairTo = nameof(DocEntityAuditDelta.Audit), OnOwnerRemove = OnRemoveAction.Deny, OnTargetRemove = OnRemoveAction.Deny)]
        public DocEntitySet<DocEntityAuditDelta> Deltas { get; private set; }


        public List<int> DeltasIds => Deltas.Select(e => e.Id).ToList();


        public int? DeltasCount { get { return Deltas.Count(); } private set { var noid = value; } }


        [Field]
        public int EntityId { get; set; }


        [Field]
        public string EntityType { get; set; }


        [Field]
        public int? EntityVersion { get; set; }


        [Field]
        [Association(PairTo = nameof(DocEntityEvent.AuditRecord), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityEvent> Events { get; private set; }


        public List<int> EventsIds => Events.Select(e => e.Id).ToList();


        public int? EventsCount { get { return Events.Count(); } private set { var noid = value; } }


        [Field]
        public DocEntityImpersonation Impersonation { get; set; }
        public int? ImpersonationId { get { return Impersonation?.Id; } private set { var noid = value; } }


        [Field]
        public int? TargetId { get; set; }


        [Field]
        public string TargetType { get; set; }


        [Field]
        public int? TargetVersion { get; set; }


        [Field]
        public DocEntityUser User { get; set; }
        public int? UserId { get { return User?.Id; } private set { var noid = value; } }


        [Field]
        public DocEntityUserSession UserSession { get; set; }
        public int? UserSessionId { get { return UserSession?.Id; } private set { var noid = value; } }


        [Field]
        public override string Gestalt { get; set; }

        [Field(DefaultValue = 0), Version(VersionMode.Manual)]
        public override int VersionNo { get; set; }

        [Field]
        public override DateTime? Created { get; set; }

        [Field]
        public override DateTime? Updated { get; set; }

        [Field(DefaultValue = false), FieldMapping(nameof(Locked))]
        public override bool Locked { get; set; }

        [Field(DefaultValue = false), FieldMapping(nameof(Archived))]
        public override bool Archived { get; set; }
        #endregion Properties

        #region Overrides of DocEntity

        public override ModelNameEnm ClassName => CLASS_NAME;

        public override DocConstantModelName TableName => CLASS_NAME.ToEnumString();

        public const string CACHE_KEY_PREFIX = "FindAuditRecords";

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
                Events.Clear(); //foreach thing in Events en.Remove();
            }
            catch(Exception ex)
            {
                throw new DocException("Failed to delete AuditRecord in Events delete", ex);
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
                throw new HttpError(HttpStatusCode.Conflict, $"AuditRecord requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();
            _validated = true;
        }

        public override IDocEntity SaveChanges(bool ignoreCache, DocConstantPermission permission)
        {
            Action = Action?.TrimAndPruneSpaces();
            DatabaseSessionId = DatabaseSessionId?.TrimAndPruneSpaces();
            EntityType = EntityType?.TrimAndPruneSpaces();
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

        public static explicit operator AuditRecord(DocEntityAuditRecord en) => en?.ToDto();
        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }
}
