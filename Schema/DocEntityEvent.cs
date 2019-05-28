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
    [TableMapping(DocConstantModelName.EVENT)]
    public partial class DocEntityEvent : DocEntityBase
    {
        private const string EVENT_CACHE = "EventCache";
        public const ModelNameEnm CLASS_NAME = ModelNameEnm.EVENT;
        
        #region Constructor
        public DocEntityEvent(Session session) : base(session) {}

        public DocEntityEvent() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        protected override List<string> _select => __vf ?? (__vf = DocWebSession.GetTypeSelect(new Event()));

        #region Static Members
        public static DocEntityEvent Get(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? Get(reference.Id) : null;
        }

        public static DocEntityEvent Get(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityEvent>.GetFromCache(primaryKey, EVENT_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityEvent>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityEvent>.UpdateCache(ret.Id, ret, EVENT_CACHE);
                    DocEntityThreadCache<DocEntityEvent>.UpdateCache(ret.Hash, ret, EVENT_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityEvent Get(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityEvent>.GetFromCache(hash, EVENT_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityEvent>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityEvent>.UpdateCache(ret.Id, ret, EVENT_CACHE);
                    DocEntityThreadCache<DocEntityEvent>.UpdateCache(ret.Hash, ret, EVENT_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field(Nullable = false)]
        public DocEntityAuditRecord AuditRecord { get; set; }
        public int? AuditRecordId { get { return AuditRecord?.Id; } private set { var noid = value; } }


        [Field]
        public string Description { get; set; }


        [Field]
        public DateTime? Processed { get; set; }


        [Field]
        public string Status { get; set; }


        [Field]
        public DocEntitySet<DocEntityTeam> Teams { get; private set; }


        public List<int> TeamsIds => Teams.Select(e => e.Id).ToList();


        public int? TeamsCount { get { return Teams.Count(); } private set { var noid = value; } }


        [Field]
        public DocEntitySet<DocEntityUpdate> Updates { get; private set; }


        public List<int> UpdatesIds => Updates.Select(e => e.Id).ToList();


        public int? UpdatesCount { get { return Updates.Count(); } private set { var noid = value; } }


        [Field]
        public DocEntitySet<DocEntityUser> Users { get; private set; }


        public List<int> UsersIds => Users.Select(e => e.Id).ToList();


        public int? UsersCount { get { return Users.Count(); } private set { var noid = value; } }


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

        public const string CACHE_KEY_PREFIX = "FindEvents";

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
                throw new HttpError(HttpStatusCode.Conflict, $"Event requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();
            _validated = true;
        }

        public override IDocEntity SaveChanges(bool ignoreCache, DocConstantPermission permission)
        {
            Description = Description?.TrimAndPruneSpaces();
            Status = Status?.TrimAndPruneSpaces();
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

                if(DocTools.IsNullOrEmpty(AuditRecord))
                {
                    isValid = false;
                    message += " AuditRecord is a required property.";
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Converters

        public Event ToDto() => Mapper.Map<DocEntityEvent, Event>(this);

        public static explicit operator Event(DocEntityEvent en) => en?.ToDto();
        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }
}
