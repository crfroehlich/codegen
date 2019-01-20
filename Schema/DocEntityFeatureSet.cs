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
    [TableMapping(DocConstantModelName.FEATURESET)]

    public partial class DocEntityFeatureSet : DocEntityBase
    {
        private const string FEATURESET_CACHE = "FeatureSetCache";

        #region Constructor

        /// <summary>
        ///    Initializes a new instance of this class.
        /// </summary>
        /// <param name="session">The session.</param>
        public DocEntityFeatureSet(Session session)
            : base(session) { }

        /// <summary>
        ///    Initializes a new instance of this class as a default, session-less object.
        /// </summary>
        public DocEntityFeatureSet()
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
                    __vf = DocWebSession.GetTypeVisibleFields(new FeatureSet());
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

        public static DocEntityFeatureSet GetFeatureSet(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetFeatureSet(reference.Id) : null;
        }

        public static DocEntityFeatureSet GetFeatureSet(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityFeatureSet>.GetFromCache(primaryKey, FEATURESET_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityFeatureSet>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityFeatureSet>.UpdateCache(ret.Id, ret, FEATURESET_CACHE);
                    DocEntityThreadCache<DocEntityFeatureSet>.UpdateCache(ret.Hash, ret, FEATURESET_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityFeatureSet GetFeatureSet(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityFeatureSet>.GetFromCache(hash, FEATURESET_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityFeatureSet>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityFeatureSet>.UpdateCache(ret.Id, ret, FEATURESET_CACHE);
                    DocEntityThreadCache<DocEntityFeatureSet>.UpdateCache(ret.Hash, ret, FEATURESET_CACHE);
                }
            }
            return ret;
        }

        #endregion Static Members

        #region Properties

        [Field()]
        [FieldMapping(nameof(Description))]
        public string Description { get; set; }


        [Field(Nullable = false)]
        [FieldMapping(nameof(Feature))]
        public string Feature { get; set; }


        [Field()]
        [FieldMapping(nameof(Name))]
        public string Name { get; set; }


        [Field()]
        [FieldMapping(nameof(Roles))]
        public DocEntitySet<DocEntityRole> Roles { get; private set; }


        public int? RolesCount { get { return Roles.Count(); } private set { var noid = value; } }



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
        ///    The Model name of this class is <see cref="DocConstantModelName.FEATURESET" />
        /// </summary>
        public static readonly DocConstantModelName MODEL_NAME = DocConstantModelName.FEATURESET;

        /// <summary>
        ///    The Model name of this instance is always the same as <see cref="MODEL_NAME" />
        /// </summary>
        public override DocConstantModelName ModelName
        {
            get { return MODEL_NAME; }
        }
        
        public const string CACHE_KEY_PREFIX = "FindFeatureSets";

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
                throw new HttpError(HttpStatusCode.Conflict, $"FeatureSet requires: {ValidationMessage.Message}.");
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
            Feature = Feature?.TrimAndPruneSpaces();
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
            if (!ret) throw new ServiceStack.HttpError(System.Net.HttpStatusCode.Forbidden, $"You do not have permission to unlock this {nameof(FeatureSet)}");
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
            DocCacheClient.RemoveSearch("FeatureSet");
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

                if(DocTools.IsNullOrEmpty(Feature))
                {
                    isValid = false;
                    message += " Feature is a required property.";
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }

        }

        #endregion Validation

        #region Hash

        
        public static Guid GetGuid(DocEntityFeatureSet thing)
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

        public FeatureSet ToDto() => Mapper.Map<DocEntityFeatureSet, FeatureSet>(this);

        public override IDto ToIDto() => ToDto();

        #endregion Converters
    }

    public partial class FeatureSetMapper : Profile
    {
        private IMappingExpression<DocEntityFeatureSet,FeatureSet> _EntityToDto;
        private IMappingExpression<FeatureSet,DocEntityFeatureSet> _DtoToEntity;

        public FeatureSetMapper()
        {
            CreateMap<DocEntitySet<DocEntityFeatureSet>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityFeatureSet,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityFeatureSet>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityFeatureSet.GetFeatureSet(c));
            _EntityToDto = CreateMap<DocEntityFeatureSet,FeatureSet>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<FeatureSet>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<FeatureSet>(c, "Updated")))
                .ForMember(dest => dest.Description, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<FeatureSet>(c, nameof(DocEntityFeatureSet.Description))))
                .ForMember(dest => dest.Feature, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<FeatureSet>(c, nameof(DocEntityFeatureSet.Feature))))
                .ForMember(dest => dest.Name, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<FeatureSet>(c, nameof(DocEntityFeatureSet.Name))))
                .ForMember(dest => dest.Roles, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<FeatureSet>(c, nameof(DocEntityFeatureSet.Roles))))
                .ForMember(dest => dest.RolesCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<FeatureSet>(c, nameof(DocEntityFeatureSet.RolesCount))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<FeatureSet,DocEntityFeatureSet>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}