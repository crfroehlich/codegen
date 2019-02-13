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
    public partial class BackgroundTaskService : DocServiceBase
    {
        private IQueryable<DocEntityBackgroundTask> _ExecSearch(BackgroundTaskSearch request)
        {
            request = InitSearch(request);
            IQueryable<DocEntityBackgroundTask> entities = null;
            Execute.Run( session => 
            {
                entities = Execute.SelectAll<DocEntityBackgroundTask>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new BackgroundTaskFullTextSearch(request);
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
                if(request.Enabled.HasValue)
                    entities = entities.Where(en => request.Enabled.Value == en.Enabled);
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
                if(request.LogError.HasValue)
                    entities = entities.Where(en => request.LogError.Value == en.LogError);
                if(request.LogInfo.HasValue)
                    entities = entities.Where(en => request.LogInfo.Value == en.LogInfo);
                if(!DocTools.IsNullOrEmpty(request.Name))
                    entities = entities.Where(en => en.Name.Contains(request.Name));
                if(request.RowsToProcessPerIteration.HasValue)
                    entities = entities.Where(en => request.RowsToProcessPerIteration.Value == en.RowsToProcessPerIteration);
                if(request.RunNow.HasValue)
                    entities = entities.Where(en => request.RunNow.Value == en.RunNow);
                if(!DocTools.IsNullOrEmpty(request.StartAt))
                    entities = entities.Where(en => en.StartAt.Contains(request.StartAt));
                        if(true == request.TaskHistoryIds?.Any())
                        {
                            entities = entities.Where(en => en.TaskHistory.Any(r => r.Id.In(request.TaskHistoryIds)));
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

        public List<BackgroundTask> Post(BackgroundTaskSearch request) => Get(request);

        public List<BackgroundTask> Get(BackgroundTaskSearch request) => GetSearchResult<BackgroundTask,DocEntityBackgroundTask,BackgroundTaskSearch>(DocConstantModelName.BACKGROUNDTASK, request, _ExecSearch);

        public object Post(BackgroundTaskVersion request) => Get(request);

        public object Get(BackgroundTaskVersion request) 
        {
            List<Version> ret = null;
            Execute.Run(s=>
            {
                ret = _ExecSearch(request).Select(e => new Version(e.Id, e.VersionNo)).ToList();
            });
            return ret;
        }

        public BackgroundTask Get(BackgroundTask request) => GetEntity<BackgroundTask>(DocConstantModelName.BACKGROUNDTASK, request, GetBackgroundTask);
        private BackgroundTask _AssignValues(BackgroundTask request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "BackgroundTask"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            BackgroundTask ret = null;
            request = _InitAssignValues(request, permission, session);
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
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.App)} cannot be modified once set.");
                    entity.App = pApp;
                if(DocPermissionFactory.IsRequested<DocEntityApp>(request, pApp, nameof(request.App)) && !request.VisibleFields.Matches(nameof(request.App), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.App));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityQueueChannel>(currentUser, request, pChannel, permission, DocConstantModelName.BACKGROUNDTASK, nameof(request.Channel)))
            {
                if(DocPermissionFactory.IsRequested(request, pChannel, entity.Channel, nameof(request.Channel)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Channel)} cannot be modified once set.");
                    entity.Channel = pChannel;
                if(DocPermissionFactory.IsRequested<DocEntityQueueChannel>(request, pChannel, nameof(request.Channel)) && !request.VisibleFields.Matches(nameof(request.Channel), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Channel));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pDescription, permission, DocConstantModelName.BACKGROUNDTASK, nameof(request.Description)))
            {
                if(DocPermissionFactory.IsRequested(request, pDescription, entity.Description, nameof(request.Description)))
                    entity.Description = pDescription;
                if(DocPermissionFactory.IsRequested<string>(request, pDescription, nameof(request.Description)) && !request.VisibleFields.Matches(nameof(request.Description), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Description));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<bool>(currentUser, request, pEnabled, permission, DocConstantModelName.BACKGROUNDTASK, nameof(request.Enabled)))
            {
                if(DocPermissionFactory.IsRequested(request, pEnabled, entity.Enabled, nameof(request.Enabled)))
                    entity.Enabled = pEnabled;
                if(DocPermissionFactory.IsRequested<bool>(request, pEnabled, nameof(request.Enabled)) && !request.VisibleFields.Matches(nameof(request.Enabled), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Enabled));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<int?>(currentUser, request, pFrequency, permission, DocConstantModelName.BACKGROUNDTASK, nameof(request.Frequency)))
            {
                if(DocPermissionFactory.IsRequested(request, pFrequency, entity.Frequency, nameof(request.Frequency)))
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
                    entity.HistoryRetention = pHistoryRetention;
                if(DocPermissionFactory.IsRequested<int?>(request, pHistoryRetention, nameof(request.HistoryRetention)) && !request.VisibleFields.Matches(nameof(request.HistoryRetention), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.HistoryRetention));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pLastRunVersion, permission, DocConstantModelName.BACKGROUNDTASK, nameof(request.LastRunVersion)))
            {
                if(DocPermissionFactory.IsRequested(request, pLastRunVersion, entity.LastRunVersion, nameof(request.LastRunVersion)))
                    entity.LastRunVersion = pLastRunVersion;
                if(DocPermissionFactory.IsRequested<string>(request, pLastRunVersion, nameof(request.LastRunVersion)) && !request.VisibleFields.Matches(nameof(request.LastRunVersion), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.LastRunVersion));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<bool>(currentUser, request, pLogError, permission, DocConstantModelName.BACKGROUNDTASK, nameof(request.LogError)))
            {
                if(DocPermissionFactory.IsRequested(request, pLogError, entity.LogError, nameof(request.LogError)))
                    entity.LogError = pLogError;
                if(DocPermissionFactory.IsRequested<bool>(request, pLogError, nameof(request.LogError)) && !request.VisibleFields.Matches(nameof(request.LogError), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.LogError));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<bool>(currentUser, request, pLogInfo, permission, DocConstantModelName.BACKGROUNDTASK, nameof(request.LogInfo)))
            {
                if(DocPermissionFactory.IsRequested(request, pLogInfo, entity.LogInfo, nameof(request.LogInfo)))
                    entity.LogInfo = pLogInfo;
                if(DocPermissionFactory.IsRequested<bool>(request, pLogInfo, nameof(request.LogInfo)) && !request.VisibleFields.Matches(nameof(request.LogInfo), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.LogInfo));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pName, permission, DocConstantModelName.BACKGROUNDTASK, nameof(request.Name)))
            {
                if(DocPermissionFactory.IsRequested(request, pName, entity.Name, nameof(request.Name)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Name)} cannot be modified once set.");
                    entity.Name = pName;
                if(DocPermissionFactory.IsRequested<string>(request, pName, nameof(request.Name)) && !request.VisibleFields.Matches(nameof(request.Name), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Name));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<int?>(currentUser, request, pRowsToProcessPerIteration, permission, DocConstantModelName.BACKGROUNDTASK, nameof(request.RowsToProcessPerIteration)))
            {
                if(DocPermissionFactory.IsRequested(request, pRowsToProcessPerIteration, entity.RowsToProcessPerIteration, nameof(request.RowsToProcessPerIteration)))
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
                    entity.RunNow = pRunNow;
                if(DocPermissionFactory.IsRequested<bool>(request, pRunNow, nameof(request.RunNow)) && !request.VisibleFields.Matches(nameof(request.RunNow), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.RunNow));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pStartAt, permission, DocConstantModelName.BACKGROUNDTASK, nameof(request.StartAt)))
            {
                if(DocPermissionFactory.IsRequested(request, pStartAt, entity.StartAt, nameof(request.StartAt)))
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

            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.BACKGROUNDTASK);

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
            Execute.Run(ssn =>
            {
                ret = _AssignValues(request, DocConstantPermission.EDIT, ssn);
            });
            return ret;
        }

        public object Get(BackgroundTaskJunction request)
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
                case "backgroundtaskitem":
                    ret = _GetBackgroundTaskBackgroundTaskItem(request, skip, take);
                    break;
                case "backgroundtaskhistory":
                    ret = _GetBackgroundTaskBackgroundTaskHistory(request, skip, take);
                    break;
                }
            });
            return ret;
        }
        
        public object Get(BackgroundTaskJunctionVersion request)
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
        

        private object _GetBackgroundTaskBackgroundTaskItem(BackgroundTaskJunction request, int skip, int take)
        {
             request.VisibleFields = InitVisibleFields<BackgroundTaskItem>(Dto.BackgroundTaskItem.Fields, request.VisibleFields);
             var en = DocEntityBackgroundTask.GetBackgroundTask(request.Id);
             if (!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.VIEW, targetName: DocConstantModelName.BACKGROUNDTASK, columnName: "Items", targetEntity: null))
                 throw new HttpError(HttpStatusCode.Forbidden, "You do not have View permission to relationships between BackgroundTask and BackgroundTaskItem");
             return en?.Items.Take(take).Skip(skip).ConvertFromEntityList<DocEntityBackgroundTaskItem,BackgroundTaskItem>(new List<BackgroundTaskItem>());
        }

        private object _GetBackgroundTaskBackgroundTaskHistory(BackgroundTaskJunction request, int skip, int take)
        {
             request.VisibleFields = InitVisibleFields<BackgroundTaskHistory>(Dto.BackgroundTaskHistory.Fields, request.VisibleFields);
             var en = DocEntityBackgroundTask.GetBackgroundTask(request.Id);
             if (!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.VIEW, targetName: DocConstantModelName.BACKGROUNDTASK, columnName: "TaskHistory", targetEntity: null))
                 throw new HttpError(HttpStatusCode.Forbidden, "You do not have View permission to relationships between BackgroundTask and BackgroundTaskHistory");
             return en?.TaskHistory.Take(take).Skip(skip).ConvertFromEntityList<DocEntityBackgroundTaskHistory,BackgroundTaskHistory>(new List<BackgroundTaskHistory>());
        }
        
        public object Post(BackgroundTaskJunction request)
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


        public object Delete(BackgroundTaskJunction request)
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

        public List<int> Any(BackgroundTaskIds request)
        {
            List<int> ret = null;
            if (currentUser.IsSuperAdmin)
            {
                Execute.Run(s => { ret = Execute.SelectAll<DocEntityBackgroundTask>().Select(d => d.Id).ToList(); });
            }
            else
            {
                throw new HttpError(HttpStatusCode.Forbidden);
            }

            return ret;
        }
    }
}