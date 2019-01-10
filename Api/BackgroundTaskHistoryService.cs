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
using Typed.Security;
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
        public const string CACHE_KEY_PREFIX = DocEntityBackgroundTaskHistory.CACHE_KEY_PREFIX;
        private void _ExecSearch(BackgroundTaskHistorySearch request, Action<IQueryable<DocEntityBackgroundTaskHistory>> callBack)
        {
            request = InitSearch(request);
            
            DocPermissionFactory.SetVisibleFields<BackgroundTaskHistory>(currentUser, "BackgroundTaskHistory", request.VisibleFields);

            var entities = Execute.SelectAll<DocEntityBackgroundTaskHistory>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new BackgroundTaskHistoryFullTextSearch(request);
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
        }
        
        public object Post(BackgroundTaskHistorySearch request)
        {
            object tryRet = null;
            Execute.Run(s =>
            {
                using (var cancellableRequest = base.Request.CreateCancellableRequest())
                {
                    var requestCancel = new DocRequestCancellation(HttpContext.Current.Response, cancellableRequest);
                    try 
                    {
                        var ret = new List<BackgroundTaskHistory>();
                        _ExecSearch(request, (entities) => entities.ConvertFromEntityList<DocEntityBackgroundTaskHistory,BackgroundTaskHistory>(ret, Execute, requestCancel));
                        tryRet = ret;
                    }
                    catch(Exception) { throw; }
                    finally
                    {
                        requestCancel?.CloseRequest();
                    }
                }
            });
            return tryRet;
        }

        public object Get(BackgroundTaskHistorySearch request)
        {
            object tryRet = null;
            Execute.Run(s =>
            {
                using (var cancellableRequest = base.Request.CreateCancellableRequest())
                {
                    var requestCancel = new DocRequestCancellation(HttpContext.Current.Response, cancellableRequest);
                    try 
                    {
                        var ret = new List<BackgroundTaskHistory>();
                        _ExecSearch(request, (entities) => entities.ConvertFromEntityList<DocEntityBackgroundTaskHistory,BackgroundTaskHistory>(ret, Execute, requestCancel));
                        tryRet = ret;
                    }
                    catch(Exception) { throw; }
                    finally
                    {
                        requestCancel?.CloseRequest();
                    }
                }
            });
            return tryRet;
        }

        public object Post(BackgroundTaskHistoryVersion request) 
        {
            return Get(request);
        }

        public object Get(BackgroundTaskHistoryVersion request) 
        {
            var ret = new List<Version>();
            Execute.Run(s =>
            {
                _ExecSearch(request, (entities) => 
                {
                    ret = entities.Select(e => new Version(e.Id, e.VersionNo)).ToList();
                });
            });
            return ret;
        }

        public object Get(BackgroundTaskHistory request)
        {
            object ret = null;
            
            if(!(request.Id > 0))
                throw new HttpError(HttpStatusCode.NotFound, "Valid Id required.");

            Execute.Run(s =>
            {
                DocPermissionFactory.SetVisibleFields<BackgroundTaskHistory>(currentUser, "BackgroundTaskHistory", request.VisibleFields);
                ret = GetBackgroundTaskHistory(request);
            });
            return ret;
        }




        public object Get(BackgroundTaskHistoryJunction request)
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
                    ret = _GetBackgroundTaskHistoryBackgroundTaskItem(request, skip, take);
                    break;
                }
            });
            return ret;
        }
        
        public object Get(BackgroundTaskHistoryJunctionVersion request)
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
        

        private object _GetBackgroundTaskHistoryBackgroundTaskItem(BackgroundTaskHistoryJunction request, int skip, int take)
        {
             DocPermissionFactory.SetVisibleFields<BackgroundTaskItem>(currentUser, "BackgroundTaskItem", request.VisibleFields);
             var en = DocEntityBackgroundTaskHistory.GetBackgroundTaskHistory(request.Id);
             if (!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.VIEW, targetName: DocConstantModelName.BACKGROUNDTASKHISTORY, columnName: "Items", targetEntity: null))
                 throw new HttpError(HttpStatusCode.Forbidden, "You do not have View permission to relationships between BackgroundTaskHistory and BackgroundTaskItem");
             return en?.Items.Take(take).Skip(skip).ConvertFromEntityList<DocEntityBackgroundTaskItem,BackgroundTaskItem>(new List<BackgroundTaskItem>());
        }
        
        public object Post(BackgroundTaskHistoryJunction request)
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


        public object Delete(BackgroundTaskHistoryJunction request)
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

        public List<int> Any(BackgroundTaskHistoryIds request)
        {
            List<int> ret = null;
            if (currentUser.IsSuperAdmin)
            {
                Execute.Run(s => { ret = Execute.SelectAll<DocEntityBackgroundTaskHistory>().Select(d => d.Id).ToList(); });
            }
            else
            {
                throw new HttpError(HttpStatusCode.Forbidden);
            }
            return ret;
        }
    }
}