
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

using Services.Core;
using Services.Dto.internals;
using Services.Enums;

using ServiceStack;
using ServiceStack.Text;

using Typed;
using Typed.Notifications;
using Typed.Bindings;

using Xtensive.Orm;


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

        public StudyTypeBase(int? pId, Reference pType, int? pTypeId) : this(DocConvert.ToInt(pId)) 
        {
            Type = pType;
            TypeId = pTypeId;
        }

        [ApiAllowableValues("Includes", Values = new string[] {@"Causation/Etiology",@"Diagnosis",@"Harm",@"Modeling",@"Other",@"Prevalence",@"Prevention/Risk",@"Prognosis",@"Therapy"})]
        [ApiMember(Name = nameof(Type), Description = "LookupTable", IsRequired = true)]
        public Reference Type { get; set; }
        [ApiMember(Name = nameof(TypeId), Description = "Primary Key of LookupTable", IsRequired = false)]
        public int? TypeId { get; set; }



        public void Deconstruct(out Reference pType, out int? pTypeId)
        {
            pType = Type;
            pTypeId = TypeId;
        }

        //Not ready until C# v8.?
        //public StudyTypeBase With(int? pId = Id, Reference pType = Type, int? pTypeId = TypeId) => 
        //	new StudyTypeBase(pId, pType, pTypeId);

    }


    public partial class StudyType : StudyTypeBase, IReturn<StudyType>, IDto, ICloneable
    {
        public StudyType() => _Constructor();

        public StudyType(int? id) : base(DocConvert.ToInt(id)) {}
        public StudyType(int id) : base(id) {}
        public StudyType(int? pId, Reference pType, int? pTypeId) :
            base(pId, pType, pTypeId) { }

        public static List<string> Fields => DocTools.Fields<StudyType>();

        private List<string> _Select;
        [ApiMember(Name = nameof(Select), Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Created),nameof(CreatorId),nameof(Gestalt),nameof(Locked),nameof(Type),nameof(TypeId),nameof(Updated),nameof(VersionNo)})]
        public override List<string> Select
        {
            get
            {
                if(null == this) return new List<string>();
                if(null == _Select)
                {

                    _Select = DocPermissionFactory.RemoveNonEssentialFields(Fields);


                }
                return _Select;
            }
            set
            {

                _Select = Fields;


            }
        }

        [Obsolete, ApiMember(Name = nameof(VisibleFields), Description = "Deprecated. Use Select instead.", AllowMultiple = true)]
        public override List<string> VisibleFields { get => Select; set => Select = value; }



        public object Clone() => this.Copy<StudyType>();

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
        public bool doCreated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(StudyType.Created))); }
        public bool doUpdated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(StudyType.Updated))); }

        public bool doType { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(StudyType.Type))); }
    }


    public partial class StudyTypeBatch : List<StudyType> { }


}
