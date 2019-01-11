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
using Typed.Security;
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
    public abstract partial class ComparatorBase : Dto<Comparator>
    {
        public ComparatorBase() {}

        public ComparatorBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public ComparatorBase(int? id) : this(DocConvert.ToInt(id)) {}
    
        [ApiMember(Name = nameof(Name), Description = "string", IsRequired = true)]
        public string Name { get; set; }


        [ApiMember(Name = nameof(URI), Description = "string", IsRequired = false)]
        public string URI { get; set; }


    }

    [Route("/comparator", "POST")]
    [Route("/profile/comparator", "POST")]
    [Route("/comparator/{Id}", "GET, PATCH, PUT, DELETE")]
    [Route("/profile/comparator/{Id}", "GET, PATCH, PUT, DELETE")]
    public partial class Comparator : ComparatorBase, IReturn<Comparator>, IDto
    {
        public Comparator()
        {
            _Constructor();
        }

        public Comparator(int? id) : base(DocConvert.ToInt(id)) {}
        public Comparator(int id) : base(id) {}
        
        #region Fields
        
        public bool? ShouldSerialize(string field)
        {
            if (DocTools.AreEqual(nameof(VisibleFields), field)) return false;
            if (DocTools.AreEqual(nameof(Fields), field)) return false;
            if (DocTools.AreEqual(nameof(AssignFields), field)) return false;
            if (DocTools.AreEqual(nameof(IgnoreCache), field)) return false;
            if (DocTools.AreEqual(nameof(Id), field)) return true;
            return true == VisibleFields?.Matches(field, true);
        }

        public static List<string> Fields => DocTools.Fields<Comparator>();

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Created),nameof(CreatorId),nameof(Gestalt),nameof(Locked),nameof(Name),nameof(Updated),nameof(URI),nameof(VersionNo)})]
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
                _VisibleFields = DocPermissionFactory.SetVisibleFields<Comparator>("Comparator",exists);
            }
        }

        #endregion Fields
    }
    
    [Route("/Comparator/{Id}/copy", "POST")]
    [Route("/profile/Comparator/{Id}/copy", "POST")]
    public partial class ComparatorCopy : Comparator {}
    [Route("/comparator", "GET")]
    [Route("/profile/comparator", "GET")]
    [Route("/comparator/search", "GET, POST, DELETE")]
    [Route("/profile/comparator/search", "GET, POST, DELETE")]
    public partial class ComparatorSearch : Search<Comparator>
    {
        public string Name { get; set; }
        public string URI { get; set; }
    }
    
    public class ComparatorFullTextSearch
    {
        private ComparatorSearch _request;
        public ComparatorFullTextSearch(ComparatorSearch request) => _request = request;
        
        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Comparator.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Comparator.Updated))); }
        
        public bool doName { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Comparator.Name))); }
        public bool doURI { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Comparator.URI))); }
    }

    [Route("/comparator/version", "GET, POST")]
    public partial class ComparatorVersion : ComparatorSearch {}

    [Route("/comparator/batch", "DELETE, PATCH, POST, PUT")]
    [Route("/profile/comparator/batch", "DELETE, PATCH, POST, PUT")]
    public partial class ComparatorBatch : List<Comparator> { }

    [Route("/admin/comparator/ids", "GET, POST")]
    public class ComparatorIds
    {
        public bool All { get; set; }
    }
}