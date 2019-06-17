//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated by a T4 template. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;

using Services.Core;
using Services.Dto.internals;
using Services.Enums;

using ServiceStack;
using ServiceStack.Text;

using Typed;
using Typed.Notifications;
using Typed.Bindings;

using Xtensive.Orm;


namespace Services.Dto
{
    public abstract partial class VariableRuleBase : Dto<VariableRule>
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public VariableRuleBase() {}

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public VariableRuleBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public VariableRuleBase(int? id) : this(DocConvert.ToInt(id)) {}

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public VariableRuleBase(int? pId, List<Reference> pChildren, int? pChildrenCount, string pDefinition, List<Reference> pInstances, int? pInstancesCount, string pName, Reference pOwner, int? pOwnerId, Reference pRule, int? pRuleId, List<Reference> pScopes, int? pScopesCount, Reference pType, int? pType_Id) : this(DocConvert.ToInt(pId)) 
        {
            Children = pChildren;
            ChildrenCount = pChildrenCount;
            Definition = pDefinition;
            Instances = pInstances;
            InstancesCount = pInstancesCount;
            Name = pName;
            Owner = pOwner;
            OwnerId = pOwnerId;
            Rule = pRule;
            RuleId = pRuleId;
            Scopes = pScopes;
            ScopesCount = pScopesCount;
            Type = pType;
            Type_Id = pType_Id;
        }

        [ApiMember(Name = nameof(Children), Description = "VariableRule", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<Reference> Children { get; set; }
        [ApiMember(Name = nameof(ChildrenIds), Description = "VariableRule Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> ChildrenIds { get; set; }
        [ApiMember(Name = nameof(ChildrenCount), Description = "VariableRule Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? ChildrenCount { get; set; }

        [ApiMember(Name = nameof(Definition), Description = "string", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string Definition { get; set; }
        [ApiMember(Name = nameof(DefinitionIds), Description = "Definition Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> DefinitionIds { get; set; }
        [ApiMember(Name = nameof(DefinitionCount), Description = "Definition Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? DefinitionCount { get; set; }

        [ApiMember(Name = nameof(Instances), Description = "VariableInstance", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<Reference> Instances { get; set; }
        [ApiMember(Name = nameof(InstancesIds), Description = "VariableInstance Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> InstancesIds { get; set; }
        [ApiMember(Name = nameof(InstancesCount), Description = "VariableInstance Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? InstancesCount { get; set; }

        [ApiMember(Name = nameof(Name), Description = "string", IsRequired = true)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string Name { get; set; }
        [ApiMember(Name = nameof(NameIds), Description = "Name Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> NameIds { get; set; }
        [ApiMember(Name = nameof(NameCount), Description = "Name Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? NameCount { get; set; }

        [ApiMember(Name = nameof(Owner), Description = "VariableRule", IsRequired = false)]
[GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Reference Owner { get; set; }
        [ApiMember(Name = nameof(OwnerId), Description = "Primary Key of VariableRule", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? OwnerId { get; set; }

        [ApiAllowableValues("Includes", Values = new string[] {@"Addition",@"Aggregation",@"Author Error",@"Correction",@"Customization",@"Inversion",@"Normalization",@"Study Edit"})]
        [ApiMember(Name = nameof(Rule), Description = "LookupTable", IsRequired = true)]
[GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Reference Rule { get; set; }
        [ApiMember(Name = nameof(RuleId), Description = "Primary Key of LookupTable", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? RuleId { get; set; }

        [ApiMember(Name = nameof(Scopes), Description = "Scope", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<Reference> Scopes { get; set; }
        [ApiMember(Name = nameof(ScopesIds), Description = "Scope Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> ScopesIds { get; set; }
        [ApiMember(Name = nameof(ScopesCount), Description = "Scope Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? ScopesCount { get; set; }

        [ApiAllowableValues("Includes", Values = new string[] {@"Applied",@"Override",@"Template"})]
        [ApiMember(Name = nameof(Type), Description = "LookupTable", IsRequired = true)]
[GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Reference Type { get; set; }
        [ApiMember(Name = nameof(Type_Id), Description = "Primary Key of LookupTable", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? Type_Id { get; set; }



        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public void Deconstruct(out List<Reference> pChildren, out int? pChildrenCount, out string pDefinition, out List<Reference> pInstances, out int? pInstancesCount, out string pName, out Reference pOwner, out int? pOwnerId, out Reference pRule, out int? pRuleId, out List<Reference> pScopes, out int? pScopesCount, out Reference pType, out int? pType_Id)
        {
            pChildren = Children;
            pChildrenCount = ChildrenCount;
            pDefinition = Definition;
            pInstances = Instances;
            pInstancesCount = InstancesCount;
            pName = Name;
            pOwner = Owner;
            pOwnerId = OwnerId;
            pRule = Rule;
            pRuleId = RuleId;
            pScopes = Scopes;
            pScopesCount = ScopesCount;
            pType = Type;
            pType_Id = Type_Id;
        }

        //Not ready until C# v8.?
        //[GeneratedCodeAttribute("T4", "1.0.0.0")]
        //public VariableRuleBase With(int? pId = Id, List<Reference> pChildren = Children, int? pChildrenCount = ChildrenCount, string pDefinition = Definition, List<Reference> pInstances = Instances, int? pInstancesCount = InstancesCount, string pName = Name, Reference pOwner = Owner, int? pOwnerId = OwnerId, Reference pRule = Rule, int? pRuleId = RuleId, List<Reference> pScopes = Scopes, int? pScopesCount = ScopesCount, Reference pType = Type, int? pType_Id = Type_Id) => 
        //	new VariableRuleBase(pId, pChildren, pChildrenCount, pDefinition, pInstances, pInstancesCount, pName, pOwner, pOwnerId, pRule, pRuleId, pScopes, pScopesCount, pType, pType_Id);

    }


    [Route("/variablerule", "POST")]
    [Route("/variablerule/{Id}", "GET, PATCH, PUT, DELETE")]

    public partial class VariableRule : VariableRuleBase, IReturn<VariableRule>, IDto, ICloneable
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public VariableRule() => _Constructor();
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public VariableRule(int? id) : base(DocConvert.ToInt(id)) {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public VariableRule(int id) : base(id) {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public VariableRule(int? pId, List<Reference> pChildren, int? pChildrenCount, string pDefinition, List<Reference> pInstances, int? pInstancesCount, string pName, Reference pOwner, int? pOwnerId, Reference pRule, int? pRuleId, List<Reference> pScopes, int? pScopesCount, Reference pType, int? pType_Id) :
            base(pId, pChildren, pChildrenCount, pDefinition, pInstances, pInstancesCount, pName, pOwner, pOwnerId, pRule, pRuleId, pScopes, pScopesCount, pType, pType_Id) { }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static List<string> Fields => DocTools.Fields<VariableRule>();

        private List<string> _Select;
        [ApiMember(Name = nameof(Select), Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Children),nameof(ChildrenCount),nameof(Created),nameof(CreatorId),nameof(Definition),nameof(Gestalt),nameof(Instances),nameof(InstancesCount),nameof(Locked),nameof(Name),nameof(Owner),nameof(OwnerId),nameof(Rule),nameof(RuleId),nameof(Scopes),nameof(ScopesCount),nameof(Type),nameof(Type_Id),nameof(Updated),nameof(VersionNo)})]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override List<string> Select
        {
            get
            {
                if(null == this) return new List<string>();
                if(null == _Select)
                {

                    _Select = DocWebSession.GetTypeSelect(this);

                }
                return _Select;
            }
            set
            {

                var requested = value ?? new List<string>();
                var exists = requested.Where( r => Fields.Any( f => DocTools.AreEqual(r, f) ) ).ToList();
                _Select = DocPermissionFactory.SetSelect<VariableRule>("VariableRule",exists);

            }
        }

        [Obsolete, ApiMember(Name = "VisibleFields", Description = "Deprecated. Use Select instead.", AllowMultiple = true)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override List<string> VisibleFields { get => Select; set => Select = value; }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private List<string> _collections = new List<string>
        {
            nameof(Children), nameof(ChildrenCount), nameof(ChildrenIds), nameof(Instances), nameof(InstancesCount), nameof(InstancesIds), nameof(Scopes), nameof(ScopesCount), nameof(ScopesIds)
        };
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private List<string> collections { get { return _collections; } }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Clone() => this.Copy<VariableRule>();

    }
    

    [Route("/variablerule/{Id}/copy", "POST")]
    public partial class VariableRuleCopy : VariableRule {}

    public partial class VariableRuleSearchBase : Search<VariableRule>
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? Id { get; set; }
        public List<int> ChildrenIds { get; set; }
        public string Definition { get; set; }
        public List<string> Definitions { get; set; }
        public List<int> InstancesIds { get; set; }
        public string Name { get; set; }
        public List<string> Names { get; set; }
        public Reference Owner { get; set; }
        public List<int> OwnerIds { get; set; }
        public Reference Rule { get; set; }
        public List<int> RuleIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"Addition",@"Aggregation",@"Author Error",@"Correction",@"Customization",@"Inversion",@"Normalization",@"Study Edit"})]
        public List<string> RuleNames { get; set; }
        public List<int> ScopesIds { get; set; }
        public Reference Type { get; set; }
        public List<int> TypeIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"Applied",@"Override",@"Template"})]
        public List<string> TypeNames { get; set; }
    }


    [Route("/variablerule", "GET")]
    [Route("/variablerule/version", "GET, POST")]
    [Route("/variablerule/search", "GET, POST, DELETE")]

    public partial class VariableRuleSearch : VariableRuleSearchBase
    {
    }

    public class VariableRuleFullTextSearch
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public VariableRuleFullTextSearch() {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private VariableRuleSearch _request;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public VariableRuleFullTextSearch(VariableRuleSearch request) => _request = request;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool doCreated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(VariableRule.Created))); }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool doUpdated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(VariableRule.Updated))); }

        public bool doChildren { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(VariableRule.Children))); }
        public bool doDefinition { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(VariableRule.Definition))); }
        public bool doInstances { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(VariableRule.Instances))); }
        public bool doName { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(VariableRule.Name))); }
        public bool doOwner { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(VariableRule.Owner))); }
        public bool doRule { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(VariableRule.Rule))); }
        public bool doScopes { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(VariableRule.Scopes))); }
        public bool doType { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(VariableRule.Type))); }
    }


    [Route("/variablerule/batch", "DELETE, PATCH, POST, PUT")]

    public partial class VariableRuleBatch : List<VariableRule> { }


    [Route("/variablerule/{Id}/{Junction}/version", "GET, POST")]
    [Route("/variablerule/{Id}/{Junction}", "GET, POST, DELETE")]
    public class VariableRuleJunction : VariableRuleSearchBase {}



}
