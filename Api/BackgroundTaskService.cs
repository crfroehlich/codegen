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
    public partial class BackgroundTaskService : DocServiceBase
    {

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private IQueryable<DocEntityBackgroundTask> _ExecSearch(BackgroundTaskSearch request, DocQuery query)
        {
            request = InitSearch<BackgroundTask, BackgroundTaskSearch>(request);
            IQueryable<DocEntityBackgroundTask> entities = null;
            query.Run( session => 
            {
                entities = query.SelectAll<DocEntityBackgroundTask>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new BackgroundTaskFullTextSearch(request);
                    entities = GetFullTextSearch<DocEntityBackgroundTask,BackgroundTaskFullTextSearch>(fts, entities);
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
                if(true == request.Archived?.Any() && currentUser.HasProperty(DocConstantModelName.BACKGROUNDTASK, nameof(Reference.Archived), DocConstantPermission.VIEW))
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
                if(!DocTools.IsNullOrEmpty(request.App) && !DocTools.IsNullOrEmpty(request.App.Id))
                {
                    entities = entities.Where(en => en.App.Id == request.App.Id );
                }
                if(true == request.AppIds?.Any())
                {
                    entities = entities.Where(en => en.App.Id.In(request.AppIds));
                }
                if(!DocTools.IsNullOrEmpty(request.Channel) && !DocTools.IsNullOrEmpty(request.Channel.Id))
                {
                    entities = entities.Where(en => en.Channel.Id == request.Channel.Id );
                }
                if(true == request.ChannelIds?.Any())
                {
                    entities = entities.Where(en => en.Channel.Id.In(request.ChannelIds));
                }
                if(!DocTools.IsNullOrEmpty(request.Description))
                    entities = entities.Where(en => en.Description.Contains(request.Description));
                if(!DocTools.IsNullOrEmpty(request.Descriptions))
                    entities = entities.Where(en => en.Description.In(request.Descriptions));
                if(true == request.Enabled?.Any())
                {
                    entities = entities.Where(en => en.Enabled.In(request.Enabled));
                }
                if(request.Frequency.HasValue)
                    entities = entities.Where(en => request.Frequency.Value == en.Frequency);
                if(request.HistoryRetention.HasValue)
                    entities = entities.Where(en => request.HistoryRetention.Value == en.HistoryRetention);
                if(true == request.ItemsIds?.Any())
                {
                    entities = entities.Where(en => en.Items.Any(r => r.Id.In(request.ItemsIds)));
                }
                if(true == request.KeepHistory?.Any())
                {
                    entities = entities.Where(en => en.KeepHistory.In(request.KeepHistory));
                }
                if(!DocTools.IsNullOrEmpty(request.LastRunVersion))
                    entities = entities.Where(en => en.LastRunVersion.Contains(request.LastRunVersion));
                if(!DocTools.IsNullOrEmpty(request.LastRunVersions))
                    entities = entities.Where(en => en.LastRunVersion.In(request.LastRunVersions));
                if(true == request.LogError?.Any())
                {
                    entities = entities.Where(en => en.LogError.In(request.LogError));
                }
                if(true == request.LogInfo?.Any())
                {
                    entities = entities.Where(en => en.LogInfo.In(request.LogInfo));
                }
                if(!DocTools.IsNullOrEmpty(request.Name))
                    entities = entities.Where(en => en.Name.Contains(request.Name));
                if(!DocTools.IsNullOrEmpty(request.Names))
                    entities = entities.Where(en => en.Name.In(request.Names));
                if(request.RowsToProcessPerIteration.HasValue)
                    entities = entities.Where(en => request.RowsToProcessPerIteration.Value == en.RowsToProcessPerIteration);
                if(true == request.RunNow?.Any())
                {
                    entities = entities.Where(en => en.RunNow.In(request.RunNow));
                }
                if(!DocTools.IsNullOrEmpty(request.StartAt))
                    entities = entities.Where(en => en.StartAt.Contains(request.StartAt));
                if(!DocTools.IsNullOrEmpty(request.StartAts))
                    entities = entities.Where(en => en.StartAt.In(request.StartAts));
                if(true == request.TaskHistoryIds?.Any())
                {
                    entities = entities.Where(en => en.TaskHistory.Any(r => r.Id.In(request.TaskHistoryIds)));
                }

                entities = ApplyFilters<DocEntityBackgroundTask,BackgroundTaskSearch>(request, entities);

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
        public object Post(BackgroundTaskSearch request) => Get(request);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Get(BackgroundTaskSearch request) => GetSearchResultWithCache<BackgroundTask,DocEntityBackgroundTask,BackgroundTaskSearch>(DocConstantModelName.BACKGROUNDTASK, request, _ExecSearch);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Get(BackgroundTask request) => GetEntityWithCache<BackgroundTask>(DocConstantModelName.BACKGROUNDTASK, request, GetBackgroundTask);



        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private BackgroundTask _AssignValues(BackgroundTask request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "BackgroundTask"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.Select = request.Select ?? new List<string>();

            BackgroundTask ret = null;
            request = _InitAssignValues<BackgroundTask>(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            var cacheKey = GetApiCacheKey<BackgroundTask>(DocConstantModelName.BACKGROUNDTASK, nameof(BackgroundTask), request);
            
            //First, assign all the variables, do database lookups and conversions
            var pApp = DocEntityApp.Get(request.App?.Id, true, Execute) ?? DocEntityApp.Get(request.AppId, true, Execute);
            var pChannel = DocEntityQueueChannel.Get(request.Channel?.Id, true, Execute) ?? DocEntityQueueChannel.Get(request.ChannelId, true, Execute);
            var pDescription = request.Description;
            var pEnabled = request.Enabled;
            var pFrequency = request.Frequency;
            var pHistoryRetention = request.HistoryRetention;
            var pItems = GetVariable<Reference>(request, nameof(request.Items), request.Items?.ToList(), request.ItemsIds?.ToList());
            var pKeepHistory = request.KeepHistory;
            var pLastRunVersion = request.LastRunVersion;
            var pLogError = request.LogError;
            var pLogInfo = request.LogInfo;
            var pName = request.Name;
            var pRowsToProcessPerIteration = request.RowsToProcessPerIteration;
            var pRunNow = request.RunNow;
            var pStartAt = request.StartAt;
            var pTaskHistory = GetVariable<Reference>(request, nameof(request.TaskHistory), request.TaskHistory?.ToList(), request.TaskHistoryIds?.ToList());
            var pArchived = true == request.Archived;
            var pLocked = request.Locked;

            var entity = InitEntity<DocEntityBackgroundTask,BackgroundTask>(request, permission, session);

            if (AllowPatchValue<BackgroundTask, bool>(request, DocConstantModelName.BACKGROUNDTASK, pArchived, permission, nameof(request.Archived), pArchived != entity.Archived))
            {
                entity.Archived = pArchived;
            }
            if (AllowPatchValue<BackgroundTask, DocEntityApp>(request, DocConstantModelName.BACKGROUNDTASK, pApp, permission, nameof(request.App), pApp != entity.App))
            {
                entity.App = pApp;
            }
            if (AllowPatchValue<BackgroundTask, DocEntityQueueChannel>(request, DocConstantModelName.BACKGROUNDTASK, pChannel, permission, nameof(request.Channel), pChannel != entity.Channel))
            {
                entity.Channel = pChannel;
            }
            if (AllowPatchValue<BackgroundTask, string>(request, DocConstantModelName.BACKGROUNDTASK, pDescription, permission, nameof(request.Description), pDescription != entity.Description))
            {
                entity.Description = pDescription;
            }
            if (AllowPatchValue<BackgroundTask, bool>(request, DocConstantModelName.BACKGROUNDTASK, pEnabled, permission, nameof(request.Enabled), pEnabled != entity.Enabled))
            {
                entity.Enabled = pEnabled;
            }
            if (AllowPatchValue<BackgroundTask, int?>(request, DocConstantModelName.BACKGROUNDTASK, pFrequency, permission, nameof(request.Frequency), pFrequency != entity.Frequency))
            {
                if(null != pFrequency) entity.Frequency = (int) pFrequency;
            }
            if (AllowPatchValue<BackgroundTask, int?>(request, DocConstantModelName.BACKGROUNDTASK, pHistoryRetention, permission, nameof(request.HistoryRetention), pHistoryRetention != entity.HistoryRetention))
            {
                entity.HistoryRetention = pHistoryRetention;
            }
            if (AllowPatchValue<BackgroundTask, bool>(request, DocConstantModelName.BACKGROUNDTASK, pKeepHistory, permission, nameof(request.KeepHistory), pKeepHistory != entity.KeepHistory))
            {
                entity.KeepHistory = pKeepHistory;
            }
            if (AllowPatchValue<BackgroundTask, string>(request, DocConstantModelName.BACKGROUNDTASK, pLastRunVersion, permission, nameof(request.LastRunVersion), pLastRunVersion != entity.LastRunVersion))
            {
                entity.LastRunVersion = pLastRunVersion;
            }
            if (AllowPatchValue<BackgroundTask, bool>(request, DocConstantModelName.BACKGROUNDTASK, pLogError, permission, nameof(request.LogError), pLogError != entity.LogError))
            {
                entity.LogError = pLogError;
            }
            if (AllowPatchValue<BackgroundTask, bool>(request, DocConstantModelName.BACKGROUNDTASK, pLogInfo, permission, nameof(request.LogInfo), pLogInfo != entity.LogInfo))
            {
                entity.LogInfo = pLogInfo;
            }
            if (AllowPatchValue<BackgroundTask, string>(request, DocConstantModelName.BACKGROUNDTASK, pName, permission, nameof(request.Name), pName != entity.Name))
            {
                entity.Name = pName;
            }
            if (AllowPatchValue<BackgroundTask, int?>(request, DocConstantModelName.BACKGROUNDTASK, pRowsToProcessPerIteration, permission, nameof(request.RowsToProcessPerIteration), pRowsToProcessPerIteration != entity.RowsToProcessPerIteration))
            {
                if(null != pRowsToProcessPerIteration) entity.RowsToProcessPerIteration = (int) pRowsToProcessPerIteration;
            }
            if (AllowPatchValue<BackgroundTask, bool>(request, DocConstantModelName.BACKGROUNDTASK, pRunNow, permission, nameof(request.RunNow), pRunNow != entity.RunNow))
            {
                entity.RunNow = pRunNow;
            }
            if (AllowPatchValue<BackgroundTask, string>(request, DocConstantModelName.BACKGROUNDTASK, pStartAt, permission, nameof(request.StartAt), pStartAt != entity.StartAt))
            {
                entity.StartAt = pStartAt;
            }
            if (request.Locked && AllowPatchValue<BackgroundTask, bool>(request, DocConstantModelName.BACKGROUNDTASK, pArchived, permission, nameof(request.Locked), pLocked != entity.Locked))
            {
                entity.Archived = pArchived;
            }
            entity.SaveChanges(permission);

            var idsToInvalidate = new List<int>();
            idsToInvalidate.AddRange(PatchCollection<BackgroundTask, DocEntityBackgroundTask, Reference, DocEntityBackgroundTaskItem>(request, entity, pItems, permission, nameof(request.Items)));
            idsToInvalidate.AddRange(PatchCollection<BackgroundTask, DocEntityBackgroundTask, Reference, DocEntityBackgroundTaskHistory>(request, entity, pTaskHistory, permission, nameof(request.TaskHistory)));
            if (idsToInvalidate.Any())
            {
                idsToInvalidate.Add(entity.Id);
                DocCacheClient.RemoveByEntityIds(idsToInvalidate);
                DocCacheClient.RemoveSearch(DocConstantModelName.BACKGROUNDTASK);
            }

            entity.SaveChanges(permission);
            DocPermissionFactory.SetSelect<BackgroundTask>(currentUser, nameof(BackgroundTask), request.Select);
            ret = entity.ToDto();

            var cacheExpires = DocResources.Metadata.GetCacheExpiration(DocConstantModelName.BACKGROUNDTASK);
            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.BACKGROUNDTASK, cacheExpires);

            return ret;
        }



        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<BackgroundTask> Put(BackgroundTaskBatch request)
        {
            return Patch(request);
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public BackgroundTask Put(BackgroundTask request)
        {
            return Patch(request);
        }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<BackgroundTask> Patch(BackgroundTaskBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<BackgroundTask>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Patch(dto) as BackgroundTask;
                    ret.Add(obj);
                    errorMap[$"{i}"] = $"true";
                }
                catch (Exception ex)
                {
                    errorMap[$"{i}"] = $"false";
                    errors.Add(new ResponseError()
                    {
                        Message = $"{ex.Message}{Environment.NewLine}{ex.InnerException?.Message}",
                        ErrorCode = $"{i}"
                    });
                }
                i += 1;
            });
            base.Response.AddHeader("X-AutoBatch-Completed", $"{ret.Count} succeeded");
            if (errors.Any())
            {
                throw new HttpError(HttpStatusCode.BadRequest, $"{errors.Count} failed in batch")
                {
                    Response = new ErrorResponse()
                    {
                        ResponseStatus = new ResponseStatus
                        {
                            ErrorCode = nameof(HttpError),
                            Meta = errorMap,
                            Message = "Incomplete request",
                            Errors = errors
                        }
                    }
                };
            }
            return ret;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public BackgroundTask Patch(BackgroundTask request)
        {
            if(true != (request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the BackgroundTask to patch.");
            
            request.Select = request.Select ?? new List<string>();
            
            BackgroundTask ret = null;
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    ret = _AssignValues(request, DocConstantPermission.EDIT, ssn);
                });
            }
            return ret;
        }



        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Get(BackgroundTaskJunction request)
        {
            switch(request.Junction.ToLower().TrimAndPruneSpaces())
            {
                    case "comment":
                        return GetJunctionSearchResult<BackgroundTask, DocEntityBackgroundTask, DocEntityComment, Comment, CommentSearch>((int)request.Id, DocConstantModelName.COMMENT, "Comments", request, (ss) => HostContext.ResolveService<CommentService>(Request)?.Get(ss));
                    case "favorite":
                        return GetJunctionSearchResult<BackgroundTask, DocEntityBackgroundTask, DocEntityFavorite, Favorite, FavoriteSearch>((int)request.Id, DocConstantModelName.FAVORITE, "Favorites", request, (ss) => HostContext.ResolveService<FavoriteService>(Request)?.Get(ss));
                    case "backgroundtaskitem":
                        return GetJunctionSearchResult<BackgroundTask, DocEntityBackgroundTask, DocEntityBackgroundTaskItem, BackgroundTaskItem, BackgroundTaskItemSearch>((int)request.Id, DocConstantModelName.BACKGROUNDTASKITEM, "Items", request, (ss) => HostContext.ResolveService<BackgroundTaskItemService>(Request)?.Get(ss));
                    case "tag":
                        return GetJunctionSearchResult<BackgroundTask, DocEntityBackgroundTask, DocEntityTag, Tag, TagSearch>((int)request.Id, DocConstantModelName.TAG, "Tags", request, (ss) => HostContext.ResolveService<TagService>(Request)?.Get(ss));
                    case "backgroundtaskhistory":
                        return GetJunctionSearchResult<BackgroundTask, DocEntityBackgroundTask, DocEntityBackgroundTaskHistory, BackgroundTaskHistory, BackgroundTaskHistorySearch>((int)request.Id, DocConstantModelName.BACKGROUNDTASKHISTORY, "TaskHistory", request, (ss) => HostContext.ResolveService<BackgroundTaskHistoryService>(Request)?.Get(ss));
                default:
                    throw new HttpError(HttpStatusCode.NotFound, $"Route for backgroundtask/{request.Id}/{request.Junction} was not found");
            }
        }



        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private BackgroundTask GetBackgroundTask(BackgroundTask request)
        {
            var id = request?.Id;
            BackgroundTask ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetSelect<BackgroundTask>(currentUser, "BackgroundTask", request.Select);

            DocEntityBackgroundTask entity = null;
            if(id.HasValue)
            {
                entity = DocEntityBackgroundTask.Get(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No BackgroundTask found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }

    }
}
