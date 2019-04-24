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
    public abstract partial class AuditDeltaBase : Dto<AuditDelta>
    {
        public AuditDeltaBase() {}

        public AuditDeltaBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public AuditDeltaBase(int? id) : this(DocConvert.ToInt(id)) {}

        public AuditDeltaBase(int? pId, Reference pAudit, int? pAuditId, string pDelta) : this(DocConvert.ToInt(pId)) 
        {
            Audit = pAudit;
            AuditId = pAuditId;
            Delta = pDelta;
        }

        [ApiMember(Name = nameof(Audit), Description = "AuditRecord", IsRequired = true)]
        public Reference Audit { get; set; }
        [ApiMember(Name = nameof(AuditId), Description = "Primary Key of AuditRecord", IsRequired = false)]
        public int? AuditId { get; set; }


        [ApiMember(Name = nameof(Delta), Description = "string", IsRequired = true)]
        public string Delta { get; set; }



        public void Deconstruct(out Reference pAudit, out int? pAuditId, out string pDelta)
        {
            pAudit = Audit;
            pAuditId = AuditId;
            pDelta = Delta;
        }

        //Not ready until C# v8.?
        //public AuditDeltaBase With(int? pId = Id, Reference pAudit = Audit, int? pAuditId = AuditId, string pDelta = Delta) => 
        //	new AuditDeltaBase(pId, pAudit, pAuditId, pDelta);

    }

    [Route("/auditdelta", "POST")]
    [Route("/auditdelta/{Id}", "GET")]
    public partial class AuditDelta : AuditDeltaBase, IReturn<AuditDelta>, IDto, ICloneable
    {
        public AuditDelta()
        {
            _Constructor();
        }

        public AuditDelta(int? id) : base(DocConvert.ToInt(id)) {}
        public AuditDelta(int id) : base(id) {}
        public AuditDelta(int? pId, Reference pAudit, int? pAuditId, string pDelta) : 
            base(pId, pAudit, pAuditId, pDelta) { }
        #region Fields

        public new bool? ShouldSerialize(string field)
        {
            //Allow individual classes to specify their own logic
            var manualOverride = _ShouldSerialize(field);
            if(null != manualOverride) return manualOverride;

            if (IgnoredVisibleFields.Matches(field, true)) return false;
            var ret = MandatoryVisibleFields.Matches(field, true) || true == VisibleFields?.Matches(field, true);
            return ret;
        }

        public static List<string> Fields => DocTools.Fields<AuditDelta>();

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Audit),nameof(AuditId),nameof(Created),nameof(CreatorId),nameof(Delta),nameof(Gestalt),nameof(Locked),nameof(Updated),nameof(VersionNo)})]
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
                _VisibleFields = DocPermissionFactory.SetVisibleFields<AuditDelta>("AuditDelta",exists);
            }
        }

        #endregion Fields

        public object Clone() => this.Copy<AuditDelta>();
    }
    
    [Route("/auditdelta/{Id}/copy", "POST")]
    public partial class AuditDeltaCopy : AuditDelta {}
    public partial class AuditDeltaSearchBase : Search<AuditDelta>
    {
        public int? Id { get; set; }
        public Reference Audit { get; set; }
        public List<int> AuditIds { get; set; }
        public string Delta { get; set; }
    }

    [Route("/auditdelta", "GET")]
    [Route("/auditdelta/version", "GET, POST")]
    [Route("/auditdelta/search", "GET, POST, DELETE")]
    public partial class AuditDeltaSearch : AuditDeltaSearchBase
    {
    }

    public class AuditDeltaFullTextSearch
    {
        public AuditDeltaFullTextSearch() {}
        private AuditDeltaSearch _request;
        public AuditDeltaFullTextSearch(AuditDeltaSearch request) => _request = request;

        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(AuditDelta.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(AuditDelta.Updated))); }

        public bool doAudit { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(AuditDelta.Audit))); }
        public bool doDelta { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(AuditDelta.Delta))); }
    }

    [Route("/auditdelta/batch", "DELETE, PATCH, POST, PUT")]
    public partial class AuditDeltaBatch : List<AuditDelta> { }

}
