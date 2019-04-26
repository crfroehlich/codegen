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
    [TableMapping(DocConstantModelName.BACKGROUNDTASK)]
    public partial class DocEntityBackgroundTask : DocEntityBase
    {
        private const string BACKGROUNDTASK_CACHE = "BackgroundTaskCache";
        public const string TABLE_NAME = DocConstantModelName.BACKGROUNDTASK;
        
        #region Constructor
        public DocEntityBackgroundTask(Session session) : base(session) {}

        public DocEntityBackgroundTask() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        protected override List<string> _visibleFields => __vf ?? (__vf = DocWebSession.GetTypeVisibleFields(new BackgroundTask()));

        #region Static Members
        public static DocEntityBackgroundTask Get(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? Get(reference.Id) : null;
        }

        public static DocEntityBackgroundTask Get(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityBackgroundTask>.GetFromCache(primaryKey, BACKGROUNDTASK_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityBackgroundTask>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityBackgroundTask>.UpdateCache(ret.Id, ret, BACKGROUNDTASK_CACHE);
                    DocEntityThreadCache<DocEntityBackgroundTask>.UpdateCache(ret.Hash, ret, BACKGROUNDTASK_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityBackgroundTask Get(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityBackgroundTask>.GetFromCache(hash, BACKGROUNDTASK_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityBackgroundTask>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityBackgroundTask>.UpdateCache(ret.Id, ret, BACKGROUNDTASK_CACHE);
                    DocEntityThreadCache<DocEntityBackgroundTask>.UpdateCache(ret.Hash, ret, BACKGROUNDTASK_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field(Nullable = false)]
        public DocEntityApp App { get; set; }
        public int? AppId { get { return App?.Id; } private set { var noid = value; } }


        [Field]
        public DocEntityQueueChannel Channel { get; set; }
        public int? ChannelId { get { return Channel?.Id; } private set { var noid = value; } }


        [Field]
        public string Description { get; set; }


        [Field(Nullable = false, DefaultValue = true)]
        public bool Enabled { get; set; }


        [Field(DefaultValue = 60)]
        public int Frequency { get; set; }


        [Field(DefaultValue = 15)]
        public int? HistoryRetention { get; set; }


        [Field]
        [Association(PairTo = nameof(DocEntityBackgroundTaskItem.Task), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityBackgroundTaskItem> Items { get; private set; }


        public int? ItemsCount { get { return Items.Count(); } private set { var noid = value; } }


        [Field]
        public string LastRunVersion { get; set; }


        [Field(Nullable = false, DefaultValue = true)]
        public bool LogError { get; set; }


        [Field(Nullable = false, DefaultValue = false)]
        public bool LogInfo { get; set; }


        [Field(Nullable = false)]
        public string Name { get; set; }


        [Field]
        public int RowsToProcessPerIteration { get; set; }


        [Field(Nullable = false, DefaultValue = false)]
        public bool RunNow { get; set; }


        [Field(DefaultValue = "midnight")]
        public string StartAt { get; set; }


        [Field]
        [Association(PairTo = nameof(DocEntityBackgroundTaskHistory.Task), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear)]
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

        public const string CACHE_KEY_PREFIX = "FindBackgroundTasks";

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
                Items.Clear(); //foreach thing in Items en.Remove();
            }
            catch(Exception ex)
            {
                throw new DocException("Failed to delete BackgroundTask in Items delete", ex);
            }
            try
            {
                TaskHistory.Clear(); //foreach thing in TaskHistory en.Remove();
            }
            catch(Exception ex)
            {
                throw new DocException("Failed to delete BackgroundTask in TaskHistory delete", ex);
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
                throw new HttpError(HttpStatusCode.Conflict, $"BackgroundTask requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();
            _validated = true;
        }

        public override IDocEntity SaveChanges(bool ignoreCache, DocConstantPermission permission)
        {
            Description = Description?.TrimAndPruneSpaces();
            LastRunVersion = LastRunVersion?.TrimAndPruneSpaces();
            Name = Name?.TrimAndPruneSpaces();
            StartAt = StartAt?.TrimAndPruneSpaces();
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

                if(DocTools.IsNullOrEmpty(App))
                {
                    isValid = false;
                    message += " App is a required property.";
                }
                if(DocTools.IsNullOrEmpty(Enabled))
                {
                    isValid = false;
                    message += " Enabled is a required property.";
                }
                if(DocTools.IsNullOrEmpty(LogError))
                {
                    isValid = false;
                    message += " LogError is a required property.";
                }
                if(DocTools.IsNullOrEmpty(LogInfo))
                {
                    isValid = false;
                    message += " LogInfo is a required property.";
                }
                if(DocTools.IsNullOrEmpty(Name))
                {
                    isValid = false;
                    message += " Name is a required property.";
                }
                if(DocTools.IsNullOrEmpty(RunNow))
                {
                    isValid = false;
                    message += " RunNow is a required property.";
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Converters

        public BackgroundTask ToDto() => Mapper.Map<DocEntityBackgroundTask, BackgroundTask>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }
}
