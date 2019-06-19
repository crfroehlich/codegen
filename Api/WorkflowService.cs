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
    public partial class WorkflowService : DocServiceBase
    {

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private IQueryable<DocEntityWorkflow> _ExecSearch(WorkflowSearch request, DocQuery query)
        {
            request = InitSearch<Workflow, WorkflowSearch>(request);
            IQueryable<DocEntityWorkflow> entities = null;
            query.Run( session => 
            {
                entities = query.SelectAll<DocEntityWorkflow>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new WorkflowFullTextSearch(request);
                    entities = GetFullTextSearch<DocEntityWorkflow,WorkflowFullTextSearch>(fts, entities);
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
                if(true == request.Archived?.Any() && currentUser.HasProperty(DocConstantModelName.WORKFLOW, nameof(Reference.Archived), DocConstantPermission.VIEW))
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
                if(true == request.BindingsIds?.Any())
                {
                    entities = entities.Where(en => en.Bindings.Any(r => r.Id.In(request.BindingsIds)));
                }
                if(!DocTools.IsNullOrEmpty(request.Description))
                    entities = entities.Where(en => en.Description.Contains(request.Description));
                if(!DocTools.IsNullOrEmpty(request.Descriptions))
                    entities = entities.Where(en => en.Description.In(request.Descriptions));
                if(true == request.DocumentsIds?.Any())
                {
                    entities = entities.Where(en => en.Documents.Any(r => r.Id.In(request.DocumentsIds)));
                }
                if(!DocTools.IsNullOrEmpty(request.Name))
                    entities = entities.Where(en => en.Name.Contains(request.Name));
                if(!DocTools.IsNullOrEmpty(request.Names))
                    entities = entities.Where(en => en.Name.In(request.Names));
                if(!DocTools.IsNullOrEmpty(request.Owner) && !DocTools.IsNullOrEmpty(request.Owner.Id))
                {
                    entities = entities.Where(en => en.Owner.Id == request.Owner.Id );
                }
                if(true == request.OwnerIds?.Any())
                {
                    entities = entities.Where(en => en.Owner.Id.In(request.OwnerIds));
                }
                if(true == request.ScopesIds?.Any())
                {
                    entities = entities.Where(en => en.Scopes.Any(r => r.Id.In(request.ScopesIds)));
                }
                if(request.Status.HasValue)
                    entities = entities.Where(en => request.Status.Value == en.Status);
                if(!DocTools.IsNullOrEmpty(request.Statuss))
                    entities = entities.Where(en => en.Status.In(request.Statuss));
                if(true == request.TasksIds?.Any())
                {
                    entities = entities.Where(en => en.Tasks.Any(r => r.Id.In(request.TasksIds)));
                }
                if(request.Type.HasValue)
                    entities = entities.Where(en => request.Type.Value == en.Type);
                if(!DocTools.IsNullOrEmpty(request.Types))
                    entities = entities.Where(en => en.Type.In(request.Types));
                if(!DocTools.IsNullOrEmpty(request.User) && !DocTools.IsNullOrEmpty(request.User.Id))
                {
                    entities = entities.Where(en => en.User.Id == request.User.Id );
                }
                if(true == request.UserIds?.Any())
                {
                    entities = entities.Where(en => en.User.Id.In(request.UserIds));
                }
                if(true == request.VariablesIds?.Any())
                {
                    entities = entities.Where(en => en.Variables.Any(r => r.Id.In(request.VariablesIds)));
                }
                if(true == request.WorkflowsIds?.Any())
                {
                    entities = entities.Where(en => en.Workflows.Any(r => r.Id.In(request.WorkflowsIds)));
                }

                entities = ApplyFilters<DocEntityWorkflow,WorkflowSearch>(request, entities);

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
        public object Post(WorkflowSearch request) => Get(request);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Get(WorkflowSearch request) => GetSearchResultWithCache<Workflow,DocEntityWorkflow,WorkflowSearch>(DocConstantModelName.WORKFLOW, request, _ExecSearch);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Get(Workflow request) => GetEntityWithCache<Workflow>(DocConstantModelName.WORKFLOW, request, GetWorkflow);



        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private Workflow _AssignValues(Workflow request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "Workflow"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.Select = request.Select ?? new List<string>();

            Workflow ret = null;
            request = _InitAssignValues<Workflow>(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            var cacheKey = GetApiCacheKey<Workflow>(DocConstantModelName.WORKFLOW, nameof(Workflow), request);
            
            //First, assign all the variables, do database lookups and conversions
            var pBindings = GetVariable<Reference>(request, nameof(request.Bindings), request.Bindings?.ToList(), request.BindingsIds?.ToList());
            var pData = request.Data;
            var pDescription = request.Description;
            var pDocuments = GetVariable<Reference>(request, nameof(request.Documents), request.Documents?.ToList(), request.DocumentsIds?.ToList());
            var pName = request.Name;
            var pOwner = (request.Owner?.Id > 0) ? DocEntityWorkflow.Get(request.Owner.Id) : null;
            var pScopes = GetVariable<Reference>(request, nameof(request.Scopes), request.Scopes?.ToList(), request.ScopesIds?.ToList());
            var pStatus = request.Status;
            var pTasks = GetVariable<Reference>(request, nameof(request.Tasks), request.Tasks?.ToList(), request.TasksIds?.ToList());
            var pType = request.Type;
            var pUser = (request.User?.Id > 0) ? DocEntityUser.Get(request.User.Id) : null;
            var pVariables = GetVariable<Reference>(request, nameof(request.Variables), request.Variables?.ToList(), request.VariablesIds?.ToList());
            var pWorkflows = GetVariable<Reference>(request, nameof(request.Workflows), request.Workflows?.ToList(), request.WorkflowsIds?.ToList());
            var pArchived = true == request.Archived;
            var pLocked = request.Locked;

            var entity = InitEntity<DocEntityWorkflow,Workflow>(request, permission, session);

            if (AllowPatchValue<Workflow, bool>(request, DocConstantModelName.WORKFLOW, pArchived, permission, nameof(request.Archived), pArchived != entity.Archived))
            {
                entity.Archived = pArchived;
            }
            if (AllowPatchValue<Workflow, string>(request, DocConstantModelName.WORKFLOW, pData, permission, nameof(request.Data), pData != entity.Data))
            {
                entity.Data = pData;
            }
            if (AllowPatchValue<Workflow, string>(request, DocConstantModelName.WORKFLOW, pDescription, permission, nameof(request.Description), pDescription != entity.Description))
            {
                entity.Description = pDescription;
            }
            if (AllowPatchValue<Workflow, string>(request, DocConstantModelName.WORKFLOW, pName, permission, nameof(request.Name), pName != entity.Name))
            {
                entity.Name = pName;
            }
            if (AllowPatchValue<Workflow, DocEntityWorkflow>(request, DocConstantModelName.WORKFLOW, pOwner, permission, nameof(request.Owner), pOwner != entity.Owner))
            {
                entity.Owner = pOwner;
            }
            if (AllowPatchValue<Workflow, WorkflowStatusEnm?>(request, DocConstantModelName.WORKFLOW, pStatus, permission, nameof(request.Status), pStatus != entity.Status))
            {
                entity.Status = pStatus;
            }
            if (AllowPatchValue<Workflow, WorkflowEnm?>(request, DocConstantModelName.WORKFLOW, pType, permission, nameof(request.Type), pType != entity.Type))
            {
                if(null != pType) entity.Type = pType.Value;
            }
            if (AllowPatchValue<Workflow, DocEntityUser>(request, DocConstantModelName.WORKFLOW, pUser, permission, nameof(request.User), pUser != entity.User))
            {
                entity.User = pUser;
            }
            if (request.Locked && AllowPatchValue<Workflow, bool>(request, DocConstantModelName.WORKFLOW, pArchived, permission, nameof(request.Locked), pLocked != entity.Locked))
            {
                entity.Archived = pArchived;
            }
            entity.SaveChanges(permission);

            var idsToInvalidate = new List<int>();
            idsToInvalidate.AddRange(PatchCollection<Workflow, DocEntityWorkflow, Reference, DocEntityLookupTableBinding>(request, entity, pBindings, permission, nameof(request.Bindings)));
            idsToInvalidate.AddRange(PatchCollection<Workflow, DocEntityWorkflow, Reference, DocEntityDocument>(request, entity, pDocuments, permission, nameof(request.Documents)));
            idsToInvalidate.AddRange(PatchCollection<Workflow, DocEntityWorkflow, Reference, DocEntityScope>(request, entity, pScopes, permission, nameof(request.Scopes)));
            idsToInvalidate.AddRange(PatchCollection<Workflow, DocEntityWorkflow, Reference, DocEntityTask>(request, entity, pTasks, permission, nameof(request.Tasks)));
            idsToInvalidate.AddRange(PatchCollection<Workflow, DocEntityWorkflow, Reference, DocEntityVariableInstance>(request, entity, pVariables, permission, nameof(request.Variables)));
            idsToInvalidate.AddRange(PatchCollection<Workflow, DocEntityWorkflow, Reference, DocEntityWorkflow>(request, entity, pWorkflows, permission, nameof(request.Workflows)));
            if (idsToInvalidate.Any())
            {
                idsToInvalidate.Add(entity.Id);
                DocCacheClient.RemoveByEntityIds(idsToInvalidate);
                DocCacheClient.RemoveSearch(DocConstantModelName.WORKFLOW);
            }

            entity.SaveChanges(permission);
            DocPermissionFactory.SetSelect<Workflow>(currentUser, nameof(Workflow), request.Select);
            ret = entity.ToDto();

            var cacheExpires = DocResources.Metadata.GetCacheExpiration(DocConstantModelName.WORKFLOW);
            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.WORKFLOW, cacheExpires);

            return ret;
        }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Workflow Post(Workflow request)
        {
            if(request == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            request.Select = request.Select ?? new List<string>();

            Workflow ret = null;

            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "Workflow")) 
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                    ret = _AssignValues(request, DocConstantPermission.ADD, ssn);
                });
            }
            return ret;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<Workflow> Post(WorkflowBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<Workflow>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Post(dto) as Workflow;
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
        public Workflow Post(WorkflowCopy request)
        {
            Workflow ret = null;
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    var entity = DocEntityWorkflow.Get(request?.Id);
                    if(null == entity) throw new HttpError(HttpStatusCode.NoContent, "The COPY request did not succeed.");
                    if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD))
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                    var pBindings = entity.Bindings.ToList();
                    var pData = entity.Data;
                    var pDescription = entity.Description;
                    if(!DocTools.IsNullOrEmpty(pDescription))
                        pDescription += " (Copy)";
                    var pDocuments = entity.Documents.ToList();
                    var pName = entity.Name;
                    if(!DocTools.IsNullOrEmpty(pName))
                        pName += " (Copy)";
                    var pOwner = entity.Owner;
                    var pScopes = entity.Scopes.ToList();
                    var pStatus = entity.Status;
                    var pTasks = entity.Tasks.ToList();
                    var pType = entity.Type;
                    var pUser = entity.User;
                    var pVariables = entity.Variables.ToList();
                    var pWorkflows = entity.Workflows.ToList();
                    var copy = new DocEntityWorkflow(ssn)
                    {
                        Hash = Guid.NewGuid()
                                , Data = pData
                                , Description = pDescription
                                , Name = pName
                                , Owner = pOwner
                                , Status = pStatus
                                , Type = pType
                                , User = pUser
                    };
                            foreach(var item in pBindings)
                            {
                                entity.Bindings.Add(item);
                            }

                            foreach(var item in pDocuments)
                            {
                                entity.Documents.Add(item);
                            }

                            foreach(var item in pScopes)
                            {
                                entity.Scopes.Add(item);
                            }

                            foreach(var item in pTasks)
                            {
                                entity.Tasks.Add(item);
                            }

                            foreach(var item in pVariables)
                            {
                                entity.Variables.Add(item);
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
        public List<Workflow> Put(WorkflowBatch request)
        {
            return Patch(request);
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Workflow Put(Workflow request)
        {
            return Patch(request);
        }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<Workflow> Patch(WorkflowBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<Workflow>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Patch(dto) as Workflow;
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
        public Workflow Patch(Workflow request)
        {
            if(true != (request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the Workflow to patch.");
            
            request.Select = request.Select ?? new List<string>();
            
            Workflow ret = null;
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
        public object Get(WorkflowJunction request)
        {
            switch(request.Junction.ToLower().TrimAndPruneSpaces())
            {
                    case "lookuptablebinding":
                        return GetJunctionSearchResult<Workflow, DocEntityWorkflow, DocEntityLookupTableBinding, LookupTableBinding, LookupTableBindingSearch>((int)request.Id, DocConstantModelName.LOOKUPTABLEBINDING, "Bindings", request, (ss) => HostContext.ResolveService<LookupTableBindingService>(Request)?.Get(ss));
                    case "comment":
                        return GetJunctionSearchResult<Workflow, DocEntityWorkflow, DocEntityComment, Comment, CommentSearch>((int)request.Id, DocConstantModelName.COMMENT, "Comments", request, (ss) => HostContext.ResolveService<CommentService>(Request)?.Get(ss));
                    case "document":
                        return GetJunctionSearchResult<Workflow, DocEntityWorkflow, DocEntityDocument, Document, DocumentSearch>((int)request.Id, DocConstantModelName.DOCUMENT, "Documents", request, (ss) => HostContext.ResolveService<DocumentService>(Request)?.Get(ss));
                    case "favorite":
                        return GetJunctionSearchResult<Workflow, DocEntityWorkflow, DocEntityFavorite, Favorite, FavoriteSearch>((int)request.Id, DocConstantModelName.FAVORITE, "Favorites", request, (ss) => HostContext.ResolveService<FavoriteService>(Request)?.Get(ss));
                    case "scope":
                        return GetJunctionSearchResult<Workflow, DocEntityWorkflow, DocEntityScope, Scope, ScopeSearch>((int)request.Id, DocConstantModelName.SCOPE, "Scopes", request, (ss) => HostContext.ResolveService<ScopeService>(Request)?.Get(ss));
                    case "tag":
                        return GetJunctionSearchResult<Workflow, DocEntityWorkflow, DocEntityTag, Tag, TagSearch>((int)request.Id, DocConstantModelName.TAG, "Tags", request, (ss) => HostContext.ResolveService<TagService>(Request)?.Get(ss));
                    case "task":
                        return GetJunctionSearchResult<Workflow, DocEntityWorkflow, DocEntityTask, Task, TaskSearch>((int)request.Id, DocConstantModelName.TASK, "Tasks", request, (ss) => HostContext.ResolveService<TaskService>(Request)?.Get(ss));
                    case "variableinstance":
                        return GetJunctionSearchResult<Workflow, DocEntityWorkflow, DocEntityVariableInstance, VariableInstance, VariableInstanceSearch>((int)request.Id, DocConstantModelName.VARIABLEINSTANCE, "Variables", request, (ss) => HostContext.ResolveService<VariableInstanceService>(Request)?.Get(ss));
                    case "workflow":
                        return GetJunctionSearchResult<Workflow, DocEntityWorkflow, DocEntityWorkflow, Workflow, WorkflowSearch>((int)request.Id, DocConstantModelName.WORKFLOW, "Workflows", request, (ss) => HostContext.ResolveService<WorkflowService>(Request)?.Get(ss));
                default:
                    throw new HttpError(HttpStatusCode.NotFound, $"Route for workflow/{request.Id}/{request.Junction} was not found");
            }
        }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Post(WorkflowJunction request)
        {
            switch(request.Junction.ToLower().TrimAndPruneSpaces())
            {
                    case "lookuptablebinding":
                        return AddJunction<Workflow, DocEntityWorkflow, DocEntityLookupTableBinding, LookupTableBinding, LookupTableBindingSearch>((int)request.Id, DocConstantModelName.LOOKUPTABLEBINDING, "Bindings", request);
                    case "comment":
                        return AddJunction<Workflow, DocEntityWorkflow, DocEntityComment, Comment, CommentSearch>((int)request.Id, DocConstantModelName.COMMENT, "Comments", request);
                    case "document":
                        return AddJunction<Workflow, DocEntityWorkflow, DocEntityDocument, Document, DocumentSearch>((int)request.Id, DocConstantModelName.DOCUMENT, "Documents", request);
                    case "favorite":
                        return AddJunction<Workflow, DocEntityWorkflow, DocEntityFavorite, Favorite, FavoriteSearch>((int)request.Id, DocConstantModelName.FAVORITE, "Favorites", request);
                    case "scope":
                        return AddJunction<Workflow, DocEntityWorkflow, DocEntityScope, Scope, ScopeSearch>((int)request.Id, DocConstantModelName.SCOPE, "Scopes", request);
                    case "tag":
                        return AddJunction<Workflow, DocEntityWorkflow, DocEntityTag, Tag, TagSearch>((int)request.Id, DocConstantModelName.TAG, "Tags", request);
                    case "task":
                        return AddJunction<Workflow, DocEntityWorkflow, DocEntityTask, Task, TaskSearch>((int)request.Id, DocConstantModelName.TASK, "Tasks", request);
                    case "variableinstance":
                        return AddJunction<Workflow, DocEntityWorkflow, DocEntityVariableInstance, VariableInstance, VariableInstanceSearch>((int)request.Id, DocConstantModelName.VARIABLEINSTANCE, "Variables", request);
                    case "workflow":
                        return AddJunction<Workflow, DocEntityWorkflow, DocEntityWorkflow, Workflow, WorkflowSearch>((int)request.Id, DocConstantModelName.WORKFLOW, "Workflows", request);
                default:
                    throw new HttpError(HttpStatusCode.NotFound, $"Route for workflow/{request.Id}/{request.Junction} was not found");
            }
        }

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Delete(WorkflowJunction request)
        {    
            switch(request.Junction.ToLower().TrimAndPruneSpaces())
            {
                    case "lookuptablebinding":
                        return RemoveJunction<Workflow, DocEntityWorkflow, DocEntityLookupTableBinding, LookupTableBinding, LookupTableBindingSearch>((int)request.Id, DocConstantModelName.LOOKUPTABLEBINDING, "Bindings", request);
                    case "comment":
                        return RemoveJunction<Workflow, DocEntityWorkflow, DocEntityComment, Comment, CommentSearch>((int)request.Id, DocConstantModelName.COMMENT, "Comments", request);
                    case "document":
                        return RemoveJunction<Workflow, DocEntityWorkflow, DocEntityDocument, Document, DocumentSearch>((int)request.Id, DocConstantModelName.DOCUMENT, "Documents", request);
                    case "favorite":
                        return RemoveJunction<Workflow, DocEntityWorkflow, DocEntityFavorite, Favorite, FavoriteSearch>((int)request.Id, DocConstantModelName.FAVORITE, "Favorites", request);
                    case "scope":
                        return RemoveJunction<Workflow, DocEntityWorkflow, DocEntityScope, Scope, ScopeSearch>((int)request.Id, DocConstantModelName.SCOPE, "Scopes", request);
                    case "tag":
                        return RemoveJunction<Workflow, DocEntityWorkflow, DocEntityTag, Tag, TagSearch>((int)request.Id, DocConstantModelName.TAG, "Tags", request);
                    case "task":
                        return RemoveJunction<Workflow, DocEntityWorkflow, DocEntityTask, Task, TaskSearch>((int)request.Id, DocConstantModelName.TASK, "Tasks", request);
                    case "variableinstance":
                        return RemoveJunction<Workflow, DocEntityWorkflow, DocEntityVariableInstance, VariableInstance, VariableInstanceSearch>((int)request.Id, DocConstantModelName.VARIABLEINSTANCE, "Variables", request);
                    case "workflow":
                        return RemoveJunction<Workflow, DocEntityWorkflow, DocEntityWorkflow, Workflow, WorkflowSearch>((int)request.Id, DocConstantModelName.WORKFLOW, "Workflows", request);
                default:
                    throw new HttpError(HttpStatusCode.NotFound, $"Route for workflow/{request.Id}/{request.Junction} was not found");
            }
        }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private Workflow GetWorkflow(Workflow request)
        {
            var id = request?.Id;
            Workflow ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetSelect<Workflow>(currentUser, "Workflow", request.Select);

            DocEntityWorkflow entity = null;
            if(id.HasValue)
            {
                entity = DocEntityWorkflow.Get(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No Workflow found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }

    }
}
