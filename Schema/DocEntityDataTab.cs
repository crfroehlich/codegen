
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
    [TableMapping(DocConstantModelName.DATATAB)]
    public partial class DocEntityDataTab : DocEntityBase
    {
        private const string DATATAB_CACHE = "DataTabCache";
        public const string TABLE_NAME = DocConstantModelName.DATATAB;
        
        #region Constructor
        public DocEntityDataTab(Session session) : base(session) {}

        public DocEntityDataTab() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        #region VisibleFields

        protected override List<string> _visibleFields
        {
            get
            {
                if(null == __vf)
                {
                    __vf = DocWebSession.GetTypeVisibleFields(new DataTab());
                }
                return __vf;
            }
        }

        #endregion VisibleFields

        #region Static Members
        public static DocEntityDataTab GetDataTab(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetDataTab(reference.Id) : null;
        }

        public static DocEntityDataTab GetDataTab(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityDataTab>.GetFromCache(primaryKey, DATATAB_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityDataTab>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityDataTab>.UpdateCache(ret.Id, ret, DATATAB_CACHE);
                    DocEntityThreadCache<DocEntityDataTab>.UpdateCache(ret.Hash, ret, DATATAB_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityDataTab GetDataTab(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityDataTab>.GetFromCache(hash, DATATAB_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityDataTab>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityDataTab>.UpdateCache(ret.Id, ret, DATATAB_CACHE);
                    DocEntityThreadCache<DocEntityDataTab>.UpdateCache(ret.Hash, ret, DATATAB_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field(Nullable = false)]
        [FieldMapping(nameof(Class))]
        public DocEntityDataClass Class { get; set; }
        public int? ClassId { get { return Class?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Description))]
        public string Description { get; set; }


        [Field(Nullable = false)]
        [FieldMapping(nameof(Name))]
        public string Name { get; set; }


        [Field(DefaultValue = 0)]
        [FieldMapping(nameof(Order))]
        public int Order { get; set; }



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

        public const string CACHE_KEY_PREFIX = "FindDataTabs";

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
                throw new HttpError(HttpStatusCode.Conflict, $"DataTab requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();
            _validated = true;
        }

        public override IDocEntity SaveChanges(bool ignoreCache, DocConstantPermission permission)
        {
            Description = Description?.TrimAndPruneSpaces();
            Name = Name?.TrimAndPruneSpaces();
            return base.SaveChanges(ignoreCache, permission);
        }

        public override IDocEntity SaveChanges(bool ignoreCache) => SaveChanges(ignoreCache, DocConstantPermission.EDIT);
        public override IDocEntity SaveChanges(DocConstantPermission permission) => SaveChanges(false, DocConstantPermission.EDIT);
        public override IDocEntity SaveChanges() => SaveChanges(DocConstantPermission.EDIT);

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

                if(DocTools.IsNullOrEmpty(Class))
                {
                    isValid = false;
                    message += " Class is a required property.";
                }
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

        public DataTab ToDto() => Mapper.Map<DocEntityDataTab, DataTab>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }

    public static partial class UniqueConstraintFilter
    {
        public static Expression<Func<DocEntityDataTab, bool>> DataTabIgnoreArchived() => d => d.Archived == false;
    }

    public partial class DataTabMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityDataTab,DataTab> _EntityToDto;
        protected IMappingExpression<DataTab,DocEntityDataTab> _DtoToEntity;

        public DataTabMapper()
        {
            CreateMap<DocEntitySet<DocEntityDataTab>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityDataTab,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityDataTab>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityDataTab.GetDataTab(c));
            _EntityToDto = CreateMap<DocEntityDataTab,DataTab>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataTab>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataTab>(c, "Updated")))
                .ForMember(dest => dest.Class, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataTab>(c, nameof(DocEntityDataTab.Class))))
                .ForMember(dest => dest.ClassId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataTab>(c, nameof(DocEntityDataTab.ClassId))))
                .ForMember(dest => dest.Description, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataTab>(c, nameof(DocEntityDataTab.Description))))
                .ForMember(dest => dest.Name, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataTab>(c, nameof(DocEntityDataTab.Name))))
                .ForMember(dest => dest.Order, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataTab>(c, nameof(DocEntityDataTab.Order))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<DataTab,DocEntityDataTab>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
