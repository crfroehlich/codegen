
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
    [TableMapping(DocConstantModelName.LOCALELOOKUP)]
    public partial class DocEntityLocaleLookup : DocEntityBase
    {
        private const string LOCALELOOKUP_CACHE = "LocaleLookupCache";
        public const ModelNameEnm CLASS_NAME = ModelNameEnm.LOCALELOOKUP;

        public DocEntityLocaleLookup(Session session) : base(session) {}

        public DocEntityLocaleLookup() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}

        protected override List<string> _select => __vf ?? (__vf = DocWebSession.GetTypeSelect(new LocaleLookup()));
        public static DocEntityLocaleLookup Get(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? Get(reference.Id) : null;
        }

        public static DocEntityLocaleLookup Get(int? primaryKey, bool noCache, DocQuery query)
        {
            if(!(primaryKey > 0)) return null;
            return query.SelectAll<DocEntityLocaleLookup>().FirstOrDefault(e => e.Id == primaryKey.Value);
        }

        public static DocEntityLocaleLookup Get(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityLocaleLookup>.GetFromCache(primaryKey, LOCALELOOKUP_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityLocaleLookup>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityLocaleLookup>.UpdateCache(ret.Id, ret, LOCALELOOKUP_CACHE);
                    DocEntityThreadCache<DocEntityLocaleLookup>.UpdateCache(ret.Hash, ret, LOCALELOOKUP_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityLocaleLookup Get(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityLocaleLookup>.GetFromCache(hash, LOCALELOOKUP_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityLocaleLookup>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityLocaleLookup>.UpdateCache(ret.Id, ret, LOCALELOOKUP_CACHE);
                    DocEntityThreadCache<DocEntityLocaleLookup>.UpdateCache(ret.Hash, ret, LOCALELOOKUP_CACHE);
                }
            }
            return ret;
        }

        [Field(Length = int.MaxValue)]
        public string Data { get; set; }


        [Field(Nullable = false)]
        public string IpAddress { get; set; }


        [Field(Nullable = false)]
        public DocEntityLocale Locale { get; set; }
        public int? LocaleId { get { return Locale?.Id; } private set { var noid = value; } }



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


        public override ModelNameEnm ClassName => CLASS_NAME;
        public override DocConstantModelName TableName => CLASS_NAME.ToEnumString();

        public const string CACHE_KEY_PREFIX = "FindLocaleLookups";

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
                throw new HttpError(HttpStatusCode.Conflict, $"LocaleLookup requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();
            _validated = true;
        }

        public override IDocEntity SaveChanges(bool ignoreCache, DocConstantPermission permission)
        {
            IpAddress = IpAddress?.TrimAndPruneSpaces();
            return base.SaveChanges(ignoreCache, permission);
        }

        public override IDocEntity SaveChanges(bool ignoreCache) => SaveChanges(ignoreCache, DocConstantPermission.EDIT);
        public override IDocEntity SaveChanges(DocConstantPermission permission) => SaveChanges(false, DocConstantPermission.EDIT);
        public override IDocEntity SaveChanges() => SaveChanges(DocConstantPermission.EDIT);

        public override void FlushCache()
        {
            base.FlushCache();

        }

        public DocValidationMessage ValidationMessage
        {
            get
            {
                var isValid = true;
                var message = string.Empty;

                if(DocTools.IsNullOrEmpty(IpAddress))
                {
                    isValid = false;
                    message += " IpAddress is a required property.";
                }
                if(DocTools.IsNullOrEmpty(Locale))
                {
                    isValid = false;
                    message += " Locale is a required property.";
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }

        public LocaleLookup ToDto() => Mapper.Map<DocEntityLocaleLookup, LocaleLookup>(this);

        public static explicit operator LocaleLookup(DocEntityLocaleLookup en) => en?.ToDto();

        public override IDto ToIDto() => ToDto();
    }
}
