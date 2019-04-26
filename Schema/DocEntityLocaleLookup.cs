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
    [TableMapping(DocConstantModelName.LOCALELOOKUP)]
    public partial class DocEntityLocaleLookup : DocEntityBase
    {
        private const string LOCALELOOKUP_CACHE = "LocaleLookupCache";
        public const string TABLE_NAME = DocConstantModelName.LOCALELOOKUP;
        
        #region Constructor
        public DocEntityLocaleLookup(Session session) : base(session) {}

        public DocEntityLocaleLookup() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        protected override List<string> _visibleFields => __vf ?? (__vf = DocWebSession.GetTypeVisibleFields(new LocaleLookup()));

        #region Static Members
        public static DocEntityLocaleLookup GetLocaleLookup(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetLocaleLookup(reference.Id) : null;
        }

        public static DocEntityLocaleLookup GetLocaleLookup(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityLocaleLookup>.GetFromCache(primaryKey, LOCALELOOKUP_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityLocaleLookup>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityLocaleLookup>.UpdateCache(ret.Id, ret, LOCALELOOKUP_CACHE);
                    DocEntityThreadCache<DocEntityLocaleLookup>.UpdateCache(ret.Hash, ret, LOCALELOOKUP_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityLocaleLookup GetLocaleLookup(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityLocaleLookup>.GetFromCache(hash, LOCALELOOKUP_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityLocaleLookup>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityLocaleLookup>.UpdateCache(ret.Id, ret, LOCALELOOKUP_CACHE);
                    DocEntityThreadCache<DocEntityLocaleLookup>.UpdateCache(ret.Hash, ret, LOCALELOOKUP_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field(Length = int.MaxValue)]
        public string Data { get; set; }


        [Field(Nullable = false)]
        public string IpAddress { get; set; }


        [Field(Nullable = false)]
        public DocEntityLocale Locale { get; set; }
        public int? LocaleId { get { return Locale?.Id; } private set { var noid = value; } }


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

        public override DocConstantModelName TableName => TABLE_NAME;

        public const string CACHE_KEY_PREFIX = "FindLocaleLookups";

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
                throw new HttpError(HttpStatusCode.Conflict, $"LocaleLookup requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();
            _validated = true;
        }

        public override IDocEntity SaveChanges(bool ignoreCache, DocConstantPermission permission)
        {
            IpAddress = IpAddress?.TrimAndPruneSpaces();
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

                if(DocTools.IsNullOrEmpty(IpAddress))
                {
                    isValid = false;
                    message += " IpAddress is a required property.";
                }
                if(DocTools.IsNullOrEmpty(Locale))
                {
                    isValid = false;
                    message += " Locale is a required property.";
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Converters

        public LocaleLookup ToDto() => Mapper.Map<DocEntityLocaleLookup, LocaleLookup>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }
}
