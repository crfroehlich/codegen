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
    public abstract partial class MeanVarianceValueBase : Dto<MeanVarianceValue>
    {
        public MeanVarianceValueBase() {}

        public MeanVarianceValueBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public MeanVarianceValueBase(int? id) : this(DocConvert.ToInt(id)) {}
    
        [ApiMember(Name = nameof(MeanVariance), Description = "Units", IsRequired = false)]
        public TypeUnits MeanVariance { get; set; }


        [ApiMember(Name = nameof(MeanVarianceRange), Description = "UnitsRange", IsRequired = false)]
        public TypeUnitsRange MeanVarianceRange { get; set; }


        [ApiMember(Name = nameof(MeanVarianceType), Description = "LookupTable", IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {@"SD",@"SE",@"Unknown",@"Semi IQR",@"IQR Difference",@"CV"})]
        public Reference MeanVarianceType { get; set; }
        [ApiMember(Name = nameof(MeanVarianceTypeId), Description = "Primary Key of LookupTable", IsRequired = false)]
        public int? MeanVarianceTypeId { get; set; }


        [ApiMember(Name = nameof(Order), Description = "int?", IsRequired = false)]
        public int? Order { get; set; }


        [ApiMember(Name = nameof(Owners), Description = "MeanVariances", IsRequired = false)]
        public List<MeanVariances> Owners { get; set; }
        public int? OwnersCount { get; set; }


    }

    [Route("/meanvariancevalue", "POST")]
    [Route("/profile/meanvariancevalue", "POST")]
    [Route("/meanvariancevalue/{Id}", "GET, PATCH, PUT, DELETE")]
    [Route("/profile/meanvariancevalue/{Id}", "GET, PATCH, PUT, DELETE")]
    public partial class MeanVarianceValue : MeanVarianceValueBase, IReturn<MeanVarianceValue>, IDto
    {
        public MeanVarianceValue()
        {
            _Constructor();
        }

        public MeanVarianceValue(int? id) : base(DocConvert.ToInt(id)) {}
        public MeanVarianceValue(int id) : base(id) {}
        
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
        public static List<string> Fields => _fields ?? (_fields = DocTools.Fields<MeanVarianceValue>());

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Created),nameof(CreatorId),nameof(Gestalt),nameof(Locked),nameof(MeanVariance),nameof(MeanVarianceRange),nameof(MeanVarianceType),nameof(MeanVarianceTypeId),nameof(Order),nameof(Owners),nameof(OwnersCount),nameof(Updated),nameof(VersionNo)})]
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
            nameof(Owners), nameof(OwnersCount)
        };
        private List<string> collections { get { return _collections; } }
    }
    
    [Route("/MeanVarianceValue/{Id}/copy", "POST")]
    [Route("/profile/MeanVarianceValue/{Id}/copy", "POST")]
    public partial class MeanVarianceValueCopy : MeanVarianceValue {}
    [Route("/meanvariancevalue", "GET")]
    [Route("/profile/meanvariancevalue", "GET")]
    [Route("/meanvariancevalue/search", "GET, POST, DELETE")]
    [Route("/profile/meanvariancevalue/search", "GET, POST, DELETE")]
    public partial class MeanVarianceValueSearch : Search<MeanVarianceValue>
    {
        public TypeUnits MeanVariance { get; set; }
        public TypeUnitsRange MeanVarianceRange { get; set; }
        public Reference MeanVarianceType { get; set; }
        public List<int> MeanVarianceTypeIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"SD",@"SE",@"Unknown",@"Semi IQR",@"IQR Difference",@"CV"})]
        public List<string> MeanVarianceTypeNames { get; set; }
        public int? Order { get; set; }
        public List<int> OwnersIds { get; set; }
    }
    
    public class MeanVarianceValueFullTextSearch
    {
        private MeanVarianceValueSearch _request;
        public MeanVarianceValueFullTextSearch(MeanVarianceValueSearch request) => _request = request;
        
        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(MeanVarianceValue.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(MeanVarianceValue.Updated))); }
        
        public bool doMeanVariance { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(MeanVarianceValue.MeanVariance))); }
        public bool doMeanVarianceRange { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(MeanVarianceValue.MeanVarianceRange))); }
        public bool doMeanVarianceType { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(MeanVarianceValue.MeanVarianceType))); }
        public bool doOrder { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(MeanVarianceValue.Order))); }
        public bool doOwners { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(MeanVarianceValue.Owners))); }
    }

    [Route("/meanvariancevalue/version", "GET, POST")]
    public partial class MeanVarianceValueVersion : MeanVarianceValueSearch {}

    [Route("/meanvariancevalue/batch", "DELETE, PATCH, POST, PUT")]
    [Route("/profile/meanvariancevalue/batch", "DELETE, PATCH, POST, PUT")]
    public partial class MeanVarianceValueBatch : List<MeanVarianceValue> { }

    [Route("/meanvariancevalue/{Id}/meanvariances", "GET, POST, DELETE")]
    [Route("/profile/meanvariancevalue/{Id}/meanvariances", "GET, POST, DELETE")]
    public class MeanVarianceValueJunction : Search<MeanVarianceValue>
    {
        public int? Id { get; set; }
        public List<int> Ids { get; set; }
        public List<string> VisibleFields { get; set; }
        public bool ShouldSerializeVisibleFields()
        {
            { return false; }
        }


        public MeanVarianceValueJunction(int id, List<int> ids)
        {
            this.Id = id;
            this.Ids = ids;
        }
    }


    [Route("/meanvariancevalue/{Id}/meanvariances/version", "GET")]
    [Route("/profile/meanvariancevalue/{Id}/meanvariances/version", "GET")]
    public class MeanVarianceValueJunctionVersion : IReturn<Version>
    {
        public int? Id { get; set; }
        public List<int> Ids { get; set; }
        public List<string> VisibleFields { get; set; }
        public bool ShouldSerializeVisibleFields()
        {
            { return false; }
        }
    }
    [Route("/admin/meanvariancevalue/ids", "GET, POST")]
    public class MeanVarianceValueIds
    {
        public bool All { get; set; }
    }
}