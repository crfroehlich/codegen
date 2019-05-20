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
    public abstract partial class JunctionBase : Dto<Junction>
    {
        public JunctionBase() {}

        public JunctionBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public JunctionBase(int? id) : this(DocConvert.ToInt(id)) {}

        public JunctionBase(int? pId, List<Reference> pChildren, int? pChildrenCount, string pData, int? pOwnerId, string pOwnerType, Reference pParent, int? pParentId, int? pTargetId, string pTargetType, Reference pType, int? pTypeId, Reference pUser, int? pUserId) : this(DocConvert.ToInt(pId)) 
        {
            Children = pChildren;
            ChildrenCount = pChildrenCount;
            Data = pData;
            OwnerId = pOwnerId;
            OwnerType = pOwnerType;
            Parent = pParent;
            ParentId = pParentId;
            TargetId = pTargetId;
            TargetType = pTargetType;
            Type = pType;
            TypeId = pTypeId;
            User = pUser;
            UserId = pUserId;
        }

        [ApiMember(Name = nameof(Children), Description = "Junction", IsRequired = false)]
        public List<Reference> Children { get; set; }
        public int? ChildrenCount { get; set; }


        [ApiMember(Name = nameof(Data), Description = "string", IsRequired = false)]
        public string Data { get; set; }


        [ApiMember(Name = nameof(OwnerId), Description = "int?", IsRequired = false)]
        public int? OwnerId { get; set; }


        [ApiMember(Name = nameof(OwnerType), Description = "string", IsRequired = false)]
        public string OwnerType { get; set; }


        [ApiMember(Name = nameof(Parent), Description = "Junction", IsRequired = false)]
        public Reference Parent { get; set; }
        [ApiMember(Name = nameof(ParentId), Description = "Primary Key of Junction", IsRequired = false)]
        public int? ParentId { get; set; }


        [ApiMember(Name = nameof(TargetId), Description = "int?", IsRequired = false)]
        public int? TargetId { get; set; }


        [ApiMember(Name = nameof(TargetType), Description = "string", IsRequired = false)]
        public string TargetType { get; set; }


        [ApiAllowableValues("Includes", Values = new string[] {@"Approval",@"Comment",@"Flagged for Approval",@"Rating"})]
        [ApiMember(Name = nameof(Type), Description = "LookupTable", IsRequired = true)]
        public Reference Type { get; set; }
        [ApiMember(Name = nameof(TypeId), Description = "Primary Key of LookupTable", IsRequired = false)]
        public int? TypeId { get; set; }


        [ApiMember(Name = nameof(User), Description = "User", IsRequired = true)]
        public Reference User { get; set; }
        [ApiMember(Name = nameof(UserId), Description = "Primary Key of User", IsRequired = false)]
        public int? UserId { get; set; }



        public void Deconstruct(out List<Reference> pChildren, out int? pChildrenCount, out string pData, out int? pOwnerId, out string pOwnerType, out Reference pParent, out int? pParentId, out int? pTargetId, out string pTargetType, out Reference pType, out int? pTypeId, out Reference pUser, out int? pUserId)
        {
            pChildren = Children;
            pChildrenCount = ChildrenCount;
            pData = Data;
            pOwnerId = OwnerId;
            pOwnerType = OwnerType;
            pParent = Parent;
            pParentId = ParentId;
            pTargetId = TargetId;
            pTargetType = TargetType;
            pType = Type;
            pTypeId = TypeId;
            pUser = User;
            pUserId = UserId;
        }

        //Not ready until C# v8.?
        //public JunctionBase With(int? pId = Id, List<Reference> pChildren = Children, int? pChildrenCount = ChildrenCount, string pData = Data, int? pOwnerId = OwnerId, string pOwnerType = OwnerType, Reference pParent = Parent, int? pParentId = ParentId, int? pTargetId = TargetId, string pTargetType = TargetType, Reference pType = Type, int? pTypeId = TypeId, Reference pUser = User, int? pUserId = UserId) => 
        //	new JunctionBase(pId, pChildren, pChildrenCount, pData, pOwnerId, pOwnerType, pParent, pParentId, pTargetId, pTargetType, pType, pTypeId, pUser, pUserId);

    }

    [Route("/junction", "POST")]
    [Route("/junction/{Id}", "GET, PATCH, PUT, DELETE")]
    public partial class Junction : JunctionBase, IReturn<Junction>, IDto, ICloneable
    {
        public Junction()
        {
            _Constructor();
        }

        public Junction(int? id) : base(DocConvert.ToInt(id)) {}
        public Junction(int id) : base(id) {}
        public Junction(int? pId, List<Reference> pChildren, int? pChildrenCount, string pData, int? pOwnerId, string pOwnerType, Reference pParent, int? pParentId, int? pTargetId, string pTargetType, Reference pType, int? pTypeId, Reference pUser, int? pUserId) : 
            base(pId, pChildren, pChildrenCount, pData, pOwnerId, pOwnerType, pParent, pParentId, pTargetId, pTargetType, pType, pTypeId, pUser, pUserId) { }
        #region Fields

        public new bool? ShouldSerialize(string field)
        {
            //Allow individual classes to specify their own logic
            var manualOverride = _ShouldSerialize(field);
            if(null != manualOverride) return manualOverride;

            if (IgnoredSelect.Matches(field, true)) return false;
            var ret = MandatorySelect.Matches(field, true) || true == Select?.Matches(field, true);
            return ret;
        }

        public static List<string> Fields => DocTools.Fields<Junction>();

        private List<string> _Select;
        [ApiMember(Name = "Select", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Children),nameof(ChildrenCount),nameof(Created),nameof(CreatorId),nameof(Data),nameof(Gestalt),nameof(Locked),nameof(OwnerId),nameof(OwnerType),nameof(Parent),nameof(ParentId),nameof(TargetId),nameof(TargetType),nameof(Type),nameof(TypeId),nameof(Updated),nameof(User),nameof(UserId),nameof(VersionNo)})]
        public new List<string> Select
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
                _Select = DocPermissionFactory.SetSelect<Junction>("Junction",exists);
            }
        }

        #endregion Fields
        private List<string> _collections = new List<string>
        {
            nameof(Children), nameof(ChildrenCount)
        };
        private List<string> collections { get { return _collections; } }

        public object Clone() => this.Copy<Junction>();
    }
    
    [Route("/junction/{Id}/copy", "POST")]
    public partial class JunctionCopy : Junction {}
    public partial class JunctionSearchBase : Search<Junction>
    {
        public int? Id { get; set; }
        public List<int> ChildrenIds { get; set; }
        public string Data { get; set; }
        public int? OwnerId { get; set; }
        public string OwnerType { get; set; }
        public Reference Parent { get; set; }
        public List<int> ParentIds { get; set; }
        public int? TargetId { get; set; }
        public string TargetType { get; set; }
        public Reference Type { get; set; }
        public List<int> TypeIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"Approval",@"Comment",@"Flagged for Approval",@"Rating"})]
        public List<string> TypeNames { get; set; }
        public Reference User { get; set; }
        public List<int> UserIds { get; set; }
    }

    [Route("/junction", "GET")]
    [Route("/junction/version", "GET, POST")]
    [Route("/junction/search", "GET, POST, DELETE")]
    public partial class JunctionSearch : JunctionSearchBase
    {
    }

    public class JunctionFullTextSearch
    {
        public JunctionFullTextSearch() {}
        private JunctionSearch _request;
        public JunctionFullTextSearch(JunctionSearch request) => _request = request;

        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Junction.Created))); }
        public bool doUpdated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Junction.Updated))); }

        public bool doChildren { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Junction.Children))); }
        public bool doData { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Junction.Data))); }
        public bool doOwnerId { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Junction.OwnerId))); }
        public bool doOwnerType { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Junction.OwnerType))); }
        public bool doParent { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Junction.Parent))); }
        public bool doTargetId { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Junction.TargetId))); }
        public bool doTargetType { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Junction.TargetType))); }
        public bool doType { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Junction.Type))); }
        public bool doUser { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(Junction.User))); }
    }

    [Route("/junction/batch", "DELETE, PATCH, POST, PUT")]
    public partial class JunctionBatch : List<Junction> { }

    [Route("/junction/{Id}/{Junction}/version", "GET, POST")]
    [Route("/junction/{Id}/{Junction}", "GET, POST, DELETE")]
    public class JunctionJunction : JunctionSearchBase {}


}
