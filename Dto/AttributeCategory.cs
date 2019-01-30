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
    public abstract partial class AttributeCategoryBase : Dto<AttributeCategory>
    {
        public AttributeCategoryBase() {}

        public AttributeCategoryBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public AttributeCategoryBase(int? id) : this(DocConvert.ToInt(id)) {}
    
        [ApiMember(Name = nameof(DocumentSet), Description = "DocumentSet", IsRequired = false)]
        public Reference DocumentSet { get; set; }
        [ApiMember(Name = nameof(DocumentSetId), Description = "Primary Key of DocumentSet", IsRequired = false)]
        public int? DocumentSetId { get; set; }


        [ApiMember(Name = nameof(Name), Description = "LookupTable", IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {@"Adverse Event",@"Clinical Outcome",@"Laboratory Value/Diagnostic",@"Scales/Scores",@"Demographics",@"Medical History",@"Mortality",@"Withdrawal/Drug Discontinuation",@"Social History",@"Medications",@"Miscellaneous",@"Cost/Utilization"})]
        public Reference Name { get; set; }
        [ApiMember(Name = nameof(NameId), Description = "Primary Key of LookupTable", IsRequired = false)]
        public int? NameId { get; set; }


        [ApiMember(Name = nameof(ParentAttributeCategory), Description = "AttributeCategory", IsRequired = false)]
        public Reference ParentAttributeCategory { get; set; }
        [ApiMember(Name = nameof(ParentAttributeCategoryId), Description = "Primary Key of AttributeCategory", IsRequired = false)]
        public int? ParentAttributeCategoryId { get; set; }


    }

    [Route("/attributecategory", "POST")]
    [Route("/attributecategory/{Id}", "GET, PATCH, PUT, DELETE")]
    public partial class AttributeCategory : AttributeCategoryBase, IReturn<AttributeCategory>, IDto
    {
        public AttributeCategory()
        {
            _Constructor();
        }

        public AttributeCategory(int? id) : base(DocConvert.ToInt(id)) {}
        public AttributeCategory(int id) : base(id) {}
        
        #region Fields
        
        public bool? ShouldSerialize(string field)
        {
            if (IgnoredVisibleFields.Matches(field, true)) return false;
            var ret = MandatoryVisibleFields.Matches(field, true) || true == VisibleFields?.Matches(field, true);
            return ret;
        }

        public static List<string> Fields => DocTools.Fields<AttributeCategory>();

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Created),nameof(CreatorId),nameof(DocumentSet),nameof(DocumentSetId),nameof(Gestalt),nameof(Locked),nameof(Name),nameof(NameId),nameof(ParentAttributeCategory),nameof(ParentAttributeCategoryId),nameof(Updated),nameof(VersionNo)})]
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
    
    [Route("/AttributeCategory/{Id}/copy", "POST")]
    public partial class AttributeCategoryCopy : AttributeCategory {}
    public partial class AttributeCategorySearchBase : Search<AttributeCategory>
    {
        public int? Id { get; set; }
        public Reference DocumentSet { get; set; }
        public List<int> DocumentSetIds { get; set; }
        public Reference Name { get; set; }
        public List<int> NameIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"Adverse Event",@"Clinical Outcome",@"Laboratory Value/Diagnostic",@"Scales/Scores",@"Demographics",@"Medical History",@"Mortality",@"Withdrawal/Drug Discontinuation",@"Social History",@"Medications",@"Miscellaneous",@"Cost/Utilization"})]
        public List<string> NameNames { get; set; }
        public Reference ParentAttributeCategory { get; set; }
        public List<int> ParentAttributeCategoryIds { get; set; }
    }

    [Route("/attributecategory", "GET")]
    [Route("/attributecategory/version", "GET, POST")]
    [Route("/attributecategory/search", "GET, POST, DELETE")]
    public partial class AttributeCategorySearch : AttributeCategorySearchBase
    {
    }

    public class AttributeCategoryFullTextSearch
    {
        public AttributeCategoryFullTextSearch() {}
        private AttributeCategorySearch _request;
        public AttributeCategoryFullTextSearch(AttributeCategorySearch request) => _request = request;
        
        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(AttributeCategory.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(AttributeCategory.Updated))); }
        
        public bool doDocumentSet { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(AttributeCategory.DocumentSet))); }
        public bool doName { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(AttributeCategory.Name))); }
        public bool doParentAttributeCategory { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(AttributeCategory.ParentAttributeCategory))); }
    }

    [Route("/attributecategory/batch", "DELETE, PATCH, POST, PUT")]
    public partial class AttributeCategoryBatch : List<AttributeCategory> { }

    [Route("/admin/attributecategory/ids", "GET, POST")]
    public class AttributeCategoryIds
    {
        public bool All { get; set; }
    }
}