//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated by a T4 template. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when
//    the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AutoMapper;

using Services.Core;
using Services.Db;
using Services.Dto;
using Services.Dto.internals;
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
    public abstract partial class LookupTableBase : Dto<LookupTable>
    {
        public LookupTableBase() {}

        public LookupTableBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public LookupTableBase(int? id) : this(DocConvert.ToInt(id)) {}

        [ApiMember(Name = nameof(Bindings), Description = "LookupTableBinding", IsRequired = false)]
        public List<Reference> Bindings { get; set; }
        public int? BindingsCount { get; set; }


        [ApiMember(Name = nameof(Categories), Description = "LookupCategory", IsRequired = false)]
        public List<Reference> Categories { get; set; }
        public int? CategoriesCount { get; set; }


        [ApiMember(Name = nameof(Documents), Description = "Document", IsRequired = false)]
        public List<Reference> Documents { get; set; }
        public int? DocumentsCount { get; set; }


        [ApiMember(Name = nameof(Enum), Description = "LookupTableEnum", IsRequired = true)]
        public Reference Enum { get; set; }
        [ApiMember(Name = nameof(EnumId), Description = "Primary Key of LookupTableEnum", IsRequired = false)]
        public int? EnumId { get; set; }


        [ApiMember(Name = nameof(Name), Description = "string", IsRequired = true)]
        public string Name { get; set; }


    }

    [Route("/lookuptable", "POST")]
    [Route("/lookuptable/{Id}", "GET, PATCH, PUT, DELETE")]
    public partial class LookupTable : LookupTableBase, IReturn<LookupTable>, IDto
    {
        public LookupTable()
        {
            _Constructor();
        }

        public LookupTable(int? id) : base(DocConvert.ToInt(id)) {}
        public LookupTable(int id) : base(id) {}
        
        #region Fields
        
        public bool? ShouldSerialize(string field)
        {
            if (IgnoredVisibleFields.Matches(field, true)) return false;
            var ret = MandatoryVisibleFields.Matches(field, true) || true == VisibleFields?.Matches(field, true);
            return ret;
        }

        public static List<string> Fields => DocTools.Fields<LookupTable>();

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Bindings),nameof(BindingsCount),nameof(Categories),nameof(CategoriesCount),nameof(Created),nameof(CreatorId),nameof(Documents),nameof(DocumentsCount),nameof(Enum),nameof(EnumId),nameof(Gestalt),nameof(Locked),nameof(Name),nameof(Updated),nameof(VersionNo)})]
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
            nameof(Bindings), nameof(BindingsCount), nameof(Categories), nameof(CategoriesCount), nameof(Documents), nameof(DocumentsCount)
        };
        private List<string> collections { get { return _collections; } }
    }
    
    [Route("/LookupTable/{Id}/copy", "POST")]
    public partial class LookupTableCopy : LookupTable {}
    public partial class LookupTableSearchBase : Search<LookupTable>
    {
        public int? Id { get; set; }
        public List<int> BindingsIds { get; set; }
        public List<int> CategoriesIds { get; set; }
        public List<int> DocumentsIds { get; set; }
        public Reference Enum { get; set; }
        public List<int> EnumIds { get; set; }
        public string Name { get; set; }
    }

    [Route("/lookuptable", "GET")]
    [Route("/lookuptable/version", "GET, POST")]
    [Route("/lookuptable/search", "GET, POST, DELETE")]
    public partial class LookupTableSearch : LookupTableSearchBase
    {
    }

    public class LookupTableFullTextSearch
    {
        public LookupTableFullTextSearch() {}
        private LookupTableSearch _request;
        public LookupTableFullTextSearch(LookupTableSearch request) => _request = request;

        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(LookupTable.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(LookupTable.Updated))); }

        public bool doBindings { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(LookupTable.Bindings))); }
        public bool doCategories { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(LookupTable.Categories))); }
        public bool doDocuments { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(LookupTable.Documents))); }
        public bool doEnum { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(LookupTable.Enum))); }
        public bool doName { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(LookupTable.Name))); }
    }

    [Route("/lookuptable/batch", "DELETE, PATCH, POST, PUT")]
    public partial class LookupTableBatch : List<LookupTable> { }

    [Route("/lookuptable/{Id}/{Junction}/version", "GET, POST")]
    [Route("/lookuptable/{Id}/{Junction}", "GET, POST, DELETE")]
    public class LookupTableJunction : LookupTableSearchBase {}


}
