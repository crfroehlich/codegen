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
    [TableMapping(DocConstantModelName.AUDITDELTA)]
    public partial class DocEntityAuditDelta : DocEntityBase
    {
        private const string AUDITDELTA_CACHE = "AuditDeltaCache";
        public const ModelNameEnm CLASS_NAME = ModelNameEnm.AUDITDELTA;
        
        #region Constructor
        public DocEntityAuditDelta(Session session) : base(session) {}

        public DocEntityAuditDelta() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        protected override List<string> _select => __vf ?? (__vf = DocWebSession.GetTypeSelect(new AuditDelta()));

        #region Static Members
        public static DocEntityAuditDelta Get(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? Get(reference.Id) : null;
        }

        public static DocEntityAuditDelta Get(int? primaryKey)
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

        public static DocEntityAuditDelta Get(Guid hash)
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
        public DocEntityAuditRecord Audit { get; set; }
        public int? AuditId { get { return Audit?.Id; } private set { var noid = value; } }


        [Field(Nullable = false, Length = int.MaxValue)]
        public byte[] DeltaCompressed { get; set; }

        private string _Delta;
        public string Delta
        {
            get => _Delta ?? (_Delta = DocZip.Unzip(DeltaCompressed));
            set
            {
                _Delta = value;
                DeltaCompressed = DocZip.Zip(_Delta);
            }
        }


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

        public const string CACHE_KEY_PREFIX = "FindAuditDeltas";

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
                throw new HttpError(HttpStatusCode.Conflict, $"AuditDelta requires: {ValidationMessage.Message}.");
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

        public static explicit operator AuditDelta(DocEntityAuditDelta en) => en?.ToDto();
        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }
}
