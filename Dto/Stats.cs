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
    public abstract partial class StatsBase : Dto<Stats>
    {
        public StatsBase() {}

        public StatsBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public StatsBase(int? id) : this(DocConvert.ToInt(id)) {}
    
        [ApiMember(Name = nameof(App), Description = "App", IsRequired = true)]
        public Reference App { get; set; }
        [ApiMember(Name = nameof(AppId), Description = "Primary Key of App", IsRequired = false)]
        public int? AppId { get; set; }


        [ApiMember(Name = nameof(ExternalId), Description = "int?", IsRequired = false)]
        public int? ExternalId { get; set; }


        [ApiMember(Name = nameof(ExternalType), Description = "string", IsRequired = false)]
        public string ExternalType { get; set; }


        [ApiMember(Name = nameof(ObjectId), Description = "int?", IsRequired = true)]
        public int? ObjectId { get; set; }


        [ApiMember(Name = nameof(ObjectType), Description = "string", IsRequired = true)]
        public string ObjectType { get; set; }


        [ApiMember(Name = nameof(StudySetStats), Description = "StatsStudySet", IsRequired = false)]
        public Reference StudySetStats { get; set; }
        [ApiMember(Name = nameof(StudySetStatsId), Description = "Primary Key of StatsStudySet", IsRequired = false)]
        public int? StudySetStatsId { get; set; }


    }

    [Route("/stats/{Id}", "GET")]
    [Route("/profile/stats/{Id}", "GET")]
    public partial class Stats : StatsBase, IReturn<Stats>, IDto
    {
        public Stats()
        {
            _Constructor();
        }

        public Stats(int? id) : base(DocConvert.ToInt(id)) {}
        public Stats(int id) : base(id) {}
        
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
        public static List<string> Fields => _fields ?? (_fields = DocTools.Fields<Stats>());

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(App),nameof(AppId),nameof(Created),nameof(CreatorId),nameof(ExternalId),nameof(ExternalType),nameof(Gestalt),nameof(Locked),nameof(ObjectId),nameof(ObjectType),nameof(StudySetStats),nameof(StudySetStatsId),nameof(Updated),nameof(VersionNo)})]
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
    
    [Route("/stats", "GET")]
    [Route("/profile/stats", "GET")]
    [Route("/stats/search", "GET, POST, DELETE")]
    [Route("/profile/stats/search", "GET, POST, DELETE")]
    public partial class StatsSearch : Search<Stats>
    {
        public Reference App { get; set; }
        public List<int> AppIds { get; set; }
        public int? ExternalId { get; set; }
        public string ExternalType { get; set; }
        public int? ObjectId { get; set; }
        public string ObjectType { get; set; }
        public Reference StudySetStats { get; set; }
        public List<int> StudySetStatsIds { get; set; }
    }
    
    public class StatsFullTextSearch
    {
        private StatsSearch _request;
        public StatsFullTextSearch(StatsSearch request) => _request = request;
        
        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Stats.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Stats.Updated))); }
        
        public bool doApp { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Stats.App))); }
        public bool doExternalId { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Stats.ExternalId))); }
        public bool doExternalType { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Stats.ExternalType))); }
        public bool doObjectId { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Stats.ObjectId))); }
        public bool doObjectType { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Stats.ObjectType))); }
        public bool doStudySetStats { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Stats.StudySetStats))); }
    }

    [Route("/stats/version", "GET, POST")]
    public partial class StatsVersion : StatsSearch {}

    [Route("/stats/batch", "DELETE, PATCH, POST, PUT")]
    [Route("/profile/stats/batch", "DELETE, PATCH, POST, PUT")]
    public partial class StatsBatch : List<Stats> { }

    [Route("/admin/stats/ids", "GET, POST")]
    public class StatsIds
    {
        public bool All { get; set; }
    }
}