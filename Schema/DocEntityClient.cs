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
    [TableMapping(DocConstantModelName.CLIENT)]
    public partial class DocEntityClient : DocEntityBase
    {
        private const string CLIENT_CACHE = "ClientCache";

        #region Constructor
        public DocEntityClient(Session session) : base(session) {}

        public DocEntityClient() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        #region VisibleFields
        private List<string> __vf;
        private List<string> _visibleFields
        {
            get
            {
                if(null == __vf)
                {
                    __vf = DocWebSession.GetTypeVisibleFields(new Client());
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
        public static DocEntityClient GetClient(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetClient(reference.Id) : null;
        }

        public static DocEntityClient GetClient(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityClient>.GetFromCache(primaryKey, CLIENT_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityClient>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityClient>.UpdateCache(ret.Id, ret, CLIENT_CACHE);
                    DocEntityThreadCache<DocEntityClient>.UpdateCache(ret.Hash, ret, CLIENT_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityClient GetClient(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityClient>.GetFromCache(hash, CLIENT_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityClient>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityClient>.UpdateCache(ret.Id, ret, CLIENT_CACHE);
                    DocEntityThreadCache<DocEntityClient>.UpdateCache(ret.Hash, ret, CLIENT_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field()]
        [FieldMapping(nameof(Account))]
        public DocEntityForeignKey Account { get; set; }
        public int? AccountId { get { return Account?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(DefaultLocale))]
        public DocEntityLocale DefaultLocale { get; set; }
        public int? DefaultLocaleId { get { return DefaultLocale?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Divisions))]
        [Association( PairTo = nameof(Division.Client), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear )]
        public DocEntitySet<DocEntityDivision> Divisions { get; private set; }


        public int? DivisionsCount { get { return Divisions.Count(); } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(DocumentSets))]
        public DocEntitySet<DocEntityDocumentSet> DocumentSets { get; private set; }


        public int? DocumentSetsCount { get { return DocumentSets.Count(); } private set { var noid = value; } }


        [Field(Nullable = false)]
        [FieldMapping(nameof(Name))]
        public string Name { get; set; }


        [Field(Nullable = false)]
        [FieldMapping(nameof(Role))]
        public DocEntityRole Role { get; set; }
        public int? RoleId { get { return Role?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Scopes))]
        [Association( PairTo = nameof(Scope.Client), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear )]
        public DocEntitySet<DocEntityScope> Scopes { get; private set; }


        public int? ScopesCount { get { return Scopes.Count(); } private set { var noid = value; } }


        [Field(Length = int.MaxValue)]
        [FieldMapping(nameof(Settings))]
        public string Settings { get; set; }



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
        public static readonly DocConstantModelName MODEL_NAME = DocConstantModelName.CLIENT;

        public override DocConstantModelName ModelName => MODEL_NAME;

        public const string CACHE_KEY_PREFIX = "FindClients";


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
                Divisions.Clear(); //foreach thing in Divisions en.Remove();
            }
            catch(Exception ex)
            {
                throw new DocException("Failed to delete Client in Divisions delete", ex);
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
                throw new HttpError(HttpStatusCode.Conflict, $"Client requires: {ValidationMessage.Message}.");
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
            if (!ret) throw new ServiceStack.HttpError(System.Net.HttpStatusCode.Forbidden, $"You do not have permission to unlock this {nameof(Client)}");
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
            DocCacheClient.RemoveSearch("Client");
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
                if(DocTools.IsNullOrEmpty(Role))
                {
                    isValid = false;
                    message += " Role is a required property.";
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Hash
        
        public static Guid GetGuid(DocEntityClient thing)
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

        public Client ToDto() => Mapper.Map<DocEntityClient, Client>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }

    public partial class ClientMapper : Profile
    {
        private IMappingExpression<DocEntityClient,Client> _EntityToDto;
        private IMappingExpression<Client,DocEntityClient> _DtoToEntity;

        public ClientMapper()
        {
            CreateMap<DocEntitySet<DocEntityClient>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityClient,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityClient>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityClient.GetClient(c));
            _EntityToDto = CreateMap<DocEntityClient,Client>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Client>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Client>(c, "Updated")))
                .ForMember(dest => dest.Account, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Client>(c, nameof(DocEntityClient.Account))))
                .ForMember(dest => dest.AccountId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Client>(c, nameof(DocEntityClient.AccountId))))
                .ForMember(dest => dest.DefaultLocale, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Client>(c, nameof(DocEntityClient.DefaultLocale))))
                .ForMember(dest => dest.DefaultLocaleId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Client>(c, nameof(DocEntityClient.DefaultLocaleId))))
                .ForMember(dest => dest.Divisions, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Client>(c, nameof(DocEntityClient.Divisions))))
                .ForMember(dest => dest.DivisionsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Client>(c, nameof(DocEntityClient.DivisionsCount))))
                .ForMember(dest => dest.DocumentSets, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Client>(c, nameof(DocEntityClient.DocumentSets))))
                .ForMember(dest => dest.DocumentSetsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Client>(c, nameof(DocEntityClient.DocumentSetsCount))))
                .ForMember(dest => dest.Name, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Client>(c, nameof(DocEntityClient.Name))))
                .ForMember(dest => dest.Role, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Client>(c, nameof(DocEntityClient.Role))))
                .ForMember(dest => dest.RoleId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Client>(c, nameof(DocEntityClient.RoleId))))
                .ForMember(dest => dest.Scopes, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Client>(c, nameof(DocEntityClient.Scopes))))
                .ForMember(dest => dest.ScopesCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Client>(c, nameof(DocEntityClient.ScopesCount))))
                .ForMember(dest => dest.Settings, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Client>(c, nameof(DocEntityClient.Settings))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<Client,DocEntityClient>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}