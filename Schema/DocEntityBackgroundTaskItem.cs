
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
    [TableMapping(DocConstantModelName.BACKGROUNDTASKITEM)]
    public partial class DocEntityBackgroundTaskItem : DocEntityBase
    {
        private const string BACKGROUNDTASKITEM_CACHE = "BackgroundTaskItemCache";
        public const ModelNameEnm CLASS_NAME = ModelNameEnm.BACKGROUNDTASKITEM;
        
        #region Constructor
        public DocEntityBackgroundTaskItem(Session session) : base(session) {}

        public DocEntityBackgroundTaskItem() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        protected override List<string> _select => __vf ?? (__vf = DocWebSession.GetTypeSelect(new BackgroundTaskItem()));

        #region Static Members
        public static DocEntityBackgroundTaskItem Get(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? Get(reference.Id) : null;
        }

        public static DocEntityBackgroundTaskItem Get(int? primaryKey, bool noCache, DocQuery query)
        {
            if(!(primaryKey > 0)) return null;
            return query.SelectAll<DocEntityBackgroundTaskItem>().FirstOrDefault(e => e.Id == primaryKey.Value);
        }

        public static DocEntityBackgroundTaskItem Get(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityBackgroundTaskItem>.GetFromCache(primaryKey, BACKGROUNDTASKITEM_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityBackgroundTaskItem>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityBackgroundTaskItem>.UpdateCache(ret.Id, ret, BACKGROUNDTASKITEM_CACHE);
                    DocEntityThreadCache<DocEntityBackgroundTaskItem>.UpdateCache(ret.Hash, ret, BACKGROUNDTASKITEM_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityBackgroundTaskItem Get(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityBackgroundTaskItem>.GetFromCache(hash, BACKGROUNDTASKITEM_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityBackgroundTaskItem>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityBackgroundTaskItem>.UpdateCache(ret.Id, ret, BACKGROUNDTASKITEM_CACHE);
                    DocEntityThreadCache<DocEntityBackgroundTaskItem>.UpdateCache(ret.Hash, ret, BACKGROUNDTASKITEM_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field(DefaultValue = 0)]
        public int? Attempts { get; set; }


        [Field]
        public DocEntityAuditRecord AuditRecord { get; set; }
        public int? AuditRecordId { get { return AuditRecord?.Id; } private set { var noid = value; } }


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
        public string Description { get; set; }


        [Field]
        public DateTime? Ended { get; set; }


        [Field]
        public int? EntityId { get; set; }


        [Field]
        public string ExecutionTime { get; set; }


        [Field]
        public DateTime? Started { get; set; }


        [Field]
        public string Status { get; set; }


        [Field(DefaultValue = false)]
        public bool Succeeded { get; set; }


        [Field(Nullable = false)]
        public DocEntityBackgroundTask Task { get; set; }
        public int? TaskId { get { return Task?.Id; } private set { var noid = value; } }


        [Field]
        public DocEntitySet<DocEntityBackgroundTaskHistory> TaskHistory { get; private set; }


        public List<int> TaskHistoryIds => TaskHistory.Select(e => e.Id).ToList();


        public int? TaskHistoryCount { get { return TaskHistory.Count(); } private set { var noid = value; } }



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

        public const string CACHE_KEY_PREFIX = "FindBackgroundTaskItems";

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
                throw new HttpError(HttpStatusCode.Conflict, $"BackgroundTaskItem requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();
            _validated = true;
        }

        public override IDocEntity SaveChanges(bool ignoreCache, DocConstantPermission permission)
        {
            Description = Description?.TrimAndPruneSpaces();
            ExecutionTime = ExecutionTime?.TrimAndPruneSpaces();
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

                if(DocTools.IsNullOrEmpty(Task))
                {
                    isValid = false;
                    message += " Task is a required property.";
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Converters

        public BackgroundTaskItem ToDto() => Mapper.Map<DocEntityBackgroundTaskItem, BackgroundTaskItem>(this);

        public static explicit operator BackgroundTaskItem(DocEntityBackgroundTaskItem en) => en?.ToDto();

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }
}
