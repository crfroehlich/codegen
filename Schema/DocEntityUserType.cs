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
    [TableMapping(DocConstantModelName.USERTYPE)]
    public partial class DocEntityUserType : DocEntityBase
    {
        private const string USERTYPE_CACHE = "UserTypeCache";

        #region Constructor
        public DocEntityUserType(Session session) : base(session) {}

        public DocEntityUserType() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        #region VisibleFields
        private List<string> __vf;
        private List<string> _visibleFields
        {
            get
            {
                if(null == __vf)
                {
                    __vf = DocWebSession.GetTypeVisibleFields(new UserType());
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
        public static DocEntityUserType GetUserType(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetUserType(reference.Id) : null;
        }

        public static DocEntityUserType GetUserType(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityUserType>.GetFromCache(primaryKey, USERTYPE_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityUserType>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityUserType>.UpdateCache(ret.Id, ret, USERTYPE_CACHE);
                    DocEntityThreadCache<DocEntityUserType>.UpdateCache(ret.Hash, ret, USERTYPE_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityUserType GetUserType(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityUserType>.GetFromCache(hash, USERTYPE_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityUserType>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityUserType>.UpdateCache(ret.Id, ret, USERTYPE_CACHE);
                    DocEntityThreadCache<DocEntityUserType>.UpdateCache(ret.Hash, ret, USERTYPE_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field()]
        [FieldMapping(nameof(PayrollStatus))]
        public DocEntityLookupTable PayrollStatus { get; set; }
        public int? PayrollStatusId { get { return PayrollStatus?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(PayrollType))]
        public DocEntityLookupTable PayrollType { get; set; }
        public int? PayrollTypeId { get { return PayrollType?.Id; } private set { var noid = value; } }


        [Field(Nullable = false)]
        [FieldMapping(nameof(Type))]
        public DocEntityLookupTable Type { get; set; }
        public int? TypeId { get { return Type?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Users))]
        public DocEntitySet<DocEntityUser> Users { get; private set; }


        public int? UsersCount { get { return Users.Count(); } private set { var noid = value; } }



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
        public static readonly DocConstantModelName MODEL_NAME = DocConstantModelName.USERTYPE;

        public override DocConstantModelName ModelName => MODEL_NAME;

        public const string CACHE_KEY_PREFIX = "FindUserTypes";


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
                throw new HttpError(HttpStatusCode.Conflict, $"UserType requires: {ValidationMessage.Message}.");
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
            if (!ret) throw new ServiceStack.HttpError(System.Net.HttpStatusCode.Forbidden, $"You do not have permission to unlock this {nameof(UserType)}");
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
            DocCacheClient.RemoveSearch("UserType");
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

                if(null != PayrollStatus && PayrollStatus?.Enum?.Name != "UserPayrollStatus")
                {
                    isValid = false;
                    message += " PayrollStatus is a " + PayrollStatus?.Enum?.Name + ", but must be a UserPayrollStatus.";
                }
                if(null != PayrollType && PayrollType?.Enum?.Name != "UserPayrollType")
                {
                    isValid = false;
                    message += " PayrollType is a " + PayrollType?.Enum?.Name + ", but must be a UserPayrollType.";
                }
                if(DocTools.IsNullOrEmpty(Type))
                {
                    isValid = false;
                    message += " Type is a required property.";
                }
                else
                {
                    if(Type.Enum?.Name != "UserEmployeeType")
                    {
                        isValid = false;
                        message += " Type is a " + Type.Enum.Name + ", but must be a UserEmployeeType.";
                    }
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Hash
        
        public static Guid GetGuid(DocEntityUserType thing)
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

        public UserType ToDto() => Mapper.Map<DocEntityUserType, UserType>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }

    public partial class UserTypeMapper : Profile
    {
        private IMappingExpression<DocEntityUserType,UserType> _EntityToDto;
        private IMappingExpression<UserType,DocEntityUserType> _DtoToEntity;

        public UserTypeMapper()
        {
            CreateMap<DocEntitySet<DocEntityUserType>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityUserType,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityUserType>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityUserType.GetUserType(c));
            _EntityToDto = CreateMap<DocEntityUserType,UserType>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UserType>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UserType>(c, "Updated")))
                .ForMember(dest => dest.PayrollStatus, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UserType>(c, nameof(DocEntityUserType.PayrollStatus))))
                .ForMember(dest => dest.PayrollStatusId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UserType>(c, nameof(DocEntityUserType.PayrollStatusId))))
                .ForMember(dest => dest.PayrollType, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UserType>(c, nameof(DocEntityUserType.PayrollType))))
                .ForMember(dest => dest.PayrollTypeId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UserType>(c, nameof(DocEntityUserType.PayrollTypeId))))
                .ForMember(dest => dest.Type, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UserType>(c, nameof(DocEntityUserType.Type))))
                .ForMember(dest => dest.TypeId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UserType>(c, nameof(DocEntityUserType.TypeId))))
                .ForMember(dest => dest.Users, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UserType>(c, nameof(DocEntityUserType.Users))))
                .ForMember(dest => dest.UsersCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UserType>(c, nameof(DocEntityUserType.UsersCount))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<UserType,DocEntityUserType>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}