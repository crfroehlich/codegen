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
    [TableMapping(DocConstantModelName.DATETIME)]
    public partial class DocEntityDateTime : DocEntityBase
    {
        private const string DATETIME_CACHE = "DateTimeCache";
        public const string TABLE_NAME = DocConstantModelName.DATETIME;
        
        #region Constructor
        public DocEntityDateTime(Session session) : base(session) {}

        public DocEntityDateTime() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        #region VisibleFields

        protected override List<string> _visibleFields
        {
            get
            {
                if(null == __vf)
                {
                    __vf = DocWebSession.GetTypeVisibleFields(new DateTimeDto());
                }
                return __vf;
            }
        }

        #endregion VisibleFields

        #region Static Members
        public static DocEntityDateTime GetDateTime(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetDateTime(reference.Id) : null;
        }

        public static DocEntityDateTime GetDateTime(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityDateTime>.GetFromCache(primaryKey, DATETIME_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityDateTime>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityDateTime>.UpdateCache(ret.Id, ret, DATETIME_CACHE);
                    DocEntityThreadCache<DocEntityDateTime>.UpdateCache(ret.Hash, ret, DATETIME_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityDateTime GetDateTime(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityDateTime>.GetFromCache(hash, DATETIME_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityDateTime>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityDateTime>.UpdateCache(ret.Id, ret, DATETIME_CACHE);
                    DocEntityThreadCache<DocEntityDateTime>.UpdateCache(ret.Hash, ret, DATETIME_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field()]
        [FieldMapping(nameof(DateDay))]
        public int? DateDay { get; set; }


        [Field()]
        [FieldMapping(nameof(DateMonth))]
        public int? DateMonth { get; set; }


        [Field()]
        [FieldMapping(nameof(DateTime))]
        public DateTime? DateTime { get; set; }


        [Field()]
        [FieldMapping(nameof(DateYear))]
        public int? DateYear { get; set; }



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

        public const string CACHE_KEY_PREFIX = "FindDateTimes";

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
                throw new HttpError(HttpStatusCode.Conflict, $"DateTime requires: {ValidationMessage.Message}.");
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



                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Converters

        public DateTimeDto ToDto() => Mapper.Map<DocEntityDateTime, DateTimeDto>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }

    public static partial class UniqueConstraintFilter
    {
        public static Expression<Func<DocEntityDateTime, bool>> DateTimeIgnoreArchived() => d => d.Archived == false;
    }

    public partial class DateTimeDtoMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityDateTime,DateTimeDto> _EntityToDto;
        protected IMappingExpression<DateTimeDto,DocEntityDateTime> _DtoToEntity;

        public DateTimeDtoMapper()
        {
            CreateMap<DocEntitySet<DocEntityDateTime>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityDateTime,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityDateTime>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityDateTime.GetDateTime(c));
            _EntityToDto = CreateMap<DocEntityDateTime,DateTimeDto>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DateTimeDto>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DateTimeDto>(c, "Updated")))
                .ForMember(dest => dest.DateDay, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DateTimeDto>(c, nameof(DocEntityDateTime.DateDay))))
                .ForMember(dest => dest.DateMonth, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DateTimeDto>(c, nameof(DocEntityDateTime.DateMonth))))
                .ForMember(dest => dest.DateTime, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DateTimeDto>(c, nameof(DocEntityDateTime.DateTime))))
                .ForMember(dest => dest.DateYear, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DateTimeDto>(c, nameof(DocEntityDateTime.DateYear))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<DateTimeDto,DocEntityDateTime>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
