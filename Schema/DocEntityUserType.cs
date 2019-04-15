//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated by a T4 template. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using AutoMapper;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Dynamic;
using System.Linq.Expressions;
using System.Net;
using System.Reflection;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using Services.Core;
using Services.Db;
using Services.Dto;
using Services.Dto.internals;
using Services.Dto.Security;
using Services.Enums;
using Services.Models;
using Services.Schema;

using ServiceStack;
using ServiceStack.Text;

using Typed;
using Typed.Bindings;
using Typed.Notifications;
using Typed.Settings;

using Xtensive.Orm;
using Xtensive.Orm.Model;

using Attribute = Services.Dto.Attribute;
using ValueType = Services.Dto.ValueType;
using Version = Services.Dto.Version;

namespace Services.Schema
{
    [TableMapping(DocConstantModelName.USERTYPE)]
    public partial class DocEntityUserType : DocEntityBase
    {
        private const string USERTYPE_CACHE = "UserTypeCache";
        public const string TABLE_NAME = DocConstantModelName.USERTYPE;
        
        #region Constructor
        public DocEntityUserType(Session session) : base(session) {}

        public DocEntityUserType() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        #region VisibleFields

        protected override List<string> _visibleFields
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
        [Field]
        public DocEntityLookupTable PayrollStatus { get; set; }
        public int? PayrollStatusId { get { return PayrollStatus?.Id; } private set { var noid = value; } }


        [Field]
        public DocEntityLookupTable PayrollType { get; set; }
        public int? PayrollTypeId { get { return PayrollType?.Id; } private set { var noid = value; } }


        [Field(Nullable = false)]
        public DocEntityLookupTable Type { get; set; }
        public int? TypeId { get { return Type?.Id; } private set { var noid = value; } }


        [Field]
        public DocEntitySet<DocEntityUser> Users { get; private set; }


        public int? UsersCount { get { return Users.Count(); } private set { var noid = value; } }



        [Field]
        public override string Gestalt { get; set; }

        [Field(DefaultValue = 0), Version(VersionMode.Manual)]
        public override int VersionNo { get; set; }

        [Field]
        public override DateTime? Created { get; set; }

        [Field]
        public override DateTime? Updated { get; set; }

        [Field(DefaultValue = false), FieldMapping(nameof(Locked))]
        public override bool Locked { get; set; }

        [Field(DefaultValue = false), FieldMapping(nameof(Archived))]
        public override bool Archived { get; set; }

        #endregion Properties

        #region Overrides of DocEntity

        public override DocConstantModelName TableName => TABLE_NAME;

        public const string CACHE_KEY_PREFIX = "FindUserTypes";

        #endregion Overrides of DocEntity

        #region Entity overrides
        /// <summary>
        ///    Called when entity is about to be removed.
        /// </summary>
        protected override void OnRemoving()
        {

            base.OnRemoving();
            FlushCache();
        }

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
            _validated = true;
        }

        public override IDocEntity SaveChanges(bool ignoreCache, DocConstantPermission permission)
        {

            return base.SaveChanges(ignoreCache, permission);
        }

        public override IDocEntity SaveChanges(bool ignoreCache) => SaveChanges(ignoreCache, DocConstantPermission.EDIT);
        public override IDocEntity SaveChanges(DocConstantPermission permission) => SaveChanges(false, DocConstantPermission.EDIT);
        public override IDocEntity SaveChanges() => SaveChanges(DocConstantPermission.EDIT);

        public override void FlushCache()
        {
            base.FlushCache();
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

        #region Converters

        public UserType ToDto() => Mapper.Map<DocEntityUserType, UserType>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }

    public static partial class UniqueConstraintFilter
    {
        public static Expression<Func<DocEntityUserType, bool>> UserTypeIgnoreArchived() => d => d.Archived == false;
    }

    public partial class UserTypeMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityUserType,UserType> _EntityToDto;
        protected IMappingExpression<UserType,DocEntityUserType> _DtoToEntity;

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
