
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
    public partial class TermSynonymService : DocServiceBase
    {

        private IQueryable<DocEntityTermSynonym> _ExecSearch(TermSynonymSearch request, DocQuery query)
        {
            request = InitSearch<TermSynonym, TermSynonymSearch>(request);
            IQueryable<DocEntityTermSynonym> entities = null;
            query.Run( session => 
            {
                entities = query.SelectAll<DocEntityTermSynonym>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new TermSynonymFullTextSearch(request);
                    entities = GetFullTextSearch<DocEntityTermSynonym,TermSynonymFullTextSearch>(fts, entities);
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
                if(true == request.Archived?.Any() && currentUser.HasProperty(DocConstantModelName.TERMSYNONYM, nameof(Reference.Archived), DocConstantPermission.VIEW))
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
                if(true == request.Approved?.Any())
                {
                    if(request.Approved.Any(v => v == null)) entities = entities.Where(en => en.Approved.In(request.Approved) || en.Approved == null);
                    else entities = entities.Where(en => en.Approved.In(request.Approved));
                }
                if(true == request.BindingsIds?.Any())
                {
                    entities = entities.Where(en => en.Bindings.Any(r => r.Id.In(request.BindingsIds)));
                }
                if(!DocTools.IsNullOrEmpty(request.Master) && !DocTools.IsNullOrEmpty(request.Master.Id))
                {
                    entities = entities.Where(en => en.Master.Id == request.Master.Id );
                }
                if(true == request.MasterIds?.Any())
                {
                    entities = entities.Where(en => en.Master.Id.In(request.MasterIds));
                }
                if(true == request.Preferred?.Any())
                {
                    if(request.Preferred.Any(v => v == null)) entities = entities.Where(en => en.Preferred.In(request.Preferred) || en.Preferred == null);
                    else entities = entities.Where(en => en.Preferred.In(request.Preferred));
                }
                if(!DocTools.IsNullOrEmpty(request.Scope) && !DocTools.IsNullOrEmpty(request.Scope.Id))
                {
                    entities = entities.Where(en => en.Scope.Id == request.Scope.Id );
                }
                if(true == request.ScopeIds?.Any())
                {
                    entities = entities.Where(en => en.Scope.Id.In(request.ScopeIds));
                }
                if(!DocTools.IsNullOrEmpty(request.Synonym))
                    entities = entities.Where(en => en.Synonym.Contains(request.Synonym));
                if(!DocTools.IsNullOrEmpty(request.Synonyms))
                    entities = entities.Where(en => en.Synonym.In(request.Synonyms));

                entities = ApplyFilters<DocEntityTermSynonym,TermSynonymSearch>(request, entities);

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

        public object Post(TermSynonymSearch request) => Get(request);

        public object Get(TermSynonymSearch request) => GetSearchResultWithCache<TermSynonym,DocEntityTermSynonym,TermSynonymSearch>(DocConstantModelName.TERMSYNONYM, request, _ExecSearch);

        public object Get(TermSynonym request) => GetEntityWithCache<TermSynonym>(DocConstantModelName.TERMSYNONYM, request, GetTermSynonym);



        private TermSynonym _AssignValues(TermSynonym request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "TermSynonym"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.Select = request.Select ?? new List<string>();

            TermSynonym ret = null;
            request = _InitAssignValues<TermSynonym>(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            var cacheKey = GetApiCacheKey<TermSynonym>(DocConstantModelName.TERMSYNONYM, nameof(TermSynonym), request);
            
            //First, assign all the variables, do database lookups and conversions
            var pApproved = request.Approved;
            var pBindings = GetVariable<Reference>(request, nameof(request.Bindings), request.Bindings?.ToList(), request.BindingsIds?.ToList());
            var pMaster = (request.Master?.Id > 0) ? DocEntityTermMaster.Get(request.Master.Id) : null;
            var pPreferred = request.Preferred;
            var pScope = (request.Scope?.Id > 0) ? DocEntityScope.Get(request.Scope.Id) : null;
            var pSynonym = request.Synonym;

            DocEntityTermSynonym entity = null;
            if(permission == DocConstantPermission.ADD)
            {
                var now = DateTime.UtcNow;
                entity = new DocEntityTermSynonym(session)
                {
                    Created = now,
                    Updated = now
                };
            }
            else
            {
                entity = DocEntityTermSynonym.Get(request.Id);
                if(null == entity)
                    throw new HttpError(HttpStatusCode.NotFound, $"No record");
            }

            //Special case for Archived
            var pArchived = true == request.Archived;
            if (PatchValue<TermSynonym, bool>(request, DocConstantModelName.TERMSYNONYM, pArchived, entity.Archived, permission, nameof(request.Archived), pArchived != entity.Archived))
            {
                entity.Archived = pArchived;
            }
            if (PatchValue<TermSynonym, bool>(request, DocConstantModelName.TERMSYNONYM, pApproved, entity.Approved, permission, nameof(request.Approved), pApproved != entity.Approved))
            {
                entity.Approved = pApproved;
            }
            if (PatchValue<TermSynonym, DocEntityTermMaster>(request, DocConstantModelName.TERMSYNONYM, pMaster, entity.Master, permission, nameof(request.Master), pMaster != entity.Master))
            {
                entity.Master = pMaster;
            }
            if (PatchValue<TermSynonym, bool>(request, DocConstantModelName.TERMSYNONYM, pPreferred, entity.Preferred, permission, nameof(request.Preferred), pPreferred != entity.Preferred))
            {
                entity.Preferred = pPreferred;
            }
            if (PatchValue<TermSynonym, DocEntityScope>(request, DocConstantModelName.TERMSYNONYM, pScope, entity.Scope, permission, nameof(request.Scope), pScope != entity.Scope))
            {
                entity.Scope = pScope;
            }
            if (PatchValue<TermSynonym, string>(request, DocConstantModelName.TERMSYNONYM, pSynonym, entity.Synonym, permission, nameof(request.Synonym), pSynonym != entity.Synonym))
            {
                entity.Synonym = pSynonym;
            }

            if (request.Locked) entity.Locked = request.Locked;

            entity.SaveChanges(permission);

            var idsToInvalidate = new List<int>();
            idsToInvalidate.AddRange(PatchCollection<TermSynonym, DocEntityTermSynonym, Reference, DocEntityLookupTableBinding>(request, entity, pBindings, permission, nameof(request.Bindings)));
            if (idsToInvalidate.Any())
            {
                idsToInvalidate.Add(entity.Id);
                DocCacheClient.RemoveByEntityIds(idsToInvalidate);
                DocCacheClient.RemoveSearch(DocConstantModelName.TERMSYNONYM);
            }

            DocPermissionFactory.SetSelect<TermSynonym>(currentUser, nameof(TermSynonym), request.Select);
            ret = entity.ToDto();

            var cacheExpires = DocResources.Metadata.GetCacheExpiration(DocConstantModelName.TERMSYNONYM);
            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.TERMSYNONYM, cacheExpires);

            return ret;
        }


        public TermSynonym Post(TermSynonym request)
        {
            if(request == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            request.Select = request.Select ?? new List<string>();

            TermSynonym ret = null;

            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "TermSynonym")) 
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                    ret = _AssignValues(request, DocConstantPermission.ADD, ssn);
                });
            }
            return ret;
        }
   
        public List<TermSynonym> Post(TermSynonymBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<TermSynonym>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Post(dto) as TermSynonym;
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

        public TermSynonym Post(TermSynonymCopy request)
        {
            TermSynonym ret = null;
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    var entity = DocEntityTermSynonym.Get(request?.Id);
                    if(null == entity) throw new HttpError(HttpStatusCode.NoContent, "The COPY request did not succeed.");
                    if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD))
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                    var pApproved = entity.Approved;
                    var pBindings = entity.Bindings.ToList();
                    var pMaster = entity.Master;
                    var pPreferred = entity.Preferred;
                    var pScope = entity.Scope;
                    var pSynonym = entity.Synonym;
                    if(!DocTools.IsNullOrEmpty(pSynonym))
                        pSynonym += " (Copy)";
                    var copy = new DocEntityTermSynonym(ssn)
                    {
                        Hash = Guid.NewGuid()
                                , Approved = pApproved
                                , Master = pMaster
                                , Preferred = pPreferred
                                , Scope = pScope
                                , Synonym = pSynonym
                    };
                            foreach(var item in pBindings)
                            {
                                entity.Bindings.Add(item);
                            }

                    copy.SaveChanges(DocConstantPermission.ADD);
                    ret = copy.ToDto();
                });
            }
            return ret;
        }



        public List<TermSynonym> Put(TermSynonymBatch request)
        {
            return Patch(request);
        }

        public TermSynonym Put(TermSynonym request)
        {
            return Patch(request);
        }


        public List<TermSynonym> Patch(TermSynonymBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<TermSynonym>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Patch(dto) as TermSynonym;
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

        public TermSynonym Patch(TermSynonym request)
        {
            if(true != (request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the TermSynonym to patch.");
            
            request.Select = request.Select ?? new List<string>();
            
            TermSynonym ret = null;
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    ret = _AssignValues(request, DocConstantPermission.EDIT, ssn);
                });
            }
            return ret;
        }


        public void Delete(TermSynonymBatch request)
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

        public void Delete(TermSynonym request)
        {
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    if(!(request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, $"No Id provided for delete.");

                    var en = DocEntityTermSynonym.Get(request?.Id);
                    if(null == en) throw new HttpError(HttpStatusCode.NotFound, $"No TermSynonym could be found for Id {request?.Id}.");
                    if(en.IsRemoved) return;
                
                    if(!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.DELETE))
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have DELETE permission for this route.");
                
                    en.Remove();

                    DocCacheClient.RemoveSearch(DocConstantModelName.TERMSYNONYM);
                    DocCacheClient.RemoveById(request.Id);
                });
            }
        }

        public void Delete(TermSynonymSearch request)
        {
            var matches = Get(request) as List<TermSynonym>;
            if(true != matches?.Any()) throw new HttpError(HttpStatusCode.NotFound, "No matches for request");
            matches.ForEach(match =>
            {
                Delete(match);
            });
        }


        public object Get(TermSynonymJunction request)
        {
            switch(request.Junction.ToLower().TrimAndPruneSpaces())
            {
                    case "lookuptablebinding":
                        return GetJunctionSearchResult<TermSynonym, DocEntityTermSynonym, DocEntityLookupTableBinding, LookupTableBinding, LookupTableBindingSearch>((int)request.Id, DocConstantModelName.LOOKUPTABLEBINDING, "Bindings", request, (ss) => HostContext.ResolveService<LookupTableBindingService>(Request)?.Get(ss));
                    case "comment":
                        return GetJunctionSearchResult<TermSynonym, DocEntityTermSynonym, DocEntityComment, Comment, CommentSearch>((int)request.Id, DocConstantModelName.COMMENT, "Comments", request, (ss) => HostContext.ResolveService<CommentService>(Request)?.Get(ss));
                    case "favorite":
                        return GetJunctionSearchResult<TermSynonym, DocEntityTermSynonym, DocEntityFavorite, Favorite, FavoriteSearch>((int)request.Id, DocConstantModelName.FAVORITE, "Favorites", request, (ss) => HostContext.ResolveService<FavoriteService>(Request)?.Get(ss));
                    case "tag":
                        return GetJunctionSearchResult<TermSynonym, DocEntityTermSynonym, DocEntityTag, Tag, TagSearch>((int)request.Id, DocConstantModelName.TAG, "Tags", request, (ss) => HostContext.ResolveService<TagService>(Request)?.Get(ss));
                default:
                    throw new HttpError(HttpStatusCode.NotFound, $"Route for termsynonym/{request.Id}/{request.Junction} was not found");
            }
        }


        public object Post(TermSynonymJunction request)
        {
            switch(request.Junction.ToLower().TrimAndPruneSpaces())
            {
                    case "lookuptablebinding":
                        return AddJunction<TermSynonym, DocEntityTermSynonym, DocEntityLookupTableBinding, LookupTableBinding, LookupTableBindingSearch>((int)request.Id, DocConstantModelName.LOOKUPTABLEBINDING, "Bindings", request);
                    case "comment":
                        return AddJunction<TermSynonym, DocEntityTermSynonym, DocEntityComment, Comment, CommentSearch>((int)request.Id, DocConstantModelName.COMMENT, "Comments", request);
                    case "favorite":
                        return AddJunction<TermSynonym, DocEntityTermSynonym, DocEntityFavorite, Favorite, FavoriteSearch>((int)request.Id, DocConstantModelName.FAVORITE, "Favorites", request);
                    case "tag":
                        return AddJunction<TermSynonym, DocEntityTermSynonym, DocEntityTag, Tag, TagSearch>((int)request.Id, DocConstantModelName.TAG, "Tags", request);
                default:
                    throw new HttpError(HttpStatusCode.NotFound, $"Route for termsynonym/{request.Id}/{request.Junction} was not found");
            }
        }

        public object Delete(TermSynonymJunction request)
        {    
            switch(request.Junction.ToLower().TrimAndPruneSpaces())
            {
                    case "lookuptablebinding":
                        return RemoveJunction<TermSynonym, DocEntityTermSynonym, DocEntityLookupTableBinding, LookupTableBinding, LookupTableBindingSearch>((int)request.Id, DocConstantModelName.LOOKUPTABLEBINDING, "Bindings", request);
                    case "comment":
                        return RemoveJunction<TermSynonym, DocEntityTermSynonym, DocEntityComment, Comment, CommentSearch>((int)request.Id, DocConstantModelName.COMMENT, "Comments", request);
                    case "favorite":
                        return RemoveJunction<TermSynonym, DocEntityTermSynonym, DocEntityFavorite, Favorite, FavoriteSearch>((int)request.Id, DocConstantModelName.FAVORITE, "Favorites", request);
                    case "tag":
                        return RemoveJunction<TermSynonym, DocEntityTermSynonym, DocEntityTag, Tag, TagSearch>((int)request.Id, DocConstantModelName.TAG, "Tags", request);
                default:
                    throw new HttpError(HttpStatusCode.NotFound, $"Route for termsynonym/{request.Id}/{request.Junction} was not found");
            }
        }


        private TermSynonym GetTermSynonym(TermSynonym request)
        {
            var id = request?.Id;
            TermSynonym ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetSelect<TermSynonym>(currentUser, "TermSynonym", request.Select);

            DocEntityTermSynonym entity = null;
            if(id.HasValue)
            {
                entity = DocEntityTermSynonym.Get(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No TermSynonym found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }

    }
}
