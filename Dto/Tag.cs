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
using Typed.Security;
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
    public abstract partial class TagBase : Dto<Tag>
    {
        public TagBase() {}

        public TagBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public TagBase(int? id) : this(DocConvert.ToInt(id)) {}
    
        [ApiMember(Name = nameof(Name), Description = "string", IsRequired = true)]
        public string Name { get; set; }


        [ApiMember(Name = nameof(Workflows), Description = "Workflow", IsRequired = false)]
        public List<Reference> Workflows { get; set; }
        public int? WorkflowsCount { get; set; }


    }

    [Route("/tag", "POST")]
    [Route("/profile/tag", "POST")]
    [Route("/tag/{Id}", "GET, DELETE")]
    [Route("/profile/tag/{Id}", "GET, DELETE")]
    public partial class Tag : TagBase, IReturn<Tag>, IDto
    {
        public Tag()
        {
            _Constructor();
        }

        public Tag(int? id) : base(DocConvert.ToInt(id)) {}
        public Tag(int id) : base(id) {}
        
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

        public static List<string> Fields => DocTools.Fields<Tag>();

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Created),nameof(CreatorId),nameof(Gestalt),nameof(Locked),nameof(Name),nameof(Updated),nameof(VersionNo),nameof(Workflows),nameof(WorkflowsCount)})]
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
                _VisibleFields = DocPermissionFactory.SetVisibleFields<Tag>("Tag",exists);
            }
        }

        #endregion Fields
        private List<string> _collections = new List<string>
        {
            nameof(Workflows), nameof(WorkflowsCount)
        };
        private List<string> collections { get { return _collections; } }
    }
    
    [Route("/Tag/{Id}/copy", "POST")]
    [Route("/profile/Tag/{Id}/copy", "POST")]
    public partial class TagCopy : Tag {}
    [Route("/tag", "GET")]
    [Route("/profile/tag", "GET")]
    [Route("/tag/search", "GET, POST, DELETE")]
    [Route("/profile/tag/search", "GET, POST, DELETE")]
    public partial class TagSearch : Search<Tag>
    {
        public string Name { get; set; }
        public List<int> WorkflowsIds { get; set; }
    }
    
    public class TagFullTextSearch
    {
        private TagSearch _request;
        public TagFullTextSearch(TagSearch request) => _request = request;
        
        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Tag.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Tag.Updated))); }
        
        public bool doName { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Tag.Name))); }
        public bool doWorkflows { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Tag.Workflows))); }
    }

    [Route("/tag/version", "GET, POST")]
    public partial class TagVersion : TagSearch {}

    [Route("/tag/batch", "DELETE, PATCH, POST, PUT")]
    [Route("/profile/tag/batch", "DELETE, PATCH, POST, PUT")]
    public partial class TagBatch : List<Tag> { }

    [Route("/tag/{Id}/workflow", "GET, POST, DELETE")]
    [Route("/profile/tag/{Id}/workflow", "GET, POST, DELETE")]
    public class TagJunction : Search<Tag>
    {
        public int? Id { get; set; }
        public List<int> Ids { get; set; }
        public List<string> VisibleFields { get; set; }
        public bool ShouldSerializeVisibleFields()
        {
            { return false; }
        }


        public TagJunction(int id, List<int> ids)
        {
            this.Id = id;
            this.Ids = ids;
        }
    }


    [Route("/tag/{Id}/workflow/version", "GET")]
    [Route("/profile/tag/{Id}/workflow/version", "GET")]
    public class TagJunctionVersion : IReturn<Version>
    {
        public int? Id { get; set; }
        public List<int> Ids { get; set; }
        public List<string> VisibleFields { get; set; }
        public bool ShouldSerializeVisibleFields()
        {
            { return false; }
        }
    }
    [Route("/admin/tag/ids", "GET, POST")]
    public class TagIds
    {
        public bool All { get; set; }
    }
}