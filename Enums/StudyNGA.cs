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
    public enum StudyNGAEnm
    {
        [EnumMember(Value = DocConstantStudyNGA.COMPLETED_FINISHED)]
        COMPLETED_FINISHED = 3413,
        [EnumMember(Value = DocConstantStudyNGA.CROSSOVER)]
        CROSSOVER = 3418,
        [EnumMember(Value = DocConstantStudyNGA.DRUG_DISCONTINUATION)]
        DRUG_DISCONTINUATION = 3423,
        [EnumMember(Value = DocConstantStudyNGA.ENROLLED)]
        ENROLLED = 3428,
        [EnumMember(Value = DocConstantStudyNGA.ITT)]
        ITT = 3433,
        [EnumMember(Value = DocConstantStudyNGA.MODIFIED_ITT)]
        MODIFIED_ITT = 3438,
        [EnumMember(Value = DocConstantStudyNGA.PARTICIPANTS_INITIATED_STUDY)]
        PARTICIPANTS_INITIATED_STUDY = 3443,
        [EnumMember(Value = DocConstantStudyNGA.PP)]
        PP = 3448,
        [EnumMember(Value = DocConstantStudyNGA.RECRUITED)]
        RECRUITED = 3453,
        [EnumMember(Value = DocConstantStudyNGA.SAFETY)]
        SAFETY = 3458,
        [EnumMember(Value = DocConstantStudyNGA.SCREENED)]
        SCREENED = 3463,
        [EnumMember(Value = DocConstantStudyNGA.STUDY_WITHDRAWALS)]
        STUDY_WITHDRAWALS = 3468
    }
    
    public static partial class EnumExtensions
    {
        public static string ToEnumString(this StudyNGAEnm instance)
        {
            switch(instance) 
            {
                case StudyNGAEnm.COMPLETED_FINISHED:
                    return DocConstantStudyNGA.COMPLETED_FINISHED;
                case StudyNGAEnm.CROSSOVER:
                    return DocConstantStudyNGA.CROSSOVER;
                case StudyNGAEnm.DRUG_DISCONTINUATION:
                    return DocConstantStudyNGA.DRUG_DISCONTINUATION;
                case StudyNGAEnm.ENROLLED:
                    return DocConstantStudyNGA.ENROLLED;
                case StudyNGAEnm.ITT:
                    return DocConstantStudyNGA.ITT;
                case StudyNGAEnm.MODIFIED_ITT:
                    return DocConstantStudyNGA.MODIFIED_ITT;
                case StudyNGAEnm.PARTICIPANTS_INITIATED_STUDY:
                    return DocConstantStudyNGA.PARTICIPANTS_INITIATED_STUDY;
                case StudyNGAEnm.PP:
                    return DocConstantStudyNGA.PP;
                case StudyNGAEnm.RECRUITED:
                    return DocConstantStudyNGA.RECRUITED;
                case StudyNGAEnm.SAFETY:
                    return DocConstantStudyNGA.SAFETY;
                case StudyNGAEnm.SCREENED:
                    return DocConstantStudyNGA.SCREENED;
                case StudyNGAEnm.STUDY_WITHDRAWALS:
                    return DocConstantStudyNGA.STUDY_WITHDRAWALS;
                default:
                    return string.Empty;
            }
        }
    }

    public sealed partial class DocConstantStudyNGA : IEquatable<DocConstantStudyNGA>, IEqualityComparer<DocConstantStudyNGA>
    {
        public const string COMPLETED_FINISHED = "Completed/Finished";
        public const string CROSSOVER = "Crossover";
        public const string DRUG_DISCONTINUATION = "Drug Discontinuation";
        public const string ENROLLED = "Enrolled";
        public const string ITT = "ITT";
        public const string MODIFIED_ITT = "Modified ITT";
        public const string PARTICIPANTS_INITIATED_STUDY = "Participants (initiated study)";
        public const string PP = "PP";
        public const string RECRUITED = "Recruited";
        public const string SAFETY = "Safety";
        public const string SCREENED = "Screened";
        public const string STUDY_WITHDRAWALS = "Study Withdrawals";
        
        #region Internals
        
        private static List<string> _all;
        public static List<string> All => _all ?? (_all = typeof(DocConstantStudyNGA).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());

        private readonly string Value;

        private DocConstantStudyNGA(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }

        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));

        public static implicit operator DocConstantStudyNGA(string Val) => new DocConstantStudyNGA(Val);

        public static implicit operator string(DocConstantStudyNGA item) => item?.Value ?? string.Empty;

        public override string ToString() => Value;

        #endregion Internals

        #region IEquatable

        public bool Equals(DocConstantStudyNGA obj) => this == obj;

        public static bool operator ==(DocConstantStudyNGA x, DocConstantStudyNGA y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        
        public bool Equals(DocConstantStudyNGA x, DocConstantStudyNGA y) => x == y;
        
        public static bool operator !=(DocConstantStudyNGA x, DocConstantStudyNGA y) => !(x == y);

        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantStudyNGA))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantStudyNGA) obj;
            }
            return ret;
        }

        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
                
        public int GetHashCode(DocConstantStudyNGA obj) => obj?.GetHashCode() ?? -17;

        #endregion IEquatable
    }
}
