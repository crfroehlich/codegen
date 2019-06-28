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
    public partial class ClientService : DocServiceBase
    {

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private IQueryable<DocEntityClient> _ExecSearch(ClientSearch request, DocQuery query)
        {
            request = InitSearch<Client, ClientSearch>(request);
            IQueryable<DocEntityClient> entities = null;
            query.Run( session => 
            {
                entities = query.SelectAll<DocEntityClient>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new ClientFullTextSearch(request);
                    entities = GetFullTextSearch<DocEntityClient,ClientFullTextSearch>(fts, entities);
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
                if(true == request.Archived?.Any() && currentUser.HasProperty(DocConstantModelName.CLIENT, nameof(Reference.Archived), DocConstantPermission.VIEW))
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
                if(!DocTools.IsNullOrEmpty(request.DefaultLocale) && !DocTools.IsNullOrEmpty(request.DefaultLocale.Id))
                {
                    entities = entities.Where(en => en.DefaultLocale.Id == request.DefaultLocale.Id );
                }
                if(true == request.DefaultLocaleIds?.Any())
                {
                    entities = entities.Where(en => en.DefaultLocale.Id.In(request.DefaultLocaleIds));
                }
                if(true == request.DivisionsIds?.Any())
                {
                    entities = entities.Where(en => en.Divisions.Any(r => r.Id.In(request.DivisionsIds)));
                }
                if(true == request.DocumentSetsIds?.Any())
                {
                    entities = entities.Where(en => en.DocumentSets.Any(r => r.Id.In(request.DocumentSetsIds)));
                }
                if(!DocTools.IsNullOrEmpty(request.Name))
                    entities = entities.Where(en => en.Name.Contains(request.Name));
                if(!DocTools.IsNullOrEmpty(request.Names))
                    entities = entities.Where(en => en.Name.In(request.Names));
                if(true == request.ProjectsIds?.Any())
                {
                    entities = entities.Where(en => en.Projects.Any(r => r.Id.In(request.ProjectsIds)));
                }
                if(!DocTools.IsNullOrEmpty(request.Role) && !DocTools.IsNullOrEmpty(request.Role.Id))
                {
                    entities = entities.Where(en => en.Role.Id == request.Role.Id );
                }
                if(true == request.RoleIds?.Any())
                {
                    entities = entities.Where(en => en.Role.Id.In(request.RoleIds));
                }
                if(!DocTools.IsNullOrEmpty(request.SalesforceAccountId))
                    entities = entities.Where(en => en.SalesforceAccountId.Contains(request.SalesforceAccountId));
                if(!DocTools.IsNullOrEmpty(request.SalesforceAccountIds))
                    entities = entities.Where(en => en.SalesforceAccountId.In(request.SalesforceAccountIds));
                if(true == request.ScopesIds?.Any())
                {
                    entities = entities.Where(en => en.Scopes.Any(r => r.Id.In(request.ScopesIds)));
                }

                entities = ApplyFilters<DocEntityClient,ClientSearch>(request, entities);

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
        public object Post(ClientSearch request) => Get(request);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Get(ClientSearch request) => GetSearchResultWithCache<Client,DocEntityClient,ClientSearch>(DocConstantModelName.CLIENT, request, _ExecSearch);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Get(Client request) => GetEntityWithCache<Client>(DocConstantModelName.CLIENT, request, GetClient);



        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private Client _AssignValues(Client request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "Client"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.Select = request.Select ?? new List<string>();

            Client ret = null;
            request = _InitAssignValues<Client>(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            var cacheKey = GetApiCacheKey<Client>(DocConstantModelName.CLIENT, nameof(Client), request);
            
            //First, assign all the variables, do database lookups and conversions
            var pDefaultLocale = DocEntityLocale.Get(request.DefaultLocale?.Id, true, Execute) ?? DocEntityLocale.Get(request.DefaultLocaleId, true, Execute);
            var pDivisions = GetVariable<Reference>(request, nameof(request.Divisions), request.Divisions?.ToList(), request.DivisionsIds?.ToList());
            var pDocumentSets = GetVariable<Reference>(request, nameof(request.DocumentSets), request.DocumentSets?.ToList(), request.DocumentSetsIds?.ToList());
            var pName = request.Name;
            var pProjects = GetVariable<Reference>(request, nameof(request.Projects), request.Projects?.ToList(), request.ProjectsIds?.ToList());
            var pRole = DocEntityRole.Get(request.Role?.Id, true, Execute) ?? DocEntityRole.Get(request.RoleId, true, Execute);
            var pSalesforceAccountId = request.SalesforceAccountId;
            var pScopes = GetVariable<Reference>(request, nameof(request.Scopes), request.Scopes?.ToList(), request.ScopesIds?.ToList());
            var pSettings = (DocTools.IsNullOrEmpty(request.Settings)) ? null : DocSerialize<ClientSettings>.ToString(request.Settings);
            var pArchived = true == request.Archived;
            var pLocked = request.Locked;

            var entity = InitEntity<DocEntityClient,Client>(request, permission, session);

            if (AllowPatchValue<Client, bool>(request, DocConstantModelName.CLIENT, pArchived, permission, nameof(request.Archived), pArchived != entity.Archived))
            {
                entity.Archived = pArchived;
            }
            if (AllowPatchValue<Client, DocEntityLocale>(request, DocConstantModelName.CLIENT, pDefaultLocale, permission, nameof(request.DefaultLocale), pDefaultLocale != entity.DefaultLocale))
            {
                entity.DefaultLocale = pDefaultLocale;
            }
            if (AllowPatchValue<Client, string>(request, DocConstantModelName.CLIENT, pName, permission, nameof(request.Name), pName != entity.Name))
            {
                entity.Name = pName;
            }
            if (AllowPatchValue<Client, DocEntityRole>(request, DocConstantModelName.CLIENT, pRole, permission, nameof(request.Role), pRole != entity.Role))
            {
                entity.Role = pRole;
            }
            if (AllowPatchValue<Client, string>(request, DocConstantModelName.CLIENT, pSalesforceAccountId, permission, nameof(request.SalesforceAccountId), pSalesforceAccountId != entity.SalesforceAccountId))
            {
                entity.SalesforceAccountId = pSalesforceAccountId;
            }
            if (AllowPatchValue<Client, string>(request, DocConstantModelName.CLIENT, pSettings, permission, nameof(request.Settings), pSettings != entity.Settings))
            {
                entity.Settings = pSettings;
            }
            if (request.Locked && AllowPatchValue<Client, bool>(request, DocConstantModelName.CLIENT, pArchived, permission, nameof(request.Locked), pLocked != entity.Locked))
            {
                entity.Archived = pArchived;
            }
            entity.SaveChanges(permission);

            var idsToInvalidate = new List<int>();
            idsToInvalidate.AddRange(PatchCollection<Client, DocEntityClient, Reference, DocEntityDivision>(request, entity, pDivisions, permission, nameof(request.Divisions)));
            idsToInvalidate.AddRange(PatchCollection<Client, DocEntityClient, Reference, DocEntityDocumentSet>(request, entity, pDocumentSets, permission, nameof(request.DocumentSets)));
            idsToInvalidate.AddRange(PatchCollection<Client, DocEntityClient, Reference, DocEntityProject>(request, entity, pProjects, permission, nameof(request.Projects)));
            idsToInvalidate.AddRange(PatchCollection<Client, DocEntityClient, Reference, DocEntityScope>(request, entity, pScopes, permission, nameof(request.Scopes)));
            if (idsToInvalidate.Any())
            {
                idsToInvalidate.Add(entity.Id);
                DocCacheClient.RemoveByEntityIds(idsToInvalidate);
                DocCacheClient.RemoveSearch(DocConstantModelName.CLIENT);
            }

            entity.SaveChanges(permission);
            DocPermissionFactory.SetSelect<Client>(currentUser, nameof(Client), request.Select);
            ret = entity.ToDto();

            var cacheExpires = DocResources.Metadata.GetCacheExpiration(DocConstantModelName.CLIENT);
            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.CLIENT, cacheExpires);

            return ret;
        }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Client Post(Client request)
        {
            if(request == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            request.Select = request.Select ?? new List<string>();

            Client ret = null;

            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "Client")) 
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                    ret = _AssignValues(request, DocConstantPermission.ADD, ssn);
                });
            }
            return ret;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<Client> Post(ClientBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<Client>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Post(dto) as Client;
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
        public Client Post(ClientCopy request)
        {
            Client ret = null;
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    var entity = DocEntityClient.Get(request?.Id);
                    if(null == entity) throw new HttpError(HttpStatusCode.NoContent, "The COPY request did not succeed.");
                    if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD))
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                    var pDefaultLocale = entity.DefaultLocale;
                    var pDivisions = entity.Divisions.ToList();
                    var pDocumentSets = entity.DocumentSets.ToList();
                    var pName = entity.Name;
                    if(!DocTools.IsNullOrEmpty(pName))
                        pName += " (Copy)";
                    var pProjects = entity.Projects.ToList();
                    var pRole = entity.Role;
                    var pSalesforceAccountId = entity.SalesforceAccountId;
                    if(!DocTools.IsNullOrEmpty(pSalesforceAccountId))
                        pSalesforceAccountId += " (Copy)";
                    var pScopes = entity.Scopes.ToList();
                    var pSettings = entity.Settings;
                    var copy = new DocEntityClient(ssn)
                    {
                        Hash = Guid.NewGuid()
                                , DefaultLocale = pDefaultLocale
                                , Name = pName
                                , Role = pRole
                                , SalesforceAccountId = pSalesforceAccountId
                                , Settings = pSettings
                    };
                            foreach(var item in pDivisions)
                            {
                                entity.Divisions.Add(item);
                            }

                            foreach(var item in pDocumentSets)
                            {
                                entity.DocumentSets.Add(item);
                            }

                            foreach(var item in pProjects)
                            {
                                entity.Projects.Add(item);
                            }

                            foreach(var item in pScopes)
                            {
                                entity.Scopes.Add(item);
                            }

                    copy.SaveChanges(DocConstantPermission.ADD);
                    ret = copy.ToDto();
                });
            }
            return ret;
        }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<Client> Put(ClientBatch request)
        {
            return Patch(request);
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Client Put(Client request)
        {
            return Patch(request);
        }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<Client> Patch(ClientBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<Client>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Patch(dto) as Client;
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
        public Client Patch(Client request)
        {
            if(true != (request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the Client to patch.");
            
            request.Select = request.Select ?? new List<string>();
            
            Client ret = null;
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
        public void Delete(ClientBatch request)
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
        public void Delete(Client request)
        {
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    if(!(request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, $"No Id provided for delete.");

                    var en = DocEntityClient.Get(request?.Id);
                    if(null == en) throw new HttpError(HttpStatusCode.NotFound, $"No Client could be found for Id {request?.Id}.");
                    if(en.IsRemoved) return;
                
                    if(!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.DELETE))
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have DELETE permission for this route.");
                
                    en.Remove();

                    DocCacheClient.RemoveSearch(DocConstantModelName.CLIENT);
                    DocCacheClient.RemoveById(request.Id);
                });
            }
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public void Delete(ClientSearch request)
        {
            var matches = Get(request) as List<Client>;
            if(true != matches?.Any()) throw new HttpError(HttpStatusCode.NotFound, "No matches for request");
            matches.ForEach(match =>
            {
                Delete(match);
            });
        }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Get(ClientJunction request)
        {
            switch(request.Junction.ToLower().TrimAndPruneSpaces())
            {
                    case "lookuptablebinding":
                        return GetJunctionSearchResult<Client, DocEntityClient, DocEntityLookupTableBinding, LookupTableBinding, LookupTableBindingSearch>((int)request.Id, DocConstantModelName.LOOKUPTABLEBINDING, "Bindings", request, (ss) => HostContext.ResolveService<LookupTableBindingService>(Request)?.Get(ss));
                    case "comment":
                        return GetJunctionSearchResult<Client, DocEntityClient, DocEntityComment, Comment, CommentSearch>((int)request.Id, DocConstantModelName.COMMENT, "Comments", request, (ss) => HostContext.ResolveService<CommentService>(Request)?.Get(ss));
                    case "division":
                        return GetJunctionSearchResult<Client, DocEntityClient, DocEntityDivision, Division, DivisionSearch>((int)request.Id, DocConstantModelName.DIVISION, "Divisions", request, (ss) => HostContext.ResolveService<DivisionService>(Request)?.Get(ss));
                    case "documentset":
                        return GetJunctionSearchResult<Client, DocEntityClient, DocEntityDocumentSet, DocumentSet, DocumentSetSearch>((int)request.Id, DocConstantModelName.DOCUMENTSET, "DocumentSets", request, (ss) => HostContext.ResolveService<DocumentSetService>(Request)?.Get(ss));
                    case "favorite":
                        return GetJunctionSearchResult<Client, DocEntityClient, DocEntityFavorite, Favorite, FavoriteSearch>((int)request.Id, DocConstantModelName.FAVORITE, "Favorites", request, (ss) => HostContext.ResolveService<FavoriteService>(Request)?.Get(ss));
                    case "project":
                        return GetJunctionSearchResult<Client, DocEntityClient, DocEntityProject, Project, ProjectSearch>((int)request.Id, DocConstantModelName.PROJECT, "Projects", request, (ss) => HostContext.ResolveService<ProjectService>(Request)?.Get(ss));
                    case "scope":
                        return GetJunctionSearchResult<Client, DocEntityClient, DocEntityScope, Scope, ScopeSearch>((int)request.Id, DocConstantModelName.SCOPE, "Scopes", request, (ss) => HostContext.ResolveService<ScopeService>(Request)?.Get(ss));
                    case "tag":
                        return GetJunctionSearchResult<Client, DocEntityClient, DocEntityTag, Tag, TagSearch>((int)request.Id, DocConstantModelName.TAG, "Tags", request, (ss) => HostContext.ResolveService<TagService>(Request)?.Get(ss));
                    case "user":
                        return GetJunctionSearchResult<Client, DocEntityClient, DocEntityUser, User, UserSearch>((int)request.Id, DocConstantModelName.USER, "Users", request, (ss) => HostContext.ResolveService<UserService>(Request)?.Get(ss));
                    case "workflow":
                        return GetJunctionSearchResult<Client, DocEntityClient, DocEntityWorkflow, Workflow, WorkflowSearch>((int)request.Id, DocConstantModelName.WORKFLOW, "Workflows", request, (ss) => HostContext.ResolveService<WorkflowService>(Request)?.Get(ss));
                default:
                    throw new HttpError(HttpStatusCode.NotFound, $"Route for client/{request.Id}/{request.Junction} was not found");
            }
        }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Post(ClientJunction request)
        {
            switch(request.Junction.ToLower().TrimAndPruneSpaces())
            {
                    case "comment":
                        return AddJunction<Client, DocEntityClient, DocEntityComment, Comment, CommentSearch>((int)request.Id, DocConstantModelName.COMMENT, "Comments", request);
                    case "division":
                        return AddJunction<Client, DocEntityClient, DocEntityDivision, Division, DivisionSearch>((int)request.Id, DocConstantModelName.DIVISION, "Divisions", request);
                    case "documentset":
                        return AddJunction<Client, DocEntityClient, DocEntityDocumentSet, DocumentSet, DocumentSetSearch>((int)request.Id, DocConstantModelName.DOCUMENTSET, "DocumentSets", request);
                    case "favorite":
                        return AddJunction<Client, DocEntityClient, DocEntityFavorite, Favorite, FavoriteSearch>((int)request.Id, DocConstantModelName.FAVORITE, "Favorites", request);
                    case "scope":
                        return AddJunction<Client, DocEntityClient, DocEntityScope, Scope, ScopeSearch>((int)request.Id, DocConstantModelName.SCOPE, "Scopes", request);
                    case "tag":
                        return AddJunction<Client, DocEntityClient, DocEntityTag, Tag, TagSearch>((int)request.Id, DocConstantModelName.TAG, "Tags", request);
                default:
                    throw new HttpError(HttpStatusCode.NotFound, $"Route for client/{request.Id}/{request.Junction} was not found");
            }
        }

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Delete(ClientJunction request)
        {    
            switch(request.Junction.ToLower().TrimAndPruneSpaces())
            {
                    case "comment":
                        return RemoveJunction<Client, DocEntityClient, DocEntityComment, Comment, CommentSearch>((int)request.Id, DocConstantModelName.COMMENT, "Comments", request);
                    case "division":
                        return RemoveJunction<Client, DocEntityClient, DocEntityDivision, Division, DivisionSearch>((int)request.Id, DocConstantModelName.DIVISION, "Divisions", request);
                    case "documentset":
                        return RemoveJunction<Client, DocEntityClient, DocEntityDocumentSet, DocumentSet, DocumentSetSearch>((int)request.Id, DocConstantModelName.DOCUMENTSET, "DocumentSets", request);
                    case "favorite":
                        return RemoveJunction<Client, DocEntityClient, DocEntityFavorite, Favorite, FavoriteSearch>((int)request.Id, DocConstantModelName.FAVORITE, "Favorites", request);
                    case "scope":
                        return RemoveJunction<Client, DocEntityClient, DocEntityScope, Scope, ScopeSearch>((int)request.Id, DocConstantModelName.SCOPE, "Scopes", request);
                    case "tag":
                        return RemoveJunction<Client, DocEntityClient, DocEntityTag, Tag, TagSearch>((int)request.Id, DocConstantModelName.TAG, "Tags", request);
                default:
                    throw new HttpError(HttpStatusCode.NotFound, $"Route for client/{request.Id}/{request.Junction} was not found");
            }
        }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private Client GetClient(Client request)
        {
            var id = request?.Id;
            Client ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetSelect<Client>(currentUser, "Client", request.Select);

            DocEntityClient entity = null;
            if(id.HasValue)
            {
                entity = DocEntityClient.Get(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No Client found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }

    }
}
