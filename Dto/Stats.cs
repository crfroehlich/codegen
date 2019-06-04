
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
    public abstract partial class StatsBase : Dto<Stats>
    {
        public StatsBase() {}

        public StatsBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public StatsBase(int? id) : this(DocConvert.ToInt(id)) {}

        public StatsBase(int? pId, Reference pApp, int? pAppId, int? pExternalId, string pExternalType, int? pObjectId, string pObjectType, Reference pStudySetStats, int? pStudySetStatsId) : this(DocConvert.ToInt(pId)) 
        {
            App = pApp;
            AppId = pAppId;
            ExternalId = pExternalId;
            ExternalType = pExternalType;
            ObjectId = pObjectId;
            ObjectType = pObjectType;
            StudySetStats = pStudySetStats;
            StudySetStatsId = pStudySetStatsId;
        }

        [ApiMember(Name = nameof(App), Description = "App", IsRequired = true)]
        public Reference App { get; set; }
        [ApiMember(Name = nameof(AppId), Description = "Primary Key of App", IsRequired = false)]
        public int? AppId { get; set; }


        [ApiMember(Name = nameof(ExternalId), Description = "int?", IsRequired = false)]
        public int? ExternalId { get; set; }


        [ApiMember(Name = nameof(ExternalType), Description = "string", IsRequired = false)]
        public string ExternalType { get; set; }


        [ApiMember(Name = nameof(ObjectId), Description = "int?", IsRequired = true)]
        public int? ObjectId { get; set; }


        [ApiMember(Name = nameof(ObjectType), Description = "string", IsRequired = true)]
        public string ObjectType { get; set; }


        [ApiMember(Name = nameof(StudySetStats), Description = "StatsStudySet", IsRequired = false)]
        public Reference StudySetStats { get; set; }
        [ApiMember(Name = nameof(StudySetStatsId), Description = "Primary Key of StatsStudySet", IsRequired = false)]
        public int? StudySetStatsId { get; set; }



        public void Deconstruct(out Reference pApp, out int? pAppId, out int? pExternalId, out string pExternalType, out int? pObjectId, out string pObjectType, out Reference pStudySetStats, out int? pStudySetStatsId)
        {
            pApp = App;
            pAppId = AppId;
            pExternalId = ExternalId;
            pExternalType = ExternalType;
            pObjectId = ObjectId;
            pObjectType = ObjectType;
            pStudySetStats = StudySetStats;
            pStudySetStatsId = StudySetStatsId;
        }

        //Not ready until C# v8.?
        //public StatsBase With(int? pId = Id, Reference pApp = App, int? pAppId = AppId, int? pExternalId = ExternalId, string pExternalType = ExternalType, int? pObjectId = ObjectId, string pObjectType = ObjectType, Reference pStudySetStats = StudySetStats, int? pStudySetStatsId = StudySetStatsId) => 
        //	new StatsBase(pId, pApp, pAppId, pExternalId, pExternalType, pObjectId, pObjectType, pStudySetStats, pStudySetStatsId);

    }


    [Route("/stats/{Id}", "GET")]

    public partial class Stats : StatsBase, IReturn<Stats>, IDto, ICloneable
    {
        public Stats()
        {
            _Constructor();
        }

        public Stats(int? id) : base(DocConvert.ToInt(id)) {}
        public Stats(int id) : base(id) {}
        public Stats(int? pId, Reference pApp, int? pAppId, int? pExternalId, string pExternalType, int? pObjectId, string pObjectType, Reference pStudySetStats, int? pStudySetStatsId) : 
            base(pId, pApp, pAppId, pExternalId, pExternalType, pObjectId, pObjectType, pStudySetStats, pStudySetStatsId) { }
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

        public static List<string> Fields => DocTools.Fields<Stats>();

        private List<string> _Select;
        [ApiMember(Name = nameof(Select), Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(App),nameof(AppId),nameof(Created),nameof(CreatorId),nameof(ExternalId),nameof(ExternalType),nameof(Gestalt),nameof(Locked),nameof(ObjectId),nameof(ObjectType),nameof(StudySetStats),nameof(StudySetStatsId),nameof(Updated),nameof(VersionNo)})]
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


        public object Clone() => this.Copy<Stats>();

    }
    

    public partial class StatsSearchBase : Search<Stats>
    {
        public int? Id { get; set; }
        public Reference App { get; set; }
        public List<int> AppIds { get; set; }
        public int? ExternalId { get; set; }
        public string ExternalType { get; set; }
        public int? ObjectId { get; set; }
        public string ObjectType { get; set; }
        public Reference StudySetStats { get; set; }
        public List<int> StudySetStatsIds { get; set; }
    }


    [Route("/stats", "GET")]
    [Route("/stats/version", "GET, POST")]
    [Route("/stats/search", "GET, POST, DELETE")]

    public partial class StatsSearch : StatsSearchBase
    {
    }

    public class StatsFullTextSearch
    {
        public StatsFullTextSearch() {}
        private StatsSearch _request;
        public StatsFullTextSearch(StatsSearch request) => _request = request;

        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Stats.Created))); }
        public bool doUpdated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Stats.Updated))); }

        public bool doApp { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Stats.App))); }
        public bool doExternalId { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Stats.ExternalId))); }
        public bool doExternalType { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Stats.ExternalType))); }
        public bool doObjectId { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Stats.ObjectId))); }
        public bool doObjectType { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Stats.ObjectType))); }
        public bool doStudySetStats { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Stats.StudySetStats))); }
    }


    public partial class StatsBatch : List<Stats> { }


}
