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
    [TableMapping(DocConstantModelName.USERREQUEST)]
    public partial class DocEntityUserRequest : DocEntityBase
    {
        private const string USERREQUEST_CACHE = "UserRequestCache";
        public const string TABLE_NAME = DocConstantModelName.USERREQUEST;
        
        #region Constructor
        public DocEntityUserRequest(Session session) : base(session) {}

        public DocEntityUserRequest() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        #region VisibleFields

        protected override List<string> _visibleFields
        {
            get
            {
                if(null == __vf)
                {
                    __vf = DocWebSession.GetTypeVisibleFields(new UserRequest());
                }
                return __vf;
            }
        }

        #endregion VisibleFields

        #region Static Members
        public static DocEntityUserRequest GetUserRequest(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetUserRequest(reference.Id) : null;
        }

        public static DocEntityUserRequest GetUserRequest(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityUserRequest>.GetFromCache(primaryKey, USERREQUEST_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityUserRequest>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityUserRequest>.UpdateCache(ret.Id, ret, USERREQUEST_CACHE);
                    DocEntityThreadCache<DocEntityUserRequest>.UpdateCache(ret.Hash, ret, USERREQUEST_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityUserRequest GetUserRequest(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityUserRequest>.GetFromCache(hash, USERREQUEST_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityUserRequest>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityUserRequest>.UpdateCache(ret.Id, ret, USERREQUEST_CACHE);
                    DocEntityThreadCache<DocEntityUserRequest>.UpdateCache(ret.Hash, ret, USERREQUEST_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field()]
        [FieldMapping(nameof(App))]
        public DocEntityApp App { get; set; }
        public int? AppId { get { return App?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Method))]
        public string Method { get; set; }


        [Field()]
        [FieldMapping(nameof(Page))]
        public DocEntityPage Page { get; set; }
        public int? PageId { get { return Page?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Path))]
        public string Path { get; set; }


        [Field()]
        [FieldMapping(nameof(URL))]
        public string URL { get; set; }


        [Field(Nullable = false)]
        [FieldMapping(nameof(UserSession))]
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

        public const string CACHE_KEY_PREFIX = "FindUserRequests";

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
                throw new HttpError(HttpStatusCode.Conflict, $"UserRequest requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();
            _validated = true;
        }

        public override IDocEntity SaveChanges(bool ignoreCache, DocConstantPermission permission)
        {
            Method = Method?.TrimAndPruneSpaces();
            Path = Path?.TrimAndPruneSpaces();
            URL = URL?.TrimAndPruneSpaces();
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

                if(DocTools.IsNullOrEmpty(UserSession))
                {
                    isValid = false;
                    message += " UserSession is a required property.";
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Converters

        public UserRequest ToDto() => Mapper.Map<DocEntityUserRequest, UserRequest>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }

    public static partial class UniqueConstraintFilter
    {
        public static Expression<Func<DocEntityUserRequest, bool>> UserRequestIgnoreArchived() => d => d.Archived == false;
    }

    public partial class UserRequestMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityUserRequest,UserRequest> _EntityToDto;
        protected IMappingExpression<UserRequest,DocEntityUserRequest> _DtoToEntity;

        public UserRequestMapper()
        {
            CreateMap<DocEntitySet<DocEntityUserRequest>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityUserRequest,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityUserRequest>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityUserRequest.GetUserRequest(c));
            _EntityToDto = CreateMap<DocEntityUserRequest,UserRequest>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UserRequest>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UserRequest>(c, "Updated")))
                .ForMember(dest => dest.App, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UserRequest>(c, nameof(DocEntityUserRequest.App))))
                .ForMember(dest => dest.AppId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UserRequest>(c, nameof(DocEntityUserRequest.AppId))))
                .ForMember(dest => dest.Method, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UserRequest>(c, nameof(DocEntityUserRequest.Method))))
                .ForMember(dest => dest.Page, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UserRequest>(c, nameof(DocEntityUserRequest.Page))))
                .ForMember(dest => dest.PageId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UserRequest>(c, nameof(DocEntityUserRequest.PageId))))
                .ForMember(dest => dest.Path, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UserRequest>(c, nameof(DocEntityUserRequest.Path))))
                .ForMember(dest => dest.URL, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UserRequest>(c, nameof(DocEntityUserRequest.URL))))
                .ForMember(dest => dest.UserSession, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UserRequest>(c, nameof(DocEntityUserRequest.UserSession))))
                .ForMember(dest => dest.UserSessionId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<UserRequest>(c, nameof(DocEntityUserRequest.UserSessionId))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<UserRequest,DocEntityUserRequest>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
