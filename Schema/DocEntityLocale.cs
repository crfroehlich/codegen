
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
    [TableMapping(DocConstantModelName.LOCALE)]
    public partial class DocEntityLocale : DocEntityBase
    {
        private const string LOCALE_CACHE = "LocaleCache";
        public const ModelNameEnm CLASS_NAME = ModelNameEnm.LOCALE;
        
        public DocEntityLocale(Session session) : base(session) {}

        public DocEntityLocale() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}

        protected override List<string> _select => __vf ?? (__vf = DocWebSession.GetTypeSelect(new Locale()));

        public static DocEntityLocale Get(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? Get(reference.Id) : null;
        }

        public static DocEntityLocale Get(int? primaryKey, bool noCache, DocQuery query)
        {
            if(!(primaryKey > 0)) return null;
            return query.SelectAll<DocEntityLocale>().FirstOrDefault(e => e.Id == primaryKey.Value);
        }

        public static DocEntityLocale Get(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityLocale>.GetFromCache(primaryKey, LOCALE_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityLocale>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityLocale>.UpdateCache(ret.Id, ret, LOCALE_CACHE);
                    DocEntityThreadCache<DocEntityLocale>.UpdateCache(ret.Hash, ret, LOCALE_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityLocale Get(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityLocale>.GetFromCache(hash, LOCALE_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityLocale>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityLocale>.UpdateCache(ret.Id, ret, LOCALE_CACHE);
                    DocEntityThreadCache<DocEntityLocale>.UpdateCache(ret.Hash, ret, LOCALE_CACHE);
                }
            }
            return ret;
        }

        [Field(Nullable = false)]
        public string Country { get; set; }


        [Field(Nullable = false)]
        public string Language { get; set; }


        [Field(Nullable = false)]
        public string TimeZone { get; set; }



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

        public const string CACHE_KEY_PREFIX = "FindLocales";


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
                throw new HttpError(HttpStatusCode.Conflict, $"Locale requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();
            _validated = true;
        }

        public override IDocEntity SaveChanges(bool ignoreCache, DocConstantPermission permission)
        {
            Country = Country?.TrimAndPruneSpaces();
            Language = Language?.TrimAndPruneSpaces();
            TimeZone = TimeZone?.TrimAndPruneSpaces();
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

                if(DocTools.IsNullOrEmpty(Country))
                {
                    isValid = false;
                    message += " Country is a required property.";
                }
                if(DocTools.IsNullOrEmpty(Language))
                {
                    isValid = false;
                    message += " Language is a required property.";
                }
                if(DocTools.IsNullOrEmpty(TimeZone))
                {
                    isValid = false;
                    message += " TimeZone is a required property.";
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }


        public Locale ToDto() => Mapper.Map<DocEntityLocale, Locale>(this);

        public static explicit operator Locale(DocEntityLocale en) => en?.ToDto();

        public override IDto ToIDto() => ToDto();
    }
}
