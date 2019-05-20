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
    public abstract partial class LookupTableEnumBase : Dto<LookupTableEnum>
    {
        public LookupTableEnumBase() {}

        public LookupTableEnumBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public LookupTableEnumBase(int? id) : this(DocConvert.ToInt(id)) {}

        public LookupTableEnumBase(int? pId, bool pIsBindable, bool pIsGlobal, string pName) : this(DocConvert.ToInt(pId)) 
        {
            IsBindable = pIsBindable;
            IsGlobal = pIsGlobal;
            Name = pName;
        }

        [ApiMember(Name = nameof(IsBindable), Description = "bool", IsRequired = false)]
        public bool IsBindable { get; set; }


        [ApiMember(Name = nameof(IsGlobal), Description = "bool", IsRequired = false)]
        public bool IsGlobal { get; set; }


        [ApiMember(Name = nameof(Name), Description = "string", IsRequired = true)]
        public string Name { get; set; }



        public void Deconstruct(out bool pIsBindable, out bool pIsGlobal, out string pName)
        {
            pIsBindable = IsBindable;
            pIsGlobal = IsGlobal;
            pName = Name;
        }

        //Not ready until C# v8.?
        //public LookupTableEnumBase With(int? pId = Id, bool pIsBindable = IsBindable, bool pIsGlobal = IsGlobal, string pName = Name) => 
        //	new LookupTableEnumBase(pId, pIsBindable, pIsGlobal, pName);

    }

    [Route("/lookuptableenum", "POST")]
    [Route("/lookuptableenum/{Id}", "GET, PATCH, PUT, DELETE")]
    public partial class LookupTableEnum : LookupTableEnumBase, IReturn<LookupTableEnum>, IDto, ICloneable
    {
        public LookupTableEnum()
        {
            _Constructor();
        }

        public LookupTableEnum(int? id) : base(DocConvert.ToInt(id)) {}
        public LookupTableEnum(int id) : base(id) {}
        public LookupTableEnum(int? pId, bool pIsBindable, bool pIsGlobal, string pName) : 
            base(pId, pIsBindable, pIsGlobal, pName) { }
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

        public static List<string> Fields => DocTools.Fields<LookupTableEnum>();

        private List<string> _Select;
        [ApiMember(Name = "Select", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Created),nameof(CreatorId),nameof(Gestalt),nameof(IsBindable),nameof(IsGlobal),nameof(Locked),nameof(Name),nameof(Updated),nameof(VersionNo)})]
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

        public object Clone() => this.Copy<LookupTableEnum>();
    }
    
    [Route("/lookuptableenum/{Id}/copy", "POST")]
    public partial class LookupTableEnumCopy : LookupTableEnum {}
    public partial class LookupTableEnumSearchBase : Search<LookupTableEnum>
    {
        public int? Id { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> IsBindable { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> IsGlobal { get; set; }
        public string Name { get; set; }
    }

    [Route("/lookuptableenum", "GET")]
    [Route("/lookuptableenum/version", "GET, POST")]
    [Route("/lookuptableenum/search", "GET, POST, DELETE")]
    public partial class LookupTableEnumSearch : LookupTableEnumSearchBase
    {
    }

    public class LookupTableEnumFullTextSearch
    {
        public LookupTableEnumFullTextSearch() {}
        private LookupTableEnumSearch _request;
        public LookupTableEnumFullTextSearch(LookupTableEnumSearch request) => _request = request;

        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(LookupTableEnum.Created))); }
        public bool doUpdated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(LookupTableEnum.Updated))); }

        public bool doIsBindable { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(LookupTableEnum.IsBindable))); }
        public bool doIsGlobal { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(LookupTableEnum.IsGlobal))); }
        public bool doName { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(LookupTableEnum.Name))); }
    }

    [Route("/lookuptableenum/batch", "DELETE, PATCH, POST, PUT")]
    public partial class LookupTableEnumBatch : List<LookupTableEnum> { }

}
