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
    public abstract partial class StatsStudySetBase : Dto<StatsStudySet>
    {
        public StatsStudySetBase() {}

        public StatsStudySetBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public StatsStudySetBase(int? id) : this(DocConvert.ToInt(id)) {}
    
        [ApiMember(Name = nameof(BoundTerms), Description = "int?", IsRequired = false)]
        public int? BoundTerms { get; set; }


        [ApiMember(Name = nameof(Characteristics), Description = "int?", IsRequired = false)]
        public int? Characteristics { get; set; }


        [ApiMember(Name = nameof(DataPoints), Description = "int?", IsRequired = false)]
        public int? DataPoints { get; set; }


        [ApiMember(Name = nameof(DesignCount), Description = "int?", IsRequired = false)]
        public int? DesignCount { get; set; }


        [ApiMember(Name = nameof(DesignList), Description = "string", IsRequired = false)]
        public string DesignList { get; set; }


        [ApiMember(Name = nameof(DocumentSet), Description = "DocumentSet", IsRequired = true)]
        public Reference DocumentSet { get; set; }
        [ApiMember(Name = nameof(DocumentSetId), Description = "Primary Key of DocumentSet", IsRequired = false)]
        public int? DocumentSetId { get; set; }


        [ApiMember(Name = nameof(Interventions), Description = "int?", IsRequired = false)]
        public int? Interventions { get; set; }


        [ApiMember(Name = nameof(Outcomes), Description = "int?", IsRequired = false)]
        public int? Outcomes { get; set; }


        [ApiMember(Name = nameof(OutcomesReported), Description = "int?", IsRequired = false)]
        public int? OutcomesReported { get; set; }


        [ApiMember(Name = nameof(Stat), Description = "Stats", IsRequired = true)]
        public Reference Stat { get; set; }
        [ApiMember(Name = nameof(StatId), Description = "Primary Key of Stats", IsRequired = false)]
        public int? StatId { get; set; }


        [ApiMember(Name = nameof(Studies), Description = "int?", IsRequired = false)]
        public int? Studies { get; set; }


        [ApiMember(Name = nameof(TypeCount), Description = "int?", IsRequired = false)]
        public int? TypeCount { get; set; }


        [ApiMember(Name = nameof(TypeList), Description = "string", IsRequired = false)]
        public string TypeList { get; set; }


        [ApiMember(Name = nameof(UnboundTerms), Description = "int?", IsRequired = false)]
        public int? UnboundTerms { get; set; }


    }

    [Route("/statsstudyset/{Id}", "GET")]
    [Route("/profile/statsstudyset/{Id}", "GET")]
    public partial class StatsStudySet : StatsStudySetBase, IReturn<StatsStudySet>, IDto
    {
        public StatsStudySet()
        {
            _Constructor();
        }

        public StatsStudySet(int? id) : base(DocConvert.ToInt(id)) {}
        public StatsStudySet(int id) : base(id) {}
        
        #region Fields
        
        public bool? ShouldSerialize(string field)
        {
            if (IgnoredVisibleFields.Matches(field, true)) return false;
            var ret = MandatoryVisibleFields.Matches(field, true) || true == VisibleFields?.Matches(field, true);
            return ret;
        }

        public static List<string> Fields => DocTools.Fields<StatsStudySet>();

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(BoundTerms),nameof(Characteristics),nameof(Created),nameof(CreatorId),nameof(DataPoints),nameof(DesignCount),nameof(DesignList),nameof(DocumentSet),nameof(DocumentSetId),nameof(Gestalt),nameof(Interventions),nameof(Locked),nameof(Outcomes),nameof(OutcomesReported),nameof(Stat),nameof(StatId),nameof(Studies),nameof(TypeCount),nameof(TypeList),nameof(UnboundTerms),nameof(Updated),nameof(VersionNo)})]
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
            nameof(Records), nameof(Records), nameof(RecordsCount)
        };
        private List<string> collections { get { return _collections; } }
    }
    
    [Route("/statsstudyset", "GET")]
    [Route("/profile/statsstudyset", "GET")]
    [Route("/statsstudyset/search", "GET, POST, DELETE")]
    [Route("/profile/statsstudyset/search", "GET, POST, DELETE")]
    public partial class StatsStudySetSearch : Search<StatsStudySet>
    {
        public int? BoundTerms { get; set; }
        public int? Characteristics { get; set; }
        public int? DataPoints { get; set; }
        public int? DesignCount { get; set; }
        public string DesignList { get; set; }
        public Reference DocumentSet { get; set; }
        public List<int> DocumentSetIds { get; set; }
        public int? Interventions { get; set; }
        public int? Outcomes { get; set; }
        public int? OutcomesReported { get; set; }
        public Reference Stat { get; set; }
        public List<int> StatIds { get; set; }
        public int? Studies { get; set; }
        public int? TypeCount { get; set; }
        public string TypeList { get; set; }
        public int? UnboundTerms { get; set; }
    }
    
    public class StatsStudySetFullTextSearch
    {
        private StatsStudySetSearch _request;
        public StatsStudySetFullTextSearch(StatsStudySetSearch request) => _request = request;
        
        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(StatsStudySet.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(StatsStudySet.Updated))); }
        
        public bool doBoundTerms { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(StatsStudySet.BoundTerms))); }
        public bool doCharacteristics { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(StatsStudySet.Characteristics))); }
        public bool doDataPoints { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(StatsStudySet.DataPoints))); }
        public bool doDesignCount { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(StatsStudySet.DesignCount))); }
        public bool doDesignList { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(StatsStudySet.DesignList))); }
        public bool doDocumentSet { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(StatsStudySet.DocumentSet))); }
        public bool doInterventions { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(StatsStudySet.Interventions))); }
        public bool doOutcomes { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(StatsStudySet.Outcomes))); }
        public bool doOutcomesReported { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(StatsStudySet.OutcomesReported))); }
        public bool doRecords { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(StatsStudySet.Records))); }
        public bool doStat { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(StatsStudySet.Stat))); }
        public bool doStudies { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(StatsStudySet.Studies))); }
        public bool doTypeCount { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(StatsStudySet.TypeCount))); }
        public bool doTypeList { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(StatsStudySet.TypeList))); }
        public bool doUnboundTerms { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(StatsStudySet.UnboundTerms))); }
    }

    [Route("/statsstudyset/version", "GET, POST")]
    public partial class StatsStudySetVersion : StatsStudySetSearch {}

    [Route("/statsstudyset/batch", "DELETE, PATCH, POST, PUT")]
    [Route("/profile/statsstudyset/batch", "DELETE, PATCH, POST, PUT")]
    public partial class StatsStudySetBatch : List<StatsStudySet> { }

    public class StatsStudySetJunction : Search<StatsStudySet>
    {
        public int? Id { get; set; }
        public List<int> Ids { get; set; }
        public List<string> VisibleFields { get; set; }
        public bool ShouldSerializeVisibleFields()
        {
            { return false; }
        }


        public StatsStudySetJunction(int id, List<int> ids)
        {
            this.Id = id;
            this.Ids = ids;
        }
    }


    public class StatsStudySetJunctionVersion : IReturn<Version>
    {
        public int? Id { get; set; }
        public List<int> Ids { get; set; }
        public List<string> VisibleFields { get; set; }
        public bool ShouldSerializeVisibleFields()
        {
            { return false; }
        }
    }
    [Route("/admin/statsstudyset/ids", "GET, POST")]
    public class StatsStudySetIds
    {
        public bool All { get; set; }
    }
}