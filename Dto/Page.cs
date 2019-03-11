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
    public abstract partial class PageBase : Dto<Page>
    {
        public PageBase() {}

        public PageBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public PageBase(int? id) : this(DocConvert.ToInt(id)) {}

        [ApiMember(Name = nameof(Apps), Description = "App", IsRequired = false)]
        public List<Reference> Apps { get; set; }
        public int? AppsCount { get; set; }


        [ApiMember(Name = nameof(Description), Description = "string", IsRequired = false)]
        public string Description { get; set; }


        [ApiMember(Name = nameof(Glossary), Description = "Glossary", IsRequired = false)]
        public List<Reference> Glossary { get; set; }
        public int? GlossaryCount { get; set; }


        [ApiMember(Name = nameof(Help), Description = "Help", IsRequired = false)]
        public List<Reference> Help { get; set; }
        public int? HelpCount { get; set; }


        [ApiMember(Name = nameof(Name), Description = "string", IsRequired = true)]
        public string Name { get; set; }


        [ApiMember(Name = nameof(Roles), Description = "Role", IsRequired = false)]
        public List<Reference> Roles { get; set; }
        public int? RolesCount { get; set; }


    }

    [Route("/page", "POST")]
    [Route("/page/{Id}", "GET, PATCH, PUT, DELETE")]
    public partial class Page : PageBase, IReturn<Page>, IDto
    {
        public Page()
        {
            _Constructor();
        }

        public Page(int? id) : base(DocConvert.ToInt(id)) {}
        public Page(int id) : base(id) {}
        
        #region Fields
        
        public bool? ShouldSerialize(string field)
        {
            if (IgnoredVisibleFields.Matches(field, true)) return false;
            var ret = MandatoryVisibleFields.Matches(field, true) || true == VisibleFields?.Matches(field, true);
            return ret;
        }

        public static List<string> Fields => DocTools.Fields<Page>();

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Apps),nameof(AppsCount),nameof(Created),nameof(CreatorId),nameof(Description),nameof(Gestalt),nameof(Glossary),nameof(GlossaryCount),nameof(Help),nameof(HelpCount),nameof(Locked),nameof(Name),nameof(Roles),nameof(RolesCount),nameof(Updated),nameof(VersionNo)})]
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
                _VisibleFields = DocPermissionFactory.SetVisibleFields<Page>("Page",exists);
            }
        }

        #endregion Fields
        private List<string> _collections = new List<string>
        {
            nameof(Apps), nameof(AppsCount), nameof(Glossary), nameof(GlossaryCount), nameof(Help), nameof(HelpCount), nameof(Roles), nameof(RolesCount)
        };
        private List<string> collections { get { return _collections; } }
    }
    
    [Route("/Page/{Id}/copy", "POST")]
    public partial class PageCopy : Page {}
    public partial class PageSearchBase : Search<Page>
    {
        public int? Id { get; set; }
        public List<int> AppsIds { get; set; }
        public string Description { get; set; }
        public List<int> GlossaryIds { get; set; }
        public List<int> HelpIds { get; set; }
        public string Name { get; set; }
        public List<int> RolesIds { get; set; }
    }

    [Route("/page", "GET")]
    [Route("/page/version", "GET, POST")]
    [Route("/page/search", "GET, POST, DELETE")]
    public partial class PageSearch : PageSearchBase
    {
    }

    public class PageFullTextSearch
    {
        public PageFullTextSearch() {}
        private PageSearch _request;
        public PageFullTextSearch(PageSearch request) => _request = request;

        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Page.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Page.Updated))); }

        public bool doApps { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Page.Apps))); }
        public bool doDescription { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Page.Description))); }
        public bool doGlossary { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Page.Glossary))); }
        public bool doHelp { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Page.Help))); }
        public bool doName { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Page.Name))); }
        public bool doRoles { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Page.Roles))); }
    }

    [Route("/page/batch", "DELETE, PATCH, POST, PUT")]
    public partial class PageBatch : List<Page> { }

    [Route("/page/{Id}/{Junction}/version", "GET, POST")]
    [Route("/page/{Id}/{Junction}", "GET, POST, DELETE")]
    public class PageJunction : PageSearchBase {}


}
