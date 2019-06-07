
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
    [TableMapping(DocConstantModelName.INTERVAL)]
    public partial class DocEntityInterval : DocEntityBase
    {
        private const string INTERVAL_CACHE = "IntervalCache";
        public const ModelNameEnm CLASS_NAME = ModelNameEnm.INTERVAL;
        
        public DocEntityInterval(Session session) : base(session) {}

        public DocEntityInterval() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}

        protected override List<string> _select => __vf ?? (__vf = DocWebSession.GetTypeSelect(new Interval()));

        public static DocEntityInterval Get(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? Get(reference.Id) : null;
        }

        public static DocEntityInterval Get(int? primaryKey, bool noCache, DocQuery query)
        {
            if(!(primaryKey > 0)) return null;
            return query.SelectAll<DocEntityInterval>().FirstOrDefault(e => e.Id == primaryKey.Value);
        }

        public static DocEntityInterval Get(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityInterval>.GetFromCache(primaryKey, INTERVAL_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityInterval>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityInterval>.UpdateCache(ret.Id, ret, INTERVAL_CACHE);
                    DocEntityThreadCache<DocEntityInterval>.UpdateCache(ret.Hash, ret, INTERVAL_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityInterval Get(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityInterval>.GetFromCache(hash, INTERVAL_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityInterval>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityInterval>.UpdateCache(ret.Id, ret, INTERVAL_CACHE);
                    DocEntityThreadCache<DocEntityInterval>.UpdateCache(ret.Hash, ret, INTERVAL_CACHE);
                }
            }
            return ret;
        }

        [Field]
        public DocEntityDateTime CalendarDateEnd { get; set; }
        public int? CalendarDateEndId { get { return CalendarDateEnd?.Id; } private set { var noid = value; } }


        [Field]
        public DocEntityDateTime CalendarDateStart { get; set; }
        public int? CalendarDateStartId { get { return CalendarDateStart?.Id; } private set { var noid = value; } }


        [Field]
        public string CalendarType { get; set; }


        [Field]
        public DocEntityTimePoint FollowUp { get; set; }
        public int? FollowUpId { get { return FollowUp?.Id; } private set { var noid = value; } }


        [Field]
        public DocEntityTimePoint TimeOfDay { get; set; }
        public int? TimeOfDayId { get { return TimeOfDay?.Id; } private set { var noid = value; } }



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

        public const string CACHE_KEY_PREFIX = "FindIntervals";


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
                throw new HttpError(HttpStatusCode.Conflict, $"Interval requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();
            _validated = true;
        }

        public override IDocEntity SaveChanges(bool ignoreCache, DocConstantPermission permission)
        {
            CalendarType = CalendarType?.TrimAndPruneSpaces();
            return base.SaveChanges(ignoreCache, permission);
        }

        public override IDocEntity SaveChanges(bool ignoreCache) => SaveChanges(ignoreCache, DocConstantPermission.EDIT);
        public override IDocEntity SaveChanges(DocConstantPermission permission) => SaveChanges(false, DocConstantPermission.EDIT);
        public override IDocEntity SaveChanges() => SaveChanges(DocConstantPermission.EDIT);

        public override void FlushCache()
        {
            base.FlushCache();

        }

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


        public Interval ToDto() => Mapper.Map<DocEntityInterval, Interval>(this);

        public static explicit operator Interval(DocEntityInterval en) => en?.ToDto();

        public override IDto ToIDto() => ToDto();
    }
}
