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
    [TableMapping(DocConstantModelName.SCOPE)]

    public partial class DocEntityScope : DocEntityBase
    {
        private const string SCOPE_CACHE = "ScopeCache";

        #region Constructor

        /// <summary>
        ///    Initializes a new instance of this class.
        /// </summary>
        /// <param name="session">The session.</param>
        public DocEntityScope(Session session)
            : base(session) { }

        /// <summary>
        ///    Initializes a new instance of this class as a default, session-less object.
        /// </summary>
        public DocEntityScope()
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
                    __vf = DocWebSession.GetTypeVisibleFields(new Scope());
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

        public static DocEntityScope GetScope(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetScope(reference.Id) : null;
        }

        public static DocEntityScope GetScope(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityScope>.GetFromCache(primaryKey, SCOPE_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityScope>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityScope>.UpdateCache(ret.Id, ret, SCOPE_CACHE);
                    DocEntityThreadCache<DocEntityScope>.UpdateCache(ret.Hash, ret, SCOPE_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityScope GetScope(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityScope>.GetFromCache(hash, SCOPE_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityScope>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityScope>.UpdateCache(ret.Id, ret, SCOPE_CACHE);
                    DocEntityThreadCache<DocEntityScope>.UpdateCache(ret.Hash, ret, SCOPE_CACHE);
                }
            }
            return ret;
        }

        #endregion Static Members

        #region Properties

        [Field()]
        [FieldMapping(nameof(App))]
        public DocEntityApp App { get; set; }
        public int? AppId { get { return App?.Id; } private set { var noid = value; } }


        [Field(DefaultValue = false)]
        [FieldMapping(nameof(Archived))]
        public bool? Archived { get; set; }


        [Field()]
        [FieldMapping(nameof(Bindings))]
        [Association( PairTo = nameof(LookupTableBinding.Scope), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear )]
        public DocEntitySet<DocEntityLookupTableBinding> Bindings { get; private set; }


        public int? BindingsCount { get { return Bindings.Count(); } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Broadcasts))]
        [Association( PairTo = nameof(Broadcast.Scopes), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear )]
        public DocEntitySet<DocEntityBroadcast> Broadcasts { get; private set; }


        public int? BroadcastsCount { get { return Broadcasts.Count(); } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Client))]
        public DocEntityClient Client { get; set; }
        public int? ClientId { get { return Client?.Id; } private set { var noid = value; } }


        [Field(DefaultValue = false)]
        [FieldMapping(nameof(Delete))]
        public bool? Delete { get; set; }


        [Field()]
        [FieldMapping(nameof(DocumentSet))]
        public DocEntityDocumentSet DocumentSet { get; set; }
        public int? DocumentSetId { get { return DocumentSet?.Id; } private set { var noid = value; } }


        [Field(DefaultValue = false)]
        [FieldMapping(nameof(Edit))]
        public bool? Edit { get; set; }


        [Field()]
        [FieldMapping(nameof(Help))]
        [Association( PairTo = nameof(Dto.Help.Scopes), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear )]
        public DocEntitySet<DocEntityHelp> Help { get; private set; }


        public int? HelpCount { get { return Help.Count(); } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(IsGlobal))]
        public bool? IsGlobal { get; set; }


        [Field()]
        [FieldMapping(nameof(Synonyms))]
        [Association( PairTo = nameof(TermSynonym.Scope), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear )]
        public DocEntitySet<DocEntityTermSynonym> Synonyms { get; private set; }


        public int? SynonymsCount { get { return Synonyms.Count(); } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Team))]
        public DocEntityTeam Team { get; set; }
        public int? TeamId { get { return Team?.Id; } private set { var noid = value; } }


        [Field(Nullable = false)]
        [FieldMapping(nameof(Type))]
        public DocEntityLookupTable Type { get; set; }
        public int? TypeId { get { return Type?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(User))]
        public DocEntityUser User { get; set; }
        public int? UserId { get { return User?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(VariableRules))]
        [Association( PairTo = nameof(VariableRule.Scopes), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear )]
        public DocEntitySet<DocEntityVariableRule> VariableRules { get; private set; }


        public int? VariableRulesCount { get { return VariableRules.Count(); } private set { var noid = value; } }


        [Field(DefaultValue = true)]
        [FieldMapping(nameof(View))]
        public bool? View { get; set; }


        [Field()]
        [FieldMapping(nameof(Workflows))]
        public DocEntitySet<DocEntityWorkflow> Workflows { get; private set; }


        public int? WorkflowsCount { get { return Workflows.Count(); } private set { var noid = value; } }



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
        ///    The Model name of this class is <see cref="DocConstantModelName.SCOPE" />
        /// </summary>
        public static readonly DocConstantModelName MODEL_NAME = DocConstantModelName.SCOPE;

        /// <summary>
        ///    The Model name of this instance is always the same as <see cref="MODEL_NAME" />
        /// </summary>
        public override DocConstantModelName ModelName
        {
            get { return MODEL_NAME; }
        }
        
        public const string CACHE_KEY_PREFIX = "FindScopes";

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
                throw new HttpError(HttpStatusCode.Conflict, $"Scope requires: {ValidationMessage.Message}.");
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
            if (!ret) throw new ServiceStack.HttpError(System.Net.HttpStatusCode.Forbidden, $"You do not have permission to unlock this {nameof(Scope)}");
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
            DocCacheClient.RemoveSearch("Scope");
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

                if(null == Type)
                {
                    isValid = false;
                    message += " Type is a required property.";
                }
                else
                {
                    if(Type.Enum?.Name != "Scope")
                    {
                        isValid = false;
                        message += " Type is a " + Type.Enum.Name + ", but must be a Scope.";
                    }
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }

        }

        #endregion Validation

        #region Hash

        
        public static Guid GetGuid(DocEntityScope thing)
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

        public Scope ToDto() => Mapper.Map<DocEntityScope, Scope>(this);

        public override IDto ToIDto() => ToDto();

        #endregion Converters
    }

    public partial class ScopeMapper : Profile
    {
        private IMappingExpression<DocEntityScope,Scope> _EntityToDto;
        private IMappingExpression<Scope,DocEntityScope> _DtoToEntity;

        public ScopeMapper()
        {
            CreateMap<DocEntitySet<DocEntityScope>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityScope,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityScope>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityScope.GetScope(c));
            _EntityToDto = CreateMap<DocEntityScope,Scope>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, "Updated")))
                .ForMember(dest => dest.App, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.App))))
                .ForMember(dest => dest.AppId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.AppId))))
                .ForMember(dest => dest.Archived, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.Archived))))
                .ForMember(dest => dest.Bindings, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.Bindings))))
                .ForMember(dest => dest.BindingsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.BindingsCount))))
                .ForMember(dest => dest.Broadcasts, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.Broadcasts))))
                .ForMember(dest => dest.BroadcastsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.BroadcastsCount))))
                .ForMember(dest => dest.Client, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.Client))))
                .ForMember(dest => dest.ClientId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.ClientId))))
                .ForMember(dest => dest.Delete, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.Delete))))
                .ForMember(dest => dest.DocumentSet, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.DocumentSet))))
                .ForMember(dest => dest.DocumentSetId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.DocumentSetId))))
                .ForMember(dest => dest.Edit, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.Edit))))
                .ForMember(dest => dest.Help, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.Help))))
                .ForMember(dest => dest.HelpCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.HelpCount))))
                .ForMember(dest => dest.IsGlobal, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.IsGlobal))))
                .ForMember(dest => dest.Synonyms, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.Synonyms))))
                .ForMember(dest => dest.SynonymsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.SynonymsCount))))
                .ForMember(dest => dest.Team, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.Team))))
                .ForMember(dest => dest.TeamId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.TeamId))))
                .ForMember(dest => dest.Type, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.Type))))
                .ForMember(dest => dest.TypeId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.TypeId))))
                .ForMember(dest => dest.User, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.User))))
                .ForMember(dest => dest.UserId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.UserId))))
                .ForMember(dest => dest.VariableRules, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.VariableRules))))
                .ForMember(dest => dest.VariableRulesCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.VariableRulesCount))))
                .ForMember(dest => dest.View, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.View))))
                .ForMember(dest => dest.Workflows, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.Workflows))))
                .ForMember(dest => dest.WorkflowsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.WorkflowsCount))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<Scope,DocEntityScope>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}