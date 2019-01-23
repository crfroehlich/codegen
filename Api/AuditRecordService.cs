﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when
//    the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AutoMapper;

using Services.Core;
using Services.Db;
using Services.Dto;
using Services.Enums;
using Services.Models;
using Services.Schema;

using Typed;
using Typed.Bindings;
using Typed.Notifications;
using Typed.Settings;

using ServiceStack;
using ServiceStack.Text;

using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Dynamic;
using System.Net;
using System.Web;

using Xtensive.Orm;
using Xtensive.Orm.Model;

using Attribute = Services.Dto.Attribute;
using ValueType = Services.Dto.ValueType;
using Version = Services.Dto.Version;

namespace Services.API
{
    public partial class AuditRecordService : DocServiceBase
    {
        private IQueryable<DocEntityAuditRecord> _ExecSearch(AuditRecordSearch request)
        {
            request = InitSearch(request);
            
            IQueryable<DocEntityAuditRecord> entities = null;
            
            DocPermissionFactory.SetVisibleFields<AuditRecord>(currentUser, "AuditRecord", request.VisibleFields);

            Execute.Run( session => 
            {
                entities = Execute.SelectAll<DocEntityAuditRecord>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new AuditRecordFullTextSearch(request);
                    entities = GetFullTextSearch(fts, entities);
                }

                if(null != request.Ids && request.Ids.Any())
                    entities = entities.Where(en => en.Id.In(request.Ids));

                if (!DocTools.IsNullOrEmpty(request.Updated))
                {
                    entities = entities.Where(e => null != e.Updated && e.Updated.Value.Date == request.Updated.Value.Date);
                }
                if (!DocTools.IsNullOrEmpty(request.UpdatedBefore))
                {
                    entities = entities.Where(e => null != e.Updated && e.Updated <= request.UpdatedBefore);
                }
                if( !DocTools.IsNullOrEmpty( request.UpdatedAfter ) )
                {
                    entities = entities.Where(e => null != e.Updated && e.Updated >= request.UpdatedAfter);
                }
                if (!DocTools.IsNullOrEmpty(request.Created))
                {
                    entities = entities.Where(e => null!= e.Created && e.Created.Value.Date == request.Created.Value.Date);
                }
                if (!DocTools.IsNullOrEmpty(request.CreatedBefore))
                {
                    entities = entities.Where(e => null!= e.Created && e.Created <= request.CreatedBefore);
                }
                if( !DocTools.IsNullOrEmpty( request.CreatedAfter ) )
                {
                    entities = entities.Where(e => null!= e.Created && e.Created >= request.CreatedAfter);
                }

                if(!DocTools.IsNullOrEmpty(request.Action))
                    entities = entities.Where(en => en.Action.Contains(request.Action));
                if(!DocTools.IsNullOrEmpty(request.BackgroundTask) && !DocTools.IsNullOrEmpty(request.BackgroundTask.Id))
                {
                    entities = entities.Where(en => en.BackgroundTask.Id == request.BackgroundTask.Id );
                }
                if(true == request.BackgroundTaskIds?.Any())
                {
                    entities = entities.Where(en => en.BackgroundTask.Id.In(request.BackgroundTaskIds));
                }
                if(!DocTools.IsNullOrEmpty(request.ChangedOnDate))
                    entities = entities.Where(en => request.ChangedOnDate.Value.Date == en.ChangedOnDate.Date);
                if(!DocTools.IsNullOrEmpty(request.ChangedOnDateBefore))
                    entities = entities.Where(en => en.ChangedOnDate <= request.ChangedOnDateBefore);
                if(!DocTools.IsNullOrEmpty(request.ChangedOnDateAfter))
                    entities = entities.Where(en => en.ChangedOnDate >= request.ChangedOnDateAfter);
                if(!DocTools.IsNullOrEmpty(request.DatabaseSessionId))
                    entities = entities.Where(en => en.DatabaseSessionId.Contains(request.DatabaseSessionId));
                        if(true == request.DeltasIds?.Any())
                        {
                            entities = entities.Where(en => en.Deltas.Any(r => r.Id.In(request.DeltasIds)));
                        }
                if(request.EntityId.HasValue)
                    entities = entities.Where(en => request.EntityId.Value == en.EntityId);
                if(!DocTools.IsNullOrEmpty(request.EntityType))
                    entities = entities.Where(en => en.EntityType.Contains(request.EntityType));
                if(request.EntityVersion.HasValue)
                    entities = entities.Where(en => request.EntityVersion.Value == en.EntityVersion);
                if(!DocTools.IsNullOrEmpty(request.Impersonation) && !DocTools.IsNullOrEmpty(request.Impersonation.Id))
                {
                    entities = entities.Where(en => en.Impersonation.Id == request.Impersonation.Id );
                }
                if(true == request.ImpersonationIds?.Any())
                {
                    entities = entities.Where(en => en.Impersonation.Id.In(request.ImpersonationIds));
                }
                if(request.TargetId.HasValue)
                    entities = entities.Where(en => request.TargetId.Value == en.TargetId);
                if(!DocTools.IsNullOrEmpty(request.TargetType))
                    entities = entities.Where(en => en.TargetType.Contains(request.TargetType));
                if(request.TargetVersion.HasValue)
                    entities = entities.Where(en => request.TargetVersion.Value == en.TargetVersion);
                if(!DocTools.IsNullOrEmpty(request.User) && !DocTools.IsNullOrEmpty(request.User.Id))
                {
                    entities = entities.Where(en => en.User.Id == request.User.Id );
                }
                if(true == request.UserIds?.Any())
                {
                    entities = entities.Where(en => en.User.Id.In(request.UserIds));
                }
                if(!DocTools.IsNullOrEmpty(request.UserSession) && !DocTools.IsNullOrEmpty(request.UserSession.Id))
                {
                    entities = entities.Where(en => en.UserSession.Id == request.UserSession.Id );
                }
                if(true == request.UserSessionIds?.Any())
                {
                    entities = entities.Where(en => en.UserSession.Id.In(request.UserSessionIds));
                }

                entities = ApplyFilters(request, entities);

                if(request.Skip > 0)
                    entities = entities.Skip(request.Skip.Value);
                if(request.Take > 0)
                    entities = entities.Take(request.Take.Value);
                if(true == request?.OrderBy?.Any())
                    entities = entities.OrderBy(request.OrderBy);
                if(true == request?.OrderByDesc?.Any())
                    entities = entities.OrderByDescending(request.OrderByDesc);
            });
            
            return entities;
        }

        public List<AuditRecord> Post(AuditRecordSearch request) => Get(request);

        public List<AuditRecord> Get(AuditRecordSearch request) => GetSearchResult<AuditRecord,DocEntityAuditRecord,AuditRecordSearch>(DocConstantModelName.AUDITRECORD, request, _ExecSearch);

        public object Post(AuditRecordVersion request) => Get(request);

        public object Get(AuditRecordVersion request) 
        {
            List<Version> ret = null;
            Execute.Run(s=>
            {
                ret = _ExecSearch(request).Select(e => new Version(e.Id, e.VersionNo)).ToList();
            });
            return ret;
        }

        public AuditRecord Get(AuditRecord request) => GetEntity<AuditRecord>(DocConstantModelName.AUDITRECORD, request, GetAuditRecord);



        public object Get(AuditRecordJunction request)
        {
            if(!(request.Id > 0))
                throw new HttpError(HttpStatusCode.NotFound, "Valid Id required.");
            object ret = null;
            var skip = (request.Skip > 0) ? request.Skip.Value : 0;
            var take = (request.Take > 0) ? request.Take.Value : int.MaxValue;
                        
            var info = Request.PathInfo.Split('?')[0].Split('/');
            var method = info[info.Length-1]?.ToLower().Trim();
            Execute.Run( s => 
            {
                switch(method)
                {
                case "auditdelta":
                    ret = _GetAuditRecordAuditDelta(request, skip, take);
                    break;
                }
            });
            return ret;
        }
        
        public object Get(AuditRecordJunctionVersion request)
        {
            if(!(request.Id > 0))
                throw new HttpError(HttpStatusCode.NotFound, "Valid Id required.");
            var ret = new List<Version>();
            
            var info = Request.PathInfo.Split('?')[0].Split('/');
            var method = info[info.Length-2]?.ToLower().Trim();
            Execute.Run( ssn =>
            {
                switch(method)
                {
                }
            });
            return ret;
        }
        

        private object _GetAuditRecordAuditDelta(AuditRecordJunction request, int skip, int take)
        {
             request.VisibleFields = InitVisibleFields<AuditDelta>(Dto.AuditDelta.Fields, request.VisibleFields);
             var en = DocEntityAuditRecord.GetAuditRecord(request.Id);
             if (!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.VIEW, targetName: DocConstantModelName.AUDITRECORD, columnName: "Deltas", targetEntity: null))
                 throw new HttpError(HttpStatusCode.Forbidden, "You do not have View permission to relationships between AuditRecord and AuditDelta");
             return en?.Deltas.Take(take).Skip(skip).ConvertFromEntityList<DocEntityAuditDelta,AuditDelta>(new List<AuditDelta>());
        }
        
        public object Post(AuditRecordJunction request)
        {
            if (request == null)
                throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");
            if (!(request.Id > 0))
                throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the {className} to update.");
            if (request.Ids == null || request.Ids.Count < 1)
                throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid list of {type} Ids.");

            object ret = null;

            Execute.Run( ssn =>
            {
                var info = Request.PathInfo.Split('/');
                var method = info[info.Length-1];
                switch(method)
                {
                }
            });
            return ret;
        }


        public object Delete(AuditRecordJunction request)
        {
            if (request == null)
                throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");
            if (!(request.Id > 0))
                throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the {className} to update.");
            if (request.Ids == null || request.Ids.Count < 1)
                throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid list of {type} Ids.");

            object ret = null;

            Execute.Run( ssn =>
            {
                var info = Request.PathInfo.Split('/');
                var method = info[info.Length-1];
                switch(method)
                {
                }
            });
            return ret;
        }


        private AuditRecord GetAuditRecord(AuditRecord request)
        {
            var id = request?.Id;
            AuditRecord ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetVisibleFields<AuditRecord>(currentUser, "AuditRecord", request.VisibleFields);

            DocEntityAuditRecord entity = null;
            if(id.HasValue)
            {
                entity = DocEntityAuditRecord.GetAuditRecord(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No AuditRecord found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }

        public List<int> Any(AuditRecordIds request)
        {
            List<int> ret = null;
            if (currentUser.IsSuperAdmin)
            {
                Execute.Run(s => { ret = Execute.SelectAll<DocEntityAuditRecord>().Select(d => d.Id).ToList(); });
            }
            else
            {
                throw new HttpError(HttpStatusCode.Forbidden);
            }

            return ret;
        }
    }
}