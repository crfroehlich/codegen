//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated by a T4 template. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using AutoMapper;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Dynamic;
using System.Linq.Expressions;
using System.Net;
using System.Reflection;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using Services.Core;
using Services.Db;
using Services.Dto;
using Services.Dto.internals;
using Services.Dto.Security;
using Services.Enums;
using Services.Models;
using Services.Schema;

using ServiceStack;
using ServiceStack.Text;

using Typed;
using Typed.Bindings;
using Typed.Notifications;
using Typed.Settings;

using Xtensive.Orm;
using Xtensive.Orm.Model;

using Attribute = Services.Dto.Attribute;
using ValueType = Services.Dto.ValueType;
using Version = Services.Dto.Version;
namespace Services.Dto
{
    public abstract partial class TagBase : Dto<Tag>
    {
        public TagBase() {}

        public TagBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public TagBase(int? id) : this(DocConvert.ToInt(id)) {}

        public TagBase(int? pId, string pName, List<Reference> pScopes, int? pScopesCount, string pURI) : this(DocConvert.ToInt(pId)) 
        {
            Name = pName;
            Scopes = pScopes;
            ScopesCount = pScopesCount;
            URI = pURI;
        }

        [ApiMember(Name = nameof(Name), Description = "string", IsRequired = true)]
        public string Name { get; set; }


        [ApiMember(Name = nameof(Scopes), Description = "Scope", IsRequired = false)]
        public List<Reference> Scopes { get; set; }
        public int? ScopesCount { get; set; }


        [ApiMember(Name = nameof(URI), Description = "string", IsRequired = false)]
        public string URI { get; set; }



        public void Deconstruct(out string pName, out List<Reference> pScopes, out int? pScopesCount, out string pURI)
        {
            pName = Name;
            pScopes = Scopes;
            pScopesCount = ScopesCount;
            pURI = URI;
        }

        //Not ready until C# v8.?
        //public TagBase With(int? pId = Id, string pName = Name, List<Reference> pScopes = Scopes, int? pScopesCount = ScopesCount, string pURI = URI) => 
        //	new TagBase(pId, pName, pScopes, pScopesCount, pURI);

    }

    [Route("/tag", "POST")]
    [Route("/tag/{Id}", "GET, DELETE")]
    public partial class Tag : TagBase, IReturn<Tag>, IDto, ICloneable
    {
        public Tag()
        {
            _Constructor();
        }

        public Tag(int? id) : base(DocConvert.ToInt(id)) {}
        public Tag(int id) : base(id) {}
        public Tag(int? pId, string pName, List<Reference> pScopes, int? pScopesCount, string pURI) : 
            base(pId, pName, pScopes, pScopesCount, pURI) { }
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

        public static List<string> Fields => DocTools.Fields<Tag>();

        private List<string> _Select;
        [ApiMember(Name = "Select", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Created),nameof(CreatorId),nameof(Gestalt),nameof(Locked),nameof(Name),nameof(Scopes),nameof(ScopesCount),nameof(Updated),nameof(URI),nameof(VersionNo)})]
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
                _Select = DocPermissionFactory.SetSelect<Tag>("Tag",exists);
            }
        }

        #endregion Fields
        private List<string> _collections = new List<string>
        {
            nameof(Scopes), nameof(ScopesCount)
        };
        private List<string> collections { get { return _collections; } }

        public object Clone() => this.Copy<Tag>();
    }
    
    [Route("/tag/{Id}/copy", "POST")]
    public partial class TagCopy : Tag {}
    public partial class TagSearchBase : Search<Tag>
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public List<int> ScopesIds { get; set; }
        public string URI { get; set; }
    }

    [Route("/tag", "GET")]
    [Route("/tag/version", "GET, POST")]
    [Route("/tag/search", "GET, POST, DELETE")]
    public partial class TagSearch : TagSearchBase
    {
    }

    public class TagFullTextSearch
    {
        public TagFullTextSearch() {}
        private TagSearch _request;
        public TagFullTextSearch(TagSearch request) => _request = request;

        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Tag.Created))); }
        public bool doUpdated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Tag.Updated))); }

        public bool doName { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Tag.Name))); }
        public bool doScopes { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Tag.Scopes))); }
        public bool doURI { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Tag.URI))); }
    }

    [Route("/tag/batch", "DELETE, PATCH, POST, PUT")]
    public partial class TagBatch : List<Tag> { }

    [Route("/tag/{Id}/{Junction}/version", "GET, POST")]
    [Route("/tag/{Id}/{Junction}", "GET, POST, DELETE")]
    public class TagJunction : TagSearchBase {}


}
