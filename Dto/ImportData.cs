
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
    public abstract partial class ImportDataBase : Dto<ImportData>
    {
        public ImportDataBase() {}

        public ImportDataBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public ImportDataBase(int? id) : this(DocConvert.ToInt(id)) {}

        public ImportDataBase(int? pId, DateTime? pCompletedOn, List<Reference> pDataSets, int? pDataSetsCount, Reference pDocument, int? pDocumentId, string pErrorData, string pExtractUrl, bool pHighPriority, bool pImportFr, Reference pImportLocation, int? pImportLocationId, bool pImportNewName, bool pImportTable, bool pImportText, Reference pImportType, int? pImportTypeId, bool pIsLegacy, int? pOrder, int? pReferenceId, Reference pRequestedBy, int? pRequestedById, DateTime? pRequestedOn, DateTime? pStartedOn, Reference pStatus, int? pStatusId) : this(DocConvert.ToInt(pId)) 
        {
            CompletedOn = pCompletedOn;
            DataSets = pDataSets;
            DataSetsCount = pDataSetsCount;
            Document = pDocument;
            DocumentId = pDocumentId;
            ErrorData = pErrorData;
            ExtractUrl = pExtractUrl;
            HighPriority = pHighPriority;
            ImportFr = pImportFr;
            ImportLocation = pImportLocation;
            ImportLocationId = pImportLocationId;
            ImportNewName = pImportNewName;
            ImportTable = pImportTable;
            ImportText = pImportText;
            ImportType = pImportType;
            ImportTypeId = pImportTypeId;
            IsLegacy = pIsLegacy;
            Order = pOrder;
            ReferenceId = pReferenceId;
            RequestedBy = pRequestedBy;
            RequestedById = pRequestedById;
            RequestedOn = pRequestedOn;
            StartedOn = pStartedOn;
            Status = pStatus;
            StatusId = pStatusId;
        }

        [ApiMember(Name = nameof(CompletedOn), Description = "DateTime?", IsRequired = false)]
        public DateTime? CompletedOn { get; set; }
        public List<int> CompletedOnIds { get; set; }
        public int? CompletedOnCount { get; set; }


        [ApiMember(Name = nameof(DataSets), Description = "DataSet", IsRequired = false)]
        public List<Reference> DataSets { get; set; }
        public List<int> DataSetsIds { get; set; }
        public int? DataSetsCount { get; set; }


        [ApiMember(Name = nameof(Document), Description = "Document", IsRequired = false)]
        public Reference Document { get; set; }
        [ApiMember(Name = nameof(DocumentId), Description = "Primary Key of Document", IsRequired = false)]
        public int? DocumentId { get; set; }


        [ApiMember(Name = nameof(ErrorData), Description = "string", IsRequired = false)]
        public string ErrorData { get; set; }
        public List<int> ErrorDataIds { get; set; }
        public int? ErrorDataCount { get; set; }


        [ApiMember(Name = nameof(ExtractUrl), Description = "string", IsRequired = false)]
        public string ExtractUrl { get; set; }
        public List<int> ExtractUrlIds { get; set; }
        public int? ExtractUrlCount { get; set; }


        [ApiMember(Name = nameof(HighPriority), Description = "bool", IsRequired = false)]
        public bool HighPriority { get; set; }
        public List<int> HighPriorityIds { get; set; }
        public int? HighPriorityCount { get; set; }


        [ApiMember(Name = nameof(ImportFr), Description = "bool", IsRequired = false)]
        public bool ImportFr { get; set; }
        public List<int> ImportFrIds { get; set; }
        public int? ImportFrCount { get; set; }


        [ApiAllowableValues("Includes", Values = new string[] {@"Default",@"DocData",@"Extract",@"Import Data"})]
        [ApiMember(Name = nameof(ImportLocation), Description = "LookupTable", IsRequired = false)]
        public Reference ImportLocation { get; set; }
        [ApiMember(Name = nameof(ImportLocationId), Description = "Primary Key of LookupTable", IsRequired = false)]
        public int? ImportLocationId { get; set; }


        [ApiMember(Name = nameof(ImportNewName), Description = "bool", IsRequired = false)]
        public bool ImportNewName { get; set; }
        public List<int> ImportNewNameIds { get; set; }
        public int? ImportNewNameCount { get; set; }


        [ApiMember(Name = nameof(ImportTable), Description = "bool", IsRequired = false)]
        public bool ImportTable { get; set; }
        public List<int> ImportTableIds { get; set; }
        public int? ImportTableCount { get; set; }


        [ApiMember(Name = nameof(ImportText), Description = "bool", IsRequired = false)]
        public bool ImportText { get; set; }
        public List<int> ImportTextIds { get; set; }
        public int? ImportTextCount { get; set; }


        [ApiAllowableValues("Includes", Values = new string[] {@"ClinicalTrials.gov",@"Extract",@"Legacy"})]
        [ApiMember(Name = nameof(ImportType), Description = "LookupTable", IsRequired = false)]
        public Reference ImportType { get; set; }
        [ApiMember(Name = nameof(ImportTypeId), Description = "Primary Key of LookupTable", IsRequired = false)]
        public int? ImportTypeId { get; set; }


        [ApiMember(Name = nameof(IsLegacy), Description = "bool", IsRequired = false)]
        public bool IsLegacy { get; set; }
        public List<int> IsLegacyIds { get; set; }
        public int? IsLegacyCount { get; set; }


        [ApiMember(Name = nameof(Order), Description = "int?", IsRequired = false)]
        public int? Order { get; set; }
        public List<int> OrderIds { get; set; }
        public int? OrderCount { get; set; }


        [ApiMember(Name = nameof(ReferenceId), Description = "int?", IsRequired = true)]
        public int? ReferenceId { get; set; }
        public List<int> ReferenceIdIds { get; set; }
        public int? ReferenceIdCount { get; set; }


        [ApiMember(Name = nameof(RequestedBy), Description = "User", IsRequired = false)]
        public Reference RequestedBy { get; set; }
        [ApiMember(Name = nameof(RequestedById), Description = "Primary Key of User", IsRequired = false)]
        public int? RequestedById { get; set; }


        [ApiMember(Name = nameof(RequestedOn), Description = "DateTime?", IsRequired = false)]
        public DateTime? RequestedOn { get; set; }
        public List<int> RequestedOnIds { get; set; }
        public int? RequestedOnCount { get; set; }


        [ApiMember(Name = nameof(StartedOn), Description = "DateTime?", IsRequired = false)]
        public DateTime? StartedOn { get; set; }
        public List<int> StartedOnIds { get; set; }
        public int? StartedOnCount { get; set; }


        [ApiAllowableValues("Includes", Values = new string[] {@"Already Imported",@"Cancelled",@"Failed",@"No JSON Found",@"Processing",@"Queued",@"Succeeded"})]
        [ApiMember(Name = nameof(Status), Description = "LookupTable", IsRequired = true)]
        public Reference Status { get; set; }
        [ApiMember(Name = nameof(StatusId), Description = "Primary Key of LookupTable", IsRequired = false)]
        public int? StatusId { get; set; }



        public void Deconstruct(out DateTime? pCompletedOn, out List<Reference> pDataSets, out int? pDataSetsCount, out Reference pDocument, out int? pDocumentId, out string pErrorData, out string pExtractUrl, out bool pHighPriority, out bool pImportFr, out Reference pImportLocation, out int? pImportLocationId, out bool pImportNewName, out bool pImportTable, out bool pImportText, out Reference pImportType, out int? pImportTypeId, out bool pIsLegacy, out int? pOrder, out int? pReferenceId, out Reference pRequestedBy, out int? pRequestedById, out DateTime? pRequestedOn, out DateTime? pStartedOn, out Reference pStatus, out int? pStatusId)
        {
            pCompletedOn = CompletedOn;
            pDataSets = DataSets;
            pDataSetsCount = DataSetsCount;
            pDocument = Document;
            pDocumentId = DocumentId;
            pErrorData = ErrorData;
            pExtractUrl = ExtractUrl;
            pHighPriority = HighPriority;
            pImportFr = ImportFr;
            pImportLocation = ImportLocation;
            pImportLocationId = ImportLocationId;
            pImportNewName = ImportNewName;
            pImportTable = ImportTable;
            pImportText = ImportText;
            pImportType = ImportType;
            pImportTypeId = ImportTypeId;
            pIsLegacy = IsLegacy;
            pOrder = Order;
            pReferenceId = ReferenceId;
            pRequestedBy = RequestedBy;
            pRequestedById = RequestedById;
            pRequestedOn = RequestedOn;
            pStartedOn = StartedOn;
            pStatus = Status;
            pStatusId = StatusId;
        }

        //Not ready until C# v8.?
        //public ImportDataBase With(int? pId = Id, DateTime? pCompletedOn = CompletedOn, List<Reference> pDataSets = DataSets, int? pDataSetsCount = DataSetsCount, Reference pDocument = Document, int? pDocumentId = DocumentId, string pErrorData = ErrorData, string pExtractUrl = ExtractUrl, bool pHighPriority = HighPriority, bool pImportFr = ImportFr, Reference pImportLocation = ImportLocation, int? pImportLocationId = ImportLocationId, bool pImportNewName = ImportNewName, bool pImportTable = ImportTable, bool pImportText = ImportText, Reference pImportType = ImportType, int? pImportTypeId = ImportTypeId, bool pIsLegacy = IsLegacy, int? pOrder = Order, int? pReferenceId = ReferenceId, Reference pRequestedBy = RequestedBy, int? pRequestedById = RequestedById, DateTime? pRequestedOn = RequestedOn, DateTime? pStartedOn = StartedOn, Reference pStatus = Status, int? pStatusId = StatusId) => 
        //	new ImportDataBase(pId, pCompletedOn, pDataSets, pDataSetsCount, pDocument, pDocumentId, pErrorData, pExtractUrl, pHighPriority, pImportFr, pImportLocation, pImportLocationId, pImportNewName, pImportTable, pImportText, pImportType, pImportTypeId, pIsLegacy, pOrder, pReferenceId, pRequestedBy, pRequestedById, pRequestedOn, pStartedOn, pStatus, pStatusId);

    }


    [Route("/importdata", "POST")]
    [Route("/importdata/{Id}", "GET, PATCH, PUT, DELETE")]

    public partial class ImportData : ImportDataBase, IReturn<ImportData>, IDto, ICloneable
    {
        public ImportData() => _Constructor();

        public ImportData(int? id) : base(DocConvert.ToInt(id)) {}
        public ImportData(int id) : base(id) {}
        public ImportData(int? pId, DateTime? pCompletedOn, List<Reference> pDataSets, int? pDataSetsCount, Reference pDocument, int? pDocumentId, string pErrorData, string pExtractUrl, bool pHighPriority, bool pImportFr, Reference pImportLocation, int? pImportLocationId, bool pImportNewName, bool pImportTable, bool pImportText, Reference pImportType, int? pImportTypeId, bool pIsLegacy, int? pOrder, int? pReferenceId, Reference pRequestedBy, int? pRequestedById, DateTime? pRequestedOn, DateTime? pStartedOn, Reference pStatus, int? pStatusId) :
            base(pId, pCompletedOn, pDataSets, pDataSetsCount, pDocument, pDocumentId, pErrorData, pExtractUrl, pHighPriority, pImportFr, pImportLocation, pImportLocationId, pImportNewName, pImportTable, pImportText, pImportType, pImportTypeId, pIsLegacy, pOrder, pReferenceId, pRequestedBy, pRequestedById, pRequestedOn, pStartedOn, pStatus, pStatusId) { }

        public static List<string> Fields => DocTools.Fields<ImportData>();

        private List<string> _Select;
        [ApiMember(Name = nameof(Select), Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(CompletedOn),nameof(Created),nameof(CreatorId),nameof(DataSets),nameof(DataSetsCount),nameof(Document),nameof(DocumentId),nameof(ErrorData),nameof(ExtractUrl),nameof(Gestalt),nameof(HighPriority),nameof(ImportFr),nameof(ImportLocation),nameof(ImportLocationId),nameof(ImportNewName),nameof(ImportTable),nameof(ImportText),nameof(ImportType),nameof(ImportTypeId),nameof(IsLegacy),nameof(Locked),nameof(Order),nameof(ReferenceId),nameof(RequestedBy),nameof(RequestedById),nameof(RequestedOn),nameof(StartedOn),nameof(Status),nameof(StatusId),nameof(Updated),nameof(VersionNo)})]
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


        private List<string> _collections = new List<string>
        {
            nameof(DataSets), nameof(DataSetsCount), nameof(DataSetsIds)
        };
        private List<string> collections { get { return _collections; } }


        public object Clone() => this.Copy<ImportData>();

    }
    

    [Route("/importdata/{Id}/copy", "POST")]
    public partial class ImportDataCopy : ImportData {}

    public partial class ImportDataSearchBase : Search<ImportData>
    {
        public int? Id { get; set; }
        public DateTime? CompletedOn { get; set; }
        public DateTime? CompletedOnAfter { get; set; }
        public DateTime? CompletedOnBefore { get; set; }
        public List<int> DataSetsIds { get; set; }
        public Reference Document { get; set; }
        public List<int> DocumentIds { get; set; }
        public string ErrorData { get; set; }
        public string ExtractUrl { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> HighPriority { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> ImportFr { get; set; }
        public Reference ImportLocation { get; set; }
        public List<int> ImportLocationIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"Default",@"DocData",@"Extract",@"Import Data"})]
        public List<string> ImportLocationNames { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> ImportNewName { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> ImportTable { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> ImportText { get; set; }
        public Reference ImportType { get; set; }
        public List<int> ImportTypeIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"ClinicalTrials.gov",@"Extract",@"Legacy"})]
        public List<string> ImportTypeNames { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> IsLegacy { get; set; }
        public int? Order { get; set; }
        public int? ReferenceId { get; set; }
        public Reference RequestedBy { get; set; }
        public List<int> RequestedByIds { get; set; }
        public DateTime? RequestedOn { get; set; }
        public DateTime? RequestedOnAfter { get; set; }
        public DateTime? RequestedOnBefore { get; set; }
        public DateTime? StartedOn { get; set; }
        public DateTime? StartedOnAfter { get; set; }
        public DateTime? StartedOnBefore { get; set; }
        public Reference Status { get; set; }
        public List<int> StatusIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"Already Imported",@"Cancelled",@"Failed",@"No JSON Found",@"Processing",@"Queued",@"Succeeded"})]
        public List<string> StatusNames { get; set; }
    }


    [Route("/importdata", "GET")]
    [Route("/importdata/version", "GET, POST")]
    [Route("/importdata/search", "GET, POST, DELETE")]

    public partial class ImportDataSearch : ImportDataSearchBase
    {
    }

    public class ImportDataFullTextSearch
    {
        public ImportDataFullTextSearch() {}
        private ImportDataSearch _request;
        public ImportDataFullTextSearch(ImportDataSearch request) => _request = request;

        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(ImportData.Created))); }
        public bool doUpdated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(ImportData.Updated))); }

        public bool doCompletedOn { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(ImportData.CompletedOn))); }
        public bool doDataSets { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(ImportData.DataSets))); }
        public bool doDocument { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(ImportData.Document))); }
        public bool doErrorData { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(ImportData.ErrorData))); }
        public bool doExtractUrl { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(ImportData.ExtractUrl))); }
        public bool doHighPriority { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(ImportData.HighPriority))); }
        public bool doImportFr { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(ImportData.ImportFr))); }
        public bool doImportLocation { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(ImportData.ImportLocation))); }
        public bool doImportNewName { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(ImportData.ImportNewName))); }
        public bool doImportTable { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(ImportData.ImportTable))); }
        public bool doImportText { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(ImportData.ImportText))); }
        public bool doImportType { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(ImportData.ImportType))); }
        public bool doIsLegacy { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(ImportData.IsLegacy))); }
        public bool doOrder { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(ImportData.Order))); }
        public bool doReferenceId { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(ImportData.ReferenceId))); }
        public bool doRequestedBy { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(ImportData.RequestedBy))); }
        public bool doRequestedOn { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(ImportData.RequestedOn))); }
        public bool doStartedOn { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(ImportData.StartedOn))); }
        public bool doStatus { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(ImportData.Status))); }
    }


    [Route("/importdata/batch", "DELETE, PATCH, POST, PUT")]

    public partial class ImportDataBatch : List<ImportData> { }


    [Route("/importdata/{Id}/{Junction}/version", "GET, POST")]
    [Route("/importdata/{Id}/{Junction}", "GET, POST, DELETE")]
    public class ImportDataJunction : ImportDataSearchBase {}



}
