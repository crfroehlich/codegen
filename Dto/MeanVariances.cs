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
    public abstract partial class MeanVariancesBase : Dto<MeanVariances>
    {
        public MeanVariancesBase() {}

        public MeanVariancesBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public MeanVariancesBase(int? id) : this(DocConvert.ToInt(id)) {}
    


    }

    [Route("/meanvariances", "POST")]
    [Route("/meanvariances/{Id}", "GET, PATCH, PUT, DELETE")]
    public partial class MeanVariances : MeanVariancesBase, IReturn<MeanVariances>, IDto
    {
        public MeanVariances()
        {
            _Constructor();
        }

        public MeanVariances(int? id) : base(DocConvert.ToInt(id)) {}
        public MeanVariances(int id) : base(id) {}
        
        #region Fields
        
        public bool? ShouldSerialize(string field)
        {
            if (IgnoredVisibleFields.Matches(field, true)) return false;
            var ret = MandatoryVisibleFields.Matches(field, true) || true == VisibleFields?.Matches(field, true);
            return ret;
        }

        public static List<string> Fields => DocTools.Fields<MeanVariances>();

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Created),nameof(CreatorId),nameof(Gestalt),nameof(Locked),nameof(Updated),nameof(Variances),nameof(VersionNo)})]
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
            nameof(Variances), nameof(Variances), nameof(VariancesCount)
        };
        private List<string> collections { get { return _collections; } }
    }
    
    [Route("/MeanVariances/{Id}/copy", "POST")]
    public partial class MeanVariancesCopy : MeanVariances {}
    public partial class MeanVariancesSearchBase : Search<MeanVariances>
    {
        public int? Id { get; set; }
        public List<int> VariancesIds { get; set; }
    }

    [Route("/meanvariances", "GET")]
    [Route("/meanvariances/version", "GET, POST")]
    [Route("/meanvariances/search", "GET, POST, DELETE")]
    public partial class MeanVariancesSearch : MeanVariancesSearchBase
    {
    }

    public class MeanVariancesFullTextSearch
    {
        public MeanVariancesFullTextSearch() {}
        private MeanVariancesSearch _request;
        public MeanVariancesFullTextSearch(MeanVariancesSearch request) => _request = request;
        
        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(MeanVariances.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(MeanVariances.Updated))); }
        
        public bool doVariances { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(MeanVariances.Variances))); }
    }

    [Route("/meanvariances/batch", "DELETE, PATCH, POST, PUT")]
    public partial class MeanVariancesBatch : List<MeanVariances> { }

    [Route("/meanvariances/{Id}/meanvariancevalue/version", "GET, POST")]
    [Route("/meanvariances/{Id}/meanvariancevalue", "GET, POST, DELETE")]
    public class MeanVariancesJunction : MeanVariancesSearchBase {}


    [Route("/admin/meanvariances/ids", "GET, POST")]
    public class MeanVariancesIds
    {
        public bool All { get; set; }
    }
}