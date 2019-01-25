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
    [TableMapping(DocConstantModelName.MEANRANGEVALUE)]
    public partial class DocEntityMeanRangeValue : DocEntityBase
    {
        private const string MEANRANGEVALUE_CACHE = "MeanRangeValueCache";

        #region Constructor
        public DocEntityMeanRangeValue(Session session) : base(session) {}

        public DocEntityMeanRangeValue() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        #region VisibleFields
        private List<string> __vf;
        private List<string> _visibleFields
        {
            get
            {
                if(null == __vf)
                {
                    __vf = DocWebSession.GetTypeVisibleFields(new MeanRangeValue());
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
        public static DocEntityMeanRangeValue GetMeanRangeValue(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetMeanRangeValue(reference.Id) : null;
        }

        public static DocEntityMeanRangeValue GetMeanRangeValue(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityMeanRangeValue>.GetFromCache(primaryKey, MEANRANGEVALUE_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityMeanRangeValue>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityMeanRangeValue>.UpdateCache(ret.Id, ret, MEANRANGEVALUE_CACHE);
                    DocEntityThreadCache<DocEntityMeanRangeValue>.UpdateCache(ret.Hash, ret, MEANRANGEVALUE_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityMeanRangeValue GetMeanRangeValue(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityMeanRangeValue>.GetFromCache(hash, MEANRANGEVALUE_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityMeanRangeValue>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityMeanRangeValue>.UpdateCache(ret.Id, ret, MEANRANGEVALUE_CACHE);
                    DocEntityThreadCache<DocEntityMeanRangeValue>.UpdateCache(ret.Hash, ret, MEANRANGEVALUE_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field()]
        [FieldMapping(nameof(MeanVarianceType))]
        public DocEntityLookupTable MeanVarianceType { get; set; }
        public int? MeanVarianceTypeId { get { return MeanVarianceType?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(MidSpread))]
        public DocStructureUnits MidSpread { get; set; }


        [Field(Nullable = false, DefaultValue = 0)]
        [FieldMapping(nameof(Order))]
        public int Order { get; set; }


        [Field()]
        [FieldMapping(nameof(Owners))]
        public DocEntitySet<DocEntityMeanRanges> Owners { get; private set; }


        public int? OwnersCount { get { return Owners.Count(); } private set { var noid = value; } }


        [Field(Precision = 16, Scale = 6)]
        [FieldMapping(nameof(Percent))]
        public decimal? Percent { get; set; }


        [Field(Precision = 16, Scale = 6)]
        [FieldMapping(nameof(PercentLow))]
        public decimal? PercentLow { get; set; }


        [Field()]
        [FieldMapping(nameof(Range))]
        public DocStructureUnitsRange Range { get; set; }


        [Field(Nullable = false)]
        [FieldMapping(nameof(Type))]
        public DocEntityLookupTable Type { get; set; }
        public int? TypeId { get { return Type?.Id; } private set { var noid = value; } }



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
        public static readonly DocConstantModelName MODEL_NAME = DocConstantModelName.MEANRANGEVALUE;

        public override DocConstantModelName ModelName => MODEL_NAME;

        public const string CACHE_KEY_PREFIX = "FindMeanRangeValues";


        private DocMeanRangeValue _model = null;

        public DocMeanRangeValue ToMeanRangeValue()
        {
            if(null == _model)
            {
                _model = DocMeanRangeValue.GetMeanRangeValue(this);
            }
            return _model;
        }

        public override T ToModel<T>() =>  (T) ((IDocModel) ToMeanRangeValue());

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
                throw new HttpError(HttpStatusCode.Conflict, $"MeanRangeValue requires: {ValidationMessage.Message}.");
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
            if (!ret) throw new ServiceStack.HttpError(System.Net.HttpStatusCode.Forbidden, $"You do not have permission to unlock this {nameof(MeanRangeValue)}");
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
            DocCacheClient.RemoveSearch("MeanRangeValue");
        }
        #endregion Entity overrides

        #region Validation
        public DocValidationMessage ValidationMessage
        {
            get
            {
                var isValid = true;
                var message = string.Empty;

                if(null != MeanVarianceType && MeanVarianceType?.Enum?.Name != "MeanVarianceType")
                {
                    isValid = false;
                    message += " MeanVarianceType is a " + MeanVarianceType?.Enum?.Name + ", but must be a MeanVarianceType.";
                }
                if(DocTools.IsNullOrEmpty(Order))
                {
                    isValid = false;
                    message += " Order is a required property.";
                }
                if(DocTools.IsNullOrEmpty(Type))
                {
                    isValid = false;
                    message += " Type is a required property.";
                }
                else
                {
                    if(Type.Enum?.Name != "MeanRangeType")
                    {
                        isValid = false;
                        message += " Type is a " + Type.Enum.Name + ", but must be a MeanRangeType.";
                    }
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Hash

        public static Guid GetGuid(DocMeanRangeValue thing)
        {
                var guid = Guid.Empty;
            if(thing == null) return guid;
            
            var ret = new DocCommaDelimitedString();

            
                if(null == thing.MeanVarianceType || thing.MeanVarianceType.Id <= 0)
                {
                    ret.Add($"MeanVarianceType:{DocConvert.NullGuid}");
                }
                else
                {
                    ret.Add($"MeanVarianceType:{thing.MeanVarianceType.Id}");
            }
                if(null == thing.MidSpread || null == thing.MidSpread.Units)
                {
                    ret.Add($"MidSpread:{DocConvert.NullGuid}");
                }
                else
                {
                    ret.Add($"MidSpread:{thing.MidSpread.GetGuid()}");
            }
                if(null == thing.Owners || false == thing.Owners.Any())
                {
                    ret.Add($"Owners:{DocConvert.NullGuid}");
                }
                else
                {
                    ret.Add($"Owners:{thing.Owners.GetGuid()}");
            }
                if(null == thing.Percent)
                {
                    ret.Add($"Percent:{DocConvert.NullGuid}");
                }
                else
                {
                    if(null == thing.Percent)
                    {
                        ret.Add($"Percent:{DocConvert.NullGuid}");
                    }
                    else
                    {
                        ret.Add($"Percent:{DocConvert.DecimalToDisplayString(thing.Percent)}");
                    }
            }
                if(null == thing.PercentLow)
                {
                    ret.Add($"PercentLow:{DocConvert.NullGuid}");
                }
                else
                {
                    if(null == thing.PercentLow)
                    {
                        ret.Add($"PercentLow:{DocConvert.NullGuid}");
                    }
                    else
                    {
                        ret.Add($"PercentLow:{DocConvert.DecimalToDisplayString(thing.PercentLow)}");
                    }
            }
                if(null == thing.Range || (null == thing.Range.High && null == thing.Range.Low))
                {
                    ret.Add($"Range:{DocConvert.NullGuid}");
                }
                else
                {
                    ret.Add($"Range:{thing.Range.GetGuid()}");
            }
                if(null == thing.Type || thing.Type.Id <= 0)
                {
                    ret.Add($"Type:{DocConvert.NullGuid}");
                }
                else
                {
                    ret.Add($"Type:{thing.Type.Id}");
            }

            guid = ret.ToString().GetGUIDFromMD5Hash();

            

            return guid;
        }
    
        
        public static Guid GetGuid(DocEntityMeanRangeValue thing)
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

        public MeanRangeValue ToDto() => Mapper.Map<DocEntityMeanRangeValue, MeanRangeValue>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }

    public partial class MeanRangeValueMapper : DocMapperBase
    {
        private IMappingExpression<DocEntityMeanRangeValue,MeanRangeValue> _EntityToDto;
        private IMappingExpression<MeanRangeValue,DocEntityMeanRangeValue> _DtoToEntity;
        private IMappingExpression<DocMeanRangeValue,MeanRangeValue> _ModelToDto;

        public MeanRangeValueMapper()
        {
            CreateMap<DocEntitySet<DocEntityMeanRangeValue>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityMeanRangeValue,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityMeanRangeValue>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityMeanRangeValue.GetMeanRangeValue(c));
            _EntityToDto = CreateMap<DocEntityMeanRangeValue,MeanRangeValue>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<MeanRangeValue>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<MeanRangeValue>(c, "Updated")))
                .ForMember(dest => dest.MeanVarianceType, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<MeanRangeValue>(c, nameof(DocEntityMeanRangeValue.MeanVarianceType))))
                .ForMember(dest => dest.MeanVarianceTypeId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<MeanRangeValue>(c, nameof(DocEntityMeanRangeValue.MeanVarianceTypeId))))
                .ForMember(dest => dest.MidSpread, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<MeanRangeValue>(c, nameof(DocEntityMeanRangeValue.MidSpread))))
                .ForMember(dest => dest.Order, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<MeanRangeValue>(c, nameof(DocEntityMeanRangeValue.Order))))
                .ForMember(dest => dest.Owners, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<MeanRangeValue>(c, nameof(DocEntityMeanRangeValue.Owners))))
                .ForMember(dest => dest.OwnersCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<MeanRangeValue>(c, nameof(DocEntityMeanRangeValue.OwnersCount))))
                .ForMember(dest => dest.Percent, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<MeanRangeValue>(c, nameof(DocEntityMeanRangeValue.Percent))))
                .ForMember(dest => dest.PercentLow, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<MeanRangeValue>(c, nameof(DocEntityMeanRangeValue.PercentLow))))
                .ForMember(dest => dest.Range, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<MeanRangeValue>(c, nameof(DocEntityMeanRangeValue.Range))))
                .ForMember(dest => dest.Type, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<MeanRangeValue>(c, nameof(DocEntityMeanRangeValue.Type))))
                .ForMember(dest => dest.TypeId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<MeanRangeValue>(c, nameof(DocEntityMeanRangeValue.TypeId))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<MeanRangeValue,DocEntityMeanRangeValue>()
                .MaxDepth(2);
            _ModelToDto = CreateMap<DocMeanRangeValue,MeanRangeValue>()
                .ForMember(dest => dest.MeanVarianceType, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<MeanRangeValue>(c, nameof(DocEntityMeanRangeValue.MeanVarianceType))))
                .ForMember(dest => dest.MidSpread, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<MeanRangeValue>(c, nameof(DocEntityMeanRangeValue.MidSpread))))
                .ForMember(dest => dest.Order, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<MeanRangeValue>(c, nameof(DocEntityMeanRangeValue.Order))))
                .ForMember(dest => dest.Owners, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<MeanRangeValue>(c, nameof(DocEntityMeanRangeValue.Owners))))
                .ForMember(dest => dest.Percent, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<MeanRangeValue>(c, nameof(DocEntityMeanRangeValue.Percent))))
                .ForMember(dest => dest.PercentLow, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<MeanRangeValue>(c, nameof(DocEntityMeanRangeValue.PercentLow))))
                .ForMember(dest => dest.Range, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<MeanRangeValue>(c, nameof(DocEntityMeanRangeValue.Range))))
                .ForMember(dest => dest.Type, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<MeanRangeValue>(c, nameof(DocEntityMeanRangeValue.Type))))
.MaxDepth(2);
            CreateMap<DocMeanRangeValue, Reference>()
                .ForMember(dest => dest.Name, opt => opt.Ignore() );
            CreateMap<Reference, DocMeanRangeValue>()
                .ForAllMembers(opt => opt.Ignore() );
            ApplyCustomMaps();
        }
    }
}