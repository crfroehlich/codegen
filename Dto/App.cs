 
 
 
 
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
    public abstract partial class AppBase : Dto<App>
    {
        public AppBase() {}

        public AppBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public AppBase(int? id) : this(DocConvert.ToInt(id)) {}

        public AppBase(int? pId, string pDescription, string pName, List<Reference> pPages, int? pPagesCount, List<Reference> pRoles, int? pRolesCount, List<Reference> pScopes, int? pScopesCount) : this(DocConvert.ToInt(pId)) 
        {
            Description = pDescription;
            Name = pName;
            Pages = pPages;
            PagesCount = pPagesCount;
            Roles = pRoles;
            RolesCount = pRolesCount;
            Scopes = pScopes;
            ScopesCount = pScopesCount;
        }

        [ApiMember(Name = nameof(Description), Description = "string", IsRequired = false)]
        public string Description { get; set; }


        [ApiMember(Name = nameof(Name), Description = "string", IsRequired = true)]
        public string Name { get; set; }


        [ApiMember(Name = nameof(Pages), Description = "Page", IsRequired = false)]
        public List<Reference> Pages { get; set; }
        public int? PagesCount { get; set; }


        [ApiMember(Name = nameof(Roles), Description = "Role", IsRequired = false)]
        public List<Reference> Roles { get; set; }
        public int? RolesCount { get; set; }


        [ApiMember(Name = nameof(Scopes), Description = "Scope", IsRequired = false)]
        public List<Reference> Scopes { get; set; }
        public int? ScopesCount { get; set; }



        public void Deconstruct(out string pDescription, out string pName, out List<Reference> pPages, out int? pPagesCount, out List<Reference> pRoles, out int? pRolesCount, out List<Reference> pScopes, out int? pScopesCount)
        {
            pDescription = Description;
            pName = Name;
            pPages = Pages;
            pPagesCount = PagesCount;
            pRoles = Roles;
            pRolesCount = RolesCount;
            pScopes = Scopes;
            pScopesCount = ScopesCount;
        }

        //Not ready until C# v8.?
        //public AppBase With(int? pId = Id, string pDescription = Description, string pName = Name, List<Reference> pPages = Pages, int? pPagesCount = PagesCount, List<Reference> pRoles = Roles, int? pRolesCount = RolesCount, List<Reference> pScopes = Scopes, int? pScopesCount = ScopesCount) => 
        //	new AppBase(pId, pDescription, pName, pPages, pPagesCount, pRoles, pRolesCount, pScopes, pScopesCount);

    }

    [Route("/app/{Id}", "GET, PATCH, PUT")]
    public partial class App : AppBase, IReturn<App>, IDto, ICloneable
    {
        public App()
        {
            _Constructor();
        }

        public App(int? id) : base(DocConvert.ToInt(id)) {}
        public App(int id) : base(id) {}
        public App(int? pId, string pDescription, string pName, List<Reference> pPages, int? pPagesCount, List<Reference> pRoles, int? pRolesCount, List<Reference> pScopes, int? pScopesCount) : 
            base(pId, pDescription, pName, pPages, pPagesCount, pRoles, pRolesCount, pScopes, pScopesCount) { }
        #region Fields
        
        public bool? ShouldSerialize(string field)
        {
            if (IgnoredVisibleFields.Matches(field, true)) return false;
            var ret = MandatoryVisibleFields.Matches(field, true) || true == VisibleFields?.Matches(field, true);
            return ret;
        }

        public static List<string> Fields => DocTools.Fields<App>();

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Created),nameof(CreatorId),nameof(Description),nameof(Gestalt),nameof(Locked),nameof(Name),nameof(Pages),nameof(PagesCount),nameof(Roles),nameof(RolesCount),nameof(Scopes),nameof(ScopesCount),nameof(Updated),nameof(VersionNo)})]
        public new List<string> VisibleFields
        {
            get
            {
                if(null == this) return new List<string>();
                if(null == _VisibleFields)
                {
                    _VisibleFields = DocWebSession.GetTypeVisibleFields(this);
                }
                return _VisibleFields;
            }
            set
            {
                var requested = value ?? new List<string>();
                var exists = requested.Where( r => Fields.Any( f => DocTools.AreEqual(r, f) ) ).ToList();
                _VisibleFields = DocPermissionFactory.SetVisibleFields<App>("App",exists);
            }
        }

        #endregion Fields
        private List<string> _collections = new List<string>
        {
            nameof(Pages), nameof(PagesCount), nameof(Roles), nameof(RolesCount), nameof(Scopes), nameof(ScopesCount)
        };
        private List<string> collections { get { return _collections; } }

        public object Clone() => this.Copy<App>();
    }
    
    public partial class AppSearchBase : Search<App>
    {
        public int? Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public List<int> PagesIds { get; set; }
        public List<int> RolesIds { get; set; }
        public List<int> ScopesIds { get; set; }
    }

    [Route("/app", "GET")]
    [Route("/app/version", "GET, POST")]
    [Route("/app/search", "GET, POST, DELETE")]
    public partial class AppSearch : AppSearchBase
    {
    }

    public class AppFullTextSearch
    {
        public AppFullTextSearch() {}
        private AppSearch _request;
        public AppFullTextSearch(AppSearch request) => _request = request;

        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(App.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(App.Updated))); }

        public bool doDescription { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(App.Description))); }
        public bool doName { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(App.Name))); }
        public bool doPages { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(App.Pages))); }
        public bool doRoles { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(App.Roles))); }
        public bool doScopes { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(App.Scopes))); }
    }

    [Route("/app/batch", "DELETE, PATCH, POST, PUT")]
    public partial class AppBatch : List<App> { }

    [Route("/app/{Id}/{Junction}/version", "GET, POST")]
    [Route("/app/{Id}/{Junction}", "GET, POST, DELETE")]
    public class AppJunction : AppSearchBase {}


}
