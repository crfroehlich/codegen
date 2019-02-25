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
    [TableMapping(DocConstantModelName.WORKFLOW)]
    public partial class DocEntityWorkflow : DocEntityBase
    {
        private const string WORKFLOW_CACHE = "WorkflowCache";

        #region Constructor
        public DocEntityWorkflow(Session session) : base(session) {}

        public DocEntityWorkflow() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        #region VisibleFields
        private List<string> __vf;
        private List<string> _visibleFields
        {
            get
            {
                if(null == __vf)
                {
                    __vf = DocWebSession.GetTypeVisibleFields(new Workflow());
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
        public static DocEntityWorkflow GetWorkflow(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetWorkflow(reference.Id) : null;
        }

        public static DocEntityWorkflow GetWorkflow(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityWorkflow>.GetFromCache(primaryKey, WORKFLOW_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityWorkflow>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityWorkflow>.UpdateCache(ret.Id, ret, WORKFLOW_CACHE);
                    DocEntityThreadCache<DocEntityWorkflow>.UpdateCache(ret.Hash, ret, WORKFLOW_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityWorkflow GetWorkflow(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityWorkflow>.GetFromCache(hash, WORKFLOW_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityWorkflow>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityWorkflow>.UpdateCache(ret.Id, ret, WORKFLOW_CACHE);
                    DocEntityThreadCache<DocEntityWorkflow>.UpdateCache(ret.Hash, ret, WORKFLOW_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field(DefaultValue = false)]
        [FieldMapping(nameof(Archived))]
        public bool? Archived { get; set; }


        [Field()]
        [FieldMapping(nameof(Bindings))]
        public DocEntitySet<DocEntityLookupTableBinding> Bindings { get; private set; }


        public int? BindingsCount { get { return Bindings.Count(); } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Comments))]
        [Association( PairTo = nameof(WorkflowComment.Workflow), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear )]
        public DocEntitySet<DocEntityWorkflowComment> Comments { get; private set; }


        public int? CommentsCount { get { return Comments.Count(); } private set { var noid = value; } }


        [Field(DefaultValue = "{}", Length = int.MaxValue, NullableOnUpgrade = true)]
        [FieldMapping(nameof(Data))]
        public string Data { get; set; }


        [Field()]
        [FieldMapping(nameof(Description))]
        public string Description { get; set; }


        [Field()]
        [FieldMapping(nameof(Documents))]
        public DocEntitySet<DocEntityDocument> Documents { get; private set; }


        public int? DocumentsCount { get { return Documents.Count(); } private set { var noid = value; } }


        [Field(Nullable = false)]
        [FieldMapping(nameof(Name))]
        public string Name { get; set; }


        [Field()]
        [FieldMapping(nameof(Owner))]
        public DocEntityWorkflow Owner { get; set; }
        public int? OwnerId { get { return Owner?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Scopes))]
        [Association( PairTo = nameof(Scope.Workflows), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear )]
        public DocEntitySet<DocEntityScope> Scopes { get; private set; }


        public int? ScopesCount { get { return Scopes.Count(); } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Status))]
        public DocEntityLookupTable Status { get; set; }
        public int? StatusId { get { return Status?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Tags))]
        public DocEntitySet<DocEntityTag> Tags { get; private set; }


        public int? TagsCount { get { return Tags.Count(); } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Tasks))]
        [Association( PairTo = nameof(WorkflowTask.Workflow), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear )]
        public DocEntitySet<DocEntityWorkflowTask> Tasks { get; private set; }


        public int? TasksCount { get { return Tasks.Count(); } private set { var noid = value; } }


        [Field(Nullable = false, NullableOnUpgrade = true)]
        [FieldMapping(nameof(Type))]
        public DocEntityLookupTable Type { get; set; }
        public int? TypeId { get { return Type?.Id; } private set { var noid = value; } }


        [Field(Nullable = false, NullableOnUpgrade = true)]
        [FieldMapping(nameof(User))]
        public DocEntityUser User { get; set; }
        public int? UserId { get { return User?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Variables))]
        public DocEntitySet<DocEntityVariableInstance> Variables { get; private set; }


        public int? VariablesCount { get { return Variables.Count(); } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Workflows))]
        [Association( PairTo = nameof(Workflow.Owner), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear )]
        public DocEntitySet<DocEntityWorkflow> Workflows { get; private set; }


        public int? WorkflowsCount { get { return Workflows.Count(); } private set { var noid = value; } }



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
        public static readonly DocConstantModelName MODEL_NAME = DocConstantModelName.WORKFLOW;

        public override DocConstantModelName ModelName => MODEL_NAME;

        public const string CACHE_KEY_PREFIX = "FindWorkflows";


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
                Comments.Clear(); //foreach thing in Comments en.Remove();
            }
            catch(Exception ex)
            {
                throw new DocException("Failed to delete Workflow in Comments delete", ex);
            }
            try
            {
                Tasks.Clear(); //foreach thing in Tasks en.Remove();
            }
            catch(Exception ex)
            {
                throw new DocException("Failed to delete Workflow in Tasks delete", ex);
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
                throw new HttpError(HttpStatusCode.Conflict, $"Workflow requires: {ValidationMessage.Message}.");
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
            Name = Name?.TrimAndPruneSpaces();

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
            if (!ret) throw new ServiceStack.HttpError(System.Net.HttpStatusCode.Forbidden, $"You do not have permission to unlock this {nameof(Workflow)}");
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
            DocCacheClient.RemoveSearch("Workflow");
            DocCacheClient.RemoveById(Id);
        }
        #endregion Entity overrides

        #region Validation
        public DocValidationMessage ValidationMessage
        {
            get
            {
                var isValid = true;
                var message = string.Empty;

                if(DocTools.IsNullOrEmpty(Name))
                {
                    isValid = false;
                    message += " Name is a required property.";
                }
                if(null != Status && Status?.Enum?.Name != "WorkflowStatus")
                {
                    isValid = false;
                    message += " Status is a " + Status?.Enum?.Name + ", but must be a WorkflowStatus.";
                }
                if(DocTools.IsNullOrEmpty(Type))
                {
                    isValid = false;
                    message += " Type is a required property.";
                }
                else
                {
                    if(Type.Enum?.Name != "Workflow")
                    {
                        isValid = false;
                        message += " Type is a " + Type.Enum.Name + ", but must be a Workflow.";
                    }
                }
                if(DocTools.IsNullOrEmpty(User))
                {
                    isValid = false;
                    message += " User is a required property.";
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Hash
        
        public static Guid GetGuid(DocEntityWorkflow thing)
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

        public Workflow ToDto() => Mapper.Map<DocEntityWorkflow, Workflow>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }

    public partial class WorkflowMapper : Profile
    {
        private IMappingExpression<DocEntityWorkflow,Workflow> _EntityToDto;
        private IMappingExpression<Workflow,DocEntityWorkflow> _DtoToEntity;

        public WorkflowMapper()
        {
            CreateMap<DocEntitySet<DocEntityWorkflow>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityWorkflow,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityWorkflow>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityWorkflow.GetWorkflow(c));
            _EntityToDto = CreateMap<DocEntityWorkflow,Workflow>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Workflow>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Workflow>(c, "Updated")))
                .ForMember(dest => dest.Archived, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Workflow>(c, nameof(DocEntityWorkflow.Archived))))
                .ForMember(dest => dest.Bindings, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Workflow>(c, nameof(DocEntityWorkflow.Bindings))))
                .ForMember(dest => dest.BindingsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Workflow>(c, nameof(DocEntityWorkflow.BindingsCount))))
                .ForMember(dest => dest.Comments, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Workflow>(c, nameof(DocEntityWorkflow.Comments))))
                .ForMember(dest => dest.CommentsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Workflow>(c, nameof(DocEntityWorkflow.CommentsCount))))
                .ForMember(dest => dest.Data, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Workflow>(c, nameof(DocEntityWorkflow.Data))))
                .ForMember(dest => dest.Description, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Workflow>(c, nameof(DocEntityWorkflow.Description))))
                .ForMember(dest => dest.Documents, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Workflow>(c, nameof(DocEntityWorkflow.Documents))))
                .ForMember(dest => dest.DocumentsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Workflow>(c, nameof(DocEntityWorkflow.DocumentsCount))))
                .ForMember(dest => dest.Name, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Workflow>(c, nameof(DocEntityWorkflow.Name))))
                .ForMember(dest => dest.Owner, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Workflow>(c, nameof(DocEntityWorkflow.Owner))))
                .ForMember(dest => dest.OwnerId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Workflow>(c, nameof(DocEntityWorkflow.OwnerId))))
                .ForMember(dest => dest.Scopes, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Workflow>(c, nameof(DocEntityWorkflow.Scopes))))
                .ForMember(dest => dest.ScopesCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Workflow>(c, nameof(DocEntityWorkflow.ScopesCount))))
                .ForMember(dest => dest.Status, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Workflow>(c, nameof(DocEntityWorkflow.Status))))
                .ForMember(dest => dest.StatusId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Workflow>(c, nameof(DocEntityWorkflow.StatusId))))
                .ForMember(dest => dest.Tags, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Workflow>(c, nameof(DocEntityWorkflow.Tags))))
                .ForMember(dest => dest.TagsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Workflow>(c, nameof(DocEntityWorkflow.TagsCount))))
                .ForMember(dest => dest.Tasks, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Workflow>(c, nameof(DocEntityWorkflow.Tasks))))
                .ForMember(dest => dest.TasksCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Workflow>(c, nameof(DocEntityWorkflow.TasksCount))))
                .ForMember(dest => dest.Type, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Workflow>(c, nameof(DocEntityWorkflow.Type))))
                .ForMember(dest => dest.TypeId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Workflow>(c, nameof(DocEntityWorkflow.TypeId))))
                .ForMember(dest => dest.User, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Workflow>(c, nameof(DocEntityWorkflow.User))))
                .ForMember(dest => dest.UserId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Workflow>(c, nameof(DocEntityWorkflow.UserId))))
                .ForMember(dest => dest.Variables, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Workflow>(c, nameof(DocEntityWorkflow.Variables))))
                .ForMember(dest => dest.VariablesCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Workflow>(c, nameof(DocEntityWorkflow.VariablesCount))))
                .ForMember(dest => dest.Workflows, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Workflow>(c, nameof(DocEntityWorkflow.Workflows))))
                .ForMember(dest => dest.WorkflowsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Workflow>(c, nameof(DocEntityWorkflow.WorkflowsCount))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<Workflow,DocEntityWorkflow>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}