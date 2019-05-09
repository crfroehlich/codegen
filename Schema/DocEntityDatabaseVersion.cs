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
    [TableMapping(DocConstantModelName.DATABASEVERSION)]
    public partial class DocEntityDatabaseVersion : DocEntityBase
    {
        private const string DATABASEVERSION_CACHE = "DatabaseVersionCache";
        public const string TABLE_NAME = DocConstantModelName.DATABASEVERSION;
        
        #region Constructor
        public DocEntityDatabaseVersion(Session session) : base(session) {}

        public DocEntityDatabaseVersion() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        protected override List<string> _select => __vf ?? (__vf = DocWebSession.GetTypeSelect(new DatabaseVersion()));

        #region Static Members
        public static DocEntityDatabaseVersion Get(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? Get(reference.Id) : null;
        }

        public static DocEntityDatabaseVersion Get(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityDatabaseVersion>.GetFromCache(primaryKey, DATABASEVERSION_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityDatabaseVersion>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityDatabaseVersion>.UpdateCache(ret.Id, ret, DATABASEVERSION_CACHE);
                    DocEntityThreadCache<DocEntityDatabaseVersion>.UpdateCache(ret.Hash, ret, DATABASEVERSION_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityDatabaseVersion Get(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityDatabaseVersion>.GetFromCache(hash, DATABASEVERSION_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityDatabaseVersion>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityDatabaseVersion>.UpdateCache(ret.Id, ret, DATABASEVERSION_CACHE);
                    DocEntityThreadCache<DocEntityDatabaseVersion>.UpdateCache(ret.Hash, ret, DATABASEVERSION_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field(Length = int.MaxValue)]
        public string DatabaseState { get; set; }


        [Field]
        public string Description { get; set; }


        [Field]
        public string Release { get; set; }


        [Field(Nullable = false)]
        public string VersionName { get; set; }


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

        public const string CACHE_KEY_PREFIX = "FindDatabaseVersions";

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
                throw new HttpError(HttpStatusCode.Conflict, $"DatabaseVersion requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();
            _validated = true;
        }

        public override IDocEntity SaveChanges(bool ignoreCache, DocConstantPermission permission)
        {
            Description = Description?.TrimAndPruneSpaces();
            Release = Release?.TrimAndPruneSpaces();
            VersionName = VersionName?.TrimAndPruneSpaces();
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

                if(DocTools.IsNullOrEmpty(VersionName))
                {
                    isValid = false;
                    message += " VersionName is a required property.";
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Converters

        public DatabaseVersion ToDto() => Mapper.Map<DocEntityDatabaseVersion, DatabaseVersion>(this);

        public static explicit operator DatabaseVersion(DocEntityDatabaseVersion en) => en?.ToDto();
        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }
}
