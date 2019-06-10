
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
    public abstract partial class UpdateBase : Dto<Update>
    {
        public UpdateBase() {}

        public UpdateBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public UpdateBase(int? id) : this(DocConvert.ToInt(id)) {}

        public UpdateBase(int? pId, string pBody, string pDeliveryStatus, int? pEmailAttempts, DateTime? pEmailSent, List<Reference> pEvents, int? pEventsCount, string pLink, int? pPriority, DateTime? pRead, DateTime? pSlackSent, string pSubject, Reference pTeam, int? pTeamId, Reference pUser, int? pUserId) : this(DocConvert.ToInt(pId)) 
        {
            Body = pBody;
            DeliveryStatus = pDeliveryStatus;
            EmailAttempts = pEmailAttempts;
            EmailSent = pEmailSent;
            Events = pEvents;
            EventsCount = pEventsCount;
            Link = pLink;
            Priority = pPriority;
            Read = pRead;
            SlackSent = pSlackSent;
            Subject = pSubject;
            Team = pTeam;
            TeamId = pTeamId;
            User = pUser;
            UserId = pUserId;
        }

        [ApiMember(Name = nameof(Body), Description = "string", IsRequired = false)]
        public string Body { get; set; }
        public List<int> BodyIds { get; set; }
        public int? BodyCount { get; set; }


        [ApiMember(Name = nameof(DeliveryStatus), Description = "string", IsRequired = false)]
        public string DeliveryStatus { get; set; }
        public List<int> DeliveryStatusIds { get; set; }
        public int? DeliveryStatusCount { get; set; }


        [ApiMember(Name = nameof(EmailAttempts), Description = "int?", IsRequired = false)]
        public int? EmailAttempts { get; set; }
        public List<int> EmailAttemptsIds { get; set; }
        public int? EmailAttemptsCount { get; set; }


        [ApiMember(Name = nameof(EmailSent), Description = "DateTime?", IsRequired = false)]
        public DateTime? EmailSent { get; set; }
        public List<int> EmailSentIds { get; set; }
        public int? EmailSentCount { get; set; }


        [ApiMember(Name = nameof(Events), Description = "Event", IsRequired = false)]
        public List<Reference> Events { get; set; }
        public List<int> EventsIds { get; set; }
        public int? EventsCount { get; set; }


        [ApiMember(Name = nameof(Link), Description = "string", IsRequired = false)]
        public string Link { get; set; }
        public List<int> LinkIds { get; set; }
        public int? LinkCount { get; set; }


        [ApiMember(Name = nameof(Priority), Description = "int?", IsRequired = false)]
        public int? Priority { get; set; }
        public List<int> PriorityIds { get; set; }
        public int? PriorityCount { get; set; }


        [ApiMember(Name = nameof(Read), Description = "DateTime?", IsRequired = false)]
        public DateTime? Read { get; set; }
        public List<int> ReadIds { get; set; }
        public int? ReadCount { get; set; }


        [ApiMember(Name = nameof(SlackSent), Description = "DateTime?", IsRequired = false)]
        public DateTime? SlackSent { get; set; }
        public List<int> SlackSentIds { get; set; }
        public int? SlackSentCount { get; set; }


        [ApiMember(Name = nameof(Subject), Description = "string", IsRequired = false)]
        public string Subject { get; set; }
        public List<int> SubjectIds { get; set; }
        public int? SubjectCount { get; set; }


        [ApiMember(Name = nameof(Team), Description = "Team", IsRequired = false)]
        public Reference Team { get; set; }
        [ApiMember(Name = nameof(TeamId), Description = "Primary Key of Team", IsRequired = false)]
        public int? TeamId { get; set; }


        [ApiMember(Name = nameof(User), Description = "User", IsRequired = false)]
        public Reference User { get; set; }
        [ApiMember(Name = nameof(UserId), Description = "Primary Key of User", IsRequired = false)]
        public int? UserId { get; set; }



        public void Deconstruct(out string pBody, out string pDeliveryStatus, out int? pEmailAttempts, out DateTime? pEmailSent, out List<Reference> pEvents, out int? pEventsCount, out string pLink, out int? pPriority, out DateTime? pRead, out DateTime? pSlackSent, out string pSubject, out Reference pTeam, out int? pTeamId, out Reference pUser, out int? pUserId)
        {
            pBody = Body;
            pDeliveryStatus = DeliveryStatus;
            pEmailAttempts = EmailAttempts;
            pEmailSent = EmailSent;
            pEvents = Events;
            pEventsCount = EventsCount;
            pLink = Link;
            pPriority = Priority;
            pRead = Read;
            pSlackSent = SlackSent;
            pSubject = Subject;
            pTeam = Team;
            pTeamId = TeamId;
            pUser = User;
            pUserId = UserId;
        }

        //Not ready until C# v8.?
        //public UpdateBase With(int? pId = Id, string pBody = Body, string pDeliveryStatus = DeliveryStatus, int? pEmailAttempts = EmailAttempts, DateTime? pEmailSent = EmailSent, List<Reference> pEvents = Events, int? pEventsCount = EventsCount, string pLink = Link, int? pPriority = Priority, DateTime? pRead = Read, DateTime? pSlackSent = SlackSent, string pSubject = Subject, Reference pTeam = Team, int? pTeamId = TeamId, Reference pUser = User, int? pUserId = UserId) => 
        //	new UpdateBase(pId, pBody, pDeliveryStatus, pEmailAttempts, pEmailSent, pEvents, pEventsCount, pLink, pPriority, pRead, pSlackSent, pSubject, pTeam, pTeamId, pUser, pUserId);

    }


    [Route("/update", "POST")]
    [Route("/update/{Id}", "GET")]

    public partial class Update : UpdateBase, IReturn<Update>, IDto, ICloneable
    {
        public Update() => _Constructor();

        public Update(int? id) : base(DocConvert.ToInt(id)) {}
        public Update(int id) : base(id) {}
        public Update(int? pId, string pBody, string pDeliveryStatus, int? pEmailAttempts, DateTime? pEmailSent, List<Reference> pEvents, int? pEventsCount, string pLink, int? pPriority, DateTime? pRead, DateTime? pSlackSent, string pSubject, Reference pTeam, int? pTeamId, Reference pUser, int? pUserId) :
            base(pId, pBody, pDeliveryStatus, pEmailAttempts, pEmailSent, pEvents, pEventsCount, pLink, pPriority, pRead, pSlackSent, pSubject, pTeam, pTeamId, pUser, pUserId) { }

        public static List<string> Fields => DocTools.Fields<Update>();

        private List<string> _Select;
        [ApiMember(Name = nameof(Select), Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Body),nameof(Created),nameof(CreatorId),nameof(DeliveryStatus),nameof(EmailAttempts),nameof(EmailSent),nameof(Events),nameof(EventsCount),nameof(Gestalt),nameof(Link),nameof(Locked),nameof(Priority),nameof(Read),nameof(SlackSent),nameof(Subject),nameof(Team),nameof(TeamId),nameof(Updated),nameof(User),nameof(UserId),nameof(VersionNo)})]
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
                _Select = DocPermissionFactory.SetSelect<Update>("Update",exists);

            }
        }

        [Obsolete, ApiMember(Name = nameof(VisibleFields), Description = "Deprecated. Use Select instead.", AllowMultiple = true)]
        public override List<string> VisibleFields { get => Select; set => Select = value; }


        private List<string> _collections = new List<string>
        {
            nameof(Events), nameof(EventsCount), nameof(EventsIds)
        };
        private List<string> collections { get { return _collections; } }


        public object Clone() => this.Copy<Update>();

    }
    

    [Route("/update/{Id}/copy", "POST")]
    public partial class UpdateCopy : Update {}

    public partial class UpdateSearchBase : Search<Update>
    {
        public int? Id { get; set; }
        public string Body { get; set; }
        public List<string> Bodys { get; set; }
        public string DeliveryStatus { get; set; }
        public List<string> DeliveryStatuss { get; set; }
        public int? EmailAttempts { get; set; }
        public DateTime? EmailSent { get; set; }
        public DateTime? EmailSentAfter { get; set; }
        public DateTime? EmailSentBefore { get; set; }
        public List<int> EventsIds { get; set; }
        public string Link { get; set; }
        public List<string> Links { get; set; }
        public int? Priority { get; set; }
        public DateTime? Read { get; set; }
        public DateTime? ReadAfter { get; set; }
        public DateTime? ReadBefore { get; set; }
        public DateTime? SlackSent { get; set; }
        public DateTime? SlackSentAfter { get; set; }
        public DateTime? SlackSentBefore { get; set; }
        public string Subject { get; set; }
        public List<string> Subjects { get; set; }
        public Reference Team { get; set; }
        public List<int> TeamIds { get; set; }
        public Reference User { get; set; }
        public List<int> UserIds { get; set; }
    }


    [Route("/update", "GET")]
    [Route("/update/version", "GET, POST")]
    [Route("/update/search", "GET, POST, DELETE")]

    public partial class UpdateSearch : UpdateSearchBase
    {
    }

    public class UpdateFullTextSearch
    {
        public UpdateFullTextSearch() {}
        private UpdateSearch _request;
        public UpdateFullTextSearch(UpdateSearch request) => _request = request;

        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Update.Created))); }
        public bool doUpdated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Update.Updated))); }

        public bool doBody { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Update.Body))); }
        public bool doDeliveryStatus { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Update.DeliveryStatus))); }
        public bool doEmailAttempts { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Update.EmailAttempts))); }
        public bool doEmailSent { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Update.EmailSent))); }
        public bool doEvents { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Update.Events))); }
        public bool doLink { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Update.Link))); }
        public bool doPriority { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Update.Priority))); }
        public bool doRead { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Update.Read))); }
        public bool doSlackSent { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Update.SlackSent))); }
        public bool doSubject { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Update.Subject))); }
        public bool doTeam { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Update.Team))); }
        public bool doUser { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Update.User))); }
    }


    [Route("/update/batch", "DELETE, PATCH, POST, PUT")]

    public partial class UpdateBatch : List<Update> { }


    [Route("/update/{Id}/{Junction}/version", "GET, POST")]
    [Route("/update/{Id}/{Junction}", "GET, POST, DELETE")]
    public class UpdateJunction : UpdateSearchBase {}



}
