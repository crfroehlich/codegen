
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
    public abstract partial class CommentBase : Dto<Comment>
    {
        public CommentBase() {}

        public CommentBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public CommentBase(int? id) : this(DocConvert.ToInt(id)) {}

        public CommentBase(int? pId, List<Reference> pScopes, int? pScopesCount, string pText, Reference pUser, int? pUserId) : this(DocConvert.ToInt(pId)) 
        {
            Scopes = pScopes;
            ScopesCount = pScopesCount;
            Text = pText;
            User = pUser;
            UserId = pUserId;
        }

        [ApiMember(Name = nameof(Scopes), Description = "Scope", IsRequired = false)]
        public List<Reference> Scopes { get; set; }
        public List<int> ScopesIds { get; set; }
        public int? ScopesCount { get; set; }


        [ApiMember(Name = nameof(Text), Description = "string", IsRequired = false)]
        public string Text { get; set; }
        public List<int> TextIds { get; set; }
        public int? TextCount { get; set; }


        [ApiMember(Name = nameof(User), Description = "User", IsRequired = true)]
        public Reference User { get; set; }
        [ApiMember(Name = nameof(UserId), Description = "Primary Key of User", IsRequired = false)]
        public int? UserId { get; set; }



        public void Deconstruct(out List<Reference> pScopes, out int? pScopesCount, out string pText, out Reference pUser, out int? pUserId)
        {
            pScopes = Scopes;
            pScopesCount = ScopesCount;
            pText = Text;
            pUser = User;
            pUserId = UserId;
        }

        //Not ready until C# v8.?
        //public CommentBase With(int? pId = Id, List<Reference> pScopes = Scopes, int? pScopesCount = ScopesCount, string pText = Text, Reference pUser = User, int? pUserId = UserId) => 
        //	new CommentBase(pId, pScopes, pScopesCount, pText, pUser, pUserId);

    }


    [Route("/comment", "POST")]
    [Route("/comment/{Id}", "GET, PATCH, PUT, DELETE")]

    public partial class Comment : CommentBase, IReturn<Comment>, IDto, ICloneable
    {
        public Comment() => _Constructor();

        public Comment(int? id) : base(DocConvert.ToInt(id)) {}
        public Comment(int id) : base(id) {}
        public Comment(int? pId, List<Reference> pScopes, int? pScopesCount, string pText, Reference pUser, int? pUserId) :
            base(pId, pScopes, pScopesCount, pText, pUser, pUserId) { }

        public static List<string> Fields => DocTools.Fields<Comment>();

        private List<string> _Select;
        [ApiMember(Name = nameof(Select), Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Created),nameof(CreatorId),nameof(Gestalt),nameof(Locked),nameof(Scopes),nameof(ScopesCount),nameof(Text),nameof(Updated),nameof(User),nameof(UserId),nameof(VersionNo)})]
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
                _Select = DocPermissionFactory.SetSelect<Comment>("Comment",exists);

            }
        }

        [Obsolete, ApiMember(Name = nameof(VisibleFields), Description = "Deprecated. Use Select instead.", AllowMultiple = true)]
        public override List<string> VisibleFields { get => Select; set => Select = value; }


        private List<string> _collections = new List<string>
        {
            nameof(Scopes), nameof(ScopesCount), nameof(ScopesIds)
        };
        private List<string> collections { get { return _collections; } }


        public object Clone() => this.Copy<Comment>();

    }
    

    [Route("/comment/{Id}/copy", "POST")]
    public partial class CommentCopy : Comment {}

    public partial class CommentSearchBase : Search<Comment>
    {
        public int? Id { get; set; }
        public List<int> ScopesIds { get; set; }
        public string Text { get; set; }
        public List<string> Texts { get; set; }
        public Reference User { get; set; }
        public List<int> UserIds { get; set; }
    }


    [Route("/comment", "GET")]
    [Route("/comment/version", "GET, POST")]
    [Route("/comment/search", "GET, POST, DELETE")]

    public partial class CommentSearch : CommentSearchBase
    {
    }

    public class CommentFullTextSearch
    {
        public CommentFullTextSearch() {}
        private CommentSearch _request;
        public CommentFullTextSearch(CommentSearch request) => _request = request;

        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Comment.Created))); }
        public bool doUpdated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Comment.Updated))); }

        public bool doScopes { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Comment.Scopes))); }
        public bool doText { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Comment.Text))); }
        public bool doUser { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Comment.User))); }
    }


    [Route("/comment/batch", "DELETE, PATCH, POST, PUT")]

    public partial class CommentBatch : List<Comment> { }


    [Route("/comment/{Id}/{Junction}/version", "GET, POST")]
    [Route("/comment/{Id}/{Junction}", "GET, POST, DELETE")]
    public class CommentJunction : CommentSearchBase {}



}
