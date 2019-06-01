
//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated by a T4 template. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Net;

using AutoMapper;

using Services.Core;
using Services.Db;
using Services.Dto;
using Services.Dto.internals;
using Services.Enums;

using ServiceStack;

using Xtensive.Orm;


namespace Services.Schema
{
    [TableMapping(DocConstantModelName.DATAPROPERTY)]
    public partial class DocEntityDataProperty : DocEntityBase
    {
        private const string DATAPROPERTY_CACHE = "DataPropertyCache";
        public const ModelNameEnm CLASS_NAME = ModelNameEnm.DATAPROPERTY;
        
        #region Constructor
        public DocEntityDataProperty(Session session) : base(session) {}

        public DocEntityDataProperty() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        protected override List<string> _select => __vf ?? (__vf = DocWebSession.GetTypeSelect(new DataProperty()));

        #region Static Members
        public static DocEntityDataProperty Get(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? Get(reference.Id) : null;
        }

        public static DocEntityDataProperty Get(int? primaryKey, bool noCache, DocQuery query)
        {
            if(!(primaryKey > 0)) return null;
            return query.SelectAll<DocEntityDataProperty>().FirstOrDefault(e => e.Id == primaryKey.Value);
        }

        public static DocEntityDataProperty Get(int? primaryKey)
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

        public static DocEntityDataProperty Get(Guid hash)
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
        public bool AutoCreateMissing { get; set; }


        [Field]
        [Association(PairTo = nameof(DocEntityDataProperty.Owner), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityDataProperty> Children { get; private set; }


        public List<int> ChildrenIds => Children.Select(e => e.Id).ToList();


        public int? ChildrenCount { get { return Children.Count(); } private set { var noid = value; } }


        [Field(Nullable = false)]
        public DocEntityDataClass Class { get; set; }
        public int? ClassId { get { return Class?.Id; } private set { var noid = value; } }


        [Field]
        public string Description { get; set; }


        [Field]
        public string DisplayName { get; set; }


        [Field(DefaultValue = true)]
        public bool IsAllowAddInForm { get; set; }


        [Field(DefaultValue = false)]
        public bool IsAllowCreateInForm { get; set; }


        [Field(DefaultValue = false)]
        public bool IsAllowEditInForm { get; set; }


        [Field(DefaultValue = false)]
        public bool IsAllowFreeText { get; set; }


        [Field(DefaultValue = false)]
        public bool IsAllowRemoveInForm { get; set; }


        [Field(DefaultValue = true)]
        public bool IsAudited { get; set; }


        [Field(DefaultValue = true)]
        public bool IsCompressed { get; set; }


        [Field(DefaultValue = true)]
        public bool IsDisplayInForm { get; set; }


        [Field(DefaultValue = true)]
        public bool IsDisplayInGrid { get; set; }


        [Field(DefaultValue = false)]
        public bool IsEditColumn { get; set; }


        [Field(DefaultValue = false)]
        public bool IsInsertOnly { get; set; }


        [Field(DefaultValue = false)]
        public bool IsJSON { get; set; }


        [Field(DefaultValue = false)]
        public bool IsLazy { get; set; }


        [Field(DefaultValue = false)]
        public bool IsNullOnUpgrade { get; set; }


        [Field(DefaultValue = false)]
        public bool IsReadOnly { get; set; }


        [Field(DefaultValue = false)]
        public bool IsRelationship { get; set; }


        [Field(DefaultValue = false)]
        public bool IsRequired { get; set; }


        [Field(DefaultValue = false)]
        public bool IsRequiredInForm { get; set; }


        [Field]
        public bool IsVirtual { get; set; }


        [Field]
        public string JsonType { get; set; }


        [Field]
        public DocEntityLookupTableEnum LookupTableEnum { get; set; }
        public int? LookupTableEnumId { get { return LookupTableEnum?.Id; } private set { var noid = value; } }


        [Field(Nullable = false, Length = 200)]
        public string Name { get; set; }


        [Field(DefaultValue = 0)]
        public int Order { get; set; }


        [Field]
        public DocEntityDataProperty Owner { get; set; }
        public int? OwnerId { get { return Owner?.Id; } private set { var noid = value; } }


        [Field]
        public int? Precision { get; set; }


        [Field]
        public OnRemoveAction? RelationshipOnOwnerRemove { get; set; }


        [Field]
        public OnRemoveAction? RelationshipOnTargetRemove { get; set; }


        [Field]
        public DocEntityDataProperty RelationshipPairTo { get; set; }
        public int? RelationshipPairToId { get { return RelationshipPairTo?.Id; } private set { var noid = value; } }


        [Field]
        public int? Scale { get; set; }


        [Field]
        public string SetDefaultValue { get; set; }


        [Field]
        public DocEntityDataTab Tab { get; set; }
        public int? TabId { get { return Tab?.Id; } private set { var noid = value; } }


        [Field]
        public DocEntityDataClass Target { get; set; }
        public int? TargetId { get { return Target?.Id; } private set { var noid = value; } }


        [Field]
        public string TargetAlias { get; set; }


        [Field]
        public DataType Type { get; set; }


        [Field]
        public UiType? UIType { get; set; }



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

        public override ModelNameEnm ClassName => CLASS_NAME;

        public override DocConstantModelName TableName => CLASS_NAME.ToEnumString();

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

        public static explicit operator DataProperty(DocEntityDataProperty en) => en?.ToDto();

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }
}
