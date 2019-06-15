
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
    public partial class PageService : DocServiceBase
    {

        private IQueryable<DocEntityPage> _ExecSearch(PageSearch request, DocQuery query)
        {
            request = InitSearch<Page, PageSearch>(request);
            IQueryable<DocEntityPage> entities = null;
            query.Run( session => 
            {
                entities = query.SelectAll<DocEntityPage>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new PageFullTextSearch(request);
                    entities = GetFullTextSearch<DocEntityPage,PageFullTextSearch>(fts, entities);
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
                if(true == request.Archived?.Any() && currentUser.HasProperty(DocConstantModelName.PAGE, nameof(Reference.Archived), DocConstantPermission.VIEW))
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
                if(true == request.AppsIds?.Any())
                {
                    entities = entities.Where(en => en.Apps.Any(r => r.Id.In(request.AppsIds)));
                }
                if(!DocTools.IsNullOrEmpty(request.Description))
                    entities = entities.Where(en => en.Description.Contains(request.Description));
                if(!DocTools.IsNullOrEmpty(request.Descriptions))
                    entities = entities.Where(en => en.Description.In(request.Descriptions));
                if(true == request.GlossaryIds?.Any())
                {
                    entities = entities.Where(en => en.Glossary.Any(r => r.Id.In(request.GlossaryIds)));
                }
                if(true == request.HelpIds?.Any())
                {
                    entities = entities.Where(en => en.Help.Any(r => r.Id.In(request.HelpIds)));
                }
                if(!DocTools.IsNullOrEmpty(request.Name))
                    entities = entities.Where(en => en.Name.Contains(request.Name));
                if(!DocTools.IsNullOrEmpty(request.Names))
                    entities = entities.Where(en => en.Name.In(request.Names));
                if(true == request.RolesIds?.Any())
                {
                    entities = entities.Where(en => en.Roles.Any(r => r.Id.In(request.RolesIds)));
                }

                entities = ApplyFilters<DocEntityPage,PageSearch>(request, entities);

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

        public object Post(PageSearch request) => Get(request);

        public object Get(PageSearch request) => GetSearchResultWithCache<Page,DocEntityPage,PageSearch>(DocConstantModelName.PAGE, request, _ExecSearch);

        public object Get(Page request) => GetEntityWithCache<Page>(DocConstantModelName.PAGE, request, GetPage);



        private Page _AssignValues(Page request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "Page"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.Select = request.Select ?? new List<string>();

            Page ret = null;
            request = _InitAssignValues<Page>(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            var cacheKey = GetApiCacheKey<Page>(DocConstantModelName.PAGE, nameof(Page), request);
            
            //First, assign all the variables, do database lookups and conversions
            var pApps = GetVariable<Reference>(request, nameof(request.Apps), request.Apps?.ToList(), request.AppsIds?.ToList());
            var pDescription = request.Description;
            var pGlossary = GetVariable<Reference>(request, nameof(request.Glossary), request.Glossary?.ToList(), request.GlossaryIds?.ToList());
            var pHelp = GetVariable<Reference>(request, nameof(request.Help), request.Help?.ToList(), request.HelpIds?.ToList());
            var pName = request.Name;
            var pRoles = GetVariable<Reference>(request, nameof(request.Roles), request.Roles?.ToList(), request.RolesIds?.ToList());
            var pArchived = true == request.Archived;
            var pLocked = request.Locked;

            var entity = InitEntity<DocEntityPage,Page>(request, permission, session);

            if (AllowPatchValue<Page, bool>(request, DocConstantModelName.PAGE, pArchived, permission, nameof(request.Archived), pArchived != entity.Archived))
            {
                entity.Archived = pArchived;
            }
            if (AllowPatchValue<Page, string>(request, DocConstantModelName.PAGE, pDescription, permission, nameof(request.Description), pDescription != entity.Description))
            {
                entity.Description = pDescription;
            }
            if (AllowPatchValue<Page, string>(request, DocConstantModelName.PAGE, pName, permission, nameof(request.Name), pName != entity.Name))
            {
                entity.Name = pName;
            }
            if (request.Locked && AllowPatchValue<Page, bool>(request, DocConstantModelName.PAGE, pArchived, permission, nameof(request.Locked), pLocked != entity.Locked))
            {
                entity.Archived = pArchived;
            }
            entity.SaveChanges(permission);

            var idsToInvalidate = new List<int>();
            idsToInvalidate.AddRange(PatchCollection<Page, DocEntityPage, Reference, DocEntityApp>(request, entity, pApps, permission, nameof(request.Apps)));
            idsToInvalidate.AddRange(PatchCollection<Page, DocEntityPage, Reference, DocEntityGlossary>(request, entity, pGlossary, permission, nameof(request.Glossary)));
            idsToInvalidate.AddRange(PatchCollection<Page, DocEntityPage, Reference, DocEntityHelp>(request, entity, pHelp, permission, nameof(request.Help)));
            idsToInvalidate.AddRange(PatchCollection<Page, DocEntityPage, Reference, DocEntityRole>(request, entity, pRoles, permission, nameof(request.Roles)));
            if (idsToInvalidate.Any())
            {
                idsToInvalidate.Add(entity.Id);
                DocCacheClient.RemoveByEntityIds(idsToInvalidate);
                DocCacheClient.RemoveSearch(DocConstantModelName.PAGE);
            }

            DocPermissionFactory.SetSelect<Page>(currentUser, nameof(Page), request.Select);
            ret = entity.ToDto();

            var cacheExpires = DocResources.Metadata.GetCacheExpiration(DocConstantModelName.PAGE);
            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.PAGE, cacheExpires);

            return ret;
        }


        public Page Post(Page request)
        {
            if(request == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            request.Select = request.Select ?? new List<string>();

            Page ret = null;

            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "Page")) 
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                    ret = _AssignValues(request, DocConstantPermission.ADD, ssn);
                });
            }
            return ret;
        }
   
        public List<Page> Post(PageBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<Page>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Post(dto) as Page;
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

        public Page Post(PageCopy request)
        {
            Page ret = null;
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    var entity = DocEntityPage.Get(request?.Id);
                    if(null == entity) throw new HttpError(HttpStatusCode.NoContent, "The COPY request did not succeed.");
                    if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD))
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                    var pApps = entity.Apps.ToList();
                    var pDescription = entity.Description;
                    if(!DocTools.IsNullOrEmpty(pDescription))
                        pDescription += " (Copy)";
                    var pGlossary = entity.Glossary.ToList();
                    var pHelp = entity.Help.ToList();
                    var pName = entity.Name;
                    if(!DocTools.IsNullOrEmpty(pName))
                        pName += " (Copy)";
                    var pRoles = entity.Roles.ToList();
                    var copy = new DocEntityPage(ssn)
                    {
                        Hash = Guid.NewGuid()
                                , Description = pDescription
                                , Name = pName
                    };
                            foreach(var item in pApps)
                            {
                                entity.Apps.Add(item);
                            }

                            foreach(var item in pGlossary)
                            {
                                entity.Glossary.Add(item);
                            }

                            foreach(var item in pHelp)
                            {
                                entity.Help.Add(item);
                            }

                            foreach(var item in pRoles)
                            {
                                entity.Roles.Add(item);
                            }

                    copy.SaveChanges(DocConstantPermission.ADD);
                    ret = copy.ToDto();
                });
            }
            return ret;
        }



        public List<Page> Put(PageBatch request)
        {
            return Patch(request);
        }

        public Page Put(Page request)
        {
            return Patch(request);
        }


        public List<Page> Patch(PageBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<Page>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Patch(dto) as Page;
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

        public Page Patch(Page request)
        {
            if(true != (request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the Page to patch.");
            
            request.Select = request.Select ?? new List<string>();
            
            Page ret = null;
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    ret = _AssignValues(request, DocConstantPermission.EDIT, ssn);
                });
            }
            return ret;
        }


        public void Delete(PageBatch request)
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

        public void Delete(Page request)
        {
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    if(!(request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, $"No Id provided for delete.");

                    var en = DocEntityPage.Get(request?.Id);
                    if(null == en) throw new HttpError(HttpStatusCode.NotFound, $"No Page could be found for Id {request?.Id}.");
                    if(en.IsRemoved) return;
                
                    if(!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.DELETE))
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have DELETE permission for this route.");
                
                    en.Remove();

                    DocCacheClient.RemoveSearch(DocConstantModelName.PAGE);
                    DocCacheClient.RemoveById(request.Id);
                });
            }
        }

        public void Delete(PageSearch request)
        {
            var matches = Get(request) as List<Page>;
            if(true != matches?.Any()) throw new HttpError(HttpStatusCode.NotFound, "No matches for request");
            matches.ForEach(match =>
            {
                Delete(match);
            });
        }


        public object Get(PageJunction request)
        {
            switch(request.Junction.ToLower().TrimAndPruneSpaces())
            {
                    case "app":
                        return GetJunctionSearchResult<Page, DocEntityPage, DocEntityApp, App, AppSearch>((int)request.Id, DocConstantModelName.APP, "Apps", request, (ss) => HostContext.ResolveService<AppService>(Request)?.Get(ss));
                    case "comment":
                        return GetJunctionSearchResult<Page, DocEntityPage, DocEntityComment, Comment, CommentSearch>((int)request.Id, DocConstantModelName.COMMENT, "Comments", request, (ss) => HostContext.ResolveService<CommentService>(Request)?.Get(ss));
                    case "favorite":
                        return GetJunctionSearchResult<Page, DocEntityPage, DocEntityFavorite, Favorite, FavoriteSearch>((int)request.Id, DocConstantModelName.FAVORITE, "Favorites", request, (ss) => HostContext.ResolveService<FavoriteService>(Request)?.Get(ss));
                    case "glossary":
                        return GetJunctionSearchResult<Page, DocEntityPage, DocEntityGlossary, Glossary, GlossarySearch>((int)request.Id, DocConstantModelName.GLOSSARY, "Glossary", request, (ss) => HostContext.ResolveService<GlossaryService>(Request)?.Get(ss));
                    case "help":
                        return GetJunctionSearchResult<Page, DocEntityPage, DocEntityHelp, Help, HelpSearch>((int)request.Id, DocConstantModelName.HELP, "Help", request, (ss) => HostContext.ResolveService<HelpService>(Request)?.Get(ss));
                    case "role":
                        return GetJunctionSearchResult<Page, DocEntityPage, DocEntityRole, Role, RoleSearch>((int)request.Id, DocConstantModelName.ROLE, "Roles", request, (ss) => HostContext.ResolveService<RoleService>(Request)?.Get(ss));
                    case "tag":
                        return GetJunctionSearchResult<Page, DocEntityPage, DocEntityTag, Tag, TagSearch>((int)request.Id, DocConstantModelName.TAG, "Tags", request, (ss) => HostContext.ResolveService<TagService>(Request)?.Get(ss));
                default:
                    throw new HttpError(HttpStatusCode.NotFound, $"Route for page/{request.Id}/{request.Junction} was not found");
            }
        }


        public object Post(PageJunction request)
        {
            switch(request.Junction.ToLower().TrimAndPruneSpaces())
            {
                    case "app":
                        return AddJunction<Page, DocEntityPage, DocEntityApp, App, AppSearch>((int)request.Id, DocConstantModelName.APP, "Apps", request);
                    case "comment":
                        return AddJunction<Page, DocEntityPage, DocEntityComment, Comment, CommentSearch>((int)request.Id, DocConstantModelName.COMMENT, "Comments", request);
                    case "favorite":
                        return AddJunction<Page, DocEntityPage, DocEntityFavorite, Favorite, FavoriteSearch>((int)request.Id, DocConstantModelName.FAVORITE, "Favorites", request);
                    case "glossary":
                        return AddJunction<Page, DocEntityPage, DocEntityGlossary, Glossary, GlossarySearch>((int)request.Id, DocConstantModelName.GLOSSARY, "Glossary", request);
                    case "help":
                        return AddJunction<Page, DocEntityPage, DocEntityHelp, Help, HelpSearch>((int)request.Id, DocConstantModelName.HELP, "Help", request);
                    case "role":
                        return AddJunction<Page, DocEntityPage, DocEntityRole, Role, RoleSearch>((int)request.Id, DocConstantModelName.ROLE, "Roles", request);
                    case "tag":
                        return AddJunction<Page, DocEntityPage, DocEntityTag, Tag, TagSearch>((int)request.Id, DocConstantModelName.TAG, "Tags", request);
                default:
                    throw new HttpError(HttpStatusCode.NotFound, $"Route for page/{request.Id}/{request.Junction} was not found");
            }
        }

        public object Delete(PageJunction request)
        {    
            switch(request.Junction.ToLower().TrimAndPruneSpaces())
            {
                    case "app":
                        return RemoveJunction<Page, DocEntityPage, DocEntityApp, App, AppSearch>((int)request.Id, DocConstantModelName.APP, "Apps", request);
                    case "comment":
                        return RemoveJunction<Page, DocEntityPage, DocEntityComment, Comment, CommentSearch>((int)request.Id, DocConstantModelName.COMMENT, "Comments", request);
                    case "favorite":
                        return RemoveJunction<Page, DocEntityPage, DocEntityFavorite, Favorite, FavoriteSearch>((int)request.Id, DocConstantModelName.FAVORITE, "Favorites", request);
                    case "glossary":
                        return RemoveJunction<Page, DocEntityPage, DocEntityGlossary, Glossary, GlossarySearch>((int)request.Id, DocConstantModelName.GLOSSARY, "Glossary", request);
                    case "help":
                        return RemoveJunction<Page, DocEntityPage, DocEntityHelp, Help, HelpSearch>((int)request.Id, DocConstantModelName.HELP, "Help", request);
                    case "role":
                        return RemoveJunction<Page, DocEntityPage, DocEntityRole, Role, RoleSearch>((int)request.Id, DocConstantModelName.ROLE, "Roles", request);
                    case "tag":
                        return RemoveJunction<Page, DocEntityPage, DocEntityTag, Tag, TagSearch>((int)request.Id, DocConstantModelName.TAG, "Tags", request);
                default:
                    throw new HttpError(HttpStatusCode.NotFound, $"Route for page/{request.Id}/{request.Junction} was not found");
            }
        }


        private Page GetPage(Page request)
        {
            var id = request?.Id;
            Page ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetSelect<Page>(currentUser, "Page", request.Select);

            DocEntityPage entity = null;
            if(id.HasValue)
            {
                entity = DocEntityPage.Get(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No Page found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }

    }
}
