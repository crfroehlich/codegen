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
    public abstract partial class VariableInstanceBase : Dto<VariableInstance>
    {
        public VariableInstanceBase() {}

        public VariableInstanceBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public VariableInstanceBase(int? id) : this(DocConvert.ToInt(id)) {}
    
        [ApiMember(Name = nameof(Data), Description = "string", IsRequired = false)]
        public string Data { get; set; }


        [ApiMember(Name = nameof(Document), Description = "Document", IsRequired = true)]
        public Reference Document { get; set; }
        [ApiMember(Name = nameof(DocumentId), Description = "Primary Key of Document", IsRequired = false)]
        public int? DocumentId { get; set; }


        [ApiMember(Name = nameof(Rule), Description = "VariableRule", IsRequired = true)]
        public Reference Rule { get; set; }
        [ApiMember(Name = nameof(RuleId), Description = "Primary Key of VariableRule", IsRequired = false)]
        public int? RuleId { get; set; }


        [ApiMember(Name = nameof(Workflows), Description = "Workflow", IsRequired = false)]
        public List<Reference> Workflows { get; set; }
        public int? WorkflowsCount { get; set; }


    }

    [Route("/variableinstance", "POST")]
    [Route("/profile/variableinstance", "POST")]
    [Route("/variableinstance/{Id}", "GET, PATCH, PUT, DELETE")]
    [Route("/profile/variableinstance/{Id}", "GET, PATCH, PUT, DELETE")]
    public partial class VariableInstance : VariableInstanceBase, IReturn<VariableInstance>, IDto
    {
        public VariableInstance()
        {
            _Constructor();
        }

        public VariableInstance(int? id) : base(DocConvert.ToInt(id)) {}
        public VariableInstance(int id) : base(id) {}
        
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
        public static List<string> Fields => _fields ?? (_fields = DocTools.Fields<VariableInstance>());

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Created),nameof(CreatorId),nameof(Data),nameof(Document),nameof(DocumentId),nameof(Gestalt),nameof(Locked),nameof(Rule),nameof(RuleId),nameof(Updated),nameof(VersionNo),nameof(Workflows),nameof(WorkflowsCount)})]
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
                _VisibleFields = DocPermissionFactory.SetVisibleFields<VariableInstance>("VariableInstance",exists);
            }
        }

        #endregion Fields
        private List<string> _collections = new List<string>
        {
            nameof(Workflows), nameof(WorkflowsCount)
        };
        private List<string> collections { get { return _collections; } }
    }
    
    [Route("/VariableInstance/{Id}/copy", "POST")]
    [Route("/profile/VariableInstance/{Id}/copy", "POST")]
    public partial class VariableInstanceCopy : VariableInstance {}
    [Route("/variableinstance", "GET")]
    [Route("/profile/variableinstance", "GET")]
    [Route("/variableinstance/search", "GET, POST, DELETE")]
    [Route("/profile/variableinstance/search", "GET, POST, DELETE")]
    public partial class VariableInstanceSearch : Search<VariableInstance>
    {
        public string Data { get; set; }
        public Reference Document { get; set; }
        public List<int> DocumentIds { get; set; }
        public Reference Rule { get; set; }
        public List<int> RuleIds { get; set; }
        public List<int> WorkflowsIds { get; set; }
    }
    
    public class VariableInstanceFullTextSearch
    {
        private VariableInstanceSearch _request;
        public VariableInstanceFullTextSearch(VariableInstanceSearch request) => _request = request;
        
        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(VariableInstance.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(VariableInstance.Updated))); }
        
        public bool doData { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(VariableInstance.Data))); }
        public bool doDocument { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(VariableInstance.Document))); }
        public bool doRule { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(VariableInstance.Rule))); }
        public bool doWorkflows { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(VariableInstance.Workflows))); }
    }

    [Route("/variableinstance/version", "GET, POST")]
    public partial class VariableInstanceVersion : VariableInstanceSearch {}

    [Route("/variableinstance/batch", "DELETE, PATCH, POST, PUT")]
    [Route("/profile/variableinstance/batch", "DELETE, PATCH, POST, PUT")]
    public partial class VariableInstanceBatch : List<VariableInstance> { }

    [Route("/variableinstance/{Id}/workflow", "GET, POST, DELETE")]
    [Route("/profile/variableinstance/{Id}/workflow", "GET, POST, DELETE")]
    public class VariableInstanceJunction : Search<VariableInstance>
    {
        public int? Id { get; set; }
        public List<int> Ids { get; set; }
        public List<string> VisibleFields { get; set; }
        public bool ShouldSerializeVisibleFields()
        {
            { return false; }
        }


        public VariableInstanceJunction(int id, List<int> ids)
        {
            this.Id = id;
            this.Ids = ids;
        }
    }


    [Route("/variableinstance/{Id}/workflow/version", "GET")]
    [Route("/profile/variableinstance/{Id}/workflow/version", "GET")]
    public class VariableInstanceJunctionVersion : IReturn<Version>
    {
        public int? Id { get; set; }
        public List<int> Ids { get; set; }
        public List<string> VisibleFields { get; set; }
        public bool ShouldSerializeVisibleFields()
        {
            { return false; }
        }
    }
}