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
    public abstract partial class FeatureSetBase : Dto<FeatureSet>
    {
        public FeatureSetBase() {}

        public FeatureSetBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public FeatureSetBase(int? id) : this(DocConvert.ToInt(id)) {}

        public FeatureSetBase(int? pId, string pDescription, string pName, string pPermissionTemplate, List<Reference> pRoles, int? pRolesCount) : this(DocConvert.ToInt(pId)) 
        {
            Description = pDescription;
            Name = pName;
            PermissionTemplate = pPermissionTemplate;
            Roles = pRoles;
            RolesCount = pRolesCount;
        }

        [ApiMember(Name = nameof(Description), Description = "string", IsRequired = false)]
        public string Description { get; set; }


        [ApiMember(Name = nameof(Name), Description = "string", IsRequired = true)]
        public string Name { get; set; }


        [ApiMember(Name = nameof(PermissionTemplate), Description = "string", IsRequired = false)]
        public string PermissionTemplate { get; set; }


        [ApiMember(Name = nameof(Roles), Description = "Role", IsRequired = false)]
        public List<Reference> Roles { get; set; }
        public int? RolesCount { get; set; }



        public void Deconstruct(out string pDescription, out string pName, out string pPermissionTemplate, out List<Reference> pRoles, out int? pRolesCount)
        {
            pDescription = Description;
            pName = Name;
            pPermissionTemplate = PermissionTemplate;
            pRoles = Roles;
            pRolesCount = RolesCount;
        }

        //Not ready until C# v8.?
        //public FeatureSetBase With(int? pId = Id, string pDescription = Description, string pName = Name, string pPermissionTemplate = PermissionTemplate, List<Reference> pRoles = Roles, int? pRolesCount = RolesCount) => 
        //	new FeatureSetBase(pId, pDescription, pName, pPermissionTemplate, pRoles, pRolesCount);

    }

    [Route("/featureset/{Id}", "GET, PATCH, PUT")]
    public partial class FeatureSet : FeatureSetBase, IReturn<FeatureSet>, IDto, ICloneable
    {
        public FeatureSet()
        {
            _Constructor();
        }

        public FeatureSet(int? id) : base(DocConvert.ToInt(id)) {}
        public FeatureSet(int id) : base(id) {}
        public FeatureSet(int? pId, string pDescription, string pName, string pPermissionTemplate, List<Reference> pRoles, int? pRolesCount) : 
            base(pId, pDescription, pName, pPermissionTemplate, pRoles, pRolesCount) { }
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

        public static List<string> Fields => DocTools.Fields<FeatureSet>();

        private List<string> _Select;
        [ApiMember(Name = "Select", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Created),nameof(CreatorId),nameof(Description),nameof(Gestalt),nameof(Locked),nameof(Name),nameof(PermissionTemplate),nameof(Roles),nameof(RolesCount),nameof(Updated),nameof(VersionNo)})]
        public new List<string> Select
        {
            get
            {
                if(null == this) return new List<string>();
                if(null == _Select)
                {
                    _Select = DocWebSession.GetTypeSelect(this);
                }
                return _Select;
            }
            set
            {
                var requested = value ?? new List<string>();
                var exists = requested.Where( r => Fields.Any( f => DocTools.AreEqual(r, f) ) ).ToList();
                _Select = DocPermissionFactory.SetSelect<FeatureSet>("FeatureSet",exists);
            }
        }

        #endregion Fields
        private List<string> _collections = new List<string>
        {
            nameof(Roles), nameof(RolesCount)
        };
        private List<string> collections { get { return _collections; } }

        public object Clone() => this.Copy<FeatureSet>();
    }
    
    public partial class FeatureSetSearchBase : Search<FeatureSet>
    {
        public int? Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string PermissionTemplate { get; set; }
        public List<int> RolesIds { get; set; }
    }

    [Route("/featureset", "GET")]
    [Route("/featureset/version", "GET, POST")]
    [Route("/featureset/search", "GET, POST, DELETE")]
    public partial class FeatureSetSearch : FeatureSetSearchBase
    {
    }

    public class FeatureSetFullTextSearch
    {
        public FeatureSetFullTextSearch() {}
        private FeatureSetSearch _request;
        public FeatureSetFullTextSearch(FeatureSetSearch request) => _request = request;

        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(FeatureSet.Created))); }
        public bool doUpdated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(FeatureSet.Updated))); }

        public bool doDescription { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(FeatureSet.Description))); }
        public bool doName { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(FeatureSet.Name))); }
        public bool doPermissionTemplate { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(FeatureSet.PermissionTemplate))); }
        public bool doRoles { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(FeatureSet.Roles))); }
    }

    [Route("/featureset/batch", "DELETE, PATCH, POST, PUT")]
    public partial class FeatureSetBatch : List<FeatureSet> { }

    [Route("/featureset/{Id}/{Junction}/version", "GET, POST")]
    [Route("/featureset/{Id}/{Junction}", "GET, POST, DELETE")]
    public class FeatureSetJunction : FeatureSetSearchBase {}


}
