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
    public abstract partial class JunctionBase : Dto<Junction>
    {
        public JunctionBase() {}

        public JunctionBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public JunctionBase(int? id) : this(DocConvert.ToInt(id)) {}
    
        [ApiMember(Name = nameof(Children), Description = "Junction", IsRequired = false)]
        public List<Reference> Children { get; set; }
        public int? ChildrenCount { get; set; }


        [ApiMember(Name = nameof(Data), Description = "string", IsRequired = false)]
        public string Data { get; set; }


        [ApiMember(Name = nameof(OwnerId), Description = "int?", IsRequired = false)]
        public int? OwnerId { get; set; }


        [ApiMember(Name = nameof(OwnerType), Description = "string", IsRequired = false)]
        public string OwnerType { get; set; }


        [ApiMember(Name = nameof(Parent), Description = "Junction", IsRequired = false)]
        public Reference Parent { get; set; }
        [ApiMember(Name = nameof(ParentId), Description = "Primary Key of Junction", IsRequired = false)]
        public int? ParentId { get; set; }


        [ApiMember(Name = nameof(TargetId), Description = "int?", IsRequired = false)]
        public int? TargetId { get; set; }


        [ApiMember(Name = nameof(TargetType), Description = "string", IsRequired = false)]
        public string TargetType { get; set; }


        [ApiMember(Name = nameof(Type), Description = "LookupTable", IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {@"Comment",@"Rating",@"Approval",@"Flagged for Approval"})]
        public Reference Type { get; set; }
        [ApiMember(Name = nameof(TypeId), Description = "Primary Key of LookupTable", IsRequired = false)]
        public int? TypeId { get; set; }


        [ApiMember(Name = nameof(User), Description = "User", IsRequired = true)]
        public Reference User { get; set; }
        [ApiMember(Name = nameof(UserId), Description = "Primary Key of User", IsRequired = false)]
        public int? UserId { get; set; }


    }

    [Route("/junction", "POST")]
    [Route("/junction/{Id}", "GET, PATCH, PUT, DELETE")]
    public partial class Junction : JunctionBase, IReturn<Junction>, IDto
    {
        public Junction()
        {
            _Constructor();
        }

        public Junction(int? id) : base(DocConvert.ToInt(id)) {}
        public Junction(int id) : base(id) {}
        
        #region Fields
        
        public bool? ShouldSerialize(string field)
        {
            if (IgnoredVisibleFields.Matches(field, true)) return false;
            var ret = MandatoryVisibleFields.Matches(field, true) || true == VisibleFields?.Matches(field, true);
            return ret;
        }

        public static List<string> Fields => DocTools.Fields<Junction>();

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Children),nameof(ChildrenCount),nameof(Created),nameof(CreatorId),nameof(Data),nameof(Gestalt),nameof(Locked),nameof(OwnerId),nameof(OwnerType),nameof(Parent),nameof(ParentId),nameof(TargetId),nameof(TargetType),nameof(Type),nameof(TypeId),nameof(Updated),nameof(User),nameof(UserId),nameof(VersionNo)})]
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
                _VisibleFields = DocPermissionFactory.SetVisibleFields<Junction>("Junction",exists);
            }
        }

        #endregion Fields
        private List<string> _collections = new List<string>
        {
            nameof(Children), nameof(ChildrenCount)
        };
        private List<string> collections { get { return _collections; } }
    }
    
    [Route("/Junction/{Id}/copy", "POST")]
    public partial class JunctionCopy : Junction {}
    public partial class JunctionSearchBase : Search<Junction>
    {
        public List<int> ChildrenIds { get; set; }
        public string Data { get; set; }
        public int? OwnerId { get; set; }
        public string OwnerType { get; set; }
        public Reference Parent { get; set; }
        public List<int> ParentIds { get; set; }
        public int? TargetId { get; set; }
        public string TargetType { get; set; }
        public Reference Type { get; set; }
        public List<int> TypeIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"Comment",@"Rating",@"Approval",@"Flagged for Approval"})]
        public List<string> TypeNames { get; set; }
        public Reference User { get; set; }
        public List<int> UserIds { get; set; }
    }

    [Route("/junction", "GET")]
    [Route("/junction/search", "GET, POST, DELETE")]
    public partial class JunctionSearch : JunctionSearchBase
    {
    }

    public class JunctionFullTextSearch
    {
        private JunctionSearch _request;
        public JunctionFullTextSearch(JunctionSearch request) => _request = request;
        
        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Junction.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Junction.Updated))); }
        
        public bool doChildren { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Junction.Children))); }
        public bool doData { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Junction.Data))); }
        public bool doOwnerId { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Junction.OwnerId))); }
        public bool doOwnerType { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Junction.OwnerType))); }
        public bool doParent { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Junction.Parent))); }
        public bool doTargetId { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Junction.TargetId))); }
        public bool doTargetType { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Junction.TargetType))); }
        public bool doType { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Junction.Type))); }
        public bool doUser { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Junction.User))); }
    }

    [Route("/junction/version", "GET, POST")]
    public partial class JunctionVersion : JunctionSearch {}

    [Route("/junction/batch", "DELETE, PATCH, POST, PUT")]
    public partial class JunctionBatch : List<Junction> { }

    [Route("/junction/{Id}/junction", "GET, POST, DELETE")]
    public class JunctionJunction : Search<Junction>
    {
        public int? Id { get; set; }
        public List<int> Ids { get; set; }
        public List<string> VisibleFields { get; set; }
        public bool ShouldSerializeVisibleFields()
        {
            { return false; }
        }


        public JunctionJunction(int id, List<int> ids)
        {
            this.Id = id;
            this.Ids = ids;
        }
    }


    [Route("/junction/{Id}/junction/version", "GET")]
    public class JunctionJunctionVersion : IReturn<Version>
    {
        public int? Id { get; set; }
        public List<int> Ids { get; set; }
        public List<string> VisibleFields { get; set; }
        public bool ShouldSerializeVisibleFields()
        {
            { return false; }
        }
    }
    [Route("/admin/junction/ids", "GET, POST")]
    public class JunctionIds
    {
        public bool All { get; set; }
    }
}