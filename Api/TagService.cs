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
    public partial class TagService : DocServiceBase
    {
        private IQueryable<DocEntityTag> _ExecSearch(TagSearch request, DocQuery query)
        {
            request = InitSearch<Tag, TagSearch>(request);
            IQueryable<DocEntityTag> entities = null;
            query.Run( session => 
            {
                entities = query.SelectAll<DocEntityTag>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new TagFullTextSearch(request);
                    entities = GetFullTextSearch<DocEntityTag,TagFullTextSearch>(fts, entities);
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
                if(true == request.Archived?.Any() && currentUser.HasProperty(DocConstantModelName.TAG, nameof(Reference.Archived), DocConstantPermission.VIEW))
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
                if(!DocTools.IsNullOrEmpty(request.Name))
                    entities = entities.Where(en => en.Name.Contains(request.Name));
                if(true == request.ScopesIds?.Any())
                {
                    entities = entities.Where(en => en.Scopes.Any(r => r.Id.In(request.ScopesIds)));
                }
                if(!DocTools.IsNullOrEmpty(request.URI))
                    entities = entities.Where(en => en.URI.Contains(request.URI));

                entities = ApplyFilters<DocEntityTag,TagSearch>(request, entities);

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

        public object Post(TagSearch request) => Get(request);

        public object Get(TagSearch request) => GetSearchResultWithCache<Tag,DocEntityTag,TagSearch>(DocConstantModelName.TAG, request, _ExecSearch);

        public object Get(Tag request) => GetEntityWithCache<Tag>(DocConstantModelName.TAG, request, GetTag);

        private Tag _AssignValues(Tag request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "Tag"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            Tag ret = null;
            request = _InitAssignValues<Tag>(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            var cacheKey = GetApiCacheKey<Tag>(DocConstantModelName.TAG, nameof(Tag), request);
            
            //First, assign all the variables, do database lookups and conversions
            var pName = request.Name;
            var pScopes = request.Scopes?.ToList();
            var pURI = request.URI;

            DocEntityTag entity = null;
            if(permission == DocConstantPermission.ADD)
            {
                var now = DateTime.UtcNow;
                entity = new DocEntityTag(session)
                {
                    Created = now,
                    Updated = now
                };
            }
            else
            {
                entity = DocEntityTag.Get(request.Id);
                if(null == entity)
                    throw new HttpError(HttpStatusCode.NotFound, $"No record");
            }

            //Special case for Archived
            var pArchived = true == request.Archived;
            if (DocPermissionFactory.IsRequestedHasPermission<bool>(currentUser, request, pArchived, permission, DocConstantModelName.TAG, nameof(request.Archived)))
            {
                if(DocPermissionFactory.IsRequested(request, pArchived, entity.Archived, nameof(request.Archived)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.TAG, nameof(request.Archived)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Archived)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pArchived) && DocResources.Metadata.IsRequired(DocConstantModelName.TAG, nameof(request.Archived))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Archived)} requires a value.");
                    entity.Archived = pArchived;
                if(DocPermissionFactory.IsRequested<bool>(request, pArchived, nameof(request.Archived)) && !request.VisibleFields.Matches(nameof(request.Archived), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Archived));
                }
            }

            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pName, permission, DocConstantModelName.TAG, nameof(request.Name)))
            {
                if(DocPermissionFactory.IsRequested(request, pName, entity.Name, nameof(request.Name)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.TAG, nameof(request.Name)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Name)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pName) && DocResources.Metadata.IsRequired(DocConstantModelName.TAG, nameof(request.Name))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Name)} requires a value.");
                    entity.Name = pName;
                if(DocPermissionFactory.IsRequested<string>(request, pName, nameof(request.Name)) && !request.VisibleFields.Matches(nameof(request.Name), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Name));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pURI, permission, DocConstantModelName.TAG, nameof(request.URI)))
            {
                if(DocPermissionFactory.IsRequested(request, pURI, entity.URI, nameof(request.URI)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.TAG, nameof(request.URI)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.URI)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pURI) && DocResources.Metadata.IsRequired(DocConstantModelName.TAG, nameof(request.URI))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.URI)} requires a value.");
                    entity.URI = pURI;
                if(DocPermissionFactory.IsRequested<string>(request, pURI, nameof(request.URI)) && !request.VisibleFields.Matches(nameof(request.URI), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.URI));
                }
            }

            if (request.Locked) entity.Locked = request.Locked;

            entity.SaveChanges(permission);

            if (DocPermissionFactory.IsRequestedHasPermission<List<Reference>>(currentUser, request, pScopes, permission, DocConstantModelName.TAG, nameof(request.Scopes)))
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
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD, targetEntity: target, targetName: nameof(Tag), columnName: nameof(request.Scopes)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to add {nameof(request.Scopes)} to {nameof(Tag)}");
                        entity.Scopes.Add(target);
                    });
                    var toRemove = entity.Scopes.Where(e => requestedScopes.All(id => e.Id != id)).Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityScope.Get(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(Tag), columnName: nameof(request.Scopes)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Scopes)} from {nameof(Tag)}");
                        entity.Scopes.Remove(target);
                    });
                }
                else
                {
                    var toRemove = entity.Scopes.Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityScope.Get(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(Tag), columnName: nameof(request.Scopes)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Scopes)} from {nameof(Tag)}");
                        entity.Scopes.Remove(target);
                    });
                }
                if(DocPermissionFactory.IsRequested<List<Reference>>(request, pScopes, nameof(request.Scopes)) && !request.VisibleFields.Matches(nameof(request.Scopes), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Scopes));
                }
            }
            DocPermissionFactory.SetVisibleFields<Tag>(currentUser, nameof(Tag), request.VisibleFields);
            ret = entity.ToDto();

            var cacheExpires = DocResources.Metadata.GetCacheExpiration(DocConstantModelName.TAG);
            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.TAG, cacheExpires);

            return ret;
        }
        public Tag Post(Tag request)
        {
            if(request == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            Tag ret = null;

            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "Tag")) 
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                    ret = _AssignValues(request, DocConstantPermission.ADD, ssn);
                });
            }
            return ret;
        }
   
        public List<Tag> Post(TagBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<Tag>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Post(dto) as Tag;
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

        public Tag Post(TagCopy request)
        {
            Tag ret = null;
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    var entity = DocEntityTag.Get(request?.Id);
                    if(null == entity) throw new HttpError(HttpStatusCode.NoContent, "The COPY request did not succeed.");
                    if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD))
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                    var pName = entity.Name;
                    if(!DocTools.IsNullOrEmpty(pName))
                        pName += " (Copy)";
                    var pScopes = entity.Scopes.ToList();
                    var pURI = entity.URI;
                    if(!DocTools.IsNullOrEmpty(pURI))
                        pURI += " (Copy)";
                    #region Custom Before copyTag
                    #endregion Custom Before copyTag
                    var copy = new DocEntityTag(ssn)
                    {
                        Hash = Guid.NewGuid()
                                , Name = pName
                                , URI = pURI
                    };
                            foreach(var item in pScopes)
                            {
                                entity.Scopes.Add(item);
                            }

                    #region Custom After copyTag
                    #endregion Custom After copyTag
                    copy.SaveChanges(DocConstantPermission.ADD);
                    ret = copy.ToDto();
                });
            }
            return ret;
        }
        public void Delete(TagBatch request)
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

        public void Delete(Tag request)
        {
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    if(!(request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, $"No Id provided for delete.");

                    var en = DocEntityTag.Get(request?.Id);
                    if(null == en) throw new HttpError(HttpStatusCode.NotFound, $"No Tag could be found for Id {request?.Id}.");
                    if(en.IsRemoved) return;
                
                    if(!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.DELETE))
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have DELETE permission for this route.");
                
                    en.Remove();

                    DocCacheClient.RemoveSearch(DocConstantModelName.TAG);
                    DocCacheClient.RemoveById(request.Id);
                });
            }
        }

        public void Delete(TagSearch request)
        {
            var matches = Get(request) as List<Tag>;
            if(true != matches?.Any()) throw new HttpError(HttpStatusCode.NotFound, "No matches for request");
            matches.ForEach(match =>
            {
                Delete(match);
            });
        }
        public object Get(TagJunction request)
        {
            switch(request.Junction.ToLower().TrimAndPruneSpaces())
            {
                    case "comment":
                        return GetJunctionSearchResult<Tag, DocEntityTag, DocEntityComment, Comment, CommentSearch>((int)request.Id, DocConstantModelName.COMMENT, "Comments", request, (ss) => HostContext.ResolveService<CommentService>(Request)?.Get(ss));
                    case "favorite":
                        return GetJunctionSearchResult<Tag, DocEntityTag, DocEntityFavorite, Favorite, FavoriteSearch>((int)request.Id, DocConstantModelName.FAVORITE, "Favorites", request, (ss) => HostContext.ResolveService<FavoriteService>(Request)?.Get(ss));
                    case "scope":
                        return GetJunctionSearchResult<Tag, DocEntityTag, DocEntityScope, Scope, ScopeSearch>((int)request.Id, DocConstantModelName.SCOPE, "Scopes", request, (ss) => HostContext.ResolveService<ScopeService>(Request)?.Get(ss));
                    case "tag":
                        return GetJunctionSearchResult<Tag, DocEntityTag, DocEntityTag, Tag, TagSearch>((int)request.Id, DocConstantModelName.TAG, "Tags", request, (ss) => HostContext.ResolveService<TagService>(Request)?.Get(ss));
                default:
                    throw new HttpError(HttpStatusCode.NotFound, $"Route for tag/{request.Id}/{request.Junction} was not found");
            }
        }
        public object Post(TagJunction request)
        {
            switch(request.Junction.ToLower().TrimAndPruneSpaces())
            {
                    case "comment":
                        return AddJunction<Tag, DocEntityTag, DocEntityComment, Comment, CommentSearch>((int)request.Id, DocConstantModelName.COMMENT, "Comments", request);
                    case "favorite":
                        return AddJunction<Tag, DocEntityTag, DocEntityFavorite, Favorite, FavoriteSearch>((int)request.Id, DocConstantModelName.FAVORITE, "Favorites", request);
                    case "scope":
                        return AddJunction<Tag, DocEntityTag, DocEntityScope, Scope, ScopeSearch>((int)request.Id, DocConstantModelName.SCOPE, "Scopes", request);
                    case "tag":
                        return AddJunction<Tag, DocEntityTag, DocEntityTag, Tag, TagSearch>((int)request.Id, DocConstantModelName.TAG, "Tags", request);
                default:
                    throw new HttpError(HttpStatusCode.NotFound, $"Route for tag/{request.Id}/{request.Junction} was not found");
            }
        }

        public object Delete(TagJunction request)
        {    
            switch(request.Junction.ToLower().TrimAndPruneSpaces())
            {
                    case "comment":
                        return RemoveJunction<Tag, DocEntityTag, DocEntityComment, Comment, CommentSearch>((int)request.Id, DocConstantModelName.COMMENT, "Comments", request);
                    case "favorite":
                        return RemoveJunction<Tag, DocEntityTag, DocEntityFavorite, Favorite, FavoriteSearch>((int)request.Id, DocConstantModelName.FAVORITE, "Favorites", request);
                    case "scope":
                        return RemoveJunction<Tag, DocEntityTag, DocEntityScope, Scope, ScopeSearch>((int)request.Id, DocConstantModelName.SCOPE, "Scopes", request);
                    case "tag":
                        return RemoveJunction<Tag, DocEntityTag, DocEntityTag, Tag, TagSearch>((int)request.Id, DocConstantModelName.TAG, "Tags", request);
                default:
                    throw new HttpError(HttpStatusCode.NotFound, $"Route for tag/{request.Id}/{request.Junction} was not found");
            }
        }
        private Tag GetTag(Tag request)
        {
            var id = request?.Id;
            Tag ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetVisibleFields<Tag>(currentUser, "Tag", request.VisibleFields);

            DocEntityTag entity = null;
            if(id.HasValue)
            {
                entity = DocEntityTag.Get(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No Tag found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }
    }
}
