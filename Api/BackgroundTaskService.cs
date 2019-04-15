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
    public partial class BackgroundTaskService : DocServiceBase
    {
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
                if(true == request.Enabled?.Any())
                {
                    if(request.Enabled.Any(v => v == null)) entities = entities.Where(en => en.Enabled.In(request.Enabled) || en.Enabled == null);
                    else entities = entities.Where(en => en.Enabled.In(request.Enabled));
                }
                if(request.Frequency.HasValue)
                    entities = entities.Where(en => request.Frequency.Value == en.Frequency);
                if(request.HistoryRetention.HasValue)
                    entities = entities.Where(en => request.HistoryRetention.Value == en.HistoryRetention);
                if(true == request.ItemsIds?.Any())
                {
                    entities = entities.Where(en => en.Items.Any(r => r.Id.In(request.ItemsIds)));
                }
                if(!DocTools.IsNullOrEmpty(request.LastRunVersion))
                    entities = entities.Where(en => en.LastRunVersion.Contains(request.LastRunVersion));
                if(true == request.LogError?.Any())
                {
                    if(request.LogError.Any(v => v == null)) entities = entities.Where(en => en.LogError.In(request.LogError) || en.LogError == null);
                    else entities = entities.Where(en => en.LogError.In(request.LogError));
                }
                if(true == request.LogInfo?.Any())
                {
                    if(request.LogInfo.Any(v => v == null)) entities = entities.Where(en => en.LogInfo.In(request.LogInfo) || en.LogInfo == null);
                    else entities = entities.Where(en => en.LogInfo.In(request.LogInfo));
                }
                if(!DocTools.IsNullOrEmpty(request.Name))
                    entities = entities.Where(en => en.Name.Contains(request.Name));
                if(request.RowsToProcessPerIteration.HasValue)
                    entities = entities.Where(en => request.RowsToProcessPerIteration.Value == en.RowsToProcessPerIteration);
                if(true == request.RunNow?.Any())
                {
                    if(request.RunNow.Any(v => v == null)) entities = entities.Where(en => en.RunNow.In(request.RunNow) || en.RunNow == null);
                    else entities = entities.Where(en => en.RunNow.In(request.RunNow));
                }
                if(!DocTools.IsNullOrEmpty(request.StartAt))
                    entities = entities.Where(en => en.StartAt.Contains(request.StartAt));
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

        public object Post(BackgroundTaskSearch request) => Get(request);

        public object Get(BackgroundTaskSearch request) => GetSearchResultWithCache<BackgroundTask,DocEntityBackgroundTask,BackgroundTaskSearch>(DocConstantModelName.BACKGROUNDTASK, request, _ExecSearch);

        public object Get(BackgroundTask request) => GetEntityWithCache<BackgroundTask>(DocConstantModelName.BACKGROUNDTASK, request, GetBackgroundTask);

        private BackgroundTask _AssignValues(BackgroundTask request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "BackgroundTask"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            BackgroundTask ret = null;
            request = _InitAssignValues<BackgroundTask>(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            var cacheKey = GetApiCacheKey<BackgroundTask>(DocConstantModelName.BACKGROUNDTASK, nameof(BackgroundTask), request);
            
            //First, assign all the variables, do database lookups and conversions
            var pApp = (request.App?.Id > 0) ? DocEntityApp.GetApp(request.App.Id) : null;
            var pChannel = (request.Channel?.Id > 0) ? DocEntityQueueChannel.GetQueueChannel(request.Channel.Id) : null;
            var pDescription = request.Description;
            var pEnabled = request.Enabled;
            var pFrequency = request.Frequency;
            var pHistoryRetention = request.HistoryRetention;
            var pItems = request.Items?.ToList();
            var pLastRunVersion = request.LastRunVersion;
            var pLogError = request.LogError;
            var pLogInfo = request.LogInfo;
            var pName = request.Name;
            var pRowsToProcessPerIteration = request.RowsToProcessPerIteration;
            var pRunNow = request.RunNow;
            var pStartAt = request.StartAt;
            var pTaskHistory = request.TaskHistory?.ToList();

            DocEntityBackgroundTask entity = null;
            if(permission == DocConstantPermission.ADD)
            {
                var now = DateTime.UtcNow;
                entity = new DocEntityBackgroundTask(session)
                {
                    Created = now,
                    Updated = now
                };
            }
            else
            {
                entity = DocEntityBackgroundTask.GetBackgroundTask(request.Id);
                if(null == entity)
                    throw new HttpError(HttpStatusCode.NotFound, $"No record");
            }

            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityApp>(currentUser, request, pApp, permission, DocConstantModelName.BACKGROUNDTASK, nameof(request.App)))
            {
                if(DocPermissionFactory.IsRequested(request, pApp, entity.App, nameof(request.App)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.BACKGROUNDTASK, nameof(request.App)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.App)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pApp) && DocResources.Metadata.IsRequired(DocConstantModelName.BACKGROUNDTASK, nameof(request.App))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.App)} requires a value.");
                    entity.App = pApp;
                if(DocPermissionFactory.IsRequested<DocEntityApp>(request, pApp, nameof(request.App)) && !request.VisibleFields.Matches(nameof(request.App), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.App));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityQueueChannel>(currentUser, request, pChannel, permission, DocConstantModelName.BACKGROUNDTASK, nameof(request.Channel)))
            {
                if(DocPermissionFactory.IsRequested(request, pChannel, entity.Channel, nameof(request.Channel)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.BACKGROUNDTASK, nameof(request.Channel)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Channel)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pChannel) && DocResources.Metadata.IsRequired(DocConstantModelName.BACKGROUNDTASK, nameof(request.Channel))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Channel)} requires a value.");
                    entity.Channel = pChannel;
                if(DocPermissionFactory.IsRequested<DocEntityQueueChannel>(request, pChannel, nameof(request.Channel)) && !request.VisibleFields.Matches(nameof(request.Channel), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Channel));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pDescription, permission, DocConstantModelName.BACKGROUNDTASK, nameof(request.Description)))
            {
                if(DocPermissionFactory.IsRequested(request, pDescription, entity.Description, nameof(request.Description)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.BACKGROUNDTASK, nameof(request.Description)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Description)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pDescription) && DocResources.Metadata.IsRequired(DocConstantModelName.BACKGROUNDTASK, nameof(request.Description))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Description)} requires a value.");
                    entity.Description = pDescription;
                if(DocPermissionFactory.IsRequested<string>(request, pDescription, nameof(request.Description)) && !request.VisibleFields.Matches(nameof(request.Description), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Description));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<bool>(currentUser, request, pEnabled, permission, DocConstantModelName.BACKGROUNDTASK, nameof(request.Enabled)))
            {
                if(DocPermissionFactory.IsRequested(request, pEnabled, entity.Enabled, nameof(request.Enabled)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.BACKGROUNDTASK, nameof(request.Enabled)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Enabled)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pEnabled) && DocResources.Metadata.IsRequired(DocConstantModelName.BACKGROUNDTASK, nameof(request.Enabled))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Enabled)} requires a value.");
                    entity.Enabled = pEnabled;
                if(DocPermissionFactory.IsRequested<bool>(request, pEnabled, nameof(request.Enabled)) && !request.VisibleFields.Matches(nameof(request.Enabled), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Enabled));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<int?>(currentUser, request, pFrequency, permission, DocConstantModelName.BACKGROUNDTASK, nameof(request.Frequency)))
            {
                if(DocPermissionFactory.IsRequested(request, pFrequency, entity.Frequency, nameof(request.Frequency)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.BACKGROUNDTASK, nameof(request.Frequency)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Frequency)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pFrequency) && DocResources.Metadata.IsRequired(DocConstantModelName.BACKGROUNDTASK, nameof(request.Frequency))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Frequency)} requires a value.");
                    if(null != pFrequency)
                        entity.Frequency = (int) pFrequency;
                if(DocPermissionFactory.IsRequested<int?>(request, pFrequency, nameof(request.Frequency)) && !request.VisibleFields.Matches(nameof(request.Frequency), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Frequency));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<int?>(currentUser, request, pHistoryRetention, permission, DocConstantModelName.BACKGROUNDTASK, nameof(request.HistoryRetention)))
            {
                if(DocPermissionFactory.IsRequested(request, pHistoryRetention, entity.HistoryRetention, nameof(request.HistoryRetention)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.BACKGROUNDTASK, nameof(request.HistoryRetention)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.HistoryRetention)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pHistoryRetention) && DocResources.Metadata.IsRequired(DocConstantModelName.BACKGROUNDTASK, nameof(request.HistoryRetention))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.HistoryRetention)} requires a value.");
                    entity.HistoryRetention = pHistoryRetention;
                if(DocPermissionFactory.IsRequested<int?>(request, pHistoryRetention, nameof(request.HistoryRetention)) && !request.VisibleFields.Matches(nameof(request.HistoryRetention), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.HistoryRetention));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pLastRunVersion, permission, DocConstantModelName.BACKGROUNDTASK, nameof(request.LastRunVersion)))
            {
                if(DocPermissionFactory.IsRequested(request, pLastRunVersion, entity.LastRunVersion, nameof(request.LastRunVersion)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.BACKGROUNDTASK, nameof(request.LastRunVersion)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.LastRunVersion)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pLastRunVersion) && DocResources.Metadata.IsRequired(DocConstantModelName.BACKGROUNDTASK, nameof(request.LastRunVersion))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.LastRunVersion)} requires a value.");
                    entity.LastRunVersion = pLastRunVersion;
                if(DocPermissionFactory.IsRequested<string>(request, pLastRunVersion, nameof(request.LastRunVersion)) && !request.VisibleFields.Matches(nameof(request.LastRunVersion), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.LastRunVersion));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<bool>(currentUser, request, pLogError, permission, DocConstantModelName.BACKGROUNDTASK, nameof(request.LogError)))
            {
                if(DocPermissionFactory.IsRequested(request, pLogError, entity.LogError, nameof(request.LogError)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.BACKGROUNDTASK, nameof(request.LogError)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.LogError)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pLogError) && DocResources.Metadata.IsRequired(DocConstantModelName.BACKGROUNDTASK, nameof(request.LogError))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.LogError)} requires a value.");
                    entity.LogError = pLogError;
                if(DocPermissionFactory.IsRequested<bool>(request, pLogError, nameof(request.LogError)) && !request.VisibleFields.Matches(nameof(request.LogError), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.LogError));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<bool>(currentUser, request, pLogInfo, permission, DocConstantModelName.BACKGROUNDTASK, nameof(request.LogInfo)))
            {
                if(DocPermissionFactory.IsRequested(request, pLogInfo, entity.LogInfo, nameof(request.LogInfo)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.BACKGROUNDTASK, nameof(request.LogInfo)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.LogInfo)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pLogInfo) && DocResources.Metadata.IsRequired(DocConstantModelName.BACKGROUNDTASK, nameof(request.LogInfo))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.LogInfo)} requires a value.");
                    entity.LogInfo = pLogInfo;
                if(DocPermissionFactory.IsRequested<bool>(request, pLogInfo, nameof(request.LogInfo)) && !request.VisibleFields.Matches(nameof(request.LogInfo), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.LogInfo));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pName, permission, DocConstantModelName.BACKGROUNDTASK, nameof(request.Name)))
            {
                if(DocPermissionFactory.IsRequested(request, pName, entity.Name, nameof(request.Name)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.BACKGROUNDTASK, nameof(request.Name)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Name)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pName) && DocResources.Metadata.IsRequired(DocConstantModelName.BACKGROUNDTASK, nameof(request.Name))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Name)} requires a value.");
                    entity.Name = pName;
                if(DocPermissionFactory.IsRequested<string>(request, pName, nameof(request.Name)) && !request.VisibleFields.Matches(nameof(request.Name), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Name));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<int?>(currentUser, request, pRowsToProcessPerIteration, permission, DocConstantModelName.BACKGROUNDTASK, nameof(request.RowsToProcessPerIteration)))
            {
                if(DocPermissionFactory.IsRequested(request, pRowsToProcessPerIteration, entity.RowsToProcessPerIteration, nameof(request.RowsToProcessPerIteration)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.BACKGROUNDTASK, nameof(request.RowsToProcessPerIteration)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.RowsToProcessPerIteration)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pRowsToProcessPerIteration) && DocResources.Metadata.IsRequired(DocConstantModelName.BACKGROUNDTASK, nameof(request.RowsToProcessPerIteration))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.RowsToProcessPerIteration)} requires a value.");
                    if(null != pRowsToProcessPerIteration)
                        entity.RowsToProcessPerIteration = (int) pRowsToProcessPerIteration;
                if(DocPermissionFactory.IsRequested<int?>(request, pRowsToProcessPerIteration, nameof(request.RowsToProcessPerIteration)) && !request.VisibleFields.Matches(nameof(request.RowsToProcessPerIteration), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.RowsToProcessPerIteration));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<bool>(currentUser, request, pRunNow, permission, DocConstantModelName.BACKGROUNDTASK, nameof(request.RunNow)))
            {
                if(DocPermissionFactory.IsRequested(request, pRunNow, entity.RunNow, nameof(request.RunNow)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.BACKGROUNDTASK, nameof(request.RunNow)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.RunNow)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pRunNow) && DocResources.Metadata.IsRequired(DocConstantModelName.BACKGROUNDTASK, nameof(request.RunNow))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.RunNow)} requires a value.");
                    entity.RunNow = pRunNow;
                if(DocPermissionFactory.IsRequested<bool>(request, pRunNow, nameof(request.RunNow)) && !request.VisibleFields.Matches(nameof(request.RunNow), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.RunNow));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pStartAt, permission, DocConstantModelName.BACKGROUNDTASK, nameof(request.StartAt)))
            {
                if(DocPermissionFactory.IsRequested(request, pStartAt, entity.StartAt, nameof(request.StartAt)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.BACKGROUNDTASK, nameof(request.StartAt)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.StartAt)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pStartAt) && DocResources.Metadata.IsRequired(DocConstantModelName.BACKGROUNDTASK, nameof(request.StartAt))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.StartAt)} requires a value.");
                    entity.StartAt = pStartAt;
                if(DocPermissionFactory.IsRequested<string>(request, pStartAt, nameof(request.StartAt)) && !request.VisibleFields.Matches(nameof(request.StartAt), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.StartAt));
                }
            }

            if (request.Locked) entity.Locked = request.Locked;

            entity.SaveChanges(permission);

            if (DocPermissionFactory.IsRequestedHasPermission<List<Reference>>(currentUser, request, pItems, permission, DocConstantModelName.BACKGROUNDTASK, nameof(request.Items)))
            {
                if (true == pItems?.Any() )
                {
                    var requestedItems = pItems.Select(p => p.Id).Distinct().ToList();
                    var existsItems = Execute.SelectAll<DocEntityBackgroundTaskItem>().Where(e => e.Id.In(requestedItems)).Select( e => e.Id ).ToList();
                    if (existsItems.Count != requestedItems.Count)
                    {
                        var nonExists = requestedItems.Where(id => existsItems.All(eId => eId != id));
                        throw new HttpError(HttpStatusCode.NotFound, $"Cannot patch collection Items with objects that do not exist. No matching Items(s) could be found for Ids: {nonExists.ToDelimitedString()}.");
                    }
                    var toAdd = requestedItems.Where(id => entity.Items.All(e => e.Id != id)).ToList(); 
                    toAdd?.ForEach(id =>
                    {
                        var target = DocEntityBackgroundTaskItem.GetBackgroundTaskItem(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD, targetEntity: target, targetName: nameof(BackgroundTask), columnName: nameof(request.Items)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to add {nameof(request.Items)} to {nameof(BackgroundTask)}");
                        entity.Items.Add(target);
                    });
                    var toRemove = entity.Items.Where(e => requestedItems.All(id => e.Id != id)).Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityBackgroundTaskItem.GetBackgroundTaskItem(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(BackgroundTask), columnName: nameof(request.Items)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Items)} from {nameof(BackgroundTask)}");
                        entity.Items.Remove(target);
                    });
                }
                else
                {
                    var toRemove = entity.Items.Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityBackgroundTaskItem.GetBackgroundTaskItem(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(BackgroundTask), columnName: nameof(request.Items)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Items)} from {nameof(BackgroundTask)}");
                        entity.Items.Remove(target);
                    });
                }
                if(DocPermissionFactory.IsRequested<List<Reference>>(request, pItems, nameof(request.Items)) && !request.VisibleFields.Matches(nameof(request.Items), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Items));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<List<Reference>>(currentUser, request, pTaskHistory, permission, DocConstantModelName.BACKGROUNDTASK, nameof(request.TaskHistory)))
            {
                if (true == pTaskHistory?.Any() )
                {
                    var requestedTaskHistory = pTaskHistory.Select(p => p.Id).Distinct().ToList();
                    var existsTaskHistory = Execute.SelectAll<DocEntityBackgroundTaskHistory>().Where(e => e.Id.In(requestedTaskHistory)).Select( e => e.Id ).ToList();
                    if (existsTaskHistory.Count != requestedTaskHistory.Count)
                    {
                        var nonExists = requestedTaskHistory.Where(id => existsTaskHistory.All(eId => eId != id));
                        throw new HttpError(HttpStatusCode.NotFound, $"Cannot patch collection TaskHistory with objects that do not exist. No matching TaskHistory(s) could be found for Ids: {nonExists.ToDelimitedString()}.");
                    }
                    var toAdd = requestedTaskHistory.Where(id => entity.TaskHistory.All(e => e.Id != id)).ToList(); 
                    toAdd?.ForEach(id =>
                    {
                        var target = DocEntityBackgroundTaskHistory.GetBackgroundTaskHistory(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD, targetEntity: target, targetName: nameof(BackgroundTask), columnName: nameof(request.TaskHistory)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to add {nameof(request.TaskHistory)} to {nameof(BackgroundTask)}");
                        entity.TaskHistory.Add(target);
                    });
                    var toRemove = entity.TaskHistory.Where(e => requestedTaskHistory.All(id => e.Id != id)).Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityBackgroundTaskHistory.GetBackgroundTaskHistory(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(BackgroundTask), columnName: nameof(request.TaskHistory)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.TaskHistory)} from {nameof(BackgroundTask)}");
                        entity.TaskHistory.Remove(target);
                    });
                }
                else
                {
                    var toRemove = entity.TaskHistory.Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityBackgroundTaskHistory.GetBackgroundTaskHistory(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(BackgroundTask), columnName: nameof(request.TaskHistory)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.TaskHistory)} from {nameof(BackgroundTask)}");
                        entity.TaskHistory.Remove(target);
                    });
                }
                if(DocPermissionFactory.IsRequested<List<Reference>>(request, pTaskHistory, nameof(request.TaskHistory)) && !request.VisibleFields.Matches(nameof(request.TaskHistory), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.TaskHistory));
                }
            }
            DocPermissionFactory.SetVisibleFields<BackgroundTask>(currentUser, nameof(BackgroundTask), request.VisibleFields);
            ret = entity.ToDto();

            var cacheExpires = DocResources.Metadata.GetCacheExpiration(DocConstantModelName.BACKGROUNDTASK);
            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.BACKGROUNDTASK, cacheExpires);

            return ret;
        }

        public List<BackgroundTask> Put(BackgroundTaskBatch request)
        {
            return Patch(request);
        }

        public BackgroundTask Put(BackgroundTask request)
        {
            return Patch(request);
        }
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

        public BackgroundTask Patch(BackgroundTask request)
        {
            if(true != (request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the BackgroundTask to patch.");
            
            request.VisibleFields = request.VisibleFields ?? new List<string>();
            
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
        public object Get(BackgroundTaskJunction request)
        {
            switch(request.Junction.ToLower().TrimAndPruneSpaces())
            {
                    case "backgroundtaskitem":
                        return GetJunctionSearchResult<BackgroundTask, DocEntityBackgroundTask, DocEntityBackgroundTaskItem, BackgroundTaskItem, BackgroundTaskItemSearch>((int)request.Id, DocConstantModelName.BACKGROUNDTASKITEM, "Items", request, (ss) => HostContext.ResolveService<BackgroundTaskItemService>(Request)?.Get(ss));
                    case "backgroundtaskhistory":
                        return GetJunctionSearchResult<BackgroundTask, DocEntityBackgroundTask, DocEntityBackgroundTaskHistory, BackgroundTaskHistory, BackgroundTaskHistorySearch>((int)request.Id, DocConstantModelName.BACKGROUNDTASKHISTORY, "TaskHistory", request, (ss) => HostContext.ResolveService<BackgroundTaskHistoryService>(Request)?.Get(ss));
                default:
                    throw new HttpError(HttpStatusCode.NotFound, $"Route for backgroundtask/{request.Id}/{request.Junction} was not found");
            }
        }
        private BackgroundTask GetBackgroundTask(BackgroundTask request)
        {
            var id = request?.Id;
            BackgroundTask ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetVisibleFields<BackgroundTask>(currentUser, "BackgroundTask", request.VisibleFields);

            DocEntityBackgroundTask entity = null;
            if(id.HasValue)
            {
                entity = DocEntityBackgroundTask.GetBackgroundTask(id.Value);
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
