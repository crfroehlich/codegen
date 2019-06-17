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
    [TableMapping(DocConstantModelName.DIVISION)]
    public partial class DocEntityDivision : DocEntityBase
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private const string DIVISION_CACHE = "DivisionCache";
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public  const ModelNameEnm CLASS_NAME = ModelNameEnm.DIVISION;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocEntityDivision(Session session) : base(session) {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocEntityDivision() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        protected override List<string> _select => __vf ?? (__vf = DocWebSession.GetTypeSelect(new Division()));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static DocEntityDivision Get(Reference reference) => (true == (reference?.Id > 0)) ? Get(reference.Id) : null;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static DocEntityDivision Get(int? primaryKey, bool noCache, DocQuery query)
        {
            if(!(primaryKey > 0)) return null;
            return query.SelectAll<DocEntityDivision>().FirstOrDefault(e => e.Id == primaryKey.Value);
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public new static DocEntityDivision Get(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityDivision>.GetFromCache(primaryKey, DIVISION_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityDivision>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityDivision>.UpdateCache(ret.Id, ret, DIVISION_CACHE);
                    DocEntityThreadCache<DocEntityDivision>.UpdateCache(ret.Hash, ret, DIVISION_CACHE);
                }
            }
            return ret;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static DocEntityDivision Get(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityDivision>.GetFromCache(hash, DIVISION_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityDivision>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityDivision>.UpdateCache(ret.Id, ret, DIVISION_CACHE);
                    DocEntityThreadCache<DocEntityDivision>.UpdateCache(ret.Hash, ret, DIVISION_CACHE);
                }
            }
            return ret;
        }

        [Field(Nullable = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocEntityClient Client { get; set; }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? ClientId { get { return Client?.Id; } private set { var noid = value; } }

        [Field]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocEntityLocale DefaultLocale { get; set; }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? DefaultLocaleId { get { return DefaultLocale?.Id; } private set { var noid = value; } }

        [Field]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocEntitySet<DocEntityDocumentSet> DocumentSets { get; private set; }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> DocumentSetsIds => DocumentSets.Select(e => e.Id).ToList();
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? DocumentSetsCount { get { return DocumentSets.Count(); } private set { var noid = value; } }

        [Field(Nullable = false, Length = 200)]
        public string Name { get; set; }

        [Field(Nullable = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocEntityRole Role { get; set; }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? RoleId { get { return Role?.Id; } private set { var noid = value; } }

        [Field(Length = int.MaxValue)]
        public string Settings { get; set; }

        [Field]
        [Association(PairTo = nameof(DocEntityUser.Division), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocEntitySet<DocEntityUser> Users { get; private set; }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> UsersIds => Users.Select(e => e.Id).ToList();
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? UsersCount { get { return Users.Count(); } private set { var noid = value; } }



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
        public const string CACHE_KEY_PREFIX = "FindDivisions";

        /// <summary>
        ///    Called when entity is about to be removed.
        /// </summary>
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        protected override void OnRemoving()
        {
            base.OnRemoving();
            try
            {
                Users.Clear(); //foreach thing in Users en.Remove();
            }
            catch(Exception ex)
            {
                throw new DocException("Failed to delete Division in Users delete", ex);
            }
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
                throw new HttpError(HttpStatusCode.Conflict, $"Division requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();
            _validated = true;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override IDocEntity SaveChanges(bool ignoreCache, DocConstantPermission permission)
        {
            Name = Name?.TrimAndPruneSpaces();
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

                if(DocTools.IsNullOrEmpty(Client))
                {
                    isValid = false;
                    message += " Client is a required property.";
                }
                if(DocTools.IsNullOrEmpty(Name))
                {
                    isValid = false;
                    message += " Name is a required property.";
                }
                if(DocTools.IsNullOrEmpty(Role))
                {
                    isValid = false;
                    message += " Role is a required property.";
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Division ToDto() => Mapper.Map<DocEntityDivision, Division>(this);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static explicit operator Division(DocEntityDivision en) => en?.ToDto();

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override IDto ToIDto() => ToDto();
    }
}
