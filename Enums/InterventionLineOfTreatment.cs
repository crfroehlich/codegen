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
    public enum InterventionLineOfTreatmentEnm
    {
        [EnumMember(Value = DocConstantInterventionLineOfTreatment.FIRST)]
        FIRST,
        [EnumMember(Value = DocConstantInterventionLineOfTreatment.MAINTENANCE)]
        MAINTENANCE,
        [EnumMember(Value = DocConstantInterventionLineOfTreatment.MIXED)]
        MIXED,
        [EnumMember(Value = DocConstantInterventionLineOfTreatment.OTHER)]
        OTHER,
        [EnumMember(Value = DocConstantInterventionLineOfTreatment.SECOND)]
        SECOND,
        [EnumMember(Value = DocConstantInterventionLineOfTreatment.THIRD)]
        THIRD
    }
    
	public static partial class EnumExtensions
    {
        public static string ToEnumString(this InterventionLineOfTreatmentEnm instance)
		{
			switch(instance) 
			{
                case InterventionLineOfTreatmentEnm.FIRST:
                    return DocConstantInterventionLineOfTreatment.FIRST;
                case InterventionLineOfTreatmentEnm.MAINTENANCE:
                    return DocConstantInterventionLineOfTreatment.MAINTENANCE;
                case InterventionLineOfTreatmentEnm.MIXED:
                    return DocConstantInterventionLineOfTreatment.MIXED;
                case InterventionLineOfTreatmentEnm.OTHER:
                    return DocConstantInterventionLineOfTreatment.OTHER;
                case InterventionLineOfTreatmentEnm.SECOND:
                    return DocConstantInterventionLineOfTreatment.SECOND;
                case InterventionLineOfTreatmentEnm.THIRD:
                    return DocConstantInterventionLineOfTreatment.THIRD;
				default:
					return string.Empty;
			}
		}
    }

    public sealed partial class DocConstantInterventionLineOfTreatment : IEquatable<DocConstantInterventionLineOfTreatment>, IEqualityComparer<DocConstantInterventionLineOfTreatment>
    {
        public const string FIRST = "First";
        public const string MAINTENANCE = "Maintenance";
        public const string MIXED = "Mixed";
        public const string OTHER = "Other";
        public const string SECOND = "Second";
        public const string THIRD = "Third";
        
        #region Internals
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantInterventionLineOfTreatment).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantInterventionLineOfTreatment(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantInterventionLineOfTreatment(string Val) => new DocConstantInterventionLineOfTreatment(Val);

        public static implicit operator string(DocConstantInterventionLineOfTreatment item) => item?.Value ?? string.Empty;

        public override string ToString() => Value;

        #endregion Internals

        #region IEquatable (DocConstantInterventionLineOfTreatment)

        public bool Equals(DocConstantInterventionLineOfTreatment obj) => this == obj;

        public static bool operator ==(DocConstantInterventionLineOfTreatment x, DocConstantInterventionLineOfTreatment y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
		
		public bool Equals(DocConstantInterventionLineOfTreatment x, DocConstantInterventionLineOfTreatment y) => x == y;
        
        public static bool operator !=(DocConstantInterventionLineOfTreatment x, DocConstantInterventionLineOfTreatment y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantInterventionLineOfTreatment))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantInterventionLineOfTreatment) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value.GetHashCode();
				
        public int GetHashCode(DocConstantInterventionLineOfTreatment obj) => obj.GetHashCode();

        #endregion IEquatable
    }
}
