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
    public abstract partial class BackgroundTaskHistoryBase : Dto<BackgroundTaskHistory>
    {
        public BackgroundTaskHistoryBase() {}

        public BackgroundTaskHistoryBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public BackgroundTaskHistoryBase(int? id) : this(DocConvert.ToInt(id)) {}
    
        [ApiMember(Name = nameof(Completed), Description = "int?", IsRequired = false)]
        public int? Completed { get; set; }


        [ApiMember(Name = nameof(Data), Description = "string", IsRequired = false)]
        public string Data { get; set; }


        [ApiMember(Name = nameof(Ended), Description = "DateTime?", IsRequired = false)]
        public DateTime? Ended { get; set; }


        [ApiMember(Name = nameof(Errors), Description = "string", IsRequired = false)]
        public string Errors { get; set; }


        [ApiMember(Name = nameof(Failed), Description = "int?", IsRequired = false)]
        public int? Failed { get; set; }


        [ApiMember(Name = nameof(Items), Description = "BackgroundTaskItem", IsRequired = false)]
        public List<Reference> Items { get; set; }
        public int? ItemsCount { get; set; }


        [ApiMember(Name = nameof(Logs), Description = "string", IsRequired = false)]
        public string Logs { get; set; }


        [ApiMember(Name = nameof(Succeeded), Description = "bool?", IsRequired = false)]
        public bool? Succeeded { get; set; }


        [ApiMember(Name = nameof(Summary), Description = "string", IsRequired = false)]
        public string Summary { get; set; }


        [ApiMember(Name = nameof(Task), Description = "BackgroundTask", IsRequired = true)]
        public Reference Task { get; set; }
        [ApiMember(Name = nameof(TaskId), Description = "Primary Key of BackgroundTask", IsRequired = false)]
        public int? TaskId { get; set; }


    }

    [Route("/backgroundtaskhistory/{Id}", "GET")]
    public partial class BackgroundTaskHistory : BackgroundTaskHistoryBase, IReturn<BackgroundTaskHistory>, IDto
    {
        public BackgroundTaskHistory()
        {
            _Constructor();
        }

        public BackgroundTaskHistory(int? id) : base(DocConvert.ToInt(id)) {}
        public BackgroundTaskHistory(int id) : base(id) {}
        
        #region Fields
        
        public bool? ShouldSerialize(string field)
        {
            if (IgnoredVisibleFields.Matches(field, true)) return false;
            var ret = MandatoryVisibleFields.Matches(field, true) || true == VisibleFields?.Matches(field, true);
            return ret;
        }

        public static List<string> Fields => DocTools.Fields<BackgroundTaskHistory>();

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Completed),nameof(Created),nameof(CreatorId),nameof(Data),nameof(Ended),nameof(Errors),nameof(Failed),nameof(Gestalt),nameof(Items),nameof(ItemsCount),nameof(Locked),nameof(Logs),nameof(Succeeded),nameof(Summary),nameof(Task),nameof(TaskId),nameof(Updated),nameof(VersionNo)})]
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
                _VisibleFields = DocPermissionFactory.SetVisibleFields<BackgroundTaskHistory>("BackgroundTaskHistory",exists);
            }
        }

        #endregion Fields
        private List<string> _collections = new List<string>
        {
            nameof(Items), nameof(ItemsCount)
        };
        private List<string> collections { get { return _collections; } }
    }
    
    public partial class BackgroundTaskHistorySearchBase : Search<BackgroundTaskHistory>
    {
        public int? Id { get; set; }
        public int? Completed { get; set; }
        public string Data { get; set; }
        public DateTime? Ended { get; set; }
        public DateTime? EndedAfter { get; set; }
        public DateTime? EndedBefore { get; set; }
        public string Errors { get; set; }
        public int? Failed { get; set; }
        public List<int> ItemsIds { get; set; }
        public string Logs { get; set; }
        public bool? Succeeded { get; set; }
        public string Summary { get; set; }
        public Reference Task { get; set; }
        public List<int> TaskIds { get; set; }
    }

    [Route("/backgroundtaskhistory", "GET")]
    [Route("/backgroundtaskhistory/version", "GET, POST")]
    [Route("/backgroundtaskhistory/search", "GET, POST, DELETE")]
    public partial class BackgroundTaskHistorySearch : BackgroundTaskHistorySearchBase
    {
    }

    public class BackgroundTaskHistoryFullTextSearch
    {
        public BackgroundTaskHistoryFullTextSearch() {}
        private BackgroundTaskHistorySearch _request;
        public BackgroundTaskHistoryFullTextSearch(BackgroundTaskHistorySearch request) => _request = request;
        
        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(BackgroundTaskHistory.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(BackgroundTaskHistory.Updated))); }
        
        public bool doCompleted { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(BackgroundTaskHistory.Completed))); }
        public bool doData { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(BackgroundTaskHistory.Data))); }
        public bool doEnded { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(BackgroundTaskHistory.Ended))); }
        public bool doErrors { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(BackgroundTaskHistory.Errors))); }
        public bool doFailed { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(BackgroundTaskHistory.Failed))); }
        public bool doItems { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(BackgroundTaskHistory.Items))); }
        public bool doLogs { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(BackgroundTaskHistory.Logs))); }
        public bool doSucceeded { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(BackgroundTaskHistory.Succeeded))); }
        public bool doSummary { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(BackgroundTaskHistory.Summary))); }
        public bool doTask { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(BackgroundTaskHistory.Task))); }
    }

    [Route("/backgroundtaskhistory/batch", "DELETE, PATCH, POST, PUT")]
    public partial class BackgroundTaskHistoryBatch : List<BackgroundTaskHistory> { }

    [Route("/backgroundtaskhistory/{Id}/{Junction}/version", "GET, POST")]
    [Route("/backgroundtaskhistory/{Id}/{Junction}", "GET, POST, DELETE")]
    public class BackgroundTaskHistoryJunction : BackgroundTaskHistorySearchBase {}


    [Route("/admin/backgroundtaskhistory/ids", "GET, POST")]
    public class BackgroundTaskHistoryIds
    {
        public bool All { get; set; }
    }
}