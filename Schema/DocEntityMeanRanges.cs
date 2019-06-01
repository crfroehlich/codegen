
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
    [TableMapping(DocConstantModelName.MEANRANGES)]
    public partial class DocEntityMeanRanges : DocEntityBase
    {
        private const string MEANRANGES_CACHE = "MeanRangesCache";
        public const ModelNameEnm CLASS_NAME = ModelNameEnm.MEANRANGES;
        
        #region Constructor
        public DocEntityMeanRanges(Session session) : base(session) {}

        public DocEntityMeanRanges() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        protected override List<string> _select => __vf ?? (__vf = DocWebSession.GetTypeSelect(new MeanRanges()));

        #region Static Members
        public static DocEntityMeanRanges Get(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? Get(reference.Id) : null;
        }

        public static DocEntityMeanRanges Get(int? primaryKey, bool noCache, DocQuery query)
        {
            if(!(primaryKey > 0)) return null;
            return query.SelectAll<DocEntityMeanRanges>().FirstOrDefault(e => e.Id == primaryKey.Value);
        }

        public static DocEntityMeanRanges Get(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityMeanRanges>.GetFromCache(primaryKey, MEANRANGES_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityMeanRanges>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityMeanRanges>.UpdateCache(ret.Id, ret, MEANRANGES_CACHE);
                    DocEntityThreadCache<DocEntityMeanRanges>.UpdateCache(ret.Hash, ret, MEANRANGES_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityMeanRanges Get(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityMeanRanges>.GetFromCache(hash, MEANRANGES_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityMeanRanges>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityMeanRanges>.UpdateCache(ret.Id, ret, MEANRANGES_CACHE);
                    DocEntityThreadCache<DocEntityMeanRanges>.UpdateCache(ret.Hash, ret, MEANRANGES_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field]
        [Association(PairTo = nameof(DocEntityMeanRangeValue.Owners), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityMeanRangeValue> Ranges { get; private set; }


        public List<int> RangesIds => Ranges.Select(e => e.Id).ToList();


        public int? RangesCount { get { return Ranges.Count(); } private set { var noid = value; } }



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

        public const string CACHE_KEY_PREFIX = "FindMeanRangess";

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
                throw new HttpError(HttpStatusCode.Conflict, $"MeanRanges requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();
            _validated = true;
        }

        public override IDocEntity SaveChanges(bool ignoreCache, DocConstantPermission permission)
        {

            return base.SaveChanges(ignoreCache, permission);
        }

        public override IDocEntity SaveChanges(bool ignoreCache) => SaveChanges(ignoreCache, DocConstantPermission.EDIT);
        public override IDocEntity SaveChanges(DocConstantPermission permission) => SaveChanges(false, DocConstantPermission.EDIT);
        public override IDocEntity SaveChanges() => SaveChanges(DocConstantPermission.EDIT);

        public override void FlushCache()
        {
            base.FlushCache();

        }
        #endregion Entity overrides

        #region Validation
        public DocValidationMessage ValidationMessage
        {
            get
            {
                var isValid = true;
                var message = string.Empty;



                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Converters

        public MeanRanges ToDto() => Mapper.Map<DocEntityMeanRanges, MeanRanges>(this);

        public static explicit operator MeanRanges(DocEntityMeanRanges en) => en?.ToDto();

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }
}
