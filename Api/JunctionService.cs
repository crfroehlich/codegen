
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
    public partial class JunctionService : DocServiceBase
    {

        private IQueryable<DocEntityJunction> _ExecSearch(JunctionSearch request, DocQuery query)
        {
            request = InitSearch<Junction, JunctionSearch>(request);
            IQueryable<DocEntityJunction> entities = null;
            query.Run( session => 
            {
                entities = query.SelectAll<DocEntityJunction>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new JunctionFullTextSearch(request);
                    entities = GetFullTextSearch<DocEntityJunction,JunctionFullTextSearch>(fts, entities);
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
                if(true == request.Archived?.Any() && currentUser.HasProperty(DocConstantModelName.JUNCTION, nameof(Reference.Archived), DocConstantPermission.VIEW))
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
                if(true == request.ChildrenIds?.Any())
                {
                    entities = entities.Where(en => en.Children.Any(r => r.Id.In(request.ChildrenIds)));
                }
                if(request.OwnerId.HasValue)
                    entities = entities.Where(en => request.OwnerId.Value == en.OwnerId);
                if(!DocTools.IsNullOrEmpty(request.OwnerType))
                    entities = entities.Where(en => en.OwnerType.Contains(request.OwnerType));
                if(!DocTools.IsNullOrEmpty(request.OwnerTypes))
                    entities = entities.Where(en => en.OwnerType.In(request.OwnerTypes));
                if(!DocTools.IsNullOrEmpty(request.Parent) && !DocTools.IsNullOrEmpty(request.Parent.Id))
                {
                    entities = entities.Where(en => en.Parent.Id == request.Parent.Id );
                }
                if(true == request.ParentIds?.Any())
                {
                    entities = entities.Where(en => en.Parent.Id.In(request.ParentIds));
                }
                if(request.TargetId.HasValue)
                    entities = entities.Where(en => request.TargetId.Value == en.TargetId);
                if(!DocTools.IsNullOrEmpty(request.TargetType))
                    entities = entities.Where(en => en.TargetType.Contains(request.TargetType));
                if(!DocTools.IsNullOrEmpty(request.TargetTypes))
                    entities = entities.Where(en => en.TargetType.In(request.TargetTypes));
                if(!DocTools.IsNullOrEmpty(request.Type) && !DocTools.IsNullOrEmpty(request.Type.Id))
                {
                    entities = entities.Where(en => en.Type.Id == request.Type.Id );
                }
                if(true == request.TypeIds?.Any())
                {
                    entities = entities.Where(en => en.Type.Id.In(request.TypeIds));
                }
                else if(!DocTools.IsNullOrEmpty(request.Type) && !DocTools.IsNullOrEmpty(request.Type.Name))
                {
                    entities = entities.Where(en => en.Type.Name == request.Type.Name );
                }
                if(true == request.TypeNames?.Any())
                {
                    entities = entities.Where(en => en.Type.Name.In(request.TypeNames));
                }
                if(!DocTools.IsNullOrEmpty(request.User) && !DocTools.IsNullOrEmpty(request.User.Id))
                {
                    entities = entities.Where(en => en.User.Id == request.User.Id );
                }
                if(true == request.UserIds?.Any())
                {
                    entities = entities.Where(en => en.User.Id.In(request.UserIds));
                }

                entities = ApplyFilters<DocEntityJunction,JunctionSearch>(request, entities);

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

        public object Post(JunctionSearch request) => Get(request);

        public object Get(JunctionSearch request) => GetSearchResultWithCache<Junction,DocEntityJunction,JunctionSearch>(DocConstantModelName.JUNCTION, request, _ExecSearch);

        public object Get(Junction request) => GetEntityWithCache<Junction>(DocConstantModelName.JUNCTION, request, GetJunction);



        private Junction _AssignValues(Junction request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "Junction"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.Select = request.Select ?? new List<string>();

            Junction ret = null;
            request = _InitAssignValues<Junction>(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            var cacheKey = GetApiCacheKey<Junction>(DocConstantModelName.JUNCTION, nameof(Junction), request);
            
            //First, assign all the variables, do database lookups and conversions
            var pChildren = GetVariable<Reference>(request, nameof(request.Children), request.Children?.ToList(), request.ChildrenIds?.ToList());
            var pData = request.Data;
            var pOwnerId = request.OwnerId;
            var pOwnerType = request.OwnerType;
            var pParent = (request.Parent?.Id > 0) ? DocEntityJunction.Get(request.Parent.Id) : null;
            var pTargetId = request.TargetId;
            var pTargetType = request.TargetType;
            DocEntityLookupTable pType = GetLookup(DocConstantLookupTable.JUNCTIONTYPE, request.Type?.Name, request.Type?.Id);
            var pUser = (request.User?.Id > 0) ? DocEntityUser.Get(request.User.Id) : null;
            var pArchived = true == request.Archived;
            var pLocked = request.Locked;

            var entity = InitEntity<DocEntityJunction,Junction>(request, permission, session);

            if (AllowPatchValue<Junction, bool>(request, DocConstantModelName.JUNCTION, pArchived, permission, nameof(request.Archived), pArchived != entity.Archived))
            {
                entity.Archived = pArchived;
            }
            if (AllowPatchValue<Junction, string>(request, DocConstantModelName.JUNCTION, pData, permission, nameof(request.Data), pData != entity.Data))
            {
                entity.Data = pData;
            }
            if (AllowPatchValue<Junction, int?>(request, DocConstantModelName.JUNCTION, pOwnerId, permission, nameof(request.OwnerId), pOwnerId != entity.OwnerId))
            {
                entity.OwnerId = pOwnerId;
            }
            if (AllowPatchValue<Junction, string>(request, DocConstantModelName.JUNCTION, pOwnerType, permission, nameof(request.OwnerType), pOwnerType != entity.OwnerType))
            {
                entity.OwnerType = pOwnerType;
            }
            if (AllowPatchValue<Junction, DocEntityJunction>(request, DocConstantModelName.JUNCTION, pParent, permission, nameof(request.Parent), pParent != entity.Parent))
            {
                entity.Parent = pParent;
            }
            if (AllowPatchValue<Junction, int?>(request, DocConstantModelName.JUNCTION, pTargetId, permission, nameof(request.TargetId), pTargetId != entity.TargetId))
            {
                entity.TargetId = pTargetId;
            }
            if (AllowPatchValue<Junction, string>(request, DocConstantModelName.JUNCTION, pTargetType, permission, nameof(request.TargetType), pTargetType != entity.TargetType))
            {
                entity.TargetType = pTargetType;
            }
            if (AllowPatchValue<Junction, DocEntityLookupTable>(request, DocConstantModelName.JUNCTION, pType, permission, nameof(request.Type), pType != entity.Type))
            {
                entity.Type = pType;
            }
            if (AllowPatchValue<Junction, DocEntityUser>(request, DocConstantModelName.JUNCTION, pUser, permission, nameof(request.User), pUser != entity.User))
            {
                entity.User = pUser;
            }
            if (request.Locked && AllowPatchValue<Junction, bool>(request, DocConstantModelName.JUNCTION, pArchived, permission, nameof(request.Locked), pLocked != entity.Locked))
            {
                entity.Archived = pArchived;
            }
            entity.SaveChanges(permission);

            var idsToInvalidate = new List<int>();
            idsToInvalidate.AddRange(PatchCollection<Junction, DocEntityJunction, Reference, DocEntityJunction>(request, entity, pChildren, permission, nameof(request.Children)));
            if (idsToInvalidate.Any())
            {
                idsToInvalidate.Add(entity.Id);
                DocCacheClient.RemoveByEntityIds(idsToInvalidate);
                DocCacheClient.RemoveSearch(DocConstantModelName.JUNCTION);
            }

            DocPermissionFactory.SetSelect<Junction>(currentUser, nameof(Junction), request.Select);
            ret = entity.ToDto();

            var cacheExpires = DocResources.Metadata.GetCacheExpiration(DocConstantModelName.JUNCTION);
            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.JUNCTION, cacheExpires);

            return ret;
        }


        public Junction Post(Junction request)
        {
            if(request == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            request.Select = request.Select ?? new List<string>();

            Junction ret = null;

            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "Junction")) 
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                    ret = _AssignValues(request, DocConstantPermission.ADD, ssn);
                });
            }
            return ret;
        }
   
        public List<Junction> Post(JunctionBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<Junction>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Post(dto) as Junction;
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

        public Junction Post(JunctionCopy request)
        {
            Junction ret = null;
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    var entity = DocEntityJunction.Get(request?.Id);
                    if(null == entity) throw new HttpError(HttpStatusCode.NoContent, "The COPY request did not succeed.");
                    if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD))
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                    var pChildren = entity.Children.ToList();
                    var pData = entity.Data;
                    var pOwnerId = entity.OwnerId;
                    var pOwnerType = entity.OwnerType;
                    if(!DocTools.IsNullOrEmpty(pOwnerType))
                        pOwnerType += " (Copy)";
                    var pParent = entity.Parent;
                    var pTargetId = entity.TargetId;
                    var pTargetType = entity.TargetType;
                    if(!DocTools.IsNullOrEmpty(pTargetType))
                        pTargetType += " (Copy)";
                    var pType = entity.Type;
                    var pUser = entity.User;
                    var copy = new DocEntityJunction(ssn)
                    {
                        Hash = Guid.NewGuid()
                                , Data = pData
                                , OwnerId = pOwnerId
                                , OwnerType = pOwnerType
                                , Parent = pParent
                                , TargetId = pTargetId
                                , TargetType = pTargetType
                                , Type = pType
                                , User = pUser
                    };
                            foreach(var item in pChildren)
                            {
                                entity.Children.Add(item);
                            }

                    copy.SaveChanges(DocConstantPermission.ADD);
                    ret = copy.ToDto();
                });
            }
            return ret;
        }



        public List<Junction> Put(JunctionBatch request)
        {
            return Patch(request);
        }

        public Junction Put(Junction request)
        {
            return Patch(request);
        }


        public List<Junction> Patch(JunctionBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<Junction>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Patch(dto) as Junction;
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

        public Junction Patch(Junction request)
        {
            if(true != (request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the Junction to patch.");
            
            request.Select = request.Select ?? new List<string>();
            
            Junction ret = null;
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    ret = _AssignValues(request, DocConstantPermission.EDIT, ssn);
                });
            }
            return ret;
        }


        public void Delete(JunctionBatch request)
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

        public void Delete(Junction request)
        {
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    if(!(request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, $"No Id provided for delete.");

                    var en = DocEntityJunction.Get(request?.Id);
                    if(null == en) throw new HttpError(HttpStatusCode.NotFound, $"No Junction could be found for Id {request?.Id}.");
                    if(en.IsRemoved) return;
                
                    if(!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.DELETE))
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have DELETE permission for this route.");
                
                    en.Remove();

                    DocCacheClient.RemoveSearch(DocConstantModelName.JUNCTION);
                    DocCacheClient.RemoveById(request.Id);
                });
            }
        }

        public void Delete(JunctionSearch request)
        {
            var matches = Get(request) as List<Junction>;
            if(true != matches?.Any()) throw new HttpError(HttpStatusCode.NotFound, "No matches for request");
            matches.ForEach(match =>
            {
                Delete(match);
            });
        }


        public object Get(JunctionJunction request)
        {
            switch(request.Junction.ToLower().TrimAndPruneSpaces())
            {
                    case "junction":
                        return GetJunctionSearchResult<Junction, DocEntityJunction, DocEntityJunction, Junction, JunctionSearch>((int)request.Id, DocConstantModelName.JUNCTION, "Children", request, (ss) => HostContext.ResolveService<JunctionService>(Request)?.Get(ss));
                    case "comment":
                        return GetJunctionSearchResult<Junction, DocEntityJunction, DocEntityComment, Comment, CommentSearch>((int)request.Id, DocConstantModelName.COMMENT, "Comments", request, (ss) => HostContext.ResolveService<CommentService>(Request)?.Get(ss));
                    case "favorite":
                        return GetJunctionSearchResult<Junction, DocEntityJunction, DocEntityFavorite, Favorite, FavoriteSearch>((int)request.Id, DocConstantModelName.FAVORITE, "Favorites", request, (ss) => HostContext.ResolveService<FavoriteService>(Request)?.Get(ss));
                    case "tag":
                        return GetJunctionSearchResult<Junction, DocEntityJunction, DocEntityTag, Tag, TagSearch>((int)request.Id, DocConstantModelName.TAG, "Tags", request, (ss) => HostContext.ResolveService<TagService>(Request)?.Get(ss));
                default:
                    throw new HttpError(HttpStatusCode.NotFound, $"Route for junction/{request.Id}/{request.Junction} was not found");
            }
        }


        public object Post(JunctionJunction request)
        {
            switch(request.Junction.ToLower().TrimAndPruneSpaces())
            {
                    case "junction":
                        return AddJunction<Junction, DocEntityJunction, DocEntityJunction, Junction, JunctionSearch>((int)request.Id, DocConstantModelName.JUNCTION, "Children", request);
                    case "comment":
                        return AddJunction<Junction, DocEntityJunction, DocEntityComment, Comment, CommentSearch>((int)request.Id, DocConstantModelName.COMMENT, "Comments", request);
                    case "favorite":
                        return AddJunction<Junction, DocEntityJunction, DocEntityFavorite, Favorite, FavoriteSearch>((int)request.Id, DocConstantModelName.FAVORITE, "Favorites", request);
                    case "tag":
                        return AddJunction<Junction, DocEntityJunction, DocEntityTag, Tag, TagSearch>((int)request.Id, DocConstantModelName.TAG, "Tags", request);
                default:
                    throw new HttpError(HttpStatusCode.NotFound, $"Route for junction/{request.Id}/{request.Junction} was not found");
            }
        }

        public object Delete(JunctionJunction request)
        {    
            switch(request.Junction.ToLower().TrimAndPruneSpaces())
            {
                    case "junction":
                        return RemoveJunction<Junction, DocEntityJunction, DocEntityJunction, Junction, JunctionSearch>((int)request.Id, DocConstantModelName.JUNCTION, "Children", request);
                    case "comment":
                        return RemoveJunction<Junction, DocEntityJunction, DocEntityComment, Comment, CommentSearch>((int)request.Id, DocConstantModelName.COMMENT, "Comments", request);
                    case "favorite":
                        return RemoveJunction<Junction, DocEntityJunction, DocEntityFavorite, Favorite, FavoriteSearch>((int)request.Id, DocConstantModelName.FAVORITE, "Favorites", request);
                    case "tag":
                        return RemoveJunction<Junction, DocEntityJunction, DocEntityTag, Tag, TagSearch>((int)request.Id, DocConstantModelName.TAG, "Tags", request);
                default:
                    throw new HttpError(HttpStatusCode.NotFound, $"Route for junction/{request.Id}/{request.Junction} was not found");
            }
        }


        private Junction GetJunction(Junction request)
        {
            var id = request?.Id;
            Junction ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetSelect<Junction>(currentUser, "Junction", request.Select);

            DocEntityJunction entity = null;
            if(id.HasValue)
            {
                entity = DocEntityJunction.Get(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No Junction found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }

    }
}
