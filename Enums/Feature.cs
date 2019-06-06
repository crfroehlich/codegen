
//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated by a T4 template. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Reflection;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using Services.Core;

using ServiceStack;

using SCDescript = System.ComponentModel.DescriptionAttribute;
using SCDisplay = System.ComponentModel.DataAnnotations.DisplayAttribute;
using SSDescript = ServiceStack.DataAnnotations.DescriptionAttribute;
namespace Services.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FeatureEnm
    {
        [EnumMember(Value = DocConstantFeature.ACCESS_BACKEND), SCDescript(DocConstantFeature.ACCESS_BACKEND), SSDescript(DocConstantFeature.ACCESS_BACKEND), SCDisplay(Name = DocConstantFeature.ACCESS_BACKEND)]
        ACCESS_BACKEND = 139850787,
        [EnumMember(Value = DocConstantFeature.ALL_ENTITIES), SCDescript(DocConstantFeature.ALL_ENTITIES), SSDescript(DocConstantFeature.ALL_ENTITIES), SCDisplay(Name = DocConstantFeature.ALL_ENTITIES)]
        ALL_ENTITIES = 146157829,
        [EnumMember(Value = DocConstantFeature.ALL_PAGES), SCDescript(DocConstantFeature.ALL_PAGES), SSDescript(DocConstantFeature.ALL_PAGES), SCDisplay(Name = DocConstantFeature.ALL_PAGES)]
        ALL_PAGES = 139850793,
        [EnumMember(Value = DocConstantFeature.ALL_STUDY_SETS), SCDescript(DocConstantFeature.ALL_STUDY_SETS), SSDescript(DocConstantFeature.ALL_STUDY_SETS), SCDisplay(Name = DocConstantFeature.ALL_STUDY_SETS)]
        ALL_STUDY_SETS = 139850794,
        [EnumMember(Value = DocConstantFeature.ALPHA_TESTING), SCDescript(DocConstantFeature.ALPHA_TESTING), SSDescript(DocConstantFeature.ALPHA_TESTING), SCDisplay(Name = DocConstantFeature.ALPHA_TESTING)]
        ALPHA_TESTING = 139850795,
        [EnumMember(Value = DocConstantFeature.AUDITING), SCDescript(DocConstantFeature.AUDITING), SSDescript(DocConstantFeature.AUDITING), SCDisplay(Name = DocConstantFeature.AUDITING)]
        AUDITING = 139850796,
        [EnumMember(Value = DocConstantFeature.BINDINGS_ADMIN), SCDescript(DocConstantFeature.BINDINGS_ADMIN), SSDescript(DocConstantFeature.BINDINGS_ADMIN), SCDisplay(Name = DocConstantFeature.BINDINGS_ADMIN)]
        BINDINGS_ADMIN = 139850797,
        [EnumMember(Value = DocConstantFeature.CLIENT_BINDING), SCDescript(DocConstantFeature.CLIENT_BINDING), SSDescript(DocConstantFeature.CLIENT_BINDING), SCDisplay(Name = DocConstantFeature.CLIENT_BINDING)]
        CLIENT_BINDING = 139850798,
        [EnumMember(Value = DocConstantFeature.CONTRACT_ONBOARDING_REPORT), SCDescript(DocConstantFeature.CONTRACT_ONBOARDING_REPORT), SSDescript(DocConstantFeature.CONTRACT_ONBOARDING_REPORT), SCDisplay(Name = DocConstantFeature.CONTRACT_ONBOARDING_REPORT)]
        CONTRACT_ONBOARDING_REPORT = 139850799,
        [EnumMember(Value = DocConstantFeature.DEBUG), SCDescript(DocConstantFeature.DEBUG), SSDescript(DocConstantFeature.DEBUG), SCDisplay(Name = DocConstantFeature.DEBUG)]
        DEBUG = 139850800,
        [EnumMember(Value = DocConstantFeature.DISPLAY_BROADCASTS), SCDescript(DocConstantFeature.DISPLAY_BROADCASTS), SSDescript(DocConstantFeature.DISPLAY_BROADCASTS), SCDisplay(Name = DocConstantFeature.DISPLAY_BROADCASTS)]
        DISPLAY_BROADCASTS = 139850801,
        [EnumMember(Value = DocConstantFeature.DISPLAY_NOTIFICATIONS), SCDescript(DocConstantFeature.DISPLAY_NOTIFICATIONS), SSDescript(DocConstantFeature.DISPLAY_NOTIFICATIONS), SCDisplay(Name = DocConstantFeature.DISPLAY_NOTIFICATIONS)]
        DISPLAY_NOTIFICATIONS = 139850802,
        [EnumMember(Value = DocConstantFeature.DOCUMENT_SET_ACCESS), SCDescript(DocConstantFeature.DOCUMENT_SET_ACCESS), SSDescript(DocConstantFeature.DOCUMENT_SET_ACCESS), SCDisplay(Name = DocConstantFeature.DOCUMENT_SET_ACCESS)]
        DOCUMENT_SET_ACCESS = 146157830,
        [EnumMember(Value = DocConstantFeature.ERROR_REPORTS), SCDescript(DocConstantFeature.ERROR_REPORTS), SSDescript(DocConstantFeature.ERROR_REPORTS), SCDisplay(Name = DocConstantFeature.ERROR_REPORTS)]
        ERROR_REPORTS = 139850803,
        [EnumMember(Value = DocConstantFeature.EXTRACTION), SCDescript(DocConstantFeature.EXTRACTION), SSDescript(DocConstantFeature.EXTRACTION), SCDisplay(Name = DocConstantFeature.EXTRACTION)]
        EXTRACTION = 139850804,
        [EnumMember(Value = DocConstantFeature.IMPERSONATION), SCDescript(DocConstantFeature.IMPERSONATION), SSDescript(DocConstantFeature.IMPERSONATION), SCDisplay(Name = DocConstantFeature.IMPERSONATION)]
        IMPERSONATION = 139850805,
        [EnumMember(Value = DocConstantFeature.LIVE_CHAT), SCDescript(DocConstantFeature.LIVE_CHAT), SSDescript(DocConstantFeature.LIVE_CHAT), SCDisplay(Name = DocConstantFeature.LIVE_CHAT)]
        LIVE_CHAT = 139850806,
        [EnumMember(Value = DocConstantFeature.PRODUCTION_REPORT), SCDescript(DocConstantFeature.PRODUCTION_REPORT), SSDescript(DocConstantFeature.PRODUCTION_REPORT), SCDisplay(Name = DocConstantFeature.PRODUCTION_REPORT)]
        PRODUCTION_REPORT = 139850807,
        [EnumMember(Value = DocConstantFeature.PRODUCTION_RESET), SCDescript(DocConstantFeature.PRODUCTION_RESET), SSDescript(DocConstantFeature.PRODUCTION_RESET), SCDisplay(Name = DocConstantFeature.PRODUCTION_RESET)]
        PRODUCTION_RESET = 139850808,
        [EnumMember(Value = DocConstantFeature.PROTOCOL_ADMIN), SCDescript(DocConstantFeature.PROTOCOL_ADMIN), SSDescript(DocConstantFeature.PROTOCOL_ADMIN), SCDisplay(Name = DocConstantFeature.PROTOCOL_ADMIN)]
        PROTOCOL_ADMIN = 139850809,
        [EnumMember(Value = DocConstantFeature.QC), SCDescript(DocConstantFeature.QC), SSDescript(DocConstantFeature.QC), SCDisplay(Name = DocConstantFeature.QC)]
        QC = 139850810,
        [EnumMember(Value = DocConstantFeature.RELEVANCE_RATING), SCDescript(DocConstantFeature.RELEVANCE_RATING), SSDescript(DocConstantFeature.RELEVANCE_RATING), SCDisplay(Name = DocConstantFeature.RELEVANCE_RATING)]
        RELEVANCE_RATING = 139850811,
        [EnumMember(Value = DocConstantFeature.RISK_OF_BIAS), SCDescript(DocConstantFeature.RISK_OF_BIAS), SSDescript(DocConstantFeature.RISK_OF_BIAS), SCDisplay(Name = DocConstantFeature.RISK_OF_BIAS)]
        RISK_OF_BIAS = 146157831,
        [EnumMember(Value = DocConstantFeature.SALESFORCE_DATA), SCDescript(DocConstantFeature.SALESFORCE_DATA), SSDescript(DocConstantFeature.SALESFORCE_DATA), SCDisplay(Name = DocConstantFeature.SALESFORCE_DATA)]
        SALESFORCE_DATA = 139850812,
        [EnumMember(Value = DocConstantFeature.SHARING), SCDescript(DocConstantFeature.SHARING), SSDescript(DocConstantFeature.SHARING), SCDisplay(Name = DocConstantFeature.SHARING)]
        SHARING = 146157832,
        [EnumMember(Value = DocConstantFeature.SUBMIT_FEEDBACK), SCDescript(DocConstantFeature.SUBMIT_FEEDBACK), SSDescript(DocConstantFeature.SUBMIT_FEEDBACK), SCDisplay(Name = DocConstantFeature.SUBMIT_FEEDBACK)]
        SUBMIT_FEEDBACK = 139850816,
        [EnumMember(Value = DocConstantFeature.TERMS_ADMIN), SCDescript(DocConstantFeature.TERMS_ADMIN), SSDescript(DocConstantFeature.TERMS_ADMIN), SCDisplay(Name = DocConstantFeature.TERMS_ADMIN)]
        TERMS_ADMIN = 139850817,
        [EnumMember(Value = DocConstantFeature.WORKFLOW_ACCESS), SCDescript(DocConstantFeature.WORKFLOW_ACCESS), SSDescript(DocConstantFeature.WORKFLOW_ACCESS), SCDisplay(Name = DocConstantFeature.WORKFLOW_ACCESS)]
        WORKFLOW_ACCESS = 146157833
    }
    
    public static partial class EnumExtensions
    {
        public static string ToEnumString(this FeatureEnm instance)
        {
            switch(instance)
            {
                case FeatureEnm.ACCESS_BACKEND:
                    return DocConstantFeature.ACCESS_BACKEND;
                case FeatureEnm.ALL_ENTITIES:
                    return DocConstantFeature.ALL_ENTITIES;
                case FeatureEnm.ALL_PAGES:
                    return DocConstantFeature.ALL_PAGES;
                case FeatureEnm.ALL_STUDY_SETS:
                    return DocConstantFeature.ALL_STUDY_SETS;
                case FeatureEnm.ALPHA_TESTING:
                    return DocConstantFeature.ALPHA_TESTING;
                case FeatureEnm.AUDITING:
                    return DocConstantFeature.AUDITING;
                case FeatureEnm.BINDINGS_ADMIN:
                    return DocConstantFeature.BINDINGS_ADMIN;
                case FeatureEnm.CLIENT_BINDING:
                    return DocConstantFeature.CLIENT_BINDING;
                case FeatureEnm.CONTRACT_ONBOARDING_REPORT:
                    return DocConstantFeature.CONTRACT_ONBOARDING_REPORT;
                case FeatureEnm.DEBUG:
                    return DocConstantFeature.DEBUG;
                case FeatureEnm.DISPLAY_BROADCASTS:
                    return DocConstantFeature.DISPLAY_BROADCASTS;
                case FeatureEnm.DISPLAY_NOTIFICATIONS:
                    return DocConstantFeature.DISPLAY_NOTIFICATIONS;
                case FeatureEnm.DOCUMENT_SET_ACCESS:
                    return DocConstantFeature.DOCUMENT_SET_ACCESS;
                case FeatureEnm.ERROR_REPORTS:
                    return DocConstantFeature.ERROR_REPORTS;
                case FeatureEnm.EXTRACTION:
                    return DocConstantFeature.EXTRACTION;
                case FeatureEnm.IMPERSONATION:
                    return DocConstantFeature.IMPERSONATION;
                case FeatureEnm.LIVE_CHAT:
                    return DocConstantFeature.LIVE_CHAT;
                case FeatureEnm.PRODUCTION_REPORT:
                    return DocConstantFeature.PRODUCTION_REPORT;
                case FeatureEnm.PRODUCTION_RESET:
                    return DocConstantFeature.PRODUCTION_RESET;
                case FeatureEnm.PROTOCOL_ADMIN:
                    return DocConstantFeature.PROTOCOL_ADMIN;
                case FeatureEnm.QC:
                    return DocConstantFeature.QC;
                case FeatureEnm.RELEVANCE_RATING:
                    return DocConstantFeature.RELEVANCE_RATING;
                case FeatureEnm.RISK_OF_BIAS:
                    return DocConstantFeature.RISK_OF_BIAS;
                case FeatureEnm.SALESFORCE_DATA:
                    return DocConstantFeature.SALESFORCE_DATA;
                case FeatureEnm.SHARING:
                    return DocConstantFeature.SHARING;
                case FeatureEnm.SUBMIT_FEEDBACK:
                    return DocConstantFeature.SUBMIT_FEEDBACK;
                case FeatureEnm.TERMS_ADMIN:
                    return DocConstantFeature.TERMS_ADMIN;
                case FeatureEnm.WORKFLOW_ACCESS:
                    return DocConstantFeature.WORKFLOW_ACCESS;
                default:
                    return string.Empty;
            }
        }

        public static string ToEnumString(this FeatureEnm? instance)
        {
            if(null == instance) return string.Empty;
            return instance.Value.ToEnumString();
        }
    }

    public sealed partial class DocConstantFeature : IEquatable<DocConstantFeature>, IEqualityComparer<DocConstantFeature>
    {
        public const string ACCESS_BACKEND = "Access Doc Data Backend";
        public const string ALL_ENTITIES = "All Entities";
        public const string ALL_PAGES = "All Pages";
        public const string ALL_STUDY_SETS = "All Study Sets";
        public const string ALPHA_TESTING = "Alpha Testing";
        public const string AUDITING = "Auditing";
        public const string BINDINGS_ADMIN = "Bindings Admin";
        public const string CLIENT_BINDING = "Client Binding";
        public const string CONTRACT_ONBOARDING_REPORT = "Contract Onboarding Report";
        public const string DEBUG = "Debug";
        public const string DISPLAY_BROADCASTS = "Display Broadcasts";
        public const string DISPLAY_NOTIFICATIONS = "Display Notifications";
        public const string DOCUMENT_SET_ACCESS = "Document Set Access";
        public const string ERROR_REPORTS = "Error Reports";
        public const string EXTRACTION = "Extraction";
        public const string IMPERSONATION = "Impersonation";
        public const string LIVE_CHAT = "Live Chat";
        public const string PRODUCTION_REPORT = "Production Report";
        public const string PRODUCTION_RESET = "Production Reset";
        public const string PROTOCOL_ADMIN = "Protocol Admin";
        public const string QC = "QC";
        public const string RELEVANCE_RATING = "Relevance Rating";
        public const string RISK_OF_BIAS = "Risk of Bias";
        public const string SALESFORCE_DATA = "Salesforce Data";
        public const string SHARING = "Sharing";
        public const string SUBMIT_FEEDBACK = "Submit Feedback";
        public const string TERMS_ADMIN = "Master Terms Admin";
        public const string WORKFLOW_ACCESS = "Workflow Access";
        
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantFeature).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantFeature(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantFeature(string Val) => new DocConstantFeature(Val);

        public static implicit operator string(DocConstantFeature item) => item?.Value ?? string.Empty;
        
        public static explicit operator DocConstantFeature(FeatureEnm Val) => new DocConstantFeature(Val.ToEnumString());

        public static explicit operator FeatureEnm(DocConstantFeature item)
        {
            Enum.TryParse<FeatureEnm>(item.ToString(), true, out var tryRet);
            return tryRet;
        }

        public override string ToString() => Value;



        public bool Equals(DocConstantFeature obj) => this == obj;

        public static bool operator ==(DocConstantFeature x, DocConstantFeature y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        
        public bool Equals(DocConstantFeature x, DocConstantFeature y) => x == y;
        
        public static bool operator !=(DocConstantFeature x, DocConstantFeature y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantFeature))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantFeature) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
                
        public int GetHashCode(DocConstantFeature obj) => obj?.GetHashCode() ?? -17;

    }
}
