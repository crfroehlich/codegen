//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated by a T4 template. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
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
    public partial class AppService : DocServiceBase
    {
        private IQueryable<DocEntityApp> _ExecSearch(AppSearch request, DocQuery query)
        {
            request = InitSearch<App, AppSearch>(request);
            IQueryable<DocEntityApp> entities = null;
            query.Run( session => 
            {
                entities = query.SelectAll<DocEntityApp>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new AppFullTextSearch(request);
                    entities = GetFullTextSearch<DocEntityApp,AppFullTextSearch>(fts, entities);
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
                if(true == request.Archived?.Any() && currentUser.HasProperty(DocConstantModelName.APP, nameof(Reference.Archived), DocConstantPermission.VIEW))
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
                if(!DocTools.IsNullOrEmpty(request.Description))
                    entities = entities.Where(en => en.Description.Contains(request.Description));
                if(!DocTools.IsNullOrEmpty(request.Name))
                    entities = entities.Where(en => en.Name.Contains(request.Name));
                if(true == request.PagesIds?.Any())
                {
                    entities = entities.Where(en => en.Pages.Any(r => r.Id.In(request.PagesIds)));
                }
                if(true == request.RolesIds?.Any())
                {
                    entities = entities.Where(en => en.Roles.Any(r => r.Id.In(request.RolesIds)));
                }
                if(true == request.ScopesIds?.Any())
                {
                    entities = entities.Where(en => en.Scopes.Any(r => r.Id.In(request.ScopesIds)));
                }

                entities = ApplyFilters<DocEntityApp,AppSearch>(request, entities);

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

        public object Post(AppSearch request) => Get(request);

        public object Get(AppSearch request) => GetSearchResultWithCache<App,DocEntityApp,AppSearch>(DocConstantModelName.APP, request, _ExecSearch);

        public object Get(App request) => GetEntityWithCache<App>(DocConstantModelName.APP, request, GetApp);

        private App _AssignValues(App request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "App"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.Select = request.Select ?? new List<string>();

            App ret = null;
            request = _InitAssignValues<App>(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            var cacheKey = GetApiCacheKey<App>(DocConstantModelName.APP, nameof(App), request);
            
            //First, assign all the variables, do database lookups and conversions
            var pDescription = request.Description;
            var pName = request.Name;
            var pPages = request.Pages?.ToList();
            var pRoles = request.Roles?.ToList();
            var pScopes = request.Scopes?.ToList();

            DocEntityApp entity = null;
            if(permission == DocConstantPermission.ADD)
            {
                var now = DateTime.UtcNow;
                entity = new DocEntityApp(session)
                {
                    Created = now,
                    Updated = now
                };
            }
            else
            {
                entity = DocEntityApp.Get(request.Id);
                if(null == entity)
                    throw new HttpError(HttpStatusCode.NotFound, $"No record");
            }

            //Special case for Archived
            var pArchived = true == request.Archived;
            if (DocPermissionFactory.IsRequestedHasPermission<bool>(currentUser, request, pArchived, permission, DocConstantModelName.APP, nameof(request.Archived)))
            {
                if(DocPermissionFactory.IsRequested(request, pArchived, entity.Archived, nameof(request.Archived)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.APP, nameof(request.Archived)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Archived)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pArchived) && DocResources.Metadata.IsRequired(DocConstantModelName.APP, nameof(request.Archived))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Archived)} requires a value.");
                    entity.Archived = pArchived;
                if(DocPermissionFactory.IsRequested<bool>(request, pArchived, nameof(request.Archived)) && !request.Select.Matches(nameof(request.Archived), ignoreSpaces: true))
                {
                    request.Select.Add(nameof(request.Archived));
                }
            }

            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pDescription, permission, DocConstantModelName.APP, nameof(request.Description)))
            {
                if(DocPermissionFactory.IsRequested(request, pDescription, entity.Description, nameof(request.Description)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.APP, nameof(request.Description)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Description)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pDescription) && DocResources.Metadata.IsRequired(DocConstantModelName.APP, nameof(request.Description))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Description)} requires a value.");
                    entity.Description = pDescription;
                if(DocPermissionFactory.IsRequested<string>(request, pDescription, nameof(request.Description)) && !request.Select.Matches(nameof(request.Description), ignoreSpaces: true))
                {
                    request.Select.Add(nameof(request.Description));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pName, permission, DocConstantModelName.APP, nameof(request.Name)))
            {
                if(DocPermissionFactory.IsRequested(request, pName, entity.Name, nameof(request.Name)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.APP, nameof(request.Name)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Name)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pName) && DocResources.Metadata.IsRequired(DocConstantModelName.APP, nameof(request.Name))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Name)} requires a value.");
                    entity.Name = pName;
                if(DocPermissionFactory.IsRequested<string>(request, pName, nameof(request.Name)) && !request.Select.Matches(nameof(request.Name), ignoreSpaces: true))
                {
                    request.Select.Add(nameof(request.Name));
                }
            }

            if (request.Locked) entity.Locked = request.Locked;

            entity.SaveChanges(permission);

            if (DocPermissionFactory.IsRequestedHasPermission<List<Reference>>(currentUser, request, pPages, permission, DocConstantModelName.APP, nameof(request.Pages)))
            {
                if (true == pPages?.Any() )
                {
                    var requestedPages = pPages.Select(p => p.Id).Distinct().ToList();
                    var existsPages = Execute.SelectAll<DocEntityPage>().Where(e => e.Id.In(requestedPages)).Select( e => e.Id ).ToList();
                    if (existsPages.Count != requestedPages.Count)
                    {
                        var nonExists = requestedPages.Where(id => existsPages.All(eId => eId != id));
                        throw new HttpError(HttpStatusCode.NotFound, $"Cannot patch collection Pages with objects that do not exist. No matching Pages(s) could be found for Ids: {nonExists.ToDelimitedString()}.");
                    }
                    var toAdd = requestedPages.Where(id => entity.Pages.All(e => e.Id != id)).ToList(); 
                    toAdd?.ForEach(id =>
                    {
                        var target = DocEntityPage.Get(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD, targetEntity: target, targetName: nameof(App), columnName: nameof(request.Pages)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to add {nameof(request.Pages)} to {nameof(App)}");
                        entity.Pages.Add(target);
                    });
                    var toRemove = entity.Pages.Where(e => requestedPages.All(id => e.Id != id)).Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityPage.Get(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(App), columnName: nameof(request.Pages)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Pages)} from {nameof(App)}");
                        entity.Pages.Remove(target);
                    });
                }
                else
                {
                    var toRemove = entity.Pages.Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityPage.Get(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(App), columnName: nameof(request.Pages)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Pages)} from {nameof(App)}");
                        entity.Pages.Remove(target);
                    });
                }
                if(DocPermissionFactory.IsRequested<List<Reference>>(request, pPages, nameof(request.Pages)) && !request.Select.Matches(nameof(request.Pages), ignoreSpaces: true))
                {
                    request.Select.Add(nameof(request.Pages));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<List<Reference>>(currentUser, request, pRoles, permission, DocConstantModelName.APP, nameof(request.Roles)))
            {
                if (true == pRoles?.Any() )
                {
                    var requestedRoles = pRoles.Select(p => p.Id).Distinct().ToList();
                    var existsRoles = Execute.SelectAll<DocEntityRole>().Where(e => e.Id.In(requestedRoles)).Select( e => e.Id ).ToList();
                    if (existsRoles.Count != requestedRoles.Count)
                    {
                        var nonExists = requestedRoles.Where(id => existsRoles.All(eId => eId != id));
                        throw new HttpError(HttpStatusCode.NotFound, $"Cannot patch collection Roles with objects that do not exist. No matching Roles(s) could be found for Ids: {nonExists.ToDelimitedString()}.");
                    }
                    var toAdd = requestedRoles.Where(id => entity.Roles.All(e => e.Id != id)).ToList(); 
                    toAdd?.ForEach(id =>
                    {
                        var target = DocEntityRole.Get(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD, targetEntity: target, targetName: nameof(App), columnName: nameof(request.Roles)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to add {nameof(request.Roles)} to {nameof(App)}");
                        entity.Roles.Add(target);
                    });
                    var toRemove = entity.Roles.Where(e => requestedRoles.All(id => e.Id != id)).Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityRole.Get(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(App), columnName: nameof(request.Roles)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Roles)} from {nameof(App)}");
                        entity.Roles.Remove(target);
                    });
                }
                else
                {
                    var toRemove = entity.Roles.Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityRole.Get(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(App), columnName: nameof(request.Roles)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Roles)} from {nameof(App)}");
                        entity.Roles.Remove(target);
                    });
                }
                if(DocPermissionFactory.IsRequested<List<Reference>>(request, pRoles, nameof(request.Roles)) && !request.Select.Matches(nameof(request.Roles), ignoreSpaces: true))
                {
                    request.Select.Add(nameof(request.Roles));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<List<Reference>>(currentUser, request, pScopes, permission, DocConstantModelName.APP, nameof(request.Scopes)))
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
                        var target = DocEntityScope.Get(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD, targetEntity: target, targetName: nameof(App), columnName: nameof(request.Scopes)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to add {nameof(request.Scopes)} to {nameof(App)}");
                        entity.Scopes.Add(target);
                    });
                    var toRemove = entity.Scopes.Where(e => requestedScopes.All(id => e.Id != id)).Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityScope.Get(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(App), columnName: nameof(request.Scopes)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Scopes)} from {nameof(App)}");
                        entity.Scopes.Remove(target);
                    });
                }
                else
                {
                    var toRemove = entity.Scopes.Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityScope.Get(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(App), columnName: nameof(request.Scopes)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Scopes)} from {nameof(App)}");
                        entity.Scopes.Remove(target);
                    });
                }
                if(DocPermissionFactory.IsRequested<List<Reference>>(request, pScopes, nameof(request.Scopes)) && !request.Select.Matches(nameof(request.Scopes), ignoreSpaces: true))
                {
                    request.Select.Add(nameof(request.Scopes));
                }
            }
            DocPermissionFactory.SetSelect<App>(currentUser, nameof(App), request.Select);
            ret = entity.ToDto();

            var cacheExpires = DocResources.Metadata.GetCacheExpiration(DocConstantModelName.APP);
            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.APP, cacheExpires);

            return ret;
        }

        public List<App> Put(AppBatch request)
        {
            return Patch(request);
        }

        public App Put(App request)
        {
            return Patch(request);
        }
        public List<App> Patch(AppBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<App>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Patch(dto) as App;
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

        public App Patch(App request)
        {
            if(true != (request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the App to patch.");
            
            request.Select = request.Select ?? new List<string>();
            
            App ret = null;
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    ret = _AssignValues(request, DocConstantPermission.EDIT, ssn);
                });
            }
            return ret;
        }
        public object Get(AppJunction request)
        {
            switch(request.Junction.ToLower().TrimAndPruneSpaces())
            {
                    case "comment":
                        return GetJunctionSearchResult<App, DocEntityApp, DocEntityComment, Comment, CommentSearch>((int)request.Id, DocConstantModelName.COMMENT, "Comments", request, (ss) => HostContext.ResolveService<CommentService>(Request)?.Get(ss));
                    case "favorite":
                        return GetJunctionSearchResult<App, DocEntityApp, DocEntityFavorite, Favorite, FavoriteSearch>((int)request.Id, DocConstantModelName.FAVORITE, "Favorites", request, (ss) => HostContext.ResolveService<FavoriteService>(Request)?.Get(ss));
                    case "page":
                        return GetJunctionSearchResult<App, DocEntityApp, DocEntityPage, Page, PageSearch>((int)request.Id, DocConstantModelName.PAGE, "Pages", request, (ss) => HostContext.ResolveService<PageService>(Request)?.Get(ss));
                    case "role":
                        return GetJunctionSearchResult<App, DocEntityApp, DocEntityRole, Role, RoleSearch>((int)request.Id, DocConstantModelName.ROLE, "Roles", request, (ss) => HostContext.ResolveService<RoleService>(Request)?.Get(ss));
                    case "scope":
                        return GetJunctionSearchResult<App, DocEntityApp, DocEntityScope, Scope, ScopeSearch>((int)request.Id, DocConstantModelName.SCOPE, "Scopes", request, (ss) => HostContext.ResolveService<ScopeService>(Request)?.Get(ss));
                    case "tag":
                        return GetJunctionSearchResult<App, DocEntityApp, DocEntityTag, Tag, TagSearch>((int)request.Id, DocConstantModelName.TAG, "Tags", request, (ss) => HostContext.ResolveService<TagService>(Request)?.Get(ss));
                default:
                    throw new HttpError(HttpStatusCode.NotFound, $"Route for app/{request.Id}/{request.Junction} was not found");
            }
        }
        public object Post(AppJunction request)
        {
            switch(request.Junction.ToLower().TrimAndPruneSpaces())
            {
                    case "comment":
                        return AddJunction<App, DocEntityApp, DocEntityComment, Comment, CommentSearch>((int)request.Id, DocConstantModelName.COMMENT, "Comments", request);
                    case "favorite":
                        return AddJunction<App, DocEntityApp, DocEntityFavorite, Favorite, FavoriteSearch>((int)request.Id, DocConstantModelName.FAVORITE, "Favorites", request);
                    case "page":
                        return AddJunction<App, DocEntityApp, DocEntityPage, Page, PageSearch>((int)request.Id, DocConstantModelName.PAGE, "Pages", request);
                    case "role":
                        return AddJunction<App, DocEntityApp, DocEntityRole, Role, RoleSearch>((int)request.Id, DocConstantModelName.ROLE, "Roles", request);
                    case "scope":
                        return AddJunction<App, DocEntityApp, DocEntityScope, Scope, ScopeSearch>((int)request.Id, DocConstantModelName.SCOPE, "Scopes", request);
                    case "tag":
                        return AddJunction<App, DocEntityApp, DocEntityTag, Tag, TagSearch>((int)request.Id, DocConstantModelName.TAG, "Tags", request);
                default:
                    throw new HttpError(HttpStatusCode.NotFound, $"Route for app/{request.Id}/{request.Junction} was not found");
            }
        }

        public object Delete(AppJunction request)
        {    
            switch(request.Junction.ToLower().TrimAndPruneSpaces())
            {
                    case "comment":
                        return RemoveJunction<App, DocEntityApp, DocEntityComment, Comment, CommentSearch>((int)request.Id, DocConstantModelName.COMMENT, "Comments", request);
                    case "favorite":
                        return RemoveJunction<App, DocEntityApp, DocEntityFavorite, Favorite, FavoriteSearch>((int)request.Id, DocConstantModelName.FAVORITE, "Favorites", request);
                    case "page":
                        return RemoveJunction<App, DocEntityApp, DocEntityPage, Page, PageSearch>((int)request.Id, DocConstantModelName.PAGE, "Pages", request);
                    case "role":
                        return RemoveJunction<App, DocEntityApp, DocEntityRole, Role, RoleSearch>((int)request.Id, DocConstantModelName.ROLE, "Roles", request);
                    case "scope":
                        return RemoveJunction<App, DocEntityApp, DocEntityScope, Scope, ScopeSearch>((int)request.Id, DocConstantModelName.SCOPE, "Scopes", request);
                    case "tag":
                        return RemoveJunction<App, DocEntityApp, DocEntityTag, Tag, TagSearch>((int)request.Id, DocConstantModelName.TAG, "Tags", request);
                default:
                    throw new HttpError(HttpStatusCode.NotFound, $"Route for app/{request.Id}/{request.Junction} was not found");
            }
        }
        private App GetApp(App request)
        {
            var id = request?.Id;
            App ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetSelect<App>(currentUser, "App", request.Select);

            DocEntityApp entity = null;
            if(id.HasValue)
            {
                entity = DocEntityApp.Get(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No App found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }
    }
}
