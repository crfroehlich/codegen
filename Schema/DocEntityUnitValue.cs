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
using System.Linq.Expressions;
using System.Net;
using System.Runtime.Serialization;

using Services.Core;
using Services.Db;
using Services.Dto;
using Services.Dto.internals;
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
        public const string TABLE_NAME = DocConstantModelName.UNITVALUE;
        
        #region Constructor
        public DocEntityUnitValue(Session session) : base(session) {}

        public DocEntityUnitValue() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        #region VisibleFields

        protected override List<string> _visibleFields
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

        [Field(DefaultValue = 0), Version(VersionMode.Manual)]
        public override int VersionNo { get; set; }

        [Field]
        public override DateTime? Created { get; set; }

        [Field]
        public override DateTime? Updated { get; set; }

        [Field(DefaultValue = false)]
        [FieldMapping(nameof(Locked))]
        public override bool Locked { get; set; }

        [Field(DefaultValue = false)]
        [FieldMapping(nameof(Archived))]
        public override bool Archived { get; set; }

        #endregion Properties

        #region Overrides of DocEntity

        public override DocConstantModelName TableName => TABLE_NAME;

        public const string CACHE_KEY_PREFIX = "FindUnitValues";

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
                throw new HttpError(HttpStatusCode.Conflict, $"UnitValue requires: {ValidationMessage.Message}.");
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

        #region Converters

        public UnitValue ToDto() => Mapper.Map<DocEntityUnitValue, UnitValue>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }

    public static partial class UniqueConstraintFilter
    {
        public static Expression<Func<DocEntityUnitValue, bool>> UnitValueIgnoreArchived() => d => d.Archived == false;
    }

    public partial class UnitValueMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityUnitValue,UnitValue> _EntityToDto;
        protected IMappingExpression<UnitValue,DocEntityUnitValue> _DtoToEntity;

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
            ApplyCustomMaps();
        }
    }
}