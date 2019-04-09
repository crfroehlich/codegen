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
    [TableMapping(DocConstantModelName.INTERVENTION)]
    public partial class DocEntityIntervention : DocEntityBase
    {
        private const string INTERVENTION_CACHE = "InterventionCache";
        public const string TABLE_NAME = DocConstantModelName.INTERVENTION;
        
        #region Constructor
        public DocEntityIntervention(Session session) : base(session) {}

        public DocEntityIntervention() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        #region VisibleFields

        protected override List<string> _visibleFields
        {
            get
            {
                if(null == __vf)
                {
                    __vf = DocWebSession.GetTypeVisibleFields(new Intervention());
                }
                return __vf;
            }
        }

        #endregion VisibleFields

        #region Static Members
        public static DocEntityIntervention GetIntervention(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetIntervention(reference.Id) : null;
        }

        public static DocEntityIntervention GetIntervention(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityIntervention>.GetFromCache(primaryKey, INTERVENTION_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityIntervention>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityIntervention>.UpdateCache(ret.Id, ret, INTERVENTION_CACHE);
                    DocEntityThreadCache<DocEntityIntervention>.UpdateCache(ret.Hash, ret, INTERVENTION_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityIntervention GetIntervention(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityIntervention>.GetFromCache(hash, INTERVENTION_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityIntervention>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityIntervention>.UpdateCache(ret.Id, ret, INTERVENTION_CACHE);
                    DocEntityThreadCache<DocEntityIntervention>.UpdateCache(ret.Hash, ret, INTERVENTION_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field]
        public DocEntitySet<DocEntityDocumentSet> DocumentSets { get; private set; }


        public int? DocumentSetsCount { get { return DocumentSets.Count(); } private set { var noid = value; } }


        [Field(Nullable = false, NullableOnUpgrade = true)]
        public string Name { get; set; }


        [Field]
        public string URI { get; set; }



        [Field]
        public override string Gestalt { get; set; }

        [Field(DefaultValue = 0), Version(VersionMode.Manual)]
        public override int VersionNo { get; set; }

        [Field]
        public override DateTime? Created { get; set; }

        [Field]
        public override DateTime? Updated { get; set; }

        [Field(DefaultValue = false), FieldMapping(nameof(Locked))]
        public override bool Locked { get; set; }

        [Field(DefaultValue = false), FieldMapping(nameof(Archived))]
        public override bool Archived { get; set; }

        #endregion Properties

        #region Overrides of DocEntity

        public override DocConstantModelName TableName => TABLE_NAME;

        public const string CACHE_KEY_PREFIX = "FindInterventions";

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
                throw new HttpError(HttpStatusCode.Conflict, $"Intervention requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();

            FlushCache();

            _validated = true;


        }

        public override IDocEntity SaveChanges(DocConstantPermission permission = null)
        {
            Name = Name?.TrimAndPruneSpaces();
            URI = URI?.TrimAndPruneSpaces();
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

        public Intervention ToDto() => Mapper.Map<DocEntityIntervention, Intervention>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }

    public static partial class UniqueConstraintFilter
    {
        public static Expression<Func<DocEntityIntervention, bool>> InterventionIgnoreArchived() => d => d.Archived == false;
    }

    public partial class InterventionMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityIntervention,Intervention> _EntityToDto;
        protected IMappingExpression<Intervention,DocEntityIntervention> _DtoToEntity;

        public InterventionMapper()
        {
            CreateMap<DocEntitySet<DocEntityIntervention>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityIntervention,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityIntervention>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityIntervention.GetIntervention(c));
            _EntityToDto = CreateMap<DocEntityIntervention,Intervention>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Intervention>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Intervention>(c, "Updated")))
                .ForMember(dest => dest.DocumentSets, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Intervention>(c, nameof(DocEntityIntervention.DocumentSets))))
                .ForMember(dest => dest.DocumentSetsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Intervention>(c, nameof(DocEntityIntervention.DocumentSetsCount))))
                .ForMember(dest => dest.Name, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Intervention>(c, nameof(DocEntityIntervention.Name))))
                .ForMember(dest => dest.URI, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Intervention>(c, nameof(DocEntityIntervention.URI))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<Intervention,DocEntityIntervention>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
