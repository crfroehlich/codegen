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
    public partial class UserTypeService : DocServiceBase
    {

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private IQueryable<DocEntityUserType> _ExecSearch(UserTypeSearch request, DocQuery query)
        {
            request = InitSearch<UserType, UserTypeSearch>(request);
            IQueryable<DocEntityUserType> entities = null;
            query.Run( session => 
            {
                entities = query.SelectAll<DocEntityUserType>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new UserTypeFullTextSearch(request);
                    entities = GetFullTextSearch<DocEntityUserType,UserTypeFullTextSearch>(fts, entities);
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
                if(true == request.Archived?.Any() && currentUser.HasProperty(DocConstantModelName.USERTYPE, nameof(Reference.Archived), DocConstantPermission.VIEW))
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
                if(!DocTools.IsNullOrEmpty(request.PayrollStatus) && !DocTools.IsNullOrEmpty(request.PayrollStatus.Id))
                {
                    entities = entities.Where(en => en.PayrollStatus.Id == request.PayrollStatus.Id );
                }
                if(true == request.PayrollStatusIds?.Any())
                {
                    entities = entities.Where(en => en.PayrollStatus.Id.In(request.PayrollStatusIds));
                }
                else if(!DocTools.IsNullOrEmpty(request.PayrollStatus) && !DocTools.IsNullOrEmpty(request.PayrollStatus.Name))
                {
                    entities = entities.Where(en => en.PayrollStatus.Name == request.PayrollStatus.Name );
                }
                if(true == request.PayrollStatusNames?.Any())
                {
                    entities = entities.Where(en => en.PayrollStatus.Name.In(request.PayrollStatusNames));
                }
                if(!DocTools.IsNullOrEmpty(request.PayrollType) && !DocTools.IsNullOrEmpty(request.PayrollType.Id))
                {
                    entities = entities.Where(en => en.PayrollType.Id == request.PayrollType.Id );
                }
                if(true == request.PayrollTypeIds?.Any())
                {
                    entities = entities.Where(en => en.PayrollType.Id.In(request.PayrollTypeIds));
                }
                else if(!DocTools.IsNullOrEmpty(request.PayrollType) && !DocTools.IsNullOrEmpty(request.PayrollType.Name))
                {
                    entities = entities.Where(en => en.PayrollType.Name == request.PayrollType.Name );
                }
                if(true == request.PayrollTypeNames?.Any())
                {
                    entities = entities.Where(en => en.PayrollType.Name.In(request.PayrollTypeNames));
                }
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
                if(true == request.UsersIds?.Any())
                {
                    entities = entities.Where(en => en.Users.Any(r => r.Id.In(request.UsersIds)));
                }

                entities = ApplyFilters<DocEntityUserType,UserTypeSearch>(request, entities);

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
        public object Post(UserTypeSearch request) => Get(request);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Get(UserTypeSearch request) => GetSearchResultWithCache<UserType,DocEntityUserType,UserTypeSearch>(DocConstantModelName.USERTYPE, request, _ExecSearch);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Get(UserType request) => GetEntityWithCache<UserType>(DocConstantModelName.USERTYPE, request, GetUserType);



        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private UserType _AssignValues(UserType request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "UserType"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.Select = request.Select ?? new List<string>();

            UserType ret = null;
            request = _InitAssignValues<UserType>(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            var cacheKey = GetApiCacheKey<UserType>(DocConstantModelName.USERTYPE, nameof(UserType), request);
            
            //First, assign all the variables, do database lookups and conversions
            DocEntityLookupTable pPayrollStatus = GetLookup(DocConstantLookupTable.USERPAYROLLSTATUS, request.PayrollStatus?.Name, request.PayrollStatus?.Id);
            DocEntityLookupTable pPayrollType = GetLookup(DocConstantLookupTable.USERPAYROLLTYPE, request.PayrollType?.Name, request.PayrollType?.Id);
            DocEntityLookupTable pType = GetLookup(DocConstantLookupTable.USEREMPLOYEETYPE, request.Type?.Name, request.Type?.Id);
            var pUsers = GetVariable<Reference>(request, nameof(request.Users), request.Users?.ToList(), request.UsersIds?.ToList());
            var pArchived = true == request.Archived;
            var pLocked = request.Locked;

            var entity = InitEntity<DocEntityUserType,UserType>(request, permission, session);

            if (AllowPatchValue<UserType, bool>(request, DocConstantModelName.USERTYPE, pArchived, permission, nameof(request.Archived), pArchived != entity.Archived))
            {
                entity.Archived = pArchived;
            }
            if (AllowPatchValue<UserType, DocEntityLookupTable>(request, DocConstantModelName.USERTYPE, pPayrollStatus, permission, nameof(request.PayrollStatus), pPayrollStatus != entity.PayrollStatus))
            {
                entity.PayrollStatus = pPayrollStatus;
            }
            if (AllowPatchValue<UserType, DocEntityLookupTable>(request, DocConstantModelName.USERTYPE, pPayrollType, permission, nameof(request.PayrollType), pPayrollType != entity.PayrollType))
            {
                entity.PayrollType = pPayrollType;
            }
            if (AllowPatchValue<UserType, DocEntityLookupTable>(request, DocConstantModelName.USERTYPE, pType, permission, nameof(request.Type), pType != entity.Type))
            {
                entity.Type = pType;
            }
            if (request.Locked && AllowPatchValue<UserType, bool>(request, DocConstantModelName.USERTYPE, pArchived, permission, nameof(request.Locked), pLocked != entity.Locked))
            {
                entity.Archived = pArchived;
            }
            entity.SaveChanges(permission);

            var idsToInvalidate = new List<int>();
            idsToInvalidate.AddRange(PatchCollection<UserType, DocEntityUserType, Reference, DocEntityUser>(request, entity, pUsers, permission, nameof(request.Users)));
            if (idsToInvalidate.Any())
            {
                idsToInvalidate.Add(entity.Id);
                DocCacheClient.RemoveByEntityIds(idsToInvalidate);
                DocCacheClient.RemoveSearch(DocConstantModelName.USERTYPE);
            }

            DocPermissionFactory.SetSelect<UserType>(currentUser, nameof(UserType), request.Select);
            ret = entity.ToDto();

            var cacheExpires = DocResources.Metadata.GetCacheExpiration(DocConstantModelName.USERTYPE);
            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.USERTYPE, cacheExpires);

            return ret;
        }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public UserType Post(UserType request)
        {
            if(request == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            request.Select = request.Select ?? new List<string>();

            UserType ret = null;

            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "UserType")) 
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                    ret = _AssignValues(request, DocConstantPermission.ADD, ssn);
                });
            }
            return ret;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<UserType> Post(UserTypeBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<UserType>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Post(dto) as UserType;
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
        public UserType Post(UserTypeCopy request)
        {
            UserType ret = null;
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    var entity = DocEntityUserType.Get(request?.Id);
                    if(null == entity) throw new HttpError(HttpStatusCode.NoContent, "The COPY request did not succeed.");
                    if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD))
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                    var pPayrollStatus = entity.PayrollStatus;
                    var pPayrollType = entity.PayrollType;
                    var pType = entity.Type;
                    var pUsers = entity.Users.ToList();
                    var copy = new DocEntityUserType(ssn)
                    {
                        Hash = Guid.NewGuid()
                                , PayrollStatus = pPayrollStatus
                                , PayrollType = pPayrollType
                                , Type = pType
                    };
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


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<UserType> Put(UserTypeBatch request)
        {
            return Patch(request);
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public UserType Put(UserType request)
        {
            return Patch(request);
        }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<UserType> Patch(UserTypeBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<UserType>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Patch(dto) as UserType;
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
        public UserType Patch(UserType request)
        {
            if(true != (request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the UserType to patch.");
            
            request.Select = request.Select ?? new List<string>();
            
            UserType ret = null;
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
        public void Delete(UserTypeBatch request)
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
        public void Delete(UserType request)
        {
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    if(!(request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, $"No Id provided for delete.");

                    var en = DocEntityUserType.Get(request?.Id);
                    if(null == en) throw new HttpError(HttpStatusCode.NotFound, $"No UserType could be found for Id {request?.Id}.");
                    if(en.IsRemoved) return;
                
                    if(!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.DELETE))
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have DELETE permission for this route.");
                
                    en.Remove();

                    DocCacheClient.RemoveSearch(DocConstantModelName.USERTYPE);
                    DocCacheClient.RemoveById(request.Id);
                });
            }
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public void Delete(UserTypeSearch request)
        {
            var matches = Get(request) as List<UserType>;
            if(true != matches?.Any()) throw new HttpError(HttpStatusCode.NotFound, "No matches for request");
            matches.ForEach(match =>
            {
                Delete(match);
            });
        }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Get(UserTypeJunction request)
        {
            switch(request.Junction.ToLower().TrimAndPruneSpaces())
            {
                    case "comment":
                        return GetJunctionSearchResult<UserType, DocEntityUserType, DocEntityComment, Comment, CommentSearch>((int)request.Id, DocConstantModelName.COMMENT, "Comments", request, (ss) => HostContext.ResolveService<CommentService>(Request)?.Get(ss));
                    case "favorite":
                        return GetJunctionSearchResult<UserType, DocEntityUserType, DocEntityFavorite, Favorite, FavoriteSearch>((int)request.Id, DocConstantModelName.FAVORITE, "Favorites", request, (ss) => HostContext.ResolveService<FavoriteService>(Request)?.Get(ss));
                    case "tag":
                        return GetJunctionSearchResult<UserType, DocEntityUserType, DocEntityTag, Tag, TagSearch>((int)request.Id, DocConstantModelName.TAG, "Tags", request, (ss) => HostContext.ResolveService<TagService>(Request)?.Get(ss));
                    case "user":
                        return GetJunctionSearchResult<UserType, DocEntityUserType, DocEntityUser, User, UserSearch>((int)request.Id, DocConstantModelName.USER, "Users", request, (ss) => HostContext.ResolveService<UserService>(Request)?.Get(ss));
                default:
                    throw new HttpError(HttpStatusCode.NotFound, $"Route for usertype/{request.Id}/{request.Junction} was not found");
            }
        }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Post(UserTypeJunction request)
        {
            switch(request.Junction.ToLower().TrimAndPruneSpaces())
            {
                    case "comment":
                        return AddJunction<UserType, DocEntityUserType, DocEntityComment, Comment, CommentSearch>((int)request.Id, DocConstantModelName.COMMENT, "Comments", request);
                    case "favorite":
                        return AddJunction<UserType, DocEntityUserType, DocEntityFavorite, Favorite, FavoriteSearch>((int)request.Id, DocConstantModelName.FAVORITE, "Favorites", request);
                    case "tag":
                        return AddJunction<UserType, DocEntityUserType, DocEntityTag, Tag, TagSearch>((int)request.Id, DocConstantModelName.TAG, "Tags", request);
                    case "user":
                        return AddJunction<UserType, DocEntityUserType, DocEntityUser, User, UserSearch>((int)request.Id, DocConstantModelName.USER, "Users", request);
                default:
                    throw new HttpError(HttpStatusCode.NotFound, $"Route for usertype/{request.Id}/{request.Junction} was not found");
            }
        }

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Delete(UserTypeJunction request)
        {    
            switch(request.Junction.ToLower().TrimAndPruneSpaces())
            {
                    case "comment":
                        return RemoveJunction<UserType, DocEntityUserType, DocEntityComment, Comment, CommentSearch>((int)request.Id, DocConstantModelName.COMMENT, "Comments", request);
                    case "favorite":
                        return RemoveJunction<UserType, DocEntityUserType, DocEntityFavorite, Favorite, FavoriteSearch>((int)request.Id, DocConstantModelName.FAVORITE, "Favorites", request);
                    case "tag":
                        return RemoveJunction<UserType, DocEntityUserType, DocEntityTag, Tag, TagSearch>((int)request.Id, DocConstantModelName.TAG, "Tags", request);
                    case "user":
                        return RemoveJunction<UserType, DocEntityUserType, DocEntityUser, User, UserSearch>((int)request.Id, DocConstantModelName.USER, "Users", request);
                default:
                    throw new HttpError(HttpStatusCode.NotFound, $"Route for usertype/{request.Id}/{request.Junction} was not found");
            }
        }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private UserType GetUserType(UserType request)
        {
            var id = request?.Id;
            UserType ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetSelect<UserType>(currentUser, "UserType", request.Select);

            DocEntityUserType entity = null;
            if(id.HasValue)
            {
                entity = DocEntityUserType.Get(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No UserType found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }

    }
}
