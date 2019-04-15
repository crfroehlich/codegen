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
    [TableMapping(DocConstantModelName.MEANVARIANCEVALUE)]
    public partial class DocEntityMeanVarianceValue : DocEntityBase
    {
        private const string MEANVARIANCEVALUE_CACHE = "MeanVarianceValueCache";
        public const string TABLE_NAME = DocConstantModelName.MEANVARIANCEVALUE;
        
        #region Constructor
        public DocEntityMeanVarianceValue(Session session) : base(session) {}

        public DocEntityMeanVarianceValue() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        #region VisibleFields

        protected override List<string> _visibleFields
        {
            get
            {
                if(null == __vf)
                {
                    __vf = DocWebSession.GetTypeVisibleFields(new MeanVarianceValue());
                }
                return __vf;
            }
        }

        #endregion VisibleFields

        #region Static Members
        public static DocEntityMeanVarianceValue GetMeanVarianceValue(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetMeanVarianceValue(reference.Id) : null;
        }

        public static DocEntityMeanVarianceValue GetMeanVarianceValue(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityMeanVarianceValue>.GetFromCache(primaryKey, MEANVARIANCEVALUE_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityMeanVarianceValue>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityMeanVarianceValue>.UpdateCache(ret.Id, ret, MEANVARIANCEVALUE_CACHE);
                    DocEntityThreadCache<DocEntityMeanVarianceValue>.UpdateCache(ret.Hash, ret, MEANVARIANCEVALUE_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityMeanVarianceValue GetMeanVarianceValue(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityMeanVarianceValue>.GetFromCache(hash, MEANVARIANCEVALUE_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityMeanVarianceValue>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityMeanVarianceValue>.UpdateCache(ret.Id, ret, MEANVARIANCEVALUE_CACHE);
                    DocEntityThreadCache<DocEntityMeanVarianceValue>.UpdateCache(ret.Hash, ret, MEANVARIANCEVALUE_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field]
        public DocStructureUnits MeanVariance { get; set; }


        [Field]
        public DocStructureUnitsRange MeanVarianceRange { get; set; }


        [Field(Nullable = false)]
        public DocEntityLookupTable MeanVarianceType { get; set; }
        public int? MeanVarianceTypeId { get { return MeanVarianceType?.Id; } private set { var noid = value; } }


        [Field(Nullable = false, DefaultValue = 0)]
        public int Order { get; set; }


        [Field]
        public DocEntitySet<DocEntityMeanVariances> Owners { get; private set; }


        public int? OwnersCount { get { return Owners.Count(); } private set { var noid = value; } }



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

        public const string CACHE_KEY_PREFIX = "FindMeanVarianceValues";

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
                throw new HttpError(HttpStatusCode.Conflict, $"MeanVarianceValue requires: {ValidationMessage.Message}.");
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

                if(DocTools.IsNullOrEmpty(MeanVarianceType))
                {
                    isValid = false;
                    message += " MeanVarianceType is a required property.";
                }
                else
                {
                    if(MeanVarianceType.Enum?.Name != "MeanVarianceType")
                    {
                        isValid = false;
                        message += " MeanVarianceType is a " + MeanVarianceType.Enum.Name + ", but must be a MeanVarianceType.";
                    }
                }
                if(DocTools.IsNullOrEmpty(Order))
                {
                    isValid = false;
                    message += " Order is a required property.";
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Converters

        public MeanVarianceValue ToDto() => Mapper.Map<DocEntityMeanVarianceValue, MeanVarianceValue>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }

    public static partial class UniqueConstraintFilter
    {
        public static Expression<Func<DocEntityMeanVarianceValue, bool>> MeanVarianceValueIgnoreArchived() => d => d.Archived == false;
    }

    public partial class MeanVarianceValueMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityMeanVarianceValue,MeanVarianceValue> _EntityToDto;
        protected IMappingExpression<MeanVarianceValue,DocEntityMeanVarianceValue> _DtoToEntity;

        public MeanVarianceValueMapper()
        {
            CreateMap<DocEntitySet<DocEntityMeanVarianceValue>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityMeanVarianceValue,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityMeanVarianceValue>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityMeanVarianceValue.GetMeanVarianceValue(c));
            _EntityToDto = CreateMap<DocEntityMeanVarianceValue,MeanVarianceValue>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<MeanVarianceValue>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<MeanVarianceValue>(c, "Updated")))
                .ForMember(dest => dest.MeanVariance, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<MeanVarianceValue>(c, nameof(DocEntityMeanVarianceValue.MeanVariance))))
                .ForMember(dest => dest.MeanVarianceRange, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<MeanVarianceValue>(c, nameof(DocEntityMeanVarianceValue.MeanVarianceRange))))
                .ForMember(dest => dest.MeanVarianceType, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<MeanVarianceValue>(c, nameof(DocEntityMeanVarianceValue.MeanVarianceType))))
                .ForMember(dest => dest.MeanVarianceTypeId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<MeanVarianceValue>(c, nameof(DocEntityMeanVarianceValue.MeanVarianceTypeId))))
                .ForMember(dest => dest.Order, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<MeanVarianceValue>(c, nameof(DocEntityMeanVarianceValue.Order))))
                .ForMember(dest => dest.Owners, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<MeanVarianceValue>(c, nameof(DocEntityMeanVarianceValue.Owners))))
                .ForMember(dest => dest.OwnersCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<MeanVarianceValue>(c, nameof(DocEntityMeanVarianceValue.OwnersCount))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<MeanVarianceValue,DocEntityMeanVarianceValue>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
