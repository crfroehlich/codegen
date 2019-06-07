
//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated by a T4 template. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
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
    public abstract partial class BackgroundTaskHistoryBase : Dto<BackgroundTaskHistory>
    {
        public BackgroundTaskHistoryBase() {}

        public BackgroundTaskHistoryBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public BackgroundTaskHistoryBase(int? id) : this(DocConvert.ToInt(id)) {}

        public BackgroundTaskHistoryBase(int? pId, int? pCompleted, string pData, DateTime? pEnded, string pErrors, int? pFailed, List<Reference> pItems, int? pItemsCount, string pLogs, bool? pSucceeded, string pSummary, Reference pTask, int? pTaskId) : this(DocConvert.ToInt(pId)) 
        {
            Completed = pCompleted;
            Data = pData;
            Ended = pEnded;
            Errors = pErrors;
            Failed = pFailed;
            Items = pItems;
            ItemsCount = pItemsCount;
            Logs = pLogs;
            Succeeded = pSucceeded;
            Summary = pSummary;
            Task = pTask;
            TaskId = pTaskId;
        }

        [ApiMember(Name = nameof(Completed), Description = "int?", IsRequired = false)]
        public int? Completed { get; set; }
        public List<int> CompletedIds { get; set; }
        public int? CompletedCount { get; set; }


        [ApiMember(Name = nameof(Data), Description = "string", IsRequired = false)]
        public string Data { get; set; }
        public List<int> DataIds { get; set; }
        public int? DataCount { get; set; }


        [ApiMember(Name = nameof(Ended), Description = "DateTime?", IsRequired = false)]
        public DateTime? Ended { get; set; }
        public List<int> EndedIds { get; set; }
        public int? EndedCount { get; set; }


        [ApiMember(Name = nameof(Errors), Description = "string", IsRequired = false)]
        public string Errors { get; set; }
        public List<int> ErrorsIds { get; set; }
        public int? ErrorsCount { get; set; }


        [ApiMember(Name = nameof(Failed), Description = "int?", IsRequired = false)]
        public int? Failed { get; set; }
        public List<int> FailedIds { get; set; }
        public int? FailedCount { get; set; }


        [ApiMember(Name = nameof(Items), Description = "BackgroundTaskItem", IsRequired = false)]
        public List<Reference> Items { get; set; }
        public List<int> ItemsIds { get; set; }
        public int? ItemsCount { get; set; }


        [ApiMember(Name = nameof(Logs), Description = "string", IsRequired = false)]
        public string Logs { get; set; }
        public List<int> LogsIds { get; set; }
        public int? LogsCount { get; set; }


        [ApiMember(Name = nameof(Succeeded), Description = "bool?", IsRequired = false)]
        public bool? Succeeded { get; set; }
        public List<int> SucceededIds { get; set; }
        public int? SucceededCount { get; set; }


        [ApiMember(Name = nameof(Summary), Description = "string", IsRequired = false)]
        public string Summary { get; set; }
        public List<int> SummaryIds { get; set; }
        public int? SummaryCount { get; set; }


        [ApiMember(Name = nameof(Task), Description = "BackgroundTask", IsRequired = true)]
        public Reference Task { get; set; }
        [ApiMember(Name = nameof(TaskId), Description = "Primary Key of BackgroundTask", IsRequired = false)]
        public int? TaskId { get; set; }



        public void Deconstruct(out int? pCompleted, out string pData, out DateTime? pEnded, out string pErrors, out int? pFailed, out List<Reference> pItems, out int? pItemsCount, out string pLogs, out bool? pSucceeded, out string pSummary, out Reference pTask, out int? pTaskId)
        {
            pCompleted = Completed;
            pData = Data;
            pEnded = Ended;
            pErrors = Errors;
            pFailed = Failed;
            pItems = Items;
            pItemsCount = ItemsCount;
            pLogs = Logs;
            pSucceeded = Succeeded;
            pSummary = Summary;
            pTask = Task;
            pTaskId = TaskId;
        }

        //Not ready until C# v8.?
        //public BackgroundTaskHistoryBase With(int? pId = Id, int? pCompleted = Completed, string pData = Data, DateTime? pEnded = Ended, string pErrors = Errors, int? pFailed = Failed, List<Reference> pItems = Items, int? pItemsCount = ItemsCount, string pLogs = Logs, bool? pSucceeded = Succeeded, string pSummary = Summary, Reference pTask = Task, int? pTaskId = TaskId) => 
        //	new BackgroundTaskHistoryBase(pId, pCompleted, pData, pEnded, pErrors, pFailed, pItems, pItemsCount, pLogs, pSucceeded, pSummary, pTask, pTaskId);

    }


    [Route("/backgroundtaskhistory/{Id}", "GET")]

    public partial class BackgroundTaskHistory : BackgroundTaskHistoryBase, IReturn<BackgroundTaskHistory>, IDto, ICloneable
    {
        public BackgroundTaskHistory() => _Constructor();

        public BackgroundTaskHistory(int? id) : base(DocConvert.ToInt(id)) {}
        public BackgroundTaskHistory(int id) : base(id) {}
        public BackgroundTaskHistory(int? pId, int? pCompleted, string pData, DateTime? pEnded, string pErrors, int? pFailed, List<Reference> pItems, int? pItemsCount, string pLogs, bool? pSucceeded, string pSummary, Reference pTask, int? pTaskId) :
            base(pId, pCompleted, pData, pEnded, pErrors, pFailed, pItems, pItemsCount, pLogs, pSucceeded, pSummary, pTask, pTaskId) { }

        public static List<string> Fields => DocTools.Fields<BackgroundTaskHistory>();

        private List<string> _Select;
        [ApiMember(Name = nameof(Select), Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Completed),nameof(Created),nameof(CreatorId),nameof(Data),nameof(Ended),nameof(Errors),nameof(Failed),nameof(Gestalt),nameof(Items),nameof(ItemsCount),nameof(Locked),nameof(Logs),nameof(Succeeded),nameof(Summary),nameof(Task),nameof(TaskId),nameof(Updated),nameof(VersionNo)})]
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
                _Select = DocPermissionFactory.SetSelect<BackgroundTaskHistory>("BackgroundTaskHistory",exists);

            }
        }

        [Obsolete, ApiMember(Name = nameof(VisibleFields), Description = "Deprecated. Use Select instead.", AllowMultiple = true)]
        public override List<string> VisibleFields { get => Select; set => Select = value; }


        private List<string> _collections = new List<string>
        {
            nameof(Items), nameof(ItemsCount), nameof(ItemsIds)
        };
        private List<string> collections { get { return _collections; } }


        public object Clone() => this.Copy<BackgroundTaskHistory>();

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
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false", "null"})]
        public List<bool?> Succeeded { get; set; }
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
        public bool doCreated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(BackgroundTaskHistory.Created))); }
        public bool doUpdated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(BackgroundTaskHistory.Updated))); }

        public bool doCompleted { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(BackgroundTaskHistory.Completed))); }
        public bool doData { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(BackgroundTaskHistory.Data))); }
        public bool doEnded { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(BackgroundTaskHistory.Ended))); }
        public bool doErrors { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(BackgroundTaskHistory.Errors))); }
        public bool doFailed { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(BackgroundTaskHistory.Failed))); }
        public bool doItems { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(BackgroundTaskHistory.Items))); }
        public bool doLogs { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(BackgroundTaskHistory.Logs))); }
        public bool doSucceeded { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(BackgroundTaskHistory.Succeeded))); }
        public bool doSummary { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(BackgroundTaskHistory.Summary))); }
        public bool doTask { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(BackgroundTaskHistory.Task))); }
    }


    public partial class BackgroundTaskHistoryBatch : List<BackgroundTaskHistory> { }


    [Route("/backgroundtaskhistory/{Id}/{Junction}/version", "GET, POST")]
    [Route("/backgroundtaskhistory/{Id}/{Junction}", "GET, POST, DELETE")]
    public class BackgroundTaskHistoryJunction : BackgroundTaskHistorySearchBase {}



}
