
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
    public abstract partial class InterventionBase : Dto<Intervention>
    {
        public InterventionBase() {}

        public InterventionBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public InterventionBase(int? id) : this(DocConvert.ToInt(id)) {}

        public InterventionBase(int? pId, List<Reference> pDocumentSets, int? pDocumentSetsCount, string pName, string pURI) : this(DocConvert.ToInt(pId)) 
        {
            DocumentSets = pDocumentSets;
            DocumentSetsCount = pDocumentSetsCount;
            Name = pName;
            URI = pURI;
        }

        [ApiMember(Name = nameof(DocumentSets), Description = "DocumentSet", IsRequired = false)]
        public List<Reference> DocumentSets { get; set; }
        public List<int> DocumentSetsIds { get; set; }
        public int? DocumentSetsCount { get; set; }


        [ApiMember(Name = nameof(Name), Description = "string", IsRequired = true)]
        public string Name { get; set; }


        [ApiMember(Name = nameof(URI), Description = "string", IsRequired = false)]
        public string URI { get; set; }



        public void Deconstruct(out List<Reference> pDocumentSets, out int? pDocumentSetsCount, out string pName, out string pURI)
        {
            pDocumentSets = DocumentSets;
            pDocumentSetsCount = DocumentSetsCount;
            pName = Name;
            pURI = URI;
        }

        //Not ready until C# v8.?
        //public InterventionBase With(int? pId = Id, List<Reference> pDocumentSets = DocumentSets, int? pDocumentSetsCount = DocumentSetsCount, string pName = Name, string pURI = URI) => 
        //	new InterventionBase(pId, pDocumentSets, pDocumentSetsCount, pName, pURI);

    }


    [Route("/intervention", "POST")]
    [Route("/intervention/{Id}", "GET, PATCH, PUT, DELETE")]

    public partial class Intervention : InterventionBase, IReturn<Intervention>, IDto, ICloneable
    {
        public Intervention()
        {
            _Constructor();
        }

        public Intervention(int? id) : base(DocConvert.ToInt(id)) {}
        public Intervention(int id) : base(id) {}
        public Intervention(int? pId, List<Reference> pDocumentSets, int? pDocumentSetsCount, string pName, string pURI) : 
            base(pId, pDocumentSets, pDocumentSetsCount, pName, pURI) { }
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

        public static List<string> Fields => DocTools.Fields<Intervention>();

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Created),nameof(CreatorId),nameof(DocumentSets),nameof(DocumentSetsCount),nameof(Gestalt),nameof(Locked),nameof(Name),nameof(Updated),nameof(URI),nameof(VersionNo)})]
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
                _VisibleFields = DocPermissionFactory.SetVisibleFields<Intervention>("Intervention",exists);

            }
        }

        #endregion Fields

        private List<string> _collections = new List<string>
        {
            nameof(DocumentSets), nameof(DocumentSetsCount)
        };
        private List<string> collections { get { return _collections; } }


        public object Clone() => this.Copy<Intervention>();
    }
    

    [Route("/intervention/{Id}/copy", "POST")]
    public partial class InterventionCopy : Intervention {}

    public partial class InterventionSearchBase : Search<Intervention>
    {
        public int? Id { get; set; }
        public List<int> DocumentSetsIds { get; set; }
        public string Name { get; set; }
        public string URI { get; set; }
    }


    [Route("/intervention", "GET")]
    [Route("/intervention/version", "GET, POST")]
    [Route("/intervention/search", "GET, POST, DELETE")]

    public partial class InterventionSearch : InterventionSearchBase
    {
    }

    public class InterventionFullTextSearch
    {
        public InterventionFullTextSearch() {}
        private InterventionSearch _request;
        public InterventionFullTextSearch(InterventionSearch request) => _request = request;

        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Intervention.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Intervention.Updated))); }

        public bool doDocumentSets { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Intervention.DocumentSets))); }
        public bool doName { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Intervention.Name))); }
        public bool doURI { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Intervention.URI))); }
    }


    [Route("/intervention/batch", "DELETE, PATCH, POST, PUT")]

    public partial class InterventionBatch : List<Intervention> { }


    [Route("/intervention/{Id}/{Junction}/version", "GET, POST")]
    [Route("/intervention/{Id}/{Junction}", "GET, POST, DELETE")]
    public class InterventionJunction : InterventionSearchBase {}



}
