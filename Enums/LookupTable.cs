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

namespace Services.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LookupTableEnm
    {
        [EnumMember(Value = DocConstantLookupTable.AMPERSONCOUNT)]
        AMPERSONCOUNT,
        [EnumMember(Value = DocConstantLookupTable.APP)]
        APP,
        [EnumMember(Value = DocConstantLookupTable.ARMPOPULATIONAGE)]
        ARMPOPULATIONAGE,
        [EnumMember(Value = DocConstantLookupTable.ARMPOPULATIONN)]
        ARMPOPULATIONN,
        [EnumMember(Value = DocConstantLookupTable.ASSOCIATIONMEASURE)]
        ASSOCIATIONMEASURE,
        [EnumMember(Value = DocConstantLookupTable.ATTRIBUTECATEGORY)]
        ATTRIBUTECATEGORY,
        [EnumMember(Value = DocConstantLookupTable.ATTRIBUTETYPE)]
        ATTRIBUTETYPE,
        [EnumMember(Value = DocConstantLookupTable.BROADCASTSTATUS)]
        BROADCASTSTATUS,
        [EnumMember(Value = DocConstantLookupTable.BROADCASTTYPE)]
        BROADCASTTYPE,
        [EnumMember(Value = DocConstantLookupTable.CONFIDENCEINTERVAL)]
        CONFIDENCEINTERVAL,
        [EnumMember(Value = DocConstantLookupTable.CONJUNCTION)]
        CONJUNCTION,
        [EnumMember(Value = DocConstantLookupTable.DATABASETYPE)]
        DATABASETYPE,
        [EnumMember(Value = DocConstantLookupTable.DATAHUBSEARCHCATEGORY)]
        DATAHUBSEARCHCATEGORY,
        [EnumMember(Value = DocConstantLookupTable.DATAHUBSOURCE)]
        DATAHUBSOURCE,
        [EnumMember(Value = DocConstantLookupTable.DEFAULTTIMEUNIT)]
        DEFAULTTIMEUNIT,
        [EnumMember(Value = DocConstantLookupTable.DEFAULTUNITTYPE)]
        DEFAULTUNITTYPE,
        [EnumMember(Value = DocConstantLookupTable.DIRECTIONALITY)]
        DIRECTIONALITY,
        [EnumMember(Value = DocConstantLookupTable.DOCUMENTSETTYPE)]
        DOCUMENTSETTYPE,
        [EnumMember(Value = DocConstantLookupTable.DOCUMENTTYPE)]
        DOCUMENTTYPE,
        [EnumMember(Value = DocConstantLookupTable.DOSAGEPROTOCOL)]
        DOSAGEPROTOCOL,
        [EnumMember(Value = DocConstantLookupTable.DOSAGETYPE)]
        DOSAGETYPE,
        [EnumMember(Value = DocConstantLookupTable.EQUALITYOPERATOR)]
        EQUALITYOPERATOR,
        [EnumMember(Value = DocConstantLookupTable.ERRORMESSAGE)]
        ERRORMESSAGE,
        [EnumMember(Value = DocConstantLookupTable.EXTERNALKEY)]
        EXTERNALKEY,
        [EnumMember(Value = DocConstantLookupTable.FEATURE)]
        FEATURE,
        [EnumMember(Value = DocConstantLookupTable.FIELDTYPE)]
        FIELDTYPE,
        [EnumMember(Value = DocConstantLookupTable.FOREIGNKEYSTATUS)]
        FOREIGNKEYSTATUS,
        [EnumMember(Value = DocConstantLookupTable.FQREFERENCESTATUS)]
        FQREFERENCESTATUS,
        [EnumMember(Value = DocConstantLookupTable.HELP)]
        HELP,
        [EnumMember(Value = DocConstantLookupTable.IMPORTSTATUS)]
        IMPORTSTATUS,
        [EnumMember(Value = DocConstantLookupTable.INCIDENCERATETYPE)]
        INCIDENCERATETYPE,
        [EnumMember(Value = DocConstantLookupTable.INSTITUTIONTYPE)]
        INSTITUTIONTYPE,
        [EnumMember(Value = DocConstantLookupTable.INTEGRATIONNAME)]
        INTEGRATIONNAME,
        [EnumMember(Value = DocConstantLookupTable.INTEGRATIONPROPERTYNAME)]
        INTEGRATIONPROPERTYNAME,
        [EnumMember(Value = DocConstantLookupTable.INTERVENTIONLINEOFTREATMENT)]
        INTERVENTIONLINEOFTREATMENT,
        [EnumMember(Value = DocConstantLookupTable.INTERVENTIONMEDIUM)]
        INTERVENTIONMEDIUM,
        [EnumMember(Value = DocConstantLookupTable.INTERVENTIONPROVIDER)]
        INTERVENTIONPROVIDER,
        [EnumMember(Value = DocConstantLookupTable.INTERVENTIONROUTE)]
        INTERVENTIONROUTE,
        [EnumMember(Value = DocConstantLookupTable.INTERVENTIONSCHEDULE)]
        INTERVENTIONSCHEDULE,
        [EnumMember(Value = DocConstantLookupTable.INTERVENTIONSTAGESETTING)]
        INTERVENTIONSTAGESETTING,
        [EnumMember(Value = DocConstantLookupTable.INTERVENTIONTYPE)]
        INTERVENTIONTYPE,
        [EnumMember(Value = DocConstantLookupTable.JOB)]
        JOB,
        [EnumMember(Value = DocConstantLookupTable.JUNCTIONTYPE)]
        JUNCTIONTYPE,
        [EnumMember(Value = DocConstantLookupTable.LOOKUPTABLE)]
        LOOKUPTABLE,
        [EnumMember(Value = DocConstantLookupTable.LOOKUPTYPE)]
        LOOKUPTYPE,
        [EnumMember(Value = DocConstantLookupTable.MANUALIZEDTREATMENT)]
        MANUALIZEDTREATMENT,
        [EnumMember(Value = DocConstantLookupTable.MEANCALCULATIONTYPE)]
        MEANCALCULATIONTYPE,
        [EnumMember(Value = DocConstantLookupTable.MEANRANGETYPE)]
        MEANRANGETYPE,
        [EnumMember(Value = DocConstantLookupTable.MEANVARIABLETYPE)]
        MEANVARIABLETYPE,
        [EnumMember(Value = DocConstantLookupTable.MEANVARIANCETYPE)]
        MEANVARIANCETYPE,
        [EnumMember(Value = DocConstantLookupTable.METHODOFANALYSIS)]
        METHODOFANALYSIS,
        [EnumMember(Value = DocConstantLookupTable.MODELNAME)]
        MODELNAME,
        [EnumMember(Value = DocConstantLookupTable.OUTCOMECATEGORY)]
        OUTCOMECATEGORY,
        [EnumMember(Value = DocConstantLookupTable.OUTCOMETYPE)]
        OUTCOMETYPE,
        [EnumMember(Value = DocConstantLookupTable.PERMISSION)]
        PERMISSION,
        [EnumMember(Value = DocConstantLookupTable.POPULATIONTYPE)]
        POPULATIONTYPE,
        [EnumMember(Value = DocConstantLookupTable.PREVALENCETYPE)]
        PREVALENCETYPE,
        [EnumMember(Value = DocConstantLookupTable.PROTOCOLFILTEROWNER)]
        PROTOCOLFILTEROWNER,
        [EnumMember(Value = DocConstantLookupTable.PROTOCOLFILTERTYPE)]
        PROTOCOLFILTERTYPE,
        [EnumMember(Value = DocConstantLookupTable.PROTOCOLTYPE)]
        PROTOCOLTYPE,
        [EnumMember(Value = DocConstantLookupTable.PUBLICATIONPOOLSTUDIES)]
        PUBLICATIONPOOLSTUDIES,
        [EnumMember(Value = DocConstantLookupTable.PUBTYPE)]
        PUBTYPE,
        [EnumMember(Value = DocConstantLookupTable.QUESTION)]
        QUESTION,
        [EnumMember(Value = DocConstantLookupTable.QUESTIONCATEGORY)]
        QUESTIONCATEGORY,
        [EnumMember(Value = DocConstantLookupTable.QUESTIONTYPE)]
        QUESTIONTYPE,
        [EnumMember(Value = DocConstantLookupTable.QUEUECHANNEL)]
        QUEUECHANNEL,
        [EnumMember(Value = DocConstantLookupTable.RANDOMIZATION)]
        RANDOMIZATION,
        [EnumMember(Value = DocConstantLookupTable.RANGETYPE)]
        RANGETYPE,
        [EnumMember(Value = DocConstantLookupTable.RATING)]
        RATING,
        [EnumMember(Value = DocConstantLookupTable.REASONREJECTED)]
        REASONREJECTED,
        [EnumMember(Value = DocConstantLookupTable.RECRUITMENTMETHOD)]
        RECRUITMENTMETHOD,
        [EnumMember(Value = DocConstantLookupTable.REPRESENTATIVESAMPLE)]
        REPRESENTATIVESAMPLE,
        [EnumMember(Value = DocConstantLookupTable.RESPONSESCOLLECTEDBY)]
        RESPONSESCOLLECTEDBY,
        [EnumMember(Value = DocConstantLookupTable.RESULTSCATEGORY)]
        RESULTSCATEGORY,
        [EnumMember(Value = DocConstantLookupTable.RISKOFBIASASSESSMENT)]
        RISKOFBIASASSESSMENT,
        [EnumMember(Value = DocConstantLookupTable.SCOPE)]
        SCOPE,
        [EnumMember(Value = DocConstantLookupTable.SETTINGTYPE)]
        SETTINGTYPE,
        [EnumMember(Value = DocConstantLookupTable.STATISTICALSIGNIFICANCE)]
        STATISTICALSIGNIFICANCE,
        [EnumMember(Value = DocConstantLookupTable.STATISTICALTEST)]
        STATISTICALTEST,
        [EnumMember(Value = DocConstantLookupTable.STATSRECORDNAME)]
        STATSRECORDNAME,
        [EnumMember(Value = DocConstantLookupTable.STATUS)]
        STATUS,
        [EnumMember(Value = DocConstantLookupTable.STRATIFICATIONTYPE)]
        STRATIFICATIONTYPE,
        [EnumMember(Value = DocConstantLookupTable.STUDYALLOCATTIONMETHOD)]
        STUDYALLOCATTIONMETHOD,
        [EnumMember(Value = DocConstantLookupTable.STUDYBIAS)]
        STUDYBIAS,
        [EnumMember(Value = DocConstantLookupTable.STUDYBLINDINGMETHOD)]
        STUDYBLINDINGMETHOD,
        [EnumMember(Value = DocConstantLookupTable.STUDYCOMPLIANCE)]
        STUDYCOMPLIANCE,
        [EnumMember(Value = DocConstantLookupTable.STUDYDESIGN)]
        STUDYDESIGN,
        [EnumMember(Value = DocConstantLookupTable.STUDYDOCUMENTTYPE)]
        STUDYDOCUMENTTYPE,
        [EnumMember(Value = DocConstantLookupTable.STUDYFUNDING)]
        STUDYFUNDING,
        [EnumMember(Value = DocConstantLookupTable.STUDYGROUPTYPE)]
        STUDYGROUPTYPE,
        [EnumMember(Value = DocConstantLookupTable.STUDYIMPORTLOCATION)]
        STUDYIMPORTLOCATION,
        [EnumMember(Value = DocConstantLookupTable.STUDYIMPORTTYPE)]
        STUDYIMPORTTYPE,
        [EnumMember(Value = DocConstantLookupTable.STUDYNGA)]
        STUDYNGA,
        [EnumMember(Value = DocConstantLookupTable.STUDYOBJECTIVE)]
        STUDYOBJECTIVE,
        [EnumMember(Value = DocConstantLookupTable.STUDYPHASENAMES)]
        STUDYPHASENAMES,
        [EnumMember(Value = DocConstantLookupTable.STUDYPURPOSE)]
        STUDYPURPOSE,
        [EnumMember(Value = DocConstantLookupTable.STUDYRANDOMIZATIONMETHOD)]
        STUDYRANDOMIZATIONMETHOD,
        [EnumMember(Value = DocConstantLookupTable.STUDYTYPE)]
        STUDYTYPE,
        [EnumMember(Value = DocConstantLookupTable.STUDYTYPEHARMETIOLOGY)]
        STUDYTYPEHARMETIOLOGY,
        [EnumMember(Value = DocConstantLookupTable.STUDYTYPETHERAPY)]
        STUDYTYPETHERAPY,
        [EnumMember(Value = DocConstantLookupTable.STUDYYEARS)]
        STUDYYEARS,
        [EnumMember(Value = DocConstantLookupTable.TERMCLASSIFICATION)]
        TERMCLASSIFICATION,
        [EnumMember(Value = DocConstantLookupTable.TERMSECTION)]
        TERMSECTION,
        [EnumMember(Value = DocConstantLookupTable.TIMECARDSTATUS)]
        TIMECARDSTATUS,
        [EnumMember(Value = DocConstantLookupTable.TIMEPOINTTYPE)]
        TIMEPOINTTYPE,
        [EnumMember(Value = DocConstantLookupTable.UNITSOFMEASURE)]
        UNITSOFMEASURE,
        [EnumMember(Value = DocConstantLookupTable.UNITTYPE)]
        UNITTYPE,
        [EnumMember(Value = DocConstantLookupTable.USEREMPLOYEETYPE)]
        USEREMPLOYEETYPE,
        [EnumMember(Value = DocConstantLookupTable.USERPAYROLLSTATUS)]
        USERPAYROLLSTATUS,
        [EnumMember(Value = DocConstantLookupTable.USERPAYROLLTYPE)]
        USERPAYROLLTYPE,
        [EnumMember(Value = DocConstantLookupTable.USERTYPE)]
        USERTYPE,
        [EnumMember(Value = DocConstantLookupTable.VALUESTATUS)]
        VALUESTATUS,
        [EnumMember(Value = DocConstantLookupTable.VALUETYPE)]
        VALUETYPE,
        [EnumMember(Value = DocConstantLookupTable.VARIABLERULE)]
        VARIABLERULE,
        [EnumMember(Value = DocConstantLookupTable.VARIABLETYPE)]
        VARIABLETYPE,
        [EnumMember(Value = DocConstantLookupTable.WORKFLOW)]
        WORKFLOW,
        [EnumMember(Value = DocConstantLookupTable.WORKFLOWSTATUS)]
        WORKFLOWSTATUS,
        [EnumMember(Value = DocConstantLookupTable.WORKFLOWTASKTYPE)]
        WORKFLOWTASKTYPE,
        [EnumMember(Value = DocConstantLookupTable.YESNONA)]
        YESNONA
    }
    
    public sealed partial class DocConstantLookupTable
    {
        public const string AMPERSONCOUNT = "AmPersonCount";
        public const string APP = "App";
        public const string ARMPOPULATIONAGE = "ArmPopulationAge";
        public const string ARMPOPULATIONN = "ArmPopulationN";
        public const string ASSOCIATIONMEASURE = "AssociationMeasure";
        public const string ATTRIBUTECATEGORY = "AttributeCategory";
        public const string ATTRIBUTETYPE = "AttributeType";
        public const string BROADCASTSTATUS = "BroadcastStatus";
        public const string BROADCASTTYPE = "BroadcastType";
        public const string CONFIDENCEINTERVAL = "ConfidenceInterval";
        public const string CONJUNCTION = "Conjunction";
        public const string DATABASETYPE = "DatabaseType";
        public const string DATAHUBSEARCHCATEGORY = "DataHubSearchCategory";
        public const string DATAHUBSOURCE = "DataHubSource";
        public const string DEFAULTTIMEUNIT = "DefaultTimeUnit";
        public const string DEFAULTUNITTYPE = "DefaultUnitType";
        public const string DIRECTIONALITY = "Directionality";
        public const string DOCUMENTSETTYPE = "DocumentSetType";
        public const string DOCUMENTTYPE = "DocumentType";
        public const string DOSAGEPROTOCOL = "DosageProtocol";
        public const string DOSAGETYPE = "DosageType";
        public const string EQUALITYOPERATOR = "EqualityOperator";
        public const string ERRORMESSAGE = "ErrorMessage";
        public const string EXTERNALKEY = "ExternalKey";
        public const string FEATURE = "Feature";
        public const string FIELDTYPE = "FieldType";
        public const string FOREIGNKEYSTATUS = "ForeignKeyStatus";
        public const string FQREFERENCESTATUS = "FqReferenceStatus";
        public const string HELP = "Help";
        public const string IMPORTSTATUS = "ImportStatus";
        public const string INCIDENCERATETYPE = "IncidenceRateType";
        public const string INSTITUTIONTYPE = "InstitutionType";
        public const string INTEGRATIONNAME = "IntegrationName";
        public const string INTEGRATIONPROPERTYNAME = "IntegrationPropertyName";
        public const string INTERVENTIONLINEOFTREATMENT = "InterventionLineOfTreatment";
        public const string INTERVENTIONMEDIUM = "InterventionMedium";
        public const string INTERVENTIONPROVIDER = "InterventionProvider";
        public const string INTERVENTIONROUTE = "InterventionRoute";
        public const string INTERVENTIONSCHEDULE = "InterventionSchedule";
        public const string INTERVENTIONSTAGESETTING = "InterventionStageSetting";
        public const string INTERVENTIONTYPE = "InterventionType";
        public const string JOB = "Job";
        public const string JUNCTIONTYPE = "JunctionType";
        public const string LOOKUPTABLE = "LookupTable";
        public const string LOOKUPTYPE = "LookupType";
        public const string MANUALIZEDTREATMENT = "ManualizedTreatment";
        public const string MEANCALCULATIONTYPE = "MeanCalculationType";
        public const string MEANRANGETYPE = "MeanRangeType";
        public const string MEANVARIABLETYPE = "MeanVariableType";
        public const string MEANVARIANCETYPE = "MeanVarianceType";
        public const string METHODOFANALYSIS = "MethodOfAnalysis";
        public const string MODELNAME = "ModelName";
        public const string OUTCOMECATEGORY = "OutcomeCategory";
        public const string OUTCOMETYPE = "OutcomeType";
        public const string PERMISSION = "Permission";
        public const string POPULATIONTYPE = "PopulationType";
        public const string PREVALENCETYPE = "PrevalenceType";
        public const string PROTOCOLFILTEROWNER = "ProtocolFilterOwner";
        public const string PROTOCOLFILTERTYPE = "ProtocolFilterType";
        public const string PROTOCOLTYPE = "ProtocolType";
        public const string PUBLICATIONPOOLSTUDIES = "PublicationPoolStudies";
        public const string PUBTYPE = "PubType";
        public const string QUESTION = "Question";
        public const string QUESTIONCATEGORY = "QuestionCategory";
        public const string QUESTIONTYPE = "QuestionType";
        public const string QUEUECHANNEL = "QueueChannel";
        public const string RANDOMIZATION = "Randomization";
        public const string RANGETYPE = "RangeType";
        public const string RATING = "Rating";
        public const string REASONREJECTED = "ReasonRejected";
        public const string RECRUITMENTMETHOD = "RecruitmentMethod";
        public const string REPRESENTATIVESAMPLE = "RepresentativeSample";
        public const string RESPONSESCOLLECTEDBY = "ResponsesCollectedBy";
        public const string RESULTSCATEGORY = "ResultsCategory";
        public const string RISKOFBIASASSESSMENT = "RiskOfBiasAssessment";
        public const string SCOPE = "Scope";
        public const string SETTINGTYPE = "SettingType";
        public const string STATISTICALSIGNIFICANCE = "StatisticalSignificance";
        public const string STATISTICALTEST = "StatisticalTest";
        public const string STATSRECORDNAME = "StatsRecordName";
        public const string STATUS = "Status";
        public const string STRATIFICATIONTYPE = "StratificationType";
        public const string STUDYALLOCATTIONMETHOD = "StudyAllocattionMethod";
        public const string STUDYBIAS = "StudyBias";
        public const string STUDYBLINDINGMETHOD = "StudyBlindingMethod";
        public const string STUDYCOMPLIANCE = "StudyCompliance";
        public const string STUDYDESIGN = "StudyDesign";
        public const string STUDYDOCUMENTTYPE = "StudyDocumentType";
        public const string STUDYFUNDING = "StudyFunding";
        public const string STUDYGROUPTYPE = "StudyGroupType";
        public const string STUDYIMPORTLOCATION = "StudyImportLocation";
        public const string STUDYIMPORTTYPE = "StudyImportType";
        public const string STUDYNGA = "StudyNGA";
        public const string STUDYOBJECTIVE = "StudyObjective";
        public const string STUDYPHASENAMES = "StudyPhaseNames";
        public const string STUDYPURPOSE = "StudyPurpose";
        public const string STUDYRANDOMIZATIONMETHOD = "StudyRandomizationMethod";
        public const string STUDYTYPE = "StudyType";
        public const string STUDYTYPEHARMETIOLOGY = "StudyTypeHarmEtiology";
        public const string STUDYTYPETHERAPY = "StudyTypeTherapy";
        public const string STUDYYEARS = "StudyYears";
        public const string TERMCLASSIFICATION = "TermClassification";
        public const string TERMSECTION = "TermSection";
        public const string TIMECARDSTATUS = "TimeCardStatus";
        public const string TIMEPOINTTYPE = "TimepointType";
        public const string UNITSOFMEASURE = "UnitsOfMeasure";
        public const string UNITTYPE = "UnitType";
        public const string USEREMPLOYEETYPE = "UserEmployeeType";
        public const string USERPAYROLLSTATUS = "UserPayrollStatus";
        public const string USERPAYROLLTYPE = "UserPayrollType";
        public const string USERTYPE = "UserType";
        public const string VALUESTATUS = "ValueStatus";
        public const string VALUETYPE = "ValueType";
        public const string VARIABLERULE = "VariableRule";
        public const string VARIABLETYPE = "VariableType";
        public const string WORKFLOW = "Workflow";
        public const string WORKFLOWSTATUS = "WorkflowStatus";
        public const string WORKFLOWTASKTYPE = "WorkflowTaskType";
        public const string YESNONA = "YesNoNa";
        
        #region Internals
        
        private static List<string> _all;
        
        public static List<string> All => _all ?? (_all = typeof(DocConstantLookupTable).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        /// <summary>
        ///    The string value of the current instance
        /// </summary>
        private readonly string Value;

        /// <summary>
        ///    The enum constructor
        /// </summary>
        /// <param name="ItemName">Name of the item.</param>
        private DocConstantLookupTable(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        /// <summary>
        /// Determines if the Constant contains an exact match (case insensitive) for the name
        /// </summary>
        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        /// <summary>
        ///    Implicit cast to Enum
        /// </summary>
        /// <param name="Val">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator DocConstantLookupTable(string Val)
        {
            return new DocConstantLookupTable(Val);
        }

        /// <summary>
        ///    Implicit cast to string
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator string(DocConstantLookupTable item)
        {
            return item?.Value ?? string.Empty;
        }

        /// <summary>
        ///    Override of ToString
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString()
        {
            return Value;
        }

        #endregion Internals

        #region IEquatable (DocConstantLookupTable)

        /// <summary>
        ///    Equals
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Equals(DocConstantLookupTable obj)
        {
            return this == obj;
        }

        /// <summary>
        ///    == Equality operator guarantees we're evaluating instance values
        /// </summary>
        /// <param name="ft1">The FT1.</param>
        /// <param name="ft2">The FT2.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(DocConstantLookupTable ft1, DocConstantLookupTable ft2)
        {
            //do a string comparison on the fieldtypes
            return string.Equals(Convert.ToString(ft1), Convert.ToString(ft2), StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        ///    != Inequality operator guarantees we're evaluating instance values
        /// </summary>
        /// <param name="ft1">The FT1.</param>
        /// <param name="ft2">The FT2.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(DocConstantLookupTable ft1, DocConstantLookupTable ft2)
        {
            return !(ft1 == ft2);
        }

        /// <summary>
        ///    Equals
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns><c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantLookupTable))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantLookupTable) obj;
            }
            return ret;
        }

        /// <summary>
        ///    Get Hash Code
        /// </summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
        public override int GetHashCode()
        {
            var ret = 23;
            const int prime = 37;
            ret = (ret * prime) + Value.GetHashCode();
            ret = (ret * prime) + All.GetHashCode();
            return ret;
        }

        #endregion IEquatable (DocConstantLookupTable)
    }
}
