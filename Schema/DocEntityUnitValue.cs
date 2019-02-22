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
    [TableMapping(DocConstantModelName.UNITVALUE)]
    public partial class DocEntityUnitValue : DocEntityBase
    {
        private const string UNITVALUE_CACHE = "UnitValueCache";

        #region Constructor
        public DocEntityUnitValue(Session session) : base(session) {}

        public DocEntityUnitValue() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        #region VisibleFields
        private List<string> __vf;
        private List<string> _visibleFields
        {
            get
            {
                if(null == __vf)
                {
                    __vf = DocWebSession.GetTypeVisibleFields(new UnitValue());
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
        public static DocEntityUnitValue GetUnitValue(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetUnitValue(reference.Id) : null;
        }

        public static DocEntityUnitValue GetUnitValue(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityUnitValue>.GetFromCache(primaryKey, UNITVALUE_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityUnitValue>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityUnitValue>.UpdateCache(ret.Id, ret, UNITVALUE_CACHE);
                    DocEntityThreadCache<DocEntityUnitValue>.UpdateCache(ret.Hash, ret, UNITVALUE_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityUnitValue GetUnitValue(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityUnitValue>.GetFromCache(hash, UNITVALUE_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityUnitValue>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityUnitValue>.UpdateCache(ret.Id, ret, UNITVALUE_CACHE);
                    DocEntityThreadCache<DocEntityUnitValue>.UpdateCache(ret.Hash, ret, UNITVALUE_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field()]
        [FieldMapping(nameof(EqualityOperator))]
        public DocEntityLookupTable EqualityOperator { get; set; }
        public int? EqualityOperatorId { get { return EqualityOperator?.Id; } private set { var noid = value; } }


        [Field(Nullable = false, DefaultValue = 1)]
        [FieldMapping(nameof(Multiplier))]
        public int Multiplier { get; set; }


        [Field(Precision = 38, Scale = 6)]
        [FieldMapping(nameof(Number))]
        public decimal? Number { get; set; }


        [Field(Nullable = false, DefaultValue = 1)]
        [FieldMapping(nameof(Order))]
        public int Order { get; set; }


        [Field()]
        [FieldMapping(nameof(Owners))]
        public DocEntitySet<DocEntityUnits> Owners { get; private set; }


        public int? OwnersCount { get { return Owners.Count(); } private set { var noid = value; } }


        [Field(Nullable = false)]
        [FieldMapping(nameof(Unit))]
        public DocEntityUnitOfMeasure Unit { get; set; }
        public int? UnitId { get { return Unit?.Id; } private set { var noid = value; } }



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
        public static readonly DocConstantModelName MODEL_NAME = DocConstantModelName.UNITVALUE;

        public override DocConstantModelName ModelName => MODEL_NAME;

        public const string CACHE_KEY_PREFIX = "FindUnitValues";


        private DocUnitValue _model = null;

        public DocUnitValue ToUnitValue()
        {
            if(null == _model)
            {
                _model = DocUnitValue.GetUnitValue(this);
            }
            return _model;
        }

        public override T ToModel<T>() =>  (T) ((IDocModel) ToUnitValue());

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
                throw new HttpError(HttpStatusCode.Conflict, $"UnitValue requires: {ValidationMessage.Message}.");
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
            if (!ret) throw new ServiceStack.HttpError(System.Net.HttpStatusCode.Forbidden, $"You do not have permission to unlock this {nameof(UnitValue)}");
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
            DocCacheClient.RemoveSearch("UnitValue");
        }
        #endregion Entity overrides

        #region Validation
        public DocValidationMessage ValidationMessage
        {
            get
            {
                var isValid = true;
                var message = string.Empty;

                if(null != EqualityOperator && EqualityOperator?.Enum?.Name != "EqualityOperator")
                {
                    isValid = false;
                    message += " EqualityOperator is a " + EqualityOperator?.Enum?.Name + ", but must be a EqualityOperator.";
                }
                if(DocTools.IsNullOrEmpty(Multiplier))
                {
                    isValid = false;
                    message += " Multiplier is a required property.";
                }
                if(DocTools.IsNullOrEmpty(Order))
                {
                    isValid = false;
                    message += " Order is a required property.";
                }
                if(DocTools.IsNullOrEmpty(Unit))
                {
                    isValid = false;
                    message += " Unit is a required property.";
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Hash

        public static Guid GetGuid(DocUnitValue thing)
        {
                var guid = Guid.Empty;
            if(thing == null) return guid;
            
            var ret = new DocCommaDelimitedString();

            
                if(null == thing.EqualityOperator || thing.EqualityOperator.Id <= 0)
                {
                    ret.Add($"EqualityOperator:{DocConvert.NullGuid}");
                }
                else
                {
                    ret.Add($"EqualityOperator:{thing.EqualityOperator.Id}");
            }
                if(null == thing.Multiplier)
                {
                    ret.Add($"Multiplier:{DocConvert.NullGuid}");
                }
                else
                {
                    if(int.MinValue == thing.Multiplier)
                    {
                        ret.Add($"Multiplier:{DocConvert.NullGuid}");
                    }
                    else
                    {
                        ret.Add($"Multiplier:{thing.Multiplier}");
                    }
            }
                if(null == thing.Number)
                {
                    ret.Add($"Number:{DocConvert.NullGuid}");
                }
                else
                {
                    if(null == thing.Number)
                    {
                        ret.Add($"Number:{DocConvert.NullGuid}");
                    }
                    else
                    {
                        ret.Add($"Number:{DocConvert.DecimalToDisplayString(thing.Number)}");
                    }
            }
                if(null == thing.Order)
                {
                    ret.Add($"Order:{DocConvert.NullGuid}");
                }
                else
                {
                    if(int.MinValue == thing.Order)
                    {
                        ret.Add($"Order:{DocConvert.NullGuid}");
                    }
                    else
                    {
                        ret.Add($"Order:{thing.Order}");
                    }
            }
                if(null == thing.Unit || thing.Unit.Id <= 0)
                {
                    ret.Add($"Unit:{DocConvert.NullGuid}");
                }
                else
                {
                    ret.Add($"Unit:{thing.Unit.Id}");
            }

            guid = ret.ToString().GetGUIDFromMD5Hash();

            

            return guid;
        }
    
        
        public static Guid GetGuid(DocEntityUnitValue thing)
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

        public UnitValue ToDto() => Mapper.Map<DocEntityUnitValue, UnitValue>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }

    public partial class UnitValueMapper : Profile
    {
        private IMappingExpression<DocEntityUnitValue,UnitValue> _EntityToDto;
        private IMappingExpression<UnitValue,DocEntityUnitValue> _DtoToEntity;
        private IMappingExpression<DocUnitValue,UnitValue> _ModelToDto;

        public UnitValueMapper()
        {
            CreateMap<DocEntitySet<DocEntityUnitValue>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityUnitValue,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityUnitValue>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityUnitValue.GetUnitValue(c));
            _EntityToDto = CreateMap<DocEntityUnitValue,UnitValue>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UnitValue>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UnitValue>(c, "Updated")))
                .ForMember(dest => dest.EqualityOperator, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UnitValue>(c, nameof(DocEntityUnitValue.EqualityOperator))))
                .ForMember(dest => dest.EqualityOperatorId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UnitValue>(c, nameof(DocEntityUnitValue.EqualityOperatorId))))
                .ForMember(dest => dest.Multiplier, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UnitValue>(c, nameof(DocEntityUnitValue.Multiplier))))
                .ForMember(dest => dest.Number, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UnitValue>(c, nameof(DocEntityUnitValue.Number))))
                .ForMember(dest => dest.Order, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UnitValue>(c, nameof(DocEntityUnitValue.Order))))
                .ForMember(dest => dest.Owners, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UnitValue>(c, nameof(DocEntityUnitValue.Owners))))
                .ForMember(dest => dest.OwnersCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UnitValue>(c, nameof(DocEntityUnitValue.OwnersCount))))
                .ForMember(dest => dest.Unit, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UnitValue>(c, nameof(DocEntityUnitValue.Unit))))
                .ForMember(dest => dest.UnitId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UnitValue>(c, nameof(DocEntityUnitValue.UnitId))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<UnitValue,DocEntityUnitValue>()
                .MaxDepth(2);
            _ModelToDto = CreateMap<DocUnitValue,UnitValue>()
                .ForMember(dest => dest.EqualityOperator, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UnitValue>(c, nameof(DocEntityUnitValue.EqualityOperator))))
                .ForMember(dest => dest.Multiplier, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UnitValue>(c, nameof(DocEntityUnitValue.Multiplier))))
                .ForMember(dest => dest.Number, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UnitValue>(c, nameof(DocEntityUnitValue.Number))))
                .ForMember(dest => dest.Order, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UnitValue>(c, nameof(DocEntityUnitValue.Order))))
                .ForMember(dest => dest.Owners, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UnitValue>(c, nameof(DocEntityUnitValue.Owners))))
                .ForMember(dest => dest.Unit, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UnitValue>(c, nameof(DocEntityUnitValue.Unit))))
.MaxDepth(2);
            CreateMap<DocUnitValue, Reference>()
                .ForMember(dest => dest.Name, opt => opt.Ignore() );
            CreateMap<Reference, DocUnitValue>()
                .ForAllMembers(opt => opt.Ignore() );
            ApplyCustomMaps();
        }
    }
}