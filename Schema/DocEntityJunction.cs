
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
using System.Net;

using AutoMapper;

using Services.Core;
using Services.Db;
using Services.Dto;
using Services.Dto.internals;
using Services.Enums;

using ServiceStack;

using Xtensive.Orm;


namespace Services.Schema
{
    [TableMapping(DocConstantModelName.JUNCTION)]
    public partial class DocEntityJunction : DocEntityBase
    {
        private const string JUNCTION_CACHE = "JunctionCache";
        public const ModelNameEnm CLASS_NAME = ModelNameEnm.JUNCTION;
        
        #region Constructor
        public DocEntityJunction(Session session) : base(session) {}

        public DocEntityJunction() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        protected override List<string> _select => __vf ?? (__vf = DocWebSession.GetTypeSelect(new Junction()));

        #region Static Members
        public static DocEntityJunction Get(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? Get(reference.Id) : null;
        }

        public static DocEntityJunction Get(int? primaryKey, bool noCache, DocQuery query)
        {
            if(!(primaryKey > 0)) return null;
            return query.SelectAll<DocEntityJunction>().FirstOrDefault(e => e.Id == primaryKey.Value);
        }

        public static DocEntityJunction Get(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityJunction>.GetFromCache(primaryKey, JUNCTION_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityJunction>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityJunction>.UpdateCache(ret.Id, ret, JUNCTION_CACHE);
                    DocEntityThreadCache<DocEntityJunction>.UpdateCache(ret.Hash, ret, JUNCTION_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityJunction Get(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityJunction>.GetFromCache(hash, JUNCTION_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityJunction>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityJunction>.UpdateCache(ret.Id, ret, JUNCTION_CACHE);
                    DocEntityThreadCache<DocEntityJunction>.UpdateCache(ret.Hash, ret, JUNCTION_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field]
        [Association(PairTo = nameof(DocEntityJunction.Parent), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityJunction> Children { get; private set; }


        public List<int> ChildrenIds => Children.Select(e => e.Id).ToList();


        public int? ChildrenCount { get { return Children.Count(); } private set { var noid = value; } }


        [Field(Length = int.MaxValue)]
        public string Data { get; set; }


        [Field]
        public int? OwnerId { get; set; }


        [Field]
        public string OwnerType { get; set; }


        [Field]
        public DocEntityJunction Parent { get; set; }
        public int? ParentId { get { return Parent?.Id; } private set { var noid = value; } }


        [Field]
        public int? TargetId { get; set; }


        [Field]
        public string TargetType { get; set; }


        [Field(Nullable = false)]
        public DocEntityLookupTable Type { get; set; }
        public int? TypeId { get { return Type?.Id; } private set { var noid = value; } }


        [Field(Nullable = false)]
        public DocEntityUser User { get; set; }
        public int? UserId { get { return User?.Id; } private set { var noid = value; } }



        [Field]
        public override string Gestalt { get; set; }

        [Field(DefaultValue = 0), Version(VersionMode.Manual)]
        public override int VersionNo { get; set; }

        [Field]
        public override DateTime? Created { get; set; }

        [Field]
        public override DateTime? Updated { get; set; }

        [Field(DefaultValue = false), FieldMapping(nameof(Locked))]
        public override bool Locked { get; set; }

        [Field(DefaultValue = false), FieldMapping(nameof(Archived))]
        public override bool Archived { get; set; }

        #endregion Properties

        #region Overrides of DocEntity

        public override ModelNameEnm ClassName => CLASS_NAME;

        public override DocConstantModelName TableName => CLASS_NAME.ToEnumString();

        public const string CACHE_KEY_PREFIX = "FindJunctions";

        #endregion Overrides of DocEntity

        #region Entity overrides
        /// <summary>
        ///    Called when entity is about to be removed.
        /// </summary>
        protected override void OnRemoving()
        {
            base.OnRemoving();
            try
            {
                Children.Clear(); //foreach thing in Children en.Remove();
            }
            catch(Exception ex)
            {
                throw new DocException("Failed to delete Junction in Children delete", ex);
            }
            FlushCache();
        }

        /// <summary>
        ///    Called when entity should be validated. Override this method to perform custom object validation.
        /// </summary>
        protected override void OnValidate()
        {
            if (false == ValidationMessage.IsValid)
            {
                throw new HttpError(HttpStatusCode.Conflict, $"Junction requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();
            _validated = true;
        }

        public override IDocEntity SaveChanges(bool ignoreCache, DocConstantPermission permission)
        {
            OwnerType = OwnerType?.TrimAndPruneSpaces();
            TargetType = TargetType?.TrimAndPruneSpaces();
            return base.SaveChanges(ignoreCache, permission);
        }

        public override IDocEntity SaveChanges(bool ignoreCache) => SaveChanges(ignoreCache, DocConstantPermission.EDIT);
        public override IDocEntity SaveChanges(DocConstantPermission permission) => SaveChanges(false, DocConstantPermission.EDIT);
        public override IDocEntity SaveChanges() => SaveChanges(DocConstantPermission.EDIT);

        public override void FlushCache()
        {
            base.FlushCache();

        }
        #endregion Entity overrides

        #region Validation
        public DocValidationMessage ValidationMessage
        {
            get
            {
                var isValid = true;
                var message = string.Empty;

                if(DocTools.IsNullOrEmpty(Type))
                {
                    isValid = false;
                    message += " Type is a required property.";
                }
                else
                {
                    if(Type.Enum?.Name != "JunctionType")
                    {
                        isValid = false;
                        message += " Type is a " + Type.Enum.Name + ", but must be a JunctionType.";
                    }
                }
                if(DocTools.IsNullOrEmpty(User))
                {
                    isValid = false;
                    message += " User is a required property.";
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Converters

        public Junction ToDto() => Mapper.Map<DocEntityJunction, Junction>(this);

        public static explicit operator Junction(DocEntityJunction en) => en?.ToDto();

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }
}
