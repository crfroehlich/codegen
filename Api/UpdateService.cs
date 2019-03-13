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
    public partial class UpdateService : DocServiceBase
    {
        private IQueryable<DocEntityUpdate> _ExecSearch(UpdateSearch request)
        {
            request = InitSearch<Update, UpdateSearch>(request);
            IQueryable<DocEntityUpdate> entities = null;
            Execute.Run( session => 
            {
                entities = Execute.SelectAll<DocEntityUpdate>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new UpdateFullTextSearch(request);
                    entities = GetFullTextSearch<DocEntityUpdate,UpdateFullTextSearch>(fts, entities);
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
                if(true == request.Archived?.Any() && currentUser.HasProperty(DocConstantModelName.UPDATE, nameof(Reference.Archived), DocConstantPermission.VIEW))
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

                if(!DocTools.IsNullOrEmpty(request.Body))
                    entities = entities.Where(en => en.Body.Contains(request.Body));
                if(!DocTools.IsNullOrEmpty(request.DeliveryStatus))
                    entities = entities.Where(en => en.DeliveryStatus.Contains(request.DeliveryStatus));
                if(request.EmailAttempts.HasValue)
                    entities = entities.Where(en => request.EmailAttempts.Value == en.EmailAttempts);
                if(!DocTools.IsNullOrEmpty(request.EmailSent))
                    entities = entities.Where(en => null != en.EmailSent && request.EmailSent.Value.Date == en.EmailSent.Value.Date);
                if(!DocTools.IsNullOrEmpty(request.EmailSentBefore))
                    entities = entities.Where(en => en.EmailSent <= request.EmailSentBefore);
                if(!DocTools.IsNullOrEmpty(request.EmailSentAfter))
                    entities = entities.Where(en => en.EmailSent >= request.EmailSentAfter);
                if(true == request.EventsIds?.Any())
                {
                    entities = entities.Where(en => en.Events.Any(r => r.Id.In(request.EventsIds)));
                }
                if(!DocTools.IsNullOrEmpty(request.Link))
                    entities = entities.Where(en => en.Link.Contains(request.Link));
                if(request.Priority.HasValue)
                    entities = entities.Where(en => request.Priority.Value == en.Priority);
                if(!DocTools.IsNullOrEmpty(request.Read))
                    entities = entities.Where(en => null != en.Read && request.Read.Value.Date == en.Read.Value.Date);
                if(!DocTools.IsNullOrEmpty(request.ReadBefore))
                    entities = entities.Where(en => en.Read <= request.ReadBefore);
                if(!DocTools.IsNullOrEmpty(request.ReadAfter))
                    entities = entities.Where(en => en.Read >= request.ReadAfter);
                if(!DocTools.IsNullOrEmpty(request.SlackSent))
                    entities = entities.Where(en => null != en.SlackSent && request.SlackSent.Value.Date == en.SlackSent.Value.Date);
                if(!DocTools.IsNullOrEmpty(request.SlackSentBefore))
                    entities = entities.Where(en => en.SlackSent <= request.SlackSentBefore);
                if(!DocTools.IsNullOrEmpty(request.SlackSentAfter))
                    entities = entities.Where(en => en.SlackSent >= request.SlackSentAfter);
                if(!DocTools.IsNullOrEmpty(request.Subject))
                    entities = entities.Where(en => en.Subject.Contains(request.Subject));
                if(!DocTools.IsNullOrEmpty(request.Team) && !DocTools.IsNullOrEmpty(request.Team.Id))
                {
                    entities = entities.Where(en => en.Team.Id == request.Team.Id );
                }
                if(true == request.TeamIds?.Any())
                {
                    entities = entities.Where(en => en.Team.Id.In(request.TeamIds));
                }
                if(!DocTools.IsNullOrEmpty(request.User) && !DocTools.IsNullOrEmpty(request.User.Id))
                {
                    entities = entities.Where(en => en.User.Id == request.User.Id );
                }
                if(true == request.UserIds?.Any())
                {
                    entities = entities.Where(en => en.User.Id.In(request.UserIds));
                }

                entities = ApplyFilters<DocEntityUpdate,UpdateSearch>(request, entities);

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

        public object Post(UpdateSearch request) => Get(request);

        public object Get(UpdateSearch request) => GetSearchResultWithCache<Update,DocEntityUpdate,UpdateSearch>(DocConstantModelName.UPDATE, request, _ExecSearch);

        public object Get(Update request) => GetEntityWithCache<Update>(DocConstantModelName.UPDATE, request, GetUpdate);

        private Update _AssignValues(Update request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "Update"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            Update ret = null;
            request = _InitAssignValues<Update>(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            var cacheKey = GetApiCacheKey<Update>(DocConstantModelName.UPDATE, nameof(Update), request);
            
            //First, assign all the variables, do database lookups and conversions
            var pBody = request.Body;
            var pDeliveryStatus = request.DeliveryStatus;
            var pEmailAttempts = request.EmailAttempts;
            var pEmailSent = request.EmailSent;
            var pEvents = request.Events?.ToList();
            var pLink = request.Link;
            var pPriority = request.Priority;
            var pRead = request.Read;
            var pSlackSent = request.SlackSent;
            var pSubject = request.Subject;
            var pTeam = (request.Team?.Id > 0) ? DocEntityTeam.GetTeam(request.Team.Id) : null;
            var pUser = (request.User?.Id > 0) ? DocEntityUser.GetUser(request.User.Id) : null;

            DocEntityUpdate entity = null;
            if(permission == DocConstantPermission.ADD)
            {
                var now = DateTime.UtcNow;
                entity = new DocEntityUpdate(session)
                {
                    Created = now,
                    Updated = now
                };
            }
            else
            {
                entity = DocEntityUpdate.GetUpdate(request.Id);
                if(null == entity)
                    throw new HttpError(HttpStatusCode.NotFound, $"No record");
            }

            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pBody, permission, DocConstantModelName.UPDATE, nameof(request.Body)))
            {
                if(DocPermissionFactory.IsRequested(request, pBody, entity.Body, nameof(request.Body)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.UPDATE, nameof(request.Body)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Body)} cannot be modified once set.");
                    entity.Body = pBody;
                if(DocPermissionFactory.IsRequested<string>(request, pBody, nameof(request.Body)) && !request.VisibleFields.Matches(nameof(request.Body), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Body));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pDeliveryStatus, permission, DocConstantModelName.UPDATE, nameof(request.DeliveryStatus)))
            {
                if(DocPermissionFactory.IsRequested(request, pDeliveryStatus, entity.DeliveryStatus, nameof(request.DeliveryStatus)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.UPDATE, nameof(request.DeliveryStatus)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.DeliveryStatus)} cannot be modified once set.");
                    entity.DeliveryStatus = pDeliveryStatus;
                if(DocPermissionFactory.IsRequested<string>(request, pDeliveryStatus, nameof(request.DeliveryStatus)) && !request.VisibleFields.Matches(nameof(request.DeliveryStatus), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.DeliveryStatus));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<int?>(currentUser, request, pEmailAttempts, permission, DocConstantModelName.UPDATE, nameof(request.EmailAttempts)))
            {
                if(DocPermissionFactory.IsRequested(request, pEmailAttempts, entity.EmailAttempts, nameof(request.EmailAttempts)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.UPDATE, nameof(request.EmailAttempts)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.EmailAttempts)} cannot be modified once set.");
                    if(null != pEmailAttempts)
                        entity.EmailAttempts = (int) pEmailAttempts;
                if(DocPermissionFactory.IsRequested<int?>(request, pEmailAttempts, nameof(request.EmailAttempts)) && !request.VisibleFields.Matches(nameof(request.EmailAttempts), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.EmailAttempts));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DateTime?>(currentUser, request, pEmailSent, permission, DocConstantModelName.UPDATE, nameof(request.EmailSent)))
            {
                if(DocPermissionFactory.IsRequested(request, pEmailSent, entity.EmailSent, nameof(request.EmailSent)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.UPDATE, nameof(request.EmailSent)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.EmailSent)} cannot be modified once set.");
                    entity.EmailSent = pEmailSent;
                if(DocPermissionFactory.IsRequested<DateTime?>(request, pEmailSent, nameof(request.EmailSent)) && !request.VisibleFields.Matches(nameof(request.EmailSent), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.EmailSent));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pLink, permission, DocConstantModelName.UPDATE, nameof(request.Link)))
            {
                if(DocPermissionFactory.IsRequested(request, pLink, entity.Link, nameof(request.Link)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.UPDATE, nameof(request.Link)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Link)} cannot be modified once set.");
                    entity.Link = pLink;
                if(DocPermissionFactory.IsRequested<string>(request, pLink, nameof(request.Link)) && !request.VisibleFields.Matches(nameof(request.Link), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Link));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<int?>(currentUser, request, pPriority, permission, DocConstantModelName.UPDATE, nameof(request.Priority)))
            {
                if(DocPermissionFactory.IsRequested(request, pPriority, entity.Priority, nameof(request.Priority)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.UPDATE, nameof(request.Priority)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Priority)} cannot be modified once set.");
                    if(null != pPriority)
                        entity.Priority = (int) pPriority;
                if(DocPermissionFactory.IsRequested<int?>(request, pPriority, nameof(request.Priority)) && !request.VisibleFields.Matches(nameof(request.Priority), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Priority));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DateTime?>(currentUser, request, pRead, permission, DocConstantModelName.UPDATE, nameof(request.Read)))
            {
                if(DocPermissionFactory.IsRequested(request, pRead, entity.Read, nameof(request.Read)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.UPDATE, nameof(request.Read)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Read)} cannot be modified once set.");
                    entity.Read = pRead;
                if(DocPermissionFactory.IsRequested<DateTime?>(request, pRead, nameof(request.Read)) && !request.VisibleFields.Matches(nameof(request.Read), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Read));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DateTime?>(currentUser, request, pSlackSent, permission, DocConstantModelName.UPDATE, nameof(request.SlackSent)))
            {
                if(DocPermissionFactory.IsRequested(request, pSlackSent, entity.SlackSent, nameof(request.SlackSent)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.UPDATE, nameof(request.SlackSent)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.SlackSent)} cannot be modified once set.");
                    entity.SlackSent = pSlackSent;
                if(DocPermissionFactory.IsRequested<DateTime?>(request, pSlackSent, nameof(request.SlackSent)) && !request.VisibleFields.Matches(nameof(request.SlackSent), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.SlackSent));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pSubject, permission, DocConstantModelName.UPDATE, nameof(request.Subject)))
            {
                if(DocPermissionFactory.IsRequested(request, pSubject, entity.Subject, nameof(request.Subject)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.UPDATE, nameof(request.Subject)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Subject)} cannot be modified once set.");
                    entity.Subject = pSubject;
                if(DocPermissionFactory.IsRequested<string>(request, pSubject, nameof(request.Subject)) && !request.VisibleFields.Matches(nameof(request.Subject), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Subject));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityTeam>(currentUser, request, pTeam, permission, DocConstantModelName.UPDATE, nameof(request.Team)))
            {
                if(DocPermissionFactory.IsRequested(request, pTeam, entity.Team, nameof(request.Team)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.UPDATE, nameof(request.Team)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Team)} cannot be modified once set.");
                    entity.Team = pTeam;
                if(DocPermissionFactory.IsRequested<DocEntityTeam>(request, pTeam, nameof(request.Team)) && !request.VisibleFields.Matches(nameof(request.Team), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Team));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityUser>(currentUser, request, pUser, permission, DocConstantModelName.UPDATE, nameof(request.User)))
            {
                if(DocPermissionFactory.IsRequested(request, pUser, entity.User, nameof(request.User)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.UPDATE, nameof(request.User)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.User)} cannot be modified once set.");
                    entity.User = pUser;
                if(DocPermissionFactory.IsRequested<DocEntityUser>(request, pUser, nameof(request.User)) && !request.VisibleFields.Matches(nameof(request.User), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.User));
                }
            }

            if (request.Locked) entity.Locked = request.Locked;

            entity.SaveChanges(permission);

            if (DocPermissionFactory.IsRequestedHasPermission<List<Reference>>(currentUser, request, pEvents, permission, DocConstantModelName.UPDATE, nameof(request.Events)))
            {
                if (true == pEvents?.Any() )
                {
                    var requestedEvents = pEvents.Select(p => p.Id).Distinct().ToList();
                    var existsEvents = Execute.SelectAll<DocEntityEvent>().Where(e => e.Id.In(requestedEvents)).Select( e => e.Id ).ToList();
                    if (existsEvents.Count != requestedEvents.Count)
                    {
                        var nonExists = requestedEvents.Where(id => existsEvents.All(eId => eId != id));
                        throw new HttpError(HttpStatusCode.NotFound, $"Cannot patch collection Events with objects that do not exist. No matching Events(s) could be found for Ids: {nonExists.ToDelimitedString()}.");
                    }
                    var toAdd = requestedEvents.Where(id => entity.Events.All(e => e.Id != id)).ToList(); 
                    toAdd?.ForEach(id =>
                    {
                        var target = DocEntityEvent.GetEvent(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD, targetEntity: target, targetName: nameof(Update), columnName: nameof(request.Events)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to add {nameof(request.Events)} to {nameof(Update)}");
                        entity.Events.Add(target);
                    });
                    var toRemove = entity.Events.Where(e => requestedEvents.All(id => e.Id != id)).Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityEvent.GetEvent(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(Update), columnName: nameof(request.Events)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Events)} from {nameof(Update)}");
                        entity.Events.Remove(target);
                    });
                }
                else
                {
                    var toRemove = entity.Events.Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityEvent.GetEvent(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(Update), columnName: nameof(request.Events)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Events)} from {nameof(Update)}");
                        entity.Events.Remove(target);
                    });
                }
                if(DocPermissionFactory.IsRequested<List<Reference>>(request, pEvents, nameof(request.Events)) && !request.VisibleFields.Matches(nameof(request.Events), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Events));
                }
            }
            DocPermissionFactory.SetVisibleFields<Update>(currentUser, nameof(Update), request.VisibleFields);
            ret = entity.ToDto();

            var cacheExpires = DocResources.Metadata.GetCacheExpiration(DocConstantModelName.UPDATE);
            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.UPDATE, cacheExpires);

            return ret;
        }

        public List<Update> Put(UpdateBatch request)
        {
            return Patch(request);
        }

        public Update Put(Update request)
        {
            return Patch(request);
        }
        public List<Update> Patch(UpdateBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<Update>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Patch(dto) as Update;
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

        public Update Patch(Update request)
        {
            if(true != (request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the Update to patch.");
            
            request.VisibleFields = request.VisibleFields ?? new List<string>();
            
            Update ret = null;
            Execute.Run(ssn =>
            {
                ret = _AssignValues(request, DocConstantPermission.EDIT, ssn);
            });
            return ret;
        }
        public object Get(UpdateJunction request) =>
            Execute.Run( s => 
            {
                switch(request.Junction.ToLower().TrimAndPruneSpaces())
                {
                    case "event":
                        return GetJunctionSearchResult<Update, DocEntityUpdate, DocEntityEvent, Event, EventSearch>((int)request.Id, DocConstantModelName.EVENT, "Events", request, (ss) => HostContext.ResolveService<EventService>(Request)?.Get(ss));
                    default:
                        throw new HttpError(HttpStatusCode.NotFound, $"Route for update/{request.Id}/{request.Junction} was not found");
                }
            });
        private Update GetUpdate(Update request)
        {
            var id = request?.Id;
            Update ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetVisibleFields<Update>(currentUser, "Update", request.VisibleFields);

            DocEntityUpdate entity = null;
            if(id.HasValue)
            {
                entity = DocEntityUpdate.GetUpdate(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No Update found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }
    }
}
