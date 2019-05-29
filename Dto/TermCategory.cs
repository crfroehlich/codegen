
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
    public abstract partial class TermCategoryBase : Dto<TermCategory>
    {
        public TermCategoryBase() {}

        public TermCategoryBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public TermCategoryBase(int? id) : this(DocConvert.ToInt(id)) {}

        public TermCategoryBase(int? pId, Reference pParentCategory, int? pParentCategoryId, Reference pScope, int? pScopeId, List<Reference> pTerms, int? pTermsCount) : this(DocConvert.ToInt(pId)) 
        {
            ParentCategory = pParentCategory;
            ParentCategoryId = pParentCategoryId;
            Scope = pScope;
            ScopeId = pScopeId;
            Terms = pTerms;
            TermsCount = pTermsCount;
        }

        [ApiMember(Name = nameof(ParentCategory), Description = "TermCategory", IsRequired = false)]
        public Reference ParentCategory { get; set; }
        [ApiMember(Name = nameof(ParentCategoryId), Description = "Primary Key of TermCategory", IsRequired = false)]
        public int? ParentCategoryId { get; set; }


        [ApiMember(Name = nameof(Scope), Description = "Scope", IsRequired = false)]
        public Reference Scope { get; set; }
        [ApiMember(Name = nameof(ScopeId), Description = "Primary Key of Scope", IsRequired = false)]
        public int? ScopeId { get; set; }


        [ApiMember(Name = nameof(Terms), Description = "TermMaster", IsRequired = false)]
        public List<Reference> Terms { get; set; }
        public List<int> TermsIds { get; set; }
        public int? TermsCount { get; set; }



        public void Deconstruct(out Reference pParentCategory, out int? pParentCategoryId, out Reference pScope, out int? pScopeId, out List<Reference> pTerms, out int? pTermsCount)
        {
            pParentCategory = ParentCategory;
            pParentCategoryId = ParentCategoryId;
            pScope = Scope;
            pScopeId = ScopeId;
            pTerms = Terms;
            pTermsCount = TermsCount;
        }

        //Not ready until C# v8.?
        //public TermCategoryBase With(int? pId = Id, Reference pParentCategory = ParentCategory, int? pParentCategoryId = ParentCategoryId, Reference pScope = Scope, int? pScopeId = ScopeId, List<Reference> pTerms = Terms, int? pTermsCount = TermsCount) => 
        //	new TermCategoryBase(pId, pParentCategory, pParentCategoryId, pScope, pScopeId, pTerms, pTermsCount);

    }


    [Route("/termcategory", "POST")]
    [Route("/termcategory/{Id}", "GET, PATCH, PUT, DELETE")]

    public partial class TermCategory : TermCategoryBase, IReturn<TermCategory>, IDto, ICloneable
    {
        public TermCategory()
        {
            _Constructor();
        }

        public TermCategory(int? id) : base(DocConvert.ToInt(id)) {}
        public TermCategory(int id) : base(id) {}
        public TermCategory(int? pId, Reference pParentCategory, int? pParentCategoryId, Reference pScope, int? pScopeId, List<Reference> pTerms, int? pTermsCount) : 
            base(pId, pParentCategory, pParentCategoryId, pScope, pScopeId, pTerms, pTermsCount) { }
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

        public static List<string> Fields => DocTools.Fields<TermCategory>();

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Created),nameof(CreatorId),nameof(Gestalt),nameof(Locked),nameof(ParentCategory),nameof(ParentCategoryId),nameof(Scope),nameof(ScopeId),nameof(Terms),nameof(TermsCount),nameof(Updated),nameof(VersionNo)})]
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
            nameof(Terms), nameof(TermsCount)
        };
        private List<string> collections { get { return _collections; } }


        public object Clone() => this.Copy<TermCategory>();
    }
    

    [Route("/termcategory/{Id}/copy", "POST")]
    public partial class TermCategoryCopy : TermCategory {}

    public partial class TermCategorySearchBase : Search<TermCategory>
    {
        public int? Id { get; set; }
        public Reference ParentCategory { get; set; }
        public List<int> ParentCategoryIds { get; set; }
        public Reference Scope { get; set; }
        public List<int> ScopeIds { get; set; }
        public List<int> TermsIds { get; set; }
    }


    [Route("/termcategory", "GET")]
    [Route("/termcategory/version", "GET, POST")]
    [Route("/termcategory/search", "GET, POST, DELETE")]

    public partial class TermCategorySearch : TermCategorySearchBase
    {
    }

    public class TermCategoryFullTextSearch
    {
        public TermCategoryFullTextSearch() {}
        private TermCategorySearch _request;
        public TermCategoryFullTextSearch(TermCategorySearch request) => _request = request;

        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(TermCategory.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(TermCategory.Updated))); }

        public bool doName { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(TermCategory.Name))); }
        public bool doParentCategory { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(TermCategory.ParentCategory))); }
        public bool doScope { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(TermCategory.Scope))); }
        public bool doTerms { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(TermCategory.Terms))); }
    }


    [Route("/termcategory/batch", "DELETE, PATCH, POST, PUT")]

    public partial class TermCategoryBatch : List<TermCategory> { }


    [Route("/termcategory/{Id}/{Junction}/version", "GET, POST")]
    [Route("/termcategory/{Id}/{Junction}", "GET, POST, DELETE")]
    public class TermCategoryJunction : TermCategorySearchBase {}



}
