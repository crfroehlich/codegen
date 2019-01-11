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
    public abstract partial class IntervalBase : Dto<Interval>
    {
        public IntervalBase() {}

        public IntervalBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public IntervalBase(int? id) : this(DocConvert.ToInt(id)) {}
    
        [ApiMember(Name = nameof(CalendarDateEnd), Description = "DateTime", IsRequired = false)]
        public DateTimeDto CalendarDateEnd { get; set; }
        [ApiMember(Name = nameof(CalendarDateEndId), Description = "Primary Key of DateTime", IsRequired = false)]
        public int? CalendarDateEndId { get; set; }


        [ApiMember(Name = nameof(CalendarDateStart), Description = "DateTime", IsRequired = false)]
        public DateTimeDto CalendarDateStart { get; set; }
        [ApiMember(Name = nameof(CalendarDateStartId), Description = "Primary Key of DateTime", IsRequired = false)]
        public int? CalendarDateStartId { get; set; }


        [ApiMember(Name = nameof(CalendarType), Description = "string", IsRequired = false)]
        public string CalendarType { get; set; }


        [ApiMember(Name = nameof(FollowUp), Description = "TimePoint", IsRequired = false)]
        public TimePoint FollowUp { get; set; }
        [ApiMember(Name = nameof(FollowUpId), Description = "Primary Key of TimePoint", IsRequired = false)]
        public int? FollowUpId { get; set; }


        [ApiMember(Name = nameof(TimeOfDay), Description = "TimePoint", IsRequired = false)]
        public TimePoint TimeOfDay { get; set; }
        [ApiMember(Name = nameof(TimeOfDayId), Description = "Primary Key of TimePoint", IsRequired = false)]
        public int? TimeOfDayId { get; set; }


    }

    [Route("/interval", "POST")]
    [Route("/profile/interval", "POST")]
    [Route("/interval/{Id}", "GET, PATCH, PUT, DELETE")]
    [Route("/profile/interval/{Id}", "GET, PATCH, PUT, DELETE")]
    public partial class Interval : IntervalBase, IReturn<Interval>, IDto
    {
        public Interval()
        {
            _Constructor();
        }

        public Interval(int? id) : base(DocConvert.ToInt(id)) {}
        public Interval(int id) : base(id) {}
        
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
        public static List<string> Fields => _fields ?? (_fields = DocTools.Fields<Interval>());

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(CalendarDateEnd),nameof(CalendarDateEndId),nameof(CalendarDateStart),nameof(CalendarDateStartId),nameof(CalendarType),nameof(Created),nameof(CreatorId),nameof(FollowUp),nameof(FollowUpId),nameof(Gestalt),nameof(Locked),nameof(TimeOfDay),nameof(TimeOfDayId),nameof(Updated),nameof(VersionNo)})]
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
    
    [Route("/Interval/{Id}/copy", "POST")]
    [Route("/profile/Interval/{Id}/copy", "POST")]
    public partial class IntervalCopy : Interval {}
    [Route("/interval", "GET")]
    [Route("/profile/interval", "GET")]
    [Route("/interval/search", "GET, POST, DELETE")]
    [Route("/profile/interval/search", "GET, POST, DELETE")]
    public partial class IntervalSearch : Search<Interval>
    {
        public Reference CalendarDateEnd { get; set; }
        public List<int> CalendarDateEndIds { get; set; }
        public Reference CalendarDateStart { get; set; }
        public List<int> CalendarDateStartIds { get; set; }
        public string CalendarType { get; set; }
        public Reference FollowUp { get; set; }
        public List<int> FollowUpIds { get; set; }
        public Reference TimeOfDay { get; set; }
        public List<int> TimeOfDayIds { get; set; }
    }
    
    public class IntervalFullTextSearch
    {
        private IntervalSearch _request;
        public IntervalFullTextSearch(IntervalSearch request) => _request = request;
        
        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Interval.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Interval.Updated))); }
        
        public bool doCalendarDateEnd { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Interval.CalendarDateEnd))); }
        public bool doCalendarDateStart { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Interval.CalendarDateStart))); }
        public bool doCalendarType { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Interval.CalendarType))); }
        public bool doFollowUp { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Interval.FollowUp))); }
        public bool doTimeOfDay { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Interval.TimeOfDay))); }
    }

    [Route("/interval/version", "GET, POST")]
    public partial class IntervalVersion : IntervalSearch {}

    [Route("/interval/batch", "DELETE, PATCH, POST, PUT")]
    [Route("/profile/interval/batch", "DELETE, PATCH, POST, PUT")]
    public partial class IntervalBatch : List<Interval> { }

    [Route("/admin/interval/ids", "GET, POST")]
    public class IntervalIds
    {
        public bool All { get; set; }
    }
}