
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
    public abstract partial class EventBase : Dto<Event>
    {
        public EventBase() {}

        public EventBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public EventBase(int? id) : this(DocConvert.ToInt(id)) {}

        public EventBase(int? pId, Reference pAuditRecord, int? pAuditRecordId, string pDescription, DateTime? pProcessed, string pStatus, List<Reference> pTeams, int? pTeamsCount, List<Reference> pUpdates, int? pUpdatesCount, List<Reference> pUsers, int? pUsersCount) : this(DocConvert.ToInt(pId)) 
        {
            AuditRecord = pAuditRecord;
            AuditRecordId = pAuditRecordId;
            Description = pDescription;
            Processed = pProcessed;
            Status = pStatus;
            Teams = pTeams;
            TeamsCount = pTeamsCount;
            Updates = pUpdates;
            UpdatesCount = pUpdatesCount;
            Users = pUsers;
            UsersCount = pUsersCount;
        }

        [ApiMember(Name = nameof(AuditRecord), Description = "AuditRecord", IsRequired = true)]
        public Reference AuditRecord { get; set; }
        [ApiMember(Name = nameof(AuditRecordId), Description = "Primary Key of AuditRecord", IsRequired = false)]
        public int? AuditRecordId { get; set; }


        [ApiMember(Name = nameof(Description), Description = "string", IsRequired = false)]
        public string Description { get; set; }


        [ApiMember(Name = nameof(Processed), Description = "DateTime?", IsRequired = false)]
        public DateTime? Processed { get; set; }


        [ApiMember(Name = nameof(Status), Description = "string", IsRequired = false)]
        public string Status { get; set; }


        [ApiMember(Name = nameof(Teams), Description = "Team", IsRequired = false)]
        public List<Reference> Teams { get; set; }
        public List<int> TeamsIds { get; set; }
        public int? TeamsCount { get; set; }


        [ApiMember(Name = nameof(Updates), Description = "Update", IsRequired = false)]
        public List<Reference> Updates { get; set; }
        public List<int> UpdatesIds { get; set; }
        public int? UpdatesCount { get; set; }


        [ApiMember(Name = nameof(Users), Description = "User", IsRequired = false)]
        public List<Reference> Users { get; set; }
        public List<int> UsersIds { get; set; }
        public int? UsersCount { get; set; }



        public void Deconstruct(out Reference pAuditRecord, out int? pAuditRecordId, out string pDescription, out DateTime? pProcessed, out string pStatus, out List<Reference> pTeams, out int? pTeamsCount, out List<Reference> pUpdates, out int? pUpdatesCount, out List<Reference> pUsers, out int? pUsersCount)
        {
            pAuditRecord = AuditRecord;
            pAuditRecordId = AuditRecordId;
            pDescription = Description;
            pProcessed = Processed;
            pStatus = Status;
            pTeams = Teams;
            pTeamsCount = TeamsCount;
            pUpdates = Updates;
            pUpdatesCount = UpdatesCount;
            pUsers = Users;
            pUsersCount = UsersCount;
        }

        //Not ready until C# v8.?
        //public EventBase With(int? pId = Id, Reference pAuditRecord = AuditRecord, int? pAuditRecordId = AuditRecordId, string pDescription = Description, DateTime? pProcessed = Processed, string pStatus = Status, List<Reference> pTeams = Teams, int? pTeamsCount = TeamsCount, List<Reference> pUpdates = Updates, int? pUpdatesCount = UpdatesCount, List<Reference> pUsers = Users, int? pUsersCount = UsersCount) => 
        //	new EventBase(pId, pAuditRecord, pAuditRecordId, pDescription, pProcessed, pStatus, pTeams, pTeamsCount, pUpdates, pUpdatesCount, pUsers, pUsersCount);

    }


    [Route("/event/{Id}", "GET")]

    public partial class Event : EventBase, IReturn<Event>, IDto, ICloneable
    {
        public Event()
        {
            _Constructor();
        }

        public Event(int? id) : base(DocConvert.ToInt(id)) {}
        public Event(int id) : base(id) {}
        public Event(int? pId, Reference pAuditRecord, int? pAuditRecordId, string pDescription, DateTime? pProcessed, string pStatus, List<Reference> pTeams, int? pTeamsCount, List<Reference> pUpdates, int? pUpdatesCount, List<Reference> pUsers, int? pUsersCount) : 
            base(pId, pAuditRecord, pAuditRecordId, pDescription, pProcessed, pStatus, pTeams, pTeamsCount, pUpdates, pUpdatesCount, pUsers, pUsersCount) { }
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

        public static List<string> Fields => DocTools.Fields<Event>();

        private List<string> _Select;
        [ApiMember(Name = "Select", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(AuditRecord),nameof(AuditRecordId),nameof(Created),nameof(CreatorId),nameof(Description),nameof(Gestalt),nameof(Locked),nameof(Processed),nameof(Status),nameof(Teams),nameof(TeamsCount),nameof(Updated),nameof(Updates),nameof(UpdatesCount),nameof(Users),nameof(UsersCount),nameof(VersionNo)})]
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
                _Select = DocPermissionFactory.SetSelect<Event>("Event",exists);

            }
        }

        #endregion Fields

        private List<string> _collections = new List<string>
        {
            nameof(Teams), nameof(TeamsCount), nameof(Updates), nameof(UpdatesCount), nameof(Users), nameof(UsersCount)
        };
        private List<string> collections { get { return _collections; } }


        public object Clone() => this.Copy<Event>();

    }
    

    public partial class EventSearchBase : Search<Event>
    {
        public int? Id { get; set; }
        public Reference AuditRecord { get; set; }
        public List<int> AuditRecordIds { get; set; }
        public string Description { get; set; }
        public DateTime? Processed { get; set; }
        public DateTime? ProcessedAfter { get; set; }
        public DateTime? ProcessedBefore { get; set; }
        public string Status { get; set; }
        public List<int> TeamsIds { get; set; }
        public List<int> UpdatesIds { get; set; }
        public List<int> UsersIds { get; set; }
    }


    [Route("/event", "GET")]
    [Route("/event/version", "GET, POST")]
    [Route("/event/search", "GET, POST, DELETE")]

    public partial class EventSearch : EventSearchBase
    {
    }

    public class EventFullTextSearch
    {
        public EventFullTextSearch() {}
        private EventSearch _request;
        public EventFullTextSearch(EventSearch request) => _request = request;

        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Event.Created))); }
        public bool doUpdated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Event.Updated))); }

        public bool doAuditRecord { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Event.AuditRecord))); }
        public bool doDescription { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Event.Description))); }
        public bool doProcessed { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Event.Processed))); }
        public bool doStatus { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Event.Status))); }
        public bool doTeams { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Event.Teams))); }
        public bool doUpdates { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Event.Updates))); }
        public bool doUsers { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Event.Users))); }
    }


    public partial class EventBatch : List<Event> { }


    [Route("/event/{Id}/{Junction}/version", "GET, POST")]
    [Route("/event/{Id}/{Junction}", "GET, POST, DELETE")]
    public class EventJunction : EventSearchBase {}



}
