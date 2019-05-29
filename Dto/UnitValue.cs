
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
    public abstract partial class UnitValueBase : Dto<UnitValue>
    {
        public UnitValueBase() {}

        public UnitValueBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public UnitValueBase(int? id) : this(DocConvert.ToInt(id)) {}

        public UnitValueBase(int? pId, Reference pEqualityOperator, int? pEqualityOperatorId, int? pMultiplier, decimal? pNumber, int? pOrder, UnitOfMeasure pUnit, int? pUnitId) : this(DocConvert.ToInt(pId)) 
        {
            EqualityOperator = pEqualityOperator;
            EqualityOperatorId = pEqualityOperatorId;
            Multiplier = pMultiplier;
            Number = pNumber;
            Order = pOrder;
            Unit = pUnit;
            UnitId = pUnitId;
        }

        [ApiMember(Name = nameof(EqualityOperator), Description = "LookupTable", IsRequired = false)]
        [ApiAllowableValues("Includes", Values = new string[] {@"~=",@"~>",@"~>=",@"~<",@"~<=",@"=",@">",@">=",@"≥",@"<",@"<=",@"≤",@"!="})]
        public Reference EqualityOperator { get; set; }
        [ApiMember(Name = nameof(EqualityOperatorId), Description = "Primary Key of LookupTable", IsRequired = false)]
        public int? EqualityOperatorId { get; set; }


        [ApiMember(Name = nameof(Multiplier), Description = "int?", IsRequired = false)]
        public int? Multiplier { get; set; }


        [ApiMember(Name = nameof(Number), Description = "decimal?", IsRequired = false)]
        public decimal? Number { get; set; }


        [ApiMember(Name = nameof(Order), Description = "int?", IsRequired = false)]
        public int? Order { get; set; }


        [ApiMember(Name = nameof(Unit), Description = "UnitOfMeasure", IsRequired = true)]
        public UnitOfMeasure Unit { get; set; }
        [ApiMember(Name = nameof(UnitId), Description = "Primary Key of UnitOfMeasure", IsRequired = false)]
        public int? UnitId { get; set; }



        public void Deconstruct(out Reference pEqualityOperator, out int? pEqualityOperatorId, out int? pMultiplier, out decimal? pNumber, out int? pOrder, out UnitOfMeasure pUnit, out int? pUnitId)
        {
            pEqualityOperator = EqualityOperator;
            pEqualityOperatorId = EqualityOperatorId;
            pMultiplier = Multiplier;
            pNumber = Number;
            pOrder = Order;
            pUnit = Unit;
            pUnitId = UnitId;
        }

        //Not ready until C# v8.?
        //public UnitValueBase With(int? pId = Id, Reference pEqualityOperator = EqualityOperator, int? pEqualityOperatorId = EqualityOperatorId, int? pMultiplier = Multiplier, decimal? pNumber = Number, int? pOrder = Order, UnitOfMeasure pUnit = Unit, int? pUnitId = UnitId) => 
        //	new UnitValueBase(pId, pEqualityOperator, pEqualityOperatorId, pMultiplier, pNumber, pOrder, pUnit, pUnitId);

    }


    public partial class UnitValue : UnitValueBase, IReturn<UnitValue>, IDto, ICloneable
    {
        public UnitValue()
        {
            _Constructor();
        }

        public UnitValue(int? id) : base(DocConvert.ToInt(id)) {}
        public UnitValue(int id) : base(id) {}
        public UnitValue(int? pId, Reference pEqualityOperator, int? pEqualityOperatorId, int? pMultiplier, decimal? pNumber, int? pOrder, UnitOfMeasure pUnit, int? pUnitId) : 
            base(pId, pEqualityOperator, pEqualityOperatorId, pMultiplier, pNumber, pOrder, pUnit, pUnitId) { }
        #region Fields

        public bool? ShouldSerialize(string field)
        {
            //Allow individual classes to specify their own logic
            var manualOverride = _ShouldSerialize(field);
            if(null != manualOverride) return manualOverride;

            if (IgnoredVisibleFields.Matches(field, true)) return false;
            var ret = MandatoryVisibleFields.Matches(field, true) || true == VisibleFields?.Matches(field, true);
            return ret;
        }

        public static List<string> Fields => DocTools.Fields<UnitValue>();

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Created),nameof(CreatorId),nameof(EqualityOperator),nameof(EqualityOperatorId),nameof(Gestalt),nameof(Locked),nameof(Multiplier),nameof(Number),nameof(Order),nameof(Unit),nameof(UnitId),nameof(Updated),nameof(VersionNo)})]
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
            nameof(Owners), nameof(Owners), nameof(OwnersCount)
        };
        private List<string> collections { get { return _collections; } }


        public object Clone() => this.Copy<UnitValue>();
    }
    

    public partial class UnitValueSearchBase : Search<UnitValue>
    {
        public int? Id { get; set; }
        public Reference EqualityOperator { get; set; }
        public List<int> EqualityOperatorIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"~=",@"~>",@"~>=",@"~<",@"~<=",@"=",@">",@">=",@"≥",@"<",@"<=",@"≤",@"!="})]
        public List<string> EqualityOperatorNames { get; set; }
        public int? Multiplier { get; set; }
        public decimal? Number { get; set; }
        public int? Order { get; set; }
        public Reference Unit { get; set; }
        public List<int> UnitIds { get; set; }
    }


    public partial class UnitValueSearch : UnitValueSearchBase
    {
    }

    public class UnitValueFullTextSearch
    {
        public UnitValueFullTextSearch() {}
        private UnitValueSearch _request;
        public UnitValueFullTextSearch(UnitValueSearch request) => _request = request;

        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(UnitValue.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(UnitValue.Updated))); }

        public bool doEqualityOperator { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(UnitValue.EqualityOperator))); }
        public bool doMultiplier { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(UnitValue.Multiplier))); }
        public bool doNumber { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(UnitValue.Number))); }
        public bool doOrder { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(UnitValue.Order))); }
        public bool doOwners { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(UnitValue.Owners))); }
        public bool doUnit { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(UnitValue.Unit))); }
    }


    public partial class UnitValueBatch : List<UnitValue> { }


    [Route("/unitvalue/{Id}/{Junction}/version", "GET, POST")]
    [Route("/unitvalue/{Id}/{Junction}", "GET, POST, DELETE")]
    public class UnitValueJunction : UnitValueSearchBase {}



}
