//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated by a T4 template. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.CodeDom.Compiler;
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
    public abstract partial class DatabaseVersionBase : Dto<DatabaseVersion>
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DatabaseVersionBase() {}

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DatabaseVersionBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DatabaseVersionBase(int? id) : this(DocConvert.ToInt(id)) {}

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DatabaseVersionBase(int? pId, string pDatabaseState, string pDescription, string pRelease, string pVersionName) : this(DocConvert.ToInt(pId)) 
        {
            DatabaseState = pDatabaseState;
            Description = pDescription;
            Release = pRelease;
            VersionName = pVersionName;
        }

        [ApiMember(Name = nameof(DatabaseState), Description = "string", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string DatabaseState { get; set; }
        [ApiMember(Name = nameof(DatabaseStateIds), Description = "DatabaseState Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> DatabaseStateIds { get; set; }
        [ApiMember(Name = nameof(DatabaseStateCount), Description = "DatabaseState Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? DatabaseStateCount { get; set; }

        [ApiMember(Name = nameof(Description), Description = "string", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string Description { get; set; }
        [ApiMember(Name = nameof(DescriptionIds), Description = "Description Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> DescriptionIds { get; set; }
        [ApiMember(Name = nameof(DescriptionCount), Description = "Description Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? DescriptionCount { get; set; }

        [ApiMember(Name = nameof(Release), Description = "string", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string Release { get; set; }
        [ApiMember(Name = nameof(ReleaseIds), Description = "Release Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> ReleaseIds { get; set; }
        [ApiMember(Name = nameof(ReleaseCount), Description = "Release Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? ReleaseCount { get; set; }

        [ApiMember(Name = nameof(VersionName), Description = "string", IsRequired = true)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string VersionName { get; set; }
        [ApiMember(Name = nameof(VersionNameIds), Description = "VersionName Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> VersionNameIds { get; set; }
        [ApiMember(Name = nameof(VersionNameCount), Description = "VersionName Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? VersionNameCount { get; set; }



        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public void Deconstruct(out string pDatabaseState, out string pDescription, out string pRelease, out string pVersionName)
        {
            pDatabaseState = DatabaseState;
            pDescription = Description;
            pRelease = Release;
            pVersionName = VersionName;
        }

        //Not ready until C# v8.?
        //[GeneratedCodeAttribute("T4", "1.0.0.0")]
        //public DatabaseVersionBase With(int? pId = Id, string pDatabaseState = DatabaseState, string pDescription = Description, string pRelease = Release, string pVersionName = VersionName) => 
        //	new DatabaseVersionBase(pId, pDatabaseState, pDescription, pRelease, pVersionName);

    }


    [Route("/databaseversion/{Id}", "GET")]

    public partial class DatabaseVersion : DatabaseVersionBase, IReturn<DatabaseVersion>, IDto, ICloneable
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DatabaseVersion() => _Constructor();
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DatabaseVersion(int? id) : base(DocConvert.ToInt(id)) {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DatabaseVersion(int id) : base(id) {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DatabaseVersion(int? pId, string pDatabaseState, string pDescription, string pRelease, string pVersionName) :
            base(pId, pDatabaseState, pDescription, pRelease, pVersionName) { }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static List<string> Fields => DocTools.Fields<DatabaseVersion>();

        private List<string> _Select;
        [ApiMember(Name = nameof(Select), Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Created),nameof(CreatorId),nameof(DatabaseState),nameof(Description),nameof(Gestalt),nameof(Locked),nameof(Release),nameof(Updated),nameof(VersionName),nameof(VersionNo)})]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override List<string> Select
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
                _Select = DocPermissionFactory.SetSelect<DatabaseVersion>("DatabaseVersion",exists);

            }
        }

        [Obsolete, ApiMember(Name = "VisibleFields", Description = "Deprecated. Use Select instead.", AllowMultiple = true)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override List<string> VisibleFields { get => Select; set => Select = value; }



        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Clone() => this.Copy<DatabaseVersion>();

    }
    

    public partial class DatabaseVersionSearchBase : Search<DatabaseVersion>
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? Id { get; set; }
        public string DatabaseState { get; set; }
        public List<string> DatabaseStates { get; set; }
        public string Description { get; set; }
        public List<string> Descriptions { get; set; }
        public string Release { get; set; }
        public List<string> Releases { get; set; }
        public string VersionName { get; set; }
        public List<string> VersionNames { get; set; }
    }


    [Route("/databaseversion", "GET")]
    [Route("/databaseversion/version", "GET, POST")]
    [Route("/databaseversion/search", "GET, POST, DELETE")]

    public partial class DatabaseVersionSearch : DatabaseVersionSearchBase
    {
    }

    public class DatabaseVersionFullTextSearch
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DatabaseVersionFullTextSearch() {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private DatabaseVersionSearch _request;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DatabaseVersionFullTextSearch(DatabaseVersionSearch request) => _request = request;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool doCreated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(DatabaseVersion.Created))); }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool doUpdated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(DatabaseVersion.Updated))); }

        public bool doDatabaseState { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(DatabaseVersion.DatabaseState))); }
        public bool doDescription { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(DatabaseVersion.Description))); }
        public bool doRelease { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(DatabaseVersion.Release))); }
        public bool doVersionName { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(DatabaseVersion.VersionName))); }
    }


    public partial class DatabaseVersionBatch : List<DatabaseVersion> { }


}
