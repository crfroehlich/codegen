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
    [TableMapping(DocConstantModelName.BACKGROUNDTASKHISTORY)]
    public partial class DocEntityBackgroundTaskHistory : DocEntityBase
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private const string BACKGROUNDTASKHISTORY_CACHE = "BackgroundTaskHistoryCache";
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public  const ModelNameEnm CLASS_NAME = ModelNameEnm.BACKGROUNDTASKHISTORY;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocEntityBackgroundTaskHistory(Session session) : base(session) {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocEntityBackgroundTaskHistory() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        protected override List<string> _select => __vf ?? (__vf = DocWebSession.GetTypeSelect(new BackgroundTaskHistory()));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public new static DocEntityBackgroundTaskHistory Get(Reference reference) => (true == (reference?.Id > 0)) ? Get(reference.Id) : null;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public new static DocEntityBackgroundTaskHistory Get(int? primaryKey, bool noCache, DocQuery query)
        {
            if(!(primaryKey > 0)) return null;
            return query.SelectAll<DocEntityBackgroundTaskHistory>().FirstOrDefault(e => e.Id == primaryKey.Value);
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public new static DocEntityBackgroundTaskHistory Get(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityBackgroundTaskHistory>.GetFromCache(primaryKey, BACKGROUNDTASKHISTORY_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityBackgroundTaskHistory>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityBackgroundTaskHistory>.UpdateCache(ret.Id, ret, BACKGROUNDTASKHISTORY_CACHE);
                    DocEntityThreadCache<DocEntityBackgroundTaskHistory>.UpdateCache(ret.Hash, ret, BACKGROUNDTASKHISTORY_CACHE);
                }
            }
            return ret;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static DocEntityBackgroundTaskHistory Get(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityBackgroundTaskHistory>.GetFromCache(hash, BACKGROUNDTASKHISTORY_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityBackgroundTaskHistory>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityBackgroundTaskHistory>.UpdateCache(ret.Id, ret, BACKGROUNDTASKHISTORY_CACHE);
                    DocEntityThreadCache<DocEntityBackgroundTaskHistory>.UpdateCache(ret.Hash, ret, BACKGROUNDTASKHISTORY_CACHE);
                }
            }
            return ret;
        }

        [Field(DefaultValue = 0)]
        public int? Completed { get; set; }


        [Field(Length = int.MaxValue)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public byte[] DataCompressed { get; set; }

        private string _Data;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string Data
        {
            get => _Data ?? (_Data = DocZip.Unzip(DataCompressed));
            set
            {
                _Data = value;
                DataCompressed = DocZip.Zip(_Data);
            }
        }


        [Field]
        public DateTime? Ended { get; set; }


        [Field(Length = int.MaxValue)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public byte[] ErrorsCompressed { get; set; }

        private string _Errors;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string Errors
        {
            get => _Errors ?? (_Errors = DocZip.Unzip(ErrorsCompressed));
            set
            {
                _Errors = value;
                ErrorsCompressed = DocZip.Zip(_Errors);
            }
        }


        [Field(DefaultValue = 0)]
        public int? Failed { get; set; }


        [Field]
        [Association(PairTo = nameof(DocEntityBackgroundTaskItem.TaskHistory), OnOwnerRemove = OnRemoveAction.Cascade, OnTargetRemove = OnRemoveAction.Clear)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocEntitySet<DocEntityBackgroundTaskItem> Items { get; private set; }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> ItemsIds => Items.Select(e => e.Id).ToList();
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? ItemsCount { get { return Items.Count(); } private set { var noid = value; } }


        [Field(Length = int.MaxValue)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public byte[] LogsCompressed { get; set; }

        private string _Logs;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string Logs
        {
            get => _Logs ?? (_Logs = DocZip.Unzip(LogsCompressed));
            set
            {
                _Logs = value;
                LogsCompressed = DocZip.Zip(_Logs);
            }
        }


        [Field(DefaultValue = false)]
        public bool? Succeeded { get; set; }


        [Field(Length = int.MaxValue)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public byte[] SummaryCompressed { get; set; }

        private string _Summary;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string Summary
        {
            get => _Summary ?? (_Summary = DocZip.Unzip(SummaryCompressed));
            set
            {
                _Summary = value;
                SummaryCompressed = DocZip.Zip(_Summary);
            }
        }


        [Field(Nullable = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocEntityBackgroundTask Task { get; set; }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? TaskId { get { return Task?.Id; } private set { var noid = value; } }



        [Field]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override string Gestalt { get; set; }

        [Field(DefaultValue = 0), Version(VersionMode.Manual)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override int VersionNo { get; set; }

        [Field]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override DateTime? Created { get; set; }

        [Field]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override DateTime? Updated { get; set; }

        [Field(DefaultValue = false), FieldMapping(nameof(Locked))]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override bool Locked { get; set; }

        [Field(DefaultValue = false), FieldMapping(nameof(Archived))]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override bool Archived { get; set; }

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override ModelNameEnm ClassName => CLASS_NAME;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override DocConstantModelName TableName => CLASS_NAME.ToEnumString();
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public const string CACHE_KEY_PREFIX = "FindBackgroundTaskHistorys";

        /// <summary>
        ///    Called when entity is about to be removed.
        /// </summary>
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        protected override void OnRemoving()
        {
            base.OnRemoving();
            try
            {
                Items.Clear(); //foreach thing in Items en.Remove();
            }
            catch(Exception ex)
            {
                throw new DocException("Failed to delete BackgroundTaskHistory in Items delete", ex);
            }
            FlushCache();
        }

        /// <summary>
        ///    Called when entity should be validated. Override this method to perform custom object validation.
        /// </summary>
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        protected override void OnValidate()
        {
            if (false == ValidationMessage.IsValid)
            {
                throw new HttpError(HttpStatusCode.Conflict, $"BackgroundTaskHistory requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();
            _validated = true;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override IDocEntity SaveChanges(bool ignoreCache, DocConstantPermission permission)
        {

            return base.SaveChanges(ignoreCache, permission);
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override IDocEntity SaveChanges(bool ignoreCache) => SaveChanges(ignoreCache, DocConstantPermission.EDIT);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override IDocEntity SaveChanges(DocConstantPermission permission) => SaveChanges(false, DocConstantPermission.EDIT);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override IDocEntity SaveChanges() => SaveChanges(DocConstantPermission.EDIT);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override void FlushCache()
        {
            base.FlushCache();

        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocValidationMessage ValidationMessage
        {
            get
            {
                var isValid = true;
                var message = string.Empty;

                if(DocTools.IsNullOrEmpty(Task))
                {
                    isValid = false;
                    message += " Task is a required property.";
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public BackgroundTaskHistory ToDto() => Mapper.Map<DocEntityBackgroundTaskHistory, BackgroundTaskHistory>(this);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static explicit operator BackgroundTaskHistory(DocEntityBackgroundTaskHistory en) => en?.ToDto();

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override IDto ToIDto() => ToDto();
    }
}
