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
    [TableMapping(DocConstantModelName.LOOKUPTABLEBINDING)]
    public partial class DocEntityLookupTableBinding : DocEntityBase
    {
        private const string LOOKUPTABLEBINDING_CACHE = "LookupTableBindingCache";

        #region Constructor
        public DocEntityLookupTableBinding(Session session) : base(session) {}

        public DocEntityLookupTableBinding() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        #region VisibleFields
        private List<string> __vf;
        private List<string> _visibleFields
        {
            get
            {
                if(null == __vf)
                {
                    __vf = DocWebSession.GetTypeVisibleFields(new LookupTableBinding());
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
        public static DocEntityLookupTableBinding GetLookupTableBinding(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetLookupTableBinding(reference.Id) : null;
        }

        public static DocEntityLookupTableBinding GetLookupTableBinding(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityLookupTableBinding>.GetFromCache(primaryKey, LOOKUPTABLEBINDING_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityLookupTableBinding>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityLookupTableBinding>.UpdateCache(ret.Id, ret, LOOKUPTABLEBINDING_CACHE);
                    DocEntityThreadCache<DocEntityLookupTableBinding>.UpdateCache(ret.Hash, ret, LOOKUPTABLEBINDING_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityLookupTableBinding GetLookupTableBinding(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityLookupTableBinding>.GetFromCache(hash, LOOKUPTABLEBINDING_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityLookupTableBinding>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityLookupTableBinding>.UpdateCache(ret.Id, ret, LOOKUPTABLEBINDING_CACHE);
                    DocEntityThreadCache<DocEntityLookupTableBinding>.UpdateCache(ret.Hash, ret, LOOKUPTABLEBINDING_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field(DefaultValue = "{}", Length = int.MaxValue)]
        [FieldMapping(nameof(Binding))]
        public string Binding { get; set; }


        [Field()]
        [FieldMapping(nameof(BoundName))]
        public string BoundName { get; set; }


        [Field(Nullable = false)]
        [FieldMapping(nameof(LookupTable))]
        public DocEntityLookupTable LookupTable { get; set; }
        public int? LookupTableId { get { return LookupTable?.Id; } private set { var noid = value; } }


        [Field(Nullable = false)]
        [FieldMapping(nameof(Scope))]
        public DocEntityScope Scope { get; set; }
        public int? ScopeId { get { return Scope?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Synonyms))]
        [Association( PairTo = nameof(TermSynonym.Bindings), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear )]
        public DocEntitySet<DocEntityTermSynonym> Synonyms { get; private set; }


        public int? SynonymsCount { get { return Synonyms.Count(); } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Workflows))]
        [Association( PairTo = nameof(Workflow.Bindings), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear )]
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
        public static readonly DocConstantModelName MODEL_NAME = DocConstantModelName.LOOKUPTABLEBINDING;

        public override DocConstantModelName ModelName => MODEL_NAME;

        public const string CACHE_KEY_PREFIX = "FindLookupTableBindings";


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
                throw new HttpError(HttpStatusCode.Conflict, $"LookupTableBinding requires: {ValidationMessage.Message}.");
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

            BoundName = BoundName?.TrimAndPruneSpaces();

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
            if (!ret) throw new ServiceStack.HttpError(System.Net.HttpStatusCode.Forbidden, $"You do not have permission to unlock this {nameof(LookupTableBinding)}");
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
            DocCacheClient.RemoveSearch("LookupTableBinding");
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

                if(DocTools.IsNullOrEmpty(LookupTable))
                {
                    isValid = false;
                    message += " LookupTable is a required property.";
                }
                else
                {
                    if(DocTools.IsNullOrEmpty(LookupTable.Enum?.Name))
                    {
                        isValid = false;
                        message += " LookupTable is a " + LookupTable.Enum?.Name + ", but must be a .";
                    }
                }
                if(DocTools.IsNullOrEmpty(Scope))
                {
                    isValid = false;
                    message += " Scope is a required property.";
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Hash
        
        public static Guid GetGuid(DocEntityLookupTableBinding thing)
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

        public LookupTableBinding ToDto() => Mapper.Map<DocEntityLookupTableBinding, LookupTableBinding>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }

    public partial class LookupTableBindingMapper : Profile
    {
        private IMappingExpression<DocEntityLookupTableBinding,LookupTableBinding> _EntityToDto;
        private IMappingExpression<LookupTableBinding,DocEntityLookupTableBinding> _DtoToEntity;

        public LookupTableBindingMapper()
        {
            CreateMap<DocEntitySet<DocEntityLookupTableBinding>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityLookupTableBinding,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityLookupTableBinding>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityLookupTableBinding.GetLookupTableBinding(c));
            _EntityToDto = CreateMap<DocEntityLookupTableBinding,LookupTableBinding>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LookupTableBinding>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LookupTableBinding>(c, "Updated")))
                .ForMember(dest => dest.Binding, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LookupTableBinding>(c, nameof(DocEntityLookupTableBinding.Binding))))
                .ForMember(dest => dest.BoundName, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LookupTableBinding>(c, nameof(DocEntityLookupTableBinding.BoundName))))
                .ForMember(dest => dest.LookupTable, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LookupTableBinding>(c, nameof(DocEntityLookupTableBinding.LookupTable))))
                .ForMember(dest => dest.LookupTableId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LookupTableBinding>(c, nameof(DocEntityLookupTableBinding.LookupTableId))))
                .ForMember(dest => dest.Scope, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LookupTableBinding>(c, nameof(DocEntityLookupTableBinding.Scope))))
                .ForMember(dest => dest.ScopeId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LookupTableBinding>(c, nameof(DocEntityLookupTableBinding.ScopeId))))
                .ForMember(dest => dest.Synonyms, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LookupTableBinding>(c, nameof(DocEntityLookupTableBinding.Synonyms))))
                .ForMember(dest => dest.SynonymsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LookupTableBinding>(c, nameof(DocEntityLookupTableBinding.SynonymsCount))))
                .ForMember(dest => dest.Workflows, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LookupTableBinding>(c, nameof(DocEntityLookupTableBinding.Workflows))))
                .ForMember(dest => dest.WorkflowsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LookupTableBinding>(c, nameof(DocEntityLookupTableBinding.WorkflowsCount))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<LookupTableBinding,DocEntityLookupTableBinding>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}