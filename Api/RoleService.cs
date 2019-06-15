
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
    public partial class RoleService : DocServiceBase
    {

        private IQueryable<DocEntityRole> _ExecSearch(RoleSearch request, DocQuery query)
        {
            request = InitSearch<Role, RoleSearch>(request);
            IQueryable<DocEntityRole> entities = null;
            query.Run( session => 
            {
                entities = query.SelectAll<DocEntityRole>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new RoleFullTextSearch(request);
                    entities = GetFullTextSearch<DocEntityRole,RoleFullTextSearch>(fts, entities);
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
                if(true == request.Archived?.Any() && currentUser.HasProperty(DocConstantModelName.ROLE, nameof(Reference.Archived), DocConstantPermission.VIEW))
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
                if(!DocTools.IsNullOrEmpty(request.AdminTeam) && !DocTools.IsNullOrEmpty(request.AdminTeam.Id))
                {
                    entities = entities.Where(en => en.AdminTeam.Id == request.AdminTeam.Id );
                }
                if(true == request.AdminTeamIds?.Any())
                {
                    entities = entities.Where(en => en.AdminTeam.Id.In(request.AdminTeamIds));
                }
                if(true == request.AppsIds?.Any())
                {
                    entities = entities.Where(en => en.Apps.Any(r => r.Id.In(request.AppsIds)));
                }
                if(!DocTools.IsNullOrEmpty(request.Description))
                    entities = entities.Where(en => en.Description.Contains(request.Description));
                if(!DocTools.IsNullOrEmpty(request.Descriptions))
                    entities = entities.Where(en => en.Description.In(request.Descriptions));
                if(true == request.FeatureSetsIds?.Any())
                {
                    entities = entities.Where(en => en.FeatureSets.Any(r => r.Id.In(request.FeatureSetsIds)));
                }
                if(true == request.IsInternal?.Any())
                {
                    if(request.IsInternal.Any(v => v == null)) entities = entities.Where(en => en.IsInternal.In(request.IsInternal) || en.IsInternal == null);
                    else entities = entities.Where(en => en.IsInternal.In(request.IsInternal));
                }
                if(true == request.IsSuperAdmin?.Any())
                {
                    if(request.IsSuperAdmin.Any(v => v == null)) entities = entities.Where(en => en.IsSuperAdmin.In(request.IsSuperAdmin) || en.IsSuperAdmin == null);
                    else entities = entities.Where(en => en.IsSuperAdmin.In(request.IsSuperAdmin));
                }
                if(!DocTools.IsNullOrEmpty(request.Name))
                    entities = entities.Where(en => en.Name.Contains(request.Name));
                if(!DocTools.IsNullOrEmpty(request.Names))
                    entities = entities.Where(en => en.Name.In(request.Names));
                if(true == request.PagesIds?.Any())
                {
                    entities = entities.Where(en => en.Pages.Any(r => r.Id.In(request.PagesIds)));
                }
                if(true == request.UsersIds?.Any())
                {
                    entities = entities.Where(en => en.Users.Any(r => r.Id.In(request.UsersIds)));
                }

                entities = ApplyFilters<DocEntityRole,RoleSearch>(request, entities);

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

        public object Post(RoleSearch request) => Get(request);

        public object Get(RoleSearch request) => GetSearchResultWithCache<Role,DocEntityRole,RoleSearch>(DocConstantModelName.ROLE, request, _ExecSearch);

        public object Get(Role request) => GetEntityWithCache<Role>(DocConstantModelName.ROLE, request, GetRole);



        private Role _AssignValues(Role request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "Role"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.Select = request.Select ?? new List<string>();

            Role ret = null;
            request = _InitAssignValues<Role>(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            var cacheKey = GetApiCacheKey<Role>(DocConstantModelName.ROLE, nameof(Role), request);
            
            //First, assign all the variables, do database lookups and conversions
            var pAdminTeam = (request.AdminTeam?.Id > 0) ? DocEntityTeam.Get(request.AdminTeam.Id) : null;
            var pApps = GetVariable<Reference>(request, nameof(request.Apps), request.Apps?.ToList(), request.AppsIds?.ToList());
            var pDescription = request.Description;
            var pFeatures = request.Features;
            var pFeatureSets = GetVariable<Reference>(request, nameof(request.FeatureSets), request.FeatureSets?.ToList(), request.FeatureSetsIds?.ToList());
            var pIsInternal = request.IsInternal;
            var pIsSuperAdmin = request.IsSuperAdmin;
            var pName = request.Name;
            var pPages = GetVariable<Reference>(request, nameof(request.Pages), request.Pages?.ToList(), request.PagesIds?.ToList());
            var pPermissions = request.Permissions;
            var pUsers = GetVariable<Reference>(request, nameof(request.Users), request.Users?.ToList(), request.UsersIds?.ToList());

            DocEntityRole entity = null;
            if(permission == DocConstantPermission.ADD)
            {
                var now = DateTime.UtcNow;
                entity = new DocEntityRole(session)
                {
                    Created = now,
                    Updated = now
                };
            }
            else
            {
                entity = DocEntityRole.Get(request.Id);
                if(null == entity)
                    throw new HttpError(HttpStatusCode.NotFound, $"No record");
            }

            //Special case for Archived
            var pArchived = true == request.Archived;
            if (PatchValue<Role, bool>(request, DocConstantModelName.ROLE, pArchived, entity.Archived, permission, nameof(request.Archived), pArchived != entity.Archived))
            {
                entity.Archived = pArchived;
            }
            if (PatchValue<Role, DocEntityTeam>(request, DocConstantModelName.ROLE, pAdminTeam, entity.AdminTeam, permission, nameof(request.AdminTeam), pAdminTeam != entity.AdminTeam))
            {
                entity.AdminTeam = pAdminTeam;
            }
            if (PatchValue<Role, string>(request, DocConstantModelName.ROLE, pDescription, entity.Description, permission, nameof(request.Description), pDescription != entity.Description))
            {
                entity.Description = pDescription;
            }
            if (PatchValue<Role, string>(request, DocConstantModelName.ROLE, pFeatures, entity.Features, permission, nameof(request.Features), pFeatures != entity.Features))
            {
                entity.Features = pFeatures;
            }
            if (PatchValue<Role, bool>(request, DocConstantModelName.ROLE, pIsInternal, entity.IsInternal, permission, nameof(request.IsInternal), pIsInternal != entity.IsInternal))
            {
                entity.IsInternal = pIsInternal;
            }
            if (PatchValue<Role, string>(request, DocConstantModelName.ROLE, pName, entity.Name, permission, nameof(request.Name), pName != entity.Name))
            {
                entity.Name = pName;
            }
            if (PatchValue<Role, string>(request, DocConstantModelName.ROLE, pPermissions, entity.Permissions, permission, nameof(request.Permissions), pPermissions != entity.Permissions))
            {
                entity.Permissions = pPermissions;
            }

            if (request.Locked) entity.Locked = request.Locked;

            entity.SaveChanges(permission);

            var idsToInvalidate = new List<int>();
            idsToInvalidate.AddRange(PatchCollection<Role, DocEntityRole, Reference, DocEntityApp>(request, entity, pApps, permission, nameof(request.Apps)));
            idsToInvalidate.AddRange(PatchCollection<Role, DocEntityRole, Reference, DocEntityFeatureSet>(request, entity, pFeatureSets, permission, nameof(request.FeatureSets)));
            idsToInvalidate.AddRange(PatchCollection<Role, DocEntityRole, Reference, DocEntityPage>(request, entity, pPages, permission, nameof(request.Pages)));
            idsToInvalidate.AddRange(PatchCollection<Role, DocEntityRole, Reference, DocEntityUser>(request, entity, pUsers, permission, nameof(request.Users)));
            if (idsToInvalidate.Any())
            {
                idsToInvalidate.Add(entity.Id);
                DocCacheClient.RemoveByEntityIds(idsToInvalidate);
                DocCacheClient.RemoveSearch(DocConstantModelName.ROLE);
            }

            DocPermissionFactory.SetSelect<Role>(currentUser, nameof(Role), request.Select);
            ret = entity.ToDto();

            var cacheExpires = DocResources.Metadata.GetCacheExpiration(DocConstantModelName.ROLE);
            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.ROLE, cacheExpires);

            return ret;
        }


        public Role Post(Role request)
        {
            if(request == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            request.Select = request.Select ?? new List<string>();

            Role ret = null;

            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "Role")) 
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                    ret = _AssignValues(request, DocConstantPermission.ADD, ssn);
                });
            }
            return ret;
        }
   
        public List<Role> Post(RoleBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<Role>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Post(dto) as Role;
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

        public Role Post(RoleCopy request)
        {
            Role ret = null;
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    var entity = DocEntityRole.Get(request?.Id);
                    if(null == entity) throw new HttpError(HttpStatusCode.NoContent, "The COPY request did not succeed.");
                    if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD))
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                    var pAdminTeam = entity.AdminTeam;
                    var pApps = entity.Apps.ToList();
                    var pDescription = entity.Description;
                    if(!DocTools.IsNullOrEmpty(pDescription))
                        pDescription += " (Copy)";
                    var pFeatures = entity.Features;
                    var pFeatureSets = entity.FeatureSets.ToList();
                    var pIsInternal = entity.IsInternal;
                    var pIsSuperAdmin = entity.IsSuperAdmin;
                    var pName = entity.Name;
                    if(!DocTools.IsNullOrEmpty(pName))
                        pName += " (Copy)";
                    var pPages = entity.Pages.ToList();
                    var pPermissions = entity.Permissions;
                    var pUsers = entity.Users.ToList();
                    var copy = new DocEntityRole(ssn)
                    {
                        Hash = Guid.NewGuid()
                                , AdminTeam = pAdminTeam
                                , Description = pDescription
                                , Features = pFeatures
                                , IsInternal = pIsInternal
                                , IsSuperAdmin = pIsSuperAdmin
                                , Name = pName
                                , Permissions = pPermissions
                    };
                            foreach(var item in pApps)
                            {
                                entity.Apps.Add(item);
                            }

                            foreach(var item in pFeatureSets)
                            {
                                entity.FeatureSets.Add(item);
                            }

                            foreach(var item in pPages)
                            {
                                entity.Pages.Add(item);
                            }

                            foreach(var item in pUsers)
                            {
                                entity.Users.Add(item);
                            }

                    copy.SaveChanges(DocConstantPermission.ADD);
                    ret = copy.ToDto();
                });
            }
            return ret;
        }



        public List<Role> Put(RoleBatch request)
        {
            return Patch(request);
        }

        public Role Put(Role request)
        {
            return Patch(request);
        }


        public List<Role> Patch(RoleBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<Role>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Patch(dto) as Role;
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

        public Role Patch(Role request)
        {
            if(true != (request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the Role to patch.");
            
            request.Select = request.Select ?? new List<string>();
            
            Role ret = null;
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    ret = _AssignValues(request, DocConstantPermission.EDIT, ssn);
                });
            }
            return ret;
        }


        public void Delete(RoleBatch request)
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

        public void Delete(Role request)
        {
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    if(!(request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, $"No Id provided for delete.");

                    var en = DocEntityRole.Get(request?.Id);
                    if(null == en) throw new HttpError(HttpStatusCode.NotFound, $"No Role could be found for Id {request?.Id}.");
                    if(en.IsRemoved) return;
                
                    if(!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.DELETE))
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have DELETE permission for this route.");
                
                    en.Remove();

                    DocCacheClient.RemoveSearch(DocConstantModelName.ROLE);
                    DocCacheClient.RemoveById(request.Id);
                });
            }
        }

        public void Delete(RoleSearch request)
        {
            var matches = Get(request) as List<Role>;
            if(true != matches?.Any()) throw new HttpError(HttpStatusCode.NotFound, "No matches for request");
            matches.ForEach(match =>
            {
                Delete(match);
            });
        }


        public object Get(RoleJunction request)
        {
            switch(request.Junction.ToLower().TrimAndPruneSpaces())
            {
                    case "app":
                        return GetJunctionSearchResult<Role, DocEntityRole, DocEntityApp, App, AppSearch>((int)request.Id, DocConstantModelName.APP, "Apps", request, (ss) => HostContext.ResolveService<AppService>(Request)?.Get(ss));
                    case "comment":
                        return GetJunctionSearchResult<Role, DocEntityRole, DocEntityComment, Comment, CommentSearch>((int)request.Id, DocConstantModelName.COMMENT, "Comments", request, (ss) => HostContext.ResolveService<CommentService>(Request)?.Get(ss));
                    case "favorite":
                        return GetJunctionSearchResult<Role, DocEntityRole, DocEntityFavorite, Favorite, FavoriteSearch>((int)request.Id, DocConstantModelName.FAVORITE, "Favorites", request, (ss) => HostContext.ResolveService<FavoriteService>(Request)?.Get(ss));
                    case "featureset":
                        return GetJunctionSearchResult<Role, DocEntityRole, DocEntityFeatureSet, FeatureSet, FeatureSetSearch>((int)request.Id, DocConstantModelName.FEATURESET, "FeatureSets", request, (ss) => HostContext.ResolveService<FeatureSetService>(Request)?.Get(ss));
                    case "page":
                        return GetJunctionSearchResult<Role, DocEntityRole, DocEntityPage, Page, PageSearch>((int)request.Id, DocConstantModelName.PAGE, "Pages", request, (ss) => HostContext.ResolveService<PageService>(Request)?.Get(ss));
                    case "tag":
                        return GetJunctionSearchResult<Role, DocEntityRole, DocEntityTag, Tag, TagSearch>((int)request.Id, DocConstantModelName.TAG, "Tags", request, (ss) => HostContext.ResolveService<TagService>(Request)?.Get(ss));
                    case "user":
                        return GetJunctionSearchResult<Role, DocEntityRole, DocEntityUser, User, UserSearch>((int)request.Id, DocConstantModelName.USER, "Users", request, (ss) => HostContext.ResolveService<UserService>(Request)?.Get(ss));
                default:
                    throw new HttpError(HttpStatusCode.NotFound, $"Route for role/{request.Id}/{request.Junction} was not found");
            }
        }


        public object Post(RoleJunction request)
        {
            switch(request.Junction.ToLower().TrimAndPruneSpaces())
            {
                    case "app":
                        return AddJunction<Role, DocEntityRole, DocEntityApp, App, AppSearch>((int)request.Id, DocConstantModelName.APP, "Apps", request);
                    case "comment":
                        return AddJunction<Role, DocEntityRole, DocEntityComment, Comment, CommentSearch>((int)request.Id, DocConstantModelName.COMMENT, "Comments", request);
                    case "favorite":
                        return AddJunction<Role, DocEntityRole, DocEntityFavorite, Favorite, FavoriteSearch>((int)request.Id, DocConstantModelName.FAVORITE, "Favorites", request);
                    case "featureset":
                        return AddJunction<Role, DocEntityRole, DocEntityFeatureSet, FeatureSet, FeatureSetSearch>((int)request.Id, DocConstantModelName.FEATURESET, "FeatureSets", request);
                    case "page":
                        return AddJunction<Role, DocEntityRole, DocEntityPage, Page, PageSearch>((int)request.Id, DocConstantModelName.PAGE, "Pages", request);
                    case "tag":
                        return AddJunction<Role, DocEntityRole, DocEntityTag, Tag, TagSearch>((int)request.Id, DocConstantModelName.TAG, "Tags", request);
                    case "user":
                        return AddJunction<Role, DocEntityRole, DocEntityUser, User, UserSearch>((int)request.Id, DocConstantModelName.USER, "Users", request);
                default:
                    throw new HttpError(HttpStatusCode.NotFound, $"Route for role/{request.Id}/{request.Junction} was not found");
            }
        }

        public object Delete(RoleJunction request)
        {    
            switch(request.Junction.ToLower().TrimAndPruneSpaces())
            {
                    case "app":
                        return RemoveJunction<Role, DocEntityRole, DocEntityApp, App, AppSearch>((int)request.Id, DocConstantModelName.APP, "Apps", request);
                    case "comment":
                        return RemoveJunction<Role, DocEntityRole, DocEntityComment, Comment, CommentSearch>((int)request.Id, DocConstantModelName.COMMENT, "Comments", request);
                    case "favorite":
                        return RemoveJunction<Role, DocEntityRole, DocEntityFavorite, Favorite, FavoriteSearch>((int)request.Id, DocConstantModelName.FAVORITE, "Favorites", request);
                    case "featureset":
                        return RemoveJunction<Role, DocEntityRole, DocEntityFeatureSet, FeatureSet, FeatureSetSearch>((int)request.Id, DocConstantModelName.FEATURESET, "FeatureSets", request);
                    case "page":
                        return RemoveJunction<Role, DocEntityRole, DocEntityPage, Page, PageSearch>((int)request.Id, DocConstantModelName.PAGE, "Pages", request);
                    case "tag":
                        return RemoveJunction<Role, DocEntityRole, DocEntityTag, Tag, TagSearch>((int)request.Id, DocConstantModelName.TAG, "Tags", request);
                    case "user":
                        return RemoveJunction<Role, DocEntityRole, DocEntityUser, User, UserSearch>((int)request.Id, DocConstantModelName.USER, "Users", request);
                default:
                    throw new HttpError(HttpStatusCode.NotFound, $"Route for role/{request.Id}/{request.Junction} was not found");
            }
        }


        private Role GetRole(Role request)
        {
            var id = request?.Id;
            Role ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetSelect<Role>(currentUser, "Role", request.Select);

            DocEntityRole entity = null;
            if(id.HasValue)
            {
                entity = DocEntityRole.Get(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No Role found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }

    }
}
