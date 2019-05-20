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
    [TableMapping(DocConstantModelName.LOOKUPTABLEBINDING)]
    public partial class DocEntityLookupTableBinding : DocEntityBase
    {
        private const string LOOKUPTABLEBINDING_CACHE = "LookupTableBindingCache";
        public const ModelNameEnm CLASS_NAME = ModelNameEnm.LOOKUPTABLEBINDING;
        
        #region Constructor
        public DocEntityLookupTableBinding(Session session) : base(session) {}

        public DocEntityLookupTableBinding() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        protected override List<string> _select => __vf ?? (__vf = DocWebSession.GetTypeSelect(new LookupTableBinding()));

        #region Static Members
        public static DocEntityLookupTableBinding Get(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? Get(reference.Id) : null;
        }

        public static DocEntityLookupTableBinding Get(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityLookupTableBinding>.GetFromCache(primaryKey, LOOKUPTABLEBINDING_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityLookupTableBinding>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityLookupTableBinding>.UpdateCache(ret.Id, ret, LOOKUPTABLEBINDING_CACHE);
                    DocEntityThreadCache<DocEntityLookupTableBinding>.UpdateCache(ret.Hash, ret, LOOKUPTABLEBINDING_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityLookupTableBinding Get(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityLookupTableBinding>.GetFromCache(hash, LOOKUPTABLEBINDING_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityLookupTableBinding>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityLookupTableBinding>.UpdateCache(ret.Id, ret, LOOKUPTABLEBINDING_CACHE);
                    DocEntityThreadCache<DocEntityLookupTableBinding>.UpdateCache(ret.Hash, ret, LOOKUPTABLEBINDING_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field(DefaultValue = "{}", Length = int.MaxValue)]
        public string Binding { get; set; }


        [Field]
        public string BoundName { get; set; }


        [Field(Nullable = false)]
        public DocEntityLookupTable LookupTable { get; set; }
        public int? LookupTableId { get { return LookupTable?.Id; } private set { var noid = value; } }


        [Field(Nullable = false)]
        public DocEntityScope Scope { get; set; }
        public int? ScopeId { get { return Scope?.Id; } private set { var noid = value; } }


        [Field]
        [Association(PairTo = nameof(DocEntityTermSynonym.Bindings), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityTermSynonym> Synonyms { get; private set; }


        public int? SynonymsCount { get { return Synonyms.Count(); } private set { var noid = value; } }


        [Field]
        [Association(PairTo = nameof(DocEntityWorkflow.Bindings), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityWorkflow> Workflows { get; private set; }


        public int? WorkflowsCount { get { return Workflows.Count(); } private set { var noid = value; } }


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

        public const string CACHE_KEY_PREFIX = "FindLookupTableBindings";

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
                throw new HttpError(HttpStatusCode.Conflict, $"LookupTableBinding requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();
            _validated = true;
        }

        public override IDocEntity SaveChanges(bool ignoreCache, DocConstantPermission permission)
        {
            BoundName = BoundName?.TrimAndPruneSpaces();
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

                if(DocTools.IsNullOrEmpty(LookupTable))
                {
                    isValid = false;
                    message += " LookupTable is a required property.";
                }
                else
                {
                    if(DocTools.IsNullOrEmpty(LookupTable.Enum?.Name))
                    {
                        isValid = false;
                        message += " LookupTable is a " + LookupTable.Enum?.Name + ", but must be a .";
                    }
                }
                if(DocTools.IsNullOrEmpty(Scope))
                {
                    isValid = false;
                    message += " Scope is a required property.";
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Converters

        public LookupTableBinding ToDto() => Mapper.Map<DocEntityLookupTableBinding, LookupTableBinding>(this);

        public static explicit operator LookupTableBinding(DocEntityLookupTableBinding en) => en?.ToDto();
        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }
}
