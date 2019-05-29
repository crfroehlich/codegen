
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

        public ImpersonationBase(int? pId, Reference pAuthenticatedUser, int? pAuthenticatedUserId, Reference pImpersonatedUser, int? pImpersonatedUserId, Reference pUserSession, int? pUserSessionId) : this(DocConvert.ToInt(pId)) 
        {
            AuthenticatedUser = pAuthenticatedUser;
            AuthenticatedUserId = pAuthenticatedUserId;
            ImpersonatedUser = pImpersonatedUser;
            ImpersonatedUserId = pImpersonatedUserId;
            UserSession = pUserSession;
            UserSessionId = pUserSessionId;
        }

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



        public void Deconstruct(out Reference pAuthenticatedUser, out int? pAuthenticatedUserId, out Reference pImpersonatedUser, out int? pImpersonatedUserId, out Reference pUserSession, out int? pUserSessionId)
        {
            pAuthenticatedUser = AuthenticatedUser;
            pAuthenticatedUserId = AuthenticatedUserId;
            pImpersonatedUser = ImpersonatedUser;
            pImpersonatedUserId = ImpersonatedUserId;
            pUserSession = UserSession;
            pUserSessionId = UserSessionId;
        }

        //Not ready until C# v8.?
        //public ImpersonationBase With(int? pId = Id, Reference pAuthenticatedUser = AuthenticatedUser, int? pAuthenticatedUserId = AuthenticatedUserId, Reference pImpersonatedUser = ImpersonatedUser, int? pImpersonatedUserId = ImpersonatedUserId, Reference pUserSession = UserSession, int? pUserSessionId = UserSessionId) => 
        //	new ImpersonationBase(pId, pAuthenticatedUser, pAuthenticatedUserId, pImpersonatedUser, pImpersonatedUserId, pUserSession, pUserSessionId);

    }


    [Route("/impersonation/{Id}", "GET")]

    public partial class Impersonation : ImpersonationBase, IReturn<Impersonation>, IDto, ICloneable
    {
        public Impersonation()
        {
            _Constructor();
        }

        public Impersonation(int? id) : base(DocConvert.ToInt(id)) {}
        public Impersonation(int id) : base(id) {}
        public Impersonation(int? pId, Reference pAuthenticatedUser, int? pAuthenticatedUserId, Reference pImpersonatedUser, int? pImpersonatedUserId, Reference pUserSession, int? pUserSessionId) : 
            base(pId, pAuthenticatedUser, pAuthenticatedUserId, pImpersonatedUser, pImpersonatedUserId, pUserSession, pUserSessionId) { }
        #region Fields

        public bool? ShouldSerialize(string field)
        {
            //Allow individual classes to specify their own logic
            var manualOverride = _ShouldSerialize(field);
            if(null != manualOverride) return manualOverride;

            if (IgnoredVisibleFields.Matches(field, true)) return false;
            var ret = MandatoryVisibleFields.Matches(field, true) || true == VisibleFields?.Matches(field, true);
            return ret;
        }

        public static List<string> Fields => DocTools.Fields<Impersonation>();

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


        public object Clone() => this.Copy<Impersonation>();
    }
    

    public partial class ImpersonationSearchBase : Search<Impersonation>
    {
        public int? Id { get; set; }
        public Reference AuthenticatedUser { get; set; }
        public List<int> AuthenticatedUserIds { get; set; }
        public Reference ImpersonatedUser { get; set; }
        public List<int> ImpersonatedUserIds { get; set; }
        public Reference UserSession { get; set; }
        public List<int> UserSessionIds { get; set; }
    }


    [Route("/impersonation", "GET")]
    [Route("/impersonation/version", "GET, POST")]
    [Route("/impersonation/search", "GET, POST, DELETE")]

    public partial class ImpersonationSearch : ImpersonationSearchBase
    {
    }

    public class ImpersonationFullTextSearch
    {
        public ImpersonationFullTextSearch() {}
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


    public partial class ImpersonationBatch : List<Impersonation> { }


}
