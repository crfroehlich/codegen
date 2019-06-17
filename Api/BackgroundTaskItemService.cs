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

using Services.Core;
using Services.Db;
using Services.Dto;
using Services.Enums;
using Services.Schema;

using ServiceStack;
using ServiceStack.Text;

using Typed;
using Typed.Bindings;
using Typed.Notifications;

using Xtensive.Orm;


namespace Services.API
{
    public partial class BackgroundTaskItemService : DocServiceBase
    {

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private IQueryable<DocEntityBackgroundTaskItem> _ExecSearch(BackgroundTaskItemSearch request, DocQuery query)
        {
            request = InitSearch<BackgroundTaskItem, BackgroundTaskItemSearch>(request);
            IQueryable<DocEntityBackgroundTaskItem> entities = null;
            query.Run( session => 
            {
                entities = query.SelectAll<DocEntityBackgroundTaskItem>();
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
                if(!DocTools.IsNullOrEmpty(request.Descriptions))
                    entities = entities.Where(en => en.Description.In(request.Descriptions));
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
                if(!DocTools.IsNullOrEmpty(request.ExecutionTimes))
                    entities = entities.Where(en => en.ExecutionTime.In(request.ExecutionTimes));
                if(!DocTools.IsNullOrEmpty(request.Started))
                    entities = entities.Where(en => null != en.Started && request.Started.Value.Date == en.Started.Value.Date);
                if(!DocTools.IsNullOrEmpty(request.StartedBefore))
                    entities = entities.Where(en => en.Started <= request.StartedBefore);
                if(!DocTools.IsNullOrEmpty(request.StartedAfter))
                    entities = entities.Where(en => en.Started >= request.StartedAfter);
                if(!DocTools.IsNullOrEmpty(request.Status))
                    entities = entities.Where(en => en.Status.Contains(request.Status));
                if(!DocTools.IsNullOrEmpty(request.Statuss))
                    entities = entities.Where(en => en.Status.In(request.Statuss));
                if(true == request.Succeeded?.Any())
                {
                    entities = entities.Where(en => en.Succeeded.In(request.Succeeded));
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
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Post(BackgroundTaskItemSearch request) => Get(request);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Get(BackgroundTaskItemSearch request) => GetSearchResultWithCache<BackgroundTaskItem,DocEntityBackgroundTaskItem,BackgroundTaskItemSearch>(DocConstantModelName.BACKGROUNDTASKITEM, request, _ExecSearch);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Get(BackgroundTaskItem request) => GetEntityWithCache<BackgroundTaskItem>(DocConstantModelName.BACKGROUNDTASKITEM, request, GetBackgroundTaskItem);








        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Get(BackgroundTaskItemJunction request)
        {
            switch(request.Junction.ToLower().TrimAndPruneSpaces())
            {
                    case "comment":
                        return GetJunctionSearchResult<BackgroundTaskItem, DocEntityBackgroundTaskItem, DocEntityComment, Comment, CommentSearch>((int)request.Id, DocConstantModelName.COMMENT, "Comments", request, (ss) => HostContext.ResolveService<CommentService>(Request)?.Get(ss));
                    case "favorite":
                        return GetJunctionSearchResult<BackgroundTaskItem, DocEntityBackgroundTaskItem, DocEntityFavorite, Favorite, FavoriteSearch>((int)request.Id, DocConstantModelName.FAVORITE, "Favorites", request, (ss) => HostContext.ResolveService<FavoriteService>(Request)?.Get(ss));
                    case "tag":
                        return GetJunctionSearchResult<BackgroundTaskItem, DocEntityBackgroundTaskItem, DocEntityTag, Tag, TagSearch>((int)request.Id, DocConstantModelName.TAG, "Tags", request, (ss) => HostContext.ResolveService<TagService>(Request)?.Get(ss));
                    case "backgroundtaskhistory":
                        return GetJunctionSearchResult<BackgroundTaskItem, DocEntityBackgroundTaskItem, DocEntityBackgroundTaskHistory, BackgroundTaskHistory, BackgroundTaskHistorySearch>((int)request.Id, DocConstantModelName.BACKGROUNDTASKHISTORY, "TaskHistory", request, (ss) => HostContext.ResolveService<BackgroundTaskHistoryService>(Request)?.Get(ss));
                default:
                    throw new HttpError(HttpStatusCode.NotFound, $"Route for backgroundtaskitem/{request.Id}/{request.Junction} was not found");
            }
        }



        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private BackgroundTaskItem GetBackgroundTaskItem(BackgroundTaskItem request)
        {
            var id = request?.Id;
            BackgroundTaskItem ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetSelect<BackgroundTaskItem>(currentUser, "BackgroundTaskItem", request.Select);

            DocEntityBackgroundTaskItem entity = null;
            if(id.HasValue)
            {
                entity = DocEntityBackgroundTaskItem.Get(id.Value);
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
