
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
    public abstract partial class UserRequestBase : Dto<UserRequest>
    {
        public UserRequestBase() {}

        public UserRequestBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public UserRequestBase(int? id) : this(DocConvert.ToInt(id)) {}

        public UserRequestBase(int? pId, Reference pApp, int? pAppId, string pMethod, Reference pPage, int? pPageId, string pPath, string pURL, Reference pUserSession, int? pUserSessionId) : this(DocConvert.ToInt(pId)) 
        {
            App = pApp;
            AppId = pAppId;
            Method = pMethod;
            Page = pPage;
            PageId = pPageId;
            Path = pPath;
            URL = pURL;
            UserSession = pUserSession;
            UserSessionId = pUserSessionId;
        }

        [ApiMember(Name = nameof(App), Description = "App", IsRequired = false)]
        public Reference App { get; set; }
        [ApiMember(Name = nameof(AppId), Description = "Primary Key of App", IsRequired = false)]
        public int? AppId { get; set; }


        [ApiMember(Name = nameof(Method), Description = "string", IsRequired = false)]
        public string Method { get; set; }
        public List<int> MethodIds { get; set; }
        public int? MethodCount { get; set; }


        [ApiMember(Name = nameof(Page), Description = "Page", IsRequired = false)]
        public Reference Page { get; set; }
        [ApiMember(Name = nameof(PageId), Description = "Primary Key of Page", IsRequired = false)]
        public int? PageId { get; set; }


        [ApiMember(Name = nameof(Path), Description = "string", IsRequired = false)]
        public string Path { get; set; }
        public List<int> PathIds { get; set; }
        public int? PathCount { get; set; }


        [ApiMember(Name = nameof(URL), Description = "string", IsRequired = false)]
        public string URL { get; set; }
        public List<int> URLIds { get; set; }
        public int? URLCount { get; set; }


        [ApiMember(Name = nameof(UserSession), Description = "UserSession", IsRequired = true)]
        public Reference UserSession { get; set; }
        [ApiMember(Name = nameof(UserSessionId), Description = "Primary Key of UserSession", IsRequired = false)]
        public int? UserSessionId { get; set; }



        public void Deconstruct(out Reference pApp, out int? pAppId, out string pMethod, out Reference pPage, out int? pPageId, out string pPath, out string pURL, out Reference pUserSession, out int? pUserSessionId)
        {
            pApp = App;
            pAppId = AppId;
            pMethod = Method;
            pPage = Page;
            pPageId = PageId;
            pPath = Path;
            pURL = URL;
            pUserSession = UserSession;
            pUserSessionId = UserSessionId;
        }

        //Not ready until C# v8.?
        //public UserRequestBase With(int? pId = Id, Reference pApp = App, int? pAppId = AppId, string pMethod = Method, Reference pPage = Page, int? pPageId = PageId, string pPath = Path, string pURL = URL, Reference pUserSession = UserSession, int? pUserSessionId = UserSessionId) => 
        //	new UserRequestBase(pId, pApp, pAppId, pMethod, pPage, pPageId, pPath, pURL, pUserSession, pUserSessionId);

    }


    [Route("/userrequest/{Id}", "GET")]

    public partial class UserRequest : UserRequestBase, IReturn<UserRequest>, IDto, ICloneable
    {
        public UserRequest() => _Constructor();

        public UserRequest(int? id) : base(DocConvert.ToInt(id)) {}
        public UserRequest(int id) : base(id) {}
        public UserRequest(int? pId, Reference pApp, int? pAppId, string pMethod, Reference pPage, int? pPageId, string pPath, string pURL, Reference pUserSession, int? pUserSessionId) :
            base(pId, pApp, pAppId, pMethod, pPage, pPageId, pPath, pURL, pUserSession, pUserSessionId) { }

        public static List<string> Fields => DocTools.Fields<UserRequest>();

        private List<string> _Select;
        [ApiMember(Name = nameof(Select), Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(App),nameof(AppId),nameof(Created),nameof(CreatorId),nameof(Gestalt),nameof(Locked),nameof(Method),nameof(Page),nameof(PageId),nameof(Path),nameof(Updated),nameof(URL),nameof(UserSession),nameof(UserSessionId),nameof(VersionNo)})]
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
                _Select = DocPermissionFactory.SetSelect<UserRequest>("UserRequest",exists);

            }
        }

        [Obsolete, ApiMember(Name = nameof(VisibleFields), Description = "Deprecated. Use Select instead.", AllowMultiple = true)]
        public override List<string> VisibleFields { get => Select; set => Select = value; }



        public object Clone() => this.Copy<UserRequest>();

    }
    

    public partial class UserRequestSearchBase : Search<UserRequest>
    {
        public int? Id { get; set; }
        public Reference App { get; set; }
        public List<int> AppIds { get; set; }
        public string Method { get; set; }
        public List<string> Methods { get; set; }
        public Reference Page { get; set; }
        public List<int> PageIds { get; set; }
        public string Path { get; set; }
        public List<string> Paths { get; set; }
        public string URL { get; set; }
        public List<string> URLs { get; set; }
        public Reference UserSession { get; set; }
        public List<int> UserSessionIds { get; set; }
    }


    [Route("/userrequest", "GET")]
    [Route("/userrequest/version", "GET, POST")]
    [Route("/userrequest/search", "GET, POST, DELETE")]

    public partial class UserRequestSearch : UserRequestSearchBase
    {
    }

    public class UserRequestFullTextSearch
    {
        public UserRequestFullTextSearch() {}
        private UserRequestSearch _request;
        public UserRequestFullTextSearch(UserRequestSearch request) => _request = request;

        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(UserRequest.Created))); }
        public bool doUpdated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(UserRequest.Updated))); }

        public bool doApp { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(UserRequest.App))); }
        public bool doMethod { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(UserRequest.Method))); }
        public bool doPage { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(UserRequest.Page))); }
        public bool doPath { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(UserRequest.Path))); }
        public bool doURL { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(UserRequest.URL))); }
        public bool doUserSession { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(UserRequest.UserSession))); }
    }


    public partial class UserRequestBatch : List<UserRequest> { }


}
