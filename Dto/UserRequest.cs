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
    public abstract partial class UserRequestBase : Dto<UserRequest>
    {
        public UserRequestBase() {}

        public UserRequestBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public UserRequestBase(int? id) : this(DocConvert.ToInt(id)) {}
    
        [ApiMember(Name = nameof(Method), Description = "string", IsRequired = false)]
        public string Method { get; set; }


        [ApiMember(Name = nameof(Path), Description = "string", IsRequired = false)]
        public string Path { get; set; }


        [ApiMember(Name = nameof(UserSession), Description = "UserSession", IsRequired = true)]
        public Reference UserSession { get; set; }
        [ApiMember(Name = nameof(UserSessionId), Description = "Primary Key of UserSession", IsRequired = false)]
        public int? UserSessionId { get; set; }


    }

    [Route("/userrequest/{Id}", "GET")]
    [Route("/profile/userrequest/{Id}", "GET")]
    public partial class UserRequest : UserRequestBase, IReturn<UserRequest>, IDto
    {
        public UserRequest()
        {
            _Constructor();
        }

        public UserRequest(int? id) : base(DocConvert.ToInt(id)) {}
        public UserRequest(int id) : base(id) {}
        
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

        public static List<string> Fields => DocTools.Fields<UserRequest>();

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Created),nameof(CreatorId),nameof(Gestalt),nameof(Locked),nameof(Method),nameof(Path),nameof(Updated),nameof(UserSession),nameof(UserSessionId),nameof(VersionNo)})]
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
                _VisibleFields = DocPermissionFactory.SetVisibleFields<UserRequest>("UserRequest",exists);
            }
        }

        #endregion Fields
    }
    
    [Route("/userrequest", "GET")]
    [Route("/profile/userrequest", "GET")]
    [Route("/userrequest/search", "GET, POST, DELETE")]
    [Route("/profile/userrequest/search", "GET, POST, DELETE")]
    public partial class UserRequestSearch : Search<UserRequest>
    {
        public string Method { get; set; }
        public string Path { get; set; }
        public Reference UserSession { get; set; }
        public List<int> UserSessionIds { get; set; }
    }
    
    public class UserRequestFullTextSearch
    {
        private UserRequestSearch _request;
        public UserRequestFullTextSearch(UserRequestSearch request) => _request = request;
        
        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(UserRequest.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(UserRequest.Updated))); }
        
        public bool doMethod { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(UserRequest.Method))); }
        public bool doPath { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(UserRequest.Path))); }
        public bool doUserSession { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(UserRequest.UserSession))); }
    }

    [Route("/userrequest/version", "GET, POST")]
    public partial class UserRequestVersion : UserRequestSearch {}

    [Route("/userrequest/batch", "DELETE, PATCH, POST, PUT")]
    [Route("/profile/userrequest/batch", "DELETE, PATCH, POST, PUT")]
    public partial class UserRequestBatch : List<UserRequest> { }

    [Route("/admin/userrequest/ids", "GET, POST")]
    public class UserRequestIds
    {
        public bool All { get; set; }
    }
}