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
    public abstract partial class TimePointBase : Dto<TimePoint>
    {
        public TimePointBase() {}

        public TimePointBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public TimePointBase(int? id) : this(DocConvert.ToInt(id)) {}

        public TimePointBase(int? pId, bool pIsAbsolute, TypeMeanBase pMeanValue, TypeUnitValue pSingleValue, TypeUnitRange pTotalValue, Reference pType, int? pTypeId) : this(DocConvert.ToInt(pId)) 
        {
            IsAbsolute = pIsAbsolute;
            MeanValue = pMeanValue;
            SingleValue = pSingleValue;
            TotalValue = pTotalValue;
            Type = pType;
            TypeId = pTypeId;
        }

        [ApiMember(Name = nameof(IsAbsolute), Description = "bool", IsRequired = false)]
        public bool IsAbsolute { get; set; }


        [ApiMember(Name = nameof(MeanValue), Description = "MeanBase", IsRequired = false)]
        public TypeMeanBase MeanValue { get; set; }


        [ApiMember(Name = nameof(SingleValue), Description = "UnitValue", IsRequired = false)]
        public TypeUnitValue SingleValue { get; set; }


        [ApiMember(Name = nameof(TotalValue), Description = "UnitRange", IsRequired = false)]
        public TypeUnitRange TotalValue { get; set; }


        [ApiAllowableValues("Includes", Values = new string[] {@"After",@"Average",@"Before",@"Duration",@"During",@"Max Range",@"Maximum",@"Mean",@"Median",@"N/A",@"None",@"Not Reported",@"Time Zero",@"Total",@"Varies"})]
        [ApiMember(Name = nameof(Type), Description = "LookupTable", IsRequired = false)]
        public Reference Type { get; set; }
        [ApiMember(Name = nameof(TypeId), Description = "Primary Key of LookupTable", IsRequired = false)]
        public int? TypeId { get; set; }



        public void Deconstruct(out bool pIsAbsolute, out TypeMeanBase pMeanValue, out TypeUnitValue pSingleValue, out TypeUnitRange pTotalValue, out Reference pType, out int? pTypeId)
        {
            pIsAbsolute = IsAbsolute;
            pMeanValue = MeanValue;
            pSingleValue = SingleValue;
            pTotalValue = TotalValue;
            pType = Type;
            pTypeId = TypeId;
        }

        //Not ready until C# v8.?
        //public TimePointBase With(int? pId = Id, bool pIsAbsolute = IsAbsolute, TypeMeanBase pMeanValue = MeanValue, TypeUnitValue pSingleValue = SingleValue, TypeUnitRange pTotalValue = TotalValue, Reference pType = Type, int? pTypeId = TypeId) => 
        //	new TimePointBase(pId, pIsAbsolute, pMeanValue, pSingleValue, pTotalValue, pType, pTypeId);

    }

    [Route("/timepoint/{Id}", "GET")]
    public partial class TimePoint : TimePointBase, IReturn<TimePoint>, IDto, ICloneable
    {
        public TimePoint()
        {
            _Constructor();
        }

        public TimePoint(int? id) : base(DocConvert.ToInt(id)) {}
        public TimePoint(int id) : base(id) {}
        public TimePoint(int? pId, bool pIsAbsolute, TypeMeanBase pMeanValue, TypeUnitValue pSingleValue, TypeUnitRange pTotalValue, Reference pType, int? pTypeId) : 
            base(pId, pIsAbsolute, pMeanValue, pSingleValue, pTotalValue, pType, pTypeId) { }
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

        public static List<string> Fields => DocTools.Fields<TimePoint>();

        private List<string> _Select;
        [ApiMember(Name = "Select", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Created),nameof(CreatorId),nameof(Gestalt),nameof(IsAbsolute),nameof(Locked),nameof(MeanValue),nameof(SingleValue),nameof(TotalValue),nameof(Type),nameof(TypeId),nameof(Updated),nameof(VersionNo)})]
        public new List<string> Select
        {
            get
            {
                if(null == this) return new List<string>();
                if(null == _Select)
                {
                    _Select = DocPermissionFactory.RemoveNonEssentialFields(Fields);
                }
                return _Select;
            }
            set
            {
                _Select = Fields;
            }
        }

        #endregion Fields

        public object Clone() => this.Copy<TimePoint>();
    }
    
    public partial class TimePointSearchBase : Search<TimePoint>
    {
        public int? Id { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> IsAbsolute { get; set; }
        public TypeMeanBase MeanValue { get; set; }
        public TypeUnitValue SingleValue { get; set; }
        public TypeUnitRange TotalValue { get; set; }
        public Reference Type { get; set; }
        public List<int> TypeIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"After",@"Average",@"Before",@"Duration",@"During",@"Max Range",@"Maximum",@"Mean",@"Median",@"N/A",@"None",@"Not Reported",@"Time Zero",@"Total",@"Varies"})]
        public List<string> TypeNames { get; set; }
    }

    [Route("/timepoint", "GET")]
    [Route("/timepoint/version", "GET, POST")]
    [Route("/timepoint/search", "GET, POST, DELETE")]
    public partial class TimePointSearch : TimePointSearchBase
    {
    }

    public class TimePointFullTextSearch
    {
        public TimePointFullTextSearch() {}
        private TimePointSearch _request;
        public TimePointFullTextSearch(TimePointSearch request) => _request = request;

        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(TimePoint.Created))); }
        public bool doUpdated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(TimePoint.Updated))); }

        public bool doIsAbsolute { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(TimePoint.IsAbsolute))); }
        public bool doMeanValue { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(TimePoint.MeanValue))); }
        public bool doSingleValue { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(TimePoint.SingleValue))); }
        public bool doTotalValue { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(TimePoint.TotalValue))); }
        public bool doType { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(TimePoint.Type))); }
    }

    public partial class TimePointBatch : List<TimePoint> { }

}
