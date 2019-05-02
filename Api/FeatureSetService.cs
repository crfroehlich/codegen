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
    public partial class FeatureSetService : DocServiceBase
    {
        private IQueryable<DocEntityFeatureSet> _ExecSearch(FeatureSetSearch request, DocQuery query)
        {
            request = InitSearch<FeatureSet, FeatureSetSearch>(request);
            IQueryable<DocEntityFeatureSet> entities = null;
            query.Run( session => 
            {
                entities = query.SelectAll<DocEntityFeatureSet>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new FeatureSetFullTextSearch(request);
                    entities = GetFullTextSearch<DocEntityFeatureSet,FeatureSetFullTextSearch>(fts, entities);
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
                if(true == request.Archived?.Any() && currentUser.HasProperty(DocConstantModelName.FEATURESET, nameof(Reference.Archived), DocConstantPermission.VIEW))
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
                if(true == request.RolesIds?.Any())
                {
                    entities = entities.Where(en => en.Roles.Any(r => r.Id.In(request.RolesIds)));
                }

                entities = ApplyFilters<DocEntityFeatureSet,FeatureSetSearch>(request, entities);

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

        public object Post(FeatureSetSearch request) => Get(request);

        public object Get(FeatureSetSearch request) => GetSearchResultWithCache<FeatureSet,DocEntityFeatureSet,FeatureSetSearch>(DocConstantModelName.FEATURESET, request, _ExecSearch);

        public object Get(FeatureSet request) => GetEntityWithCache<FeatureSet>(DocConstantModelName.FEATURESET, request, GetFeatureSet);

        private FeatureSet _AssignValues(FeatureSet request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "FeatureSet"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            FeatureSet ret = null;
            request = _InitAssignValues<FeatureSet>(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            var cacheKey = GetApiCacheKey<FeatureSet>(DocConstantModelName.FEATURESET, nameof(FeatureSet), request);
            
            //First, assign all the variables, do database lookups and conversions
            var pDescription = request.Description;
            var pName = request.Name;
            var pPermissionTemplate = request.PermissionTemplate;
            var pRoles = request.Roles?.ToList();

            DocEntityFeatureSet entity = null;
            if(permission == DocConstantPermission.ADD)
            {
                var now = DateTime.UtcNow;
                entity = new DocEntityFeatureSet(session)
                {
                    Created = now,
                    Updated = now
                };
            }
            else
            {
                entity = DocEntityFeatureSet.Get(request.Id);
                if(null == entity)
                    throw new HttpError(HttpStatusCode.NotFound, $"No record");
            }

            //Special case for Archived
            var pArchived = true == request.Archived;
            if (DocPermissionFactory.IsRequestedHasPermission<bool>(currentUser, request, pArchived, permission, DocConstantModelName.FEATURESET, nameof(request.Archived)))
            {
                if(DocPermissionFactory.IsRequested(request, pArchived, entity.Archived, nameof(request.Archived)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.FEATURESET, nameof(request.Archived)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Archived)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pArchived) && DocResources.Metadata.IsRequired(DocConstantModelName.FEATURESET, nameof(request.Archived))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Archived)} requires a value.");
                    entity.Archived = pArchived;
                if(DocPermissionFactory.IsRequested<bool>(request, pArchived, nameof(request.Archived)) && !request.VisibleFields.Matches(nameof(request.Archived), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Archived));
                }
            }

            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pDescription, permission, DocConstantModelName.FEATURESET, nameof(request.Description)))
            {
                if(DocPermissionFactory.IsRequested(request, pDescription, entity.Description, nameof(request.Description)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.FEATURESET, nameof(request.Description)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Description)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pDescription) && DocResources.Metadata.IsRequired(DocConstantModelName.FEATURESET, nameof(request.Description))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Description)} requires a value.");
                    entity.Description = pDescription;
                if(DocPermissionFactory.IsRequested<string>(request, pDescription, nameof(request.Description)) && !request.VisibleFields.Matches(nameof(request.Description), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Description));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pName, permission, DocConstantModelName.FEATURESET, nameof(request.Name)))
            {
                if(DocPermissionFactory.IsRequested(request, pName, entity.Name, nameof(request.Name)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.FEATURESET, nameof(request.Name)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Name)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pName) && DocResources.Metadata.IsRequired(DocConstantModelName.FEATURESET, nameof(request.Name))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Name)} requires a value.");
                    entity.Name = pName;
                if(DocPermissionFactory.IsRequested<string>(request, pName, nameof(request.Name)) && !request.VisibleFields.Matches(nameof(request.Name), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Name));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pPermissionTemplate, permission, DocConstantModelName.FEATURESET, nameof(request.PermissionTemplate)))
            {
                if(DocPermissionFactory.IsRequested(request, pPermissionTemplate, entity.PermissionTemplate, nameof(request.PermissionTemplate)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.FEATURESET, nameof(request.PermissionTemplate)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.PermissionTemplate)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pPermissionTemplate) && DocResources.Metadata.IsRequired(DocConstantModelName.FEATURESET, nameof(request.PermissionTemplate))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.PermissionTemplate)} requires a value.");
                    entity.PermissionTemplate = pPermissionTemplate;
                if(DocPermissionFactory.IsRequested<string>(request, pPermissionTemplate, nameof(request.PermissionTemplate)) && !request.VisibleFields.Matches(nameof(request.PermissionTemplate), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.PermissionTemplate));
                }
            }

            if (request.Locked) entity.Locked = request.Locked;

            entity.SaveChanges(permission);

            if (DocPermissionFactory.IsRequestedHasPermission<List<Reference>>(currentUser, request, pRoles, permission, DocConstantModelName.FEATURESET, nameof(request.Roles)))
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
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD, targetEntity: target, targetName: nameof(FeatureSet), columnName: nameof(request.Roles)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to add {nameof(request.Roles)} to {nameof(FeatureSet)}");
                        entity.Roles.Add(target);
                    });
                    var toRemove = entity.Roles.Where(e => requestedRoles.All(id => e.Id != id)).Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityRole.Get(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(FeatureSet), columnName: nameof(request.Roles)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Roles)} from {nameof(FeatureSet)}");
                        entity.Roles.Remove(target);
                    });
                }
                else
                {
                    var toRemove = entity.Roles.Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityRole.Get(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(FeatureSet), columnName: nameof(request.Roles)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Roles)} from {nameof(FeatureSet)}");
                        entity.Roles.Remove(target);
                    });
                }
                if(DocPermissionFactory.IsRequested<List<Reference>>(request, pRoles, nameof(request.Roles)) && !request.VisibleFields.Matches(nameof(request.Roles), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Roles));
                }
            }
            DocPermissionFactory.SetVisibleFields<FeatureSet>(currentUser, nameof(FeatureSet), request.VisibleFields);
            ret = entity.ToDto();

            var cacheExpires = DocResources.Metadata.GetCacheExpiration(DocConstantModelName.FEATURESET);
            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.FEATURESET, cacheExpires);

            return ret;
        }

        public List<FeatureSet> Put(FeatureSetBatch request)
        {
            return Patch(request);
        }

        public FeatureSet Put(FeatureSet request)
        {
            return Patch(request);
        }
        public List<FeatureSet> Patch(FeatureSetBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<FeatureSet>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Patch(dto) as FeatureSet;
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

        public FeatureSet Patch(FeatureSet request)
        {
            if(true != (request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the FeatureSet to patch.");
            
            request.VisibleFields = request.VisibleFields ?? new List<string>();
            
            FeatureSet ret = null;
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    ret = _AssignValues(request, DocConstantPermission.EDIT, ssn);
                });
            }
            return ret;
        }
        public object Get(FeatureSetJunction request)
        {
            switch(request.Junction.ToLower().TrimAndPruneSpaces())
            {
                    case "comment":
                        return GetJunctionSearchResult<FeatureSet, DocEntityFeatureSet, DocEntityComment, Comment, CommentSearch>((int)request.Id, DocConstantModelName.COMMENT, "Comments", request, (ss) => HostContext.ResolveService<CommentService>(Request)?.Get(ss));
                    case "favorite":
                        return GetJunctionSearchResult<FeatureSet, DocEntityFeatureSet, DocEntityFavorite, Favorite, FavoriteSearch>((int)request.Id, DocConstantModelName.FAVORITE, "Favorites", request, (ss) => HostContext.ResolveService<FavoriteService>(Request)?.Get(ss));
                    case "role":
                        return GetJunctionSearchResult<FeatureSet, DocEntityFeatureSet, DocEntityRole, Role, RoleSearch>((int)request.Id, DocConstantModelName.ROLE, "Roles", request, (ss) => HostContext.ResolveService<RoleService>(Request)?.Get(ss));
                    case "tag":
                        return GetJunctionSearchResult<FeatureSet, DocEntityFeatureSet, DocEntityTag, Tag, TagSearch>((int)request.Id, DocConstantModelName.TAG, "Tags", request, (ss) => HostContext.ResolveService<TagService>(Request)?.Get(ss));
                default:
                    throw new HttpError(HttpStatusCode.NotFound, $"Route for featureset/{request.Id}/{request.Junction} was not found");
            }
        }
        public object Post(FeatureSetJunction request)
        {
            switch(request.Junction.ToLower().TrimAndPruneSpaces())
            {
                    case "comment":
                        return AddJunction<FeatureSet, DocEntityFeatureSet, DocEntityComment, Comment, CommentSearch>((int)request.Id, DocConstantModelName.COMMENT, "Comments", request);
                    case "favorite":
                        return AddJunction<FeatureSet, DocEntityFeatureSet, DocEntityFavorite, Favorite, FavoriteSearch>((int)request.Id, DocConstantModelName.FAVORITE, "Favorites", request);
                    case "role":
                        return AddJunction<FeatureSet, DocEntityFeatureSet, DocEntityRole, Role, RoleSearch>((int)request.Id, DocConstantModelName.ROLE, "Roles", request);
                    case "tag":
                        return AddJunction<FeatureSet, DocEntityFeatureSet, DocEntityTag, Tag, TagSearch>((int)request.Id, DocConstantModelName.TAG, "Tags", request);
                default:
                    throw new HttpError(HttpStatusCode.NotFound, $"Route for featureset/{request.Id}/{request.Junction} was not found");
            }
        }

        public object Delete(FeatureSetJunction request)
        {    
            switch(request.Junction.ToLower().TrimAndPruneSpaces())
            {
                    case "comment":
                        return RemoveJunction<FeatureSet, DocEntityFeatureSet, DocEntityComment, Comment, CommentSearch>((int)request.Id, DocConstantModelName.COMMENT, "Comments", request);
                    case "favorite":
                        return RemoveJunction<FeatureSet, DocEntityFeatureSet, DocEntityFavorite, Favorite, FavoriteSearch>((int)request.Id, DocConstantModelName.FAVORITE, "Favorites", request);
                    case "role":
                        return RemoveJunction<FeatureSet, DocEntityFeatureSet, DocEntityRole, Role, RoleSearch>((int)request.Id, DocConstantModelName.ROLE, "Roles", request);
                    case "tag":
                        return RemoveJunction<FeatureSet, DocEntityFeatureSet, DocEntityTag, Tag, TagSearch>((int)request.Id, DocConstantModelName.TAG, "Tags", request);
                default:
                    throw new HttpError(HttpStatusCode.NotFound, $"Route for featureset/{request.Id}/{request.Junction} was not found");
            }
        }
        private FeatureSet GetFeatureSet(FeatureSet request)
        {
            var id = request?.Id;
            FeatureSet ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetVisibleFields<FeatureSet>(currentUser, "FeatureSet", request.VisibleFields);

            DocEntityFeatureSet entity = null;
            if(id.HasValue)
            {
                entity = DocEntityFeatureSet.Get(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No FeatureSet found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }
    }
}
