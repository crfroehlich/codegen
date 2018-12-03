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
    [TableMapping(DocConstantModelName.BACKGROUNDTASKHISTORY)]
    public partial class DocEntityBackgroundTaskHistory : DocEntityBase
    {
        private const string BACKGROUNDTASKHISTORY_CACHE = "BackgroundTaskHistoryCache";

        #region Constructor
        public DocEntityBackgroundTaskHistory(Session session) : base(session) {}

        public DocEntityBackgroundTaskHistory() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        #region VisibleFields
        private List<string> __vf;
        private List<string> _visibleFields
        {
            get
            {
                if(null == __vf)
                {
                    __vf = DocWebSession.GetTypeVisibleFields(new BackgroundTaskHistory());
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
        public static DocEntityBackgroundTaskHistory GetBackgroundTaskHistory(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetBackgroundTaskHistory(reference.Id) : null;
        }

        public static DocEntityBackgroundTaskHistory GetBackgroundTaskHistory(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityBackgroundTaskHistory>.GetFromCache(primaryKey, BACKGROUNDTASKHISTORY_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityBackgroundTaskHistory>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityBackgroundTaskHistory>.UpdateCache(ret.Id, ret, BACKGROUNDTASKHISTORY_CACHE);
                    DocEntityThreadCache<DocEntityBackgroundTaskHistory>.UpdateCache(ret.Hash, ret, BACKGROUNDTASKHISTORY_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityBackgroundTaskHistory GetBackgroundTaskHistory(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityBackgroundTaskHistory>.GetFromCache(hash, BACKGROUNDTASKHISTORY_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityBackgroundTaskHistory>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityBackgroundTaskHistory>.UpdateCache(ret.Id, ret, BACKGROUNDTASKHISTORY_CACHE);
                    DocEntityThreadCache<DocEntityBackgroundTaskHistory>.UpdateCache(ret.Hash, ret, BACKGROUNDTASKHISTORY_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field(DefaultValue = 0)]
        [FieldMapping(nameof(Completed))]
        public int? Completed { get; set; }


        [Field(Length = int.MaxValue)]
        [FieldMapping(nameof(Data))]
        public string Data { get; set; }


        [Field()]
        [FieldMapping(nameof(Ended))]
        public DateTime? Ended { get; set; }


        [Field(Length = int.MaxValue)]
        [FieldMapping(nameof(Errors))]
        public string Errors { get; set; }


        [Field(DefaultValue = 0)]
        [FieldMapping(nameof(Failed))]
        public int? Failed { get; set; }


        [Field()]
        [FieldMapping(nameof(Items))]
        [Association( PairTo = nameof(BackgroundTaskItem.TaskHistory), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear )]
        public DocEntitySet<DocEntityBackgroundTaskItem> Items { get; private set; }


        public int? ItemsCount { get { return Items.Count(); } private set { var noid = value; } }


        [Field(Length = int.MaxValue)]
        [FieldMapping(nameof(Logs))]
        public string Logs { get; set; }


        [Field(DefaultValue = false)]
        [FieldMapping(nameof(Succeeded))]
        public bool Succeeded { get; set; }


        [Field(Length = int.MaxValue)]
        [FieldMapping(nameof(Summary))]
        public string Summary { get; set; }


        [Field(Nullable = false)]
        [FieldMapping(nameof(Task))]
        public DocEntityBackgroundTask Task { get; set; }
        public int? TaskId { get { return Task?.Id; } private set { var noid = value; } }



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
        public static readonly DocConstantModelName MODEL_NAME = DocConstantModelName.BACKGROUNDTASKHISTORY;

        public override DocConstantModelName ModelName => MODEL_NAME;

        public const string CACHE_KEY_PREFIX = "FindBackgroundTaskHistorys";


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
                throw new DocException("Failed to delete BackgroundTaskHistory in Items delete", ex);
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
                throw new HttpError(HttpStatusCode.Conflict, $"BackgroundTaskHistory requires: {ValidationMessage.Message}.");
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
            if (!ret) throw new ServiceStack.HttpError(System.Net.HttpStatusCode.Forbidden, $"You do not have permission to unlock this {nameof(BackgroundTaskHistory)}");
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
            DocCacheClient.RemoveSearch("BackgroundTaskHistory");
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

        #region Hash
        
        public static Guid GetGuid(DocEntityBackgroundTaskHistory thing)
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
            var ret = new Reference(Id, "", Gestalt);
            return _ToReference(ret);
        }

        public BackgroundTaskHistory ToDto() => Mapper.Map<DocEntityBackgroundTaskHistory, BackgroundTaskHistory>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }

    public partial class BackgroundTaskHistoryMapper : Profile
    {
        private IMappingExpression<DocEntityBackgroundTaskHistory,BackgroundTaskHistory> _EntityToDto;
        private IMappingExpression<BackgroundTaskHistory,DocEntityBackgroundTaskHistory> _DtoToEntity;

        public BackgroundTaskHistoryMapper()
        {
            CreateMap<DocEntitySet<DocEntityBackgroundTaskHistory>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityBackgroundTaskHistory,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityBackgroundTaskHistory>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityBackgroundTaskHistory.GetBackgroundTaskHistory(c));
            _EntityToDto = CreateMap<DocEntityBackgroundTaskHistory,BackgroundTaskHistory>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTaskHistory>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTaskHistory>(c, "Updated")))
                .ForMember(dest => dest.Completed, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTaskHistory>(c, nameof(DocEntityBackgroundTaskHistory.Completed))))
                .ForMember(dest => dest.Data, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTaskHistory>(c, nameof(DocEntityBackgroundTaskHistory.Data))))
                .ForMember(dest => dest.Ended, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTaskHistory>(c, nameof(DocEntityBackgroundTaskHistory.Ended))))
                .ForMember(dest => dest.Errors, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTaskHistory>(c, nameof(DocEntityBackgroundTaskHistory.Errors))))
                .ForMember(dest => dest.Failed, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTaskHistory>(c, nameof(DocEntityBackgroundTaskHistory.Failed))))
                .ForMember(dest => dest.Items, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTaskHistory>(c, nameof(DocEntityBackgroundTaskHistory.Items))))
                .ForMember(dest => dest.ItemsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTaskHistory>(c, nameof(DocEntityBackgroundTaskHistory.ItemsCount))))
                .ForMember(dest => dest.Logs, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTaskHistory>(c, nameof(DocEntityBackgroundTaskHistory.Logs))))
                .ForMember(dest => dest.Succeeded, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTaskHistory>(c, nameof(DocEntityBackgroundTaskHistory.Succeeded))))
                .ForMember(dest => dest.Summary, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTaskHistory>(c, nameof(DocEntityBackgroundTaskHistory.Summary))))
                .ForMember(dest => dest.Task, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTaskHistory>(c, nameof(DocEntityBackgroundTaskHistory.Task))))
                .ForMember(dest => dest.TaskId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTaskHistory>(c, nameof(DocEntityBackgroundTaskHistory.TaskId))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<BackgroundTaskHistory,DocEntityBackgroundTaskHistory>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}