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
    [TableMapping(DocConstantModelName.BACKGROUNDTASK)]
    public partial class DocEntityBackgroundTask : DocEntityBase
    {
        private const string BACKGROUNDTASK_CACHE = "BackgroundTaskCache";

        #region Constructor
        public DocEntityBackgroundTask(Session session) : base(session) {}

        public DocEntityBackgroundTask() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        #region VisibleFields
        private List<string> __vf;
        private List<string> _visibleFields
        {
            get
            {
                if(null == __vf)
                {
                    __vf = DocWebSession.GetTypeVisibleFields(new BackgroundTask());
                }
                return __vf;
            }
        }
        
        public bool IsPropertyVisible(string propertyName)
        {
            return _visibleFields.Count == 0 || _visibleFields.Any(v => DocTools.AreEqual(v, propertyName));
        }
        #endregion VisibleFields

        #region Static Members
        public static DocEntityBackgroundTask GetBackgroundTask(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetBackgroundTask(reference.Id) : null;
        }

        public static DocEntityBackgroundTask GetBackgroundTask(int? primaryKey)
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

        public static DocEntityBackgroundTask GetBackgroundTask(Guid hash)
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
        [FieldMapping(nameof(App))]
        public DocEntityApp App { get; set; }
        public int? AppId { get { return App?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Channel))]
        public DocEntityQueueChannel Channel { get; set; }
        public int? ChannelId { get { return Channel?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Description))]
        public string Description { get; set; }


        [Field(Nullable = false, DefaultValue = true)]
        [FieldMapping(nameof(Enabled))]
        public bool Enabled { get; set; }


        [Field(DefaultValue = 60)]
        [FieldMapping(nameof(Frequency))]
        public int Frequency { get; set; }


        [Field(DefaultValue = 15)]
        [FieldMapping(nameof(HistoryRetention))]
        public int? HistoryRetention { get; set; }


        [Field()]
        [FieldMapping(nameof(Items))]
        [Association( PairTo = nameof(BackgroundTaskItem.Task), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear )]
        public DocEntitySet<DocEntityBackgroundTaskItem> Items { get; private set; }


        public int? ItemsCount { get { return Items.Count(); } private set { var noid = value; } }


        [Field(DefaultValue = "")]
        [FieldMapping(nameof(LastRunVersion))]
        public string LastRunVersion { get; set; }


        [Field(Nullable = false, DefaultValue = true)]
        [FieldMapping(nameof(LogError))]
        public bool LogError { get; set; }


        [Field(Nullable = false, DefaultValue = false)]
        [FieldMapping(nameof(LogInfo))]
        public bool LogInfo { get; set; }


        [Field(Nullable = false)]
        [FieldMapping(nameof(Name))]
        public string Name { get; set; }


        [Field()]
        [FieldMapping(nameof(RowsToProcessPerIteration))]
        public int RowsToProcessPerIteration { get; set; }


        [Field(Nullable = false, DefaultValue = false)]
        [FieldMapping(nameof(RunNow))]
        public bool RunNow { get; set; }


        [Field(DefaultValue = "midnight")]
        [FieldMapping(nameof(StartAt))]
        public string StartAt { get; set; }


        [Field()]
        [FieldMapping(nameof(TaskHistory))]
        [Association( PairTo = nameof(BackgroundTaskHistory.Task), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear )]
        public DocEntitySet<DocEntityBackgroundTaskHistory> TaskHistory { get; private set; }


        public int? TaskHistoryCount { get { return TaskHistory.Count(); } private set { var noid = value; } }



        [Field(LazyLoad = false, Length = Int32.MaxValue)]
        public override string Gestalt { get; set; }

        [Field]
        public override Guid Hash { get; set; }

        [Field(DefaultValue = 0), Version(VersionMode.Manual)]
        public override int VersionNo { get; set; }

        [Field]
        public override DateTime? Created { get; set; }

        [Field]
        public override DateTime? Updated { get; set; }

        [Field]
        public override bool Locked { get; set; }
        private bool? _isNewlyLocked;
        private bool? _isModified;
        
        private List<string> __editableFields;
        private List<string> _editableFields 
        {
            get
            {
                if (null == __editableFields)
                {
                    __editableFields = _GetEditableFields();
                }
                return __editableFields;
            }
        }
        #endregion Properties

        #region Overrides of DocEntity
        public static readonly DocConstantModelName MODEL_NAME = DocConstantModelName.BACKGROUNDTASK;

        public override DocConstantModelName ModelName => MODEL_NAME;

        public const string CACHE_KEY_PREFIX = "FindBackgroundTasks";


        public override T ToModel<T>() =>  null;

        #endregion Overrides of DocEntity

        #region Entity overrides
        protected override object AdjustFieldValue(FieldInfo fieldInfo, object oldValue, object newValue)
        {
            if (!Locked || true == _isNewlyLocked || _editableFields.Any(f => f == fieldInfo.Name))
            {
                return base.AdjustFieldValue(fieldInfo, oldValue, newValue);
            }
            else
            {
                return oldValue;
            }
        }

        ///    Called before field value is about to be changed. This event is raised only on actual change attempt (i.e. when new value differs from the current one).
        protected override void OnSettingFieldValue(FieldInfo fieldInfo, object value)
        {
            if (_OnSettingFieldValue(fieldInfo, value) && (!Locked || true == _isNewlyLocked || _editableFields.Any(f => f == fieldInfo.Name)))
            {
                base.OnSettingFieldValue(fieldInfo, value);
            }
        }

        /// <summary>
        ///    Called when field value has been changed.
        /// </summary>
        protected override void OnSetFieldValue(FieldInfo fieldInfo, object oldValue, object newValue)
        {
            if (fieldInfo.Name == nameof(Locked) && true == DocConvert.ToBool(newValue)) 
            {
                _isNewlyLocked = true;
            }
            if (fieldInfo.Name != nameof(Locked) && fieldInfo.Name != nameof(Hash) && fieldInfo.Name != nameof(Id) && fieldInfo.Name != nameof(VersionNo) && fieldInfo.Name != nameof(Gestalt) && fieldInfo.Name != nameof(Created) && fieldInfo.Name != nameof(Updated))
            {
                _isModified = true;
            }
            if (_OnSetFieldValue(fieldInfo, oldValue, newValue) && (!Locked || true == _isNewlyLocked || _editableFields.Any(f => f == fieldInfo.Name)))
            {
                base.OnSetFieldValue(fieldInfo, oldValue, newValue);
            }
        }

        /// <summary>
        ///    Called when entity is about to be removed.
        /// </summary>
        protected override void OnRemoving()
        {
            if (Locked) throw new ServiceStack.HttpError(System.Net.HttpStatusCode.Forbidden, $"Locked records cannot be deleted.");
            if (!DocPermissionFactory.HasPermission(this, null, DocConstantPermission.DELETE))
            {
                throw new ServiceStack.HttpError(System.Net.HttpStatusCode.Forbidden, $"You do not have permission to delete this {ModelName}.");
            }

            _OnRemoving();
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
            base.OnRemoving();
        }

        /// <summary>
        ///    Called after entity marked as removed.
        /// </summary>
        protected override void OnRemove()
        {
            _OnRemove();
            base.OnRemove();
            FlushCache();
        }

        private bool _validated = false;

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

            FlushCache();

            _validated = true;

        }

        public override IDocEntity SaveChanges(DocConstantPermission permission = null)
        {
            var hash = GetGuid();
            if(Hash != hash)
                Hash = hash;

            Description = Description?.TrimAndPruneSpaces();
            LastRunVersion = LastRunVersion?.TrimAndPruneSpaces();
            Name = Name?.TrimAndPruneSpaces();
            StartAt = StartAt?.TrimAndPruneSpaces();

            if (DocTools.IsNullOrEmpty(Created))
            {
                Created = DateTime.UtcNow;
            }
            if (DocTools.IsNullOrEmpty(Updated))
            {
                Updated = Created;
            }
            if (true == _isModified)
            {
                Updated = DateTime.UtcNow;
                VersionNo += 1;
                _OnIsModified();
                _isModified = null;
            }

            _OnSaveChanges(permission);

            if(!_validated)
                OnValidate();

            _OnSetGestalt();

            //Only do permissions checks AFTER validation has finished to get better errors
            //The transaction still hasn't completed, so if we throw then the rollback will work as expected
            permission = permission ?? DocConstantPermission.EDIT;
            if(!DocPermissionFactory.HasPermission(this, null, permission))
            {
                throw new ServiceStack.HttpError(System.Net.HttpStatusCode.Forbidden, $"You do not have permission to {permission} this {ModelName}.");
            }

            return this;
        }

        public override bool UnlockRecord()
        {
            var ret = DocPermissionFactory.HasPermission(this, null, DocConstantPermission.UNLOCK);
            _OnUnlock();
            if (!ret) throw new ServiceStack.HttpError(System.Net.HttpStatusCode.Forbidden, $"You do not have permission to unlock this {nameof(BackgroundTask)}");
            if (ret)
            {
                _isNewlyLocked = true;
                Locked = false;
            }
            return ret;
        }

        public void FlushCache()
        {
            _OnFlushCache();
            DocCacheClient.RemoveSearch("BackgroundTask");
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

        #region Hash
        
        public static Guid GetGuid(DocEntityBackgroundTask thing)
        {
            if(thing == null) return Guid.Empty;
            return thing.GetGuid();
        }

        /// <summary>
        ///    Get Hash Code
        /// </summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
        public override Guid GetGuid(bool forceRefresh = false)
        {
            return GetGuid(this);
        }
        #endregion Hash

        #region Converters
        public override string ToString() => _ToString();

        public override Reference ToReference()
        {
            var ret = new Reference(Id, Name , Gestalt);
            return _ToReference(ret);
        }

        public BackgroundTask ToDto() => Mapper.Map<DocEntityBackgroundTask, BackgroundTask>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }

    public partial class BackgroundTaskMapper : DocMapperBase
    {
        private IMappingExpression<DocEntityBackgroundTask,BackgroundTask> _EntityToDto;
        private IMappingExpression<BackgroundTask,DocEntityBackgroundTask> _DtoToEntity;

        public BackgroundTaskMapper()
        {
            CreateMap<DocEntitySet<DocEntityBackgroundTask>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityBackgroundTask,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityBackgroundTask>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityBackgroundTask.GetBackgroundTask(c));
            _EntityToDto = CreateMap<DocEntityBackgroundTask,BackgroundTask>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTask>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTask>(c, "Updated")))
                .ForMember(dest => dest.App, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTask>(c, nameof(DocEntityBackgroundTask.App))))
                .ForMember(dest => dest.AppId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTask>(c, nameof(DocEntityBackgroundTask.AppId))))
                .ForMember(dest => dest.Channel, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTask>(c, nameof(DocEntityBackgroundTask.Channel))))
                .ForMember(dest => dest.ChannelId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTask>(c, nameof(DocEntityBackgroundTask.ChannelId))))
                .ForMember(dest => dest.Description, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTask>(c, nameof(DocEntityBackgroundTask.Description))))
                .ForMember(dest => dest.Enabled, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTask>(c, nameof(DocEntityBackgroundTask.Enabled))))
                .ForMember(dest => dest.Frequency, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTask>(c, nameof(DocEntityBackgroundTask.Frequency))))
                .ForMember(dest => dest.HistoryRetention, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTask>(c, nameof(DocEntityBackgroundTask.HistoryRetention))))
                .ForMember(dest => dest.Items, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTask>(c, nameof(DocEntityBackgroundTask.Items))))
                .ForMember(dest => dest.ItemsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTask>(c, nameof(DocEntityBackgroundTask.ItemsCount))))
                .ForMember(dest => dest.LastRunVersion, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTask>(c, nameof(DocEntityBackgroundTask.LastRunVersion))))
                .ForMember(dest => dest.LogError, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTask>(c, nameof(DocEntityBackgroundTask.LogError))))
                .ForMember(dest => dest.LogInfo, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTask>(c, nameof(DocEntityBackgroundTask.LogInfo))))
                .ForMember(dest => dest.Name, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTask>(c, nameof(DocEntityBackgroundTask.Name))))
                .ForMember(dest => dest.RowsToProcessPerIteration, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTask>(c, nameof(DocEntityBackgroundTask.RowsToProcessPerIteration))))
                .ForMember(dest => dest.RunNow, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTask>(c, nameof(DocEntityBackgroundTask.RunNow))))
                .ForMember(dest => dest.StartAt, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTask>(c, nameof(DocEntityBackgroundTask.StartAt))))
                .ForMember(dest => dest.TaskHistory, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTask>(c, nameof(DocEntityBackgroundTask.TaskHistory))))
                .ForMember(dest => dest.TaskHistoryCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTask>(c, nameof(DocEntityBackgroundTask.TaskHistoryCount))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<BackgroundTask,DocEntityBackgroundTask>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}