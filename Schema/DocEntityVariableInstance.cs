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
    [TableMapping(DocConstantModelName.VARIABLEINSTANCE)]
    public partial class DocEntityVariableInstance : DocEntityBase
    {
        private const string VARIABLEINSTANCE_CACHE = "VariableInstanceCache";
        public const string TABLE_NAME = DocConstantModelName.VARIABLEINSTANCE;
        
        #region Constructor
        public DocEntityVariableInstance(Session session) : base(session) {}

        public DocEntityVariableInstance() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        #region VisibleFields

        protected override List<string> _visibleFields
        {
            get
            {
                if(null == __vf)
                {
                    __vf = DocWebSession.GetTypeVisibleFields(new VariableInstance());
                }
                return __vf;
            }
        }

        #endregion VisibleFields

        #region Static Members
        public static DocEntityVariableInstance GetVariableInstance(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetVariableInstance(reference.Id) : null;
        }

        public static DocEntityVariableInstance GetVariableInstance(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityVariableInstance>.GetFromCache(primaryKey, VARIABLEINSTANCE_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityVariableInstance>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityVariableInstance>.UpdateCache(ret.Id, ret, VARIABLEINSTANCE_CACHE);
                    DocEntityThreadCache<DocEntityVariableInstance>.UpdateCache(ret.Hash, ret, VARIABLEINSTANCE_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityVariableInstance GetVariableInstance(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityVariableInstance>.GetFromCache(hash, VARIABLEINSTANCE_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityVariableInstance>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityVariableInstance>.UpdateCache(ret.Id, ret, VARIABLEINSTANCE_CACHE);
                    DocEntityThreadCache<DocEntityVariableInstance>.UpdateCache(ret.Hash, ret, VARIABLEINSTANCE_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field(DefaultValue = "{}", Length = int.MaxValue)]
        [FieldMapping(nameof(Data))]
        public string Data { get; set; }


        [Field(Nullable = false)]
        [FieldMapping(nameof(Document))]
        public DocEntityDocument Document { get; set; }
        public int? DocumentId { get { return Document?.Id; } private set { var noid = value; } }


        [Field(Nullable = false)]
        [FieldMapping(nameof(Rule))]
        public DocEntityVariableRule Rule { get; set; }
        public int? RuleId { get { return Rule?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Workflows))]
        [Association( PairTo = nameof(Workflow.Variables), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear )]
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

        [Field]
        public override bool Locked { get; set; }
        #endregion Properties

        #region Overrides of DocEntity

        public override DocConstantModelName TableName => TABLE_NAME;

        public const string CACHE_KEY_PREFIX = "FindVariableInstances";


        public override T ToModel<T>() =>  null;

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
                throw new HttpError(HttpStatusCode.Conflict, $"VariableInstance requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();

            FlushCache();

            _validated = true;

        }

        public override IDocEntity SaveChanges(DocConstantPermission permission = null)
        {
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

                if(DocTools.IsNullOrEmpty(Document))
                {
                    isValid = false;
                    message += " Document is a required property.";
                }
                if(DocTools.IsNullOrEmpty(Rule))
                {
                    isValid = false;
                    message += " Rule is a required property.";
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Converters

        public VariableInstance ToDto() => Mapper.Map<DocEntityVariableInstance, VariableInstance>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }

    public partial class VariableInstanceMapper : DocMapperBase
    {
        private IMappingExpression<DocEntityVariableInstance,VariableInstance> _EntityToDto;
        private IMappingExpression<VariableInstance,DocEntityVariableInstance> _DtoToEntity;

        public VariableInstanceMapper()
        {
            CreateMap<DocEntitySet<DocEntityVariableInstance>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityVariableInstance,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityVariableInstance>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityVariableInstance.GetVariableInstance(c));
            _EntityToDto = CreateMap<DocEntityVariableInstance,VariableInstance>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<VariableInstance>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<VariableInstance>(c, "Updated")))
                .ForMember(dest => dest.Data, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<VariableInstance>(c, nameof(DocEntityVariableInstance.Data))))
                .ForMember(dest => dest.Document, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<VariableInstance>(c, nameof(DocEntityVariableInstance.Document))))
                .ForMember(dest => dest.DocumentId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<VariableInstance>(c, nameof(DocEntityVariableInstance.DocumentId))))
                .ForMember(dest => dest.Rule, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<VariableInstance>(c, nameof(DocEntityVariableInstance.Rule))))
                .ForMember(dest => dest.RuleId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<VariableInstance>(c, nameof(DocEntityVariableInstance.RuleId))))
                .ForMember(dest => dest.Workflows, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<VariableInstance>(c, nameof(DocEntityVariableInstance.Workflows))))
                .ForMember(dest => dest.WorkflowsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<VariableInstance>(c, nameof(DocEntityVariableInstance.WorkflowsCount))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<VariableInstance,DocEntityVariableInstance>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}