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
    [TableMapping(DocConstantModelName.BROADCAST)]
    public partial class DocEntityBroadcast : DocEntityBase
    {
        private const string BROADCAST_CACHE = "BroadcastCache";
        public const string TABLE_NAME = DocConstantModelName.BROADCAST;
        
        #region Constructor
        public DocEntityBroadcast(Session session) : base(session) {}

        public DocEntityBroadcast() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        #region VisibleFields

        protected override List<string> _visibleFields
        {
            get
            {
                if(null == __vf)
                {
                    __vf = DocWebSession.GetTypeVisibleFields(new Broadcast());
                }
                return __vf;
            }
        }

        #endregion VisibleFields

        #region Static Members
        public static DocEntityBroadcast GetBroadcast(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetBroadcast(reference.Id) : null;
        }

        public static DocEntityBroadcast GetBroadcast(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityBroadcast>.GetFromCache(primaryKey, BROADCAST_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityBroadcast>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityBroadcast>.UpdateCache(ret.Id, ret, BROADCAST_CACHE);
                    DocEntityThreadCache<DocEntityBroadcast>.UpdateCache(ret.Hash, ret, BROADCAST_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityBroadcast GetBroadcast(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityBroadcast>.GetFromCache(hash, BROADCAST_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityBroadcast>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityBroadcast>.UpdateCache(ret.Id, ret, BROADCAST_CACHE);
                    DocEntityThreadCache<DocEntityBroadcast>.UpdateCache(ret.Hash, ret, BROADCAST_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field(Nullable = false)]
        [FieldMapping(nameof(App))]
        public DocEntityApp App { get; set; }
        public int? AppId { get { return App?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(ConfluenceId))]
        public string ConfluenceId { get; set; }


        [Field(Nullable = false)]
        [FieldMapping(nameof(Name))]
        public string Name { get; set; }


        [Field(Nullable = false, DefaultValue = true)]
        [FieldMapping(nameof(Reprocess))]
        public bool Reprocess { get; set; }


        [Field(DefaultValue = null)]
        [FieldMapping(nameof(Reprocessed))]
        public DateTime? Reprocessed { get; set; }


        [Field()]
        [FieldMapping(nameof(Scopes))]
        public DocEntitySet<DocEntityScope> Scopes { get; private set; }


        public int? ScopesCount { get { return Scopes.Count(); } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Status))]
        public DocEntityLookupTable Status { get; set; }
        public int? StatusId { get { return Status?.Id; } private set { var noid = value; } }


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

        [Field(DefaultValue = false)]
        [FieldMapping(nameof(Locked))]
        public override bool Locked { get; set; }

        [Field(DefaultValue = false)]
        [FieldMapping(nameof(Archived))]
        public override bool Archived { get; set; }

        #endregion Properties

        #region Overrides of DocEntity

        public override DocConstantModelName TableName => TABLE_NAME;

        public const string CACHE_KEY_PREFIX = "FindBroadcasts";

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
                throw new HttpError(HttpStatusCode.Conflict, $"Broadcast requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();

            FlushCache();

            _validated = true;


        }

        public override IDocEntity SaveChanges(DocConstantPermission permission = null)
        {
            ConfluenceId = ConfluenceId?.TrimAndPruneSpaces();
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

                if(DocTools.IsNullOrEmpty(App))
                {
                    isValid = false;
                    message += " App is a required property.";
                }
                if(DocTools.IsNullOrEmpty(Name))
                {
                    isValid = false;
                    message += " Name is a required property.";
                }
                if(DocTools.IsNullOrEmpty(Reprocess))
                {
                    isValid = false;
                    message += " Reprocess is a required property.";
                }
                if(null != Status && Status?.Enum?.Name != "BroadcastStatus")
                {
                    isValid = false;
                    message += " Status is a " + Status?.Enum?.Name + ", but must be a BroadcastStatus.";
                }
                if(DocTools.IsNullOrEmpty(Type))
                {
                    isValid = false;
                    message += " Type is a required property.";
                }
                else
                {
                    if(Type.Enum?.Name != "BroadcastType")
                    {
                        isValid = false;
                        message += " Type is a " + Type.Enum.Name + ", but must be a BroadcastType.";
                    }
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Converters

        public Broadcast ToDto() => Mapper.Map<DocEntityBroadcast, Broadcast>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }

    public static partial class UniqueConstraintFilter
    {
        public static Expression<Func<DocEntityBroadcast, bool>> BroadcastIgnoreArchived() => d => d.Archived == false;
    }

    public partial class BroadcastMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityBroadcast,Broadcast> _EntityToDto;
        protected IMappingExpression<Broadcast,DocEntityBroadcast> _DtoToEntity;

        public BroadcastMapper()
        {
            CreateMap<DocEntitySet<DocEntityBroadcast>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityBroadcast,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityBroadcast>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityBroadcast.GetBroadcast(c));
            _EntityToDto = CreateMap<DocEntityBroadcast,Broadcast>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Broadcast>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Broadcast>(c, "Updated")))
                .ForMember(dest => dest.App, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Broadcast>(c, nameof(DocEntityBroadcast.App))))
                .ForMember(dest => dest.AppId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Broadcast>(c, nameof(DocEntityBroadcast.AppId))))
                .ForMember(dest => dest.ConfluenceId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Broadcast>(c, nameof(DocEntityBroadcast.ConfluenceId))))
                .ForMember(dest => dest.Name, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Broadcast>(c, nameof(DocEntityBroadcast.Name))))
                .ForMember(dest => dest.Reprocess, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Broadcast>(c, nameof(DocEntityBroadcast.Reprocess))))
                .ForMember(dest => dest.Reprocessed, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Broadcast>(c, nameof(DocEntityBroadcast.Reprocessed))))
                .ForMember(dest => dest.Scopes, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Broadcast>(c, nameof(DocEntityBroadcast.Scopes))))
                .ForMember(dest => dest.ScopesCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Broadcast>(c, nameof(DocEntityBroadcast.ScopesCount))))
                .ForMember(dest => dest.Status, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Broadcast>(c, nameof(DocEntityBroadcast.Status))))
                .ForMember(dest => dest.StatusId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Broadcast>(c, nameof(DocEntityBroadcast.StatusId))))
                .ForMember(dest => dest.Type, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Broadcast>(c, nameof(DocEntityBroadcast.Type))))
                .ForMember(dest => dest.TypeId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Broadcast>(c, nameof(DocEntityBroadcast.TypeId))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<Broadcast,DocEntityBroadcast>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
