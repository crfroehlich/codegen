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
    public abstract partial class UnitValueBase : Dto<UnitValue>
    {
        public UnitValueBase() {}

        public UnitValueBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public UnitValueBase(int? id) : this(DocConvert.ToInt(id)) {}
    
        [ApiMember(Name = nameof(EqualityOperator), Description = "LookupTable", IsRequired = false)]
        [ApiAllowableValues("Includes", Values = new string[] {@"~=",@"~>",@"~>=",@"~<",@"~<=",@"=",@">",@">=",@"≥",@"<",@"<=",@"≤",@"!="})]
        public Reference EqualityOperator { get; set; }
        [ApiMember(Name = nameof(EqualityOperatorId), Description = "Primary Key of LookupTable", IsRequired = false)]
        public int? EqualityOperatorId { get; set; }


        [ApiMember(Name = nameof(Multiplier), Description = "int?", IsRequired = false)]
        public int? Multiplier { get; set; }


        [ApiMember(Name = nameof(Number), Description = "decimal?", IsRequired = false)]
        public decimal? Number { get; set; }


        [ApiMember(Name = nameof(Order), Description = "int?", IsRequired = false)]
        public int? Order { get; set; }


        [ApiMember(Name = nameof(Unit), Description = "UnitOfMeasure", IsRequired = true)]
        public UnitOfMeasure Unit { get; set; }
        [ApiMember(Name = nameof(UnitId), Description = "Primary Key of UnitOfMeasure", IsRequired = false)]
        public int? UnitId { get; set; }


    }

    [Route("/unitvalue", "POST")]
    [Route("/profile/unitvalue", "POST")]
    [Route("/unitvalue/{Id}", "GET, PATCH, PUT, DELETE")]
    [Route("/profile/unitvalue/{Id}", "GET, PATCH, PUT, DELETE")]
    public partial class UnitValue : UnitValueBase, IReturn<UnitValue>, IDto
    {
        public UnitValue()
        {
            _Constructor();
        }

        public UnitValue(int? id) : base(DocConvert.ToInt(id)) {}
        public UnitValue(int id) : base(id) {}
        
        #region Fields
        
        public bool? ShouldSerialize(string field)
        {
            if (IgnoredVisibleFields.Matches(field, true)) return false;
            var ret = MandatoryVisibleFields.Matches(field, true) || true == VisibleFields?.Matches(field, true);
            return ret;
        }

        public static List<string> Fields => DocTools.Fields<UnitValue>();

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Created),nameof(CreatorId),nameof(EqualityOperator),nameof(EqualityOperatorId),nameof(Gestalt),nameof(Locked),nameof(Multiplier),nameof(Number),nameof(Order),nameof(Unit),nameof(UnitId),nameof(Updated),nameof(VersionNo)})]
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
            nameof(Owners), nameof(Owners), nameof(OwnersCount)
        };
        private List<string> collections { get { return _collections; } }
    }
    
    [Route("/UnitValue/{Id}/copy", "POST")]
    [Route("/profile/UnitValue/{Id}/copy", "POST")]
    public partial class UnitValueCopy : UnitValue {}
    [Route("/unitvalue", "GET")]
    [Route("/profile/unitvalue", "GET")]
    [Route("/unitvalue/search", "GET, POST, DELETE")]
    [Route("/profile/unitvalue/search", "GET, POST, DELETE")]
    public partial class UnitValueSearch : Search<UnitValue>
    {
        public Reference EqualityOperator { get; set; }
        public List<int> EqualityOperatorIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"~=",@"~>",@"~>=",@"~<",@"~<=",@"=",@">",@">=",@"≥",@"<",@"<=",@"≤",@"!="})]
        public List<string> EqualityOperatorNames { get; set; }
        public int? Multiplier { get; set; }
        public decimal? Number { get; set; }
        public int? Order { get; set; }
        public Reference Unit { get; set; }
        public List<int> UnitIds { get; set; }
    }
    
    public class UnitValueFullTextSearch
    {
        private UnitValueSearch _request;
        public UnitValueFullTextSearch(UnitValueSearch request) => _request = request;
        
        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(UnitValue.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(UnitValue.Updated))); }
        
        public bool doEqualityOperator { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(UnitValue.EqualityOperator))); }
        public bool doMultiplier { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(UnitValue.Multiplier))); }
        public bool doNumber { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(UnitValue.Number))); }
        public bool doOrder { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(UnitValue.Order))); }
        public bool doOwners { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(UnitValue.Owners))); }
        public bool doUnit { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(UnitValue.Unit))); }
    }

    [Route("/unitvalue/version", "GET, POST")]
    public partial class UnitValueVersion : UnitValueSearch {}

    [Route("/unitvalue/batch", "DELETE, PATCH, POST, PUT")]
    [Route("/profile/unitvalue/batch", "DELETE, PATCH, POST, PUT")]
    public partial class UnitValueBatch : List<UnitValue> { }

    public class UnitValueJunction : Search<UnitValue>
    {
        public int? Id { get; set; }
        public List<int> Ids { get; set; }
        public List<string> VisibleFields { get; set; }
        public bool ShouldSerializeVisibleFields()
        {
            { return false; }
        }


        public UnitValueJunction(int id, List<int> ids)
        {
            this.Id = id;
            this.Ids = ids;
        }
    }


    public class UnitValueJunctionVersion : IReturn<Version>
    {
        public int? Id { get; set; }
        public List<int> Ids { get; set; }
        public List<string> VisibleFields { get; set; }
        public bool ShouldSerializeVisibleFields()
        {
            { return false; }
        }
    }
    [Route("/admin/unitvalue/ids", "GET, POST")]
    public class UnitValueIds
    {
        public bool All { get; set; }
    }
}