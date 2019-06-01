
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
    public abstract partial class TherapeuticAreaSetBase : DocumentSetBase
    {
        public TherapeuticAreaSetBase() {}

        public TherapeuticAreaSetBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public TherapeuticAreaSetBase(int? id) : this(DocConvert.ToInt(id)) {}

        public TherapeuticAreaSetBase(int? pId, bool isDummyParam) : this(DocConvert.ToInt(pId)) 
        {

        }



        public void Deconstruct(bool isDummyParam)
        {

        }

        //Not ready until C# v8.?
        //public TherapeuticAreaSetBase With(int? pId = Id, ) => 
        //	new TherapeuticAreaSetBase(pId, isDummyParam);

    }


    [Route("/therapeuticareaset", "POST")]
    [Route("/therapeuticareaset/{Id}", "GET, PATCH, PUT, DELETE")]

    public partial class TherapeuticAreaSet : TherapeuticAreaSetBase, IReturn<TherapeuticAreaSet>, IDto, ICloneable
    {
        public TherapeuticAreaSet()
        {
            _Constructor();
        }

        public TherapeuticAreaSet(int? id) : base(DocConvert.ToInt(id)) {}
        public TherapeuticAreaSet(int id) : base(id) {}
        public TherapeuticAreaSet(int? pId, bool isDummyParam) : 
            base(pId, isDummyParam) { }
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

        public static List<string> Fields => DocTools.Fields<TherapeuticAreaSet>();

        private List<string> _Select;
        [ApiMember(Name = "Select", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Created),nameof(CreatorId),nameof(Gestalt),nameof(Locked),nameof(Updated),nameof(VersionNo)})]
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
                _Select = DocPermissionFactory.SetSelect<TherapeuticAreaSet>("TherapeuticAreaSet",exists);

            }
        }

        #endregion Fields


        public object Clone() => this.Copy<TherapeuticAreaSet>();

        public static explicit operator DocumentSet(TherapeuticAreaSet dto) => DocTransmogrify<TherapeuticAreaSet, DocumentSet>.ToNewObject(dto);
        public static explicit operator TherapeuticAreaSet(DocumentSet dto) => DocTransmogrify<DocumentSet, TherapeuticAreaSet>.ToNewObject(dto);

    }
    

    [Route("/therapeuticareaset/{Id}/copy", "POST")]
    public partial class TherapeuticAreaSetCopy : TherapeuticAreaSet {}

    public partial class TherapeuticAreaSetSearchBase : Search<TherapeuticAreaSet>
    {
        public int? Id { get; set; }
        public List<int> ClientsIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {"true", "false"})]
        public List<bool> Confidential { get; set; }
        public List<int> DivisionsIds { get; set; }
        public List<int> DocumentsIds { get; set; }
        public List<int> DocumentSetsIds { get; set; }
        public List<int> HistoriesIds { get; set; }
        public int? LegacyDocumentSetId { get; set; }
        public string Name { get; set; }
        public Reference Owner { get; set; }
        public List<int> OwnerIds { get; set; }
        public Reference ProjectTeam { get; set; }
        public List<int> ProjectTeamIds { get; set; }
        public List<int> ScopesIds { get; set; }
        public string Settings { get; set; }
        public List<int> StatsIds { get; set; }
        public DocumentSetTypeEnm? Type { get; set; }
        public List<int> UsersIds { get; set; }
    }


    [Route("/therapeuticareaset", "GET")]
    [Route("/therapeuticareaset/version", "GET, POST")]
    [Route("/therapeuticareaset/search", "GET, POST, DELETE")]

    public partial class TherapeuticAreaSetSearch : TherapeuticAreaSetSearchBase
    {
    }

    public class TherapeuticAreaSetFullTextSearch
    {
        public TherapeuticAreaSetFullTextSearch() {}
        private TherapeuticAreaSetSearch _request;
        public TherapeuticAreaSetFullTextSearch(TherapeuticAreaSetSearch request) => _request = request;

        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(TherapeuticAreaSet.Created))); }
        public bool doUpdated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(TherapeuticAreaSet.Updated))); }


    }


    [Route("/therapeuticareaset/batch", "DELETE, PATCH, POST, PUT")]

    public partial class TherapeuticAreaSetBatch : List<TherapeuticAreaSet> { }


}
