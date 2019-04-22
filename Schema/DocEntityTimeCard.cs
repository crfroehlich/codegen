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
    [TableMapping(DocConstantModelName.TIMECARD)]
    public partial class DocEntityTimeCard : DocEntityBase
    {
        private const string TIMECARD_CACHE = "TimeCardCache";
        public const string TABLE_NAME = DocConstantModelName.TIMECARD;
        
        #region Constructor
        public DocEntityTimeCard(Session session) : base(session) {}

        public DocEntityTimeCard() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        #region VisibleFields

        protected override List<string> _visibleFields
        {
            get
            {
                if(null == __vf)
                {
                    __vf = DocWebSession.GetTypeVisibleFields(new TimeCard());
                }
                return __vf;
            }
        }

        #endregion VisibleFields

        #region Static Members
        public static DocEntityTimeCard GetTimeCard(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetTimeCard(reference.Id) : null;
        }

        public static DocEntityTimeCard GetTimeCard(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityTimeCard>.GetFromCache(primaryKey, TIMECARD_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityTimeCard>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityTimeCard>.UpdateCache(ret.Id, ret, TIMECARD_CACHE);
                    DocEntityThreadCache<DocEntityTimeCard>.UpdateCache(ret.Hash, ret, TIMECARD_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityTimeCard GetTimeCard(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityTimeCard>.GetFromCache(hash, TIMECARD_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityTimeCard>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityTimeCard>.UpdateCache(ret.Id, ret, TIMECARD_CACHE);
                    DocEntityThreadCache<DocEntityTimeCard>.UpdateCache(ret.Hash, ret, TIMECARD_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field()]
        [FieldMapping(nameof(Description))]
        public string Description { get; set; }


        [Field()]
        [FieldMapping(nameof(Document))]
        public DocEntityDocument Document { get; set; }
        public int? DocumentId { get { return Document?.Id; } private set { var noid = value; } }


        [Field(Nullable = false)]
        [FieldMapping(nameof(End))]
        public DateTime End { get; set; }


        [Field()]
        [FieldMapping(nameof(Project))]
        public DocEntityProject Project { get; set; }
        public int? ProjectId { get { return Project?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(ReferenceId))]
        public int? ReferenceId { get; set; }


        [Field(Nullable = false)]
        [FieldMapping(nameof(Start))]
        public DateTime Start { get; set; }


        [Field()]
        [FieldMapping(nameof(Status))]
        public DocEntityLookupTable Status { get; set; }
        public int? StatusId { get { return Status?.Id; } private set { var noid = value; } }


        [Field(Nullable = false)]
        [FieldMapping(nameof(User))]
        public DocEntityUser User { get; set; }
        public int? UserId { get { return User?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(WorkType))]
        public DocEntityLookupTable WorkType { get; set; }
        public int? WorkTypeId { get { return WorkType?.Id; } private set { var noid = value; } }



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

        public const string CACHE_KEY_PREFIX = "FindTimeCards";

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
                throw new HttpError(HttpStatusCode.Conflict, $"TimeCard requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();
            _validated = true;
        }

        public override IDocEntity SaveChanges(bool ignoreCache, DocConstantPermission permission)
        {
            Description = Description?.TrimAndPruneSpaces();
            return base.SaveChanges(ignoreCache, permission);
        }

        public override IDocEntity SaveChanges(bool ignoreCache) => SaveChanges(ignoreCache, DocConstantPermission.EDIT);
        public override IDocEntity SaveChanges(DocConstantPermission permission) => SaveChanges(false, DocConstantPermission.EDIT);
        public override IDocEntity SaveChanges() => SaveChanges(DocConstantPermission.EDIT);

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

                if(DocTools.IsNullOrEmpty(End))
                {
                    isValid = false;
                    message += " End is a required property.";
                }
                if(DocTools.IsNullOrEmpty(Start))
                {
                    isValid = false;
                    message += " Start is a required property.";
                }
                if(null != Status && Status?.Enum?.Name != "TimeCardStatus")
                {
                    isValid = false;
                    message += " Status is a " + Status?.Enum?.Name + ", but must be a TimeCardStatus.";
                }
                if(DocTools.IsNullOrEmpty(User))
                {
                    isValid = false;
                    message += " User is a required property.";
                }
                if(null != WorkType && WorkType?.Enum?.Name != "WorkType")
                {
                    isValid = false;
                    message += " WorkType is a " + WorkType?.Enum?.Name + ", but must be a WorkType.";
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Converters

        public TimeCard ToDto() => Mapper.Map<DocEntityTimeCard, TimeCard>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }

    public static partial class UniqueConstraintFilter
    {
        public static Expression<Func<DocEntityTimeCard, bool>> TimeCardIgnoreArchived() => d => d.Archived == false;
    }

    public partial class TimeCardMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityTimeCard,TimeCard> _EntityToDto;
        protected IMappingExpression<TimeCard,DocEntityTimeCard> _DtoToEntity;

        public TimeCardMapper()
        {
            CreateMap<DocEntitySet<DocEntityTimeCard>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityTimeCard,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityTimeCard>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityTimeCard.GetTimeCard(c));
            _EntityToDto = CreateMap<DocEntityTimeCard,TimeCard>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TimeCard>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TimeCard>(c, "Updated")))
                .ForMember(dest => dest.Description, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TimeCard>(c, nameof(DocEntityTimeCard.Description))))
                .ForMember(dest => dest.Document, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TimeCard>(c, nameof(DocEntityTimeCard.Document))))
                .ForMember(dest => dest.DocumentId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TimeCard>(c, nameof(DocEntityTimeCard.DocumentId))))
                .ForMember(dest => dest.End, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TimeCard>(c, nameof(DocEntityTimeCard.End))))
                .ForMember(dest => dest.Project, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TimeCard>(c, nameof(DocEntityTimeCard.Project))))
                .ForMember(dest => dest.ProjectId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TimeCard>(c, nameof(DocEntityTimeCard.ProjectId))))
                .ForMember(dest => dest.ReferenceId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TimeCard>(c, nameof(DocEntityTimeCard.ReferenceId))))
                .ForMember(dest => dest.Start, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TimeCard>(c, nameof(DocEntityTimeCard.Start))))
                .ForMember(dest => dest.Status, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TimeCard>(c, nameof(DocEntityTimeCard.Status))))
                .ForMember(dest => dest.StatusId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TimeCard>(c, nameof(DocEntityTimeCard.StatusId))))
                .ForMember(dest => dest.User, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TimeCard>(c, nameof(DocEntityTimeCard.User))))
                .ForMember(dest => dest.UserId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TimeCard>(c, nameof(DocEntityTimeCard.UserId))))
                .ForMember(dest => dest.WorkType, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TimeCard>(c, nameof(DocEntityTimeCard.WorkType))))
                .ForMember(dest => dest.WorkTypeId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<TimeCard>(c, nameof(DocEntityTimeCard.WorkTypeId))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<TimeCard,DocEntityTimeCard>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
