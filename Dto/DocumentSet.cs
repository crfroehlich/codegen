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
    public abstract partial class DocumentSetBase : Dto<DocumentSet>
    {
        public DocumentSetBase() {}

        public DocumentSetBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public DocumentSetBase(int? id) : this(DocConvert.ToInt(id)) {}
    
        [ApiMember(Name = nameof(AdditionalCriteria), Description = "string", IsRequired = false)]
        public string AdditionalCriteria { get; set; }


        [ApiMember(Name = nameof(Archived), Description = "bool?", IsRequired = false)]
        public bool? Archived { get; set; }


        [ApiMember(Name = nameof(Categories), Description = "JctAttributeCategoryAttributeDocumentSet", IsRequired = false)]
        public List<Reference> Categories { get; set; }
        public int? CategoriesCount { get; set; }


        [ApiMember(Name = nameof(Characteristics), Description = "Characteristic", IsRequired = false)]
        public List<Reference> Characteristics { get; set; }
        public int? CharacteristicsCount { get; set; }


        [ApiMember(Name = nameof(Clients), Description = "Client", IsRequired = false)]
        public List<Reference> Clients { get; set; }
        public int? ClientsCount { get; set; }


        [ApiMember(Name = nameof(Comparators), Description = "Comparator", IsRequired = false)]
        public List<Reference> Comparators { get; set; }
        public int? ComparatorsCount { get; set; }


        [ApiMember(Name = nameof(Confidential), Description = "bool", IsRequired = false)]
        public bool Confidential { get; set; }


        [ApiMember(Name = nameof(DataCollection), Description = "string", IsRequired = false)]
        public string DataCollection { get; set; }


        [ApiMember(Name = nameof(Divisions), Description = "Division", IsRequired = false)]
        public List<Reference> Divisions { get; set; }
        public int? DivisionsCount { get; set; }


        [ApiMember(Name = nameof(Documents), Description = "Document", IsRequired = false)]
        public List<Reference> Documents { get; set; }
        public int? DocumentsCount { get; set; }


        [ApiMember(Name = nameof(DocumentSets), Description = "DocumentSet", IsRequired = false)]
        public List<Reference> DocumentSets { get; set; }
        public int? DocumentSetsCount { get; set; }


        [ApiMember(Name = nameof(EvidencePortalId), Description = "int?", IsRequired = false)]
        public int? EvidencePortalId { get; set; }


        [ApiMember(Name = nameof(ExtractionProtocol), Description = "string", IsRequired = false)]
        public string ExtractionProtocol { get; set; }


        [ApiMember(Name = nameof(FqId), Description = "int?", IsRequired = false)]
        public int? FqId { get; set; }


        [ApiMember(Name = nameof(FramedQuestionId), Description = "int?", IsRequired = false)]
        public int? FramedQuestionId { get; set; }


        [ApiMember(Name = nameof(GeneralScope), Description = "string", IsRequired = false)]
        public string GeneralScope { get; set; }


        [ApiMember(Name = nameof(Histories), Description = "DocumentSetHistory", IsRequired = false)]
        public List<Reference> Histories { get; set; }
        public int? HistoriesCount { get; set; }


        [ApiMember(Name = nameof(ImportPriority), Description = "int?", IsRequired = false)]
        public int? ImportPriority { get; set; }


        [ApiMember(Name = nameof(Imports), Description = "ImportData", IsRequired = false)]
        public List<Reference> Imports { get; set; }
        public int? ImportsCount { get; set; }


        [ApiMember(Name = nameof(Indications), Description = "string", IsRequired = false)]
        public string Indications { get; set; }


        [ApiMember(Name = nameof(Interventions), Description = "Intervention", IsRequired = false)]
        public List<Reference> Interventions { get; set; }
        public int? InterventionsCount { get; set; }


        [ApiMember(Name = nameof(LibraryPackageId), Description = "int?", IsRequired = false)]
        public int? LibraryPackageId { get; set; }


        [ApiMember(Name = nameof(Name), Description = "string", IsRequired = true)]
        public string Name { get; set; }


        [ApiMember(Name = nameof(NonDigitizedDocuments), Description = "Document", IsRequired = false)]
        public List<Reference> NonDigitizedDocuments { get; set; }
        public int? NonDigitizedDocumentsCount { get; set; }


        [ApiMember(Name = nameof(Notes), Description = "string", IsRequired = false)]
        public string Notes { get; set; }


        [ApiMember(Name = nameof(OriginalComparators), Description = "string", IsRequired = false)]
        public string OriginalComparators { get; set; }


        [ApiMember(Name = nameof(OriginalDatabase), Description = "string", IsRequired = false)]
        public string OriginalDatabase { get; set; }


        [ApiMember(Name = nameof(OriginalDesigns), Description = "string", IsRequired = false)]
        public string OriginalDesigns { get; set; }


        [ApiMember(Name = nameof(OriginalInterventions), Description = "string", IsRequired = false)]
        public string OriginalInterventions { get; set; }


        [ApiMember(Name = nameof(OriginalOutcomes), Description = "string", IsRequired = false)]
        public string OriginalOutcomes { get; set; }


        [ApiMember(Name = nameof(OriginalSearch), Description = "string", IsRequired = false)]
        public string OriginalSearch { get; set; }


        [ApiMember(Name = nameof(Outcomes), Description = "Outcome", IsRequired = false)]
        public List<Reference> Outcomes { get; set; }
        public int? OutcomesCount { get; set; }


        [ApiMember(Name = nameof(Owner), Description = "DocumentSet", IsRequired = false)]
        public Reference Owner { get; set; }
        [ApiMember(Name = nameof(OwnerId), Description = "Primary Key of DocumentSet", IsRequired = false)]
        public int? OwnerId { get; set; }


        [ApiMember(Name = nameof(Packages), Description = "Package", IsRequired = false)]
        public List<Reference> Packages { get; set; }
        public int? PackagesCount { get; set; }


        [ApiMember(Name = nameof(Participants), Description = "string", IsRequired = false)]
        public string Participants { get; set; }


        [ApiMember(Name = nameof(PRISMA), Description = "string", IsRequired = false)]
        public string PRISMA { get; set; }


        [ApiMember(Name = nameof(Products), Description = "Product", IsRequired = false)]
        public List<Reference> Products { get; set; }
        public int? ProductsCount { get; set; }


        [ApiMember(Name = nameof(ProjectTeam), Description = "Team", IsRequired = false)]
        public Reference ProjectTeam { get; set; }
        [ApiMember(Name = nameof(ProjectTeamId), Description = "Primary Key of Team", IsRequired = false)]
        public int? ProjectTeamId { get; set; }


        [ApiMember(Name = nameof(ProtocolReferenceId), Description = "int?", IsRequired = false)]
        public int? ProtocolReferenceId { get; set; }


        [ApiMember(Name = nameof(QUOROM), Description = "string", IsRequired = false)]
        public string QUOROM { get; set; }


        [ApiMember(Name = nameof(Scopes), Description = "Scope", IsRequired = false)]
        public List<Reference> Scopes { get; set; }
        public int? ScopesCount { get; set; }


        [ApiMember(Name = nameof(SearchEnd), Description = "DateTime?", IsRequired = false)]
        public DateTime? SearchEnd { get; set; }


        [ApiMember(Name = nameof(SearchStart), Description = "DateTime?", IsRequired = false)]
        public DateTime? SearchStart { get; set; }


        [ApiMember(Name = nameof(SearchStrategy), Description = "string", IsRequired = false)]
        public string SearchStrategy { get; set; }


        [ApiMember(Name = nameof(SelectionCriteria), Description = "string", IsRequired = false)]
        public string SelectionCriteria { get; set; }


        [ApiMember(Name = nameof(Settings), Description = "string", IsRequired = false)]
        public string Settings { get; set; }


        [ApiMember(Name = nameof(Stats), Description = "StatsStudySet", IsRequired = false)]
        public List<Reference> Stats { get; set; }
        public int? StatsCount { get; set; }


        [ApiMember(Name = nameof(StudyDesigns), Description = "StudyDesign", IsRequired = false)]
        public List<Reference> StudyDesigns { get; set; }
        public int? StudyDesignsCount { get; set; }


        [ApiMember(Name = nameof(Type), Description = "LookupTable", IsRequired = false)]
        [ApiAllowableValues("Includes", Values = new string[] {@"Global",@"Therapeutic Area",@"Disease State",@"Data Set",@"SERVE Portal"})]
        public Reference Type { get; set; }
        [ApiMember(Name = nameof(TypeId), Description = "Primary Key of LookupTable", IsRequired = false)]
        public int? TypeId { get; set; }


        [ApiMember(Name = nameof(Users), Description = "User", IsRequired = false)]
        public List<Reference> Users { get; set; }
        public int? UsersCount { get; set; }


    }

    [Route("/documentset", "POST")]
    [Route("/profile/documentset", "POST")]
    [Route("/documentset/{Id}", "GET, PATCH, PUT, DELETE")]
    [Route("/profile/documentset/{Id}", "GET, PATCH, PUT, DELETE")]
    public partial class DocumentSet : DocumentSetBase, IReturn<DocumentSet>, IDto
    {
        public DocumentSet()
        {
            _Constructor();
        }

        public DocumentSet(int? id) : base(DocConvert.ToInt(id)) {}
        public DocumentSet(int id) : base(id) {}
        
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
        public static List<string> Fields => _fields ?? (_fields = DocTools.Fields<DocumentSet>());

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(AdditionalCriteria),nameof(Archived),nameof(Categories),nameof(CategoriesCount),nameof(Characteristics),nameof(CharacteristicsCount),nameof(Clients),nameof(ClientsCount),nameof(Comparators),nameof(ComparatorsCount),nameof(Confidential),nameof(Created),nameof(CreatorId),nameof(DataCollection),nameof(Divisions),nameof(DivisionsCount),nameof(Documents),nameof(DocumentsCount),nameof(DocumentSets),nameof(DocumentSetsCount),nameof(EvidencePortalId),nameof(ExtractionProtocol),nameof(FqId),nameof(FramedQuestionId),nameof(GeneralScope),nameof(Gestalt),nameof(Histories),nameof(HistoriesCount),nameof(ImportPriority),nameof(Imports),nameof(ImportsCount),nameof(Indications),nameof(Interventions),nameof(InterventionsCount),nameof(LibraryPackageId),nameof(Locked),nameof(Name),nameof(NonDigitizedDocuments),nameof(NonDigitizedDocumentsCount),nameof(Notes),nameof(OriginalComparators),nameof(OriginalDatabase),nameof(OriginalDesigns),nameof(OriginalInterventions),nameof(OriginalOutcomes),nameof(OriginalSearch),nameof(Outcomes),nameof(OutcomesCount),nameof(Owner),nameof(OwnerId),nameof(Packages),nameof(PackagesCount),nameof(Participants),nameof(PRISMA),nameof(Products),nameof(ProductsCount),nameof(ProjectTeam),nameof(ProjectTeamId),nameof(ProtocolReferenceId),nameof(QUOROM),nameof(Scopes),nameof(ScopesCount),nameof(SearchEnd),nameof(SearchStart),nameof(SearchStrategy),nameof(SelectionCriteria),nameof(Settings),nameof(Stats),nameof(StatsCount),nameof(StudyDesigns),nameof(StudyDesignsCount),nameof(Type),nameof(TypeId),nameof(Updated),nameof(Users),nameof(UsersCount),nameof(VersionNo)})]
        public new List<string> VisibleFields
        {
            get
            {
                if(null == this) return new List<string>();
                if(null == _VisibleFields)
                {
                    _VisibleFields = DocWebSession.GetTypeVisibleFields(this);
                }
                return _VisibleFields;
            }
            set
            {
                var requested = value ?? new List<string>();
                var exists = requested.Where( r => Fields.Any( f => DocTools.AreEqual(r, f) ) ).ToList();
                _VisibleFields = DocPermissionFactory.SetVisibleFields<DocumentSet>("DocumentSet",exists);
            }
        }

        #endregion Fields
        private List<string> _collections = new List<string>
        {
            nameof(Categories), nameof(CategoriesCount), nameof(Characteristics), nameof(CharacteristicsCount), nameof(Clients), nameof(ClientsCount), nameof(Comparators), nameof(ComparatorsCount), nameof(Divisions), nameof(DivisionsCount), nameof(Documents), nameof(DocumentsCount), nameof(DocumentSets), nameof(DocumentSetsCount), nameof(Histories), nameof(HistoriesCount), nameof(Imports), nameof(ImportsCount), nameof(Interventions), nameof(InterventionsCount), nameof(NonDigitizedDocuments), nameof(NonDigitizedDocumentsCount), nameof(Outcomes), nameof(OutcomesCount), nameof(Packages), nameof(PackagesCount), nameof(Products), nameof(ProductsCount), nameof(Scopes), nameof(ScopesCount), nameof(Stats), nameof(StatsCount), nameof(StudyDesigns), nameof(StudyDesignsCount), nameof(Users), nameof(UsersCount)
        };
        private List<string> collections { get { return _collections; } }
    }
    
    [Route("/DocumentSet/{Id}/copy", "POST")]
    [Route("/profile/DocumentSet/{Id}/copy", "POST")]
    public partial class DocumentSetCopy : DocumentSet {}
    [Route("/documentset", "GET")]
    [Route("/profile/documentset", "GET")]
    [Route("/documentset/search", "GET, POST, DELETE")]
    [Route("/profile/documentset/search", "GET, POST, DELETE")]
    public partial class DocumentSetSearch : Search<DocumentSet>
    {
        public string AdditionalCriteria { get; set; }
        public bool? Archived { get; set; }
        public List<int> CategoriesIds { get; set; }
        public List<int> CharacteristicsIds { get; set; }
        public List<int> ClientsIds { get; set; }
        public List<int> ComparatorsIds { get; set; }
        public bool? Confidential { get; set; }
        public string DataCollection { get; set; }
        public List<int> DivisionsIds { get; set; }
        public List<int> DocumentsIds { get; set; }
        public List<int> DocumentSetsIds { get; set; }
        public int? EvidencePortalId { get; set; }
        public string ExtractionProtocol { get; set; }
        public int? FqId { get; set; }
        public int? FramedQuestionId { get; set; }
        public string GeneralScope { get; set; }
        public List<int> HistoriesIds { get; set; }
        public int? ImportPriority { get; set; }
        public List<int> ImportsIds { get; set; }
        public string Indications { get; set; }
        public List<int> InterventionsIds { get; set; }
        public int? LibraryPackageId { get; set; }
        public string Name { get; set; }
        public List<int> NonDigitizedDocumentsIds { get; set; }
        public string Notes { get; set; }
        public string OriginalComparators { get; set; }
        public string OriginalDatabase { get; set; }
        public string OriginalDesigns { get; set; }
        public string OriginalInterventions { get; set; }
        public string OriginalOutcomes { get; set; }
        public string OriginalSearch { get; set; }
        public List<int> OutcomesIds { get; set; }
        public Reference Owner { get; set; }
        public List<int> OwnerIds { get; set; }
        public List<int> PackagesIds { get; set; }
        public string Participants { get; set; }
        public string PRISMA { get; set; }
        public List<int> ProductsIds { get; set; }
        public Reference ProjectTeam { get; set; }
        public List<int> ProjectTeamIds { get; set; }
        public int? ProtocolReferenceId { get; set; }
        public string QUOROM { get; set; }
        public List<int> ScopesIds { get; set; }
        public DateTime? SearchEnd { get; set; }
        public DateTime? SearchEndAfter { get; set; }
        public DateTime? SearchEndBefore { get; set; }
        public DateTime? SearchStart { get; set; }
        public DateTime? SearchStartAfter { get; set; }
        public DateTime? SearchStartBefore { get; set; }
        public string SearchStrategy { get; set; }
        public string SelectionCriteria { get; set; }
        public string Settings { get; set; }
        public List<int> StatsIds { get; set; }
        public List<int> StudyDesignsIds { get; set; }
        public Reference Type { get; set; }
        public List<int> TypeIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"Global",@"Therapeutic Area",@"Disease State",@"Data Set",@"SERVE Portal"})]
        public List<string> TypeNames { get; set; }
        public List<int> UsersIds { get; set; }
    }
    
    public class DocumentSetFullTextSearch
    {
        private DocumentSetSearch _request;
        public DocumentSetFullTextSearch(DocumentSetSearch request) => _request = request;
        
        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.Updated))); }
        
        public bool doAdditionalCriteria { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.AdditionalCriteria))); }
        public bool doArchived { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.Archived))); }
        public bool doCategories { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.Categories))); }
        public bool doCharacteristics { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.Characteristics))); }
        public bool doClients { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.Clients))); }
        public bool doComparators { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.Comparators))); }
        public bool doConfidential { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.Confidential))); }
        public bool doDataCollection { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.DataCollection))); }
        public bool doDivisions { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.Divisions))); }
        public bool doDocuments { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.Documents))); }
        public bool doDocumentSets { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.DocumentSets))); }
        public bool doEvidencePortalId { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.EvidencePortalId))); }
        public bool doExtractionProtocol { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.ExtractionProtocol))); }
        public bool doFqId { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.FqId))); }
        public bool doFramedQuestionId { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.FramedQuestionId))); }
        public bool doGeneralScope { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.GeneralScope))); }
        public bool doHistories { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.Histories))); }
        public bool doImportPriority { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.ImportPriority))); }
        public bool doImports { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.Imports))); }
        public bool doIndications { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.Indications))); }
        public bool doInterventions { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.Interventions))); }
        public bool doLibraryPackageId { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.LibraryPackageId))); }
        public bool doName { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.Name))); }
        public bool doNonDigitizedDocuments { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.NonDigitizedDocuments))); }
        public bool doNotes { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.Notes))); }
        public bool doOriginalComparators { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.OriginalComparators))); }
        public bool doOriginalDatabase { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.OriginalDatabase))); }
        public bool doOriginalDesigns { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.OriginalDesigns))); }
        public bool doOriginalInterventions { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.OriginalInterventions))); }
        public bool doOriginalOutcomes { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.OriginalOutcomes))); }
        public bool doOriginalSearch { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.OriginalSearch))); }
        public bool doOutcomes { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.Outcomes))); }
        public bool doOwner { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.Owner))); }
        public bool doPackages { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.Packages))); }
        public bool doParticipants { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.Participants))); }
        public bool doPRISMA { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.PRISMA))); }
        public bool doProducts { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.Products))); }
        public bool doProjectTeam { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.ProjectTeam))); }
        public bool doProtocolReferenceId { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.ProtocolReferenceId))); }
        public bool doQUOROM { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.QUOROM))); }
        public bool doScopes { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.Scopes))); }
        public bool doSearchEnd { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.SearchEnd))); }
        public bool doSearchStart { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.SearchStart))); }
        public bool doSearchStrategy { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.SearchStrategy))); }
        public bool doSelectionCriteria { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.SelectionCriteria))); }
        public bool doSettings { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.Settings))); }
        public bool doStats { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.Stats))); }
        public bool doStudyDesigns { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.StudyDesigns))); }
        public bool doType { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.Type))); }
        public bool doUsers { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DocumentSet.Users))); }
    }

    [Route("/documentset/version", "GET, POST")]
    public partial class DocumentSetVersion : DocumentSetSearch {}

    [Route("/documentset/batch", "DELETE, PATCH, POST, PUT")]
    [Route("/profile/documentset/batch", "DELETE, PATCH, POST, PUT")]
    public partial class DocumentSetBatch : List<DocumentSet> { }

    [Route("/documentset/{Id}/allusers", "GET, POST, DELETE")]
    [Route("/profile/documentset/{Id}/allusers", "GET, POST, DELETE")]
    [Route("/documentset/{Id}/lookuptablebinding", "GET, POST, DELETE")]
    [Route("/profile/documentset/{Id}/lookuptablebinding", "GET, POST, DELETE")]
    [Route("/documentset/{Id}/jctattributecategoryattributedocumentset", "GET, POST, DELETE")]
    [Route("/profile/documentset/{Id}/jctattributecategoryattributedocumentset", "GET, POST, DELETE")]
    [Route("/documentset/{Id}/characteristic", "GET, POST, DELETE")]
    [Route("/profile/documentset/{Id}/characteristic", "GET, POST, DELETE")]
    [Route("/documentset/{Id}/client", "GET, POST, DELETE")]
    [Route("/profile/documentset/{Id}/client", "GET, POST, DELETE")]
    [Route("/documentset/{Id}/comparator", "GET, POST, DELETE")]
    [Route("/profile/documentset/{Id}/comparator", "GET, POST, DELETE")]
    [Route("/documentset/{Id}/division", "GET, POST, DELETE")]
    [Route("/profile/documentset/{Id}/division", "GET, POST, DELETE")]
    [Route("/documentset/{Id}/document", "GET, POST, DELETE")]
    [Route("/profile/documentset/{Id}/document", "GET, POST, DELETE")]
    [Route("/documentset/{Id}/documentset", "GET, POST, DELETE")]
    [Route("/profile/documentset/{Id}/documentset", "GET, POST, DELETE")]
    [Route("/documentset/{Id}/documentsethistory", "GET, POST, DELETE")]
    [Route("/profile/documentset/{Id}/documentsethistory", "GET, POST, DELETE")]
    [Route("/documentset/{Id}/importdata", "GET, POST, DELETE")]
    [Route("/profile/documentset/{Id}/importdata", "GET, POST, DELETE")]
    [Route("/documentset/{Id}/intervention", "GET, POST, DELETE")]
    [Route("/profile/documentset/{Id}/intervention", "GET, POST, DELETE")]
    [Route("/documentset/{Id}/nondigitizeddocument", "GET, POST, DELETE")]
    [Route("/profile/documentset/{Id}/nondigitizeddocument", "GET, POST, DELETE")]
    [Route("/documentset/{Id}/outcome", "GET, POST, DELETE")]
    [Route("/profile/documentset/{Id}/outcome", "GET, POST, DELETE")]
    [Route("/documentset/{Id}/package", "GET, POST, DELETE")]
    [Route("/profile/documentset/{Id}/package", "GET, POST, DELETE")]
    [Route("/documentset/{Id}/product", "GET, POST, DELETE")]
    [Route("/profile/documentset/{Id}/product", "GET, POST, DELETE")]
    [Route("/documentset/{Id}/projectlink", "GET, POST, DELETE")]
    [Route("/profile/documentset/{Id}/projectlink", "GET, POST, DELETE")]
    [Route("/documentset/{Id}/scope", "GET, POST, DELETE")]
    [Route("/profile/documentset/{Id}/scope", "GET, POST, DELETE")]
    [Route("/documentset/{Id}/statsstudyset", "GET, POST, DELETE")]
    [Route("/profile/documentset/{Id}/statsstudyset", "GET, POST, DELETE")]
    [Route("/documentset/{Id}/studydesign", "GET, POST, DELETE")]
    [Route("/profile/documentset/{Id}/studydesign", "GET, POST, DELETE")]
    [Route("/documentset/{Id}/user", "GET, POST, DELETE")]
    [Route("/profile/documentset/{Id}/user", "GET, POST, DELETE")]
    [Route("/documentset/{Id}/workflow", "GET, POST, DELETE")]
    [Route("/profile/documentset/{Id}/workflow", "GET, POST, DELETE")]
    public class DocumentSetJunction : Search<DocumentSet>
    {
        public int? Id { get; set; }
        public List<int> Ids { get; set; }
        public List<string> VisibleFields { get; set; }
        public bool ShouldSerializeVisibleFields()
        {
            { return false; }
        }


        public DocumentSetJunction(int id, List<int> ids)
        {
            this.Id = id;
            this.Ids = ids;
        }
    }


    [Route("/documentset/{Id}/allusers/version", "GET")]
    [Route("/profile/documentset/{Id}/allusers/version", "GET")]
    [Route("/documentset/{Id}/lookuptablebinding/version", "GET")]
    [Route("/profile/documentset/{Id}/lookuptablebinding/version", "GET")]
    [Route("/documentset/{Id}/jctattributecategoryattributedocumentset/version", "GET")]
    [Route("/profile/documentset/{Id}/jctattributecategoryattributedocumentset/version", "GET")]
    [Route("/documentset/{Id}/characteristic/version", "GET")]
    [Route("/profile/documentset/{Id}/characteristic/version", "GET")]
    [Route("/documentset/{Id}/client/version", "GET")]
    [Route("/profile/documentset/{Id}/client/version", "GET")]
    [Route("/documentset/{Id}/comparator/version", "GET")]
    [Route("/profile/documentset/{Id}/comparator/version", "GET")]
    [Route("/documentset/{Id}/division/version", "GET")]
    [Route("/profile/documentset/{Id}/division/version", "GET")]
    [Route("/documentset/{Id}/document/version", "GET")]
    [Route("/profile/documentset/{Id}/document/version", "GET")]
    [Route("/documentset/{Id}/documentset/version", "GET")]
    [Route("/profile/documentset/{Id}/documentset/version", "GET")]
    [Route("/documentset/{Id}/documentsethistory/version", "GET")]
    [Route("/profile/documentset/{Id}/documentsethistory/version", "GET")]
    [Route("/documentset/{Id}/importdata/version", "GET")]
    [Route("/profile/documentset/{Id}/importdata/version", "GET")]
    [Route("/documentset/{Id}/intervention/version", "GET")]
    [Route("/profile/documentset/{Id}/intervention/version", "GET")]
    [Route("/documentset/{Id}/nondigitizeddocument/version", "GET")]
    [Route("/profile/documentset/{Id}/nondigitizeddocument/version", "GET")]
    [Route("/documentset/{Id}/outcome/version", "GET")]
    [Route("/profile/documentset/{Id}/outcome/version", "GET")]
    [Route("/documentset/{Id}/package/version", "GET")]
    [Route("/profile/documentset/{Id}/package/version", "GET")]
    [Route("/documentset/{Id}/product/version", "GET")]
    [Route("/profile/documentset/{Id}/product/version", "GET")]
    [Route("/documentset/{Id}/projectlink/version", "GET")]
    [Route("/profile/documentset/{Id}/projectlink/version", "GET")]
    [Route("/documentset/{Id}/scope/version", "GET")]
    [Route("/profile/documentset/{Id}/scope/version", "GET")]
    [Route("/documentset/{Id}/statsstudyset/version", "GET")]
    [Route("/profile/documentset/{Id}/statsstudyset/version", "GET")]
    [Route("/documentset/{Id}/studydesign/version", "GET")]
    [Route("/profile/documentset/{Id}/studydesign/version", "GET")]
    [Route("/documentset/{Id}/user/version", "GET")]
    [Route("/profile/documentset/{Id}/user/version", "GET")]
    [Route("/documentset/{Id}/workflow/version", "GET")]
    [Route("/profile/documentset/{Id}/workflow/version", "GET")]
    public class DocumentSetJunctionVersion : IReturn<Version>
    {
        public int? Id { get; set; }
        public List<int> Ids { get; set; }
        public List<string> VisibleFields { get; set; }
        public bool ShouldSerializeVisibleFields()
        {
            { return false; }
        }
    }
    [Route("/admin/documentset/ids", "GET, POST")]
    public class DocumentSetIds
    {
        public bool All { get; set; }
    }
}