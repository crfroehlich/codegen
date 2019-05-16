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
    [TableMapping(DocConstantModelName.DOCUMENTSET)]
    public partial class DocEntityDocumentSet : DocEntityBase
    {
        private const string DOCUMENTSET_CACHE = "DocumentSetCache";
        public const string TABLE_NAME = DocConstantModelName.DOCUMENTSET;
        
        #region Constructor
        public DocEntityDocumentSet(Session session) : base(session) {}

        public DocEntityDocumentSet() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        protected override List<string> _select => __vf ?? (__vf = DocWebSession.GetTypeSelect(new DocumentSet()));

        #region Static Members
        public static DocEntityDocumentSet Get(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? Get(reference.Id) : null;
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
        #endregion Static Members

        #region Properties
        [Field]
        [Association(PairTo = nameof(DocEntityClient.DocumentSets), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityClient> Clients { get; private set; }


        public int? ClientsCount { get { return Clients.Count(); } private set { var noid = value; } }


        [Field(Nullable = false, DefaultValue = false)]
        public bool Confidential { get; set; }


        [Field]
        [Association(PairTo = nameof(DocEntityDivision.DocumentSets), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityDivision> Divisions { get; private set; }


        public int? DivisionsCount { get { return Divisions.Count(); } private set { var noid = value; } }


        [Field]
        [Association(PairTo = nameof(DocEntityDocument.DocumentSets), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityDocument> Documents { get; private set; }


        public int? DocumentsCount { get { return Documents.Count(); } private set { var noid = value; } }


        [Field]
        [Association(PairTo = nameof(DocEntityDocumentSet.Owner), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityDocumentSet> DocumentSets { get; private set; }


        public int? DocumentSetsCount { get { return DocumentSets.Count(); } private set { var noid = value; } }


        [Field]
        [Association(PairTo = nameof(DocEntityDocumentSetHistory.DocumentSet), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityDocumentSetHistory> Histories { get; private set; }


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


        public int? ScopesCount { get { return Scopes.Count(); } private set { var noid = value; } }


        [Field(Length = int.MaxValue)]
        public string Settings { get; set; }


        [Field]
        [Association(PairTo = nameof(DocEntityStatsStudySet.DocumentSet), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityStatsStudySet> Stats { get; private set; }


        public int? StatsCount { get { return Stats.Count(); } private set { var noid = value; } }


        [Field(Nullable = false, DefaultValue = DocumentSetTypeEnm.DATA_SET)]
        public DocumentSetTypeEnm Type { get; set; }


        [Field]
        [Association(PairTo = nameof(DocEntityUser.DocumentSets), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityUser> Users { get; private set; }


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
        #endregion Properties

        #region Overrides of DocEntity

        public override DocConstantModelName TableName => TABLE_NAME;

        public const string CACHE_KEY_PREFIX = "FindDocumentSets";

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
        #endregion Entity overrides

        #region Validation
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
        #endregion Validation

        #region Converters

        public DocumentSet ToDto() => Mapper.Map<DocEntityDocumentSet, DocumentSet>(this);

        public static explicit operator DocumentSet(DocEntityDocumentSet en) => en?.ToDto();
        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }
}
