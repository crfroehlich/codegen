﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when
//    the code is regenerated.
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
    [TableMapping(DocConstantModelName.PROJECT)]
    public partial class DocEntityProject : DocEntityBase
    {
        private const string PROJECT_CACHE = "ProjectCache";
        public const string TABLE_NAME = DocConstantModelName.PROJECT;
        
        #region Constructor
        public DocEntityProject(Session session) : base(session) {}

        public DocEntityProject() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        #region VisibleFields

        protected override List<string> _visibleFields
        {
            get
            {
                if(null == __vf)
                {
                    __vf = DocWebSession.GetTypeVisibleFields(new Project());
                }
                return __vf;
            }
        }

        #endregion VisibleFields

        #region Static Members
        public static DocEntityProject GetProject(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetProject(reference.Id) : null;
        }

        public static DocEntityProject GetProject(int? primaryKey)
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

        public static DocEntityProject GetProject(Guid hash)
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
        [Field()]
        [FieldMapping(nameof(Children))]
        [Association(PairTo = nameof(DocEntityProject.Parent), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityProject> Children { get; private set; }


        public int? ChildrenCount { get { return Children.Count(); } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Client))]
        public DocEntityClient Client { get; set; }
        public int? ClientId { get { return Client?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(DatabaseDeadline))]
        public DateTime? DatabaseDeadline { get; set; }


        [Field()]
        [FieldMapping(nameof(DatabaseName))]
        public string DatabaseName { get; set; }


        [Field()]
        [FieldMapping(nameof(Dataset))]
        public DocEntityDocumentSet Dataset { get; set; }
        public int? DatasetId { get { return Dataset?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(DeliverableDeadline))]
        public DateTime? DeliverableDeadline { get; set; }


        [Field()]
        [FieldMapping(nameof(FqId))]
        public int? FqId { get; set; }


        [Field()]
        [FieldMapping(nameof(LegacyPackageId))]
        public int? LegacyPackageId { get; set; }


        [Field()]
        [FieldMapping(nameof(LibraryPackageId))]
        public int? LibraryPackageId { get; set; }


        [Field()]
        [FieldMapping(nameof(LibraryPackageName))]
        public string LibraryPackageName { get; set; }


        [Field(DefaultValue = "001")]
        [FieldMapping(nameof(Number))]
        public string Number { get; set; }


        [Field()]
        [FieldMapping(nameof(OperationsDeliverable))]
        public string OperationsDeliverable { get; set; }


        [Field()]
        [FieldMapping(nameof(OpportunityId))]
        public string OpportunityId { get; set; }


        [Field()]
        [FieldMapping(nameof(OpportunityName))]
        public string OpportunityName { get; set; }


        [Field()]
        [FieldMapping(nameof(Parent))]
        public DocEntityProject Parent { get; set; }
        public int? ParentId { get { return Parent?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(PICO))]
        public string PICO { get; set; }


        [Field()]
        [FieldMapping(nameof(ProjectId))]
        public string ProjectId { get; set; }


        [Field()]
        [FieldMapping(nameof(ProjectName))]
        public string ProjectName { get; set; }


        [Field()]
        [FieldMapping(nameof(Status))]
        public DocEntityLookupTable Status { get; set; }
        public int? StatusId { get { return Status?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(TimeCards))]
        [Association(PairTo = nameof(DocEntityTimeCard.Project), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityTimeCard> TimeCards { get; private set; }


        public int? TimeCardsCount { get { return TimeCards.Count(); } private set { var noid = value; } }



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

        public const string CACHE_KEY_PREFIX = "FindProjects";


        public override T ToModel<T>() =>  null;

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
                throw new DocException("Failed to delete Project in Children delete", ex);
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
                throw new HttpError(HttpStatusCode.Conflict, $"Project requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();

            FlushCache();

            _validated = true;


        }

        public override IDocEntity SaveChanges(DocConstantPermission permission = null)
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

    public static partial class UniqueConstraintFilter
    {
        public static Expression<Func<DocEntityProject, bool>> ProjectIgnoreArchived() => d => d.Archived == false;
    }

    public partial class ProjectMapper : DocMapperBase
    {
        private IMappingExpression<DocEntityProject,Project> _EntityToDto;
        private IMappingExpression<Project,DocEntityProject> _DtoToEntity;
        public ProjectMapper()
        {
            CreateMap<DocEntitySet<DocEntityProject>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityProject,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityProject>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityProject.GetProject(c));
            _EntityToDto = CreateMap<DocEntityProject,Project>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Project>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Project>(c, "Updated")))
                .ForMember(dest => dest.Children, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Project>(c, nameof(DocEntityProject.Children))))
                .ForMember(dest => dest.ChildrenCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Project>(c, nameof(DocEntityProject.ChildrenCount))))
                .ForMember(dest => dest.Client, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Project>(c, nameof(DocEntityProject.Client))))
                .ForMember(dest => dest.ClientId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Project>(c, nameof(DocEntityProject.ClientId))))
                .ForMember(dest => dest.DatabaseDeadline, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Project>(c, nameof(DocEntityProject.DatabaseDeadline))))
                .ForMember(dest => dest.DatabaseName, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Project>(c, nameof(DocEntityProject.DatabaseName))))
                .ForMember(dest => dest.Dataset, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Project>(c, nameof(DocEntityProject.Dataset))))
                .ForMember(dest => dest.DatasetId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Project>(c, nameof(DocEntityProject.DatasetId))))
                .ForMember(dest => dest.DeliverableDeadline, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Project>(c, nameof(DocEntityProject.DeliverableDeadline))))
                .ForMember(dest => dest.FqId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Project>(c, nameof(DocEntityProject.FqId))))
                .ForMember(dest => dest.LegacyPackageId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Project>(c, nameof(DocEntityProject.LegacyPackageId))))
                .ForMember(dest => dest.LibraryPackageId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Project>(c, nameof(DocEntityProject.LibraryPackageId))))
                .ForMember(dest => dest.LibraryPackageName, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Project>(c, nameof(DocEntityProject.LibraryPackageName))))
                .ForMember(dest => dest.Number, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Project>(c, nameof(DocEntityProject.Number))))
                .ForMember(dest => dest.OperationsDeliverable, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Project>(c, nameof(DocEntityProject.OperationsDeliverable))))
                .ForMember(dest => dest.OpportunityId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Project>(c, nameof(DocEntityProject.OpportunityId))))
                .ForMember(dest => dest.OpportunityName, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Project>(c, nameof(DocEntityProject.OpportunityName))))
                .ForMember(dest => dest.Parent, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Project>(c, nameof(DocEntityProject.Parent))))
                .ForMember(dest => dest.ParentId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Project>(c, nameof(DocEntityProject.ParentId))))
                .ForMember(dest => dest.PICO, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Project>(c, nameof(DocEntityProject.PICO))))
                .ForMember(dest => dest.ProjectId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Project>(c, nameof(DocEntityProject.ProjectId))))
                .ForMember(dest => dest.ProjectName, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Project>(c, nameof(DocEntityProject.ProjectName))))
                .ForMember(dest => dest.Status, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Project>(c, nameof(DocEntityProject.Status))))
                .ForMember(dest => dest.StatusId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Project>(c, nameof(DocEntityProject.StatusId))))
                .ForMember(dest => dest.TimeCards, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Project>(c, nameof(DocEntityProject.TimeCards))))
                .ForMember(dest => dest.TimeCardsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Project>(c, nameof(DocEntityProject.TimeCardsCount))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<Project,DocEntityProject>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}