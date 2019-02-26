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
    [TableMapping(DocConstantModelName.INTERVAL)]
    public partial class DocEntityInterval : DocEntityBase
    {
        private const string INTERVAL_CACHE = "IntervalCache";
        public const string TABLE_NAME = DocConstantModelName.INTERVAL;
        
        #region Constructor
        public DocEntityInterval(Session session) : base(session) {}

        public DocEntityInterval() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        #region VisibleFields

        protected override List<string> _visibleFields
        {
            get
            {
                if(null == __vf)
                {
                    __vf = DocWebSession.GetTypeVisibleFields(new Interval());
                }
                return __vf;
            }
        }

        #endregion VisibleFields

        #region Static Members
        public static DocEntityInterval GetInterval(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetInterval(reference.Id) : null;
        }

        public static DocEntityInterval GetInterval(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityInterval>.GetFromCache(primaryKey, INTERVAL_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityInterval>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityInterval>.UpdateCache(ret.Id, ret, INTERVAL_CACHE);
                    DocEntityThreadCache<DocEntityInterval>.UpdateCache(ret.Hash, ret, INTERVAL_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityInterval GetInterval(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityInterval>.GetFromCache(hash, INTERVAL_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityInterval>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityInterval>.UpdateCache(ret.Id, ret, INTERVAL_CACHE);
                    DocEntityThreadCache<DocEntityInterval>.UpdateCache(ret.Hash, ret, INTERVAL_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field()]
        [FieldMapping(nameof(CalendarDateEnd))]
        public DocEntityDateTime CalendarDateEnd { get; set; }
        public int? CalendarDateEndId { get { return CalendarDateEnd?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(CalendarDateStart))]
        public DocEntityDateTime CalendarDateStart { get; set; }
        public int? CalendarDateStartId { get { return CalendarDateStart?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(CalendarType))]
        public string CalendarType { get; set; }


        [Field()]
        [FieldMapping(nameof(FollowUp))]
        public DocEntityTimePoint FollowUp { get; set; }
        public int? FollowUpId { get { return FollowUp?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(TimeOfDay))]
        public DocEntityTimePoint TimeOfDay { get; set; }
        public int? TimeOfDayId { get { return TimeOfDay?.Id; } private set { var noid = value; } }



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

        public const string CACHE_KEY_PREFIX = "FindIntervals";

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
                throw new HttpError(HttpStatusCode.Conflict, $"Interval requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();

            FlushCache();

            _validated = true;

        }

        public override IDocEntity SaveChanges(DocConstantPermission permission = null)
        {
            CalendarType = CalendarType?.TrimAndPruneSpaces();
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


                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Converters

        public Interval ToDto() => Mapper.Map<DocEntityInterval, Interval>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }

    public static partial class UniqueConstraintFilter
    {
        public static Expression<Func<DocEntityInterval, bool>> IntervalIgnoreArchived() => d => d.Archived == false;
    }

    public partial class IntervalMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityInterval,Interval> _EntityToDto;
        protected IMappingExpression<Interval,DocEntityInterval> _DtoToEntity;

        public IntervalMapper()
        {
            CreateMap<DocEntitySet<DocEntityInterval>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityInterval,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityInterval>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityInterval.GetInterval(c));
            _EntityToDto = CreateMap<DocEntityInterval,Interval>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Interval>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Interval>(c, "Updated")))
                .ForMember(dest => dest.CalendarDateEnd, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Interval>(c, nameof(DocEntityInterval.CalendarDateEnd))))
                .ForMember(dest => dest.CalendarDateEndId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Interval>(c, nameof(DocEntityInterval.CalendarDateEndId))))
                .ForMember(dest => dest.CalendarDateStart, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Interval>(c, nameof(DocEntityInterval.CalendarDateStart))))
                .ForMember(dest => dest.CalendarDateStartId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Interval>(c, nameof(DocEntityInterval.CalendarDateStartId))))
                .ForMember(dest => dest.CalendarType, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Interval>(c, nameof(DocEntityInterval.CalendarType))))
                .ForMember(dest => dest.FollowUp, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Interval>(c, nameof(DocEntityInterval.FollowUp))))
                .ForMember(dest => dest.FollowUpId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Interval>(c, nameof(DocEntityInterval.FollowUpId))))
                .ForMember(dest => dest.TimeOfDay, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Interval>(c, nameof(DocEntityInterval.TimeOfDay))))
                .ForMember(dest => dest.TimeOfDayId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Interval>(c, nameof(DocEntityInterval.TimeOfDayId))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<Interval,DocEntityInterval>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}