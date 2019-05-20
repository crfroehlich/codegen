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
    [TableMapping(DocConstantModelName.APP)]
    public partial class DocEntityApp : DocEntityBase
    {
        private const string APP_CACHE = "AppCache";
        public const ModelNameEnm CLASS_NAME = ModelNameEnm.APP;
        
        #region Constructor
        public DocEntityApp(Session session) : base(session) {}

        public DocEntityApp() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        protected override List<string> _select => __vf ?? (__vf = DocWebSession.GetTypeSelect(new App()));

        #region Static Members
        public static DocEntityApp Get(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? Get(reference.Id) : null;
        }

        public static DocEntityApp Get(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityApp>.GetFromCache(primaryKey, APP_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityApp>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityApp>.UpdateCache(ret.Id, ret, APP_CACHE);
                    DocEntityThreadCache<DocEntityApp>.UpdateCache(ret.Hash, ret, APP_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityApp Get(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityApp>.GetFromCache(hash, APP_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityApp>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityApp>.UpdateCache(ret.Id, ret, APP_CACHE);
                    DocEntityThreadCache<DocEntityApp>.UpdateCache(ret.Hash, ret, APP_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field]
        public string Description { get; set; }


        [Field(Nullable = false, Length = 200)]
        public string Name { get; set; }


        [Field]
        [Association(PairTo = nameof(DocEntityPage.Apps), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityPage> Pages { get; private set; }


        public int? PagesCount { get { return Pages.Count(); } private set { var noid = value; } }


        [Field]
        [Association(PairTo = nameof(DocEntityRole.Apps), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityRole> Roles { get; private set; }


        public int? RolesCount { get { return Roles.Count(); } private set { var noid = value; } }


        [Field]
        [Association(PairTo = nameof(DocEntityScope.App), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityScope> Scopes { get; private set; }


        public int? ScopesCount { get { return Scopes.Count(); } private set { var noid = value; } }


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

        public const string CACHE_KEY_PREFIX = "FindApps";

        #endregion Overrides of DocEntity

        #region Entity overrides
        /// <summary>
        ///    Called when entity is about to be removed.
        /// </summary>
        protected override void OnRemoving()
        {
            base.OnRemoving();
            try
            {
                Scopes.Clear(); //foreach thing in Scopes en.Remove();
            }
            catch(Exception ex)
            {
                throw new DocException("Failed to delete App in Scopes delete", ex);
            }
            FlushCache();
        }

        /// <summary>
        ///    Called when entity should be validated. Override this method to perform custom object validation.
        /// </summary>
        protected override void OnValidate()
        {
            if (false == ValidationMessage.IsValid)
            {
                throw new HttpError(HttpStatusCode.Conflict, $"App requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();
            _validated = true;
        }

        public override IDocEntity SaveChanges(bool ignoreCache, DocConstantPermission permission)
        {
            Description = Description?.TrimAndPruneSpaces();
            Name = Name?.TrimAndPruneSpaces();
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

                if(DocTools.IsNullOrEmpty(Name))
                {
                    isValid = false;
                    message += " Name is a required property.";
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Converters

        public App ToDto() => Mapper.Map<DocEntityApp, App>(this);

        public static explicit operator App(DocEntityApp en) => en?.ToDto();
        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }
}
