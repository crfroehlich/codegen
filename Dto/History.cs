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
using Services.Dto.internals;
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
    public abstract partial class HistoryBase : Dto<History>
    {
        public HistoryBase() {}

        public HistoryBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public HistoryBase(int? id) : this(DocConvert.ToInt(id)) {}
    
        [ApiMember(Name = nameof(App), Description = "App", IsRequired = false)]
        public Reference App { get; set; }
        [ApiMember(Name = nameof(AppId), Description = "Primary Key of App", IsRequired = false)]
        public int? AppId { get; set; }


        [ApiMember(Name = nameof(DocumentSet), Description = "DocumentSet", IsRequired = false)]
        public Reference DocumentSet { get; set; }
        [ApiMember(Name = nameof(DocumentSetId), Description = "Primary Key of DocumentSet", IsRequired = false)]
        public int? DocumentSetId { get; set; }


        [ApiMember(Name = nameof(Impersonation), Description = "Impersonation", IsRequired = false)]
        public Reference Impersonation { get; set; }
        [ApiMember(Name = nameof(ImpersonationId), Description = "Primary Key of Impersonation", IsRequired = false)]
        public int? ImpersonationId { get; set; }


        [ApiMember(Name = nameof(Page), Description = "Page", IsRequired = false)]
        public Reference Page { get; set; }
        [ApiMember(Name = nameof(PageId), Description = "Primary Key of Page", IsRequired = false)]
        public int? PageId { get; set; }


        [ApiMember(Name = nameof(URL), Description = "string", IsRequired = false)]
        public string URL { get; set; }


        [ApiMember(Name = nameof(User), Description = "User", IsRequired = true)]
        public Reference User { get; set; }
        [ApiMember(Name = nameof(UserId), Description = "Primary Key of User", IsRequired = false)]
        public int? UserId { get; set; }


        [ApiMember(Name = nameof(UserSession), Description = "UserSession", IsRequired = false)]
        public Reference UserSession { get; set; }
        [ApiMember(Name = nameof(UserSessionId), Description = "Primary Key of UserSession", IsRequired = false)]
        public int? UserSessionId { get; set; }


        [ApiMember(Name = nameof(Workflow), Description = "Workflow", IsRequired = false)]
        public Reference Workflow { get; set; }
        [ApiMember(Name = nameof(WorkflowId), Description = "Primary Key of Workflow", IsRequired = false)]
        public int? WorkflowId { get; set; }


    }

    [Route("/history", "POST")]
    [Route("/history/{Id}", "GET")]
    public partial class History : HistoryBase, IReturn<History>, IDto
    {
        public History()
        {
            _Constructor();
        }

        public History(int? id) : base(DocConvert.ToInt(id)) {}
        public History(int id) : base(id) {}
        
        #region Fields
        
        public bool? ShouldSerialize(string field)
        {
            if (IgnoredVisibleFields.Matches(field, true)) return false;
            var ret = MandatoryVisibleFields.Matches(field, true) || true == VisibleFields?.Matches(field, true);
            return ret;
        }

        public static List<string> Fields => DocTools.Fields<History>();

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(App),nameof(AppId),nameof(Created),nameof(CreatorId),nameof(DocumentSet),nameof(DocumentSetId),nameof(Gestalt),nameof(Impersonation),nameof(ImpersonationId),nameof(Locked),nameof(Page),nameof(PageId),nameof(Updated),nameof(URL),nameof(User),nameof(UserId),nameof(UserSession),nameof(UserSessionId),nameof(VersionNo),nameof(Workflow),nameof(WorkflowId)})]
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
                _VisibleFields = DocPermissionFactory.SetVisibleFields<History>("History",exists);
            }
        }

        #endregion Fields
    }
    
    [Route("/History/{Id}/copy", "POST")]
    public partial class HistoryCopy : History {}
    public partial class HistorySearchBase : Search<History>
    {
        public int? Id { get; set; }
        public Reference App { get; set; }
        public List<int> AppIds { get; set; }
        public Reference DocumentSet { get; set; }
        public List<int> DocumentSetIds { get; set; }
        public Reference Impersonation { get; set; }
        public List<int> ImpersonationIds { get; set; }
        public Reference Page { get; set; }
        public List<int> PageIds { get; set; }
        public string URL { get; set; }
        public Reference User { get; set; }
        public List<int> UserIds { get; set; }
        public Reference UserSession { get; set; }
        public List<int> UserSessionIds { get; set; }
        public Reference Workflow { get; set; }
        public List<int> WorkflowIds { get; set; }
    }

    [Route("/history", "GET")]
    [Route("/history/version", "GET, POST")]
    [Route("/history/search", "GET, POST, DELETE")]
    public partial class HistorySearch : HistorySearchBase
    {
    }

    public class HistoryFullTextSearch
    {
        public HistoryFullTextSearch() {}
        private HistorySearch _request;
        public HistoryFullTextSearch(HistorySearch request) => _request = request;
        
        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(History.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(History.Updated))); }
        
        public bool doApp { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(History.App))); }
        public bool doDocumentSet { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(History.DocumentSet))); }
        public bool doImpersonation { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(History.Impersonation))); }
        public bool doPage { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(History.Page))); }
        public bool doURL { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(History.URL))); }
        public bool doUser { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(History.User))); }
        public bool doUserSession { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(History.UserSession))); }
        public bool doWorkflow { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(History.Workflow))); }
    }

    [Route("/history/batch", "DELETE, PATCH, POST, PUT")]
    public partial class HistoryBatch : List<History> { }

}