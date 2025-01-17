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
    public abstract partial class ReconcileDocumentBase : TaskBase
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public ReconcileDocumentBase() {}

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public ReconcileDocumentBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public ReconcileDocumentBase(int? id) : this(DocConvert.ToInt(id)) {}

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public ReconcileDocumentBase(int? pId, string pArticleId, string pArticleLink, Reference pDocument, int? pDocumentId, int? pMatches, string pSearchLink, ReconciliationStatusEnm? pStatus) : this(DocConvert.ToInt(pId)) 
        {
            ArticleId = pArticleId;
            ArticleLink = pArticleLink;
            Document = pDocument;
            DocumentId = pDocumentId;
            Matches = pMatches;
            SearchLink = pSearchLink;
            Status = pStatus;
        }

        [ApiMember(Name = nameof(ArticleId), Description = "string", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string ArticleId { get; set; }


        [ApiMember(Name = nameof(ArticleLink), Description = "string", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string ArticleLink { get; set; }


        [ApiMember(Name = nameof(Document), Description = "Document", IsRequired = false)]
[GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Reference Document { get; set; }
        [ApiMember(Name = nameof(DocumentId), Description = "Primary Key of Document", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? DocumentId { get; set; }


        [ApiMember(Name = nameof(Matches), Description = "int?", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? Matches { get; set; }


        [ApiMember(Name = nameof(SearchLink), Description = "string", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string SearchLink { get; set; }


        [ApiAllowableValues("Includes", Values = new string[] {@"Matched",@"Multiple Matches",@"No Match",@"One Match"})]
        [ApiMember(Name = nameof(Status), Description = "ReconciliationStatusEnm?", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public ReconciliationStatusEnm? Status { get; set; }



        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public void Deconstruct(out string pArticleId, out string pArticleLink, out Reference pDocument, out int? pDocumentId, out int? pMatches, out string pSearchLink, out ReconciliationStatusEnm? pStatus)
        {
            pArticleId = ArticleId;
            pArticleLink = ArticleLink;
            pDocument = Document;
            pDocumentId = DocumentId;
            pMatches = Matches;
            pSearchLink = SearchLink;
            pStatus = Status;
        }

        //Not ready until C# v8.?
        //[GeneratedCodeAttribute("T4", "1.0.0.0")]
        //public ReconcileDocumentBase With(int? pId = Id, string pArticleId = ArticleId, string pArticleLink = ArticleLink, Reference pDocument = Document, int? pDocumentId = DocumentId, int? pMatches = Matches, string pSearchLink = SearchLink, ReconciliationStatusEnm? pStatus = Status) => 
        //	new ReconcileDocumentBase(pId, pArticleId, pArticleLink, pDocument, pDocumentId, pMatches, pSearchLink, pStatus);

    }


    [Route("/reconciledocument", "POST")]
    [Route("/reconciledocument/{Id}", "GET, PATCH, PUT, DELETE")]

    public partial class ReconcileDocument : ReconcileDocumentBase, IReturn<ReconcileDocument>, IDto, ICloneable
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public ReconcileDocument() => _Constructor();
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public ReconcileDocument(int? id) : base(DocConvert.ToInt(id)) {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public ReconcileDocument(int id) : base(id) {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public ReconcileDocument(int? pId, string pArticleId, string pArticleLink, Reference pDocument, int? pDocumentId, int? pMatches, string pSearchLink, ReconciliationStatusEnm? pStatus) :
            base(pId, pArticleId, pArticleLink, pDocument, pDocumentId, pMatches, pSearchLink, pStatus) { }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static List<string> Fields => DocTools.Fields<ReconcileDocument>();

        private List<string> _Select;
        [ApiMember(Name = nameof(Select), Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(ArticleId),nameof(ArticleLink),nameof(Created),nameof(CreatorId),nameof(Document),nameof(DocumentId),nameof(Gestalt),nameof(Locked),nameof(Matches),nameof(SearchLink),nameof(Status),nameof(Updated),nameof(VersionNo)})]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
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
                _Select = DocPermissionFactory.SetSelect<ReconcileDocument>("ReconcileDocument",exists);

            }
        }

        [Obsolete, ApiMember(Name = "VisibleFields", Description = "Deprecated. Use Select instead.", AllowMultiple = true)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override List<string> VisibleFields { get => Select; set => Select = value; }



        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Clone() => this.Copy<ReconcileDocument>();

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static explicit operator Task(ReconcileDocument dto) => DocTransmogrify<ReconcileDocument, Task>.ToNewObject(dto);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static explicit operator ReconcileDocument(Task dto) => DocTransmogrify<Task, ReconcileDocument>.ToNewObject(dto);

    }
    

    [Route("/reconciledocument/{Id}/copy", "POST")]
    public partial class ReconcileDocumentCopy : ReconcileDocument {}

    public partial class ReconcileDocumentSearchBase : Search<ReconcileDocument>
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? Id { get; set; }
        public Reference Assignee { get; set; }
        public List<int> AssigneeIds { get; set; }
        public string Data { get; set; }
        public List<string> Datas { get; set; }
        public string Description { get; set; }
        public List<string> Descriptions { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? DueDateAfter { get; set; }
        public DateTime? DueDateBefore { get; set; }
        public Reference Reporter { get; set; }
        public List<int> ReporterIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"Document Adjudication",@"Document Rating",@"Document Search Reconciliation",@"Evidence on Demand"})]
        public TaskTypeEnm? Type { get; set; }
        public List<TaskTypeEnm> Types { get; set; }
        public Reference Workflow { get; set; }
        public List<int> WorkflowIds { get; set; }
        public string ArticleId { get; set; }
        public List<string> ArticleIds { get; set; }
        public string ArticleLink { get; set; }
        public List<string> ArticleLinks { get; set; }
        public Reference Document { get; set; }
        public List<int> DocumentIds { get; set; }
        public int? Matches { get; set; }
        public string SearchLink { get; set; }
        public List<string> SearchLinks { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"Matched",@"Multiple Matches",@"No Match",@"One Match"})]
        public ReconciliationStatusEnm? Status { get; set; }
        public List<ReconciliationStatusEnm> Statuss { get; set; }
    }


    [Route("/reconciledocument", "GET")]
    [Route("/reconciledocument/version", "GET, POST")]
    [Route("/reconciledocument/search", "GET, POST, DELETE")]

    public partial class ReconcileDocumentSearch : ReconcileDocumentSearchBase
    {
    }

    public class ReconcileDocumentFullTextSearch
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public ReconcileDocumentFullTextSearch() {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private ReconcileDocumentSearch _request;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public ReconcileDocumentFullTextSearch(ReconcileDocumentSearch request) => _request = request;
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
        public bool doCreated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(ReconcileDocument.Created))); }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool doUpdated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(ReconcileDocument.Updated))); }

        public bool doArticleId { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(ReconcileDocument.ArticleId))); }
        public bool doArticleLink { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(ReconcileDocument.ArticleLink))); }
        public bool doDocument { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(ReconcileDocument.Document))); }
        public bool doMatches { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(ReconcileDocument.Matches))); }
        public bool doSearchLink { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(ReconcileDocument.SearchLink))); }
        public bool doStatus { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(ReconcileDocument.Status))); }
    }


    [Route("/reconciledocument/batch", "DELETE, PATCH, POST, PUT")]

    public partial class ReconcileDocumentBatch : List<ReconcileDocument> { }


}
