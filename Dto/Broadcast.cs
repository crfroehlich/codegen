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
using Typed.Security;
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
    public abstract partial class BroadcastBase : Dto<Broadcast>
    {
        public BroadcastBase() {}

        public BroadcastBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public BroadcastBase(int? id) : this(DocConvert.ToInt(id)) {}
    
        [ApiMember(Name = nameof(App), Description = "App", IsRequired = true)]
        public Reference App { get; set; }
        [ApiMember(Name = nameof(AppId), Description = "Primary Key of App", IsRequired = false)]
        public int? AppId { get; set; }


        [ApiMember(Name = nameof(ConfluenceId), Description = "string", IsRequired = false)]
        public string ConfluenceId { get; set; }


        [ApiMember(Name = nameof(Name), Description = "string", IsRequired = true)]
        public string Name { get; set; }


        [ApiMember(Name = nameof(Reprocess), Description = "bool", IsRequired = false)]
        public bool Reprocess { get; set; }


        [ApiMember(Name = nameof(Reprocessed), Description = "DateTime?", IsRequired = false)]
        public DateTime? Reprocessed { get; set; }


        [ApiMember(Name = nameof(Scopes), Description = "Scope", IsRequired = false)]
        public List<Reference> Scopes { get; set; }
        public int? ScopesCount { get; set; }


        [ApiMember(Name = nameof(Status), Description = "LookupTable", IsRequired = false)]
        [ApiAllowableValues("Includes", Values = new string[] {@"Draft",@"Release"})]
        public Reference Status { get; set; }
        [ApiMember(Name = nameof(StatusId), Description = "Primary Key of LookupTable", IsRequired = false)]
        public int? StatusId { get; set; }


        [ApiMember(Name = nameof(Type), Description = "LookupTable", IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {@"Change Log",@"System Alert",@"Terms of Service",@"Scope Specific"})]
        public Reference Type { get; set; }
        [ApiMember(Name = nameof(TypeId), Description = "Primary Key of LookupTable", IsRequired = false)]
        public int? TypeId { get; set; }


    }

    [Route("/broadcast", "POST")]
    [Route("/profile/broadcast", "POST")]
    [Route("/broadcast/{Id}", "GET, PATCH, PUT, DELETE")]
    [Route("/profile/broadcast/{Id}", "GET, PATCH, PUT, DELETE")]
    public partial class Broadcast : BroadcastBase, IReturn<Broadcast>, IDto
    {
        public Broadcast()
        {
            _Constructor();
        }

        public Broadcast(int? id) : base(DocConvert.ToInt(id)) {}
        public Broadcast(int id) : base(id) {}
        
        #region Fields
        
        public bool? ShouldSerialize(string field)
        {
            if (IgnoredVisibleFields.Matches(field, true)) return false;
            var ret = MandatoryVisibleFields.Matches(field, true) || true == VisibleFields?.Matches(field, true);
            return ret;
        }

        public static List<string> Fields => DocTools.Fields<Broadcast>();

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(App),nameof(AppId),nameof(ConfluenceId),nameof(Created),nameof(CreatorId),nameof(Gestalt),nameof(Locked),nameof(Name),nameof(Reprocess),nameof(Reprocessed),nameof(Scopes),nameof(ScopesCount),nameof(Status),nameof(StatusId),nameof(Type),nameof(TypeId),nameof(Updated),nameof(VersionNo)})]
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
                _VisibleFields = DocPermissionFactory.SetVisibleFields<Broadcast>("Broadcast",exists);
            }
        }

        #endregion Fields
        private List<string> _collections = new List<string>
        {
            nameof(Scopes), nameof(ScopesCount)
        };
        private List<string> collections { get { return _collections; } }
    }
    
    [Route("/Broadcast/{Id}/copy", "POST")]
    [Route("/profile/Broadcast/{Id}/copy", "POST")]
    public partial class BroadcastCopy : Broadcast {}
    [Route("/broadcast", "GET")]
    [Route("/profile/broadcast", "GET")]
    [Route("/broadcast/search", "GET, POST, DELETE")]
    [Route("/profile/broadcast/search", "GET, POST, DELETE")]
    public partial class BroadcastSearch : Search<Broadcast>
    {
        public Reference App { get; set; }
        public List<int> AppIds { get; set; }
        public string ConfluenceId { get; set; }
        public string Name { get; set; }
        public bool? Reprocess { get; set; }
        public DateTime? Reprocessed { get; set; }
        public DateTime? ReprocessedAfter { get; set; }
        public DateTime? ReprocessedBefore { get; set; }
        public List<int> ScopesIds { get; set; }
        public Reference Status { get; set; }
        public List<int> StatusIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"Draft",@"Release"})]
        public List<string> StatusNames { get; set; }
        public Reference Type { get; set; }
        public List<int> TypeIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"Change Log",@"System Alert",@"Terms of Service",@"Scope Specific"})]
        public List<string> TypeNames { get; set; }
    }
    
    public class BroadcastFullTextSearch
    {
        private BroadcastSearch _request;
        public BroadcastFullTextSearch(BroadcastSearch request) => _request = request;
        
        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Broadcast.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Broadcast.Updated))); }
        
        public bool doApp { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Broadcast.App))); }
        public bool doConfluenceId { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Broadcast.ConfluenceId))); }
        public bool doName { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Broadcast.Name))); }
        public bool doReprocess { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Broadcast.Reprocess))); }
        public bool doReprocessed { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Broadcast.Reprocessed))); }
        public bool doScopes { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Broadcast.Scopes))); }
        public bool doStatus { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Broadcast.Status))); }
        public bool doType { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Broadcast.Type))); }
    }

    [Route("/broadcast/version", "GET, POST")]
    public partial class BroadcastVersion : BroadcastSearch {}

    [Route("/broadcast/batch", "DELETE, PATCH, POST, PUT")]
    [Route("/profile/broadcast/batch", "DELETE, PATCH, POST, PUT")]
    public partial class BroadcastBatch : List<Broadcast> { }

    [Route("/broadcast/{Id}/scope", "GET, POST, DELETE")]
    [Route("/profile/broadcast/{Id}/scope", "GET, POST, DELETE")]
    public class BroadcastJunction : Search<Broadcast>
    {
        public int? Id { get; set; }
        public List<int> Ids { get; set; }
        public List<string> VisibleFields { get; set; }
        public bool ShouldSerializeVisibleFields()
        {
            { return false; }
        }


        public BroadcastJunction(int id, List<int> ids)
        {
            this.Id = id;
            this.Ids = ids;
        }
    }


    [Route("/broadcast/{Id}/scope/version", "GET")]
    [Route("/profile/broadcast/{Id}/scope/version", "GET")]
    public class BroadcastJunctionVersion : IReturn<Version>
    {
        public int? Id { get; set; }
        public List<int> Ids { get; set; }
        public List<string> VisibleFields { get; set; }
        public bool ShouldSerializeVisibleFields()
        {
            { return false; }
        }
    }
    [Route("/admin/broadcast/ids", "GET, POST")]
    public class BroadcastIds
    {
        public bool All { get; set; }
    }
}