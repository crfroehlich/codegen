
//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated by a T4 template. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;

using Services.Core;
using Services.Dto.internals;
using Services.Enums;

using ServiceStack;
using ServiceStack.Text;

using Typed;
using Typed.Notifications;
using Typed.Bindings;

using Xtensive.Orm;


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

        public DateTimeBase(int? pId, int? pDateDay, int? pDateMonth, DateTime? pDateTime, int? pDateYear) : this(DocConvert.ToInt(pId)) 
        {
            DateDay = pDateDay;
            DateMonth = pDateMonth;
            DateTime = pDateTime;
            DateYear = pDateYear;
        }

        [ApiMember(Name = nameof(DateDay), Description = "int?", IsRequired = false)]
        public int? DateDay { get; set; }


        [ApiMember(Name = nameof(DateMonth), Description = "int?", IsRequired = false)]
        public int? DateMonth { get; set; }


        [ApiMember(Name = nameof(DateTime), Description = "DateTime?", IsRequired = false)]
        public DateTime? DateTime { get; set; }


        [ApiMember(Name = nameof(DateYear), Description = "int?", IsRequired = false)]
        public int? DateYear { get; set; }



        public void Deconstruct(out int? pDateDay, out int? pDateMonth, out DateTime? pDateTime, out int? pDateYear)
        {
            pDateDay = DateDay;
            pDateMonth = DateMonth;
            pDateTime = DateTime;
            pDateYear = DateYear;
        }

        //Not ready until C# v8.?
        //public DateTimeBase With(int? pId = Id, int? pDateDay = DateDay, int? pDateMonth = DateMonth, DateTime? pDateTime = DateTime, int? pDateYear = DateYear) => 
        //	new DateTimeBase(pId, pDateDay, pDateMonth, pDateTime, pDateYear);

    }


    [Route("/datetime", "POST")]
    [Route("/datetime/{Id}", "GET, PATCH, PUT, DELETE")]

    public partial class DateTimeDto : DateTimeBase, IReturn<DateTimeDto>, IDto, ICloneable
    {
        public DateTimeDto()
        {
            _Constructor();
        }

        public DateTimeDto(int? id) : base(DocConvert.ToInt(id)) {}
        public DateTimeDto(int id) : base(id) {}
        public DateTimeDto(int? pId, int? pDateDay, int? pDateMonth, DateTime? pDateTime, int? pDateYear) : 
            base(pId, pDateDay, pDateMonth, pDateTime, pDateYear) { }
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

        public static List<string> Fields => DocTools.Fields<DateTimeDto>();

        private List<string> _Select;
        [ApiMember(Name = nameof(Select), Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Created),nameof(CreatorId),nameof(DateDay),nameof(DateMonth),nameof(DateTime),nameof(DateYear),nameof(Gestalt),nameof(Locked),nameof(Updated),nameof(VersionNo)})]
        public override List<string> Select
        {
            get
            {
                if(null == this) return new List<string>();
                if(null == _Select)
                {

                    _Select = DocPermissionFactory.RemoveNonEssentialFields(Fields);


                }
                return _Select;
            }
            set
            {

                _Select = Fields;


            }
        }

        [Obsolete, ApiMember(Name = nameof(VisibleFields), Description = "Deprecated. Use Select instead.", AllowMultiple = true)]
        public override List<string> VisibleFields { get => Select; set => Select = value; }

        #endregion Fields


        public object Clone() => this.Copy<DateTimeDto>();

    }
    

    [Route("/datetime/{Id}/copy", "POST")]
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
        public bool doCreated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(DateTimeDto.Created))); }
        public bool doUpdated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(DateTimeDto.Updated))); }

        public bool doDateDay { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(DateTimeDto.DateDay))); }
        public bool doDateMonth { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(DateTimeDto.DateMonth))); }
        public bool doDateTime { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(DateTimeDto.DateTime))); }
        public bool doDateYear { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(DateTimeDto.DateYear))); }
    }


    [Route("/datetime/batch", "DELETE, PATCH, POST, PUT")]

    public partial class DateTimeBatch : List<DateTimeDto> { }


}
