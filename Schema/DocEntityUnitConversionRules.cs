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
    [TableMapping(DocConstantModelName.UNITCONVERSIONRULES)]
    public partial class DocEntityUnitConversionRules : DocEntityBase
    {
        private const string UNITCONVERSIONRULES_CACHE = "UnitConversionRulesCache";
        public const string TABLE_NAME = DocConstantModelName.UNITCONVERSIONRULES;
        
        #region Constructor
        public DocEntityUnitConversionRules(Session session) : base(session) {}

        public DocEntityUnitConversionRules() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        #region VisibleFields

        protected override List<string> _visibleFields
        {
            get
            {
                if(null == __vf)
                {
                    __vf = DocWebSession.GetTypeVisibleFields(new UnitConversionRules());
                }
                return __vf;
            }
        }

        #endregion VisibleFields

        #region Static Members
        public static DocEntityUnitConversionRules GetUnitConversionRules(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetUnitConversionRules(reference.Id) : null;
        }

        public static DocEntityUnitConversionRules GetUnitConversionRules(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityUnitConversionRules>.GetFromCache(primaryKey, UNITCONVERSIONRULES_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityUnitConversionRules>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityUnitConversionRules>.UpdateCache(ret.Id, ret, UNITCONVERSIONRULES_CACHE);
                    DocEntityThreadCache<DocEntityUnitConversionRules>.UpdateCache(ret.Hash, ret, UNITCONVERSIONRULES_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityUnitConversionRules GetUnitConversionRules(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityUnitConversionRules>.GetFromCache(hash, UNITCONVERSIONRULES_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityUnitConversionRules>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityUnitConversionRules>.UpdateCache(ret.Id, ret, UNITCONVERSIONRULES_CACHE);
                    DocEntityThreadCache<DocEntityUnitConversionRules>.UpdateCache(ret.Hash, ret, UNITCONVERSIONRULES_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field(Nullable = false)]
        [FieldMapping(nameof(DestinationUnit))]
        public DocEntityUnitOfMeasure DestinationUnit { get; set; }
        public int? DestinationUnitId { get { return DestinationUnit?.Id; } private set { var noid = value; } }


        [Field(DefaultValue = false)]
        [FieldMapping(nameof(IsDefault))]
        public bool IsDefault { get; set; }


        [Field(DefaultValue = false)]
        [FieldMapping(nameof(IsDestinationSi))]
        public bool IsDestinationSi { get; set; }


        [Field()]
        [FieldMapping(nameof(ModifierTerm))]
        public DocEntityTermMaster ModifierTerm { get; set; }
        public int? ModifierTermId { get { return ModifierTerm?.Id; } private set { var noid = value; } }


        [Field(Nullable = false, Precision = 38, Scale = 19)]
        [FieldMapping(nameof(Multiplier))]
        public decimal Multiplier { get; set; }


        [Field()]
        [FieldMapping(nameof(Parent))]
        public DocEntityLookupTable Parent { get; set; }
        public int? ParentId { get { return Parent?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(RootTerm))]
        public DocEntityTermMaster RootTerm { get; set; }
        public int? RootTermId { get { return RootTerm?.Id; } private set { var noid = value; } }


        [Field(Nullable = false)]
        [FieldMapping(nameof(SourceUnit))]
        public DocEntityUnitOfMeasure SourceUnit { get; set; }
        public int? SourceUnitId { get { return SourceUnit?.Id; } private set { var noid = value; } }



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

        public const string CACHE_KEY_PREFIX = "FindUnitConversionRuless";

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
                throw new HttpError(HttpStatusCode.Conflict, $"UnitConversionRules requires: {ValidationMessage.Message}.");
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

                if(DocTools.IsNullOrEmpty(DestinationUnit))
                {
                    isValid = false;
                    message += " DestinationUnit is a required property.";
                }
                if(DocTools.IsNullOrEmpty(Multiplier))
                {
                    isValid = false;
                    message += " Multiplier is a required property.";
                }
                if(null != Parent && Parent?.Enum?.Name != "UnitConversionRuleParent")
                {
                    isValid = false;
                    message += " Parent is a " + Parent?.Enum?.Name + ", but must be a UnitConversionRuleParent.";
                }
                if(DocTools.IsNullOrEmpty(SourceUnit))
                {
                    isValid = false;
                    message += " SourceUnit is a required property.";
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Converters

        public UnitConversionRules ToDto() => Mapper.Map<DocEntityUnitConversionRules, UnitConversionRules>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }

    public static partial class UniqueConstraintFilter
    {
        public static Expression<Func<DocEntityUnitConversionRules, bool>> UnitConversionRulesIgnoreArchived() => d => d.Archived == false;
    }

    public partial class UnitConversionRulesMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityUnitConversionRules,UnitConversionRules> _EntityToDto;
        protected IMappingExpression<UnitConversionRules,DocEntityUnitConversionRules> _DtoToEntity;

        public UnitConversionRulesMapper()
        {
            CreateMap<DocEntitySet<DocEntityUnitConversionRules>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityUnitConversionRules,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityUnitConversionRules>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityUnitConversionRules.GetUnitConversionRules(c));
            _EntityToDto = CreateMap<DocEntityUnitConversionRules,UnitConversionRules>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UnitConversionRules>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UnitConversionRules>(c, "Updated")))
                .ForMember(dest => dest.DestinationUnit, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UnitConversionRules>(c, nameof(DocEntityUnitConversionRules.DestinationUnit))))
                .ForMember(dest => dest.DestinationUnitId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UnitConversionRules>(c, nameof(DocEntityUnitConversionRules.DestinationUnitId))))
                .ForMember(dest => dest.IsDefault, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UnitConversionRules>(c, nameof(DocEntityUnitConversionRules.IsDefault))))
                .ForMember(dest => dest.IsDestinationSi, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UnitConversionRules>(c, nameof(DocEntityUnitConversionRules.IsDestinationSi))))
                .ForMember(dest => dest.ModifierTerm, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UnitConversionRules>(c, nameof(DocEntityUnitConversionRules.ModifierTerm))))
                .ForMember(dest => dest.ModifierTermId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UnitConversionRules>(c, nameof(DocEntityUnitConversionRules.ModifierTermId))))
                .ForMember(dest => dest.Multiplier, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UnitConversionRules>(c, nameof(DocEntityUnitConversionRules.Multiplier))))
                .ForMember(dest => dest.Parent, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UnitConversionRules>(c, nameof(DocEntityUnitConversionRules.Parent))))
                .ForMember(dest => dest.ParentId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UnitConversionRules>(c, nameof(DocEntityUnitConversionRules.ParentId))))
                .ForMember(dest => dest.RootTerm, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UnitConversionRules>(c, nameof(DocEntityUnitConversionRules.RootTerm))))
                .ForMember(dest => dest.RootTermId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UnitConversionRules>(c, nameof(DocEntityUnitConversionRules.RootTermId))))
                .ForMember(dest => dest.SourceUnit, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UnitConversionRules>(c, nameof(DocEntityUnitConversionRules.SourceUnit))))
                .ForMember(dest => dest.SourceUnitId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UnitConversionRules>(c, nameof(DocEntityUnitConversionRules.SourceUnitId))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<UnitConversionRules,DocEntityUnitConversionRules>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
