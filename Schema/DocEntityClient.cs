//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated by a T4 template. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using AutoMapper;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Dynamic;
using System.Linq.Expressions;
using System.Net;
using System.Reflection;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using Services.Core;
using Services.Db;
using Services.Dto;
using Services.Dto.internals;
using Services.Dto.Security;
using Services.Enums;
using Services.Models;
using Services.Schema;

using ServiceStack;
using ServiceStack.Text;

using Typed;
using Typed.Bindings;
using Typed.Notifications;
using Typed.Settings;

using Xtensive.Orm;
using Xtensive.Orm.Model;

using Attribute = Services.Dto.Attribute;
using ValueType = Services.Dto.ValueType;
using Version = Services.Dto.Version;

namespace Services.Schema
{
    [TableMapping(DocConstantModelName.CLIENT)]
    public partial class DocEntityClient : DocEntityBase
    {
        private const string CLIENT_CACHE = "ClientCache";
        public const string TABLE_NAME = DocConstantModelName.CLIENT;
        
        #region Constructor
        public DocEntityClient(Session session) : base(session) {}

        public DocEntityClient() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        #region VisibleFields

        protected override List<string> _visibleFields
        {
            get
            {
                if(null == __vf)
                {
                    __vf = DocWebSession.GetTypeVisibleFields(new Client());
                }
                return __vf;
            }
        }

        #endregion VisibleFields

        #region Static Members
        public static DocEntityClient GetClient(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetClient(reference.Id) : null;
        }

        public static DocEntityClient GetClient(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityClient>.GetFromCache(primaryKey, CLIENT_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityClient>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityClient>.UpdateCache(ret.Id, ret, CLIENT_CACHE);
                    DocEntityThreadCache<DocEntityClient>.UpdateCache(ret.Hash, ret, CLIENT_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityClient GetClient(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityClient>.GetFromCache(hash, CLIENT_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityClient>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityClient>.UpdateCache(ret.Id, ret, CLIENT_CACHE);
                    DocEntityThreadCache<DocEntityClient>.UpdateCache(ret.Hash, ret, CLIENT_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field()]
        [FieldMapping(nameof(DefaultLocale))]
        public DocEntityLocale DefaultLocale { get; set; }
        public int? DefaultLocaleId { get { return DefaultLocale?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Divisions))]
        [Association(PairTo = nameof(DocEntityDivision.Client), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityDivision> Divisions { get; private set; }


        public int? DivisionsCount { get { return Divisions.Count(); } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(DocumentSets))]
        public DocEntitySet<DocEntityDocumentSet> DocumentSets { get; private set; }


        public int? DocumentSetsCount { get { return DocumentSets.Count(); } private set { var noid = value; } }


        [Field(Nullable = false)]
        [FieldMapping(nameof(Name))]
        public string Name { get; set; }


        [Field()]
        [FieldMapping(nameof(Projects))]
        [Association(PairTo = nameof(DocEntityProject.Client), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityProject> Projects { get; private set; }


        public int? ProjectsCount { get { return Projects.Count(); } private set { var noid = value; } }


        [Field(Nullable = false)]
        [FieldMapping(nameof(Role))]
        public DocEntityRole Role { get; set; }
        public int? RoleId { get { return Role?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(SalesforceAccountId))]
        public string SalesforceAccountId { get; set; }


        [Field()]
        [FieldMapping(nameof(Scopes))]
        [Association(PairTo = nameof(DocEntityScope.Client), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityScope> Scopes { get; private set; }


        public int? ScopesCount { get { return Scopes.Count(); } private set { var noid = value; } }


        [Field(Length = int.MaxValue)]
        [FieldMapping(nameof(Settings))]
        public string Settings { get; set; }



        [Field(LazyLoad = false, Length = Int32.MaxValue)]
        public override string Gestalt { get; set; }

        [Field(DefaultValue = 0), Version(VersionMode.Manual)]
        public override int VersionNo { get; set; }

        [Field]
        public override DateTime? Created { get; set; }

        [Field]
        public override DateTime? Updated { get; set; }

        [Field(DefaultValue = false)]
        [FieldMapping(nameof(Locked))]
        public override bool Locked { get; set; }

        [Field(DefaultValue = false)]
        [FieldMapping(nameof(Archived))]
        public override bool Archived { get; set; }

        #endregion Properties

        #region Overrides of DocEntity

        public override DocConstantModelName TableName => TABLE_NAME;

        public const string CACHE_KEY_PREFIX = "FindClients";

        #endregion Overrides of DocEntity

        #region Entity overrides
        /// <summary>
        ///    Called when entity is about to be removed.
        /// </summary>
        protected override void OnRemoving()
        {
            try
            {
                Divisions.Clear(); //foreach thing in Divisions en.Remove();
            }
            catch(Exception ex)
            {
                throw new DocException("Failed to delete Client in Divisions delete", ex);
            }
            try
            {
                Projects.Clear(); //foreach thing in Projects en.Remove();
            }
            catch(Exception ex)
            {
                throw new DocException("Failed to delete Client in Projects delete", ex);
            }
            base.OnRemoving();
            FlushCache();
        }

        /// <summary>
        ///    Called when entity should be validated. Override this method to perform custom object validation.
        /// </summary>
        protected override void OnValidate()
        {
            if (false == ValidationMessage.IsValid)
            {
                throw new HttpError(HttpStatusCode.Conflict, $"Client requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();
            _validated = true;
        }

        public override IDocEntity SaveChanges(bool ignoreCache, DocConstantPermission permission)
        {
            Name = Name?.TrimAndPruneSpaces();
            SalesforceAccountId = SalesforceAccountId?.TrimAndPruneSpaces();
            return base.SaveChanges(ignoreCache, permission);
        }

        public override IDocEntity SaveChanges(bool ignoreCache) => SaveChanges(ignoreCache, DocConstantPermission.EDIT);
        public override IDocEntity SaveChanges(DocConstantPermission permission) => SaveChanges(false, DocConstantPermission.EDIT);
        public override IDocEntity SaveChanges() => SaveChanges(DocConstantPermission.EDIT);

        public override void FlushCache()
        {
            base.FlushCache();
            DocCacheClient.RemoveById(Id);
        }
        #endregion Entity overrides

        #region Validation
        public DocValidationMessage ValidationMessage
        {
            get
            {
                var isValid = true;
                var message = string.Empty;

                if(DocTools.IsNullOrEmpty(Name))
                {
                    isValid = false;
                    message += " Name is a required property.";
                }
                if(DocTools.IsNullOrEmpty(Role))
                {
                    isValid = false;
                    message += " Role is a required property.";
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Converters

        public Client ToDto() => Mapper.Map<DocEntityClient, Client>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }

    public static partial class UniqueConstraintFilter
    {
        public static Expression<Func<DocEntityClient, bool>> ClientIgnoreArchived() => d => d.Archived == false;
    }

    public partial class ClientMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityClient,Client> _EntityToDto;
        protected IMappingExpression<Client,DocEntityClient> _DtoToEntity;

        public ClientMapper()
        {
            CreateMap<DocEntitySet<DocEntityClient>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityClient,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityClient>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityClient.GetClient(c));
            _EntityToDto = CreateMap<DocEntityClient,Client>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Client>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Client>(c, "Updated")))
                .ForMember(dest => dest.DefaultLocale, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Client>(c, nameof(DocEntityClient.DefaultLocale))))
                .ForMember(dest => dest.DefaultLocaleId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Client>(c, nameof(DocEntityClient.DefaultLocaleId))))
                .ForMember(dest => dest.Divisions, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Client>(c, nameof(DocEntityClient.Divisions))))
                .ForMember(dest => dest.DivisionsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Client>(c, nameof(DocEntityClient.DivisionsCount))))
                .ForMember(dest => dest.DocumentSets, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Client>(c, nameof(DocEntityClient.DocumentSets))))
                .ForMember(dest => dest.DocumentSetsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Client>(c, nameof(DocEntityClient.DocumentSetsCount))))
                .ForMember(dest => dest.Name, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Client>(c, nameof(DocEntityClient.Name))))
                .ForMember(dest => dest.Projects, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Client>(c, nameof(DocEntityClient.Projects))))
                .ForMember(dest => dest.ProjectsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Client>(c, nameof(DocEntityClient.ProjectsCount))))
                .ForMember(dest => dest.Role, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Client>(c, nameof(DocEntityClient.Role))))
                .ForMember(dest => dest.RoleId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Client>(c, nameof(DocEntityClient.RoleId))))
                .ForMember(dest => dest.SalesforceAccountId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Client>(c, nameof(DocEntityClient.SalesforceAccountId))))
                .ForMember(dest => dest.Scopes, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Client>(c, nameof(DocEntityClient.Scopes))))
                .ForMember(dest => dest.ScopesCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Client>(c, nameof(DocEntityClient.ScopesCount))))
                .ForMember(dest => dest.Settings, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Client>(c, nameof(DocEntityClient.Settings))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<Client,DocEntityClient>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
