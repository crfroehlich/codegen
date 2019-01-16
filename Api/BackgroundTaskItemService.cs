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
    public partial class BackgroundTaskItemService : DocServiceBase
    {
        private void _ExecSearch(BackgroundTaskItemSearch request, Action<IQueryable<DocEntityBackgroundTaskItem>> callBack)
        {
            request = InitSearch(request);
            
            DocPermissionFactory.SetVisibleFields<BackgroundTaskItem>(currentUser, "BackgroundTaskItem", request.VisibleFields);

            Execute.Run( session => 
            {
                var entities = Execute.SelectAll<DocEntityBackgroundTaskItem>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new BackgroundTaskItemFullTextSearch(request);
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
                if(request.Succeeded.HasValue)
                    entities = entities.Where(en => request.Succeeded.Value == en.Succeeded);
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

                entities = ApplyFilters(request, entities);

                if(request.Skip > 0)
                    entities = entities.Skip(request.Skip.Value);
                if(request.Take > 0)
                    entities = entities.Take(request.Take.Value);
                if(true == request?.OrderBy?.Any())
                    entities = entities.OrderBy(request.OrderBy);
                if(true == request?.OrderByDesc?.Any())
                    entities = entities.OrderByDescending(request.OrderByDesc);
                callBack?.Invoke(entities);
            });
        }
        
        public object Post(BackgroundTaskItemSearch request)
        {
            return Get(request);
        }

        public object Get(BackgroundTaskItemSearch request)
        {
            object tryRet = null;
            var ret = new List<BackgroundTaskItem>();
            var cacheKey = GetApiCacheKey<BackgroundTaskItem>(DocConstantModelName.BACKGROUNDTASKITEM, nameof(BackgroundTaskItem), request);
            using (var cancellableRequest = base.Request.CreateCancellableRequest())
            {
                var requestCancel = new DocRequestCancellation(HttpContext.Current.Response, cancellableRequest);
                try 
                {
                    if (tryRet == null)
                    {
                        _ExecSearch(request, (entities) => entities.ConvertFromEntityList<DocEntityBackgroundTaskItem,BackgroundTaskItem>(ret, Execute, requestCancel));
                        tryRet = ret;
                        //Go ahead and cache the result for any future consumers
                        DocCacheClient.Set(key: cacheKey, value: ret, entityType: DocConstantModelName.BACKGROUNDTASKITEM, search: true);
                    }
                }
                catch(Exception) { throw; }
                finally
                {
                    requestCancel?.CloseRequest();
                }
            }
            DocCacheClient.SyncKeys(key: cacheKey, entityType: DocConstantModelName.BACKGROUNDTASKITEM, search: true);
            return tryRet;
        }

        public object Post(BackgroundTaskItemVersion request) 
        {
            return Get(request);
        }

        public object Get(BackgroundTaskItemVersion request) 
        {
            var ret = new List<Version>();
            _ExecSearch(request, (entities) => 
            {
                ret = entities.Select(e => new Version(e.Id, e.VersionNo)).ToList();
            });
            return ret;
        }

        public object Get(BackgroundTaskItem request)
        {
            object ret = null;
            
            if(!(request.Id > 0))
                throw new HttpError(HttpStatusCode.NotFound, "Valid Id required.");

            DocPermissionFactory.SetVisibleFields<BackgroundTaskItem>(currentUser, "BackgroundTaskItem", request.VisibleFields);
            var cacheKey = GetApiCacheKey<BackgroundTaskItem>(DocConstantModelName.BACKGROUNDTASKITEM, nameof(BackgroundTaskItem), request);
            if(null == ret)
            {
                Execute.Run(s =>
                {
                    ret = GetBackgroundTaskItem(request);
                    DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.BACKGROUNDTASKITEM);
                });
            }
            DocCacheClient.SyncKeys(key: cacheKey, entityId: request.Id, entityType: DocConstantModelName.BACKGROUNDTASKITEM);
            return ret;
        }




        public object Get(BackgroundTaskItemJunction request)
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
                case "backgroundtaskhistory":
                    ret = _GetBackgroundTaskItemBackgroundTaskHistory(request, skip, take);
                    break;
                }
            });
            return ret;
        }
        
        public object Get(BackgroundTaskItemJunctionVersion request)
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
        

        private object _GetBackgroundTaskItemBackgroundTaskHistory(BackgroundTaskItemJunction request, int skip, int take)
        {
             DocPermissionFactory.SetVisibleFields<BackgroundTaskHistory>(currentUser, "BackgroundTaskHistory", request.VisibleFields);
             var en = DocEntityBackgroundTaskItem.GetBackgroundTaskItem(request.Id);
             if (!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.VIEW, targetName: DocConstantModelName.BACKGROUNDTASKITEM, columnName: "TaskHistory", targetEntity: null))
                 throw new HttpError(HttpStatusCode.Forbidden, "You do not have View permission to relationships between BackgroundTaskItem and BackgroundTaskHistory");
             return en?.TaskHistory.Take(take).Skip(skip).ConvertFromEntityList<DocEntityBackgroundTaskHistory,BackgroundTaskHistory>(new List<BackgroundTaskHistory>());
        }
        
        public object Post(BackgroundTaskItemJunction request)
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


        public object Delete(BackgroundTaskItemJunction request)
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

        public List<int> Any(BackgroundTaskItemIds request)
        {
            List<int> ret = null;
            if (currentUser.IsSuperAdmin)
            {
                Execute.Run(s => { ret = Execute.SelectAll<DocEntityBackgroundTaskItem>().Select(d => d.Id).ToList(); });
            }
            else
            {
                throw new HttpError(HttpStatusCode.Forbidden);
            }

            return ret;
        }
    }
}