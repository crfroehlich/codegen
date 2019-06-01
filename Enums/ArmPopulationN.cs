
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
    public enum ArmPopulationNEnm
    {
        [EnumMember(Value = DocConstantArmPopulationN.COMPLETED), SCDescript(DocConstantArmPopulationN.COMPLETED), SSDescript(DocConstantArmPopulationN.COMPLETED), SCDisplay(Name = DocConstantArmPopulationN.COMPLETED)]
        COMPLETED = 183,
        [EnumMember(Value = DocConstantArmPopulationN.CROSSOVER), SCDescript(DocConstantArmPopulationN.CROSSOVER), SSDescript(DocConstantArmPopulationN.CROSSOVER), SCDisplay(Name = DocConstantArmPopulationN.CROSSOVER)]
        CROSSOVER = 188,
        [EnumMember(Value = DocConstantArmPopulationN.ENROLLED), SCDescript(DocConstantArmPopulationN.ENROLLED), SSDescript(DocConstantArmPopulationN.ENROLLED), SCDisplay(Name = DocConstantArmPopulationN.ENROLLED)]
        ENROLLED = 193,
        [EnumMember(Value = DocConstantArmPopulationN.INITIATED_STUDY), SCDescript(DocConstantArmPopulationN.INITIATED_STUDY), SSDescript(DocConstantArmPopulationN.INITIATED_STUDY), SCDisplay(Name = DocConstantArmPopulationN.INITIATED_STUDY)]
        INITIATED_STUDY = 198,
        [EnumMember(Value = DocConstantArmPopulationN.ITT), SCDescript(DocConstantArmPopulationN.ITT), SSDescript(DocConstantArmPopulationN.ITT), SCDisplay(Name = DocConstantArmPopulationN.ITT)]
        ITT = 203,
        [EnumMember(Value = DocConstantArmPopulationN.MODIFIED_ITT), SCDescript(DocConstantArmPopulationN.MODIFIED_ITT), SSDescript(DocConstantArmPopulationN.MODIFIED_ITT), SCDisplay(Name = DocConstantArmPopulationN.MODIFIED_ITT)]
        MODIFIED_ITT = 208,
        [EnumMember(Value = DocConstantArmPopulationN.PARTICIPANTS), SCDescript(DocConstantArmPopulationN.PARTICIPANTS), SSDescript(DocConstantArmPopulationN.PARTICIPANTS), SCDisplay(Name = DocConstantArmPopulationN.PARTICIPANTS)]
        PARTICIPANTS = 213,
        [EnumMember(Value = DocConstantArmPopulationN.PP), SCDescript(DocConstantArmPopulationN.PP), SSDescript(DocConstantArmPopulationN.PP), SCDisplay(Name = DocConstantArmPopulationN.PP)]
        PP = 218,
        [EnumMember(Value = DocConstantArmPopulationN.RANDOMIZED), SCDescript(DocConstantArmPopulationN.RANDOMIZED), SSDescript(DocConstantArmPopulationN.RANDOMIZED), SCDisplay(Name = DocConstantArmPopulationN.RANDOMIZED)]
        RANDOMIZED = 223,
        [EnumMember(Value = DocConstantArmPopulationN.RECRUITED), SCDescript(DocConstantArmPopulationN.RECRUITED), SSDescript(DocConstantArmPopulationN.RECRUITED), SCDisplay(Name = DocConstantArmPopulationN.RECRUITED)]
        RECRUITED = 228,
        [EnumMember(Value = DocConstantArmPopulationN.SAFETY), SCDescript(DocConstantArmPopulationN.SAFETY), SSDescript(DocConstantArmPopulationN.SAFETY), SCDisplay(Name = DocConstantArmPopulationN.SAFETY)]
        SAFETY = 233,
        [EnumMember(Value = DocConstantArmPopulationN.SCREENED), SCDescript(DocConstantArmPopulationN.SCREENED), SSDescript(DocConstantArmPopulationN.SCREENED), SCDisplay(Name = DocConstantArmPopulationN.SCREENED)]
        SCREENED = 238
    }
    
    public static partial class EnumExtensions
    {
        public static string ToEnumString(this ArmPopulationNEnm instance)
        {
            switch(instance)
            {
                case ArmPopulationNEnm.COMPLETED:
                    return DocConstantArmPopulationN.COMPLETED;
                case ArmPopulationNEnm.CROSSOVER:
                    return DocConstantArmPopulationN.CROSSOVER;
                case ArmPopulationNEnm.ENROLLED:
                    return DocConstantArmPopulationN.ENROLLED;
                case ArmPopulationNEnm.INITIATED_STUDY:
                    return DocConstantArmPopulationN.INITIATED_STUDY;
                case ArmPopulationNEnm.ITT:
                    return DocConstantArmPopulationN.ITT;
                case ArmPopulationNEnm.MODIFIED_ITT:
                    return DocConstantArmPopulationN.MODIFIED_ITT;
                case ArmPopulationNEnm.PARTICIPANTS:
                    return DocConstantArmPopulationN.PARTICIPANTS;
                case ArmPopulationNEnm.PP:
                    return DocConstantArmPopulationN.PP;
                case ArmPopulationNEnm.RANDOMIZED:
                    return DocConstantArmPopulationN.RANDOMIZED;
                case ArmPopulationNEnm.RECRUITED:
                    return DocConstantArmPopulationN.RECRUITED;
                case ArmPopulationNEnm.SAFETY:
                    return DocConstantArmPopulationN.SAFETY;
                case ArmPopulationNEnm.SCREENED:
                    return DocConstantArmPopulationN.SCREENED;
                default:
                    return string.Empty;
            }
        }

        public static string ToEnumString(this ArmPopulationNEnm? instance)
        {
            if(null == instance) return string.Empty;
            return instance.Value.ToEnumString();
        }
    }

    public sealed partial class DocConstantArmPopulationN : IEquatable<DocConstantArmPopulationN>, IEqualityComparer<DocConstantArmPopulationN>
    {
        public const string COMPLETED = "Completed/Finished";
        public const string CROSSOVER = "Crossover";
        public const string ENROLLED = "Enrolled";
        public const string INITIATED_STUDY = "Initiated Study";
        public const string ITT = "ITT";
        public const string MODIFIED_ITT = "Modified ITT";
        public const string PARTICIPANTS = "Participants";
        public const string PP = "PP";
        public const string RANDOMIZED = "Randomized";
        public const string RECRUITED = "Recruited";
        public const string SAFETY = "Safety";
        public const string SCREENED = "Screened";
        
        #region Internals
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantArmPopulationN).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantArmPopulationN(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantArmPopulationN(string Val) => new DocConstantArmPopulationN(Val);

        public static implicit operator string(DocConstantArmPopulationN item) => item?.Value ?? string.Empty;
        
        public static explicit operator DocConstantArmPopulationN(ArmPopulationNEnm Val) => new DocConstantArmPopulationN(Val.ToEnumString());

        public static explicit operator ArmPopulationNEnm(DocConstantArmPopulationN item)
        {
            Enum.TryParse<ArmPopulationNEnm>(item.ToString(), true, out var tryRet);
            return tryRet;
        }

        public override string ToString() => Value;

        #endregion Internals

        #region IEquatable

        public bool Equals(DocConstantArmPopulationN obj) => this == obj;

        public static bool operator ==(DocConstantArmPopulationN x, DocConstantArmPopulationN y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        
        public bool Equals(DocConstantArmPopulationN x, DocConstantArmPopulationN y) => x == y;
        
        public static bool operator !=(DocConstantArmPopulationN x, DocConstantArmPopulationN y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantArmPopulationN))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantArmPopulationN) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
                
        public int GetHashCode(DocConstantArmPopulationN obj) => obj?.GetHashCode() ?? -17;

        #endregion IEquatable
    }
}
