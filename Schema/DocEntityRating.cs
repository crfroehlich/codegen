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
    [TableMapping(DocConstantModelName.RATING)]
    public partial class DocEntityRating : DocEntityTask
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private const string RATING_CACHE = "RatingCache";
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public new const ModelNameEnm CLASS_NAME = ModelNameEnm.RATING;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocEntityRating(Session session) : base(session) {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocEntityRating() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        protected override List<string> _select => __vf ?? (__vf = DocWebSession.GetTypeSelect(new Rating()));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public new static DocEntityRating Get(Reference reference) => (true == (reference?.Id > 0)) ? Get(reference.Id) : null;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public new static DocEntityRating Get(int? primaryKey, bool noCache, DocQuery query)
        {
            if(!(primaryKey > 0)) return null;
            return query.SelectAll<DocEntityRating>().FirstOrDefault(e => e.Id == primaryKey.Value);
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public new static DocEntityRating Get(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityRating>.GetFromCache(primaryKey, RATING_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityRating>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityRating>.UpdateCache(ret.Id, ret, RATING_CACHE);
                    DocEntityThreadCache<DocEntityRating>.UpdateCache(ret.Hash, ret, RATING_CACHE);
                }
            }
            return ret;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public new static DocEntityRating Get(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityRating>.GetFromCache(hash, RATING_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityRating>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityRating>.UpdateCache(ret.Id, ret, RATING_CACHE);
                    DocEntityThreadCache<DocEntityRating>.UpdateCache(ret.Hash, ret, RATING_CACHE);
                }
            }
            return ret;
        }

        [Field]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocEntityDocument Document { get; set; }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? DocumentId { get { return Document?.Id; } private set { var noid = value; } }


        [Field(DefaultValue = RatingEnm.NOT_RATED)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public RatingEnm Rating { get; set; }


        [Field]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public ReasonRejectedEnm? ReasonRejected { get; set; }



        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override ModelNameEnm ClassName => CLASS_NAME;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override DocConstantModelName TableName => CLASS_NAME.ToEnumString();
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public new const string CACHE_KEY_PREFIX = "FindRatings";

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
                throw new HttpError(HttpStatusCode.Conflict, $"Rating requires: {ValidationMessage.Message}.");
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
        public new DocValidationMessage ValidationMessage
        {
            get
            {
                var isValid = true;
                var message = string.Empty;



                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public new Rating ToDto() => Mapper.Map<DocEntityRating, Rating>(this);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static explicit operator Rating(DocEntityRating en) => en?.ToDto();

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static explicit operator Task(DocEntityRating en) => (Task) en?.ToDto();

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override IDto ToIDto() => ToDto();
    }
}
