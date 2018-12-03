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
    public partial class UpdateService : DocServiceBase
    {
        public const string CACHE_KEY_PREFIX = DocEntityUpdate.CACHE_KEY_PREFIX;
        private void _ExecSearch(UpdateSearch request, Action<IQueryable<DocEntityUpdate>> callBack)
        {
            request = InitSearch(request);
            
            DocPermissionFactory.SetVisibleFields<Update>(currentUser, "Update", request.VisibleFields);

            Execute.Run( session => 
            {
                var entities = Execute.SelectAll<DocEntityUpdate>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new UpdateFullTextSearch(request);
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
        
        public object Post(UpdateSearch request)
        {
            object tryRet = null;
            using (var cancellableRequest = base.Request.CreateCancellableRequest())
            {
                var requestCancel = new DocRequestCancellation(HttpContext.Current.Response, cancellableRequest);
                try 
                {
                    var ret = new List<Update>();
                    _ExecSearch(request, (entities) => entities.ConvertFromEntityList<DocEntityUpdate,Update>(ret, Execute, requestCancel));
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

        public object Get(UpdateSearch request)
        {
            object tryRet = null;
            using (var cancellableRequest = base.Request.CreateCancellableRequest())
            {
                var requestCancel = new DocRequestCancellation(HttpContext.Current.Response, cancellableRequest);
                try 
                {
                    var ret = new List<Update>();
                    _ExecSearch(request, (entities) => entities.ConvertFromEntityList<DocEntityUpdate,Update>(ret, Execute, requestCancel));
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

        public object Post(UpdateVersion request) 
        {
            return Get(request);
        }

        public object Get(UpdateVersion request) 
        {
            var ret = new List<Version>();
            _ExecSearch(request, (entities) => 
            {
                ret = entities.Select(e => new Version(e.Id, e.VersionNo)).ToList();
            });
            return ret;
        }

        public object Get(Update request)
        {
            Update ret = null;
            
            if(!(request.Id > 0))
                throw new HttpError(HttpStatusCode.NotFound, "Valid Id required.");

            DocPermissionFactory.SetVisibleFields<Update>(currentUser, "Update", request.VisibleFields);
            Execute.Run((ssn) =>
            {
                ret = GetUpdate(request);
            });
            return ret;
        }

        private Update _AssignValues(Update dtoSource, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (dtoSource == null || dtoSource.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "Update"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            dtoSource.VisibleFields = dtoSource.VisibleFields ?? new List<string>();

            Update ret = null;
            dtoSource = _InitAssignValues(dtoSource, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && dtoSource.Id > 0) return dtoSource;
            
            //First, assign all the variables, do database lookups and conversions
            var pBody = dtoSource.Body;
            var pDeliveryStatus = dtoSource.DeliveryStatus;
            var pEmailAttempts = dtoSource.EmailAttempts;
            var pEmailSent = dtoSource.EmailSent;
            var pEvents = dtoSource.Events?.ToList();
            var pLink = dtoSource.Link;
            var pPriority = dtoSource.Priority;
            var pRead = dtoSource.Read;
            var pSlackSent = dtoSource.SlackSent;
            var pSubject = dtoSource.Subject;
            var pTeam = (dtoSource.Team?.Id > 0) ? DocEntityTeam.GetTeam(dtoSource.Team.Id) : null;
            var pUser = (dtoSource.User?.Id > 0) ? DocEntityUser.GetUser(dtoSource.User.Id) : null;

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
                entity = DocEntityUpdate.GetUpdate(dtoSource.Id);
                if(null == entity)
                    throw new HttpError(HttpStatusCode.NotFound, $"No record");
            }

            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, dtoSource, pBody, permission, DocConstantModelName.UPDATE, nameof(dtoSource.Body)))
            {
                if(DocPermissionFactory.IsRequested(dtoSource, pBody, entity.Body, nameof(dtoSource.Body)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(dtoSource.Body)} cannot be modified once set.");
                    entity.Body = pBody;
                if(DocPermissionFactory.IsRequested<string>(dtoSource, pBody, nameof(dtoSource.Body)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.Body), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.Body));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, dtoSource, pDeliveryStatus, permission, DocConstantModelName.UPDATE, nameof(dtoSource.DeliveryStatus)))
            {
                if(DocPermissionFactory.IsRequested(dtoSource, pDeliveryStatus, entity.DeliveryStatus, nameof(dtoSource.DeliveryStatus)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(dtoSource.DeliveryStatus)} cannot be modified once set.");
                    entity.DeliveryStatus = pDeliveryStatus;
                if(DocPermissionFactory.IsRequested<string>(dtoSource, pDeliveryStatus, nameof(dtoSource.DeliveryStatus)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.DeliveryStatus), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.DeliveryStatus));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<int?>(currentUser, dtoSource, pEmailAttempts, permission, DocConstantModelName.UPDATE, nameof(dtoSource.EmailAttempts)))
            {
                if(DocPermissionFactory.IsRequested(dtoSource, pEmailAttempts, entity.EmailAttempts, nameof(dtoSource.EmailAttempts)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(dtoSource.EmailAttempts)} cannot be modified once set.");
                    if(null != pEmailAttempts)
                        entity.EmailAttempts = (int) pEmailAttempts;
                if(DocPermissionFactory.IsRequested<int?>(dtoSource, pEmailAttempts, nameof(dtoSource.EmailAttempts)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.EmailAttempts), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.EmailAttempts));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DateTime?>(currentUser, dtoSource, pEmailSent, permission, DocConstantModelName.UPDATE, nameof(dtoSource.EmailSent)))
            {
                if(DocPermissionFactory.IsRequested(dtoSource, pEmailSent, entity.EmailSent, nameof(dtoSource.EmailSent)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(dtoSource.EmailSent)} cannot be modified once set.");
                    entity.EmailSent = pEmailSent;
                if(DocPermissionFactory.IsRequested<DateTime?>(dtoSource, pEmailSent, nameof(dtoSource.EmailSent)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.EmailSent), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.EmailSent));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, dtoSource, pLink, permission, DocConstantModelName.UPDATE, nameof(dtoSource.Link)))
            {
                if(DocPermissionFactory.IsRequested(dtoSource, pLink, entity.Link, nameof(dtoSource.Link)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(dtoSource.Link)} cannot be modified once set.");
                    entity.Link = pLink;
                if(DocPermissionFactory.IsRequested<string>(dtoSource, pLink, nameof(dtoSource.Link)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.Link), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.Link));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<int?>(currentUser, dtoSource, pPriority, permission, DocConstantModelName.UPDATE, nameof(dtoSource.Priority)))
            {
                if(DocPermissionFactory.IsRequested(dtoSource, pPriority, entity.Priority, nameof(dtoSource.Priority)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(dtoSource.Priority)} cannot be modified once set.");
                    if(null != pPriority)
                        entity.Priority = (int) pPriority;
                if(DocPermissionFactory.IsRequested<int?>(dtoSource, pPriority, nameof(dtoSource.Priority)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.Priority), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.Priority));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DateTime?>(currentUser, dtoSource, pRead, permission, DocConstantModelName.UPDATE, nameof(dtoSource.Read)))
            {
                if(DocPermissionFactory.IsRequested(dtoSource, pRead, entity.Read, nameof(dtoSource.Read)))
                    entity.Read = pRead;
                if(DocPermissionFactory.IsRequested<DateTime?>(dtoSource, pRead, nameof(dtoSource.Read)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.Read), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.Read));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DateTime?>(currentUser, dtoSource, pSlackSent, permission, DocConstantModelName.UPDATE, nameof(dtoSource.SlackSent)))
            {
                if(DocPermissionFactory.IsRequested(dtoSource, pSlackSent, entity.SlackSent, nameof(dtoSource.SlackSent)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(dtoSource.SlackSent)} cannot be modified once set.");
                    entity.SlackSent = pSlackSent;
                if(DocPermissionFactory.IsRequested<DateTime?>(dtoSource, pSlackSent, nameof(dtoSource.SlackSent)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.SlackSent), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.SlackSent));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, dtoSource, pSubject, permission, DocConstantModelName.UPDATE, nameof(dtoSource.Subject)))
            {
                if(DocPermissionFactory.IsRequested(dtoSource, pSubject, entity.Subject, nameof(dtoSource.Subject)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(dtoSource.Subject)} cannot be modified once set.");
                    entity.Subject = pSubject;
                if(DocPermissionFactory.IsRequested<string>(dtoSource, pSubject, nameof(dtoSource.Subject)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.Subject), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.Subject));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityTeam>(currentUser, dtoSource, pTeam, permission, DocConstantModelName.UPDATE, nameof(dtoSource.Team)))
            {
                if(DocPermissionFactory.IsRequested(dtoSource, pTeam, entity.Team, nameof(dtoSource.Team)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(dtoSource.Team)} cannot be modified once set.");
                    entity.Team = pTeam;
                if(DocPermissionFactory.IsRequested<DocEntityTeam>(dtoSource, pTeam, nameof(dtoSource.Team)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.Team), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.Team));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityUser>(currentUser, dtoSource, pUser, permission, DocConstantModelName.UPDATE, nameof(dtoSource.User)))
            {
                if(DocPermissionFactory.IsRequested(dtoSource, pUser, entity.User, nameof(dtoSource.User)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(dtoSource.User)} cannot be modified once set.");
                    entity.User = pUser;
                if(DocPermissionFactory.IsRequested<DocEntityUser>(dtoSource, pUser, nameof(dtoSource.User)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.User), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.User));
                }
            }
            
            if (dtoSource.Locked) entity.Locked = dtoSource.Locked;

            entity.SaveChanges(permission);
            
            if (DocPermissionFactory.IsRequestedHasPermission<List<Reference>>(currentUser, dtoSource, pEvents, permission, DocConstantModelName.UPDATE, nameof(dtoSource.Events)))
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
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD, targetEntity: target, targetName: nameof(Update), columnName: nameof(dtoSource.Events)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to add {nameof(dtoSource.Events)} to {nameof(Update)}");
                        entity.Events.Add(target);
                    });
                    var toRemove = entity.Events.Where(e => requestedEvents.All(id => e.Id != id)).Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityEvent.GetEvent(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(Update), columnName: nameof(dtoSource.Events)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(dtoSource.Events)} from {nameof(Update)}");
                        entity.Events.Remove(target);
                    });
                }
                else
                {
                    var toRemove = entity.Events.Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityEvent.GetEvent(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(Update), columnName: nameof(dtoSource.Events)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(dtoSource.Events)} from {nameof(Update)}");
                        entity.Events.Remove(target);
                    });
                }
                if(DocPermissionFactory.IsRequested<List<Reference>>(dtoSource, pEvents, nameof(dtoSource.Events)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.Events), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.Events));
                }
            }
            DocPermissionFactory.SetVisibleFields<Update>(currentUser, nameof(Update), dtoSource.VisibleFields);
            ret = entity.ToDto();

            return ret;
        }


        public List<Update> Put(UpdateBatch request)
        {
            return Patch(request);
        }

        public Update Put(Update dtoSource)
        {
            return Patch(dtoSource);
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

        public Update Patch(Update dtoSource)
        {
            if(true != (dtoSource?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the Update to patch.");
            
            dtoSource.VisibleFields = dtoSource.VisibleFields ?? new List<string>();
            
            Update ret = null;
            Execute.Run(ssn =>
            {
                ret = _AssignValues(dtoSource, DocConstantPermission.EDIT, ssn);
            });
            return ret;
        }

        public object Get(UpdateJunction request)
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
                case "event":
                    ret = _GetUpdateEvent(request, skip, take);
                    break;
                }
            });
            return ret;
        }
        
        public object Get(UpdateJunctionVersion request)
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
        

        private object _GetUpdateEvent(UpdateJunction request, int skip, int take)
        {
             DocPermissionFactory.SetVisibleFields<Event>(currentUser, "Event", request.VisibleFields);
             var en = DocEntityUpdate.GetUpdate(request.Id);
             if (!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.VIEW, targetName: DocConstantModelName.UPDATE, columnName: "Events", targetEntity: null))
                 throw new HttpError(HttpStatusCode.Forbidden, "You do not have View permission to relationships between Update and Event");
             return en?.Events.Take(take).Skip(skip).ConvertFromEntityList<DocEntityEvent,Event>(new List<Event>());
        }
        
        public object Post(UpdateJunction request)
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


        public object Delete(UpdateJunction request)
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

        public List<int> Any(UpdateIds request)
        {
            List<int> ret = null;
            if (currentUser.IsSuperAdmin)
            {
                Execute.Run(s => { ret = Execute.SelectAll<DocEntityUpdate>().Select(d => d.Id).ToList(); });
            }
            else
            {
                throw new HttpError(HttpStatusCode.Forbidden);
            }

            return ret;
        }
    }
}