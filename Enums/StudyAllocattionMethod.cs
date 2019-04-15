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
    public enum StudyAllocattionMethodEnm
    {
        [EnumMember(Value = DocConstantStudyAllocattionMethod.OPAQUE_ENVELOPES)]
        OPAQUE_ENVELOPES,
        [EnumMember(Value = DocConstantStudyAllocattionMethod.RANDOM_NUMBER_GENERATOR)]
        RANDOM_NUMBER_GENERATOR,
        [EnumMember(Value = DocConstantStudyAllocattionMethod.ROLLING_DICE)]
        ROLLING_DICE,
        [EnumMember(Value = DocConstantStudyAllocattionMethod.SEQUENCE_ALLOCATION)]
        SEQUENCE_ALLOCATION
    }
    
    public static partial class EnumExtensions
    {
        public static string ToEnumString(this StudyAllocattionMethodEnm instance)
        {
            switch(instance) 
            {
                case StudyAllocattionMethodEnm.OPAQUE_ENVELOPES:
                    return DocConstantStudyAllocattionMethod.OPAQUE_ENVELOPES;
                case StudyAllocattionMethodEnm.RANDOM_NUMBER_GENERATOR:
                    return DocConstantStudyAllocattionMethod.RANDOM_NUMBER_GENERATOR;
                case StudyAllocattionMethodEnm.ROLLING_DICE:
                    return DocConstantStudyAllocattionMethod.ROLLING_DICE;
                case StudyAllocattionMethodEnm.SEQUENCE_ALLOCATION:
                    return DocConstantStudyAllocattionMethod.SEQUENCE_ALLOCATION;
                default:
                    return string.Empty;
            }
        }
    }

    public sealed partial class DocConstantStudyAllocattionMethod : IEquatable<DocConstantStudyAllocattionMethod>, IEqualityComparer<DocConstantStudyAllocattionMethod>
    {
        public const string OPAQUE_ENVELOPES = "Opaque Envelopes";
        public const string RANDOM_NUMBER_GENERATOR = "Random Number Generator";
        public const string ROLLING_DICE = "Rolling Dice";
        public const string SEQUENCE_ALLOCATION = "Sequence Allocation";
        
        #region Internals
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantStudyAllocattionMethod).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantStudyAllocattionMethod(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantStudyAllocattionMethod(string Val) => new DocConstantStudyAllocattionMethod(Val);

        public static implicit operator string(DocConstantStudyAllocattionMethod item) => item?.Value ?? string.Empty;

        public override string ToString() => Value;

        #endregion Internals

        #region IEquatable

        public bool Equals(DocConstantStudyAllocattionMethod obj) => this == obj;

        public static bool operator ==(DocConstantStudyAllocattionMethod x, DocConstantStudyAllocattionMethod y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        
        public bool Equals(DocConstantStudyAllocattionMethod x, DocConstantStudyAllocattionMethod y) => x == y;
        
        public static bool operator !=(DocConstantStudyAllocattionMethod x, DocConstantStudyAllocattionMethod y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantStudyAllocattionMethod))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantStudyAllocattionMethod) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
                
        public int GetHashCode(DocConstantStudyAllocattionMethod obj) => obj?.GetHashCode() ?? -17;

        #endregion IEquatable
    }
}
