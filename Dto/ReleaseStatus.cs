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
    public abstract partial class ReleaseStatusBase : Dto<ReleaseStatus>
    {
        public ReleaseStatusBase() {}

        public ReleaseStatusBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public ReleaseStatusBase(int? id) : this(DocConvert.ToInt(id)) {}
    
        [ApiMember(Name = nameof(Branch), Description = "string", IsRequired = true)]
        public string Branch { get; set; }


        [ApiMember(Name = nameof(Release), Description = "string", IsRequired = true)]
        public string Release { get; set; }


        [ApiMember(Name = nameof(Server), Description = "string", IsRequired = true)]
        public string Server { get; set; }


        [ApiMember(Name = nameof(URL), Description = "string", IsRequired = true)]
        public string URL { get; set; }


        [ApiMember(Name = nameof(Version), Description = "string", IsRequired = true)]
        public string Version { get; set; }


    }

    [Route("/releasestatus", "POST")]
    [Route("/profile/releasestatus", "POST")]
    [Route("/releasestatus/{Id}", "GET, PATCH, PUT, DELETE")]
    [Route("/profile/releasestatus/{Id}", "GET, PATCH, PUT, DELETE")]
    public partial class ReleaseStatus : ReleaseStatusBase, IReturn<ReleaseStatus>, IDto
    {
        public ReleaseStatus()
        {
            _Constructor();
        }

        public ReleaseStatus(int? id) : base(DocConvert.ToInt(id)) {}
        public ReleaseStatus(int id) : base(id) {}
        
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

        public static List<string> Fields => DocTools.Fields<ReleaseStatus>();

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Branch),nameof(Created),nameof(CreatorId),nameof(Gestalt),nameof(Locked),nameof(Release),nameof(Server),nameof(Updated),nameof(URL),nameof(Version),nameof(VersionNo)})]
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
                _VisibleFields = DocPermissionFactory.SetVisibleFields<ReleaseStatus>("ReleaseStatus",exists);
            }
        }

        #endregion Fields
    }
    
    [Route("/ReleaseStatus/{Id}/copy", "POST")]
    [Route("/profile/ReleaseStatus/{Id}/copy", "POST")]
    public partial class ReleaseStatusCopy : ReleaseStatus {}
    [Route("/releasestatus", "GET")]
    [Route("/profile/releasestatus", "GET")]
    [Route("/releasestatus/search", "GET, POST, DELETE")]
    [Route("/profile/releasestatus/search", "GET, POST, DELETE")]
    public partial class ReleaseStatusSearch : Search<ReleaseStatus>
    {
        public string Branch { get; set; }
        public string Release { get; set; }
        public string Server { get; set; }
        public string URL { get; set; }
        public string Version { get; set; }
    }
    
    public class ReleaseStatusFullTextSearch
    {
        private ReleaseStatusSearch _request;
        public ReleaseStatusFullTextSearch(ReleaseStatusSearch request) => _request = request;
        
        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(ReleaseStatus.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(ReleaseStatus.Updated))); }
        
        public bool doBranch { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(ReleaseStatus.Branch))); }
        public bool doRelease { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(ReleaseStatus.Release))); }
        public bool doServer { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(ReleaseStatus.Server))); }
        public bool doURL { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(ReleaseStatus.URL))); }
        public bool doVersion { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(ReleaseStatus.Version))); }
    }

    [Route("/releasestatus/version", "GET, POST")]
    public partial class ReleaseStatusVersion : ReleaseStatusSearch {}

    [Route("/releasestatus/batch", "DELETE, PATCH, POST, PUT")]
    [Route("/profile/releasestatus/batch", "DELETE, PATCH, POST, PUT")]
    public partial class ReleaseStatusBatch : List<ReleaseStatus> { }

    [Route("/admin/releasestatus/ids", "GET, POST")]
    public class ReleaseStatusIds
    {
        public bool All { get; set; }
    }
}