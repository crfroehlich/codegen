﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when
//    the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AutoMapper;

using Services.Core;
using Services.Db;
using Services.Dto;
using Services.Enums;
using Services.Models;
using Services.Schema;

using Typed;
using Typed.Bindings;
using Typed.Notifications;
using Typed.Settings;

using ServiceStack;
using ServiceStack.Text;

using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Dynamic;
using System.Net;

using Xtensive.Orm;
using Xtensive.Orm.Model;

using Attribute = Services.Dto.Attribute;
using ValueType = Services.Dto.ValueType;

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

    [Route("/studytype/{Id}", "GET")]
    [Route("/profile/studytype/{Id}", "GET")]
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
            if (DocTools.AreEqual(nameof(VisibleFields), field)) return false;
            if (DocTools.AreEqual(nameof(Fields), field)) return false;
            if (DocTools.AreEqual(nameof(AssignFields), field)) return false;
            if (DocTools.AreEqual(nameof(IgnoreCache), field)) return false;
            if (DocTools.AreEqual(nameof(Id), field)) return true;
            return true == VisibleFields?.Matches(field, true);
        }

        private static List<string> _fields;
        public static List<string> Fields => _fields ?? (_fields = DocTools.Fields<StudyType>());

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
    
    [Route("/studytype", "GET")]
    [Route("/profile/studytype", "GET")]
    [Route("/studytype/search", "GET, POST, DELETE")]
    [Route("/profile/studytype/search", "GET, POST, DELETE")]
    public partial class StudyTypeSearch : Search<StudyType>
    {
        public Reference Type { get; set; }
        public List<int> TypeIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"Causation/Etiology",@"Diagnosis",@"Harm",@"Modeling",@"Other",@"Prevalence",@"Prevention/Risk",@"Prognosis",@"Therapy"})]
        public List<string> TypeNames { get; set; }
    }
    
    public class StudyTypeFullTextSearch
    {
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

    [Route("/studytype/version", "GET, POST")]
    public partial class StudyTypeVersion : StudyTypeSearch {}

    [Route("/studytype/batch", "DELETE, PATCH, POST, PUT")]
    [Route("/profile/studytype/batch", "DELETE, PATCH, POST, PUT")]
    public partial class StudyTypeBatch : List<StudyType> { }

}