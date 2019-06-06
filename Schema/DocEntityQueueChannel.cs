
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
    [TableMapping(DocConstantModelName.QUEUECHANNEL)]
    public partial class DocEntityQueueChannel : DocEntityBase
    {
        private const string QUEUECHANNEL_CACHE = "QueueChannelCache";
        public const ModelNameEnm CLASS_NAME = ModelNameEnm.QUEUECHANNEL;
        
        public DocEntityQueueChannel(Session session) : base(session) {}

        public DocEntityQueueChannel() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}

        protected override List<string> _select => __vf ?? (__vf = DocWebSession.GetTypeSelect(new QueueChannel()));

        public static DocEntityQueueChannel Get(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? Get(reference.Id) : null;
        }

        public static DocEntityQueueChannel Get(int? primaryKey, bool noCache, DocQuery query)
        {
            if(!(primaryKey > 0)) return null;
            return query.SelectAll<DocEntityQueueChannel>().FirstOrDefault(e => e.Id == primaryKey.Value);
        }

        public static DocEntityQueueChannel Get(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityQueueChannel>.GetFromCache(primaryKey, QUEUECHANNEL_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityQueueChannel>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityQueueChannel>.UpdateCache(ret.Id, ret, QUEUECHANNEL_CACHE);
                    DocEntityThreadCache<DocEntityQueueChannel>.UpdateCache(ret.Hash, ret, QUEUECHANNEL_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityQueueChannel Get(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityQueueChannel>.GetFromCache(hash, QUEUECHANNEL_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityQueueChannel>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityQueueChannel>.UpdateCache(ret.Id, ret, QUEUECHANNEL_CACHE);
                    DocEntityThreadCache<DocEntityQueueChannel>.UpdateCache(ret.Hash, ret, QUEUECHANNEL_CACHE);
                }
            }
            return ret;
        }

        [Field(Nullable = false, DefaultValue = false)]
        public bool AutoDelete { get; set; }


        [Field]
        public DocEntityBackgroundTask BackgroundTask { get; set; }
        public int? BackgroundTaskId { get { return BackgroundTask?.Id; } private set { var noid = value; } }


        [Field]
        public string Description { get; set; }


        [Field(Nullable = false, DefaultValue = true)]
        public bool Durable { get; set; }


        [Field(Nullable = false, DefaultValue = true)]
        public bool Enabled { get; set; }


        [Field(Nullable = false, DefaultValue = true)]
        public bool Exclusive { get; set; }


        [Field(Nullable = false, Length = 200)]
        public string Name { get; set; }



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



        public override ModelNameEnm ClassName => CLASS_NAME;

        public override DocConstantModelName TableName => CLASS_NAME.ToEnumString();

        public const string CACHE_KEY_PREFIX = "FindQueueChannels";


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
                throw new HttpError(HttpStatusCode.Conflict, $"QueueChannel requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();
            _validated = true;
        }

        public override IDocEntity SaveChanges(bool ignoreCache, DocConstantPermission permission)
        {
            Description = Description?.TrimAndPruneSpaces();
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

        public DocValidationMessage ValidationMessage
        {
            get
            {
                var isValid = true;
                var message = string.Empty;

                if(DocTools.IsNullOrEmpty(AutoDelete))
                {
                    isValid = false;
                    message += " AutoDelete is a required property.";
                }
                if(DocTools.IsNullOrEmpty(Durable))
                {
                    isValid = false;
                    message += " Durable is a required property.";
                }
                if(DocTools.IsNullOrEmpty(Enabled))
                {
                    isValid = false;
                    message += " Enabled is a required property.";
                }
                if(DocTools.IsNullOrEmpty(Exclusive))
                {
                    isValid = false;
                    message += " Exclusive is a required property.";
                }
                if(DocTools.IsNullOrEmpty(Name))
                {
                    isValid = false;
                    message += " Name is a required property.";
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }


        public QueueChannel ToDto() => Mapper.Map<DocEntityQueueChannel, QueueChannel>(this);

        public static explicit operator QueueChannel(DocEntityQueueChannel en) => en?.ToDto();

        public override IDto ToIDto() => ToDto();
    }
}
