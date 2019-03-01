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
    [TableMapping(DocConstantModelName.OUTCOME)]
    public partial class DocEntityOutcome : DocEntityBase
    {
        private const string OUTCOME_CACHE = "OutcomeCache";
        public const string TABLE_NAME = DocConstantModelName.OUTCOME;
        
        #region Constructor
        public DocEntityOutcome(Session session) : base(session) {}

        public DocEntityOutcome() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        #region VisibleFields

        protected override List<string> _visibleFields
        {
            get
            {
                if(null == __vf)
                {
                    __vf = DocWebSession.GetTypeVisibleFields(new Outcome());
                }
                return __vf;
            }
        }

        #endregion VisibleFields

        #region Static Members
        public static DocEntityOutcome GetOutcome(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetOutcome(reference.Id) : null;
        }

        public static DocEntityOutcome GetOutcome(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityOutcome>.GetFromCache(primaryKey, OUTCOME_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityOutcome>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityOutcome>.UpdateCache(ret.Id, ret, OUTCOME_CACHE);
                    DocEntityThreadCache<DocEntityOutcome>.UpdateCache(ret.Hash, ret, OUTCOME_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityOutcome GetOutcome(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityOutcome>.GetFromCache(hash, OUTCOME_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityOutcome>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityOutcome>.UpdateCache(ret.Id, ret, OUTCOME_CACHE);
                    DocEntityThreadCache<DocEntityOutcome>.UpdateCache(ret.Hash, ret, OUTCOME_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field()]
        [FieldMapping(nameof(DocumentSets))]
        public DocEntitySet<DocEntityDocumentSet> DocumentSets { get; private set; }


        public int? DocumentSetsCount { get { return DocumentSets.Count(); } private set { var noid = value; } }


        [Field(Nullable = false, NullableOnUpgrade = true)]
        [FieldMapping(nameof(Name))]
        public string Name { get; set; }


        [Field()]
        [FieldMapping(nameof(URI))]
        public string URI { get; set; }



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

        public const string CACHE_KEY_PREFIX = "FindOutcomes";

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
                throw new HttpError(HttpStatusCode.Conflict, $"Outcome requires: {ValidationMessage.Message}.");
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

        public Outcome ToDto() => Mapper.Map<DocEntityOutcome, Outcome>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }

    public static partial class UniqueConstraintFilter
    {
        public static Expression<Func<DocEntityOutcome, bool>> OutcomeIgnoreArchived() => d => d.Archived == false;
    }

    public partial class OutcomeMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityOutcome,Outcome> _EntityToDto;
        protected IMappingExpression<Outcome,DocEntityOutcome> _DtoToEntity;

        public OutcomeMapper()
        {
            CreateMap<DocEntitySet<DocEntityOutcome>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityOutcome,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityOutcome>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityOutcome.GetOutcome(c));
            _EntityToDto = CreateMap<DocEntityOutcome,Outcome>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Outcome>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Outcome>(c, "Updated")))
                .ForMember(dest => dest.DocumentSets, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Outcome>(c, nameof(DocEntityOutcome.DocumentSets))))
                .ForMember(dest => dest.DocumentSetsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Outcome>(c, nameof(DocEntityOutcome.DocumentSetsCount))))
                .ForMember(dest => dest.Name, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Outcome>(c, nameof(DocEntityOutcome.Name))))
                .ForMember(dest => dest.URI, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Outcome>(c, nameof(DocEntityOutcome.URI))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<Outcome,DocEntityOutcome>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
