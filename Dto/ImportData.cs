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
using Services.Dto.Security;
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
    public abstract partial class ImportDataBase : Dto<ImportData>
    {
        public ImportDataBase() {}

        public ImportDataBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public ImportDataBase(int? id) : this(DocConvert.ToInt(id)) {}
    
        [ApiMember(Name = nameof(CompletedOn), Description = "DateTime?", IsRequired = false)]
        public DateTime? CompletedOn { get; set; }


        [ApiMember(Name = nameof(Document), Description = "Document", IsRequired = false)]
        public Reference Document { get; set; }
        [ApiMember(Name = nameof(DocumentId), Description = "Primary Key of Document", IsRequired = false)]
        public int? DocumentId { get; set; }


        [ApiMember(Name = nameof(DocumentSets), Description = "DocumentSet", IsRequired = false)]
        public List<Reference> DocumentSets { get; set; }
        public int? DocumentSetsCount { get; set; }


        [ApiMember(Name = nameof(ErrorData), Description = "string", IsRequired = false)]
        public string ErrorData { get; set; }


        [ApiMember(Name = nameof(ExtractUrl), Description = "string", IsRequired = false)]
        public string ExtractUrl { get; set; }


        [ApiMember(Name = nameof(HighPriority), Description = "bool", IsRequired = false)]
        public bool HighPriority { get; set; }


        [ApiMember(Name = nameof(ImportFr), Description = "bool", IsRequired = false)]
        public bool ImportFr { get; set; }


        [ApiMember(Name = nameof(ImportNewName), Description = "bool", IsRequired = false)]
        public bool ImportNewName { get; set; }


        [ApiMember(Name = nameof(ImportTable), Description = "bool", IsRequired = false)]
        public bool ImportTable { get; set; }


        [ApiMember(Name = nameof(ImportText), Description = "bool", IsRequired = false)]
        public bool ImportText { get; set; }


        [ApiMember(Name = nameof(ImportType), Description = "LookupTable", IsRequired = false)]
        [ApiAllowableValues("Includes", Values = new string[] {@"Legacy",@"Extract",@"ClinicalTrials.gov"})]
        public Reference ImportType { get; set; }
        [ApiMember(Name = nameof(ImportTypeId), Description = "Primary Key of LookupTable", IsRequired = false)]
        public int? ImportTypeId { get; set; }


        [ApiMember(Name = nameof(IsLegacy), Description = "bool", IsRequired = false)]
        public bool IsLegacy { get; set; }


        [ApiMember(Name = nameof(Order), Description = "int?", IsRequired = false)]
        public int? Order { get; set; }


        [ApiMember(Name = nameof(ReferenceId), Description = "int?", IsRequired = true)]
        public int? ReferenceId { get; set; }


        [ApiMember(Name = nameof(RequestedBy), Description = "User", IsRequired = false)]
        public Reference RequestedBy { get; set; }
        [ApiMember(Name = nameof(RequestedById), Description = "Primary Key of User", IsRequired = false)]
        public int? RequestedById { get; set; }


        [ApiMember(Name = nameof(RequestedOn), Description = "DateTime?", IsRequired = false)]
        public DateTime? RequestedOn { get; set; }


        [ApiMember(Name = nameof(StartedOn), Description = "DateTime?", IsRequired = false)]
        public DateTime? StartedOn { get; set; }


        [ApiMember(Name = nameof(Status), Description = "LookupTable", IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {@"Queued",@"Processing",@"Succeeded",@"Already Imported",@"Failed",@"No JSON Found",@"Cancelled"})]
        public Reference Status { get; set; }
        [ApiMember(Name = nameof(StatusId), Description = "Primary Key of LookupTable", IsRequired = false)]
        public int? StatusId { get; set; }


    }

    [Route("/importdata", "POST")]
    [Route("/importdata/{Id}", "GET, PATCH, PUT, DELETE")]
    public partial class ImportData : ImportDataBase, IReturn<ImportData>, IDto
    {
        public ImportData()
        {
            _Constructor();
        }

        public ImportData(int? id) : base(DocConvert.ToInt(id)) {}
        public ImportData(int id) : base(id) {}
        
        #region Fields
        
        public bool? ShouldSerialize(string field)
        {
            if (IgnoredVisibleFields.Matches(field, true)) return false;
            var ret = MandatoryVisibleFields.Matches(field, true) || true == VisibleFields?.Matches(field, true);
            return ret;
        }

        public static List<string> Fields => DocTools.Fields<ImportData>();

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(CompletedOn),nameof(Created),nameof(CreatorId),nameof(Document),nameof(DocumentId),nameof(DocumentSets),nameof(DocumentSetsCount),nameof(ErrorData),nameof(ExtractUrl),nameof(Gestalt),nameof(HighPriority),nameof(ImportFr),nameof(ImportNewName),nameof(ImportTable),nameof(ImportText),nameof(ImportType),nameof(ImportTypeId),nameof(IsLegacy),nameof(Locked),nameof(Order),nameof(ReferenceId),nameof(RequestedBy),nameof(RequestedById),nameof(RequestedOn),nameof(StartedOn),nameof(Status),nameof(StatusId),nameof(Updated),nameof(VersionNo)})]
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
            nameof(DocumentSets), nameof(DocumentSetsCount)
        };
        private List<string> collections { get { return _collections; } }
    }
    
    [Route("/ImportData/{Id}/copy", "POST")]
    public partial class ImportDataCopy : ImportData {}
    public partial class ImportDataSearchBase : Search<ImportData>
    {
        public DateTime? CompletedOn { get; set; }
        public DateTime? CompletedOnAfter { get; set; }
        public DateTime? CompletedOnBefore { get; set; }
        public Reference Document { get; set; }
        public List<int> DocumentIds { get; set; }
        public List<int> DocumentSetsIds { get; set; }
        public string ErrorData { get; set; }
        public string ExtractUrl { get; set; }
        public bool? HighPriority { get; set; }
        public bool? ImportFr { get; set; }
        public bool? ImportNewName { get; set; }
        public bool? ImportTable { get; set; }
        public bool? ImportText { get; set; }
        public Reference ImportType { get; set; }
        public List<int> ImportTypeIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"Legacy",@"Extract",@"ClinicalTrials.gov"})]
        public List<string> ImportTypeNames { get; set; }
        public bool? IsLegacy { get; set; }
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
        [ApiAllowableValues("Includes", Values = new string[] {@"Queued",@"Processing",@"Succeeded",@"Already Imported",@"Failed",@"No JSON Found",@"Cancelled"})]
        public List<string> StatusNames { get; set; }
    }

    [Route("/importdata", "GET")]
    [Route("/importdata/search", "GET, POST, DELETE")]
    public partial class ImportDataSearch : ImportDataSearchBase
    {
    }

    public class ImportDataFullTextSearch
    {
        private ImportDataSearch _request;
        public ImportDataFullTextSearch(ImportDataSearch request) => _request = request;
        
        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(ImportData.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(ImportData.Updated))); }
        
        public bool doCompletedOn { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(ImportData.CompletedOn))); }
        public bool doDocument { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(ImportData.Document))); }
        public bool doDocumentSets { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(ImportData.DocumentSets))); }
        public bool doErrorData { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(ImportData.ErrorData))); }
        public bool doExtractUrl { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(ImportData.ExtractUrl))); }
        public bool doHighPriority { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(ImportData.HighPriority))); }
        public bool doImportFr { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(ImportData.ImportFr))); }
        public bool doImportNewName { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(ImportData.ImportNewName))); }
        public bool doImportTable { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(ImportData.ImportTable))); }
        public bool doImportText { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(ImportData.ImportText))); }
        public bool doImportType { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(ImportData.ImportType))); }
        public bool doIsLegacy { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(ImportData.IsLegacy))); }
        public bool doOrder { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(ImportData.Order))); }
        public bool doReferenceId { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(ImportData.ReferenceId))); }
        public bool doRequestedBy { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(ImportData.RequestedBy))); }
        public bool doRequestedOn { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(ImportData.RequestedOn))); }
        public bool doStartedOn { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(ImportData.StartedOn))); }
        public bool doStatus { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(ImportData.Status))); }
    }

    [Route("/importdata/version", "GET, POST")]
    public partial class ImportDataVersion : ImportDataSearch {}

    [Route("/importdata/batch", "DELETE, PATCH, POST, PUT")]
    public partial class ImportDataBatch : List<ImportData> { }

    [Route("/importdata/{Id}/documentset", "GET, POST, DELETE")]
    public class ImportDataJunction : Search<ImportData>
    {
        public int? Id { get; set; }
        public List<int> Ids { get; set; }
        public List<string> VisibleFields { get; set; }
        public bool ShouldSerializeVisibleFields()
        {
            { return false; }
        }


        public ImportDataJunction(int id, List<int> ids)
        {
            this.Id = id;
            this.Ids = ids;
        }
    }


    [Route("/importdata/{Id}/documentset/version", "GET")]
    public class ImportDataJunctionVersion : IReturn<Version>
    {
        public int? Id { get; set; }
        public List<int> Ids { get; set; }
        public List<string> VisibleFields { get; set; }
        public bool ShouldSerializeVisibleFields()
        {
            { return false; }
        }
    }
    [Route("/admin/importdata/ids", "GET, POST")]
    public class ImportDataIds
    {
        public bool All { get; set; }
    }
}