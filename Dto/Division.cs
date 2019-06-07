
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
    public abstract partial class DivisionBase : Dto<Division>
    {
        public DivisionBase() {}

        public DivisionBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public DivisionBase(int? id) : this(DocConvert.ToInt(id)) {}

        public DivisionBase(int? pId, Reference pClient, int? pClientId, Reference pDefaultLocale, int? pDefaultLocaleId, List<Reference> pDocumentSets, int? pDocumentSetsCount, string pName, Reference pRole, int? pRoleId, DivisionSettings pSettings, List<Reference> pUsers, int? pUsersCount) : this(DocConvert.ToInt(pId)) 
        {
            Client = pClient;
            ClientId = pClientId;
            DefaultLocale = pDefaultLocale;
            DefaultLocaleId = pDefaultLocaleId;
            DocumentSets = pDocumentSets;
            DocumentSetsCount = pDocumentSetsCount;
            Name = pName;
            Role = pRole;
            RoleId = pRoleId;
            Settings = pSettings;
            Users = pUsers;
            UsersCount = pUsersCount;
        }

        [ApiMember(Name = nameof(Client), Description = "Client", IsRequired = true)]
        public Reference Client { get; set; }
        [ApiMember(Name = nameof(ClientId), Description = "Primary Key of Client", IsRequired = false)]
        public int? ClientId { get; set; }


        [ApiMember(Name = nameof(DefaultLocale), Description = "Locale", IsRequired = false)]
        public Reference DefaultLocale { get; set; }
        [ApiMember(Name = nameof(DefaultLocaleId), Description = "Primary Key of Locale", IsRequired = false)]
        public int? DefaultLocaleId { get; set; }


        [ApiMember(Name = nameof(DocumentSets), Description = "DocumentSet", IsRequired = false)]
        public List<Reference> DocumentSets { get; set; }
        public List<int> DocumentSetsIds { get; set; }
        public int? DocumentSetsCount { get; set; }


        [ApiMember(Name = nameof(Name), Description = "string", IsRequired = true)]
        public string Name { get; set; }
        public List<int> NameIds { get; set; }
        public int? NameCount { get; set; }


        [ApiMember(Name = nameof(Role), Description = "Role", IsRequired = true)]
        public Reference Role { get; set; }
        [ApiMember(Name = nameof(RoleId), Description = "Primary Key of Role", IsRequired = false)]
        public int? RoleId { get; set; }


        [ApiMember(Name = nameof(Settings), Description = "DivisionSettings", IsRequired = false)]
        public DivisionSettings Settings { get; set; }
        public List<int> SettingsIds { get; set; }
        public int? SettingsCount { get; set; }


        [ApiMember(Name = nameof(Users), Description = "User", IsRequired = false)]
        public List<Reference> Users { get; set; }
        public List<int> UsersIds { get; set; }
        public int? UsersCount { get; set; }



        public void Deconstruct(out Reference pClient, out int? pClientId, out Reference pDefaultLocale, out int? pDefaultLocaleId, out List<Reference> pDocumentSets, out int? pDocumentSetsCount, out string pName, out Reference pRole, out int? pRoleId, out DivisionSettings pSettings, out List<Reference> pUsers, out int? pUsersCount)
        {
            pClient = Client;
            pClientId = ClientId;
            pDefaultLocale = DefaultLocale;
            pDefaultLocaleId = DefaultLocaleId;
            pDocumentSets = DocumentSets;
            pDocumentSetsCount = DocumentSetsCount;
            pName = Name;
            pRole = Role;
            pRoleId = RoleId;
            pSettings = Settings;
            pUsers = Users;
            pUsersCount = UsersCount;
        }

        //Not ready until C# v8.?
        //public DivisionBase With(int? pId = Id, Reference pClient = Client, int? pClientId = ClientId, Reference pDefaultLocale = DefaultLocale, int? pDefaultLocaleId = DefaultLocaleId, List<Reference> pDocumentSets = DocumentSets, int? pDocumentSetsCount = DocumentSetsCount, string pName = Name, Reference pRole = Role, int? pRoleId = RoleId, DivisionSettings pSettings = Settings, List<Reference> pUsers = Users, int? pUsersCount = UsersCount) => 
        //	new DivisionBase(pId, pClient, pClientId, pDefaultLocale, pDefaultLocaleId, pDocumentSets, pDocumentSetsCount, pName, pRole, pRoleId, pSettings, pUsers, pUsersCount);

    }


    [Route("/division", "POST")]
    [Route("/division/{Id}", "GET, PATCH, PUT, DELETE")]

    public partial class Division : DivisionBase, IReturn<Division>, IDto, ICloneable
    {
        public Division() => _Constructor();

        public Division(int? id) : base(DocConvert.ToInt(id)) {}
        public Division(int id) : base(id) {}
        public Division(int? pId, Reference pClient, int? pClientId, Reference pDefaultLocale, int? pDefaultLocaleId, List<Reference> pDocumentSets, int? pDocumentSetsCount, string pName, Reference pRole, int? pRoleId, DivisionSettings pSettings, List<Reference> pUsers, int? pUsersCount) :
            base(pId, pClient, pClientId, pDefaultLocale, pDefaultLocaleId, pDocumentSets, pDocumentSetsCount, pName, pRole, pRoleId, pSettings, pUsers, pUsersCount) { }

        public static List<string> Fields => DocTools.Fields<Division>();

        private List<string> _Select;
        [ApiMember(Name = nameof(Select), Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Client),nameof(ClientId),nameof(Created),nameof(CreatorId),nameof(DefaultLocale),nameof(DefaultLocaleId),nameof(DocumentSets),nameof(DocumentSetsCount),nameof(Gestalt),nameof(Locked),nameof(Name),nameof(Role),nameof(RoleId),nameof(Settings),nameof(Updated),nameof(Users),nameof(UsersCount),nameof(VersionNo)})]
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
                _Select = DocPermissionFactory.SetSelect<Division>("Division",exists);

            }
        }

        [Obsolete, ApiMember(Name = nameof(VisibleFields), Description = "Deprecated. Use Select instead.", AllowMultiple = true)]
        public override List<string> VisibleFields { get => Select; set => Select = value; }


        private List<string> _collections = new List<string>
        {
            nameof(DocumentSets), nameof(DocumentSetsCount), nameof(DocumentSetsIds), nameof(Users), nameof(UsersCount), nameof(UsersIds)
        };
        private List<string> collections { get { return _collections; } }


        public object Clone() => this.Copy<Division>();

    }
    

    [Route("/division/{Id}/copy", "POST")]
    public partial class DivisionCopy : Division {}

    public partial class DivisionSearchBase : Search<Division>
    {
        public int? Id { get; set; }
        public Reference Client { get; set; }
        public List<int> ClientIds { get; set; }
        public Reference DefaultLocale { get; set; }
        public List<int> DefaultLocaleIds { get; set; }
        public List<int> DocumentSetsIds { get; set; }
        public string Name { get; set; }
        public Reference Role { get; set; }
        public List<int> RoleIds { get; set; }
        public string Settings { get; set; }
        public List<int> UsersIds { get; set; }
    }


    [Route("/division", "GET")]
    [Route("/division/version", "GET, POST")]
    [Route("/division/search", "GET, POST, DELETE")]

    public partial class DivisionSearch : DivisionSearchBase
    {
    }

    public class DivisionFullTextSearch
    {
        public DivisionFullTextSearch() {}
        private DivisionSearch _request;
        public DivisionFullTextSearch(DivisionSearch request) => _request = request;

        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Division.Created))); }
        public bool doUpdated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Division.Updated))); }

        public bool doClient { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Division.Client))); }
        public bool doDefaultLocale { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Division.DefaultLocale))); }
        public bool doDocumentSets { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Division.DocumentSets))); }
        public bool doName { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Division.Name))); }
        public bool doRole { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Division.Role))); }
        public bool doSettings { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Division.Settings))); }
        public bool doUsers { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Division.Users))); }
    }


    [Route("/division/batch", "DELETE, PATCH, POST, PUT")]

    public partial class DivisionBatch : List<Division> { }


    [Route("/division/{Id}/{Junction}/version", "GET, POST")]
    [Route("/division/{Id}/{Junction}", "GET, POST, DELETE")]
    public class DivisionJunction : DivisionSearchBase {}



}
