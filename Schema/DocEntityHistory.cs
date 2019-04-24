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
    [TableMapping(DocConstantModelName.HISTORY)]
    public partial class DocEntityHistory : DocEntityBase
    {
        private const string HISTORY_CACHE = "HistoryCache";
        public const string TABLE_NAME = DocConstantModelName.HISTORY;
        
        #region Constructor
        public DocEntityHistory(Session session) : base(session) {}

        public DocEntityHistory() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        #region VisibleFields

        protected override List<string> _visibleFields
        {
            get
            {
                if(null == __vf)
                {
                    __vf = DocWebSession.GetTypeVisibleFields(new History());
                }
                return __vf;
            }
        }

        #endregion VisibleFields

        #region Static Members
        public static DocEntityHistory GetHistory(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetHistory(reference.Id) : null;
        }

        public static DocEntityHistory GetHistory(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityHistory>.GetFromCache(primaryKey, HISTORY_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityHistory>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityHistory>.UpdateCache(ret.Id, ret, HISTORY_CACHE);
                    DocEntityThreadCache<DocEntityHistory>.UpdateCache(ret.Hash, ret, HISTORY_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityHistory GetHistory(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityHistory>.GetFromCache(hash, HISTORY_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityHistory>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityHistory>.UpdateCache(ret.Id, ret, HISTORY_CACHE);
                    DocEntityThreadCache<DocEntityHistory>.UpdateCache(ret.Hash, ret, HISTORY_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field]
        public DocEntityApp App { get; set; }
        public int? AppId { get { return App?.Id; } private set { var noid = value; } }


        [Field]
        public DocEntityDocumentSet DocumentSet { get; set; }
        public int? DocumentSetId { get { return DocumentSet?.Id; } private set { var noid = value; } }


        [Field]
        public DocEntityImpersonation Impersonation { get; set; }
        public int? ImpersonationId { get { return Impersonation?.Id; } private set { var noid = value; } }


        [Field]
        public DocEntityPage Page { get; set; }
        public int? PageId { get { return Page?.Id; } private set { var noid = value; } }


        [Field]
        public string URL { get; set; }


        [Field(Nullable = false)]
        public DocEntityUser User { get; set; }
        public int? UserId { get { return User?.Id; } private set { var noid = value; } }


        [Field]
        public DocEntityUserSession UserSession { get; set; }
        public int? UserSessionId { get { return UserSession?.Id; } private set { var noid = value; } }


        [Field]
        public DocEntityWorkflow Workflow { get; set; }
        public int? WorkflowId { get { return Workflow?.Id; } private set { var noid = value; } }



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

        public const string CACHE_KEY_PREFIX = "FindHistorys";

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
                throw new HttpError(HttpStatusCode.Conflict, $"History requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();
            _validated = true;
        }

        public override IDocEntity SaveChanges(bool ignoreCache, DocConstantPermission permission)
        {
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

                if(DocTools.IsNullOrEmpty(User))
                {
                    isValid = false;
                    message += " User is a required property.";
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Converters

        public History ToDto() => Mapper.Map<DocEntityHistory, History>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }

    public static partial class UniqueConstraintFilter
    {
        public static Expression<Func<DocEntityHistory, bool>> HistoryIgnoreArchived() => d => d.Archived == false;
    }

    public partial class HistoryMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityHistory,History> _EntityToDto;
        protected IMappingExpression<History,DocEntityHistory> _DtoToEntity;

        public HistoryMapper()
        {
            CreateMap<DocEntitySet<DocEntityHistory>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityHistory,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityHistory>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityHistory.GetHistory(c));
            _EntityToDto = CreateMap<DocEntityHistory,History>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<History>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<History>(c, "Updated")))
                .ForMember(dest => dest.App, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<History>(c, nameof(DocEntityHistory.App))))
                .ForMember(dest => dest.AppId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<History>(c, nameof(DocEntityHistory.AppId))))
                .ForMember(dest => dest.DocumentSet, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<History>(c, nameof(DocEntityHistory.DocumentSet))))
                .ForMember(dest => dest.DocumentSetId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<History>(c, nameof(DocEntityHistory.DocumentSetId))))
                .ForMember(dest => dest.Impersonation, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<History>(c, nameof(DocEntityHistory.Impersonation))))
                .ForMember(dest => dest.ImpersonationId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<History>(c, nameof(DocEntityHistory.ImpersonationId))))
                .ForMember(dest => dest.Page, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<History>(c, nameof(DocEntityHistory.Page))))
                .ForMember(dest => dest.PageId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<History>(c, nameof(DocEntityHistory.PageId))))
                .ForMember(dest => dest.URL, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<History>(c, nameof(DocEntityHistory.URL))))
                .ForMember(dest => dest.User, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<History>(c, nameof(DocEntityHistory.User))))
                .ForMember(dest => dest.UserId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<History>(c, nameof(DocEntityHistory.UserId))))
                .ForMember(dest => dest.UserSession, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<History>(c, nameof(DocEntityHistory.UserSession))))
                .ForMember(dest => dest.UserSessionId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<History>(c, nameof(DocEntityHistory.UserSessionId))))
                .ForMember(dest => dest.Workflow, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<History>(c, nameof(DocEntityHistory.Workflow))))
                .ForMember(dest => dest.WorkflowId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<History>(c, nameof(DocEntityHistory.WorkflowId))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<History,DocEntityHistory>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
