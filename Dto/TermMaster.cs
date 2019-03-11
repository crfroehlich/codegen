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
    public abstract partial class TermMasterBase : Dto<TermMaster>
    {
        public TermMasterBase() {}

        public TermMasterBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public TermMasterBase(int? id) : this(DocConvert.ToInt(id)) {}

        [ApiMember(Name = nameof(BioPortal), Description = "string", IsRequired = false)]
        public string BioPortal { get; set; }


        [ApiMember(Name = nameof(Categories), Description = "TermCategory", IsRequired = false)]
        public List<TermCategory> Categories { get; set; }
        public int? CategoriesCount { get; set; }


        [ApiMember(Name = nameof(CUI), Description = "string", IsRequired = false)]
        public string CUI { get; set; }


        [ApiMember(Name = nameof(Enum), Description = "LookupTableEnum", IsRequired = true)]
        public Reference Enum { get; set; }
        [ApiMember(Name = nameof(EnumId), Description = "Primary Key of LookupTableEnum", IsRequired = false)]
        public int? EnumId { get; set; }


        [ApiMember(Name = nameof(MedDRA), Description = "string", IsRequired = false)]
        public string MedDRA { get; set; }


        [ApiMember(Name = nameof(Name), Description = "string", IsRequired = true)]
        public string Name { get; set; }


        [ApiMember(Name = nameof(RxNorm), Description = "string", IsRequired = false)]
        public string RxNorm { get; set; }


        [ApiMember(Name = nameof(SNOWMED), Description = "string", IsRequired = false)]
        public string SNOWMED { get; set; }


        [ApiMember(Name = nameof(Synonyms), Description = "TermSynonym", IsRequired = false)]
        public List<Reference> Synonyms { get; set; }
        public int? SynonymsCount { get; set; }


        [ApiMember(Name = nameof(TUI), Description = "string", IsRequired = false)]
        public string TUI { get; set; }


        [ApiMember(Name = nameof(URI), Description = "string", IsRequired = false)]
        public string URI { get; set; }


    }

    [Route("/termmaster", "POST")]
    [Route("/termmaster/{Id}", "GET, PATCH, PUT, DELETE")]
    public partial class TermMaster : TermMasterBase, IReturn<TermMaster>, IDto
    {
        public TermMaster()
        {
            _Constructor();
        }

        public TermMaster(int? id) : base(DocConvert.ToInt(id)) {}
        public TermMaster(int id) : base(id) {}
        
        #region Fields
        
        public bool? ShouldSerialize(string field)
        {
            if (IgnoredVisibleFields.Matches(field, true)) return false;
            var ret = MandatoryVisibleFields.Matches(field, true) || true == VisibleFields?.Matches(field, true);
            return ret;
        }

        public static List<string> Fields => DocTools.Fields<TermMaster>();

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(BioPortal),nameof(Categories),nameof(CategoriesCount),nameof(Created),nameof(CreatorId),nameof(CUI),nameof(Enum),nameof(EnumId),nameof(Gestalt),nameof(Locked),nameof(MedDRA),nameof(Name),nameof(RxNorm),nameof(SNOWMED),nameof(Synonyms),nameof(SynonymsCount),nameof(TUI),nameof(Updated),nameof(URI),nameof(VersionNo)})]
        public new List<string> VisibleFields
        {
            get
            {
                if(null == this) return new List<string>();
                if(null == _VisibleFields)
                {
                    _VisibleFields = DocWebSession.GetTypeVisibleFields(this);
                }
                return _VisibleFields;
            }
            set
            {
                var requested = value ?? new List<string>();
                var exists = requested.Where( r => Fields.Any( f => DocTools.AreEqual(r, f) ) ).ToList();
                _VisibleFields = DocPermissionFactory.SetVisibleFields<TermMaster>("TermMaster",exists);
            }
        }

        #endregion Fields
        private List<string> _collections = new List<string>
        {
            nameof(Categories), nameof(CategoriesCount), nameof(Synonyms), nameof(SynonymsCount)
        };
        private List<string> collections { get { return _collections; } }
    }
    
    [Route("/TermMaster/{Id}/copy", "POST")]
    public partial class TermMasterCopy : TermMaster {}
    public partial class TermMasterSearchBase : Search<TermMaster>
    {
        public int? Id { get; set; }
        public string BioPortal { get; set; }
        public List<int> CategoriesIds { get; set; }
        public string CUI { get; set; }
        public Reference Enum { get; set; }
        public List<int> EnumIds { get; set; }
        public string MedDRA { get; set; }
        public string Name { get; set; }
        public string RxNorm { get; set; }
        public string SNOWMED { get; set; }
        public List<int> SynonymsIds { get; set; }
        public string TUI { get; set; }
        public string URI { get; set; }
    }

    [Route("/termmaster", "GET")]
    [Route("/termmaster/version", "GET, POST")]
    [Route("/termmaster/search", "GET, POST, DELETE")]
    public partial class TermMasterSearch : TermMasterSearchBase
    {
    }

    public class TermMasterFullTextSearch
    {
        public TermMasterFullTextSearch() {}
        private TermMasterSearch _request;
        public TermMasterFullTextSearch(TermMasterSearch request) => _request = request;

        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(TermMaster.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(TermMaster.Updated))); }

        public bool doBioPortal { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(TermMaster.BioPortal))); }
        public bool doCategories { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(TermMaster.Categories))); }
        public bool doCUI { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(TermMaster.CUI))); }
        public bool doEnum { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(TermMaster.Enum))); }
        public bool doMedDRA { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(TermMaster.MedDRA))); }
        public bool doName { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(TermMaster.Name))); }
        public bool doRxNorm { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(TermMaster.RxNorm))); }
        public bool doSNOWMED { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(TermMaster.SNOWMED))); }
        public bool doSynonyms { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(TermMaster.Synonyms))); }
        public bool doTUI { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(TermMaster.TUI))); }
        public bool doURI { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(TermMaster.URI))); }
    }

    [Route("/termmaster/batch", "DELETE, PATCH, POST, PUT")]
    public partial class TermMasterBatch : List<TermMaster> { }

    [Route("/termmaster/{Id}/{Junction}/version", "GET, POST")]
    [Route("/termmaster/{Id}/{Junction}", "GET, POST, DELETE")]
    public class TermMasterJunction : TermMasterSearchBase {}


}
