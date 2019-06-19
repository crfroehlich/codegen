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
    public partial class LookupTableService : DocServiceBase
    {

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private IQueryable<DocEntityLookupTable> _ExecSearch(LookupTableSearch request, DocQuery query)
        {
            request = InitSearch<LookupTable, LookupTableSearch>(request);
            IQueryable<DocEntityLookupTable> entities = null;
            query.Run( session => 
            {
                entities = query.SelectAll<DocEntityLookupTable>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new LookupTableFullTextSearch(request);
                    entities = GetFullTextSearch<DocEntityLookupTable,LookupTableFullTextSearch>(fts, entities);
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
                if(true == request.Archived?.Any() && currentUser.HasProperty(DocConstantModelName.LOOKUPTABLE, nameof(Reference.Archived), DocConstantPermission.VIEW))
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
                if(true == request.BindingsIds?.Any())
                {
                    entities = entities.Where(en => en.Bindings.Any(r => r.Id.In(request.BindingsIds)));
                }
                if(true == request.CategoriesIds?.Any())
                {
                    entities = entities.Where(en => en.Categories.Any(r => r.Id.In(request.CategoriesIds)));
                }
                if(true == request.DocumentsIds?.Any())
                {
                    entities = entities.Where(en => en.Documents.Any(r => r.Id.In(request.DocumentsIds)));
                }
                if(!DocTools.IsNullOrEmpty(request.Enum) && !DocTools.IsNullOrEmpty(request.Enum.Id))
                {
                    entities = entities.Where(en => en.Enum.Id == request.Enum.Id );
                }
                if(true == request.EnumIds?.Any())
                {
                    entities = entities.Where(en => en.Enum.Id.In(request.EnumIds));
                }
                if(true == request.EnumNames?.Any())
                {
                    entities = entities.Where(en => en.Enum.Name.In(request.EnumNames));
                }
                if(!DocTools.IsNullOrEmpty(request.Name))
                    entities = entities.Where(en => en.Name.Contains(request.Name));
                if(!DocTools.IsNullOrEmpty(request.Names))
                    entities = entities.Where(en => en.Name.In(request.Names));

                entities = ApplyFilters<DocEntityLookupTable,LookupTableSearch>(request, entities);

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
        public object Post(LookupTableSearch request) => Get(request);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Get(LookupTableSearch request) => GetSearchResultWithCache<LookupTable,DocEntityLookupTable,LookupTableSearch>(DocConstantModelName.LOOKUPTABLE, request, _ExecSearch);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Get(LookupTable request) => GetEntityWithCache<LookupTable>(DocConstantModelName.LOOKUPTABLE, request, GetLookupTable);



        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private LookupTable _AssignValues(LookupTable request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "LookupTable"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.Select = request.Select ?? new List<string>();

            LookupTable ret = null;
            request = _InitAssignValues<LookupTable>(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            var cacheKey = GetApiCacheKey<LookupTable>(DocConstantModelName.LOOKUPTABLE, nameof(LookupTable), request);
            
            //First, assign all the variables, do database lookups and conversions
            var pBindings = GetVariable<Reference>(request, nameof(request.Bindings), request.Bindings?.ToList(), request.BindingsIds?.ToList());
            var pCategories = GetVariable<Reference>(request, nameof(request.Categories), request.Categories?.ToList(), request.CategoriesIds?.ToList());
            var pDocuments = GetVariable<Reference>(request, nameof(request.Documents), request.Documents?.ToList(), request.DocumentsIds?.ToList());
            var pEnum = DocEntityLookupTableEnum.Get(request.Enum);
            var pName = request.Name;
            var pArchived = true == request.Archived;
            var pLocked = request.Locked;

            var entity = InitEntity<DocEntityLookupTable,LookupTable>(request, permission, session);

            if (AllowPatchValue<LookupTable, bool>(request, DocConstantModelName.LOOKUPTABLE, pArchived, permission, nameof(request.Archived), pArchived != entity.Archived))
            {
                entity.Archived = pArchived;
            }
            if (AllowPatchValue<LookupTable, DocEntityLookupTableEnum>(request, DocConstantModelName.LOOKUPTABLE, pEnum, permission, nameof(request.Enum), pEnum != entity.Enum))
            {
                entity.Enum = pEnum;
            }
            if (AllowPatchValue<LookupTable, string>(request, DocConstantModelName.LOOKUPTABLE, pName, permission, nameof(request.Name), pName != entity.Name))
            {
                entity.Name = pName;
            }
            if (request.Locked && AllowPatchValue<LookupTable, bool>(request, DocConstantModelName.LOOKUPTABLE, pArchived, permission, nameof(request.Locked), pLocked != entity.Locked))
            {
                entity.Archived = pArchived;
            }
            entity.SaveChanges(permission);

            var idsToInvalidate = new List<int>();
            idsToInvalidate.AddRange(PatchCollection<LookupTable, DocEntityLookupTable, Reference, DocEntityLookupTableBinding>(request, entity, pBindings, permission, nameof(request.Bindings)));
            idsToInvalidate.AddRange(PatchCollection<LookupTable, DocEntityLookupTable, Reference, DocEntityLookupCategory>(request, entity, pCategories, permission, nameof(request.Categories)));
            idsToInvalidate.AddRange(PatchCollection<LookupTable, DocEntityLookupTable, Reference, DocEntityDocument>(request, entity, pDocuments, permission, nameof(request.Documents)));
            if (idsToInvalidate.Any())
            {
                idsToInvalidate.Add(entity.Id);
                DocCacheClient.RemoveByEntityIds(idsToInvalidate);
                DocCacheClient.RemoveSearch(DocConstantModelName.LOOKUPTABLE);
            }

            entity.SaveChanges(permission);
            DocPermissionFactory.SetSelect<LookupTable>(currentUser, nameof(LookupTable), request.Select);
            ret = entity.ToDto();

            var cacheExpires = DocResources.Metadata.GetCacheExpiration(DocConstantModelName.LOOKUPTABLE);
            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.LOOKUPTABLE, cacheExpires);

            return ret;
        }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public LookupTable Post(LookupTable request)
        {
            if(request == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            request.Select = request.Select ?? new List<string>();

            LookupTable ret = null;

            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "LookupTable")) 
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                    ret = _AssignValues(request, DocConstantPermission.ADD, ssn);
                });
            }
            return ret;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<LookupTable> Post(LookupTableBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<LookupTable>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Post(dto) as LookupTable;
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
        public LookupTable Post(LookupTableCopy request)
        {
            LookupTable ret = null;
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    var entity = DocEntityLookupTable.Get(request?.Id);
                    if(null == entity) throw new HttpError(HttpStatusCode.NoContent, "The COPY request did not succeed.");
                    if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD))
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                    var pBindings = entity.Bindings.ToList();
                    var pCategories = entity.Categories.ToList();
                    var pDocuments = entity.Documents.ToList();
                    var pEnum = entity.Enum;
                    var pName = entity.Name;
                    if(!DocTools.IsNullOrEmpty(pName))
                        pName += " (Copy)";
                    var copy = new DocEntityLookupTable(ssn)
                    {
                        Hash = Guid.NewGuid()
                                , Enum = pEnum
                                , Name = pName
                    };
                            foreach(var item in pBindings)
                            {
                                entity.Bindings.Add(item);
                            }

                            foreach(var item in pCategories)
                            {
                                entity.Categories.Add(item);
                            }

                            foreach(var item in pDocuments)
                            {
                                entity.Documents.Add(item);
                            }

                    copy.SaveChanges(DocConstantPermission.ADD);
                    ret = copy.ToDto();
                });
            }
            return ret;
        }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<LookupTable> Put(LookupTableBatch request)
        {
            return Patch(request);
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public LookupTable Put(LookupTable request)
        {
            return Patch(request);
        }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<LookupTable> Patch(LookupTableBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<LookupTable>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Patch(dto) as LookupTable;
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
        public LookupTable Patch(LookupTable request)
        {
            if(true != (request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the LookupTable to patch.");
            
            request.Select = request.Select ?? new List<string>();
            
            LookupTable ret = null;
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
        public void Delete(LookupTableBatch request)
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
        public void Delete(LookupTable request)
        {
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    if(!(request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, $"No Id provided for delete.");

                    var en = DocEntityLookupTable.Get(request?.Id);
                    if(null == en) throw new HttpError(HttpStatusCode.NotFound, $"No LookupTable could be found for Id {request?.Id}.");
                    if(en.IsRemoved) return;
                
                    if(!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.DELETE))
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have DELETE permission for this route.");
                
                    en.Remove();

                    DocCacheClient.RemoveSearch(DocConstantModelName.LOOKUPTABLE);
                    DocCacheClient.RemoveById(request.Id);
                });
            }
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public void Delete(LookupTableSearch request)
        {
            var matches = Get(request) as List<LookupTable>;
            if(true != matches?.Any()) throw new HttpError(HttpStatusCode.NotFound, "No matches for request");
            matches.ForEach(match =>
            {
                Delete(match);
            });
        }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Get(LookupTableJunction request)
        {
            switch(request.Junction.ToLower().TrimAndPruneSpaces())
            {
                    case "lookuptablebinding":
                        return GetJunctionSearchResult<LookupTable, DocEntityLookupTable, DocEntityLookupTableBinding, LookupTableBinding, LookupTableBindingSearch>((int)request.Id, DocConstantModelName.LOOKUPTABLEBINDING, "Bindings", request, (ss) => HostContext.ResolveService<LookupTableBindingService>(Request)?.Get(ss));
                    case "lookupcategory":
                        return GetJunctionSearchResult<LookupTable, DocEntityLookupTable, DocEntityLookupCategory, LookupCategory, LookupCategorySearch>((int)request.Id, DocConstantModelName.LOOKUPCATEGORY, "Categories", request, (ss) => HostContext.ResolveService<LookupCategoryService>(Request)?.Get(ss));
                    case "comment":
                        return GetJunctionSearchResult<LookupTable, DocEntityLookupTable, DocEntityComment, Comment, CommentSearch>((int)request.Id, DocConstantModelName.COMMENT, "Comments", request, (ss) => HostContext.ResolveService<CommentService>(Request)?.Get(ss));
                    case "document":
                        return GetJunctionSearchResult<LookupTable, DocEntityLookupTable, DocEntityDocument, Document, DocumentSearch>((int)request.Id, DocConstantModelName.DOCUMENT, "Documents", request, (ss) => HostContext.ResolveService<DocumentService>(Request)?.Get(ss));
                    case "favorite":
                        return GetJunctionSearchResult<LookupTable, DocEntityLookupTable, DocEntityFavorite, Favorite, FavoriteSearch>((int)request.Id, DocConstantModelName.FAVORITE, "Favorites", request, (ss) => HostContext.ResolveService<FavoriteService>(Request)?.Get(ss));
                    case "tag":
                        return GetJunctionSearchResult<LookupTable, DocEntityLookupTable, DocEntityTag, Tag, TagSearch>((int)request.Id, DocConstantModelName.TAG, "Tags", request, (ss) => HostContext.ResolveService<TagService>(Request)?.Get(ss));
                default:
                    throw new HttpError(HttpStatusCode.NotFound, $"Route for lookuptable/{request.Id}/{request.Junction} was not found");
            }
        }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Post(LookupTableJunction request)
        {
            switch(request.Junction.ToLower().TrimAndPruneSpaces())
            {
                    case "lookuptablebinding":
                        return AddJunction<LookupTable, DocEntityLookupTable, DocEntityLookupTableBinding, LookupTableBinding, LookupTableBindingSearch>((int)request.Id, DocConstantModelName.LOOKUPTABLEBINDING, "Bindings", request);
                    case "lookupcategory":
                        return AddJunction<LookupTable, DocEntityLookupTable, DocEntityLookupCategory, LookupCategory, LookupCategorySearch>((int)request.Id, DocConstantModelName.LOOKUPCATEGORY, "Categories", request);
                    case "comment":
                        return AddJunction<LookupTable, DocEntityLookupTable, DocEntityComment, Comment, CommentSearch>((int)request.Id, DocConstantModelName.COMMENT, "Comments", request);
                    case "document":
                        return AddJunction<LookupTable, DocEntityLookupTable, DocEntityDocument, Document, DocumentSearch>((int)request.Id, DocConstantModelName.DOCUMENT, "Documents", request);
                    case "favorite":
                        return AddJunction<LookupTable, DocEntityLookupTable, DocEntityFavorite, Favorite, FavoriteSearch>((int)request.Id, DocConstantModelName.FAVORITE, "Favorites", request);
                    case "tag":
                        return AddJunction<LookupTable, DocEntityLookupTable, DocEntityTag, Tag, TagSearch>((int)request.Id, DocConstantModelName.TAG, "Tags", request);
                default:
                    throw new HttpError(HttpStatusCode.NotFound, $"Route for lookuptable/{request.Id}/{request.Junction} was not found");
            }
        }

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Delete(LookupTableJunction request)
        {    
            switch(request.Junction.ToLower().TrimAndPruneSpaces())
            {
                    case "lookuptablebinding":
                        return RemoveJunction<LookupTable, DocEntityLookupTable, DocEntityLookupTableBinding, LookupTableBinding, LookupTableBindingSearch>((int)request.Id, DocConstantModelName.LOOKUPTABLEBINDING, "Bindings", request);
                    case "lookupcategory":
                        return RemoveJunction<LookupTable, DocEntityLookupTable, DocEntityLookupCategory, LookupCategory, LookupCategorySearch>((int)request.Id, DocConstantModelName.LOOKUPCATEGORY, "Categories", request);
                    case "comment":
                        return RemoveJunction<LookupTable, DocEntityLookupTable, DocEntityComment, Comment, CommentSearch>((int)request.Id, DocConstantModelName.COMMENT, "Comments", request);
                    case "document":
                        return RemoveJunction<LookupTable, DocEntityLookupTable, DocEntityDocument, Document, DocumentSearch>((int)request.Id, DocConstantModelName.DOCUMENT, "Documents", request);
                    case "favorite":
                        return RemoveJunction<LookupTable, DocEntityLookupTable, DocEntityFavorite, Favorite, FavoriteSearch>((int)request.Id, DocConstantModelName.FAVORITE, "Favorites", request);
                    case "tag":
                        return RemoveJunction<LookupTable, DocEntityLookupTable, DocEntityTag, Tag, TagSearch>((int)request.Id, DocConstantModelName.TAG, "Tags", request);
                default:
                    throw new HttpError(HttpStatusCode.NotFound, $"Route for lookuptable/{request.Id}/{request.Junction} was not found");
            }
        }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private LookupTable GetLookupTable(LookupTable request)
        {
            var id = request?.Id;
            LookupTable ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetSelect<LookupTable>(currentUser, "LookupTable", request.Select);

            DocEntityLookupTable entity = null;
            if(id.HasValue)
            {
                entity = DocEntityLookupTable.Get(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No LookupTable found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }

    }
}
