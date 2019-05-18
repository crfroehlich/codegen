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
    [TableMapping(DocConstantModelName.ADJUDICATEDRATING)]
    public partial class DocEntityAdjudicatedRating : DocEntityTask
    {
        private const string ADJUDICATEDRATING_CACHE = "AdjudicatedRatingCache";
        public const ModelNameEnm CLASS_NAME = ModelNameEnm.ADJUDICATEDRATING;
        
        #region Constructor
        public DocEntityAdjudicatedRating(Session session) : base(session) {}

        public DocEntityAdjudicatedRating() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        protected override List<string> _select => __vf ?? (__vf = DocWebSession.GetTypeSelect(new AdjudicatedRating()));

        #region Static Members
        public static DocEntityAdjudicatedRating Get(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? Get(reference.Id) : null;
        }

        public static DocEntityAdjudicatedRating Get(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityAdjudicatedRating>.GetFromCache(primaryKey, ADJUDICATEDRATING_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityAdjudicatedRating>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityAdjudicatedRating>.UpdateCache(ret.Id, ret, ADJUDICATEDRATING_CACHE);
                    DocEntityThreadCache<DocEntityAdjudicatedRating>.UpdateCache(ret.Hash, ret, ADJUDICATEDRATING_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityAdjudicatedRating Get(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityAdjudicatedRating>.GetFromCache(hash, ADJUDICATEDRATING_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityAdjudicatedRating>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityAdjudicatedRating>.UpdateCache(ret.Id, ret, ADJUDICATEDRATING_CACHE);
                    DocEntityThreadCache<DocEntityAdjudicatedRating>.UpdateCache(ret.Hash, ret, ADJUDICATEDRATING_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field]
        public DocEntityDocument Document { get; set; }
        public int? DocumentId { get { return Document?.Id; } private set { var noid = value; } }


        [Field(DefaultValue = RatingEnm.NOT_RATED)]
        public RatingEnm Rating { get; set; }


        [Field]
        public ReasonRejectedEnm? ReasonRejected { get; set; }


        #endregion Properties

        #region Overrides of DocEntity

        public override ModelNameEnm ClassName => CLASS_NAME;

        public override DocConstantModelName TableName => CLASS_NAME.ToEnumString();

        public const string CACHE_KEY_PREFIX = "FindAdjudicatedRatings";

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
                throw new HttpError(HttpStatusCode.Conflict, $"AdjudicatedRating requires: {ValidationMessage.Message}.");
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

        public AdjudicatedRating ToDto() => Mapper.Map<DocEntityAdjudicatedRating, AdjudicatedRating>(this);

        public static explicit operator AdjudicatedRating(DocEntityAdjudicatedRating en) => en?.ToDto();
        public static explicit operator Task(DocEntityAdjudicatedRating en) => (Task) en?.ToDto();
        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }
}
