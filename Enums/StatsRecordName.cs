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
    public enum StatsRecordNameEnm
    {
        [EnumMember(Value = DocConstantStatsRecordName.AMBISPECTIVE_OBSERVATIONAL)]
        AMBISPECTIVE_OBSERVATIONAL,
        [EnumMember(Value = DocConstantStatsRecordName.BOUNDCHARACTERISTICVARIABLES)]
        BOUNDCHARACTERISTICVARIABLES,
        [EnumMember(Value = DocConstantStatsRecordName.BOUNDGROUPVARIABLES)]
        BOUNDGROUPVARIABLES,
        [EnumMember(Value = DocConstantStatsRecordName.BOUNDOUTCOMEITERATIONS)]
        BOUNDOUTCOMEITERATIONS,
        [EnumMember(Value = DocConstantStatsRecordName.BOUNDOUTCOMEVARIABLES)]
        BOUNDOUTCOMEVARIABLES,
        [EnumMember(Value = DocConstantStatsRecordName.BOUNDSTUDYLEVELVARIABLES)]
        BOUNDSTUDYLEVELVARIABLES,
        [EnumMember(Value = DocConstantStatsRecordName.BOUNDTOTALVARIABLES)]
        BOUNDTOTALVARIABLES,
        [EnumMember(Value = DocConstantStatsRecordName.CASE_CONTROL)]
        CASE_CONTROL,
        [EnumMember(Value = DocConstantStatsRecordName.CASE_REPORT)]
        CASE_REPORT,
        [EnumMember(Value = DocConstantStatsRecordName.CASE_SERIES)]
        CASE_SERIES,
        [EnumMember(Value = DocConstantStatsRecordName.COLLECTEDCHARACTERISTICVARIABLES)]
        COLLECTEDCHARACTERISTICVARIABLES,
        [EnumMember(Value = DocConstantStatsRecordName.COLLECTEDMAINGROUPS)]
        COLLECTEDMAINGROUPS,
        [EnumMember(Value = DocConstantStatsRecordName.COLLECTEDOUTCOMEVARIABLES)]
        COLLECTEDOUTCOMEVARIABLES,
        [EnumMember(Value = DocConstantStatsRecordName.COMPARISONS)]
        COMPARISONS,
        [EnumMember(Value = DocConstantStatsRecordName.CROSS_SECTIONAL)]
        CROSS_SECTIONAL,
        [EnumMember(Value = DocConstantStatsRecordName.DATAPOINTSAVG)]
        DATAPOINTSAVG,
        [EnumMember(Value = DocConstantStatsRecordName.DATAPOINTSMAX)]
        DATAPOINTSMAX,
        [EnumMember(Value = DocConstantStatsRecordName.DATAPOINTSTOTAL)]
        DATAPOINTSTOTAL,
        [EnumMember(Value = DocConstantStatsRecordName.DATASTUDIES)]
        DATASTUDIES,
        [EnumMember(Value = DocConstantStatsRecordName.DIAGNOSIS)]
        DIAGNOSIS,
        [EnumMember(Value = DocConstantStatsRecordName.FOLLOW_UP_EXTENSION)]
        FOLLOW_UP_EXTENSION,
        [EnumMember(Value = DocConstantStatsRecordName.FRSTUDIES)]
        FRSTUDIES,
        [EnumMember(Value = DocConstantStatsRecordName.HARM)]
        HARM,
        [EnumMember(Value = DocConstantStatsRecordName.INTERVENTIONS)]
        INTERVENTIONS,
        [EnumMember(Value = DocConstantStatsRecordName.MODELING)]
        MODELING,
        [EnumMember(Value = DocConstantStatsRecordName.NON_RANDOMIZED_CONTROLLED_TRIAL)]
        NON_RANDOMIZED_CONTROLLED_TRIAL,
        [EnumMember(Value = DocConstantStatsRecordName.NON_RANDOMIZED_CROSSOVER)]
        NON_RANDOMIZED_CROSSOVER,
        [EnumMember(Value = DocConstantStatsRecordName.NON_RANDOMIZED_NON_CONTROLLED_TRIAL)]
        NON_RANDOMIZED_NON_CONTROLLED_TRIAL,
        [EnumMember(Value = DocConstantStatsRecordName.OTHER)]
        OTHER,
        [EnumMember(Value = DocConstantStatsRecordName.POOLED_ANALYSIS)]
        POOLED_ANALYSIS,
        [EnumMember(Value = DocConstantStatsRecordName.POSTHOC_ANALYSIS)]
        POSTHOC_ANALYSIS,
        [EnumMember(Value = DocConstantStatsRecordName.PREVALENCE)]
        PREVALENCE,
        [EnumMember(Value = DocConstantStatsRecordName.PREVENTION_RISK)]
        PREVENTION_RISK,
        [EnumMember(Value = DocConstantStatsRecordName.PROGNOSIS)]
        PROGNOSIS,
        [EnumMember(Value = DocConstantStatsRecordName.PROSPECTIVE_OBSERVATIONAL)]
        PROSPECTIVE_OBSERVATIONAL,
        [EnumMember(Value = DocConstantStatsRecordName.RANDOMIZED_CONTROLLED_TRIAL)]
        RANDOMIZED_CONTROLLED_TRIAL,
        [EnumMember(Value = DocConstantStatsRecordName.RANDOMIZED_CROSSOVER)]
        RANDOMIZED_CROSSOVER,
        [EnumMember(Value = DocConstantStatsRecordName.RANDOMIZED_NON_CONTROLLED_TRIAL)]
        RANDOMIZED_NON_CONTROLLED_TRIAL,
        [EnumMember(Value = DocConstantStatsRecordName.RETROSPECTIVE_OBSERVATIONAL)]
        RETROSPECTIVE_OBSERVATIONAL,
        [EnumMember(Value = DocConstantStatsRecordName.STUDY_DESIGN_OVERVIEW)]
        STUDY_DESIGN_OVERVIEW,
        [EnumMember(Value = DocConstantStatsRecordName.SUB_GROUP_ANALYSIS)]
        SUB_GROUP_ANALYSIS,
        [EnumMember(Value = DocConstantStatsRecordName.SUBGROUPS)]
        SUBGROUPS,
        [EnumMember(Value = DocConstantStatsRecordName.THERAPY)]
        THERAPY,
        [EnumMember(Value = DocConstantStatsRecordName.TOTALCHARACTERISTICVARIABLES)]
        TOTALCHARACTERISTICVARIABLES,
        [EnumMember(Value = DocConstantStatsRecordName.TOTALCOMPARATIVESTATEMENTS)]
        TOTALCOMPARATIVESTATEMENTS,
        [EnumMember(Value = DocConstantStatsRecordName.TOTALGROUPVARIABLES)]
        TOTALGROUPVARIABLES,
        [EnumMember(Value = DocConstantStatsRecordName.TOTALMAINGROUPS)]
        TOTALMAINGROUPS,
        [EnumMember(Value = DocConstantStatsRecordName.TOTALOUTCOMEITERATIONS)]
        TOTALOUTCOMEITERATIONS,
        [EnumMember(Value = DocConstantStatsRecordName.TOTALOUTCOMEVARIABLES)]
        TOTALOUTCOMEVARIABLES,
        [EnumMember(Value = DocConstantStatsRecordName.TOTALPARTICIPANTS)]
        TOTALPARTICIPANTS,
        [EnumMember(Value = DocConstantStatsRecordName.TOTALSTUDIES)]
        TOTALSTUDIES,
        [EnumMember(Value = DocConstantStatsRecordName.TOTALSTUDYLEVELVARIABLES)]
        TOTALSTUDYLEVELVARIABLES,
        [EnumMember(Value = DocConstantStatsRecordName.TOTALVARIABLES)]
        TOTALVARIABLES,
        [EnumMember(Value = DocConstantStatsRecordName.UNCOLLECTEDCHARACTERISTICVARIABLES)]
        UNCOLLECTEDCHARACTERISTICVARIABLES,
        [EnumMember(Value = DocConstantStatsRecordName.UNCOLLECTEDMAINGROUPS)]
        UNCOLLECTEDMAINGROUPS,
        [EnumMember(Value = DocConstantStatsRecordName.UNCOLLECTEDOUTCOMEVARIABLES)]
        UNCOLLECTEDOUTCOMEVARIABLES
    }
    
    public sealed partial class DocConstantStatsRecordName
    {
        public const string AMBISPECTIVE_OBSERVATIONAL = "Ambispective Observational";
        public const string BOUNDCHARACTERISTICVARIABLES = "Bound Characteristic Variables";
        public const string BOUNDGROUPVARIABLES = "Bound Group Variables";
        public const string BOUNDOUTCOMEITERATIONS = "Bound Outcome Iterations";
        public const string BOUNDOUTCOMEVARIABLES = "Bound Outcome Variables";
        public const string BOUNDSTUDYLEVELVARIABLES = "Bound Study Level Variables";
        public const string BOUNDTOTALVARIABLES = "Bound Total Variables";
        public const string CASE_CONTROL = "Case Control";
        public const string CASE_REPORT = "Case Report";
        public const string CASE_SERIES = "Case Series";
        public const string COLLECTEDCHARACTERISTICVARIABLES = "Collected Characteristic Variables";
        public const string COLLECTEDMAINGROUPS = "Collected MainGroups";
        public const string COLLECTEDOUTCOMEVARIABLES = "Collected Outcome Variables";
        public const string COMPARISONS = "Comparisons";
        public const string CROSS_SECTIONAL = "Cross-Sectional";
        public const string DATAPOINTSAVG = "Data Points Avg";
        public const string DATAPOINTSMAX = "Data Points Max";
        public const string DATAPOINTSTOTAL = "Data Points Total";
        public const string DATASTUDIES = "Data Studies";
        public const string DIAGNOSIS = "Diagnosis";
        public const string FOLLOW_UP_EXTENSION = "Follow-up/Extension";
        public const string FRSTUDIES = "FR Studies";
        public const string HARM = "Harm";
        public const string INTERVENTIONS = "Interventions";
        public const string MODELING = "Modeling";
        public const string NON_RANDOMIZED_CONTROLLED_TRIAL = "Non-Randomized Controlled Trial";
        public const string NON_RANDOMIZED_CROSSOVER = "Non-Randomized Crossover";
        public const string NON_RANDOMIZED_NON_CONTROLLED_TRIAL = "Non-Randomized Non-Controlled Trial";
        public const string OTHER = "Other";
        public const string POOLED_ANALYSIS = "Pooled Analysis";
        public const string POSTHOC_ANALYSIS = "Posthoc Analysis";
        public const string PREVALENCE = "Prevalence";
        public const string PREVENTION_RISK = "Prevention/Risk";
        public const string PROGNOSIS = "Prognosis";
        public const string PROSPECTIVE_OBSERVATIONAL = "Prospective Observational";
        public const string RANDOMIZED_CONTROLLED_TRIAL = "Randomized Controlled Trial";
        public const string RANDOMIZED_CROSSOVER = "Randomized Crossover";
        public const string RANDOMIZED_NON_CONTROLLED_TRIAL = "Randomized Non-Controlled Trial";
        public const string RETROSPECTIVE_OBSERVATIONAL = "Retrospective Observational";
        public const string STUDY_DESIGN_OVERVIEW = "Study Design Overview";
        public const string SUB_GROUP_ANALYSIS = "Sub-Group Analysis";
        public const string SUBGROUPS = "SubGroups";
        public const string THERAPY = "Therapy";
        public const string TOTALCHARACTERISTICVARIABLES = "Total Characteristic Variables";
        public const string TOTALCOMPARATIVESTATEMENTS = "Total Comparative Statements";
        public const string TOTALGROUPVARIABLES = "Total Group Variables";
        public const string TOTALMAINGROUPS = "Total MainGroups";
        public const string TOTALOUTCOMEITERATIONS = "Total Outcome Iterations";
        public const string TOTALOUTCOMEVARIABLES = "Total Outcome Variables";
        public const string TOTALPARTICIPANTS = "Total Participants";
        public const string TOTALSTUDIES = "Total Studies";
        public const string TOTALSTUDYLEVELVARIABLES = "Total Study Level Variables";
        public const string TOTALVARIABLES = "Total Variables";
        public const string UNCOLLECTEDCHARACTERISTICVARIABLES = "Uncollected Characteristic Variables";
        public const string UNCOLLECTEDMAINGROUPS = "Uncollected MainGroups";
        public const string UNCOLLECTEDOUTCOMEVARIABLES = "Uncollected Outcome Variables";
        
        #region Internals
        
        private static List<string> _all;
        
        public static List<string> All => _all ?? (_all = typeof(DocConstantStatsRecordName).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        /// <summary>
        ///    The string value of the current instance
        /// </summary>
        private readonly string Value;

        /// <summary>
        ///    The enum constructor
        /// </summary>
        /// <param name="ItemName">Name of the item.</param>
        private DocConstantStatsRecordName(string ItemName = null)
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
        public static implicit operator DocConstantStatsRecordName(string Val)
        {
            return new DocConstantStatsRecordName(Val);
        }

        /// <summary>
        ///    Implicit cast to string
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator string(DocConstantStatsRecordName item)
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

        #region IEquatable (DocConstantStatsRecordName)

        /// <summary>
        ///    Equals
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Equals(DocConstantStatsRecordName obj)
        {
            return this == obj;
        }

        /// <summary>
        ///    == Equality operator guarantees we're evaluating instance values
        /// </summary>
        /// <param name="ft1">The FT1.</param>
        /// <param name="ft2">The FT2.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(DocConstantStatsRecordName ft1, DocConstantStatsRecordName ft2)
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
        public static bool operator !=(DocConstantStatsRecordName ft1, DocConstantStatsRecordName ft2)
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
            if(!(obj is DocConstantStatsRecordName))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantStatsRecordName) obj;
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

        #endregion IEquatable (DocConstantStatsRecordName)
    }
}
