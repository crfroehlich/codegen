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
using System.Net;

using AutoMapper;

using Services.Core;
using Services.Db;
using Services.Dto;
using Services.Dto.internals;
using Services.Enums;

using ServiceStack;

using Xtensive.Orm;
namespace Services.Schema
{
    [TableMapping(DocConstantModelName.DATASET)]
    public partial class DocEntityDataSet : DocEntityDocumentSet
    {
        private const string DATASET_CACHE = "DataSetCache";
        public const ModelNameEnm CLASS_NAME = ModelNameEnm.DATASET;
        
        #region Constructor
        public DocEntityDataSet(Session session) : base(session) {}

        public DocEntityDataSet() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        protected override List<string> _select => __vf ?? (__vf = DocWebSession.GetTypeSelect(new DataSet()));

        #region Static Members
        public static DocEntityDataSet Get(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? Get(reference.Id) : null;
        }

        public static DocEntityDataSet Get(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityDataSet>.GetFromCache(primaryKey, DATASET_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityDataSet>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityDataSet>.UpdateCache(ret.Id, ret, DATASET_CACHE);
                    DocEntityThreadCache<DocEntityDataSet>.UpdateCache(ret.Hash, ret, DATASET_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityDataSet Get(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityDataSet>.GetFromCache(hash, DATASET_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityDataSet>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityDataSet>.UpdateCache(ret.Id, ret, DATASET_CACHE);
                    DocEntityThreadCache<DocEntityDataSet>.UpdateCache(ret.Hash, ret, DATASET_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field(Length = int.MaxValue)]
        public string AdditionalCriteria { get; set; }


        [Field]
        public DocEntitySet<DocEntityTag> Characteristics { get; private set; }


        public List<int> CharacteristicsIds => Characteristics.Select(e => e.Id).ToList();


        public int? CharacteristicsCount { get { return Characteristics.Count(); } private set { var noid = value; } }


        [Field]
        public DocEntitySet<DocEntityTag> Comparators { get; private set; }


        public List<int> ComparatorsIds => Comparators.Select(e => e.Id).ToList();


        public int? ComparatorsCount { get { return Comparators.Count(); } private set { var noid = value; } }


        [Field(Length = int.MaxValue)]
        public string DataCollection { get; set; }


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
        [Association(PairTo = nameof(DocEntityImportData.DataSets), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityImportData> Imports { get; private set; }


        public List<int> ImportsIds => Imports.Select(e => e.Id).ToList();


        public int? ImportsCount { get { return Imports.Count(); } private set { var noid = value; } }


        [Field(Length = int.MaxValue)]
        public string Indications { get; set; }


        [Field]
        public DocEntitySet<DocEntityTag> Interventions { get; private set; }


        public List<int> InterventionsIds => Interventions.Select(e => e.Id).ToList();


        public int? InterventionsCount { get { return Interventions.Count(); } private set { var noid = value; } }


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


        [Field]
        public DocEntitySet<DocEntityTag> Outcomes { get; private set; }


        public List<int> OutcomesIds => Outcomes.Select(e => e.Id).ToList();


        public int? OutcomesCount { get { return Outcomes.Count(); } private set { var noid = value; } }


        [Field(Length = int.MaxValue)]
        public string Participants { get; set; }


        [Field]
        public DocEntityWorkflow PrismaWorkflow { get; set; }
        public int? PrismaWorkflowId { get { return PrismaWorkflow?.Id; } private set { var noid = value; } }


        [Field]
        [Association(PairTo = nameof(DocEntityProject.Dataset), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityProject> Projects { get; private set; }


        public List<int> ProjectsIds => Projects.Select(e => e.Id).ToList();


        public int? ProjectsCount { get { return Projects.Count(); } private set { var noid = value; } }


        [Field(Nullable = false, DefaultValue = false)]
        public bool ShowEtw { get; set; }


        [Field(Nullable = false, DefaultValue = false)]
        public bool ShowPublicationType { get; set; }


        [Field]
        public DocEntitySet<DocEntityStudyDesign> StudyDesigns { get; private set; }


        public List<int> StudyDesignsIds => StudyDesigns.Select(e => e.Id).ToList();


        public int? StudyDesignsCount { get { return StudyDesigns.Count(); } private set { var noid = value; } }


        #endregion Properties

        #region Overrides of DocEntity

        public override ModelNameEnm ClassName => CLASS_NAME;

        public override DocConstantModelName TableName => CLASS_NAME.ToEnumString();

        public const string CACHE_KEY_PREFIX = "FindDataSets";

        #endregion Overrides of DocEntity

        #region Entity overrides
        /// <summary>
        ///    Called when entity is about to be removed.
        /// </summary>
        protected override void OnRemoving()
        {
            base.OnRemoving();

            FlushCache();
        }

        /// <summary>
        ///    Called when entity should be validated. Override this method to perform custom object validation.
        /// </summary>
        protected override void OnValidate()
        {
            if (false == ValidationMessage.IsValid)
            {
                throw new HttpError(HttpStatusCode.Conflict, $"DataSet requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();
            _validated = true;
        }

        public override IDocEntity SaveChanges(bool ignoreCache, DocConstantPermission permission)
        {
            OriginalDatabase = OriginalDatabase?.TrimAndPruneSpaces();
            return base.SaveChanges(ignoreCache, permission);
        }

        public override IDocEntity SaveChanges(bool ignoreCache) => SaveChanges(ignoreCache, DocConstantPermission.EDIT);
        public override IDocEntity SaveChanges(DocConstantPermission permission) => SaveChanges(false, DocConstantPermission.EDIT);
        public override IDocEntity SaveChanges() => SaveChanges(DocConstantPermission.EDIT);

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

                if(DocTools.IsNullOrEmpty(ShowEtw))
                {
                    isValid = false;
                    message += " ShowEtw is a required property.";
                }
                if(DocTools.IsNullOrEmpty(ShowPublicationType))
                {
                    isValid = false;
                    message += " ShowPublicationType is a required property.";
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Converters

        public DataSet ToDto() => Mapper.Map<DocEntityDataSet, DataSet>(this);

        public static explicit operator DataSet(DocEntityDataSet en) => en?.ToDto();
        public static explicit operator DocumentSet(DocEntityDataSet en) => (DocumentSet) en?.ToDto();
        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }
}
