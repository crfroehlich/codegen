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
    public abstract partial class MeanRangeValueBase : Dto<MeanRangeValue>
    {
        public MeanRangeValueBase() {}

        public MeanRangeValueBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public MeanRangeValueBase(int? id) : this(DocConvert.ToInt(id)) {}
    
        [ApiMember(Name = nameof(MeanVarianceType), Description = "LookupTable", IsRequired = false)]
        [ApiAllowableValues("Includes", Values = new string[] {@"SD",@"SE",@"Unknown",@"Semi IQR",@"IQR Difference",@"CV"})]
        public Reference MeanVarianceType { get; set; }
        [ApiMember(Name = nameof(MeanVarianceTypeId), Description = "Primary Key of LookupTable", IsRequired = false)]
        public int? MeanVarianceTypeId { get; set; }


        [ApiMember(Name = nameof(MidSpread), Description = "Units", IsRequired = false)]
        public TypeUnits MidSpread { get; set; }


        [ApiMember(Name = nameof(Order), Description = "int?", IsRequired = false)]
        public int? Order { get; set; }


        [ApiMember(Name = nameof(Owners), Description = "MeanRanges", IsRequired = false)]
        public List<MeanRanges> Owners { get; set; }
        public int? OwnersCount { get; set; }


        [ApiMember(Name = nameof(Percent), Description = "decimal?", IsRequired = false)]
        public decimal? Percent { get; set; }


        [ApiMember(Name = nameof(PercentLow), Description = "decimal?", IsRequired = false)]
        public decimal? PercentLow { get; set; }


        [ApiMember(Name = nameof(Range), Description = "UnitsRange", IsRequired = false)]
        public TypeUnitsRange Range { get; set; }


        [ApiMember(Name = nameof(Type), Description = "LookupTable", IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {@"CI",@"Total",@"IQR",@"Percentile",@"Variance CI",@"Variance Total",@"Variance IQR",@"Variance Percentile"})]
        public Reference Type { get; set; }
        [ApiMember(Name = nameof(TypeId), Description = "Primary Key of LookupTable", IsRequired = false)]
        public int? TypeId { get; set; }


    }

    [Route("/meanrangevalue", "POST")]
    [Route("/meanrangevalue/{Id}", "GET, PATCH, PUT, DELETE")]
    public partial class MeanRangeValue : MeanRangeValueBase, IReturn<MeanRangeValue>, IDto
    {
        public MeanRangeValue()
        {
            _Constructor();
        }

        public MeanRangeValue(int? id) : base(DocConvert.ToInt(id)) {}
        public MeanRangeValue(int id) : base(id) {}
        
        #region Fields
        
        public bool? ShouldSerialize(string field)
        {
            if (IgnoredVisibleFields.Matches(field, true)) return false;
            var ret = MandatoryVisibleFields.Matches(field, true) || true == VisibleFields?.Matches(field, true);
            return ret;
        }

        public static List<string> Fields => DocTools.Fields<MeanRangeValue>();

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Created),nameof(CreatorId),nameof(Gestalt),nameof(Locked),nameof(MeanVarianceType),nameof(MeanVarianceTypeId),nameof(MidSpread),nameof(Order),nameof(Owners),nameof(OwnersCount),nameof(Percent),nameof(PercentLow),nameof(Range),nameof(Type),nameof(TypeId),nameof(Updated),nameof(VersionNo)})]
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
        private List<string> _collections = new List<string>
        {
            nameof(Owners), nameof(OwnersCount)
        };
        private List<string> collections { get { return _collections; } }
    }
    
    [Route("/MeanRangeValue/{Id}/copy", "POST")]
    public partial class MeanRangeValueCopy : MeanRangeValue {}
    public partial class MeanRangeValueSearchBase : Search<MeanRangeValue>
    {
        public int? Id { get; set; }
        public Reference MeanVarianceType { get; set; }
        public List<int> MeanVarianceTypeIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"SD",@"SE",@"Unknown",@"Semi IQR",@"IQR Difference",@"CV"})]
        public List<string> MeanVarianceTypeNames { get; set; }
        public TypeUnits MidSpread { get; set; }
        public int? Order { get; set; }
        public List<int> OwnersIds { get; set; }
        public decimal? Percent { get; set; }
        public decimal? PercentLow { get; set; }
        public TypeUnitsRange Range { get; set; }
        public Reference Type { get; set; }
        public List<int> TypeIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"CI",@"Total",@"IQR",@"Percentile",@"Variance CI",@"Variance Total",@"Variance IQR",@"Variance Percentile"})]
        public List<string> TypeNames { get; set; }
    }

    [Route("/meanrangevalue", "GET")]
    [Route("/meanrangevalue/version", "GET, POST")]
    [Route("/meanrangevalue/search", "GET, POST, DELETE")]
    public partial class MeanRangeValueSearch : MeanRangeValueSearchBase
    {
    }

    public class MeanRangeValueFullTextSearch
    {
        public MeanRangeValueFullTextSearch() {}
        private MeanRangeValueSearch _request;
        public MeanRangeValueFullTextSearch(MeanRangeValueSearch request) => _request = request;
        
        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(MeanRangeValue.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(MeanRangeValue.Updated))); }
        
        public bool doMeanVarianceType { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(MeanRangeValue.MeanVarianceType))); }
        public bool doMidSpread { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(MeanRangeValue.MidSpread))); }
        public bool doOrder { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(MeanRangeValue.Order))); }
        public bool doOwners { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(MeanRangeValue.Owners))); }
        public bool doPercent { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(MeanRangeValue.Percent))); }
        public bool doPercentLow { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(MeanRangeValue.PercentLow))); }
        public bool doRange { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(MeanRangeValue.Range))); }
        public bool doType { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(MeanRangeValue.Type))); }
    }

    [Route("/meanrangevalue/batch", "DELETE, PATCH, POST, PUT")]
    public partial class MeanRangeValueBatch : List<MeanRangeValue> { }

    [Route("/meanrangevalue/{Id}/meanranges/version", "GET, POST")]
    [Route("/meanrangevalue/{Id}/meanranges", "GET, POST, DELETE")]
    public class MeanRangeValueJunction : MeanRangeValueSearchBase {}


    [Route("/admin/meanrangevalue/ids", "GET, POST")]
    public class MeanRangeValueIds
    {
        public bool All { get; set; }
    }
}