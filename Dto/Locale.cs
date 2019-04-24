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
    public abstract partial class LocaleBase : Dto<Locale>
    {
        public LocaleBase() {}

        public LocaleBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public LocaleBase(int? id) : this(DocConvert.ToInt(id)) {}

        public LocaleBase(int? pId, string pCountry, string pLanguage, string pTimeZone) : this(DocConvert.ToInt(pId)) 
        {
            Country = pCountry;
            Language = pLanguage;
            TimeZone = pTimeZone;
        }

        [ApiMember(Name = nameof(Country), Description = "string", IsRequired = true)]
        public string Country { get; set; }


        [ApiMember(Name = nameof(Language), Description = "string", IsRequired = true)]
        public string Language { get; set; }


        [ApiMember(Name = nameof(TimeZone), Description = "string", IsRequired = true)]
        public string TimeZone { get; set; }



        public void Deconstruct(out string pCountry, out string pLanguage, out string pTimeZone)
        {
            pCountry = Country;
            pLanguage = Language;
            pTimeZone = TimeZone;
        }

        //Not ready until C# v8.?
        //public LocaleBase With(int? pId = Id, string pCountry = Country, string pLanguage = Language, string pTimeZone = TimeZone) => 
        //	new LocaleBase(pId, pCountry, pLanguage, pTimeZone);

    }

    [Route("/locale", "POST")]
    [Route("/locale/{Id}", "GET")]
    public partial class Locale : LocaleBase, IReturn<Locale>, IDto, ICloneable
    {
        public Locale()
        {
            _Constructor();
        }

        public Locale(int? id) : base(DocConvert.ToInt(id)) {}
        public Locale(int id) : base(id) {}
        public Locale(int? pId, string pCountry, string pLanguage, string pTimeZone) : 
            base(pId, pCountry, pLanguage, pTimeZone) { }
        #region Fields

        public new bool? ShouldSerialize(string field)
        {
            //Allow individual classes to specify their own logic
            var manualOverride = _ShouldSerialize(field);
            if(null != manualOverride) return manualOverride;

            if (IgnoredVisibleFields.Matches(field, true)) return false;
            var ret = MandatoryVisibleFields.Matches(field, true) || true == VisibleFields?.Matches(field, true);
            return ret;
        }

        public static List<string> Fields => DocTools.Fields<Locale>();

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Country),nameof(Created),nameof(CreatorId),nameof(Gestalt),nameof(Language),nameof(Locked),nameof(TimeZone),nameof(Updated),nameof(VersionNo)})]
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
                _VisibleFields = DocPermissionFactory.SetVisibleFields<Locale>("Locale",exists);
            }
        }

        #endregion Fields

        public object Clone() => this.Copy<Locale>();
    }
    
    [Route("/locale/{Id}/copy", "POST")]
    public partial class LocaleCopy : Locale {}
    public partial class LocaleSearchBase : Search<Locale>
    {
        public int? Id { get; set; }
        public string Country { get; set; }
        public string Language { get; set; }
        public string TimeZone { get; set; }
    }

    [Route("/locale", "GET")]
    [Route("/locale/version", "GET, POST")]
    [Route("/locale/search", "GET, POST, DELETE")]
    public partial class LocaleSearch : LocaleSearchBase
    {
    }

    public class LocaleFullTextSearch
    {
        public LocaleFullTextSearch() {}
        private LocaleSearch _request;
        public LocaleFullTextSearch(LocaleSearch request) => _request = request;

        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Locale.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Locale.Updated))); }

        public bool doCountry { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Locale.Country))); }
        public bool doLanguage { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Locale.Language))); }
        public bool doTimeZone { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Locale.TimeZone))); }
    }

    [Route("/locale/batch", "DELETE, PATCH, POST, PUT")]
    public partial class LocaleBatch : List<Locale> { }

}
