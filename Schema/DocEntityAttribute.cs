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
    [TableMapping(DocConstantModelName.ATTRIBUTE)]
    public partial class DocEntityAttribute : DocEntityBase
    {
        private const string ATTRIBUTE_CACHE = "AttributeCache";

        #region Constructor
        public DocEntityAttribute(Session session) : base(session) {}

        public DocEntityAttribute() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        #region VisibleFields
        private List<string> __vf;
        private List<string> _visibleFields
        {
            get
            {
                if(null == __vf)
                {
                    __vf = DocWebSession.GetTypeVisibleFields(new Attribute());
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
        public static DocEntityAttribute GetAttribute(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetAttribute(reference.Id) : null;
        }

        public static DocEntityAttribute GetAttribute(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityAttribute>.GetFromCache(primaryKey, ATTRIBUTE_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityAttribute>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityAttribute>.UpdateCache(ret.Id, ret, ATTRIBUTE_CACHE);
                    DocEntityThreadCache<DocEntityAttribute>.UpdateCache(ret.Hash, ret, ATTRIBUTE_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityAttribute GetAttribute(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityAttribute>.GetFromCache(hash, ATTRIBUTE_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityAttribute>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityAttribute>.UpdateCache(ret.Id, ret, ATTRIBUTE_CACHE);
                    DocEntityThreadCache<DocEntityAttribute>.UpdateCache(ret.Hash, ret, ATTRIBUTE_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field(Nullable = false)]
        [FieldMapping(nameof(AttributeName))]
        public DocEntityLookupTable AttributeName { get; set; }
        public int? AttributeNameId { get { return AttributeName?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(AttributeType))]
        public DocEntityLookupTable AttributeType { get; set; }
        public int? AttributeTypeId { get { return AttributeType?.Id; } private set { var noid = value; } }


        [Field(Nullable = false)]
        [FieldMapping(nameof(Interval))]
        public DocEntityAttributeInterval Interval { get; set; }
        public int? IntervalId { get { return Interval?.Id; } private set { var noid = value; } }


        [Field(Nullable = false, DefaultValue = false)]
        [FieldMapping(nameof(IsCharacteristic))]
        public bool IsCharacteristic { get; set; }


        [Field(Nullable = false, DefaultValue = false)]
        [FieldMapping(nameof(IsOutcome))]
        public bool IsOutcome { get; set; }


        [Field(DefaultValue = false)]
        [FieldMapping(nameof(IsPositive))]
        public bool? IsPositive { get; set; }


        [Field()]
        [FieldMapping(nameof(UniqueKey))]
        public string UniqueKey { get; set; }


        [Field(Nullable = false)]
        [FieldMapping(nameof(ValueType))]
        public DocEntityValueType ValueType { get; set; }
        public int? ValueTypeId { get { return ValueType?.Id; } private set { var noid = value; } }



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
        public static readonly DocConstantModelName MODEL_NAME = DocConstantModelName.ATTRIBUTE;

        public override DocConstantModelName ModelName => MODEL_NAME;

        public const string CACHE_KEY_PREFIX = "FindAttributes";


        private DocAttribute _model = null;

        public DocAttribute ToAttribute()
        {
            if(null == _model)
            {
                _model = DocAttribute.GetAttribute(this);
            }
            return _model;
        }

        public override T ToModel<T>() =>  (T) ((IDocModel) ToAttribute());

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
                throw new HttpError(HttpStatusCode.Conflict, $"Attribute requires: {ValidationMessage.Message}.");
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

            UniqueKey = UniqueKey?.TrimAndPruneSpaces();

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
            if (!ret) throw new ServiceStack.HttpError(System.Net.HttpStatusCode.Forbidden, $"You do not have permission to unlock this {nameof(Attribute)}");
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
            DocCacheClient.RemoveSearch("Attribute");
        }
        #endregion Entity overrides

        #region Validation
        public DocValidationMessage ValidationMessage
        {
            get
            {
                var isValid = true;
                var message = string.Empty;

                if(DocTools.IsNullOrEmpty(AttributeName))
                {
                    isValid = false;
                    message += " AttributeName is a required property.";
                }
                else
                {
                    if(AttributeName.Enum?.Name != "AttributeName")
                    {
                        isValid = false;
                        message += " AttributeName is a " + AttributeName.Enum.Name + ", but must be a AttributeName.";
                    }
                }
                if(null != AttributeType && AttributeType?.Enum?.Name != "AttributeType")
                {
                    isValid = false;
                    message += " AttributeType is a " + AttributeType?.Enum?.Name + ", but must be a AttributeType.";
                }
                if(DocTools.IsNullOrEmpty(Interval))
                {
                    isValid = false;
                    message += " Interval is a required property.";
                }
                if(DocTools.IsNullOrEmpty(IsCharacteristic))
                {
                    isValid = false;
                    message += " IsCharacteristic is a required property.";
                }
                if(DocTools.IsNullOrEmpty(IsOutcome))
                {
                    isValid = false;
                    message += " IsOutcome is a required property.";
                }
                if(DocTools.IsNullOrEmpty(ValueType))
                {
                    isValid = false;
                    message += " ValueType is a required property.";
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Hash

        public static Guid GetGuid(DocAttribute thing)
        {
                var guid = Guid.Empty;
            if(thing == null) return guid;
            
            var ret = new DocCommaDelimitedString();

            
                if(null == thing.AttributeName || thing.AttributeName.Id <= 0)
                {
                    ret.Add($"AttributeName:{DocConvert.NullGuid}");
                }
                else
                {
                    ret.Add($"AttributeName:{thing.AttributeName.Id}");
            }
                if(null == thing.AttributeType || thing.AttributeType.Id <= 0)
                {
                    ret.Add($"AttributeType:{DocConvert.NullGuid}");
                }
                else
                {
                    ret.Add($"AttributeType:{thing.AttributeType.Id}");
            }
                if(null == thing.Interval || thing.Interval.Id <= 0)
                {
                    ret.Add($"Interval:{DocConvert.NullGuid}");
                }
                else
                {
                    ret.Add($"Interval:{thing.Interval.Id}");
            }
                if(null == thing.IsCharacteristic)
                {
                    ret.Add($"IsCharacteristic:{DocConvert.NullGuid}");
                }
                else
                {
                    ret.Add($"IsCharacteristic:{thing.IsCharacteristic}");
            }
                if(null == thing.IsOutcome)
                {
                    ret.Add($"IsOutcome:{DocConvert.NullGuid}");
                }
                else
                {
                    ret.Add($"IsOutcome:{thing.IsOutcome}");
            }
                if(null == thing.IsPositive)
                {
                    ret.Add($"IsPositive:{DocConvert.NullGuid}");
                }
                else
                {
                    ret.Add($"IsPositive:{thing.IsPositive}");
            }
                if(null == thing.UniqueKey)
                {
                    ret.Add($"UniqueKey:{DocConvert.NullGuid}");
                }
                else
                {
                    ret.Add($"UniqueKey:{thing.UniqueKey.Trim().ToLower()}");
            }
                if(null == thing.ValueType || thing.ValueType.Id <= 0)
                {
                    ret.Add($"ValueType:{DocConvert.NullGuid}");
                }
                else
                {
                    ret.Add($"ValueType:{thing.ValueType.Id}");
            }

            guid = ret.ToString().GetGUIDFromMD5Hash();

            

            return guid;
        }
    
        
        public static Guid GetGuid(DocEntityAttribute thing)
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

        public Attribute ToDto() => Mapper.Map<DocEntityAttribute, Attribute>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }

    public partial class AttributeMapper : DocMapperBase
    {
        private IMappingExpression<DocEntityAttribute,Attribute> _EntityToDto;
        private IMappingExpression<Attribute,DocEntityAttribute> _DtoToEntity;
        private IMappingExpression<DocAttribute,Attribute> _ModelToDto;

        public AttributeMapper()
        {
            CreateMap<DocEntitySet<DocEntityAttribute>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityAttribute,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityAttribute>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityAttribute.GetAttribute(c));
            _EntityToDto = CreateMap<DocEntityAttribute,Attribute>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Attribute>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Attribute>(c, "Updated")))
                .ForMember(dest => dest.AttributeName, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Attribute>(c, nameof(DocEntityAttribute.AttributeName))))
                .ForMember(dest => dest.AttributeNameId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Attribute>(c, nameof(DocEntityAttribute.AttributeNameId))))
                .ForMember(dest => dest.AttributeType, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Attribute>(c, nameof(DocEntityAttribute.AttributeType))))
                .ForMember(dest => dest.AttributeTypeId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Attribute>(c, nameof(DocEntityAttribute.AttributeTypeId))))
                .ForMember(dest => dest.Interval, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Attribute>(c, nameof(DocEntityAttribute.Interval))))
                .ForMember(dest => dest.IntervalId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Attribute>(c, nameof(DocEntityAttribute.IntervalId))))
                .ForMember(dest => dest.IsCharacteristic, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Attribute>(c, nameof(DocEntityAttribute.IsCharacteristic))))
                .ForMember(dest => dest.IsOutcome, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Attribute>(c, nameof(DocEntityAttribute.IsOutcome))))
                .ForMember(dest => dest.IsPositive, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Attribute>(c, nameof(DocEntityAttribute.IsPositive))))
                .ForMember(dest => dest.UniqueKey, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Attribute>(c, nameof(DocEntityAttribute.UniqueKey))))
                .ForMember(dest => dest.ValueType, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Attribute>(c, nameof(DocEntityAttribute.ValueType))))
                .ForMember(dest => dest.ValueTypeId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Attribute>(c, nameof(DocEntityAttribute.ValueTypeId))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<Attribute,DocEntityAttribute>()
                .MaxDepth(2);
            _ModelToDto = CreateMap<DocAttribute,Attribute>()
                .ForMember(dest => dest.AttributeName, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Attribute>(c, nameof(DocEntityAttribute.AttributeName))))
                .ForMember(dest => dest.AttributeType, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Attribute>(c, nameof(DocEntityAttribute.AttributeType))))
                .ForMember(dest => dest.Interval, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Attribute>(c, nameof(DocEntityAttribute.Interval))))
                .ForMember(dest => dest.IsCharacteristic, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Attribute>(c, nameof(DocEntityAttribute.IsCharacteristic))))
                .ForMember(dest => dest.IsOutcome, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Attribute>(c, nameof(DocEntityAttribute.IsOutcome))))
                .ForMember(dest => dest.IsPositive, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Attribute>(c, nameof(DocEntityAttribute.IsPositive))))
                .ForMember(dest => dest.UniqueKey, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Attribute>(c, nameof(DocEntityAttribute.UniqueKey))))
                .ForMember(dest => dest.ValueType, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Attribute>(c, nameof(DocEntityAttribute.ValueType))))
.MaxDepth(2);
            CreateMap<DocAttribute, Reference>()
                .ForMember(dest => dest.Name, opt => opt.Ignore() );
            CreateMap<Reference, DocAttribute>()
                .ForAllMembers(opt => opt.Ignore() );
            ApplyCustomMaps();
        }
    }
}