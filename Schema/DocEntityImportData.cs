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
using System.Runtime.Serialization;

using Services.Core;
using Services.Db;
using Services.Dto;
using Services.Dto.internals;
using Services.Enums;
using Services.Models;

using ServiceStack;

using Typed.Notifications;
using Typed.Settings;

using Xtensive.Orm;
using Xtensive.Orm.Model;

using Attribute = Services.Dto.Attribute;
using ValueType = Services.Dto.ValueType;

namespace Services.Schema
{
    [TableMapping(DocConstantModelName.IMPORTDATA)]
    public partial class DocEntityImportData : DocEntityBase
    {
        private const string IMPORTDATA_CACHE = "ImportDataCache";
        public const string TABLE_NAME = DocConstantModelName.IMPORTDATA;
        
        #region Constructor
        public DocEntityImportData(Session session) : base(session) {}

        public DocEntityImportData() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        #region VisibleFields

        protected override List<string> _visibleFields
        {
            get
            {
                if(null == __vf)
                {
                    __vf = DocWebSession.GetTypeVisibleFields(new ImportData());
                }
                return __vf;
            }
        }

        #endregion VisibleFields

        #region Static Members
        public static DocEntityImportData GetImportData(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetImportData(reference.Id) : null;
        }

        public static DocEntityImportData GetImportData(int? primaryKey)
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

        public static DocEntityImportData GetImportData(Guid hash)
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
        [Field()]
        [FieldMapping(nameof(CompletedOn))]
        public DateTime? CompletedOn { get; set; }


        [Field()]
        [FieldMapping(nameof(Document))]
        public DocEntityDocument Document { get; set; }
        public int? DocumentId { get { return Document?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(DocumentSets))]
        public DocEntitySet<DocEntityDocumentSet> DocumentSets { get; private set; }


        public int? DocumentSetsCount { get { return DocumentSets.Count(); } private set { var noid = value; } }


        [Field(Length = int.MaxValue)]
        [FieldMapping(nameof(ErrorData))]
        public string ErrorData { get; set; }


        [Field()]
        [FieldMapping(nameof(ExtractUrl))]
        public string ExtractUrl { get; set; }


        [Field(DefaultValue = false)]
        [FieldMapping(nameof(HighPriority))]
        public bool HighPriority { get; set; }


        [Field(DefaultValue = true)]
        [FieldMapping(nameof(ImportFr))]
        public bool ImportFr { get; set; }


        [Field(DefaultValue = false)]
        [FieldMapping(nameof(ImportNewName))]
        public bool ImportNewName { get; set; }


        [Field(DefaultValue = false)]
        [FieldMapping(nameof(ImportTable))]
        public bool ImportTable { get; set; }


        [Field(DefaultValue = true)]
        [FieldMapping(nameof(ImportText))]
        public bool ImportText { get; set; }


        [Field()]
        [FieldMapping(nameof(ImportType))]
        public DocEntityLookupTable ImportType { get; set; }
        public int? ImportTypeId { get { return ImportType?.Id; } private set { var noid = value; } }


        [Field(Nullable = false, DefaultValue = false)]
        [FieldMapping(nameof(IsLegacy))]
        public bool IsLegacy { get; set; }


        [Field()]
        [FieldMapping(nameof(Order))]
        public int? Order { get; set; }


        [Field(Nullable = false)]
        [FieldMapping(nameof(ReferenceId))]
        public int ReferenceId { get; set; }


        [Field()]
        [FieldMapping(nameof(RequestedBy))]
        public DocEntityUser RequestedBy { get; set; }
        public int? RequestedById { get { return RequestedBy?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(RequestedOn))]
        public DateTime? RequestedOn { get; set; }


        [Field()]
        [FieldMapping(nameof(StartedOn))]
        public DateTime? StartedOn { get; set; }


        [Field(Nullable = false)]
        [FieldMapping(nameof(Status))]
        public DocEntityLookupTable Status { get; set; }
        public int? StatusId { get { return Status?.Id; } private set { var noid = value; } }



        [Field(LazyLoad = false, Length = Int32.MaxValue)]
        public override string Gestalt { get; set; }

        [Field(DefaultValue = 0), Version(VersionMode.Manual)]
        public override int VersionNo { get; set; }

        [Field]
        public override DateTime? Created { get; set; }

        [Field]
        public override DateTime? Updated { get; set; }

        [Field(DefaultValue = false)]
        [FieldMapping(nameof(Locked))]
        public override bool Locked { get; set; }

        [Field(DefaultValue = false)]
        [FieldMapping(nameof(Archived))]
        public override bool Archived { get; set; }

        #endregion Properties

        #region Overrides of DocEntity

        public override DocConstantModelName TableName => TABLE_NAME;

        public const string CACHE_KEY_PREFIX = "FindImportDatas";

        #endregion Overrides of DocEntity

        #region Entity overrides
        /// <summary>
        ///    Called when entity is about to be removed.
        /// </summary>
        protected override void OnRemoving()
        {

            base.OnRemoving();
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

            FlushCache();

            _validated = true;


        }

        public override IDocEntity SaveChanges(DocConstantPermission permission = null)
        {
            ExtractUrl = ExtractUrl?.TrimAndPruneSpaces();
            return base.SaveChanges(permission);
        }

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

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }

    public static partial class UniqueConstraintFilter
    {
        public static Expression<Func<DocEntityImportData, bool>> ImportDataIgnoreArchived() => d => d.Archived == false;
    }

    public partial class ImportDataMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityImportData,ImportData> _EntityToDto;
        protected IMappingExpression<ImportData,DocEntityImportData> _DtoToEntity;

        public ImportDataMapper()
        {
            CreateMap<DocEntitySet<DocEntityImportData>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityImportData,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityImportData>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityImportData.GetImportData(c));
            _EntityToDto = CreateMap<DocEntityImportData,ImportData>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<ImportData>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<ImportData>(c, "Updated")))
                .ForMember(dest => dest.CompletedOn, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<ImportData>(c, nameof(DocEntityImportData.CompletedOn))))
                .ForMember(dest => dest.Document, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<ImportData>(c, nameof(DocEntityImportData.Document))))
                .ForMember(dest => dest.DocumentId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<ImportData>(c, nameof(DocEntityImportData.DocumentId))))
                .ForMember(dest => dest.DocumentSets, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<ImportData>(c, nameof(DocEntityImportData.DocumentSets))))
                .ForMember(dest => dest.DocumentSetsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<ImportData>(c, nameof(DocEntityImportData.DocumentSetsCount))))
                .ForMember(dest => dest.ErrorData, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<ImportData>(c, nameof(DocEntityImportData.ErrorData))))
                .ForMember(dest => dest.ExtractUrl, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<ImportData>(c, nameof(DocEntityImportData.ExtractUrl))))
                .ForMember(dest => dest.HighPriority, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<ImportData>(c, nameof(DocEntityImportData.HighPriority))))
                .ForMember(dest => dest.ImportFr, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<ImportData>(c, nameof(DocEntityImportData.ImportFr))))
                .ForMember(dest => dest.ImportNewName, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<ImportData>(c, nameof(DocEntityImportData.ImportNewName))))
                .ForMember(dest => dest.ImportTable, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<ImportData>(c, nameof(DocEntityImportData.ImportTable))))
                .ForMember(dest => dest.ImportText, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<ImportData>(c, nameof(DocEntityImportData.ImportText))))
                .ForMember(dest => dest.ImportType, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<ImportData>(c, nameof(DocEntityImportData.ImportType))))
                .ForMember(dest => dest.ImportTypeId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<ImportData>(c, nameof(DocEntityImportData.ImportTypeId))))
                .ForMember(dest => dest.IsLegacy, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<ImportData>(c, nameof(DocEntityImportData.IsLegacy))))
                .ForMember(dest => dest.Order, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<ImportData>(c, nameof(DocEntityImportData.Order))))
                .ForMember(dest => dest.ReferenceId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<ImportData>(c, nameof(DocEntityImportData.ReferenceId))))
                .ForMember(dest => dest.RequestedBy, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<ImportData>(c, nameof(DocEntityImportData.RequestedBy))))
                .ForMember(dest => dest.RequestedById, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<ImportData>(c, nameof(DocEntityImportData.RequestedById))))
                .ForMember(dest => dest.RequestedOn, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<ImportData>(c, nameof(DocEntityImportData.RequestedOn))))
                .ForMember(dest => dest.StartedOn, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<ImportData>(c, nameof(DocEntityImportData.StartedOn))))
                .ForMember(dest => dest.Status, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<ImportData>(c, nameof(DocEntityImportData.Status))))
                .ForMember(dest => dest.StatusId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<ImportData>(c, nameof(DocEntityImportData.StatusId))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<ImportData,DocEntityImportData>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
