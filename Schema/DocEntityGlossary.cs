//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated by a T4 template. This class can be only customized modifying the corresponding partial class.
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
    [TableMapping(DocConstantModelName.GLOSSARY)]
    public partial class DocEntityGlossary : DocEntityBase
    {
        private const string GLOSSARY_CACHE = "GlossaryCache";
        public const string TABLE_NAME = DocConstantModelName.GLOSSARY;
        
        #region Constructor
        public DocEntityGlossary(Session session) : base(session) {}

        public DocEntityGlossary() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        #region VisibleFields

        protected override List<string> _visibleFields
        {
            get
            {
                if(null == __vf)
                {
                    __vf = DocWebSession.GetTypeVisibleFields(new Glossary());
                }
                return __vf;
            }
        }

        #endregion VisibleFields

        #region Static Members
        public static DocEntityGlossary GetGlossary(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetGlossary(reference.Id) : null;
        }

        public static DocEntityGlossary GetGlossary(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityGlossary>.GetFromCache(primaryKey, GLOSSARY_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityGlossary>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityGlossary>.UpdateCache(ret.Id, ret, GLOSSARY_CACHE);
                    DocEntityThreadCache<DocEntityGlossary>.UpdateCache(ret.Hash, ret, GLOSSARY_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityGlossary GetGlossary(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityGlossary>.GetFromCache(hash, GLOSSARY_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityGlossary>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityGlossary>.UpdateCache(ret.Id, ret, GLOSSARY_CACHE);
                    DocEntityThreadCache<DocEntityGlossary>.UpdateCache(ret.Hash, ret, GLOSSARY_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field(Length = int.MaxValue)]
        [FieldMapping(nameof(Definition))]
        public string Definition { get; set; }


        [Field(Nullable = false)]
        [FieldMapping(nameof(Enum))]
        public DocEntityLookupTableEnum Enum { get; set; }
        public int? EnumId { get { return Enum?.Id; } private set { var noid = value; } }


        [Field(DefaultValue = "fa fa-info-circle")]
        [FieldMapping(nameof(Icon))]
        public string Icon { get; set; }


        [Field()]
        [FieldMapping(nameof(Page))]
        public DocEntityPage Page { get; set; }
        public int? PageId { get { return Page?.Id; } private set { var noid = value; } }


        [Field(Nullable = false)]
        [FieldMapping(nameof(Term))]
        public DocEntityTermMaster Term { get; set; }
        public int? TermId { get { return Term?.Id; } private set { var noid = value; } }



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

        public const string CACHE_KEY_PREFIX = "FindGlossarys";

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
                throw new HttpError(HttpStatusCode.Conflict, $"Glossary requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();

            FlushCache();

            _validated = true;


        }

        public override IDocEntity SaveChanges(DocConstantPermission permission = null)
        {
            Icon = Icon?.TrimAndPruneSpaces();
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

                if(DocTools.IsNullOrEmpty(Enum))
                {
                    isValid = false;
                    message += " Enum is a required property.";
                }
                if(DocTools.IsNullOrEmpty(Term))
                {
                    isValid = false;
                    message += " Term is a required property.";
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Converters

        public Glossary ToDto() => Mapper.Map<DocEntityGlossary, Glossary>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }

    public static partial class UniqueConstraintFilter
    {
        public static Expression<Func<DocEntityGlossary, bool>> GlossaryIgnoreArchived() => d => d.Archived == false;
    }

    public partial class GlossaryMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityGlossary,Glossary> _EntityToDto;
        protected IMappingExpression<Glossary,DocEntityGlossary> _DtoToEntity;

        public GlossaryMapper()
        {
            CreateMap<DocEntitySet<DocEntityGlossary>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityGlossary,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityGlossary>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityGlossary.GetGlossary(c));
            _EntityToDto = CreateMap<DocEntityGlossary,Glossary>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Glossary>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Glossary>(c, "Updated")))
                .ForMember(dest => dest.Definition, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Glossary>(c, nameof(DocEntityGlossary.Definition))))
                .ForMember(dest => dest.Enum, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Glossary>(c, nameof(DocEntityGlossary.Enum))))
                .ForMember(dest => dest.EnumId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Glossary>(c, nameof(DocEntityGlossary.EnumId))))
                .ForMember(dest => dest.Icon, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Glossary>(c, nameof(DocEntityGlossary.Icon))))
                .ForMember(dest => dest.Page, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Glossary>(c, nameof(DocEntityGlossary.Page))))
                .ForMember(dest => dest.PageId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Glossary>(c, nameof(DocEntityGlossary.PageId))))
                .ForMember(dest => dest.Term, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Glossary>(c, nameof(DocEntityGlossary.Term))))
                .ForMember(dest => dest.TermId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Glossary>(c, nameof(DocEntityGlossary.TermId))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<Glossary,DocEntityGlossary>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
