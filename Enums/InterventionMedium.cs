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
    public enum InterventionMediumEnm
    {
        [EnumMember(Value = DocConstantInterventionMedium.BOOKLET)]
        BOOKLET,
        [EnumMember(Value = DocConstantInterventionMedium.BROCHURE)]
        BROCHURE,
        [EnumMember(Value = DocConstantInterventionMedium.VIDEO)]
        VIDEO,
        [EnumMember(Value = DocConstantInterventionMedium.WEBSITE)]
        WEBSITE
    }
    
	public static partial class EnumExtensions
    {
        public static string ToEnumString(this InterventionMediumEnm instance)
		{
			switch(instance) 
			{
                case InterventionMediumEnm.BOOKLET:
                    return DocConstantInterventionMedium.BOOKLET;
                case InterventionMediumEnm.BROCHURE:
                    return DocConstantInterventionMedium.BROCHURE;
                case InterventionMediumEnm.VIDEO:
                    return DocConstantInterventionMedium.VIDEO;
                case InterventionMediumEnm.WEBSITE:
                    return DocConstantInterventionMedium.WEBSITE;
				default:
					return string.Empty;
			}
		}
    }

    public sealed partial class DocConstantInterventionMedium : IEquatable<DocConstantInterventionMedium>, IEqualityComparer<DocConstantInterventionMedium>
    {
        public const string BOOKLET = "Booklet";
        public const string BROCHURE = "Brochure";
        public const string VIDEO = "Video";
        public const string WEBSITE = "Website";
        
        #region Internals
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantInterventionMedium).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantInterventionMedium(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantInterventionMedium(string Val) => new DocConstantInterventionMedium(Val);

        public static implicit operator string(DocConstantInterventionMedium item) => item?.Value ?? string.Empty;

        public override string ToString() => Value;

        #endregion Internals

        #region IEquatable (DocConstantInterventionMedium)

        public bool Equals(DocConstantInterventionMedium obj) => this == obj;

        public static bool operator ==(DocConstantInterventionMedium x, DocConstantInterventionMedium y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
		
		public bool Equals(DocConstantInterventionMedium x, DocConstantInterventionMedium y) => x == y;
        
        public static bool operator !=(DocConstantInterventionMedium x, DocConstantInterventionMedium y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantInterventionMedium))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantInterventionMedium) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value.GetHashCode();
				
        public int GetHashCode(DocConstantInterventionMedium obj) => obj.GetHashCode();

        #endregion IEquatable
    }
}
