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
    [TableMapping(DocConstantModelName.PROJECT)]
    public partial class DocEntityProject : DocEntityBase
    {
        private const string PROJECT_CACHE = "ProjectCache";
        public const string TABLE_NAME = DocConstantModelName.PROJECT;
        
        #region Constructor
        public DocEntityProject(Session session) : base(session) {}

        public DocEntityProject() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        protected override List<string> _visibleFields => __vf ?? (__vf = DocWebSession.GetTypeVisibleFields(new Project()));

        #region Static Members
        public static DocEntityProject Get(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? Get(reference.Id) : null;
        }

        public static DocEntityProject Get(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityProject>.GetFromCache(primaryKey, PROJECT_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityProject>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityProject>.UpdateCache(ret.Id, ret, PROJECT_CACHE);
                    DocEntityThreadCache<DocEntityProject>.UpdateCache(ret.Hash, ret, PROJECT_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityProject Get(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityProject>.GetFromCache(hash, PROJECT_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityProject>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityProject>.UpdateCache(ret.Id, ret, PROJECT_CACHE);
                    DocEntityThreadCache<DocEntityProject>.UpdateCache(ret.Hash, ret, PROJECT_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field]
        [Association(PairTo = nameof(DocEntityProject.Parent), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityProject> Children { get; private set; }


        public int? ChildrenCount { get { return Children.Count(); } private set { var noid = value; } }


        [Field]
        public DocEntityClient Client { get; set; }
        public int? ClientId { get { return Client?.Id; } private set { var noid = value; } }


        [Field]
        public DateTime? DatabaseDeadline { get; set; }


        [Field]
        public string DatabaseName { get; set; }


        [Field]
        public DocEntityDocumentSet Dataset { get; set; }
        public int? DatasetId { get { return Dataset?.Id; } private set { var noid = value; } }


        [Field]
        public DateTime? DeliverableDeadline { get; set; }


        [Field]
        public int? FqId { get; set; }


        [Field]
        public int? LegacyPackageId { get; set; }


        [Field]
        public int? LibraryPackageId { get; set; }


        [Field]
        public string LibraryPackageName { get; set; }


        [Field(DefaultValue = "001")]
        public string Number { get; set; }


        [Field]
        public string OperationsDeliverable { get; set; }


        [Field]
        public string OpportunityId { get; set; }


        [Field]
        public string OpportunityName { get; set; }


        [Field]
        public DocEntityProject Parent { get; set; }
        public int? ParentId { get { return Parent?.Id; } private set { var noid = value; } }


        [Field]
        public string PICO { get; set; }


        [Field]
        public string ProjectId { get; set; }


        [Field]
        public string ProjectName { get; set; }


        [Field]
        public DocEntityLookupTable Status { get; set; }
        public int? StatusId { get { return Status?.Id; } private set { var noid = value; } }


        [Field]
        [Association(PairTo = nameof(DocEntityTimeCard.Project), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityTimeCard> TimeCards { get; private set; }


        public int? TimeCardsCount { get { return TimeCards.Count(); } private set { var noid = value; } }


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

        public const string CACHE_KEY_PREFIX = "FindProjects";

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
                Children.Clear(); //foreach thing in Children en.Remove();
            }
            catch(Exception ex)
            {
                throw new DocException("Failed to delete Project in Children delete", ex);
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
                throw new HttpError(HttpStatusCode.Conflict, $"Project requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();
            _validated = true;
        }

        public override IDocEntity SaveChanges(bool ignoreCache, DocConstantPermission permission)
        {
            DatabaseName = DatabaseName?.TrimAndPruneSpaces();
            LibraryPackageName = LibraryPackageName?.TrimAndPruneSpaces();
            Number = Number?.TrimAndPruneSpaces();
            OperationsDeliverable = OperationsDeliverable?.TrimAndPruneSpaces();
            OpportunityId = OpportunityId?.TrimAndPruneSpaces();
            OpportunityName = OpportunityName?.TrimAndPruneSpaces();
            PICO = PICO?.TrimAndPruneSpaces();
            ProjectId = ProjectId?.TrimAndPruneSpaces();
            ProjectName = ProjectName?.TrimAndPruneSpaces();
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

                if(null != Status && Status?.Enum?.Name != "ForeignKeyStatus")
                {
                    isValid = false;
                    message += " Status is a " + Status?.Enum?.Name + ", but must be a ForeignKeyStatus.";
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Converters

        public Project ToDto() => Mapper.Map<DocEntityProject, Project>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }
}
