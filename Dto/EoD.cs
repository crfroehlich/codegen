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
    public abstract partial class EoDBase : TaskBase
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public EoDBase() {}

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public EoDBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public EoDBase(int? id) : this(DocConvert.ToInt(id)) {}

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public EoDBase(int? pId, Reference pDocument, int? pDocumentId, EoDStatusEnm? pStatus) : this(DocConvert.ToInt(pId)) 
        {
            Document = pDocument;
            DocumentId = pDocumentId;
            Status = pStatus;
        }

        [ApiMember(Name = nameof(Document), Description = "Document", IsRequired = false)]
[GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Reference Document { get; set; }
        [ApiMember(Name = nameof(DocumentId), Description = "Primary Key of Document", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? DocumentId { get; set; }

        [ApiAllowableValues("Includes", Values = new string[] {@"Accepted",@"Collected",@"Rejected",@"Requested",@"Unavailable"})]
        [ApiMember(Name = nameof(Status), Description = "EoDStatusEnm?", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public EoDStatusEnm? Status { get; set; }
        [ApiMember(Name = nameof(StatusIds), Description = "Status Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> StatusIds { get; set; }
        [ApiMember(Name = nameof(StatusCount), Description = "Status Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? StatusCount { get; set; }



        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public void Deconstruct(out Reference pDocument, out int? pDocumentId, out EoDStatusEnm? pStatus)
        {
            pDocument = Document;
            pDocumentId = DocumentId;
            pStatus = Status;
        }

        //Not ready until C# v8.?
        //[GeneratedCodeAttribute("T4", "1.0.0.0")]
        //public EoDBase With(int? pId = Id, Reference pDocument = Document, int? pDocumentId = DocumentId, EoDStatusEnm? pStatus = Status) => 
        //	new EoDBase(pId, pDocument, pDocumentId, pStatus);

    }


    [Route("/eod", "POST")]
    [Route("/eod/{Id}", "GET, PATCH, PUT, DELETE")]

    public partial class EoD : EoDBase, IReturn<EoD>, IDto, ICloneable
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public EoD() => _Constructor();
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public EoD(int? id) : base(DocConvert.ToInt(id)) {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public EoD(int id) : base(id) {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public EoD(int? pId, Reference pDocument, int? pDocumentId, EoDStatusEnm? pStatus) :
            base(pId, pDocument, pDocumentId, pStatus) { }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static List<string> Fields => DocTools.Fields<EoD>();

        private List<string> _Select;
        [ApiMember(Name = nameof(Select), Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Created),nameof(CreatorId),nameof(Document),nameof(DocumentId),nameof(Gestalt),nameof(Locked),nameof(Status),nameof(Updated),nameof(VersionNo)})]
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
                _Select = DocPermissionFactory.SetSelect<EoD>("EoD",exists);

            }
        }

        [Obsolete, ApiMember(Name = "VisibleFields", Description = "Deprecated. Use Select instead.", AllowMultiple = true)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override List<string> VisibleFields { get => Select; set => Select = value; }



        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Clone() => this.Copy<EoD>();

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static explicit operator Task(EoD dto) => DocTransmogrify<EoD, Task>.ToNewObject(dto);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static explicit operator EoD(Task dto) => DocTransmogrify<Task, EoD>.ToNewObject(dto);

    }
    

    [Route("/eod/{Id}/copy", "POST")]
    public partial class EoDCopy : EoD {}

    public partial class EoDSearchBase : Search<EoD>
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
        public Reference Document { get; set; }
        public List<int> DocumentIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"Accepted",@"Collected",@"Rejected",@"Requested",@"Unavailable"})]
        public EoDStatusEnm? Status { get; set; }
        public List<EoDStatusEnm> Statuss { get; set; }
    }


    [Route("/eod", "GET")]
    [Route("/eod/version", "GET, POST")]
    [Route("/eod/search", "GET, POST, DELETE")]

    public partial class EoDSearch : EoDSearchBase
    {
    }

    public class EoDFullTextSearch
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public EoDFullTextSearch() {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private EoDSearch _request;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public EoDFullTextSearch(EoDSearch request) => _request = request;
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
        public bool doCreated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(EoD.Created))); }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool doUpdated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(EoD.Updated))); }

        public bool doDocument { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(EoD.Document))); }
        public bool doStatus { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(EoD.Status))); }
    }


    [Route("/eod/batch", "DELETE, PATCH, POST, PUT")]

    public partial class EoDBatch : List<EoD> { }


}
