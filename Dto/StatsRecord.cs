
//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated by a T4 template. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
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
    public abstract partial class StatsRecordBase : Dto<StatsRecord>
    {
        public StatsRecordBase() {}

        public StatsRecordBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public StatsRecordBase(int? id) : this(DocConvert.ToInt(id)) {}

        public StatsRecordBase(int? pId, Reference pName, int? pNameId, int? pOwnerId, string pOwnerType, decimal pValue) : this(DocConvert.ToInt(pId)) 
        {
            Name = pName;
            NameId = pNameId;
            OwnerId = pOwnerId;
            OwnerType = pOwnerType;
            Value = pValue;
        }

        [ApiAllowableValues("Includes", Values = new string[] {@"Ambispective Observational",@"Bound Characteristic Variables",@"Bound Group Variables",@"Bound Outcome Iterations",@"Bound Outcome Variables",@"Bound Study Level Variables",@"Bound Total Variables",@"Case Control",@"Case Report",@"Case Series",@"Collected Characteristic Variables",@"Collected MainGroups",@"Collected Outcome Variables",@"Comparisons",@"Cross-Sectional",@"Data Points Avg",@"Data Points Max",@"Data Points Total",@"Data Studies",@"Diagnosis",@"Follow-up/Extension",@"FR Studies",@"Harm",@"Interventions",@"Modeling",@"Non-Randomized Controlled Trial",@"Non-Randomized Crossover",@"Non-Randomized Non-Controlled Trial",@"Other",@"Pooled Analysis",@"Posthoc Analysis",@"Prevalence",@"Prevention/Risk",@"Prognosis",@"Prospective Observational",@"Randomized Controlled Trial",@"Randomized Crossover",@"Randomized Non-Controlled Trial",@"Retrospective Observational",@"Study Design Overview",@"Sub-Group Analysis",@"SubGroups",@"Therapy",@"Total Characteristic Variables",@"Total Comparative Statements",@"Total Group Variables",@"Total MainGroups",@"Total Outcome Iterations",@"Total Outcome Variables",@"Total Participants",@"Total Studies",@"Total Study Level Variables",@"Total Variables",@"Uncollected Characteristic Variables",@"Uncollected MainGroups",@"Uncollected Outcome Variables"})]
        [ApiMember(Name = nameof(Name), Description = "LookupTable", IsRequired = true)]
        public Reference Name { get; set; }
        [ApiMember(Name = nameof(NameId), Description = "Primary Key of LookupTable", IsRequired = false)]
        public int? NameId { get; set; }


        [ApiMember(Name = nameof(OwnerId), Description = "int?", IsRequired = true)]
        public int? OwnerId { get; set; }
        public List<int> OwnerIdIds { get; set; }
        public int? OwnerIdCount { get; set; }


        [ApiMember(Name = nameof(OwnerType), Description = "string", IsRequired = true)]
        public string OwnerType { get; set; }
        public List<int> OwnerTypeIds { get; set; }
        public int? OwnerTypeCount { get; set; }


        [ApiMember(Name = nameof(Value), Description = "decimal", IsRequired = true)]
        public decimal Value { get; set; }
        public List<int> ValueIds { get; set; }
        public int? ValueCount { get; set; }



        public void Deconstruct(out Reference pName, out int? pNameId, out int? pOwnerId, out string pOwnerType, out decimal pValue)
        {
            pName = Name;
            pNameId = NameId;
            pOwnerId = OwnerId;
            pOwnerType = OwnerType;
            pValue = Value;
        }

        //Not ready until C# v8.?
        //public StatsRecordBase With(int? pId = Id, Reference pName = Name, int? pNameId = NameId, int? pOwnerId = OwnerId, string pOwnerType = OwnerType, decimal pValue = Value) => 
        //	new StatsRecordBase(pId, pName, pNameId, pOwnerId, pOwnerType, pValue);

    }


    [Route("/statsrecord/{Id}", "GET")]

    public partial class StatsRecord : StatsRecordBase, IReturn<StatsRecord>, IDto, ICloneable
    {
        public StatsRecord() => _Constructor();

        public StatsRecord(int? id) : base(DocConvert.ToInt(id)) {}
        public StatsRecord(int id) : base(id) {}
        public StatsRecord(int? pId, Reference pName, int? pNameId, int? pOwnerId, string pOwnerType, decimal pValue) :
            base(pId, pName, pNameId, pOwnerId, pOwnerType, pValue) { }

        public static List<string> Fields => DocTools.Fields<StatsRecord>();

        private List<string> _Select;
        [ApiMember(Name = nameof(Select), Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Created),nameof(CreatorId),nameof(Gestalt),nameof(Locked),nameof(Name),nameof(NameId),nameof(OwnerId),nameof(OwnerType),nameof(Updated),nameof(Value),nameof(VersionNo)})]
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

        [Obsolete, ApiMember(Name = nameof(VisibleFields), Description = "Deprecated. Use Select instead.", AllowMultiple = true)]
        public override List<string> VisibleFields { get => Select; set => Select = value; }



        public object Clone() => this.Copy<StatsRecord>();

    }
    

    public partial class StatsRecordSearchBase : Search<StatsRecord>
    {
        public int? Id { get; set; }
        public Reference Name { get; set; }
        public List<int> NameIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"Ambispective Observational",@"Bound Characteristic Variables",@"Bound Group Variables",@"Bound Outcome Iterations",@"Bound Outcome Variables",@"Bound Study Level Variables",@"Bound Total Variables",@"Case Control",@"Case Report",@"Case Series",@"Collected Characteristic Variables",@"Collected MainGroups",@"Collected Outcome Variables",@"Comparisons",@"Cross-Sectional",@"Data Points Avg",@"Data Points Max",@"Data Points Total",@"Data Studies",@"Diagnosis",@"Follow-up/Extension",@"FR Studies",@"Harm",@"Interventions",@"Modeling",@"Non-Randomized Controlled Trial",@"Non-Randomized Crossover",@"Non-Randomized Non-Controlled Trial",@"Other",@"Pooled Analysis",@"Posthoc Analysis",@"Prevalence",@"Prevention/Risk",@"Prognosis",@"Prospective Observational",@"Randomized Controlled Trial",@"Randomized Crossover",@"Randomized Non-Controlled Trial",@"Retrospective Observational",@"Study Design Overview",@"Sub-Group Analysis",@"SubGroups",@"Therapy",@"Total Characteristic Variables",@"Total Comparative Statements",@"Total Group Variables",@"Total MainGroups",@"Total Outcome Iterations",@"Total Outcome Variables",@"Total Participants",@"Total Studies",@"Total Study Level Variables",@"Total Variables",@"Uncollected Characteristic Variables",@"Uncollected MainGroups",@"Uncollected Outcome Variables"})]
        public List<string> NameNames { get; set; }
        public int? OwnerId { get; set; }
        public string OwnerType { get; set; }
        public List<string> OwnerTypes { get; set; }
        public decimal? Value { get; set; }
    }


    [Route("/statsrecord", "GET")]
    [Route("/statsrecord/version", "GET, POST")]
    [Route("/statsrecord/search", "GET, POST, DELETE")]

    public partial class StatsRecordSearch : StatsRecordSearchBase
    {
    }

    public class StatsRecordFullTextSearch
    {
        public StatsRecordFullTextSearch() {}
        private StatsRecordSearch _request;
        public StatsRecordFullTextSearch(StatsRecordSearch request) => _request = request;

        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(StatsRecord.Created))); }
        public bool doUpdated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(StatsRecord.Updated))); }

        public bool doName { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(StatsRecord.Name))); }
        public bool doOwnerId { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(StatsRecord.OwnerId))); }
        public bool doOwnerType { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(StatsRecord.OwnerType))); }
        public bool doValue { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(StatsRecord.Value))); }
    }


    public partial class StatsRecordBatch : List<StatsRecord> { }


}
