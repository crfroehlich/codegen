//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated by a T4 template. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;

using Services.Core;
using Services.Dto.internals;
using Services.Enums;

using ServiceStack;
using ServiceStack.Text;

using Typed;
using Typed.Notifications;
using Typed.Bindings;

using Xtensive.Orm;


namespace Services.Dto
{
    public abstract partial class StudyDesignBase : Dto<StudyDesign>
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public StudyDesignBase() {}

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public StudyDesignBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public StudyDesignBase(int? id) : this(DocConvert.ToInt(id)) {}

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public StudyDesignBase(int? pId, Reference pDesign, int? pDesignId) : this(DocConvert.ToInt(pId)) 
        {
            Design = pDesign;
            DesignId = pDesignId;
        }

        [ApiAllowableValues("Includes", Values = new string[] {@"Before and After Trial",@"Case Control",@"Case Report",@"Case Series",@"Cluster RCT",@"Cohort Study",@"Controlled Before and After Trial",@"Cross Sectional Study",@"Expanded Access Program",@"Follow-up/Extension",@"Interim Analysis",@"Literature Review",@"Non-Comparative, Other",@"Non-Controlled Clinical Trial",@"Non-Randomized Controlled Trial",@"Non-Randomized Crossover",@"Observational Non-Comparative Study",@"Pooled Analysis",@"Posthoc Analysis",@"Prospective Cohort Study",@"Qualitative Research",@"Randomized Controlled Trial",@"Randomized Crossover",@"Randomized Non-Controlled Trial",@"Retrospective Cohort Study",@"Sub-Group Analysis"})]
        [ApiMember(Name = nameof(Design), Description = "LookupTable", IsRequired = true)]
[GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Reference Design { get; set; }
        [ApiMember(Name = nameof(DesignId), Description = "Primary Key of LookupTable", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? DesignId { get; set; }



        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public void Deconstruct(out Reference pDesign, out int? pDesignId)
        {
            pDesign = Design;
            pDesignId = DesignId;
        }

        //Not ready until C# v8.?
        //[GeneratedCodeAttribute("T4", "1.0.0.0")]
        //public StudyDesignBase With(int? pId = Id, Reference pDesign = Design, int? pDesignId = DesignId) => 
        //	new StudyDesignBase(pId, pDesign, pDesignId);

    }


    public partial class StudyDesign : StudyDesignBase, IReturn<StudyDesign>, IDto, ICloneable
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public StudyDesign() => _Constructor();
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public StudyDesign(int? id) : base(DocConvert.ToInt(id)) {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public StudyDesign(int id) : base(id) {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public StudyDesign(int? pId, Reference pDesign, int? pDesignId) :
            base(pId, pDesign, pDesignId) { }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static List<string> Fields => DocTools.Fields<StudyDesign>();

        private List<string> _Select;
        [ApiMember(Name = nameof(Select), Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Created),nameof(CreatorId),nameof(Design),nameof(DesignId),nameof(Gestalt),nameof(Locked),nameof(Updated),nameof(VersionNo)})]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override List<string> Select
        {
            get
            {
                if(null == this) return new List<string>();
                if(null == _Select)
                {

                    _Select = DocPermissionFactory.RemoveNonEssentialFields(Fields);

                }
                return _Select;
            }
            set
            {

                _Select = Fields;

            }
        }

        [Obsolete, ApiMember(Name = "VisibleFields", Description = "Deprecated. Use Select instead.", AllowMultiple = true)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override List<string> VisibleFields { get => Select; set => Select = value; }



        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Clone() => this.Copy<StudyDesign>();

    }
    

    public partial class StudyDesignSearchBase : Search<StudyDesign>
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? Id { get; set; }
        public Reference Design { get; set; }
        public List<int> DesignIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"Before and After Trial",@"Case Control",@"Case Report",@"Case Series",@"Cluster RCT",@"Cohort Study",@"Controlled Before and After Trial",@"Cross Sectional Study",@"Expanded Access Program",@"Follow-up/Extension",@"Interim Analysis",@"Literature Review",@"Non-Comparative, Other",@"Non-Controlled Clinical Trial",@"Non-Randomized Controlled Trial",@"Non-Randomized Crossover",@"Observational Non-Comparative Study",@"Pooled Analysis",@"Posthoc Analysis",@"Prospective Cohort Study",@"Qualitative Research",@"Randomized Controlled Trial",@"Randomized Crossover",@"Randomized Non-Controlled Trial",@"Retrospective Cohort Study",@"Sub-Group Analysis"})]
        public List<string> DesignNames { get; set; }
    }


    public partial class StudyDesignSearch : StudyDesignSearchBase
    {
    }

    public class StudyDesignFullTextSearch
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public StudyDesignFullTextSearch() {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private StudyDesignSearch _request;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public StudyDesignFullTextSearch(StudyDesignSearch request) => _request = request;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool doCreated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(StudyDesign.Created))); }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool doUpdated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(StudyDesign.Updated))); }

        public bool doDesign { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(StudyDesign.Design))); }
    }


    public partial class StudyDesignBatch : List<StudyDesign> { }


}
