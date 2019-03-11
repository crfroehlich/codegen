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
    [TableMapping(DocConstantModelName.WORKFLOWTASK)]
    public partial class DocEntityWorkflowTask : DocEntityBase
    {
        private const string WORKFLOWTASK_CACHE = "WorkflowTaskCache";
        public const string TABLE_NAME = DocConstantModelName.WORKFLOWTASK;
        
        #region Constructor
        public DocEntityWorkflowTask(Session session) : base(session) {}

        public DocEntityWorkflowTask() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        #region VisibleFields

        protected override List<string> _visibleFields
        {
            get
            {
                if(null == __vf)
                {
                    __vf = DocWebSession.GetTypeVisibleFields(new WorkflowTask());
                }
                return __vf;
            }
        }

        #endregion VisibleFields

        #region Static Members
        public static DocEntityWorkflowTask GetWorkflowTask(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetWorkflowTask(reference.Id) : null;
        }

        public static DocEntityWorkflowTask GetWorkflowTask(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityWorkflowTask>.GetFromCache(primaryKey, WORKFLOWTASK_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityWorkflowTask>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityWorkflowTask>.UpdateCache(ret.Id, ret, WORKFLOWTASK_CACHE);
                    DocEntityThreadCache<DocEntityWorkflowTask>.UpdateCache(ret.Hash, ret, WORKFLOWTASK_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityWorkflowTask GetWorkflowTask(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityWorkflowTask>.GetFromCache(hash, WORKFLOWTASK_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityWorkflowTask>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityWorkflowTask>.UpdateCache(ret.Id, ret, WORKFLOWTASK_CACHE);
                    DocEntityThreadCache<DocEntityWorkflowTask>.UpdateCache(ret.Hash, ret, WORKFLOWTASK_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field()]
        [FieldMapping(nameof(Assignee))]
        public DocEntityUser Assignee { get; set; }
        public int? AssigneeId { get { return Assignee?.Id; } private set { var noid = value; } }


        [Field(Length = int.MaxValue)]
        [FieldMapping(nameof(Data))]
        public string Data { get; set; }


        [Field(Nullable = false)]
        [FieldMapping(nameof(Description))]
        public string Description { get; set; }


        [Field()]
        [FieldMapping(nameof(DueDate))]
        public DateTime? DueDate { get; set; }


        [Field(Nullable = false)]
        [FieldMapping(nameof(Reporter))]
        public DocEntityUser Reporter { get; set; }
        public int? ReporterId { get { return Reporter?.Id; } private set { var noid = value; } }


        [Field(NullableOnUpgrade = true)]
        [FieldMapping(nameof(Status))]
        public DocEntityLookupTable Status { get; set; }
        public int? StatusId { get { return Status?.Id; } private set { var noid = value; } }


        [Field(Nullable = false, NullableOnUpgrade = true)]
        [FieldMapping(nameof(Type))]
        public DocEntityLookupTable Type { get; set; }
        public int? TypeId { get { return Type?.Id; } private set { var noid = value; } }


        [Field(Nullable = false)]
        [FieldMapping(nameof(Workflow))]
        public DocEntityWorkflow Workflow { get; set; }
        public int? WorkflowId { get { return Workflow?.Id; } private set { var noid = value; } }



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

        public const string CACHE_KEY_PREFIX = "FindWorkflowTasks";

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
                throw new HttpError(HttpStatusCode.Conflict, $"WorkflowTask requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();

            FlushCache();

            _validated = true;


        }

        public override IDocEntity SaveChanges(DocConstantPermission permission = null)
        {
            Description = Description?.TrimAndPruneSpaces();
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

                if(DocTools.IsNullOrEmpty(Description))
                {
                    isValid = false;
                    message += " Description is a required property.";
                }
                if(DocTools.IsNullOrEmpty(Reporter))
                {
                    isValid = false;
                    message += " Reporter is a required property.";
                }
                if(null != Status && Status?.Enum?.Name != "WorkflowStatus")
                {
                    isValid = false;
                    message += " Status is a " + Status?.Enum?.Name + ", but must be a WorkflowStatus.";
                }
                if(DocTools.IsNullOrEmpty(Type))
                {
                    isValid = false;
                    message += " Type is a required property.";
                }
                else
                {
                    if(Type.Enum?.Name != "WorkflowTaskType")
                    {
                        isValid = false;
                        message += " Type is a " + Type.Enum.Name + ", but must be a WorkflowTaskType.";
                    }
                }
                if(DocTools.IsNullOrEmpty(Workflow))
                {
                    isValid = false;
                    message += " Workflow is a required property.";
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Converters

        public WorkflowTask ToDto() => Mapper.Map<DocEntityWorkflowTask, WorkflowTask>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }

    public static partial class UniqueConstraintFilter
    {
        public static Expression<Func<DocEntityWorkflowTask, bool>> WorkflowTaskIgnoreArchived() => d => d.Archived == false;
    }

    public partial class WorkflowTaskMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityWorkflowTask,WorkflowTask> _EntityToDto;
        protected IMappingExpression<WorkflowTask,DocEntityWorkflowTask> _DtoToEntity;

        public WorkflowTaskMapper()
        {
            CreateMap<DocEntitySet<DocEntityWorkflowTask>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityWorkflowTask,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityWorkflowTask>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityWorkflowTask.GetWorkflowTask(c));
            _EntityToDto = CreateMap<DocEntityWorkflowTask,WorkflowTask>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<WorkflowTask>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<WorkflowTask>(c, "Updated")))
                .ForMember(dest => dest.Assignee, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<WorkflowTask>(c, nameof(DocEntityWorkflowTask.Assignee))))
                .ForMember(dest => dest.AssigneeId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<WorkflowTask>(c, nameof(DocEntityWorkflowTask.AssigneeId))))
                .ForMember(dest => dest.Data, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<WorkflowTask>(c, nameof(DocEntityWorkflowTask.Data))))
                .ForMember(dest => dest.Description, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<WorkflowTask>(c, nameof(DocEntityWorkflowTask.Description))))
                .ForMember(dest => dest.DueDate, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<WorkflowTask>(c, nameof(DocEntityWorkflowTask.DueDate))))
                .ForMember(dest => dest.Reporter, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<WorkflowTask>(c, nameof(DocEntityWorkflowTask.Reporter))))
                .ForMember(dest => dest.ReporterId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<WorkflowTask>(c, nameof(DocEntityWorkflowTask.ReporterId))))
                .ForMember(dest => dest.Status, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<WorkflowTask>(c, nameof(DocEntityWorkflowTask.Status))))
                .ForMember(dest => dest.StatusId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<WorkflowTask>(c, nameof(DocEntityWorkflowTask.StatusId))))
                .ForMember(dest => dest.Type, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<WorkflowTask>(c, nameof(DocEntityWorkflowTask.Type))))
                .ForMember(dest => dest.TypeId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<WorkflowTask>(c, nameof(DocEntityWorkflowTask.TypeId))))
                .ForMember(dest => dest.Workflow, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<WorkflowTask>(c, nameof(DocEntityWorkflowTask.Workflow))))
                .ForMember(dest => dest.WorkflowId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<WorkflowTask>(c, nameof(DocEntityWorkflowTask.WorkflowId))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<WorkflowTask,DocEntityWorkflowTask>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
