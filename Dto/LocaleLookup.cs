﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when
//    the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AutoMapper;

using Services.Core;
using Services.Db;
using Services.Dto;
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
    public abstract partial class LocaleLookupBase : Dto<LocaleLookup>
    {
        public LocaleLookupBase() {}

        public LocaleLookupBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public LocaleLookupBase(int? id) : this(DocConvert.ToInt(id)) {}
    
        [ApiMember(Name = nameof(Data), Description = "IpData", IsRequired = false)]
        public IpData Data { get; set; }


        [ApiMember(Name = nameof(IpAddress), Description = "string", IsRequired = true)]
        public string IpAddress { get; set; }


        [ApiMember(Name = nameof(Locale), Description = "Locale", IsRequired = true)]
        public Reference Locale { get; set; }
        [ApiMember(Name = nameof(LocaleId), Description = "Primary Key of Locale", IsRequired = false)]
        public int? LocaleId { get; set; }


    }

    [Route("/localelookup", "POST")]
    [Route("/localelookup/{Id}", "GET")]
    public partial class LocaleLookup : LocaleLookupBase, IReturn<LocaleLookup>, IDto
    {
        public LocaleLookup()
        {
            _Constructor();
        }

        public LocaleLookup(int? id) : base(DocConvert.ToInt(id)) {}
        public LocaleLookup(int id) : base(id) {}
        
        #region Fields
        
        public bool? ShouldSerialize(string field)
        {
            if (IgnoredVisibleFields.Matches(field, true)) return false;
            var ret = MandatoryVisibleFields.Matches(field, true) || true == VisibleFields?.Matches(field, true);
            return ret;
        }

        public static List<string> Fields => DocTools.Fields<LocaleLookup>();

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Created),nameof(CreatorId),nameof(Data),nameof(Gestalt),nameof(IpAddress),nameof(Locale),nameof(LocaleId),nameof(Locked),nameof(Updated),nameof(VersionNo)})]
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
                _VisibleFields = DocPermissionFactory.SetVisibleFields<LocaleLookup>("LocaleLookup",exists);
            }
        }

        #endregion Fields
    }
    
    [Route("/LocaleLookup/{Id}/copy", "POST")]
    public partial class LocaleLookupCopy : LocaleLookup {}
    [Route("/localelookup", "GET")]
    [Route("/localelookup/search", "GET, POST, DELETE")]
    public partial class LocaleLookupSearch : Search<LocaleLookup>
    {
        public string Data { get; set; }
        public string IpAddress { get; set; }
        public Reference Locale { get; set; }
        public List<int> LocaleIds { get; set; }
    }
    
    public class LocaleLookupFullTextSearch
    {
        private LocaleLookupSearch _request;
        public LocaleLookupFullTextSearch(LocaleLookupSearch request) => _request = request;
        
        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(LocaleLookup.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(LocaleLookup.Updated))); }
        
        public bool doData { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(LocaleLookup.Data))); }
        public bool doIpAddress { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(LocaleLookup.IpAddress))); }
        public bool doLocale { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(LocaleLookup.Locale))); }
    }

    [Route("/localelookup/version", "GET, POST")]
    public partial class LocaleLookupVersion : LocaleLookupSearch {}

    [Route("/localelookup/batch", "DELETE, PATCH, POST, PUT")]
    public partial class LocaleLookupBatch : List<LocaleLookup> { }

    [Route("/admin/localelookup/ids", "GET, POST")]
    public class LocaleLookupIds
    {
        public bool All { get; set; }
    }
}