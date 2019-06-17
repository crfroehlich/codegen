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
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private const string DATASET_CACHE = "DataSetCache";
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public new const ModelNameEnm CLASS_NAME = ModelNameEnm.DATASET;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocEntityDataSet(Session session) : base(session) {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocEntityDataSet() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        protected override List<string> _select => __vf ?? (__vf = DocWebSession.GetTypeSelect(new DataSet()));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public new static DocEntityDataSet Get(Reference reference) => (true == (reference?.Id > 0)) ? Get(reference.Id) : null;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public new static DocEntityDataSet Get(int? primaryKey, bool noCache, DocQuery query)
        {
            if(!(primaryKey > 0)) return null;
            return query.SelectAll<DocEntityDataSet>().FirstOrDefault(e => e.Id == primaryKey.Value);
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public new static DocEntityDataSet Get(int? primaryKey)
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
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public new static DocEntityDataSet Get(Guid hash)
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

        [Field(Length = int.MaxValue)]
        public string AdditionalCriteria { get; set; }

        [Field]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocEntitySet<DocEntityTag> Characteristics { get; private set; }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> CharacteristicsIds => Characteristics.Select(e => e.Id).ToList();
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? CharacteristicsCount { get { return Characteristics.Count(); } private set { var noid = value; } }

        [Field]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocEntitySet<DocEntityTag> Comparators { get; private set; }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> ComparatorsIds => Comparators.Select(e => e.Id).ToList();
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
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
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocEntitySet<DocEntityImportData> Imports { get; private set; }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> ImportsIds => Imports.Select(e => e.Id).ToList();
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? ImportsCount { get { return Imports.Count(); } private set { var noid = value; } }

        [Field(Length = int.MaxValue)]
        public string Indications { get; set; }

        [Field]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocEntitySet<DocEntityTag> Interventions { get; private set; }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> InterventionsIds => Interventions.Select(e => e.Id).ToList();
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
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
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocEntitySet<DocEntityTag> Outcomes { get; private set; }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> OutcomesIds => Outcomes.Select(e => e.Id).ToList();
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? OutcomesCount { get { return Outcomes.Count(); } private set { var noid = value; } }

        [Field(Length = int.MaxValue)]
        public string Participants { get; set; }

        [Field]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocEntityWorkflow PrismaWorkflow { get; set; }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? PrismaWorkflowId { get { return PrismaWorkflow?.Id; } private set { var noid = value; } }

        [Field]
        [Association(PairTo = nameof(DocEntityProject.Dataset), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocEntitySet<DocEntityProject> Projects { get; private set; }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> ProjectsIds => Projects.Select(e => e.Id).ToList();
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? ProjectsCount { get { return Projects.Count(); } private set { var noid = value; } }

        [Field(Nullable = false, DefaultValue = false)]
        public bool ShowEtw { get; set; }

        [Field(Nullable = false, DefaultValue = false)]
        public bool ShowPublicationType { get; set; }

        [Field]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocEntitySet<DocEntityStudyDesign> StudyDesigns { get; private set; }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> StudyDesignsIds => StudyDesigns.Select(e => e.Id).ToList();
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? StudyDesignsCount { get { return StudyDesigns.Count(); } private set { var noid = value; } }



        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override ModelNameEnm ClassName => CLASS_NAME;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override DocConstantModelName TableName => CLASS_NAME.ToEnumString();
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public new const string CACHE_KEY_PREFIX = "FindDataSets";

        /// <summary>
        ///    Called when entity is about to be removed.
        /// </summary>
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        protected override void OnRemoving()
        {
            base.OnRemoving();

            FlushCache();
        }

        /// <summary>
        ///    Called when entity should be validated. Override this method to perform custom object validation.
        /// </summary>
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        protected override void OnValidate()
        {
            if (false == ValidationMessage.IsValid)
            {
                throw new HttpError(HttpStatusCode.Conflict, $"DataSet requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();
            _validated = true;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override IDocEntity SaveChanges(bool ignoreCache, DocConstantPermission permission)
        {
            OriginalDatabase = OriginalDatabase?.TrimAndPruneSpaces();
            return base.SaveChanges(ignoreCache, permission);
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override IDocEntity SaveChanges(bool ignoreCache) => SaveChanges(ignoreCache, DocConstantPermission.EDIT);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override IDocEntity SaveChanges(DocConstantPermission permission) => SaveChanges(false, DocConstantPermission.EDIT);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override IDocEntity SaveChanges() => SaveChanges(DocConstantPermission.EDIT);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override void FlushCache()
        {
            base.FlushCache();
            DocCacheClient.RemoveById(Id);
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public new DocValidationMessage ValidationMessage
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
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public new DataSet ToDto() => Mapper.Map<DocEntityDataSet, DataSet>(this);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static explicit operator DataSet(DocEntityDataSet en) => en?.ToDto();

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static explicit operator DocumentSet(DocEntityDataSet en) => (DocumentSet) en?.ToDto();

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override IDto ToIDto() => ToDto();
    }
}
