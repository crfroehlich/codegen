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
    public abstract partial class UnitConversionRulesBase : Dto<UnitConversionRules>
    {
        public UnitConversionRulesBase() {}

        public UnitConversionRulesBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public UnitConversionRulesBase(int? id) : this(DocConvert.ToInt(id)) {}
    
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


    }

    [Route("/unitconversionrules", "POST")]
    [Route("/unitconversionrules/{Id}", "GET, PATCH, PUT, DELETE")]
    public partial class UnitConversionRules : UnitConversionRulesBase, IReturn<UnitConversionRules>, IDto
    {
        public UnitConversionRules()
        {
            _Constructor();
        }

        public UnitConversionRules(int? id) : base(DocConvert.ToInt(id)) {}
        public UnitConversionRules(int id) : base(id) {}
        
        #region Fields
        
        public bool? ShouldSerialize(string field)
        {
            if (IgnoredVisibleFields.Matches(field, true)) return false;
            var ret = MandatoryVisibleFields.Matches(field, true) || true == VisibleFields?.Matches(field, true);
            return ret;
        }

        public static List<string> Fields => DocTools.Fields<UnitConversionRules>();

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Created),nameof(CreatorId),nameof(DestinationUnit),nameof(DestinationUnitId),nameof(Gestalt),nameof(IsDefault),nameof(IsDestinationSi),nameof(Locked),nameof(ModifierTerm),nameof(ModifierTermId),nameof(Multiplier),nameof(Parent),nameof(ParentId),nameof(RootTerm),nameof(RootTermId),nameof(SourceUnit),nameof(SourceUnitId),nameof(Updated),nameof(VersionNo)})]
        public new List<string> VisibleFields
        {
            get
            {
                if(null == this) return new List<string>();
                if(null == _VisibleFields)
                {
                    _VisibleFields = DocPermissionFactory.RemoveNonEssentialFields(Fields);
                }
                return _VisibleFields;
            }
            set
            {
                _VisibleFields = Fields;
            }
        }

        #endregion Fields
    }
    
    [Route("/UnitConversionRules/{Id}/copy", "POST")]
    public partial class UnitConversionRulesCopy : UnitConversionRules {}
    [Route("/unitconversionrules", "GET")]
    [Route("/unitconversionrules/search", "GET, POST, DELETE")]
    public partial class UnitConversionRulesSearch : Search<UnitConversionRules>
    {
        public Reference DestinationUnit { get; set; }
        public List<int> DestinationUnitIds { get; set; }
        public bool? IsDefault { get; set; }
        public bool? IsDestinationSi { get; set; }
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
    
    public class UnitConversionRulesFullTextSearch
    {
        private UnitConversionRulesSearch _request;
        public UnitConversionRulesFullTextSearch(UnitConversionRulesSearch request) => _request = request;
        
        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(UnitConversionRules.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(UnitConversionRules.Updated))); }
        
        public bool doDestinationUnit { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(UnitConversionRules.DestinationUnit))); }
        public bool doIsDefault { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(UnitConversionRules.IsDefault))); }
        public bool doIsDestinationSi { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(UnitConversionRules.IsDestinationSi))); }
        public bool doModifierTerm { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(UnitConversionRules.ModifierTerm))); }
        public bool doMultiplier { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(UnitConversionRules.Multiplier))); }
        public bool doParent { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(UnitConversionRules.Parent))); }
        public bool doRootTerm { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(UnitConversionRules.RootTerm))); }
        public bool doSourceUnit { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(UnitConversionRules.SourceUnit))); }
    }

    [Route("/unitconversionrules/version", "GET, POST")]
    public partial class UnitConversionRulesVersion : UnitConversionRulesSearch {}

    [Route("/unitconversionrules/batch", "DELETE, PATCH, POST, PUT")]
    public partial class UnitConversionRulesBatch : List<UnitConversionRules> { }

    [Route("/admin/unitconversionrules/ids", "GET, POST")]
    public class UnitConversionRulesIds
    {
        public bool All { get; set; }
    }
}