



















//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated by a T4 template. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System.Collections.Generic;

using Services.Dto;
using Services.Enums;

using Attribute = Services.Dto.Attribute;
using ValueType = Services.Dto.ValueType;
namespace Services.Schema
{
    public class TypeMap
    {
        public int TypeId { get; set; }
        
        public string SchemaName { get; set; }
        
        public string TableName { get; set; }
        
        public string ClassName { get; set; }

        public string DtoName { get; set; }

        public ModelNameEnm Class { get; set; }
    }

    public static class TypeMaps
    {
        public static List<TypeMap> Maps { get; } = new List<TypeMap>
        {
            new TypeMap() { SchemaName = typeof(DocEntityReconcileDocument).FullName, TypeId = 21185, TableName = DocConstantModelName.RECONCILEDOCUMENT, ClassName = "ReconcileDocument", DtoName = nameof(ReconcileDocument), Class = ModelNameEnm.RECONCILEDOCUMENT },
            new TypeMap() { SchemaName = typeof(DocEntityServePortalSet).FullName, TypeId = 21085, TableName = DocConstantModelName.SERVEPORTALSET, ClassName = "ServePortalSet", DtoName = nameof(ServePortalSet), Class = ModelNameEnm.SERVEPORTALSET },
            new TypeMap() { SchemaName = typeof(DocEntityDataSet).FullName, TypeId = 20985, TableName = DocConstantModelName.DATASET, ClassName = "DataSet", DtoName = nameof(DataSet), Class = ModelNameEnm.DATASET },
            new TypeMap() { SchemaName = typeof(DocEntityLibrarySet).FullName, TypeId = 20885, TableName = DocConstantModelName.LIBRARYSET, ClassName = "LibrarySet", DtoName = nameof(LibrarySet), Class = ModelNameEnm.LIBRARYSET },
            new TypeMap() { SchemaName = typeof(DocEntityDiseaseStateSet).FullName, TypeId = 20785, TableName = DocConstantModelName.DISEASESTATESET, ClassName = "DiseaseStateSet", DtoName = nameof(DiseaseStateSet), Class = ModelNameEnm.DISEASESTATESET },
            new TypeMap() { SchemaName = typeof(DocEntityTherapeuticAreaSet).FullName, TypeId = 20685, TableName = DocConstantModelName.THERAPEUTICAREASET, ClassName = "TherapeuticAreaSet", DtoName = nameof(TherapeuticAreaSet), Class = ModelNameEnm.THERAPEUTICAREASET },
            new TypeMap() { SchemaName = typeof(DocEntityAdjudicatedRating).FullName, TypeId = 20585, TableName = DocConstantModelName.ADJUDICATEDRATING, ClassName = "AdjudicatedRating", DtoName = nameof(AdjudicatedRating), Class = ModelNameEnm.ADJUDICATEDRATING },
            new TypeMap() { SchemaName = typeof(DocEntityFavorite).FullName, TypeId = 20485, TableName = DocConstantModelName.FAVORITE, ClassName = "Favorite", DtoName = nameof(Favorite), Class = ModelNameEnm.FAVORITE },
            new TypeMap() { SchemaName = typeof(DocEntityEoD).FullName, TypeId = 20385, TableName = DocConstantModelName.EOD, ClassName = "EoD", DtoName = nameof(EoD), Class = ModelNameEnm.EOD },
            new TypeMap() { SchemaName = typeof(DocEntityRating).FullName, TypeId = 20365, TableName = DocConstantModelName.RATING, ClassName = "Rating", DtoName = nameof(Rating), Class = ModelNameEnm.RATING },
            new TypeMap() { SchemaName = typeof(DocEntityDataTab).FullName, TypeId = 20265, TableName = DocConstantModelName.DATATAB, ClassName = "DataTab", DtoName = nameof(DataTab), Class = ModelNameEnm.DATATAB },
            new TypeMap() { SchemaName = typeof(DocEntityDataProperty).FullName, TypeId = 20255, TableName = DocConstantModelName.DATAPROPERTY, ClassName = "DataProperty", DtoName = nameof(DataProperty), Class = ModelNameEnm.DATAPROPERTY },
            new TypeMap() { SchemaName = typeof(DocEntityDataClass).FullName, TypeId = 20235, TableName = DocConstantModelName.DATACLASS, ClassName = "DataClass", DtoName = nameof(DataClass), Class = ModelNameEnm.DATACLASS },
            new TypeMap() { SchemaName = typeof(DocEntityProject).FullName, TypeId = 20135, TableName = DocConstantModelName.PROJECT, ClassName = "Project", DtoName = nameof(Project), Class = ModelNameEnm.PROJECT },
            new TypeMap() { SchemaName = typeof(DocEntityBackgroundTaskItem).FullName, TypeId = 19935, TableName = DocConstantModelName.BACKGROUNDTASKITEM, ClassName = "BackgroundTaskItem", DtoName = nameof(BackgroundTaskItem), Class = ModelNameEnm.BACKGROUNDTASKITEM },
            new TypeMap() { SchemaName = typeof(DocEntityDefault).FullName, TypeId = 19435, TableName = DocConstantModelName.DEFAULT, ClassName = "Default", DtoName = nameof(Default), Class = ModelNameEnm.DEFAULT },
            new TypeMap() { SchemaName = typeof(DocEntityLocale).FullName, TypeId = 19335, TableName = DocConstantModelName.LOCALE, ClassName = "Locale", DtoName = nameof(Locale), Class = ModelNameEnm.LOCALE },
            new TypeMap() { SchemaName = typeof(DocEntityLocaleLookup).FullName, TypeId = 19325, TableName = DocConstantModelName.LOCALELOOKUP, ClassName = "LocaleLookup", DtoName = nameof(LocaleLookup), Class = ModelNameEnm.LOCALELOOKUP },
            new TypeMap() { SchemaName = typeof(DocEntityImpersonation).FullName, TypeId = 19319, TableName = DocConstantModelName.IMPERSONATION, ClassName = "Impersonation", DtoName = nameof(Impersonation), Class = ModelNameEnm.IMPERSONATION },
            new TypeMap() { SchemaName = typeof(DocEntityEvent).FullName, TypeId = 19219, TableName = DocConstantModelName.EVENT, ClassName = "Event", DtoName = nameof(Event), Class = ModelNameEnm.EVENT },
            new TypeMap() { SchemaName = typeof(DocEntityUpdate).FullName, TypeId = 19119, TableName = DocConstantModelName.UPDATE, ClassName = "Update", DtoName = nameof(Update), Class = ModelNameEnm.UPDATE },
            new TypeMap() { SchemaName = typeof(DocEntityAuditDelta).FullName, TypeId = 19019, TableName = DocConstantModelName.AUDITDELTA, ClassName = "AuditDelta", DtoName = nameof(AuditDelta), Class = ModelNameEnm.AUDITDELTA },
            new TypeMap() { SchemaName = typeof(DocEntityBackgroundTaskHistory).FullName, TypeId = 18919, TableName = DocConstantModelName.BACKGROUNDTASKHISTORY, ClassName = "BackgroundTaskHistory", DtoName = nameof(BackgroundTaskHistory), Class = ModelNameEnm.BACKGROUNDTASKHISTORY },
            new TypeMap() { SchemaName = typeof(DocEntityDatabaseVersion).FullName, TypeId = 18819, TableName = DocConstantModelName.DATABASEVERSION, ClassName = "DatabaseVersion", DtoName = nameof(DatabaseVersion), Class = ModelNameEnm.DATABASEVERSION },
            new TypeMap() { SchemaName = typeof(DocEntityTask).FullName, TypeId = 18719, TableName = DocConstantModelName.TASK, ClassName = "Task", DtoName = nameof(Task), Class = ModelNameEnm.TASK },
            new TypeMap() { SchemaName = typeof(DocEntityUserRequest).FullName, TypeId = 18619, TableName = DocConstantModelName.USERREQUEST, ClassName = "UserRequest", DtoName = nameof(UserRequest), Class = ModelNameEnm.USERREQUEST },
            new TypeMap() { SchemaName = typeof(DocEntityQueueChannel).FullName, TypeId = 18519, TableName = DocConstantModelName.QUEUECHANNEL, ClassName = "QueueChannel", DtoName = nameof(QueueChannel), Class = ModelNameEnm.QUEUECHANNEL },
            new TypeMap() { SchemaName = typeof(DocEntityUserSession).FullName, TypeId = 18419, TableName = DocConstantModelName.USERSESSION, ClassName = "UserSession", DtoName = nameof(UserSession), Class = ModelNameEnm.USERSESSION },
            new TypeMap() { SchemaName = typeof(DocEntityComment).FullName, TypeId = 18319, TableName = DocConstantModelName.COMMENT, ClassName = "Comment", DtoName = nameof(Comment), Class = ModelNameEnm.COMMENT },
            new TypeMap() { SchemaName = typeof(DocEntityMeanVariances).FullName, TypeId = 18219, TableName = DocConstantModelName.MEANVARIANCES, ClassName = "MeanVariances", DtoName = nameof(MeanVariances), Class = ModelNameEnm.MEANVARIANCES },
            new TypeMap() { SchemaName = typeof(DocEntityMeanVarianceValue).FullName, TypeId = 18119, TableName = DocConstantModelName.MEANVARIANCEVALUE, ClassName = "MeanVarianceValue", DtoName = nameof(MeanVarianceValue), Class = ModelNameEnm.MEANVARIANCEVALUE },
            new TypeMap() { SchemaName = typeof(DocEntityTag).FullName, TypeId = 18019, TableName = DocConstantModelName.TAG, ClassName = "Tag", DtoName = nameof(Tag), Class = ModelNameEnm.TAG },
            new TypeMap() { SchemaName = typeof(DocEntityUserType).FullName, TypeId = 17919, TableName = DocConstantModelName.USERTYPE, ClassName = "UserType", DtoName = nameof(UserType), Class = ModelNameEnm.USERTYPE },
            new TypeMap() { SchemaName = typeof(DocEntityJunction).FullName, TypeId = 17619, TableName = DocConstantModelName.JUNCTION, ClassName = "Junction", DtoName = nameof(Junction), Class = ModelNameEnm.JUNCTION },
            new TypeMap() { SchemaName = typeof(DocEntityLookupCategory).FullName, TypeId = 17419, TableName = DocConstantModelName.LOOKUPCATEGORY, ClassName = "LookupCategory", DtoName = nameof(LookupCategory), Class = ModelNameEnm.LOOKUPCATEGORY },
            new TypeMap() { SchemaName = typeof(DocEntityTimeCard).FullName, TypeId = 17319, TableName = DocConstantModelName.TIMECARD, ClassName = "TimeCard", DtoName = nameof(TimeCard), Class = ModelNameEnm.TIMECARD },
            new TypeMap() { SchemaName = typeof(DocEntityHistory).FullName, TypeId = 15885, TableName = DocConstantModelName.HISTORY, ClassName = "History", DtoName = nameof(History), Class = ModelNameEnm.HISTORY },
            new TypeMap() { SchemaName = typeof(DocEntityTeam).FullName, TypeId = 15881, TableName = DocConstantModelName.TEAM, ClassName = "Team", DtoName = nameof(Team), Class = ModelNameEnm.TEAM },
            new TypeMap() { SchemaName = typeof(DocEntityVariableInstance).FullName, TypeId = 15781, TableName = DocConstantModelName.VARIABLEINSTANCE, ClassName = "VariableInstance", DtoName = nameof(VariableInstance), Class = ModelNameEnm.VARIABLEINSTANCE },
            new TypeMap() { SchemaName = typeof(DocEntityVariableRule).FullName, TypeId = 15680, TableName = DocConstantModelName.VARIABLERULE, ClassName = "VariableRule", DtoName = nameof(VariableRule), Class = ModelNameEnm.VARIABLERULE },
            new TypeMap() { SchemaName = typeof(DocEntityLookupTableBinding).FullName, TypeId = 15380, TableName = DocConstantModelName.LOOKUPTABLEBINDING, ClassName = "LookupTableBinding", DtoName = nameof(LookupTableBinding), Class = ModelNameEnm.LOOKUPTABLEBINDING },
            new TypeMap() { SchemaName = typeof(DocEntityScope).FullName, TypeId = 15379, TableName = DocConstantModelName.SCOPE, ClassName = "Scope", DtoName = nameof(Scope), Class = ModelNameEnm.SCOPE },
            new TypeMap() { SchemaName = typeof(DocEntityWorkflow).FullName, TypeId = 15378, TableName = DocConstantModelName.WORKFLOW, ClassName = "Workflow", DtoName = nameof(Workflow), Class = ModelNameEnm.WORKFLOW },
            new TypeMap() { SchemaName = typeof(DocEntityDateTime).FullName, TypeId = 15278, TableName = DocConstantModelName.DATETIME, ClassName = "DateTime", DtoName = nameof(DateTimeDto), Class = ModelNameEnm.DATETIME },
            new TypeMap() { SchemaName = typeof(DocEntityInterval).FullName, TypeId = 15178, TableName = DocConstantModelName.INTERVAL, ClassName = "Interval", DtoName = nameof(Interval), Class = ModelNameEnm.INTERVAL },
            new TypeMap() { SchemaName = typeof(DocEntityTimePoint).FullName, TypeId = 15078, TableName = DocConstantModelName.TIMEPOINT, ClassName = "TimePoint", DtoName = nameof(TimePoint), Class = ModelNameEnm.TIMEPOINT },
            new TypeMap() { SchemaName = typeof(DocEntityHelp).FullName, TypeId = 14978, TableName = DocConstantModelName.HELP, ClassName = "Help", DtoName = nameof(Help), Class = ModelNameEnm.HELP },
            new TypeMap() { SchemaName = typeof(DocEntityGlossary).FullName, TypeId = 14977, TableName = DocConstantModelName.GLOSSARY, ClassName = "Glossary", DtoName = nameof(Glossary), Class = ModelNameEnm.GLOSSARY },
            new TypeMap() { SchemaName = typeof(DocEntityBackgroundTask).FullName, TypeId = 14375, TableName = DocConstantModelName.BACKGROUNDTASK, ClassName = "BackgroundTask", DtoName = nameof(BackgroundTask), Class = ModelNameEnm.BACKGROUNDTASK },
            new TypeMap() { SchemaName = typeof(DocEntityStatsRecord).FullName, TypeId = 14275, TableName = DocConstantModelName.STATSRECORD, ClassName = "StatsRecord", DtoName = nameof(StatsRecord), Class = ModelNameEnm.STATSRECORD },
            new TypeMap() { SchemaName = typeof(DocEntityStatsStudySet).FullName, TypeId = 14274, TableName = DocConstantModelName.STATSSTUDYSET, ClassName = "StatsStudySet", DtoName = nameof(StatsStudySet), Class = ModelNameEnm.STATSSTUDYSET },
            new TypeMap() { SchemaName = typeof(DocEntityStats).FullName, TypeId = 14273, TableName = DocConstantModelName.STATS, ClassName = "Stats", DtoName = nameof(Stats), Class = ModelNameEnm.STATS },
            new TypeMap() { SchemaName = typeof(DocEntityApp).FullName, TypeId = 14173, TableName = DocConstantModelName.APP, ClassName = "App", DtoName = nameof(App), Class = ModelNameEnm.APP },
            new TypeMap() { SchemaName = typeof(DocEntityBroadcast).FullName, TypeId = 13962, TableName = DocConstantModelName.BROADCAST, ClassName = "Broadcast", DtoName = nameof(Broadcast), Class = ModelNameEnm.BROADCAST },
            new TypeMap() { SchemaName = typeof(DocEntityDocumentSetHistory).FullName, TypeId = 13320, TableName = DocConstantModelName.DOCUMENTSETHISTORY, ClassName = "DocumentSetHistory", DtoName = nameof(DocumentSetHistory), Class = ModelNameEnm.DOCUMENTSETHISTORY },
            new TypeMap() { SchemaName = typeof(DocEntityImportData).FullName, TypeId = 12600, TableName = DocConstantModelName.IMPORTDATA, ClassName = "ImportData", DtoName = nameof(ImportData), Class = ModelNameEnm.IMPORTDATA },
            new TypeMap() { SchemaName = typeof(DocEntityPage).FullName, TypeId = 180, TableName = DocConstantModelName.PAGE, ClassName = "Page", DtoName = nameof(Page), Class = ModelNameEnm.PAGE },
            new TypeMap() { SchemaName = typeof(DocEntityValueType).FullName, TypeId = 171, TableName = DocConstantModelName.VALUETYPE, ClassName = "ValueType", DtoName = nameof(ValueType), Class = ModelNameEnm.VALUETYPE },
            new TypeMap() { SchemaName = typeof(DocEntityUser).FullName, TypeId = 153, TableName = DocConstantModelName.USER, ClassName = "User", DtoName = nameof(User), Class = ModelNameEnm.USER },
            new TypeMap() { SchemaName = typeof(DocEntityUnits).FullName, TypeId = 152, TableName = DocConstantModelName.UNITS, ClassName = "Units", DtoName = nameof(UnitsDto), Class = ModelNameEnm.UNITS },
            new TypeMap() { SchemaName = typeof(DocEntityUnitValue).FullName, TypeId = 151, TableName = DocConstantModelName.UNITVALUE, ClassName = "UnitValue", DtoName = nameof(UnitValue), Class = ModelNameEnm.UNITVALUE },
            new TypeMap() { SchemaName = typeof(DocEntityUnitOfMeasure).FullName, TypeId = 150, TableName = DocConstantModelName.UNITOFMEASURE, ClassName = "UnitOfMeasure", DtoName = nameof(UnitOfMeasure), Class = ModelNameEnm.UNITOFMEASURE },
            new TypeMap() { SchemaName = typeof(DocEntityUnitConversionRules).FullName, TypeId = 149, TableName = DocConstantModelName.UNITCONVERSIONRULES, ClassName = "UnitConversionRules", DtoName = nameof(UnitConversionRules), Class = ModelNameEnm.UNITCONVERSIONRULES },
            new TypeMap() { SchemaName = typeof(DocEntityTermSynonym).FullName, TypeId = 148, TableName = DocConstantModelName.TERMSYNONYM, ClassName = "TermSynonym", DtoName = nameof(TermSynonym), Class = ModelNameEnm.TERMSYNONYM },
            new TypeMap() { SchemaName = typeof(DocEntityTermMaster).FullName, TypeId = 147, TableName = DocConstantModelName.TERMMASTER, ClassName = "TermMaster", DtoName = nameof(TermMaster), Class = ModelNameEnm.TERMMASTER },
            new TypeMap() { SchemaName = typeof(DocEntityTermCategory).FullName, TypeId = 146, TableName = DocConstantModelName.TERMCATEGORY, ClassName = "TermCategory", DtoName = nameof(TermCategory), Class = ModelNameEnm.TERMCATEGORY },
            new TypeMap() { SchemaName = typeof(DocEntityStudyType).FullName, TypeId = 143, TableName = DocConstantModelName.STUDYTYPE, ClassName = "StudyType", DtoName = nameof(StudyType), Class = ModelNameEnm.STUDYTYPE },
            new TypeMap() { SchemaName = typeof(DocEntityDocumentSet).FullName, TypeId = 142, TableName = DocConstantModelName.DOCUMENTSET, ClassName = "DocumentSet", DtoName = nameof(DocumentSet), Class = ModelNameEnm.DOCUMENTSET },
            new TypeMap() { SchemaName = typeof(DocEntityStudyDesign).FullName, TypeId = 137, TableName = DocConstantModelName.STUDYDESIGN, ClassName = "StudyDesign", DtoName = nameof(StudyDesign), Class = ModelNameEnm.STUDYDESIGN },
            new TypeMap() { SchemaName = typeof(DocEntityDocument).FullName, TypeId = 136, TableName = DocConstantModelName.DOCUMENT, ClassName = "Document", DtoName = nameof(Document), Class = ModelNameEnm.DOCUMENT },
            new TypeMap() { SchemaName = typeof(DocEntityRole).FullName, TypeId = 133, TableName = DocConstantModelName.ROLE, ClassName = "Role", DtoName = nameof(Role), Class = ModelNameEnm.ROLE },
            new TypeMap() { SchemaName = typeof(DocEntityMeanRanges).FullName, TypeId = 130, TableName = DocConstantModelName.MEANRANGES, ClassName = "MeanRanges", DtoName = nameof(MeanRanges), Class = ModelNameEnm.MEANRANGES },
            new TypeMap() { SchemaName = typeof(DocEntityMeanRangeValue).FullName, TypeId = 129, TableName = DocConstantModelName.MEANRANGEVALUE, ClassName = "MeanRangeValue", DtoName = nameof(MeanRangeValue), Class = ModelNameEnm.MEANRANGEVALUE },
            new TypeMap() { SchemaName = typeof(DocEntityLookupTableEnum).FullName, TypeId = 128, TableName = DocConstantModelName.LOOKUPTABLEENUM, ClassName = "LookupTableEnum", DtoName = nameof(LookupTableEnum), Class = ModelNameEnm.LOOKUPTABLEENUM },
            new TypeMap() { SchemaName = typeof(DocEntityLookupTable).FullName, TypeId = 127, TableName = DocConstantModelName.LOOKUPTABLE, ClassName = "LookupTable", DtoName = nameof(LookupTable), Class = ModelNameEnm.LOOKUPTABLE },
            new TypeMap() { SchemaName = typeof(DocEntityFeatureSet).FullName, TypeId = 116, TableName = DocConstantModelName.FEATURESET, ClassName = "FeatureSet", DtoName = nameof(FeatureSet), Class = ModelNameEnm.FEATURESET },
            new TypeMap() { SchemaName = typeof(DocEntityDivision).FullName, TypeId = 112, TableName = DocConstantModelName.DIVISION, ClassName = "Division", DtoName = nameof(Division), Class = ModelNameEnm.DIVISION },
            new TypeMap() { SchemaName = typeof(DocEntityClient).FullName, TypeId = 111, TableName = DocConstantModelName.CLIENT, ClassName = "Client", DtoName = nameof(Client), Class = ModelNameEnm.CLIENT },
            new TypeMap() { SchemaName = typeof(DocEntityAuditRecord).FullName, TypeId = 108, TableName = DocConstantModelName.AUDITRECORD, ClassName = "AuditRecord", DtoName = nameof(AuditRecord), Class = ModelNameEnm.AUDITRECORD },
            new TypeMap() { SchemaName = typeof(DocEntityAttributeInterval).FullName, TypeId = 104, TableName = DocConstantModelName.ATTRIBUTEINTERVAL, ClassName = "AttributeInterval", DtoName = nameof(AttributeInterval), Class = ModelNameEnm.ATTRIBUTEINTERVAL },
            new TypeMap() { SchemaName = typeof(DocEntityAttribute).FullName, TypeId = 102, TableName = DocConstantModelName.ATTRIBUTE, ClassName = "Attribute", DtoName = nameof(Attribute), Class = ModelNameEnm.ATTRIBUTE },
        };
    }
}
