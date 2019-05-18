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
    [TableMapping(DocConstantModelName.IMPORTDATA)]
    public partial class DocEntityImportData : DocEntityBase
    {
        private const string IMPORTDATA_CACHE = "ImportDataCache";
        public const ModelNameEnm CLASS_NAME = ModelNameEnm.IMPORTDATA;
        
        #region Constructor
        public DocEntityImportData(Session session) : base(session) {}

        public DocEntityImportData() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        protected override List<string> _select => __vf ?? (__vf = DocWebSession.GetTypeSelect(new ImportData()));

        #region Static Members
        public static DocEntityImportData Get(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? Get(reference.Id) : null;
        }

        public static DocEntityImportData Get(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityImportData>.GetFromCache(primaryKey, IMPORTDATA_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityImportData>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityImportData>.UpdateCache(ret.Id, ret, IMPORTDATA_CACHE);
                    DocEntityThreadCache<DocEntityImportData>.UpdateCache(ret.Hash, ret, IMPORTDATA_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityImportData Get(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityImportData>.GetFromCache(hash, IMPORTDATA_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityImportData>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityImportData>.UpdateCache(ret.Id, ret, IMPORTDATA_CACHE);
                    DocEntityThreadCache<DocEntityImportData>.UpdateCache(ret.Hash, ret, IMPORTDATA_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field]
        public DateTime? CompletedOn { get; set; }


        [Field]
        public DocEntitySet<DocEntityDataSet> DataSets { get; private set; }


        public int? DataSetsCount { get { return DataSets.Count(); } private set { var noid = value; } }


        [Field]
        public DocEntityDocument Document { get; set; }
        public int? DocumentId { get { return Document?.Id; } private set { var noid = value; } }


        [Field(Length = int.MaxValue)]
        public string ErrorData { get; set; }


        [Field]
        public string ExtractUrl { get; set; }


        [Field(DefaultValue = false)]
        public bool HighPriority { get; set; }


        [Field(DefaultValue = true)]
        public bool ImportFr { get; set; }


        [Field]
        public DocEntityLookupTable ImportLocation { get; set; }
        public int? ImportLocationId { get { return ImportLocation?.Id; } private set { var noid = value; } }


        [Field(DefaultValue = false)]
        public bool ImportNewName { get; set; }


        [Field(DefaultValue = false)]
        public bool ImportTable { get; set; }


        [Field(DefaultValue = true)]
        public bool ImportText { get; set; }


        [Field]
        public DocEntityLookupTable ImportType { get; set; }
        public int? ImportTypeId { get { return ImportType?.Id; } private set { var noid = value; } }


        [Field(Nullable = false, DefaultValue = false)]
        public bool IsLegacy { get; set; }


        [Field]
        public int? Order { get; set; }


        [Field(Nullable = false)]
        public int ReferenceId { get; set; }


        [Field]
        public DocEntityUser RequestedBy { get; set; }
        public int? RequestedById { get { return RequestedBy?.Id; } private set { var noid = value; } }


        [Field]
        public DateTime? RequestedOn { get; set; }


        [Field]
        public DateTime? StartedOn { get; set; }


        [Field(Nullable = false)]
        public DocEntityLookupTable Status { get; set; }
        public int? StatusId { get { return Status?.Id; } private set { var noid = value; } }


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

        public override ModelNameEnm ClassName => CLASS_NAME;

        public override DocConstantModelName TableName => CLASS_NAME.ToEnumString();

        public const string CACHE_KEY_PREFIX = "FindImportDatas";

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
                throw new HttpError(HttpStatusCode.Conflict, $"ImportData requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();
            _validated = true;
        }

        public override IDocEntity SaveChanges(bool ignoreCache, DocConstantPermission permission)
        {
            ExtractUrl = ExtractUrl?.TrimAndPruneSpaces();
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

                if(null != ImportLocation && ImportLocation?.Enum?.Name != "StudyImportLocation")
                {
                    isValid = false;
                    message += " ImportLocation is a " + ImportLocation?.Enum?.Name + ", but must be a StudyImportLocation.";
                }
                if(null != ImportType && ImportType?.Enum?.Name != "StudyImportType")
                {
                    isValid = false;
                    message += " ImportType is a " + ImportType?.Enum?.Name + ", but must be a StudyImportType.";
                }
                if(DocTools.IsNullOrEmpty(IsLegacy))
                {
                    isValid = false;
                    message += " IsLegacy is a required property.";
                }
                if(DocTools.IsNullOrEmpty(ReferenceId))
                {
                    isValid = false;
                    message += " ReferenceId is a required property.";
                }
                if(DocTools.IsNullOrEmpty(Status))
                {
                    isValid = false;
                    message += " Status is a required property.";
                }
                else
                {
                    if(Status.Enum?.Name != "ImportStatus")
                    {
                        isValid = false;
                        message += " Status is a " + Status.Enum.Name + ", but must be a ImportStatus.";
                    }
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Converters

        public ImportData ToDto() => Mapper.Map<DocEntityImportData, ImportData>(this);

        public static explicit operator ImportData(DocEntityImportData en) => en?.ToDto();
        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }
}
