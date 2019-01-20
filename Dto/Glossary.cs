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
    public abstract partial class GlossaryBase : Dto<Glossary>
    {
        public GlossaryBase() {}

        public GlossaryBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public GlossaryBase(int? id) : this(DocConvert.ToInt(id)) {}
    
        [ApiMember(Name = nameof(Definition), Description = "string", IsRequired = false)]
        public string Definition { get; set; }


        [ApiMember(Name = nameof(Enum), Description = "LookupTableEnum", IsRequired = true)]
        public Reference Enum { get; set; }
        [ApiMember(Name = nameof(EnumId), Description = "Primary Key of LookupTableEnum", IsRequired = false)]
        public int? EnumId { get; set; }


        [ApiMember(Name = nameof(Icon), Description = "string", IsRequired = false)]
        public string Icon { get; set; }


        [ApiMember(Name = nameof(Page), Description = "Page", IsRequired = false)]
        public Reference Page { get; set; }
        [ApiMember(Name = nameof(PageId), Description = "Primary Key of Page", IsRequired = false)]
        public int? PageId { get; set; }


        [ApiMember(Name = nameof(Term), Description = "TermMaster", IsRequired = true)]
        public Reference Term { get; set; }
        [ApiMember(Name = nameof(TermId), Description = "Primary Key of TermMaster", IsRequired = false)]
        public int? TermId { get; set; }


    }

    [Route("/glossary", "POST")]
    [Route("/glossary/{Id}", "GET, PATCH, PUT, DELETE")]
    public partial class Glossary : GlossaryBase, IReturn<Glossary>, IDto
    {
        public Glossary()
        {
            _Constructor();
        }

        public Glossary(int? id) : base(DocConvert.ToInt(id)) {}
        public Glossary(int id) : base(id) {}
        
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
        public static List<string> Fields => _fields ?? (_fields = DocTools.Fields<Glossary>());

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Created),nameof(CreatorId),nameof(Definition),nameof(Enum),nameof(EnumId),nameof(Gestalt),nameof(Icon),nameof(Locked),nameof(Page),nameof(PageId),nameof(Term),nameof(TermId),nameof(Updated),nameof(VersionNo)})]
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
                _VisibleFields = DocPermissionFactory.SetVisibleFields<Glossary>("Glossary",exists);
            }
        }

        #endregion Fields
    }
    
    [Route("/Glossary/{Id}/copy", "POST")]
    public partial class GlossaryCopy : Glossary {}
    [Route("/glossary", "GET")]
    [Route("/glossary/search", "GET, POST, DELETE")]
    public partial class GlossarySearch : Search<Glossary>
    {
        public string Definition { get; set; }
        public Reference Enum { get; set; }
        public List<int> EnumIds { get; set; }
        public string Icon { get; set; }
        public Reference Page { get; set; }
        public List<int> PageIds { get; set; }
        public Reference Term { get; set; }
        public List<int> TermIds { get; set; }
    }
    
    public class GlossaryFullTextSearch
    {
        private GlossarySearch _request;
        public GlossaryFullTextSearch(GlossarySearch request) => _request = request;
        
        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Glossary.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Glossary.Updated))); }
        
        public bool doDefinition { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Glossary.Definition))); }
        public bool doEnum { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Glossary.Enum))); }
        public bool doIcon { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Glossary.Icon))); }
        public bool doPage { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Glossary.Page))); }
        public bool doTerm { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Glossary.Term))); }
    }

    [Route("/glossary/version", "GET, POST")]
    public partial class GlossaryVersion : GlossarySearch {}

    [Route("/glossary/batch", "DELETE, PATCH, POST, PUT")]
    public partial class GlossaryBatch : List<Glossary> { }

    [Route("/admin/glossary/ids", "GET, POST")]
    public class GlossaryIds
    {
        public bool All { get; set; }
    }
}