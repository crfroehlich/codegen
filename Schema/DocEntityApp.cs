﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when
//    the code is regenerated.
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
using System.Runtime.Serialization;

using Services.Core;
using Services.Db;
using Services.Dto;
using Services.Dto.internals;
using Services.Enums;
using Services.Models;

using ServiceStack;

using Typed.Notifications;
using Typed.Settings;

using Xtensive.Orm;
using Xtensive.Orm.Model;

using Attribute = Services.Dto.Attribute;
using ValueType = Services.Dto.ValueType;

namespace Services.Schema
{
    [TableMapping(DocConstantModelName.APP)]
    public partial class DocEntityApp : DocEntityBase
    {
        private const string APP_CACHE = "AppCache";
        public const string TABLE_NAME = DocConstantModelName.APP;
        
        #region Constructor
        public DocEntityApp(Session session) : base(session) {}

        public DocEntityApp() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        #region VisibleFields

        protected override List<string> _visibleFields
        {
            get
            {
                if(null == __vf)
                {
                    __vf = DocWebSession.GetTypeVisibleFields(new App());
                }
                return __vf;
            }
        }

        #endregion VisibleFields

        #region Static Members
        public static DocEntityApp GetApp(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetApp(reference.Id) : null;
        }

        public static DocEntityApp GetApp(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityApp>.GetFromCache(primaryKey, APP_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityApp>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityApp>.UpdateCache(ret.Id, ret, APP_CACHE);
                    DocEntityThreadCache<DocEntityApp>.UpdateCache(ret.Hash, ret, APP_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityApp GetApp(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityApp>.GetFromCache(hash, APP_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityApp>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityApp>.UpdateCache(ret.Id, ret, APP_CACHE);
                    DocEntityThreadCache<DocEntityApp>.UpdateCache(ret.Hash, ret, APP_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field()]
        [FieldMapping(nameof(Description))]
        public string Description { get; set; }


        [Field(Nullable = false)]
        [FieldMapping(nameof(Name))]
        public string Name { get; set; }


        [Field()]
        [FieldMapping(nameof(Pages))]
        [Association(PairTo = nameof(DocEntityPage.Apps), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityPage> Pages { get; private set; }


        public int? PagesCount { get { return Pages.Count(); } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Roles))]
        [Association(PairTo = nameof(DocEntityRole.Apps), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityRole> Roles { get; private set; }


        public int? RolesCount { get { return Roles.Count(); } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Scopes))]
        [Association(PairTo = nameof(DocEntityScope.App), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityScope> Scopes { get; private set; }


        public int? ScopesCount { get { return Scopes.Count(); } private set { var noid = value; } }



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

        public const string CACHE_KEY_PREFIX = "FindApps";

        #endregion Overrides of DocEntity

        #region Entity overrides
        /// <summary>
        ///    Called when entity is about to be removed.
        /// </summary>
        protected override void OnRemoving()
        {
            try
            {
                Scopes.Clear(); //foreach thing in Scopes en.Remove();
            }
            catch(Exception ex)
            {
                throw new DocException("Failed to delete App in Scopes delete", ex);
            }
            base.OnRemoving();
        }

        /// <summary>
        ///    Called when entity should be validated. Override this method to perform custom object validation.
        /// </summary>
        protected override void OnValidate()
        {
            if (false == ValidationMessage.IsValid)
            {
                throw new HttpError(HttpStatusCode.Conflict, $"App requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();

            FlushCache();

            _validated = true;


        }

        public override IDocEntity SaveChanges(DocConstantPermission permission = null)
        {
            Description = Description?.TrimAndPruneSpaces();
            Name = Name?.TrimAndPruneSpaces();
            return base.SaveChanges(permission);
        }

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

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Converters

        public App ToDto() => Mapper.Map<DocEntityApp, App>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }

    public static partial class UniqueConstraintFilter
    {
        public static Expression<Func<DocEntityApp, bool>> AppIgnoreArchived() => d => d.Archived == false;
    }

    public partial class AppMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityApp,App> _EntityToDto;
        protected IMappingExpression<App,DocEntityApp> _DtoToEntity;

        public AppMapper()
        {
            CreateMap<DocEntitySet<DocEntityApp>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityApp,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityApp>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityApp.GetApp(c));
            _EntityToDto = CreateMap<DocEntityApp,App>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<App>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<App>(c, "Updated")))
                .ForMember(dest => dest.Description, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<App>(c, nameof(DocEntityApp.Description))))
                .ForMember(dest => dest.Name, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<App>(c, nameof(DocEntityApp.Name))))
                .ForMember(dest => dest.Pages, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<App>(c, nameof(DocEntityApp.Pages))))
                .ForMember(dest => dest.PagesCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<App>(c, nameof(DocEntityApp.PagesCount))))
                .ForMember(dest => dest.Roles, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<App>(c, nameof(DocEntityApp.Roles))))
                .ForMember(dest => dest.RolesCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<App>(c, nameof(DocEntityApp.RolesCount))))
                .ForMember(dest => dest.Scopes, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<App>(c, nameof(DocEntityApp.Scopes))))
                .ForMember(dest => dest.ScopesCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<App>(c, nameof(DocEntityApp.ScopesCount))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<App,DocEntityApp>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}