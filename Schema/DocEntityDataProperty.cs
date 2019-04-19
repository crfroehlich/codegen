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
    [TableMapping(DocConstantModelName.DATAPROPERTY)]
    public partial class DocEntityDataProperty : DocEntityBase
    {
        private const string DATAPROPERTY_CACHE = "DataPropertyCache";
        public const string TABLE_NAME = DocConstantModelName.DATAPROPERTY;
        
        #region Constructor
        public DocEntityDataProperty(Session session) : base(session) {}

        public DocEntityDataProperty() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        #region VisibleFields

        protected override List<string> _visibleFields
        {
            get
            {
                if(null == __vf)
                {
                    __vf = DocWebSession.GetTypeVisibleFields(new DataProperty());
                }
                return __vf;
            }
        }

        #endregion VisibleFields

        #region Static Members
        public static DocEntityDataProperty GetDataProperty(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetDataProperty(reference.Id) : null;
        }

        public static DocEntityDataProperty GetDataProperty(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityDataProperty>.GetFromCache(primaryKey, DATAPROPERTY_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityDataProperty>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityDataProperty>.UpdateCache(ret.Id, ret, DATAPROPERTY_CACHE);
                    DocEntityThreadCache<DocEntityDataProperty>.UpdateCache(ret.Hash, ret, DATAPROPERTY_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityDataProperty GetDataProperty(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityDataProperty>.GetFromCache(hash, DATAPROPERTY_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityDataProperty>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityDataProperty>.UpdateCache(ret.Id, ret, DATAPROPERTY_CACHE);
                    DocEntityThreadCache<DocEntityDataProperty>.UpdateCache(ret.Hash, ret, DATAPROPERTY_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field(DefaultValue = false)]
        [FieldMapping(nameof(AutoCreateMissing))]
        public bool AutoCreateMissing { get; set; }


        [Field()]
        [FieldMapping(nameof(Children))]
        [Association(PairTo = nameof(DocEntityDataProperty.Owner), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityDataProperty> Children { get; private set; }


        public int? ChildrenCount { get { return Children.Count(); } private set { var noid = value; } }


        [Field(Nullable = false)]
        [FieldMapping(nameof(Class))]
        public DocEntityDataClass Class { get; set; }
        public int? ClassId { get { return Class?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Description))]
        public string Description { get; set; }


        [Field()]
        [FieldMapping(nameof(DisplayName))]
        public string DisplayName { get; set; }


        [Field(DefaultValue = true)]
        [FieldMapping(nameof(IsAllowAddInForm))]
        public bool IsAllowAddInForm { get; set; }


        [Field(DefaultValue = false)]
        [FieldMapping(nameof(IsAllowCreateInForm))]
        public bool IsAllowCreateInForm { get; set; }


        [Field(DefaultValue = false)]
        [FieldMapping(nameof(IsAllowEditInForm))]
        public bool IsAllowEditInForm { get; set; }


        [Field(DefaultValue = false)]
        [FieldMapping(nameof(IsAllowFreeText))]
        public bool IsAllowFreeText { get; set; }


        [Field(DefaultValue = false)]
        [FieldMapping(nameof(IsAllowRemoveInForm))]
        public bool IsAllowRemoveInForm { get; set; }


        [Field(DefaultValue = true)]
        [FieldMapping(nameof(IsAudited))]
        public bool IsAudited { get; set; }


        [Field(DefaultValue = true)]
        [FieldMapping(nameof(IsDisplayInForm))]
        public bool IsDisplayInForm { get; set; }


        [Field(DefaultValue = true)]
        [FieldMapping(nameof(IsDisplayInGrid))]
        public bool IsDisplayInGrid { get; set; }


        [Field(DefaultValue = false)]
        [FieldMapping(nameof(IsEditColumn))]
        public bool IsEditColumn { get; set; }


        [Field(DefaultValue = false)]
        [FieldMapping(nameof(IsInsertOnly))]
        public bool IsInsertOnly { get; set; }


        [Field(DefaultValue = false)]
        [FieldMapping(nameof(IsJSON))]
        public bool IsJSON { get; set; }


        [Field(DefaultValue = false)]
        [FieldMapping(nameof(IsLazy))]
        public bool IsLazy { get; set; }


        [Field(DefaultValue = false)]
        [FieldMapping(nameof(IsNullOnUpgrade))]
        public bool IsNullOnUpgrade { get; set; }


        [Field(DefaultValue = false)]
        [FieldMapping(nameof(IsReadOnly))]
        public bool IsReadOnly { get; set; }


        [Field(DefaultValue = false)]
        [FieldMapping(nameof(IsRelationship))]
        public bool IsRelationship { get; set; }


        [Field(DefaultValue = false)]
        [FieldMapping(nameof(IsRequired))]
        public bool IsRequired { get; set; }


        [Field(DefaultValue = false)]
        [FieldMapping(nameof(IsRequiredInForm))]
        public bool IsRequiredInForm { get; set; }


        [Field()]
        [FieldMapping(nameof(IsVirtual))]
        public bool IsVirtual { get; set; }


        [Field()]
        [FieldMapping(nameof(JsonType))]
        public string JsonType { get; set; }


        [Field()]
        [FieldMapping(nameof(LookupTableEnum))]
        public DocEntityLookupTableEnum LookupTableEnum { get; set; }
        public int? LookupTableEnumId { get { return LookupTableEnum?.Id; } private set { var noid = value; } }


        [Field(Nullable = false)]
        [FieldMapping(nameof(Name))]
        public string Name { get; set; }


        [Field(DefaultValue = 0)]
        [FieldMapping(nameof(Order))]
        public int Order { get; set; }


        [Field()]
        [FieldMapping(nameof(Owner))]
        public DocEntityDataProperty Owner { get; set; }
        public int? OwnerId { get { return Owner?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Precision))]
        public int? Precision { get; set; }


        [Field()]
        [FieldMapping(nameof(RelationshipOnOwnerRemove))]
        public OnRemoveAction? RelationshipOnOwnerRemove { get; set; }


        [Field()]
        [FieldMapping(nameof(RelationshipOnTargetRemove))]
        public OnRemoveAction? RelationshipOnTargetRemove { get; set; }


        [Field()]
        [FieldMapping(nameof(RelationshipPairTo))]
        public DocEntityDataProperty RelationshipPairTo { get; set; }
        public int? RelationshipPairToId { get { return RelationshipPairTo?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Scale))]
        public int? Scale { get; set; }


        [Field()]
        [FieldMapping(nameof(SetDefaultValue))]
        public string SetDefaultValue { get; set; }


        [Field()]
        [FieldMapping(nameof(Tab))]
        public DocEntityDataTab Tab { get; set; }
        public int? TabId { get { return Tab?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Target))]
        public DocEntityDataClass Target { get; set; }
        public int? TargetId { get { return Target?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(TargetAlias))]
        public string TargetAlias { get; set; }


        [Field()]
        [FieldMapping(nameof(Type))]
        public DataType Type { get; set; }


        [Field()]
        [FieldMapping(nameof(UIType))]
        public UiType? UIType { get; set; }



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

        public const string CACHE_KEY_PREFIX = "FindDataPropertys";

        #endregion Overrides of DocEntity

        #region Entity overrides
        /// <summary>
        ///    Called when entity is about to be removed.
        /// </summary>
        protected override void OnRemoving()
        {
            base.OnRemoving();
            try
            {
                Children.Clear(); //foreach thing in Children en.Remove();
            }
            catch(Exception ex)
            {
                throw new DocException("Failed to delete DataProperty in Children delete", ex);
            }
            FlushCache();
        }

        /// <summary>
        ///    Called when entity should be validated. Override this method to perform custom object validation.
        /// </summary>
        protected override void OnValidate()
        {
            if (false == ValidationMessage.IsValid)
            {
                throw new HttpError(HttpStatusCode.Conflict, $"DataProperty requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();
            _validated = true;
        }

        public override IDocEntity SaveChanges(bool ignoreCache, DocConstantPermission permission)
        {
            Description = Description?.TrimAndPruneSpaces();
            DisplayName = DisplayName?.TrimAndPruneSpaces();
            JsonType = JsonType?.TrimAndPruneSpaces();
            Name = Name?.TrimAndPruneSpaces();
            SetDefaultValue = SetDefaultValue?.TrimAndPruneSpaces();
            TargetAlias = TargetAlias?.TrimAndPruneSpaces();
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

        public DataProperty ToDto() => Mapper.Map<DocEntityDataProperty, DataProperty>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }

    public static partial class UniqueConstraintFilter
    {
        public static Expression<Func<DocEntityDataProperty, bool>> DataPropertyIgnoreArchived() => d => d.Archived == false;
    }

    public partial class DataPropertyMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityDataProperty,DataProperty> _EntityToDto;
        protected IMappingExpression<DataProperty,DocEntityDataProperty> _DtoToEntity;

        public DataPropertyMapper()
        {
            CreateMap<DocEntitySet<DocEntityDataProperty>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityDataProperty,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityDataProperty>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityDataProperty.GetDataProperty(c));
            _EntityToDto = CreateMap<DocEntityDataProperty,DataProperty>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataProperty>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataProperty>(c, "Updated")))
                .ForMember(dest => dest.AutoCreateMissing, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataProperty>(c, nameof(DocEntityDataProperty.AutoCreateMissing))))
                .ForMember(dest => dest.Children, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataProperty>(c, nameof(DocEntityDataProperty.Children))))
                .ForMember(dest => dest.ChildrenCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataProperty>(c, nameof(DocEntityDataProperty.ChildrenCount))))
                .ForMember(dest => dest.Class, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataProperty>(c, nameof(DocEntityDataProperty.Class))))
                .ForMember(dest => dest.ClassId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataProperty>(c, nameof(DocEntityDataProperty.ClassId))))
                .ForMember(dest => dest.Description, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataProperty>(c, nameof(DocEntityDataProperty.Description))))
                .ForMember(dest => dest.DisplayName, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataProperty>(c, nameof(DocEntityDataProperty.DisplayName))))
                .ForMember(dest => dest.IsAllowAddInForm, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataProperty>(c, nameof(DocEntityDataProperty.IsAllowAddInForm))))
                .ForMember(dest => dest.IsAllowCreateInForm, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataProperty>(c, nameof(DocEntityDataProperty.IsAllowCreateInForm))))
                .ForMember(dest => dest.IsAllowEditInForm, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataProperty>(c, nameof(DocEntityDataProperty.IsAllowEditInForm))))
                .ForMember(dest => dest.IsAllowFreeText, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataProperty>(c, nameof(DocEntityDataProperty.IsAllowFreeText))))
                .ForMember(dest => dest.IsAllowRemoveInForm, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataProperty>(c, nameof(DocEntityDataProperty.IsAllowRemoveInForm))))
                .ForMember(dest => dest.IsAudited, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataProperty>(c, nameof(DocEntityDataProperty.IsAudited))))
                .ForMember(dest => dest.IsDisplayInForm, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataProperty>(c, nameof(DocEntityDataProperty.IsDisplayInForm))))
                .ForMember(dest => dest.IsDisplayInGrid, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataProperty>(c, nameof(DocEntityDataProperty.IsDisplayInGrid))))
                .ForMember(dest => dest.IsEditColumn, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataProperty>(c, nameof(DocEntityDataProperty.IsEditColumn))))
                .ForMember(dest => dest.IsInsertOnly, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataProperty>(c, nameof(DocEntityDataProperty.IsInsertOnly))))
                .ForMember(dest => dest.IsJSON, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataProperty>(c, nameof(DocEntityDataProperty.IsJSON))))
                .ForMember(dest => dest.IsLazy, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataProperty>(c, nameof(DocEntityDataProperty.IsLazy))))
                .ForMember(dest => dest.IsNullOnUpgrade, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataProperty>(c, nameof(DocEntityDataProperty.IsNullOnUpgrade))))
                .ForMember(dest => dest.IsReadOnly, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataProperty>(c, nameof(DocEntityDataProperty.IsReadOnly))))
                .ForMember(dest => dest.IsRelationship, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataProperty>(c, nameof(DocEntityDataProperty.IsRelationship))))
                .ForMember(dest => dest.IsRequired, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataProperty>(c, nameof(DocEntityDataProperty.IsRequired))))
                .ForMember(dest => dest.IsRequiredInForm, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataProperty>(c, nameof(DocEntityDataProperty.IsRequiredInForm))))
                .ForMember(dest => dest.IsVirtual, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataProperty>(c, nameof(DocEntityDataProperty.IsVirtual))))
                .ForMember(dest => dest.JsonType, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataProperty>(c, nameof(DocEntityDataProperty.JsonType))))
                .ForMember(dest => dest.LookupTableEnum, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataProperty>(c, nameof(DocEntityDataProperty.LookupTableEnum))))
                .ForMember(dest => dest.LookupTableEnumId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataProperty>(c, nameof(DocEntityDataProperty.LookupTableEnumId))))
                .ForMember(dest => dest.Name, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataProperty>(c, nameof(DocEntityDataProperty.Name))))
                .ForMember(dest => dest.Order, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataProperty>(c, nameof(DocEntityDataProperty.Order))))
                .ForMember(dest => dest.Owner, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataProperty>(c, nameof(DocEntityDataProperty.Owner))))
                .ForMember(dest => dest.OwnerId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataProperty>(c, nameof(DocEntityDataProperty.OwnerId))))
                .ForMember(dest => dest.Precision, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataProperty>(c, nameof(DocEntityDataProperty.Precision))))
                .ForMember(dest => dest.RelationshipOnOwnerRemove, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataProperty>(c, nameof(DocEntityDataProperty.RelationshipOnOwnerRemove))))
                .ForMember(dest => dest.RelationshipOnTargetRemove, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataProperty>(c, nameof(DocEntityDataProperty.RelationshipOnTargetRemove))))
                .ForMember(dest => dest.RelationshipPairTo, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataProperty>(c, nameof(DocEntityDataProperty.RelationshipPairTo))))
                .ForMember(dest => dest.RelationshipPairToId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataProperty>(c, nameof(DocEntityDataProperty.RelationshipPairToId))))
                .ForMember(dest => dest.Scale, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataProperty>(c, nameof(DocEntityDataProperty.Scale))))
                .ForMember(dest => dest.SetDefaultValue, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataProperty>(c, nameof(DocEntityDataProperty.SetDefaultValue))))
                .ForMember(dest => dest.Tab, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataProperty>(c, nameof(DocEntityDataProperty.Tab))))
                .ForMember(dest => dest.TabId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataProperty>(c, nameof(DocEntityDataProperty.TabId))))
                .ForMember(dest => dest.Target, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataProperty>(c, nameof(DocEntityDataProperty.Target))))
                .ForMember(dest => dest.TargetId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataProperty>(c, nameof(DocEntityDataProperty.TargetId))))
                .ForMember(dest => dest.TargetAlias, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataProperty>(c, nameof(DocEntityDataProperty.TargetAlias))))
                .ForMember(dest => dest.Type, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataProperty>(c, nameof(DocEntityDataProperty.Type))))
                .ForMember(dest => dest.UIType, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataProperty>(c, nameof(DocEntityDataProperty.UIType))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<DataProperty,DocEntityDataProperty>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
