//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated by a T4 template. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when the code is regenerated.
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
    public abstract partial class QueueChannelBase : Dto<QueueChannel>
    {
        public QueueChannelBase() {}

        public QueueChannelBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public QueueChannelBase(int? id) : this(DocConvert.ToInt(id)) {}

        [ApiMember(Name = nameof(AutoDelete), Description = "bool", IsRequired = false)]
        public bool AutoDelete { get; set; }


        [ApiMember(Name = nameof(BackgroundTask), Description = "BackgroundTask", IsRequired = false)]
        public Reference BackgroundTask { get; set; }
        [ApiMember(Name = nameof(BackgroundTaskId), Description = "Primary Key of BackgroundTask", IsRequired = false)]
        public int? BackgroundTaskId { get; set; }


        [ApiMember(Name = nameof(Description), Description = "string", IsRequired = false)]
        public string Description { get; set; }


        [ApiMember(Name = nameof(Durable), Description = "bool", IsRequired = false)]
        public bool Durable { get; set; }


        [ApiMember(Name = nameof(Enabled), Description = "bool", IsRequired = false)]
        public bool Enabled { get; set; }


        [ApiMember(Name = nameof(Exclusive), Description = "bool", IsRequired = false)]
        public bool Exclusive { get; set; }


        [ApiMember(Name = nameof(Name), Description = "string", IsRequired = true)]
        public string Name { get; set; }


    }

    [Route("/queuechannel", "POST")]
    [Route("/queuechannel/{Id}", "GET, PATCH, PUT, DELETE")]
    public partial class QueueChannel : QueueChannelBase, IReturn<QueueChannel>, IDto
    {
        public QueueChannel()
        {
            _Constructor();
        }

        public QueueChannel(int? id) : base(DocConvert.ToInt(id)) {}
        public QueueChannel(int id) : base(id) {}
        
        #region Fields
        
        public bool? ShouldSerialize(string field)
        {
            if (IgnoredVisibleFields.Matches(field, true)) return false;
            var ret = MandatoryVisibleFields.Matches(field, true) || true == VisibleFields?.Matches(field, true);
            return ret;
        }

        public static List<string> Fields => DocTools.Fields<QueueChannel>();

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(AutoDelete),nameof(BackgroundTask),nameof(BackgroundTaskId),nameof(Created),nameof(CreatorId),nameof(Description),nameof(Durable),nameof(Enabled),nameof(Exclusive),nameof(Gestalt),nameof(Locked),nameof(Name),nameof(Updated),nameof(VersionNo)})]
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
                _VisibleFields = DocPermissionFactory.SetVisibleFields<QueueChannel>("QueueChannel",exists);
            }
        }

        #endregion Fields
    }
    
    [Route("/QueueChannel/{Id}/copy", "POST")]
    public partial class QueueChannelCopy : QueueChannel {}
    public partial class QueueChannelSearchBase : Search<QueueChannel>
    {
        public int? Id { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> AutoDelete { get; set; }
        public Reference BackgroundTask { get; set; }
        public List<int> BackgroundTaskIds { get; set; }
        public string Description { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> Durable { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> Enabled { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> Exclusive { get; set; }
        public string Name { get; set; }
    }

    [Route("/queuechannel", "GET")]
    [Route("/queuechannel/version", "GET, POST")]
    [Route("/queuechannel/search", "GET, POST, DELETE")]
    public partial class QueueChannelSearch : QueueChannelSearchBase
    {
    }

    public class QueueChannelFullTextSearch
    {
        public QueueChannelFullTextSearch() {}
        private QueueChannelSearch _request;
        public QueueChannelFullTextSearch(QueueChannelSearch request) => _request = request;

        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(QueueChannel.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(QueueChannel.Updated))); }

        public bool doAutoDelete { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(QueueChannel.AutoDelete))); }
        public bool doBackgroundTask { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(QueueChannel.BackgroundTask))); }
        public bool doDescription { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(QueueChannel.Description))); }
        public bool doDurable { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(QueueChannel.Durable))); }
        public bool doEnabled { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(QueueChannel.Enabled))); }
        public bool doExclusive { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(QueueChannel.Exclusive))); }
        public bool doName { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(QueueChannel.Name))); }
    }

    [Route("/queuechannel/batch", "DELETE, PATCH, POST, PUT")]
    public partial class QueueChannelBatch : List<QueueChannel> { }

}
