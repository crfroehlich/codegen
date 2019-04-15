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
    [TableMapping(DocConstantModelName.LOOKUPTABLEBINDING)]
    public partial class DocEntityLookupTableBinding : DocEntityBase
    {
        private const string LOOKUPTABLEBINDING_CACHE = "LookupTableBindingCache";
        public const string TABLE_NAME = DocConstantModelName.LOOKUPTABLEBINDING;
        
        #region Constructor
        public DocEntityLookupTableBinding(Session session) : base(session) {}

        public DocEntityLookupTableBinding() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        #region VisibleFields

        protected override List<string> _visibleFields
        {
            get
            {
                if(null == __vf)
                {
                    __vf = DocWebSession.GetTypeVisibleFields(new LookupTableBinding());
                }
                return __vf;
            }
        }

        #endregion VisibleFields

        #region Static Members
        public static DocEntityLookupTableBinding GetLookupTableBinding(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetLookupTableBinding(reference.Id) : null;
        }

        public static DocEntityLookupTableBinding GetLookupTableBinding(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityLookupTableBinding>.GetFromCache(primaryKey, LOOKUPTABLEBINDING_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityLookupTableBinding>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityLookupTableBinding>.UpdateCache(ret.Id, ret, LOOKUPTABLEBINDING_CACHE);
                    DocEntityThreadCache<DocEntityLookupTableBinding>.UpdateCache(ret.Hash, ret, LOOKUPTABLEBINDING_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityLookupTableBinding GetLookupTableBinding(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityLookupTableBinding>.GetFromCache(hash, LOOKUPTABLEBINDING_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityLookupTableBinding>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityLookupTableBinding>.UpdateCache(ret.Id, ret, LOOKUPTABLEBINDING_CACHE);
                    DocEntityThreadCache<DocEntityLookupTableBinding>.UpdateCache(ret.Hash, ret, LOOKUPTABLEBINDING_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field(DefaultValue = "{}", Length = int.MaxValue)]
        [FieldMapping(nameof(Binding))]
        public string Binding { get; set; }


        [Field()]
        [FieldMapping(nameof(BoundName))]
        public string BoundName { get; set; }


        [Field(Nullable = false)]
        [FieldMapping(nameof(LookupTable))]
        public DocEntityLookupTable LookupTable { get; set; }
        public int? LookupTableId { get { return LookupTable?.Id; } private set { var noid = value; } }


        [Field(Nullable = false)]
        [FieldMapping(nameof(Scope))]
        public DocEntityScope Scope { get; set; }
        public int? ScopeId { get { return Scope?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Synonyms))]
        [Association(PairTo = nameof(DocEntityTermSynonym.Bindings), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityTermSynonym> Synonyms { get; private set; }


        public int? SynonymsCount { get { return Synonyms.Count(); } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Workflows))]
        [Association(PairTo = nameof(DocEntityWorkflow.Bindings), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityWorkflow> Workflows { get; private set; }


        public int? WorkflowsCount { get { return Workflows.Count(); } private set { var noid = value; } }



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

        public const string CACHE_KEY_PREFIX = "FindLookupTableBindings";

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
                throw new HttpError(HttpStatusCode.Conflict, $"LookupTableBinding requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();

            FlushCache();

            _validated = true;


        }

        public override IDocEntity SaveChanges(DocConstantPermission permission = null)
        {
            BoundName = BoundName?.TrimAndPruneSpaces();
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

                if(DocTools.IsNullOrEmpty(LookupTable))
                {
                    isValid = false;
                    message += " LookupTable is a required property.";
                }
                else
                {
                    if(DocTools.IsNullOrEmpty(LookupTable.Enum?.Name))
                    {
                        isValid = false;
                        message += " LookupTable is a " + LookupTable.Enum?.Name + ", but must be a .";
                    }
                }
                if(DocTools.IsNullOrEmpty(Scope))
                {
                    isValid = false;
                    message += " Scope is a required property.";
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Converters

        public LookupTableBinding ToDto() => Mapper.Map<DocEntityLookupTableBinding, LookupTableBinding>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }

    public static partial class UniqueConstraintFilter
    {
        public static Expression<Func<DocEntityLookupTableBinding, bool>> LookupTableBindingIgnoreArchived() => d => d.Archived == false;
    }

    public partial class LookupTableBindingMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityLookupTableBinding,LookupTableBinding> _EntityToDto;
        protected IMappingExpression<LookupTableBinding,DocEntityLookupTableBinding> _DtoToEntity;

        public LookupTableBindingMapper()
        {
            CreateMap<DocEntitySet<DocEntityLookupTableBinding>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityLookupTableBinding,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityLookupTableBinding>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityLookupTableBinding.GetLookupTableBinding(c));
            _EntityToDto = CreateMap<DocEntityLookupTableBinding,LookupTableBinding>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LookupTableBinding>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LookupTableBinding>(c, "Updated")))
                .ForMember(dest => dest.Binding, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LookupTableBinding>(c, nameof(DocEntityLookupTableBinding.Binding))))
                .ForMember(dest => dest.BoundName, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LookupTableBinding>(c, nameof(DocEntityLookupTableBinding.BoundName))))
                .ForMember(dest => dest.LookupTable, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LookupTableBinding>(c, nameof(DocEntityLookupTableBinding.LookupTable))))
                .ForMember(dest => dest.LookupTableId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LookupTableBinding>(c, nameof(DocEntityLookupTableBinding.LookupTableId))))
                .ForMember(dest => dest.Scope, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LookupTableBinding>(c, nameof(DocEntityLookupTableBinding.Scope))))
                .ForMember(dest => dest.ScopeId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LookupTableBinding>(c, nameof(DocEntityLookupTableBinding.ScopeId))))
                .ForMember(dest => dest.Synonyms, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LookupTableBinding>(c, nameof(DocEntityLookupTableBinding.Synonyms))))
                .ForMember(dest => dest.SynonymsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LookupTableBinding>(c, nameof(DocEntityLookupTableBinding.SynonymsCount))))
                .ForMember(dest => dest.Workflows, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LookupTableBinding>(c, nameof(DocEntityLookupTableBinding.Workflows))))
                .ForMember(dest => dest.WorkflowsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<LookupTableBinding>(c, nameof(DocEntityLookupTableBinding.WorkflowsCount))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<LookupTableBinding,DocEntityLookupTableBinding>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
