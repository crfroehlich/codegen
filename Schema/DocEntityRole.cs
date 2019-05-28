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
    [TableMapping(DocConstantModelName.ROLE)]
    public partial class DocEntityRole : DocEntityBase
    {
        private const string ROLE_CACHE = "RoleCache";
        public const ModelNameEnm CLASS_NAME = ModelNameEnm.ROLE;
        
        #region Constructor
        public DocEntityRole(Session session) : base(session) {}

        public DocEntityRole() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        protected override List<string> _select => __vf ?? (__vf = DocWebSession.GetTypeSelect(new Role()));

        #region Static Members
        public static DocEntityRole Get(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? Get(reference.Id) : null;
        }

        public static DocEntityRole Get(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityRole>.GetFromCache(primaryKey, ROLE_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityRole>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityRole>.UpdateCache(ret.Id, ret, ROLE_CACHE);
                    DocEntityThreadCache<DocEntityRole>.UpdateCache(ret.Hash, ret, ROLE_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityRole Get(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityRole>.GetFromCache(hash, ROLE_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityRole>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityRole>.UpdateCache(ret.Id, ret, ROLE_CACHE);
                    DocEntityThreadCache<DocEntityRole>.UpdateCache(ret.Hash, ret, ROLE_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field]
        public DocEntityTeam AdminTeam { get; set; }
        public int? AdminTeamId { get { return AdminTeam?.Id; } private set { var noid = value; } }


        [Field]
        public DocEntitySet<DocEntityApp> Apps { get; private set; }


        public List<int> AppsIds => Apps.Select(e => e.Id).ToList();


        public int? AppsCount { get { return Apps.Count(); } private set { var noid = value; } }


        [Field]
        public string Description { get; set; }


        [Field(Length = int.MaxValue)]
        public string Features { get; set; }


        [Field]
        [Association(PairTo = nameof(DocEntityFeatureSet.Roles), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityFeatureSet> FeatureSets { get; private set; }


        public List<int> FeatureSetsIds => FeatureSets.Select(e => e.Id).ToList();


        public int? FeatureSetsCount { get { return FeatureSets.Count(); } private set { var noid = value; } }


        [Field(Nullable = false, DefaultValue = false)]
        public bool IsInternal { get; set; }


        [Field(Nullable = false, DefaultValue = false)]
        public bool IsSuperAdmin { get; set; }


        [Field(Nullable = false, Length = 200)]
        public string Name { get; set; }


        [Field]
        public DocEntitySet<DocEntityPage> Pages { get; private set; }


        public List<int> PagesIds => Pages.Select(e => e.Id).ToList();


        public int? PagesCount { get { return Pages.Count(); } private set { var noid = value; } }


        [Field(Length = int.MaxValue)]
        public string Permissions { get; set; }


        [Field]
        [Association(PairTo = nameof(DocEntityUser.Roles), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityUser> Users { get; private set; }


        public List<int> UsersIds => Users.Select(e => e.Id).ToList();


        public int? UsersCount { get { return Users.Count(); } private set { var noid = value; } }


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

        public const string CACHE_KEY_PREFIX = "FindRoles";

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
                throw new HttpError(HttpStatusCode.Conflict, $"Role requires: {ValidationMessage.Message}.");
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

                if(DocTools.IsNullOrEmpty(IsInternal))
                {
                    isValid = false;
                    message += " IsInternal is a required property.";
                }
                if(DocTools.IsNullOrEmpty(IsSuperAdmin))
                {
                    isValid = false;
                    message += " IsSuperAdmin is a required property.";
                }
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

        public Role ToDto() => Mapper.Map<DocEntityRole, Role>(this);

        public static explicit operator Role(DocEntityRole en) => en?.ToDto();
        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }
}
