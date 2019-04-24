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
    [TableMapping(DocConstantModelName.STATSRECORD)]
    public partial class DocEntityStatsRecord : DocEntityBase
    {
        private const string STATSRECORD_CACHE = "StatsRecordCache";
        public const string TABLE_NAME = DocConstantModelName.STATSRECORD;
        
        #region Constructor
        public DocEntityStatsRecord(Session session) : base(session) {}

        public DocEntityStatsRecord() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        #region VisibleFields

        protected override List<string> _visibleFields
        {
            get
            {
                if(null == __vf)
                {
                    __vf = DocWebSession.GetTypeVisibleFields(new StatsRecord());
                }
                return __vf;
            }
        }

        #endregion VisibleFields

        #region Static Members
        public static DocEntityStatsRecord GetStatsRecord(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetStatsRecord(reference.Id) : null;
        }

        public static DocEntityStatsRecord GetStatsRecord(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityStatsRecord>.GetFromCache(primaryKey, STATSRECORD_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityStatsRecord>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityStatsRecord>.UpdateCache(ret.Id, ret, STATSRECORD_CACHE);
                    DocEntityThreadCache<DocEntityStatsRecord>.UpdateCache(ret.Hash, ret, STATSRECORD_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityStatsRecord GetStatsRecord(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityStatsRecord>.GetFromCache(hash, STATSRECORD_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityStatsRecord>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityStatsRecord>.UpdateCache(ret.Id, ret, STATSRECORD_CACHE);
                    DocEntityThreadCache<DocEntityStatsRecord>.UpdateCache(ret.Hash, ret, STATSRECORD_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field(Nullable = false)]
        public DocEntityLookupTable Name { get; set; }
        public int? NameId { get { return Name?.Id; } private set { var noid = value; } }


        [Field(Nullable = false)]
        public int OwnerId { get; set; }


        [Field(Nullable = false)]
        public string OwnerType { get; set; }


        [Field(Nullable = false)]
        public decimal Value { get; set; }



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

        public const string CACHE_KEY_PREFIX = "FindStatsRecords";

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
                throw new HttpError(HttpStatusCode.Conflict, $"StatsRecord requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();
            _validated = true;
        }

        public override IDocEntity SaveChanges(bool ignoreCache, DocConstantPermission permission)
        {
            OwnerType = OwnerType?.TrimAndPruneSpaces();
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

                if(DocTools.IsNullOrEmpty(Name))
                {
                    isValid = false;
                    message += " Name is a required property.";
                }
                else
                {
                    if(Name.Enum?.Name != "StatsRecordName")
                    {
                        isValid = false;
                        message += " Name is a " + Name.Enum.Name + ", but must be a StatsRecordName.";
                    }
                }
                if(DocTools.IsNullOrEmpty(OwnerId))
                {
                    isValid = false;
                    message += " OwnerId is a required property.";
                }
                if(DocTools.IsNullOrEmpty(OwnerType))
                {
                    isValid = false;
                    message += " OwnerType is a required property.";
                }
                if(DocTools.IsNullOrEmpty(Value))
                {
                    isValid = false;
                    message += " Value is a required property.";
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Converters

        public StatsRecord ToDto() => Mapper.Map<DocEntityStatsRecord, StatsRecord>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }

    public static partial class UniqueConstraintFilter
    {
        public static Expression<Func<DocEntityStatsRecord, bool>> StatsRecordIgnoreArchived() => d => d.Archived == false;
    }

    public partial class StatsRecordMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityStatsRecord,StatsRecord> _EntityToDto;
        protected IMappingExpression<StatsRecord,DocEntityStatsRecord> _DtoToEntity;

        public StatsRecordMapper()
        {
            CreateMap<DocEntitySet<DocEntityStatsRecord>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityStatsRecord,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityStatsRecord>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityStatsRecord.GetStatsRecord(c));
            _EntityToDto = CreateMap<DocEntityStatsRecord,StatsRecord>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<StatsRecord>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<StatsRecord>(c, "Updated")))
                .ForMember(dest => dest.Name, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<StatsRecord>(c, nameof(DocEntityStatsRecord.Name))))
                .ForMember(dest => dest.NameId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<StatsRecord>(c, nameof(DocEntityStatsRecord.NameId))))
                .ForMember(dest => dest.OwnerId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<StatsRecord>(c, nameof(DocEntityStatsRecord.OwnerId))))
                .ForMember(dest => dest.OwnerType, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<StatsRecord>(c, nameof(DocEntityStatsRecord.OwnerType))))
                .ForMember(dest => dest.Value, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<StatsRecord>(c, nameof(DocEntityStatsRecord.Value))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<StatsRecord,DocEntityStatsRecord>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
