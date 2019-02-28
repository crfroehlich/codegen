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
    [TableMapping(DocConstantModelName.STATS)]
    public partial class DocEntityStats : DocEntityBase
    {
        private const string STATS_CACHE = "StatsCache";
        public const string TABLE_NAME = DocConstantModelName.STATS;
        
        #region Constructor
        public DocEntityStats(Session session) : base(session) {}

        public DocEntityStats() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        #region VisibleFields

        protected override List<string> _visibleFields
        {
            get
            {
                if(null == __vf)
                {
                    __vf = DocWebSession.GetTypeVisibleFields(new Stats());
                }
                return __vf;
            }
        }

        #endregion VisibleFields

        #region Static Members
        public static DocEntityStats GetStats(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetStats(reference.Id) : null;
        }

        public static DocEntityStats GetStats(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityStats>.GetFromCache(primaryKey, STATS_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityStats>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityStats>.UpdateCache(ret.Id, ret, STATS_CACHE);
                    DocEntityThreadCache<DocEntityStats>.UpdateCache(ret.Hash, ret, STATS_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityStats GetStats(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityStats>.GetFromCache(hash, STATS_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityStats>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityStats>.UpdateCache(ret.Id, ret, STATS_CACHE);
                    DocEntityThreadCache<DocEntityStats>.UpdateCache(ret.Hash, ret, STATS_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field(Nullable = false)]
        [FieldMapping(nameof(App))]
        public DocEntityApp App { get; set; }
        public int? AppId { get { return App?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(ExternalId))]
        public int ExternalId { get; set; }


        [Field()]
        [FieldMapping(nameof(ExternalType))]
        public string ExternalType { get; set; }


        [Field(Nullable = false)]
        [FieldMapping(nameof(ObjectId))]
        public int ObjectId { get; set; }


        [Field(Nullable = false)]
        [FieldMapping(nameof(ObjectType))]
        public string ObjectType { get; set; }


        [Field()]
        [FieldMapping(nameof(StudySetStats))]
        public DocEntityStatsStudySet StudySetStats { get; set; }
        public int? StudySetStatsId { get { return StudySetStats?.Id; } private set { var noid = value; } }



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

        public const string CACHE_KEY_PREFIX = "FindStatss";

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
                throw new HttpError(HttpStatusCode.Conflict, $"Stats requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();

            FlushCache();

            _validated = true;


        }

        public override IDocEntity SaveChanges(DocConstantPermission permission = null)
        {
            ExternalType = ExternalType?.TrimAndPruneSpaces();
            ObjectType = ObjectType?.TrimAndPruneSpaces();
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

                if(DocTools.IsNullOrEmpty(App))
                {
                    isValid = false;
                    message += " App is a required property.";
                }
                if(DocTools.IsNullOrEmpty(ObjectId))
                {
                    isValid = false;
                    message += " ObjectId is a required property.";
                }
                if(DocTools.IsNullOrEmpty(ObjectType))
                {
                    isValid = false;
                    message += " ObjectType is a required property.";
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Converters

        public Stats ToDto() => Mapper.Map<DocEntityStats, Stats>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }

    public static partial class UniqueConstraintFilter
    {
        public static Expression<Func<DocEntityStats, bool>> StatsIgnoreArchived() => d => d.Archived == false;
    }

    public partial class StatsMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityStats,Stats> _EntityToDto;
        protected IMappingExpression<Stats,DocEntityStats> _DtoToEntity;

        public StatsMapper()
        {
            CreateMap<DocEntitySet<DocEntityStats>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityStats,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityStats>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityStats.GetStats(c));
            _EntityToDto = CreateMap<DocEntityStats,Stats>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Stats>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Stats>(c, "Updated")))
                .ForMember(dest => dest.App, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Stats>(c, nameof(DocEntityStats.App))))
                .ForMember(dest => dest.AppId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Stats>(c, nameof(DocEntityStats.AppId))))
                .ForMember(dest => dest.ExternalId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Stats>(c, nameof(DocEntityStats.ExternalId))))
                .ForMember(dest => dest.ExternalType, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Stats>(c, nameof(DocEntityStats.ExternalType))))
                .ForMember(dest => dest.ObjectId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Stats>(c, nameof(DocEntityStats.ObjectId))))
                .ForMember(dest => dest.ObjectType, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Stats>(c, nameof(DocEntityStats.ObjectType))))
                .ForMember(dest => dest.StudySetStats, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Stats>(c, nameof(DocEntityStats.StudySetStats))))
                .ForMember(dest => dest.StudySetStatsId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Stats>(c, nameof(DocEntityStats.StudySetStatsId))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<Stats,DocEntityStats>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
