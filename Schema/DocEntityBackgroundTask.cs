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
    [TableMapping(DocConstantModelName.BACKGROUNDTASK)]
    public partial class DocEntityBackgroundTask : DocEntityBase
    {
        private const string BACKGROUNDTASK_CACHE = "BackgroundTaskCache";
        public const string TABLE_NAME = DocConstantModelName.BACKGROUNDTASK;
        
        #region Constructor
        public DocEntityBackgroundTask(Session session) : base(session) {}

        public DocEntityBackgroundTask() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        #region VisibleFields

        protected override List<string> _visibleFields
        {
            get
            {
                if(null == __vf)
                {
                    __vf = DocWebSession.GetTypeVisibleFields(new BackgroundTask());
                }
                return __vf;
            }
        }

        #endregion VisibleFields

        #region Static Members
        public static DocEntityBackgroundTask GetBackgroundTask(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetBackgroundTask(reference.Id) : null;
        }

        public static DocEntityBackgroundTask GetBackgroundTask(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityBackgroundTask>.GetFromCache(primaryKey, BACKGROUNDTASK_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityBackgroundTask>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityBackgroundTask>.UpdateCache(ret.Id, ret, BACKGROUNDTASK_CACHE);
                    DocEntityThreadCache<DocEntityBackgroundTask>.UpdateCache(ret.Hash, ret, BACKGROUNDTASK_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityBackgroundTask GetBackgroundTask(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityBackgroundTask>.GetFromCache(hash, BACKGROUNDTASK_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityBackgroundTask>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityBackgroundTask>.UpdateCache(ret.Id, ret, BACKGROUNDTASK_CACHE);
                    DocEntityThreadCache<DocEntityBackgroundTask>.UpdateCache(ret.Hash, ret, BACKGROUNDTASK_CACHE);
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
        [FieldMapping(nameof(Channel))]
        public DocEntityQueueChannel Channel { get; set; }
        public int? ChannelId { get { return Channel?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Description))]
        public string Description { get; set; }


        [Field(Nullable = false, DefaultValue = true)]
        [FieldMapping(nameof(Enabled))]
        public bool Enabled { get; set; }


        [Field(DefaultValue = 60)]
        [FieldMapping(nameof(Frequency))]
        public int Frequency { get; set; }


        [Field(DefaultValue = 15)]
        [FieldMapping(nameof(HistoryRetention))]
        public int? HistoryRetention { get; set; }


        [Field()]
        [FieldMapping(nameof(Items))]
        [Association(PairTo = nameof(DocEntityBackgroundTaskItem.Task), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityBackgroundTaskItem> Items { get; private set; }


        public int? ItemsCount { get { return Items.Count(); } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(LastRunVersion))]
        public string LastRunVersion { get; set; }


        [Field(Nullable = false, DefaultValue = true)]
        [FieldMapping(nameof(LogError))]
        public bool LogError { get; set; }


        [Field(Nullable = false, DefaultValue = false)]
        [FieldMapping(nameof(LogInfo))]
        public bool LogInfo { get; set; }


        [Field(Nullable = false)]
        [FieldMapping(nameof(Name))]
        public string Name { get; set; }


        [Field()]
        [FieldMapping(nameof(RowsToProcessPerIteration))]
        public int RowsToProcessPerIteration { get; set; }


        [Field(Nullable = false, DefaultValue = false)]
        [FieldMapping(nameof(RunNow))]
        public bool RunNow { get; set; }


        [Field(DefaultValue = "midnight")]
        [FieldMapping(nameof(StartAt))]
        public string StartAt { get; set; }


        [Field()]
        [FieldMapping(nameof(TaskHistory))]
        [Association(PairTo = nameof(DocEntityBackgroundTaskHistory.Task), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityBackgroundTaskHistory> TaskHistory { get; private set; }


        public int? TaskHistoryCount { get { return TaskHistory.Count(); } private set { var noid = value; } }



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

        public const string CACHE_KEY_PREFIX = "FindBackgroundTasks";

        #endregion Overrides of DocEntity

        #region Entity overrides
        /// <summary>
        ///    Called when entity is about to be removed.
        /// </summary>
        protected override void OnRemoving()
        {
            try
            {
                Items.Clear(); //foreach thing in Items en.Remove();
            }
            catch(Exception ex)
            {
                throw new DocException("Failed to delete BackgroundTask in Items delete", ex);
            }
            try
            {
                TaskHistory.Clear(); //foreach thing in TaskHistory en.Remove();
            }
            catch(Exception ex)
            {
                throw new DocException("Failed to delete BackgroundTask in TaskHistory delete", ex);
            }
            base.OnRemoving();
        }

        /// <summary>
        ///    Called when entity should be validated. Override this method to perform custom object validation.
        /// </summary>
        protected override void OnValidate()
        {
            if (false == ValidationMessage.IsValid)
            {
                throw new HttpError(HttpStatusCode.Conflict, $"BackgroundTask requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();

            FlushCache();

            _validated = true;


        }

        public override IDocEntity SaveChanges(DocConstantPermission permission = null)
        {
            Description = Description?.TrimAndPruneSpaces();
            LastRunVersion = LastRunVersion?.TrimAndPruneSpaces();
            Name = Name?.TrimAndPruneSpaces();
            StartAt = StartAt?.TrimAndPruneSpaces();
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
                if(DocTools.IsNullOrEmpty(Enabled))
                {
                    isValid = false;
                    message += " Enabled is a required property.";
                }
                if(DocTools.IsNullOrEmpty(LogError))
                {
                    isValid = false;
                    message += " LogError is a required property.";
                }
                if(DocTools.IsNullOrEmpty(LogInfo))
                {
                    isValid = false;
                    message += " LogInfo is a required property.";
                }
                if(DocTools.IsNullOrEmpty(Name))
                {
                    isValid = false;
                    message += " Name is a required property.";
                }
                if(DocTools.IsNullOrEmpty(RunNow))
                {
                    isValid = false;
                    message += " RunNow is a required property.";
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Converters

        public BackgroundTask ToDto() => Mapper.Map<DocEntityBackgroundTask, BackgroundTask>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }

    public static partial class UniqueConstraintFilter
    {
        public static Expression<Func<DocEntityBackgroundTask, bool>> BackgroundTaskIgnoreArchived() => d => d.Archived == false;
    }

    public partial class BackgroundTaskMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityBackgroundTask,BackgroundTask> _EntityToDto;
        protected IMappingExpression<BackgroundTask,DocEntityBackgroundTask> _DtoToEntity;

        public BackgroundTaskMapper()
        {
            CreateMap<DocEntitySet<DocEntityBackgroundTask>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityBackgroundTask,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityBackgroundTask>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityBackgroundTask.GetBackgroundTask(c));
            _EntityToDto = CreateMap<DocEntityBackgroundTask,BackgroundTask>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTask>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTask>(c, "Updated")))
                .ForMember(dest => dest.App, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTask>(c, nameof(DocEntityBackgroundTask.App))))
                .ForMember(dest => dest.AppId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTask>(c, nameof(DocEntityBackgroundTask.AppId))))
                .ForMember(dest => dest.Channel, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTask>(c, nameof(DocEntityBackgroundTask.Channel))))
                .ForMember(dest => dest.ChannelId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTask>(c, nameof(DocEntityBackgroundTask.ChannelId))))
                .ForMember(dest => dest.Description, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTask>(c, nameof(DocEntityBackgroundTask.Description))))
                .ForMember(dest => dest.Enabled, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTask>(c, nameof(DocEntityBackgroundTask.Enabled))))
                .ForMember(dest => dest.Frequency, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTask>(c, nameof(DocEntityBackgroundTask.Frequency))))
                .ForMember(dest => dest.HistoryRetention, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTask>(c, nameof(DocEntityBackgroundTask.HistoryRetention))))
                .ForMember(dest => dest.Items, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTask>(c, nameof(DocEntityBackgroundTask.Items))))
                .ForMember(dest => dest.ItemsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTask>(c, nameof(DocEntityBackgroundTask.ItemsCount))))
                .ForMember(dest => dest.LastRunVersion, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTask>(c, nameof(DocEntityBackgroundTask.LastRunVersion))))
                .ForMember(dest => dest.LogError, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTask>(c, nameof(DocEntityBackgroundTask.LogError))))
                .ForMember(dest => dest.LogInfo, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTask>(c, nameof(DocEntityBackgroundTask.LogInfo))))
                .ForMember(dest => dest.Name, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTask>(c, nameof(DocEntityBackgroundTask.Name))))
                .ForMember(dest => dest.RowsToProcessPerIteration, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTask>(c, nameof(DocEntityBackgroundTask.RowsToProcessPerIteration))))
                .ForMember(dest => dest.RunNow, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTask>(c, nameof(DocEntityBackgroundTask.RunNow))))
                .ForMember(dest => dest.StartAt, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTask>(c, nameof(DocEntityBackgroundTask.StartAt))))
                .ForMember(dest => dest.TaskHistory, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTask>(c, nameof(DocEntityBackgroundTask.TaskHistory))))
                .ForMember(dest => dest.TaskHistoryCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<BackgroundTask>(c, nameof(DocEntityBackgroundTask.TaskHistoryCount))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<BackgroundTask,DocEntityBackgroundTask>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
