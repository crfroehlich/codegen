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
using Services.Dto.internals;
using Services.Enums;
using Services.Models;
using Services.Schema;

using Typed;
using Typed.Bindings;
using Typed.Notifications;
using Services.Dto.Security;
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
    [Route("/lookuptablebinding/{Id}", "GET, PATCH, PUT, DELETE")]
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
            if (IgnoredVisibleFields.Matches(field, true)) return false;
            var ret = MandatoryVisibleFields.Matches(field, true) || true == VisibleFields?.Matches(field, true);
            return ret;
        }

        public static List<string> Fields => DocTools.Fields<LookupTableBinding>();

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
    public partial class LookupTableBindingCopy : LookupTableBinding {}
    public partial class LookupTableBindingSearchBase : Search<LookupTableBinding>
    {
        public int? Id { get; set; }
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

    [Route("/lookuptablebinding", "GET")]
    [Route("/lookuptablebinding/version", "GET, POST")]
    [Route("/lookuptablebinding/search", "GET, POST, DELETE")]
    public partial class LookupTableBindingSearch : LookupTableBindingSearchBase
    {
    }

    public class LookupTableBindingFullTextSearch
    {
        public LookupTableBindingFullTextSearch() {}
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

    [Route("/lookuptablebinding/batch", "DELETE, PATCH, POST, PUT")]
    public partial class LookupTableBindingBatch : List<LookupTableBinding> { }

    [Route("/lookuptablebinding/{Id}/{Junction}/version", "GET, POST")]
    [Route("/lookuptablebinding/{Id}/{Junction}", "GET, POST, DELETE")]
    public class LookupTableBindingJunction : LookupTableBindingSearchBase {}


}