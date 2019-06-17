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
    [TableMapping(DocConstantModelName.MEANVARIANCEVALUE)]
    public partial class DocEntityMeanVarianceValue : DocEntityBase
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private const string MEANVARIANCEVALUE_CACHE = "MeanVarianceValueCache";
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public  const ModelNameEnm CLASS_NAME = ModelNameEnm.MEANVARIANCEVALUE;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocEntityMeanVarianceValue(Session session) : base(session) {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocEntityMeanVarianceValue() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        protected override List<string> _select => __vf ?? (__vf = DocWebSession.GetTypeSelect(new MeanVarianceValue()));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static DocEntityMeanVarianceValue Get(Reference reference) => (true == (reference?.Id > 0)) ? Get(reference.Id) : null;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static DocEntityMeanVarianceValue Get(int? primaryKey, bool noCache, DocQuery query)
        {
            if(!(primaryKey > 0)) return null;
            return query.SelectAll<DocEntityMeanVarianceValue>().FirstOrDefault(e => e.Id == primaryKey.Value);
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public new static DocEntityMeanVarianceValue Get(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityMeanVarianceValue>.GetFromCache(primaryKey, MEANVARIANCEVALUE_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityMeanVarianceValue>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityMeanVarianceValue>.UpdateCache(ret.Id, ret, MEANVARIANCEVALUE_CACHE);
                    DocEntityThreadCache<DocEntityMeanVarianceValue>.UpdateCache(ret.Hash, ret, MEANVARIANCEVALUE_CACHE);
                }
            }
            return ret;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static DocEntityMeanVarianceValue Get(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityMeanVarianceValue>.GetFromCache(hash, MEANVARIANCEVALUE_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityMeanVarianceValue>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityMeanVarianceValue>.UpdateCache(ret.Id, ret, MEANVARIANCEVALUE_CACHE);
                    DocEntityThreadCache<DocEntityMeanVarianceValue>.UpdateCache(ret.Hash, ret, MEANVARIANCEVALUE_CACHE);
                }
            }
            return ret;
        }

        [Field]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocStructureUnits MeanVariance { get; set; }


        [Field]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocStructureUnitsRange MeanVarianceRange { get; set; }


        [Field(Nullable = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocEntityLookupTable MeanVarianceType { get; set; }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? MeanVarianceTypeId { get { return MeanVarianceType?.Id; } private set { var noid = value; } }


        [Field(Nullable = false, DefaultValue = 0)]
        public int Order { get; set; }


        [Field]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocEntitySet<DocEntityMeanVariances> Owners { get; private set; }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> OwnersIds => Owners.Select(e => e.Id).ToList();
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? OwnersCount { get { return Owners.Count(); } private set { var noid = value; } }



        [Field]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override string Gestalt { get; set; }

        [Field(DefaultValue = 0), Version(VersionMode.Manual)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override int VersionNo { get; set; }

        [Field]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override DateTime? Created { get; set; }

        [Field]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override DateTime? Updated { get; set; }

        [Field(DefaultValue = false), FieldMapping(nameof(Locked))]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override bool Locked { get; set; }

        [Field(DefaultValue = false), FieldMapping(nameof(Archived))]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override bool Archived { get; set; }

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override ModelNameEnm ClassName => CLASS_NAME;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override DocConstantModelName TableName => CLASS_NAME.ToEnumString();
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public const string CACHE_KEY_PREFIX = "FindMeanVarianceValues";

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
                throw new HttpError(HttpStatusCode.Conflict, $"MeanVarianceValue requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();
            _validated = true;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override IDocEntity SaveChanges(bool ignoreCache, DocConstantPermission permission)
        {

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

        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocValidationMessage ValidationMessage
        {
            get
            {
                var isValid = true;
                var message = string.Empty;

                if(DocTools.IsNullOrEmpty(MeanVarianceType))
                {
                    isValid = false;
                    message += " MeanVarianceType is a required property.";
                }
                else
                {
                    if(MeanVarianceType.Enum?.Name != "MeanVarianceType")
                    {
                        isValid = false;
                        message += " MeanVarianceType is a " + MeanVarianceType.Enum.Name + ", but must be a MeanVarianceType.";
                    }
                }
                if(DocTools.IsNullOrEmpty(Order))
                {
                    isValid = false;
                    message += " Order is a required property.";
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public MeanVarianceValue ToDto() => Mapper.Map<DocEntityMeanVarianceValue, MeanVarianceValue>(this);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static explicit operator MeanVarianceValue(DocEntityMeanVarianceValue en) => en?.ToDto();

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override IDto ToIDto() => ToDto();
    }
}
