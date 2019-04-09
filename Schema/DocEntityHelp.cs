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
    [TableMapping(DocConstantModelName.HELP)]
    public partial class DocEntityHelp : DocEntityBase
    {
        private const string HELP_CACHE = "HelpCache";
        public const string TABLE_NAME = DocConstantModelName.HELP;
        
        #region Constructor
        public DocEntityHelp(Session session) : base(session) {}

        public DocEntityHelp() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        #region VisibleFields

        protected override List<string> _visibleFields
        {
            get
            {
                if(null == __vf)
                {
                    __vf = DocWebSession.GetTypeVisibleFields(new Help());
                }
                return __vf;
            }
        }

        #endregion VisibleFields

        #region Static Members
        public static DocEntityHelp GetHelp(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetHelp(reference.Id) : null;
        }

        public static DocEntityHelp GetHelp(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityHelp>.GetFromCache(primaryKey, HELP_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityHelp>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityHelp>.UpdateCache(ret.Id, ret, HELP_CACHE);
                    DocEntityThreadCache<DocEntityHelp>.UpdateCache(ret.Hash, ret, HELP_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityHelp GetHelp(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityHelp>.GetFromCache(hash, HELP_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityHelp>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityHelp>.UpdateCache(ret.Id, ret, HELP_CACHE);
                    DocEntityThreadCache<DocEntityHelp>.UpdateCache(ret.Hash, ret, HELP_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field]
        public string ConfluenceId { get; set; }


        [Field]
        public string Description { get; set; }


        [Field(DefaultValue = "fa fa-question-circle")]
        public string Icon { get; set; }


        [Field]
        public int? Order { get; set; }


        [Field]
        public DocEntitySet<DocEntityPage> Pages { get; private set; }


        public int? PagesCount { get { return Pages.Count(); } private set { var noid = value; } }


        [Field]
        public DocEntitySet<DocEntityScope> Scopes { get; private set; }


        public int? ScopesCount { get { return Scopes.Count(); } private set { var noid = value; } }


        [Field(Nullable = false)]
        public string Title { get; set; }


        [Field]
        public DocEntityLookupTable Type { get; set; }
        public int? TypeId { get { return Type?.Id; } private set { var noid = value; } }



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

        public const string CACHE_KEY_PREFIX = "FindHelps";

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
                throw new HttpError(HttpStatusCode.Conflict, $"Help requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();

            FlushCache();

            _validated = true;


        }

        public override IDocEntity SaveChanges(DocConstantPermission permission = null)
        {
            ConfluenceId = ConfluenceId?.TrimAndPruneSpaces();
            Description = Description?.TrimAndPruneSpaces();
            Icon = Icon?.TrimAndPruneSpaces();
            Title = Title?.TrimAndPruneSpaces();
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

                if(DocTools.IsNullOrEmpty(Title))
                {
                    isValid = false;
                    message += " Title is a required property.";
                }
                if(null != Type && Type?.Enum?.Name != "Help")
                {
                    isValid = false;
                    message += " Type is a " + Type?.Enum?.Name + ", but must be a Help.";
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Converters

        public Help ToDto() => Mapper.Map<DocEntityHelp, Help>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }

    public static partial class UniqueConstraintFilter
    {
        public static Expression<Func<DocEntityHelp, bool>> HelpIgnoreArchived() => d => d.Archived == false;
    }

    public partial class HelpMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityHelp,Help> _EntityToDto;
        protected IMappingExpression<Help,DocEntityHelp> _DtoToEntity;

        public HelpMapper()
        {
            CreateMap<DocEntitySet<DocEntityHelp>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityHelp,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityHelp>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityHelp.GetHelp(c));
            _EntityToDto = CreateMap<DocEntityHelp,Help>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Help>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Help>(c, "Updated")))
                .ForMember(dest => dest.ConfluenceId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Help>(c, nameof(DocEntityHelp.ConfluenceId))))
                .ForMember(dest => dest.Description, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Help>(c, nameof(DocEntityHelp.Description))))
                .ForMember(dest => dest.Icon, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Help>(c, nameof(DocEntityHelp.Icon))))
                .ForMember(dest => dest.Order, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Help>(c, nameof(DocEntityHelp.Order))))
                .ForMember(dest => dest.Pages, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Help>(c, nameof(DocEntityHelp.Pages))))
                .ForMember(dest => dest.PagesCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Help>(c, nameof(DocEntityHelp.PagesCount))))
                .ForMember(dest => dest.Scopes, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Help>(c, nameof(DocEntityHelp.Scopes))))
                .ForMember(dest => dest.ScopesCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Help>(c, nameof(DocEntityHelp.ScopesCount))))
                .ForMember(dest => dest.Title, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Help>(c, nameof(DocEntityHelp.Title))))
                .ForMember(dest => dest.Type, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Help>(c, nameof(DocEntityHelp.Type))))
                .ForMember(dest => dest.TypeId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Help>(c, nameof(DocEntityHelp.TypeId))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<Help,DocEntityHelp>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
