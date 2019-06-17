//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated by a T4 template. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Net;

using Services.Core;
using Services.Db;
using Services.Dto;
using Services.Enums;
using Services.Schema;

using ServiceStack;
using ServiceStack.Text;

using Typed;
using Typed.Bindings;
using Typed.Notifications;

using Xtensive.Orm;


namespace Services.API
{
    public partial class LookupTableBindingService : DocServiceBase
    {

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
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
                if(!DocTools.IsNullOrEmpty(request.BoundNames))
                    entities = entities.Where(en => en.BoundName.In(request.BoundNames));
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
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Post(LookupTableBindingSearch request) => Get(request);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Get(LookupTableBindingSearch request) => GetSearchResultWithCache<LookupTableBinding,DocEntityLookupTableBinding,LookupTableBindingSearch>(DocConstantModelName.LOOKUPTABLEBINDING, request, _ExecSearch);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Get(LookupTableBinding request) => GetEntityWithCache<LookupTableBinding>(DocConstantModelName.LOOKUPTABLEBINDING, request, GetLookupTableBinding);



        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private LookupTableBinding _AssignValues(LookupTableBinding request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "LookupTableBinding"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.Select = request.Select ?? new List<string>();

            LookupTableBinding ret = null;
            request = _InitAssignValues<LookupTableBinding>(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            var cacheKey = GetApiCacheKey<LookupTableBinding>(DocConstantModelName.LOOKUPTABLEBINDING, nameof(LookupTableBinding), request);
            
            //First, assign all the variables, do database lookups and conversions
            var pBinding = (DocTools.IsNullOrEmpty(request.Binding)) ? null : DocSerialize<Bindings>.ToString(request.Binding);
            var pBoundName = request.BoundName;
            DocEntityLookupTable pLookupTable = GetLookup(DocConstantLookupTable.ATTRIBUTENAME, request.LookupTable?.Name, request.LookupTable?.Id);
            var pScope = (request.Scope?.Id > 0) ? DocEntityScope.Get(request.Scope.Id) : null;
            var pSynonyms = GetVariable<Reference>(request, nameof(request.Synonyms), request.Synonyms?.ToList(), request.SynonymsIds?.ToList());
            var pWorkflows = GetVariable<Reference>(request, nameof(request.Workflows), request.Workflows?.ToList(), request.WorkflowsIds?.ToList());
            var pArchived = true == request.Archived;
            var pLocked = request.Locked;

            var entity = InitEntity<DocEntityLookupTableBinding,LookupTableBinding>(request, permission, session);

            if (AllowPatchValue<LookupTableBinding, bool>(request, DocConstantModelName.LOOKUPTABLEBINDING, pArchived, permission, nameof(request.Archived), pArchived != entity.Archived))
            {
                entity.Archived = pArchived;
            }
            if (AllowPatchValue<LookupTableBinding, string>(request, DocConstantModelName.LOOKUPTABLEBINDING, pBinding, permission, nameof(request.Binding), pBinding != entity.Binding))
            {
                entity.Binding = pBinding;
            }
            if (AllowPatchValue<LookupTableBinding, string>(request, DocConstantModelName.LOOKUPTABLEBINDING, pBoundName, permission, nameof(request.BoundName), pBoundName != entity.BoundName))
            {
                entity.BoundName = pBoundName;
            }
            if (AllowPatchValue<LookupTableBinding, DocEntityLookupTable>(request, DocConstantModelName.LOOKUPTABLEBINDING, pLookupTable, permission, nameof(request.LookupTable), pLookupTable != entity.LookupTable))
            {
                entity.LookupTable = pLookupTable;
            }
            if (AllowPatchValue<LookupTableBinding, DocEntityScope>(request, DocConstantModelName.LOOKUPTABLEBINDING, pScope, permission, nameof(request.Scope), pScope != entity.Scope))
            {
                entity.Scope = pScope;
            }
            if (request.Locked && AllowPatchValue<LookupTableBinding, bool>(request, DocConstantModelName.LOOKUPTABLEBINDING, pArchived, permission, nameof(request.Locked), pLocked != entity.Locked))
            {
                entity.Archived = pArchived;
            }
            entity.SaveChanges(permission);

            var idsToInvalidate = new List<int>();
            idsToInvalidate.AddRange(PatchCollection<LookupTableBinding, DocEntityLookupTableBinding, Reference, DocEntityTermSynonym>(request, entity, pSynonyms, permission, nameof(request.Synonyms)));
            idsToInvalidate.AddRange(PatchCollection<LookupTableBinding, DocEntityLookupTableBinding, Reference, DocEntityWorkflow>(request, entity, pWorkflows, permission, nameof(request.Workflows)));
            if (idsToInvalidate.Any())
            {
                idsToInvalidate.Add(entity.Id);
                DocCacheClient.RemoveByEntityIds(idsToInvalidate);
                DocCacheClient.RemoveSearch(DocConstantModelName.LOOKUPTABLEBINDING);
            }

            DocPermissionFactory.SetSelect<LookupTableBinding>(currentUser, nameof(LookupTableBinding), request.Select);
            ret = entity.ToDto();

            var cacheExpires = DocResources.Metadata.GetCacheExpiration(DocConstantModelName.LOOKUPTABLEBINDING);
            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.LOOKUPTABLEBINDING, cacheExpires);

            return ret;
        }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public LookupTableBinding Post(LookupTableBinding request)
        {
            if(request == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            request.Select = request.Select ?? new List<string>();

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
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
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
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
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

                    copy.SaveChanges(DocConstantPermission.ADD);
                    ret = copy.ToDto();
                });
            }
            return ret;
        }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<LookupTableBinding> Put(LookupTableBindingBatch request)
        {
            return Patch(request);
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public LookupTableBinding Put(LookupTableBinding request)
        {
            return Patch(request);
        }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
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
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public LookupTableBinding Patch(LookupTableBinding request)
        {
            if(true != (request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the LookupTableBinding to patch.");
            
            request.Select = request.Select ?? new List<string>();
            
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


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
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
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
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
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public void Delete(LookupTableBindingSearch request)
        {
            var matches = Get(request) as List<LookupTableBinding>;
            if(true != matches?.Any()) throw new HttpError(HttpStatusCode.NotFound, "No matches for request");
            matches.ForEach(match =>
            {
                Delete(match);
            });
        }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
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


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
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

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
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


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private LookupTableBinding GetLookupTableBinding(LookupTableBinding request)
        {
            var id = request?.Id;
            LookupTableBinding ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetSelect<LookupTableBinding>(currentUser, "LookupTableBinding", request.Select);

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
