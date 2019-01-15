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
    public abstract partial class LookupTableBindingBase : Dto<LookupTableBinding>
    {
        public LookupTableBindingBase() {}

        public LookupTableBindingBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public LookupTableBindingBase(int? id) : this(DocConvert.ToInt(id)) {}
    
        [ApiMember(Name = nameof(Binding), Description = "Bindings", IsRequired = false)]
        public Bindings Binding { get; set; }


        [ApiMember(Name = nameof(BoundName), Description = "string", IsRequired = false)]
        public string BoundName { get; set; }


        [ApiMember(Name = nameof(LookupTable), Description = "LookupTable", IsRequired = true)]
        public Reference LookupTable { get; set; }
        [ApiMember(Name = nameof(LookupTableId), Description = "Primary Key of LookupTable", IsRequired = false)]
        public int? LookupTableId { get; set; }


        [ApiMember(Name = nameof(Scope), Description = "Scope", IsRequired = true)]
        public Reference Scope { get; set; }
        [ApiMember(Name = nameof(ScopeId), Description = "Primary Key of Scope", IsRequired = false)]
        public int? ScopeId { get; set; }


        [ApiMember(Name = nameof(Synonyms), Description = "TermSynonym", IsRequired = false)]
        public List<Reference> Synonyms { get; set; }
        public int? SynonymsCount { get; set; }


        [ApiMember(Name = nameof(Workflows), Description = "Workflow", IsRequired = false)]
        public List<Reference> Workflows { get; set; }
        public int? WorkflowsCount { get; set; }


    }

    [Route("/lookuptablebinding", "POST")]
    [Route("/profile/lookuptablebinding", "POST")]
    [Route("/lookuptablebinding/{Id}", "GET, PATCH, PUT, DELETE")]
    [Route("/profile/lookuptablebinding/{Id}", "GET, PATCH, PUT, DELETE")]
    public partial class LookupTableBinding : LookupTableBindingBase, IReturn<LookupTableBinding>, IDto
    {
        public LookupTableBinding()
        {
            _Constructor();
        }

        public LookupTableBinding(int? id) : base(DocConvert.ToInt(id)) {}
        public LookupTableBinding(int id) : base(id) {}
        
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
        public static List<string> Fields => _fields ?? (_fields = DocTools.Fields<LookupTableBinding>());

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Binding),nameof(BoundName),nameof(Created),nameof(CreatorId),nameof(Gestalt),nameof(Locked),nameof(LookupTable),nameof(LookupTableId),nameof(Scope),nameof(ScopeId),nameof(Synonyms),nameof(SynonymsCount),nameof(Updated),nameof(VersionNo),nameof(Workflows),nameof(WorkflowsCount)})]
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
                _VisibleFields = DocPermissionFactory.SetVisibleFields<LookupTableBinding>("LookupTableBinding",exists);
            }
        }

        #endregion Fields
        private List<string> _collections = new List<string>
        {
            nameof(Synonyms), nameof(SynonymsCount), nameof(Workflows), nameof(WorkflowsCount)
        };
        private List<string> collections { get { return _collections; } }
    }
    
    [Route("/LookupTableBinding/{Id}/copy", "POST")]
    [Route("/profile/LookupTableBinding/{Id}/copy", "POST")]
    public partial class LookupTableBindingCopy : LookupTableBinding {}
    [Route("/lookuptablebinding", "GET")]
    [Route("/profile/lookuptablebinding", "GET")]
    [Route("/lookuptablebinding/search", "GET, POST, DELETE")]
    [Route("/profile/lookuptablebinding/search", "GET, POST, DELETE")]
    public partial class LookupTableBindingSearch : Search<LookupTableBinding>
    {
        public string Binding { get; set; }
        public string BoundName { get; set; }
        public Reference LookupTable { get; set; }
        public List<int> LookupTableIds { get; set; }
        public List<string> LookupTableNames { get; set; }
        public Reference Scope { get; set; }
        public List<int> ScopeIds { get; set; }
        public List<int> SynonymsIds { get; set; }
        public List<int> WorkflowsIds { get; set; }
    }
    
    public class LookupTableBindingFullTextSearch
    {
        private LookupTableBindingSearch _request;
        public LookupTableBindingFullTextSearch(LookupTableBindingSearch request) => _request = request;
        
        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(LookupTableBinding.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(LookupTableBinding.Updated))); }
        
        public bool doBinding { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(LookupTableBinding.Binding))); }
        public bool doBoundName { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(LookupTableBinding.BoundName))); }
        public bool doLookupTable { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(LookupTableBinding.LookupTable))); }
        public bool doScope { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(LookupTableBinding.Scope))); }
        public bool doSynonyms { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(LookupTableBinding.Synonyms))); }
        public bool doWorkflows { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(LookupTableBinding.Workflows))); }
    }

    [Route("/lookuptablebinding/version", "GET, POST")]
    public partial class LookupTableBindingVersion : LookupTableBindingSearch {}

    [Route("/lookuptablebinding/batch", "DELETE, PATCH, POST, PUT")]
    [Route("/profile/lookuptablebinding/batch", "DELETE, PATCH, POST, PUT")]
    public partial class LookupTableBindingBatch : List<LookupTableBinding> { }

    [Route("/lookuptablebinding/{Id}/termsynonym", "GET, POST, DELETE")]
    [Route("/profile/lookuptablebinding/{Id}/termsynonym", "GET, POST, DELETE")]
    [Route("/lookuptablebinding/{Id}/workflow", "GET, POST, DELETE")]
    [Route("/profile/lookuptablebinding/{Id}/workflow", "GET, POST, DELETE")]
    public class LookupTableBindingJunction : Search<LookupTableBinding>
    {
        public int? Id { get; set; }
        public List<int> Ids { get; set; }
        public List<string> VisibleFields { get; set; }
        public bool ShouldSerializeVisibleFields()
        {
            { return false; }
        }


        public LookupTableBindingJunction(int id, List<int> ids)
        {
            this.Id = id;
            this.Ids = ids;
        }
    }


    [Route("/lookuptablebinding/{Id}/termsynonym/version", "GET")]
    [Route("/profile/lookuptablebinding/{Id}/termsynonym/version", "GET")]
    [Route("/lookuptablebinding/{Id}/workflow/version", "GET")]
    [Route("/profile/lookuptablebinding/{Id}/workflow/version", "GET")]
    public class LookupTableBindingJunctionVersion : IReturn<Version>
    {
        public int? Id { get; set; }
        public List<int> Ids { get; set; }
        public List<string> VisibleFields { get; set; }
        public bool ShouldSerializeVisibleFields()
        {
            { return false; }
        }
    }
    [Route("/admin/lookuptablebinding/ids", "GET, POST")]
    public class LookupTableBindingIds
    {
        public bool All { get; set; }
    }
}