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
    [TableMapping(DocConstantModelName.VARIABLERULE)]
    public partial class DocEntityVariableRule : DocEntityBase
    {
        private const string VARIABLERULE_CACHE = "VariableRuleCache";
        public const string TABLE_NAME = DocConstantModelName.VARIABLERULE;
        
        #region Constructor
        public DocEntityVariableRule(Session session) : base(session) {}

        public DocEntityVariableRule() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        #region VisibleFields

        protected override List<string> _visibleFields
        {
            get
            {
                if(null == __vf)
                {
                    __vf = DocWebSession.GetTypeVisibleFields(new VariableRule());
                }
                return __vf;
            }
        }

        #endregion VisibleFields

        #region Static Members
        public static DocEntityVariableRule GetVariableRule(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetVariableRule(reference.Id) : null;
        }

        public static DocEntityVariableRule GetVariableRule(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityVariableRule>.GetFromCache(primaryKey, VARIABLERULE_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityVariableRule>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityVariableRule>.UpdateCache(ret.Id, ret, VARIABLERULE_CACHE);
                    DocEntityThreadCache<DocEntityVariableRule>.UpdateCache(ret.Hash, ret, VARIABLERULE_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityVariableRule GetVariableRule(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityVariableRule>.GetFromCache(hash, VARIABLERULE_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityVariableRule>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityVariableRule>.UpdateCache(ret.Id, ret, VARIABLERULE_CACHE);
                    DocEntityThreadCache<DocEntityVariableRule>.UpdateCache(ret.Hash, ret, VARIABLERULE_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field()]
        [FieldMapping(nameof(Children))]
        [Association( PairTo = nameof(VariableRule.Owner), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear )]
        public DocEntitySet<DocEntityVariableRule> Children { get; private set; }


        public int? ChildrenCount { get { return Children.Count(); } private set { var noid = value; } }


        [Field(Length = int.MaxValue)]
        [FieldMapping(nameof(Definition))]
        public string Definition { get; set; }


        [Field()]
        [FieldMapping(nameof(Instances))]
        [Association( PairTo = nameof(VariableInstance.Rule), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear )]
        public DocEntitySet<DocEntityVariableInstance> Instances { get; private set; }


        public int? InstancesCount { get { return Instances.Count(); } private set { var noid = value; } }


        [Field(Nullable = false)]
        [FieldMapping(nameof(Name))]
        public string Name { get; set; }


        [Field()]
        [FieldMapping(nameof(Owner))]
        public DocEntityVariableRule Owner { get; set; }
        public int? OwnerId { get { return Owner?.Id; } private set { var noid = value; } }


        [Field(Nullable = false)]
        [FieldMapping(nameof(Rule))]
        public DocEntityLookupTable Rule { get; set; }
        public int? RuleId { get { return Rule?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Scopes))]
        public DocEntitySet<DocEntityScope> Scopes { get; private set; }


        public int? ScopesCount { get { return Scopes.Count(); } private set { var noid = value; } }


        [Field(Nullable = false)]
        [FieldMapping(nameof(Type))]
        public DocEntityLookupTable Type { get; set; }
        public int? TypeId { get { return Type?.Id; } private set { var noid = value; } }



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

        public const string CACHE_KEY_PREFIX = "FindVariableRules";


        public override T ToModel<T>() =>  null;

        #endregion Overrides of DocEntity

        #region Entity overrides
        /// <summary>
        ///    Called when entity is about to be removed.
        /// </summary>
        protected override void OnRemoving()
        {
            try
            {
                Children.Clear(); //foreach thing in Children en.Remove();
            }
            catch(Exception ex)
            {
                throw new DocException("Failed to delete VariableRule in Children delete", ex);
            }
            try
            {
                Instances.Clear(); //foreach thing in Instances en.Remove();
            }
            catch(Exception ex)
            {
                throw new DocException("Failed to delete VariableRule in Instances delete", ex);
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
                throw new HttpError(HttpStatusCode.Conflict, $"VariableRule requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();

            FlushCache();

            _validated = true;

        }

        public override IDocEntity SaveChanges(DocConstantPermission permission = null)
        {
            Name = Name?.TrimAndPruneSpaces();
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
                if(DocTools.IsNullOrEmpty(Rule))
                {
                    isValid = false;
                    message += " Rule is a required property.";
                }
                else
                {
                    if(Rule.Enum?.Name != "VariableRule")
                    {
                        isValid = false;
                        message += " Rule is a " + Rule.Enum.Name + ", but must be a VariableRule.";
                    }
                }
                if(DocTools.IsNullOrEmpty(Type))
                {
                    isValid = false;
                    message += " Type is a required property.";
                }
                else
                {
                    if(Type.Enum?.Name != "VariableType")
                    {
                        isValid = false;
                        message += " Type is a " + Type.Enum.Name + ", but must be a VariableType.";
                    }
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Converters

        public VariableRule ToDto() => Mapper.Map<DocEntityVariableRule, VariableRule>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }

    public partial class VariableRuleMapper : DocMapperBase
    {
        private IMappingExpression<DocEntityVariableRule,VariableRule> _EntityToDto;
        private IMappingExpression<VariableRule,DocEntityVariableRule> _DtoToEntity;

        public VariableRuleMapper()
        {
            CreateMap<DocEntitySet<DocEntityVariableRule>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityVariableRule,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityVariableRule>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityVariableRule.GetVariableRule(c));
            _EntityToDto = CreateMap<DocEntityVariableRule,VariableRule>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<VariableRule>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<VariableRule>(c, "Updated")))
                .ForMember(dest => dest.Children, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<VariableRule>(c, nameof(DocEntityVariableRule.Children))))
                .ForMember(dest => dest.ChildrenCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<VariableRule>(c, nameof(DocEntityVariableRule.ChildrenCount))))
                .ForMember(dest => dest.Definition, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<VariableRule>(c, nameof(DocEntityVariableRule.Definition))))
                .ForMember(dest => dest.Instances, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<VariableRule>(c, nameof(DocEntityVariableRule.Instances))))
                .ForMember(dest => dest.InstancesCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<VariableRule>(c, nameof(DocEntityVariableRule.InstancesCount))))
                .ForMember(dest => dest.Name, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<VariableRule>(c, nameof(DocEntityVariableRule.Name))))
                .ForMember(dest => dest.Owner, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<VariableRule>(c, nameof(DocEntityVariableRule.Owner))))
                .ForMember(dest => dest.OwnerId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<VariableRule>(c, nameof(DocEntityVariableRule.OwnerId))))
                .ForMember(dest => dest.Rule, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<VariableRule>(c, nameof(DocEntityVariableRule.Rule))))
                .ForMember(dest => dest.RuleId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<VariableRule>(c, nameof(DocEntityVariableRule.RuleId))))
                .ForMember(dest => dest.Scopes, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<VariableRule>(c, nameof(DocEntityVariableRule.Scopes))))
                .ForMember(dest => dest.ScopesCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<VariableRule>(c, nameof(DocEntityVariableRule.ScopesCount))))
                .ForMember(dest => dest.Type, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<VariableRule>(c, nameof(DocEntityVariableRule.Type))))
                .ForMember(dest => dest.TypeId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<VariableRule>(c, nameof(DocEntityVariableRule.TypeId))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<VariableRule,DocEntityVariableRule>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}