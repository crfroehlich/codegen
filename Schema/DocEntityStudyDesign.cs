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
    [TableMapping(DocConstantModelName.STUDYDESIGN)]
    public partial class DocEntityStudyDesign : DocEntityBase
    {
        private const string STUDYDESIGN_CACHE = "StudyDesignCache";
        public const string TABLE_NAME = DocConstantModelName.STUDYDESIGN;
        
        #region Constructor
        public DocEntityStudyDesign(Session session) : base(session) {}

        public DocEntityStudyDesign() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        #region VisibleFields

        protected override List<string> _visibleFields
        {
            get
            {
                if(null == __vf)
                {
                    __vf = DocWebSession.GetTypeVisibleFields(new StudyDesign());
                }
                return __vf;
            }
        }

        #endregion VisibleFields

        #region Static Members
        public static DocEntityStudyDesign GetStudyDesign(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetStudyDesign(reference.Id) : null;
        }

        public static DocEntityStudyDesign GetStudyDesign(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityStudyDesign>.GetFromCache(primaryKey, STUDYDESIGN_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityStudyDesign>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityStudyDesign>.UpdateCache(ret.Id, ret, STUDYDESIGN_CACHE);
                    DocEntityThreadCache<DocEntityStudyDesign>.UpdateCache(ret.Hash, ret, STUDYDESIGN_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityStudyDesign GetStudyDesign(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityStudyDesign>.GetFromCache(hash, STUDYDESIGN_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityStudyDesign>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityStudyDesign>.UpdateCache(ret.Id, ret, STUDYDESIGN_CACHE);
                    DocEntityThreadCache<DocEntityStudyDesign>.UpdateCache(ret.Hash, ret, STUDYDESIGN_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field(Nullable = false)]
        [FieldMapping(nameof(Design))]
        public DocEntityLookupTable Design { get; set; }
        public int? DesignId { get { return Design?.Id; } private set { var noid = value; } }



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

        public const string CACHE_KEY_PREFIX = "FindStudyDesigns";


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
                throw new HttpError(HttpStatusCode.Conflict, $"StudyDesign requires: {ValidationMessage.Message}.");
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

                if(DocTools.IsNullOrEmpty(Design))
                {
                    isValid = false;
                    message += " Design is a required property.";
                }
                else
                {
                    if(Design.Enum?.Name != "StudyDesign")
                    {
                        isValid = false;
                        message += " Design is a " + Design.Enum.Name + ", but must be a StudyDesign.";
                    }
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Converters

        public StudyDesign ToDto() => Mapper.Map<DocEntityStudyDesign, StudyDesign>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }

    public static partial class UniqueConstraintFilter
    {
        public static Expression<Func<DocEntityStudyDesign, bool>> StudyDesignIgnoreArchived() => d => d.Archived == false;
    }

    public partial class StudyDesignMapper : DocMapperBase
    {
        private IMappingExpression<DocEntityStudyDesign,StudyDesign> _EntityToDto;
        private IMappingExpression<StudyDesign,DocEntityStudyDesign> _DtoToEntity;
        public StudyDesignMapper()
        {
            CreateMap<DocEntitySet<DocEntityStudyDesign>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityStudyDesign,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityStudyDesign>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityStudyDesign.GetStudyDesign(c));
            _EntityToDto = CreateMap<DocEntityStudyDesign,StudyDesign>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<StudyDesign>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<StudyDesign>(c, "Updated")))
                .ForMember(dest => dest.Design, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<StudyDesign>(c, nameof(DocEntityStudyDesign.Design))))
                .ForMember(dest => dest.DesignId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<StudyDesign>(c, nameof(DocEntityStudyDesign.DesignId))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<StudyDesign,DocEntityStudyDesign>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}