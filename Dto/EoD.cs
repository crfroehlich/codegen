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
    public abstract partial class EoDBase : TaskBase
    {
        public EoDBase() {}

        public EoDBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public EoDBase(int? id) : this(DocConvert.ToInt(id)) {}

        public EoDBase(int? pId, Reference pDocument, int? pDocumentId, EoDStatusEnm? pStatus) : this(DocConvert.ToInt(pId)) 
        {
            Document = pDocument;
            DocumentId = pDocumentId;
            Status = pStatus;
        }

        [ApiMember(Name = nameof(Document), Description = "Document", IsRequired = false)]
        public Reference Document { get; set; }
        [ApiMember(Name = nameof(DocumentId), Description = "Primary Key of Document", IsRequired = false)]
        public int? DocumentId { get; set; }


        [ApiAllowableValues("Includes", Values = new string[] {@"Accepted",@"Collected",@"Rejected",@"Requested",@"Unavailable"})]
        [ApiMember(Name = nameof(Status), Description = "EoDStatusEnm?", IsRequired = false)]
        public EoDStatusEnm? Status { get; set; }



        public void Deconstruct(out Reference pDocument, out int? pDocumentId, out EoDStatusEnm? pStatus)
        {
            pDocument = Document;
            pDocumentId = DocumentId;
            pStatus = Status;
        }

        //Not ready until C# v8.?
        //public EoDBase With(int? pId = Id, Reference pDocument = Document, int? pDocumentId = DocumentId, EoDStatusEnm? pStatus = Status) => 
        //	new EoDBase(pId, pDocument, pDocumentId, pStatus);

    }

    [Route("/eod", "POST")]
    [Route("/eod/{Id}", "GET, PATCH, PUT, DELETE")]
    public partial class EoD : EoDBase, IReturn<EoD>, IDto, ICloneable
    {
        public EoD()
        {
            _Constructor();
        }

        public EoD(int? id) : base(DocConvert.ToInt(id)) {}
        public EoD(int id) : base(id) {}
        public EoD(int? pId, Reference pDocument, int? pDocumentId, EoDStatusEnm? pStatus) : 
            base(pId, pDocument, pDocumentId, pStatus) { }
        #region Fields

        public new bool? ShouldSerialize(string field)
        {
            //Allow individual classes to specify their own logic
            var manualOverride = _ShouldSerialize(field);
            if(null != manualOverride) return manualOverride;

            if (IgnoredSelect.Matches(field, true)) return false;
            var ret = MandatorySelect.Matches(field, true) || true == Select?.Matches(field, true);
            return ret;
        }

        public static List<string> Fields => DocTools.Fields<EoD>();

        private List<string> _Select;
        [ApiMember(Name = "Select", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Created),nameof(CreatorId),nameof(Document),nameof(DocumentId),nameof(Gestalt),nameof(Locked),nameof(Status),nameof(Updated),nameof(VersionNo)})]
        public new List<string> Select
        {
            get
            {
                if(null == this) return new List<string>();
                if(null == _Select)
                {
                    _Select = DocWebSession.GetTypeSelect(this);
                }
                return _Select;
            }
            set
            {
                var requested = value ?? new List<string>();
                var exists = requested.Where( r => Fields.Any( f => DocTools.AreEqual(r, f) ) ).ToList();
                _Select = DocPermissionFactory.SetSelect<EoD>("EoD",exists);
            }
        }

        #endregion Fields

        public object Clone() => this.Copy<EoD>();
        public static explicit operator Task(EoD dto) => DocTransmogrify<EoD, Task>.ToNewObject(dto);
        public static explicit operator EoD(Task dto) => DocTransmogrify<Task, EoD>.ToNewObject(dto);
    }
    
    [Route("/eod/{Id}/copy", "POST")]
    public partial class EoDCopy : EoD {}
    public partial class EoDSearchBase : Search<EoD>
    {
        public int? Id { get; set; }
        public Reference Document { get; set; }
        public List<int> DocumentIds { get; set; }
        public EoDStatusEnm? Status { get; set; }
    }

    [Route("/eod", "GET")]
    [Route("/eod/version", "GET, POST")]
    [Route("/eod/search", "GET, POST, DELETE")]
    public partial class EoDSearch : EoDSearchBase
    {
    }

    public class EoDFullTextSearch
    {
        public EoDFullTextSearch() {}
        private EoDSearch _request;
        public EoDFullTextSearch(EoDSearch request) => _request = request;

        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(EoD.Created))); }
        public bool doUpdated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(EoD.Updated))); }

        public bool doDocument { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(EoD.Document))); }
        public bool doStatus { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(EoD.Status))); }
    }

    [Route("/eod/batch", "DELETE, PATCH, POST, PUT")]
    public partial class EoDBatch : List<EoD> { }

}
