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
    public abstract partial class VariableRuleBase : Dto<VariableRule>
    {
        public VariableRuleBase() {}

        public VariableRuleBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public VariableRuleBase(int? id) : this(DocConvert.ToInt(id)) {}
    
        [ApiMember(Name = nameof(Children), Description = "VariableRule", IsRequired = false)]
        public List<Reference> Children { get; set; }
        public int? ChildrenCount { get; set; }


        [ApiMember(Name = nameof(Definition), Description = "string", IsRequired = false)]
        public string Definition { get; set; }


        [ApiMember(Name = nameof(Instances), Description = "VariableInstance", IsRequired = false)]
        public List<Reference> Instances { get; set; }
        public int? InstancesCount { get; set; }


        [ApiMember(Name = nameof(Name), Description = "string", IsRequired = true)]
        public string Name { get; set; }


        [ApiMember(Name = nameof(Owner), Description = "VariableRule", IsRequired = false)]
        public Reference Owner { get; set; }
        [ApiMember(Name = nameof(OwnerId), Description = "Primary Key of VariableRule", IsRequired = false)]
        public int? OwnerId { get; set; }


        [ApiMember(Name = nameof(Rule), Description = "LookupTable", IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {@"Study Edit",@"Author Error",@"Inversion",@"Aggregation",@"Customization",@"Normalization",@"Correction",@"Addition"})]
        public Reference Rule { get; set; }
        [ApiMember(Name = nameof(RuleId), Description = "Primary Key of LookupTable", IsRequired = false)]
        public int? RuleId { get; set; }


        [ApiMember(Name = nameof(Scopes), Description = "Scope", IsRequired = false)]
        public List<Reference> Scopes { get; set; }
        public int? ScopesCount { get; set; }


        [ApiMember(Name = nameof(Type), Description = "LookupTable", IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {@"Template",@"Applied",@"Override"})]
        public Reference Type { get; set; }
        [ApiMember(Name = nameof(TypeId), Description = "Primary Key of LookupTable", IsRequired = false)]
        public int? TypeId { get; set; }


    }

    [Route("/variablerule", "POST")]
    [Route("/profile/variablerule", "POST")]
    [Route("/variablerule/{Id}", "GET, PATCH, PUT, DELETE")]
    [Route("/profile/variablerule/{Id}", "GET, PATCH, PUT, DELETE")]
    public partial class VariableRule : VariableRuleBase, IReturn<VariableRule>, IDto
    {
        public VariableRule()
        {
            _Constructor();
        }

        public VariableRule(int? id) : base(DocConvert.ToInt(id)) {}
        public VariableRule(int id) : base(id) {}
        
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
        public static List<string> Fields => _fields ?? (_fields = DocTools.Fields<VariableRule>());

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Children),nameof(ChildrenCount),nameof(Created),nameof(CreatorId),nameof(Definition),nameof(Gestalt),nameof(Instances),nameof(InstancesCount),nameof(Locked),nameof(Name),nameof(Owner),nameof(OwnerId),nameof(Rule),nameof(RuleId),nameof(Scopes),nameof(ScopesCount),nameof(Type),nameof(TypeId),nameof(Updated),nameof(VersionNo)})]
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
                _VisibleFields = DocPermissionFactory.SetVisibleFields<VariableRule>("VariableRule",exists);
            }
        }

        #endregion Fields
        private List<string> _collections = new List<string>
        {
            nameof(Children), nameof(ChildrenCount), nameof(Instances), nameof(InstancesCount), nameof(Scopes), nameof(ScopesCount)
        };
        private List<string> collections { get { return _collections; } }
    }
    
    [Route("/VariableRule/{Id}/copy", "POST")]
    [Route("/profile/VariableRule/{Id}/copy", "POST")]
    public partial class VariableRuleCopy : VariableRule {}
    [Route("/variablerule", "GET")]
    [Route("/profile/variablerule", "GET")]
    [Route("/variablerule/search", "GET, POST, DELETE")]
    [Route("/profile/variablerule/search", "GET, POST, DELETE")]
    public partial class VariableRuleSearch : Search<VariableRule>
    {
        public List<int> ChildrenIds { get; set; }
        public string Definition { get; set; }
        public List<int> InstancesIds { get; set; }
        public string Name { get; set; }
        public Reference Owner { get; set; }
        public List<int> OwnerIds { get; set; }
        public Reference Rule { get; set; }
        public List<int> RuleIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"Study Edit",@"Author Error",@"Inversion",@"Aggregation",@"Customization",@"Normalization",@"Correction",@"Addition"})]
        public List<string> RuleNames { get; set; }
        public List<int> ScopesIds { get; set; }
        public Reference Type { get; set; }
        public List<int> TypeIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"Template",@"Applied",@"Override"})]
        public List<string> TypeNames { get; set; }
    }
    
    public class VariableRuleFullTextSearch
    {
        private VariableRuleSearch _request;
        public VariableRuleFullTextSearch(VariableRuleSearch request) => _request = request;
        
        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(VariableRule.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(VariableRule.Updated))); }
        
        public bool doChildren { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(VariableRule.Children))); }
        public bool doDefinition { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(VariableRule.Definition))); }
        public bool doInstances { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(VariableRule.Instances))); }
        public bool doName { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(VariableRule.Name))); }
        public bool doOwner { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(VariableRule.Owner))); }
        public bool doRule { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(VariableRule.Rule))); }
        public bool doScopes { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(VariableRule.Scopes))); }
        public bool doType { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(VariableRule.Type))); }
    }

    [Route("/variablerule/version", "GET, POST")]
    public partial class VariableRuleVersion : VariableRuleSearch {}

    [Route("/variablerule/batch", "DELETE, PATCH, POST, PUT")]
    [Route("/profile/variablerule/batch", "DELETE, PATCH, POST, PUT")]
    public partial class VariableRuleBatch : List<VariableRule> { }

    [Route("/variablerule/{Id}/variablerule", "GET, POST, DELETE")]
    [Route("/profile/variablerule/{Id}/variablerule", "GET, POST, DELETE")]
    [Route("/variablerule/{Id}/variableinstance", "GET, POST, DELETE")]
    [Route("/profile/variablerule/{Id}/variableinstance", "GET, POST, DELETE")]
    [Route("/variablerule/{Id}/scope", "GET, POST, DELETE")]
    [Route("/profile/variablerule/{Id}/scope", "GET, POST, DELETE")]
    public class VariableRuleJunction : Search<VariableRule>
    {
        public int? Id { get; set; }
        public List<int> Ids { get; set; }
        public List<string> VisibleFields { get; set; }
        public bool ShouldSerializeVisibleFields()
        {
            { return false; }
        }


        public VariableRuleJunction(int id, List<int> ids)
        {
            this.Id = id;
            this.Ids = ids;
        }
    }


    [Route("/variablerule/{Id}/variablerule/version", "GET")]
    [Route("/profile/variablerule/{Id}/variablerule/version", "GET")]
    [Route("/variablerule/{Id}/variableinstance/version", "GET")]
    [Route("/profile/variablerule/{Id}/variableinstance/version", "GET")]
    [Route("/variablerule/{Id}/scope/version", "GET")]
    [Route("/profile/variablerule/{Id}/scope/version", "GET")]
    public class VariableRuleJunctionVersion : IReturn<Version>
    {
        public int? Id { get; set; }
        public List<int> Ids { get; set; }
        public List<string> VisibleFields { get; set; }
        public bool ShouldSerializeVisibleFields()
        {
            { return false; }
        }
    }
    [Route("/admin/variablerule/ids", "GET, POST")]
    public class VariableRuleIds
    {
        public bool All { get; set; }
    }
}