
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
    [TableMapping(DocConstantModelName.CLIENT)]
    public partial class DocEntityClient : DocEntityBase
    {
        private const string CLIENT_CACHE = "ClientCache";
        public const ModelNameEnm CLASS_NAME = ModelNameEnm.CLIENT;

        public DocEntityClient(Session session) : base(session) {}

        public DocEntityClient() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}

        protected override List<string> _select => __vf ?? (__vf = DocWebSession.GetTypeSelect(new Client()));
        public static DocEntityClient Get(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? Get(reference.Id) : null;
        }

        public static DocEntityClient Get(int? primaryKey, bool noCache, DocQuery query)
        {
            if(!(primaryKey > 0)) return null;
            return query.SelectAll<DocEntityClient>().FirstOrDefault(e => e.Id == primaryKey.Value);
        }

        public static DocEntityClient Get(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityClient>.GetFromCache(primaryKey, CLIENT_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityClient>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityClient>.UpdateCache(ret.Id, ret, CLIENT_CACHE);
                    DocEntityThreadCache<DocEntityClient>.UpdateCache(ret.Hash, ret, CLIENT_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityClient Get(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityClient>.GetFromCache(hash, CLIENT_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityClient>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityClient>.UpdateCache(ret.Id, ret, CLIENT_CACHE);
                    DocEntityThreadCache<DocEntityClient>.UpdateCache(ret.Hash, ret, CLIENT_CACHE);
                }
            }
            return ret;
        }

        [Field]
        public DocEntityLocale DefaultLocale { get; set; }
        public int? DefaultLocaleId { get { return DefaultLocale?.Id; } private set { var noid = value; } }


        [Field]
        [Association(PairTo = nameof(DocEntityDivision.Client), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityDivision> Divisions { get; private set; }


        public List<int> DivisionsIds => Divisions.Select(e => e.Id).ToList();


        public int? DivisionsCount { get { return Divisions.Count(); } private set { var noid = value; } }


        [Field]
        public DocEntitySet<DocEntityDocumentSet> DocumentSets { get; private set; }


        public List<int> DocumentSetsIds => DocumentSets.Select(e => e.Id).ToList();


        public int? DocumentSetsCount { get { return DocumentSets.Count(); } private set { var noid = value; } }


        [Field(Nullable = false, Length = 200)]
        public string Name { get; set; }


        [Field]
        [Association(PairTo = nameof(DocEntityProject.Client), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityProject> Projects { get; private set; }


        public List<int> ProjectsIds => Projects.Select(e => e.Id).ToList();


        public int? ProjectsCount { get { return Projects.Count(); } private set { var noid = value; } }


        [Field(Nullable = false)]
        public DocEntityRole Role { get; set; }
        public int? RoleId { get { return Role?.Id; } private set { var noid = value; } }


        [Field]
        public string SalesforceAccountId { get; set; }


        [Field]
        [Association(PairTo = nameof(DocEntityScope.Client), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityScope> Scopes { get; private set; }


        public List<int> ScopesIds => Scopes.Select(e => e.Id).ToList();


        public int? ScopesCount { get { return Scopes.Count(); } private set { var noid = value; } }


        [Field(Length = int.MaxValue)]
        public string Settings { get; set; }



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

        public const string CACHE_KEY_PREFIX = "FindClients";

        /// <summary>
        ///    Called when entity is about to be removed.
        /// </summary>
        protected override void OnRemoving()
        {
            base.OnRemoving();
            try
            {
                Divisions.Clear(); //foreach thing in Divisions en.Remove();
            }
            catch(Exception ex)
            {
                throw new DocException("Failed to delete Client in Divisions delete", ex);
            }
            try
            {
                Projects.Clear(); //foreach thing in Projects en.Remove();
            }
            catch(Exception ex)
            {
                throw new DocException("Failed to delete Client in Projects delete", ex);
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
                throw new HttpError(HttpStatusCode.Conflict, $"Client requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();
            _validated = true;
        }

        public override IDocEntity SaveChanges(bool ignoreCache, DocConstantPermission permission)
        {
            Name = Name?.TrimAndPruneSpaces();
            SalesforceAccountId = SalesforceAccountId?.TrimAndPruneSpaces();
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

        public DocValidationMessage ValidationMessage
        {
            get
            {
                var isValid = true;
                var message = string.Empty;

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

        public Client ToDto() => Mapper.Map<DocEntityClient, Client>(this);

        public static explicit operator Client(DocEntityClient en) => en?.ToDto();

        public override IDto ToIDto() => ToDto();
    }
}
