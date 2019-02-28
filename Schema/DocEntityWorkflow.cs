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
    [TableMapping(DocConstantModelName.WORKFLOW)]
    public partial class DocEntityWorkflow : DocEntityBase
    {
        private const string WORKFLOW_CACHE = "WorkflowCache";
        public const string TABLE_NAME = DocConstantModelName.WORKFLOW;
        
        #region Constructor
        public DocEntityWorkflow(Session session) : base(session) {}

        public DocEntityWorkflow() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        #region VisibleFields

        protected override List<string> _visibleFields
        {
            get
            {
                if(null == __vf)
                {
                    __vf = DocWebSession.GetTypeVisibleFields(new Workflow());
                }
                return __vf;
            }
        }

        #endregion VisibleFields

        #region Static Members
        public static DocEntityWorkflow GetWorkflow(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetWorkflow(reference.Id) : null;
        }

        public static DocEntityWorkflow GetWorkflow(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityWorkflow>.GetFromCache(primaryKey, WORKFLOW_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityWorkflow>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityWorkflow>.UpdateCache(ret.Id, ret, WORKFLOW_CACHE);
                    DocEntityThreadCache<DocEntityWorkflow>.UpdateCache(ret.Hash, ret, WORKFLOW_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityWorkflow GetWorkflow(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityWorkflow>.GetFromCache(hash, WORKFLOW_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityWorkflow>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityWorkflow>.UpdateCache(ret.Id, ret, WORKFLOW_CACHE);
                    DocEntityThreadCache<DocEntityWorkflow>.UpdateCache(ret.Hash, ret, WORKFLOW_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field()]
        [FieldMapping(nameof(Bindings))]
        public DocEntitySet<DocEntityLookupTableBinding> Bindings { get; private set; }


        public int? BindingsCount { get { return Bindings.Count(); } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Comments))]
        [Association(PairTo = nameof(DocEntityWorkflowComment.Workflow), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityWorkflowComment> Comments { get; private set; }


        public int? CommentsCount { get { return Comments.Count(); } private set { var noid = value; } }


        [Field(DefaultValue = "{}", Length = int.MaxValue, NullableOnUpgrade = true)]
        [FieldMapping(nameof(Data))]
        public string Data { get; set; }


        [Field()]
        [FieldMapping(nameof(Description))]
        public string Description { get; set; }


        [Field()]
        [FieldMapping(nameof(Documents))]
        public DocEntitySet<DocEntityDocument> Documents { get; private set; }


        public int? DocumentsCount { get { return Documents.Count(); } private set { var noid = value; } }


        [Field(Nullable = false)]
        [FieldMapping(nameof(Name))]
        public string Name { get; set; }


        [Field()]
        [FieldMapping(nameof(Owner))]
        public DocEntityWorkflow Owner { get; set; }
        public int? OwnerId { get { return Owner?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Scopes))]
        [Association(PairTo = nameof(DocEntityScope.Workflows), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityScope> Scopes { get; private set; }


        public int? ScopesCount { get { return Scopes.Count(); } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Status))]
        public DocEntityLookupTable Status { get; set; }
        public int? StatusId { get { return Status?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Tags))]
        public DocEntitySet<DocEntityTag> Tags { get; private set; }


        public int? TagsCount { get { return Tags.Count(); } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Tasks))]
        [Association(PairTo = nameof(DocEntityWorkflowTask.Workflow), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityWorkflowTask> Tasks { get; private set; }


        public int? TasksCount { get { return Tasks.Count(); } private set { var noid = value; } }


        [Field(Nullable = false, NullableOnUpgrade = true)]
        [FieldMapping(nameof(Type))]
        public DocEntityLookupTable Type { get; set; }
        public int? TypeId { get { return Type?.Id; } private set { var noid = value; } }


        [Field(Nullable = false, NullableOnUpgrade = true)]
        [FieldMapping(nameof(User))]
        public DocEntityUser User { get; set; }
        public int? UserId { get { return User?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Variables))]
        public DocEntitySet<DocEntityVariableInstance> Variables { get; private set; }


        public int? VariablesCount { get { return Variables.Count(); } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Workflows))]
        [Association(PairTo = nameof(DocEntityWorkflow.Owner), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityWorkflow> Workflows { get; private set; }


        public int? WorkflowsCount { get { return Workflows.Count(); } private set { var noid = value; } }



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

        public const string CACHE_KEY_PREFIX = "FindWorkflows";

        #endregion Overrides of DocEntity

        #region Entity overrides
        /// <summary>
        ///    Called when entity is about to be removed.
        /// </summary>
        protected override void OnRemoving()
        {
            try
            {
                Comments.Clear(); //foreach thing in Comments en.Remove();
            }
            catch(Exception ex)
            {
                throw new DocException("Failed to delete Workflow in Comments delete", ex);
            }
            try
            {
                Tasks.Clear(); //foreach thing in Tasks en.Remove();
            }
            catch(Exception ex)
            {
                throw new DocException("Failed to delete Workflow in Tasks delete", ex);
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
                throw new HttpError(HttpStatusCode.Conflict, $"Workflow requires: {ValidationMessage.Message}.");
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

                if(DocTools.IsNullOrEmpty(Name))
                {
                    isValid = false;
                    message += " Name is a required property.";
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
                    if(Type.Enum?.Name != "Workflow")
                    {
                        isValid = false;
                        message += " Type is a " + Type.Enum.Name + ", but must be a Workflow.";
                    }
                }
                if(DocTools.IsNullOrEmpty(User))
                {
                    isValid = false;
                    message += " User is a required property.";
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Converters

        public Workflow ToDto() => Mapper.Map<DocEntityWorkflow, Workflow>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }

    public static partial class UniqueConstraintFilter
    {
        public static Expression<Func<DocEntityWorkflow, bool>> WorkflowIgnoreArchived() => d => d.Archived == false;
    }

    public partial class WorkflowMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityWorkflow,Workflow> _EntityToDto;
        protected IMappingExpression<Workflow,DocEntityWorkflow> _DtoToEntity;

        public WorkflowMapper()
        {
            CreateMap<DocEntitySet<DocEntityWorkflow>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityWorkflow,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityWorkflow>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityWorkflow.GetWorkflow(c));
            _EntityToDto = CreateMap<DocEntityWorkflow,Workflow>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Workflow>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Workflow>(c, "Updated")))
                .ForMember(dest => dest.Bindings, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Workflow>(c, nameof(DocEntityWorkflow.Bindings))))
                .ForMember(dest => dest.BindingsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Workflow>(c, nameof(DocEntityWorkflow.BindingsCount))))
                .ForMember(dest => dest.Comments, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Workflow>(c, nameof(DocEntityWorkflow.Comments))))
                .ForMember(dest => dest.CommentsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Workflow>(c, nameof(DocEntityWorkflow.CommentsCount))))
                .ForMember(dest => dest.Data, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Workflow>(c, nameof(DocEntityWorkflow.Data))))
                .ForMember(dest => dest.Description, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Workflow>(c, nameof(DocEntityWorkflow.Description))))
                .ForMember(dest => dest.Documents, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Workflow>(c, nameof(DocEntityWorkflow.Documents))))
                .ForMember(dest => dest.DocumentsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Workflow>(c, nameof(DocEntityWorkflow.DocumentsCount))))
                .ForMember(dest => dest.Name, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Workflow>(c, nameof(DocEntityWorkflow.Name))))
                .ForMember(dest => dest.Owner, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Workflow>(c, nameof(DocEntityWorkflow.Owner))))
                .ForMember(dest => dest.OwnerId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Workflow>(c, nameof(DocEntityWorkflow.OwnerId))))
                .ForMember(dest => dest.Scopes, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Workflow>(c, nameof(DocEntityWorkflow.Scopes))))
                .ForMember(dest => dest.ScopesCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Workflow>(c, nameof(DocEntityWorkflow.ScopesCount))))
                .ForMember(dest => dest.Status, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Workflow>(c, nameof(DocEntityWorkflow.Status))))
                .ForMember(dest => dest.StatusId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Workflow>(c, nameof(DocEntityWorkflow.StatusId))))
                .ForMember(dest => dest.Tags, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Workflow>(c, nameof(DocEntityWorkflow.Tags))))
                .ForMember(dest => dest.TagsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Workflow>(c, nameof(DocEntityWorkflow.TagsCount))))
                .ForMember(dest => dest.Tasks, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Workflow>(c, nameof(DocEntityWorkflow.Tasks))))
                .ForMember(dest => dest.TasksCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Workflow>(c, nameof(DocEntityWorkflow.TasksCount))))
                .ForMember(dest => dest.Type, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Workflow>(c, nameof(DocEntityWorkflow.Type))))
                .ForMember(dest => dest.TypeId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Workflow>(c, nameof(DocEntityWorkflow.TypeId))))
                .ForMember(dest => dest.User, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Workflow>(c, nameof(DocEntityWorkflow.User))))
                .ForMember(dest => dest.UserId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Workflow>(c, nameof(DocEntityWorkflow.UserId))))
                .ForMember(dest => dest.Variables, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Workflow>(c, nameof(DocEntityWorkflow.Variables))))
                .ForMember(dest => dest.VariablesCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Workflow>(c, nameof(DocEntityWorkflow.VariablesCount))))
                .ForMember(dest => dest.Workflows, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Workflow>(c, nameof(DocEntityWorkflow.Workflows))))
                .ForMember(dest => dest.WorkflowsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Workflow>(c, nameof(DocEntityWorkflow.WorkflowsCount))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<Workflow,DocEntityWorkflow>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
