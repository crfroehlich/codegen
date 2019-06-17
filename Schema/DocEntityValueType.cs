//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated by a T4 template. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.CodeDom.Compiler;
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


using ValueType = Services.Dto.ValueType;

namespace Services.Schema
{
    [TableMapping(DocConstantModelName.VALUETYPE)]
    public partial class DocEntityValueType : DocEntityBase
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private const string VALUETYPE_CACHE = "ValueTypeCache";
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public  const ModelNameEnm CLASS_NAME = ModelNameEnm.VALUETYPE;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocEntityValueType(Session session) : base(session) {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocEntityValueType() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        protected override List<string> _select => __vf ?? (__vf = DocWebSession.GetTypeSelect(new ValueType()));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static DocEntityValueType Get(Reference reference) => (true == (reference?.Id > 0)) ? Get(reference.Id) : null;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static DocEntityValueType Get(int? primaryKey, bool noCache, DocQuery query)
        {
            if(!(primaryKey > 0)) return null;
            return query.SelectAll<DocEntityValueType>().FirstOrDefault(e => e.Id == primaryKey.Value);
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public new static DocEntityValueType Get(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityValueType>.GetFromCache(primaryKey, VALUETYPE_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityValueType>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityValueType>.UpdateCache(ret.Id, ret, VALUETYPE_CACHE);
                    DocEntityThreadCache<DocEntityValueType>.UpdateCache(ret.Hash, ret, VALUETYPE_CACHE);
                }
            }
            return ret;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static DocEntityValueType Get(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityValueType>.GetFromCache(hash, VALUETYPE_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityValueType>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityValueType>.UpdateCache(ret.Id, ret, VALUETYPE_CACHE);
                    DocEntityThreadCache<DocEntityValueType>.UpdateCache(ret.Hash, ret, VALUETYPE_CACHE);
                }
            }
            return ret;
        }

        [Field]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocEntityLookupTable FieldType { get; set; }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? FieldTypeId { get { return FieldType?.Id; } private set { var noid = value; } }

        [Field(Nullable = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocEntityLookupTable Name { get; set; }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? NameId { get { return Name?.Id; } private set { var noid = value; } }



        [Field]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override string Gestalt { get; set; }

        [Field(DefaultValue = 0), Version(VersionMode.Manual)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override int VersionNo { get; set; }

        [Field]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override DateTime? Created { get; set; }

        [Field]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override DateTime? Updated { get; set; }

        [Field(DefaultValue = false), FieldMapping(nameof(Locked))]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override bool Locked { get; set; }

        [Field(DefaultValue = false), FieldMapping(nameof(Archived))]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override bool Archived { get; set; }

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override ModelNameEnm ClassName => CLASS_NAME;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override DocConstantModelName TableName => CLASS_NAME.ToEnumString();
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public const string CACHE_KEY_PREFIX = "FindValueTypes";

        /// <summary>
        ///    Called when entity is about to be removed.
        /// </summary>
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        protected override void OnRemoving()
        {
            base.OnRemoving();

            FlushCache();
        }

        /// <summary>
        ///    Called when entity should be validated. Override this method to perform custom object validation.
        /// </summary>
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        protected override void OnValidate()
        {
            if (false == ValidationMessage.IsValid)
            {
                throw new HttpError(HttpStatusCode.Conflict, $"ValueType requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();
            _validated = true;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override IDocEntity SaveChanges(bool ignoreCache, DocConstantPermission permission)
        {

            return base.SaveChanges(ignoreCache, permission);
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override IDocEntity SaveChanges(bool ignoreCache) => SaveChanges(ignoreCache, DocConstantPermission.EDIT);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override IDocEntity SaveChanges(DocConstantPermission permission) => SaveChanges(false, DocConstantPermission.EDIT);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override IDocEntity SaveChanges() => SaveChanges(DocConstantPermission.EDIT);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override void FlushCache()
        {
            base.FlushCache();

        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocValidationMessage ValidationMessage
        {
            get
            {
                var isValid = true;
                var message = string.Empty;

                if(null != FieldType && FieldType?.Enum?.Name != "FieldType")
                {
                    isValid = false;
                    message += " FieldType is a " + FieldType?.Enum?.Name + ", but must be a FieldType.";
                }
                if(DocTools.IsNullOrEmpty(Name))
                {
                    isValid = false;
                    message += " Name is a required property.";
                }
                else
                {
                    if(Name.Enum?.Name != "ValueType")
                    {
                        isValid = false;
                        message += " Name is a " + Name.Enum.Name + ", but must be a ValueType.";
                    }
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public ValueType ToDto() => Mapper.Map<DocEntityValueType, ValueType>(this);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static explicit operator ValueType(DocEntityValueType en) => en?.ToDto();

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override IDto ToIDto() => ToDto();
    }
}
