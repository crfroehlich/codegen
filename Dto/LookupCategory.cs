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
    public abstract partial class LookupCategoryBase : Dto<LookupCategory>
    {
        public LookupCategoryBase() {}

        public LookupCategoryBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public LookupCategoryBase(int? id) : this(DocConvert.ToInt(id)) {}

        [ApiMember(Name = nameof(Category), Description = "string", IsRequired = true)]
        public string Category { get; set; }


        [ApiMember(Name = nameof(Enum), Description = "LookupTableEnum", IsRequired = true)]
        public Reference Enum { get; set; }
        [ApiMember(Name = nameof(EnumId), Description = "Primary Key of LookupTableEnum", IsRequired = false)]
        public int? EnumId { get; set; }


        [ApiMember(Name = nameof(Lookups), Description = "LookupTable", IsRequired = false)]
        public List<Reference> Lookups { get; set; }
        public int? LookupsCount { get; set; }


    }

    [Route("/lookupcategory", "POST")]
    [Route("/lookupcategory/{Id}", "GET, PATCH, PUT, DELETE")]
    public partial class LookupCategory : LookupCategoryBase, IReturn<LookupCategory>, IDto
    {
        public LookupCategory()
        {
            _Constructor();
        }

        public LookupCategory(int? id) : base(DocConvert.ToInt(id)) {}
        public LookupCategory(int id) : base(id) {}
        
        #region Fields
        
        public bool? ShouldSerialize(string field)
        {
            if (IgnoredVisibleFields.Matches(field, true)) return false;
            var ret = MandatoryVisibleFields.Matches(field, true) || true == VisibleFields?.Matches(field, true);
            return ret;
        }

        public static List<string> Fields => DocTools.Fields<LookupCategory>();

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Category),nameof(Created),nameof(CreatorId),nameof(Enum),nameof(EnumId),nameof(Gestalt),nameof(Locked),nameof(Lookups),nameof(LookupsCount),nameof(Updated),nameof(VersionNo)})]
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
            nameof(Lookups), nameof(LookupsCount)
        };
        private List<string> collections { get { return _collections; } }
    }
    
    [Route("/LookupCategory/{Id}/copy", "POST")]
    public partial class LookupCategoryCopy : LookupCategory {}
    public partial class LookupCategorySearchBase : Search<LookupCategory>
    {
        public int? Id { get; set; }
        public string Category { get; set; }
        public Reference Enum { get; set; }
        public List<int> EnumIds { get; set; }
        public List<int> LookupsIds { get; set; }
    }

    [Route("/lookupcategory", "GET")]
    [Route("/lookupcategory/version", "GET, POST")]
    [Route("/lookupcategory/search", "GET, POST, DELETE")]
    public partial class LookupCategorySearch : LookupCategorySearchBase
    {
    }

    public class LookupCategoryFullTextSearch
    {
        public LookupCategoryFullTextSearch() {}
        private LookupCategorySearch _request;
        public LookupCategoryFullTextSearch(LookupCategorySearch request) => _request = request;

        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(LookupCategory.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(LookupCategory.Updated))); }

        public bool doCategory { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(LookupCategory.Category))); }
        public bool doEnum { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(LookupCategory.Enum))); }
        public bool doLookups { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(LookupCategory.Lookups))); }
    }

    [Route("/lookupcategory/batch", "DELETE, PATCH, POST, PUT")]
    public partial class LookupCategoryBatch : List<LookupCategory> { }

    [Route("/lookupcategory/{Id}/{Junction}/version", "GET, POST")]
    [Route("/lookupcategory/{Id}/{Junction}", "GET, POST, DELETE")]
    public class LookupCategoryJunction : LookupCategorySearchBase {}


}
