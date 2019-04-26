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
    [TableMapping(DocConstantModelName.WORKFLOW)]
    public partial class DocEntityWorkflow : DocEntityBase
    {
        private const string WORKFLOW_CACHE = "WorkflowCache";
        public const string TABLE_NAME = DocConstantModelName.WORKFLOW;
        
        #region Constructor
        public DocEntityWorkflow(Session session) : base(session) {}

        public DocEntityWorkflow() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        protected override List<string> _visibleFields => __vf ?? (__vf = DocWebSession.GetTypeVisibleFields(new Workflow()));

        #region Static Members
        public static DocEntityWorkflow Get(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? Get(reference.Id) : null;
        }

        public static DocEntityWorkflow Get(int? primaryKey)
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

        public static DocEntityWorkflow Get(Guid hash)
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
        [Field]
        public DocEntitySet<DocEntityLookupTableBinding> Bindings { get; private set; }


        public int? BindingsCount { get { return Bindings.Count(); } private set { var noid = value; } }


        [Field]
        [Association(PairTo = nameof(DocEntityWorkflowComment.Workflow), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityWorkflowComment> Comments { get; private set; }


        public int? CommentsCount { get { return Comments.Count(); } private set { var noid = value; } }


        [Field(Length = int.MaxValue, NullableOnUpgrade = true)]
        public string Data { get; set; }


        [Field]
        public string Description { get; set; }


        [Field]
        public DocEntitySet<DocEntityDocument> Documents { get; private set; }


        public int? DocumentsCount { get { return Documents.Count(); } private set { var noid = value; } }


        [Field(Nullable = false)]
        public string Name { get; set; }


        [Field]
        public DocEntityWorkflow Owner { get; set; }
        public int? OwnerId { get { return Owner?.Id; } private set { var noid = value; } }


        [Field]
        [Association(PairTo = nameof(DocEntityScope.Workflows), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityScope> Scopes { get; private set; }


        public int? ScopesCount { get { return Scopes.Count(); } private set { var noid = value; } }


        [Field]
        public DocEntityLookupTable Status { get; set; }
        public int? StatusId { get { return Status?.Id; } private set { var noid = value; } }


        [Field]
        [Association(PairTo = nameof(DocEntityWorkflowTask.Workflow), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityWorkflowTask> Tasks { get; private set; }


        public int? TasksCount { get { return Tasks.Count(); } private set { var noid = value; } }


        [Field(Nullable = false, NullableOnUpgrade = true)]
        public DocEntityLookupTable Type { get; set; }
        public int? TypeId { get { return Type?.Id; } private set { var noid = value; } }


        [Field(Nullable = false, NullableOnUpgrade = true)]
        public DocEntityUser User { get; set; }
        public int? UserId { get { return User?.Id; } private set { var noid = value; } }


        [Field]
        public DocEntitySet<DocEntityVariableInstance> Variables { get; private set; }


        public int? VariablesCount { get { return Variables.Count(); } private set { var noid = value; } }


        [Field]
        [Association(PairTo = nameof(DocEntityWorkflow.Owner), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityWorkflow> Workflows { get; private set; }


        public int? WorkflowsCount { get { return Workflows.Count(); } private set { var noid = value; } }


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

        public const string CACHE_KEY_PREFIX = "FindWorkflows";

        #endregion Overrides of DocEntity

        #region Entity overrides
        /// <summary>
        ///    Called when entity is about to be removed.
        /// </summary>
        protected override void OnRemoving()
        {
            base.OnRemoving();
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
            FlushCache();
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
            _validated = true;
        }

        public override IDocEntity SaveChanges(bool ignoreCache, DocConstantPermission permission)
        {
            Description = Description?.TrimAndPruneSpaces();
            Name = Name?.TrimAndPruneSpaces();
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
}
