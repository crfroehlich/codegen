//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated by a T4 template. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.CodeDom.Compiler;
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
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private const string BACKGROUNDTASKITEM_CACHE = "BackgroundTaskItemCache";
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public  const ModelNameEnm CLASS_NAME = ModelNameEnm.BACKGROUNDTASKITEM;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocEntityBackgroundTaskItem(Session session) : base(session) {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocEntityBackgroundTaskItem() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        protected override List<string> _select => __vf ?? (__vf = DocWebSession.GetTypeSelect(new BackgroundTaskItem()));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public new static DocEntityBackgroundTaskItem Get(Reference reference) => (true == (reference?.Id > 0)) ? Get(reference.Id) : null;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public new static DocEntityBackgroundTaskItem Get(int? primaryKey, bool noCache, DocQuery query)
        {
            if(!(primaryKey > 0)) return null;
            return query.SelectAll<DocEntityBackgroundTaskItem>().FirstOrDefault(e => e.Id == primaryKey.Value);
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public new static DocEntityBackgroundTaskItem Get(int? primaryKey)
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
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
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

        [Field(DefaultValue = 0)]
        public int? Attempts { get; set; }


        [Field]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocEntityAuditRecord AuditRecord { get; set; }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? AuditRecordId { get { return AuditRecord?.Id; } private set { var noid = value; } }


        [Field(Length = int.MaxValue)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public byte[] DataCompressed { get; set; }

        private string _Data;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
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
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocEntityBackgroundTask Task { get; set; }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? TaskId { get { return Task?.Id; } private set { var noid = value; } }


        [Field]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocEntitySet<DocEntityBackgroundTaskHistory> TaskHistory { get; private set; }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> TaskHistoryIds => TaskHistory.Select(e => e.Id).ToList();
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? TaskHistoryCount { get { return TaskHistory.Count(); } private set { var noid = value; } }



        [Field]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override string Gestalt { get; set; }

        [Field(DefaultValue = 0), Version(VersionMode.Manual)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override int VersionNo { get; set; }

        [Field]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override DateTime? Created { get; set; }

        [Field]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override DateTime? Updated { get; set; }

        [Field(DefaultValue = false), FieldMapping(nameof(Locked))]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override bool Locked { get; set; }

        [Field(DefaultValue = false), FieldMapping(nameof(Archived))]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override bool Archived { get; set; }

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override ModelNameEnm ClassName => CLASS_NAME;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override DocConstantModelName TableName => CLASS_NAME.ToEnumString();
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public const string CACHE_KEY_PREFIX = "FindBackgroundTaskItems";

        /// <summary>
        ///    Called when entity is about to be removed.
        /// </summary>
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        protected override void OnRemoving()
        {
            base.OnRemoving();

            FlushCache();
        }

        /// <summary>
        ///    Called when entity should be validated. Override this method to perform custom object validation.
        /// </summary>
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        protected override void OnValidate()
        {
            if (false == ValidationMessage.IsValid)
            {
                throw new HttpError(HttpStatusCode.Conflict, $"BackgroundTaskItem requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();
            _validated = true;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override IDocEntity SaveChanges(bool ignoreCache, DocConstantPermission permission)
        {
            Description = Description?.TrimAndPruneSpaces();
            ExecutionTime = ExecutionTime?.TrimAndPruneSpaces();
            Status = Status?.TrimAndPruneSpaces();
            return base.SaveChanges(ignoreCache, permission);
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override IDocEntity SaveChanges(bool ignoreCache) => SaveChanges(ignoreCache, DocConstantPermission.EDIT);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override IDocEntity SaveChanges(DocConstantPermission permission) => SaveChanges(false, DocConstantPermission.EDIT);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override IDocEntity SaveChanges() => SaveChanges(DocConstantPermission.EDIT);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override void FlushCache()
        {
            base.FlushCache();

        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
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
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public BackgroundTaskItem ToDto() => Mapper.Map<DocEntityBackgroundTaskItem, BackgroundTaskItem>(this);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static explicit operator BackgroundTaskItem(DocEntityBackgroundTaskItem en) => en?.ToDto();

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override IDto ToIDto() => ToDto();
    }
}
