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
    public abstract partial class ReleaseStatusBase : Dto<ReleaseStatus>
    {
        public ReleaseStatusBase() {}

        public ReleaseStatusBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public ReleaseStatusBase(int? id) : this(DocConvert.ToInt(id)) {}

        public ReleaseStatusBase(int? pId, string pBranch, string pRelease, string pServer, string pURL, string pVersion) : this(DocConvert.ToInt(pId)) 
        {
            Branch = pBranch;
            Release = pRelease;
            Server = pServer;
            URL = pURL;
            Version = pVersion;
        }

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



        public void Deconstruct(out string pBranch, out string pRelease, out string pServer, out string pURL, out string pVersion)
        {
            pBranch = Branch;
            pRelease = Release;
            pServer = Server;
            pURL = URL;
            pVersion = Version;
        }

        //Not ready until C# v8.?
        //public ReleaseStatusBase With(int? pId = Id, string pBranch = Branch, string pRelease = Release, string pServer = Server, string pURL = URL, string pVersion = Version) => 
        //	new ReleaseStatusBase(pId, pBranch, pRelease, pServer, pURL, pVersion);

    }

    [Route("/releasestatus", "POST")]
    [Route("/releasestatus/{Id}", "GET, PATCH, PUT, DELETE")]
    public partial class ReleaseStatus : ReleaseStatusBase, IReturn<ReleaseStatus>, IDto, ICloneable
    {
        public ReleaseStatus()
        {
            _Constructor();
        }

        public ReleaseStatus(int? id) : base(DocConvert.ToInt(id)) {}
        public ReleaseStatus(int id) : base(id) {}
        public ReleaseStatus(int? pId, string pBranch, string pRelease, string pServer, string pURL, string pVersion) : 
            base(pId, pBranch, pRelease, pServer, pURL, pVersion) { }
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

        public object Clone() => this.Copy<ReleaseStatus>();
    }
    
    [Route("/releasestatus/{Id}/copy", "POST")]
    public partial class ReleaseStatusCopy : ReleaseStatus {}
    public partial class ReleaseStatusSearchBase : Search<ReleaseStatus>
    {
        public int? Id { get; set; }
        public string Branch { get; set; }
        public string Release { get; set; }
        public string Server { get; set; }
        public string URL { get; set; }
        public string Version { get; set; }
    }

    [Route("/releasestatus", "GET")]
    [Route("/releasestatus/version", "GET, POST")]
    [Route("/releasestatus/search", "GET, POST, DELETE")]
    public partial class ReleaseStatusSearch : ReleaseStatusSearchBase
    {
    }

    public class ReleaseStatusFullTextSearch
    {
        public ReleaseStatusFullTextSearch() {}
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

    [Route("/releasestatus/batch", "DELETE, PATCH, POST, PUT")]
    public partial class ReleaseStatusBatch : List<ReleaseStatus> { }

}
