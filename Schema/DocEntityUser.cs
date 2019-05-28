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
    [TableMapping(DocConstantModelName.USER)]
    public partial class DocEntityUser : DocEntityBase
    {
        private const string USER_CACHE = "UserCache";
        public const ModelNameEnm CLASS_NAME = ModelNameEnm.USER;
        
        #region Constructor
        public DocEntityUser(Session session) : base(session) {}

        public DocEntityUser() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        protected override List<string> _select => __vf ?? (__vf = DocWebSession.GetTypeSelect(new User()));

        #region Static Members
        public static DocEntityUser Get(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? Get(reference.Id) : null;
        }

        public static DocEntityUser Get(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityUser>.GetFromCache(primaryKey, USER_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityUser>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityUser>.UpdateCache(ret.Id, ret, USER_CACHE);
                    DocEntityThreadCache<DocEntityUser>.UpdateCache(ret.Hash, ret, USER_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityUser Get(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityUser>.GetFromCache(hash, USER_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityUser>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityUser>.UpdateCache(ret.Id, ret, USER_CACHE);
                    DocEntityThreadCache<DocEntityUser>.UpdateCache(ret.Hash, ret, USER_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field]
        public string ClientDepartment { get; set; }


        [Field(Nullable = false)]
        public DocEntityDivision Division { get; set; }
        public int? DivisionId { get { return Division?.Id; } private set { var noid = value; } }


        [Field]
        public DocEntitySet<DocEntityDocumentSet> DocumentSets { get; private set; }


        public List<int> DocumentSetsIds => DocumentSets.Select(e => e.Id).ToList();


        public int? DocumentSetsCount { get { return DocumentSets.Count(); } private set { var noid = value; } }


        [Field]
        public string Email { get; set; }


        [Field]
        public DateTime? ExpireDate { get; set; }


        [Field(DefaultValue = 0)]
        public int FailedLoginCount { get; set; }


        [Field]
        public string FirstName { get; set; }


        [Field]
        public string Gravatar { get; set; }


        [Field]
        [Association(PairTo = nameof(DocEntityHistory.User), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityHistory> History { get; private set; }


        public List<int> HistoryIds => History.Select(e => e.Id).ToList();


        public int? HistoryCount { get { return History.Count(); } private set { var noid = value; } }


        [Field]
        [Association(PairTo = nameof(DocEntityImpersonation.ImpersonatedUser), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityImpersonation> Impersonated { get; private set; }


        public List<int> ImpersonatedIds => Impersonated.Select(e => e.Id).ToList();


        public int? ImpersonatedCount { get { return Impersonated.Count(); } private set { var noid = value; } }


        [Field]
        [Association(PairTo = nameof(DocEntityImpersonation.AuthenticatedUser), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityImpersonation> Impersonating { get; private set; }


        public List<int> ImpersonatingIds => Impersonating.Select(e => e.Id).ToList();


        public int? ImpersonatingCount { get { return Impersonating.Count(); } private set { var noid = value; } }


        [Field(DefaultValue = false)]
        public bool? IsSystemUser { get; set; }


        [Field]
        public string JobTitle { get; set; }


        [Field]
        public DateTime? LastLogin { get; set; }


        [Field]
        public string LastName { get; set; }


        [Field]
        public string LegacyUsername { get; set; }


        [Field]
        public DocEntityLocale Locale { get; set; }
        public int? LocaleId { get { return Locale?.Id; } private set { var noid = value; } }


        [Field(DefaultValue = 0)]
        public int LoginCount { get; set; }


        [Field(Nullable = false, Length = 200)]
        public string Name { get; set; }


        [Field]
        public DocEntitySet<DocEntityRole> Roles { get; private set; }


        public List<int> RolesIds => Roles.Select(e => e.Id).ToList();


        public int? RolesCount { get { return Roles.Count(); } private set { var noid = value; } }


        [Field]
        [Association(PairTo = nameof(DocEntityScope.User), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityScope> Scopes { get; private set; }


        public List<int> ScopesIds => Scopes.Select(e => e.Id).ToList();


        public int? ScopesCount { get { return Scopes.Count(); } private set { var noid = value; } }


        [Field]
        [Association(PairTo = nameof(DocEntityUserSession.User), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityUserSession> Sessions { get; private set; }


        public List<int> SessionsIds => Sessions.Select(e => e.Id).ToList();


        public int? SessionsCount { get { return Sessions.Count(); } private set { var noid = value; } }


        [Field(Length = int.MaxValue)]
        public string Settings { get; set; }


        [Field]
        public string Slack { get; set; }


        [Field]
        public DateTime? StartDate { get; set; }


        [Field(Nullable = false, DefaultValue = StatusEnm.ACTIVE)]
        public StatusEnm Status { get; set; }


        [Field]
        [Association(PairTo = nameof(DocEntityTeam.Owner), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityTeam> Teams { get; private set; }


        public List<int> TeamsIds => Teams.Select(e => e.Id).ToList();


        public int? TeamsCount { get { return Teams.Count(); } private set { var noid = value; } }


        [Field]
        [Association(PairTo = nameof(DocEntityTimeCard.User), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityTimeCard> TimeCards { get; private set; }


        public List<int> TimeCardsIds => TimeCards.Select(e => e.Id).ToList();


        public int? TimeCardsCount { get { return TimeCards.Count(); } private set { var noid = value; } }


        [Field]
        [Association(PairTo = nameof(DocEntityUpdate.User), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityUpdate> Updates { get; private set; }


        public List<int> UpdatesIds => Updates.Select(e => e.Id).ToList();


        public int? UpdatesCount { get { return Updates.Count(); } private set { var noid = value; } }


        [Field]
        public DocEntityUserType UserType { get; set; }
        public int? UserTypeId { get { return UserType?.Id; } private set { var noid = value; } }


        [Field]
        [Association(PairTo = nameof(DocEntityWorkflow.User), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityWorkflow> Workflows { get; private set; }


        public List<int> WorkflowsIds => Workflows.Select(e => e.Id).ToList();


        public int? WorkflowsCount { get { return Workflows.Count(); } private set { var noid = value; } }


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

        public const string CACHE_KEY_PREFIX = "FindUsers";

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
                throw new DocException("Failed to delete User in Scopes delete", ex);
            }
            try
            {
                Sessions.Clear(); //foreach thing in Sessions en.Remove();
            }
            catch(Exception ex)
            {
                throw new DocException("Failed to delete User in Sessions delete", ex);
            }
            try
            {
                Teams.Clear(); //foreach thing in Teams en.Remove();
            }
            catch(Exception ex)
            {
                throw new DocException("Failed to delete User in Teams delete", ex);
            }
            try
            {
                Updates.Clear(); //foreach thing in Updates en.Remove();
            }
            catch(Exception ex)
            {
                throw new DocException("Failed to delete User in Updates delete", ex);
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
                throw new HttpError(HttpStatusCode.Conflict, $"User requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();
            _validated = true;
        }

        public override IDocEntity SaveChanges(bool ignoreCache, DocConstantPermission permission)
        {
            ClientDepartment = ClientDepartment?.TrimAndPruneSpaces();
            Email = Email?.TrimAndPruneSpaces();
            FirstName = FirstName?.TrimAndPruneSpaces();
            Gravatar = Gravatar?.TrimAndPruneSpaces();
            JobTitle = JobTitle?.TrimAndPruneSpaces();
            LastName = LastName?.TrimAndPruneSpaces();
            LegacyUsername = LegacyUsername?.TrimAndPruneSpaces();
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

                if(DocTools.IsNullOrEmpty(Division))
                {
                    isValid = false;
                    message += " Division is a required property.";
                }
                if(DocTools.IsNullOrEmpty(Name))
                {
                    isValid = false;
                    message += " Name is a required property.";
                }
                if(DocTools.IsNullOrEmpty(Status))
                {
                    isValid = false;
                    message += " Status is a required property.";
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Converters

        public User ToDto() => Mapper.Map<DocEntityUser, User>(this);

        public static explicit operator User(DocEntityUser en) => en?.ToDto();
        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }
}
