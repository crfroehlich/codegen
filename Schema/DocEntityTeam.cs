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
    [TableMapping(DocConstantModelName.TEAM)]
    public partial class DocEntityTeam : DocEntityBase
    {
        private const string TEAM_CACHE = "TeamCache";
        public const string TABLE_NAME = DocConstantModelName.TEAM;
        
        #region Constructor
        public DocEntityTeam(Session session) : base(session) {}

        public DocEntityTeam() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        protected override List<string> _visibleFields => __vf ?? (__vf = DocWebSession.GetTypeVisibleFields(new Team()));

        #region Static Members
        public static DocEntityTeam Get(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? Get(reference.Id) : null;
        }

        public static DocEntityTeam Get(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityTeam>.GetFromCache(primaryKey, TEAM_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityTeam>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityTeam>.UpdateCache(ret.Id, ret, TEAM_CACHE);
                    DocEntityThreadCache<DocEntityTeam>.UpdateCache(ret.Hash, ret, TEAM_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityTeam Get(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityTeam>.GetFromCache(hash, TEAM_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityTeam>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityTeam>.UpdateCache(ret.Id, ret, TEAM_CACHE);
                    DocEntityThreadCache<DocEntityTeam>.UpdateCache(ret.Hash, ret, TEAM_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field]
        [Association(PairTo = nameof(DocEntityRole.AdminTeam), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityRole> AdminRoles { get; private set; }


        public int? AdminRolesCount { get { return AdminRoles.Count(); } private set { var noid = value; } }


        [Field]
        public string Description { get; set; }


        [Field]
        public string Email { get; set; }


        [Field(Nullable = false, DefaultValue = false)]
        public bool IsInternal { get; set; }


        [Field(Nullable = false)]
        public string Name { get; set; }


        [Field(Nullable = false)]
        public DocEntityUser Owner { get; set; }
        public int? OwnerId { get { return Owner?.Id; } private set { var noid = value; } }


        [Field]
        [Association(PairTo = nameof(DocEntityScope.Team), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityScope> Scopes { get; private set; }


        public int? ScopesCount { get { return Scopes.Count(); } private set { var noid = value; } }


        [Field(Length = int.MaxValue)]
        public string Settings { get; set; }


        [Field]
        public string Slack { get; set; }


        [Field]
        [Association(PairTo = nameof(DocEntityUpdate.Team), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityUpdate> Updates { get; private set; }


        public int? UpdatesCount { get { return Updates.Count(); } private set { var noid = value; } }


        [Field]
        public DocEntitySet<DocEntityUser> Users { get; private set; }


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

        public override DocConstantModelName TableName => TABLE_NAME;

        public const string CACHE_KEY_PREFIX = "FindTeams";

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
                AdminRoles.Clear(); //foreach thing in AdminRoles en.Remove();
            }
            catch(Exception ex)
            {
                throw new DocException("Failed to delete Team in AdminRoles delete", ex);
            }
            try
            {
                Scopes.Clear(); //foreach thing in Scopes en.Remove();
            }
            catch(Exception ex)
            {
                throw new DocException("Failed to delete Team in Scopes delete", ex);
            }
            try
            {
                Updates.Clear(); //foreach thing in Updates en.Remove();
            }
            catch(Exception ex)
            {
                throw new DocException("Failed to delete Team in Updates delete", ex);
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
                throw new HttpError(HttpStatusCode.Conflict, $"Team requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();
            _validated = true;
        }

        public override IDocEntity SaveChanges(bool ignoreCache, DocConstantPermission permission)
        {
            Description = Description?.TrimAndPruneSpaces();
            Email = Email?.TrimAndPruneSpaces();
            Name = Name?.TrimAndPruneSpaces();
            Slack = Slack?.TrimAndPruneSpaces();
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
                if(DocTools.IsNullOrEmpty(Name))
                {
                    isValid = false;
                    message += " Name is a required property.";
                }
                if(DocTools.IsNullOrEmpty(Owner))
                {
                    isValid = false;
                    message += " Owner is a required property.";
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Converters

        public Team ToDto() => Mapper.Map<DocEntityTeam, Team>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }
}
