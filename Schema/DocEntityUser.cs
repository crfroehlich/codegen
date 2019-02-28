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
using System.Runtime.Serialization;

using Services.Core;
using Services.Db;
using Services.Dto;
using Services.Dto.internals;
using Services.Enums;
using Services.Models;

using ServiceStack;

using Typed.Notifications;
using Typed.Settings;

using Xtensive.Orm;
using Xtensive.Orm.Model;

using Attribute = Services.Dto.Attribute;
using ValueType = Services.Dto.ValueType;

namespace Services.Schema
{
    [TableMapping(DocConstantModelName.USER)]
    public partial class DocEntityUser : DocEntityBase
    {
        private const string USER_CACHE = "UserCache";
        public const string TABLE_NAME = DocConstantModelName.USER;
        
        #region Constructor
        public DocEntityUser(Session session) : base(session) {}

        public DocEntityUser() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        #region VisibleFields

        protected override List<string> _visibleFields
        {
            get
            {
                if(null == __vf)
                {
                    __vf = DocWebSession.GetTypeVisibleFields(new User());
                }
                return __vf;
            }
        }

        #endregion VisibleFields

        #region Static Members
        public static DocEntityUser GetUser(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetUser(reference.Id) : null;
        }

        public static DocEntityUser GetUser(int? primaryKey)
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

        public static DocEntityUser GetUser(Guid hash)
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
        [Field()]
        [FieldMapping(nameof(ClientDepartment))]
        public string ClientDepartment { get; set; }


        [Field(Nullable = false)]
        [FieldMapping(nameof(Division))]
        public DocEntityDivision Division { get; set; }
        public int? DivisionId { get { return Division?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(DocumentSets))]
        public DocEntitySet<DocEntityDocumentSet> DocumentSets { get; private set; }


        public int? DocumentSetsCount { get { return DocumentSets.Count(); } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Email))]
        public string Email { get; set; }


        [Field()]
        [FieldMapping(nameof(ExpireDate))]
        public DateTime? ExpireDate { get; set; }


        [Field(DefaultValue = 0)]
        [FieldMapping(nameof(FailedLoginCount))]
        public int FailedLoginCount { get; set; }


        [Field()]
        [FieldMapping(nameof(FirstName))]
        public string FirstName { get; set; }


        [Field()]
        [FieldMapping(nameof(Gravatar))]
        public string Gravatar { get; set; }


        [Field()]
        [FieldMapping(nameof(History))]
        [Association(PairTo = nameof(DocEntityHistory.User), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityHistory> History { get; private set; }


        public int? HistoryCount { get { return History.Count(); } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Impersonated))]
        [Association(PairTo = nameof(DocEntityImpersonation.ImpersonatedUser), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityImpersonation> Impersonated { get; private set; }


        public int? ImpersonatedCount { get { return Impersonated.Count(); } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Impersonating))]
        [Association(PairTo = nameof(DocEntityImpersonation.AuthenticatedUser), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityImpersonation> Impersonating { get; private set; }


        public int? ImpersonatingCount { get { return Impersonating.Count(); } private set { var noid = value; } }


        [Field(DefaultValue = false)]
        [FieldMapping(nameof(IsSystemUser))]
        public bool? IsSystemUser { get; set; }


        [Field()]
        [FieldMapping(nameof(JobTitle))]
        public string JobTitle { get; set; }


        [Field()]
        [FieldMapping(nameof(LastLogin))]
        public DateTime? LastLogin { get; set; }


        [Field()]
        [FieldMapping(nameof(LastName))]
        public string LastName { get; set; }


        [Field()]
        [FieldMapping(nameof(LegacyUsername))]
        public string LegacyUsername { get; set; }


        [Field()]
        [FieldMapping(nameof(Locale))]
        public DocEntityLocale Locale { get; set; }
        public int? LocaleId { get { return Locale?.Id; } private set { var noid = value; } }


        [Field(DefaultValue = 0)]
        [FieldMapping(nameof(LoginCount))]
        public int LoginCount { get; set; }


        [Field(Nullable = false)]
        [FieldMapping(nameof(Name))]
        public string Name { get; set; }


        [Field()]
        [FieldMapping(nameof(Roles))]
        public DocEntitySet<DocEntityRole> Roles { get; private set; }


        public int? RolesCount { get { return Roles.Count(); } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Scopes))]
        [Association(PairTo = nameof(DocEntityScope.User), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityScope> Scopes { get; private set; }


        public int? ScopesCount { get { return Scopes.Count(); } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Sessions))]
        [Association(PairTo = nameof(DocEntityUserSession.User), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityUserSession> Sessions { get; private set; }


        public int? SessionsCount { get { return Sessions.Count(); } private set { var noid = value; } }


        [Field(Length = int.MaxValue)]
        [FieldMapping(nameof(Settings))]
        public string Settings { get; set; }


        [Field()]
        [FieldMapping(nameof(Slack))]
        public string Slack { get; set; }


        [Field()]
        [FieldMapping(nameof(StartDate))]
        public DateTime? StartDate { get; set; }


        [Field()]
        [FieldMapping(nameof(Status))]
        public DocEntityLookupTable Status { get; set; }
        public int? StatusId { get { return Status?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Teams))]
        [Association(PairTo = nameof(DocEntityTeam.Owner), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityTeam> Teams { get; private set; }


        public int? TeamsCount { get { return Teams.Count(); } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(TimeCards))]
        [Association(PairTo = nameof(DocEntityTimeCard.User), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityTimeCard> TimeCards { get; private set; }


        public int? TimeCardsCount { get { return TimeCards.Count(); } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Updates))]
        [Association(PairTo = nameof(DocEntityUpdate.User), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityUpdate> Updates { get; private set; }


        public int? UpdatesCount { get { return Updates.Count(); } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(UserType))]
        public DocEntityUserType UserType { get; set; }
        public int? UserTypeId { get { return UserType?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Workflows))]
        [Association(PairTo = nameof(DocEntityWorkflow.User), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityWorkflow> Workflows { get; private set; }


        public int? WorkflowsCount { get { return Workflows.Count(); } private set { var noid = value; } }



        [Field(LazyLoad = false, Length = Int32.MaxValue)]
        public override string Gestalt { get; set; }

        [Field(DefaultValue = 0), Version(VersionMode.Manual)]
        public override int VersionNo { get; set; }

        [Field]
        public override DateTime? Created { get; set; }

        [Field]
        public override DateTime? Updated { get; set; }

        [Field(DefaultValue = false)]
        [FieldMapping(nameof(Locked))]
        public override bool Locked { get; set; }

        [Field(DefaultValue = false)]
        [FieldMapping(nameof(Archived))]
        public override bool Archived { get; set; }

        #endregion Properties

        #region Overrides of DocEntity

        public override DocConstantModelName TableName => TABLE_NAME;

        public const string CACHE_KEY_PREFIX = "FindUsers";

        #endregion Overrides of DocEntity

        #region Entity overrides
        /// <summary>
        ///    Called when entity is about to be removed.
        /// </summary>
        protected override void OnRemoving()
        {
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
            base.OnRemoving();
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

            FlushCache();

            _validated = true;


        }

        public override IDocEntity SaveChanges(DocConstantPermission permission = null)
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
            return base.SaveChanges(permission);
        }

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
                if(null != Status && Status?.Enum?.Name != "Status")
                {
                    isValid = false;
                    message += " Status is a " + Status?.Enum?.Name + ", but must be a Status.";
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Converters

        public User ToDto() => Mapper.Map<DocEntityUser, User>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }

    public static partial class UniqueConstraintFilter
    {
        public static Expression<Func<DocEntityUser, bool>> UserIgnoreArchived() => d => d.Archived == false;
    }

    public partial class UserMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityUser,User> _EntityToDto;
        protected IMappingExpression<User,DocEntityUser> _DtoToEntity;

        public UserMapper()
        {
            CreateMap<DocEntitySet<DocEntityUser>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityUser,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityUser>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityUser.GetUser(c));
            _EntityToDto = CreateMap<DocEntityUser,User>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, "Updated")))
                .ForMember(dest => dest.ClientDepartment, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.ClientDepartment))))
                .ForMember(dest => dest.Division, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.Division))))
                .ForMember(dest => dest.DivisionId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.DivisionId))))
                .ForMember(dest => dest.DocumentSets, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.DocumentSets))))
                .ForMember(dest => dest.DocumentSetsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.DocumentSetsCount))))
                .ForMember(dest => dest.Email, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.Email))))
                .ForMember(dest => dest.ExpireDate, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.ExpireDate))))
                .ForMember(dest => dest.FailedLoginCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.FailedLoginCount))))
                .ForMember(dest => dest.FirstName, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.FirstName))))
                .ForMember(dest => dest.Gravatar, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.Gravatar))))
                .ForMember(dest => dest.History, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.History))))
                .ForMember(dest => dest.HistoryCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.HistoryCount))))
                .ForMember(dest => dest.Impersonated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.Impersonated))))
                .ForMember(dest => dest.ImpersonatedCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.ImpersonatedCount))))
                .ForMember(dest => dest.Impersonating, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.Impersonating))))
                .ForMember(dest => dest.ImpersonatingCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.ImpersonatingCount))))
                .ForMember(dest => dest.IsSystemUser, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.IsSystemUser))))
                .ForMember(dest => dest.JobTitle, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.JobTitle))))
                .ForMember(dest => dest.LastLogin, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.LastLogin))))
                .ForMember(dest => dest.LastName, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.LastName))))
                .ForMember(dest => dest.LegacyUsername, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.LegacyUsername))))
                .ForMember(dest => dest.Locale, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.Locale))))
                .ForMember(dest => dest.LocaleId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.LocaleId))))
                .ForMember(dest => dest.LoginCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.LoginCount))))
                .ForMember(dest => dest.Name, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.Name))))
                .ForMember(dest => dest.Roles, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.Roles))))
                .ForMember(dest => dest.RolesCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.RolesCount))))
                .ForMember(dest => dest.Scopes, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.Scopes))))
                .ForMember(dest => dest.ScopesCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.ScopesCount))))
                .ForMember(dest => dest.Sessions, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.Sessions))))
                .ForMember(dest => dest.SessionsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.SessionsCount))))
                .ForMember(dest => dest.Settings, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.Settings))))
                .ForMember(dest => dest.Slack, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.Slack))))
                .ForMember(dest => dest.StartDate, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.StartDate))))
                .ForMember(dest => dest.Status, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.Status))))
                .ForMember(dest => dest.StatusId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.StatusId))))
                .ForMember(dest => dest.Teams, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.Teams))))
                .ForMember(dest => dest.TeamsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.TeamsCount))))
                .ForMember(dest => dest.TimeCards, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.TimeCards))))
                .ForMember(dest => dest.TimeCardsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.TimeCardsCount))))
                .ForMember(dest => dest.Updates, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.Updates))))
                .ForMember(dest => dest.UpdatesCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.UpdatesCount))))
                .ForMember(dest => dest.UserType, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.UserType))))
                .ForMember(dest => dest.UserTypeId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.UserTypeId))))
                .ForMember(dest => dest.Workflows, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.Workflows))))
                .ForMember(dest => dest.WorkflowsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<User>(c, nameof(DocEntityUser.WorkflowsCount))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<User,DocEntityUser>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
