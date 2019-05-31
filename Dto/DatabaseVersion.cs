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
    public abstract partial class DatabaseVersionBase : Dto<DatabaseVersion>
    {
        public DatabaseVersionBase() {}

        public DatabaseVersionBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public DatabaseVersionBase(int? id) : this(DocConvert.ToInt(id)) {}

        public DatabaseVersionBase(int? pId, string pDatabaseState, string pDescription, string pRelease, string pVersionName) : this(DocConvert.ToInt(pId)) 
        {
            DatabaseState = pDatabaseState;
            Description = pDescription;
            Release = pRelease;
            VersionName = pVersionName;
        }

        [ApiMember(Name = nameof(DatabaseState), Description = "string", IsRequired = false)]
        public string DatabaseState { get; set; }


        [ApiMember(Name = nameof(Description), Description = "string", IsRequired = false)]
        public string Description { get; set; }


        [ApiMember(Name = nameof(Release), Description = "string", IsRequired = false)]
        public string Release { get; set; }


        [ApiMember(Name = nameof(VersionName), Description = "string", IsRequired = true)]
        public string VersionName { get; set; }



        public void Deconstruct(out string pDatabaseState, out string pDescription, out string pRelease, out string pVersionName)
        {
            pDatabaseState = DatabaseState;
            pDescription = Description;
            pRelease = Release;
            pVersionName = VersionName;
        }

        //Not ready until C# v8.?
        //public DatabaseVersionBase With(int? pId = Id, string pDatabaseState = DatabaseState, string pDescription = Description, string pRelease = Release, string pVersionName = VersionName) => 
        //	new DatabaseVersionBase(pId, pDatabaseState, pDescription, pRelease, pVersionName);

    }

    [Route("/databaseversion/{Id}", "GET")]
    public partial class DatabaseVersion : DatabaseVersionBase, IReturn<DatabaseVersion>, IDto, ICloneable
    {
        public DatabaseVersion()
        {
            _Constructor();
        }

        public DatabaseVersion(int? id) : base(DocConvert.ToInt(id)) {}
        public DatabaseVersion(int id) : base(id) {}
        public DatabaseVersion(int? pId, string pDatabaseState, string pDescription, string pRelease, string pVersionName) : 
            base(pId, pDatabaseState, pDescription, pRelease, pVersionName) { }
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

        public static List<string> Fields => DocTools.Fields<DatabaseVersion>();

        private List<string> _Select;
        [ApiMember(Name = "Select", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Created),nameof(CreatorId),nameof(DatabaseState),nameof(Description),nameof(Gestalt),nameof(Locked),nameof(Release),nameof(Updated),nameof(VersionName),nameof(VersionNo)})]
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
                _Select = DocPermissionFactory.SetSelect<DatabaseVersion>("DatabaseVersion",exists);
            }
        }

        #endregion Fields

        public object Clone() => this.Copy<DatabaseVersion>();
    }
    
    public partial class DatabaseVersionSearchBase : Search<DatabaseVersion>
    {
        public int? Id { get; set; }
        public string DatabaseState { get; set; }
        public string Description { get; set; }
        public string Release { get; set; }
        public string VersionName { get; set; }
    }

    [Route("/databaseversion", "GET")]
    [Route("/databaseversion/version", "GET, POST")]
    [Route("/databaseversion/search", "GET, POST, DELETE")]
    public partial class DatabaseVersionSearch : DatabaseVersionSearchBase
    {
    }

    public class DatabaseVersionFullTextSearch
    {
        public DatabaseVersionFullTextSearch() {}
        private DatabaseVersionSearch _request;
        public DatabaseVersionFullTextSearch(DatabaseVersionSearch request) => _request = request;

        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(DatabaseVersion.Created))); }
        public bool doUpdated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(DatabaseVersion.Updated))); }

        public bool doDatabaseState { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(DatabaseVersion.DatabaseState))); }
        public bool doDescription { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(DatabaseVersion.Description))); }
        public bool doRelease { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(DatabaseVersion.Release))); }
        public bool doVersionName { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(DatabaseVersion.VersionName))); }
    }

    public partial class DatabaseVersionBatch : List<DatabaseVersion> { }

}
