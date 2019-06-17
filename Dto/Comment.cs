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
    public abstract partial class CommentBase : Dto<Comment>
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public CommentBase() {}

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public CommentBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public CommentBase(int? id) : this(DocConvert.ToInt(id)) {}

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public CommentBase(int? pId, List<Reference> pScopes, int? pScopesCount, string pText, Reference pUser, int? pUserId) : this(DocConvert.ToInt(pId)) 
        {
            Scopes = pScopes;
            ScopesCount = pScopesCount;
            Text = pText;
            User = pUser;
            UserId = pUserId;
        }

        [ApiMember(Name = nameof(Scopes), Description = "Scope", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<Reference> Scopes { get; set; }
        [ApiMember(Name = nameof(ScopesIds), Description = "Scope Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> ScopesIds { get; set; }
        [ApiMember(Name = nameof(ScopesCount), Description = "Scope Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? ScopesCount { get; set; }


        [ApiMember(Name = nameof(Text), Description = "string", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string Text { get; set; }
        [ApiMember(Name = nameof(TextIds), Description = "Text Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> TextIds { get; set; }
        [ApiMember(Name = nameof(TextCount), Description = "Text Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? TextCount { get; set; }


        [ApiMember(Name = nameof(User), Description = "User", IsRequired = true)]
[GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Reference User { get; set; }
        [ApiMember(Name = nameof(UserId), Description = "Primary Key of User", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? UserId { get; set; }



        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public void Deconstruct(out List<Reference> pScopes, out int? pScopesCount, out string pText, out Reference pUser, out int? pUserId)
        {
            pScopes = Scopes;
            pScopesCount = ScopesCount;
            pText = Text;
            pUser = User;
            pUserId = UserId;
        }

        //Not ready until C# v8.?
        //[GeneratedCodeAttribute("T4", "1.0.0.0")]
        //public CommentBase With(int? pId = Id, List<Reference> pScopes = Scopes, int? pScopesCount = ScopesCount, string pText = Text, Reference pUser = User, int? pUserId = UserId) => 
        //	new CommentBase(pId, pScopes, pScopesCount, pText, pUser, pUserId);

    }


    [Route("/comment", "POST")]
    [Route("/comment/{Id}", "GET, PATCH, PUT, DELETE")]

    public partial class Comment : CommentBase, IReturn<Comment>, IDto, ICloneable
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Comment() => _Constructor();
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Comment(int? id) : base(DocConvert.ToInt(id)) {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Comment(int id) : base(id) {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Comment(int? pId, List<Reference> pScopes, int? pScopesCount, string pText, Reference pUser, int? pUserId) :
            base(pId, pScopes, pScopesCount, pText, pUser, pUserId) { }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static List<string> Fields => DocTools.Fields<Comment>();

        private List<string> _Select;
        [ApiMember(Name = nameof(Select), Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Created),nameof(CreatorId),nameof(Gestalt),nameof(Locked),nameof(Scopes),nameof(ScopesCount),nameof(Text),nameof(Updated),nameof(User),nameof(UserId),nameof(VersionNo)})]
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
                _Select = DocPermissionFactory.SetSelect<Comment>("Comment",exists);

            }
        }

        [Obsolete, ApiMember(Name = "VisibleFields", Description = "Deprecated. Use Select instead.", AllowMultiple = true)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override List<string> VisibleFields { get => Select; set => Select = value; }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private List<string> _collections = new List<string>
        {
            nameof(Scopes), nameof(ScopesCount), nameof(ScopesIds)
        };
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private List<string> collections { get { return _collections; } }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Clone() => this.Copy<Comment>();

    }
    

    [Route("/comment/{Id}/copy", "POST")]
    public partial class CommentCopy : Comment {}

    public partial class CommentSearchBase : Search<Comment>
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
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
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public CommentFullTextSearch() {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private CommentSearch _request;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public CommentFullTextSearch(CommentSearch request) => _request = request;
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
        public bool doCreated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Comment.Created))); }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
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
