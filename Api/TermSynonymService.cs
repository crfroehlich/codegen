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
    public partial class TermSynonymService : DocServiceBase
    {
        private IQueryable<DocEntityTermSynonym> _ExecSearch(TermSynonymSearch request, DocQuery query)
        {
            request = InitSearch<TermSynonym, TermSynonymSearch>(request);
            IQueryable<DocEntityTermSynonym> entities = null;
            query.Run( session => 
            {
                entities = query.SelectAll<DocEntityTermSynonym>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new TermSynonymFullTextSearch(request);
                    entities = GetFullTextSearch<DocEntityTermSynonym,TermSynonymFullTextSearch>(fts, entities);
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
                if(true == request.Archived?.Any() && currentUser.HasProperty(DocConstantModelName.TERMSYNONYM, nameof(Reference.Archived), DocConstantPermission.VIEW))
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

                if(true == request.Approved?.Any())
                {
                    if(request.Approved.Any(v => v == null)) entities = entities.Where(en => en.Approved.In(request.Approved) || en.Approved == null);
                    else entities = entities.Where(en => en.Approved.In(request.Approved));
                }
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
                if(true == request.Preferred?.Any())
                {
                    if(request.Preferred.Any(v => v == null)) entities = entities.Where(en => en.Preferred.In(request.Preferred) || en.Preferred == null);
                    else entities = entities.Where(en => en.Preferred.In(request.Preferred));
                }
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

                entities = ApplyFilters<DocEntityTermSynonym,TermSynonymSearch>(request, entities);

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

        public object Post(TermSynonymSearch request) => Get(request);

        public object Get(TermSynonymSearch request) => GetSearchResultWithCache<TermSynonym,DocEntityTermSynonym,TermSynonymSearch>(DocConstantModelName.TERMSYNONYM, request, _ExecSearch);

        public object Get(TermSynonym request) => GetEntityWithCache<TermSynonym>(DocConstantModelName.TERMSYNONYM, request, GetTermSynonym);

        private TermSynonym _AssignValues(TermSynonym request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "TermSynonym"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            TermSynonym ret = null;
            request = _InitAssignValues<TermSynonym>(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            var cacheKey = GetApiCacheKey<TermSynonym>(DocConstantModelName.TERMSYNONYM, nameof(TermSynonym), request);
            
            //First, assign all the variables, do database lookups and conversions
            var pApproved = request.Approved;
            var pBindings = request.Bindings?.ToList();
            var pMaster = (request.Master?.Id > 0) ? DocEntityTermMaster.GetTermMaster(request.Master.Id) : null;
            var pPreferred = request.Preferred;
            var pScope = (request.Scope?.Id > 0) ? DocEntityScope.GetScope(request.Scope.Id) : null;
            var pSynonym = request.Synonym;

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
                entity = DocEntityTermSynonym.GetTermSynonym(request.Id);
                if(null == entity)
                    throw new HttpError(HttpStatusCode.NotFound, $"No record");
            }

            //Special case for Archived
            var pArchived = true == request.Archived;
            if (DocPermissionFactory.IsRequestedHasPermission<bool>(currentUser, request, pArchived, permission, DocConstantModelName.TERMSYNONYM, nameof(request.Archived)))
            {
                if(DocPermissionFactory.IsRequested(request, pArchived, entity.Archived, nameof(request.Archived)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.TERMSYNONYM, nameof(request.Archived)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Archived)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pArchived) && DocResources.Metadata.IsRequired(DocConstantModelName.TERMSYNONYM, nameof(request.Archived))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Archived)} requires a value.");
                    entity.Archived = pArchived;
                if(DocPermissionFactory.IsRequested<bool>(request, pArchived, nameof(request.Archived)) && !request.VisibleFields.Matches(nameof(request.Archived), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Archived));
                }
            }

            if (DocPermissionFactory.IsRequestedHasPermission<bool>(currentUser, request, pApproved, permission, DocConstantModelName.TERMSYNONYM, nameof(request.Approved)))
            {
                if(DocPermissionFactory.IsRequested(request, pApproved, entity.Approved, nameof(request.Approved)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.TERMSYNONYM, nameof(request.Approved)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Approved)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pApproved) && DocResources.Metadata.IsRequired(DocConstantModelName.TERMSYNONYM, nameof(request.Approved))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Approved)} requires a value.");
                    entity.Approved = pApproved;
                if(DocPermissionFactory.IsRequested<bool>(request, pApproved, nameof(request.Approved)) && !request.VisibleFields.Matches(nameof(request.Approved), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Approved));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityTermMaster>(currentUser, request, pMaster, permission, DocConstantModelName.TERMSYNONYM, nameof(request.Master)))
            {
                if(DocPermissionFactory.IsRequested(request, pMaster, entity.Master, nameof(request.Master)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.TERMSYNONYM, nameof(request.Master)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Master)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pMaster) && DocResources.Metadata.IsRequired(DocConstantModelName.TERMSYNONYM, nameof(request.Master))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Master)} requires a value.");
                    entity.Master = pMaster;
                if(DocPermissionFactory.IsRequested<DocEntityTermMaster>(request, pMaster, nameof(request.Master)) && !request.VisibleFields.Matches(nameof(request.Master), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Master));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<bool>(currentUser, request, pPreferred, permission, DocConstantModelName.TERMSYNONYM, nameof(request.Preferred)))
            {
                if(DocPermissionFactory.IsRequested(request, pPreferred, entity.Preferred, nameof(request.Preferred)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.TERMSYNONYM, nameof(request.Preferred)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Preferred)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pPreferred) && DocResources.Metadata.IsRequired(DocConstantModelName.TERMSYNONYM, nameof(request.Preferred))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Preferred)} requires a value.");
                    entity.Preferred = pPreferred;
                if(DocPermissionFactory.IsRequested<bool>(request, pPreferred, nameof(request.Preferred)) && !request.VisibleFields.Matches(nameof(request.Preferred), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Preferred));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityScope>(currentUser, request, pScope, permission, DocConstantModelName.TERMSYNONYM, nameof(request.Scope)))
            {
                if(DocPermissionFactory.IsRequested(request, pScope, entity.Scope, nameof(request.Scope)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.TERMSYNONYM, nameof(request.Scope)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Scope)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pScope) && DocResources.Metadata.IsRequired(DocConstantModelName.TERMSYNONYM, nameof(request.Scope))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Scope)} requires a value.");
                    entity.Scope = pScope;
                if(DocPermissionFactory.IsRequested<DocEntityScope>(request, pScope, nameof(request.Scope)) && !request.VisibleFields.Matches(nameof(request.Scope), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Scope));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pSynonym, permission, DocConstantModelName.TERMSYNONYM, nameof(request.Synonym)))
            {
                if(DocPermissionFactory.IsRequested(request, pSynonym, entity.Synonym, nameof(request.Synonym)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.TERMSYNONYM, nameof(request.Synonym)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Synonym)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pSynonym) && DocResources.Metadata.IsRequired(DocConstantModelName.TERMSYNONYM, nameof(request.Synonym))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Synonym)} requires a value.");
                    entity.Synonym = pSynonym;
                if(DocPermissionFactory.IsRequested<string>(request, pSynonym, nameof(request.Synonym)) && !request.VisibleFields.Matches(nameof(request.Synonym), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Synonym));
                }
            }

            if (request.Locked) entity.Locked = request.Locked;

            entity.SaveChanges(permission);

            if (DocPermissionFactory.IsRequestedHasPermission<List<Reference>>(currentUser, request, pBindings, permission, DocConstantModelName.TERMSYNONYM, nameof(request.Bindings)))
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
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD, targetEntity: target, targetName: nameof(TermSynonym), columnName: nameof(request.Bindings)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to add {nameof(request.Bindings)} to {nameof(TermSynonym)}");
                        entity.Bindings.Add(target);
                    });
                    var toRemove = entity.Bindings.Where(e => requestedBindings.All(id => e.Id != id)).Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityLookupTableBinding.GetLookupTableBinding(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(TermSynonym), columnName: nameof(request.Bindings)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Bindings)} from {nameof(TermSynonym)}");
                        entity.Bindings.Remove(target);
                    });
                }
                else
                {
                    var toRemove = entity.Bindings.Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityLookupTableBinding.GetLookupTableBinding(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(TermSynonym), columnName: nameof(request.Bindings)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Bindings)} from {nameof(TermSynonym)}");
                        entity.Bindings.Remove(target);
                    });
                }
                if(DocPermissionFactory.IsRequested<List<Reference>>(request, pBindings, nameof(request.Bindings)) && !request.VisibleFields.Matches(nameof(request.Bindings), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Bindings));
                }
            }
            DocPermissionFactory.SetVisibleFields<TermSynonym>(currentUser, nameof(TermSynonym), request.VisibleFields);
            ret = entity.ToDto();

            var cacheExpires = DocResources.Metadata.GetCacheExpiration(DocConstantModelName.TERMSYNONYM);
            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.TERMSYNONYM, cacheExpires);

            return ret;
        }
        public TermSynonym Post(TermSynonym request)
        {
            if(request == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            TermSynonym ret = null;

            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "TermSynonym")) 
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                    ret = _AssignValues(request, DocConstantPermission.ADD, ssn);
                });
            }
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
            using(Execute)
            {
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
                    #region Custom Before copyTermSynonym
                    #endregion Custom Before copyTermSynonym
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

                    #region Custom After copyTermSynonym
                    #endregion Custom After copyTermSynonym
                    copy.SaveChanges(DocConstantPermission.ADD);
                    ret = copy.ToDto();
                });
            }
            return ret;
        }

        public List<TermSynonym> Put(TermSynonymBatch request)
        {
            return Patch(request);
        }

        public TermSynonym Put(TermSynonym request)
        {
            return Patch(request);
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

        public TermSynonym Patch(TermSynonym request)
        {
            if(true != (request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the TermSynonym to patch.");
            
            request.VisibleFields = request.VisibleFields ?? new List<string>();
            
            TermSynonym ret = null;
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    ret = _AssignValues(request, DocConstantPermission.EDIT, ssn);
                });
            }
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
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    if(!(request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, $"No Id provided for delete.");

                    var en = DocEntityTermSynonym.GetTermSynonym(request?.Id);
                    if(null == en) throw new HttpError(HttpStatusCode.NotFound, $"No TermSynonym could be found for Id {request?.Id}.");
                    if(en.IsRemoved) return;
                
                    if(!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.DELETE))
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have DELETE permission for this route.");
                
                    en.Remove();

                    DocCacheClient.RemoveSearch(DocConstantModelName.TERMSYNONYM);
                    DocCacheClient.RemoveById(request.Id);
                });
            }
        }

        public void Delete(TermSynonymSearch request)
        {
            var matches = Get(request) as List<TermSynonym>;
            if(true != matches?.Any()) throw new HttpError(HttpStatusCode.NotFound, "No matches for request");
            matches.ForEach(match =>
            {
                Delete(match);
            });
        }
        public object Get(TermSynonymJunction request)
        {
            switch(request.Junction.ToLower().TrimAndPruneSpaces())
            {
                    case "lookuptablebinding":
                        return GetJunctionSearchResult<TermSynonym, DocEntityTermSynonym, DocEntityLookupTableBinding, LookupTableBinding, LookupTableBindingSearch>((int)request.Id, DocConstantModelName.LOOKUPTABLEBINDING, "Bindings", request, (ss) => HostContext.ResolveService<LookupTableBindingService>(Request)?.Get(ss));
                    case "tag":
                        return GetJunctionSearchResult<TermSynonym, DocEntityTermSynonym, DocEntityTag, Tag, TagSearch>((int)request.Id, DocConstantModelName.TAG, "Tags", request, (ss) => HostContext.ResolveService<TagService>(Request)?.Get(ss));
                default:
                    throw new HttpError(HttpStatusCode.NotFound, $"Route for termsynonym/{request.Id}/{request.Junction} was not found");
            }
        }
        public object Post(TermSynonymJunction request)
        {
            switch(request.Junction.ToLower().TrimAndPruneSpaces())
            {
                    case "lookuptablebinding":
                        return AddJunction<TermSynonym, DocEntityTermSynonym, DocEntityLookupTableBinding, LookupTableBinding, LookupTableBindingSearch>((int)request.Id, DocConstantModelName.LOOKUPTABLEBINDING, "Bindings", request);
                    case "tag":
                        return AddJunction<TermSynonym, DocEntityTermSynonym, DocEntityTag, Tag, TagSearch>((int)request.Id, DocConstantModelName.TAG, "Tags", request);
                default:
                    throw new HttpError(HttpStatusCode.NotFound, $"Route for termsynonym/{request.Id}/{request.Junction} was not found");
            }
        }

        public object Delete(TermSynonymJunction request)
        {    
            switch(request.Junction.ToLower().TrimAndPruneSpaces())
            {
                    case "lookuptablebinding":
                        return RemoveJunction<TermSynonym, DocEntityTermSynonym, DocEntityLookupTableBinding, LookupTableBinding, LookupTableBindingSearch>((int)request.Id, DocConstantModelName.LOOKUPTABLEBINDING, "Bindings", request);
                    case "tag":
                        return RemoveJunction<TermSynonym, DocEntityTermSynonym, DocEntityTag, Tag, TagSearch>((int)request.Id, DocConstantModelName.TAG, "Tags", request);
                default:
                    throw new HttpError(HttpStatusCode.NotFound, $"Route for termsynonym/{request.Id}/{request.Junction} was not found");
            }
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
    }
}
