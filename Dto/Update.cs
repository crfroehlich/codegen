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
    public abstract partial class UpdateBase : Dto<Update>
    {
        public UpdateBase() {}

        public UpdateBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public UpdateBase(int? id) : this(DocConvert.ToInt(id)) {}

        [ApiMember(Name = nameof(Body), Description = "string", IsRequired = false)]
        public string Body { get; set; }


        [ApiMember(Name = nameof(DeliveryStatus), Description = "string", IsRequired = false)]
        public string DeliveryStatus { get; set; }


        [ApiMember(Name = nameof(EmailAttempts), Description = "int?", IsRequired = false)]
        public int? EmailAttempts { get; set; }


        [ApiMember(Name = nameof(EmailSent), Description = "DateTime?", IsRequired = false)]
        public DateTime? EmailSent { get; set; }


        [ApiMember(Name = nameof(Events), Description = "Event", IsRequired = false)]
        public List<Reference> Events { get; set; }
        public int? EventsCount { get; set; }


        [ApiMember(Name = nameof(Link), Description = "string", IsRequired = false)]
        public string Link { get; set; }


        [ApiMember(Name = nameof(Priority), Description = "int?", IsRequired = false)]
        public int? Priority { get; set; }


        [ApiMember(Name = nameof(Read), Description = "DateTime?", IsRequired = false)]
        public DateTime? Read { get; set; }


        [ApiMember(Name = nameof(SlackSent), Description = "DateTime?", IsRequired = false)]
        public DateTime? SlackSent { get; set; }


        [ApiMember(Name = nameof(Subject), Description = "string", IsRequired = false)]
        public string Subject { get; set; }


        [ApiMember(Name = nameof(Team), Description = "Team", IsRequired = false)]
        public Reference Team { get; set; }
        [ApiMember(Name = nameof(TeamId), Description = "Primary Key of Team", IsRequired = false)]
        public int? TeamId { get; set; }


        [ApiMember(Name = nameof(User), Description = "User", IsRequired = false)]
        public Reference User { get; set; }
        [ApiMember(Name = nameof(UserId), Description = "Primary Key of User", IsRequired = false)]
        public int? UserId { get; set; }


    }

    [Route("/update/{Id}", "GET, PATCH")]
    public partial class Update : UpdateBase, IReturn<Update>, IDto
    {
        public Update()
        {
            _Constructor();
        }

        public Update(int? id) : base(DocConvert.ToInt(id)) {}
        public Update(int id) : base(id) {}
        
        #region Fields
        
        public bool? ShouldSerialize(string field)
        {
            if (IgnoredVisibleFields.Matches(field, true)) return false;
            var ret = MandatoryVisibleFields.Matches(field, true) || true == VisibleFields?.Matches(field, true);
            return ret;
        }

        public static List<string> Fields => DocTools.Fields<Update>();

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Body),nameof(Created),nameof(CreatorId),nameof(DeliveryStatus),nameof(EmailAttempts),nameof(EmailSent),nameof(Events),nameof(EventsCount),nameof(Gestalt),nameof(Link),nameof(Locked),nameof(Priority),nameof(Read),nameof(SlackSent),nameof(Subject),nameof(Team),nameof(TeamId),nameof(Updated),nameof(User),nameof(UserId),nameof(VersionNo)})]
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
                _VisibleFields = DocPermissionFactory.SetVisibleFields<Update>("Update",exists);
            }
        }

        #endregion Fields
        private List<string> _collections = new List<string>
        {
            nameof(Events), nameof(EventsCount)
        };
        private List<string> collections { get { return _collections; } }
    }
    
    public partial class UpdateSearchBase : Search<Update>
    {
        public int? Id { get; set; }
        public string Body { get; set; }
        public string DeliveryStatus { get; set; }
        public int? EmailAttempts { get; set; }
        public DateTime? EmailSent { get; set; }
        public DateTime? EmailSentAfter { get; set; }
        public DateTime? EmailSentBefore { get; set; }
        public List<int> EventsIds { get; set; }
        public string Link { get; set; }
        public int? Priority { get; set; }
        public DateTime? Read { get; set; }
        public DateTime? ReadAfter { get; set; }
        public DateTime? ReadBefore { get; set; }
        public DateTime? SlackSent { get; set; }
        public DateTime? SlackSentAfter { get; set; }
        public DateTime? SlackSentBefore { get; set; }
        public string Subject { get; set; }
        public Reference Team { get; set; }
        public List<int> TeamIds { get; set; }
        public Reference User { get; set; }
        public List<int> UserIds { get; set; }
    }

    [Route("/update", "GET")]
    [Route("/update/version", "GET, POST")]
    [Route("/update/search", "GET, POST, DELETE")]
    public partial class UpdateSearch : UpdateSearchBase
    {
    }

    public class UpdateFullTextSearch
    {
        public UpdateFullTextSearch() {}
        private UpdateSearch _request;
        public UpdateFullTextSearch(UpdateSearch request) => _request = request;

        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Update.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Update.Updated))); }

        public bool doBody { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Update.Body))); }
        public bool doDeliveryStatus { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Update.DeliveryStatus))); }
        public bool doEmailAttempts { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Update.EmailAttempts))); }
        public bool doEmailSent { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Update.EmailSent))); }
        public bool doEvents { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Update.Events))); }
        public bool doLink { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Update.Link))); }
        public bool doPriority { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Update.Priority))); }
        public bool doRead { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Update.Read))); }
        public bool doSlackSent { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Update.SlackSent))); }
        public bool doSubject { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Update.Subject))); }
        public bool doTeam { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Update.Team))); }
        public bool doUser { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Update.User))); }
    }

    [Route("/update/batch", "DELETE, PATCH, POST, PUT")]
    public partial class UpdateBatch : List<Update> { }

    [Route("/update/{Id}/{Junction}/version", "GET, POST")]
    [Route("/update/{Id}/{Junction}", "GET, POST, DELETE")]
    public class UpdateJunction : UpdateSearchBase {}


}
