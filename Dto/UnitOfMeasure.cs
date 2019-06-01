
//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated by a T4 template. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
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
    public abstract partial class UnitOfMeasureBase : Dto<UnitOfMeasure>
    {
        public UnitOfMeasureBase() {}

        public UnitOfMeasureBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public UnitOfMeasureBase(int? id) : this(DocConvert.ToInt(id)) {}

        public UnitOfMeasureBase(int? pId, bool pIsSI, Reference pName, int? pNameId, Reference pType, int? pTypeId, Reference pUnit, int? pUnitId) : this(DocConvert.ToInt(pId)) 
        {
            IsSI = pIsSI;
            Name = pName;
            NameId = pNameId;
            Type = pType;
            TypeId = pTypeId;
            Unit = pUnit;
            UnitId = pUnitId;
        }

        [ApiMember(Name = nameof(IsSI), Description = "bool", IsRequired = false)]
        public bool IsSI { get; set; }


        [ApiMember(Name = nameof(Name), Description = "LookupTable", IsRequired = true)]
        public Reference Name { get; set; }
        [ApiMember(Name = nameof(NameId), Description = "Primary Key of LookupTable", IsRequired = false)]
        public int? NameId { get; set; }


        [ApiAllowableValues("Includes", Values = new string[] {@"Amount",@"Area",@"Concentration",@"Concentration Molar",@"Concentration Solution",@"Label",@"Length",@"Mass",@"Moles",@"NonTime",@"NonUnit",@"Radiation",@"Time",@"Volume",@"Weight"})]
        [ApiMember(Name = nameof(Type), Description = "LookupTable", IsRequired = true)]
        public Reference Type { get; set; }
        [ApiMember(Name = nameof(TypeId), Description = "Primary Key of LookupTable", IsRequired = false)]
        public int? TypeId { get; set; }


        [ApiMember(Name = nameof(Unit), Description = "LookupTable", IsRequired = false)]
        public Reference Unit { get; set; }
        [ApiMember(Name = nameof(UnitId), Description = "Primary Key of LookupTable", IsRequired = false)]
        public int? UnitId { get; set; }



        public void Deconstruct(out bool pIsSI, out Reference pName, out int? pNameId, out Reference pType, out int? pTypeId, out Reference pUnit, out int? pUnitId)
        {
            pIsSI = IsSI;
            pName = Name;
            pNameId = NameId;
            pType = Type;
            pTypeId = TypeId;
            pUnit = Unit;
            pUnitId = UnitId;
        }

        //Not ready until C# v8.?
        //public UnitOfMeasureBase With(int? pId = Id, bool pIsSI = IsSI, Reference pName = Name, int? pNameId = NameId, Reference pType = Type, int? pTypeId = TypeId, Reference pUnit = Unit, int? pUnitId = UnitId) => 
        //	new UnitOfMeasureBase(pId, pIsSI, pName, pNameId, pType, pTypeId, pUnit, pUnitId);

    }


    [Route("/unitofmeasure", "POST")]
    [Route("/unitofmeasure/{Id}", "GET, PATCH, PUT, DELETE")]

    public partial class UnitOfMeasure : UnitOfMeasureBase, IReturn<UnitOfMeasure>, IDto, ICloneable
    {
        public UnitOfMeasure()
        {
            _Constructor();
        }

        public UnitOfMeasure(int? id) : base(DocConvert.ToInt(id)) {}
        public UnitOfMeasure(int id) : base(id) {}
        public UnitOfMeasure(int? pId, bool pIsSI, Reference pName, int? pNameId, Reference pType, int? pTypeId, Reference pUnit, int? pUnitId) : 
            base(pId, pIsSI, pName, pNameId, pType, pTypeId, pUnit, pUnitId) { }
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

        public static List<string> Fields => DocTools.Fields<UnitOfMeasure>();

        private List<string> _Select;
        [ApiMember(Name = "Select", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Created),nameof(CreatorId),nameof(Gestalt),nameof(IsSI),nameof(Locked),nameof(Name),nameof(NameId),nameof(Type),nameof(TypeId),nameof(Unit),nameof(UnitId),nameof(Updated),nameof(VersionNo)})]
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


        public object Clone() => this.Copy<UnitOfMeasure>();

    }
    

    [Route("/unitofmeasure/{Id}/copy", "POST")]
    public partial class UnitOfMeasureCopy : UnitOfMeasure {}

    public partial class UnitOfMeasureSearchBase : Search<UnitOfMeasure>
    {
        public int? Id { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> IsSI { get; set; }
        public Reference Name { get; set; }
        public List<int> NameIds { get; set; }
        public List<string> NameNames { get; set; }
        public Reference Type { get; set; }
        public List<int> TypeIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"Amount",@"Area",@"Concentration",@"Concentration Molar",@"Concentration Solution",@"Label",@"Length",@"Mass",@"Moles",@"NonTime",@"NonUnit",@"Radiation",@"Time",@"Volume",@"Weight"})]
        public List<string> TypeNames { get; set; }
        public Reference Unit { get; set; }
        public List<int> UnitIds { get; set; }
        public List<string> UnitNames { get; set; }
    }


    [Route("/unitofmeasure", "GET")]
    [Route("/unitofmeasure/version", "GET, POST")]
    [Route("/unitofmeasure/search", "GET, POST, DELETE")]

    public partial class UnitOfMeasureSearch : UnitOfMeasureSearchBase
    {
    }

    public class UnitOfMeasureFullTextSearch
    {
        public UnitOfMeasureFullTextSearch() {}
        private UnitOfMeasureSearch _request;
        public UnitOfMeasureFullTextSearch(UnitOfMeasureSearch request) => _request = request;

        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(UnitOfMeasure.Created))); }
        public bool doUpdated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(UnitOfMeasure.Updated))); }

        public bool doIsSI { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(UnitOfMeasure.IsSI))); }
        public bool doName { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(UnitOfMeasure.Name))); }
        public bool doType { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(UnitOfMeasure.Type))); }
        public bool doUnit { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(UnitOfMeasure.Unit))); }
    }


    [Route("/unitofmeasure/batch", "DELETE, PATCH, POST, PUT")]

    public partial class UnitOfMeasureBatch : List<UnitOfMeasure> { }


}
