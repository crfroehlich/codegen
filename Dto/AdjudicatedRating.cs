



















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
    public abstract partial class AdjudicatedRatingBase : TaskBase
    {
        public AdjudicatedRatingBase() {}

        public AdjudicatedRatingBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public AdjudicatedRatingBase(int? id) : this(DocConvert.ToInt(id)) {}

        public AdjudicatedRatingBase(int? pId, Reference pDocument, int? pDocumentId, RatingEnm? pRating, ReasonRejectedEnm? pReasonRejected) : this(DocConvert.ToInt(pId)) 
        {
            Document = pDocument;
            DocumentId = pDocumentId;
            Rating = pRating;
            ReasonRejected = pReasonRejected;
        }

        [ApiMember(Name = nameof(Document), Description = "Document", IsRequired = false)]
        public Reference Document { get; set; }
        [ApiMember(Name = nameof(DocumentId), Description = "Primary Key of Document", IsRequired = false)]
        public int? DocumentId { get; set; }


        [ApiAllowableValues("Includes", Values = new string[] {@"Maybe Relevant",@"Not Rated",@"Not Relevant",@"Relevant"})]
        [ApiMember(Name = nameof(Rating), Description = "RatingEnm?", IsRequired = false)]
        public RatingEnm? Rating { get; set; }


        [ApiAllowableValues("Includes", Values = new string[] {@"Abstract with Insufficient Information",@"Animal study",@"Does not meet protocol",@"Duplicate Publication",@"Erroneous Data",@"In vitro study",@"Missing Characteristic(s)",@"Missing Outcome(s)",@"Not a Clinical Study",@"Not English",@"Not a treatment Study",@"Relevant misclassified reference",@"Study fits protocol, to be possibly added later",@"Wrong Comparison",@"Wrong Intervention",@"Wrong Number of Participants",@"Wrong Outcome Stratification",@"Wrong Outcome(s)",@"Wrong Population",@"Wrong Publication Date Cutoff",@"Wrong Setting",@"Wrong Study Design",@"Wrong Timing"})]
        [ApiMember(Name = nameof(ReasonRejected), Description = "ReasonRejectedEnm?", IsRequired = false)]
        public ReasonRejectedEnm? ReasonRejected { get; set; }



        public void Deconstruct(out Reference pDocument, out int? pDocumentId, out RatingEnm? pRating, out ReasonRejectedEnm? pReasonRejected)
        {
            pDocument = Document;
            pDocumentId = DocumentId;
            pRating = Rating;
            pReasonRejected = ReasonRejected;
        }

        //Not ready until C# v8.?
        //public AdjudicatedRatingBase With(int? pId = Id, Reference pDocument = Document, int? pDocumentId = DocumentId, RatingEnm? pRating = Rating, ReasonRejectedEnm? pReasonRejected = ReasonRejected) => 
        //	new AdjudicatedRatingBase(pId, pDocument, pDocumentId, pRating, pReasonRejected);

    }


    [Route("/adjudicatedrating", "POST")]
    [Route("/adjudicatedrating/{Id}", "GET, PATCH, PUT, DELETE")]

    public partial class AdjudicatedRating : AdjudicatedRatingBase, IReturn<AdjudicatedRating>, IDto, ICloneable
    {
        public AdjudicatedRating()
        {
            _Constructor();
        }

        public AdjudicatedRating(int? id) : base(DocConvert.ToInt(id)) {}
        public AdjudicatedRating(int id) : base(id) {}
        public AdjudicatedRating(int? pId, Reference pDocument, int? pDocumentId, RatingEnm? pRating, ReasonRejectedEnm? pReasonRejected) : 
            base(pId, pDocument, pDocumentId, pRating, pReasonRejected) { }

        public new bool? ShouldSerialize(string field)
        {
            //Allow individual classes to specify their own logic
            var manualOverride = _ShouldSerialize(field);
            if(null != manualOverride) return manualOverride;

            if (IgnoredSelect.Matches(field, true)) return false;
            var ret = MandatorySelect.Matches(field, true) || true == Select?.Matches(field, true);
            return ret;
        }

        public static List<string> Fields => DocTools.Fields<AdjudicatedRating>();

        private List<string> _Select;
        [ApiMember(Name = nameof(Select), Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Created),nameof(CreatorId),nameof(Document),nameof(DocumentId),nameof(Gestalt),nameof(Locked),nameof(Rating),nameof(ReasonRejected),nameof(Updated),nameof(VersionNo)})]
        public override List<string> Select
        {
            get
            {
                if(null == this) return new List<string>();
                if(null == _Select)
                {


                    _Select = DocWebSession.GetTypeSelect(this);

                }
                return _Select;
            }
            set
            {


                var requested = value ?? new List<string>();
                var exists = requested.Where( r => Fields.Any( f => DocTools.AreEqual(r, f) ) ).ToList();
                _Select = DocPermissionFactory.SetSelect<AdjudicatedRating>("AdjudicatedRating",exists);

            }
        }

        [Obsolete, ApiMember(Name = nameof(VisibleFields), Description = "Deprecated. Use Select instead.", AllowMultiple = true)]
        public override List<string> VisibleFields { get => Select; set => Select = value; }



        public object Clone() => this.Copy<AdjudicatedRating>();

        public static explicit operator Task(AdjudicatedRating dto) => DocTransmogrify<AdjudicatedRating, Task>.ToNewObject(dto);
        public static explicit operator AdjudicatedRating(Task dto) => DocTransmogrify<Task, AdjudicatedRating>.ToNewObject(dto);

    }
    

    [Route("/adjudicatedrating/{Id}/copy", "POST")]
    public partial class AdjudicatedRatingCopy : AdjudicatedRating {}

    public partial class AdjudicatedRatingSearchBase : Search<AdjudicatedRating>
    {
        public int? Id { get; set; }
        public Reference Assignee { get; set; }
        public List<int> AssigneeIds { get; set; }
        public string Data { get; set; }
        public string Description { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? DueDateAfter { get; set; }
        public DateTime? DueDateBefore { get; set; }
        public Reference Reporter { get; set; }
        public List<int> ReporterIds { get; set; }
        public TaskTypeEnm? Type { get; set; }
        public Reference Workflow { get; set; }
        public List<int> WorkflowIds { get; set; }
        public Reference Document { get; set; }
        public List<int> DocumentIds { get; set; }
        public RatingEnm? Rating { get; set; }
        public ReasonRejectedEnm? ReasonRejected { get; set; }
    }


    [Route("/adjudicatedrating", "GET")]
    [Route("/adjudicatedrating/version", "GET, POST")]
    [Route("/adjudicatedrating/search", "GET, POST, DELETE")]

    public partial class AdjudicatedRatingSearch : AdjudicatedRatingSearchBase
    {
    }

    public class AdjudicatedRatingFullTextSearch
    {
        public AdjudicatedRatingFullTextSearch() {}
        private AdjudicatedRatingSearch _request;
        public AdjudicatedRatingFullTextSearch(AdjudicatedRatingSearch request) => _request = request;

        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(AdjudicatedRating.Created))); }
        public bool doUpdated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(AdjudicatedRating.Updated))); }

        public bool doDocument { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(AdjudicatedRating.Document))); }
        public bool doRating { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(AdjudicatedRating.Rating))); }
        public bool doReasonRejected { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(AdjudicatedRating.ReasonRejected))); }
    }


    [Route("/adjudicatedrating/batch", "DELETE, PATCH, POST, PUT")]

    public partial class AdjudicatedRatingBatch : List<AdjudicatedRating> { }


}
