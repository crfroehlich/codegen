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

namespace Services.Dto
{
    public abstract partial class StudyTypeBase : Dto<StudyType>
    {
        public StudyTypeBase() {}

        public StudyTypeBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public StudyTypeBase(int? id) : this(DocConvert.ToInt(id)) {}

        [ApiMember(Name = nameof(Type), Description = "LookupTable", IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {@"Causation/Etiology",@"Diagnosis",@"Harm",@"Modeling",@"Other",@"Prevalence",@"Prevention/Risk",@"Prognosis",@"Therapy"})]
        public Reference Type { get; set; }
        [ApiMember(Name = nameof(TypeId), Description = "Primary Key of LookupTable", IsRequired = false)]
        public int? TypeId { get; set; }


    }

    public partial class StudyType : StudyTypeBase, IReturn<StudyType>, IDto
    {
        public StudyType()
        {
            _Constructor();
        }

        public StudyType(int? id) : base(DocConvert.ToInt(id)) {}
        public StudyType(int id) : base(id) {}
        
        #region Fields
        
        public bool? ShouldSerialize(string field)
        {
            if (IgnoredVisibleFields.Matches(field, true)) return false;
            var ret = MandatoryVisibleFields.Matches(field, true) || true == VisibleFields?.Matches(field, true);
            return ret;
        }

        public static List<string> Fields => DocTools.Fields<StudyType>();

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Created),nameof(CreatorId),nameof(Gestalt),nameof(Locked),nameof(Type),nameof(TypeId),nameof(Updated),nameof(VersionNo)})]
        public new List<string> VisibleFields
        {
            get
            {
                if(null == this) return new List<string>();
                if(null == _VisibleFields)
                {
                    _VisibleFields = DocPermissionFactory.RemoveNonEssentialFields(Fields);
                }
                return _VisibleFields;
            }
            set
            {
                _VisibleFields = Fields;
            }
        }

        #endregion Fields
    }
    
    public partial class StudyTypeSearchBase : Search<StudyType>
    {
        public int? Id { get; set; }
        public Reference Type { get; set; }
        public List<int> TypeIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"Causation/Etiology",@"Diagnosis",@"Harm",@"Modeling",@"Other",@"Prevalence",@"Prevention/Risk",@"Prognosis",@"Therapy"})]
        public List<string> TypeNames { get; set; }
    }

    public partial class StudyTypeSearch : StudyTypeSearchBase
    {
    }

    public class StudyTypeFullTextSearch
    {
        public StudyTypeFullTextSearch() {}
        private StudyTypeSearch _request;
        public StudyTypeFullTextSearch(StudyTypeSearch request) => _request = request;

        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(StudyType.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(StudyType.Updated))); }

        public bool doType { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(StudyType.Type))); }
    }

    public partial class StudyTypeBatch : List<StudyType> { }

}
