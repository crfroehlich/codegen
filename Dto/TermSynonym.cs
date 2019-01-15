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
    public abstract partial class TermSynonymBase : Dto<TermSynonym>
    {
        public TermSynonymBase() {}

        public TermSynonymBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public TermSynonymBase(int? id) : this(DocConvert.ToInt(id)) {}
    
        [ApiMember(Name = nameof(Approved), Description = "bool", IsRequired = false)]
        public bool Approved { get; set; }


        [ApiMember(Name = nameof(Bindings), Description = "LookupTableBinding", IsRequired = false)]
        public List<Reference> Bindings { get; set; }
        public int? BindingsCount { get; set; }


        [ApiMember(Name = nameof(Master), Description = "TermMaster", IsRequired = true)]
        public Reference Master { get; set; }
        [ApiMember(Name = nameof(MasterId), Description = "Primary Key of TermMaster", IsRequired = false)]
        public int? MasterId { get; set; }


        [ApiMember(Name = nameof(Preferred), Description = "bool", IsRequired = false)]
        public bool Preferred { get; set; }


        [ApiMember(Name = nameof(Scope), Description = "Scope", IsRequired = false)]
        public Reference Scope { get; set; }
        [ApiMember(Name = nameof(ScopeId), Description = "Primary Key of Scope", IsRequired = false)]
        public int? ScopeId { get; set; }


        [ApiMember(Name = nameof(Synonym), Description = "string", IsRequired = true)]
        public string Synonym { get; set; }


    }

    [Route("/termsynonym", "POST")]
    [Route("/profile/termsynonym", "POST")]
    [Route("/termsynonym/{Id}", "GET, PATCH, PUT, DELETE")]
    [Route("/profile/termsynonym/{Id}", "GET, PATCH, PUT, DELETE")]
    public partial class TermSynonym : TermSynonymBase, IReturn<TermSynonym>, IDto
    {
        public TermSynonym()
        {
            _Constructor();
        }

        public TermSynonym(int? id) : base(DocConvert.ToInt(id)) {}
        public TermSynonym(int id) : base(id) {}
        
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
        public static List<string> Fields => _fields ?? (_fields = DocTools.Fields<TermSynonym>());

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Approved),nameof(Bindings),nameof(BindingsCount),nameof(Created),nameof(CreatorId),nameof(Gestalt),nameof(Locked),nameof(Master),nameof(MasterId),nameof(Preferred),nameof(Scope),nameof(ScopeId),nameof(Synonym),nameof(Updated),nameof(VersionNo)})]
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
                _VisibleFields = DocPermissionFactory.SetVisibleFields<TermSynonym>("TermSynonym",exists);
            }
        }

        #endregion Fields
        private List<string> _collections = new List<string>
        {
            nameof(Bindings), nameof(BindingsCount)
        };
        private List<string> collections { get { return _collections; } }
    }
    
    [Route("/TermSynonym/{Id}/copy", "POST")]
    [Route("/profile/TermSynonym/{Id}/copy", "POST")]
    public partial class TermSynonymCopy : TermSynonym {}
    [Route("/termsynonym", "GET")]
    [Route("/profile/termsynonym", "GET")]
    [Route("/termsynonym/search", "GET, POST, DELETE")]
    [Route("/profile/termsynonym/search", "GET, POST, DELETE")]
    public partial class TermSynonymSearch : Search<TermSynonym>
    {
        public bool? Approved { get; set; }
        public List<int> BindingsIds { get; set; }
        public Reference Master { get; set; }
        public List<int> MasterIds { get; set; }
        public bool? Preferred { get; set; }
        public Reference Scope { get; set; }
        public List<int> ScopeIds { get; set; }
        public string Synonym { get; set; }
    }
    
    public class TermSynonymFullTextSearch
    {
        private TermSynonymSearch _request;
        public TermSynonymFullTextSearch(TermSynonymSearch request) => _request = request;
        
        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(TermSynonym.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(TermSynonym.Updated))); }
        
        public bool doApproved { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(TermSynonym.Approved))); }
        public bool doBindings { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(TermSynonym.Bindings))); }
        public bool doMaster { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(TermSynonym.Master))); }
        public bool doPreferred { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(TermSynonym.Preferred))); }
        public bool doScope { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(TermSynonym.Scope))); }
        public bool doSynonym { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(TermSynonym.Synonym))); }
    }

    [Route("/termsynonym/version", "GET, POST")]
    public partial class TermSynonymVersion : TermSynonymSearch {}

    [Route("/termsynonym/batch", "DELETE, PATCH, POST, PUT")]
    [Route("/profile/termsynonym/batch", "DELETE, PATCH, POST, PUT")]
    public partial class TermSynonymBatch : List<TermSynonym> { }

    [Route("/termsynonym/{Id}/lookuptablebinding", "GET, POST, DELETE")]
    [Route("/profile/termsynonym/{Id}/lookuptablebinding", "GET, POST, DELETE")]
    public class TermSynonymJunction : Search<TermSynonym>
    {
        public int? Id { get; set; }
        public List<int> Ids { get; set; }
        public List<string> VisibleFields { get; set; }
        public bool ShouldSerializeVisibleFields()
        {
            { return false; }
        }


        public TermSynonymJunction(int id, List<int> ids)
        {
            this.Id = id;
            this.Ids = ids;
        }
    }


    [Route("/termsynonym/{Id}/lookuptablebinding/version", "GET")]
    [Route("/profile/termsynonym/{Id}/lookuptablebinding/version", "GET")]
    public class TermSynonymJunctionVersion : IReturn<Version>
    {
        public int? Id { get; set; }
        public List<int> Ids { get; set; }
        public List<string> VisibleFields { get; set; }
        public bool ShouldSerializeVisibleFields()
        {
            { return false; }
        }
    }
    [Route("/admin/termsynonym/ids", "GET, POST")]
    public class TermSynonymIds
    {
        public bool All { get; set; }
    }
}