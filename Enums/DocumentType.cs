
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
    public enum DocumentTypeEnm
    {
        [EnumMember(Value = DocConstantDocumentType.CTG)]
        CTG,
        [EnumMember(Value = DocConstantDocumentType.DATA_HUB)]
        DATA_HUB,
        [EnumMember(Value = DocConstantDocumentType.DOC_EXTRACT)]
        DOC_EXTRACT,
        [EnumMember(Value = DocConstantDocumentType.DOC_LIBRARY)]
        DOC_LIBRARY,
        [EnumMember(Value = DocConstantDocumentType.PUBMED)]
        PUBMED
    }
    
    public static partial class EnumExtensions
    {
        public static string ToEnumString(this DocumentTypeEnm instance)
        {
            switch(instance) 
            {
                case DocumentTypeEnm.CTG:
                    return DocConstantDocumentType.CTG;
                case DocumentTypeEnm.DATA_HUB:
                    return DocConstantDocumentType.DATA_HUB;
                case DocumentTypeEnm.DOC_EXTRACT:
                    return DocConstantDocumentType.DOC_EXTRACT;
                case DocumentTypeEnm.DOC_LIBRARY:
                    return DocConstantDocumentType.DOC_LIBRARY;
                case DocumentTypeEnm.PUBMED:
                    return DocConstantDocumentType.PUBMED;
                default:
                    return string.Empty;
            }
        }
    }

    public sealed partial class DocConstantDocumentType : IEquatable<DocConstantDocumentType>, IEqualityComparer<DocConstantDocumentType>
    {
        public const string CTG = "CTG";
        public const string DATA_HUB = "Data Hub";
        public const string DOC_EXTRACT = "DOC Extract";
        public const string DOC_LIBRARY = "DOC Library";
        public const string PUBMED = "PubMed";
        
        #region Internals
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantDocumentType).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantDocumentType(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantDocumentType(string Val) => new DocConstantDocumentType(Val);

        public static implicit operator string(DocConstantDocumentType item) => item?.Value ?? string.Empty;

        public override string ToString() => Value;

        #endregion Internals

        #region IEquatable

        public bool Equals(DocConstantDocumentType obj) => this == obj;

        public static bool operator ==(DocConstantDocumentType x, DocConstantDocumentType y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        
        public bool Equals(DocConstantDocumentType x, DocConstantDocumentType y) => x == y;
        
        public static bool operator !=(DocConstantDocumentType x, DocConstantDocumentType y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantDocumentType))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantDocumentType) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
                
        public int GetHashCode(DocConstantDocumentType obj) => obj?.GetHashCode() ?? -17;

        #endregion IEquatable
    }
}
