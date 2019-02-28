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
    [TableMapping(DocConstantModelName.UPDATE)]
    public partial class DocEntityUpdate : DocEntityBase
    {
        private const string UPDATE_CACHE = "UpdateCache";
        public const string TABLE_NAME = DocConstantModelName.UPDATE;
        
        #region Constructor
        public DocEntityUpdate(Session session) : base(session) {}

        public DocEntityUpdate() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        #region VisibleFields

        protected override List<string> _visibleFields
        {
            get
            {
                if(null == __vf)
                {
                    __vf = DocWebSession.GetTypeVisibleFields(new Update());
                }
                return __vf;
            }
        }

        #endregion VisibleFields

        #region Static Members
        public static DocEntityUpdate GetUpdate(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetUpdate(reference.Id) : null;
        }

        public static DocEntityUpdate GetUpdate(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityUpdate>.GetFromCache(primaryKey, UPDATE_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityUpdate>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityUpdate>.UpdateCache(ret.Id, ret, UPDATE_CACHE);
                    DocEntityThreadCache<DocEntityUpdate>.UpdateCache(ret.Hash, ret, UPDATE_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityUpdate GetUpdate(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityUpdate>.GetFromCache(hash, UPDATE_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityUpdate>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityUpdate>.UpdateCache(ret.Id, ret, UPDATE_CACHE);
                    DocEntityThreadCache<DocEntityUpdate>.UpdateCache(ret.Hash, ret, UPDATE_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field(Length = int.MaxValue)]
        [FieldMapping(nameof(Body))]
        public string Body { get; set; }


        [Field(Length = int.MaxValue)]
        [FieldMapping(nameof(DeliveryStatus))]
        public string DeliveryStatus { get; set; }


        [Field(DefaultValue = 0)]
        [FieldMapping(nameof(EmailAttempts))]
        public int EmailAttempts { get; set; }


        [Field()]
        [FieldMapping(nameof(EmailSent))]
        public DateTime? EmailSent { get; set; }


        [Field()]
        [FieldMapping(nameof(Events))]
        [Association(PairTo = nameof(DocEntityEvent.Updates), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityEvent> Events { get; private set; }


        public int? EventsCount { get { return Events.Count(); } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Link))]
        public string Link { get; set; }


        [Field(DefaultValue = 5)]
        [FieldMapping(nameof(Priority))]
        public int Priority { get; set; }


        [Field()]
        [FieldMapping(nameof(Read))]
        public DateTime? Read { get; set; }


        [Field()]
        [FieldMapping(nameof(SlackSent))]
        public DateTime? SlackSent { get; set; }


        [Field()]
        [FieldMapping(nameof(Subject))]
        public string Subject { get; set; }


        [Field()]
        [FieldMapping(nameof(Team))]
        public DocEntityTeam Team { get; set; }
        public int? TeamId { get { return Team?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(User))]
        public DocEntityUser User { get; set; }
        public int? UserId { get { return User?.Id; } private set { var noid = value; } }



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

        public const string CACHE_KEY_PREFIX = "FindUpdates";

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
                throw new HttpError(HttpStatusCode.Conflict, $"Update requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();

            FlushCache();

            _validated = true;


        }

        public override IDocEntity SaveChanges(DocConstantPermission permission = null)
        {
            Link = Link?.TrimAndPruneSpaces();
            Subject = Subject?.TrimAndPruneSpaces();
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

        public Update ToDto() => Mapper.Map<DocEntityUpdate, Update>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }

    public static partial class UniqueConstraintFilter
    {
        public static Expression<Func<DocEntityUpdate, bool>> UpdateIgnoreArchived() => d => d.Archived == false;
    }

    public partial class UpdateMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityUpdate,Update> _EntityToDto;
        protected IMappingExpression<Update,DocEntityUpdate> _DtoToEntity;

        public UpdateMapper()
        {
            CreateMap<DocEntitySet<DocEntityUpdate>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityUpdate,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityUpdate>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityUpdate.GetUpdate(c));
            _EntityToDto = CreateMap<DocEntityUpdate,Update>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Update>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Update>(c, "Updated")))
                .ForMember(dest => dest.Body, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Update>(c, nameof(DocEntityUpdate.Body))))
                .ForMember(dest => dest.DeliveryStatus, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Update>(c, nameof(DocEntityUpdate.DeliveryStatus))))
                .ForMember(dest => dest.EmailAttempts, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Update>(c, nameof(DocEntityUpdate.EmailAttempts))))
                .ForMember(dest => dest.EmailSent, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Update>(c, nameof(DocEntityUpdate.EmailSent))))
                .ForMember(dest => dest.Events, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Update>(c, nameof(DocEntityUpdate.Events))))
                .ForMember(dest => dest.EventsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Update>(c, nameof(DocEntityUpdate.EventsCount))))
                .ForMember(dest => dest.Link, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Update>(c, nameof(DocEntityUpdate.Link))))
                .ForMember(dest => dest.Priority, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Update>(c, nameof(DocEntityUpdate.Priority))))
                .ForMember(dest => dest.Read, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Update>(c, nameof(DocEntityUpdate.Read))))
                .ForMember(dest => dest.SlackSent, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Update>(c, nameof(DocEntityUpdate.SlackSent))))
                .ForMember(dest => dest.Subject, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Update>(c, nameof(DocEntityUpdate.Subject))))
                .ForMember(dest => dest.Team, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Update>(c, nameof(DocEntityUpdate.Team))))
                .ForMember(dest => dest.TeamId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Update>(c, nameof(DocEntityUpdate.TeamId))))
                .ForMember(dest => dest.User, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Update>(c, nameof(DocEntityUpdate.User))))
                .ForMember(dest => dest.UserId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Update>(c, nameof(DocEntityUpdate.UserId))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<Update,DocEntityUpdate>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
