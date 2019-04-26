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
using System.Reflection;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using Services.Core;
using Services.Db;
using Services.Dto;
using Services.Dto.internals;
using Services.Dto.Security;
using Services.Enums;
using Services.Models;
using Services.Schema;

using ServiceStack;
using ServiceStack.Text;

using Typed;
using Typed.Bindings;
using Typed.Notifications;
using Typed.Settings;

using Xtensive.Orm;
using Xtensive.Orm.Model;

using Attribute = Services.Dto.Attribute;
using ValueType = Services.Dto.ValueType;
using Version = Services.Dto.Version;
namespace Services.Schema
{
    [TableMapping(DocConstantModelName.BACKGROUNDTASKITEM)]
    public partial class DocEntityBackgroundTaskItem : DocEntityBase
    {
        private const string BACKGROUNDTASKITEM_CACHE = "BackgroundTaskItemCache";
        public const string TABLE_NAME = DocConstantModelName.BACKGROUNDTASKITEM;
        
        #region Constructor
        public DocEntityBackgroundTaskItem(Session session) : base(session) {}

        public DocEntityBackgroundTaskItem() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        protected override List<string> _visibleFields => __vf ?? (__vf = DocWebSession.GetTypeVisibleFields(new BackgroundTaskItem()));

        #region Static Members
        public static DocEntityBackgroundTaskItem GetBackgroundTaskItem(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetBackgroundTaskItem(reference.Id) : null;
        }

        public static DocEntityBackgroundTaskItem GetBackgroundTaskItem(int? primaryKey)
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

        public static DocEntityBackgroundTaskItem GetBackgroundTaskItem(Guid hash)
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

        public override DocConstantModelName TableName => TABLE_NAME;

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

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }
}
