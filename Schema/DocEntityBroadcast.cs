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
    [TableMapping(DocConstantModelName.BROADCAST)]
    public partial class DocEntityBroadcast : DocEntityBase
    {
        private const string BROADCAST_CACHE = "BroadcastCache";
        public const ModelNameEnm CLASS_NAME = ModelNameEnm.BROADCAST;
        
        #region Constructor
        public DocEntityBroadcast(Session session) : base(session) {}

        public DocEntityBroadcast() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        protected override List<string> _select => __vf ?? (__vf = DocWebSession.GetTypeSelect(new Broadcast()));

        #region Static Members
        public static DocEntityBroadcast Get(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? Get(reference.Id) : null;
        }

        public static DocEntityBroadcast Get(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityBroadcast>.GetFromCache(primaryKey, BROADCAST_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityBroadcast>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityBroadcast>.UpdateCache(ret.Id, ret, BROADCAST_CACHE);
                    DocEntityThreadCache<DocEntityBroadcast>.UpdateCache(ret.Hash, ret, BROADCAST_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityBroadcast Get(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityBroadcast>.GetFromCache(hash, BROADCAST_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityBroadcast>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityBroadcast>.UpdateCache(ret.Id, ret, BROADCAST_CACHE);
                    DocEntityThreadCache<DocEntityBroadcast>.UpdateCache(ret.Hash, ret, BROADCAST_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field(Nullable = false)]
        public DocEntityApp App { get; set; }
        public int? AppId { get { return App?.Id; } private set { var noid = value; } }


        [Field]
        public string ConfluenceId { get; set; }


        [Field(Nullable = false)]
        public string Name { get; set; }


        [Field(Nullable = false, DefaultValue = true)]
        public bool Reprocess { get; set; }


        [Field(DefaultValue = null)]
        public DateTime? Reprocessed { get; set; }


        [Field]
        public DocEntitySet<DocEntityScope> Scopes { get; private set; }


        public List<int> ScopesIds => Scopes.Select(e => e.Id).ToList();


        public int? ScopesCount { get { return Scopes.Count(); } private set { var noid = value; } }


        [Field]
        public DocEntityLookupTable Status { get; set; }
        public int? StatusId { get { return Status?.Id; } private set { var noid = value; } }


        [Field(Nullable = false)]
        public DocEntityLookupTable Type { get; set; }
        public int? TypeId { get { return Type?.Id; } private set { var noid = value; } }


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

        public const string CACHE_KEY_PREFIX = "FindBroadcasts";

        #endregion Overrides of DocEntity

        #region Entity overrides
        /// <summary>
        ///    Called when entity is about to be removed.
        /// </summary>
        protected override void OnRemoving()
        {
            base.OnRemoving();

            FlushCache();
        }

        /// <summary>
        ///    Called when entity should be validated. Override this method to perform custom object validation.
        /// </summary>
        protected override void OnValidate()
        {
            if (false == ValidationMessage.IsValid)
            {
                throw new HttpError(HttpStatusCode.Conflict, $"Broadcast requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();
            _validated = true;
        }

        public override IDocEntity SaveChanges(bool ignoreCache, DocConstantPermission permission)
        {
            ConfluenceId = ConfluenceId?.TrimAndPruneSpaces();
            Name = Name?.TrimAndPruneSpaces();
            return base.SaveChanges(ignoreCache, permission);
        }

        public override IDocEntity SaveChanges(bool ignoreCache) => SaveChanges(ignoreCache, DocConstantPermission.EDIT);
        public override IDocEntity SaveChanges(DocConstantPermission permission) => SaveChanges(false, DocConstantPermission.EDIT);
        public override IDocEntity SaveChanges() => SaveChanges(DocConstantPermission.EDIT);

        public override void FlushCache()
        {
            base.FlushCache();
            DocCacheClient.RemoveById(Id);
        }
        #endregion Entity overrides

        #region Validation
        public DocValidationMessage ValidationMessage
        {
            get
            {
                var isValid = true;
                var message = string.Empty;

                if(DocTools.IsNullOrEmpty(App))
                {
                    isValid = false;
                    message += " App is a required property.";
                }
                if(DocTools.IsNullOrEmpty(Name))
                {
                    isValid = false;
                    message += " Name is a required property.";
                }
                if(DocTools.IsNullOrEmpty(Reprocess))
                {
                    isValid = false;
                    message += " Reprocess is a required property.";
                }
                if(null != Status && Status?.Enum?.Name != "BroadcastStatus")
                {
                    isValid = false;
                    message += " Status is a " + Status?.Enum?.Name + ", but must be a BroadcastStatus.";
                }
                if(DocTools.IsNullOrEmpty(Type))
                {
                    isValid = false;
                    message += " Type is a required property.";
                }
                else
                {
                    if(Type.Enum?.Name != "BroadcastType")
                    {
                        isValid = false;
                        message += " Type is a " + Type.Enum.Name + ", but must be a BroadcastType.";
                    }
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Converters

        public Broadcast ToDto() => Mapper.Map<DocEntityBroadcast, Broadcast>(this);

        public static explicit operator Broadcast(DocEntityBroadcast en) => en?.ToDto();
        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }
}
