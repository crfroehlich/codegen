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
    public partial class DivisionService : DocServiceBase
    {

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private IQueryable<DocEntityDivision> _ExecSearch(DivisionSearch request, DocQuery query)
        {
            request = InitSearch<Division, DivisionSearch>(request);
            IQueryable<DocEntityDivision> entities = null;
            query.Run( session => 
            {
                entities = query.SelectAll<DocEntityDivision>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new DivisionFullTextSearch(request);
                    entities = GetFullTextSearch<DocEntityDivision,DivisionFullTextSearch>(fts, entities);
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
                if(true == request.Archived?.Any() && currentUser.HasProperty(DocConstantModelName.DIVISION, nameof(Reference.Archived), DocConstantPermission.VIEW))
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
                if(!DocTools.IsNullOrEmpty(request.Client) && !DocTools.IsNullOrEmpty(request.Client.Id))
                {
                    entities = entities.Where(en => en.Client.Id == request.Client.Id );
                }
                if(true == request.ClientIds?.Any())
                {
                    entities = entities.Where(en => en.Client.Id.In(request.ClientIds));
                }
                if(!DocTools.IsNullOrEmpty(request.DefaultLocale) && !DocTools.IsNullOrEmpty(request.DefaultLocale.Id))
                {
                    entities = entities.Where(en => en.DefaultLocale.Id == request.DefaultLocale.Id );
                }
                if(true == request.DefaultLocaleIds?.Any())
                {
                    entities = entities.Where(en => en.DefaultLocale.Id.In(request.DefaultLocaleIds));
                }
                if(true == request.DocumentSetsIds?.Any())
                {
                    entities = entities.Where(en => en.DocumentSets.Any(r => r.Id.In(request.DocumentSetsIds)));
                }
                if(!DocTools.IsNullOrEmpty(request.Name))
                    entities = entities.Where(en => en.Name.Contains(request.Name));
                if(!DocTools.IsNullOrEmpty(request.Names))
                    entities = entities.Where(en => en.Name.In(request.Names));
                if(!DocTools.IsNullOrEmpty(request.Role) && !DocTools.IsNullOrEmpty(request.Role.Id))
                {
                    entities = entities.Where(en => en.Role.Id == request.Role.Id );
                }
                if(true == request.RoleIds?.Any())
                {
                    entities = entities.Where(en => en.Role.Id.In(request.RoleIds));
                }
                if(true == request.UsersIds?.Any())
                {
                    entities = entities.Where(en => en.Users.Any(r => r.Id.In(request.UsersIds)));
                }

                entities = ApplyFilters<DocEntityDivision,DivisionSearch>(request, entities);

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
        public object Post(DivisionSearch request) => Get(request);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Get(DivisionSearch request) => GetSearchResultWithCache<Division,DocEntityDivision,DivisionSearch>(DocConstantModelName.DIVISION, request, _ExecSearch);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Get(Division request) => GetEntityWithCache<Division>(DocConstantModelName.DIVISION, request, GetDivision);



        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private Division _AssignValues(Division request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "Division"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.Select = request.Select ?? new List<string>();

            Division ret = null;
            request = _InitAssignValues<Division>(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            var cacheKey = GetApiCacheKey<Division>(DocConstantModelName.DIVISION, nameof(Division), request);
            
            //First, assign all the variables, do database lookups and conversions
            var pClient = (request.Client?.Id > 0) ? DocEntityClient.Get(request.Client.Id) : null;
            var pDefaultLocale = (request.DefaultLocale?.Id > 0) ? DocEntityLocale.Get(request.DefaultLocale.Id) : null;
            var pDocumentSets = GetVariable<Reference>(request, nameof(request.DocumentSets), request.DocumentSets?.ToList(), request.DocumentSetsIds?.ToList());
            var pName = request.Name;
            var pRole = (request.Role?.Id > 0) ? DocEntityRole.Get(request.Role.Id) : null;
            var pSettings = (DocTools.IsNullOrEmpty(request.Settings)) ? null : DocSerialize<DivisionSettings>.ToString(request.Settings);
            var pUsers = GetVariable<Reference>(request, nameof(request.Users), request.Users?.ToList(), request.UsersIds?.ToList());
            var pArchived = true == request.Archived;
            var pLocked = request.Locked;

            var entity = InitEntity<DocEntityDivision,Division>(request, permission, session);

            if (AllowPatchValue<Division, bool>(request, DocConstantModelName.DIVISION, pArchived, permission, nameof(request.Archived), pArchived != entity.Archived))
            {
                entity.Archived = pArchived;
            }
            if (AllowPatchValue<Division, DocEntityClient>(request, DocConstantModelName.DIVISION, pClient, permission, nameof(request.Client), pClient != entity.Client))
            {
                entity.Client = pClient;
            }
            if (AllowPatchValue<Division, DocEntityLocale>(request, DocConstantModelName.DIVISION, pDefaultLocale, permission, nameof(request.DefaultLocale), pDefaultLocale != entity.DefaultLocale))
            {
                entity.DefaultLocale = pDefaultLocale;
            }
            if (AllowPatchValue<Division, string>(request, DocConstantModelName.DIVISION, pName, permission, nameof(request.Name), pName != entity.Name))
            {
                entity.Name = pName;
            }
            if (AllowPatchValue<Division, DocEntityRole>(request, DocConstantModelName.DIVISION, pRole, permission, nameof(request.Role), pRole != entity.Role))
            {
                entity.Role = pRole;
            }
            if (AllowPatchValue<Division, string>(request, DocConstantModelName.DIVISION, pSettings, permission, nameof(request.Settings), pSettings != entity.Settings))
            {
                entity.Settings = pSettings;
            }
            if (request.Locked && AllowPatchValue<Division, bool>(request, DocConstantModelName.DIVISION, pArchived, permission, nameof(request.Locked), pLocked != entity.Locked))
            {
                entity.Archived = pArchived;
            }
            entity.SaveChanges(permission);

            var idsToInvalidate = new List<int>();
            idsToInvalidate.AddRange(PatchCollection<Division, DocEntityDivision, Reference, DocEntityDocumentSet>(request, entity, pDocumentSets, permission, nameof(request.DocumentSets)));
            idsToInvalidate.AddRange(PatchCollection<Division, DocEntityDivision, Reference, DocEntityUser>(request, entity, pUsers, permission, nameof(request.Users)));
            if (idsToInvalidate.Any())
            {
                idsToInvalidate.Add(entity.Id);
                DocCacheClient.RemoveByEntityIds(idsToInvalidate);
                DocCacheClient.RemoveSearch(DocConstantModelName.DIVISION);
            }

            entity.SaveChanges(permission);
            DocPermissionFactory.SetSelect<Division>(currentUser, nameof(Division), request.Select);
            ret = entity.ToDto();

            var cacheExpires = DocResources.Metadata.GetCacheExpiration(DocConstantModelName.DIVISION);
            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.DIVISION, cacheExpires);

            return ret;
        }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Division Post(Division request)
        {
            if(request == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            request.Select = request.Select ?? new List<string>();

            Division ret = null;

            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "Division")) 
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                    ret = _AssignValues(request, DocConstantPermission.ADD, ssn);
                });
            }
            return ret;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<Division> Post(DivisionBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<Division>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Post(dto) as Division;
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
        public Division Post(DivisionCopy request)
        {
            Division ret = null;
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    var entity = DocEntityDivision.Get(request?.Id);
                    if(null == entity) throw new HttpError(HttpStatusCode.NoContent, "The COPY request did not succeed.");
                    if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD))
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                    var pClient = entity.Client;
                    var pDefaultLocale = entity.DefaultLocale;
                    var pDocumentSets = entity.DocumentSets.ToList();
                    var pName = entity.Name;
                    if(!DocTools.IsNullOrEmpty(pName))
                        pName += " (Copy)";
                    var pRole = entity.Role;
                    var pSettings = entity.Settings;
                    var pUsers = entity.Users.ToList();
                    var copy = new DocEntityDivision(ssn)
                    {
                        Hash = Guid.NewGuid()
                                , Client = pClient
                                , DefaultLocale = pDefaultLocale
                                , Name = pName
                                , Role = pRole
                                , Settings = pSettings
                    };
                            foreach(var item in pDocumentSets)
                            {
                                entity.DocumentSets.Add(item);
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


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<Division> Put(DivisionBatch request)
        {
            return Patch(request);
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Division Put(Division request)
        {
            return Patch(request);
        }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<Division> Patch(DivisionBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<Division>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Patch(dto) as Division;
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
        public Division Patch(Division request)
        {
            if(true != (request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the Division to patch.");
            
            request.Select = request.Select ?? new List<string>();
            
            Division ret = null;
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
        public void Delete(DivisionBatch request)
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
        public void Delete(Division request)
        {
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    if(!(request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, $"No Id provided for delete.");

                    var en = DocEntityDivision.Get(request?.Id);
                    if(null == en) throw new HttpError(HttpStatusCode.NotFound, $"No Division could be found for Id {request?.Id}.");
                    if(en.IsRemoved) return;
                
                    if(!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.DELETE))
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have DELETE permission for this route.");
                
                    en.Remove();

                    DocCacheClient.RemoveSearch(DocConstantModelName.DIVISION);
                    DocCacheClient.RemoveById(request.Id);
                });
            }
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public void Delete(DivisionSearch request)
        {
            var matches = Get(request) as List<Division>;
            if(true != matches?.Any()) throw new HttpError(HttpStatusCode.NotFound, "No matches for request");
            matches.ForEach(match =>
            {
                Delete(match);
            });
        }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Get(DivisionJunction request)
        {
            switch(request.Junction.ToLower().TrimAndPruneSpaces())
            {
                    case "comment":
                        return GetJunctionSearchResult<Division, DocEntityDivision, DocEntityComment, Comment, CommentSearch>((int)request.Id, DocConstantModelName.COMMENT, "Comments", request, (ss) => HostContext.ResolveService<CommentService>(Request)?.Get(ss));
                    case "documentset":
                        return GetJunctionSearchResult<Division, DocEntityDivision, DocEntityDocumentSet, DocumentSet, DocumentSetSearch>((int)request.Id, DocConstantModelName.DOCUMENTSET, "DocumentSets", request, (ss) => HostContext.ResolveService<DocumentSetService>(Request)?.Get(ss));
                    case "favorite":
                        return GetJunctionSearchResult<Division, DocEntityDivision, DocEntityFavorite, Favorite, FavoriteSearch>((int)request.Id, DocConstantModelName.FAVORITE, "Favorites", request, (ss) => HostContext.ResolveService<FavoriteService>(Request)?.Get(ss));
                    case "tag":
                        return GetJunctionSearchResult<Division, DocEntityDivision, DocEntityTag, Tag, TagSearch>((int)request.Id, DocConstantModelName.TAG, "Tags", request, (ss) => HostContext.ResolveService<TagService>(Request)?.Get(ss));
                    case "user":
                        return GetJunctionSearchResult<Division, DocEntityDivision, DocEntityUser, User, UserSearch>((int)request.Id, DocConstantModelName.USER, "Users", request, (ss) => HostContext.ResolveService<UserService>(Request)?.Get(ss));
                default:
                    throw new HttpError(HttpStatusCode.NotFound, $"Route for division/{request.Id}/{request.Junction} was not found");
            }
        }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Post(DivisionJunction request)
        {
            switch(request.Junction.ToLower().TrimAndPruneSpaces())
            {
                    case "comment":
                        return AddJunction<Division, DocEntityDivision, DocEntityComment, Comment, CommentSearch>((int)request.Id, DocConstantModelName.COMMENT, "Comments", request);
                    case "documentset":
                        return AddJunction<Division, DocEntityDivision, DocEntityDocumentSet, DocumentSet, DocumentSetSearch>((int)request.Id, DocConstantModelName.DOCUMENTSET, "DocumentSets", request);
                    case "favorite":
                        return AddJunction<Division, DocEntityDivision, DocEntityFavorite, Favorite, FavoriteSearch>((int)request.Id, DocConstantModelName.FAVORITE, "Favorites", request);
                    case "tag":
                        return AddJunction<Division, DocEntityDivision, DocEntityTag, Tag, TagSearch>((int)request.Id, DocConstantModelName.TAG, "Tags", request);
                    case "user":
                        return AddJunction<Division, DocEntityDivision, DocEntityUser, User, UserSearch>((int)request.Id, DocConstantModelName.USER, "Users", request);
                default:
                    throw new HttpError(HttpStatusCode.NotFound, $"Route for division/{request.Id}/{request.Junction} was not found");
            }
        }

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Delete(DivisionJunction request)
        {    
            switch(request.Junction.ToLower().TrimAndPruneSpaces())
            {
                    case "comment":
                        return RemoveJunction<Division, DocEntityDivision, DocEntityComment, Comment, CommentSearch>((int)request.Id, DocConstantModelName.COMMENT, "Comments", request);
                    case "documentset":
                        return RemoveJunction<Division, DocEntityDivision, DocEntityDocumentSet, DocumentSet, DocumentSetSearch>((int)request.Id, DocConstantModelName.DOCUMENTSET, "DocumentSets", request);
                    case "favorite":
                        return RemoveJunction<Division, DocEntityDivision, DocEntityFavorite, Favorite, FavoriteSearch>((int)request.Id, DocConstantModelName.FAVORITE, "Favorites", request);
                    case "tag":
                        return RemoveJunction<Division, DocEntityDivision, DocEntityTag, Tag, TagSearch>((int)request.Id, DocConstantModelName.TAG, "Tags", request);
                    case "user":
                        return RemoveJunction<Division, DocEntityDivision, DocEntityUser, User, UserSearch>((int)request.Id, DocConstantModelName.USER, "Users", request);
                default:
                    throw new HttpError(HttpStatusCode.NotFound, $"Route for division/{request.Id}/{request.Junction} was not found");
            }
        }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private Division GetDivision(Division request)
        {
            var id = request?.Id;
            Division ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetSelect<Division>(currentUser, "Division", request.Select);

            DocEntityDivision entity = null;
            if(id.HasValue)
            {
                entity = DocEntityDivision.Get(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No Division found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }

    }
}
