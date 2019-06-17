//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated by a T4 template. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;

using Services.Core;
using Services.Dto.internals;
using Services.Enums;

using ServiceStack;
using ServiceStack.Text;

using Typed;
using Typed.Notifications;
using Typed.Bindings;

using Xtensive.Orm;


namespace Services.Dto
{
    public abstract partial class UnitValueBase : Dto<UnitValue>
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public UnitValueBase() {}

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public UnitValueBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public UnitValueBase(int? id) : this(DocConvert.ToInt(id)) {}

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
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

        [ApiAllowableValues("Includes", Values = new string[] {@"~=",@"~>",@"~>=",@"~<",@"~<=",@"=",@">",@">=",@"≥",@"<",@"<=",@"≤",@"!="})]
        [ApiMember(Name = nameof(EqualityOperator), Description = "LookupTable", IsRequired = false)]
[GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Reference EqualityOperator { get; set; }
        [ApiMember(Name = nameof(EqualityOperatorId), Description = "Primary Key of LookupTable", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? EqualityOperatorId { get; set; }

        [ApiMember(Name = nameof(Multiplier), Description = "int?", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? Multiplier { get; set; }
        [ApiMember(Name = nameof(MultiplierIds), Description = "Multiplier Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> MultiplierIds { get; set; }
        [ApiMember(Name = nameof(MultiplierCount), Description = "Multiplier Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? MultiplierCount { get; set; }

        [ApiMember(Name = nameof(Number), Description = "decimal?", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public decimal? Number { get; set; }
        [ApiMember(Name = nameof(NumberIds), Description = "Number Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> NumberIds { get; set; }
        [ApiMember(Name = nameof(NumberCount), Description = "Number Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? NumberCount { get; set; }

        [ApiMember(Name = nameof(Order), Description = "int?", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? Order { get; set; }
        [ApiMember(Name = nameof(OrderIds), Description = "Order Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> OrderIds { get; set; }
        [ApiMember(Name = nameof(OrderCount), Description = "Order Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? OrderCount { get; set; }

        [ApiMember(Name = nameof(Unit), Description = "UnitOfMeasure", IsRequired = true)]
[GeneratedCodeAttribute("T4", "1.0.0.0")]
        public UnitOfMeasure Unit { get; set; }
        [ApiMember(Name = nameof(UnitId), Description = "Primary Key of UnitOfMeasure", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? UnitId { get; set; }



        [GeneratedCodeAttribute("T4", "1.0.0.0")]
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
        //[GeneratedCodeAttribute("T4", "1.0.0.0")]
        //public UnitValueBase With(int? pId = Id, Reference pEqualityOperator = EqualityOperator, int? pEqualityOperatorId = EqualityOperatorId, int? pMultiplier = Multiplier, decimal? pNumber = Number, int? pOrder = Order, UnitOfMeasure pUnit = Unit, int? pUnitId = UnitId) => 
        //	new UnitValueBase(pId, pEqualityOperator, pEqualityOperatorId, pMultiplier, pNumber, pOrder, pUnit, pUnitId);

    }


    public partial class UnitValue : UnitValueBase, IReturn<UnitValue>, IDto, ICloneable
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public UnitValue() => _Constructor();
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public UnitValue(int? id) : base(DocConvert.ToInt(id)) {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public UnitValue(int id) : base(id) {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public UnitValue(int? pId, Reference pEqualityOperator, int? pEqualityOperatorId, int? pMultiplier, decimal? pNumber, int? pOrder, UnitOfMeasure pUnit, int? pUnitId) :
            base(pId, pEqualityOperator, pEqualityOperatorId, pMultiplier, pNumber, pOrder, pUnit, pUnitId) { }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static List<string> Fields => DocTools.Fields<UnitValue>();

        private List<string> _Select;
        [ApiMember(Name = nameof(Select), Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Created),nameof(CreatorId),nameof(EqualityOperator),nameof(EqualityOperatorId),nameof(Gestalt),nameof(Locked),nameof(Multiplier),nameof(Number),nameof(Order),nameof(Unit),nameof(UnitId),nameof(Updated),nameof(VersionNo)})]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override List<string> Select
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

        [Obsolete, ApiMember(Name = "VisibleFields", Description = "Deprecated. Use Select instead.", AllowMultiple = true)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override List<string> VisibleFields { get => Select; set => Select = value; }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private List<string> _collections = new List<string>
        {
            nameof(Owners), nameof(Owners), nameof(OwnersCount), nameof(OwnersIds)
        };
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private List<string> collections { get { return _collections; } }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Clone() => this.Copy<UnitValue>();

    }
    

    public partial class UnitValueSearchBase : Search<UnitValue>
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
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
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public UnitValueFullTextSearch() {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private UnitValueSearch _request;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public UnitValueFullTextSearch(UnitValueSearch request) => _request = request;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool doCreated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(UnitValue.Created))); }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool doUpdated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(UnitValue.Updated))); }

        public bool doEqualityOperator { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(UnitValue.EqualityOperator))); }
        public bool doMultiplier { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(UnitValue.Multiplier))); }
        public bool doNumber { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(UnitValue.Number))); }
        public bool doOrder { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(UnitValue.Order))); }
        public bool doOwners { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(UnitValue.Owners))); }
        public bool doUnit { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(UnitValue.Unit))); }
    }


    public partial class UnitValueBatch : List<UnitValue> { }


    [Route("/unitvalue/{Id}/{Junction}/version", "GET, POST")]
    [Route("/unitvalue/{Id}/{Junction}", "GET, POST, DELETE")]
    public class UnitValueJunction : UnitValueSearchBase {}



}
