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
    public abstract partial class JctAttributeCategoryAttributeDocumentSetBase : Dto<JctAttributeCategoryAttributeDocumentSet>
    {
        public JctAttributeCategoryAttributeDocumentSetBase() {}

        public JctAttributeCategoryAttributeDocumentSetBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public JctAttributeCategoryAttributeDocumentSetBase(int? id) : this(DocConvert.ToInt(id)) {}
    
        [ApiMember(Name = nameof(Attribute), Description = "Attribute", IsRequired = true)]
        public Reference Attribute { get; set; }
        [ApiMember(Name = nameof(AttributeId), Description = "Primary Key of Attribute", IsRequired = false)]
        public int? AttributeId { get; set; }


        [ApiMember(Name = nameof(AttributeCategory), Description = "AttributeCategory", IsRequired = true)]
        public Reference AttributeCategory { get; set; }
        [ApiMember(Name = nameof(AttributeCategoryId), Description = "Primary Key of AttributeCategory", IsRequired = false)]
        public int? AttributeCategoryId { get; set; }


        [ApiMember(Name = nameof(DocumentSet), Description = "DocumentSet", IsRequired = true)]
        public Reference DocumentSet { get; set; }
        [ApiMember(Name = nameof(DocumentSetId), Description = "Primary Key of DocumentSet", IsRequired = false)]
        public int? DocumentSetId { get; set; }


    }

    [Route("/jctattributecategoryattributedocumentset", "POST")]
    [Route("/jctattributecategoryattributedocumentset/{Id}", "GET, PATCH, PUT, DELETE")]
    public partial class JctAttributeCategoryAttributeDocumentSet : JctAttributeCategoryAttributeDocumentSetBase, IReturn<JctAttributeCategoryAttributeDocumentSet>, IDto
    {
        public JctAttributeCategoryAttributeDocumentSet()
        {
            _Constructor();
        }

        public JctAttributeCategoryAttributeDocumentSet(int? id) : base(DocConvert.ToInt(id)) {}
        public JctAttributeCategoryAttributeDocumentSet(int id) : base(id) {}
        
        #region Fields
        
        public bool? ShouldSerialize(string field)
        {
            if (IgnoredVisibleFields.Matches(field, true)) return false;
            var ret = MandatoryVisibleFields.Matches(field, true) || true == VisibleFields?.Matches(field, true);
            return ret;
        }

        public static List<string> Fields => DocTools.Fields<JctAttributeCategoryAttributeDocumentSet>();

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Attribute),nameof(AttributeCategory),nameof(AttributeCategoryId),nameof(AttributeId),nameof(Created),nameof(CreatorId),nameof(DocumentSet),nameof(DocumentSetId),nameof(Gestalt),nameof(Locked),nameof(Updated),nameof(VersionNo)})]
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
    
    [Route("/JctAttributeCategoryAttributeDocumentSet/{Id}/copy", "POST")]
    public partial class JctAttributeCategoryAttributeDocumentSetCopy : JctAttributeCategoryAttributeDocumentSet {}
    [Route("/jctattributecategoryattributedocumentset", "GET")]
    [Route("/jctattributecategoryattributedocumentset/search", "GET, POST, DELETE")]
    public partial class JctAttributeCategoryAttributeDocumentSetSearch : Search<JctAttributeCategoryAttributeDocumentSet>
    {
        public Reference Attribute { get; set; }
        public List<int> AttributeIds { get; set; }
        public Reference AttributeCategory { get; set; }
        public List<int> AttributeCategoryIds { get; set; }
        public Reference DocumentSet { get; set; }
        public List<int> DocumentSetIds { get; set; }
    }
    
    public class JctAttributeCategoryAttributeDocumentSetFullTextSearch
    {
        private JctAttributeCategoryAttributeDocumentSetSearch _request;
        public JctAttributeCategoryAttributeDocumentSetFullTextSearch(JctAttributeCategoryAttributeDocumentSetSearch request) => _request = request;
        
        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(JctAttributeCategoryAttributeDocumentSet.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(JctAttributeCategoryAttributeDocumentSet.Updated))); }
        
        public bool doAttribute { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(JctAttributeCategoryAttributeDocumentSet.Attribute))); }
        public bool doAttributeCategory { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(JctAttributeCategoryAttributeDocumentSet.AttributeCategory))); }
        public bool doDocumentSet { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(JctAttributeCategoryAttributeDocumentSet.DocumentSet))); }
    }

    [Route("/jctattributecategoryattributedocumentset/version", "GET, POST")]
    public partial class JctAttributeCategoryAttributeDocumentSetVersion : JctAttributeCategoryAttributeDocumentSetSearch {}

    [Route("/jctattributecategoryattributedocumentset/batch", "DELETE, PATCH, POST, PUT")]
    public partial class JctAttributeCategoryAttributeDocumentSetBatch : List<JctAttributeCategoryAttributeDocumentSet> { }

    [Route("/admin/jctattributecategoryattributedocumentset/ids", "GET, POST")]
    public class JctAttributeCategoryAttributeDocumentSetIds
    {
        public bool All { get; set; }
    }
}