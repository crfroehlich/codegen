
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
    [TableMapping(DocConstantModelName.DOCUMENTSET)]
    public partial class DocEntityDocumentSet : DocEntityBase
    {
        private const string DOCUMENTSET_CACHE = "DocumentSetCache";
        public const ModelNameEnm CLASS_NAME = ModelNameEnm.DOCUMENTSET;
        
        public DocEntityDocumentSet(Session session) : base(session) {}

        public DocEntityDocumentSet() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}

        protected override List<string> _select => __vf ?? (__vf = DocWebSession.GetTypeSelect(new DocumentSet()));

        public static DocEntityDocumentSet Get(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? Get(reference.Id) : null;
        }

        public static DocEntityDocumentSet Get(int? primaryKey, bool noCache, DocQuery query)
        {
            if(!(primaryKey > 0)) return null;
            return query.SelectAll<DocEntityDocumentSet>().FirstOrDefault(e => e.Id == primaryKey.Value);
        }

        public static DocEntityDocumentSet Get(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityDocumentSet>.GetFromCache(primaryKey, DOCUMENTSET_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityDocumentSet>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityDocumentSet>.UpdateCache(ret.Id, ret, DOCUMENTSET_CACHE);
                    DocEntityThreadCache<DocEntityDocumentSet>.UpdateCache(ret.Hash, ret, DOCUMENTSET_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityDocumentSet Get(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityDocumentSet>.GetFromCache(hash, DOCUMENTSET_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityDocumentSet>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityDocumentSet>.UpdateCache(ret.Id, ret, DOCUMENTSET_CACHE);
                    DocEntityThreadCache<DocEntityDocumentSet>.UpdateCache(ret.Hash, ret, DOCUMENTSET_CACHE);
                }
            }
            return ret;
        }

        [Field]
        [Association(PairTo = nameof(DocEntityClient.DocumentSets), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityClient> Clients { get; private set; }


        public List<int> ClientsIds => Clients.Select(e => e.Id).ToList();


        public int? ClientsCount { get { return Clients.Count(); } private set { var noid = value; } }


        [Field(Nullable = false, DefaultValue = false)]
        public bool Confidential { get; set; }


        [Field]
        [Association(PairTo = nameof(DocEntityDivision.DocumentSets), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityDivision> Divisions { get; private set; }


        public List<int> DivisionsIds => Divisions.Select(e => e.Id).ToList();


        public int? DivisionsCount { get { return Divisions.Count(); } private set { var noid = value; } }


        [Field]
        [Association(PairTo = nameof(DocEntityDocument.DocumentSets), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityDocument> Documents { get; private set; }


        public List<int> DocumentsIds => Documents.Select(e => e.Id).ToList();


        public int? DocumentsCount { get { return Documents.Count(); } private set { var noid = value; } }


        [Field]
        [Association(PairTo = nameof(DocEntityDocumentSet.Owner), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityDocumentSet> DocumentSets { get; private set; }


        public List<int> DocumentSetsIds => DocumentSets.Select(e => e.Id).ToList();


        public int? DocumentSetsCount { get { return DocumentSets.Count(); } private set { var noid = value; } }


        [Field]
        [Association(PairTo = nameof(DocEntityDocumentSetHistory.DocumentSet), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityDocumentSetHistory> Histories { get; private set; }


        public List<int> HistoriesIds => Histories.Select(e => e.Id).ToList();


        public int? HistoriesCount { get { return Histories.Count(); } private set { var noid = value; } }


        [Field]
        public int? LegacyDocumentSetId { get; set; }


        [Field(Nullable = false, Length = 400)]
        public string Name { get; set; }


        [Field]
        public DocEntityDocumentSet Owner { get; set; }
        public int? OwnerId { get { return Owner?.Id; } private set { var noid = value; } }


        [Field]
        public DocEntityTeam ProjectTeam { get; set; }
        public int? ProjectTeamId { get { return ProjectTeam?.Id; } private set { var noid = value; } }


        [Field]
        [Association(PairTo = nameof(DocEntityScope.DocumentSet), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityScope> Scopes { get; private set; }


        public List<int> ScopesIds => Scopes.Select(e => e.Id).ToList();


        public int? ScopesCount { get { return Scopes.Count(); } private set { var noid = value; } }


        [Field(Length = int.MaxValue)]
        public string Settings { get; set; }


        [Field]
        [Association(PairTo = nameof(DocEntityStatsStudySet.DocumentSet), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityStatsStudySet> Stats { get; private set; }


        public List<int> StatsIds => Stats.Select(e => e.Id).ToList();


        public int? StatsCount { get { return Stats.Count(); } private set { var noid = value; } }


        [Field(Nullable = false, DefaultValue = DocumentSetTypeEnm.DATA_SET)]
        public DocumentSetTypeEnm Type { get; set; }


        [Field]
        [Association(PairTo = nameof(DocEntityUser.DocumentSets), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityUser> Users { get; private set; }


        public List<int> UsersIds => Users.Select(e => e.Id).ToList();


        public int? UsersCount { get { return Users.Count(); } private set { var noid = value; } }



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

        public const string CACHE_KEY_PREFIX = "FindDocumentSets";


        /// <summary>
        ///    Called when entity is about to be removed.
        /// </summary>
        protected override void OnRemoving()
        {
            base.OnRemoving();
            try
            {
                DocumentSets.Clear(); //foreach thing in DocumentSets en.Remove();
            }
            catch(Exception ex)
            {
                throw new DocException("Failed to delete DocumentSet in DocumentSets delete", ex);
            }
            try
            {
                Histories.Clear(); //foreach thing in Histories en.Remove();
            }
            catch(Exception ex)
            {
                throw new DocException("Failed to delete DocumentSet in Histories delete", ex);
            }
            try
            {
                Scopes.Clear(); //foreach thing in Scopes en.Remove();
            }
            catch(Exception ex)
            {
                throw new DocException("Failed to delete DocumentSet in Scopes delete", ex);
            }
            try
            {
                Stats.Clear(); //foreach thing in Stats en.Remove();
            }
            catch(Exception ex)
            {
                throw new DocException("Failed to delete DocumentSet in Stats delete", ex);
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
                throw new HttpError(HttpStatusCode.Conflict, $"DocumentSet requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();
            _validated = true;
        }

        public override IDocEntity SaveChanges(bool ignoreCache, DocConstantPermission permission)
        {
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

        public DocValidationMessage ValidationMessage
        {
            get
            {
                var isValid = true;
                var message = string.Empty;

                if(DocTools.IsNullOrEmpty(Confidential))
                {
                    isValid = false;
                    message += " Confidential is a required property.";
                }
                if(DocTools.IsNullOrEmpty(Name))
                {
                    isValid = false;
                    message += " Name is a required property.";
                }
                if(DocTools.IsNullOrEmpty(Type))
                {
                    isValid = false;
                    message += " Type is a required property.";
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }


        public DocumentSet ToDto() => Mapper.Map<DocEntityDocumentSet, DocumentSet>(this);

        public static explicit operator DocumentSet(DocEntityDocumentSet en) => en?.ToDto();

        public override IDto ToIDto() => ToDto();
    }
}
