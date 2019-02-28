//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated by a T4 template. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when the code is regenerated.
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
    public abstract partial class CharacteristicBase : Dto<Characteristic>
    {
        public CharacteristicBase() {}

        public CharacteristicBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public CharacteristicBase(int? id) : this(DocConvert.ToInt(id)) {}

        [ApiMember(Name = nameof(DocumentSets), Description = "DocumentSet", IsRequired = false)]
        public List<Reference> DocumentSets { get; set; }
        public int? DocumentSetsCount { get; set; }


        [ApiMember(Name = nameof(Name), Description = "string", IsRequired = true)]
        public string Name { get; set; }


        [ApiMember(Name = nameof(URI), Description = "string", IsRequired = false)]
        public string URI { get; set; }


    }

    [Route("/characteristic", "POST")]
    [Route("/characteristic/{Id}", "GET, PATCH, PUT, DELETE")]
    public partial class Characteristic : CharacteristicBase, IReturn<Characteristic>, IDto
    {
        public Characteristic()
        {
            _Constructor();
        }

        public Characteristic(int? id) : base(DocConvert.ToInt(id)) {}
        public Characteristic(int id) : base(id) {}
        
        #region Fields
        
        public bool? ShouldSerialize(string field)
        {
            if (IgnoredVisibleFields.Matches(field, true)) return false;
            var ret = MandatoryVisibleFields.Matches(field, true) || true == VisibleFields?.Matches(field, true);
            return ret;
        }

        public static List<string> Fields => DocTools.Fields<Characteristic>();

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
                _VisibleFields = DocPermissionFactory.SetVisibleFields<Characteristic>("Characteristic",exists);
            }
        }

        #endregion Fields
        private List<string> _collections = new List<string>
        {
            nameof(DocumentSets), nameof(DocumentSetsCount)
        };
        private List<string> collections { get { return _collections; } }
    }
    
    [Route("/Characteristic/{Id}/copy", "POST")]
    public partial class CharacteristicCopy : Characteristic {}
    public partial class CharacteristicSearchBase : Search<Characteristic>
    {
        public int? Id { get; set; }
        public List<int> DocumentSetsIds { get; set; }
        public string Name { get; set; }
        public string URI { get; set; }
    }

    [Route("/characteristic", "GET")]
    [Route("/characteristic/version", "GET, POST")]
    [Route("/characteristic/search", "GET, POST, DELETE")]
    public partial class CharacteristicSearch : CharacteristicSearchBase
    {
    }

    public class CharacteristicFullTextSearch
    {
        public CharacteristicFullTextSearch() {}
        private CharacteristicSearch _request;
        public CharacteristicFullTextSearch(CharacteristicSearch request) => _request = request;

        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Characteristic.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Characteristic.Updated))); }

        public bool doDocumentSets { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Characteristic.DocumentSets))); }
        public bool doName { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Characteristic.Name))); }
        public bool doURI { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Characteristic.URI))); }
    }

    [Route("/characteristic/batch", "DELETE, PATCH, POST, PUT")]
    public partial class CharacteristicBatch : List<Characteristic> { }

    [Route("/characteristic/{Id}/{Junction}/version", "GET, POST")]
    [Route("/characteristic/{Id}/{Junction}", "GET, POST, DELETE")]
    public class CharacteristicJunction : CharacteristicSearchBase {}


}
