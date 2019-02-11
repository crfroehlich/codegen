﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when
//    the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AutoMapper;

using Services.Core;
using Services.Db;
using Services.Dto;
using Services.Dto.internals;
using Services.Enums;
using Services.Models;
using Services.Schema;

using Typed;
using Typed.Bindings;
using Typed.Notifications;
using Services.Dto.Security;
using Typed.Settings;

using ServiceStack;
using ServiceStack.Text;

using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Dynamic;
using System.Net;

using Xtensive.Orm;
using Xtensive.Orm.Model;

using Attribute = Services.Dto.Attribute;
using ValueType = Services.Dto.ValueType;

namespace Services.Dto
{
    public abstract partial class TeamBase : Dto<Team>
    {
        public TeamBase() {}

        public TeamBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public TeamBase(int? id) : this(DocConvert.ToInt(id)) {}
    
        [ApiMember(Name = nameof(AdminRoles), Description = "Role", IsRequired = false)]
        public List<Reference> AdminRoles { get; set; }
        public int? AdminRolesCount { get; set; }


        [ApiMember(Name = nameof(Description), Description = "string", IsRequired = false)]
        public string Description { get; set; }


        [ApiMember(Name = nameof(Email), Description = "string", IsRequired = false)]
        public string Email { get; set; }


        [ApiMember(Name = nameof(IsInternal), Description = "bool", IsRequired = false)]
        public bool IsInternal { get; set; }


        [ApiMember(Name = nameof(Name), Description = "string", IsRequired = true)]
        public string Name { get; set; }


        [ApiMember(Name = nameof(Owner), Description = "User", IsRequired = true)]
        public Reference Owner { get; set; }
        [ApiMember(Name = nameof(OwnerId), Description = "Primary Key of User", IsRequired = false)]
        public int? OwnerId { get; set; }


        [ApiMember(Name = nameof(Scopes), Description = "Scope", IsRequired = false)]
        public List<Reference> Scopes { get; set; }
        public int? ScopesCount { get; set; }


        [ApiMember(Name = nameof(Settings), Description = "TeamSettings", IsRequired = false)]
        public TeamSettings Settings { get; set; }


        [ApiMember(Name = nameof(Slack), Description = "string", IsRequired = false)]
        public string Slack { get; set; }


        [ApiMember(Name = nameof(Updates), Description = "Update", IsRequired = false)]
        public List<Reference> Updates { get; set; }
        public int? UpdatesCount { get; set; }


        [ApiMember(Name = nameof(Users), Description = "User", IsRequired = false)]
        public List<Reference> Users { get; set; }
        public int? UsersCount { get; set; }


    }

    [Route("/team", "POST")]
    [Route("/team/{Id}", "GET, PATCH, PUT, DELETE")]
    public partial class Team : TeamBase, IReturn<Team>, IDto
    {
        public Team()
        {
            _Constructor();
        }

        public Team(int? id) : base(DocConvert.ToInt(id)) {}
        public Team(int id) : base(id) {}
        
        #region Fields
        
        public bool? ShouldSerialize(string field)
        {
            if (IgnoredVisibleFields.Matches(field, true)) return false;
            var ret = MandatoryVisibleFields.Matches(field, true) || true == VisibleFields?.Matches(field, true);
            return ret;
        }

        public static List<string> Fields => DocTools.Fields<Team>();

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(AdminRoles),nameof(AdminRolesCount),nameof(Created),nameof(CreatorId),nameof(Description),nameof(Email),nameof(Gestalt),nameof(IsInternal),nameof(Locked),nameof(Name),nameof(Owner),nameof(OwnerId),nameof(Scopes),nameof(ScopesCount),nameof(Settings),nameof(Slack),nameof(Updated),nameof(Updates),nameof(UpdatesCount),nameof(Users),nameof(UsersCount),nameof(VersionNo)})]
        public new List<string> VisibleFields
        {
            get
            {
                if(null == this) return new List<string>();
                if(null == _VisibleFields)
                {
                    _VisibleFields = DocWebSession.GetTypeVisibleFields(this);
                }
                return _VisibleFields;
            }
            set
            {
                var requested = value ?? new List<string>();
                var exists = requested.Where( r => Fields.Any( f => DocTools.AreEqual(r, f) ) ).ToList();
                _VisibleFields = DocPermissionFactory.SetVisibleFields<Team>("Team",exists);
            }
        }

        #endregion Fields
        private List<string> _collections = new List<string>
        {
            nameof(AdminRoles), nameof(AdminRolesCount), nameof(Scopes), nameof(ScopesCount), nameof(Updates), nameof(UpdatesCount), nameof(Users), nameof(UsersCount)
        };
        private List<string> collections { get { return _collections; } }
    }
    
    [Route("/Team/{Id}/copy", "POST")]
    public partial class TeamCopy : Team {}
    public partial class TeamSearchBase : Search<Team>
    {
        public int? Id { get; set; }
        public List<int> AdminRolesIds { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> IsInternal { get; set; }
        public string Name { get; set; }
        public Reference Owner { get; set; }
        public List<int> OwnerIds { get; set; }
        public List<int> ScopesIds { get; set; }
        public string Settings { get; set; }
        public string Slack { get; set; }
        public List<int> UpdatesIds { get; set; }
        public List<int> UsersIds { get; set; }
    }

    [Route("/team", "GET")]
    [Route("/team/version", "GET, POST")]
    [Route("/team/search", "GET, POST, DELETE")]
    public partial class TeamSearch : TeamSearchBase
    {
    }

    public class TeamFullTextSearch
    {
        public TeamFullTextSearch() {}
        private TeamSearch _request;
        public TeamFullTextSearch(TeamSearch request) => _request = request;
        
        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Team.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Team.Updated))); }
        
        public bool doAdminRoles { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Team.AdminRoles))); }
        public bool doDescription { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Team.Description))); }
        public bool doEmail { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Team.Email))); }
        public bool doIsInternal { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Team.IsInternal))); }
        public bool doName { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Team.Name))); }
        public bool doOwner { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Team.Owner))); }
        public bool doScopes { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Team.Scopes))); }
        public bool doSettings { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Team.Settings))); }
        public bool doSlack { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Team.Slack))); }
        public bool doUpdates { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Team.Updates))); }
        public bool doUsers { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Team.Users))); }
    }

    [Route("/team/batch", "DELETE, PATCH, POST, PUT")]
    public partial class TeamBatch : List<Team> { }

    [Route("/team/{Id}/{Junction}/version", "GET, POST")]
    [Route("/team/{Id}/{Junction}", "GET, POST, DELETE")]
    public class TeamJunction : TeamSearchBase {}


}