//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated by a T4 template. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.CodeDom.Compiler;
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
    public abstract partial class UserTypeBase : Dto<UserType>
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public UserTypeBase() {}

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public UserTypeBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public UserTypeBase(int? id) : this(DocConvert.ToInt(id)) {}

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public UserTypeBase(int? pId, Reference pPayrollStatus, int? pPayrollStatusId, Reference pPayrollType, int? pPayrollTypeId, Reference pType, int? pType_Id, List<Reference> pUsers, int? pUsersCount) : this(DocConvert.ToInt(pId)) 
        {
            PayrollStatus = pPayrollStatus;
            PayrollStatusId = pPayrollStatusId;
            PayrollType = pPayrollType;
            PayrollTypeId = pPayrollTypeId;
            Type = pType;
            Type_Id = pType_Id;
            Users = pUsers;
            UsersCount = pUsersCount;
        }

        [ApiAllowableValues("Includes", Values = new string[] {@"Contract",@"Full-Time",@"Part-Time"})]
        [ApiMember(Name = nameof(PayrollStatus), Description = "LookupTable", IsRequired = false)]
[GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Reference PayrollStatus { get; set; }
        [ApiMember(Name = nameof(PayrollStatusId), Description = "Primary Key of LookupTable", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? PayrollStatusId { get; set; }

        [ApiAllowableValues("Includes", Values = new string[] {@"Hourly",@"Salary"})]
        [ApiMember(Name = nameof(PayrollType), Description = "LookupTable", IsRequired = false)]
[GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Reference PayrollType { get; set; }
        [ApiMember(Name = nameof(PayrollTypeId), Description = "Primary Key of LookupTable", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? PayrollTypeId { get; set; }

        [ApiAllowableValues("Includes", Values = new string[] {@"Client",@"Contractor",@"Employee",@"Vendor"})]
        [ApiMember(Name = nameof(Type), Description = "LookupTable", IsRequired = true)]
[GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Reference Type { get; set; }
        [ApiMember(Name = nameof(Type_Id), Description = "Primary Key of LookupTable", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? Type_Id { get; set; }

        [ApiMember(Name = nameof(Users), Description = "User", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<Reference> Users { get; set; }
        [ApiMember(Name = nameof(UsersIds), Description = "User Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> UsersIds { get; set; }
        [ApiMember(Name = nameof(UsersCount), Description = "User Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? UsersCount { get; set; }



        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public void Deconstruct(out Reference pPayrollStatus, out int? pPayrollStatusId, out Reference pPayrollType, out int? pPayrollTypeId, out Reference pType, out int? pType_Id, out List<Reference> pUsers, out int? pUsersCount)
        {
            pPayrollStatus = PayrollStatus;
            pPayrollStatusId = PayrollStatusId;
            pPayrollType = PayrollType;
            pPayrollTypeId = PayrollTypeId;
            pType = Type;
            pType_Id = Type_Id;
            pUsers = Users;
            pUsersCount = UsersCount;
        }

        //Not ready until C# v8.?
        //[GeneratedCodeAttribute("T4", "1.0.0.0")]
        //public UserTypeBase With(int? pId = Id, Reference pPayrollStatus = PayrollStatus, int? pPayrollStatusId = PayrollStatusId, Reference pPayrollType = PayrollType, int? pPayrollTypeId = PayrollTypeId, Reference pType = Type, int? pType_Id = Type_Id, List<Reference> pUsers = Users, int? pUsersCount = UsersCount) => 
        //	new UserTypeBase(pId, pPayrollStatus, pPayrollStatusId, pPayrollType, pPayrollTypeId, pType, pType_Id, pUsers, pUsersCount);

    }


    [Route("/usertype", "POST")]
    [Route("/usertype/{Id}", "GET, PATCH, PUT, DELETE")]

    public partial class UserType : UserTypeBase, IReturn<UserType>, IDto, ICloneable
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public UserType() => _Constructor();
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public UserType(int? id) : base(DocConvert.ToInt(id)) {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public UserType(int id) : base(id) {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public UserType(int? pId, Reference pPayrollStatus, int? pPayrollStatusId, Reference pPayrollType, int? pPayrollTypeId, Reference pType, int? pType_Id, List<Reference> pUsers, int? pUsersCount) :
            base(pId, pPayrollStatus, pPayrollStatusId, pPayrollType, pPayrollTypeId, pType, pType_Id, pUsers, pUsersCount) { }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static List<string> Fields => DocTools.Fields<UserType>();

        private List<string> _Select;
        [ApiMember(Name = nameof(Select), Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Created),nameof(CreatorId),nameof(Gestalt),nameof(Locked),nameof(PayrollStatus),nameof(PayrollStatusId),nameof(PayrollType),nameof(PayrollTypeId),nameof(Type),nameof(Type_Id),nameof(Updated),nameof(Users),nameof(UsersCount),nameof(VersionNo)})]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override List<string> Select
        {
            get
            {
                if(null == this) return new List<string>();
                if(null == _Select)
                {

                    _Select = DocWebSession.GetTypeSelect(this);

                }
                return _Select;
            }
            set
            {

                var requested = value ?? new List<string>();
                var exists = requested.Where( r => Fields.Any( f => DocTools.AreEqual(r, f) ) ).ToList();
                _Select = DocPermissionFactory.SetSelect<UserType>("UserType",exists);

            }
        }

        [Obsolete, ApiMember(Name = "VisibleFields", Description = "Deprecated. Use Select instead.", AllowMultiple = true)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override List<string> VisibleFields { get => Select; set => Select = value; }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private List<string> _collections = new List<string>
        {
            nameof(Users), nameof(UsersCount), nameof(UsersIds)
        };
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private List<string> collections { get { return _collections; } }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Clone() => this.Copy<UserType>();

    }
    

    [Route("/usertype/{Id}/copy", "POST")]
    public partial class UserTypeCopy : UserType {}

    public partial class UserTypeSearchBase : Search<UserType>
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? Id { get; set; }
        public Reference PayrollStatus { get; set; }
        public List<int> PayrollStatusIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"Contract",@"Full-Time",@"Part-Time"})]
        public List<string> PayrollStatusNames { get; set; }
        public Reference PayrollType { get; set; }
        public List<int> PayrollTypeIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"Hourly",@"Salary"})]
        public List<string> PayrollTypeNames { get; set; }
        public Reference Type { get; set; }
        public List<int> TypeIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"Client",@"Contractor",@"Employee",@"Vendor"})]
        public List<string> TypeNames { get; set; }
        public List<int> UsersIds { get; set; }
    }


    [Route("/usertype", "GET")]
    [Route("/usertype/version", "GET, POST")]
    [Route("/usertype/search", "GET, POST, DELETE")]

    public partial class UserTypeSearch : UserTypeSearchBase
    {
    }

    public class UserTypeFullTextSearch
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public UserTypeFullTextSearch() {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private UserTypeSearch _request;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public UserTypeFullTextSearch(UserTypeSearch request) => _request = request;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool doCreated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(UserType.Created))); }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool doUpdated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(UserType.Updated))); }

        public bool doPayrollStatus { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(UserType.PayrollStatus))); }
        public bool doPayrollType { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(UserType.PayrollType))); }
        public bool doType { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(UserType.Type))); }
        public bool doUsers { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(UserType.Users))); }
    }


    [Route("/usertype/batch", "DELETE, PATCH, POST, PUT")]

    public partial class UserTypeBatch : List<UserType> { }


    [Route("/usertype/{Id}/{Junction}/version", "GET, POST")]
    [Route("/usertype/{Id}/{Junction}", "GET, POST, DELETE")]
    public class UserTypeJunction : UserTypeSearchBase {}



}
