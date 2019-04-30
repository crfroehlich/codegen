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
    public abstract partial class RatingBase : TaskBase
    {
        public RatingBase() {}

        public RatingBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public RatingBase(int? id) : this(DocConvert.ToInt(id)) {}

        public RatingBase(int? pId, Reference pDocument, int? pDocumentId, RatingEnm? pRating) : this(DocConvert.ToInt(pId)) 
        {
            Document = pDocument;
            DocumentId = pDocumentId;
            Rating = pRating;
        }

        [ApiMember(Name = nameof(Document), Description = "Document", IsRequired = false)]
        public Reference Document { get; set; }
        [ApiMember(Name = nameof(DocumentId), Description = "Primary Key of Document", IsRequired = false)]
        public int? DocumentId { get; set; }


        [ApiMember(Name = nameof(Rating), Description = "RatingEnm?", IsRequired = false)]
        public RatingEnm? Rating { get; set; }



        public void Deconstruct(out Reference pDocument, out int? pDocumentId, out RatingEnm? pRating)
        {
            pDocument = Document;
            pDocumentId = DocumentId;
            pRating = Rating;
        }

        //Not ready until C# v8.?
        //public RatingBase With(int? pId = Id, Reference pDocument = Document, int? pDocumentId = DocumentId, RatingEnm? pRating = Rating) => 
        //	new RatingBase(pId, pDocument, pDocumentId, pRating);

    }

    [Route("/rating", "POST")]
    [Route("/rating/{Id}", "GET, PATCH, PUT, DELETE")]
    public partial class Rating : RatingBase, IReturn<Rating>, IDto, ICloneable
    {
        public Rating()
        {
            _Constructor();
        }

        public Rating(int? id) : base(DocConvert.ToInt(id)) {}
        public Rating(int id) : base(id) {}
        public Rating(int? pId, Reference pDocument, int? pDocumentId, RatingEnm? pRating) : 
            base(pId, pDocument, pDocumentId, pRating) { }
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

        public static List<string> Fields => DocTools.Fields<Rating>();

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Created),nameof(CreatorId),nameof(Document),nameof(DocumentId),nameof(Gestalt),nameof(Locked),nameof(Rating),nameof(Updated),nameof(VersionNo)})]
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
                _VisibleFields = DocPermissionFactory.SetVisibleFields<Rating>("Rating",exists);
            }
        }

        #endregion Fields

        public object Clone() => this.Copy<Rating>();
        public static explicit operator Task(Rating dto) => DocTransmogrify<Rating, Task>.ToNewObject(dto);
        public static explicit operator Rating(Task dto) => DocTransmogrify<Task, Rating>.ToNewObject(dto);
    }
    
    [Route("/rating/{Id}/copy", "POST")]
    public partial class RatingCopy : Rating {}
    public partial class RatingSearchBase : Search<Rating>
    {
        public int? Id { get; set; }
        public Reference Document { get; set; }
        public List<int> DocumentIds { get; set; }
        public RatingEnm? Rating { get; set; }
    }

    [Route("/rating", "GET")]
    [Route("/rating/version", "GET, POST")]
    [Route("/rating/search", "GET, POST, DELETE")]
    public partial class RatingSearch : RatingSearchBase
    {
    }

    public class RatingFullTextSearch
    {
        public RatingFullTextSearch() {}
        private RatingSearch _request;
        public RatingFullTextSearch(RatingSearch request) => _request = request;

        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Rating.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Rating.Updated))); }

        public bool doDocument { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Rating.Document))); }
        public bool doRating { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Rating.Rating))); }
    }

    [Route("/rating/batch", "DELETE, PATCH, POST, PUT")]
    public partial class RatingBatch : List<Rating> { }

}
