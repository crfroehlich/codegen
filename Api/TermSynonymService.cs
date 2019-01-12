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
    public partial class TermSynonymService : DocServiceBase
    {
        public const string CACHE_KEY_PREFIX = DocEntityTermSynonym.CACHE_KEY_PREFIX;
        private object _GetIdCache(TermSynonym request)
        {
            object ret = null;

            if (true != request.IgnoreCache)
            {
                var key = currentUser.GetApiCacheKey(DocConstantModelName.TERMSYNONYM);
                var cacheKey = $"TermSynonym_{key}_{request.Id}_{UrnId.Create<TermSynonym>(request.GetMD5Hash())}";
                ret = Request.ToOptimizedResultUsingCache(Cache, cacheKey, new TimeSpan(0, DocResources.Settings.SessionTimeout, 0), () =>
                {
                    object cachedRet = null;
                    cachedRet = GetTermSynonym(request);
                    return cachedRet;
                });
            }
            ret = ret ?? GetTermSynonym(request);
            return ret;
        }

        private object _GetSearchCache(TermSynonymSearch request, DocRequestCancellation requestCancel)
        {
            object tryRet = null;
            var ret = new List<TermSynonym>();

            //Keys need to be customized to factor in permissions/scoping. Often, including the current user's Role Id is sufficient in the key
            var key = currentUser.GetApiCacheKey(DocConstantModelName.TERMSYNONYM);
            var cacheKey = $"{CACHE_KEY_PREFIX}_{key}_{UrnId.Create<TermSynonymSearch>(request.GetMD5Hash())}";
            tryRet = Request.ToOptimizedResultUsingCache(Cache, cacheKey, new TimeSpan(0, DocResources.Settings.SessionTimeout, 0), () =>
            {
                _ExecSearch(request, (entities) => entities.ConvertFromEntityList<DocEntityTermSynonym,TermSynonym>(ret, Execute, requestCancel));
                return ret;
            });

            if(tryRet == null)
            {
                ret = new List<TermSynonym>();
                _ExecSearch(request, (entities) => entities.ConvertFromEntityList<DocEntityTermSynonym,TermSynonym>(ret, Execute, requestCancel));
                return ret;
            }
            else
            {
                return tryRet;
            }
        }
        private void _ExecSearch(TermSynonymSearch request, Action<IQueryable<DocEntityTermSynonym>> callBack)
        {
            request = InitSearch(request);
            
            DocPermissionFactory.SetVisibleFields<TermSynonym>(currentUser, "TermSynonym", request.VisibleFields);

            var entities = Execute.SelectAll<DocEntityTermSynonym>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new TermSynonymFullTextSearch(request);
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

                if(request.Approved.HasValue)
                    entities = entities.Where(en => request.Approved.Value == en.Approved);
                        if(true == request.BindingsIds?.Any())
                        {
                            entities = entities.Where(en => en.Bindings.Any(r => r.Id.In(request.BindingsIds)));
                        }
                if(!DocTools.IsNullOrEmpty(request.Master) && !DocTools.IsNullOrEmpty(request.Master.Id))
                {
                    entities = entities.Where(en => en.Master.Id == request.Master.Id );
                }
                if(true == request.MasterIds?.Any())
                {
                    entities = entities.Where(en => en.Master.Id.In(request.MasterIds));
                }
                if(request.Preferred.HasValue)
                    entities = entities.Where(en => request.Preferred.Value == en.Preferred);
                if(!DocTools.IsNullOrEmpty(request.Scope) && !DocTools.IsNullOrEmpty(request.Scope.Id))
                {
                    entities = entities.Where(en => en.Scope.Id == request.Scope.Id );
                }
                if(true == request.ScopeIds?.Any())
                {
                    entities = entities.Where(en => en.Scope.Id.In(request.ScopeIds));
                }
                if(!DocTools.IsNullOrEmpty(request.Synonym))
                    entities = entities.Where(en => en.Synonym.Contains(request.Synonym));

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
        
        public object Post(TermSynonymSearch request)
        {
            object tryRet = null;
            Execute.Run(s =>
            {
                using (var cancellableRequest = base.Request.CreateCancellableRequest())
                {
                    var requestCancel = new DocRequestCancellation(HttpContext.Current.Response, cancellableRequest);
                    try 
                    {
                        var ret = new List<TermSynonym>();
                        var settings = DocResources.Settings;
                        if(true != request.IgnoreCache && settings.Cache.CacheWebServices && true != settings.Cache.ExcludedServicesFromCache?.Any(webservice => webservice.ToLower().Trim() == "termsynonym")) 
                        {
                            tryRet = _GetSearchCache(request, requestCancel);
                        }
                        if (tryRet == null)
                        {
                            _ExecSearch(request, (entities) => entities.ConvertFromEntityList<DocEntityTermSynonym,TermSynonym>(ret, Execute, requestCancel));
                            tryRet = ret;
                        }
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

        public object Get(TermSynonymSearch request)
        {
            object tryRet = null;
            Execute.Run(s =>
            {
                using (var cancellableRequest = base.Request.CreateCancellableRequest())
                {
                    var requestCancel = new DocRequestCancellation(HttpContext.Current.Response, cancellableRequest);
                    try 
                    {
                        var ret = new List<TermSynonym>();
                        var settings = DocResources.Settings;
                        if(true != request.IgnoreCache && settings.Cache.CacheWebServices && true != settings.Cache.ExcludedServicesFromCache?.Any(webservice => webservice.ToLower().Trim() == "termsynonym")) 
                        {
                            tryRet = _GetSearchCache(request, requestCancel);
                        }
                        if (tryRet == null)
                        {
                            _ExecSearch(request, (entities) => entities.ConvertFromEntityList<DocEntityTermSynonym,TermSynonym>(ret, Execute, requestCancel));
                            tryRet = ret;
                        }
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

        public object Post(TermSynonymVersion request) 
        {
            return Get(request);
        }

        public object Get(TermSynonymVersion request) 
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

        public object Get(TermSynonym request)
        {
            object ret = null;
            
            if(!(request.Id > 0))
                throw new HttpError(HttpStatusCode.NotFound, "Valid Id required.");

            Execute.Run(s =>
            {
                DocPermissionFactory.SetVisibleFields<TermSynonym>(currentUser, "TermSynonym", request.VisibleFields);
                var settings = DocResources.Settings;
                if(true != request.IgnoreCache && settings.Cache.CacheWebServices && true != settings.Cache.ExcludedServicesFromCache?.Any(webservice => webservice.ToLower().Trim() == "termsynonym")) 
                {
                    ret = _GetIdCache(request);
                }
                else 
                {
                    ret = GetTermSynonym(request);
                }
            });
            return ret;
        }

        private TermSynonym _AssignValues(TermSynonym dtoSource, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (dtoSource == null || dtoSource.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "TermSynonym"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            dtoSource.VisibleFields = dtoSource.VisibleFields ?? new List<string>();

            TermSynonym ret = null;
            dtoSource = _InitAssignValues(dtoSource, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && dtoSource.Id > 0) return dtoSource;
            
            //First, assign all the variables, do database lookups and conversions
            var pApproved = dtoSource.Approved;
            var pBindings = dtoSource.Bindings?.ToList();
            var pMaster = (dtoSource.Master?.Id > 0) ? DocEntityTermMaster.GetTermMaster(dtoSource.Master.Id) : null;
            var pPreferred = dtoSource.Preferred;
            var pScope = (dtoSource.Scope?.Id > 0) ? DocEntityScope.GetScope(dtoSource.Scope.Id) : null;
            var pSynonym = dtoSource.Synonym;

            DocEntityTermSynonym entity = null;
            if(permission == DocConstantPermission.ADD)
            {
                var now = DateTime.UtcNow;
                entity = new DocEntityTermSynonym(session)
                {
                    Created = now,
                    Updated = now
                };
            }
            else
            {
                entity = DocEntityTermSynonym.GetTermSynonym(dtoSource.Id);
                if(null == entity)
                    throw new HttpError(HttpStatusCode.NotFound, $"No record");
            }

            if (DocPermissionFactory.IsRequestedHasPermission<bool>(currentUser, dtoSource, pApproved, permission, DocConstantModelName.TERMSYNONYM, nameof(dtoSource.Approved)))
            {
                if(DocPermissionFactory.IsRequested(dtoSource, pApproved, entity.Approved, nameof(dtoSource.Approved)))
                    entity.Approved = pApproved;
                if(DocPermissionFactory.IsRequested<bool>(dtoSource, pApproved, nameof(dtoSource.Approved)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.Approved), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.Approved));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityTermMaster>(currentUser, dtoSource, pMaster, permission, DocConstantModelName.TERMSYNONYM, nameof(dtoSource.Master)))
            {
                if(DocPermissionFactory.IsRequested(dtoSource, pMaster, entity.Master, nameof(dtoSource.Master)))
                    entity.Master = pMaster;
                if(DocPermissionFactory.IsRequested<DocEntityTermMaster>(dtoSource, pMaster, nameof(dtoSource.Master)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.Master), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.Master));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<bool>(currentUser, dtoSource, pPreferred, permission, DocConstantModelName.TERMSYNONYM, nameof(dtoSource.Preferred)))
            {
                if(DocPermissionFactory.IsRequested(dtoSource, pPreferred, entity.Preferred, nameof(dtoSource.Preferred)))
                    entity.Preferred = pPreferred;
                if(DocPermissionFactory.IsRequested<bool>(dtoSource, pPreferred, nameof(dtoSource.Preferred)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.Preferred), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.Preferred));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityScope>(currentUser, dtoSource, pScope, permission, DocConstantModelName.TERMSYNONYM, nameof(dtoSource.Scope)))
            {
                if(DocPermissionFactory.IsRequested(dtoSource, pScope, entity.Scope, nameof(dtoSource.Scope)))
                    entity.Scope = pScope;
                if(DocPermissionFactory.IsRequested<DocEntityScope>(dtoSource, pScope, nameof(dtoSource.Scope)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.Scope), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.Scope));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, dtoSource, pSynonym, permission, DocConstantModelName.TERMSYNONYM, nameof(dtoSource.Synonym)))
            {
                if(DocPermissionFactory.IsRequested(dtoSource, pSynonym, entity.Synonym, nameof(dtoSource.Synonym)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(dtoSource.Synonym)} cannot be modified once set.");
                    entity.Synonym = pSynonym;
                if(DocPermissionFactory.IsRequested<string>(dtoSource, pSynonym, nameof(dtoSource.Synonym)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.Synonym), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.Synonym));
                }
            }
            
            if (dtoSource.Locked) entity.Locked = dtoSource.Locked;

            entity.SaveChanges(permission);
            
            if (DocPermissionFactory.IsRequestedHasPermission<List<Reference>>(currentUser, dtoSource, pBindings, permission, DocConstantModelName.TERMSYNONYM, nameof(dtoSource.Bindings)))
            {
                if (true == pBindings?.Any() )
                {
                    var requestedBindings = pBindings.Select(p => p.Id).Distinct().ToList();
                    var existsBindings = Execute.SelectAll<DocEntityLookupTableBinding>().Where(e => e.Id.In(requestedBindings)).Select( e => e.Id ).ToList();
                    if (existsBindings.Count != requestedBindings.Count)
                    {
                        var nonExists = requestedBindings.Where(id => existsBindings.All(eId => eId != id));
                        throw new HttpError(HttpStatusCode.NotFound, $"Cannot patch collection Bindings with objects that do not exist. No matching Bindings(s) could be found for Ids: {nonExists.ToDelimitedString()}.");
                    }
                    var toAdd = requestedBindings.Where(id => entity.Bindings.All(e => e.Id != id)).ToList(); 
                    toAdd?.ForEach(id =>
                    {
                        var target = DocEntityLookupTableBinding.GetLookupTableBinding(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD, targetEntity: target, targetName: nameof(TermSynonym), columnName: nameof(dtoSource.Bindings)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to add {nameof(dtoSource.Bindings)} to {nameof(TermSynonym)}");
                        entity.Bindings.Add(target);
                    });
                    var toRemove = entity.Bindings.Where(e => requestedBindings.All(id => e.Id != id)).Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityLookupTableBinding.GetLookupTableBinding(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(TermSynonym), columnName: nameof(dtoSource.Bindings)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(dtoSource.Bindings)} from {nameof(TermSynonym)}");
                        entity.Bindings.Remove(target);
                    });
                }
                else
                {
                    var toRemove = entity.Bindings.Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityLookupTableBinding.GetLookupTableBinding(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(TermSynonym), columnName: nameof(dtoSource.Bindings)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(dtoSource.Bindings)} from {nameof(TermSynonym)}");
                        entity.Bindings.Remove(target);
                    });
                }
                if(DocPermissionFactory.IsRequested<List<Reference>>(dtoSource, pBindings, nameof(dtoSource.Bindings)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.Bindings), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.Bindings));
                }
            }
            DocPermissionFactory.SetVisibleFields<TermSynonym>(currentUser, nameof(TermSynonym), dtoSource.VisibleFields);
            ret = entity.ToDto();

            return ret;
        }
        public TermSynonym Post(TermSynonym dtoSource)
        {
            if(dtoSource == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            dtoSource.VisibleFields = dtoSource.VisibleFields ?? new List<string>();

            TermSynonym ret = null;

            Execute.Run(ssn =>
            {
                if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "TermSynonym")) 
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                ret = _AssignValues(dtoSource, DocConstantPermission.ADD, ssn);
            });

            return ret;
        }
   
        public List<TermSynonym> Post(TermSynonymBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<TermSynonym>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Post(dto) as TermSynonym;
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

        public TermSynonym Post(TermSynonymCopy request)
        {
            TermSynonym ret = null;
            Execute.Run(ssn =>
            {
                var entity = DocEntityTermSynonym.GetTermSynonym(request?.Id);
                if(null == entity) throw new HttpError(HttpStatusCode.NoContent, "The COPY request did not succeed.");
                if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");
                
                    var pApproved = entity.Approved;
                    var pBindings = entity.Bindings.ToList();
                    var pMaster = entity.Master;
                    var pPreferred = entity.Preferred;
                    var pScope = entity.Scope;
                    var pSynonym = entity.Synonym;
                    if(!DocTools.IsNullOrEmpty(pSynonym))
                        pSynonym += " (Copy)";
                var copy = new DocEntityTermSynonym(ssn)
                {
                    Hash = Guid.NewGuid()
                                , Approved = pApproved
                                , Master = pMaster
                                , Preferred = pPreferred
                                , Scope = pScope
                                , Synonym = pSynonym
                };
                            foreach(var item in pBindings)
                            {
                                entity.Bindings.Add(item);
                            }

                copy.SaveChanges(DocConstantPermission.ADD);
                ret = copy.ToDto();
            });
            return ret;
        }


        public List<TermSynonym> Put(TermSynonymBatch request)
        {
            return Patch(request);
        }

        public TermSynonym Put(TermSynonym dtoSource)
        {
            return Patch(dtoSource);
        }

        public List<TermSynonym> Patch(TermSynonymBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<TermSynonym>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Patch(dto) as TermSynonym;
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

        public TermSynonym Patch(TermSynonym dtoSource)
        {
            if(true != (dtoSource?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the TermSynonym to patch.");
            
            dtoSource.VisibleFields = dtoSource.VisibleFields ?? new List<string>();
            
            TermSynonym ret = null;
            Execute.Run(ssn =>
            {
                ret = _AssignValues(dtoSource, DocConstantPermission.EDIT, ssn);
            });
            return ret;
        }

        public void Delete(TermSynonymBatch request)
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

        public void Delete(TermSynonym request)
        {
            Execute.Run(ssn =>
            {
                var en = DocEntityTermSynonym.GetTermSynonym(request?.Id);

                if(null == en) throw new HttpError(HttpStatusCode.NotFound, $"No TermSynonym could be found for Id {request?.Id}.");
                if(en.IsRemoved) return;
                
                if(!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.DELETE))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have DELETE permission for this route.");
                
                en.Remove();
            });
        }

        public void Delete(TermSynonymSearch request)
        {
            var matches = Get(request) as List<TermSynonym>;
            if(true != matches?.Any()) throw new HttpError(HttpStatusCode.NotFound, "No matches for request");

            Execute.Run(ssn =>
            {
                matches.ForEach(match =>
                {
                    Delete(match);
                });
            });
        }
        public object Get(TermSynonymJunction request)
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
                case "lookuptablebinding":
                    ret = _GetTermSynonymLookupTableBinding(request, skip, take);
                    break;
                }
            });
            return ret;
        }
        
        public object Get(TermSynonymJunctionVersion request)
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
                case "lookuptablebinding":
                    ret = GetTermSynonymLookupTableBindingVersion(request);
                    break;
                }
            });
            return ret;
        }
        

        private object _GetTermSynonymLookupTableBinding(TermSynonymJunction request, int skip, int take)
        {
             DocPermissionFactory.SetVisibleFields<LookupTableBinding>(currentUser, "LookupTableBinding", request.VisibleFields);
             var en = DocEntityTermSynonym.GetTermSynonym(request.Id);
             if (!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.VIEW, targetName: DocConstantModelName.TERMSYNONYM, columnName: "Bindings", targetEntity: null))
                 throw new HttpError(HttpStatusCode.Forbidden, "You do not have View permission to relationships between TermSynonym and LookupTableBinding");
             return en?.Bindings.Take(take).Skip(skip).ConvertFromEntityList<DocEntityLookupTableBinding,LookupTableBinding>(new List<LookupTableBinding>());
        }

        private List<Version> GetTermSynonymLookupTableBindingVersion(TermSynonymJunctionVersion request)
        { 
            if(!(request.Id > 0))
                throw new HttpError(HttpStatusCode.NotFound, "Valid Id required.");
            var ret = new List<Version>();
             Execute.Run((ssn) =>
             {
                var en = DocEntityTermSynonym.GetTermSynonym(request.Id);
                ret = en?.Bindings.Select(e => new Version(e.Id, e.VersionNo)).ToList();
             });
            return ret;
        }
        
        public object Post(TermSynonymJunction request)
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
                case "lookuptablebinding":
                    ret = _PostTermSynonymLookupTableBinding(request);
                    break;
                }
            });
            return ret;
        }


        private object _PostTermSynonymLookupTableBinding(TermSynonymJunction request)
        {
            var entity = DocEntityTermSynonym.GetTermSynonym(request.Id);

            if (null == entity) throw new HttpError(HttpStatusCode.NotFound, $"No TermSynonym found for Id {request.Id}");

            if (!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.EDIT))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have Edit permission to TermSynonym");

            foreach (var id in request.Ids)
            {
                var relationship = DocEntityLookupTableBinding.GetLookupTableBinding(id);
                if (!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD, targetEntity: relationship, targetName: DocConstantModelName.LOOKUPTABLEBINDING, columnName: "Bindings")) 
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have Add permission to the Bindings property.");
                if (null == relationship) throw new HttpError(HttpStatusCode.NotFound, $"Cannot post to collection of TermSynonym with objects that do not exist. No matching LookupTableBinding could be found for {id}.");
                entity.Bindings.Add(relationship);
            }
            entity.SaveChanges();
            return entity.ToDto();
        }

        public object Delete(TermSynonymJunction request)
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
                case "lookuptablebinding":
                    ret = _DeleteTermSynonymLookupTableBinding(request);
                    break;
                }
            });
            return ret;
        }


        private object _DeleteTermSynonymLookupTableBinding(TermSynonymJunction request)
        {
            var entity = DocEntityTermSynonym.GetTermSynonym(request.Id);

            if (null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No TermSynonym found for Id {request.Id}");
            if (!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.EDIT))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have Edit permission to TermSynonym");
            foreach (var id in request.Ids)
            {
                var relationship = DocEntityLookupTableBinding.GetLookupTableBinding(id);
                if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: relationship, targetName: DocConstantModelName.LOOKUPTABLEBINDING, columnName: "Bindings"))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have Edit permission to relationships between TermSynonym and LookupTableBinding");
                if(null != relationship && false == relationship.IsRemoved) entity.Bindings.Remove(relationship);
            }
            entity.SaveChanges();
            return entity.ToDto();
        }

        private TermSynonym GetTermSynonym(TermSynonym request)
        {
            var id = request?.Id;
            TermSynonym ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetVisibleFields<TermSynonym>(currentUser, "TermSynonym", request.VisibleFields);

            DocEntityTermSynonym entity = null;
            if(id.HasValue)
            {
                entity = DocEntityTermSynonym.GetTermSynonym(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No TermSynonym found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }

        public List<int> Any(TermSynonymIds request)
        {
            List<int> ret = null;
            if (currentUser.IsSuperAdmin)
            {
                Execute.Run(s => { ret = Execute.SelectAll<DocEntityTermSynonym>().Select(d => d.Id).ToList(); });
            }
            else
            {
                throw new HttpError(HttpStatusCode.Forbidden);
            }
            return ret;
        }
    }
}