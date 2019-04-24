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
    [TableMapping(DocConstantModelName.IMPERSONATION)]
    public partial class DocEntityImpersonation : DocEntityBase
    {
        private const string IMPERSONATION_CACHE = "ImpersonationCache";
        public const string TABLE_NAME = DocConstantModelName.IMPERSONATION;
        
        #region Constructor
        public DocEntityImpersonation(Session session) : base(session) {}

        public DocEntityImpersonation() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        #region VisibleFields

        protected override List<string> _visibleFields
        {
            get
            {
                if(null == __vf)
                {
                    __vf = DocWebSession.GetTypeVisibleFields(new Impersonation());
                }
                return __vf;
            }
        }

        #endregion VisibleFields

        #region Static Members
        public static DocEntityImpersonation GetImpersonation(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetImpersonation(reference.Id) : null;
        }

        public static DocEntityImpersonation GetImpersonation(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityImpersonation>.GetFromCache(primaryKey, IMPERSONATION_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityImpersonation>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityImpersonation>.UpdateCache(ret.Id, ret, IMPERSONATION_CACHE);
                    DocEntityThreadCache<DocEntityImpersonation>.UpdateCache(ret.Hash, ret, IMPERSONATION_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityImpersonation GetImpersonation(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityImpersonation>.GetFromCache(hash, IMPERSONATION_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityImpersonation>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityImpersonation>.UpdateCache(ret.Id, ret, IMPERSONATION_CACHE);
                    DocEntityThreadCache<DocEntityImpersonation>.UpdateCache(ret.Hash, ret, IMPERSONATION_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field(Nullable = false)]
        public DocEntityUser AuthenticatedUser { get; set; }
        public int? AuthenticatedUserId { get { return AuthenticatedUser?.Id; } private set { var noid = value; } }


        [Field(Nullable = false)]
        public DocEntityUser ImpersonatedUser { get; set; }
        public int? ImpersonatedUserId { get { return ImpersonatedUser?.Id; } private set { var noid = value; } }


        [Field]
        public DocEntityUserSession UserSession { get; set; }
        public int? UserSessionId { get { return UserSession?.Id; } private set { var noid = value; } }



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

        public const string CACHE_KEY_PREFIX = "FindImpersonations";

        #endregion Overrides of DocEntity

        #region Entity overrides
        /// <summary>
        ///    Called when entity is about to be removed.
        /// </summary>
        protected override void OnRemoving()
        {
            base.OnRemoving();

            FlushCache();
        }

        /// <summary>
        ///    Called when entity should be validated. Override this method to perform custom object validation.
        /// </summary>
        protected override void OnValidate()
        {
            if (false == ValidationMessage.IsValid)
            {
                throw new HttpError(HttpStatusCode.Conflict, $"Impersonation requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();
            _validated = true;
        }

        public override IDocEntity SaveChanges(bool ignoreCache, DocConstantPermission permission)
        {

            return base.SaveChanges(ignoreCache, permission);
        }

        public override IDocEntity SaveChanges(bool ignoreCache) => SaveChanges(ignoreCache, DocConstantPermission.EDIT);
        public override IDocEntity SaveChanges(DocConstantPermission permission) => SaveChanges(false, DocConstantPermission.EDIT);
        public override IDocEntity SaveChanges() => SaveChanges(DocConstantPermission.EDIT);

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

                if(DocTools.IsNullOrEmpty(AuthenticatedUser))
                {
                    isValid = false;
                    message += " AuthenticatedUser is a required property.";
                }
                if(DocTools.IsNullOrEmpty(ImpersonatedUser))
                {
                    isValid = false;
                    message += " ImpersonatedUser is a required property.";
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Converters

        public Impersonation ToDto() => Mapper.Map<DocEntityImpersonation, Impersonation>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }

    public static partial class UniqueConstraintFilter
    {
        public static Expression<Func<DocEntityImpersonation, bool>> ImpersonationIgnoreArchived() => d => d.Archived == false;
    }

    public partial class ImpersonationMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityImpersonation,Impersonation> _EntityToDto;
        protected IMappingExpression<Impersonation,DocEntityImpersonation> _DtoToEntity;

        public ImpersonationMapper()
        {
            CreateMap<DocEntitySet<DocEntityImpersonation>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityImpersonation,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityImpersonation>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityImpersonation.GetImpersonation(c));
            _EntityToDto = CreateMap<DocEntityImpersonation,Impersonation>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Impersonation>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Impersonation>(c, "Updated")))
                .ForMember(dest => dest.AuthenticatedUser, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Impersonation>(c, nameof(DocEntityImpersonation.AuthenticatedUser))))
                .ForMember(dest => dest.AuthenticatedUserId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Impersonation>(c, nameof(DocEntityImpersonation.AuthenticatedUserId))))
                .ForMember(dest => dest.ImpersonatedUser, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Impersonation>(c, nameof(DocEntityImpersonation.ImpersonatedUser))))
                .ForMember(dest => dest.ImpersonatedUserId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Impersonation>(c, nameof(DocEntityImpersonation.ImpersonatedUserId))))
                .ForMember(dest => dest.UserSession, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Impersonation>(c, nameof(DocEntityImpersonation.UserSession))))
                .ForMember(dest => dest.UserSessionId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Impersonation>(c, nameof(DocEntityImpersonation.UserSessionId))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<Impersonation,DocEntityImpersonation>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
