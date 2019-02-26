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
    [TableMapping(DocConstantModelName.RELEASESTATUS)]
    public partial class DocEntityReleaseStatus : DocEntityBase
    {
        private const string RELEASESTATUS_CACHE = "ReleaseStatusCache";
        public const string TABLE_NAME = DocConstantModelName.RELEASESTATUS;
        
        #region Constructor
        public DocEntityReleaseStatus(Session session) : base(session) {}

        public DocEntityReleaseStatus() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        #region VisibleFields

        protected override List<string> _visibleFields
        {
            get
            {
                if(null == __vf)
                {
                    __vf = DocWebSession.GetTypeVisibleFields(new ReleaseStatus());
                }
                return __vf;
            }
        }

        #endregion VisibleFields

        #region Static Members
        public static DocEntityReleaseStatus GetReleaseStatus(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetReleaseStatus(reference.Id) : null;
        }

        public static DocEntityReleaseStatus GetReleaseStatus(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityReleaseStatus>.GetFromCache(primaryKey, RELEASESTATUS_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityReleaseStatus>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityReleaseStatus>.UpdateCache(ret.Id, ret, RELEASESTATUS_CACHE);
                    DocEntityThreadCache<DocEntityReleaseStatus>.UpdateCache(ret.Hash, ret, RELEASESTATUS_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityReleaseStatus GetReleaseStatus(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityReleaseStatus>.GetFromCache(hash, RELEASESTATUS_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityReleaseStatus>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityReleaseStatus>.UpdateCache(ret.Id, ret, RELEASESTATUS_CACHE);
                    DocEntityThreadCache<DocEntityReleaseStatus>.UpdateCache(ret.Hash, ret, RELEASESTATUS_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field(Nullable = false)]
        [FieldMapping(nameof(Branch))]
        public string Branch { get; set; }


        [Field(Nullable = false)]
        [FieldMapping(nameof(Release))]
        public string Release { get; set; }


        [Field(Nullable = false)]
        [FieldMapping(nameof(Server))]
        public string Server { get; set; }


        [Field(Nullable = false)]
        [FieldMapping(nameof(URL))]
        public string URL { get; set; }


        [Field(Nullable = false)]
        [FieldMapping(nameof(Version))]
        public string Version { get; set; }



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

        public const string CACHE_KEY_PREFIX = "FindReleaseStatuss";

        #endregion Overrides of DocEntity

        #region Entity overrides
        /// <summary>
        ///    Called when entity is about to be removed.
        /// </summary>
        protected override void OnRemoving()
        {
            base.OnRemoving();
        }

        /// <summary>
        ///    Called when entity should be validated. Override this method to perform custom object validation.
        /// </summary>
        protected override void OnValidate()
        {
            if (false == ValidationMessage.IsValid)
            {
                throw new HttpError(HttpStatusCode.Conflict, $"ReleaseStatus requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();

            FlushCache();

            _validated = true;

        }

        public override IDocEntity SaveChanges(DocConstantPermission permission = null)
        {
            Branch = Branch?.TrimAndPruneSpaces();
            Release = Release?.TrimAndPruneSpaces();
            Server = Server?.TrimAndPruneSpaces();
            URL = URL?.TrimAndPruneSpaces();
            Version = Version?.TrimAndPruneSpaces();
            return base.SaveChanges(permission);
        }

        public override void FlushCache()
        {
            base.FlushCache();
        }
        #endregion Entity overrides

        #region Validation
        public DocValidationMessage ValidationMessage
        {
            get
            {
                var isValid = true;
                var message = string.Empty;

                if(DocTools.IsNullOrEmpty(Branch))
                {
                    isValid = false;
                    message += " Branch is a required property.";
                }
                if(DocTools.IsNullOrEmpty(Release))
                {
                    isValid = false;
                    message += " Release is a required property.";
                }
                if(DocTools.IsNullOrEmpty(Server))
                {
                    isValid = false;
                    message += " Server is a required property.";
                }
                if(DocTools.IsNullOrEmpty(URL))
                {
                    isValid = false;
                    message += " URL is a required property.";
                }
                if(DocTools.IsNullOrEmpty(Version))
                {
                    isValid = false;
                    message += " Version is a required property.";
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Converters

        public ReleaseStatus ToDto() => Mapper.Map<DocEntityReleaseStatus, ReleaseStatus>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }

    public static partial class UniqueConstraintFilter
    {
        public static Expression<Func<DocEntityReleaseStatus, bool>> ReleaseStatusIgnoreArchived() => d => d.Archived == false;
    }

    public partial class ReleaseStatusMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityReleaseStatus,ReleaseStatus> _EntityToDto;
        protected IMappingExpression<ReleaseStatus,DocEntityReleaseStatus> _DtoToEntity;

        public ReleaseStatusMapper()
        {
            CreateMap<DocEntitySet<DocEntityReleaseStatus>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityReleaseStatus,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityReleaseStatus>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityReleaseStatus.GetReleaseStatus(c));
            _EntityToDto = CreateMap<DocEntityReleaseStatus,ReleaseStatus>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<ReleaseStatus>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<ReleaseStatus>(c, "Updated")))
                .ForMember(dest => dest.Branch, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<ReleaseStatus>(c, nameof(DocEntityReleaseStatus.Branch))))
                .ForMember(dest => dest.Release, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<ReleaseStatus>(c, nameof(DocEntityReleaseStatus.Release))))
                .ForMember(dest => dest.Server, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<ReleaseStatus>(c, nameof(DocEntityReleaseStatus.Server))))
                .ForMember(dest => dest.URL, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<ReleaseStatus>(c, nameof(DocEntityReleaseStatus.URL))))
                .ForMember(dest => dest.Version, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<ReleaseStatus>(c, nameof(DocEntityReleaseStatus.Version))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<ReleaseStatus,DocEntityReleaseStatus>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}