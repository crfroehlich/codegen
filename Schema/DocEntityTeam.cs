﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when
//    the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AutoMapper;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Dynamic;
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
    [TableMapping(DocConstantModelName.TEAM)]
    public partial class DocEntityTeam : DocEntityBase
    {
        private const string TEAM_CACHE = "TeamCache";
        public const string TABLE_NAME = DocConstantModelName.TEAM;
        
        #region Constructor
        public DocEntityTeam(Session session) : base(session) {}

        public DocEntityTeam() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        #region VisibleFields

        protected override List<string> _visibleFields
        {
            get
            {
                if(null == __vf)
                {
                    __vf = DocWebSession.GetTypeVisibleFields(new Team());
                }
                return __vf;
            }
        }

        #endregion VisibleFields

        #region Static Members
        public static DocEntityTeam GetTeam(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetTeam(reference.Id) : null;
        }

        public static DocEntityTeam GetTeam(int? primaryKey)
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

        public static DocEntityTeam GetTeam(Guid hash)
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
        [Field()]
        [FieldMapping(nameof(AdminRoles))]
        [Association(PairTo = nameof(DocEntityRole.AdminTeam), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityRole> AdminRoles { get; private set; }


        public int? AdminRolesCount { get { return AdminRoles.Count(); } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Description))]
        public string Description { get; set; }


        [Field()]
        [FieldMapping(nameof(Email))]
        public string Email { get; set; }


        [Field(Nullable = false, DefaultValue = false)]
        [FieldMapping(nameof(IsInternal))]
        public bool IsInternal { get; set; }


        [Field(Nullable = false)]
        [FieldMapping(nameof(Name))]
        public string Name { get; set; }


        [Field(Nullable = false)]
        [FieldMapping(nameof(Owner))]
        public DocEntityUser Owner { get; set; }
        public int? OwnerId { get { return Owner?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Scopes))]
        [Association(PairTo = nameof(DocEntityScope.Team), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityScope> Scopes { get; private set; }


        public int? ScopesCount { get { return Scopes.Count(); } private set { var noid = value; } }


        [Field(Length = int.MaxValue)]
        [FieldMapping(nameof(Settings))]
        public string Settings { get; set; }


        [Field()]
        [FieldMapping(nameof(Slack))]
        public string Slack { get; set; }


        [Field()]
        [FieldMapping(nameof(Updates))]
        [Association(PairTo = nameof(DocEntityUpdate.Team), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityUpdate> Updates { get; private set; }


        public int? UpdatesCount { get { return Updates.Count(); } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Users))]
        public DocEntitySet<DocEntityUser> Users { get; private set; }


        public int? UsersCount { get { return Users.Count(); } private set { var noid = value; } }



        [Field(LazyLoad = false, Length = Int32.MaxValue)]
        public override string Gestalt { get; set; }

        [Field(DefaultValue = 0), Version(VersionMode.Manual)]
        public override int VersionNo { get; set; }

        [Field]
        public override DateTime? Created { get; set; }

        [Field]
        public override DateTime? Updated { get; set; }

        [Field]
        public override bool Locked { get; set; }
        #endregion Properties

        #region Overrides of DocEntity

        public override DocConstantModelName TableName => TABLE_NAME;

        public const string CACHE_KEY_PREFIX = "FindTeams";


        public override T ToModel<T>() =>  null;

        #endregion Overrides of DocEntity

        #region Entity overrides
        /// <summary>
        ///    Called when entity is about to be removed.
        /// </summary>
        protected override void OnRemoving()
        {
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
            base.OnRemoving();
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

            FlushCache();

            _validated = true;


        }

        public override IDocEntity SaveChanges(DocConstantPermission permission = null)
        {
            Description = Description?.TrimAndPruneSpaces();
            Email = Email?.TrimAndPruneSpaces();
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

    public partial class TeamMapper : DocMapperBase
    {
        private IMappingExpression<DocEntityTeam,Team> _EntityToDto;
        private IMappingExpression<Team,DocEntityTeam> _DtoToEntity;

        public TeamMapper()
        {
            CreateMap<DocEntitySet<DocEntityTeam>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityTeam,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityTeam>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityTeam.GetTeam(c));
            _EntityToDto = CreateMap<DocEntityTeam,Team>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Team>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Team>(c, "Updated")))
                .ForMember(dest => dest.AdminRoles, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Team>(c, nameof(DocEntityTeam.AdminRoles))))
                .ForMember(dest => dest.AdminRolesCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Team>(c, nameof(DocEntityTeam.AdminRolesCount))))
                .ForMember(dest => dest.Description, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Team>(c, nameof(DocEntityTeam.Description))))
                .ForMember(dest => dest.Email, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Team>(c, nameof(DocEntityTeam.Email))))
                .ForMember(dest => dest.IsInternal, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Team>(c, nameof(DocEntityTeam.IsInternal))))
                .ForMember(dest => dest.Name, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Team>(c, nameof(DocEntityTeam.Name))))
                .ForMember(dest => dest.Owner, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Team>(c, nameof(DocEntityTeam.Owner))))
                .ForMember(dest => dest.OwnerId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Team>(c, nameof(DocEntityTeam.OwnerId))))
                .ForMember(dest => dest.Scopes, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Team>(c, nameof(DocEntityTeam.Scopes))))
                .ForMember(dest => dest.ScopesCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Team>(c, nameof(DocEntityTeam.ScopesCount))))
                .ForMember(dest => dest.Settings, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Team>(c, nameof(DocEntityTeam.Settings))))
                .ForMember(dest => dest.Slack, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Team>(c, nameof(DocEntityTeam.Slack))))
                .ForMember(dest => dest.Updates, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Team>(c, nameof(DocEntityTeam.Updates))))
                .ForMember(dest => dest.UpdatesCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Team>(c, nameof(DocEntityTeam.UpdatesCount))))
                .ForMember(dest => dest.Users, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Team>(c, nameof(DocEntityTeam.Users))))
                .ForMember(dest => dest.UsersCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Team>(c, nameof(DocEntityTeam.UsersCount))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<Team,DocEntityTeam>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}