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
    [TableMapping(DocConstantModelName.FEATURESET)]
    public partial class DocEntityFeatureSet : DocEntityBase
    {
        private const string FEATURESET_CACHE = "FeatureSetCache";
        public const string TABLE_NAME = DocConstantModelName.FEATURESET;
        
        #region Constructor
        public DocEntityFeatureSet(Session session) : base(session) {}

        public DocEntityFeatureSet() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        #region VisibleFields

        protected override List<string> _visibleFields
        {
            get
            {
                if(null == __vf)
                {
                    __vf = DocWebSession.GetTypeVisibleFields(new FeatureSet());
                }
                return __vf;
            }
        }

        #endregion VisibleFields

        #region Static Members
        public static DocEntityFeatureSet GetFeatureSet(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetFeatureSet(reference.Id) : null;
        }

        public static DocEntityFeatureSet GetFeatureSet(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityFeatureSet>.GetFromCache(primaryKey, FEATURESET_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityFeatureSet>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityFeatureSet>.UpdateCache(ret.Id, ret, FEATURESET_CACHE);
                    DocEntityThreadCache<DocEntityFeatureSet>.UpdateCache(ret.Hash, ret, FEATURESET_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityFeatureSet GetFeatureSet(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityFeatureSet>.GetFromCache(hash, FEATURESET_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityFeatureSet>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityFeatureSet>.UpdateCache(ret.Id, ret, FEATURESET_CACHE);
                    DocEntityThreadCache<DocEntityFeatureSet>.UpdateCache(ret.Hash, ret, FEATURESET_CACHE);
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


        [Field(Length = int.MaxValue)]
        [FieldMapping(nameof(PermissionTemplate))]
        public string PermissionTemplate { get; set; }


        [Field()]
        [FieldMapping(nameof(Roles))]
        public DocEntitySet<DocEntityRole> Roles { get; private set; }


        public int? RolesCount { get { return Roles.Count(); } private set { var noid = value; } }



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

        public const string CACHE_KEY_PREFIX = "FindFeatureSets";

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
                throw new HttpError(HttpStatusCode.Conflict, $"FeatureSet requires: {ValidationMessage.Message}.");
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

        public FeatureSet ToDto() => Mapper.Map<DocEntityFeatureSet, FeatureSet>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }

    public static partial class UniqueConstraintFilter
    {
        public static Expression<Func<DocEntityFeatureSet, bool>> FeatureSetIgnoreArchived() => d => d.Archived == false;
    }

    public partial class FeatureSetMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityFeatureSet,FeatureSet> _EntityToDto;
        protected IMappingExpression<FeatureSet,DocEntityFeatureSet> _DtoToEntity;

        public FeatureSetMapper()
        {
            CreateMap<DocEntitySet<DocEntityFeatureSet>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityFeatureSet,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityFeatureSet>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityFeatureSet.GetFeatureSet(c));
            _EntityToDto = CreateMap<DocEntityFeatureSet,FeatureSet>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<FeatureSet>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<FeatureSet>(c, "Updated")))
                .ForMember(dest => dest.Description, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<FeatureSet>(c, nameof(DocEntityFeatureSet.Description))))
                .ForMember(dest => dest.Name, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<FeatureSet>(c, nameof(DocEntityFeatureSet.Name))))
                .ForMember(dest => dest.PermissionTemplate, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<FeatureSet>(c, nameof(DocEntityFeatureSet.PermissionTemplate))))
                .ForMember(dest => dest.Roles, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<FeatureSet>(c, nameof(DocEntityFeatureSet.Roles))))
                .ForMember(dest => dest.RolesCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<FeatureSet>(c, nameof(DocEntityFeatureSet.RolesCount))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<FeatureSet,DocEntityFeatureSet>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
