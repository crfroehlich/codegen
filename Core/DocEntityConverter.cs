//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated by a T4 template. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Services.Dto.internals;
using Services.Enums;
using Services.Schema;

namespace Services.Core
{
    public static class DocEntityConverter
    {
        public static TDto ToDto<TEntity, TDto>(DocEntityBase entity)
            where TEntity : DocEntityBase, new()
            where TDto : class, IDto, new()
        {
            TDto ret = null;
            switch (typeof(TDto).Name)
            {
                case DocConstantModelName.ADJUDICATEDRATING:
                    var enAdjudicatedRating = entity as DocEntityAdjudicatedRating;
                    ret = enAdjudicatedRating.ToDto() as TDto;
                    break;
                case DocConstantModelName.APP:
                    var enApp = entity as DocEntityApp;
                    ret = enApp.ToDto() as TDto;
                    break;
                case DocConstantModelName.ATTRIBUTE:
                    var enAttribute = entity as DocEntityAttribute;
                    ret = enAttribute.ToDto() as TDto;
                    break;
                case DocConstantModelName.ATTRIBUTEINTERVAL:
                    var enAttributeInterval = entity as DocEntityAttributeInterval;
                    ret = enAttributeInterval.ToDto() as TDto;
                    break;
                case DocConstantModelName.AUDITDELTA:
                    var enAuditDelta = entity as DocEntityAuditDelta;
                    ret = enAuditDelta.ToDto() as TDto;
                    break;
                case DocConstantModelName.AUDITRECORD:
                    var enAuditRecord = entity as DocEntityAuditRecord;
                    ret = enAuditRecord.ToDto() as TDto;
                    break;
                case DocConstantModelName.BACKGROUNDTASK:
                    var enBackgroundTask = entity as DocEntityBackgroundTask;
                    ret = enBackgroundTask.ToDto() as TDto;
                    break;
                case DocConstantModelName.BACKGROUNDTASKHISTORY:
                    var enBackgroundTaskHistory = entity as DocEntityBackgroundTaskHistory;
                    ret = enBackgroundTaskHistory.ToDto() as TDto;
                    break;
                case DocConstantModelName.BACKGROUNDTASKITEM:
                    var enBackgroundTaskItem = entity as DocEntityBackgroundTaskItem;
                    ret = enBackgroundTaskItem.ToDto() as TDto;
                    break;
                case DocConstantModelName.BROADCAST:
                    var enBroadcast = entity as DocEntityBroadcast;
                    ret = enBroadcast.ToDto() as TDto;
                    break;
                case DocConstantModelName.CLIENT:
                    var enClient = entity as DocEntityClient;
                    ret = enClient.ToDto() as TDto;
                    break;
                case DocConstantModelName.COMMENT:
                    var enComment = entity as DocEntityComment;
                    ret = enComment.ToDto() as TDto;
                    break;
                case DocConstantModelName.DATABASEVERSION:
                    var enDatabaseVersion = entity as DocEntityDatabaseVersion;
                    ret = enDatabaseVersion.ToDto() as TDto;
                    break;
                case DocConstantModelName.DATACLASS:
                    var enDataClass = entity as DocEntityDataClass;
                    ret = enDataClass.ToDto() as TDto;
                    break;
                case DocConstantModelName.DATAPROPERTY:
                    var enDataProperty = entity as DocEntityDataProperty;
                    ret = enDataProperty.ToDto() as TDto;
                    break;
                case DocConstantModelName.DATASET:
                    var enDataSet = entity as DocEntityDataSet;
                    ret = enDataSet.ToDto() as TDto;
                    break;
                case DocConstantModelName.DATATAB:
                    var enDataTab = entity as DocEntityDataTab;
                    ret = enDataTab.ToDto() as TDto;
                    break;
                case DocConstantModelName.DATETIME:
                    var enDateTime = entity as DocEntityDateTime;
                    ret = enDateTime.ToDto() as TDto;
                    break;
                case DocConstantModelName.DEFAULT:
                    var enDefault = entity as DocEntityDefault;
                    ret = enDefault.ToDto() as TDto;
                    break;
                case DocConstantModelName.DISEASESTATESET:
                    var enDiseaseStateSet = entity as DocEntityDiseaseStateSet;
                    ret = enDiseaseStateSet.ToDto() as TDto;
                    break;
                case DocConstantModelName.DIVISION:
                    var enDivision = entity as DocEntityDivision;
                    ret = enDivision.ToDto() as TDto;
                    break;
                case DocConstantModelName.DOCUMENT:
                    var enDocument = entity as DocEntityDocument;
                    ret = enDocument.ToDto() as TDto;
                    break;
                case DocConstantModelName.DOCUMENTSET:
                    var enDocumentSet = entity as DocEntityDocumentSet;
                    ret = enDocumentSet.ToDto() as TDto;
                    break;
                case DocConstantModelName.DOCUMENTSETHISTORY:
                    var enDocumentSetHistory = entity as DocEntityDocumentSetHistory;
                    ret = enDocumentSetHistory.ToDto() as TDto;
                    break;
                case DocConstantModelName.EOD:
                    var enEoD = entity as DocEntityEoD;
                    ret = enEoD.ToDto() as TDto;
                    break;
                case DocConstantModelName.EVENT:
                    var enEvent = entity as DocEntityEvent;
                    ret = enEvent.ToDto() as TDto;
                    break;
                case DocConstantModelName.FAVORITE:
                    var enFavorite = entity as DocEntityFavorite;
                    ret = enFavorite.ToDto() as TDto;
                    break;
                case DocConstantModelName.FEATURESET:
                    var enFeatureSet = entity as DocEntityFeatureSet;
                    ret = enFeatureSet.ToDto() as TDto;
                    break;
                case DocConstantModelName.GLOSSARY:
                    var enGlossary = entity as DocEntityGlossary;
                    ret = enGlossary.ToDto() as TDto;
                    break;
                case DocConstantModelName.HELP:
                    var enHelp = entity as DocEntityHelp;
                    ret = enHelp.ToDto() as TDto;
                    break;
                case DocConstantModelName.HISTORY:
                    var enHistory = entity as DocEntityHistory;
                    ret = enHistory.ToDto() as TDto;
                    break;
                case DocConstantModelName.IMPERSONATION:
                    var enImpersonation = entity as DocEntityImpersonation;
                    ret = enImpersonation.ToDto() as TDto;
                    break;
                case DocConstantModelName.IMPORTDATA:
                    var enImportData = entity as DocEntityImportData;
                    ret = enImportData.ToDto() as TDto;
                    break;
                case DocConstantModelName.INTERVAL:
                    var enInterval = entity as DocEntityInterval;
                    ret = enInterval.ToDto() as TDto;
                    break;
                case DocConstantModelName.JUNCTION:
                    var enJunction = entity as DocEntityJunction;
                    ret = enJunction.ToDto() as TDto;
                    break;
                case DocConstantModelName.LIBRARYSET:
                    var enLibrarySet = entity as DocEntityLibrarySet;
                    ret = enLibrarySet.ToDto() as TDto;
                    break;
                case DocConstantModelName.LOCALE:
                    var enLocale = entity as DocEntityLocale;
                    ret = enLocale.ToDto() as TDto;
                    break;
                case DocConstantModelName.LOCALELOOKUP:
                    var enLocaleLookup = entity as DocEntityLocaleLookup;
                    ret = enLocaleLookup.ToDto() as TDto;
                    break;
                case DocConstantModelName.LOOKUPCATEGORY:
                    var enLookupCategory = entity as DocEntityLookupCategory;
                    ret = enLookupCategory.ToDto() as TDto;
                    break;
                case DocConstantModelName.LOOKUPTABLE:
                    var enLookupTable = entity as DocEntityLookupTable;
                    ret = enLookupTable.ToDto() as TDto;
                    break;
                case DocConstantModelName.LOOKUPTABLEBINDING:
                    var enLookupTableBinding = entity as DocEntityLookupTableBinding;
                    ret = enLookupTableBinding.ToDto() as TDto;
                    break;
                case DocConstantModelName.LOOKUPTABLEENUM:
                    var enLookupTableEnum = entity as DocEntityLookupTableEnum;
                    ret = enLookupTableEnum.ToDto() as TDto;
                    break;
                case DocConstantModelName.MEANRANGES:
                    var enMeanRanges = entity as DocEntityMeanRanges;
                    ret = enMeanRanges.ToDto() as TDto;
                    break;
                case DocConstantModelName.MEANRANGEVALUE:
                    var enMeanRangeValue = entity as DocEntityMeanRangeValue;
                    ret = enMeanRangeValue.ToDto() as TDto;
                    break;
                case DocConstantModelName.MEANVARIANCES:
                    var enMeanVariances = entity as DocEntityMeanVariances;
                    ret = enMeanVariances.ToDto() as TDto;
                    break;
                case DocConstantModelName.MEANVARIANCEVALUE:
                    var enMeanVarianceValue = entity as DocEntityMeanVarianceValue;
                    ret = enMeanVarianceValue.ToDto() as TDto;
                    break;
                case DocConstantModelName.PAGE:
                    var enPage = entity as DocEntityPage;
                    ret = enPage.ToDto() as TDto;
                    break;
                case DocConstantModelName.PROJECT:
                    var enProject = entity as DocEntityProject;
                    ret = enProject.ToDto() as TDto;
                    break;
                case DocConstantModelName.QUEUECHANNEL:
                    var enQueueChannel = entity as DocEntityQueueChannel;
                    ret = enQueueChannel.ToDto() as TDto;
                    break;
                case DocConstantModelName.RATING:
                    var enRating = entity as DocEntityRating;
                    ret = enRating.ToDto() as TDto;
                    break;
                case DocConstantModelName.RECONCILEDOCUMENT:
                    var enReconcileDocument = entity as DocEntityReconcileDocument;
                    ret = enReconcileDocument.ToDto() as TDto;
                    break;
                case DocConstantModelName.ROLE:
                    var enRole = entity as DocEntityRole;
                    ret = enRole.ToDto() as TDto;
                    break;
                case DocConstantModelName.SCOPE:
                    var enScope = entity as DocEntityScope;
                    ret = enScope.ToDto() as TDto;
                    break;
                case DocConstantModelName.SERVEPORTALSET:
                    var enServePortalSet = entity as DocEntityServePortalSet;
                    ret = enServePortalSet.ToDto() as TDto;
                    break;
                case DocConstantModelName.STATS:
                    var enStats = entity as DocEntityStats;
                    ret = enStats.ToDto() as TDto;
                    break;
                case DocConstantModelName.STATSRECORD:
                    var enStatsRecord = entity as DocEntityStatsRecord;
                    ret = enStatsRecord.ToDto() as TDto;
                    break;
                case DocConstantModelName.STATSSTUDYSET:
                    var enStatsStudySet = entity as DocEntityStatsStudySet;
                    ret = enStatsStudySet.ToDto() as TDto;
                    break;
                case DocConstantModelName.STUDYDESIGN:
                    var enStudyDesign = entity as DocEntityStudyDesign;
                    ret = enStudyDesign.ToDto() as TDto;
                    break;
                case DocConstantModelName.STUDYTYPE:
                    var enStudyType = entity as DocEntityStudyType;
                    ret = enStudyType.ToDto() as TDto;
                    break;
                case DocConstantModelName.TAG:
                    var enTag = entity as DocEntityTag;
                    ret = enTag.ToDto() as TDto;
                    break;
                case DocConstantModelName.TASK:
                    var enTask = entity as DocEntityTask;
                    ret = enTask.ToDto() as TDto;
                    break;
                case DocConstantModelName.TEAM:
                    var enTeam = entity as DocEntityTeam;
                    ret = enTeam.ToDto() as TDto;
                    break;
                case DocConstantModelName.TERMCATEGORY:
                    var enTermCategory = entity as DocEntityTermCategory;
                    ret = enTermCategory.ToDto() as TDto;
                    break;
                case DocConstantModelName.TERMMASTER:
                    var enTermMaster = entity as DocEntityTermMaster;
                    ret = enTermMaster.ToDto() as TDto;
                    break;
                case DocConstantModelName.TERMSYNONYM:
                    var enTermSynonym = entity as DocEntityTermSynonym;
                    ret = enTermSynonym.ToDto() as TDto;
                    break;
                case DocConstantModelName.THERAPEUTICAREASET:
                    var enTherapeuticAreaSet = entity as DocEntityTherapeuticAreaSet;
                    ret = enTherapeuticAreaSet.ToDto() as TDto;
                    break;
                case DocConstantModelName.TIMECARD:
                    var enTimeCard = entity as DocEntityTimeCard;
                    ret = enTimeCard.ToDto() as TDto;
                    break;
                case DocConstantModelName.TIMEPOINT:
                    var enTimePoint = entity as DocEntityTimePoint;
                    ret = enTimePoint.ToDto() as TDto;
                    break;
                case DocConstantModelName.UNITCONVERSIONRULES:
                    var enUnitConversionRules = entity as DocEntityUnitConversionRules;
                    ret = enUnitConversionRules.ToDto() as TDto;
                    break;
                case DocConstantModelName.UNITOFMEASURE:
                    var enUnitOfMeasure = entity as DocEntityUnitOfMeasure;
                    ret = enUnitOfMeasure.ToDto() as TDto;
                    break;
                case DocConstantModelName.UNITS:
                    var enUnits = entity as DocEntityUnits;
                    ret = enUnits.ToDto() as TDto;
                    break;
                case DocConstantModelName.UNITVALUE:
                    var enUnitValue = entity as DocEntityUnitValue;
                    ret = enUnitValue.ToDto() as TDto;
                    break;
                case DocConstantModelName.UPDATE:
                    var enUpdate = entity as DocEntityUpdate;
                    ret = enUpdate.ToDto() as TDto;
                    break;
                case DocConstantModelName.USER:
                    var enUser = entity as DocEntityUser;
                    ret = enUser.ToDto() as TDto;
                    break;
                case DocConstantModelName.USERREQUEST:
                    var enUserRequest = entity as DocEntityUserRequest;
                    ret = enUserRequest.ToDto() as TDto;
                    break;
                case DocConstantModelName.USERSESSION:
                    var enUserSession = entity as DocEntityUserSession;
                    ret = enUserSession.ToDto() as TDto;
                    break;
                case DocConstantModelName.USERTYPE:
                    var enUserType = entity as DocEntityUserType;
                    ret = enUserType.ToDto() as TDto;
                    break;
                case DocConstantModelName.VALUETYPE:
                    var enValueType = entity as DocEntityValueType;
                    ret = enValueType.ToDto() as TDto;
                    break;
                case DocConstantModelName.VARIABLEINSTANCE:
                    var enVariableInstance = entity as DocEntityVariableInstance;
                    ret = enVariableInstance.ToDto() as TDto;
                    break;
                case DocConstantModelName.VARIABLERULE:
                    var enVariableRule = entity as DocEntityVariableRule;
                    ret = enVariableRule.ToDto() as TDto;
                    break;
                case DocConstantModelName.WORKFLOW:
                    var enWorkflow = entity as DocEntityWorkflow;
                    ret = enWorkflow.ToDto() as TDto;
                    break;
            }
            return ret;
        }
    }
}
