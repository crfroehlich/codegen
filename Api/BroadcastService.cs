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
    public partial class BroadcastService : DocServiceBase
    {
        private IQueryable<DocEntityBroadcast> _ExecSearch(BroadcastSearch request)
        {
            request = InitSearch<Broadcast, BroadcastSearch>(request);
            IQueryable<DocEntityBroadcast> entities = null;
            Execute.Run( session => 
            {
                entities = Execute.SelectAll<DocEntityBroadcast>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new BroadcastFullTextSearch(request);
                    entities = GetFullTextSearch<DocEntityBroadcast,BroadcastFullTextSearch>(fts, entities);
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
                if(true == request.Archived?.Any() && currentUser.HasProperty(DocConstantModelName.BROADCAST, nameof(Reference.Archived), DocConstantPermission.VIEW))
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
                if(!DocTools.IsNullOrEmpty(request.ConfluenceId))
                    entities = entities.Where(en => en.ConfluenceId.Contains(request.ConfluenceId));
                if(!DocTools.IsNullOrEmpty(request.Name))
                    entities = entities.Where(en => en.Name.Contains(request.Name));
                if(true == request.Reprocess?.Any())
                {
                    if(request.Reprocess.Any(v => v == null)) entities = entities.Where(en => en.Reprocess.In(request.Reprocess) || en.Reprocess == null);
                    else entities = entities.Where(en => en.Reprocess.In(request.Reprocess));
                }
                if(!DocTools.IsNullOrEmpty(request.Reprocessed))
                    entities = entities.Where(en => null != en.Reprocessed && request.Reprocessed.Value.Date == en.Reprocessed.Value.Date);
                if(!DocTools.IsNullOrEmpty(request.ReprocessedBefore))
                    entities = entities.Where(en => en.Reprocessed <= request.ReprocessedBefore);
                if(!DocTools.IsNullOrEmpty(request.ReprocessedAfter))
                    entities = entities.Where(en => en.Reprocessed >= request.ReprocessedAfter);
                if(true == request.ScopesIds?.Any())
                {
                    entities = entities.Where(en => en.Scopes.Any(r => r.Id.In(request.ScopesIds)));
                }
                if(!DocTools.IsNullOrEmpty(request.Status) && !DocTools.IsNullOrEmpty(request.Status.Id))
                {
                    entities = entities.Where(en => en.Status.Id == request.Status.Id );
                }
                if(true == request.StatusIds?.Any())
                {
                    entities = entities.Where(en => en.Status.Id.In(request.StatusIds));
                }
                else if(!DocTools.IsNullOrEmpty(request.Status) && !DocTools.IsNullOrEmpty(request.Status.Name))
                {
                    entities = entities.Where(en => en.Status.Name == request.Status.Name );
                }
                if(true == request.StatusNames?.Any())
                {
                    entities = entities.Where(en => en.Status.Name.In(request.StatusNames));
                }
                if(!DocTools.IsNullOrEmpty(request.Type) && !DocTools.IsNullOrEmpty(request.Type.Id))
                {
                    entities = entities.Where(en => en.Type.Id == request.Type.Id );
                }
                if(true == request.TypeIds?.Any())
                {
                    entities = entities.Where(en => en.Type.Id.In(request.TypeIds));
                }
                else if(!DocTools.IsNullOrEmpty(request.Type) && !DocTools.IsNullOrEmpty(request.Type.Name))
                {
                    entities = entities.Where(en => en.Type.Name == request.Type.Name );
                }
                if(true == request.TypeNames?.Any())
                {
                    entities = entities.Where(en => en.Type.Name.In(request.TypeNames));
                }

                entities = ApplyFilters<DocEntityBroadcast,BroadcastSearch>(request, entities);

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

        public object Post(BroadcastSearch request) => Get(request);

        public object Get(BroadcastSearch request) => GetSearchResultWithCache<Broadcast,DocEntityBroadcast,BroadcastSearch>(DocConstantModelName.BROADCAST, request, _ExecSearch);

        public object Get(Broadcast request) => GetEntityWithCache<Broadcast>(DocConstantModelName.BROADCAST, request, GetBroadcast);
        private Broadcast _AssignValues(Broadcast request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "Broadcast"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            Broadcast ret = null;
            request = _InitAssignValues<Broadcast>(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            var cacheKey = GetApiCacheKey<Broadcast>(DocConstantModelName.BROADCAST, nameof(Broadcast), request);
            
            //First, assign all the variables, do database lookups and conversions
            var pApp = (request.App?.Id > 0) ? DocEntityApp.GetApp(request.App.Id) : null;
            var pConfluenceId = request.ConfluenceId;
            var pName = request.Name;
            var pReprocess = request.Reprocess;
            var pReprocessed = request.Reprocessed;
            var pScopes = request.Scopes?.ToList();
            DocEntityLookupTable pStatus = GetLookup(DocConstantLookupTable.BROADCASTSTATUS, request.Status?.Name, request.Status?.Id);
            DocEntityLookupTable pType = GetLookup(DocConstantLookupTable.BROADCASTTYPE, request.Type?.Name, request.Type?.Id);

            DocEntityBroadcast entity = null;
            if(permission == DocConstantPermission.ADD)
            {
                var now = DateTime.UtcNow;
                entity = new DocEntityBroadcast(session)
                {
                    Created = now,
                    Updated = now
                };
            }
            else
            {
                entity = DocEntityBroadcast.GetBroadcast(request.Id);
                if(null == entity)
                    throw new HttpError(HttpStatusCode.NotFound, $"No record");
            }

            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityApp>(currentUser, request, pApp, permission, DocConstantModelName.BROADCAST, nameof(request.App)))
            {
                if(DocPermissionFactory.IsRequested(request, pApp, entity.App, nameof(request.App)))
                    entity.App = pApp;
                if(DocPermissionFactory.IsRequested<DocEntityApp>(request, pApp, nameof(request.App)) && !request.VisibleFields.Matches(nameof(request.App), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.App));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pConfluenceId, permission, DocConstantModelName.BROADCAST, nameof(request.ConfluenceId)))
            {
                if(DocPermissionFactory.IsRequested(request, pConfluenceId, entity.ConfluenceId, nameof(request.ConfluenceId)))
                    entity.ConfluenceId = pConfluenceId;
                if(DocPermissionFactory.IsRequested<string>(request, pConfluenceId, nameof(request.ConfluenceId)) && !request.VisibleFields.Matches(nameof(request.ConfluenceId), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.ConfluenceId));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pName, permission, DocConstantModelName.BROADCAST, nameof(request.Name)))
            {
                if(DocPermissionFactory.IsRequested(request, pName, entity.Name, nameof(request.Name)))
                    entity.Name = pName;
                if(DocPermissionFactory.IsRequested<string>(request, pName, nameof(request.Name)) && !request.VisibleFields.Matches(nameof(request.Name), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Name));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<bool>(currentUser, request, pReprocess, permission, DocConstantModelName.BROADCAST, nameof(request.Reprocess)))
            {
                if(DocPermissionFactory.IsRequested(request, pReprocess, entity.Reprocess, nameof(request.Reprocess)))
                    entity.Reprocess = pReprocess;
                if(DocPermissionFactory.IsRequested<bool>(request, pReprocess, nameof(request.Reprocess)) && !request.VisibleFields.Matches(nameof(request.Reprocess), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Reprocess));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DateTime?>(currentUser, request, pReprocessed, permission, DocConstantModelName.BROADCAST, nameof(request.Reprocessed)))
            {
                if(DocPermissionFactory.IsRequested(request, pReprocessed, entity.Reprocessed, nameof(request.Reprocessed)))
                    entity.Reprocessed = pReprocessed;
                if(DocPermissionFactory.IsRequested<DateTime?>(request, pReprocessed, nameof(request.Reprocessed)) && !request.VisibleFields.Matches(nameof(request.Reprocessed), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Reprocessed));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityLookupTable>(currentUser, request, pStatus, permission, DocConstantModelName.BROADCAST, nameof(request.Status)))
            {
                if(DocPermissionFactory.IsRequested(request, pStatus, entity.Status, nameof(request.Status)))
                    entity.Status = pStatus;
                if(DocPermissionFactory.IsRequested<DocEntityLookupTable>(request, pStatus, nameof(request.Status)) && !request.VisibleFields.Matches(nameof(request.Status), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Status));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityLookupTable>(currentUser, request, pType, permission, DocConstantModelName.BROADCAST, nameof(request.Type)))
            {
                if(DocPermissionFactory.IsRequested(request, pType, entity.Type, nameof(request.Type)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Type)} cannot be modified once set.");
                    entity.Type = pType;
                if(DocPermissionFactory.IsRequested<DocEntityLookupTable>(request, pType, nameof(request.Type)) && !request.VisibleFields.Matches(nameof(request.Type), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Type));
                }
            }

            if (request.Locked) entity.Locked = request.Locked;

            entity.SaveChanges(permission);

            if (DocPermissionFactory.IsRequestedHasPermission<List<Reference>>(currentUser, request, pScopes, permission, DocConstantModelName.BROADCAST, nameof(request.Scopes)))
            {
                if (true == pScopes?.Any() )
                {
                    var requestedScopes = pScopes.Select(p => p.Id).Distinct().ToList();
                    var existsScopes = Execute.SelectAll<DocEntityScope>().Where(e => e.Id.In(requestedScopes)).Select( e => e.Id ).ToList();
                    if (existsScopes.Count != requestedScopes.Count)
                    {
                        var nonExists = requestedScopes.Where(id => existsScopes.All(eId => eId != id));
                        throw new HttpError(HttpStatusCode.NotFound, $"Cannot patch collection Scopes with objects that do not exist. No matching Scopes(s) could be found for Ids: {nonExists.ToDelimitedString()}.");
                    }
                    var toAdd = requestedScopes.Where(id => entity.Scopes.All(e => e.Id != id)).ToList(); 
                    toAdd?.ForEach(id =>
                    {
                        var target = DocEntityScope.GetScope(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD, targetEntity: target, targetName: nameof(Broadcast), columnName: nameof(request.Scopes)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to add {nameof(request.Scopes)} to {nameof(Broadcast)}");
                        entity.Scopes.Add(target);
                    });
                    var toRemove = entity.Scopes.Where(e => requestedScopes.All(id => e.Id != id)).Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityScope.GetScope(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(Broadcast), columnName: nameof(request.Scopes)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Scopes)} from {nameof(Broadcast)}");
                        entity.Scopes.Remove(target);
                    });
                }
                else
                {
                    var toRemove = entity.Scopes.Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityScope.GetScope(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(Broadcast), columnName: nameof(request.Scopes)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Scopes)} from {nameof(Broadcast)}");
                        entity.Scopes.Remove(target);
                    });
                }
                if(DocPermissionFactory.IsRequested<List<Reference>>(request, pScopes, nameof(request.Scopes)) && !request.VisibleFields.Matches(nameof(request.Scopes), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Scopes));
                }
            }
            DocPermissionFactory.SetVisibleFields<Broadcast>(currentUser, nameof(Broadcast), request.VisibleFields);
            ret = entity.ToDto();

            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.BROADCAST);

            return ret;
        }
        public Broadcast Post(Broadcast request)
        {
            if(request == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            Broadcast ret = null;

            Execute.Run(ssn =>
            {
                if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "Broadcast")) 
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                ret = _AssignValues(request, DocConstantPermission.ADD, ssn);
            });

            return ret;
        }
   
        public List<Broadcast> Post(BroadcastBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<Broadcast>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Post(dto) as Broadcast;
                    ret.Add(obj);
                    errorMap[$"{i}"] = $"{obj.Id}";
                }
                catch (Exception ex)
                {
                    errorMap[$"{i}"] = null;
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

        public Broadcast Post(BroadcastCopy request)
        {
            Broadcast ret = null;
            Execute.Run(ssn =>
            {
                var entity = DocEntityBroadcast.GetBroadcast(request?.Id);
                if(null == entity) throw new HttpError(HttpStatusCode.NoContent, "The COPY request did not succeed.");
                if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                    var pApp = entity.App;
                    var pConfluenceId = entity.ConfluenceId;
                    if(!DocTools.IsNullOrEmpty(pConfluenceId))
                        pConfluenceId += " (Copy)";
                    var pName = entity.Name;
                    if(!DocTools.IsNullOrEmpty(pName))
                        pName += " (Copy)";
                    var pReprocess = entity.Reprocess;
                    var pReprocessed = entity.Reprocessed;
                    var pScopes = entity.Scopes.ToList();
                    var pStatus = entity.Status;
                    var pType = entity.Type;
                #region Custom Before copyBroadcast
                #endregion Custom Before copyBroadcast
                var copy = new DocEntityBroadcast(ssn)
                {
                    Hash = Guid.NewGuid()
                                , App = pApp
                                , ConfluenceId = pConfluenceId
                                , Name = pName
                                , Reprocess = pReprocess
                                , Reprocessed = pReprocessed
                                , Status = pStatus
                                , Type = pType
                };
                            foreach(var item in pScopes)
                            {
                                entity.Scopes.Add(item);
                            }

                #region Custom After copyBroadcast
                #endregion Custom After copyBroadcast
                copy.SaveChanges(DocConstantPermission.ADD);
                ret = copy.ToDto();
            });
            return ret;
        }

        public List<Broadcast> Put(BroadcastBatch request)
        {
            return Patch(request);
        }

        public Broadcast Put(Broadcast request)
        {
            return Patch(request);
        }
        public List<Broadcast> Patch(BroadcastBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<Broadcast>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Patch(dto) as Broadcast;
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

        public Broadcast Patch(Broadcast request)
        {
            if(true != (request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the Broadcast to patch.");
            
            request.VisibleFields = request.VisibleFields ?? new List<string>();
            
            Broadcast ret = null;
            Execute.Run(ssn =>
            {
                ret = _AssignValues(request, DocConstantPermission.EDIT, ssn);
            });
            return ret;
        }
        public void Delete(BroadcastBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    Delete(dto);
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
            base.Response.AddHeader("X-AutoBatch-Completed", $"{request.Count-errors.Count} succeeded");
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
        }

        public void Delete(Broadcast request)
        {
            Execute.Run(ssn =>
            {
                if(!(request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, $"No Id provided for delete.");

                DocCacheClient.RemoveSearch(DocConstantModelName.BROADCAST);
                DocCacheClient.RemoveById(request.Id);
                var en = DocEntityBroadcast.GetBroadcast(request?.Id);

                if(null == en) throw new HttpError(HttpStatusCode.NotFound, $"No Broadcast could be found for Id {request?.Id}.");
                if(en.IsRemoved) return;
                
                if(!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.DELETE))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have DELETE permission for this route.");
                
                en.Remove();
            });
        }

        public void Delete(BroadcastSearch request)
        {
            var matches = Get(request) as List<Broadcast>;
            if(true != matches?.Any()) throw new HttpError(HttpStatusCode.NotFound, "No matches for request");

            Execute.Run(ssn =>
            {
                matches.ForEach(match =>
                {
                    Delete(match);
                });
            });
        }
        public object Get(BroadcastJunction request) =>
            Execute.Run( s => 
            {
                switch(request.Junction.ToLower().TrimAndPruneSpaces())
                {
                    case "scope":
                        return GetJunctionSearchResult<Broadcast, DocEntityBroadcast, DocEntityScope, Scope, ScopeSearch>((int)request.Id, DocConstantModelName.SCOPE, "Scopes", request, (ss) => HostContext.ResolveService<ScopeService>(Request)?.Get(ss));
                    default:
                        throw new HttpError(HttpStatusCode.NotFound, $"Route for broadcast/{request.Id}/{request.Junction} was not found");
                }
            });
        public object Post(BroadcastJunction request) =>
            Execute.Run( ssn =>
            {
                switch(request.Junction.ToLower().TrimAndPruneSpaces())
                {
                    case "scope":
                        return AddJunction<Broadcast, DocEntityBroadcast, DocEntityScope, Scope, ScopeSearch>((int)request.Id, DocConstantModelName.SCOPE, "Scopes", request);
                    default:
                        throw new HttpError(HttpStatusCode.NotFound, $"Route for broadcast/{request.Id}/{request.Junction} was not found");
                }
            });

        public object Delete(BroadcastJunction request) =>
            Execute.Run( ssn =>
            {
                switch(request.Junction.ToLower().TrimAndPruneSpaces())
                {
                    case "scope":
                        return RemoveJunction<Broadcast, DocEntityBroadcast, DocEntityScope, Scope, ScopeSearch>((int)request.Id, DocConstantModelName.SCOPE, "Scopes", request);
                    default:
                        throw new HttpError(HttpStatusCode.NotFound, $"Route for broadcast/{request.Id}/{request.Junction} was not found");
                }
            });
        private Broadcast GetBroadcast(Broadcast request)
        {
            var id = request?.Id;
            Broadcast ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetVisibleFields<Broadcast>(currentUser, "Broadcast", request.VisibleFields);

            DocEntityBroadcast entity = null;
            if(id.HasValue)
            {
                entity = DocEntityBroadcast.GetBroadcast(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No Broadcast found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }
    }
}
