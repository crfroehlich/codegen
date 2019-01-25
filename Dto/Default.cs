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
    public abstract partial class DefaultBase : Dto<Default>
    {
        public DefaultBase() {}

        public DefaultBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public DefaultBase(int? id) : this(DocConvert.ToInt(id)) {}
    
        [ApiMember(Name = nameof(DiseaseState), Description = "DocumentSet", IsRequired = true)]
        public Reference DiseaseState { get; set; }
        [ApiMember(Name = nameof(DiseaseStateId), Description = "Primary Key of DocumentSet", IsRequired = false)]
        public int? DiseaseStateId { get; set; }


        [ApiMember(Name = nameof(Role), Description = "Role", IsRequired = false)]
        public Reference Role { get; set; }
        [ApiMember(Name = nameof(RoleId), Description = "Primary Key of Role", IsRequired = false)]
        public int? RoleId { get; set; }


        [ApiMember(Name = nameof(Scope), Description = "Scope", IsRequired = true)]
        public Reference Scope { get; set; }
        [ApiMember(Name = nameof(ScopeId), Description = "Primary Key of Scope", IsRequired = false)]
        public int? ScopeId { get; set; }


        [ApiMember(Name = nameof(TherapeuticArea), Description = "DocumentSet", IsRequired = true)]
        public Reference TherapeuticArea { get; set; }
        [ApiMember(Name = nameof(TherapeuticAreaId), Description = "Primary Key of DocumentSet", IsRequired = false)]
        public int? TherapeuticAreaId { get; set; }


    }

    [Route("/default", "POST")]
    [Route("/default/{Id}", "GET, PATCH, PUT")]
    public partial class Default : DefaultBase, IReturn<Default>, IDto
    {
        public Default()
        {
            _Constructor();
        }

        public Default(int? id) : base(DocConvert.ToInt(id)) {}
        public Default(int id) : base(id) {}
        
        #region Fields
        
        public bool? ShouldSerialize(string field)
        {
            if (IgnoredVisibleFields.Matches(field, true)) return false;
            var ret = MandatoryVisibleFields.Matches(field, true) || true == VisibleFields?.Matches(field, true);
            return ret;
        }

        public static List<string> Fields => DocTools.Fields<Default>();

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Created),nameof(CreatorId),nameof(DiseaseState),nameof(DiseaseStateId),nameof(Gestalt),nameof(Locked),nameof(Role),nameof(RoleId),nameof(Scope),nameof(ScopeId),nameof(TherapeuticArea),nameof(TherapeuticAreaId),nameof(Updated),nameof(VersionNo)})]
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
                _VisibleFields = DocPermissionFactory.SetVisibleFields<Default>("Default",exists);
            }
        }

        #endregion Fields
    }
    
    [Route("/Default/{Id}/copy", "POST")]
    public partial class DefaultCopy : Default {}
    public partial class DefaultSearchBase : Search<Default>
    {
        public Reference DiseaseState { get; set; }
        public List<int> DiseaseStateIds { get; set; }
        public Reference Role { get; set; }
        public List<int> RoleIds { get; set; }
        public Reference Scope { get; set; }
        public List<int> ScopeIds { get; set; }
        public Reference TherapeuticArea { get; set; }
        public List<int> TherapeuticAreaIds { get; set; }
    }

    [Route("/default", "GET")]
    [Route("/default/search", "GET, POST, DELETE")]
    public partial class DefaultSearch : DefaultSearchBase
    {
    }

    public class DefaultFullTextSearch
    {
        public DefaultFullTextSearch() {}
        private DefaultSearch _request;
        public DefaultFullTextSearch(DefaultSearch request) => _request = request;
        
        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Default.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Default.Updated))); }
        
        public bool doDiseaseState { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Default.DiseaseState))); }
        public bool doRole { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Default.Role))); }
        public bool doScope { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Default.Scope))); }
        public bool doTherapeuticArea { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Default.TherapeuticArea))); }
    }

    [Route("/default/version", "GET, POST")]
    public partial class DefaultVersion : DefaultSearch {}

    [Route("/default/batch", "DELETE, PATCH, POST, PUT")]
    public partial class DefaultBatch : List<Default> { }

    [Route("/admin/default/ids", "GET, POST")]
    public class DefaultIds
    {
        public bool All { get; set; }
    }
}