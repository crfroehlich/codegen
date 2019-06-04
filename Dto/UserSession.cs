
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
    public abstract partial class UserSessionBase : Dto<UserSession>
    {
        public UserSessionBase() {}

        public UserSessionBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public UserSessionBase(int? id) : this(DocConvert.ToInt(id)) {}

        public UserSessionBase(int? pId, string pClientId, int? pHits, List<Reference> pImpersonations, int? pImpersonationsCount, string pIpAddress, List<Reference> pRequests, int? pRequestsCount, string pSessionId, string pTemporarySessionId, Reference pUser, int? pUserId, List<Reference> pUserHistory, int? pUserHistoryCount) : this(DocConvert.ToInt(pId)) 
        {
            ClientId = pClientId;
            Hits = pHits;
            Impersonations = pImpersonations;
            ImpersonationsCount = pImpersonationsCount;
            IpAddress = pIpAddress;
            Requests = pRequests;
            RequestsCount = pRequestsCount;
            SessionId = pSessionId;
            TemporarySessionId = pTemporarySessionId;
            User = pUser;
            UserId = pUserId;
            UserHistory = pUserHistory;
            UserHistoryCount = pUserHistoryCount;
        }

        [ApiMember(Name = nameof(ClientId), Description = "string", IsRequired = false)]
        public string ClientId { get; set; }


        [ApiMember(Name = nameof(Hits), Description = "int?", IsRequired = false)]
        public int? Hits { get; set; }


        [ApiMember(Name = nameof(Impersonations), Description = "Impersonation", IsRequired = false)]
        public List<Reference> Impersonations { get; set; }
        public List<int> ImpersonationsIds { get; set; }
        public int? ImpersonationsCount { get; set; }


        [ApiMember(Name = nameof(IpAddress), Description = "string", IsRequired = false)]
        public string IpAddress { get; set; }


        [ApiMember(Name = nameof(Requests), Description = "UserRequest", IsRequired = false)]
        public List<Reference> Requests { get; set; }
        public List<int> RequestsIds { get; set; }
        public int? RequestsCount { get; set; }


        [ApiMember(Name = nameof(SessionId), Description = "string", IsRequired = false)]
        public string SessionId { get; set; }


        [ApiMember(Name = nameof(TemporarySessionId), Description = "string", IsRequired = false)]
        public string TemporarySessionId { get; set; }


        [ApiMember(Name = nameof(User), Description = "User", IsRequired = true)]
        public Reference User { get; set; }
        [ApiMember(Name = nameof(UserId), Description = "Primary Key of User", IsRequired = false)]
        public int? UserId { get; set; }


        [ApiMember(Name = nameof(UserHistory), Description = "History", IsRequired = false)]
        public List<Reference> UserHistory { get; set; }
        public List<int> UserHistoryIds { get; set; }
        public int? UserHistoryCount { get; set; }



        public void Deconstruct(out string pClientId, out int? pHits, out List<Reference> pImpersonations, out int? pImpersonationsCount, out string pIpAddress, out List<Reference> pRequests, out int? pRequestsCount, out string pSessionId, out string pTemporarySessionId, out Reference pUser, out int? pUserId, out List<Reference> pUserHistory, out int? pUserHistoryCount)
        {
            pClientId = ClientId;
            pHits = Hits;
            pImpersonations = Impersonations;
            pImpersonationsCount = ImpersonationsCount;
            pIpAddress = IpAddress;
            pRequests = Requests;
            pRequestsCount = RequestsCount;
            pSessionId = SessionId;
            pTemporarySessionId = TemporarySessionId;
            pUser = User;
            pUserId = UserId;
            pUserHistory = UserHistory;
            pUserHistoryCount = UserHistoryCount;
        }

        //Not ready until C# v8.?
        //public UserSessionBase With(int? pId = Id, string pClientId = ClientId, int? pHits = Hits, List<Reference> pImpersonations = Impersonations, int? pImpersonationsCount = ImpersonationsCount, string pIpAddress = IpAddress, List<Reference> pRequests = Requests, int? pRequestsCount = RequestsCount, string pSessionId = SessionId, string pTemporarySessionId = TemporarySessionId, Reference pUser = User, int? pUserId = UserId, List<Reference> pUserHistory = UserHistory, int? pUserHistoryCount = UserHistoryCount) => 
        //	new UserSessionBase(pId, pClientId, pHits, pImpersonations, pImpersonationsCount, pIpAddress, pRequests, pRequestsCount, pSessionId, pTemporarySessionId, pUser, pUserId, pUserHistory, pUserHistoryCount);

    }


    [Route("/usersession/{Id}", "GET")]

    public partial class UserSession : UserSessionBase, IReturn<UserSession>, IDto, ICloneable
    {
        public UserSession()
        {
            _Constructor();
        }

        public UserSession(int? id) : base(DocConvert.ToInt(id)) {}
        public UserSession(int id) : base(id) {}
        public UserSession(int? pId, string pClientId, int? pHits, List<Reference> pImpersonations, int? pImpersonationsCount, string pIpAddress, List<Reference> pRequests, int? pRequestsCount, string pSessionId, string pTemporarySessionId, Reference pUser, int? pUserId, List<Reference> pUserHistory, int? pUserHistoryCount) : 
            base(pId, pClientId, pHits, pImpersonations, pImpersonationsCount, pIpAddress, pRequests, pRequestsCount, pSessionId, pTemporarySessionId, pUser, pUserId, pUserHistory, pUserHistoryCount) { }
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

        public static List<string> Fields => DocTools.Fields<UserSession>();

        private List<string> _Select;
        [ApiMember(Name = nameof(Select), Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(ClientId),nameof(Created),nameof(CreatorId),nameof(Gestalt),nameof(Hits),nameof(Impersonations),nameof(ImpersonationsCount),nameof(IpAddress),nameof(Locked),nameof(Requests),nameof(RequestsCount),nameof(SessionId),nameof(TemporarySessionId),nameof(Updated),nameof(User),nameof(UserHistory),nameof(UserHistoryCount),nameof(UserId),nameof(VersionNo)})]
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
                _Select = DocPermissionFactory.SetSelect<UserSession>("UserSession",exists);

            }
        }

        [Obsolete, ApiMember(Name = nameof(VisibleFields), Description = "Deprecated. Use Select instead.", AllowMultiple = true)]
        public override List<string> VisibleFields { get => Select; set => Select = value; }

        #endregion Fields

        private List<string> _collections = new List<string>
        {
            nameof(Impersonations), nameof(ImpersonationsCount), nameof(Requests), nameof(RequestsCount), nameof(UserHistory), nameof(UserHistoryCount)
        };
        private List<string> collections { get { return _collections; } }


        public object Clone() => this.Copy<UserSession>();

    }
    

    public partial class UserSessionSearchBase : Search<UserSession>
    {
        public int? Id { get; set; }
        public string ClientId { get; set; }
        public int? Hits { get; set; }
        public List<int> ImpersonationsIds { get; set; }
        public string IpAddress { get; set; }
        public List<int> RequestsIds { get; set; }
        public string SessionId { get; set; }
        public string TemporarySessionId { get; set; }
        public Reference User { get; set; }
        public List<int> UserIds { get; set; }
        public List<int> UserHistoryIds { get; set; }
    }


    [Route("/usersession", "GET")]
    [Route("/usersession/version", "GET, POST")]
    [Route("/usersession/search", "GET, POST, DELETE")]

    public partial class UserSessionSearch : UserSessionSearchBase
    {
    }

    public class UserSessionFullTextSearch
    {
        public UserSessionFullTextSearch() {}
        private UserSessionSearch _request;
        public UserSessionFullTextSearch(UserSessionSearch request) => _request = request;

        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(UserSession.Created))); }
        public bool doUpdated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(UserSession.Updated))); }

        public bool doClientId { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(UserSession.ClientId))); }
        public bool doHits { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(UserSession.Hits))); }
        public bool doImpersonations { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(UserSession.Impersonations))); }
        public bool doIpAddress { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(UserSession.IpAddress))); }
        public bool doRequests { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(UserSession.Requests))); }
        public bool doSessionId { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(UserSession.SessionId))); }
        public bool doTemporarySessionId { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(UserSession.TemporarySessionId))); }
        public bool doUser { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(UserSession.User))); }
        public bool doUserHistory { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(UserSession.UserHistory))); }
    }


    public partial class UserSessionBatch : List<UserSession> { }


    [Route("/usersession/{Id}/{Junction}/version", "GET, POST")]
    [Route("/usersession/{Id}/{Junction}", "GET, POST, DELETE")]
    public class UserSessionJunction : UserSessionSearchBase {}



}
