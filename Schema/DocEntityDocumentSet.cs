﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when
//    the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AutoMapper;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Dynamic;
using System.Net;
using System.Runtime.Serialization;

using Services.Core;
using Services.Db;
using Services.Dto;
using Services.Enums;
using Services.Models;

using ServiceStack;

using Typed.Notifications;
using Typed.Settings;

using Xtensive.Orm;
using Xtensive.Orm.Model;

using Attribute = Services.Dto.Attribute;
using ValueType = Services.Dto.ValueType;

namespace Services.Schema
{
    [TableMapping(DocConstantModelName.DOCUMENTSET)]

    public partial class DocEntityDocumentSet : DocEntityBase
    {
        private const string DOCUMENTSET_CACHE = "DocumentSetCache";

        #region Constructor

        /// <summary>
        ///    Initializes a new instance of this class.
        /// </summary>
        /// <param name="session">The session.</param>
        public DocEntityDocumentSet(Session session)
            : base(session) { }

        /// <summary>
        ///    Initializes a new instance of this class as a default, session-less object.
        /// </summary>
        public DocEntityDocumentSet()
            : base(new DocDbSession(Xtensive.Orm.Session.Current)) { }

        #endregion Constructor

        #region VisibleFields
        
        private List<string> __vf;
        private List<string> _visibleFields
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
        
        public bool IsPropertyVisible(string propertyName)
        {
            return _visibleFields.Count == 0 || _visibleFields.Any(v => DocTools.AreEqual(v, propertyName));
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
        [FieldMapping(nameof(AdditionalCriteria))]
        public string AdditionalCriteria { get; set; }


        [Field(DefaultValue = false)]
        [FieldMapping(nameof(Archived))]
        public bool? Archived { get; set; }


        [Field()]
        [FieldMapping(nameof(Categories))]
        [Association( PairTo = nameof(JctAttributeCategoryAttributeDocumentSet.DocumentSet), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear )]
        public DocEntitySet<DocEntityJctAttributeCategoryAttributeDocumentSet> Categories { get; private set; }


        public int? CategoriesCount { get { return Categories.Count(); } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Characteristics))]
        public DocEntitySet<DocEntityCharacteristic> Characteristics { get; private set; }


        public int? CharacteristicsCount { get { return Characteristics.Count(); } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Clients))]
        [Association( PairTo = nameof(Client.DocumentSets), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear )]
        public DocEntitySet<DocEntityClient> Clients { get; private set; }


        public int? ClientsCount { get { return Clients.Count(); } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Comparators))]
        public DocEntitySet<DocEntityIntervention> Comparators { get; private set; }


        public int? ComparatorsCount { get { return Comparators.Count(); } private set { var noid = value; } }


        [Field(Nullable = false, DefaultValue = false)]
        [FieldMapping(nameof(Confidential))]
        public bool Confidential { get; set; }


        [Field(Length = int.MaxValue)]
        [FieldMapping(nameof(DataCollection))]
        public string DataCollection { get; set; }


        [Field()]
        [FieldMapping(nameof(Divisions))]
        [Association( PairTo = nameof(Division.DocumentSets), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear )]
        public DocEntitySet<DocEntityDivision> Divisions { get; private set; }


        public int? DivisionsCount { get { return Divisions.Count(); } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Documents))]
        [Association( PairTo = nameof(Document.DocumentSets), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear )]
        public DocEntitySet<DocEntityDocument> Documents { get; private set; }


        public int? DocumentsCount { get { return Documents.Count(); } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(DocumentSets))]
        [Association( PairTo = nameof(DocumentSet.Owner), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear )]
        public DocEntitySet<DocEntityDocumentSet> DocumentSets { get; private set; }


        public int? DocumentSetsCount { get { return DocumentSets.Count(); } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(EvidencePortalId))]
        public int? EvidencePortalId { get; set; }


        [Field(Length = int.MaxValue)]
        [FieldMapping(nameof(ExtractionProtocol))]
        public string ExtractionProtocol { get; set; }


        [Field()]
        [FieldMapping(nameof(FqId))]
        public int? FqId { get; set; }


        [Field()]
        [FieldMapping(nameof(FramedQuestionId))]
        public int? FramedQuestionId { get; set; }


        [Field(DefaultValue = "", Length = int.MaxValue)]
        [FieldMapping(nameof(GeneralScope))]
        public string GeneralScope { get; set; }


        [Field()]
        [FieldMapping(nameof(Histories))]
        [Association( PairTo = nameof(DocumentSetHistory.DocumentSet), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear )]
        public DocEntitySet<DocEntityDocumentSetHistory> Histories { get; private set; }


        public int? HistoriesCount { get { return Histories.Count(); } private set { var noid = value; } }


        [Field(DefaultValue = 9999)]
        [FieldMapping(nameof(ImportPriority))]
        public int? ImportPriority { get; set; }


        [Field()]
        [FieldMapping(nameof(Imports))]
        [Association( PairTo = nameof(ImportData.DocumentSets), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear )]
        public DocEntitySet<DocEntityImportData> Imports { get; private set; }


        public int? ImportsCount { get { return Imports.Count(); } private set { var noid = value; } }


        [Field(Length = int.MaxValue)]
        [FieldMapping(nameof(Indications))]
        public string Indications { get; set; }


        [Field()]
        [FieldMapping(nameof(Interventions))]
        public DocEntitySet<DocEntityIntervention> Interventions { get; private set; }


        public int? InterventionsCount { get { return Interventions.Count(); } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(LibraryPackageId))]
        public int? LibraryPackageId { get; set; }


        [Field(Nullable = false)]
        [FieldMapping(nameof(Name))]
        public string Name { get; set; }


        [Field()]
        [FieldMapping(nameof(NonDigitizedDocuments))]
        [Association( PairTo = nameof(Document.NonDigitizedDocumentSets), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear )]
        public DocEntitySet<DocEntityDocument> NonDigitizedDocuments { get; private set; }


        public int? NonDigitizedDocumentsCount { get { return NonDigitizedDocuments.Count(); } private set { var noid = value; } }


        [Field(Length = int.MaxValue)]
        [FieldMapping(nameof(Notes))]
        public string Notes { get; set; }


        [Field(Length = int.MaxValue)]
        [FieldMapping(nameof(OriginalComparators))]
        public string OriginalComparators { get; set; }


        [Field()]
        [FieldMapping(nameof(OriginalDatabase))]
        public string OriginalDatabase { get; set; }


        [Field(Length = int.MaxValue)]
        [FieldMapping(nameof(OriginalDesigns))]
        public string OriginalDesigns { get; set; }


        [Field(Length = int.MaxValue)]
        [FieldMapping(nameof(OriginalInterventions))]
        public string OriginalInterventions { get; set; }


        [Field(Length = int.MaxValue)]
        [FieldMapping(nameof(OriginalOutcomes))]
        public string OriginalOutcomes { get; set; }


        [Field(Length = int.MaxValue)]
        [FieldMapping(nameof(OriginalSearch))]
        public string OriginalSearch { get; set; }


        [Field()]
        [FieldMapping(nameof(Outcomes))]
        public DocEntitySet<DocEntityOutcome> Outcomes { get; private set; }


        public int? OutcomesCount { get { return Outcomes.Count(); } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Owner))]
        public DocEntityDocumentSet Owner { get; set; }
        public int? OwnerId { get { return Owner?.Id; } private set { var noid = value; } }


        [Field(Length = int.MaxValue)]
        [FieldMapping(nameof(Participants))]
        public string Participants { get; set; }


        [Field()]
        [FieldMapping(nameof(PRISMA))]
        public string PRISMA { get; set; }


        [Field()]
        [FieldMapping(nameof(Products))]
        [Association( PairTo = nameof(Product.Dataset), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear )]
        public DocEntitySet<DocEntityProduct> Products { get; private set; }


        public int? ProductsCount { get { return Products.Count(); } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(ProjectTeam))]
        public DocEntityTeam ProjectTeam { get; set; }
        public int? ProjectTeamId { get { return ProjectTeam?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(ProtocolReferenceId))]
        public int? ProtocolReferenceId { get; set; }


        [Field()]
        [FieldMapping(nameof(QUOROM))]
        public string QUOROM { get; set; }


        [Field()]
        [FieldMapping(nameof(Scopes))]
        [Association( PairTo = nameof(Scope.DocumentSet), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear )]
        public DocEntitySet<DocEntityScope> Scopes { get; private set; }


        public int? ScopesCount { get { return Scopes.Count(); } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(SearchEnd))]
        public DateTime? SearchEnd { get; set; }


        [Field()]
        [FieldMapping(nameof(SearchStart))]
        public DateTime? SearchStart { get; set; }


        [Field(Length = int.MaxValue)]
        [FieldMapping(nameof(SearchStrategy))]
        public string SearchStrategy { get; set; }


        [Field(Length = int.MaxValue)]
        [FieldMapping(nameof(SelectionCriteria))]
        public string SelectionCriteria { get; set; }


        [Field(Length = int.MaxValue)]
        [FieldMapping(nameof(Settings))]
        public string Settings { get; set; }


        [Field()]
        [FieldMapping(nameof(Stats))]
        [Association( PairTo = nameof(StatsStudySet.DocumentSet), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear )]
        public DocEntitySet<DocEntityStatsStudySet> Stats { get; private set; }


        public int? StatsCount { get { return Stats.Count(); } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(StudyDesigns))]
        public DocEntitySet<DocEntityStudyDesign> StudyDesigns { get; private set; }


        public int? StudyDesignsCount { get { return StudyDesigns.Count(); } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Type))]
        public DocEntityLookupTable Type { get; set; }
        public int? TypeId { get { return Type?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Users))]
        [Association( PairTo = nameof(User.DocumentSets), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear )]
        public DocEntitySet<DocEntityUser> Users { get; private set; }


        public int? UsersCount { get { return Users.Count(); } private set { var noid = value; } }



        [Field(LazyLoad = false, Length = Int32.MaxValue)]
        [FieldMapping(DocEntityConstants.PropertyName.GESTALT)]
        public override string Gestalt { get; set; }

        [Field()]
        [FieldMapping(BasePropertyName.HASH)]
        public override Guid Hash { get; set; }

        [Field(DefaultValue = 0), Version(VersionMode.Manual)]
        public override int VersionNo { get; set; }

        [Field()]
        public override DateTime? Created { get; set; }

        [Field()]
        public override DateTime? Updated { get; set; }

        [Field()]
        public override bool Locked { get; set; }

        private bool? _isNewlyLocked;
        private bool? _isModified;
        
        private List<string> __editableFields;
        private List<string> _editableFields 
        {
            get
            {
                if (null == __editableFields)
                {
                    __editableFields = _GetEditableFields();
                }
                return __editableFields;
            }
        }
        #endregion Properties

        #region Overrides of DocEntity

        /// <summary>
        ///    The Model name of this class is <see cref="DocConstantModelName.DOCUMENTSET" />
        /// </summary>
        public static readonly DocConstantModelName MODEL_NAME = DocConstantModelName.DOCUMENTSET;

        /// <summary>
        ///    The Model name of this instance is always the same as <see cref="MODEL_NAME" />
        /// </summary>
        public override DocConstantModelName ModelName
        {
            get { return MODEL_NAME; }
        }
        
        public const string CACHE_KEY_PREFIX = "FindDocumentSets";

        /// <summary>
        ///    Converts this Domain object to its corresponding Model.
        /// </summary>
        public override T ToModel<T>()
        {
            return  null;

        }

        #endregion Overrides of DocEntity

        #region Entity overrides

        protected override object AdjustFieldValue(FieldInfo fieldInfo, object oldValue, object newValue)
        {
            if (!Locked || true == _isNewlyLocked || _editableFields.Any(f => f == fieldInfo.Name))
            {
                return base.AdjustFieldValue(fieldInfo, oldValue, newValue);
            }
            else
            {
                return oldValue;
            }
        }
        
        ///    Called before field value is about to be changed. This event is raised only on actual change attempt (i.e. when new value differs from the current one).
        protected override void OnSettingFieldValue(FieldInfo fieldInfo, object value)
        {
            if (_OnSettingFieldValue(fieldInfo, value) && (!Locked || true == _isNewlyLocked || _editableFields.Any(f => f == fieldInfo.Name)))
            {
                base.OnSettingFieldValue(fieldInfo, value);
            }
        }

        /// <summary>
        ///    Called when field value has been changed.
        /// </summary>
        protected override void OnSetFieldValue(FieldInfo fieldInfo, object oldValue, object newValue)
        {
            if (fieldInfo.Name == nameof(Locked) && true == DocConvert.ToBool(newValue)) 
            {
                _isNewlyLocked = true;
            }
            if (fieldInfo.Name != nameof(Locked) && fieldInfo.Name != nameof(Hash) && fieldInfo.Name != nameof(Id) && fieldInfo.Name != nameof(VersionNo) && fieldInfo.Name != nameof(Gestalt) && fieldInfo.Name != nameof(Created) && fieldInfo.Name != nameof(Updated))
            {
                _isModified = true;
            }
            if (_OnSetFieldValue(fieldInfo, oldValue, newValue) && (!Locked || true == _isNewlyLocked || _editableFields.Any(f => f == fieldInfo.Name)))
            {
                base.OnSetFieldValue(fieldInfo, oldValue, newValue);
            }
        }

        /// <summary>
        ///    Called when entity is about to be removed.
        /// </summary>
        protected override void OnRemoving()
        {
            if (Locked) throw new ServiceStack.HttpError(System.Net.HttpStatusCode.Forbidden, $"Locked records cannot be deleted.");
            if (!DocPermissionFactory.HasPermission(this, null, DocConstantPermission.DELETE))
            {
                throw new ServiceStack.HttpError(System.Net.HttpStatusCode.Forbidden, $"You do not have permission to delete this {ModelName}.");
            }

            _OnRemoving();
            base.OnRemoving();
        }

        /// <summary>
        ///    Called after entity marked as removed.
        /// </summary>
        protected override void OnRemove()
        {
            _OnRemove();
            base.OnRemove();
            FlushCache();
        }

        private bool _validated = false;

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

            var hash = GetGuid();
            if(Hash != hash)
                Hash = hash;

            Name = Name?.TrimAndPruneSpaces();
            OriginalDatabase = OriginalDatabase?.TrimAndPruneSpaces();
            PRISMA = PRISMA?.TrimAndPruneSpaces();
            QUOROM = QUOROM?.TrimAndPruneSpaces();

            if (DocTools.IsNullOrEmpty(Created))
            {
                Created = DateTime.UtcNow;
            }
            if (DocTools.IsNullOrEmpty(Updated))
            {
                Updated = Created;
            }
            if (true == _isModified)
            {
                Updated = DateTime.UtcNow;
                VersionNo += 1;
                _OnIsModified();
                _isModified = null;
            }

            _OnSaveChanges(permission);

            if(!_validated)
                OnValidate();

            _OnSetGestalt();

            //Only do permissions checks AFTER validation has finished to get better errors
            //The transaction still hasn't completed, so if we throw then the rollback will work as expected
            permission = permission ?? DocConstantPermission.EDIT;
            if(!DocPermissionFactory.HasPermission(this, null, permission))
            {
                throw new ServiceStack.HttpError(System.Net.HttpStatusCode.Forbidden, $"You do not have permission to {permission} this {ModelName}.");
            }

            return this;
        }

        public override bool UnlockRecord()
        {
            var ret = DocPermissionFactory.HasPermission(this, null, DocConstantPermission.UNLOCK);
            _OnUnlock();
            if (!ret) throw new ServiceStack.HttpError(System.Net.HttpStatusCode.Forbidden, $"You do not have permission to unlock this {nameof(DocumentSet)}");
            if (ret)
            {
                _isNewlyLocked = true;
                Locked = false;
            }
            return ret;
        }

        public void FlushCache()
        {
            _OnFlushCache();
            DocCacheClient.RemoveSearch("DocumentSet");
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

        #region Hash

        
        public static Guid GetGuid(DocEntityDocumentSet thing)
        {
            if(thing == null) return Guid.Empty;
            return thing.GetGuid();
        }

        /// <summary>
        ///    Get Hash Code
        /// </summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
        public override Guid GetGuid(bool forceRefresh = false)
        {
            return GetGuid(this);
        }

        #endregion Hash

        #region Converters

        public override string ToString() => _ToString();

        public override Reference ToReference()
        {
            var ret = new Reference(Id, Name , Gestalt);
            return _ToReference(ret);
        }

        public DocumentSet ToDto() => Mapper.Map<DocEntityDocumentSet, DocumentSet>(this);

        public override IDto ToIDto() => ToDto();

        #endregion Converters
    }

    public partial class DocumentSetMapper : Profile
    {
        private IMappingExpression<DocEntityDocumentSet,DocumentSet> _EntityToDto;
        private IMappingExpression<DocumentSet,DocEntityDocumentSet> _DtoToEntity;

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
                .ForMember(dest => dest.Archived, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.Archived))))
                .ForMember(dest => dest.Categories, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.Categories))))
                .ForMember(dest => dest.CategoriesCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.CategoriesCount))))
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
                .ForMember(dest => dest.NonDigitizedDocuments, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.NonDigitizedDocuments))))
                .ForMember(dest => dest.NonDigitizedDocumentsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.NonDigitizedDocumentsCount))))
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
                .ForMember(dest => dest.Products, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.Products))))
                .ForMember(dest => dest.ProductsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.ProductsCount))))
                .ForMember(dest => dest.ProjectTeam, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.ProjectTeam))))
                .ForMember(dest => dest.ProjectTeamId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.ProjectTeamId))))
                .ForMember(dest => dest.ProtocolReferenceId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.ProtocolReferenceId))))
                .ForMember(dest => dest.QUOROM, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.QUOROM))))
                .ForMember(dest => dest.Scopes, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.Scopes))))
                .ForMember(dest => dest.ScopesCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.ScopesCount))))
                .ForMember(dest => dest.SearchEnd, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.SearchEnd))))
                .ForMember(dest => dest.SearchStart, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.SearchStart))))
                .ForMember(dest => dest.SearchStrategy, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.SearchStrategy))))
                .ForMember(dest => dest.SelectionCriteria, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.SelectionCriteria))))
                .ForMember(dest => dest.Settings, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.Settings))))
                .ForMember(dest => dest.Stats, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.Stats))))
                .ForMember(dest => dest.StatsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.StatsCount))))
                .ForMember(dest => dest.StudyDesigns, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.StudyDesigns))))
                .ForMember(dest => dest.StudyDesignsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.StudyDesignsCount))))
                .ForMember(dest => dest.Type, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.Type))))
                .ForMember(dest => dest.TypeId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.TypeId))))
                .ForMember(dest => dest.Users, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.Users))))
                .ForMember(dest => dest.UsersCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DocumentSet>(c, nameof(DocEntityDocumentSet.UsersCount))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<DocumentSet,DocEntityDocumentSet>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}