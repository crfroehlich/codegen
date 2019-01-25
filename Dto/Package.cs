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
    public abstract partial class PackageBase : Dto<Package>
    {
        public PackageBase() {}

        public PackageBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public PackageBase(int? id) : this(DocConvert.ToInt(id)) {}
    
        [ApiMember(Name = nameof(Archived), Description = "bool?", IsRequired = false)]
        public bool? Archived { get; set; }


        [ApiMember(Name = nameof(Children), Description = "Package", IsRequired = false)]
        public List<Reference> Children { get; set; }
        public int? ChildrenCount { get; set; }


        [ApiMember(Name = nameof(Client), Description = "Client", IsRequired = false)]
        public Reference Client { get; set; }
        [ApiMember(Name = nameof(ClientId), Description = "Primary Key of Client", IsRequired = false)]
        public int? ClientId { get; set; }


        [ApiMember(Name = nameof(DatabaseDeadline), Description = "DateTime?", IsRequired = false)]
        public DateTime? DatabaseDeadline { get; set; }


        [ApiMember(Name = nameof(DatabaseName), Description = "string", IsRequired = false)]
        public string DatabaseName { get; set; }


        [ApiMember(Name = nameof(Dataset), Description = "DocumentSet", IsRequired = false)]
        public Reference Dataset { get; set; }
        [ApiMember(Name = nameof(DatasetId), Description = "Primary Key of DocumentSet", IsRequired = false)]
        public int? DatasetId { get; set; }


        [ApiMember(Name = nameof(DeliverableDeadline), Description = "DateTime?", IsRequired = false)]
        public DateTime? DeliverableDeadline { get; set; }


        [ApiMember(Name = nameof(FqId), Description = "int?", IsRequired = false)]
        public int? FqId { get; set; }


        [ApiMember(Name = nameof(LegacyTimeCards), Description = "TimeCard", IsRequired = false)]
        public List<Reference> LegacyTimeCards { get; set; }
        public int? LegacyTimeCardsCount { get; set; }


        [ApiMember(Name = nameof(LibraryPackageId), Description = "int?", IsRequired = false)]
        public int? LibraryPackageId { get; set; }


        [ApiMember(Name = nameof(LibraryPackageName), Description = "string", IsRequired = false)]
        public string LibraryPackageName { get; set; }


        [ApiMember(Name = nameof(Number), Description = "string", IsRequired = false)]
        public string Number { get; set; }


        [ApiMember(Name = nameof(OperationsDeliverable), Description = "string", IsRequired = false)]
        public string OperationsDeliverable { get; set; }


        [ApiMember(Name = nameof(Opportunity), Description = "ForeignKey", IsRequired = false)]
        public Reference Opportunity { get; set; }
        [ApiMember(Name = nameof(OpportunityId), Description = "Primary Key of ForeignKey", IsRequired = false)]
        public int? OpportunityId { get; set; }


        [ApiMember(Name = nameof(Parent), Description = "Package", IsRequired = false)]
        public Reference Parent { get; set; }
        [ApiMember(Name = nameof(ParentId), Description = "Primary Key of Package", IsRequired = false)]
        public int? ParentId { get; set; }


        [ApiMember(Name = nameof(PICO), Description = "string", IsRequired = false)]
        public string PICO { get; set; }


        [ApiMember(Name = nameof(Project), Description = "ForeignKey", IsRequired = false)]
        public Reference Project { get; set; }
        [ApiMember(Name = nameof(ProjectId), Description = "Primary Key of ForeignKey", IsRequired = false)]
        public int? ProjectId { get; set; }


        [ApiMember(Name = nameof(Status), Description = "LookupTable", IsRequired = false)]
        [ApiAllowableValues("Includes", Values = new string[] {@"Active",@"Archived",@"Inactive"})]
        public Reference Status { get; set; }
        [ApiMember(Name = nameof(StatusId), Description = "Primary Key of LookupTable", IsRequired = false)]
        public int? StatusId { get; set; }


    }

    [Route("/package", "POST")]
    [Route("/package/{Id}", "GET, PATCH, PUT, DELETE")]
    public partial class Package : PackageBase, IReturn<Package>, IDto
    {
        public Package()
        {
            _Constructor();
        }

        public Package(int? id) : base(DocConvert.ToInt(id)) {}
        public Package(int id) : base(id) {}
        
        #region Fields
        
        public bool? ShouldSerialize(string field)
        {
            if (IgnoredVisibleFields.Matches(field, true)) return false;
            var ret = MandatoryVisibleFields.Matches(field, true) || true == VisibleFields?.Matches(field, true);
            return ret;
        }

        public static List<string> Fields => DocTools.Fields<Package>();

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Archived),nameof(Children),nameof(ChildrenCount),nameof(Client),nameof(ClientId),nameof(Created),nameof(CreatorId),nameof(DatabaseDeadline),nameof(DatabaseName),nameof(Dataset),nameof(DatasetId),nameof(DeliverableDeadline),nameof(FqId),nameof(Gestalt),nameof(LegacyTimeCards),nameof(LegacyTimeCardsCount),nameof(LibraryPackageId),nameof(LibraryPackageName),nameof(Locked),nameof(Number),nameof(OperationsDeliverable),nameof(Opportunity),nameof(OpportunityId),nameof(Parent),nameof(ParentId),nameof(PICO),nameof(Project),nameof(ProjectId),nameof(Status),nameof(StatusId),nameof(Updated),nameof(VersionNo)})]
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
                _VisibleFields = DocPermissionFactory.SetVisibleFields<Package>("Package",exists);
            }
        }

        #endregion Fields
        private List<string> _collections = new List<string>
        {
            nameof(Children), nameof(ChildrenCount), nameof(LegacyTimeCards), nameof(LegacyTimeCardsCount)
        };
        private List<string> collections { get { return _collections; } }
    }
    
    [Route("/Package/{Id}/copy", "POST")]
    public partial class PackageCopy : Package {}
    public partial class PackageSearchBase : Search<Package>
    {
        public bool? Archived { get; set; }
        public List<int> ChildrenIds { get; set; }
        public Reference Client { get; set; }
        public List<int> ClientIds { get; set; }
        public DateTime? DatabaseDeadline { get; set; }
        public DateTime? DatabaseDeadlineAfter { get; set; }
        public DateTime? DatabaseDeadlineBefore { get; set; }
        public string DatabaseName { get; set; }
        public Reference Dataset { get; set; }
        public List<int> DatasetIds { get; set; }
        public DateTime? DeliverableDeadline { get; set; }
        public DateTime? DeliverableDeadlineAfter { get; set; }
        public DateTime? DeliverableDeadlineBefore { get; set; }
        public int? FqId { get; set; }
        public List<int> LegacyTimeCardsIds { get; set; }
        public int? LibraryPackageId { get; set; }
        public string LibraryPackageName { get; set; }
        public string Number { get; set; }
        public string OperationsDeliverable { get; set; }
        public Reference Opportunity { get; set; }
        public List<int> OpportunityIds { get; set; }
        public Reference Parent { get; set; }
        public List<int> ParentIds { get; set; }
        public string PICO { get; set; }
        public Reference Project { get; set; }
        public List<int> ProjectIds { get; set; }
        public Reference Status { get; set; }
        public List<int> StatusIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"Active",@"Archived",@"Inactive"})]
        public List<string> StatusNames { get; set; }
    }

    [Route("/package", "GET")]
    [Route("/package/search", "GET, POST, DELETE")]
    public partial class PackageSearch : PackageSearchBase
    {
    }

    public class PackageFullTextSearch
    {
        private PackageSearch _request;
        public PackageFullTextSearch(PackageSearch request) => _request = request;
        
        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Package.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Package.Updated))); }
        
        public bool doArchived { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Package.Archived))); }
        public bool doChildren { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Package.Children))); }
        public bool doClient { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Package.Client))); }
        public bool doDatabaseDeadline { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Package.DatabaseDeadline))); }
        public bool doDatabaseName { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Package.DatabaseName))); }
        public bool doDataset { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Package.Dataset))); }
        public bool doDeliverableDeadline { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Package.DeliverableDeadline))); }
        public bool doFqId { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Package.FqId))); }
        public bool doLegacyTimeCards { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Package.LegacyTimeCards))); }
        public bool doLibraryPackageId { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Package.LibraryPackageId))); }
        public bool doLibraryPackageName { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Package.LibraryPackageName))); }
        public bool doNumber { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Package.Number))); }
        public bool doOperationsDeliverable { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Package.OperationsDeliverable))); }
        public bool doOpportunity { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Package.Opportunity))); }
        public bool doParent { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Package.Parent))); }
        public bool doPICO { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Package.PICO))); }
        public bool doProject { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Package.Project))); }
        public bool doStatus { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(Package.Status))); }
    }

    [Route("/package/version", "GET, POST")]
    public partial class PackageVersion : PackageSearch {}

    [Route("/package/batch", "DELETE, PATCH, POST, PUT")]
    public partial class PackageBatch : List<Package> { }

    [Route("/package/{Id}/package", "GET, POST, DELETE")]
    [Route("/package/{Id}/timecard", "GET, POST, DELETE")]
    public class PackageJunction : Search<Package>
    {
        public int? Id { get; set; }
        public List<int> Ids { get; set; }
        public List<string> VisibleFields { get; set; }
        public bool ShouldSerializeVisibleFields()
        {
            { return false; }
        }


        public PackageJunction(int id, List<int> ids)
        {
            this.Id = id;
            this.Ids = ids;
        }
    }


    [Route("/package/{Id}/package/version", "GET")]
    [Route("/package/{Id}/timecard/version", "GET")]
    public class PackageJunctionVersion : IReturn<Version>
    {
        public int? Id { get; set; }
        public List<int> Ids { get; set; }
        public List<string> VisibleFields { get; set; }
        public bool ShouldSerializeVisibleFields()
        {
            { return false; }
        }
    }
    [Route("/admin/package/ids", "GET, POST")]
    public class PackageIds
    {
        public bool All { get; set; }
    }
}