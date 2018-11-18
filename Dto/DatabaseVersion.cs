﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when
//    the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AutoMapper;

using Services.Core;
using Services.Db;
using Services.Dto;
using Services.Enums;
using Services.Models;
using Services.Schema;

using Typed;
using Typed.Bindings;
using Typed.Notifications;
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
    public abstract partial class DatabaseVersionBase : Dto<DatabaseVersion>
    {
        public DatabaseVersionBase() {}

        public DatabaseVersionBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public DatabaseVersionBase(int? id) : this(DocConvert.ToInt(id)) {}
    
        [ApiMember(Name = nameof(Description), Description = "string", IsRequired = false)]
        public string Description { get; set; }


        [ApiMember(Name = nameof(Release), Description = "string", IsRequired = false)]
        public string Release { get; set; }


        [ApiMember(Name = nameof(VersionName), Description = "string", IsRequired = true)]
        public string VersionName { get; set; }


    }

    [Route("/databaseversion/{Id}", "GET")]
    [Route("/profile/databaseversion/{Id}", "GET")]
    public partial class DatabaseVersion : DatabaseVersionBase, IReturn<DatabaseVersion>, IDto
    {
        public DatabaseVersion()
        {
            _Constructor();
        }

        public DatabaseVersion(int? id) : base(DocConvert.ToInt(id)) {}
        public DatabaseVersion(int id) : base(id) {}
        
        #region Fields
        
        public bool? ShouldSerialize(string field)
        {
            if (DocTools.AreEqual(nameof(VisibleFields), field)) return false;
            if (DocTools.AreEqual(nameof(Fields), field)) return false;
            if (DocTools.AreEqual(nameof(AssignFields), field)) return false;
            if (DocTools.AreEqual(nameof(IgnoreCache), field)) return false;
            if (DocTools.AreEqual(nameof(Id), field)) return true;
            return true == VisibleFields?.Matches(field, true);
        }

        private static List<string> _fields;
        public static List<string> Fields => _fields ?? (_fields = DocTools.Fields<DatabaseVersion>());

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Created),nameof(CreatorId),nameof(Description),nameof(Gestalt),nameof(Locked),nameof(Release),nameof(Updated),nameof(VersionName),nameof(VersionNo)})]
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
                _VisibleFields = DocPermissionFactory.SetVisibleFields<DatabaseVersion>("DatabaseVersion",exists);
            }
        }

        #endregion Fields
    }
    
    [Route("/databaseversion", "GET")]
    [Route("/profile/databaseversion", "GET")]
    [Route("/databaseversion/search", "GET, POST, DELETE")]
    [Route("/profile/databaseversion/search", "GET, POST, DELETE")]
    public partial class DatabaseVersionSearch : Search<DatabaseVersion>
    {
        public string Description { get; set; }
        public string Release { get; set; }
        public string VersionName { get; set; }
    }
    
    public class DatabaseVersionFullTextSearch
    {
        private DatabaseVersionSearch _request;
        public DatabaseVersionFullTextSearch(DatabaseVersionSearch request) => _request = request;
        
        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DatabaseVersion.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DatabaseVersion.Updated))); }
        
        public bool doDescription { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DatabaseVersion.Description))); }
        public bool doRelease { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DatabaseVersion.Release))); }
        public bool doVersionName { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DatabaseVersion.VersionName))); }
    }

    [Route("/databaseversion/version", "GET, POST")]
    public partial class DatabaseVersionVersion : DatabaseVersionSearch {}

    [Route("/databaseversion/batch", "DELETE, PATCH, POST, PUT")]
    [Route("/profile/databaseversion/batch", "DELETE, PATCH, POST, PUT")]
    public partial class DatabaseVersionBatch : List<DatabaseVersion> { }

}