
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
    public abstract partial class FavoriteBase : Dto<Favorite>
    {
        public FavoriteBase() {}

        public FavoriteBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public FavoriteBase(int? id) : this(DocConvert.ToInt(id)) {}

        public FavoriteBase(int? pId, Reference pScope, int? pScopeId) : this(DocConvert.ToInt(pId)) 
        {
            Scope = pScope;
            ScopeId = pScopeId;
        }

        [ApiMember(Name = nameof(Scope), Description = "Scope", IsRequired = true)]
        public Reference Scope { get; set; }
        [ApiMember(Name = nameof(ScopeId), Description = "Primary Key of Scope", IsRequired = false)]
        public int? ScopeId { get; set; }



        public void Deconstruct(out Reference pScope, out int? pScopeId)
        {
            pScope = Scope;
            pScopeId = ScopeId;
        }

        //Not ready until C# v8.?
        //public FavoriteBase With(int? pId = Id, Reference pScope = Scope, int? pScopeId = ScopeId) => 
        //	new FavoriteBase(pId, pScope, pScopeId);

    }


    [Route("/favorite", "POST")]
    [Route("/favorite/{Id}", "GET, DELETE")]

    public partial class Favorite : FavoriteBase, IReturn<Favorite>, IDto, ICloneable
    {
        public Favorite()
        {
            _Constructor();
        }

        public Favorite(int? id) : base(DocConvert.ToInt(id)) {}
        public Favorite(int id) : base(id) {}
        public Favorite(int? pId, Reference pScope, int? pScopeId) : 
            base(pId, pScope, pScopeId) { }

        public new bool? ShouldSerialize(string field)
        {
            //Allow individual classes to specify their own logic
            var manualOverride = _ShouldSerialize(field);
            if(null != manualOverride) return manualOverride;

            if (IgnoredSelect.Matches(field, true)) return false;
            var ret = MandatorySelect.Matches(field, true) || true == Select?.Matches(field, true);
            return ret;
        }

        public static List<string> Fields => DocTools.Fields<Favorite>();

        private List<string> _Select;
        [ApiMember(Name = nameof(Select), Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Created),nameof(CreatorId),nameof(Gestalt),nameof(Locked),nameof(Scope),nameof(ScopeId),nameof(Updated),nameof(VersionNo)})]
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
                _Select = DocPermissionFactory.SetSelect<Favorite>("Favorite",exists);

            }
        }

        [Obsolete, ApiMember(Name = nameof(VisibleFields), Description = "Deprecated. Use Select instead.", AllowMultiple = true)]
        public override List<string> VisibleFields { get => Select; set => Select = value; }



        public object Clone() => this.Copy<Favorite>();

    }
    

    [Route("/favorite/{Id}/copy", "POST")]
    public partial class FavoriteCopy : Favorite {}

    public partial class FavoriteSearchBase : Search<Favorite>
    {
        public int? Id { get; set; }
        public Reference Scope { get; set; }
        public List<int> ScopeIds { get; set; }
    }


    [Route("/favorite", "GET")]
    [Route("/favorite/version", "GET, POST")]
    [Route("/favorite/search", "GET, POST, DELETE")]

    public partial class FavoriteSearch : FavoriteSearchBase
    {
    }

    public class FavoriteFullTextSearch
    {
        public FavoriteFullTextSearch() {}
        private FavoriteSearch _request;
        public FavoriteFullTextSearch(FavoriteSearch request) => _request = request;

        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Favorite.Created))); }
        public bool doUpdated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Favorite.Updated))); }

        public bool doScope { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Favorite.Scope))); }
    }


    [Route("/favorite/batch", "DELETE, PATCH, POST, PUT")]

    public partial class FavoriteBatch : List<Favorite> { }


}
