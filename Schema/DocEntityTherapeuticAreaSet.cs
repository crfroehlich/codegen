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
    [TableMapping(DocConstantModelName.THERAPEUTICAREASET)]
    public partial class DocEntityTherapeuticAreaSet : DocEntityDocumentSet
    {
        private const string THERAPEUTICAREASET_CACHE = "TherapeuticAreaSetCache";
        public const string TABLE_NAME = DocConstantModelName.THERAPEUTICAREASET;
        
        #region Constructor
        public DocEntityTherapeuticAreaSet(Session session) : base(session) {}

        public DocEntityTherapeuticAreaSet() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        protected override List<string> _select => __vf ?? (__vf = DocWebSession.GetTypeSelect(new TherapeuticAreaSet()));

        #region Static Members
        public static DocEntityTherapeuticAreaSet Get(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? Get(reference.Id) : null;
        }

        public static DocEntityTherapeuticAreaSet Get(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityTherapeuticAreaSet>.GetFromCache(primaryKey, THERAPEUTICAREASET_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityTherapeuticAreaSet>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityTherapeuticAreaSet>.UpdateCache(ret.Id, ret, THERAPEUTICAREASET_CACHE);
                    DocEntityThreadCache<DocEntityTherapeuticAreaSet>.UpdateCache(ret.Hash, ret, THERAPEUTICAREASET_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityTherapeuticAreaSet Get(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityTherapeuticAreaSet>.GetFromCache(hash, THERAPEUTICAREASET_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityTherapeuticAreaSet>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityTherapeuticAreaSet>.UpdateCache(ret.Id, ret, THERAPEUTICAREASET_CACHE);
                    DocEntityThreadCache<DocEntityTherapeuticAreaSet>.UpdateCache(ret.Hash, ret, THERAPEUTICAREASET_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties

        #endregion Properties

        #region Overrides of DocEntity

        public override DocConstantModelName TableName => TABLE_NAME;

        public const string CACHE_KEY_PREFIX = "FindTherapeuticAreaSets";

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
                throw new HttpError(HttpStatusCode.Conflict, $"TherapeuticAreaSet requires: {ValidationMessage.Message}.");
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



                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Converters

        public TherapeuticAreaSet ToDto() => Mapper.Map<DocEntityTherapeuticAreaSet, TherapeuticAreaSet>(this);

        public static explicit operator TherapeuticAreaSet(DocEntityTherapeuticAreaSet en) => en?.ToDto();
        public static explicit operator DocumentSet(DocEntityTherapeuticAreaSet en) => (DocumentSet) en?.ToDto();
        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }
}
