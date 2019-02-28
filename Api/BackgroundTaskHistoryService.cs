//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated by a T4 template. This class can be only customized modifying the corresponding partial class.
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
    public partial class BackgroundTaskHistoryService : DocServiceBase
    {
        private IQueryable<DocEntityBackgroundTaskHistory> _ExecSearch(BackgroundTaskHistorySearch request)
        {
            request = InitSearch<BackgroundTaskHistory, BackgroundTaskHistorySearch>(request);
            IQueryable<DocEntityBackgroundTaskHistory> entities = null;
            Execute.Run( session => 
            {
                entities = Execute.SelectAll<DocEntityBackgroundTaskHistory>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new BackgroundTaskHistoryFullTextSearch(request);
                    entities = GetFullTextSearch<DocEntityBackgroundTaskHistory,BackgroundTaskHistoryFullTextSearch>(fts, entities);
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
                if(true == request.Archived?.Any() && currentUser.HasProperty(DocConstantModelName.BACKGROUNDTASKHISTORY, nameof(Reference.Archived), DocConstantPermission.VIEW))
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

                if(request.Completed.HasValue)
                    entities = entities.Where(en => request.Completed.Value == en.Completed);
                if(!DocTools.IsNullOrEmpty(request.Ended))
                    entities = entities.Where(en => null != en.Ended && request.Ended.Value.Date == en.Ended.Value.Date);
                if(!DocTools.IsNullOrEmpty(request.EndedBefore))
                    entities = entities.Where(en => en.Ended <= request.EndedBefore);
                if(!DocTools.IsNullOrEmpty(request.EndedAfter))
                    entities = entities.Where(en => en.Ended >= request.EndedAfter);
                if(request.Failed.HasValue)
                    entities = entities.Where(en => request.Failed.Value == en.Failed);
                if(true == request.ItemsIds?.Any())
                {
                    entities = entities.Where(en => en.Items.Any(r => r.Id.In(request.ItemsIds)));
                }
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

                entities = ApplyFilters<DocEntityBackgroundTaskHistory,BackgroundTaskHistorySearch>(request, entities);

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

        public List<BackgroundTaskHistory> Post(BackgroundTaskHistorySearch request) => Get(request);

        public List<BackgroundTaskHistory> Get(BackgroundTaskHistorySearch request) => GetSearchResult<BackgroundTaskHistory,DocEntityBackgroundTaskHistory,BackgroundTaskHistorySearch>(DocConstantModelName.BACKGROUNDTASKHISTORY, request, _ExecSearch);

        public BackgroundTaskHistory Get(BackgroundTaskHistory request) => GetEntity<BackgroundTaskHistory>(DocConstantModelName.BACKGROUNDTASKHISTORY, request, GetBackgroundTaskHistory);
        public object Get(BackgroundTaskHistoryJunction request) =>
            Execute.Run( s => 
            {
                switch(request.Junction.ToLower().TrimAndPruneSpaces())
                {
                    case "backgroundtaskitem":
                        return GetJunctionSearchResult<BackgroundTaskHistory, DocEntityBackgroundTaskHistory, DocEntityBackgroundTaskItem, BackgroundTaskItem, BackgroundTaskItemSearch>((int)request.Id, DocConstantModelName.BACKGROUNDTASKITEM, "Items", request, (ss) => HostContext.ResolveService<BackgroundTaskItemService>(Request)?.Get(ss));
                    default:
                        throw new HttpError(HttpStatusCode.NotFound, $"Route for backgroundtaskhistory/{request.Id}/{request.Junction} was not found");
                }
            });
        private BackgroundTaskHistory GetBackgroundTaskHistory(BackgroundTaskHistory request)
        {
            var id = request?.Id;
            BackgroundTaskHistory ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetVisibleFields<BackgroundTaskHistory>(currentUser, "BackgroundTaskHistory", request.VisibleFields);

            DocEntityBackgroundTaskHistory entity = null;
            if(id.HasValue)
            {
                entity = DocEntityBackgroundTaskHistory.GetBackgroundTaskHistory(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No BackgroundTaskHistory found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }
    }
}
