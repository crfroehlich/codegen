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
    public abstract partial class UserRequestBase : Dto<UserRequest>
    {
        public UserRequestBase() {}

        public UserRequestBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public UserRequestBase(int? id) : this(DocConvert.ToInt(id)) {}

        [ApiMember(Name = nameof(App), Description = "App", IsRequired = false)]
        public Reference App { get; set; }
        [ApiMember(Name = nameof(AppId), Description = "Primary Key of App", IsRequired = false)]
        public int? AppId { get; set; }


        [ApiMember(Name = nameof(Method), Description = "string", IsRequired = false)]
        public string Method { get; set; }


        [ApiMember(Name = nameof(Page), Description = "Page", IsRequired = false)]
        public Reference Page { get; set; }
        [ApiMember(Name = nameof(PageId), Description = "Primary Key of Page", IsRequired = false)]
        public int? PageId { get; set; }


        [ApiMember(Name = nameof(Path), Description = "string", IsRequired = false)]
        public string Path { get; set; }


        [ApiMember(Name = nameof(URL), Description = "string", IsRequired = false)]
        public string URL { get; set; }


        [ApiMember(Name = nameof(UserSession), Description = "UserSession", IsRequired = true)]
        public Reference UserSession { get; set; }
        [ApiMember(Name = nameof(UserSessionId), Description = "Primary Key of UserSession", IsRequired = false)]
        public int? UserSessionId { get; set; }


    }

    [Route("/userrequest/{Id}", "GET")]
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
            if (IgnoredVisibleFields.Matches(field, true)) return false;
            var ret = MandatoryVisibleFields.Matches(field, true) || true == VisibleFields?.Matches(field, true);
            return ret;
        }

        public static List<string> Fields => DocTools.Fields<UserRequest>();

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(App),nameof(AppId),nameof(Created),nameof(CreatorId),nameof(Gestalt),nameof(Locked),nameof(Method),nameof(Page),nameof(PageId),nameof(Path),nameof(Updated),nameof(URL),nameof(UserSession),nameof(UserSessionId),nameof(VersionNo)})]
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
    
    public partial class UserRequestSearchBase : Search<UserRequest>
    {
        public int? Id { get; set; }
        public Reference App { get; set; }
        public List<int> AppIds { get; set; }
        public string Method { get; set; }
        public Reference Page { get; set; }
        public List<int> PageIds { get; set; }
        public string Path { get; set; }
        public string URL { get; set; }
        public Reference UserSession { get; set; }
        public List<int> UserSessionIds { get; set; }
    }

    [Route("/userrequest", "GET")]
    [Route("/userrequest/version", "GET, POST")]
    [Route("/userrequest/search", "GET, POST, DELETE")]
    public partial class UserRequestSearch : UserRequestSearchBase
    {
    }

    public class UserRequestFullTextSearch
    {
        public UserRequestFullTextSearch() {}
        private UserRequestSearch _request;
        public UserRequestFullTextSearch(UserRequestSearch request) => _request = request;

        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(UserRequest.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(UserRequest.Updated))); }

        public bool doApp { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(UserRequest.App))); }
        public bool doMethod { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(UserRequest.Method))); }
        public bool doPage { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(UserRequest.Page))); }
        public bool doPath { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(UserRequest.Path))); }
        public bool doURL { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(UserRequest.URL))); }
        public bool doUserSession { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(UserRequest.UserSession))); }
    }

    public partial class UserRequestBatch : List<UserRequest> { }

}