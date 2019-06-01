
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
    public enum WorkflowStatusEnm
    {
        [EnumMember(Value = DocConstantWorkflowStatus.ACCEPTED), SCDescript(DocConstantWorkflowStatus.ACCEPTED), SSDescript(DocConstantWorkflowStatus.ACCEPTED), SCDisplay(Name = DocConstantWorkflowStatus.ACCEPTED)]
        ACCEPTED = 150786181,
        [EnumMember(Value = DocConstantWorkflowStatus.COLLECTED), SCDescript(DocConstantWorkflowStatus.COLLECTED), SSDescript(DocConstantWorkflowStatus.COLLECTED), SCDisplay(Name = DocConstantWorkflowStatus.COLLECTED)]
        COLLECTED = 150786183,
        [EnumMember(Value = DocConstantWorkflowStatus.REJECTED), SCDescript(DocConstantWorkflowStatus.REJECTED), SSDescript(DocConstantWorkflowStatus.REJECTED), SCDisplay(Name = DocConstantWorkflowStatus.REJECTED)]
        REJECTED = 150786182,
        [EnumMember(Value = DocConstantWorkflowStatus.REQUESTED), SCDescript(DocConstantWorkflowStatus.REQUESTED), SSDescript(DocConstantWorkflowStatus.REQUESTED), SCDisplay(Name = DocConstantWorkflowStatus.REQUESTED)]
        REQUESTED = 150786184,
        [EnumMember(Value = DocConstantWorkflowStatus.UNAVAILABLE), SCDescript(DocConstantWorkflowStatus.UNAVAILABLE), SSDescript(DocConstantWorkflowStatus.UNAVAILABLE), SCDisplay(Name = DocConstantWorkflowStatus.UNAVAILABLE)]
        UNAVAILABLE = 150786185
    }
    
    public static partial class EnumExtensions
    {
        public static string ToEnumString(this WorkflowStatusEnm instance)
        {
            switch(instance)
            {
                case WorkflowStatusEnm.ACCEPTED:
                    return DocConstantWorkflowStatus.ACCEPTED;
                case WorkflowStatusEnm.COLLECTED:
                    return DocConstantWorkflowStatus.COLLECTED;
                case WorkflowStatusEnm.REJECTED:
                    return DocConstantWorkflowStatus.REJECTED;
                case WorkflowStatusEnm.REQUESTED:
                    return DocConstantWorkflowStatus.REQUESTED;
                case WorkflowStatusEnm.UNAVAILABLE:
                    return DocConstantWorkflowStatus.UNAVAILABLE;
                default:
                    return string.Empty;
            }
        }

        public static string ToEnumString(this WorkflowStatusEnm? instance)
        {
            if(null == instance) return string.Empty;
            return instance.Value.ToEnumString();
        }
    }

    public sealed partial class DocConstantWorkflowStatus : IEquatable<DocConstantWorkflowStatus>, IEqualityComparer<DocConstantWorkflowStatus>
    {
        public const string ACCEPTED = "Accepted";
        public const string COLLECTED = "Collected";
        public const string REJECTED = "Rejected";
        public const string REQUESTED = "Requested";
        public const string UNAVAILABLE = "Unavailable";
        
        #region Internals
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantWorkflowStatus).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantWorkflowStatus(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantWorkflowStatus(string Val) => new DocConstantWorkflowStatus(Val);

        public static implicit operator string(DocConstantWorkflowStatus item) => item?.Value ?? string.Empty;
        
        public static explicit operator DocConstantWorkflowStatus(WorkflowStatusEnm Val) => new DocConstantWorkflowStatus(Val.ToEnumString());

        public static explicit operator WorkflowStatusEnm(DocConstantWorkflowStatus item)
        {
            Enum.TryParse<WorkflowStatusEnm>(item.ToString(), true, out var tryRet);
            return tryRet;
        }

        public override string ToString() => Value;

        #endregion Internals

        #region IEquatable

        public bool Equals(DocConstantWorkflowStatus obj) => this == obj;

        public static bool operator ==(DocConstantWorkflowStatus x, DocConstantWorkflowStatus y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        
        public bool Equals(DocConstantWorkflowStatus x, DocConstantWorkflowStatus y) => x == y;
        
        public static bool operator !=(DocConstantWorkflowStatus x, DocConstantWorkflowStatus y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantWorkflowStatus))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantWorkflowStatus) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
                
        public int GetHashCode(DocConstantWorkflowStatus obj) => obj?.GetHashCode() ?? -17;

        #endregion IEquatable
    }
}
