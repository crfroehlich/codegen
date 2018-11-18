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
    public abstract partial class DocumentSetHistoryBase : Dto<DocumentSetHistory>
    {
        public DocumentSetHistoryBase() {}

        public DocumentSetHistoryBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public DocumentSetHistoryBase(int? id) : this(DocConvert.ToInt(id)) {}
    
        [ApiMember(Name = nameof(DocumentSet), Description = "DocumentSet", IsRequired = true)]
        public Reference DocumentSet { get; set; }
        [ApiMember(Name = nameof(DocumentSetId), Description = "Primary Key of DocumentSet", IsRequired = false)]
        public int? DocumentSetId { get; set; }


        [ApiMember(Name = nameof(EvidencePortalID), Description = "int?", IsRequired = false)]
        public int? EvidencePortalID { get; set; }


        [ApiMember(Name = nameof(FqId), Description = "int?", IsRequired = false)]
        public int? FqId { get; set; }


        [ApiMember(Name = nameof(StudyCount), Description = "int?", IsRequired = false)]
        public int? StudyCount { get; set; }


        [ApiMember(Name = nameof(StudyCountFQ), Description = "int?", IsRequired = false)]
        public int? StudyCountFQ { get; set; }


    }

    [Route("/documentsethistory/{Id}", "GET")]
    [Route("/profile/documentsethistory/{Id}", "GET")]
    public partial class DocumentSetHistory : DocumentSetHistoryBase, IReturn<DocumentSetHistory>, IDto
    {
        public DocumentSetHistory()
        {
            _Constructor();
        }

        public DocumentSetHistory(int? id) : base(DocConvert.ToInt(id)) {}
        public DocumentSetHistory(int id) : base(id) {}
        
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
        public static List<string> Fields => _fields ?? (_fields = DocTools.Fields<DocumentSetHistory>());

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Created),nameof(CreatorId),nameof(DocumentSet),nameof(DocumentSetId),nameof(EvidencePortalID),nameof(FqId),nameof(Gestalt),nameof(Locked),nameof(StudyCount),nameof(StudyCountFQ),nameof(Updated),nameof(VersionNo)})]
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
                _VisibleFields = DocPermissionFactory.SetVisibleFields<DocumentSetHistory>("DocumentSetHistory",exists);
            }
        }

        #endregion Fields
    }
    
    [Route("/documentsethistory", "GET")]
    [Route("/profile/documentsethistory", "GET")]
    [Route("/documentsethistory/search", "GET, POST, DELETE")]
    [Route("/profile/documentsethistory/search", "GET, POST, DELETE")]
    public partial class DocumentSetHistorySearch : Search<DocumentSetHistory>
    {
        public Reference DocumentSet { get; set; }
        public List<int> DocumentSetIds { get; set; }
        public int? EvidencePortalID { get; set; }
        public int? FqId { get; set; }
        public int? StudyCount { get; set; }
        public int? StudyCountFQ { get; set; }
    }
    
    public class DocumentSetHistoryFullTextSearch
    {
        private DocumentSetHistorySearch _request;
        public DocumentSetHistoryFullTextSearch(DocumentSetHistorySearch request) => _request = request;
        
        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DocumentSetHistory.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DocumentSetHistory.Updated))); }
        
        public bool doDocumentSet { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DocumentSetHistory.DocumentSet))); }
        public bool doEvidencePortalID { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DocumentSetHistory.EvidencePortalID))); }
        public bool doFqId { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DocumentSetHistory.FqId))); }
        public bool doStudyCount { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DocumentSetHistory.StudyCount))); }
        public bool doStudyCountFQ { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DocumentSetHistory.StudyCountFQ))); }
    }

    [Route("/documentsethistory/version", "GET, POST")]
    public partial class DocumentSetHistoryVersion : DocumentSetHistorySearch {}

    [Route("/documentsethistory/batch", "DELETE, PATCH, POST, PUT")]
    [Route("/profile/documentsethistory/batch", "DELETE, PATCH, POST, PUT")]
    public partial class DocumentSetHistoryBatch : List<DocumentSetHistory> { }

}