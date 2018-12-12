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
    public abstract partial class DocumentAttributeBase : Dto<DocumentAttribute>
    {
        public DocumentAttributeBase() {}

        public DocumentAttributeBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public DocumentAttributeBase(int? id) : this(DocConvert.ToInt(id)) {}
    
        [ApiMember(Name = nameof(Attribute), Description = "Attribute", IsRequired = true)]
        public Attribute Attribute { get; set; }
        [ApiMember(Name = nameof(AttributeId), Description = "Primary Key of Attribute", IsRequired = false)]
        public int? AttributeId { get; set; }


        [ApiMember(Name = nameof(Document), Description = "Document", IsRequired = true)]
        public Reference Document { get; set; }
        [ApiMember(Name = nameof(DocumentId), Description = "Primary Key of Document", IsRequired = false)]
        public int? DocumentId { get; set; }


    }

    [Route("/documentattribute", "POST")]
    [Route("/profile/documentattribute", "POST")]
    [Route("/documentattribute/{Id}", "GET, PATCH, PUT, DELETE")]
    [Route("/profile/documentattribute/{Id}", "GET, PATCH, PUT, DELETE")]
    public partial class DocumentAttribute : DocumentAttributeBase, IReturn<DocumentAttribute>, IDto
    {
        public DocumentAttribute()
        {
            _Constructor();
        }

        public DocumentAttribute(int? id) : base(DocConvert.ToInt(id)) {}
        public DocumentAttribute(int id) : base(id) {}
        
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
        public static List<string> Fields => _fields ?? (_fields = DocTools.Fields<DocumentAttribute>());

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Attribute),nameof(AttributeId),nameof(Created),nameof(CreatorId),nameof(Document),nameof(DocumentId),nameof(Gestalt),nameof(Locked),nameof(Updated),nameof(VersionNo)})]
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
    
    [Route("/DocumentAttribute/{Id}/copy", "POST")]
    [Route("/profile/DocumentAttribute/{Id}/copy", "POST")]
    public partial class DocumentAttributeCopy : DocumentAttribute {}
    [Route("/documentattribute", "GET")]
    [Route("/profile/documentattribute", "GET")]
    [Route("/documentattribute/search", "GET, POST, DELETE")]
    [Route("/profile/documentattribute/search", "GET, POST, DELETE")]
    public partial class DocumentAttributeSearch : Search<DocumentAttribute>
    {
        public Reference Attribute { get; set; }
        public List<int> AttributeIds { get; set; }
        public Reference Document { get; set; }
        public List<int> DocumentIds { get; set; }
    }
    
    public class DocumentAttributeFullTextSearch
    {
        private DocumentAttributeSearch _request;
        public DocumentAttributeFullTextSearch(DocumentAttributeSearch request) => _request = request;
        
        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DocumentAttribute.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DocumentAttribute.Updated))); }
        
        public bool doAttribute { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DocumentAttribute.Attribute))); }
        public bool doDocument { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DocumentAttribute.Document))); }
    }

    [Route("/documentattribute/version", "GET, POST")]
    public partial class DocumentAttributeVersion : DocumentAttributeSearch {}

    [Route("/documentattribute/batch", "DELETE, PATCH, POST, PUT")]
    [Route("/profile/documentattribute/batch", "DELETE, PATCH, POST, PUT")]
    public partial class DocumentAttributeBatch : List<DocumentAttribute> { }

    [Route("/admin/documentattribute/ids", "GET, POST")]
    public class DocumentAttributeIds
    {
        public bool All { get; set; }
    }
}