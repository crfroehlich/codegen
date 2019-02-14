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
    [TableMapping(DocConstantModelName.TAG)]
    public partial class DocEntityTag : DocEntityBase
    {
        private const string TAG_CACHE = "TagCache";
        public const string TABLE_NAME = DocConstantModelName.TAG;
        
        #region Constructor
        public DocEntityTag(Session session) : base(session) {}

        public DocEntityTag() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        #region VisibleFields

        protected override List<string> _visibleFields
        {
            get
            {
                if(null == __vf)
                {
                    __vf = DocWebSession.GetTypeVisibleFields(new Tag());
                }
                return __vf;
            }
        }

        #endregion VisibleFields

        #region Static Members
        public static DocEntityTag GetTag(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetTag(reference.Id) : null;
        }

        public static DocEntityTag GetTag(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityTag>.GetFromCache(primaryKey, TAG_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityTag>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityTag>.UpdateCache(ret.Id, ret, TAG_CACHE);
                    DocEntityThreadCache<DocEntityTag>.UpdateCache(ret.Hash, ret, TAG_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityTag GetTag(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityTag>.GetFromCache(hash, TAG_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityTag>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityTag>.UpdateCache(ret.Id, ret, TAG_CACHE);
                    DocEntityThreadCache<DocEntityTag>.UpdateCache(ret.Hash, ret, TAG_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field(Nullable = false)]
        [FieldMapping(nameof(Name))]
        public string Name { get; set; }


        [Field()]
        [FieldMapping(nameof(Workflows))]
        [Association( PairTo = nameof(Workflow.Tags), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear )]
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

        public const string CACHE_KEY_PREFIX = "FindTags";


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
                throw new HttpError(HttpStatusCode.Conflict, $"Tag requires: {ValidationMessage.Message}.");
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

        public Tag ToDto() => Mapper.Map<DocEntityTag, Tag>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }

    public partial class TagMapper : DocMapperBase
    {
        private IMappingExpression<DocEntityTag,Tag> _EntityToDto;
        private IMappingExpression<Tag,DocEntityTag> _DtoToEntity;

        public TagMapper()
        {
            CreateMap<DocEntitySet<DocEntityTag>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityTag,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityTag>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityTag.GetTag(c));
            _EntityToDto = CreateMap<DocEntityTag,Tag>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Tag>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Tag>(c, "Updated")))
                .ForMember(dest => dest.Name, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Tag>(c, nameof(DocEntityTag.Name))))
                .ForMember(dest => dest.Workflows, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Tag>(c, nameof(DocEntityTag.Workflows))))
                .ForMember(dest => dest.WorkflowsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Tag>(c, nameof(DocEntityTag.WorkflowsCount))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<Tag,DocEntityTag>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}