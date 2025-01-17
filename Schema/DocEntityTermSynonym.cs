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


namespace Services.Schema
{
    [TableMapping(DocConstantModelName.TERMSYNONYM)]
    public partial class DocEntityTermSynonym : DocEntityBase
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private const string TERMSYNONYM_CACHE = "TermSynonymCache";
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public  const ModelNameEnm CLASS_NAME = ModelNameEnm.TERMSYNONYM;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocEntityTermSynonym(Session session) : base(session) {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocEntityTermSynonym() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        protected override List<string> _select => __vf ?? (__vf = DocWebSession.GetTypeSelect(new TermSynonym()));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public new static DocEntityTermSynonym Get(Reference reference) => (true == (reference?.Id > 0)) ? Get(reference.Id) : null;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public new static DocEntityTermSynonym Get(int? primaryKey, bool noCache, DocQuery query)
        {
            if(!(primaryKey > 0)) return null;
            return query.SelectAll<DocEntityTermSynonym>().FirstOrDefault(e => e.Id == primaryKey.Value);
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public new static DocEntityTermSynonym Get(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityTermSynonym>.GetFromCache(primaryKey, TERMSYNONYM_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityTermSynonym>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityTermSynonym>.UpdateCache(ret.Id, ret, TERMSYNONYM_CACHE);
                    DocEntityThreadCache<DocEntityTermSynonym>.UpdateCache(ret.Hash, ret, TERMSYNONYM_CACHE);
                }
            }
            return ret;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static DocEntityTermSynonym Get(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityTermSynonym>.GetFromCache(hash, TERMSYNONYM_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityTermSynonym>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityTermSynonym>.UpdateCache(ret.Id, ret, TERMSYNONYM_CACHE);
                    DocEntityThreadCache<DocEntityTermSynonym>.UpdateCache(ret.Hash, ret, TERMSYNONYM_CACHE);
                }
            }
            return ret;
        }

        [Field]
        public bool Approved { get; set; }


        [Field]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocEntitySet<DocEntityLookupTableBinding> Bindings { get; private set; }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> BindingsIds => Bindings.Select(e => e.Id).ToList();
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? BindingsCount { get { return Bindings.Count(); } private set { var noid = value; } }


        [Field(Nullable = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocEntityTermMaster Master { get; set; }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? MasterId { get { return Master?.Id; } private set { var noid = value; } }


        [Field]
        public bool Preferred { get; set; }


        [Field]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocEntityScope Scope { get; set; }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? ScopeId { get { return Scope?.Id; } private set { var noid = value; } }


        [Field(Nullable = false, Length = 800)]
        public string Synonym { get; set; }



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
        public const string CACHE_KEY_PREFIX = "FindTermSynonyms";

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
                throw new HttpError(HttpStatusCode.Conflict, $"TermSynonym requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();
            _validated = true;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override IDocEntity SaveChanges(bool ignoreCache, DocConstantPermission permission)
        {
            Synonym = Synonym?.TrimAndPruneSpaces();
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
            DocCacheClient.RemoveById(Id);
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocValidationMessage ValidationMessage
        {
            get
            {
                var isValid = true;
                var message = string.Empty;

                if(DocTools.IsNullOrEmpty(Master))
                {
                    isValid = false;
                    message += " Master is a required property.";
                }
                if(DocTools.IsNullOrEmpty(Synonym))
                {
                    isValid = false;
                    message += " Synonym is a required property.";
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public TermSynonym ToDto() => Mapper.Map<DocEntityTermSynonym, TermSynonym>(this);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static explicit operator TermSynonym(DocEntityTermSynonym en) => en?.ToDto();

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override IDto ToIDto() => ToDto();
    }
}
