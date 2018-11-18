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
    public abstract partial class TimePointBase : Dto<TimePoint>
    {
        public TimePointBase() {}

        public TimePointBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public TimePointBase(int? id) : this(DocConvert.ToInt(id)) {}
    
        [ApiMember(Name = nameof(IsAbsolute), Description = "bool", IsRequired = false)]
        public bool IsAbsolute { get; set; }


        [ApiMember(Name = nameof(MeanValue), Description = "MeanBase", IsRequired = false)]
        public TypeMeanBase MeanValue { get; set; }


        [ApiMember(Name = nameof(SingleValue), Description = "UnitValue", IsRequired = false)]
        public TypeUnitValue SingleValue { get; set; }


        [ApiMember(Name = nameof(TotalValue), Description = "UnitRange", IsRequired = false)]
        public TypeUnitRange TotalValue { get; set; }


        [ApiMember(Name = nameof(Type), Description = "LookupTable", IsRequired = false)]
        [ApiAllowableValues("Includes", Values = new string[] {@"Duration",@"Maximum",@"Average",@"Mean",@"Median",@"Total",@"Max Range",@"Time Zero",@"Not Reported",@"N/A",@"None",@"Varies",@"Before",@"During",@"After"})]
        public Reference Type { get; set; }
        [ApiMember(Name = nameof(TypeId), Description = "Primary Key of LookupTable", IsRequired = false)]
        public int? TypeId { get; set; }


    }

    [Route("/timepoint/{Id}", "GET")]
    [Route("/profile/timepoint/{Id}", "GET")]
    public partial class TimePoint : TimePointBase, IReturn<TimePoint>, IDto
    {
        public TimePoint()
        {
            _Constructor();
        }

        public TimePoint(int? id) : base(DocConvert.ToInt(id)) {}
        public TimePoint(int id) : base(id) {}
        
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
        public static List<string> Fields => _fields ?? (_fields = DocTools.Fields<TimePoint>());

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Created),nameof(CreatorId),nameof(Gestalt),nameof(IsAbsolute),nameof(Locked),nameof(MeanValue),nameof(SingleValue),nameof(TotalValue),nameof(Type),nameof(TypeId),nameof(Updated),nameof(VersionNo)})]
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
    
    [Route("/timepoint", "GET")]
    [Route("/profile/timepoint", "GET")]
    [Route("/timepoint/search", "GET, POST, DELETE")]
    [Route("/profile/timepoint/search", "GET, POST, DELETE")]
    public partial class TimePointSearch : Search<TimePoint>
    {
        public bool? IsAbsolute { get; set; }
        public TypeMeanBase MeanValue { get; set; }
        public TypeUnitValue SingleValue { get; set; }
        public TypeUnitRange TotalValue { get; set; }
        public Reference Type { get; set; }
        public List<int> TypeIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"Duration",@"Maximum",@"Average",@"Mean",@"Median",@"Total",@"Max Range",@"Time Zero",@"Not Reported",@"N/A",@"None",@"Varies",@"Before",@"During",@"After"})]
        public List<string> TypeNames { get; set; }
    }
    
    public class TimePointFullTextSearch
    {
        private TimePointSearch _request;
        public TimePointFullTextSearch(TimePointSearch request) => _request = request;
        
        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(TimePoint.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(TimePoint.Updated))); }
        
        public bool doIsAbsolute { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(TimePoint.IsAbsolute))); }
        public bool doMeanValue { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(TimePoint.MeanValue))); }
        public bool doSingleValue { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(TimePoint.SingleValue))); }
        public bool doTotalValue { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(TimePoint.TotalValue))); }
        public bool doType { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(TimePoint.Type))); }
    }

    [Route("/timepoint/version", "GET, POST")]
    public partial class TimePointVersion : TimePointSearch {}

    [Route("/timepoint/batch", "DELETE, PATCH, POST, PUT")]
    [Route("/profile/timepoint/batch", "DELETE, PATCH, POST, PUT")]
    public partial class TimePointBatch : List<TimePoint> { }

}