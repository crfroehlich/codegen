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

namespace Services.Schema
{
    [TableMapping(DocConstantModelName.DOCUMENTSET)]
    public partial class DocEntityDocumentSet : DocEntityBase
    {
        private const string DOCUMENTSET_CACHE = "DocumentSetCache";
        public const string TABLE_NAME = DocConstantModelName.DOCUMENTSET;
        
        #region Constructor
        public DocEntityDocumentSet(Session session) : base(session) {}

        public DocEntityDocumentSet() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        #region VisibleFields

        protected override List<string> _visibleFields
        {
            get
            {
                if(null == __vf)
                {
                    __vf = DocWebSession.GetTypeVisibleFields(new DocumentSet());
                }
                return __vf;
            }
        }

        #endregion VisibleFields

        #region Static Members
        public static DocEntityDocumentSet GetDocumentSet(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetDocumentSet(reference.Id) : null;
        }

        public static DocEntityDocumentSet GetDocumentSet(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityDocumentSet>.GetFromCache(primaryKey, DOCUMENTSET_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityDocumentSet>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityDocumentSet>.UpdateCache(ret.Id, ret, DOCUMENTSET_CACHE);
                    DocEntityThreadCache<DocEntityDocumentSet>.UpdateCache(ret.Hash, ret, DOCUMENTSET_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityDocumentSet GetDocumentSet(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityDocumentSet>.GetFromCache(hash, DOCUMENTSET_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityDocumentSet>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityDocumentSet>.UpdateCache(ret.Id, ret, DOCUMENTSET_CACHE);
                    DocEntityThreadCache<DocEntityDocumentSet>.UpdateCache(ret.Hash, ret, DOCUMENTSET_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field(Length = int.MaxValue)]
        public string AdditionalCriteria { get; set; }


        [Field]
        public DocEntitySet<DocEntityCharacteristic> Characteristics { get; private set; }


        public int? CharacteristicsCount { get { return Characteristics.Count(); } private set { var noid = value; } }


        [Field]
        [Association(PairTo = nameof(DocEntityClient.DocumentSets), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityClient> Clients { get; private set; }


        public int? ClientsCount { get { return Clients.Count(); } private set { var noid = value; } }


        [Field]
        public DocEntitySet<DocEntityComparator> Comparators { get; private set; }


        public int? ComparatorsCount { get { return Comparators.Count(); } private set { var noid = value; } }


        [Field(Nullable = false, DefaultValue = false)]
        public bool Confidential { get; set; }


        [Field(Length = int.MaxValue)]
        public string DataCollection { get; set; }


        [Field]
        [Association(PairTo = nameof(DocEntityDivision.DocumentSets), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityDivision> Divisions { get; private set; }


        public int? DivisionsCount { get { return Divisions.Count(); } private set { var noid = value; } }


        [Field]
        [Association(PairTo = nameof(DocEntityDocument.DocumentSets), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityDocument> Documents { get; private set; }


        public int? DocumentsCount { get { return Documents.Count(); } private set { var noid = value; } }


        [Field]
        [Association(PairTo = nameof(DocEntityDocumentSet.Owner), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityDocumentSet> DocumentSets { get; private set; }


        public int? DocumentSetsCount { get { return DocumentSets.Count(); } private set { var noid = value; } }


        [Field]
        public int? EvidencePortalId { get; set; }


        [Field(Length = int.MaxValue)]
        public string ExtractionProtocol { get; set; }


        [Field]
        public int? FqId { get; set; }


        [Field]
        public int? FramedQuestionId { get; set; }


        [Field(Length = int.MaxValue)]
        public string GeneralScope { get; set; }


        [Field]
        [Association(PairTo = nameof(DocEntityDocumentSetHistory.DocumentSet), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityDocumentSetHistory> Histories { get; private set; }


        public int? HistoriesCount { get { return Histories.Count(); } private set { var noid = value; } }


        [Field(DefaultValue = 9999)]
        public int? ImportPriority { get; set; }


        [Field]
        [Association(PairTo = nameof(DocEntityImportData.DocumentSets), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityImportData> Imports { get; private set; }


        public int? ImportsCount { get { return Imports.Count(); } private set { var noid = value; } }


        [Field(Length = int.MaxValue)]
        public string Indications { get; set; }


        [Field]
        public DocEntitySet<DocEntityIntervention> Interventions { get; private set; }


        public int? InterventionsCount { get { return Interventions.Count(); } private set { var noid = value; } }


        [Field]
        public int? LibraryPackageId { get; set; }


        [Field(Nullable = false)]
        public string Name { get; set; }


        [Field(Length = int.MaxValue)]
        public string Notes { get; set; }


        [Field(Length = int.MaxValue)]
        public string OriginalComparators { get; set; }


        [Field]
        public string OriginalDatabase { get; set; }


        [Field(Length = int.MaxValue)]
        public string OriginalDesigns { get; set; }


        [Field(Length = int.MaxValue)]
        public string OriginalInterventions { get; set; }


        [Field(Length = int.MaxValue)]
        public string OriginalOutcomes { get; set; }


        [Field(Length = int.MaxValue)]
        public string OriginalSearch { get; set; }


        [Field]
        public DocEntitySet<DocEntityOutcome> Outcomes { get; private set; }


        public int? OutcomesCount { get { return Outcomes.Count(); } private set { var noid = value; } }


        [Field]
        public DocEntityDocumentSet Owner { get; set; }
        public int? OwnerId { get { return Owner?.Id; } private set { var noid = value; } }


        [Field(Length = int.MaxValue)]
        public string Participants { get; set; }


        [Field]
        public string PRISMA { get; set; }


        [Field]
        [Association(PairTo = nameof(DocEntityProject.Dataset), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityProject> Projects { get; private set; }


        public int? ProjectsCount { get { return Projects.Count(); } private set { var noid = value; } }


        [Field]
        public DocEntityTeam ProjectTeam { get; set; }
        public int? ProjectTeamId { get { return ProjectTeam?.Id; } private set { var noid = value; } }


        [Field]
        public int? ProtocolReferenceId { get; set; }


        [Field]
        public string QUOROM { get; set; }


        [Field]
        [Association(PairTo = nameof(DocEntityScope.DocumentSet), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityScope> Scopes { get; private set; }


        public int? ScopesCount { get { return Scopes.Count(); } private set { var noid = value; } }


        [Field]
        public DateTime? SearchEnd { get; set; }


        [Field]
        public DateTime? SearchStart { get; set; }


        [Field(Length = int.MaxValue)]
        public string SearchStrategy { get; set; }


        [Field]
        public DateTime? SearchUpdated { get; set; }


        [Field(Length = int.MaxValue)]
        public string SelectionCriteria { get; set; }


        [Field(Length = int.MaxValue)]
        public string Settings { get; set; }


        [Field(Nullable = false, DefaultValue = false)]
        public bool ShowEtw { get; set; }


        [Field]
        [Association(PairTo = nameof(DocEntityStatsStudySet.DocumentSet), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityStatsStudySet> Stats { get; private set; }


        public int? StatsCount { get { return Stats.Count(); } private set { var noid = value; } }


        [Field]
        public DocEntitySet<DocEntityStudyDesign> StudyDesigns { get; private set; }


        public int? StudyDesignsCount { get { return StudyDesigns.Count(); } private set { var noid = value; } }


        [Field]
        public DocEntityLookupTable Type { get; set; }
        public int? TypeId { get { return Type?.Id; } private set { var noid = value; } }


        [Field]
        public int? UpdateFrequency { get; set; }


        [Field]
        [Association(PairTo = nameof(DocEntityUser.DocumentSets), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityUser> Users { get; private set; }


        public int? UsersCount { get { return Users.Count(); } private set { var noid = value; } }



        [Field]
        public override string Gestalt { get; set; }

        [Field(DefaultValue = 0), Version(VersionMode.Manual)]
        public override int VersionNo { get; set; }

        [Field]
        public override DateTime? Created { get; set; }

        [Field]
        public override DateTime? Updated { get; set; }

        [Field(DefaultValue = false), FieldMapping(nameof(Locked))]
        public override bool Locked { get; set; }

        [Field(DefaultValue = false), FieldMapping(nameof(Archived))]
        public override bool Archived { get; set; }

        #endregion Properties

        #region Overrides of DocEntity

        public override DocConstantModelName TableName => TABLE_NAME;

        public const string CACHE_KEY_PREFIX = "FindDocumentSets";

        #endregion Overrides of DocEntity

        #region Entity overrides
        /// <summary>
        ///    Called when entity is about to be removed.
        /// </summary>
        protected override void OnRemoving()
        {
            try
            {
                DocumentSets.Clear(); //foreach thing in DocumentSets en.Remove();
            }
            catch(Exception ex)
            {
                throw new DocException("Failed to delete DocumentSet in DocumentSets delete", ex);
            }
            try
            {
                Histories.Clear(); //foreach thing in Histories en.Remove();
            }
            catch(Exception ex)
            {
                throw new DocException("Failed to delete DocumentSet in Histories delete", ex);
            }
            try
            {
                Scopes.Clear(); //foreach thing in Scopes en.Remove();
            }
            catch(Exception ex)
            {
                throw new DocException("Failed to delete DocumentSet in Scopes delete", ex);
            }
            try
            {
                Stats.Clear(); //foreach thing in Stats en.Remove();
            }
            catch(Exception ex)
            {
                throw new DocException("Failed to delete DocumentSet in Stats delete", ex);
            }
            base.OnRemoving();
        }

        /// <summary>
        ///    Called when entity should be validated. Override this method to perform custom object validation.
        /// </summary>
        protected override void OnValidate()
        {
            if (false == ValidationMessage.IsValid)
            {
                throw new HttpError(HttpStatusCode.Conflict, $"DocumentSet requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();

            FlushCache();

            _validated = true;


        }

        public override IDocEntity SaveChanges(DocConstantPermission permission = null)
        {
            Name = Name?.TrimAndPruneSpaces();
            OriginalDatabase = OriginalDatabase?.TrimAndPruneSpaces();
            PRISMA = PRISMA?.TrimAndPruneSpaces();
            QUOROM = QUOROM?.TrimAndPruneSpaces();
            return base.SaveChanges(permission);
        }

        public override void FlushCache()
        {
            base.FlushCache();
            DocCacheClient.RemoveById(Id);
        }
        #endregion Entity overrides

        #region Validation
        public DocValidationMessage ValidationMessage
        {
            get
            {
                var isValid = true;
                var message = string.Empty;

                if(DocTools.IsNullOrEmpty(Confidential))
                {
                    isValid = false;
                    message += " Confidential is a required property.";
                }
                if(DocTools.IsNullOrEmpty(Name))
                {
                    isValid = false;
                    message += " Name is a required property.";
                }
                if(DocTools.IsNullOrEmpty(ShowEtw))
                {
                    isValid = false;
                    message += " ShowEtw is a required property.";
                }
                if(null != Type && Type?.Enum?.Name != "DocumentSetType")
                {
                    isValid = false;
                    message += " Type is a " + Type?.Enum?.Name + ", but must be a DocumentSetType.";
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Converters

        public DocumentSet ToDto() => Mapper.Map<DocEntityDocumentSet, DocumentSet>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }

    public static partial class UniqueConstraintFilter
    {
        public static Expression<Func<DocEntityDocumentSet, bool>> DocumentSetIgnoreArchived() => d => d.Archived == false;
    }

    public partial class DocumentSetMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityDocumentSet,DocumentSet> _EntityToDto;
        protected IMappingExpression<DocumentSet,DocEntityDocumentSet> _DtoToEntity;

        public DocumentSetMapper()
        {
            CreateMap<DocEntitySet<DocEntityDocumentSet>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityDocumentSet,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityDocumentSet>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityDocumentSet.GetDocumentSet(c));
            _EntityToDto = CreateMap<DocEntityDocumentSet,DocumentSet>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, "Updated")))
                .ForMember(dest => dest.AdditionalCriteria, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.AdditionalCriteria))))
                .ForMember(dest => dest.Characteristics, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.Characteristics))))
                .ForMember(dest => dest.CharacteristicsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.CharacteristicsCount))))
                .ForMember(dest => dest.Clients, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.Clients))))
                .ForMember(dest => dest.ClientsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.ClientsCount))))
                .ForMember(dest => dest.Comparators, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.Comparators))))
                .ForMember(dest => dest.ComparatorsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.ComparatorsCount))))
                .ForMember(dest => dest.Confidential, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.Confidential))))
                .ForMember(dest => dest.DataCollection, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.DataCollection))))
                .ForMember(dest => dest.Divisions, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.Divisions))))
                .ForMember(dest => dest.DivisionsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.DivisionsCount))))
                .ForMember(dest => dest.Documents, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.Documents))))
                .ForMember(dest => dest.DocumentsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.DocumentsCount))))
                .ForMember(dest => dest.DocumentSets, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.DocumentSets))))
                .ForMember(dest => dest.DocumentSetsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.DocumentSetsCount))))
                .ForMember(dest => dest.EvidencePortalId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.EvidencePortalId))))
                .ForMember(dest => dest.ExtractionProtocol, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.ExtractionProtocol))))
                .ForMember(dest => dest.FqId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.FqId))))
                .ForMember(dest => dest.FramedQuestionId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.FramedQuestionId))))
                .ForMember(dest => dest.GeneralScope, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.GeneralScope))))
                .ForMember(dest => dest.Histories, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.Histories))))
                .ForMember(dest => dest.HistoriesCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.HistoriesCount))))
                .ForMember(dest => dest.ImportPriority, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.ImportPriority))))
                .ForMember(dest => dest.Imports, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.Imports))))
                .ForMember(dest => dest.ImportsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.ImportsCount))))
                .ForMember(dest => dest.Indications, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.Indications))))
                .ForMember(dest => dest.Interventions, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.Interventions))))
                .ForMember(dest => dest.InterventionsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.InterventionsCount))))
                .ForMember(dest => dest.LibraryPackageId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.LibraryPackageId))))
                .ForMember(dest => dest.Name, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.Name))))
                .ForMember(dest => dest.Notes, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.Notes))))
                .ForMember(dest => dest.OriginalComparators, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.OriginalComparators))))
                .ForMember(dest => dest.OriginalDatabase, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.OriginalDatabase))))
                .ForMember(dest => dest.OriginalDesigns, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.OriginalDesigns))))
                .ForMember(dest => dest.OriginalInterventions, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.OriginalInterventions))))
                .ForMember(dest => dest.OriginalOutcomes, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.OriginalOutcomes))))
                .ForMember(dest => dest.OriginalSearch, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.OriginalSearch))))
                .ForMember(dest => dest.Outcomes, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.Outcomes))))
                .ForMember(dest => dest.OutcomesCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.OutcomesCount))))
                .ForMember(dest => dest.Owner, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.Owner))))
                .ForMember(dest => dest.OwnerId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.OwnerId))))
                .ForMember(dest => dest.Participants, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.Participants))))
                .ForMember(dest => dest.PRISMA, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.PRISMA))))
                .ForMember(dest => dest.Projects, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.Projects))))
                .ForMember(dest => dest.ProjectsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.ProjectsCount))))
                .ForMember(dest => dest.ProjectTeam, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.ProjectTeam))))
                .ForMember(dest => dest.ProjectTeamId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.ProjectTeamId))))
                .ForMember(dest => dest.ProtocolReferenceId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.ProtocolReferenceId))))
                .ForMember(dest => dest.QUOROM, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.QUOROM))))
                .ForMember(dest => dest.Scopes, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.Scopes))))
                .ForMember(dest => dest.ScopesCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.ScopesCount))))
                .ForMember(dest => dest.SearchEnd, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.SearchEnd))))
                .ForMember(dest => dest.SearchStart, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.SearchStart))))
                .ForMember(dest => dest.SearchStrategy, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.SearchStrategy))))
                .ForMember(dest => dest.SearchUpdated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.SearchUpdated))))
                .ForMember(dest => dest.SelectionCriteria, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.SelectionCriteria))))
                .ForMember(dest => dest.Settings, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.Settings))))
                .ForMember(dest => dest.ShowEtw, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.ShowEtw))))
                .ForMember(dest => dest.Stats, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.Stats))))
                .ForMember(dest => dest.StatsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.StatsCount))))
                .ForMember(dest => dest.StudyDesigns, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.StudyDesigns))))
                .ForMember(dest => dest.StudyDesignsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.StudyDesignsCount))))
                .ForMember(dest => dest.Type, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.Type))))
                .ForMember(dest => dest.TypeId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.TypeId))))
                .ForMember(dest => dest.UpdateFrequency, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.UpdateFrequency))))
                .ForMember(dest => dest.Users, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.Users))))
                .ForMember(dest => dest.UsersCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.UsersCount))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<DocumentSet,DocEntityDocumentSet>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
