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
namespace Services.Schema
{
    [TableMapping(DocConstantModelName.UPDATE)]
    public partial class DocEntityUpdate : DocEntityBase
    {
        private const string UPDATE_CACHE = "UpdateCache";
        public const ModelNameEnm CLASS_NAME = ModelNameEnm.UPDATE;
        
        #region Constructor
        public DocEntityUpdate(Session session) : base(session) {}

        public DocEntityUpdate() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        protected override List<string> _select => __vf ?? (__vf = DocWebSession.GetTypeSelect(new Update()));

        #region Static Members
        public static DocEntityUpdate Get(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? Get(reference.Id) : null;
        }

        public static DocEntityUpdate Get(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityUpdate>.GetFromCache(primaryKey, UPDATE_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityUpdate>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityUpdate>.UpdateCache(ret.Id, ret, UPDATE_CACHE);
                    DocEntityThreadCache<DocEntityUpdate>.UpdateCache(ret.Hash, ret, UPDATE_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityUpdate Get(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityUpdate>.GetFromCache(hash, UPDATE_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityUpdate>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityUpdate>.UpdateCache(ret.Id, ret, UPDATE_CACHE);
                    DocEntityThreadCache<DocEntityUpdate>.UpdateCache(ret.Hash, ret, UPDATE_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field(Length = int.MaxValue)]
        public string Body { get; set; }


        [Field(Length = int.MaxValue)]
        public string DeliveryStatus { get; set; }


        [Field(DefaultValue = 0)]
        public int EmailAttempts { get; set; }


        [Field]
        public DateTime? EmailSent { get; set; }


        [Field]
        [Association(PairTo = nameof(DocEntityEvent.Updates), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityEvent> Events { get; private set; }


        public int? EventsCount { get { return Events.Count(); } private set { var noid = value; } }


        [Field]
        public string Link { get; set; }


        [Field(DefaultValue = 5)]
        public int Priority { get; set; }


        [Field]
        public DateTime? Read { get; set; }


        [Field]
        public DateTime? SlackSent { get; set; }


        [Field]
        public string Subject { get; set; }


        [Field]
        public DocEntityTeam Team { get; set; }
        public int? TeamId { get { return Team?.Id; } private set { var noid = value; } }


        [Field]
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

        public const string CACHE_KEY_PREFIX = "FindUpdates";

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
                throw new HttpError(HttpStatusCode.Conflict, $"Update requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();
            _validated = true;
        }

        public override IDocEntity SaveChanges(bool ignoreCache, DocConstantPermission permission)
        {
            Link = Link?.TrimAndPruneSpaces();
            Subject = Subject?.TrimAndPruneSpaces();
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



                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Converters

        public Update ToDto() => Mapper.Map<DocEntityUpdate, Update>(this);

        public static explicit operator Update(DocEntityUpdate en) => en?.ToDto();
        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }
}
