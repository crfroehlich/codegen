﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when
//    the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AutoMapper;

using Services.Core;
using Services.Db;
using Services.Dto;
using Services.Dto.internals;
using Services.Enums;
using Services.Models;
using Services.Schema;

using Typed;
using Typed.Bindings;
using Typed.Notifications;
using Services.Dto.Security;
using Typed.Settings;

using ServiceStack;
using ServiceStack.Text;

using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Dynamic;
using System.Net;

using Xtensive.Orm;
using Xtensive.Orm.Model;

using Attribute = Services.Dto.Attribute;
using ValueType = Services.Dto.ValueType;

namespace Services.Dto
{
    public abstract partial class ProjectBase : Dto<Project>
    {
        public ProjectBase() {}

        public ProjectBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public ProjectBase(int? id) : this(DocConvert.ToInt(id)) {}
    
        [ApiMember(Name = nameof(Children), Description = "Project", IsRequired = false)]
        public List<Reference> Children { get; set; }
        public int? ChildrenCount { get; set; }


        [ApiMember(Name = nameof(Client), Description = "Client", IsRequired = false)]
        public Reference Client { get; set; }
        [ApiMember(Name = nameof(ClientId), Description = "Primary Key of Client", IsRequired = false)]
        public int? ClientId { get; set; }


        [ApiMember(Name = nameof(DatabaseDeadline), Description = "DateTime?", IsRequired = false)]
        public DateTime? DatabaseDeadline { get; set; }


        [ApiMember(Name = nameof(DatabaseName), Description = "string", IsRequired = false)]
        public string DatabaseName { get; set; }


        [ApiMember(Name = nameof(Dataset), Description = "DocumentSet", IsRequired = false)]
        public Reference Dataset { get; set; }
        [ApiMember(Name = nameof(DatasetId), Description = "Primary Key of DocumentSet", IsRequired = false)]
        public int? DatasetId { get; set; }


        [ApiMember(Name = nameof(DeliverableDeadline), Description = "DateTime?", IsRequired = false)]
        public DateTime? DeliverableDeadline { get; set; }


        [ApiMember(Name = nameof(FqId), Description = "int?", IsRequired = false)]
        public int? FqId { get; set; }


        [ApiMember(Name = nameof(LegacyPackageId), Description = "int?", IsRequired = false)]
        public int? LegacyPackageId { get; set; }


        [ApiMember(Name = nameof(LibraryPackageId), Description = "int?", IsRequired = false)]
        public int? LibraryPackageId { get; set; }


        [ApiMember(Name = nameof(LibraryPackageName), Description = "string", IsRequired = false)]
        public string LibraryPackageName { get; set; }


        [ApiMember(Name = nameof(Number), Description = "string", IsRequired = false)]
        public string Number { get; set; }


        [ApiMember(Name = nameof(OperationsDeliverable), Description = "string", IsRequired = false)]
        public string OperationsDeliverable { get; set; }


        [ApiMember(Name = nameof(OpportunityId), Description = "string", IsRequired = false)]
        public string OpportunityId { get; set; }


        [ApiMember(Name = nameof(OpportunityName), Description = "string", IsRequired = false)]
        public string OpportunityName { get; set; }


        [ApiMember(Name = nameof(Parent), Description = "Project", IsRequired = false)]
        public Reference Parent { get; set; }
        [ApiMember(Name = nameof(ParentId), Description = "Primary Key of Project", IsRequired = false)]
        public int? ParentId { get; set; }


        [ApiMember(Name = nameof(PICO), Description = "string", IsRequired = false)]
        public string PICO { get; set; }


        [ApiMember(Name = nameof(ProjectId), Description = "string", IsRequired = false)]
        public string ProjectId { get; set; }


        [ApiMember(Name = nameof(ProjectName), Description = "string", IsRequired = false)]
        public string ProjectName { get; set; }


        [ApiMember(Name = nameof(Status), Description = "LookupTable", IsRequired = false)]
        [ApiAllowableValues("Includes", Values = new string[] {@"Active",@"Archived",@"Inactive"})]
        public Reference Status { get; set; }
        [ApiMember(Name = nameof(StatusId), Description = "Primary Key of LookupTable", IsRequired = false)]
        public int? StatusId { get; set; }


        [ApiMember(Name = nameof(TimeCards), Description = "TimeCard", IsRequired = false)]
        public List<Reference> TimeCards { get; set; }
        public int? TimeCardsCount { get; set; }


    }

    [Route("/project", "POST")]
    [Route("/project/{Id}", "GET, PATCH, PUT, DELETE")]
    public partial class Project : ProjectBase, IReturn<Project>, IDto
    {
        public Project()
        {
            _Constructor();
        }

        public Project(int? id) : base(DocConvert.ToInt(id)) {}
        public Project(int id) : base(id) {}
        
        #region Fields
        
        public bool? ShouldSerialize(string field)
        {
            if (IgnoredVisibleFields.Matches(field, true)) return false;
            var ret = MandatoryVisibleFields.Matches(field, true) || true == VisibleFields?.Matches(field, true);
            return ret;
        }

        public static List<string> Fields => DocTools.Fields<Project>();

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Children),nameof(ChildrenCount),nameof(Client),nameof(ClientId),nameof(Created),nameof(CreatorId),nameof(DatabaseDeadline),nameof(DatabaseName),nameof(Dataset),nameof(DatasetId),nameof(DeliverableDeadline),nameof(FqId),nameof(Gestalt),nameof(LegacyPackageId),nameof(LibraryPackageId),nameof(LibraryPackageName),nameof(Locked),nameof(Number),nameof(OperationsDeliverable),nameof(OpportunityId),nameof(OpportunityName),nameof(Parent),nameof(ParentId),nameof(PICO),nameof(ProjectId),nameof(ProjectName),nameof(Status),nameof(StatusId),nameof(TimeCards),nameof(TimeCardsCount),nameof(Updated),nameof(VersionNo)})]
        public new List<string> VisibleFields
        {
            get
            {
                if(null == this) return new List<string>();
                if(null == _VisibleFields)
                {
                    _VisibleFields = DocWebSession.GetTypeVisibleFields(this);
                }
                return _VisibleFields;
            }
            set
            {
                var requested = value ?? new List<string>();
                var exists = requested.Where( r => Fields.Any( f => DocTools.AreEqual(r, f) ) ).ToList();
                _VisibleFields = DocPermissionFactory.SetVisibleFields<Project>("Project",exists);
            }
        }

        #endregion Fields
        private List<string> _collections = new List<string>
        {
            nameof(Children), nameof(ChildrenCount), nameof(TimeCards), nameof(TimeCardsCount)
        };
        private List<string> collections { get { return _collections; } }
    }
    
    [Route("/Project/{Id}/copy", "POST")]
    public partial class ProjectCopy : Project {}
    public partial class ProjectSearchBase : Search<Project>
    {
        public int? Id { get; set; }
        public List<int> ChildrenIds { get; set; }
        public Reference Client { get; set; }
        public List<int> ClientIds { get; set; }
        public DateTime? DatabaseDeadline { get; set; }
        public DateTime? DatabaseDeadlineAfter { get; set; }
        public DateTime? DatabaseDeadlineBefore { get; set; }
        public string DatabaseName { get; set; }
        public Reference Dataset { get; set; }
        public List<int> DatasetIds { get; set; }
        public DateTime? DeliverableDeadline { get; set; }
        public DateTime? DeliverableDeadlineAfter { get; set; }
        public DateTime? DeliverableDeadlineBefore { get; set; }
        public int? FqId { get; set; }
        public int? LegacyPackageId { get; set; }
        public int? LibraryPackageId { get; set; }
        public string LibraryPackageName { get; set; }
        public string Number { get; set; }
        public string OperationsDeliverable { get; set; }
        public string OpportunityId { get; set; }
        public string OpportunityName { get; set; }
        public Reference Parent { get; set; }
        public List<int> ParentIds { get; set; }
        public string PICO { get; set; }
        public string ProjectId { get; set; }
        public string ProjectName { get; set; }
        public Reference Status { get; set; }
        public List<int> StatusIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"Active",@"Archived",@"Inactive"})]
        public List<string> StatusNames { get; set; }
        public List<int> TimeCardsIds { get; set; }
    }

    [Route("/project", "GET")]
    [Route("/project/version", "GET, POST")]
    [Route("/project/search", "GET, POST, DELETE")]
    public partial class ProjectSearch : ProjectSearchBase
    {
    }

    public class ProjectFullTextSearch
    {
        public ProjectFullTextSearch() {}
        private ProjectSearch _request;
        public ProjectFullTextSearch(ProjectSearch request) => _request = request;
        
        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Project.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Project.Updated))); }
        
        public bool doChildren { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Project.Children))); }
        public bool doClient { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Project.Client))); }
        public bool doDatabaseDeadline { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Project.DatabaseDeadline))); }
        public bool doDatabaseName { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Project.DatabaseName))); }
        public bool doDataset { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Project.Dataset))); }
        public bool doDeliverableDeadline { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Project.DeliverableDeadline))); }
        public bool doFqId { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Project.FqId))); }
        public bool doLegacyPackageId { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Project.LegacyPackageId))); }
        public bool doLibraryPackageId { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Project.LibraryPackageId))); }
        public bool doLibraryPackageName { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Project.LibraryPackageName))); }
        public bool doNumber { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Project.Number))); }
        public bool doOperationsDeliverable { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Project.OperationsDeliverable))); }
        public bool doOpportunityId { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Project.OpportunityId))); }
        public bool doOpportunityName { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Project.OpportunityName))); }
        public bool doParent { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Project.Parent))); }
        public bool doPICO { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Project.PICO))); }
        public bool doProjectId { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Project.ProjectId))); }
        public bool doProjectName { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Project.ProjectName))); }
        public bool doStatus { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Project.Status))); }
        public bool doTimeCards { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Project.TimeCards))); }
    }

    [Route("/project/batch", "DELETE, PATCH, POST, PUT")]
    public partial class ProjectBatch : List<Project> { }

    [Route("/project/{Id}/{Junction}/version", "GET, POST")]
    [Route("/project/{Id}/{Junction}", "GET, POST, DELETE")]
    public class ProjectJunction : ProjectSearchBase {}


}