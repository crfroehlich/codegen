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
    public abstract partial class DateTimeBase : Dto<DateTimeDto>
    {
        public DateTimeBase() {}

        public DateTimeBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public DateTimeBase(int? id) : this(DocConvert.ToInt(id)) {}

        [ApiMember(Name = nameof(DateDay), Description = "int?", IsRequired = false)]
        public int? DateDay { get; set; }


        [ApiMember(Name = nameof(DateMonth), Description = "int?", IsRequired = false)]
        public int? DateMonth { get; set; }


        [ApiMember(Name = nameof(DateTime), Description = "DateTime?", IsRequired = false)]
        public DateTime? DateTime { get; set; }


        [ApiMember(Name = nameof(DateYear), Description = "int?", IsRequired = false)]
        public int? DateYear { get; set; }


    }

    [Route("/datetime", "POST")]
    [Route("/datetime/{Id}", "GET, PATCH, PUT, DELETE")]
    public partial class DateTimeDto : DateTimeBase, IReturn<DateTimeDto>, IDto
    {
        public DateTimeDto()
        {
            _Constructor();
        }

        public DateTimeDto(int? id) : base(DocConvert.ToInt(id)) {}
        public DateTimeDto(int id) : base(id) {}
        
        #region Fields
        
        public bool? ShouldSerialize(string field)
        {
            if (IgnoredVisibleFields.Matches(field, true)) return false;
            var ret = MandatoryVisibleFields.Matches(field, true) || true == VisibleFields?.Matches(field, true);
            return ret;
        }

        public static List<string> Fields => DocTools.Fields<DateTimeDto>();

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Created),nameof(CreatorId),nameof(DateDay),nameof(DateMonth),nameof(DateTime),nameof(DateYear),nameof(Gestalt),nameof(Locked),nameof(Updated),nameof(VersionNo)})]
        public new List<string> VisibleFields
        {
            get
            {
                if(null == this) return new List<string>();
                if(null == _VisibleFields)
                {
                    _VisibleFields = DocPermissionFactory.RemoveNonEssentialFields(Fields);
                }
                return _VisibleFields;
            }
            set
            {
                _VisibleFields = Fields;
            }
        }

        #endregion Fields
    }
    
    [Route("/DateTime/{Id}/copy", "POST")]
    public partial class DateTimeDtoCopy : DateTimeDto {}
    public partial class DateTimeSearchBase : Search<DateTimeDto>
    {
        public int? Id { get; set; }
        public int? DateDay { get; set; }
        public int? DateMonth { get; set; }
        public DateTime? DateTime { get; set; }
        public DateTime? DateTimeAfter { get; set; }
        public DateTime? DateTimeBefore { get; set; }
        public int? DateYear { get; set; }
    }

    [Route("/datetime", "GET")]
    [Route("/datetime/version", "GET, POST")]
    [Route("/datetime/search", "GET, POST, DELETE")]
    public partial class DateTimeSearch : DateTimeSearchBase
    {
    }

    public class DateTimeFullTextSearch
    {
        public DateTimeFullTextSearch() {}
        private DateTimeSearch _request;
        public DateTimeFullTextSearch(DateTimeSearch request) => _request = request;

        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DateTimeDto.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DateTimeDto.Updated))); }

        public bool doDateDay { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DateTimeDto.DateDay))); }
        public bool doDateMonth { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DateTimeDto.DateMonth))); }
        public bool doDateTime { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DateTimeDto.DateTime))); }
        public bool doDateYear { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DateTimeDto.DateYear))); }
    }

    [Route("/datetime/batch", "DELETE, PATCH, POST, PUT")]
    public partial class DateTimeBatch : List<DateTimeDto> { }

}
