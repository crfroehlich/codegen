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

namespace Services.API
{
    public partial class AuditRecordService : DocServiceBase
    {
        private IQueryable<DocEntityAuditRecord> _ExecSearch(AuditRecordSearch request, DocQuery query)
        {
            request = InitSearch<AuditRecord, AuditRecordSearch>(request);
            IQueryable<DocEntityAuditRecord> entities = null;
            query.Run( session => 
            {
                entities = query.SelectAll<DocEntityAuditRecord>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new AuditRecordFullTextSearch(request);
                    entities = GetFullTextSearch<DocEntityAuditRecord,AuditRecordFullTextSearch>(fts, entities);
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
                if(true == request.Archived?.Any() && currentUser.HasProperty(DocConstantModelName.AUDITRECORD, nameof(Reference.Archived), DocConstantPermission.VIEW))
                {
                    entities = entities.Where(en => en.Archived.In(request.Archived));
                }
                else
                {
                    entities = entities.Where(en => !en.Archived);
                }
                if(true == request.Locked?.Any())
                {
                    entities = entities.Where(en => en.Locked.In(request.Locked));
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
                if(true == request.EventsIds?.Any())
                {
                    entities = entities.Where(en => en.Events.Any(r => r.Id.In(request.EventsIds)));
                }
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

                entities = ApplyFilters<DocEntityAuditRecord,AuditRecordSearch>(request, entities);

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

        public object Post(AuditRecordSearch request) => Get(request);

        public object Get(AuditRecordSearch request) => GetSearchResultWithCache<AuditRecord,DocEntityAuditRecord,AuditRecordSearch>(DocConstantModelName.AUDITRECORD, request, _ExecSearch);

        public object Get(AuditRecord request) => GetEntityWithCache<AuditRecord>(DocConstantModelName.AUDITRECORD, request, GetAuditRecord);

        public object Get(AuditRecordJunction request)
        {
            switch(request.Junction.ToLower().TrimAndPruneSpaces())
            {
                    case "auditdelta":
                        return GetJunctionSearchResult<AuditRecord, DocEntityAuditRecord, DocEntityAuditDelta, AuditDelta, AuditDeltaSearch>((int)request.Id, DocConstantModelName.AUDITDELTA, "Deltas", request, (ss) => HostContext.ResolveService<AuditDeltaService>(Request)?.Get(ss));
                    case "event":
                        return GetJunctionSearchResult<AuditRecord, DocEntityAuditRecord, DocEntityEvent, Event, EventSearch>((int)request.Id, DocConstantModelName.EVENT, "Events", request, (ss) => HostContext.ResolveService<EventService>(Request)?.Get(ss));
                    case "tag":
                        return GetJunctionSearchResult<AuditRecord, DocEntityAuditRecord, DocEntityTag, Tag, TagSearch>((int)request.Id, DocConstantModelName.TAG, "Tags", request, (ss) => HostContext.ResolveService<TagService>(Request)?.Get(ss));
                default:
                    throw new HttpError(HttpStatusCode.NotFound, $"Route for auditrecord/{request.Id}/{request.Junction} was not found");
            }
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
    }
}
