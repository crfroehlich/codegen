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
    public abstract partial class TimeCardBase : Dto<TimeCard>
    {
        public TimeCardBase() {}

        public TimeCardBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public TimeCardBase(int? id) : this(DocConvert.ToInt(id)) {}
    
        [ApiMember(Name = nameof(Description), Description = "string", IsRequired = false)]
        public string Description { get; set; }


        [ApiMember(Name = nameof(Document), Description = "Document", IsRequired = false)]
        public Reference Document { get; set; }
        [ApiMember(Name = nameof(DocumentId), Description = "Primary Key of Document", IsRequired = false)]
        public int? DocumentId { get; set; }


        [ApiMember(Name = nameof(End), Description = "DateTime?", IsRequired = true)]
        public DateTime? End { get; set; }


        [ApiMember(Name = nameof(Project), Description = "Project", IsRequired = false)]
        public Reference Project { get; set; }
        [ApiMember(Name = nameof(ProjectId), Description = "Primary Key of Project", IsRequired = false)]
        public int? ProjectId { get; set; }


        [ApiMember(Name = nameof(ReferenceId), Description = "int?", IsRequired = false)]
        public int? ReferenceId { get; set; }


        [ApiMember(Name = nameof(Start), Description = "DateTime?", IsRequired = true)]
        public DateTime? Start { get; set; }


        [ApiMember(Name = nameof(Status), Description = "LookupTable", IsRequired = false)]
        [ApiAllowableValues("Includes", Values = new string[] {@"Pending",@"Approved",@"Rejected"})]
        public Reference Status { get; set; }
        [ApiMember(Name = nameof(StatusId), Description = "Primary Key of LookupTable", IsRequired = false)]
        public int? StatusId { get; set; }


        [ApiMember(Name = nameof(User), Description = "User", IsRequired = true)]
        public Reference User { get; set; }
        [ApiMember(Name = nameof(UserId), Description = "Primary Key of User", IsRequired = false)]
        public int? UserId { get; set; }


        [ApiMember(Name = nameof(WorkType), Description = "LookupTable", IsRequired = false)]
        public Reference WorkType { get; set; }
        [ApiMember(Name = nameof(WorkTypeId), Description = "Primary Key of LookupTable", IsRequired = false)]
        public int? WorkTypeId { get; set; }


    }

    [Route("/timecard", "POST")]
    [Route("/timecard/{Id}", "GET, PATCH, PUT, DELETE")]
    public partial class TimeCard : TimeCardBase, IReturn<TimeCard>, IDto
    {
        public TimeCard()
        {
            _Constructor();
        }

        public TimeCard(int? id) : base(DocConvert.ToInt(id)) {}
        public TimeCard(int id) : base(id) {}
        
        #region Fields
        
        public bool? ShouldSerialize(string field)
        {
            if (IgnoredVisibleFields.Matches(field, true)) return false;
            var ret = MandatoryVisibleFields.Matches(field, true) || true == VisibleFields?.Matches(field, true);
            return ret;
        }

        public static List<string> Fields => DocTools.Fields<TimeCard>();

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Created),nameof(CreatorId),nameof(Description),nameof(Document),nameof(DocumentId),nameof(End),nameof(Gestalt),nameof(Locked),nameof(Project),nameof(ProjectId),nameof(ReferenceId),nameof(Start),nameof(Status),nameof(StatusId),nameof(Updated),nameof(User),nameof(UserId),nameof(VersionNo),nameof(WorkType),nameof(WorkTypeId)})]
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
                _VisibleFields = DocPermissionFactory.SetVisibleFields<TimeCard>("TimeCard",exists);
            }
        }

        #endregion Fields
    }
    
    [Route("/TimeCard/{Id}/copy", "POST")]
    public partial class TimeCardCopy : TimeCard {}
    [Route("/timecard", "GET")]
    [Route("/timecard/search", "GET, POST, DELETE")]
    public partial class TimeCardSearch : Search<TimeCard>
    {
        public string Description { get; set; }
        public Reference Document { get; set; }
        public List<int> DocumentIds { get; set; }
        public DateTime? End { get; set; }
        public DateTime? EndAfter { get; set; }
        public DateTime? EndBefore { get; set; }
        public Reference Project { get; set; }
        public List<int> ProjectIds { get; set; }
        public int? ReferenceId { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? StartAfter { get; set; }
        public DateTime? StartBefore { get; set; }
        public Reference Status { get; set; }
        public List<int> StatusIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"Pending",@"Approved",@"Rejected"})]
        public List<string> StatusNames { get; set; }
        public Reference User { get; set; }
        public List<int> UserIds { get; set; }
        public Reference WorkType { get; set; }
        public List<int> WorkTypeIds { get; set; }
        public List<string> WorkTypeNames { get; set; }
    }
    
    public class TimeCardFullTextSearch
    {
        private TimeCardSearch _request;
        public TimeCardFullTextSearch(TimeCardSearch request) => _request = request;
        
        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(TimeCard.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(TimeCard.Updated))); }
        
        public bool doDescription { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(TimeCard.Description))); }
        public bool doDocument { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(TimeCard.Document))); }
        public bool doEnd { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(TimeCard.End))); }
        public bool doProject { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(TimeCard.Project))); }
        public bool doReferenceId { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(TimeCard.ReferenceId))); }
        public bool doStart { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(TimeCard.Start))); }
        public bool doStatus { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(TimeCard.Status))); }
        public bool doUser { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(TimeCard.User))); }
        public bool doWorkType { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(TimeCard.WorkType))); }
    }

    [Route("/timecard/version", "GET, POST")]
    public partial class TimeCardVersion : TimeCardSearch {}

    [Route("/timecard/batch", "DELETE, PATCH, POST, PUT")]
    public partial class TimeCardBatch : List<TimeCard> { }

    [Route("/admin/timecard/ids", "GET, POST")]
    public class TimeCardIds
    {
        public bool All { get; set; }
    }
}