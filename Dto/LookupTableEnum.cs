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
    public abstract partial class LookupTableEnumBase : Dto<LookupTableEnum>
    {
        public LookupTableEnumBase() {}

        public LookupTableEnumBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public LookupTableEnumBase(int? id) : this(DocConvert.ToInt(id)) {}
    
        [ApiMember(Name = nameof(IsBindable), Description = "bool", IsRequired = false)]
        public bool IsBindable { get; set; }


        [ApiMember(Name = nameof(IsGlobal), Description = "bool", IsRequired = false)]
        public bool IsGlobal { get; set; }


        [ApiMember(Name = nameof(Name), Description = "string", IsRequired = true)]
        public string Name { get; set; }


    }

    [Route("/lookuptableenum", "POST")]
    [Route("/profile/lookuptableenum", "POST")]
    [Route("/lookuptableenum/{Id}", "GET, PATCH, PUT, DELETE")]
    [Route("/profile/lookuptableenum/{Id}", "GET, PATCH, PUT, DELETE")]
    public partial class LookupTableEnum : LookupTableEnumBase, IReturn<LookupTableEnum>, IDto
    {
        public LookupTableEnum()
        {
            _Constructor();
        }

        public LookupTableEnum(int? id) : base(DocConvert.ToInt(id)) {}
        public LookupTableEnum(int id) : base(id) {}
        
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
        public static List<string> Fields => _fields ?? (_fields = DocTools.Fields<LookupTableEnum>());

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Created),nameof(CreatorId),nameof(Gestalt),nameof(IsBindable),nameof(IsGlobal),nameof(Locked),nameof(Name),nameof(Updated),nameof(VersionNo)})]
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
    
    [Route("/LookupTableEnum/{Id}/copy", "POST")]
    [Route("/profile/LookupTableEnum/{Id}/copy", "POST")]
    public partial class LookupTableEnumCopy : LookupTableEnum {}
    [Route("/lookuptableenum", "GET")]
    [Route("/profile/lookuptableenum", "GET")]
    [Route("/lookuptableenum/search", "GET, POST, DELETE")]
    [Route("/profile/lookuptableenum/search", "GET, POST, DELETE")]
    public partial class LookupTableEnumSearch : Search<LookupTableEnum>
    {
        public bool? IsBindable { get; set; }
        public bool? IsGlobal { get; set; }
        public string Name { get; set; }
    }
    
    public class LookupTableEnumFullTextSearch
    {
        private LookupTableEnumSearch _request;
        public LookupTableEnumFullTextSearch(LookupTableEnumSearch request) => _request = request;
        
        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(LookupTableEnum.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(LookupTableEnum.Updated))); }
        
        public bool doIsBindable { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(LookupTableEnum.IsBindable))); }
        public bool doIsGlobal { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(LookupTableEnum.IsGlobal))); }
        public bool doName { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(LookupTableEnum.Name))); }
    }

    [Route("/lookuptableenum/version", "GET, POST")]
    public partial class LookupTableEnumVersion : LookupTableEnumSearch {}

    [Route("/lookuptableenum/batch", "DELETE, PATCH, POST, PUT")]
    [Route("/profile/lookuptableenum/batch", "DELETE, PATCH, POST, PUT")]
    public partial class LookupTableEnumBatch : List<LookupTableEnum> { }

}