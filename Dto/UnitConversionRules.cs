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
    public abstract partial class UnitConversionRulesBase : Dto<UnitConversionRules>
    {
        public UnitConversionRulesBase() {}

        public UnitConversionRulesBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public UnitConversionRulesBase(int? id) : this(DocConvert.ToInt(id)) {}

        public UnitConversionRulesBase(int? pId, Reference pDestinationUnit, int? pDestinationUnitId, bool pIsDefault, bool pIsDestinationSi, Reference pModifierTerm, int? pModifierTermId, decimal pMultiplier, Reference pParent, int? pParentId, Reference pRootTerm, int? pRootTermId, Reference pSourceUnit, int? pSourceUnitId) : this(DocConvert.ToInt(pId)) 
        {
            DestinationUnit = pDestinationUnit;
            DestinationUnitId = pDestinationUnitId;
            IsDefault = pIsDefault;
            IsDestinationSi = pIsDestinationSi;
            ModifierTerm = pModifierTerm;
            ModifierTermId = pModifierTermId;
            Multiplier = pMultiplier;
            Parent = pParent;
            ParentId = pParentId;
            RootTerm = pRootTerm;
            RootTermId = pRootTermId;
            SourceUnit = pSourceUnit;
            SourceUnitId = pSourceUnitId;
        }

        [ApiMember(Name = nameof(DestinationUnit), Description = "UnitOfMeasure", IsRequired = true)]
        public Reference DestinationUnit { get; set; }
        [ApiMember(Name = nameof(DestinationUnitId), Description = "Primary Key of UnitOfMeasure", IsRequired = false)]
        public int? DestinationUnitId { get; set; }


        [ApiMember(Name = nameof(IsDefault), Description = "bool", IsRequired = false)]
        public bool IsDefault { get; set; }


        [ApiMember(Name = nameof(IsDestinationSi), Description = "bool", IsRequired = false)]
        public bool IsDestinationSi { get; set; }


        [ApiMember(Name = nameof(ModifierTerm), Description = "TermMaster", IsRequired = false)]
        public Reference ModifierTerm { get; set; }
        [ApiMember(Name = nameof(ModifierTermId), Description = "Primary Key of TermMaster", IsRequired = false)]
        public int? ModifierTermId { get; set; }


        [ApiMember(Name = nameof(Multiplier), Description = "decimal", IsRequired = true)]
        public decimal Multiplier { get; set; }


        [ApiMember(Name = nameof(Parent), Description = "LookupTable", IsRequired = false)]
        public Reference Parent { get; set; }
        [ApiMember(Name = nameof(ParentId), Description = "Primary Key of LookupTable", IsRequired = false)]
        public int? ParentId { get; set; }


        [ApiMember(Name = nameof(RootTerm), Description = "TermMaster", IsRequired = false)]
        public Reference RootTerm { get; set; }
        [ApiMember(Name = nameof(RootTermId), Description = "Primary Key of TermMaster", IsRequired = false)]
        public int? RootTermId { get; set; }


        [ApiMember(Name = nameof(SourceUnit), Description = "UnitOfMeasure", IsRequired = true)]
        public Reference SourceUnit { get; set; }
        [ApiMember(Name = nameof(SourceUnitId), Description = "Primary Key of UnitOfMeasure", IsRequired = false)]
        public int? SourceUnitId { get; set; }



        public void Deconstruct(out Reference pDestinationUnit, out int? pDestinationUnitId, out bool pIsDefault, out bool pIsDestinationSi, out Reference pModifierTerm, out int? pModifierTermId, out decimal pMultiplier, out Reference pParent, out int? pParentId, out Reference pRootTerm, out int? pRootTermId, out Reference pSourceUnit, out int? pSourceUnitId)
        {
            pDestinationUnit = DestinationUnit;
            pDestinationUnitId = DestinationUnitId;
            pIsDefault = IsDefault;
            pIsDestinationSi = IsDestinationSi;
            pModifierTerm = ModifierTerm;
            pModifierTermId = ModifierTermId;
            pMultiplier = Multiplier;
            pParent = Parent;
            pParentId = ParentId;
            pRootTerm = RootTerm;
            pRootTermId = RootTermId;
            pSourceUnit = SourceUnit;
            pSourceUnitId = SourceUnitId;
        }

        //Not ready until C# v8.?
        //public UnitConversionRulesBase With(int? pId = Id, Reference pDestinationUnit = DestinationUnit, int? pDestinationUnitId = DestinationUnitId, bool pIsDefault = IsDefault, bool pIsDestinationSi = IsDestinationSi, Reference pModifierTerm = ModifierTerm, int? pModifierTermId = ModifierTermId, decimal pMultiplier = Multiplier, Reference pParent = Parent, int? pParentId = ParentId, Reference pRootTerm = RootTerm, int? pRootTermId = RootTermId, Reference pSourceUnit = SourceUnit, int? pSourceUnitId = SourceUnitId) => 
        //	new UnitConversionRulesBase(pId, pDestinationUnit, pDestinationUnitId, pIsDefault, pIsDestinationSi, pModifierTerm, pModifierTermId, pMultiplier, pParent, pParentId, pRootTerm, pRootTermId, pSourceUnit, pSourceUnitId);

    }

    [Route("/unitconversionrules", "POST")]
    [Route("/unitconversionrules/{Id}", "GET, PATCH, PUT, DELETE")]
    public partial class UnitConversionRules : UnitConversionRulesBase, IReturn<UnitConversionRules>, IDto, ICloneable
    {
        public UnitConversionRules()
        {
            _Constructor();
        }

        public UnitConversionRules(int? id) : base(DocConvert.ToInt(id)) {}
        public UnitConversionRules(int id) : base(id) {}
        public UnitConversionRules(int? pId, Reference pDestinationUnit, int? pDestinationUnitId, bool pIsDefault, bool pIsDestinationSi, Reference pModifierTerm, int? pModifierTermId, decimal pMultiplier, Reference pParent, int? pParentId, Reference pRootTerm, int? pRootTermId, Reference pSourceUnit, int? pSourceUnitId) : 
            base(pId, pDestinationUnit, pDestinationUnitId, pIsDefault, pIsDestinationSi, pModifierTerm, pModifierTermId, pMultiplier, pParent, pParentId, pRootTerm, pRootTermId, pSourceUnit, pSourceUnitId) { }
        #region Fields

        public new bool? ShouldSerialize(string field)
        {
            //Allow individual classes to specify their own logic
            var manualOverride = _ShouldSerialize(field);
            if(null != manualOverride) return manualOverride;

            if (IgnoredSelect.Matches(field, true)) return false;
            var ret = MandatorySelect.Matches(field, true) || true == Select?.Matches(field, true);
            return ret;
        }

        public static List<string> Fields => DocTools.Fields<UnitConversionRules>();

        private List<string> _Select;
        [ApiMember(Name = "Select", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Created),nameof(CreatorId),nameof(DestinationUnit),nameof(DestinationUnitId),nameof(Gestalt),nameof(IsDefault),nameof(IsDestinationSi),nameof(Locked),nameof(ModifierTerm),nameof(ModifierTermId),nameof(Multiplier),nameof(Parent),nameof(ParentId),nameof(RootTerm),nameof(RootTermId),nameof(SourceUnit),nameof(SourceUnitId),nameof(Updated),nameof(VersionNo)})]
        public new List<string> Select
        {
            get
            {
                if(null == this) return new List<string>();
                if(null == _Select)
                {
                    _Select = DocPermissionFactory.RemoveNonEssentialFields(Fields);
                }
                return _Select;
            }
            set
            {
                _Select = Fields;
            }
        }

        #endregion Fields

        public object Clone() => this.Copy<UnitConversionRules>();
    }
    
    [Route("/unitconversionrules/{Id}/copy", "POST")]
    public partial class UnitConversionRulesCopy : UnitConversionRules {}
    public partial class UnitConversionRulesSearchBase : Search<UnitConversionRules>
    {
        public int? Id { get; set; }
        public Reference DestinationUnit { get; set; }
        public List<int> DestinationUnitIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> IsDefault { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> IsDestinationSi { get; set; }
        public Reference ModifierTerm { get; set; }
        public List<int> ModifierTermIds { get; set; }
        public decimal? Multiplier { get; set; }
        public Reference Parent { get; set; }
        public List<int> ParentIds { get; set; }
        public List<string> ParentNames { get; set; }
        public Reference RootTerm { get; set; }
        public List<int> RootTermIds { get; set; }
        public Reference SourceUnit { get; set; }
        public List<int> SourceUnitIds { get; set; }
    }

    [Route("/unitconversionrules", "GET")]
    [Route("/unitconversionrules/version", "GET, POST")]
    [Route("/unitconversionrules/search", "GET, POST, DELETE")]
    public partial class UnitConversionRulesSearch : UnitConversionRulesSearchBase
    {
    }

    public class UnitConversionRulesFullTextSearch
    {
        public UnitConversionRulesFullTextSearch() {}
        private UnitConversionRulesSearch _request;
        public UnitConversionRulesFullTextSearch(UnitConversionRulesSearch request) => _request = request;

        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(UnitConversionRules.Created))); }
        public bool doUpdated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(UnitConversionRules.Updated))); }

        public bool doDestinationUnit { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(UnitConversionRules.DestinationUnit))); }
        public bool doIsDefault { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(UnitConversionRules.IsDefault))); }
        public bool doIsDestinationSi { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(UnitConversionRules.IsDestinationSi))); }
        public bool doModifierTerm { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(UnitConversionRules.ModifierTerm))); }
        public bool doMultiplier { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(UnitConversionRules.Multiplier))); }
        public bool doParent { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(UnitConversionRules.Parent))); }
        public bool doRootTerm { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(UnitConversionRules.RootTerm))); }
        public bool doSourceUnit { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(UnitConversionRules.SourceUnit))); }
    }

    [Route("/unitconversionrules/batch", "DELETE, PATCH, POST, PUT")]
    public partial class UnitConversionRulesBatch : List<UnitConversionRules> { }

}
