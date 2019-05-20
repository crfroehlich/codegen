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
    public abstract partial class UnitsBase : Dto<UnitsDto>
    {
        public UnitsBase() {}

        public UnitsBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public UnitsBase(int? id) : this(DocConvert.ToInt(id)) {}

        public UnitsBase(int? pId, bool isDummyParam) : this(DocConvert.ToInt(pId)) 
        {

        }




        public void Deconstruct(bool isDummyParam)
        {

        }

        //Not ready until C# v8.?
        //public UnitsBase With(int? pId = Id, ) => 
        //	new UnitsBase(pId, isDummyParam);

    }

    public partial class UnitsDto : UnitsBase, IReturn<UnitsDto>, IDto, ICloneable
    {
        public UnitsDto()
        {
            _Constructor();
        }

        public UnitsDto(int? id) : base(DocConvert.ToInt(id)) {}
        public UnitsDto(int id) : base(id) {}
        public UnitsDto(int? pId, bool isDummyParam) : 
            base(pId, isDummyParam) { }
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

        public static List<string> Fields => DocTools.Fields<UnitsDto>();

        private List<string> _Select;
        [ApiMember(Name = "Select", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Created),nameof(CreatorId),nameof(Gestalt),nameof(Locked),nameof(Units),nameof(Updated),nameof(VersionNo)})]
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
        private List<string> _collections = new List<string>
        {
            nameof(Units), nameof(Units), nameof(UnitsCount)
        };
        private List<string> collections { get { return _collections; } }

        public object Clone() => this.Copy<UnitsDto>();
    }
    
    public partial class UnitsSearchBase : Search<UnitsDto>
    {
        public int? Id { get; set; }
        public List<int> UnitsIds { get; set; }
    }

    public partial class UnitsSearch : UnitsSearchBase
    {
    }

    public class UnitsFullTextSearch
    {
        public UnitsFullTextSearch() {}
        private UnitsSearch _request;
        public UnitsFullTextSearch(UnitsSearch request) => _request = request;

        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(UnitsDto.Created))); }
        public bool doUpdated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(UnitsDto.Updated))); }

        public bool doUnits { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(UnitsDto.Units))); }
    }

    public partial class UnitsBatch : List<UnitsDto> { }

    [Route("/units/{Id}/{Junction}/version", "GET, POST")]
    [Route("/units/{Id}/{Junction}", "GET, POST, DELETE")]
    public class UnitsJunction : UnitsSearchBase {}


}
