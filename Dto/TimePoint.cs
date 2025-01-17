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
    public abstract partial class TimePointBase : Dto<TimePoint>
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public TimePointBase() {}

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public TimePointBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public TimePointBase(int? id) : this(DocConvert.ToInt(id)) {}

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public TimePointBase(int? pId, bool pIsAbsolute, TypeMeanBase pMeanValue, TypeUnitValue pSingleValue, TypeUnitRange pTotalValue, Reference pType, int? pType_Id) : this(DocConvert.ToInt(pId)) 
        {
            IsAbsolute = pIsAbsolute;
            MeanValue = pMeanValue;
            SingleValue = pSingleValue;
            TotalValue = pTotalValue;
            Type = pType;
            Type_Id = pType_Id;
        }

        [ApiMember(Name = nameof(IsAbsolute), Description = "bool", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool IsAbsolute { get; set; }


        [ApiMember(Name = nameof(MeanValue), Description = "MeanBase", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public TypeMeanBase MeanValue { get; set; }


        [ApiMember(Name = nameof(SingleValue), Description = "UnitValue", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public TypeUnitValue SingleValue { get; set; }


        [ApiMember(Name = nameof(TotalValue), Description = "UnitRange", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public TypeUnitRange TotalValue { get; set; }


        [ApiAllowableValues("Includes", Values = new string[] {@"After",@"Average",@"Before",@"Duration",@"During",@"Max Range",@"Maximum",@"Mean",@"Median",@"N/A",@"None",@"Not Reported",@"Time Zero",@"Total",@"Varies"})]
        [ApiMember(Name = nameof(Type), Description = "LookupTable", IsRequired = false)]
[GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Reference Type { get; set; }
        [ApiMember(Name = nameof(Type_Id), Description = "Primary Key of LookupTable", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? Type_Id { get; set; }



        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public void Deconstruct(out bool pIsAbsolute, out TypeMeanBase pMeanValue, out TypeUnitValue pSingleValue, out TypeUnitRange pTotalValue, out Reference pType, out int? pType_Id)
        {
            pIsAbsolute = IsAbsolute;
            pMeanValue = MeanValue;
            pSingleValue = SingleValue;
            pTotalValue = TotalValue;
            pType = Type;
            pType_Id = Type_Id;
        }

        //Not ready until C# v8.?
        //[GeneratedCodeAttribute("T4", "1.0.0.0")]
        //public TimePointBase With(int? pId = Id, bool pIsAbsolute = IsAbsolute, TypeMeanBase pMeanValue = MeanValue, TypeUnitValue pSingleValue = SingleValue, TypeUnitRange pTotalValue = TotalValue, Reference pType = Type, int? pType_Id = Type_Id) => 
        //	new TimePointBase(pId, pIsAbsolute, pMeanValue, pSingleValue, pTotalValue, pType, pType_Id);

    }


    [Route("/timepoint/{Id}", "GET")]

    public partial class TimePoint : TimePointBase, IReturn<TimePoint>, IDto, ICloneable
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public TimePoint() => _Constructor();
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public TimePoint(int? id) : base(DocConvert.ToInt(id)) {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public TimePoint(int id) : base(id) {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public TimePoint(int? pId, bool pIsAbsolute, TypeMeanBase pMeanValue, TypeUnitValue pSingleValue, TypeUnitRange pTotalValue, Reference pType, int? pType_Id) :
            base(pId, pIsAbsolute, pMeanValue, pSingleValue, pTotalValue, pType, pType_Id) { }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static List<string> Fields => DocTools.Fields<TimePoint>();

        private List<string> _Select;
        [ApiMember(Name = nameof(Select), Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Created),nameof(CreatorId),nameof(Gestalt),nameof(IsAbsolute),nameof(Locked),nameof(MeanValue),nameof(SingleValue),nameof(TotalValue),nameof(Type),nameof(Type_Id),nameof(Updated),nameof(VersionNo)})]
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
        public object Clone() => this.Copy<TimePoint>();

    }
    

    public partial class TimePointSearchBase : Search<TimePoint>
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
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
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public TimePointFullTextSearch() {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private TimePointSearch _request;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public TimePointFullTextSearch(TimePointSearch request) => _request = request;
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
        public bool doCreated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(TimePoint.Created))); }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool doUpdated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(TimePoint.Updated))); }

        public bool doIsAbsolute { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(TimePoint.IsAbsolute))); }
        public bool doMeanValue { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(TimePoint.MeanValue))); }
        public bool doSingleValue { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(TimePoint.SingleValue))); }
        public bool doTotalValue { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(TimePoint.TotalValue))); }
        public bool doType { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(TimePoint.Type))); }
    }


    public partial class TimePointBatch : List<TimePoint> { }


}
