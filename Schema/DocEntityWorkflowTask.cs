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
    [TableMapping(DocConstantModelName.WORKFLOWTASK)]

    public partial class DocEntityWorkflowTask : DocEntityBase
    {
        private const string WORKFLOWTASK_CACHE = "WorkflowTaskCache";

        #region Constructor

        /// <summary>
        ///    Initializes a new instance of this class.
        /// </summary>
        /// <param name="session">The session.</param>
        public DocEntityWorkflowTask(Session session)
            : base(session) { }

        /// <summary>
        ///    Initializes a new instance of this class as a default, session-less object.
        /// </summary>
        public DocEntityWorkflowTask()
            : base(new DocDbSession(Xtensive.Orm.Session.Current)) { }

        #endregion Constructor

        #region VisibleFields
        
        private List<string> __vf;
        private List<string> _visibleFields
        {
            get
            {
                if(null == __vf)
                {
                    __vf = DocWebSession.GetTypeVisibleFields(new WorkflowTask());
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

        public static DocEntityWorkflowTask GetWorkflowTask(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetWorkflowTask(reference.Id) : null;
        }

        public static DocEntityWorkflowTask GetWorkflowTask(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityWorkflowTask>.GetFromCache(primaryKey, WORKFLOWTASK_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityWorkflowTask>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityWorkflowTask>.UpdateCache(ret.Id, ret, WORKFLOWTASK_CACHE);
                    DocEntityThreadCache<DocEntityWorkflowTask>.UpdateCache(ret.Hash, ret, WORKFLOWTASK_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityWorkflowTask GetWorkflowTask(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityWorkflowTask>.GetFromCache(hash, WORKFLOWTASK_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityWorkflowTask>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityWorkflowTask>.UpdateCache(ret.Id, ret, WORKFLOWTASK_CACHE);
                    DocEntityThreadCache<DocEntityWorkflowTask>.UpdateCache(ret.Hash, ret, WORKFLOWTASK_CACHE);
                }
            }
            return ret;
        }

        #endregion Static Members

        #region Properties

        [Field()]
        [FieldMapping(nameof(Assignee))]
        public DocEntityUser Assignee { get; set; }
        public int? AssigneeId { get { return Assignee?.Id; } private set { var noid = value; } }


        [Field(Length = int.MaxValue)]
        [FieldMapping(nameof(Data))]
        public string Data { get; set; }


        [Field(Nullable = false)]
        [FieldMapping(nameof(Description))]
        public string Description { get; set; }


        [Field()]
        [FieldMapping(nameof(DueDate))]
        public DateTime? DueDate { get; set; }


        [Field(Nullable = false)]
        [FieldMapping(nameof(Reporter))]
        public DocEntityUser Reporter { get; set; }
        public int? ReporterId { get { return Reporter?.Id; } private set { var noid = value; } }


        [Field(NullableOnUpgrade = true)]
        [FieldMapping(nameof(Status))]
        public DocEntityLookupTable Status { get; set; }
        public int? StatusId { get { return Status?.Id; } private set { var noid = value; } }


        [Field(Nullable = false, NullableOnUpgrade = true)]
        [FieldMapping(nameof(Type))]
        public DocEntityLookupTable Type { get; set; }
        public int? TypeId { get { return Type?.Id; } private set { var noid = value; } }


        [Field(Nullable = false)]
        [FieldMapping(nameof(Workflow))]
        public DocEntityWorkflow Workflow { get; set; }
        public int? WorkflowId { get { return Workflow?.Id; } private set { var noid = value; } }



        [Field(LazyLoad = false, Length = Int32.MaxValue)]
        [FieldMapping(DocEntityConstants.PropertyName.GESTALT)]
        public override string Gestalt { get; set; }

        [Field()]
        [FieldMapping(BasePropertyName.HASH)]
        public override Guid Hash { get; set; }

        [Field(DefaultValue = 0), Version(VersionMode.Manual)]
        public override int VersionNo { get; set; }

        [Field()]
        public override DateTime? Created { get; set; }

        [Field()]
        public override DateTime? Updated { get; set; }

        [Field()]
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

        /// <summary>
        ///    The Model name of this class is <see cref="DocConstantModelName.WORKFLOWTASK" />
        /// </summary>
        public static readonly DocConstantModelName MODEL_NAME = DocConstantModelName.WORKFLOWTASK;

        /// <summary>
        ///    The Model name of this instance is always the same as <see cref="MODEL_NAME" />
        /// </summary>
        public override DocConstantModelName ModelName
        {
            get { return MODEL_NAME; }
        }
        
        public const string CACHE_KEY_PREFIX = "FindWorkflowTasks";

        /// <summary>
        ///    Converts this Domain object to its corresponding Model.
        /// </summary>
        public override T ToModel<T>()
        {
            return  null;

        }

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
                throw new HttpError(HttpStatusCode.Conflict, $"WorkflowTask requires: {ValidationMessage.Message}.");
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
            if (!ret) throw new ServiceStack.HttpError(System.Net.HttpStatusCode.Forbidden, $"You do not have permission to unlock this {nameof(WorkflowTask)}");
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
            DocCacheClient.RemoveSearch("WorkflowTask");
        }

        #endregion Entity overrides

        #region Validation

        public DocValidationMessage ValidationMessage
        {
            get
            {
                var isValid = true;
                var message = string.Empty;

                if(DocTools.IsNullOrEmpty(Description))
                {
                    isValid = false;
                    message += " Description is a required property.";
                }
                if(null == Reporter)
                {
                    isValid = false;
                    message += " Reporter is a required property.";
                }
                if(null != Status && Status?.Enum?.Name != "WorkflowStatus")
                {
                    isValid = false;
                    message += " Status is a " + Status?.Enum?.Name + ", but must be a WorkflowStatus.";
                }
                if(null == Type)
                {
                    isValid = false;
                    message += " Type is a required property.";
                }
                else
                {
                    if(Type.Enum?.Name != "WorkflowTaskType")
                    {
                        isValid = false;
                        message += " Type is a " + Type.Enum.Name + ", but must be a WorkflowTaskType.";
                    }
                }
                if(null == Workflow)
                {
                    isValid = false;
                    message += " Workflow is a required property.";
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }

        }

        #endregion Validation

        #region Hash

        
        public static Guid GetGuid(DocEntityWorkflowTask thing)
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

        public WorkflowTask ToDto() => Mapper.Map<DocEntityWorkflowTask, WorkflowTask>(this);

        public override IDto ToIDto() => ToDto();

        #endregion Converters
    }

    public partial class WorkflowTaskMapper : Profile
    {
        private IMappingExpression<DocEntityWorkflowTask,WorkflowTask> _EntityToDto;
        private IMappingExpression<WorkflowTask,DocEntityWorkflowTask> _DtoToEntity;

        public WorkflowTaskMapper()
        {
            CreateMap<DocEntitySet<DocEntityWorkflowTask>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityWorkflowTask,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityWorkflowTask>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityWorkflowTask.GetWorkflowTask(c));
            _EntityToDto = CreateMap<DocEntityWorkflowTask,WorkflowTask>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<WorkflowTask>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<WorkflowTask>(c, "Updated")))
                .ForMember(dest => dest.Assignee, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<WorkflowTask>(c, nameof(DocEntityWorkflowTask.Assignee))))
                .ForMember(dest => dest.AssigneeId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<WorkflowTask>(c, nameof(DocEntityWorkflowTask.AssigneeId))))
                .ForMember(dest => dest.Data, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<WorkflowTask>(c, nameof(DocEntityWorkflowTask.Data))))
                .ForMember(dest => dest.Description, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<WorkflowTask>(c, nameof(DocEntityWorkflowTask.Description))))
                .ForMember(dest => dest.DueDate, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<WorkflowTask>(c, nameof(DocEntityWorkflowTask.DueDate))))
                .ForMember(dest => dest.Reporter, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<WorkflowTask>(c, nameof(DocEntityWorkflowTask.Reporter))))
                .ForMember(dest => dest.ReporterId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<WorkflowTask>(c, nameof(DocEntityWorkflowTask.ReporterId))))
                .ForMember(dest => dest.Status, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<WorkflowTask>(c, nameof(DocEntityWorkflowTask.Status))))
                .ForMember(dest => dest.StatusId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<WorkflowTask>(c, nameof(DocEntityWorkflowTask.StatusId))))
                .ForMember(dest => dest.Type, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<WorkflowTask>(c, nameof(DocEntityWorkflowTask.Type))))
                .ForMember(dest => dest.TypeId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<WorkflowTask>(c, nameof(DocEntityWorkflowTask.TypeId))))
                .ForMember(dest => dest.Workflow, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<WorkflowTask>(c, nameof(DocEntityWorkflowTask.Workflow))))
                .ForMember(dest => dest.WorkflowId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<WorkflowTask>(c, nameof(DocEntityWorkflowTask.WorkflowId))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<WorkflowTask,DocEntityWorkflowTask>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}