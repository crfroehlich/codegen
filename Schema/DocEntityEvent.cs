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
    [TableMapping(DocConstantModelName.EVENT)]
    public partial class DocEntityEvent : DocEntityBase
    {
        private const string EVENT_CACHE = "EventCache";
        public const string TABLE_NAME = DocConstantModelName.EVENT;
        
        #region Constructor
        public DocEntityEvent(Session session) : base(session) {}

        public DocEntityEvent() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        #region VisibleFields

        protected override List<string> _visibleFields
        {
            get
            {
                if(null == __vf)
                {
                    __vf = DocWebSession.GetTypeVisibleFields(new Event());
                }
                return __vf;
            }
        }

        #endregion VisibleFields

        #region Static Members
        public static DocEntityEvent GetEvent(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetEvent(reference.Id) : null;
        }

        public static DocEntityEvent GetEvent(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityEvent>.GetFromCache(primaryKey, EVENT_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityEvent>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityEvent>.UpdateCache(ret.Id, ret, EVENT_CACHE);
                    DocEntityThreadCache<DocEntityEvent>.UpdateCache(ret.Hash, ret, EVENT_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityEvent GetEvent(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityEvent>.GetFromCache(hash, EVENT_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityEvent>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityEvent>.UpdateCache(ret.Id, ret, EVENT_CACHE);
                    DocEntityThreadCache<DocEntityEvent>.UpdateCache(ret.Hash, ret, EVENT_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field(Nullable = false)]
        public DocEntityAuditRecord AuditRecord { get; set; }
        public int? AuditRecordId { get { return AuditRecord?.Id; } private set { var noid = value; } }


        [Field]
        public string Description { get; set; }


        [Field]
        public DateTime? Processed { get; set; }


        [Field]
        public string Status { get; set; }


        [Field]
        public DocEntitySet<DocEntityTeam> Teams { get; private set; }


        public int? TeamsCount { get { return Teams.Count(); } private set { var noid = value; } }


        [Field]
        public DocEntitySet<DocEntityUpdate> Updates { get; private set; }


        public int? UpdatesCount { get { return Updates.Count(); } private set { var noid = value; } }


        [Field]
        public DocEntitySet<DocEntityUser> Users { get; private set; }


        public int? UsersCount { get { return Users.Count(); } private set { var noid = value; } }



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

        public const string CACHE_KEY_PREFIX = "FindEvents";

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
                throw new HttpError(HttpStatusCode.Conflict, $"Event requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();
            _validated = true;
        }

        public override IDocEntity SaveChanges(bool ignoreCache, DocConstantPermission permission)
        {
            Description = Description?.TrimAndPruneSpaces();
            Status = Status?.TrimAndPruneSpaces();
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

                if(DocTools.IsNullOrEmpty(AuditRecord))
                {
                    isValid = false;
                    message += " AuditRecord is a required property.";
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Converters

        public Event ToDto() => Mapper.Map<DocEntityEvent, Event>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }

    public static partial class UniqueConstraintFilter
    {
        public static Expression<Func<DocEntityEvent, bool>> EventIgnoreArchived() => d => d.Archived == false;
    }

    public partial class EventMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityEvent,Event> _EntityToDto;
        protected IMappingExpression<Event,DocEntityEvent> _DtoToEntity;

        public EventMapper()
        {
            CreateMap<DocEntitySet<DocEntityEvent>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityEvent,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityEvent>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityEvent.GetEvent(c));
            _EntityToDto = CreateMap<DocEntityEvent,Event>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Event>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Event>(c, "Updated")))
                .ForMember(dest => dest.AuditRecord, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Event>(c, nameof(DocEntityEvent.AuditRecord))))
                .ForMember(dest => dest.AuditRecordId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Event>(c, nameof(DocEntityEvent.AuditRecordId))))
                .ForMember(dest => dest.Description, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Event>(c, nameof(DocEntityEvent.Description))))
                .ForMember(dest => dest.Processed, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Event>(c, nameof(DocEntityEvent.Processed))))
                .ForMember(dest => dest.Status, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Event>(c, nameof(DocEntityEvent.Status))))
                .ForMember(dest => dest.Teams, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Event>(c, nameof(DocEntityEvent.Teams))))
                .ForMember(dest => dest.TeamsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Event>(c, nameof(DocEntityEvent.TeamsCount))))
                .ForMember(dest => dest.Updates, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Event>(c, nameof(DocEntityEvent.Updates))))
                .ForMember(dest => dest.UpdatesCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Event>(c, nameof(DocEntityEvent.UpdatesCount))))
                .ForMember(dest => dest.Users, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Event>(c, nameof(DocEntityEvent.Users))))
                .ForMember(dest => dest.UsersCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Event>(c, nameof(DocEntityEvent.UsersCount))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<Event,DocEntityEvent>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
