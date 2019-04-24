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
    public abstract partial class MeanRangeValueBase : Dto<MeanRangeValue>
    {
        public MeanRangeValueBase() {}

        public MeanRangeValueBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public MeanRangeValueBase(int? id) : this(DocConvert.ToInt(id)) {}

        public MeanRangeValueBase(int? pId, Reference pMeanVarianceType, int? pMeanVarianceTypeId, TypeUnits pMidSpread, int? pOrder, List<MeanRanges> pOwners, int? pOwnersCount, decimal? pPercent, decimal? pPercentLow, TypeUnitsRange pRange, Reference pType, int? pTypeId) : this(DocConvert.ToInt(pId)) 
        {
            MeanVarianceType = pMeanVarianceType;
            MeanVarianceTypeId = pMeanVarianceTypeId;
            MidSpread = pMidSpread;
            Order = pOrder;
            Owners = pOwners;
            OwnersCount = pOwnersCount;
            Percent = pPercent;
            PercentLow = pPercentLow;
            Range = pRange;
            Type = pType;
            TypeId = pTypeId;
        }

        [ApiMember(Name = nameof(MeanVarianceType), Description = "LookupTable", IsRequired = false)]
        [ApiAllowableValues("Includes", Values = new string[] {@"CV",@"IQR Difference",@"SD",@"SE",@"Semi IQR",@"Unknown"})]
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
        [ApiAllowableValues("Includes", Values = new string[] {@"CI",@"IQR",@"Percentile",@"Total",@"Variance CI",@"Variance IQR",@"Variance Percentile",@"Variance Total"})]
        public Reference Type { get; set; }
        [ApiMember(Name = nameof(TypeId), Description = "Primary Key of LookupTable", IsRequired = false)]
        public int? TypeId { get; set; }



        public void Deconstruct(out Reference pMeanVarianceType, out int? pMeanVarianceTypeId, out TypeUnits pMidSpread, out int? pOrder, out List<MeanRanges> pOwners, out int? pOwnersCount, out decimal? pPercent, out decimal? pPercentLow, out TypeUnitsRange pRange, out Reference pType, out int? pTypeId)
        {
            pMeanVarianceType = MeanVarianceType;
            pMeanVarianceTypeId = MeanVarianceTypeId;
            pMidSpread = MidSpread;
            pOrder = Order;
            pOwners = Owners;
            pOwnersCount = OwnersCount;
            pPercent = Percent;
            pPercentLow = PercentLow;
            pRange = Range;
            pType = Type;
            pTypeId = TypeId;
        }

        //Not ready until C# v8.?
        //public MeanRangeValueBase With(int? pId = Id, Reference pMeanVarianceType = MeanVarianceType, int? pMeanVarianceTypeId = MeanVarianceTypeId, TypeUnits pMidSpread = MidSpread, int? pOrder = Order, List<MeanRanges> pOwners = Owners, int? pOwnersCount = OwnersCount, decimal? pPercent = Percent, decimal? pPercentLow = PercentLow, TypeUnitsRange pRange = Range, Reference pType = Type, int? pTypeId = TypeId) => 
        //	new MeanRangeValueBase(pId, pMeanVarianceType, pMeanVarianceTypeId, pMidSpread, pOrder, pOwners, pOwnersCount, pPercent, pPercentLow, pRange, pType, pTypeId);

    }

    public partial class MeanRangeValue : MeanRangeValueBase, IReturn<MeanRangeValue>, IDto, ICloneable
    {
        public MeanRangeValue()
        {
            _Constructor();
        }

        public MeanRangeValue(int? id) : base(DocConvert.ToInt(id)) {}
        public MeanRangeValue(int id) : base(id) {}
        public MeanRangeValue(int? pId, Reference pMeanVarianceType, int? pMeanVarianceTypeId, TypeUnits pMidSpread, int? pOrder, List<MeanRanges> pOwners, int? pOwnersCount, decimal? pPercent, decimal? pPercentLow, TypeUnitsRange pRange, Reference pType, int? pTypeId) : 
            base(pId, pMeanVarianceType, pMeanVarianceTypeId, pMidSpread, pOrder, pOwners, pOwnersCount, pPercent, pPercentLow, pRange, pType, pTypeId) { }
        #region Fields

        public new bool? ShouldSerialize(string field)
        {
            //Allow individual classes to specify their own logic
            var manualOverride = _ShouldSerialize(field);
            if(null != manualOverride) return manualOverride;

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

        public object Clone() => this.Copy<MeanRangeValue>();
    }
    
    public partial class MeanRangeValueSearchBase : Search<MeanRangeValue>
    {
        public int? Id { get; set; }
        public Reference MeanVarianceType { get; set; }
        public List<int> MeanVarianceTypeIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"CV",@"IQR Difference",@"SD",@"SE",@"Semi IQR",@"Unknown"})]
        public List<string> MeanVarianceTypeNames { get; set; }
        public TypeUnits MidSpread { get; set; }
        public int? Order { get; set; }
        public List<int> OwnersIds { get; set; }
        public decimal? Percent { get; set; }
        public decimal? PercentLow { get; set; }
        public TypeUnitsRange Range { get; set; }
        public Reference Type { get; set; }
        public List<int> TypeIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"CI",@"IQR",@"Percentile",@"Total",@"Variance CI",@"Variance IQR",@"Variance Percentile",@"Variance Total"})]
        public List<string> TypeNames { get; set; }
    }

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

    public partial class MeanRangeValueBatch : List<MeanRangeValue> { }

    [Route("/meanrangevalue/{Id}/{Junction}/version", "GET, POST")]
    [Route("/meanrangevalue/{Id}/{Junction}", "GET, POST, DELETE")]
    public class MeanRangeValueJunction : MeanRangeValueSearchBase {}


}
