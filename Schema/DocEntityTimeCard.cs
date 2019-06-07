
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
    [TableMapping(DocConstantModelName.TIMECARD)]
    public partial class DocEntityTimeCard : DocEntityBase
    {
        private const string TIMECARD_CACHE = "TimeCardCache";
        public const ModelNameEnm CLASS_NAME = ModelNameEnm.TIMECARD;

        public DocEntityTimeCard(Session session) : base(session) {}

        public DocEntityTimeCard() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}

        protected override List<string> _select => __vf ?? (__vf = DocWebSession.GetTypeSelect(new TimeCard()));
        public static DocEntityTimeCard Get(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? Get(reference.Id) : null;
        }

        public static DocEntityTimeCard Get(int? primaryKey, bool noCache, DocQuery query)
        {
            if(!(primaryKey > 0)) return null;
            return query.SelectAll<DocEntityTimeCard>().FirstOrDefault(e => e.Id == primaryKey.Value);
        }

        public static DocEntityTimeCard Get(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityTimeCard>.GetFromCache(primaryKey, TIMECARD_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityTimeCard>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityTimeCard>.UpdateCache(ret.Id, ret, TIMECARD_CACHE);
                    DocEntityThreadCache<DocEntityTimeCard>.UpdateCache(ret.Hash, ret, TIMECARD_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityTimeCard Get(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityTimeCard>.GetFromCache(hash, TIMECARD_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityTimeCard>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityTimeCard>.UpdateCache(ret.Id, ret, TIMECARD_CACHE);
                    DocEntityThreadCache<DocEntityTimeCard>.UpdateCache(ret.Hash, ret, TIMECARD_CACHE);
                }
            }
            return ret;
        }

        [Field]
        public string Description { get; set; }


        [Field]
        public DocEntityDocument Document { get; set; }
        public int? DocumentId { get { return Document?.Id; } private set { var noid = value; } }


        [Field(Nullable = false)]
        public DateTime End { get; set; }


        [Field]
        public DocEntityProject Project { get; set; }
        public int? ProjectId { get { return Project?.Id; } private set { var noid = value; } }


        [Field]
        public int? ReferenceId { get; set; }


        [Field(Nullable = false)]
        public DateTime Start { get; set; }


        [Field]
        public DocEntityLookupTable Status { get; set; }
        public int? StatusId { get { return Status?.Id; } private set { var noid = value; } }


        [Field(Nullable = false)]
        public DocEntityUser User { get; set; }
        public int? UserId { get { return User?.Id; } private set { var noid = value; } }


        [Field]
        public DocEntityLookupTable WorkType { get; set; }
        public int? WorkTypeId { get { return WorkType?.Id; } private set { var noid = value; } }



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

        public const string CACHE_KEY_PREFIX = "FindTimeCards";

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
                throw new HttpError(HttpStatusCode.Conflict, $"TimeCard requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();
            _validated = true;
        }

        public override IDocEntity SaveChanges(bool ignoreCache, DocConstantPermission permission)
        {
            Description = Description?.TrimAndPruneSpaces();
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

                if(DocTools.IsNullOrEmpty(End))
                {
                    isValid = false;
                    message += " End is a required property.";
                }
                if(DocTools.IsNullOrEmpty(Start))
                {
                    isValid = false;
                    message += " Start is a required property.";
                }
                if(null != Status && Status?.Enum?.Name != "TimeCardStatus")
                {
                    isValid = false;
                    message += " Status is a " + Status?.Enum?.Name + ", but must be a TimeCardStatus.";
                }
                if(DocTools.IsNullOrEmpty(User))
                {
                    isValid = false;
                    message += " User is a required property.";
                }
                if(null != WorkType && WorkType?.Enum?.Name != "WorkType")
                {
                    isValid = false;
                    message += " WorkType is a " + WorkType?.Enum?.Name + ", but must be a WorkType.";
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }

        public TimeCard ToDto() => Mapper.Map<DocEntityTimeCard, TimeCard>(this);

        public static explicit operator TimeCard(DocEntityTimeCard en) => en?.ToDto();

        public override IDto ToIDto() => ToDto();
    }
}
