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
    public abstract partial class UserTypeBase : Dto<UserType>
    {
        public UserTypeBase() {}

        public UserTypeBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public UserTypeBase(int? id) : this(DocConvert.ToInt(id)) {}
    
        [ApiMember(Name = nameof(PayrollStatus), Description = "LookupTable", IsRequired = false)]
        [ApiAllowableValues("Includes", Values = new string[] {@"Full-Time",@"Part-Time",@"Contract"})]
        public Reference PayrollStatus { get; set; }
        [ApiMember(Name = nameof(PayrollStatusId), Description = "Primary Key of LookupTable", IsRequired = false)]
        public int? PayrollStatusId { get; set; }


        [ApiMember(Name = nameof(PayrollType), Description = "LookupTable", IsRequired = false)]
        [ApiAllowableValues("Includes", Values = new string[] {@"Salary",@"Hourly"})]
        public Reference PayrollType { get; set; }
        [ApiMember(Name = nameof(PayrollTypeId), Description = "Primary Key of LookupTable", IsRequired = false)]
        public int? PayrollTypeId { get; set; }


        [ApiMember(Name = nameof(Type), Description = "LookupTable", IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {@"Employee",@"Contractor",@"Client",@"Vendor"})]
        public Reference Type { get; set; }
        [ApiMember(Name = nameof(TypeId), Description = "Primary Key of LookupTable", IsRequired = false)]
        public int? TypeId { get; set; }


        [ApiMember(Name = nameof(Users), Description = "User", IsRequired = false)]
        public List<Reference> Users { get; set; }
        public int? UsersCount { get; set; }


    }

    [Route("/usertype", "POST")]
    [Route("/usertype/{Id}", "GET, PATCH, PUT, DELETE")]
    public partial class UserType : UserTypeBase, IReturn<UserType>, IDto
    {
        public UserType()
        {
            _Constructor();
        }

        public UserType(int? id) : base(DocConvert.ToInt(id)) {}
        public UserType(int id) : base(id) {}
        
        #region Fields
        
        public bool? ShouldSerialize(string field)
        {
            if (IgnoredVisibleFields.Matches(field, true)) return false;
            var ret = MandatoryVisibleFields.Matches(field, true) || true == VisibleFields?.Matches(field, true);
            return ret;
        }

        public static List<string> Fields => DocTools.Fields<UserType>();

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Created),nameof(CreatorId),nameof(Gestalt),nameof(Locked),nameof(PayrollStatus),nameof(PayrollStatusId),nameof(PayrollType),nameof(PayrollTypeId),nameof(Type),nameof(TypeId),nameof(Updated),nameof(Users),nameof(UsersCount),nameof(VersionNo)})]
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
                _VisibleFields = DocPermissionFactory.SetVisibleFields<UserType>("UserType",exists);
            }
        }

        #endregion Fields
        private List<string> _collections = new List<string>
        {
            nameof(Users), nameof(UsersCount)
        };
        private List<string> collections { get { return _collections; } }
    }
    
    [Route("/UserType/{Id}/copy", "POST")]
    public partial class UserTypeCopy : UserType {}
    public partial class UserTypeSearchBase : Search<UserType>
    {
        public Reference PayrollStatus { get; set; }
        public List<int> PayrollStatusIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"Full-Time",@"Part-Time",@"Contract"})]
        public List<string> PayrollStatusNames { get; set; }
        public Reference PayrollType { get; set; }
        public List<int> PayrollTypeIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"Salary",@"Hourly"})]
        public List<string> PayrollTypeNames { get; set; }
        public Reference Type { get; set; }
        public List<int> TypeIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"Employee",@"Contractor",@"Client",@"Vendor"})]
        public List<string> TypeNames { get; set; }
        public List<int> UsersIds { get; set; }
    }

    [Route("/usertype", "GET")]
    [Route("/usertype/search", "GET, POST, DELETE")]
    public partial class UserTypeSearch : UserTypeSearchBase
    {
    }

    public class UserTypeFullTextSearch
    {
        public UserTypeFullTextSearch() {}
        private UserTypeSearch _request;
        public UserTypeFullTextSearch(UserTypeSearch request) => _request = request;
        
        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(UserType.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(UserType.Updated))); }
        
        public bool doPayrollStatus { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(UserType.PayrollStatus))); }
        public bool doPayrollType { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(UserType.PayrollType))); }
        public bool doType { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(UserType.Type))); }
        public bool doUsers { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(UserType.Users))); }
    }

    [Route("/usertype/version", "GET, POST")]
    public partial class UserTypeVersion : UserTypeSearch {}

    [Route("/usertype/batch", "DELETE, PATCH, POST, PUT")]
    public partial class UserTypeBatch : List<UserType> { }

    [Route("/usertype/{Id}/user", "GET, POST, DELETE")]
    public class UserTypeJunction : UserTypeSearchBase
    {
        public int? Id { get; set; }
        public List<int> Ids { get; set; }
        public List<string> VisibleFields { get; set; }


        public UserTypeJunction(int id, List<int> ids)
        {
            this.Id = id;
            this.Ids = ids;
        }
    }


    [Route("/usertype/{Id}/user/version", "GET")]
    public class UserTypeJunctionVersion : IReturn<Version>
    {
        public int? Id { get; set; }
        public List<int> Ids { get; set; }
        public List<string> VisibleFields { get; set; }
        public bool ShouldSerializeVisibleFields()
        {
            { return false; }
        }
    }
    [Route("/admin/usertype/ids", "GET, POST")]
    public class UserTypeIds
    {
        public bool All { get; set; }
    }
}