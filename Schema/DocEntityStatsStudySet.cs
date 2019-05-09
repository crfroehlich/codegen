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
    [TableMapping(DocConstantModelName.STATSSTUDYSET)]
    public partial class DocEntityStatsStudySet : DocEntityBase
    {
        private const string STATSSTUDYSET_CACHE = "StatsStudySetCache";
        public const string TABLE_NAME = DocConstantModelName.STATSSTUDYSET;
        
        #region Constructor
        public DocEntityStatsStudySet(Session session) : base(session) {}

        public DocEntityStatsStudySet() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        protected override List<string> _select => __vf ?? (__vf = DocWebSession.GetTypeSelect(new StatsStudySet()));

        #region Static Members
        public static DocEntityStatsStudySet Get(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? Get(reference.Id) : null;
        }

        public static DocEntityStatsStudySet Get(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityStatsStudySet>.GetFromCache(primaryKey, STATSSTUDYSET_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityStatsStudySet>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityStatsStudySet>.UpdateCache(ret.Id, ret, STATSSTUDYSET_CACHE);
                    DocEntityThreadCache<DocEntityStatsStudySet>.UpdateCache(ret.Hash, ret, STATSSTUDYSET_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityStatsStudySet Get(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityStatsStudySet>.GetFromCache(hash, STATSSTUDYSET_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityStatsStudySet>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityStatsStudySet>.UpdateCache(ret.Id, ret, STATSSTUDYSET_CACHE);
                    DocEntityThreadCache<DocEntityStatsStudySet>.UpdateCache(ret.Hash, ret, STATSSTUDYSET_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field(Nullable = false, DefaultValue = 0)]
        public int BoundTerms { get; set; }


        [Field(Nullable = false, DefaultValue = 0)]
        public int Characteristics { get; set; }


        [Field(Nullable = false, DefaultValue = 0)]
        public int DataPoints { get; set; }


        [Field(Nullable = false, DefaultValue = 0)]
        public int DesignCount { get; set; }


        [Field]
        public string DesignList { get; set; }


        [Field(Nullable = false)]
        public DocEntityDocumentSet DocumentSet { get; set; }
        public int? DocumentSetId { get { return DocumentSet?.Id; } private set { var noid = value; } }


        [Field(Nullable = false, DefaultValue = 0)]
        public int Interventions { get; set; }


        [Field(Nullable = false, DefaultValue = 0)]
        public int Outcomes { get; set; }


        [Field(Nullable = false, DefaultValue = 0)]
        public int OutcomesReported { get; set; }


        [Field]
        public DocEntitySet<DocEntityStatsRecord> Records { get; private set; }


        public int? RecordsCount { get { return Records.Count(); } private set { var noid = value; } }


        [Field(Nullable = false)]
        public DocEntityStats Stat { get; set; }
        public int? StatId { get { return Stat?.Id; } private set { var noid = value; } }


        [Field]
        public int Studies { get; set; }


        [Field(Nullable = false, DefaultValue = 0)]
        public int TypeCount { get; set; }


        [Field]
        public string TypeList { get; set; }


        [Field(Nullable = false, DefaultValue = 0)]
        public int UnboundTerms { get; set; }


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

        public const string CACHE_KEY_PREFIX = "FindStatsStudySets";

        #endregion Overrides of DocEntity

        #region Entity overrides
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
                throw new HttpError(HttpStatusCode.Conflict, $"StatsStudySet requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();
            _validated = true;
        }

        public override IDocEntity SaveChanges(bool ignoreCache, DocConstantPermission permission)
        {
            DesignList = DesignList?.TrimAndPruneSpaces();
            TypeList = TypeList?.TrimAndPruneSpaces();
            return base.SaveChanges(ignoreCache, permission);
        }

        public override IDocEntity SaveChanges(bool ignoreCache) => SaveChanges(ignoreCache, DocConstantPermission.EDIT);
        public override IDocEntity SaveChanges(DocConstantPermission permission) => SaveChanges(false, DocConstantPermission.EDIT);
        public override IDocEntity SaveChanges() => SaveChanges(DocConstantPermission.EDIT);

        public override void FlushCache()
        {
            base.FlushCache();

        }
        #endregion Entity overrides

        #region Validation
        public DocValidationMessage ValidationMessage
        {
            get
            {
                var isValid = true;
                var message = string.Empty;

                if(DocTools.IsNullOrEmpty(BoundTerms))
                {
                    isValid = false;
                    message += " BoundTerms is a required property.";
                }
                if(DocTools.IsNullOrEmpty(Characteristics))
                {
                    isValid = false;
                    message += " Characteristics is a required property.";
                }
                if(DocTools.IsNullOrEmpty(DataPoints))
                {
                    isValid = false;
                    message += " DataPoints is a required property.";
                }
                if(DocTools.IsNullOrEmpty(DesignCount))
                {
                    isValid = false;
                    message += " DesignCount is a required property.";
                }
                if(DocTools.IsNullOrEmpty(DocumentSet))
                {
                    isValid = false;
                    message += " DocumentSet is a required property.";
                }
                if(DocTools.IsNullOrEmpty(Interventions))
                {
                    isValid = false;
                    message += " Interventions is a required property.";
                }
                if(DocTools.IsNullOrEmpty(Outcomes))
                {
                    isValid = false;
                    message += " Outcomes is a required property.";
                }
                if(DocTools.IsNullOrEmpty(OutcomesReported))
                {
                    isValid = false;
                    message += " OutcomesReported is a required property.";
                }
                if(DocTools.IsNullOrEmpty(Stat))
                {
                    isValid = false;
                    message += " Stat is a required property.";
                }
                if(DocTools.IsNullOrEmpty(TypeCount))
                {
                    isValid = false;
                    message += " TypeCount is a required property.";
                }
                if(DocTools.IsNullOrEmpty(UnboundTerms))
                {
                    isValid = false;
                    message += " UnboundTerms is a required property.";
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Converters

        public StatsStudySet ToDto() => Mapper.Map<DocEntityStatsStudySet, StatsStudySet>(this);

        public static explicit operator StatsStudySet(DocEntityStatsStudySet en) => en?.ToDto();
        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }
}
