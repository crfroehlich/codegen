
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
    public abstract partial class DocumentSetBase : Dto<DocumentSet>
    {
        public DocumentSetBase() {}

        public DocumentSetBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public DocumentSetBase(int? id) : this(DocConvert.ToInt(id)) {}

        public DocumentSetBase(int? pId, List<Reference> pClients, int? pClientsCount, bool pConfidential, List<Reference> pDivisions, int? pDivisionsCount, List<Reference> pDocuments, int? pDocumentsCount, List<Reference> pDocumentSets, int? pDocumentSetsCount, List<Reference> pHistories, int? pHistoriesCount, int? pLegacyDocumentSetId, string pName, Reference pOwner, int? pOwnerId, Reference pProjectTeam, int? pProjectTeamId, List<Reference> pScopes, int? pScopesCount, string pSettings, List<Reference> pStats, int? pStatsCount, DocumentSetTypeEnm? pType, List<Reference> pUsers, int? pUsersCount) : this(DocConvert.ToInt(pId)) 
        {
            Clients = pClients;
            ClientsCount = pClientsCount;
            Confidential = pConfidential;
            Divisions = pDivisions;
            DivisionsCount = pDivisionsCount;
            Documents = pDocuments;
            DocumentsCount = pDocumentsCount;
            DocumentSets = pDocumentSets;
            DocumentSetsCount = pDocumentSetsCount;
            Histories = pHistories;
            HistoriesCount = pHistoriesCount;
            LegacyDocumentSetId = pLegacyDocumentSetId;
            Name = pName;
            Owner = pOwner;
            OwnerId = pOwnerId;
            ProjectTeam = pProjectTeam;
            ProjectTeamId = pProjectTeamId;
            Scopes = pScopes;
            ScopesCount = pScopesCount;
            Settings = pSettings;
            Stats = pStats;
            StatsCount = pStatsCount;
            Type = pType;
            Users = pUsers;
            UsersCount = pUsersCount;
        }

        [ApiMember(Name = nameof(Clients), Description = "Client", IsRequired = false)]
        public List<Reference> Clients { get; set; }
        public List<int> ClientsIds { get; set; }
        public int? ClientsCount { get; set; }


        [ApiMember(Name = nameof(Confidential), Description = "bool", IsRequired = false)]
        public bool Confidential { get; set; }


        [ApiMember(Name = nameof(Divisions), Description = "Division", IsRequired = false)]
        public List<Reference> Divisions { get; set; }
        public List<int> DivisionsIds { get; set; }
        public int? DivisionsCount { get; set; }


        [ApiMember(Name = nameof(Documents), Description = "Document", IsRequired = false)]
        public List<Reference> Documents { get; set; }
        public List<int> DocumentsIds { get; set; }
        public int? DocumentsCount { get; set; }


        [ApiMember(Name = nameof(DocumentSets), Description = "DocumentSet", IsRequired = false)]
        public List<Reference> DocumentSets { get; set; }
        public List<int> DocumentSetsIds { get; set; }
        public int? DocumentSetsCount { get; set; }


        [ApiMember(Name = nameof(Histories), Description = "DocumentSetHistory", IsRequired = false)]
        public List<Reference> Histories { get; set; }
        public List<int> HistoriesIds { get; set; }
        public int? HistoriesCount { get; set; }


        [ApiMember(Name = nameof(LegacyDocumentSetId), Description = "int?", IsRequired = false)]
        public int? LegacyDocumentSetId { get; set; }


        [ApiMember(Name = nameof(Name), Description = "string", IsRequired = true)]
        public string Name { get; set; }


        [ApiMember(Name = nameof(Owner), Description = "DocumentSet", IsRequired = false)]
        public Reference Owner { get; set; }
        [ApiMember(Name = nameof(OwnerId), Description = "Primary Key of DocumentSet", IsRequired = false)]
        public int? OwnerId { get; set; }


        [ApiMember(Name = nameof(ProjectTeam), Description = "Team", IsRequired = false)]
        public Reference ProjectTeam { get; set; }
        [ApiMember(Name = nameof(ProjectTeamId), Description = "Primary Key of Team", IsRequired = false)]
        public int? ProjectTeamId { get; set; }


        [ApiMember(Name = nameof(Scopes), Description = "Scope", IsRequired = false)]
        public List<Reference> Scopes { get; set; }
        public List<int> ScopesIds { get; set; }
        public int? ScopesCount { get; set; }


        [ApiMember(Name = nameof(Settings), Description = "string", IsRequired = false)]
        public string Settings { get; set; }


        [ApiMember(Name = nameof(Stats), Description = "StatsStudySet", IsRequired = false)]
        public List<Reference> Stats { get; set; }
        public List<int> StatsIds { get; set; }
        public int? StatsCount { get; set; }


        [ApiAllowableValues("Includes", Values = new string[] {@"Data Set",@"Disease State",@"Global",@"Library",@"SERVE Portal",@"Therapeutic Area"})]
        [ApiMember(Name = nameof(Type), Description = "DocumentSetTypeEnm?", IsRequired = false)]
        public DocumentSetTypeEnm? Type { get; set; }


        [ApiMember(Name = nameof(Users), Description = "User", IsRequired = false)]
        public List<Reference> Users { get; set; }
        public List<int> UsersIds { get; set; }
        public int? UsersCount { get; set; }



        public void Deconstruct(out List<Reference> pClients, out int? pClientsCount, out bool pConfidential, out List<Reference> pDivisions, out int? pDivisionsCount, out List<Reference> pDocuments, out int? pDocumentsCount, out List<Reference> pDocumentSets, out int? pDocumentSetsCount, out List<Reference> pHistories, out int? pHistoriesCount, out int? pLegacyDocumentSetId, out string pName, out Reference pOwner, out int? pOwnerId, out Reference pProjectTeam, out int? pProjectTeamId, out List<Reference> pScopes, out int? pScopesCount, out string pSettings, out List<Reference> pStats, out int? pStatsCount, out DocumentSetTypeEnm? pType, out List<Reference> pUsers, out int? pUsersCount)
        {
            pClients = Clients;
            pClientsCount = ClientsCount;
            pConfidential = Confidential;
            pDivisions = Divisions;
            pDivisionsCount = DivisionsCount;
            pDocuments = Documents;
            pDocumentsCount = DocumentsCount;
            pDocumentSets = DocumentSets;
            pDocumentSetsCount = DocumentSetsCount;
            pHistories = Histories;
            pHistoriesCount = HistoriesCount;
            pLegacyDocumentSetId = LegacyDocumentSetId;
            pName = Name;
            pOwner = Owner;
            pOwnerId = OwnerId;
            pProjectTeam = ProjectTeam;
            pProjectTeamId = ProjectTeamId;
            pScopes = Scopes;
            pScopesCount = ScopesCount;
            pSettings = Settings;
            pStats = Stats;
            pStatsCount = StatsCount;
            pType = Type;
            pUsers = Users;
            pUsersCount = UsersCount;
        }

        //Not ready until C# v8.?
        //public DocumentSetBase With(int? pId = Id, List<Reference> pClients = Clients, int? pClientsCount = ClientsCount, bool pConfidential = Confidential, List<Reference> pDivisions = Divisions, int? pDivisionsCount = DivisionsCount, List<Reference> pDocuments = Documents, int? pDocumentsCount = DocumentsCount, List<Reference> pDocumentSets = DocumentSets, int? pDocumentSetsCount = DocumentSetsCount, List<Reference> pHistories = Histories, int? pHistoriesCount = HistoriesCount, int? pLegacyDocumentSetId = LegacyDocumentSetId, string pName = Name, Reference pOwner = Owner, int? pOwnerId = OwnerId, Reference pProjectTeam = ProjectTeam, int? pProjectTeamId = ProjectTeamId, List<Reference> pScopes = Scopes, int? pScopesCount = ScopesCount, string pSettings = Settings, List<Reference> pStats = Stats, int? pStatsCount = StatsCount, DocumentSetTypeEnm? pType = Type, List<Reference> pUsers = Users, int? pUsersCount = UsersCount) => 
        //	new DocumentSetBase(pId, pClients, pClientsCount, pConfidential, pDivisions, pDivisionsCount, pDocuments, pDocumentsCount, pDocumentSets, pDocumentSetsCount, pHistories, pHistoriesCount, pLegacyDocumentSetId, pName, pOwner, pOwnerId, pProjectTeam, pProjectTeamId, pScopes, pScopesCount, pSettings, pStats, pStatsCount, pType, pUsers, pUsersCount);

    }


    [Route("/documentset", "POST")]
    [Route("/documentset/{Id}", "GET, PATCH, PUT, DELETE")]

    public partial class DocumentSet : DocumentSetBase, IReturn<DocumentSet>, IDto, ICloneable
    {
        public DocumentSet()
        {
            _Constructor();
        }

        public DocumentSet(int? id) : base(DocConvert.ToInt(id)) {}
        public DocumentSet(int id) : base(id) {}
        public DocumentSet(int? pId, List<Reference> pClients, int? pClientsCount, bool pConfidential, List<Reference> pDivisions, int? pDivisionsCount, List<Reference> pDocuments, int? pDocumentsCount, List<Reference> pDocumentSets, int? pDocumentSetsCount, List<Reference> pHistories, int? pHistoriesCount, int? pLegacyDocumentSetId, string pName, Reference pOwner, int? pOwnerId, Reference pProjectTeam, int? pProjectTeamId, List<Reference> pScopes, int? pScopesCount, string pSettings, List<Reference> pStats, int? pStatsCount, DocumentSetTypeEnm? pType, List<Reference> pUsers, int? pUsersCount) : 
            base(pId, pClients, pClientsCount, pConfidential, pDivisions, pDivisionsCount, pDocuments, pDocumentsCount, pDocumentSets, pDocumentSetsCount, pHistories, pHistoriesCount, pLegacyDocumentSetId, pName, pOwner, pOwnerId, pProjectTeam, pProjectTeamId, pScopes, pScopesCount, pSettings, pStats, pStatsCount, pType, pUsers, pUsersCount) { }

        public new bool? ShouldSerialize(string field)
        {
            //Allow individual classes to specify their own logic
            var manualOverride = _ShouldSerialize(field);
            if(null != manualOverride) return manualOverride;

            if (IgnoredSelect.Matches(field, true)) return false;
            var ret = MandatorySelect.Matches(field, true) || true == Select?.Matches(field, true);
            return ret;
        }

        public static List<string> Fields => DocTools.Fields<DocumentSet>();

        private List<string> _Select;
        [ApiMember(Name = nameof(Select), Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Clients),nameof(ClientsCount),nameof(Confidential),nameof(Created),nameof(CreatorId),nameof(Divisions),nameof(DivisionsCount),nameof(Documents),nameof(DocumentsCount),nameof(DocumentSets),nameof(DocumentSetsCount),nameof(Gestalt),nameof(Histories),nameof(HistoriesCount),nameof(LegacyDocumentSetId),nameof(Locked),nameof(Name),nameof(Owner),nameof(OwnerId),nameof(ProjectTeam),nameof(ProjectTeamId),nameof(Scopes),nameof(ScopesCount),nameof(Settings),nameof(Stats),nameof(StatsCount),nameof(Type),nameof(Updated),nameof(Users),nameof(UsersCount),nameof(VersionNo)})]
        public override List<string> Select
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
                _Select = DocPermissionFactory.SetSelect<DocumentSet>("DocumentSet",exists);

            }
        }

        [Obsolete, ApiMember(Name = nameof(VisibleFields), Description = "Deprecated. Use Select instead.", AllowMultiple = true)]
        public override List<string> VisibleFields { get => Select; set => Select = value; }


        private List<string> _collections = new List<string>
        {
            nameof(Clients), nameof(ClientsCount), nameof(Divisions), nameof(DivisionsCount), nameof(Documents), nameof(DocumentsCount), nameof(DocumentSets), nameof(DocumentSetsCount), nameof(Histories), nameof(HistoriesCount), nameof(Scopes), nameof(ScopesCount), nameof(Stats), nameof(StatsCount), nameof(Users), nameof(UsersCount)
        };
        private List<string> collections { get { return _collections; } }


        public object Clone() => this.Copy<DocumentSet>();

    }
    

    [Route("/documentset/{Id}/copy", "POST")]
    public partial class DocumentSetCopy : DocumentSet {}

    public partial class DocumentSetSearchBase : Search<DocumentSet>
    {
        public int? Id { get; set; }
        public List<int> ClientsIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> Confidential { get; set; }
        public List<int> DivisionsIds { get; set; }
        public List<int> DocumentsIds { get; set; }
        public List<int> DocumentSetsIds { get; set; }
        public List<int> HistoriesIds { get; set; }
        public int? LegacyDocumentSetId { get; set; }
        public string Name { get; set; }
        public Reference Owner { get; set; }
        public List<int> OwnerIds { get; set; }
        public Reference ProjectTeam { get; set; }
        public List<int> ProjectTeamIds { get; set; }
        public List<int> ScopesIds { get; set; }
        public string Settings { get; set; }
        public List<int> StatsIds { get; set; }
        public DocumentSetTypeEnm? Type { get; set; }
        public List<int> UsersIds { get; set; }
    }


    [Route("/documentset", "GET")]
    [Route("/documentset/version", "GET, POST")]
    [Route("/documentset/search", "GET, POST, DELETE")]

    public partial class DocumentSetSearch : DocumentSetSearchBase
    {
    }

    public class DocumentSetFullTextSearch
    {
        public DocumentSetFullTextSearch() {}
        private DocumentSetSearch _request;
        public DocumentSetFullTextSearch(DocumentSetSearch request) => _request = request;

        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.Created))); }
        public bool doUpdated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.Updated))); }

        public bool doClients { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.Clients))); }
        public bool doConfidential { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.Confidential))); }
        public bool doDivisions { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.Divisions))); }
        public bool doDocuments { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.Documents))); }
        public bool doDocumentSets { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.DocumentSets))); }
        public bool doHistories { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.Histories))); }
        public bool doLegacyDocumentSetId { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.LegacyDocumentSetId))); }
        public bool doName { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.Name))); }
        public bool doOwner { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.Owner))); }
        public bool doProjectTeam { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.ProjectTeam))); }
        public bool doScopes { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.Scopes))); }
        public bool doSettings { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.Settings))); }
        public bool doStats { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.Stats))); }
        public bool doType { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.Type))); }
        public bool doUsers { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.Users))); }
    }


    [Route("/documentset/batch", "DELETE, PATCH, POST, PUT")]

    public partial class DocumentSetBatch : List<DocumentSet> { }


    [Route("/documentset/{Id}/{Junction}/version", "GET, POST")]
    [Route("/documentset/{Id}/{Junction}", "GET, POST, DELETE")]
    public class DocumentSetJunction : DocumentSetSearchBase {}



}
