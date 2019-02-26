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
using Services.Dto.Security;
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
    public partial class BackgroundTaskItemService : DocServiceBase
    {
        private IQueryable<DocEntityBackgroundTaskItem> _ExecSearch(BackgroundTaskItemSearch request)
        {
            request = InitSearch<BackgroundTaskItem, BackgroundTaskItemSearch>(request);
            IQueryable<DocEntityBackgroundTaskItem> entities = null;
            Execute.Run( session => 
            {
                entities = Execute.SelectAll<DocEntityBackgroundTaskItem>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new BackgroundTaskItemFullTextSearch(request);
                    entities = GetFullTextSearch<DocEntityBackgroundTaskItem,BackgroundTaskItemFullTextSearch>(fts, entities);
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
                if(true == request.Archived?.Any() && currentUser.HasProperty(DocConstantModelName.BACKGROUNDTASKITEM, nameof(Reference.Archived), DocConstantPermission.VIEW))
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

                if(request.Attempts.HasValue)
                    entities = entities.Where(en => request.Attempts.Value == en.Attempts);
                if(!DocTools.IsNullOrEmpty(request.AuditRecord) && !DocTools.IsNullOrEmpty(request.AuditRecord.Id))
                {
                    entities = entities.Where(en => en.AuditRecord.Id == request.AuditRecord.Id );
                }
                if(true == request.AuditRecordIds?.Any())
                {
                    entities = entities.Where(en => en.AuditRecord.Id.In(request.AuditRecordIds));
                }
                if(!DocTools.IsNullOrEmpty(request.Description))
                    entities = entities.Where(en => en.Description.Contains(request.Description));
                if(!DocTools.IsNullOrEmpty(request.Ended))
                    entities = entities.Where(en => null != en.Ended && request.Ended.Value.Date == en.Ended.Value.Date);
                if(!DocTools.IsNullOrEmpty(request.EndedBefore))
                    entities = entities.Where(en => en.Ended <= request.EndedBefore);
                if(!DocTools.IsNullOrEmpty(request.EndedAfter))
                    entities = entities.Where(en => en.Ended >= request.EndedAfter);
                if(request.EntityId.HasValue)
                    entities = entities.Where(en => request.EntityId.Value == en.EntityId);
                if(!DocTools.IsNullOrEmpty(request.ExecutionTime))
                    entities = entities.Where(en => en.ExecutionTime.Contains(request.ExecutionTime));
                if(!DocTools.IsNullOrEmpty(request.Started))
                    entities = entities.Where(en => null != en.Started && request.Started.Value.Date == en.Started.Value.Date);
                if(!DocTools.IsNullOrEmpty(request.StartedBefore))
                    entities = entities.Where(en => en.Started <= request.StartedBefore);
                if(!DocTools.IsNullOrEmpty(request.StartedAfter))
                    entities = entities.Where(en => en.Started >= request.StartedAfter);
                if(!DocTools.IsNullOrEmpty(request.Status))
                    entities = entities.Where(en => en.Status.Contains(request.Status));
                if(true == request.Succeeded?.Any())
                {
                    if(request.Succeeded.Any(v => v == null)) entities = entities.Where(en => en.Succeeded.In(request.Succeeded) || en.Succeeded == null);
                    else entities = entities.Where(en => en.Succeeded.In(request.Succeeded));
                }
                if(!DocTools.IsNullOrEmpty(request.Task) && !DocTools.IsNullOrEmpty(request.Task.Id))
                {
                    entities = entities.Where(en => en.Task.Id == request.Task.Id );
                }
                if(true == request.TaskIds?.Any())
                {
                    entities = entities.Where(en => en.Task.Id.In(request.TaskIds));
                }
                if(true == request.TaskHistoryIds?.Any())
                {
                    entities = entities.Where(en => en.TaskHistory.Any(r => r.Id.In(request.TaskHistoryIds)));
                }

                entities = ApplyFilters<DocEntityBackgroundTaskItem,BackgroundTaskItemSearch>(request, entities);

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

        public List<BackgroundTaskItem> Post(BackgroundTaskItemSearch request) => Get(request);

        public List<BackgroundTaskItem> Get(BackgroundTaskItemSearch request) => GetSearchResult<BackgroundTaskItem,DocEntityBackgroundTaskItem,BackgroundTaskItemSearch>(DocConstantModelName.BACKGROUNDTASKITEM, request, _ExecSearch);

        public BackgroundTaskItem Get(BackgroundTaskItem request) => GetEntity<BackgroundTaskItem>(DocConstantModelName.BACKGROUNDTASKITEM, request, GetBackgroundTaskItem);
        public object Get(BackgroundTaskItemJunction request) =>
            Execute.Run( s => 
            {
                switch(request.Junction.ToLower().TrimAndPruneSpaces())
                {
                    case "backgroundtaskhistory":
                        return GetJunctionSearchResult<BackgroundTaskItem, DocEntityBackgroundTaskItem, DocEntityBackgroundTaskHistory, BackgroundTaskHistory, BackgroundTaskHistorySearch>((int)request.Id, DocConstantModelName.BACKGROUNDTASKHISTORY, "TaskHistory", request, (ss) => HostContext.ResolveService<BackgroundTaskHistoryService>(Request)?.Get(ss));
                    default:
                        throw new HttpError(HttpStatusCode.NotFound, $"Route for backgroundtaskitem/{request.Id}/{request.Junction} was not found");
                }
            });
        private BackgroundTaskItem GetBackgroundTaskItem(BackgroundTaskItem request)
        {
            var id = request?.Id;
            BackgroundTaskItem ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetVisibleFields<BackgroundTaskItem>(currentUser, "BackgroundTaskItem", request.VisibleFields);

            DocEntityBackgroundTaskItem entity = null;
            if(id.HasValue)
            {
                entity = DocEntityBackgroundTaskItem.GetBackgroundTaskItem(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No BackgroundTaskItem found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }
    }
}