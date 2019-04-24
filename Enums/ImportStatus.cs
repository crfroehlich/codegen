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
    public enum ImportStatusEnm
    {
        [EnumMember(Value = DocConstantImportStatus.ALREADY_IMPORTED)]
        ALREADY_IMPORTED,
        [EnumMember(Value = DocConstantImportStatus.CANCELLED)]
        CANCELLED,
        [EnumMember(Value = DocConstantImportStatus.FAILED)]
        FAILED,
        [EnumMember(Value = DocConstantImportStatus.NO_JSON_FOUND)]
        NO_JSON_FOUND,
        [EnumMember(Value = DocConstantImportStatus.PROCESSING)]
        PROCESSING,
        [EnumMember(Value = DocConstantImportStatus.QUEUED)]
        QUEUED,
        [EnumMember(Value = DocConstantImportStatus.SUCCEEDED)]
        SUCCEEDED
    }
    
    public static partial class EnumExtensions
    {
        public static string ToEnumString(this ImportStatusEnm instance)
        {
            switch(instance) 
            {
                case ImportStatusEnm.ALREADY_IMPORTED:
                    return DocConstantImportStatus.ALREADY_IMPORTED;
                case ImportStatusEnm.CANCELLED:
                    return DocConstantImportStatus.CANCELLED;
                case ImportStatusEnm.FAILED:
                    return DocConstantImportStatus.FAILED;
                case ImportStatusEnm.NO_JSON_FOUND:
                    return DocConstantImportStatus.NO_JSON_FOUND;
                case ImportStatusEnm.PROCESSING:
                    return DocConstantImportStatus.PROCESSING;
                case ImportStatusEnm.QUEUED:
                    return DocConstantImportStatus.QUEUED;
                case ImportStatusEnm.SUCCEEDED:
                    return DocConstantImportStatus.SUCCEEDED;
                default:
                    return string.Empty;
            }
        }
    }

    public sealed partial class DocConstantImportStatus : IEquatable<DocConstantImportStatus>, IEqualityComparer<DocConstantImportStatus>
    {
        public const string ALREADY_IMPORTED = "Already Imported";
        public const string CANCELLED = "Cancelled";
        public const string FAILED = "Failed";
        public const string NO_JSON_FOUND = "No JSON Found";
        public const string PROCESSING = "Processing";
        public const string QUEUED = "Queued";
        public const string SUCCEEDED = "Succeeded";
        
        #region Internals
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantImportStatus).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantImportStatus(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantImportStatus(string Val) => new DocConstantImportStatus(Val);

        public static implicit operator string(DocConstantImportStatus item) => item?.Value ?? string.Empty;

        public override string ToString() => Value;

        #endregion Internals

        #region IEquatable

        public bool Equals(DocConstantImportStatus obj) => this == obj;

        public static bool operator ==(DocConstantImportStatus x, DocConstantImportStatus y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        
        public bool Equals(DocConstantImportStatus x, DocConstantImportStatus y) => x == y;
        
        public static bool operator !=(DocConstantImportStatus x, DocConstantImportStatus y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantImportStatus))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantImportStatus) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
                
        public int GetHashCode(DocConstantImportStatus obj) => obj?.GetHashCode() ?? -17;

        #endregion IEquatable
    }
}
