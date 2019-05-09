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
    public abstract partial class BackgroundTaskBase : Dto<BackgroundTask>
    {
        public BackgroundTaskBase() {}

        public BackgroundTaskBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public BackgroundTaskBase(int? id) : this(DocConvert.ToInt(id)) {}

        public BackgroundTaskBase(int? pId, Reference pApp, int? pAppId, Reference pChannel, int? pChannelId, string pDescription, bool pEnabled, int? pFrequency, int? pHistoryRetention, List<Reference> pItems, int? pItemsCount, string pLastRunVersion, bool pLogError, bool pLogInfo, string pName, int? pRowsToProcessPerIteration, bool pRunNow, string pStartAt, List<Reference> pTaskHistory, int? pTaskHistoryCount) : this(DocConvert.ToInt(pId)) 
        {
            App = pApp;
            AppId = pAppId;
            Channel = pChannel;
            ChannelId = pChannelId;
            Description = pDescription;
            Enabled = pEnabled;
            Frequency = pFrequency;
            HistoryRetention = pHistoryRetention;
            Items = pItems;
            ItemsCount = pItemsCount;
            LastRunVersion = pLastRunVersion;
            LogError = pLogError;
            LogInfo = pLogInfo;
            Name = pName;
            RowsToProcessPerIteration = pRowsToProcessPerIteration;
            RunNow = pRunNow;
            StartAt = pStartAt;
            TaskHistory = pTaskHistory;
            TaskHistoryCount = pTaskHistoryCount;
        }

        [ApiMember(Name = nameof(App), Description = "App", IsRequired = true)]
        public Reference App { get; set; }
        [ApiMember(Name = nameof(AppId), Description = "Primary Key of App", IsRequired = false)]
        public int? AppId { get; set; }


        [ApiMember(Name = nameof(Channel), Description = "QueueChannel", IsRequired = false)]
        public Reference Channel { get; set; }
        [ApiMember(Name = nameof(ChannelId), Description = "Primary Key of QueueChannel", IsRequired = false)]
        public int? ChannelId { get; set; }


        [ApiMember(Name = nameof(Description), Description = "string", IsRequired = false)]
        public string Description { get; set; }


        [ApiMember(Name = nameof(Enabled), Description = "bool", IsRequired = false)]
        public bool Enabled { get; set; }


        [ApiMember(Name = nameof(Frequency), Description = "int?", IsRequired = false)]
        public int? Frequency { get; set; }


        [ApiMember(Name = nameof(HistoryRetention), Description = "int?", IsRequired = false)]
        public int? HistoryRetention { get; set; }


        [ApiMember(Name = nameof(Items), Description = "BackgroundTaskItem", IsRequired = false)]
        public List<Reference> Items { get; set; }
        public int? ItemsCount { get; set; }


        [ApiMember(Name = nameof(LastRunVersion), Description = "string", IsRequired = false)]
        public string LastRunVersion { get; set; }


        [ApiMember(Name = nameof(LogError), Description = "bool", IsRequired = false)]
        public bool LogError { get; set; }


        [ApiMember(Name = nameof(LogInfo), Description = "bool", IsRequired = false)]
        public bool LogInfo { get; set; }


        [ApiMember(Name = nameof(Name), Description = "string", IsRequired = true)]
        public string Name { get; set; }


        [ApiMember(Name = nameof(RowsToProcessPerIteration), Description = "int?", IsRequired = false)]
        public int? RowsToProcessPerIteration { get; set; }


        [ApiMember(Name = nameof(RunNow), Description = "bool", IsRequired = false)]
        public bool RunNow { get; set; }


        [ApiMember(Name = nameof(StartAt), Description = "string", IsRequired = false)]
        public string StartAt { get; set; }


        [ApiMember(Name = nameof(TaskHistory), Description = "BackgroundTaskHistory", IsRequired = false)]
        public List<Reference> TaskHistory { get; set; }
        public int? TaskHistoryCount { get; set; }



        public void Deconstruct(out Reference pApp, out int? pAppId, out Reference pChannel, out int? pChannelId, out string pDescription, out bool pEnabled, out int? pFrequency, out int? pHistoryRetention, out List<Reference> pItems, out int? pItemsCount, out string pLastRunVersion, out bool pLogError, out bool pLogInfo, out string pName, out int? pRowsToProcessPerIteration, out bool pRunNow, out string pStartAt, out List<Reference> pTaskHistory, out int? pTaskHistoryCount)
        {
            pApp = App;
            pAppId = AppId;
            pChannel = Channel;
            pChannelId = ChannelId;
            pDescription = Description;
            pEnabled = Enabled;
            pFrequency = Frequency;
            pHistoryRetention = HistoryRetention;
            pItems = Items;
            pItemsCount = ItemsCount;
            pLastRunVersion = LastRunVersion;
            pLogError = LogError;
            pLogInfo = LogInfo;
            pName = Name;
            pRowsToProcessPerIteration = RowsToProcessPerIteration;
            pRunNow = RunNow;
            pStartAt = StartAt;
            pTaskHistory = TaskHistory;
            pTaskHistoryCount = TaskHistoryCount;
        }

        //Not ready until C# v8.?
        //public BackgroundTaskBase With(int? pId = Id, Reference pApp = App, int? pAppId = AppId, Reference pChannel = Channel, int? pChannelId = ChannelId, string pDescription = Description, bool pEnabled = Enabled, int? pFrequency = Frequency, int? pHistoryRetention = HistoryRetention, List<Reference> pItems = Items, int? pItemsCount = ItemsCount, string pLastRunVersion = LastRunVersion, bool pLogError = LogError, bool pLogInfo = LogInfo, string pName = Name, int? pRowsToProcessPerIteration = RowsToProcessPerIteration, bool pRunNow = RunNow, string pStartAt = StartAt, List<Reference> pTaskHistory = TaskHistory, int? pTaskHistoryCount = TaskHistoryCount) => 
        //	new BackgroundTaskBase(pId, pApp, pAppId, pChannel, pChannelId, pDescription, pEnabled, pFrequency, pHistoryRetention, pItems, pItemsCount, pLastRunVersion, pLogError, pLogInfo, pName, pRowsToProcessPerIteration, pRunNow, pStartAt, pTaskHistory, pTaskHistoryCount);

    }

    [Route("/backgroundtask/{Id}", "GET, PATCH, PUT")]
    public partial class BackgroundTask : BackgroundTaskBase, IReturn<BackgroundTask>, IDto, ICloneable
    {
        public BackgroundTask()
        {
            _Constructor();
        }

        public BackgroundTask(int? id) : base(DocConvert.ToInt(id)) {}
        public BackgroundTask(int id) : base(id) {}
        public BackgroundTask(int? pId, Reference pApp, int? pAppId, Reference pChannel, int? pChannelId, string pDescription, bool pEnabled, int? pFrequency, int? pHistoryRetention, List<Reference> pItems, int? pItemsCount, string pLastRunVersion, bool pLogError, bool pLogInfo, string pName, int? pRowsToProcessPerIteration, bool pRunNow, string pStartAt, List<Reference> pTaskHistory, int? pTaskHistoryCount) : 
            base(pId, pApp, pAppId, pChannel, pChannelId, pDescription, pEnabled, pFrequency, pHistoryRetention, pItems, pItemsCount, pLastRunVersion, pLogError, pLogInfo, pName, pRowsToProcessPerIteration, pRunNow, pStartAt, pTaskHistory, pTaskHistoryCount) { }
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

        public static List<string> Fields => DocTools.Fields<BackgroundTask>();

        private List<string> _Select;
        [ApiMember(Name = "Select", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(App),nameof(AppId),nameof(Channel),nameof(ChannelId),nameof(Created),nameof(CreatorId),nameof(Description),nameof(Enabled),nameof(Frequency),nameof(Gestalt),nameof(HistoryRetention),nameof(Items),nameof(ItemsCount),nameof(LastRunVersion),nameof(Locked),nameof(LogError),nameof(LogInfo),nameof(Name),nameof(RowsToProcessPerIteration),nameof(RunNow),nameof(StartAt),nameof(TaskHistory),nameof(TaskHistoryCount),nameof(Updated),nameof(VersionNo)})]
        public new List<string> Select
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
                _Select = DocPermissionFactory.SetSelect<BackgroundTask>("BackgroundTask",exists);
            }
        }

        #endregion Fields
        private List<string> _collections = new List<string>
        {
            nameof(Items), nameof(ItemsCount), nameof(TaskHistory), nameof(TaskHistoryCount)
        };
        private List<string> collections { get { return _collections; } }

        public object Clone() => this.Copy<BackgroundTask>();
    }
    
    public partial class BackgroundTaskSearchBase : Search<BackgroundTask>
    {
        public int? Id { get; set; }
        public Reference App { get; set; }
        public List<int> AppIds { get; set; }
        public Reference Channel { get; set; }
        public List<int> ChannelIds { get; set; }
        public string Description { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> Enabled { get; set; }
        public int? Frequency { get; set; }
        public int? HistoryRetention { get; set; }
        public List<int> ItemsIds { get; set; }
        public string LastRunVersion { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> LogError { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> LogInfo { get; set; }
        public string Name { get; set; }
        public int? RowsToProcessPerIteration { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> RunNow { get; set; }
        public string StartAt { get; set; }
        public List<int> TaskHistoryIds { get; set; }
    }

    [Route("/backgroundtask", "GET")]
    [Route("/backgroundtask/version", "GET, POST")]
    [Route("/backgroundtask/search", "GET, POST, DELETE")]
    public partial class BackgroundTaskSearch : BackgroundTaskSearchBase
    {
    }

    public class BackgroundTaskFullTextSearch
    {
        public BackgroundTaskFullTextSearch() {}
        private BackgroundTaskSearch _request;
        public BackgroundTaskFullTextSearch(BackgroundTaskSearch request) => _request = request;

        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(BackgroundTask.Created))); }
        public bool doUpdated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(BackgroundTask.Updated))); }

        public bool doApp { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(BackgroundTask.App))); }
        public bool doChannel { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(BackgroundTask.Channel))); }
        public bool doDescription { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(BackgroundTask.Description))); }
        public bool doEnabled { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(BackgroundTask.Enabled))); }
        public bool doFrequency { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(BackgroundTask.Frequency))); }
        public bool doHistoryRetention { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(BackgroundTask.HistoryRetention))); }
        public bool doItems { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(BackgroundTask.Items))); }
        public bool doLastRunVersion { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(BackgroundTask.LastRunVersion))); }
        public bool doLogError { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(BackgroundTask.LogError))); }
        public bool doLogInfo { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(BackgroundTask.LogInfo))); }
        public bool doName { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(BackgroundTask.Name))); }
        public bool doRowsToProcessPerIteration { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(BackgroundTask.RowsToProcessPerIteration))); }
        public bool doRunNow { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(BackgroundTask.RunNow))); }
        public bool doStartAt { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(BackgroundTask.StartAt))); }
        public bool doTaskHistory { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(BackgroundTask.TaskHistory))); }
    }

    [Route("/backgroundtask/batch", "DELETE, PATCH, POST, PUT")]
    public partial class BackgroundTaskBatch : List<BackgroundTask> { }

    [Route("/backgroundtask/{Id}/{Junction}/version", "GET, POST")]
    [Route("/backgroundtask/{Id}/{Junction}", "GET, POST, DELETE")]
    public class BackgroundTaskJunction : BackgroundTaskSearchBase {}


}
