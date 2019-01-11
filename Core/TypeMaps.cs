using Services.Dto;
using Services.Enums;

using System.Collections.Generic;

namespace Services.Schema
{
    public class TypeMap
    {
        public int TypeId { get; set; }
        
        public string SchemaName { get; set; }
        
        public string TableName { get; set; }
        
        public string ClassName { get; set; }

        public string DtoName { get; set; }
    }

    public static class TypeMaps
    {
        public static List<TypeMap> Maps { get; } = new List<TypeMap>
        {
            new TypeMap() { SchemaName = typeof(DocEntityComparator).FullName, TypeId = 20035, TableName = DocConstantModelName.COMPARATOR, ClassName = "Comparator", DtoName = nameof(Comparator) },
            new TypeMap() { SchemaName = typeof(DocEntityBackgroundTaskItem).FullName, TypeId = 19935, TableName = DocConstantModelName.BACKGROUNDTASKITEM, ClassName = "BackgroundTaskItem", DtoName = nameof(BackgroundTaskItem) },
            new TypeMap() { SchemaName = typeof(DocEntityReleaseStatus).FullName, TypeId = 19835, TableName = DocConstantModelName.RELEASESTATUS, ClassName = "ReleaseStatus", DtoName = nameof(ReleaseStatus) },
            new TypeMap() { SchemaName = typeof(DocEntityDefault).FullName, TypeId = 19435, TableName = DocConstantModelName.DEFAULT, ClassName = "Default", DtoName = nameof(Default) },
            new TypeMap() { SchemaName = typeof(DocEntityLocale).FullName, TypeId = 19335, TableName = DocConstantModelName.LOCALE, ClassName = "Locale", DtoName = nameof(Locale) },
            new TypeMap() { SchemaName = typeof(DocEntityLocaleLookup).FullName, TypeId = 19325, TableName = DocConstantModelName.LOCALELOOKUP, ClassName = "LocaleLookup", DtoName = nameof(LocaleLookup) },
            new TypeMap() { SchemaName = typeof(DocEntityImpersonation).FullName, TypeId = 19319, TableName = DocConstantModelName.IMPERSONATION, ClassName = "Impersonation", DtoName = nameof(Impersonation) },
            new TypeMap() { SchemaName = typeof(DocEntityEvent).FullName, TypeId = 19219, TableName = DocConstantModelName.EVENT, ClassName = "Event", DtoName = nameof(Event) },
            new TypeMap() { SchemaName = typeof(DocEntityUpdate).FullName, TypeId = 19119, TableName = DocConstantModelName.UPDATE, ClassName = "Update", DtoName = nameof(Update) },
            new TypeMap() { SchemaName = typeof(DocEntityAuditDelta).FullName, TypeId = 19019, TableName = DocConstantModelName.AUDITDELTA, ClassName = "AuditDelta", DtoName = nameof(AuditDelta) },
            new TypeMap() { SchemaName = typeof(DocEntityBackgroundTaskHistory).FullName, TypeId = 18919, TableName = DocConstantModelName.BACKGROUNDTASKHISTORY, ClassName = "BackgroundTaskHistory", DtoName = nameof(BackgroundTaskHistory) },
            new TypeMap() { SchemaName = typeof(DocEntityDatabaseVersion).FullName, TypeId = 18819, TableName = DocConstantModelName.DATABASEVERSION, ClassName = "DatabaseVersion", DtoName = nameof(DatabaseVersion) },
            new TypeMap() { SchemaName = typeof(DocEntityWorkflowTask).FullName, TypeId = 18719, TableName = DocConstantModelName.WORKFLOWTASK, ClassName = "WorkflowTask", DtoName = nameof(WorkflowTask) },
            new TypeMap() { SchemaName = typeof(DocEntityUserRequest).FullName, TypeId = 18619, TableName = DocConstantModelName.USERREQUEST, ClassName = "UserRequest", DtoName = nameof(UserRequest) },
            new TypeMap() { SchemaName = typeof(DocEntityQueueChannel).FullName, TypeId = 18519, TableName = DocConstantModelName.QUEUECHANNEL, ClassName = "QueueChannel", DtoName = nameof(QueueChannel) },
            new TypeMap() { SchemaName = typeof(DocEntityUserSession).FullName, TypeId = 18419, TableName = DocConstantModelName.USERSESSION, ClassName = "UserSession", DtoName = nameof(UserSession) },
            new TypeMap() { SchemaName = typeof(DocEntityWorkflowComment).FullName, TypeId = 18319, TableName = DocConstantModelName.WORKFLOWCOMMENT, ClassName = "WorkflowComment", DtoName = nameof(WorkflowComment) },
            new TypeMap() { SchemaName = typeof(DocEntityMeanVariances).FullName, TypeId = 18219, TableName = DocConstantModelName.MEANVARIANCES, ClassName = "MeanVariances", DtoName = nameof(MeanVariances) },
            new TypeMap() { SchemaName = typeof(DocEntityMeanVarianceValue).FullName, TypeId = 18119, TableName = DocConstantModelName.MEANVARIANCEVALUE, ClassName = "MeanVarianceValue", DtoName = nameof(MeanVarianceValue) },
            new TypeMap() { SchemaName = typeof(DocEntityTag).FullName, TypeId = 18019, TableName = DocConstantModelName.TAG, ClassName = "Tag", DtoName = nameof(Tag) },
            new TypeMap() { SchemaName = typeof(DocEntityUserType).FullName, TypeId = 17919, TableName = DocConstantModelName.USERTYPE, ClassName = "UserType", DtoName = nameof(UserType) },
            new TypeMap() { SchemaName = typeof(DocEntityForeignKey).FullName, TypeId = 17719, TableName = DocConstantModelName.FOREIGNKEY, ClassName = "ForeignKey", DtoName = nameof(ForeignKey) },
            new TypeMap() { SchemaName = typeof(DocEntityJunction).FullName, TypeId = 17619, TableName = DocConstantModelName.JUNCTION, ClassName = "Junction", DtoName = nameof(Junction) },
            new TypeMap() { SchemaName = typeof(DocEntityLookupCategory).FullName, TypeId = 17419, TableName = DocConstantModelName.LOOKUPCATEGORY, ClassName = "LookupCategory", DtoName = nameof(LookupCategory) },
            new TypeMap() { SchemaName = typeof(DocEntityTimeCard).FullName, TypeId = 17319, TableName = DocConstantModelName.TIMECARD, ClassName = "TimeCard", DtoName = nameof(TimeCard) },
            new TypeMap() { SchemaName = typeof(DocEntityPackage).FullName, TypeId = 17219, TableName = DocConstantModelName.PACKAGE, ClassName = "Package", DtoName = nameof(Package) },
            new TypeMap() { SchemaName = typeof(DocEntityHistory).FullName, TypeId = 15885, TableName = DocConstantModelName.HISTORY, ClassName = "History", DtoName = nameof(History) },
            new TypeMap() { SchemaName = typeof(DocEntityTeam).FullName, TypeId = 15881, TableName = DocConstantModelName.TEAM, ClassName = "Team", DtoName = nameof(Team) },
            new TypeMap() { SchemaName = typeof(DocEntityVariableInstance).FullName, TypeId = 15781, TableName = DocConstantModelName.VARIABLEINSTANCE, ClassName = "VariableInstance", DtoName = nameof(VariableInstance) },
            new TypeMap() { SchemaName = typeof(DocEntityVariableRule).FullName, TypeId = 15680, TableName = DocConstantModelName.VARIABLERULE, ClassName = "VariableRule", DtoName = nameof(VariableRule) },
            new TypeMap() { SchemaName = typeof(DocEntityLookupTableBinding).FullName, TypeId = 15380, TableName = DocConstantModelName.LOOKUPTABLEBINDING, ClassName = "LookupTableBinding", DtoName = nameof(LookupTableBinding) },
            new TypeMap() { SchemaName = typeof(DocEntityScope).FullName, TypeId = 15379, TableName = DocConstantModelName.SCOPE, ClassName = "Scope", DtoName = nameof(Scope) },
            new TypeMap() { SchemaName = typeof(DocEntityWorkflow).FullName, TypeId = 15378, TableName = DocConstantModelName.WORKFLOW, ClassName = "Workflow", DtoName = nameof(Workflow) },
            new TypeMap() { SchemaName = typeof(DocEntityDateTime).FullName, TypeId = 15278, TableName = DocConstantModelName.DATETIME, ClassName = "DateTime", DtoName = nameof(DateTimeDto) },
            new TypeMap() { SchemaName = typeof(DocEntityInterval).FullName, TypeId = 15178, TableName = DocConstantModelName.INTERVAL, ClassName = "Interval", DtoName = nameof(Interval) },
            new TypeMap() { SchemaName = typeof(DocEntityTimePoint).FullName, TypeId = 15078, TableName = DocConstantModelName.TIMEPOINT, ClassName = "TimePoint", DtoName = nameof(TimePoint) },
            new TypeMap() { SchemaName = typeof(DocEntityHelp).FullName, TypeId = 14978, TableName = DocConstantModelName.HELP, ClassName = "Help", DtoName = nameof(Help) },
            new TypeMap() { SchemaName = typeof(DocEntityGlossary).FullName, TypeId = 14977, TableName = DocConstantModelName.GLOSSARY, ClassName = "Glossary", DtoName = nameof(Glossary) },
            new TypeMap() { SchemaName = typeof(DocEntityCharacteristic).FullName, TypeId = 14475, TableName = DocConstantModelName.CHARACTERISTIC, ClassName = "Characteristic", DtoName = nameof(Characteristic) },
            new TypeMap() { SchemaName = typeof(DocEntityBackgroundTask).FullName, TypeId = 14375, TableName = DocConstantModelName.BACKGROUNDTASK, ClassName = "BackgroundTask", DtoName = nameof(BackgroundTask) },
            new TypeMap() { SchemaName = typeof(DocEntityStatsRecord).FullName, TypeId = 14275, TableName = DocConstantModelName.STATSRECORD, ClassName = "StatsRecord", DtoName = nameof(StatsRecord) },
            new TypeMap() { SchemaName = typeof(DocEntityStatsStudySet).FullName, TypeId = 14274, TableName = DocConstantModelName.STATSSTUDYSET, ClassName = "StatsStudySet", DtoName = nameof(StatsStudySet) },
            new TypeMap() { SchemaName = typeof(DocEntityStats).FullName, TypeId = 14273, TableName = DocConstantModelName.STATS, ClassName = "Stats", DtoName = nameof(Stats) },
            new TypeMap() { SchemaName = typeof(DocEntityApp).FullName, TypeId = 14173, TableName = DocConstantModelName.APP, ClassName = "App", DtoName = nameof(App) },
            new TypeMap() { SchemaName = typeof(DocEntityBroadcast).FullName, TypeId = 13962, TableName = DocConstantModelName.BROADCAST, ClassName = "Broadcast", DtoName = nameof(Broadcast) },
            new TypeMap() { SchemaName = typeof(DocEntityOutcome).FullName, TypeId = 13662, TableName = DocConstantModelName.OUTCOME, ClassName = "Outcome", DtoName = nameof(Outcome) },
            new TypeMap() { SchemaName = typeof(DocEntityIntervention).FullName, TypeId = 13420, TableName = DocConstantModelName.INTERVENTION, ClassName = "Intervention", DtoName = nameof(Intervention) },
            new TypeMap() { SchemaName = typeof(DocEntityDocumentSetHistory).FullName, TypeId = 13320, TableName = DocConstantModelName.DOCUMENTSETHISTORY, ClassName = "DocumentSetHistory", DtoName = nameof(DocumentSetHistory) },
            new TypeMap() { SchemaName = typeof(DocEntityJctAttributeCategoryAttributeDocumentSet).FullName, TypeId = 13223, TableName = DocConstantModelName.JCTATTRIBUTECATEGORYATTRIBUTEDOCUMENTSET, ClassName = "JctAttributeCategoryAttributeDocumentSet", DtoName = nameof(JctAttributeCategoryAttributeDocumentSet) },
            new TypeMap() { SchemaName = typeof(DocEntityAttributeCategory).FullName, TypeId = 13222, TableName = DocConstantModelName.ATTRIBUTECATEGORY, ClassName = "AttributeCategory", DtoName = nameof(AttributeCategory) },
            new TypeMap() { SchemaName = typeof(DocEntityImportData).FullName, TypeId = 12600, TableName = DocConstantModelName.IMPORTDATA, ClassName = "ImportData", DtoName = nameof(ImportData) },
            new TypeMap() { SchemaName = typeof(DocEntityDocumentAttribute).FullName, TypeId = 6355, TableName = DocConstantModelName.DOCUMENTATTRIBUTE, ClassName = "DocumentAttribute", DtoName = nameof(DocumentAttribute) },
            new TypeMap() { SchemaName = typeof(DocEntityPage).FullName, TypeId = 180, TableName = DocConstantModelName.PAGE, ClassName = "Page", DtoName = nameof(Page) },
            new TypeMap() { SchemaName = typeof(DocEntityValueType).FullName, TypeId = 171, TableName = DocConstantModelName.VALUETYPE, ClassName = "ValueType", DtoName = nameof(ValueType) },
            new TypeMap() { SchemaName = typeof(DocEntityUser).FullName, TypeId = 153, TableName = DocConstantModelName.USER, ClassName = "User", DtoName = nameof(User) },
            new TypeMap() { SchemaName = typeof(DocEntityUnits).FullName, TypeId = 152, TableName = DocConstantModelName.UNITS, ClassName = "Units", DtoName = nameof(UnitsDto) },
            new TypeMap() { SchemaName = typeof(DocEntityUnitValue).FullName, TypeId = 151, TableName = DocConstantModelName.UNITVALUE, ClassName = "UnitValue", DtoName = nameof(UnitValue) },
            new TypeMap() { SchemaName = typeof(DocEntityUnitOfMeasure).FullName, TypeId = 150, TableName = DocConstantModelName.UNITOFMEASURE, ClassName = "UnitOfMeasure", DtoName = nameof(UnitOfMeasure) },
            new TypeMap() { SchemaName = typeof(DocEntityUnitConversionRules).FullName, TypeId = 149, TableName = DocConstantModelName.UNITCONVERSIONRULES, ClassName = "UnitConversionRules", DtoName = nameof(UnitConversionRules) },
            new TypeMap() { SchemaName = typeof(DocEntityTermSynonym).FullName, TypeId = 148, TableName = DocConstantModelName.TERMSYNONYM, ClassName = "TermSynonym", DtoName = nameof(TermSynonym) },
            new TypeMap() { SchemaName = typeof(DocEntityTermMaster).FullName, TypeId = 147, TableName = DocConstantModelName.TERMMASTER, ClassName = "TermMaster", DtoName = nameof(TermMaster) },
            new TypeMap() { SchemaName = typeof(DocEntityTermCategory).FullName, TypeId = 146, TableName = DocConstantModelName.TERMCATEGORY, ClassName = "TermCategory", DtoName = nameof(TermCategory) },
            new TypeMap() { SchemaName = typeof(DocEntityStudyType).FullName, TypeId = 143, TableName = DocConstantModelName.STUDYTYPE, ClassName = "StudyType", DtoName = nameof(StudyType) },
            new TypeMap() { SchemaName = typeof(DocEntityDocumentSet).FullName, TypeId = 142, TableName = DocConstantModelName.DOCUMENTSET, ClassName = "DocumentSet", DtoName = nameof(DocumentSet) },
            new TypeMap() { SchemaName = typeof(DocEntityStudyDesign).FullName, TypeId = 137, TableName = DocConstantModelName.STUDYDESIGN, ClassName = "StudyDesign", DtoName = nameof(StudyDesign) },
            new TypeMap() { SchemaName = typeof(DocEntityDocument).FullName, TypeId = 136, TableName = DocConstantModelName.DOCUMENT, ClassName = "Document", DtoName = nameof(Document) },
            new TypeMap() { SchemaName = typeof(DocEntityRole).FullName, TypeId = 133, TableName = DocConstantModelName.ROLE, ClassName = "Role", DtoName = nameof(Role) },
            new TypeMap() { SchemaName = typeof(DocEntityMeanRanges).FullName, TypeId = 130, TableName = DocConstantModelName.MEANRANGES, ClassName = "MeanRanges", DtoName = nameof(MeanRanges) },
            new TypeMap() { SchemaName = typeof(DocEntityMeanRangeValue).FullName, TypeId = 129, TableName = DocConstantModelName.MEANRANGEVALUE, ClassName = "MeanRangeValue", DtoName = nameof(MeanRangeValue) },
            new TypeMap() { SchemaName = typeof(DocEntityLookupTableEnum).FullName, TypeId = 128, TableName = DocConstantModelName.LOOKUPTABLEENUM, ClassName = "LookupTableEnum", DtoName = nameof(LookupTableEnum) },
            new TypeMap() { SchemaName = typeof(DocEntityLookupTable).FullName, TypeId = 127, TableName = DocConstantModelName.LOOKUPTABLE, ClassName = "LookupTable", DtoName = nameof(LookupTable) },
            new TypeMap() { SchemaName = typeof(DocEntityFeatureSet).FullName, TypeId = 116, TableName = DocConstantModelName.FEATURESET, ClassName = "FeatureSet", DtoName = nameof(FeatureSet) },
            new TypeMap() { SchemaName = typeof(DocEntityDivision).FullName, TypeId = 112, TableName = DocConstantModelName.DIVISION, ClassName = "Division", DtoName = nameof(Division) },
            new TypeMap() { SchemaName = typeof(DocEntityClient).FullName, TypeId = 111, TableName = DocConstantModelName.CLIENT, ClassName = "Client", DtoName = nameof(Client) },
            new TypeMap() { SchemaName = typeof(DocEntityAuditRecord).FullName, TypeId = 108, TableName = DocConstantModelName.AUDITRECORD, ClassName = "AuditRecord", DtoName = nameof(AuditRecord) },
            new TypeMap() { SchemaName = typeof(DocEntityAttributeInterval).FullName, TypeId = 104, TableName = DocConstantModelName.ATTRIBUTEINTERVAL, ClassName = "AttributeInterval", DtoName = nameof(AttributeInterval) },
            new TypeMap() { SchemaName = typeof(DocEntityAttribute).FullName, TypeId = 102, TableName = DocConstantModelName.ATTRIBUTE, ClassName = "Attribute", DtoName = nameof(Attribute) },
        };
    }
}
