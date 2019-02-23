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
    [TableMapping(DocConstantModelName.DIVISION)]
    public partial class DocEntityDivision : DocEntityBase
    {
        private const string DIVISION_CACHE = "DivisionCache";
        public const string TABLE_NAME = DocConstantModelName.DIVISION;
        
        #region Constructor
        public DocEntityDivision(Session session) : base(session) {}

        public DocEntityDivision() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        #region VisibleFields

        protected override List<string> _visibleFields
        {
            get
            {
                if(null == __vf)
                {
                    __vf = DocWebSession.GetTypeVisibleFields(new Division());
                }
                return __vf;
            }
        }

        #endregion VisibleFields

        #region Static Members
        public static DocEntityDivision GetDivision(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetDivision(reference.Id) : null;
        }

        public static DocEntityDivision GetDivision(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityDivision>.GetFromCache(primaryKey, DIVISION_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityDivision>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityDivision>.UpdateCache(ret.Id, ret, DIVISION_CACHE);
                    DocEntityThreadCache<DocEntityDivision>.UpdateCache(ret.Hash, ret, DIVISION_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityDivision GetDivision(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityDivision>.GetFromCache(hash, DIVISION_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityDivision>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityDivision>.UpdateCache(ret.Id, ret, DIVISION_CACHE);
                    DocEntityThreadCache<DocEntityDivision>.UpdateCache(ret.Hash, ret, DIVISION_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field(Nullable = false)]
        [FieldMapping(nameof(Client))]
        public DocEntityClient Client { get; set; }
        public int? ClientId { get { return Client?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(DefaultLocale))]
        public DocEntityLocale DefaultLocale { get; set; }
        public int? DefaultLocaleId { get { return DefaultLocale?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(DocumentSets))]
        public DocEntitySet<DocEntityDocumentSet> DocumentSets { get; private set; }


        public int? DocumentSetsCount { get { return DocumentSets.Count(); } private set { var noid = value; } }


        [Field(Nullable = false)]
        [FieldMapping(nameof(Name))]
        public string Name { get; set; }


        [Field(Nullable = false)]
        [FieldMapping(nameof(Role))]
        public DocEntityRole Role { get; set; }
        public int? RoleId { get { return Role?.Id; } private set { var noid = value; } }


        [Field(Length = int.MaxValue)]
        [FieldMapping(nameof(Settings))]
        public string Settings { get; set; }


        [Field()]
        [FieldMapping(nameof(Users))]
        [Association(PairTo = nameof(DocEntityUser.Division), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityUser> Users { get; private set; }


        public int? UsersCount { get { return Users.Count(); } private set { var noid = value; } }



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

        public const string CACHE_KEY_PREFIX = "FindDivisions";


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
                Users.Clear(); //foreach thing in Users en.Remove();
            }
            catch(Exception ex)
            {
                throw new DocException("Failed to delete Division in Users delete", ex);
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
                throw new HttpError(HttpStatusCode.Conflict, $"Division requires: {ValidationMessage.Message}.");
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

                if(DocTools.IsNullOrEmpty(Client))
                {
                    isValid = false;
                    message += " Client is a required property.";
                }
                if(DocTools.IsNullOrEmpty(Name))
                {
                    isValid = false;
                    message += " Name is a required property.";
                }
                if(DocTools.IsNullOrEmpty(Role))
                {
                    isValid = false;
                    message += " Role is a required property.";
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Converters

        public Division ToDto() => Mapper.Map<DocEntityDivision, Division>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }

    public static partial class UniqueConstraintFilter
    {
        public static Expression<Func<DocEntityDivision, bool>> DivisionIgnoreArchived() => d => d.Archived == false;
    }

    public partial class DivisionMapper : DocMapperBase
    {
        private IMappingExpression<DocEntityDivision,Division> _EntityToDto;
        private IMappingExpression<Division,DocEntityDivision> _DtoToEntity;
        public DivisionMapper()
        {
            CreateMap<DocEntitySet<DocEntityDivision>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityDivision,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityDivision>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityDivision.GetDivision(c));
            _EntityToDto = CreateMap<DocEntityDivision,Division>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Division>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Division>(c, "Updated")))
                .ForMember(dest => dest.Client, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Division>(c, nameof(DocEntityDivision.Client))))
                .ForMember(dest => dest.ClientId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Division>(c, nameof(DocEntityDivision.ClientId))))
                .ForMember(dest => dest.DefaultLocale, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Division>(c, nameof(DocEntityDivision.DefaultLocale))))
                .ForMember(dest => dest.DefaultLocaleId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Division>(c, nameof(DocEntityDivision.DefaultLocaleId))))
                .ForMember(dest => dest.DocumentSets, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Division>(c, nameof(DocEntityDivision.DocumentSets))))
                .ForMember(dest => dest.DocumentSetsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Division>(c, nameof(DocEntityDivision.DocumentSetsCount))))
                .ForMember(dest => dest.Name, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Division>(c, nameof(DocEntityDivision.Name))))
                .ForMember(dest => dest.Role, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Division>(c, nameof(DocEntityDivision.Role))))
                .ForMember(dest => dest.RoleId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Division>(c, nameof(DocEntityDivision.RoleId))))
                .ForMember(dest => dest.Settings, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Division>(c, nameof(DocEntityDivision.Settings))))
                .ForMember(dest => dest.Users, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Division>(c, nameof(DocEntityDivision.Users))))
                .ForMember(dest => dest.UsersCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Division>(c, nameof(DocEntityDivision.UsersCount))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<Division,DocEntityDivision>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}