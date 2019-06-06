
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
    public abstract partial class HelpBase : Dto<Help>
    {
        public HelpBase() {}

        public HelpBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public HelpBase(int? id) : this(DocConvert.ToInt(id)) {}

        public HelpBase(int? pId, string pConfluenceId, string pDescription, string pIcon, int? pOrder, List<Reference> pPages, int? pPagesCount, List<Reference> pScopes, int? pScopesCount, string pTitle, Reference pType, int? pTypeId) : this(DocConvert.ToInt(pId)) 
        {
            ConfluenceId = pConfluenceId;
            Description = pDescription;
            Icon = pIcon;
            Order = pOrder;
            Pages = pPages;
            PagesCount = pPagesCount;
            Scopes = pScopes;
            ScopesCount = pScopesCount;
            Title = pTitle;
            Type = pType;
            TypeId = pTypeId;
        }

        [ApiMember(Name = nameof(ConfluenceId), Description = "string", IsRequired = false)]
        public string ConfluenceId { get; set; }


        [ApiMember(Name = nameof(Description), Description = "string", IsRequired = false)]
        public string Description { get; set; }


        [ApiMember(Name = nameof(Icon), Description = "string", IsRequired = false)]
        public string Icon { get; set; }


        [ApiMember(Name = nameof(Order), Description = "int?", IsRequired = false)]
        public int? Order { get; set; }


        [ApiMember(Name = nameof(Pages), Description = "Page", IsRequired = false)]
        public List<Reference> Pages { get; set; }
        public List<int> PagesIds { get; set; }
        public int? PagesCount { get; set; }


        [ApiMember(Name = nameof(Scopes), Description = "Scope", IsRequired = false)]
        public List<Reference> Scopes { get; set; }
        public List<int> ScopesIds { get; set; }
        public int? ScopesCount { get; set; }


        [ApiMember(Name = nameof(Title), Description = "string", IsRequired = true)]
        public string Title { get; set; }


        [ApiAllowableValues("Includes", Values = new string[] {@"Dialog",@"Manual",@"Section",@"Sidebar"})]
        [ApiMember(Name = nameof(Type), Description = "LookupTable", IsRequired = false)]
        public Reference Type { get; set; }
        [ApiMember(Name = nameof(TypeId), Description = "Primary Key of LookupTable", IsRequired = false)]
        public int? TypeId { get; set; }



        public void Deconstruct(out string pConfluenceId, out string pDescription, out string pIcon, out int? pOrder, out List<Reference> pPages, out int? pPagesCount, out List<Reference> pScopes, out int? pScopesCount, out string pTitle, out Reference pType, out int? pTypeId)
        {
            pConfluenceId = ConfluenceId;
            pDescription = Description;
            pIcon = Icon;
            pOrder = Order;
            pPages = Pages;
            pPagesCount = PagesCount;
            pScopes = Scopes;
            pScopesCount = ScopesCount;
            pTitle = Title;
            pType = Type;
            pTypeId = TypeId;
        }

        //Not ready until C# v8.?
        //public HelpBase With(int? pId = Id, string pConfluenceId = ConfluenceId, string pDescription = Description, string pIcon = Icon, int? pOrder = Order, List<Reference> pPages = Pages, int? pPagesCount = PagesCount, List<Reference> pScopes = Scopes, int? pScopesCount = ScopesCount, string pTitle = Title, Reference pType = Type, int? pTypeId = TypeId) => 
        //	new HelpBase(pId, pConfluenceId, pDescription, pIcon, pOrder, pPages, pPagesCount, pScopes, pScopesCount, pTitle, pType, pTypeId);

    }


    [Route("/help", "POST")]
    [Route("/help/{Id}", "GET, PATCH, PUT, DELETE")]

    public partial class Help : HelpBase, IReturn<Help>, IDto, ICloneable
    {
        public Help()
        {
            _Constructor();
        }

        public Help(int? id) : base(DocConvert.ToInt(id)) {}
        public Help(int id) : base(id) {}
        public Help(int? pId, string pConfluenceId, string pDescription, string pIcon, int? pOrder, List<Reference> pPages, int? pPagesCount, List<Reference> pScopes, int? pScopesCount, string pTitle, Reference pType, int? pTypeId) : 
            base(pId, pConfluenceId, pDescription, pIcon, pOrder, pPages, pPagesCount, pScopes, pScopesCount, pTitle, pType, pTypeId) { }

        public new bool? ShouldSerialize(string field)
        {
            //Allow individual classes to specify their own logic
            var manualOverride = _ShouldSerialize(field);
            if(null != manualOverride) return manualOverride;

            if (IgnoredSelect.Matches(field, true)) return false;
            var ret = MandatorySelect.Matches(field, true) || true == Select?.Matches(field, true);
            return ret;
        }

        public static List<string> Fields => DocTools.Fields<Help>();

        private List<string> _Select;
        [ApiMember(Name = nameof(Select), Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(ConfluenceId),nameof(Created),nameof(CreatorId),nameof(Description),nameof(Gestalt),nameof(Icon),nameof(Locked),nameof(Order),nameof(Pages),nameof(PagesCount),nameof(Scopes),nameof(ScopesCount),nameof(Title),nameof(Type),nameof(TypeId),nameof(Updated),nameof(VersionNo)})]
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
                _Select = DocPermissionFactory.SetSelect<Help>("Help",exists);

            }
        }

        [Obsolete, ApiMember(Name = nameof(VisibleFields), Description = "Deprecated. Use Select instead.", AllowMultiple = true)]
        public override List<string> VisibleFields { get => Select; set => Select = value; }


        private List<string> _collections = new List<string>
        {
            nameof(Pages), nameof(PagesCount), nameof(Scopes), nameof(ScopesCount)
        };
        private List<string> collections { get { return _collections; } }


        public object Clone() => this.Copy<Help>();

    }
    

    [Route("/help/{Id}/copy", "POST")]
    public partial class HelpCopy : Help {}

    public partial class HelpSearchBase : Search<Help>
    {
        public int? Id { get; set; }
        public string ConfluenceId { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public int? Order { get; set; }
        public List<int> PagesIds { get; set; }
        public List<int> ScopesIds { get; set; }
        public string Title { get; set; }
        public Reference Type { get; set; }
        public List<int> TypeIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"Dialog",@"Manual",@"Section",@"Sidebar"})]
        public List<string> TypeNames { get; set; }
    }


    [Route("/help", "GET")]
    [Route("/help/version", "GET, POST")]
    [Route("/help/search", "GET, POST, DELETE")]

    public partial class HelpSearch : HelpSearchBase
    {
    }

    public class HelpFullTextSearch
    {
        public HelpFullTextSearch() {}
        private HelpSearch _request;
        public HelpFullTextSearch(HelpSearch request) => _request = request;

        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Help.Created))); }
        public bool doUpdated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Help.Updated))); }

        public bool doConfluenceId { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Help.ConfluenceId))); }
        public bool doDescription { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Help.Description))); }
        public bool doIcon { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Help.Icon))); }
        public bool doOrder { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Help.Order))); }
        public bool doPages { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Help.Pages))); }
        public bool doScopes { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Help.Scopes))); }
        public bool doTitle { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Help.Title))); }
        public bool doType { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Help.Type))); }
    }


    [Route("/help/batch", "DELETE, PATCH, POST, PUT")]

    public partial class HelpBatch : List<Help> { }


    [Route("/help/{Id}/{Junction}/version", "GET, POST")]
    [Route("/help/{Id}/{Junction}", "GET, POST, DELETE")]
    public class HelpJunction : HelpSearchBase {}



}
