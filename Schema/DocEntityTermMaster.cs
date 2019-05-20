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
    [TableMapping(DocConstantModelName.TERMMASTER)]
    public partial class DocEntityTermMaster : DocEntityBase
    {
        private const string TERMMASTER_CACHE = "TermMasterCache";
        public const ModelNameEnm CLASS_NAME = ModelNameEnm.TERMMASTER;
        
        #region Constructor
        public DocEntityTermMaster(Session session) : base(session) {}

        public DocEntityTermMaster() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        protected override List<string> _select => __vf ?? (__vf = DocWebSession.GetTypeSelect(new TermMaster()));

        #region Static Members
        public static DocEntityTermMaster Get(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? Get(reference.Id) : null;
        }

        public static DocEntityTermMaster Get(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityTermMaster>.GetFromCache(primaryKey, TERMMASTER_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityTermMaster>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityTermMaster>.UpdateCache(ret.Id, ret, TERMMASTER_CACHE);
                    DocEntityThreadCache<DocEntityTermMaster>.UpdateCache(ret.Hash, ret, TERMMASTER_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityTermMaster Get(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityTermMaster>.GetFromCache(hash, TERMMASTER_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityTermMaster>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityTermMaster>.UpdateCache(ret.Id, ret, TERMMASTER_CACHE);
                    DocEntityThreadCache<DocEntityTermMaster>.UpdateCache(ret.Hash, ret, TERMMASTER_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field]
        public string BioPortal { get; set; }


        [Field]
        public DocEntitySet<DocEntityTermCategory> Categories { get; private set; }


        public int? CategoriesCount { get { return Categories.Count(); } private set { var noid = value; } }


        [Field]
        public string CUI { get; set; }


        [Field(Nullable = false)]
        public DocEntityLookupTableEnum Enum { get; set; }
        public int? EnumId { get { return Enum?.Id; } private set { var noid = value; } }


        [Field]
        public string MedDRA { get; set; }


        [Field(Nullable = false, Length = 800)]
        public string Name { get; set; }


        [Field]
        public string RxNorm { get; set; }


        [Field]
        public string SNOWMED { get; set; }


        [Field]
        [Association(PairTo = nameof(DocEntityTermSynonym.Master), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityTermSynonym> Synonyms { get; private set; }


        public int? SynonymsCount { get { return Synonyms.Count(); } private set { var noid = value; } }


        [Field]
        public string TUI { get; set; }


        [Field]
        public string URI { get; set; }


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

        public override ModelNameEnm ClassName => CLASS_NAME;

        public override DocConstantModelName TableName => CLASS_NAME.ToEnumString();

        public const string CACHE_KEY_PREFIX = "FindTermMasters";

        #endregion Overrides of DocEntity

        #region Entity overrides
        /// <summary>
        ///    Called when entity is about to be removed.
        /// </summary>
        protected override void OnRemoving()
        {
            base.OnRemoving();
            try
            {
                Synonyms.Clear(); //foreach thing in Synonyms en.Remove();
            }
            catch(Exception ex)
            {
                throw new DocException("Failed to delete TermMaster in Synonyms delete", ex);
            }
            FlushCache();
        }

        /// <summary>
        ///    Called when entity should be validated. Override this method to perform custom object validation.
        /// </summary>
        protected override void OnValidate()
        {
            if (false == ValidationMessage.IsValid)
            {
                throw new HttpError(HttpStatusCode.Conflict, $"TermMaster requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();
            _validated = true;
        }

        public override IDocEntity SaveChanges(bool ignoreCache, DocConstantPermission permission)
        {
            BioPortal = BioPortal?.TrimAndPruneSpaces();
            CUI = CUI?.TrimAndPruneSpaces();
            MedDRA = MedDRA?.TrimAndPruneSpaces();
            Name = Name?.TrimAndPruneSpaces();
            RxNorm = RxNorm?.TrimAndPruneSpaces();
            SNOWMED = SNOWMED?.TrimAndPruneSpaces();
            TUI = TUI?.TrimAndPruneSpaces();
            URI = URI?.TrimAndPruneSpaces();
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

                if(DocTools.IsNullOrEmpty(Enum))
                {
                    isValid = false;
                    message += " Enum is a required property.";
                }
                if(DocTools.IsNullOrEmpty(Name))
                {
                    isValid = false;
                    message += " Name is a required property.";
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Converters

        public TermMaster ToDto() => Mapper.Map<DocEntityTermMaster, TermMaster>(this);

        public static explicit operator TermMaster(DocEntityTermMaster en) => en?.ToDto();
        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }
}
