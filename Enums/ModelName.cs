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
    public enum ModelNameEnm
    {
        [EnumMember(Value = DocConstantModelName.APP)]
        APP,
        [EnumMember(Value = DocConstantModelName.ATTRIBUTE)]
        ATTRIBUTE,
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
        [EnumMember(Value = DocConstantModelName.DATACLASS)]
        DATACLASS,
        [EnumMember(Value = DocConstantModelName.DATAPROPERTY)]
        DATAPROPERTY,
        [EnumMember(Value = DocConstantModelName.DATATAB)]
        DATATAB,
        [EnumMember(Value = DocConstantModelName.DATETIME)]
        DATETIME,
        [EnumMember(Value = DocConstantModelName.DEFAULT)]
        DEFAULT,
        [EnumMember(Value = DocConstantModelName.DIVISION)]
        DIVISION,
        [EnumMember(Value = DocConstantModelName.DOCUMENT)]
        DOCUMENT,
        [EnumMember(Value = DocConstantModelName.DOCUMENTSET)]
        DOCUMENTSET,
        [EnumMember(Value = DocConstantModelName.DOCUMENTSETHISTORY)]
        DOCUMENTSETHISTORY,
        [EnumMember(Value = DocConstantModelName.ENTITIES)]
        ENTITIES,
        [EnumMember(Value = DocConstantModelName.EVENT)]
        EVENT,
        [EnumMember(Value = DocConstantModelName.FEATURESET)]
        FEATURESET,
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
    
    public static partial class EnumExtensions
    {
        public static string ToEnumString(this ModelNameEnm instance)
        {
            switch(instance) 
            {
                case ModelNameEnm.APP:
                    return DocConstantModelName.APP;
                case ModelNameEnm.ATTRIBUTE:
                    return DocConstantModelName.ATTRIBUTE;
                case ModelNameEnm.ATTRIBUTEINTERVAL:
                    return DocConstantModelName.ATTRIBUTEINTERVAL;
                case ModelNameEnm.AUDITDELTA:
                    return DocConstantModelName.AUDITDELTA;
                case ModelNameEnm.AUDITRECORD:
                    return DocConstantModelName.AUDITRECORD;
                case ModelNameEnm.BACKGROUNDTASK:
                    return DocConstantModelName.BACKGROUNDTASK;
                case ModelNameEnm.BACKGROUNDTASKHISTORY:
                    return DocConstantModelName.BACKGROUNDTASKHISTORY;
                case ModelNameEnm.BACKGROUNDTASKITEM:
                    return DocConstantModelName.BACKGROUNDTASKITEM;
                case ModelNameEnm.BROADCAST:
                    return DocConstantModelName.BROADCAST;
                case ModelNameEnm.CHARACTERISTIC:
                    return DocConstantModelName.CHARACTERISTIC;
                case ModelNameEnm.CLIENT:
                    return DocConstantModelName.CLIENT;
                case ModelNameEnm.COMPARATOR:
                    return DocConstantModelName.COMPARATOR;
                case ModelNameEnm.DATABASEVERSION:
                    return DocConstantModelName.DATABASEVERSION;
                case ModelNameEnm.DATACLASS:
                    return DocConstantModelName.DATACLASS;
                case ModelNameEnm.DATAPROPERTY:
                    return DocConstantModelName.DATAPROPERTY;
                case ModelNameEnm.DATATAB:
                    return DocConstantModelName.DATATAB;
                case ModelNameEnm.DATETIME:
                    return DocConstantModelName.DATETIME;
                case ModelNameEnm.DEFAULT:
                    return DocConstantModelName.DEFAULT;
                case ModelNameEnm.DIVISION:
                    return DocConstantModelName.DIVISION;
                case ModelNameEnm.DOCUMENT:
                    return DocConstantModelName.DOCUMENT;
                case ModelNameEnm.DOCUMENTSET:
                    return DocConstantModelName.DOCUMENTSET;
                case ModelNameEnm.DOCUMENTSETHISTORY:
                    return DocConstantModelName.DOCUMENTSETHISTORY;
                case ModelNameEnm.ENTITIES:
                    return DocConstantModelName.ENTITIES;
                case ModelNameEnm.EVENT:
                    return DocConstantModelName.EVENT;
                case ModelNameEnm.FEATURESET:
                    return DocConstantModelName.FEATURESET;
                case ModelNameEnm.GLOSSARY:
                    return DocConstantModelName.GLOSSARY;
                case ModelNameEnm.HELP:
                    return DocConstantModelName.HELP;
                case ModelNameEnm.HISTORY:
                    return DocConstantModelName.HISTORY;
                case ModelNameEnm.IMPERSONATION:
                    return DocConstantModelName.IMPERSONATION;
                case ModelNameEnm.IMPORTDATA:
                    return DocConstantModelName.IMPORTDATA;
                case ModelNameEnm.INTERVAL:
                    return DocConstantModelName.INTERVAL;
                case ModelNameEnm.INTERVENTION:
                    return DocConstantModelName.INTERVENTION;
                case ModelNameEnm.JUNCTION:
                    return DocConstantModelName.JUNCTION;
                case ModelNameEnm.LOCALE:
                    return DocConstantModelName.LOCALE;
                case ModelNameEnm.LOCALELOOKUP:
                    return DocConstantModelName.LOCALELOOKUP;
                case ModelNameEnm.LOOKUPCATEGORY:
                    return DocConstantModelName.LOOKUPCATEGORY;
                case ModelNameEnm.LOOKUPTABLE:
                    return DocConstantModelName.LOOKUPTABLE;
                case ModelNameEnm.LOOKUPTABLEBINDING:
                    return DocConstantModelName.LOOKUPTABLEBINDING;
                case ModelNameEnm.LOOKUPTABLEENUM:
                    return DocConstantModelName.LOOKUPTABLEENUM;
                case ModelNameEnm.MEANRANGES:
                    return DocConstantModelName.MEANRANGES;
                case ModelNameEnm.MEANRANGEVALUE:
                    return DocConstantModelName.MEANRANGEVALUE;
                case ModelNameEnm.MEANVARIANCES:
                    return DocConstantModelName.MEANVARIANCES;
                case ModelNameEnm.MEANVARIANCEVALUE:
                    return DocConstantModelName.MEANVARIANCEVALUE;
                case ModelNameEnm.OUTCOME:
                    return DocConstantModelName.OUTCOME;
                case ModelNameEnm.PAGE:
                    return DocConstantModelName.PAGE;
                case ModelNameEnm.PROJECT:
                    return DocConstantModelName.PROJECT;
                case ModelNameEnm.QUEUECHANNEL:
                    return DocConstantModelName.QUEUECHANNEL;
                case ModelNameEnm.RELEASESTATUS:
                    return DocConstantModelName.RELEASESTATUS;
                case ModelNameEnm.ROLE:
                    return DocConstantModelName.ROLE;
                case ModelNameEnm.SCOPE:
                    return DocConstantModelName.SCOPE;
                case ModelNameEnm.STATS:
                    return DocConstantModelName.STATS;
                case ModelNameEnm.STATSRECORD:
                    return DocConstantModelName.STATSRECORD;
                case ModelNameEnm.STATSSTUDYSET:
                    return DocConstantModelName.STATSSTUDYSET;
                case ModelNameEnm.STUDYDESIGN:
                    return DocConstantModelName.STUDYDESIGN;
                case ModelNameEnm.STUDYTYPE:
                    return DocConstantModelName.STUDYTYPE;
                case ModelNameEnm.TAG:
                    return DocConstantModelName.TAG;
                case ModelNameEnm.TEAM:
                    return DocConstantModelName.TEAM;
                case ModelNameEnm.TERMCATEGORY:
                    return DocConstantModelName.TERMCATEGORY;
                case ModelNameEnm.TERMMASTER:
                    return DocConstantModelName.TERMMASTER;
                case ModelNameEnm.TERMSYNONYM:
                    return DocConstantModelName.TERMSYNONYM;
                case ModelNameEnm.TIMECARD:
                    return DocConstantModelName.TIMECARD;
                case ModelNameEnm.TIMEPOINT:
                    return DocConstantModelName.TIMEPOINT;
                case ModelNameEnm.UNITCONVERSIONRULES:
                    return DocConstantModelName.UNITCONVERSIONRULES;
                case ModelNameEnm.UNITOFMEASURE:
                    return DocConstantModelName.UNITOFMEASURE;
                case ModelNameEnm.UNITS:
                    return DocConstantModelName.UNITS;
                case ModelNameEnm.UNITVALUE:
                    return DocConstantModelName.UNITVALUE;
                case ModelNameEnm.UPDATE:
                    return DocConstantModelName.UPDATE;
                case ModelNameEnm.USER:
                    return DocConstantModelName.USER;
                case ModelNameEnm.USERREQUEST:
                    return DocConstantModelName.USERREQUEST;
                case ModelNameEnm.USERSESSION:
                    return DocConstantModelName.USERSESSION;
                case ModelNameEnm.USERTYPE:
                    return DocConstantModelName.USERTYPE;
                case ModelNameEnm.VALUETYPE:
                    return DocConstantModelName.VALUETYPE;
                case ModelNameEnm.VARIABLEINSTANCE:
                    return DocConstantModelName.VARIABLEINSTANCE;
                case ModelNameEnm.VARIABLERULE:
                    return DocConstantModelName.VARIABLERULE;
                case ModelNameEnm.WORKFLOW:
                    return DocConstantModelName.WORKFLOW;
                case ModelNameEnm.WORKFLOWCOMMENT:
                    return DocConstantModelName.WORKFLOWCOMMENT;
                case ModelNameEnm.WORKFLOWTASK:
                    return DocConstantModelName.WORKFLOWTASK;
                default:
                    return string.Empty;
            }
        }
    }

    public sealed partial class DocConstantModelName : IEquatable<DocConstantModelName>, IEqualityComparer<DocConstantModelName>
    {
        public const string APP = "App";
        public const string ATTRIBUTE = "Attribute";
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
        public const string DATACLASS = "DataClass";
        public const string DATAPROPERTY = "DataProperty";
        public const string DATATAB = "DataTab";
        public const string DATETIME = "DateTime";
        public const string DEFAULT = "Default";
        public const string DIVISION = "Division";
        public const string DOCUMENT = "Document";
        public const string DOCUMENTSET = "DocumentSet";
        public const string DOCUMENTSETHISTORY = "DocumentSetHistory";
        public const string ENTITIES = "Entities";
        public const string EVENT = "Event";
        public const string FEATURESET = "FeatureSet";
        public const string GLOSSARY = "Glossary";
        public const string HELP = "Help";
        public const string HISTORY = "History";
        public const string IMPERSONATION = "Impersonation";
        public const string IMPORTDATA = "ImportData";
        public const string INTERVAL = "Interval";
        public const string INTERVENTION = "Intervention";
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
        public static List<string> All => _all ?? (_all = typeof(DocConstantModelName).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantModelName(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantModelName(string Val) => new DocConstantModelName(Val);

        public static implicit operator string(DocConstantModelName item) => item?.Value ?? string.Empty;

        public override string ToString() => Value;

        #endregion Internals

        #region IEquatable

        public bool Equals(DocConstantModelName obj) => this == obj;

        public static bool operator ==(DocConstantModelName x, DocConstantModelName y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        
        public bool Equals(DocConstantModelName x, DocConstantModelName y) => x == y;
        
        public static bool operator !=(DocConstantModelName x, DocConstantModelName y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantModelName))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantModelName) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
                
        public int GetHashCode(DocConstantModelName obj) => obj?.GetHashCode() ?? -17;

        #endregion IEquatable
    }
}
