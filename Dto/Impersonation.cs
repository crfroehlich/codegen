//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated by a T4 template. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.CodeDom.Compiler;
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
    public abstract partial class ImpersonationBase : Dto<Impersonation>
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public ImpersonationBase() {}

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public ImpersonationBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public ImpersonationBase(int? id) : this(DocConvert.ToInt(id)) {}

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public ImpersonationBase(int? pId, Reference pAuthenticatedUser, int? pAuthenticatedUserId, Reference pImpersonatedUser, int? pImpersonatedUserId, Reference pUserSession, int? pUserSessionId) : this(DocConvert.ToInt(pId)) 
        {
            AuthenticatedUser = pAuthenticatedUser;
            AuthenticatedUserId = pAuthenticatedUserId;
            ImpersonatedUser = pImpersonatedUser;
            ImpersonatedUserId = pImpersonatedUserId;
            UserSession = pUserSession;
            UserSessionId = pUserSessionId;
        }

        [ApiMember(Name = nameof(AuthenticatedUser), Description = "User", IsRequired = true)]
[GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Reference AuthenticatedUser { get; set; }
        [ApiMember(Name = nameof(AuthenticatedUserId), Description = "Primary Key of User", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? AuthenticatedUserId { get; set; }


        [ApiMember(Name = nameof(ImpersonatedUser), Description = "User", IsRequired = true)]
[GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Reference ImpersonatedUser { get; set; }
        [ApiMember(Name = nameof(ImpersonatedUserId), Description = "Primary Key of User", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? ImpersonatedUserId { get; set; }


        [ApiMember(Name = nameof(UserSession), Description = "UserSession", IsRequired = false)]
[GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Reference UserSession { get; set; }
        [ApiMember(Name = nameof(UserSessionId), Description = "Primary Key of UserSession", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? UserSessionId { get; set; }



        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public void Deconstruct(out Reference pAuthenticatedUser, out int? pAuthenticatedUserId, out Reference pImpersonatedUser, out int? pImpersonatedUserId, out Reference pUserSession, out int? pUserSessionId)
        {
            pAuthenticatedUser = AuthenticatedUser;
            pAuthenticatedUserId = AuthenticatedUserId;
            pImpersonatedUser = ImpersonatedUser;
            pImpersonatedUserId = ImpersonatedUserId;
            pUserSession = UserSession;
            pUserSessionId = UserSessionId;
        }

        //Not ready until C# v8.?
        //[GeneratedCodeAttribute("T4", "1.0.0.0")]
        //public ImpersonationBase With(int? pId = Id, Reference pAuthenticatedUser = AuthenticatedUser, int? pAuthenticatedUserId = AuthenticatedUserId, Reference pImpersonatedUser = ImpersonatedUser, int? pImpersonatedUserId = ImpersonatedUserId, Reference pUserSession = UserSession, int? pUserSessionId = UserSessionId) => 
        //	new ImpersonationBase(pId, pAuthenticatedUser, pAuthenticatedUserId, pImpersonatedUser, pImpersonatedUserId, pUserSession, pUserSessionId);

    }


    [Route("/impersonation/{Id}", "GET")]

    public partial class Impersonation : ImpersonationBase, IReturn<Impersonation>, IDto, ICloneable
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Impersonation() => _Constructor();
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Impersonation(int? id) : base(DocConvert.ToInt(id)) {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Impersonation(int id) : base(id) {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Impersonation(int? pId, Reference pAuthenticatedUser, int? pAuthenticatedUserId, Reference pImpersonatedUser, int? pImpersonatedUserId, Reference pUserSession, int? pUserSessionId) :
            base(pId, pAuthenticatedUser, pAuthenticatedUserId, pImpersonatedUser, pImpersonatedUserId, pUserSession, pUserSessionId) { }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static List<string> Fields => DocTools.Fields<Impersonation>();

        private List<string> _Select;
        [ApiMember(Name = nameof(Select), Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(AuthenticatedUser),nameof(AuthenticatedUserId),nameof(Created),nameof(CreatorId),nameof(Gestalt),nameof(ImpersonatedUser),nameof(ImpersonatedUserId),nameof(Locked),nameof(Updated),nameof(UserSession),nameof(UserSessionId),nameof(VersionNo)})]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
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
                _Select = DocPermissionFactory.SetSelect<Impersonation>("Impersonation",exists);

            }
        }

        [Obsolete, ApiMember(Name = "VisibleFields", Description = "Deprecated. Use Select instead.", AllowMultiple = true)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override List<string> VisibleFields { get => Select; set => Select = value; }



        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Clone() => this.Copy<Impersonation>();

    }
    

    public partial class ImpersonationSearchBase : Search<Impersonation>
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? Id { get; set; }
        public Reference AuthenticatedUser { get; set; }
        public List<int> AuthenticatedUserIds { get; set; }
        public Reference ImpersonatedUser { get; set; }
        public List<int> ImpersonatedUserIds { get; set; }
        public Reference UserSession { get; set; }
        public List<int> UserSessionIds { get; set; }
    }


    [Route("/impersonation", "GET")]
    [Route("/impersonation/version", "GET, POST")]
    [Route("/impersonation/search", "GET, POST, DELETE")]

    public partial class ImpersonationSearch : ImpersonationSearchBase
    {
    }

    public class ImpersonationFullTextSearch
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public ImpersonationFullTextSearch() {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private ImpersonationSearch _request;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public ImpersonationFullTextSearch(ImpersonationSearch request) => _request = request;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool doCreated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Impersonation.Created))); }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool doUpdated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Impersonation.Updated))); }

        public bool doAuthenticatedUser { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Impersonation.AuthenticatedUser))); }
        public bool doImpersonatedUser { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Impersonation.ImpersonatedUser))); }
        public bool doUserSession { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Impersonation.UserSession))); }
    }


    public partial class ImpersonationBatch : List<Impersonation> { }


}
