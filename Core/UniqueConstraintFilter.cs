



















//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated by a T4 template. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Linq.Expressions;

using Services.Schema;
namespace Services.Core
{
    public static partial class UniqueConstraintFilter
    {
            public static Expression<Func<DocEntityAdjudicatedRating, bool>> AdjudicatedRatingIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityApp, bool>> AppIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityAttribute, bool>> AttributeIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityAttributeInterval, bool>> AttributeIntervalIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityAuditDelta, bool>> AuditDeltaIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityAuditRecord, bool>> AuditRecordIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityBackgroundTask, bool>> BackgroundTaskIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityBackgroundTaskHistory, bool>> BackgroundTaskHistoryIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityBackgroundTaskItem, bool>> BackgroundTaskItemIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityBroadcast, bool>> BroadcastIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityClient, bool>> ClientIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityComment, bool>> CommentIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityDatabaseVersion, bool>> DatabaseVersionIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityDataClass, bool>> DataClassIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityDataProperty, bool>> DataPropertyIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityDataSet, bool>> DataSetIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityDataTab, bool>> DataTabIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityDateTime, bool>> DateTimeIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityDefault, bool>> DefaultIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityDiseaseStateSet, bool>> DiseaseStateSetIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityDivision, bool>> DivisionIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityDocument, bool>> DocumentIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityDocumentSet, bool>> DocumentSetIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityDocumentSetHistory, bool>> DocumentSetHistoryIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityEoD, bool>> EoDIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityEvent, bool>> EventIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityFavorite, bool>> FavoriteIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityFeatureSet, bool>> FeatureSetIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityFile, bool>> FileIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityGlossary, bool>> GlossaryIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityHelp, bool>> HelpIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityHistory, bool>> HistoryIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityImpersonation, bool>> ImpersonationIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityImportData, bool>> ImportDataIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityInterval, bool>> IntervalIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityJunction, bool>> JunctionIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityLibrarySet, bool>> LibrarySetIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityLocale, bool>> LocaleIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityLocaleLookup, bool>> LocaleLookupIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityLookupCategory, bool>> LookupCategoryIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityLookupTable, bool>> LookupTableIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityLookupTableBinding, bool>> LookupTableBindingIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityLookupTableEnum, bool>> LookupTableEnumIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityMeanRanges, bool>> MeanRangesIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityMeanRangeValue, bool>> MeanRangeValueIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityMeanVariances, bool>> MeanVariancesIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityMeanVarianceValue, bool>> MeanVarianceValueIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityPage, bool>> PageIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityProject, bool>> ProjectIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityQueueChannel, bool>> QueueChannelIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityRating, bool>> RatingIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityReconcileDocument, bool>> ReconcileDocumentIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityRole, bool>> RoleIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityScope, bool>> ScopeIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityServePortalSet, bool>> ServePortalSetIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityStats, bool>> StatsIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityStatsRecord, bool>> StatsRecordIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityStatsStudySet, bool>> StatsStudySetIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityStudyDesign, bool>> StudyDesignIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityStudyType, bool>> StudyTypeIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityTag, bool>> TagIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityTask, bool>> TaskIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityTeam, bool>> TeamIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityTermCategory, bool>> TermCategoryIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityTermMaster, bool>> TermMasterIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityTermSynonym, bool>> TermSynonymIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityTherapeuticAreaSet, bool>> TherapeuticAreaSetIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityTimeCard, bool>> TimeCardIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityTimePoint, bool>> TimePointIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityUnitConversionRules, bool>> UnitConversionRulesIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityUnitOfMeasure, bool>> UnitOfMeasureIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityUnits, bool>> UnitsIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityUnitValue, bool>> UnitValueIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityUpdate, bool>> UpdateIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityUser, bool>> UserIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityUserRequest, bool>> UserRequestIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityUserSession, bool>> UserSessionIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityUserType, bool>> UserTypeIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityValueType, bool>> ValueTypeIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityVariableInstance, bool>> VariableInstanceIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityVariableRule, bool>> VariableRuleIgnoreArchived() => d => d.Archived == false;
            public static Expression<Func<DocEntityWorkflow, bool>> WorkflowIgnoreArchived() => d => d.Archived == false;
    }
}
