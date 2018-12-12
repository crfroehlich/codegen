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
    public abstract partial class OutcomeBase : Dto<OutcomeDto>
    {
        public OutcomeBase() {}

        public OutcomeBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public OutcomeBase(int? id) : this(DocConvert.ToInt(id)) {}
    
        [ApiMember(Name = nameof(Outcome), Description = "LookupTable", IsRequired = true)]
        public Reference Outcome { get; set; }
        [ApiMember(Name = nameof(OutcomeId), Description = "Primary Key of LookupTable", IsRequired = false)]
        public int? OutcomeId { get; set; }


    }

    [Route("/outcome", "POST")]
    [Route("/profile/outcome", "POST")]
    [Route("/outcome/{Id}", "GET, PATCH, PUT, DELETE")]
    [Route("/profile/outcome/{Id}", "GET, PATCH, PUT, DELETE")]
    public partial class OutcomeDto : OutcomeBase, IReturn<OutcomeDto>, IDto
    {
        public OutcomeDto()
        {
            _Constructor();
        }

        public OutcomeDto(int? id) : base(DocConvert.ToInt(id)) {}
        public OutcomeDto(int id) : base(id) {}
        
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

        private static List<string> _fields;
        public static List<string> Fields => _fields ?? (_fields = DocTools.Fields<OutcomeDto>());

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Created),nameof(CreatorId),nameof(Gestalt),nameof(Locked),nameof(Outcome),nameof(OutcomeId),nameof(Updated),nameof(VersionNo)})]
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
    }
    
    [Route("/Outcome/{Id}/copy", "POST")]
    [Route("/profile/Outcome/{Id}/copy", "POST")]
    public partial class OutcomeDtoCopy : OutcomeDto {}
    [Route("/outcome", "GET")]
    [Route("/profile/outcome", "GET")]
    [Route("/outcome/search", "GET, POST, DELETE")]
    [Route("/profile/outcome/search", "GET, POST, DELETE")]
    public partial class OutcomeSearch : Search<OutcomeDto>
    {
        public Reference Outcome { get; set; }
        public List<int> OutcomeIds { get; set; }
        public List<string> OutcomeNames { get; set; }
    }
    
    public class OutcomeFullTextSearch
    {
        private OutcomeSearch _request;
        public OutcomeFullTextSearch(OutcomeSearch request) => _request = request;
        
        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(OutcomeDto.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(OutcomeDto.Updated))); }
        
        public bool doOutcome { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(OutcomeDto.Outcome))); }
    }

    [Route("/outcome/version", "GET, POST")]
    public partial class OutcomeVersion : OutcomeSearch {}

    [Route("/outcome/batch", "DELETE, PATCH, POST, PUT")]
    [Route("/profile/outcome/batch", "DELETE, PATCH, POST, PUT")]
    public partial class OutcomeBatch : List<OutcomeDto> { }

    [Route("/admin/outcome/ids", "GET, POST")]
    public class OutcomeIds
    {
        public bool All { get; set; }
    }
}