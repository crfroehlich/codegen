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
    [TableMapping(DocConstantModelName.QUEUECHANNEL)]
    public partial class DocEntityQueueChannel : DocEntityBase
    {
        private const string QUEUECHANNEL_CACHE = "QueueChannelCache";
        public const string TABLE_NAME = DocConstantModelName.QUEUECHANNEL;
        
        #region Constructor
        public DocEntityQueueChannel(Session session) : base(session) {}

        public DocEntityQueueChannel() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        #region VisibleFields

        protected override List<string> _visibleFields
        {
            get
            {
                if(null == __vf)
                {
                    __vf = DocWebSession.GetTypeVisibleFields(new QueueChannel());
                }
                return __vf;
            }
        }

        #endregion VisibleFields

        #region Static Members
        public static DocEntityQueueChannel GetQueueChannel(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetQueueChannel(reference.Id) : null;
        }

        public static DocEntityQueueChannel GetQueueChannel(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityQueueChannel>.GetFromCache(primaryKey, QUEUECHANNEL_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityQueueChannel>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityQueueChannel>.UpdateCache(ret.Id, ret, QUEUECHANNEL_CACHE);
                    DocEntityThreadCache<DocEntityQueueChannel>.UpdateCache(ret.Hash, ret, QUEUECHANNEL_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityQueueChannel GetQueueChannel(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityQueueChannel>.GetFromCache(hash, QUEUECHANNEL_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityQueueChannel>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityQueueChannel>.UpdateCache(ret.Id, ret, QUEUECHANNEL_CACHE);
                    DocEntityThreadCache<DocEntityQueueChannel>.UpdateCache(ret.Hash, ret, QUEUECHANNEL_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field(Nullable = false, DefaultValue = false)]
        [FieldMapping(nameof(AutoDelete))]
        public bool AutoDelete { get; set; }


        [Field()]
        [FieldMapping(nameof(BackgroundTask))]
        public DocEntityBackgroundTask BackgroundTask { get; set; }
        public int? BackgroundTaskId { get { return BackgroundTask?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Description))]
        public string Description { get; set; }


        [Field(Nullable = false, DefaultValue = true)]
        [FieldMapping(nameof(Durable))]
        public bool Durable { get; set; }


        [Field(Nullable = false, DefaultValue = true)]
        [FieldMapping(nameof(Enabled))]
        public bool Enabled { get; set; }


        [Field(Nullable = false, DefaultValue = true)]
        [FieldMapping(nameof(Exclusive))]
        public bool Exclusive { get; set; }


        [Field(Nullable = false)]
        [FieldMapping(nameof(Name))]
        public string Name { get; set; }



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

        public const string CACHE_KEY_PREFIX = "FindQueueChannels";

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
                throw new HttpError(HttpStatusCode.Conflict, $"QueueChannel requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();

            FlushCache();

            _validated = true;


        }

        public override IDocEntity SaveChanges(DocConstantPermission permission = null)
        {
            Description = Description?.TrimAndPruneSpaces();
            Name = Name?.TrimAndPruneSpaces();
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

                if(DocTools.IsNullOrEmpty(AutoDelete))
                {
                    isValid = false;
                    message += " AutoDelete is a required property.";
                }
                if(DocTools.IsNullOrEmpty(Durable))
                {
                    isValid = false;
                    message += " Durable is a required property.";
                }
                if(DocTools.IsNullOrEmpty(Enabled))
                {
                    isValid = false;
                    message += " Enabled is a required property.";
                }
                if(DocTools.IsNullOrEmpty(Exclusive))
                {
                    isValid = false;
                    message += " Exclusive is a required property.";
                }
                if(DocTools.IsNullOrEmpty(Name))
                {
                    isValid = false;
                    message += " Name is a required property.";
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Converters

        public QueueChannel ToDto() => Mapper.Map<DocEntityQueueChannel, QueueChannel>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }

    public static partial class UniqueConstraintFilter
    {
        public static Expression<Func<DocEntityQueueChannel, bool>> QueueChannelIgnoreArchived() => d => d.Archived == false;
    }

    public partial class QueueChannelMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityQueueChannel,QueueChannel> _EntityToDto;
        protected IMappingExpression<QueueChannel,DocEntityQueueChannel> _DtoToEntity;

        public QueueChannelMapper()
        {
            CreateMap<DocEntitySet<DocEntityQueueChannel>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityQueueChannel,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityQueueChannel>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityQueueChannel.GetQueueChannel(c));
            _EntityToDto = CreateMap<DocEntityQueueChannel,QueueChannel>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<QueueChannel>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<QueueChannel>(c, "Updated")))
                .ForMember(dest => dest.AutoDelete, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<QueueChannel>(c, nameof(DocEntityQueueChannel.AutoDelete))))
                .ForMember(dest => dest.BackgroundTask, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<QueueChannel>(c, nameof(DocEntityQueueChannel.BackgroundTask))))
                .ForMember(dest => dest.BackgroundTaskId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<QueueChannel>(c, nameof(DocEntityQueueChannel.BackgroundTaskId))))
                .ForMember(dest => dest.Description, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<QueueChannel>(c, nameof(DocEntityQueueChannel.Description))))
                .ForMember(dest => dest.Durable, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<QueueChannel>(c, nameof(DocEntityQueueChannel.Durable))))
                .ForMember(dest => dest.Enabled, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<QueueChannel>(c, nameof(DocEntityQueueChannel.Enabled))))
                .ForMember(dest => dest.Exclusive, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<QueueChannel>(c, nameof(DocEntityQueueChannel.Exclusive))))
                .ForMember(dest => dest.Name, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<QueueChannel>(c, nameof(DocEntityQueueChannel.Name))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<QueueChannel,DocEntityQueueChannel>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
