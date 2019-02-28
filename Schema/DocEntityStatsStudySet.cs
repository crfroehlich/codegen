//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated by a T4 template. This class can be only customized modifying the corresponding partial class.
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
    [TableMapping(DocConstantModelName.STATSSTUDYSET)]
    public partial class DocEntityStatsStudySet : DocEntityBase
    {
        private const string STATSSTUDYSET_CACHE = "StatsStudySetCache";
        public const string TABLE_NAME = DocConstantModelName.STATSSTUDYSET;
        
        #region Constructor
        public DocEntityStatsStudySet(Session session) : base(session) {}

        public DocEntityStatsStudySet() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        #region VisibleFields

        protected override List<string> _visibleFields
        {
            get
            {
                if(null == __vf)
                {
                    __vf = DocWebSession.GetTypeVisibleFields(new StatsStudySet());
                }
                return __vf;
            }
        }

        #endregion VisibleFields

        #region Static Members
        public static DocEntityStatsStudySet GetStatsStudySet(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetStatsStudySet(reference.Id) : null;
        }

        public static DocEntityStatsStudySet GetStatsStudySet(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityStatsStudySet>.GetFromCache(primaryKey, STATSSTUDYSET_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityStatsStudySet>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityStatsStudySet>.UpdateCache(ret.Id, ret, STATSSTUDYSET_CACHE);
                    DocEntityThreadCache<DocEntityStatsStudySet>.UpdateCache(ret.Hash, ret, STATSSTUDYSET_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityStatsStudySet GetStatsStudySet(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityStatsStudySet>.GetFromCache(hash, STATSSTUDYSET_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityStatsStudySet>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityStatsStudySet>.UpdateCache(ret.Id, ret, STATSSTUDYSET_CACHE);
                    DocEntityThreadCache<DocEntityStatsStudySet>.UpdateCache(ret.Hash, ret, STATSSTUDYSET_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field(Nullable = false, DefaultValue = 0)]
        [FieldMapping(nameof(BoundTerms))]
        public int BoundTerms { get; set; }


        [Field(Nullable = false, DefaultValue = 0)]
        [FieldMapping(nameof(Characteristics))]
        public int Characteristics { get; set; }


        [Field(Nullable = false, DefaultValue = 0)]
        [FieldMapping(nameof(DataPoints))]
        public int DataPoints { get; set; }


        [Field(Nullable = false, DefaultValue = 0)]
        [FieldMapping(nameof(DesignCount))]
        public int DesignCount { get; set; }


        [Field()]
        [FieldMapping(nameof(DesignList))]
        public string DesignList { get; set; }


        [Field(Nullable = false)]
        [FieldMapping(nameof(DocumentSet))]
        public DocEntityDocumentSet DocumentSet { get; set; }
        public int? DocumentSetId { get { return DocumentSet?.Id; } private set { var noid = value; } }


        [Field(Nullable = false, DefaultValue = 0)]
        [FieldMapping(nameof(Interventions))]
        public int Interventions { get; set; }


        [Field(Nullable = false, DefaultValue = 0)]
        [FieldMapping(nameof(Outcomes))]
        public int Outcomes { get; set; }


        [Field(Nullable = false, DefaultValue = 0)]
        [FieldMapping(nameof(OutcomesReported))]
        public int OutcomesReported { get; set; }


        [Field()]
        [FieldMapping(nameof(Records))]
        public DocEntitySet<DocEntityStatsRecord> Records { get; private set; }


        public int? RecordsCount { get { return Records.Count(); } private set { var noid = value; } }


        [Field(Nullable = false)]
        [FieldMapping(nameof(Stat))]
        public DocEntityStats Stat { get; set; }
        public int? StatId { get { return Stat?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Studies))]
        public int Studies { get; set; }


        [Field(Nullable = false, DefaultValue = 0)]
        [FieldMapping(nameof(TypeCount))]
        public int TypeCount { get; set; }


        [Field()]
        [FieldMapping(nameof(TypeList))]
        public string TypeList { get; set; }


        [Field(Nullable = false, DefaultValue = 0)]
        [FieldMapping(nameof(UnboundTerms))]
        public int UnboundTerms { get; set; }



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

        public const string CACHE_KEY_PREFIX = "FindStatsStudySets";

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
                throw new HttpError(HttpStatusCode.Conflict, $"StatsStudySet requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();

            FlushCache();

            _validated = true;


        }

        public override IDocEntity SaveChanges(DocConstantPermission permission = null)
        {
            DesignList = DesignList?.TrimAndPruneSpaces();
            TypeList = TypeList?.TrimAndPruneSpaces();
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

                if(DocTools.IsNullOrEmpty(BoundTerms))
                {
                    isValid = false;
                    message += " BoundTerms is a required property.";
                }
                if(DocTools.IsNullOrEmpty(Characteristics))
                {
                    isValid = false;
                    message += " Characteristics is a required property.";
                }
                if(DocTools.IsNullOrEmpty(DataPoints))
                {
                    isValid = false;
                    message += " DataPoints is a required property.";
                }
                if(DocTools.IsNullOrEmpty(DesignCount))
                {
                    isValid = false;
                    message += " DesignCount is a required property.";
                }
                if(DocTools.IsNullOrEmpty(DocumentSet))
                {
                    isValid = false;
                    message += " DocumentSet is a required property.";
                }
                if(DocTools.IsNullOrEmpty(Interventions))
                {
                    isValid = false;
                    message += " Interventions is a required property.";
                }
                if(DocTools.IsNullOrEmpty(Outcomes))
                {
                    isValid = false;
                    message += " Outcomes is a required property.";
                }
                if(DocTools.IsNullOrEmpty(OutcomesReported))
                {
                    isValid = false;
                    message += " OutcomesReported is a required property.";
                }
                if(DocTools.IsNullOrEmpty(Stat))
                {
                    isValid = false;
                    message += " Stat is a required property.";
                }
                if(DocTools.IsNullOrEmpty(TypeCount))
                {
                    isValid = false;
                    message += " TypeCount is a required property.";
                }
                if(DocTools.IsNullOrEmpty(UnboundTerms))
                {
                    isValid = false;
                    message += " UnboundTerms is a required property.";
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Converters

        public StatsStudySet ToDto() => Mapper.Map<DocEntityStatsStudySet, StatsStudySet>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }

    public static partial class UniqueConstraintFilter
    {
        public static Expression<Func<DocEntityStatsStudySet, bool>> StatsStudySetIgnoreArchived() => d => d.Archived == false;
    }

    public partial class StatsStudySetMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityStatsStudySet,StatsStudySet> _EntityToDto;
        protected IMappingExpression<StatsStudySet,DocEntityStatsStudySet> _DtoToEntity;

        public StatsStudySetMapper()
        {
            CreateMap<DocEntitySet<DocEntityStatsStudySet>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityStatsStudySet,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityStatsStudySet>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityStatsStudySet.GetStatsStudySet(c));
            _EntityToDto = CreateMap<DocEntityStatsStudySet,StatsStudySet>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<StatsStudySet>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<StatsStudySet>(c, "Updated")))
                .ForMember(dest => dest.BoundTerms, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<StatsStudySet>(c, nameof(DocEntityStatsStudySet.BoundTerms))))
                .ForMember(dest => dest.Characteristics, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<StatsStudySet>(c, nameof(DocEntityStatsStudySet.Characteristics))))
                .ForMember(dest => dest.DataPoints, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<StatsStudySet>(c, nameof(DocEntityStatsStudySet.DataPoints))))
                .ForMember(dest => dest.DesignCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<StatsStudySet>(c, nameof(DocEntityStatsStudySet.DesignCount))))
                .ForMember(dest => dest.DesignList, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<StatsStudySet>(c, nameof(DocEntityStatsStudySet.DesignList))))
                .ForMember(dest => dest.DocumentSet, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<StatsStudySet>(c, nameof(DocEntityStatsStudySet.DocumentSet))))
                .ForMember(dest => dest.DocumentSetId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<StatsStudySet>(c, nameof(DocEntityStatsStudySet.DocumentSetId))))
                .ForMember(dest => dest.Interventions, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<StatsStudySet>(c, nameof(DocEntityStatsStudySet.Interventions))))
                .ForMember(dest => dest.Outcomes, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<StatsStudySet>(c, nameof(DocEntityStatsStudySet.Outcomes))))
                .ForMember(dest => dest.OutcomesReported, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<StatsStudySet>(c, nameof(DocEntityStatsStudySet.OutcomesReported))))
                .ForMember(dest => dest.Records, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<StatsStudySet>(c, nameof(DocEntityStatsStudySet.Records))))
                .ForMember(dest => dest.RecordsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<StatsStudySet>(c, nameof(DocEntityStatsStudySet.RecordsCount))))
                .ForMember(dest => dest.Stat, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<StatsStudySet>(c, nameof(DocEntityStatsStudySet.Stat))))
                .ForMember(dest => dest.StatId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<StatsStudySet>(c, nameof(DocEntityStatsStudySet.StatId))))
                .ForMember(dest => dest.Studies, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<StatsStudySet>(c, nameof(DocEntityStatsStudySet.Studies))))
                .ForMember(dest => dest.TypeCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<StatsStudySet>(c, nameof(DocEntityStatsStudySet.TypeCount))))
                .ForMember(dest => dest.TypeList, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<StatsStudySet>(c, nameof(DocEntityStatsStudySet.TypeList))))
                .ForMember(dest => dest.UnboundTerms, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<StatsStudySet>(c, nameof(DocEntityStatsStudySet.UnboundTerms))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<StatsStudySet,DocEntityStatsStudySet>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
