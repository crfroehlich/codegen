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
using Services.Dto.internals;
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
        [ApiAllowableValues("Includes", Values = new string[] {@"CV",@"IQR Difference",@"SD",@"SE",@"Semi IQR",@"Unknown"})]
        public Reference MeanVarianceType { get; set; }
        [ApiMember(Name = nameof(MeanVarianceTypeId), Description = "Primary Key of LookupTable", IsRequired = false)]
        public int? MeanVarianceTypeId { get; set; }


        [ApiMember(Name = nameof(Order), Description = "int?", IsRequired = false)]
        public int? Order { get; set; }


        [ApiMember(Name = nameof(Owners), Description = "MeanVariances", IsRequired = false)]
        public List<MeanVariances> Owners { get; set; }
        public int? OwnersCount { get; set; }


    }

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
            if (IgnoredVisibleFields.Matches(field, true)) return false;
            var ret = MandatoryVisibleFields.Matches(field, true) || true == VisibleFields?.Matches(field, true);
            return ret;
        }

        public static List<string> Fields => DocTools.Fields<MeanVarianceValue>();

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
    
    public partial class MeanVarianceValueSearchBase : Search<MeanVarianceValue>
    {
        public int? Id { get; set; }
        public TypeUnits MeanVariance { get; set; }
        public TypeUnitsRange MeanVarianceRange { get; set; }
        public Reference MeanVarianceType { get; set; }
        public List<int> MeanVarianceTypeIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"CV",@"IQR Difference",@"SD",@"SE",@"Semi IQR",@"Unknown"})]
        public List<string> MeanVarianceTypeNames { get; set; }
        public int? Order { get; set; }
        public List<int> OwnersIds { get; set; }
    }

    public partial class MeanVarianceValueSearch : MeanVarianceValueSearchBase
    {
    }

    public class MeanVarianceValueFullTextSearch
    {
        public MeanVarianceValueFullTextSearch() {}
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

    public partial class MeanVarianceValueBatch : List<MeanVarianceValue> { }

    [Route("/meanvariancevalue/{Id}/{Junction}/version", "GET, POST")]
    [Route("/meanvariancevalue/{Id}/{Junction}", "GET, POST, DELETE")]
    public class MeanVarianceValueJunction : MeanVarianceValueSearchBase {}


}