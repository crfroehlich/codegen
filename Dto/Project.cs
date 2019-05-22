//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated by a T4 template. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;

using Services.Core;
using Services.Dto.internals;
using Services.Enums;

using ServiceStack;
using ServiceStack.Text;

using Typed;
using Typed.Notifications;
using Typed.Bindings;

using Xtensive.Orm;
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

        public ProjectBase(int? pId, List<Reference> pChildren, int? pChildrenCount, Reference pClient, int? pClientId, DateTime? pDatabaseDeadline, string pDatabaseName, Reference pDataset, int? pDatasetId, DateTime? pDeliverableDeadline, int? pFqId, Reference pFqWorkflow, int? pFqWorkflowId, int? pLegacyPackageId, Reference pLibrary, int? pLibraryId, int? pLibraryPackageId, string pLibraryPackageName, string pNumber, string pOperationsDeliverable, string pOpportunityId, string pOpportunityName, Reference pParent, int? pParentId, string pPICO, string pProjectId, string pProjectName, ForeignKeyStatusEnm? pStatus, List<Reference> pTimeCards, int? pTimeCardsCount) : this(DocConvert.ToInt(pId)) 
        {
            Children = pChildren;
            ChildrenCount = pChildrenCount;
            Client = pClient;
            ClientId = pClientId;
            DatabaseDeadline = pDatabaseDeadline;
            DatabaseName = pDatabaseName;
            Dataset = pDataset;
            DatasetId = pDatasetId;
            DeliverableDeadline = pDeliverableDeadline;
            FqId = pFqId;
            FqWorkflow = pFqWorkflow;
            FqWorkflowId = pFqWorkflowId;
            LegacyPackageId = pLegacyPackageId;
            Library = pLibrary;
            LibraryId = pLibraryId;
            LibraryPackageId = pLibraryPackageId;
            LibraryPackageName = pLibraryPackageName;
            Number = pNumber;
            OperationsDeliverable = pOperationsDeliverable;
            OpportunityId = pOpportunityId;
            OpportunityName = pOpportunityName;
            Parent = pParent;
            ParentId = pParentId;
            PICO = pPICO;
            ProjectId = pProjectId;
            ProjectName = pProjectName;
            Status = pStatus;
            TimeCards = pTimeCards;
            TimeCardsCount = pTimeCardsCount;
        }

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


        [ApiMember(Name = nameof(Dataset), Description = "DataSet", IsRequired = false)]
        public Reference Dataset { get; set; }
        [ApiMember(Name = nameof(DatasetId), Description = "Primary Key of DataSet", IsRequired = false)]
        public int? DatasetId { get; set; }


        [ApiMember(Name = nameof(DeliverableDeadline), Description = "DateTime?", IsRequired = false)]
        public DateTime? DeliverableDeadline { get; set; }


        [ApiMember(Name = nameof(FqId), Description = "int?", IsRequired = false)]
        public int? FqId { get; set; }


        [ApiMember(Name = nameof(FqWorkflow), Description = "Workflow", IsRequired = false)]
        public Reference FqWorkflow { get; set; }
        [ApiMember(Name = nameof(FqWorkflowId), Description = "Primary Key of Workflow", IsRequired = false)]
        public int? FqWorkflowId { get; set; }


        [ApiMember(Name = nameof(LegacyPackageId), Description = "int?", IsRequired = false)]
        public int? LegacyPackageId { get; set; }


        [ApiMember(Name = nameof(Library), Description = "LibrarySet", IsRequired = false)]
        public Reference Library { get; set; }
        [ApiMember(Name = nameof(LibraryId), Description = "Primary Key of LibrarySet", IsRequired = false)]
        public int? LibraryId { get; set; }


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


        [ApiAllowableValues("Includes", Values = new string[] {@"Active",@"Archived",@"Inactive"})]
        [ApiMember(Name = nameof(Status), Description = "ForeignKeyStatusEnm?", IsRequired = false)]
        public ForeignKeyStatusEnm? Status { get; set; }


        [ApiMember(Name = nameof(TimeCards), Description = "TimeCard", IsRequired = false)]
        public List<Reference> TimeCards { get; set; }
        public int? TimeCardsCount { get; set; }



        public void Deconstruct(out List<Reference> pChildren, out int? pChildrenCount, out Reference pClient, out int? pClientId, out DateTime? pDatabaseDeadline, out string pDatabaseName, out Reference pDataset, out int? pDatasetId, out DateTime? pDeliverableDeadline, out int? pFqId, out Reference pFqWorkflow, out int? pFqWorkflowId, out int? pLegacyPackageId, out Reference pLibrary, out int? pLibraryId, out int? pLibraryPackageId, out string pLibraryPackageName, out string pNumber, out string pOperationsDeliverable, out string pOpportunityId, out string pOpportunityName, out Reference pParent, out int? pParentId, out string pPICO, out string pProjectId, out string pProjectName, out ForeignKeyStatusEnm? pStatus, out List<Reference> pTimeCards, out int? pTimeCardsCount)
        {
            pChildren = Children;
            pChildrenCount = ChildrenCount;
            pClient = Client;
            pClientId = ClientId;
            pDatabaseDeadline = DatabaseDeadline;
            pDatabaseName = DatabaseName;
            pDataset = Dataset;
            pDatasetId = DatasetId;
            pDeliverableDeadline = DeliverableDeadline;
            pFqId = FqId;
            pFqWorkflow = FqWorkflow;
            pFqWorkflowId = FqWorkflowId;
            pLegacyPackageId = LegacyPackageId;
            pLibrary = Library;
            pLibraryId = LibraryId;
            pLibraryPackageId = LibraryPackageId;
            pLibraryPackageName = LibraryPackageName;
            pNumber = Number;
            pOperationsDeliverable = OperationsDeliverable;
            pOpportunityId = OpportunityId;
            pOpportunityName = OpportunityName;
            pParent = Parent;
            pParentId = ParentId;
            pPICO = PICO;
            pProjectId = ProjectId;
            pProjectName = ProjectName;
            pStatus = Status;
            pTimeCards = TimeCards;
            pTimeCardsCount = TimeCardsCount;
        }

        //Not ready until C# v8.?
        //public ProjectBase With(int? pId = Id, List<Reference> pChildren = Children, int? pChildrenCount = ChildrenCount, Reference pClient = Client, int? pClientId = ClientId, DateTime? pDatabaseDeadline = DatabaseDeadline, string pDatabaseName = DatabaseName, Reference pDataset = Dataset, int? pDatasetId = DatasetId, DateTime? pDeliverableDeadline = DeliverableDeadline, int? pFqId = FqId, Reference pFqWorkflow = FqWorkflow, int? pFqWorkflowId = FqWorkflowId, int? pLegacyPackageId = LegacyPackageId, Reference pLibrary = Library, int? pLibraryId = LibraryId, int? pLibraryPackageId = LibraryPackageId, string pLibraryPackageName = LibraryPackageName, string pNumber = Number, string pOperationsDeliverable = OperationsDeliverable, string pOpportunityId = OpportunityId, string pOpportunityName = OpportunityName, Reference pParent = Parent, int? pParentId = ParentId, string pPICO = PICO, string pProjectId = ProjectId, string pProjectName = ProjectName, ForeignKeyStatusEnm? pStatus = Status, List<Reference> pTimeCards = TimeCards, int? pTimeCardsCount = TimeCardsCount) => 
        //	new ProjectBase(pId, pChildren, pChildrenCount, pClient, pClientId, pDatabaseDeadline, pDatabaseName, pDataset, pDatasetId, pDeliverableDeadline, pFqId, pFqWorkflow, pFqWorkflowId, pLegacyPackageId, pLibrary, pLibraryId, pLibraryPackageId, pLibraryPackageName, pNumber, pOperationsDeliverable, pOpportunityId, pOpportunityName, pParent, pParentId, pPICO, pProjectId, pProjectName, pStatus, pTimeCards, pTimeCardsCount);

    }

    [Route("/project", "POST")]
    [Route("/project/{Id}", "GET, PATCH, PUT, DELETE")]
    public partial class Project : ProjectBase, IReturn<Project>, IDto, ICloneable
    {
        public Project()
        {
            _Constructor();
        }

        public Project(int? id) : base(DocConvert.ToInt(id)) {}
        public Project(int id) : base(id) {}
        public Project(int? pId, List<Reference> pChildren, int? pChildrenCount, Reference pClient, int? pClientId, DateTime? pDatabaseDeadline, string pDatabaseName, Reference pDataset, int? pDatasetId, DateTime? pDeliverableDeadline, int? pFqId, Reference pFqWorkflow, int? pFqWorkflowId, int? pLegacyPackageId, Reference pLibrary, int? pLibraryId, int? pLibraryPackageId, string pLibraryPackageName, string pNumber, string pOperationsDeliverable, string pOpportunityId, string pOpportunityName, Reference pParent, int? pParentId, string pPICO, string pProjectId, string pProjectName, ForeignKeyStatusEnm? pStatus, List<Reference> pTimeCards, int? pTimeCardsCount) : 
            base(pId, pChildren, pChildrenCount, pClient, pClientId, pDatabaseDeadline, pDatabaseName, pDataset, pDatasetId, pDeliverableDeadline, pFqId, pFqWorkflow, pFqWorkflowId, pLegacyPackageId, pLibrary, pLibraryId, pLibraryPackageId, pLibraryPackageName, pNumber, pOperationsDeliverable, pOpportunityId, pOpportunityName, pParent, pParentId, pPICO, pProjectId, pProjectName, pStatus, pTimeCards, pTimeCardsCount) { }
        #region Fields

        public new bool? ShouldSerialize(string field)
        {
            //Allow individual classes to specify their own logic
            var manualOverride = _ShouldSerialize(field);
            if(null != manualOverride) return manualOverride;

            if (IgnoredSelect.Matches(field, true)) return false;
            var ret = MandatorySelect.Matches(field, true) || true == Select?.Matches(field, true);
            return ret;
        }

        public static List<string> Fields => DocTools.Fields<Project>();

        private List<string> _Select;
        [ApiMember(Name = "Select", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Children),nameof(ChildrenCount),nameof(Client),nameof(ClientId),nameof(Created),nameof(CreatorId),nameof(DatabaseDeadline),nameof(DatabaseName),nameof(Dataset),nameof(DatasetId),nameof(DeliverableDeadline),nameof(FqId),nameof(FqWorkflow),nameof(FqWorkflowId),nameof(Gestalt),nameof(LegacyPackageId),nameof(Library),nameof(LibraryId),nameof(LibraryPackageId),nameof(LibraryPackageName),nameof(Locked),nameof(Number),nameof(OperationsDeliverable),nameof(OpportunityId),nameof(OpportunityName),nameof(Parent),nameof(ParentId),nameof(PICO),nameof(ProjectId),nameof(ProjectName),nameof(Status),nameof(TimeCards),nameof(TimeCardsCount),nameof(Updated),nameof(VersionNo)})]
        public new List<string> Select
        {
            get
            {
                if(null == this) return new List<string>();
                if(null == _Select)
                {
                    _Select = DocWebSession.GetTypeSelect(this);
                }
                return _Select;
            }
            set
            {
                var requested = value ?? new List<string>();
                var exists = requested.Where( r => Fields.Any( f => DocTools.AreEqual(r, f) ) ).ToList();
                _Select = DocPermissionFactory.SetSelect<Project>("Project",exists);
            }
        }

        #endregion Fields
        private List<string> _collections = new List<string>
        {
            nameof(Children), nameof(ChildrenCount), nameof(TimeCards), nameof(TimeCardsCount)
        };
        private List<string> collections { get { return _collections; } }

        public object Clone() => this.Copy<Project>();
    }
    
    [Route("/project/{Id}/copy", "POST")]
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
        public Reference FqWorkflow { get; set; }
        public List<int> FqWorkflowIds { get; set; }
        public int? LegacyPackageId { get; set; }
        public Reference Library { get; set; }
        public List<int> LibraryIds { get; set; }
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
        public ForeignKeyStatusEnm? Status { get; set; }
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
        public bool doCreated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Project.Created))); }
        public bool doUpdated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Project.Updated))); }

        public bool doChildren { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Project.Children))); }
        public bool doClient { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Project.Client))); }
        public bool doDatabaseDeadline { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Project.DatabaseDeadline))); }
        public bool doDatabaseName { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Project.DatabaseName))); }
        public bool doDataset { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Project.Dataset))); }
        public bool doDeliverableDeadline { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Project.DeliverableDeadline))); }
        public bool doFqId { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Project.FqId))); }
        public bool doFqWorkflow { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Project.FqWorkflow))); }
        public bool doLegacyPackageId { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Project.LegacyPackageId))); }
        public bool doLibrary { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Project.Library))); }
        public bool doLibraryPackageId { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Project.LibraryPackageId))); }
        public bool doLibraryPackageName { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Project.LibraryPackageName))); }
        public bool doNumber { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Project.Number))); }
        public bool doOperationsDeliverable { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Project.OperationsDeliverable))); }
        public bool doOpportunityId { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Project.OpportunityId))); }
        public bool doOpportunityName { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Project.OpportunityName))); }
        public bool doParent { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Project.Parent))); }
        public bool doPICO { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Project.PICO))); }
        public bool doProjectId { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Project.ProjectId))); }
        public bool doProjectName { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Project.ProjectName))); }
        public bool doStatus { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Project.Status))); }
        public bool doTimeCards { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Project.TimeCards))); }
    }

    [Route("/project/batch", "DELETE, PATCH, POST, PUT")]
    public partial class ProjectBatch : List<Project> { }

    [Route("/project/{Id}/{Junction}/version", "GET, POST")]
    [Route("/project/{Id}/{Junction}", "GET, POST, DELETE")]
    public class ProjectJunction : ProjectSearchBase {}


}
