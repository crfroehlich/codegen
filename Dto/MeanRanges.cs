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
    public abstract partial class MeanRangesBase : Dto<MeanRanges>
    {
        public MeanRangesBase() {}

        public MeanRangesBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public MeanRangesBase(int? id) : this(DocConvert.ToInt(id)) {}



    }

    public partial class MeanRanges : MeanRangesBase, IReturn<MeanRanges>, IDto
    {
        public MeanRanges()
        {
            _Constructor();
        }

        public MeanRanges(int? id) : base(DocConvert.ToInt(id)) {}
        public MeanRanges(int id) : base(id) {}
        
        #region Fields
        
        public bool? ShouldSerialize(string field)
        {
            if (IgnoredVisibleFields.Matches(field, true)) return false;
            var ret = MandatoryVisibleFields.Matches(field, true) || true == VisibleFields?.Matches(field, true);
            return ret;
        }

        public static List<string> Fields => DocTools.Fields<MeanRanges>();

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Created),nameof(CreatorId),nameof(Gestalt),nameof(Locked),nameof(Ranges),nameof(Updated),nameof(VersionNo)})]
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
            nameof(Ranges), nameof(Ranges), nameof(RangesCount)
        };
        private List<string> collections { get { return _collections; } }
    }
    
    public partial class MeanRangesSearchBase : Search<MeanRanges>
    {
        public int? Id { get; set; }
        public List<int> RangesIds { get; set; }
    }

    public partial class MeanRangesSearch : MeanRangesSearchBase
    {
    }

    public class MeanRangesFullTextSearch
    {
        public MeanRangesFullTextSearch() {}
        private MeanRangesSearch _request;
        public MeanRangesFullTextSearch(MeanRangesSearch request) => _request = request;

        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(MeanRanges.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(MeanRanges.Updated))); }

        public bool doRanges { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(MeanRanges.Ranges))); }
    }

    public partial class MeanRangesBatch : List<MeanRanges> { }

    [Route("/meanranges/{Id}/{Junction}/version", "GET, POST")]
    [Route("/meanranges/{Id}/{Junction}", "GET, POST, DELETE")]
    public class MeanRangesJunction : MeanRangesSearchBase {}


}
