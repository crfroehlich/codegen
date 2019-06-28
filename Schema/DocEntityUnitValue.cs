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
    [TableMapping(DocConstantModelName.UNITVALUE)]
    public partial class DocEntityUnitValue : DocEntityBase
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private const string UNITVALUE_CACHE = "UnitValueCache";
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public  const ModelNameEnm CLASS_NAME = ModelNameEnm.UNITVALUE;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocEntityUnitValue(Session session) : base(session) {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocEntityUnitValue() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        protected override List<string> _select => __vf ?? (__vf = DocWebSession.GetTypeSelect(new UnitValue()));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public new static DocEntityUnitValue Get(Reference reference) => (true == (reference?.Id > 0)) ? Get(reference.Id) : null;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public new static DocEntityUnitValue Get(int? primaryKey, bool noCache, DocQuery query)
        {
            if(!(primaryKey > 0)) return null;
            return query.SelectAll<DocEntityUnitValue>().FirstOrDefault(e => e.Id == primaryKey.Value);
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public new static DocEntityUnitValue Get(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityUnitValue>.GetFromCache(primaryKey, UNITVALUE_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityUnitValue>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityUnitValue>.UpdateCache(ret.Id, ret, UNITVALUE_CACHE);
                    DocEntityThreadCache<DocEntityUnitValue>.UpdateCache(ret.Hash, ret, UNITVALUE_CACHE);
                }
            }
            return ret;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static DocEntityUnitValue Get(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityUnitValue>.GetFromCache(hash, UNITVALUE_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityUnitValue>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityUnitValue>.UpdateCache(ret.Id, ret, UNITVALUE_CACHE);
                    DocEntityThreadCache<DocEntityUnitValue>.UpdateCache(ret.Hash, ret, UNITVALUE_CACHE);
                }
            }
            return ret;
        }

        [Field]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocEntityLookupTable EqualityOperator { get; set; }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? EqualityOperatorId { get { return EqualityOperator?.Id; } private set { var noid = value; } }


        [Field(Nullable = false, DefaultValue = 1)]
        public int Multiplier { get; set; }


        [Field(Precision = 38, Scale = 6)]
        public decimal? Number { get; set; }


        [Field(Nullable = false, DefaultValue = 1)]
        public int Order { get; set; }


        [Field]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocEntitySet<DocEntityUnits> Owners { get; private set; }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> OwnersIds => Owners.Select(e => e.Id).ToList();
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? OwnersCount { get { return Owners.Count(); } private set { var noid = value; } }


        [Field(Nullable = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocEntityUnitOfMeasure Unit { get; set; }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? UnitId { get { return Unit?.Id; } private set { var noid = value; } }



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
        public const string CACHE_KEY_PREFIX = "FindUnitValues";

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
                throw new HttpError(HttpStatusCode.Conflict, $"UnitValue requires: {ValidationMessage.Message}.");
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

                if(null != EqualityOperator && EqualityOperator?.Enum?.Name != "EqualityOperator")
                {
                    isValid = false;
                    message += " EqualityOperator is a " + EqualityOperator?.Enum?.Name + ", but must be a EqualityOperator.";
                }
                if(DocTools.IsNullOrEmpty(Multiplier))
                {
                    isValid = false;
                    message += " Multiplier is a required property.";
                }
                if(DocTools.IsNullOrEmpty(Order))
                {
                    isValid = false;
                    message += " Order is a required property.";
                }
                if(DocTools.IsNullOrEmpty(Unit))
                {
                    isValid = false;
                    message += " Unit is a required property.";
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public UnitValue ToDto() => Mapper.Map<DocEntityUnitValue, UnitValue>(this);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static explicit operator UnitValue(DocEntityUnitValue en) => en?.ToDto();

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override IDto ToIDto() => ToDto();
    }
}
