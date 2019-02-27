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
    public abstract partial class DivisionBase : Dto<Division>
    {
        public DivisionBase() {}

        public DivisionBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public DivisionBase(int? id) : this(DocConvert.ToInt(id)) {}

        [ApiMember(Name = nameof(Client), Description = "Client", IsRequired = true)]
        public Reference Client { get; set; }
        [ApiMember(Name = nameof(ClientId), Description = "Primary Key of Client", IsRequired = false)]
        public int? ClientId { get; set; }


        [ApiMember(Name = nameof(DefaultLocale), Description = "Locale", IsRequired = false)]
        public Reference DefaultLocale { get; set; }
        [ApiMember(Name = nameof(DefaultLocaleId), Description = "Primary Key of Locale", IsRequired = false)]
        public int? DefaultLocaleId { get; set; }


        [ApiMember(Name = nameof(DocumentSets), Description = "DocumentSet", IsRequired = false)]
        public List<Reference> DocumentSets { get; set; }
        public int? DocumentSetsCount { get; set; }


        [ApiMember(Name = nameof(Name), Description = "string", IsRequired = true)]
        public string Name { get; set; }


        [ApiMember(Name = nameof(Role), Description = "Role", IsRequired = true)]
        public Reference Role { get; set; }
        [ApiMember(Name = nameof(RoleId), Description = "Primary Key of Role", IsRequired = false)]
        public int? RoleId { get; set; }


        [ApiMember(Name = nameof(Settings), Description = "DivisionSettings", IsRequired = false)]
        public DivisionSettings Settings { get; set; }


        [ApiMember(Name = nameof(Users), Description = "User", IsRequired = false)]
        public List<Reference> Users { get; set; }
        public int? UsersCount { get; set; }


    }

    [Route("/division", "POST")]
    [Route("/division/{Id}", "GET, PATCH, PUT, DELETE")]
    public partial class Division : DivisionBase, IReturn<Division>, IDto
    {
        public Division()
        {
            _Constructor();
        }

        public Division(int? id) : base(DocConvert.ToInt(id)) {}
        public Division(int id) : base(id) {}
        
        #region Fields
        
        public bool? ShouldSerialize(string field)
        {
            if (IgnoredVisibleFields.Matches(field, true)) return false;
            var ret = MandatoryVisibleFields.Matches(field, true) || true == VisibleFields?.Matches(field, true);
            return ret;
        }

        public static List<string> Fields => DocTools.Fields<Division>();

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Client),nameof(ClientId),nameof(Created),nameof(CreatorId),nameof(DefaultLocale),nameof(DefaultLocaleId),nameof(DocumentSets),nameof(DocumentSetsCount),nameof(Gestalt),nameof(Locked),nameof(Name),nameof(Role),nameof(RoleId),nameof(Settings),nameof(Updated),nameof(Users),nameof(UsersCount),nameof(VersionNo)})]
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
                _VisibleFields = DocPermissionFactory.SetVisibleFields<Division>("Division",exists);
            }
        }

        #endregion Fields
        private List<string> _collections = new List<string>
        {
            nameof(DocumentSets), nameof(DocumentSetsCount), nameof(Users), nameof(UsersCount)
        };
        private List<string> collections { get { return _collections; } }
    }
    
    [Route("/Division/{Id}/copy", "POST")]
    public partial class DivisionCopy : Division {}
    public partial class DivisionSearchBase : Search<Division>
    {
        public int? Id { get; set; }
        public Reference Client { get; set; }
        public List<int> ClientIds { get; set; }
        public Reference DefaultLocale { get; set; }
        public List<int> DefaultLocaleIds { get; set; }
        public List<int> DocumentSetsIds { get; set; }
        public string Name { get; set; }
        public Reference Role { get; set; }
        public List<int> RoleIds { get; set; }
        public string Settings { get; set; }
        public List<int> UsersIds { get; set; }
    }

    [Route("/division", "GET")]
    [Route("/division/version", "GET, POST")]
    [Route("/division/search", "GET, POST, DELETE")]
    public partial class DivisionSearch : DivisionSearchBase
    {
    }

    public class DivisionFullTextSearch
    {
        public DivisionFullTextSearch() {}
        private DivisionSearch _request;
        public DivisionFullTextSearch(DivisionSearch request) => _request = request;

        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Division.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Division.Updated))); }

        public bool doClient { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Division.Client))); }
        public bool doDefaultLocale { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Division.DefaultLocale))); }
        public bool doDocumentSets { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Division.DocumentSets))); }
        public bool doName { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Division.Name))); }
        public bool doRole { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Division.Role))); }
        public bool doSettings { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Division.Settings))); }
        public bool doUsers { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Division.Users))); }
    }

    [Route("/division/batch", "DELETE, PATCH, POST, PUT")]
    public partial class DivisionBatch : List<Division> { }

    [Route("/division/{Id}/{Junction}/version", "GET, POST")]
    [Route("/division/{Id}/{Junction}", "GET, POST, DELETE")]
    public class DivisionJunction : DivisionSearchBase {}


}