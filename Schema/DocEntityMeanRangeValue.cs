
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
    [TableMapping(DocConstantModelName.MEANRANGEVALUE)]
    public partial class DocEntityMeanRangeValue : DocEntityBase
    {
        private const string MEANRANGEVALUE_CACHE = "MeanRangeValueCache";
        public const string TABLE_NAME = DocConstantModelName.MEANRANGEVALUE;
        
        #region Constructor
        public DocEntityMeanRangeValue(Session session) : base(session) {}

        public DocEntityMeanRangeValue() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        #region VisibleFields

        protected override List<string> _visibleFields
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
        public List<int> OwnersIds => Owners.Select(e => e.Id).ToList();




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

        public const string CACHE_KEY_PREFIX = "FindMeanRangeValues";

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
                throw new HttpError(HttpStatusCode.Conflict, $"MeanRangeValue requires: {ValidationMessage.Message}.");
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

        #region Converters

        public MeanRangeValue ToDto() => Mapper.Map<DocEntityMeanRangeValue, MeanRangeValue>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }

    public static partial class UniqueConstraintFilter
    {
        public static Expression<Func<DocEntityMeanRangeValue, bool>> MeanRangeValueIgnoreArchived() => d => d.Archived == false;
    }

    public partial class MeanRangeValueMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityMeanRangeValue,MeanRangeValue> _EntityToDto;
        protected IMappingExpression<MeanRangeValue,DocEntityMeanRangeValue> _DtoToEntity;

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
            ApplyCustomMaps();
        }
    }
}
