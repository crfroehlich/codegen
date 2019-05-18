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
    [TableMapping(DocConstantModelName.UNITVALUE)]
    public partial class DocEntityUnitValue : DocEntityBase
    {
        private const string UNITVALUE_CACHE = "UnitValueCache";
        public const ModelNameEnm CLASS_NAME = ModelNameEnm.UNITVALUE;
        
        #region Constructor
        public DocEntityUnitValue(Session session) : base(session) {}

        public DocEntityUnitValue() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        protected override List<string> _select => __vf ?? (__vf = DocWebSession.GetTypeSelect(new UnitValue()));

        #region Static Members
        public static DocEntityUnitValue Get(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? Get(reference.Id) : null;
        }

        public static DocEntityUnitValue Get(int? primaryKey)
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
        #endregion Static Members

        #region Properties
        [Field]
        public DocEntityLookupTable EqualityOperator { get; set; }
        public int? EqualityOperatorId { get { return EqualityOperator?.Id; } private set { var noid = value; } }


        [Field(Nullable = false, DefaultValue = 1)]
        public int Multiplier { get; set; }


        [Field(Precision = 38, Scale = 6)]
        public decimal? Number { get; set; }


        [Field(Nullable = false, DefaultValue = 1)]
        public int Order { get; set; }


        [Field]
        public DocEntitySet<DocEntityUnits> Owners { get; private set; }


        public int? OwnersCount { get { return Owners.Count(); } private set { var noid = value; } }


        [Field(Nullable = false)]
        public DocEntityUnitOfMeasure Unit { get; set; }
        public int? UnitId { get { return Unit?.Id; } private set { var noid = value; } }


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

        public const string CACHE_KEY_PREFIX = "FindUnitValues";

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
                throw new HttpError(HttpStatusCode.Conflict, $"UnitValue requires: {ValidationMessage.Message}.");
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
        #endregion Validation

        #region Converters

        public UnitValue ToDto() => Mapper.Map<DocEntityUnitValue, UnitValue>(this);

        public static explicit operator UnitValue(DocEntityUnitValue en) => en?.ToDto();
        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }
}
