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
    [TableMapping(DocConstantModelName.VALUETYPE)]
    public partial class DocEntityValueType : DocEntityBase
    {
        private const string VALUETYPE_CACHE = "ValueTypeCache";
        public const string TABLE_NAME = DocConstantModelName.VALUETYPE;
        
        #region Constructor
        public DocEntityValueType(Session session) : base(session) {}

        public DocEntityValueType() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        #region VisibleFields

        protected override List<string> _visibleFields
        {
            get
            {
                if(null == __vf)
                {
                    __vf = DocWebSession.GetTypeVisibleFields(new ValueType());
                }
                return __vf;
            }
        }

        #endregion VisibleFields

        #region Static Members
        public static DocEntityValueType GetValueType(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetValueType(reference.Id) : null;
        }

        public static DocEntityValueType GetValueType(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityValueType>.GetFromCache(primaryKey, VALUETYPE_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityValueType>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityValueType>.UpdateCache(ret.Id, ret, VALUETYPE_CACHE);
                    DocEntityThreadCache<DocEntityValueType>.UpdateCache(ret.Hash, ret, VALUETYPE_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityValueType GetValueType(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityValueType>.GetFromCache(hash, VALUETYPE_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityValueType>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityValueType>.UpdateCache(ret.Id, ret, VALUETYPE_CACHE);
                    DocEntityThreadCache<DocEntityValueType>.UpdateCache(ret.Hash, ret, VALUETYPE_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field]
        public DocEntityLookupTable FieldType { get; set; }
        public int? FieldTypeId { get { return FieldType?.Id; } private set { var noid = value; } }


        [Field(Nullable = false)]
        public DocEntityLookupTable Name { get; set; }
        public int? NameId { get { return Name?.Id; } private set { var noid = value; } }



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

        public const string CACHE_KEY_PREFIX = "FindValueTypes";

        #endregion Overrides of DocEntity

        #region Entity overrides
        /// <summary>
        ///    Called when entity is about to be removed.
        /// </summary>
        protected override void OnRemoving()
        {

            base.OnRemoving();
        }

        /// <summary>
        ///    Called when entity should be validated. Override this method to perform custom object validation.
        /// </summary>
        protected override void OnValidate()
        {
            if (false == ValidationMessage.IsValid)
            {
                throw new HttpError(HttpStatusCode.Conflict, $"ValueType requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();

            FlushCache();

            _validated = true;


        }

        public override IDocEntity SaveChanges(DocConstantPermission permission = null)
        {

            return base.SaveChanges(permission);
        }

        public override void FlushCache()
        {
            base.FlushCache();

        }
        #endregion Entity overrides

        #region Validation
        public DocValidationMessage ValidationMessage
        {
            get
            {
                var isValid = true;
                var message = string.Empty;

                if(null != FieldType && FieldType?.Enum?.Name != "FieldType")
                {
                    isValid = false;
                    message += " FieldType is a " + FieldType?.Enum?.Name + ", but must be a FieldType.";
                }
                if(DocTools.IsNullOrEmpty(Name))
                {
                    isValid = false;
                    message += " Name is a required property.";
                }
                else
                {
                    if(Name.Enum?.Name != "ValueType")
                    {
                        isValid = false;
                        message += " Name is a " + Name.Enum.Name + ", but must be a ValueType.";
                    }
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Converters

        public ValueType ToDto() => Mapper.Map<DocEntityValueType, ValueType>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }

    public static partial class UniqueConstraintFilter
    {
        public static Expression<Func<DocEntityValueType, bool>> ValueTypeIgnoreArchived() => d => d.Archived == false;
    }

    public partial class ValueTypeMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityValueType,ValueType> _EntityToDto;
        protected IMappingExpression<ValueType,DocEntityValueType> _DtoToEntity;

        public ValueTypeMapper()
        {
            CreateMap<DocEntitySet<DocEntityValueType>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityValueType,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityValueType>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityValueType.GetValueType(c));
            _EntityToDto = CreateMap<DocEntityValueType,ValueType>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<ValueType>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<ValueType>(c, "Updated")))
                .ForMember(dest => dest.FieldType, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<ValueType>(c, nameof(DocEntityValueType.FieldType))))
                .ForMember(dest => dest.FieldTypeId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<ValueType>(c, nameof(DocEntityValueType.FieldTypeId))))
                .ForMember(dest => dest.Name, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<ValueType>(c, nameof(DocEntityValueType.Name))))
                .ForMember(dest => dest.NameId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<ValueType>(c, nameof(DocEntityValueType.NameId))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<ValueType,DocEntityValueType>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
