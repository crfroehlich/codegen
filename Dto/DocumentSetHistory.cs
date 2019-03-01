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
            if (IgnoredVisibleFields.Matches(field, true)) return false;
            var ret = MandatoryVisibleFields.Matches(field, true) || true == VisibleFields?.Matches(field, true);
            return ret;
        }

        public static List<string> Fields => DocTools.Fields<DocumentSetHistory>();

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
    
    public partial class DocumentSetHistorySearchBase : Search<DocumentSetHistory>
    {
        public int? Id { get; set; }
        public Reference DocumentSet { get; set; }
        public List<int> DocumentSetIds { get; set; }
        public int? EvidencePortalID { get; set; }
        public int? FqId { get; set; }
        public int? StudyCount { get; set; }
        public int? StudyCountFQ { get; set; }
    }

    [Route("/documentsethistory", "GET")]
    [Route("/documentsethistory/version", "GET, POST")]
    [Route("/documentsethistory/search", "GET, POST, DELETE")]
    public partial class DocumentSetHistorySearch : DocumentSetHistorySearchBase
    {
    }

    public class DocumentSetHistoryFullTextSearch
    {
        public DocumentSetHistoryFullTextSearch() {}
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

    public partial class DocumentSetHistoryBatch : List<DocumentSetHistory> { }

}
