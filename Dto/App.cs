﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when
//    the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AutoMapper;

using Services.Core;
using Services.Db;
using Services.Dto;
using Services.Enums;
using Services.Models;
using Services.Schema;

using Typed;
using Typed.Bindings;
using Typed.Notifications;
using Typed.Settings;

using ServiceStack;
using ServiceStack.Text;

using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Dynamic;
using System.Net;

using Xtensive.Orm;
using Xtensive.Orm.Model;

using Attribute = Services.Dto.Attribute;
using ValueType = Services.Dto.ValueType;

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
    
        [ApiMember(Name = nameof(Description), Description = "string", IsRequired = false)]
        public string Description { get; set; }


        [ApiMember(Name = nameof(Icon), Description = "string", IsRequired = false)]
        public string Icon { get; set; }


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


        [ApiMember(Name = nameof(Version), Description = "decimal", IsRequired = false)]
        public decimal Version { get; set; }


    }

    [Route("/app/{Id}", "GET, PATCH, PUT")]
    [Route("/profile/app/{Id}", "GET, PATCH, PUT")]
    public partial class App : AppBase, IReturn<App>, IDto
    {
        public App()
        {
            _Constructor();
        }

        public App(int? id) : base(DocConvert.ToInt(id)) {}
        public App(int id) : base(id) {}
        
        #region Fields
        
        public bool? ShouldSerialize(string field)
        {
            if (DocTools.AreEqual(nameof(VisibleFields), field)) return false;
            if (DocTools.AreEqual(nameof(Fields), field)) return false;
            if (DocTools.AreEqual(nameof(AssignFields), field)) return false;
            if (DocTools.AreEqual(nameof(IgnoreCache), field)) return false;
            if (DocTools.AreEqual(nameof(Id), field)) return true;
            return true == VisibleFields?.Matches(field, true);
        }

        private static List<string> _fields;
        public static List<string> Fields => _fields ?? (_fields = DocTools.Fields<App>());

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Created),nameof(CreatorId),nameof(Description),nameof(Gestalt),nameof(Icon),nameof(Locked),nameof(Name),nameof(Pages),nameof(PagesCount),nameof(Roles),nameof(RolesCount),nameof(Scopes),nameof(ScopesCount),nameof(Updated),nameof(Version),nameof(VersionNo)})]
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
    }
    
    [Route("/app", "GET")]
    [Route("/profile/app", "GET")]
    [Route("/app/search", "GET, POST, DELETE")]
    [Route("/profile/app/search", "GET, POST, DELETE")]
    public partial class AppSearch : Search<App>
    {
        public string Description { get; set; }
        public string Icon { get; set; }
        public string Name { get; set; }
        public List<int> PagesIds { get; set; }
        public List<int> RolesIds { get; set; }
        public List<int> ScopesIds { get; set; }
        public decimal? Version { get; set; }
    }
    
    public class AppFullTextSearch
    {
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
        public bool doIcon { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(App.Icon))); }
        public bool doName { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(App.Name))); }
        public bool doPages { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(App.Pages))); }
        public bool doRoles { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(App.Roles))); }
        public bool doScopes { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(App.Scopes))); }
        public bool doVersion { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(App.Version))); }
    }

    [Route("/app/version", "GET, POST")]
    public partial class AppVersion : AppSearch {}

    [Route("/app/batch", "DELETE, PATCH, POST, PUT")]
    [Route("/profile/app/batch", "DELETE, PATCH, POST, PUT")]
    public partial class AppBatch : List<App> { }

    [Route("/app/{Id}/page", "GET, POST, DELETE")]
    [Route("/profile/app/{Id}/page", "GET, POST, DELETE")]
    [Route("/app/{Id}/role", "GET, POST, DELETE")]
    [Route("/profile/app/{Id}/role", "GET, POST, DELETE")]
    [Route("/app/{Id}/scope", "GET, POST, DELETE")]
    [Route("/profile/app/{Id}/scope", "GET, POST, DELETE")]
    public class AppJunction : Search<App>
    {
        public int? Id { get; set; }
        public List<int> Ids { get; set; }
        public List<string> VisibleFields { get; set; }
        public bool ShouldSerializeVisibleFields()
        {
            { return false; }
        }


        public AppJunction(int id, List<int> ids)
        {
            this.Id = id;
            this.Ids = ids;
        }
    }


    [Route("/app/{Id}/page/version", "GET")]
    [Route("/profile/app/{Id}/page/version", "GET")]
    [Route("/app/{Id}/role/version", "GET")]
    [Route("/profile/app/{Id}/role/version", "GET")]
    [Route("/app/{Id}/scope/version", "GET")]
    [Route("/profile/app/{Id}/scope/version", "GET")]
    public class AppJunctionVersion : IReturn<Version>
    {
        public int? Id { get; set; }
        public List<int> Ids { get; set; }
        public List<string> VisibleFields { get; set; }
        public bool ShouldSerializeVisibleFields()
        {
            { return false; }
        }
    }
    [Route("/admin/app/ids", "GET, POST")]
    public class AppIds
    {
        public bool All { get; set; }
    }
}