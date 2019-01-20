﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated by a CodeSmith Generator project.
//
//    This class can be customized by adding or removing code from supported Custom regions
//    (e.g. Custom Imports, Custom Region 1).
//
//    All other changes to this file will cause incorrect behavior and will be lost if
//    the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#region Custom Imports

using Services.Dto;
using Services.Enums;
using Services.Schema;

using ServiceStack;

using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Net;

#endregion Custom Imports

namespace Services.API
{
    public class UnlockService : DocServiceBase
    {
        private object _GetDto(DocEntityBase en)
        {
            object ret = null;
            if (null == en) return ret;
            
            Execute.Run(s =>
            {
                switch(en.ModelName)
                {
                    case DocConstantModelName.APP:
                        var enApp = DocEntityFactory.GetEntity<DocEntityApp>( en.Id );
                        ret = enApp.ToDto();
                        break;
                    case DocConstantModelName.ATTRIBUTE:
                        var enAttribute = DocEntityFactory.GetEntity<DocEntityAttribute>( en.Id );
                        ret = enAttribute.ToDto();
                        break;
                    case DocConstantModelName.ATTRIBUTECATEGORY:
                        var enAttributeCategory = DocEntityFactory.GetEntity<DocEntityAttributeCategory>( en.Id );
                        ret = enAttributeCategory.ToDto();
                        break;
                    case DocConstantModelName.ATTRIBUTEINTERVAL:
                        var enAttributeInterval = DocEntityFactory.GetEntity<DocEntityAttributeInterval>( en.Id );
                        ret = enAttributeInterval.ToDto();
                        break;
                    case DocConstantModelName.AUDITDELTA:
                        var enAuditDelta = DocEntityFactory.GetEntity<DocEntityAuditDelta>( en.Id );
                        ret = enAuditDelta.ToDto();
                        break;
                    case DocConstantModelName.AUDITRECORD:
                        var enAuditRecord = DocEntityFactory.GetEntity<DocEntityAuditRecord>( en.Id );
                        ret = enAuditRecord.ToDto();
                        break;
                    case DocConstantModelName.BACKGROUNDTASK:
                        var enBackgroundTask = DocEntityFactory.GetEntity<DocEntityBackgroundTask>( en.Id );
                        ret = enBackgroundTask.ToDto();
                        break;
                    case DocConstantModelName.BACKGROUNDTASKHISTORY:
                        var enBackgroundTaskHistory = DocEntityFactory.GetEntity<DocEntityBackgroundTaskHistory>( en.Id );
                        ret = enBackgroundTaskHistory.ToDto();
                        break;
                    case DocConstantModelName.BACKGROUNDTASKITEM:
                        var enBackgroundTaskItem = DocEntityFactory.GetEntity<DocEntityBackgroundTaskItem>( en.Id );
                        ret = enBackgroundTaskItem.ToDto();
                        break;
                    case DocConstantModelName.BROADCAST:
                        var enBroadcast = DocEntityFactory.GetEntity<DocEntityBroadcast>( en.Id );
                        ret = enBroadcast.ToDto();
                        break;
                    case DocConstantModelName.CHARACTERISTIC:
                        var enCharacteristic = DocEntityFactory.GetEntity<DocEntityCharacteristic>( en.Id );
                        ret = enCharacteristic.ToDto();
                        break;
                    case DocConstantModelName.CLIENT:
                        var enClient = DocEntityFactory.GetEntity<DocEntityClient>( en.Id );
                        ret = enClient.ToDto();
                        break;
                    case DocConstantModelName.DATABASEVERSION:
                        var enDatabaseVersion = DocEntityFactory.GetEntity<DocEntityDatabaseVersion>( en.Id );
                        ret = enDatabaseVersion.ToDto();
                        break;
                    case DocConstantModelName.DATETIME:
                        var enDateTime = DocEntityFactory.GetEntity<DocEntityDateTime>( en.Id );
                        ret = enDateTime.ToDto();
                        break;
                    case DocConstantModelName.DEFAULT:
                        var enDefault = DocEntityFactory.GetEntity<DocEntityDefault>( en.Id );
                        ret = enDefault.ToDto();
                        break;
                    case DocConstantModelName.DIVISION:
                        var enDivision = DocEntityFactory.GetEntity<DocEntityDivision>( en.Id );
                        ret = enDivision.ToDto();
                        break;
                    case DocConstantModelName.DOCUMENT:
                        var enDocument = DocEntityFactory.GetEntity<DocEntityDocument>( en.Id );
                        ret = enDocument.ToDto();
                        break;
                    case DocConstantModelName.DOCUMENTATTRIBUTE:
                        var enDocumentAttribute = DocEntityFactory.GetEntity<DocEntityDocumentAttribute>( en.Id );
                        ret = enDocumentAttribute.ToDto();
                        break;
                    case DocConstantModelName.DOCUMENTSET:
                        var enDocumentSet = DocEntityFactory.GetEntity<DocEntityDocumentSet>( en.Id );
                        ret = enDocumentSet.ToDto();
                        break;
                    case DocConstantModelName.DOCUMENTSETHISTORY:
                        var enDocumentSetHistory = DocEntityFactory.GetEntity<DocEntityDocumentSetHistory>( en.Id );
                        ret = enDocumentSetHistory.ToDto();
                        break;
                    case DocConstantModelName.EVENT:
                        var enEvent = DocEntityFactory.GetEntity<DocEntityEvent>( en.Id );
                        ret = enEvent.ToDto();
                        break;
                    case DocConstantModelName.FEATURESET:
                        var enFeatureSet = DocEntityFactory.GetEntity<DocEntityFeatureSet>( en.Id );
                        ret = enFeatureSet.ToDto();
                        break;
                    case DocConstantModelName.FOREIGNKEY:
                        var enForeignKey = DocEntityFactory.GetEntity<DocEntityForeignKey>( en.Id );
                        ret = enForeignKey.ToDto();
                        break;
                    case DocConstantModelName.GLOSSARY:
                        var enGlossary = DocEntityFactory.GetEntity<DocEntityGlossary>( en.Id );
                        ret = enGlossary.ToDto();
                        break;
                    case DocConstantModelName.HELP:
                        var enHelp = DocEntityFactory.GetEntity<DocEntityHelp>( en.Id );
                        ret = enHelp.ToDto();
                        break;
                    case DocConstantModelName.HISTORY:
                        var enHistory = DocEntityFactory.GetEntity<DocEntityHistory>( en.Id );
                        ret = enHistory.ToDto();
                        break;
                    case DocConstantModelName.IMPERSONATION:
                        var enImpersonation = DocEntityFactory.GetEntity<DocEntityImpersonation>( en.Id );
                        ret = enImpersonation.ToDto();
                        break;
                    case DocConstantModelName.IMPORTDATA:
                        var enImportData = DocEntityFactory.GetEntity<DocEntityImportData>( en.Id );
                        ret = enImportData.ToDto();
                        break;
                    case DocConstantModelName.INTERVAL:
                        var enInterval = DocEntityFactory.GetEntity<DocEntityInterval>( en.Id );
                        ret = enInterval.ToDto();
                        break;
                    case DocConstantModelName.INTERVENTION:
                        var enIntervention = DocEntityFactory.GetEntity<DocEntityIntervention>( en.Id );
                        ret = enIntervention.ToDto();
                        break;
                    case DocConstantModelName.JCTATTRIBUTECATEGORYATTRIBUTEDOCUMENTSET:
                        var enJctAttributeCategoryAttributeDocumentSet = DocEntityFactory.GetEntity<DocEntityJctAttributeCategoryAttributeDocumentSet>( en.Id );
                        ret = enJctAttributeCategoryAttributeDocumentSet.ToDto();
                        break;
                    case DocConstantModelName.JUNCTION:
                        var enJunction = DocEntityFactory.GetEntity<DocEntityJunction>( en.Id );
                        ret = enJunction.ToDto();
                        break;
                    case DocConstantModelName.LOCALE:
                        var enLocale = DocEntityFactory.GetEntity<DocEntityLocale>( en.Id );
                        ret = enLocale.ToDto();
                        break;
                    case DocConstantModelName.LOCALELOOKUP:
                        var enLocaleLookup = DocEntityFactory.GetEntity<DocEntityLocaleLookup>( en.Id );
                        ret = enLocaleLookup.ToDto();
                        break;
                    case DocConstantModelName.LOOKUPCATEGORY:
                        var enLookupCategory = DocEntityFactory.GetEntity<DocEntityLookupCategory>( en.Id );
                        ret = enLookupCategory.ToDto();
                        break;
                    case DocConstantModelName.LOOKUPTABLE:
                        var enLookupTable = DocEntityFactory.GetEntity<DocEntityLookupTable>( en.Id );
                        ret = enLookupTable.ToDto();
                        break;
                    case DocConstantModelName.LOOKUPTABLEBINDING:
                        var enLookupTableBinding = DocEntityFactory.GetEntity<DocEntityLookupTableBinding>( en.Id );
                        ret = enLookupTableBinding.ToDto();
                        break;
                    case DocConstantModelName.LOOKUPTABLEENUM:
                        var enLookupTableEnum = DocEntityFactory.GetEntity<DocEntityLookupTableEnum>( en.Id );
                        ret = enLookupTableEnum.ToDto();
                        break;
                    case DocConstantModelName.MEANRANGES:
                        var enMeanRanges = DocEntityFactory.GetEntity<DocEntityMeanRanges>( en.Id );
                        ret = enMeanRanges.ToDto();
                        break;
                    case DocConstantModelName.MEANRANGEVALUE:
                        var enMeanRangeValue = DocEntityFactory.GetEntity<DocEntityMeanRangeValue>( en.Id );
                        ret = enMeanRangeValue.ToDto();
                        break;
                    case DocConstantModelName.MEANVARIANCES:
                        var enMeanVariances = DocEntityFactory.GetEntity<DocEntityMeanVariances>( en.Id );
                        ret = enMeanVariances.ToDto();
                        break;
                    case DocConstantModelName.MEANVARIANCEVALUE:
                        var enMeanVarianceValue = DocEntityFactory.GetEntity<DocEntityMeanVarianceValue>( en.Id );
                        ret = enMeanVarianceValue.ToDto();
                        break;
                    case DocConstantModelName.OUTCOME:
                        var enOutcome = DocEntityFactory.GetEntity<DocEntityOutcome>( en.Id );
                        ret = enOutcome.ToDto();
                        break;
                    case DocConstantModelName.PACKAGE:
                        var enPackage = DocEntityFactory.GetEntity<DocEntityPackage>( en.Id );
                        ret = enPackage.ToDto();
                        break;
                    case DocConstantModelName.PAGE:
                        var enPage = DocEntityFactory.GetEntity<DocEntityPage>( en.Id );
                        ret = enPage.ToDto();
                        break;
                    case DocConstantModelName.QUEUECHANNEL:
                        var enQueueChannel = DocEntityFactory.GetEntity<DocEntityQueueChannel>( en.Id );
                        ret = enQueueChannel.ToDto();
                        break;
                    case DocConstantModelName.RELEASESTATUS:
                        var enReleaseStatus = DocEntityFactory.GetEntity<DocEntityReleaseStatus>( en.Id );
                        ret = enReleaseStatus.ToDto();
                        break;
                    case DocConstantModelName.ROLE:
                        var enRole = DocEntityFactory.GetEntity<DocEntityRole>( en.Id );
                        ret = enRole.ToDto();
                        break;
                    case DocConstantModelName.SCOPE:
                        var enScope = DocEntityFactory.GetEntity<DocEntityScope>( en.Id );
                        ret = enScope.ToDto();
                        break;
                    case DocConstantModelName.STATS:
                        var enStats = DocEntityFactory.GetEntity<DocEntityStats>( en.Id );
                        ret = enStats.ToDto();
                        break;
                    case DocConstantModelName.STATSRECORD:
                        var enStatsRecord = DocEntityFactory.GetEntity<DocEntityStatsRecord>( en.Id );
                        ret = enStatsRecord.ToDto();
                        break;
                    case DocConstantModelName.STATSSTUDYSET:
                        var enStatsStudySet = DocEntityFactory.GetEntity<DocEntityStatsStudySet>( en.Id );
                        ret = enStatsStudySet.ToDto();
                        break;
                    case DocConstantModelName.STUDYDESIGN:
                        var enStudyDesign = DocEntityFactory.GetEntity<DocEntityStudyDesign>( en.Id );
                        ret = enStudyDesign.ToDto();
                        break;
                    case DocConstantModelName.STUDYTYPE:
                        var enStudyType = DocEntityFactory.GetEntity<DocEntityStudyType>( en.Id );
                        ret = enStudyType.ToDto();
                        break;
                    case DocConstantModelName.TAG:
                        var enTag = DocEntityFactory.GetEntity<DocEntityTag>( en.Id );
                        ret = enTag.ToDto();
                        break;
                    case DocConstantModelName.TEAM:
                        var enTeam = DocEntityFactory.GetEntity<DocEntityTeam>( en.Id );
                        ret = enTeam.ToDto();
                        break;
                    case DocConstantModelName.TERMCATEGORY:
                        var enTermCategory = DocEntityFactory.GetEntity<DocEntityTermCategory>( en.Id );
                        ret = enTermCategory.ToDto();
                        break;
                    case DocConstantModelName.TERMMASTER:
                        var enTermMaster = DocEntityFactory.GetEntity<DocEntityTermMaster>( en.Id );
                        ret = enTermMaster.ToDto();
                        break;
                    case DocConstantModelName.TERMSYNONYM:
                        var enTermSynonym = DocEntityFactory.GetEntity<DocEntityTermSynonym>( en.Id );
                        ret = enTermSynonym.ToDto();
                        break;
                    case DocConstantModelName.TIMECARD:
                        var enTimeCard = DocEntityFactory.GetEntity<DocEntityTimeCard>( en.Id );
                        ret = enTimeCard.ToDto();
                        break;
                    case DocConstantModelName.TIMEPOINT:
                        var enTimePoint = DocEntityFactory.GetEntity<DocEntityTimePoint>( en.Id );
                        ret = enTimePoint.ToDto();
                        break;
                    case DocConstantModelName.UNITCONVERSIONRULES:
                        var enUnitConversionRules = DocEntityFactory.GetEntity<DocEntityUnitConversionRules>( en.Id );
                        ret = enUnitConversionRules.ToDto();
                        break;
                    case DocConstantModelName.UNITOFMEASURE:
                        var enUnitOfMeasure = DocEntityFactory.GetEntity<DocEntityUnitOfMeasure>( en.Id );
                        ret = enUnitOfMeasure.ToDto();
                        break;
                    case DocConstantModelName.UNITS:
                        var enUnits = DocEntityFactory.GetEntity<DocEntityUnits>( en.Id );
                        ret = enUnits.ToDto();
                        break;
                    case DocConstantModelName.UNITVALUE:
                        var enUnitValue = DocEntityFactory.GetEntity<DocEntityUnitValue>( en.Id );
                        ret = enUnitValue.ToDto();
                        break;
                    case DocConstantModelName.UPDATE:
                        var enUpdate = DocEntityFactory.GetEntity<DocEntityUpdate>( en.Id );
                        ret = enUpdate.ToDto();
                        break;
                    case DocConstantModelName.USER:
                        var enUser = DocEntityFactory.GetEntity<DocEntityUser>( en.Id );
                        ret = enUser.ToDto();
                        break;
                    case DocConstantModelName.USERREQUEST:
                        var enUserRequest = DocEntityFactory.GetEntity<DocEntityUserRequest>( en.Id );
                        ret = enUserRequest.ToDto();
                        break;
                    case DocConstantModelName.USERSESSION:
                        var enUserSession = DocEntityFactory.GetEntity<DocEntityUserSession>( en.Id );
                        ret = enUserSession.ToDto();
                        break;
                    case DocConstantModelName.USERTYPE:
                        var enUserType = DocEntityFactory.GetEntity<DocEntityUserType>( en.Id );
                        ret = enUserType.ToDto();
                        break;
                    case DocConstantModelName.VALUETYPE:
                        var enValueType = DocEntityFactory.GetEntity<DocEntityValueType>( en.Id );
                        ret = enValueType.ToDto();
                        break;
                    case DocConstantModelName.VARIABLEINSTANCE:
                        var enVariableInstance = DocEntityFactory.GetEntity<DocEntityVariableInstance>( en.Id );
                        ret = enVariableInstance.ToDto();
                        break;
                    case DocConstantModelName.VARIABLERULE:
                        var enVariableRule = DocEntityFactory.GetEntity<DocEntityVariableRule>( en.Id );
                        ret = enVariableRule.ToDto();
                        break;
                    case DocConstantModelName.WORKFLOW:
                        var enWorkflow = DocEntityFactory.GetEntity<DocEntityWorkflow>( en.Id );
                        ret = enWorkflow.ToDto();
                        break;
                    case DocConstantModelName.WORKFLOWCOMMENT:
                        var enWorkflowComment = DocEntityFactory.GetEntity<DocEntityWorkflowComment>( en.Id );
                        ret = enWorkflowComment.ToDto();
                        break;
                    case DocConstantModelName.WORKFLOWTASK:
                        var enWorkflowTask = DocEntityFactory.GetEntity<DocEntityWorkflowTask>( en.Id );
                        ret = enWorkflowTask.ToDto();
                        break;
                }
            });
            return ret;
        }

        public object Get(Unlock request)
        {
            List<object> ret = new List<object>();

            var ids = new List<int>();
            if (request.Id > 0) ids.Add(request.Id);
            if (request.Ids?.Any() == true) ids.AddRange(request.Ids);

            if (true != ids?.Any())
                throw new HttpError(HttpStatusCode.NotFound, "Valid Id(s) required.");

            Execute.Run(s =>
           {
               ids.ForEach(id =>
               {
                   if (id <= 0) return;

                   var en = Execute.SelectAll<DocEntityBase>().FirstOrDefault(e => e.Id == id);
                   if (null != en)
                   {
                       en.UnlockRecord();
                       var dto = _GetDto(en);
                       ret.Add(dto);
                   }
               });
           });
            return ret;
        }

        public object Patch(Unlock request)
        {
            return Get(request);
        }
        public object Put(Unlock request)
        {
            return Get(request);
        }
    }
    
}
