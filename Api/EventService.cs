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
    public partial class EventService : DocServiceBase
    {
        public const string CACHE_KEY_PREFIX = DocEntityEvent.CACHE_KEY_PREFIX;
        private void _ExecSearch(EventSearch request, Action<IQueryable<DocEntityEvent>> callBack)
        {
            request = InitSearch(request);
            
            DocPermissionFactory.SetVisibleFields<Event>(currentUser, "Event", request.VisibleFields);

            Execute.Run( session => 
            {
                var entities = Execute.SelectAll<DocEntityEvent>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new EventFullTextSearch(request);
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
                if(!DocTools.IsNullOrEmpty(request.Processed))
                    entities = entities.Where(en => null != en.Processed && request.Processed.Value.Date == en.Processed.Value.Date);
                if(!DocTools.IsNullOrEmpty(request.ProcessedBefore))
                    entities = entities.Where(en => en.Processed <= request.ProcessedBefore);
                if(!DocTools.IsNullOrEmpty(request.ProcessedAfter))
                    entities = entities.Where(en => en.Processed >= request.ProcessedAfter);
                if(!DocTools.IsNullOrEmpty(request.Status))
                    entities = entities.Where(en => en.Status.Contains(request.Status));
                        if(true == request.TeamsIds?.Any())
                        {
                            entities = entities.Where(en => en.Teams.Any(r => r.Id.In(request.TeamsIds)));
                        }
                        if(true == request.UpdatesIds?.Any())
                        {
                            entities = entities.Where(en => en.Updates.Any(r => r.Id.In(request.UpdatesIds)));
                        }
                        if(true == request.UsersIds?.Any())
                        {
                            entities = entities.Where(en => en.Users.Any(r => r.Id.In(request.UsersIds)));
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
        
        public object Post(EventSearch request)
        {
            object tryRet = null;
            using (var cancellableRequest = base.Request.CreateCancellableRequest())
            {
                var requestCancel = new DocRequestCancellation(HttpContext.Current.Response, cancellableRequest);
                try 
                {
                    var ret = new List<Event>();
                    _ExecSearch(request, (entities) => entities.ConvertFromEntityList<DocEntityEvent,Event>(ret, Execute, requestCancel));
                    tryRet = ret;
                }
                catch(Exception) { throw; }
                finally
                {
                    requestCancel?.CloseRequest();
                }
            }
            return tryRet;
        }

        public object Get(EventSearch request)
        {
            object tryRet = null;
            using (var cancellableRequest = base.Request.CreateCancellableRequest())
            {
                var requestCancel = new DocRequestCancellation(HttpContext.Current.Response, cancellableRequest);
                try 
                {
                    var ret = new List<Event>();
                    _ExecSearch(request, (entities) => entities.ConvertFromEntityList<DocEntityEvent,Event>(ret, Execute, requestCancel));
                    tryRet = ret;
                }
                catch(Exception) { throw; }
                finally
                {
                    requestCancel?.CloseRequest();
                }
            }
            return tryRet;
        }

        public object Post(EventVersion request) 
        {
            return Get(request);
        }

        public object Get(EventVersion request) 
        {
            var ret = new List<Version>();
            _ExecSearch(request, (entities) => 
            {
                ret = entities.Select(e => new Version(e.Id, e.VersionNo)).ToList();
            });
            return ret;
        }

        public object Get(Event request)
        {
            Event ret = null;
            
            if(!(request.Id > 0))
                throw new HttpError(HttpStatusCode.NotFound, "Valid Id required.");

            DocPermissionFactory.SetVisibleFields<Event>(currentUser, "Event", request.VisibleFields);
            Execute.Run((ssn) =>
            {
                ret = GetEvent(request);
            });
            return ret;
        }




        public object Get(EventJunction request)
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
                case "team":
                    ret = _GetEventTeam(request, skip, take);
                    break;
                case "update":
                    ret = _GetEventUpdate(request, skip, take);
                    break;
                case "user":
                    ret = _GetEventUser(request, skip, take);
                    break;
                }
            });
            return ret;
        }
        
        public object Get(EventJunctionVersion request)
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
        

        private object _GetEventTeam(EventJunction request, int skip, int take)
        {
             DocPermissionFactory.SetVisibleFields<Team>(currentUser, "Team", request.VisibleFields);
             var en = DocEntityEvent.GetEvent(request.Id);
             if (!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.VIEW, targetName: DocConstantModelName.EVENT, columnName: "Teams", targetEntity: null))
                 throw new HttpError(HttpStatusCode.Forbidden, "You do not have View permission to relationships between Event and Team");
             return en?.Teams.Take(take).Skip(skip).ConvertFromEntityList<DocEntityTeam,Team>(new List<Team>());
        }

        private object _GetEventUpdate(EventJunction request, int skip, int take)
        {
             DocPermissionFactory.SetVisibleFields<Update>(currentUser, "Update", request.VisibleFields);
             var en = DocEntityEvent.GetEvent(request.Id);
             if (!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.VIEW, targetName: DocConstantModelName.EVENT, columnName: "Updates", targetEntity: null))
                 throw new HttpError(HttpStatusCode.Forbidden, "You do not have View permission to relationships between Event and Update");
             return en?.Updates.Take(take).Skip(skip).ConvertFromEntityList<DocEntityUpdate,Update>(new List<Update>());
        }

        private object _GetEventUser(EventJunction request, int skip, int take)
        {
             DocPermissionFactory.SetVisibleFields<User>(currentUser, "User", request.VisibleFields);
             var en = DocEntityEvent.GetEvent(request.Id);
             if (!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.VIEW, targetName: DocConstantModelName.EVENT, columnName: "Users", targetEntity: null))
                 throw new HttpError(HttpStatusCode.Forbidden, "You do not have View permission to relationships between Event and User");
             return en?.Users.Take(take).Skip(skip).ConvertFromEntityList<DocEntityUser,User>(new List<User>());
        }
        
        public object Post(EventJunction request)
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


        public object Delete(EventJunction request)
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


        private Event GetEvent(Event request)
        {
            var id = request?.Id;
            Event ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetVisibleFields<Event>(currentUser, "Event", request.VisibleFields);

            DocEntityEvent entity = null;
            if(id.HasValue)
            {
                entity = DocEntityEvent.GetEvent(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No Event found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }

        public List<int> Any(EventIds request)
        {
            List<int> ret = null;
            if (currentUser.IsSuperAdmin)
            {
                Execute.Run(s => { ret = Execute.SelectAll<DocEntityEvent>().Select(d => d.Id).ToList(); });
            }
            else
            {
                throw new HttpError(HttpStatusCode.Forbidden);
            }

            return ret;
        }
    }
}