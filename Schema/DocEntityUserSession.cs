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
    [TableMapping(DocConstantModelName.USERSESSION)]
    public partial class DocEntityUserSession : DocEntityBase
    {
        private const string USERSESSION_CACHE = "UserSessionCache";
        public const ModelNameEnm CLASS_NAME = ModelNameEnm.USERSESSION;
        
        #region Constructor
        public DocEntityUserSession(Session session) : base(session) {}

        public DocEntityUserSession() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        protected override List<string> _select => __vf ?? (__vf = DocWebSession.GetTypeSelect(new UserSession()));

        #region Static Members
        public static DocEntityUserSession Get(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? Get(reference.Id) : null;
        }

        public static DocEntityUserSession Get(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityUserSession>.GetFromCache(primaryKey, USERSESSION_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityUserSession>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityUserSession>.UpdateCache(ret.Id, ret, USERSESSION_CACHE);
                    DocEntityThreadCache<DocEntityUserSession>.UpdateCache(ret.Hash, ret, USERSESSION_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityUserSession Get(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityUserSession>.GetFromCache(hash, USERSESSION_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityUserSession>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityUserSession>.UpdateCache(ret.Id, ret, USERSESSION_CACHE);
                    DocEntityThreadCache<DocEntityUserSession>.UpdateCache(ret.Hash, ret, USERSESSION_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field]
        public string ClientId { get; set; }


        [Field(Nullable = false, DefaultValue = 0)]
        public int Hits { get; set; }


        [Field]
        [Association(PairTo = nameof(DocEntityImpersonation.UserSession), OnOwnerRemove = OnRemoveAction.Deny, OnTargetRemove = OnRemoveAction.Deny)]
        public DocEntitySet<DocEntityImpersonation> Impersonations { get; private set; }


        public int? ImpersonationsCount { get { return Impersonations.Count(); } private set { var noid = value; } }


        [Field]
        public string IpAddress { get; set; }


        [Field]
        [Association(PairTo = nameof(DocEntityUserRequest.UserSession), OnOwnerRemove = OnRemoveAction.Deny, OnTargetRemove = OnRemoveAction.Deny)]
        public DocEntitySet<DocEntityUserRequest> Requests { get; private set; }


        public int? RequestsCount { get { return Requests.Count(); } private set { var noid = value; } }


        [Field]
        public string SessionId { get; set; }


        [Field]
        public string TemporarySessionId { get; set; }


        [Field(Nullable = false)]
        public DocEntityUser User { get; set; }
        public int? UserId { get { return User?.Id; } private set { var noid = value; } }


        [Field]
        [Association(PairTo = nameof(DocEntityHistory.UserSession), OnOwnerRemove = OnRemoveAction.Deny, OnTargetRemove = OnRemoveAction.Deny)]
        public DocEntitySet<DocEntityHistory> UserHistory { get; private set; }


        public int? UserHistoryCount { get { return UserHistory.Count(); } private set { var noid = value; } }


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

        public const string CACHE_KEY_PREFIX = "FindUserSessions";

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
                throw new HttpError(HttpStatusCode.Conflict, $"UserSession requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();
            _validated = true;
        }

        public override IDocEntity SaveChanges(bool ignoreCache, DocConstantPermission permission)
        {
            ClientId = ClientId?.TrimAndPruneSpaces();
            IpAddress = IpAddress?.TrimAndPruneSpaces();
            SessionId = SessionId?.TrimAndPruneSpaces();
            TemporarySessionId = TemporarySessionId?.TrimAndPruneSpaces();
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

                if(DocTools.IsNullOrEmpty(Hits))
                {
                    isValid = false;
                    message += " Hits is a required property.";
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

        public UserSession ToDto() => Mapper.Map<DocEntityUserSession, UserSession>(this);

        public static explicit operator UserSession(DocEntityUserSession en) => en?.ToDto();
        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }
}
