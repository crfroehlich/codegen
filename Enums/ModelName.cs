﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated by a CodeSmith Generator project.
//
//    Changes to this file may cause incorrect behavior and will be lost if
//    the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;

namespace Services.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ModelNameEnm
    {
        [EnumMember(Value = DocConstantModelName.APP)]
        APP,
        [EnumMember(Value = DocConstantModelName.ATTRIBUTE)]
        ATTRIBUTE,
        [EnumMember(Value = DocConstantModelName.ATTRIBUTECATEGORY)]
        ATTRIBUTECATEGORY,
        [EnumMember(Value = DocConstantModelName.ATTRIBUTEINTERVAL)]
        ATTRIBUTEINTERVAL,
        [EnumMember(Value = DocConstantModelName.AUDITDELTA)]
        AUDITDELTA,
        [EnumMember(Value = DocConstantModelName.AUDITRECORD)]
        AUDITRECORD,
        [EnumMember(Value = DocConstantModelName.BACKGROUNDTASK)]
        BACKGROUNDTASK,
        [EnumMember(Value = DocConstantModelName.BACKGROUNDTASKHISTORY)]
        BACKGROUNDTASKHISTORY,
        [EnumMember(Value = DocConstantModelName.BACKGROUNDTASKITEM)]
        BACKGROUNDTASKITEM,
        [EnumMember(Value = DocConstantModelName.BROADCAST)]
        BROADCAST,
        [EnumMember(Value = DocConstantModelName.CHARACTERISTIC)]
        CHARACTERISTIC,
        [EnumMember(Value = DocConstantModelName.CLIENT)]
        CLIENT,
        [EnumMember(Value = DocConstantModelName.COMPARATOR)]
        COMPARATOR,
        [EnumMember(Value = DocConstantModelName.DATABASEVERSION)]
        DATABASEVERSION,
        [EnumMember(Value = DocConstantModelName.DATETIME)]
        DATETIME,
        [EnumMember(Value = DocConstantModelName.DEFAULT)]
        DEFAULT,
        [EnumMember(Value = DocConstantModelName.DIVISION)]
        DIVISION,
        [EnumMember(Value = DocConstantModelName.DOCUMENT)]
        DOCUMENT,
        [EnumMember(Value = DocConstantModelName.DOCUMENTATTRIBUTE)]
        DOCUMENTATTRIBUTE,
        [EnumMember(Value = DocConstantModelName.DOCUMENTSET)]
        DOCUMENTSET,
        [EnumMember(Value = DocConstantModelName.DOCUMENTSETHISTORY)]
        DOCUMENTSETHISTORY,
        [EnumMember(Value = DocConstantModelName.ENTITY)]
        ENTITY,
        [EnumMember(Value = DocConstantModelName.ENTITYAUDITRECORD)]
        ENTITYAUDITRECORD,
        [EnumMember(Value = DocConstantModelName.EVENT)]
        EVENT,
        [EnumMember(Value = DocConstantModelName.FEATURESET)]
        FEATURESET,
        [EnumMember(Value = DocConstantModelName.FOREIGNKEY)]
        FOREIGNKEY,
        [EnumMember(Value = DocConstantModelName.GLOSSARY)]
        GLOSSARY,
        [EnumMember(Value = DocConstantModelName.HELP)]
        HELP,
        [EnumMember(Value = DocConstantModelName.HISTORY)]
        HISTORY,
        [EnumMember(Value = DocConstantModelName.IMPERSONATION)]
        IMPERSONATION,
        [EnumMember(Value = DocConstantModelName.IMPORTDATA)]
        IMPORTDATA,
        [EnumMember(Value = DocConstantModelName.INTERVAL)]
        INTERVAL,
        [EnumMember(Value = DocConstantModelName.INTERVENTION)]
        INTERVENTION,
        [EnumMember(Value = DocConstantModelName.JCTATTRIBUTECATEGORYATTRIBUTEDOCUMENTSET)]
        JCTATTRIBUTECATEGORYATTRIBUTEDOCUMENTSET,
        [EnumMember(Value = DocConstantModelName.JUNCTION)]
        JUNCTION,
        [EnumMember(Value = DocConstantModelName.LOCALE)]
        LOCALE,
        [EnumMember(Value = DocConstantModelName.LOCALELOOKUP)]
        LOCALELOOKUP,
        [EnumMember(Value = DocConstantModelName.LOOKUPCATEGORY)]
        LOOKUPCATEGORY,
        [EnumMember(Value = DocConstantModelName.LOOKUPTABLE)]
        LOOKUPTABLE,
        [EnumMember(Value = DocConstantModelName.LOOKUPTABLEBINDING)]
        LOOKUPTABLEBINDING,
        [EnumMember(Value = DocConstantModelName.LOOKUPTABLEENUM)]
        LOOKUPTABLEENUM,
        [EnumMember(Value = DocConstantModelName.MEANRANGES)]
        MEANRANGES,
        [EnumMember(Value = DocConstantModelName.MEANRANGEVALUE)]
        MEANRANGEVALUE,
        [EnumMember(Value = DocConstantModelName.MEANVARIANCES)]
        MEANVARIANCES,
        [EnumMember(Value = DocConstantModelName.MEANVARIANCEVALUE)]
        MEANVARIANCEVALUE,
        [EnumMember(Value = DocConstantModelName.OUTCOME)]
        OUTCOME,
        [EnumMember(Value = DocConstantModelName.PACKAGE)]
        PACKAGE,
        [EnumMember(Value = DocConstantModelName.PAGE)]
        PAGE,
        [EnumMember(Value = DocConstantModelName.PROJECT)]
        PROJECT,
        [EnumMember(Value = DocConstantModelName.QUEUECHANNEL)]
        QUEUECHANNEL,
        [EnumMember(Value = DocConstantModelName.RELEASESTATUS)]
        RELEASESTATUS,
        [EnumMember(Value = DocConstantModelName.ROLE)]
        ROLE,
        [EnumMember(Value = DocConstantModelName.SCOPE)]
        SCOPE,
        [EnumMember(Value = DocConstantModelName.STATS)]
        STATS,
        [EnumMember(Value = DocConstantModelName.STATSRECORD)]
        STATSRECORD,
        [EnumMember(Value = DocConstantModelName.STATSSTUDYSET)]
        STATSSTUDYSET,
        [EnumMember(Value = DocConstantModelName.STUDYDESIGN)]
        STUDYDESIGN,
        [EnumMember(Value = DocConstantModelName.STUDYTYPE)]
        STUDYTYPE,
        [EnumMember(Value = DocConstantModelName.TAG)]
        TAG,
        [EnumMember(Value = DocConstantModelName.TEAM)]
        TEAM,
        [EnumMember(Value = DocConstantModelName.TERMCATEGORY)]
        TERMCATEGORY,
        [EnumMember(Value = DocConstantModelName.TERMMASTER)]
        TERMMASTER,
        [EnumMember(Value = DocConstantModelName.TERMSYNONYM)]
        TERMSYNONYM,
        [EnumMember(Value = DocConstantModelName.TIMECARD)]
        TIMECARD,
        [EnumMember(Value = DocConstantModelName.TIMEPOINT)]
        TIMEPOINT,
        [EnumMember(Value = DocConstantModelName.UNITCONVERSIONRULES)]
        UNITCONVERSIONRULES,
        [EnumMember(Value = DocConstantModelName.UNITOFMEASURE)]
        UNITOFMEASURE,
        [EnumMember(Value = DocConstantModelName.UNITS)]
        UNITS,
        [EnumMember(Value = DocConstantModelName.UNITVALUE)]
        UNITVALUE,
        [EnumMember(Value = DocConstantModelName.UPDATE)]
        UPDATE,
        [EnumMember(Value = DocConstantModelName.USER)]
        USER,
        [EnumMember(Value = DocConstantModelName.USERREQUEST)]
        USERREQUEST,
        [EnumMember(Value = DocConstantModelName.USERSESSION)]
        USERSESSION,
        [EnumMember(Value = DocConstantModelName.USERTYPE)]
        USERTYPE,
        [EnumMember(Value = DocConstantModelName.VALUETYPE)]
        VALUETYPE,
        [EnumMember(Value = DocConstantModelName.VARIABLEINSTANCE)]
        VARIABLEINSTANCE,
        [EnumMember(Value = DocConstantModelName.VARIABLERULE)]
        VARIABLERULE,
        [EnumMember(Value = DocConstantModelName.WORKFLOW)]
        WORKFLOW,
        [EnumMember(Value = DocConstantModelName.WORKFLOWCOMMENT)]
        WORKFLOWCOMMENT,
        [EnumMember(Value = DocConstantModelName.WORKFLOWTASK)]
        WORKFLOWTASK
    }

    public sealed partial class DocConstantModelName
    {
        public const string APP = "App";
        public const string ATTRIBUTE = "Attribute";
        public const string ATTRIBUTECATEGORY = "AttributeCategory";
        public const string ATTRIBUTEINTERVAL = "AttributeInterval";
        public const string AUDITDELTA = "AuditDelta";
        public const string AUDITRECORD = "AuditRecord";
        public const string BACKGROUNDTASK = "BackgroundTask";
        public const string BACKGROUNDTASKHISTORY = "BackgroundTaskHistory";
        public const string BACKGROUNDTASKITEM = "BackgroundTaskItem";
        public const string BROADCAST = "Broadcast";
        public const string CHARACTERISTIC = "Characteristic";
        public const string CLIENT = "Client";
        public const string COMPARATOR = "Comparator";
        public const string DATABASEVERSION = "DatabaseVersion";
        public const string DATETIME = "DateTime";
        public const string DEFAULT = "Default";
        public const string DIVISION = "Division";
        public const string DOCUMENT = "Document";
        public const string DOCUMENTATTRIBUTE = "DocumentAttribute";
        public const string DOCUMENTSET = "DocumentSet";
        public const string DOCUMENTSETHISTORY = "DocumentSetHistory";
        public const string ENTITY = "Entities";
        public const string ENTITYAUDITRECORD = "EntityAuditRecords";
        public const string EVENT = "Event";
        public const string FEATURESET = "FeatureSet";
        public const string FOREIGNKEY = "ForeignKey";
        public const string GLOSSARY = "Glossary";
        public const string HELP = "Help";
        public const string HISTORY = "History";
        public const string IMPERSONATION = "Impersonation";
        public const string IMPORTDATA = "ImportData";
        public const string INTERVAL = "Interval";
        public const string INTERVENTION = "Intervention";
        public const string JCTATTRIBUTECATEGORYATTRIBUTEDOCUMENTSET = "JctAttributeCategoryAttributeDocumentSet";
        public const string JUNCTION = "Junction";
        public const string LOCALE = "Locale";
        public const string LOCALELOOKUP = "LocaleLookup";
        public const string LOOKUPCATEGORY = "LookupCategory";
        public const string LOOKUPTABLE = "LookupTable";
        public const string LOOKUPTABLEBINDING = "LookupTableBinding";
        public const string LOOKUPTABLEENUM = "LookupTableEnum";
        public const string MEANRANGES = "MeanRanges";
        public const string MEANRANGEVALUE = "MeanRangeValue";
        public const string MEANVARIANCES = "MeanVariances";
        public const string MEANVARIANCEVALUE = "MeanVarianceValue";
        public const string OUTCOME = "Outcome";
        public const string PACKAGE = "Package";
        public const string PAGE = "Page";
        public const string PROJECT = "Project";
        public const string QUEUECHANNEL = "QueueChannel";
        public const string RELEASESTATUS = "ReleaseStatus";
        public const string ROLE = "Role";
        public const string SCOPE = "Scope";
        public const string STATS = "Stats";
        public const string STATSRECORD = "StatsRecord";
        public const string STATSSTUDYSET = "StatsStudySet";
        public const string STUDYDESIGN = "StudyDesign";
        public const string STUDYTYPE = "StudyType";
        public const string TAG = "Tag";
        public const string TEAM = "Team";
        public const string TERMCATEGORY = "TermCategory";
        public const string TERMMASTER = "TermMaster";
        public const string TERMSYNONYM = "TermSynonym";
        public const string TIMECARD = "TimeCard";
        public const string TIMEPOINT = "TimePoint";
        public const string UNITCONVERSIONRULES = "UnitConversionRules";
        public const string UNITOFMEASURE = "UnitOfMeasure";
        public const string UNITS = "Units";
        public const string UNITVALUE = "UnitValue";
        public const string UPDATE = "Update";
        public const string USER = "User";
        public const string USERREQUEST = "UserRequest";
        public const string USERSESSION = "UserSession";
        public const string USERTYPE = "UserType";
        public const string VALUETYPE = "ValueType";
        public const string VARIABLEINSTANCE = "VariableInstance";
        public const string VARIABLERULE = "VariableRule";
        public const string WORKFLOW = "Workflow";
        public const string WORKFLOWCOMMENT = "WorkflowComment";
        public const string WORKFLOWTASK = "WorkflowTask";

        #region Internals

        private static List<string> _all;

        public static List<string> All => _all ?? (_all = typeof(DocConstantModelName).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select(fi => fi.GetRawConstantValue().ToString()).OrderBy(n => n).ToList());

        /// <summary>
        ///    The string value of the current instance
        /// </summary>
        private readonly string Value;

        /// <summary>
        ///    The enum constructor
        /// </summary>
        /// <param name="ItemName">Name of the item.</param>
        private DocConstantModelName(string ItemName = null)
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
        public static implicit operator DocConstantModelName(string Val)
        {
            return new DocConstantModelName(Val);
        }

        /// <summary>
        ///    Implicit cast to string
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator string(DocConstantModelName item)
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

        #region IEquatable (DocConstantModelName)

        /// <summary>
        ///    Equals
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Equals(DocConstantModelName obj)
        {
            return this == obj;
        }

        /// <summary>
        ///    == Equality operator guarantees we're evaluating instance values
        /// </summary>
        /// <param name="ft1">The FT1.</param>
        /// <param name="ft2">The FT2.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(DocConstantModelName ft1, DocConstantModelName ft2)
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
        public static bool operator !=(DocConstantModelName ft1, DocConstantModelName ft2)
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
            if (!(obj is DocConstantModelName))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantModelName)obj;
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

        #endregion IEquatable (DocConstantModelName)
    }
}