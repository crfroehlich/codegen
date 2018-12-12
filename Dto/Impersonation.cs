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
using Services.Enums;
using Services.Models;
using Services.Schema;

using Typed;
using Typed.Bindings;
using Typed.Notifications;
using Typed.Security;
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
    public abstract partial class ImpersonationBase : Dto<Impersonation>
    {
        public ImpersonationBase() {}

        public ImpersonationBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public ImpersonationBase(int? id) : this(DocConvert.ToInt(id)) {}
    
        [ApiMember(Name = nameof(AuthenticatedUser), Description = "User", IsRequired = true)]
        public Reference AuthenticatedUser { get; set; }
        [ApiMember(Name = nameof(AuthenticatedUserId), Description = "Primary Key of User", IsRequired = false)]
        public int? AuthenticatedUserId { get; set; }


        [ApiMember(Name = nameof(ImpersonatedUser), Description = "User", IsRequired = true)]
        public Reference ImpersonatedUser { get; set; }
        [ApiMember(Name = nameof(ImpersonatedUserId), Description = "Primary Key of User", IsRequired = false)]
        public int? ImpersonatedUserId { get; set; }


        [ApiMember(Name = nameof(UserSession), Description = "UserSession", IsRequired = false)]
        public Reference UserSession { get; set; }
        [ApiMember(Name = nameof(UserSessionId), Description = "Primary Key of UserSession", IsRequired = false)]
        public int? UserSessionId { get; set; }


    }

    [Route("/impersonation/{Id}", "GET")]
    [Route("/profile/impersonation/{Id}", "GET")]
    public partial class Impersonation : ImpersonationBase, IReturn<Impersonation>, IDto
    {
        public Impersonation()
        {
            _Constructor();
        }

        public Impersonation(int? id) : base(DocConvert.ToInt(id)) {}
        public Impersonation(int id) : base(id) {}
        
        #region Fields
        
        public bool? ShouldSerialize(string field)
        {
            if (DocTools.AreEqual(nameof(VisibleFields), field)) return false;
            if (DocTools.AreEqual(nameof(Fields), field)) return false;
            if (DocTools.AreEqual(nameof(AssignFields), field)) return false;
            if (DocTools.AreEqual(nameof(IgnoreCache), field)) return false;
            if (DocTools.AreEqual(nameof(Id), field)) return true;
            return true == VisibleFields?.Matches(field, true);
        }

        private static List<string> _fields;
        public static List<string> Fields => _fields ?? (_fields = DocTools.Fields<Impersonation>());

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(AuthenticatedUser),nameof(AuthenticatedUserId),nameof(Created),nameof(CreatorId),nameof(Gestalt),nameof(ImpersonatedUser),nameof(ImpersonatedUserId),nameof(Locked),nameof(Updated),nameof(UserSession),nameof(UserSessionId),nameof(VersionNo)})]
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
                _VisibleFields = DocPermissionFactory.SetVisibleFields<Impersonation>("Impersonation",exists);
            }
        }

        #endregion Fields
    }
    
    [Route("/impersonation", "GET")]
    [Route("/profile/impersonation", "GET")]
    [Route("/impersonation/search", "GET, POST, DELETE")]
    [Route("/profile/impersonation/search", "GET, POST, DELETE")]
    public partial class ImpersonationSearch : Search<Impersonation>
    {
        public Reference AuthenticatedUser { get; set; }
        public List<int> AuthenticatedUserIds { get; set; }
        public Reference ImpersonatedUser { get; set; }
        public List<int> ImpersonatedUserIds { get; set; }
        public Reference UserSession { get; set; }
        public List<int> UserSessionIds { get; set; }
    }
    
    public class ImpersonationFullTextSearch
    {
        private ImpersonationSearch _request;
        public ImpersonationFullTextSearch(ImpersonationSearch request) => _request = request;
        
        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Impersonation.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Impersonation.Updated))); }
        
        public bool doAuthenticatedUser { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Impersonation.AuthenticatedUser))); }
        public bool doImpersonatedUser { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Impersonation.ImpersonatedUser))); }
        public bool doUserSession { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Impersonation.UserSession))); }
    }

    [Route("/impersonation/version", "GET, POST")]
    public partial class ImpersonationVersion : ImpersonationSearch {}

    [Route("/impersonation/batch", "DELETE, PATCH, POST, PUT")]
    [Route("/profile/impersonation/batch", "DELETE, PATCH, POST, PUT")]
    public partial class ImpersonationBatch : List<Impersonation> { }

    [Route("/admin/impersonation/ids", "GET, POST")]
    public class ImpersonationIds
    {
        public bool All { get; set; }
    }
}