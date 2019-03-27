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
    public abstract partial class StudyDesignBase : Dto<StudyDesign>
    {
        public StudyDesignBase() {}

        public StudyDesignBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public StudyDesignBase(int? id) : this(DocConvert.ToInt(id)) {}

        public StudyDesignBase(int? pId, Reference pDesign, int? pDesignId) : this(DocConvert.ToInt(pId)) 
        {
            Design = pDesign;
            DesignId = pDesignId;
        }

        [ApiMember(Name = nameof(Design), Description = "LookupTable", IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {@"Before and After Trial",@"Case Control",@"Case Report",@"Case Series",@"Cluster RCT",@"Cohort Study",@"Controlled Before and After Trial",@"Cross Sectional Study",@"Expanded Access Program",@"Follow-up/Extension",@"Literature Review",@"Non-Comparative, Other",@"Non-Controlled Clinical Trial",@"Non-Randomized Controlled Trial",@"Non-Randomized Crossover",@"Observational Non-Comparative Study",@"Pooled Analysis",@"Posthoc Analysis",@"Prospective Cohort Study",@"Qualitative Research",@"Randomized Controlled Trial",@"Randomized Crossover",@"Randomized Non-Controlled Trial",@"Retrospective Cohort Study",@"Sub-Group Analysis"})]
        public Reference Design { get; set; }
        [ApiMember(Name = nameof(DesignId), Description = "Primary Key of LookupTable", IsRequired = false)]
        public int? DesignId { get; set; }



        public void Deconstruct(out Reference pDesign, out int? pDesignId)
        {
            pDesign = Design;
            pDesignId = DesignId;
        }

        //Not ready until C# v8.?
        //public StudyDesignBase With(int? pId = Id, Reference pDesign = Design, int? pDesignId = DesignId) => 
        //	new StudyDesignBase(pId, pDesign, pDesignId);

    }

    public partial class StudyDesign : StudyDesignBase, IReturn<StudyDesign>, IDto, ICloneable
    {
        public StudyDesign()
        {
            _Constructor();
        }

        public StudyDesign(int? id) : base(DocConvert.ToInt(id)) {}
        public StudyDesign(int id) : base(id) {}
        public StudyDesign(int? pId, Reference pDesign, int? pDesignId) : 
            base(pId, pDesign, pDesignId) { }
        #region Fields
        
        public bool? ShouldSerialize(string field)
        {
            if (IgnoredVisibleFields.Matches(field, true)) return false;
            var ret = MandatoryVisibleFields.Matches(field, true) || true == VisibleFields?.Matches(field, true);
            return ret;
        }

        public static List<string> Fields => DocTools.Fields<StudyDesign>();

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Created),nameof(CreatorId),nameof(Design),nameof(DesignId),nameof(Gestalt),nameof(Locked),nameof(Updated),nameof(VersionNo)})]
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

        public object Clone() => this.Copy<StudyDesign>();
    }
    
    public partial class StudyDesignSearchBase : Search<StudyDesign>
    {
        public int? Id { get; set; }
        public Reference Design { get; set; }
        public List<int> DesignIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"Before and After Trial",@"Case Control",@"Case Report",@"Case Series",@"Cluster RCT",@"Cohort Study",@"Controlled Before and After Trial",@"Cross Sectional Study",@"Expanded Access Program",@"Follow-up/Extension",@"Literature Review",@"Non-Comparative, Other",@"Non-Controlled Clinical Trial",@"Non-Randomized Controlled Trial",@"Non-Randomized Crossover",@"Observational Non-Comparative Study",@"Pooled Analysis",@"Posthoc Analysis",@"Prospective Cohort Study",@"Qualitative Research",@"Randomized Controlled Trial",@"Randomized Crossover",@"Randomized Non-Controlled Trial",@"Retrospective Cohort Study",@"Sub-Group Analysis"})]
        public List<string> DesignNames { get; set; }
    }

    public partial class StudyDesignSearch : StudyDesignSearchBase
    {
    }

    public class StudyDesignFullTextSearch
    {
        public StudyDesignFullTextSearch() {}
        private StudyDesignSearch _request;
        public StudyDesignFullTextSearch(StudyDesignSearch request) => _request = request;

        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(StudyDesign.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(StudyDesign.Updated))); }

        public bool doDesign { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(StudyDesign.Design))); }
    }

    public partial class StudyDesignBatch : List<StudyDesign> { }

}
