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
    public partial class LookupTableBindingService : DocServiceBase
    {
        private IQueryable<DocEntityLookupTableBinding> _ExecSearch(LookupTableBindingSearch request, DocQuery query)
        {
            request = InitSearch<LookupTableBinding, LookupTableBindingSearch>(request);
            IQueryable<DocEntityLookupTableBinding> entities = null;
            query.Run( session => 
            {
                entities = query.SelectAll<DocEntityLookupTableBinding>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new LookupTableBindingFullTextSearch(request);
                    entities = GetFullTextSearch<DocEntityLookupTableBinding,LookupTableBindingFullTextSearch>(fts, entities);
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
                if(true == request.Archived?.Any() && currentUser.HasProperty(DocConstantModelName.LOOKUPTABLEBINDING, nameof(Reference.Archived), DocConstantPermission.VIEW))
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
                if(!DocTools.IsNullOrEmpty(request.BoundName))
                    entities = entities.Where(en => en.BoundName.Contains(request.BoundName));
                if(!DocTools.IsNullOrEmpty(request.LookupTable) && !DocTools.IsNullOrEmpty(request.LookupTable.Id))
                {
                    entities = entities.Where(en => en.LookupTable.Id == request.LookupTable.Id );
                }
                if(true == request.LookupTableIds?.Any())
                {
                    entities = entities.Where(en => en.LookupTable.Id.In(request.LookupTableIds));
                }
                else if(!DocTools.IsNullOrEmpty(request.LookupTable) && !DocTools.IsNullOrEmpty(request.LookupTable.Name))
                {
                    entities = entities.Where(en => en.LookupTable.Name == request.LookupTable.Name );
                }
                if(true == request.LookupTableNames?.Any())
                {
                    entities = entities.Where(en => en.LookupTable.Name.In(request.LookupTableNames));
                }
                if(!DocTools.IsNullOrEmpty(request.Scope) && !DocTools.IsNullOrEmpty(request.Scope.Id))
                {
                    entities = entities.Where(en => en.Scope.Id == request.Scope.Id );
                }
                if(true == request.ScopeIds?.Any())
                {
                    entities = entities.Where(en => en.Scope.Id.In(request.ScopeIds));
                }
                if(true == request.SynonymsIds?.Any())
                {
                    entities = entities.Where(en => en.Synonyms.Any(r => r.Id.In(request.SynonymsIds)));
                }
                if(true == request.WorkflowsIds?.Any())
                {
                    entities = entities.Where(en => en.Workflows.Any(r => r.Id.In(request.WorkflowsIds)));
                }

                entities = ApplyFilters<DocEntityLookupTableBinding,LookupTableBindingSearch>(request, entities);

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

        public object Post(LookupTableBindingSearch request) => Get(request);

        public object Get(LookupTableBindingSearch request) => GetSearchResultWithCache<LookupTableBinding,DocEntityLookupTableBinding,LookupTableBindingSearch>(DocConstantModelName.LOOKUPTABLEBINDING, request, _ExecSearch);

        public object Get(LookupTableBinding request) => GetEntityWithCache<LookupTableBinding>(DocConstantModelName.LOOKUPTABLEBINDING, request, GetLookupTableBinding);

        private LookupTableBinding _AssignValues(LookupTableBinding request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "LookupTableBinding"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            LookupTableBinding ret = null;
            request = _InitAssignValues<LookupTableBinding>(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            var cacheKey = GetApiCacheKey<LookupTableBinding>(DocConstantModelName.LOOKUPTABLEBINDING, nameof(LookupTableBinding), request);
            
            //First, assign all the variables, do database lookups and conversions
            var pBinding = request.Binding;
            var pBoundName = request.BoundName;
            DocEntityLookupTable pLookupTable = GetLookup(DocConstantLookupTable.ATTRIBUTENAME, request.LookupTable?.Name, request.LookupTable?.Id);
            var pScope = (request.Scope?.Id > 0) ? DocEntityScope.Get(request.Scope.Id) : null;
            var pSynonyms = request.Synonyms?.ToList();
            var pWorkflows = request.Workflows?.ToList();

            DocEntityLookupTableBinding entity = null;
            if(permission == DocConstantPermission.ADD)
            {
                var now = DateTime.UtcNow;
                entity = new DocEntityLookupTableBinding(session)
                {
                    Created = now,
                    Updated = now
                };
            }
            else
            {
                entity = DocEntityLookupTableBinding.Get(request.Id);
                if(null == entity)
                    throw new HttpError(HttpStatusCode.NotFound, $"No record");
            }

            //Special case for Archived
            var pArchived = true == request.Archived;
            if (DocPermissionFactory.IsRequestedHasPermission<bool>(currentUser, request, pArchived, permission, DocConstantModelName.LOOKUPTABLEBINDING, nameof(request.Archived)))
            {
                if(DocPermissionFactory.IsRequested(request, pArchived, entity.Archived, nameof(request.Archived)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.LOOKUPTABLEBINDING, nameof(request.Archived)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Archived)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pArchived) && DocResources.Metadata.IsRequired(DocConstantModelName.LOOKUPTABLEBINDING, nameof(request.Archived))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Archived)} requires a value.");
                    entity.Archived = pArchived;
                if(DocPermissionFactory.IsRequested<bool>(request, pArchived, nameof(request.Archived)) && !request.VisibleFields.Matches(nameof(request.Archived), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Archived));
                }
            }

            if (DocPermissionFactory.IsRequestedHasPermission<Bindings>(currentUser, request, pBinding, permission, DocConstantModelName.LOOKUPTABLEBINDING, nameof(request.Binding)))
            {
                if(DocPermissionFactory.IsRequested(request, pBinding, entity.Binding, nameof(request.Binding)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.LOOKUPTABLEBINDING, nameof(request.Binding)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Binding)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pBinding) && DocResources.Metadata.IsRequired(DocConstantModelName.LOOKUPTABLEBINDING, nameof(request.Binding))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Binding)} requires a value.");
                    entity.Binding = DocSerialize<Bindings>.ToString(pBinding);
                if(DocPermissionFactory.IsRequested<Bindings>(request, pBinding, nameof(request.Binding)) && !request.VisibleFields.Matches(nameof(request.Binding), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Binding));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pBoundName, permission, DocConstantModelName.LOOKUPTABLEBINDING, nameof(request.BoundName)))
            {
                if(DocPermissionFactory.IsRequested(request, pBoundName, entity.BoundName, nameof(request.BoundName)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.LOOKUPTABLEBINDING, nameof(request.BoundName)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.BoundName)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pBoundName) && DocResources.Metadata.IsRequired(DocConstantModelName.LOOKUPTABLEBINDING, nameof(request.BoundName))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.BoundName)} requires a value.");
                    entity.BoundName = pBoundName;
                if(DocPermissionFactory.IsRequested<string>(request, pBoundName, nameof(request.BoundName)) && !request.VisibleFields.Matches(nameof(request.BoundName), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.BoundName));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityLookupTable>(currentUser, request, pLookupTable, permission, DocConstantModelName.LOOKUPTABLEBINDING, nameof(request.LookupTable)))
            {
                if(DocPermissionFactory.IsRequested(request, pLookupTable, entity.LookupTable, nameof(request.LookupTable)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.LOOKUPTABLEBINDING, nameof(request.LookupTable)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.LookupTable)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pLookupTable) && DocResources.Metadata.IsRequired(DocConstantModelName.LOOKUPTABLEBINDING, nameof(request.LookupTable))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.LookupTable)} requires a value.");
                    entity.LookupTable = pLookupTable;
                if(DocPermissionFactory.IsRequested<DocEntityLookupTable>(request, pLookupTable, nameof(request.LookupTable)) && !request.VisibleFields.Matches(nameof(request.LookupTable), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.LookupTable));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityScope>(currentUser, request, pScope, permission, DocConstantModelName.LOOKUPTABLEBINDING, nameof(request.Scope)))
            {
                if(DocPermissionFactory.IsRequested(request, pScope, entity.Scope, nameof(request.Scope)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.LOOKUPTABLEBINDING, nameof(request.Scope)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Scope)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pScope) && DocResources.Metadata.IsRequired(DocConstantModelName.LOOKUPTABLEBINDING, nameof(request.Scope))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Scope)} requires a value.");
                    entity.Scope = pScope;
                if(DocPermissionFactory.IsRequested<DocEntityScope>(request, pScope, nameof(request.Scope)) && !request.VisibleFields.Matches(nameof(request.Scope), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Scope));
                }
            }

            if (request.Locked) entity.Locked = request.Locked;

            entity.SaveChanges(permission);

            if (DocPermissionFactory.IsRequestedHasPermission<List<Reference>>(currentUser, request, pSynonyms, permission, DocConstantModelName.LOOKUPTABLEBINDING, nameof(request.Synonyms)))
            {
                if (true == pSynonyms?.Any() )
                {
                    var requestedSynonyms = pSynonyms.Select(p => p.Id).Distinct().ToList();
                    var existsSynonyms = Execute.SelectAll<DocEntityTermSynonym>().Where(e => e.Id.In(requestedSynonyms)).Select( e => e.Id ).ToList();
                    if (existsSynonyms.Count != requestedSynonyms.Count)
                    {
                        var nonExists = requestedSynonyms.Where(id => existsSynonyms.All(eId => eId != id));
                        throw new HttpError(HttpStatusCode.NotFound, $"Cannot patch collection Synonyms with objects that do not exist. No matching Synonyms(s) could be found for Ids: {nonExists.ToDelimitedString()}.");
                    }
                    var toAdd = requestedSynonyms.Where(id => entity.Synonyms.All(e => e.Id != id)).ToList(); 
                    toAdd?.ForEach(id =>
                    {
                        var target = DocEntityTermSynonym.Get(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD, targetEntity: target, targetName: nameof(LookupTableBinding), columnName: nameof(request.Synonyms)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to add {nameof(request.Synonyms)} to {nameof(LookupTableBinding)}");
                        entity.Synonyms.Add(target);
                    });
                    var toRemove = entity.Synonyms.Where(e => requestedSynonyms.All(id => e.Id != id)).Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityTermSynonym.Get(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(LookupTableBinding), columnName: nameof(request.Synonyms)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Synonyms)} from {nameof(LookupTableBinding)}");
                        entity.Synonyms.Remove(target);
                    });
                }
                else
                {
                    var toRemove = entity.Synonyms.Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityTermSynonym.Get(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(LookupTableBinding), columnName: nameof(request.Synonyms)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Synonyms)} from {nameof(LookupTableBinding)}");
                        entity.Synonyms.Remove(target);
                    });
                }
                if(DocPermissionFactory.IsRequested<List<Reference>>(request, pSynonyms, nameof(request.Synonyms)) && !request.VisibleFields.Matches(nameof(request.Synonyms), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Synonyms));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<List<Reference>>(currentUser, request, pWorkflows, permission, DocConstantModelName.LOOKUPTABLEBINDING, nameof(request.Workflows)))
            {
                if (true == pWorkflows?.Any() )
                {
                    var requestedWorkflows = pWorkflows.Select(p => p.Id).Distinct().ToList();
                    var existsWorkflows = Execute.SelectAll<DocEntityWorkflow>().Where(e => e.Id.In(requestedWorkflows)).Select( e => e.Id ).ToList();
                    if (existsWorkflows.Count != requestedWorkflows.Count)
                    {
                        var nonExists = requestedWorkflows.Where(id => existsWorkflows.All(eId => eId != id));
                        throw new HttpError(HttpStatusCode.NotFound, $"Cannot patch collection Workflows with objects that do not exist. No matching Workflows(s) could be found for Ids: {nonExists.ToDelimitedString()}.");
                    }
                    var toAdd = requestedWorkflows.Where(id => entity.Workflows.All(e => e.Id != id)).ToList(); 
                    toAdd?.ForEach(id =>
                    {
                        var target = DocEntityWorkflow.Get(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD, targetEntity: target, targetName: nameof(LookupTableBinding), columnName: nameof(request.Workflows)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to add {nameof(request.Workflows)} to {nameof(LookupTableBinding)}");
                        entity.Workflows.Add(target);
                    });
                    var toRemove = entity.Workflows.Where(e => requestedWorkflows.All(id => e.Id != id)).Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityWorkflow.Get(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(LookupTableBinding), columnName: nameof(request.Workflows)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Workflows)} from {nameof(LookupTableBinding)}");
                        entity.Workflows.Remove(target);
                    });
                }
                else
                {
                    var toRemove = entity.Workflows.Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityWorkflow.Get(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(LookupTableBinding), columnName: nameof(request.Workflows)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Workflows)} from {nameof(LookupTableBinding)}");
                        entity.Workflows.Remove(target);
                    });
                }
                if(DocPermissionFactory.IsRequested<List<Reference>>(request, pWorkflows, nameof(request.Workflows)) && !request.VisibleFields.Matches(nameof(request.Workflows), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Workflows));
                }
            }
            DocPermissionFactory.SetVisibleFields<LookupTableBinding>(currentUser, nameof(LookupTableBinding), request.VisibleFields);
            ret = entity.ToDto();

            var cacheExpires = DocResources.Metadata.GetCacheExpiration(DocConstantModelName.LOOKUPTABLEBINDING);
            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.LOOKUPTABLEBINDING, cacheExpires);

            return ret;
        }
        public LookupTableBinding Post(LookupTableBinding request)
        {
            if(request == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            LookupTableBinding ret = null;

            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "LookupTableBinding")) 
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                    ret = _AssignValues(request, DocConstantPermission.ADD, ssn);
                });
            }
            return ret;
        }
   
        public List<LookupTableBinding> Post(LookupTableBindingBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<LookupTableBinding>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Post(dto) as LookupTableBinding;
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

        public LookupTableBinding Post(LookupTableBindingCopy request)
        {
            LookupTableBinding ret = null;
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    var entity = DocEntityLookupTableBinding.Get(request?.Id);
                    if(null == entity) throw new HttpError(HttpStatusCode.NoContent, "The COPY request did not succeed.");
                    if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD))
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                    var pBinding = entity.Binding;
                    var pBoundName = entity.BoundName;
                    if(!DocTools.IsNullOrEmpty(pBoundName))
                        pBoundName += " (Copy)";
                    var pLookupTable = entity.LookupTable;
                    var pScope = entity.Scope;
                    var pSynonyms = entity.Synonyms.ToList();
                    var pWorkflows = entity.Workflows.ToList();
                    #region Custom Before copyLookupTableBinding
                    #endregion Custom Before copyLookupTableBinding
                    var copy = new DocEntityLookupTableBinding(ssn)
                    {
                        Hash = Guid.NewGuid()
                                , Binding = pBinding
                                , BoundName = pBoundName
                                , LookupTable = pLookupTable
                                , Scope = pScope
                    };
                            foreach(var item in pSynonyms)
                            {
                                entity.Synonyms.Add(item);
                            }

                            foreach(var item in pWorkflows)
                            {
                                entity.Workflows.Add(item);
                            }

                    #region Custom After copyLookupTableBinding
                    #endregion Custom After copyLookupTableBinding
                    copy.SaveChanges(DocConstantPermission.ADD);
                    ret = copy.ToDto();
                });
            }
            return ret;
        }

        public List<LookupTableBinding> Put(LookupTableBindingBatch request)
        {
            return Patch(request);
        }

        public LookupTableBinding Put(LookupTableBinding request)
        {
            return Patch(request);
        }
        public List<LookupTableBinding> Patch(LookupTableBindingBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<LookupTableBinding>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Patch(dto) as LookupTableBinding;
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

        public LookupTableBinding Patch(LookupTableBinding request)
        {
            if(true != (request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the LookupTableBinding to patch.");
            
            request.VisibleFields = request.VisibleFields ?? new List<string>();
            
            LookupTableBinding ret = null;
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    ret = _AssignValues(request, DocConstantPermission.EDIT, ssn);
                });
            }
            return ret;
        }
        public void Delete(LookupTableBindingBatch request)
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

        public void Delete(LookupTableBinding request)
        {
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    if(!(request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, $"No Id provided for delete.");

                    var en = DocEntityLookupTableBinding.Get(request?.Id);
                    if(null == en) throw new HttpError(HttpStatusCode.NotFound, $"No LookupTableBinding could be found for Id {request?.Id}.");
                    if(en.IsRemoved) return;
                
                    if(!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.DELETE))
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have DELETE permission for this route.");
                
                    en.Remove();

                    DocCacheClient.RemoveSearch(DocConstantModelName.LOOKUPTABLEBINDING);
                    DocCacheClient.RemoveById(request.Id);
                });
            }
        }

        public void Delete(LookupTableBindingSearch request)
        {
            var matches = Get(request) as List<LookupTableBinding>;
            if(true != matches?.Any()) throw new HttpError(HttpStatusCode.NotFound, "No matches for request");
            matches.ForEach(match =>
            {
                Delete(match);
            });
        }
        public object Get(LookupTableBindingJunction request)
        {
            switch(request.Junction.ToLower().TrimAndPruneSpaces())
            {
                    case "comment":
                        return GetJunctionSearchResult<LookupTableBinding, DocEntityLookupTableBinding, DocEntityComment, Comment, CommentSearch>((int)request.Id, DocConstantModelName.COMMENT, "Comments", request, (ss) => HostContext.ResolveService<CommentService>(Request)?.Get(ss));
                    case "favorite":
                        return GetJunctionSearchResult<LookupTableBinding, DocEntityLookupTableBinding, DocEntityFavorite, Favorite, FavoriteSearch>((int)request.Id, DocConstantModelName.FAVORITE, "Favorites", request, (ss) => HostContext.ResolveService<FavoriteService>(Request)?.Get(ss));
                    case "termsynonym":
                        return GetJunctionSearchResult<LookupTableBinding, DocEntityLookupTableBinding, DocEntityTermSynonym, TermSynonym, TermSynonymSearch>((int)request.Id, DocConstantModelName.TERMSYNONYM, "Synonyms", request, (ss) => HostContext.ResolveService<TermSynonymService>(Request)?.Get(ss));
                    case "tag":
                        return GetJunctionSearchResult<LookupTableBinding, DocEntityLookupTableBinding, DocEntityTag, Tag, TagSearch>((int)request.Id, DocConstantModelName.TAG, "Tags", request, (ss) => HostContext.ResolveService<TagService>(Request)?.Get(ss));
                    case "workflow":
                        return GetJunctionSearchResult<LookupTableBinding, DocEntityLookupTableBinding, DocEntityWorkflow, Workflow, WorkflowSearch>((int)request.Id, DocConstantModelName.WORKFLOW, "Workflows", request, (ss) => HostContext.ResolveService<WorkflowService>(Request)?.Get(ss));
                default:
                    throw new HttpError(HttpStatusCode.NotFound, $"Route for lookuptablebinding/{request.Id}/{request.Junction} was not found");
            }
        }
        public object Post(LookupTableBindingJunction request)
        {
            switch(request.Junction.ToLower().TrimAndPruneSpaces())
            {
                    case "comment":
                        return AddJunction<LookupTableBinding, DocEntityLookupTableBinding, DocEntityComment, Comment, CommentSearch>((int)request.Id, DocConstantModelName.COMMENT, "Comments", request);
                    case "favorite":
                        return AddJunction<LookupTableBinding, DocEntityLookupTableBinding, DocEntityFavorite, Favorite, FavoriteSearch>((int)request.Id, DocConstantModelName.FAVORITE, "Favorites", request);
                    case "termsynonym":
                        return AddJunction<LookupTableBinding, DocEntityLookupTableBinding, DocEntityTermSynonym, TermSynonym, TermSynonymSearch>((int)request.Id, DocConstantModelName.TERMSYNONYM, "Synonyms", request);
                    case "tag":
                        return AddJunction<LookupTableBinding, DocEntityLookupTableBinding, DocEntityTag, Tag, TagSearch>((int)request.Id, DocConstantModelName.TAG, "Tags", request);
                    case "workflow":
                        return AddJunction<LookupTableBinding, DocEntityLookupTableBinding, DocEntityWorkflow, Workflow, WorkflowSearch>((int)request.Id, DocConstantModelName.WORKFLOW, "Workflows", request);
                default:
                    throw new HttpError(HttpStatusCode.NotFound, $"Route for lookuptablebinding/{request.Id}/{request.Junction} was not found");
            }
        }

        public object Delete(LookupTableBindingJunction request)
        {    
            switch(request.Junction.ToLower().TrimAndPruneSpaces())
            {
                    case "comment":
                        return RemoveJunction<LookupTableBinding, DocEntityLookupTableBinding, DocEntityComment, Comment, CommentSearch>((int)request.Id, DocConstantModelName.COMMENT, "Comments", request);
                    case "favorite":
                        return RemoveJunction<LookupTableBinding, DocEntityLookupTableBinding, DocEntityFavorite, Favorite, FavoriteSearch>((int)request.Id, DocConstantModelName.FAVORITE, "Favorites", request);
                    case "termsynonym":
                        return RemoveJunction<LookupTableBinding, DocEntityLookupTableBinding, DocEntityTermSynonym, TermSynonym, TermSynonymSearch>((int)request.Id, DocConstantModelName.TERMSYNONYM, "Synonyms", request);
                    case "tag":
                        return RemoveJunction<LookupTableBinding, DocEntityLookupTableBinding, DocEntityTag, Tag, TagSearch>((int)request.Id, DocConstantModelName.TAG, "Tags", request);
                    case "workflow":
                        return RemoveJunction<LookupTableBinding, DocEntityLookupTableBinding, DocEntityWorkflow, Workflow, WorkflowSearch>((int)request.Id, DocConstantModelName.WORKFLOW, "Workflows", request);
                default:
                    throw new HttpError(HttpStatusCode.NotFound, $"Route for lookuptablebinding/{request.Id}/{request.Junction} was not found");
            }
        }
        private LookupTableBinding GetLookupTableBinding(LookupTableBinding request)
        {
            var id = request?.Id;
            LookupTableBinding ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetVisibleFields<LookupTableBinding>(currentUser, "LookupTableBinding", request.VisibleFields);

            DocEntityLookupTableBinding entity = null;
            if(id.HasValue)
            {
                entity = DocEntityLookupTableBinding.Get(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No LookupTableBinding found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }
    }
}
