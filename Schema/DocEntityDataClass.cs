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
    [TableMapping(DocConstantModelName.DATACLASS)]
    public partial class DocEntityDataClass : DocEntityBase
    {
        private const string DATACLASS_CACHE = "DataClassCache";
        public const string TABLE_NAME = DocConstantModelName.DATACLASS;
        
        #region Constructor
        public DocEntityDataClass(Session session) : base(session) {}

        public DocEntityDataClass() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        protected override List<string> _select => __vf ?? (__vf = DocWebSession.GetTypeSelect(new DataClass()));

        #region Static Members
        public static DocEntityDataClass Get(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? Get(reference.Id) : null;
        }

        public static DocEntityDataClass Get(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityDataClass>.GetFromCache(primaryKey, DATACLASS_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityDataClass>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityDataClass>.UpdateCache(ret.Id, ret, DATACLASS_CACHE);
                    DocEntityThreadCache<DocEntityDataClass>.UpdateCache(ret.Hash, ret, DATACLASS_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityDataClass Get(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityDataClass>.GetFromCache(hash, DATACLASS_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityDataClass>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityDataClass>.UpdateCache(ret.Id, ret, DATACLASS_CACHE);
                    DocEntityThreadCache<DocEntityDataClass>.UpdateCache(ret.Hash, ret, DATACLASS_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field(DefaultValue = true)]
        public bool AllowDelete { get; set; }


        [Field(DefaultValue = false)]
        public bool AllSelectByDefault { get; set; }


        [Field(Nullable = false, DefaultValue = 5)]
        public int CacheDuration { get; set; }


        [Field(Nullable = false)]
        public int ClassId { get; set; }


        [Field]
        public DocEntitySet<DocEntityDataProperty> CustomCollections { get; private set; }


        public int? CustomCollectionsCount { get { return CustomCollections.Count(); } private set { var noid = value; } }


        [Field(DefaultValue = false)]
        public bool DELETE { get; set; }


        [Field]
        public string Description { get; set; }


        [Field]
        public DocEntitySet<DocEntityDataProperty> DontFlattenProperties { get; private set; }


        public int? DontFlattenPropertiesCount { get { return DontFlattenProperties.Count(); } private set { var noid = value; } }


        [Field]
        public string DtoSuffix { get; set; }


        [Field(DefaultValue = false)]
        public bool FlattenReferences { get; set; }


        [Field(DefaultValue = true)]
        public bool GET { get; set; }


        [Field]
        public DocEntitySet<DocEntityDataProperty> IgnoreProps { get; private set; }


        public int? IgnorePropsCount { get { return IgnoreProps.Count(); } private set { var noid = value; } }


        [Field(DefaultValue = false)]
        public bool IsInsertOnly { get; set; }


        [Field(DefaultValue = false)]
        public bool IsReadOnly { get; set; }


        [Field(Nullable = false)]
        public string Name { get; set; }


        [Field(DefaultValue = false)]
        public bool PATCH { get; set; }


        [Field(DefaultValue = false)]
        public bool POST { get; set; }


        [Field]
        [Association(PairTo = nameof(DocEntityDataProperty.Class), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityDataProperty> Properties { get; private set; }


        public int? PropertiesCount { get { return Properties.Count(); } private set { var noid = value; } }


        [Field(DefaultValue = false)]
        public bool PUT { get; set; }


        [Field]
        [Association(PairTo = nameof(DocEntityDataTab.Class), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityDataTab> Tabs { get; private set; }


        public int? TabsCount { get { return Tabs.Count(); } private set { var noid = value; } }


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

        public const string CACHE_KEY_PREFIX = "FindDataClasss";

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
                Properties.Clear(); //foreach thing in Properties en.Remove();
            }
            catch(Exception ex)
            {
                throw new DocException("Failed to delete DataClass in Properties delete", ex);
            }
            try
            {
                Tabs.Clear(); //foreach thing in Tabs en.Remove();
            }
            catch(Exception ex)
            {
                throw new DocException("Failed to delete DataClass in Tabs delete", ex);
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
                throw new HttpError(HttpStatusCode.Conflict, $"DataClass requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();
            _validated = true;
        }

        public override IDocEntity SaveChanges(bool ignoreCache, DocConstantPermission permission)
        {
            Description = Description?.TrimAndPruneSpaces();
            DtoSuffix = DtoSuffix?.TrimAndPruneSpaces();
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

                if(DocTools.IsNullOrEmpty(CacheDuration))
                {
                    isValid = false;
                    message += " CacheDuration is a required property.";
                }
                if(DocTools.IsNullOrEmpty(ClassId))
                {
                    isValid = false;
                    message += " ClassId is a required property.";
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

        public DataClass ToDto() => Mapper.Map<DocEntityDataClass, DataClass>(this);

        public static explicit operator DataClass(DocEntityDataClass en) => en?.ToDto();
        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }
}
