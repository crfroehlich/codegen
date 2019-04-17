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
    [TableMapping(DocConstantModelName.WORKFLOWCOMMENT)]
    public partial class DocEntityWorkflowComment : DocEntityBase
    {
        private const string WORKFLOWCOMMENT_CACHE = "WorkflowCommentCache";
        public const string TABLE_NAME = DocConstantModelName.WORKFLOWCOMMENT;
        
        #region Constructor
        public DocEntityWorkflowComment(Session session) : base(session) {}

        public DocEntityWorkflowComment() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        #region VisibleFields

        protected override List<string> _visibleFields
        {
            get
            {
                if(null == __vf)
                {
                    __vf = DocWebSession.GetTypeVisibleFields(new WorkflowComment());
                }
                return __vf;
            }
        }

        #endregion VisibleFields

        #region Static Members
        public static DocEntityWorkflowComment GetWorkflowComment(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetWorkflowComment(reference.Id) : null;
        }

        public static DocEntityWorkflowComment GetWorkflowComment(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityWorkflowComment>.GetFromCache(primaryKey, WORKFLOWCOMMENT_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityWorkflowComment>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityWorkflowComment>.UpdateCache(ret.Id, ret, WORKFLOWCOMMENT_CACHE);
                    DocEntityThreadCache<DocEntityWorkflowComment>.UpdateCache(ret.Hash, ret, WORKFLOWCOMMENT_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityWorkflowComment GetWorkflowComment(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityWorkflowComment>.GetFromCache(hash, WORKFLOWCOMMENT_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityWorkflowComment>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityWorkflowComment>.UpdateCache(ret.Id, ret, WORKFLOWCOMMENT_CACHE);
                    DocEntityThreadCache<DocEntityWorkflowComment>.UpdateCache(ret.Hash, ret, WORKFLOWCOMMENT_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field()]
        [FieldMapping(nameof(Children))]
        [Association(PairTo = nameof(DocEntityWorkflowComment.Parent), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityWorkflowComment> Children { get; private set; }


        public int? ChildrenCount { get { return Children.Count(); } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Parent))]
        public DocEntityWorkflowComment Parent { get; set; }
        public int? ParentId { get { return Parent?.Id; } private set { var noid = value; } }


        [Field(Length = int.MaxValue)]
        [FieldMapping(nameof(Text))]
        public string Text { get; set; }


        [Field(Nullable = false)]
        [FieldMapping(nameof(User))]
        public DocEntityUser User { get; set; }
        public int? UserId { get { return User?.Id; } private set { var noid = value; } }


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

        public const string CACHE_KEY_PREFIX = "FindWorkflowComments";

        #endregion Overrides of DocEntity

        #region Entity overrides
        /// <summary>
        ///    Called when entity is about to be removed.
        /// </summary>
        protected override void OnRemoving()
        {
            try
            {
                Children.Clear(); //foreach thing in Children en.Remove();
            }
            catch(Exception ex)
            {
                throw new DocException("Failed to delete WorkflowComment in Children delete", ex);
            }
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
                throw new HttpError(HttpStatusCode.Conflict, $"WorkflowComment requires: {ValidationMessage.Message}.");
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

                if(DocTools.IsNullOrEmpty(User))
                {
                    isValid = false;
                    message += " User is a required property.";
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

        public WorkflowComment ToDto() => Mapper.Map<DocEntityWorkflowComment, WorkflowComment>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }

    public static partial class UniqueConstraintFilter
    {
        public static Expression<Func<DocEntityWorkflowComment, bool>> WorkflowCommentIgnoreArchived() => d => d.Archived == false;
    }

    public partial class WorkflowCommentMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityWorkflowComment,WorkflowComment> _EntityToDto;
        protected IMappingExpression<WorkflowComment,DocEntityWorkflowComment> _DtoToEntity;

        public WorkflowCommentMapper()
        {
            CreateMap<DocEntitySet<DocEntityWorkflowComment>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityWorkflowComment,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityWorkflowComment>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityWorkflowComment.GetWorkflowComment(c));
            _EntityToDto = CreateMap<DocEntityWorkflowComment,WorkflowComment>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<WorkflowComment>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<WorkflowComment>(c, "Updated")))
                .ForMember(dest => dest.Children, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<WorkflowComment>(c, nameof(DocEntityWorkflowComment.Children))))
                .ForMember(dest => dest.ChildrenCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<WorkflowComment>(c, nameof(DocEntityWorkflowComment.ChildrenCount))))
                .ForMember(dest => dest.Parent, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<WorkflowComment>(c, nameof(DocEntityWorkflowComment.Parent))))
                .ForMember(dest => dest.ParentId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<WorkflowComment>(c, nameof(DocEntityWorkflowComment.ParentId))))
                .ForMember(dest => dest.Text, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<WorkflowComment>(c, nameof(DocEntityWorkflowComment.Text))))
                .ForMember(dest => dest.User, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<WorkflowComment>(c, nameof(DocEntityWorkflowComment.User))))
                .ForMember(dest => dest.UserId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<WorkflowComment>(c, nameof(DocEntityWorkflowComment.UserId))))
                .ForMember(dest => dest.Workflow, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<WorkflowComment>(c, nameof(DocEntityWorkflowComment.Workflow))))
                .ForMember(dest => dest.WorkflowId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<WorkflowComment>(c, nameof(DocEntityWorkflowComment.WorkflowId))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<WorkflowComment,DocEntityWorkflowComment>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
