
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
                if(!DocTools.IsNullOrEmpty(request.Descriptions))
                    entities = entities.Where(en => en.Description.In(request.Descriptions));
                if(!DocTools.IsNullOrEmpty(request.Name))
                    entities = entities.Where(en => en.Name.Contains(request.Name));
                if(!DocTools.IsNullOrEmpty(request.Names))
                    entities = entities.Where(en => en.Name.In(request.Names));
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
            var pPages = GetVariable<Reference>(request, nameof(request.Pages), request.Pages?.ToList(), request.PagesIds?.ToList());
            var pRoles = GetVariable<Reference>(request, nameof(request.Roles), request.Roles?.ToList(), request.RolesIds?.ToList());
            var pScopes = GetVariable<Reference>(request, nameof(request.Scopes), request.Scopes?.ToList(), request.ScopesIds?.ToList());
            var pArchived = true == request.Archived;
            var pLocked = request.Locked;

            var entity = InitEntity<DocEntityApp,App>(request, permission, session);

            if (AllowPatchValue<App, bool>(request, DocConstantModelName.APP, pArchived, permission, nameof(request.Archived), pArchived != entity.Archived))
            {
                entity.Archived = pArchived;
            }
            if (AllowPatchValue<App, string>(request, DocConstantModelName.APP, pDescription, permission, nameof(request.Description), pDescription != entity.Description))
            {
                entity.Description = pDescription;
            }
            if (AllowPatchValue<App, string>(request, DocConstantModelName.APP, pName, permission, nameof(request.Name), pName != entity.Name))
            {
                entity.Name = pName;
            }
            if (request.Locked && AllowPatchValue<App, bool>(request, DocConstantModelName.APP, pArchived, permission, nameof(request.Locked), pLocked != entity.Locked))
            {
                entity.Archived = pArchived;
            }
            entity.SaveChanges(permission);

            var idsToInvalidate = new List<int>();
            idsToInvalidate.AddRange(PatchCollection<App, DocEntityApp, Reference, DocEntityPage>(request, entity, pPages, permission, nameof(request.Pages)));
            idsToInvalidate.AddRange(PatchCollection<App, DocEntityApp, Reference, DocEntityRole>(request, entity, pRoles, permission, nameof(request.Roles)));
            idsToInvalidate.AddRange(PatchCollection<App, DocEntityApp, Reference, DocEntityScope>(request, entity, pScopes, permission, nameof(request.Scopes)));
            if (idsToInvalidate.Any())
            {
                idsToInvalidate.Add(entity.Id);
                DocCacheClient.RemoveByEntityIds(idsToInvalidate);
                DocCacheClient.RemoveSearch(DocConstantModelName.APP);
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
