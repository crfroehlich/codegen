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
    public partial class TermCategoryService : DocServiceBase
    {
        private IQueryable<DocEntityTermCategory> _ExecSearch(TermCategorySearch request, DocQuery query)
        {
            request = InitSearch<TermCategory, TermCategorySearch>(request);
            IQueryable<DocEntityTermCategory> entities = null;
            query.Run( session => 
            {
                entities = query.SelectAll<DocEntityTermCategory>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new TermCategoryFullTextSearch(request);
                    entities = GetFullTextSearch<DocEntityTermCategory,TermCategoryFullTextSearch>(fts, entities);
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
                if(true == request.Archived?.Any() && currentUser.HasProperty(DocConstantModelName.TERMCATEGORY, nameof(Reference.Archived), DocConstantPermission.VIEW))
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

                if(!DocTools.IsNullOrEmpty(request.Name) && !DocTools.IsNullOrEmpty(request.Name.Id))
                {
                    entities = entities.Where(en => en.Name.Id == request.Name.Id );
                }
                if(true == request.NameIds?.Any())
                {
                    entities = entities.Where(en => en.Name.Id.In(request.NameIds));
                }
                else if(!DocTools.IsNullOrEmpty(request.Name) && !DocTools.IsNullOrEmpty(request.Name.Name))
                {
                    entities = entities.Where(en => en.Name.Name == request.Name.Name );
                }
                if(true == request.NameNames?.Any())
                {
                    entities = entities.Where(en => en.Name.Name.In(request.NameNames));
                }
                if(!DocTools.IsNullOrEmpty(request.ParentCategory) && !DocTools.IsNullOrEmpty(request.ParentCategory.Id))
                {
                    entities = entities.Where(en => en.ParentCategory.Id == request.ParentCategory.Id );
                }
                if(true == request.ParentCategoryIds?.Any())
                {
                    entities = entities.Where(en => en.ParentCategory.Id.In(request.ParentCategoryIds));
                }
                if(!DocTools.IsNullOrEmpty(request.Scope) && !DocTools.IsNullOrEmpty(request.Scope.Id))
                {
                    entities = entities.Where(en => en.Scope.Id == request.Scope.Id );
                }
                if(true == request.ScopeIds?.Any())
                {
                    entities = entities.Where(en => en.Scope.Id.In(request.ScopeIds));
                }
                if(true == request.TermsIds?.Any())
                {
                    entities = entities.Where(en => en.Terms.Any(r => r.Id.In(request.TermsIds)));
                }

                entities = ApplyFilters<DocEntityTermCategory,TermCategorySearch>(request, entities);

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

        public object Post(TermCategorySearch request) => Get(request);

        public object Get(TermCategorySearch request) => GetSearchResultWithCache<TermCategory,DocEntityTermCategory,TermCategorySearch>(DocConstantModelName.TERMCATEGORY, request, _ExecSearch);

        public object Get(TermCategory request) => GetEntityWithCache<TermCategory>(DocConstantModelName.TERMCATEGORY, request, GetTermCategory);

        private TermCategory _AssignValues(TermCategory request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "TermCategory"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            TermCategory ret = null;
            request = _InitAssignValues<TermCategory>(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            var cacheKey = GetApiCacheKey<TermCategory>(DocConstantModelName.TERMCATEGORY, nameof(TermCategory), request);
            
            //First, assign all the variables, do database lookups and conversions
            DocEntityLookupTable pName = GetLookup(DocConstantLookupTable.TERMCATEGORY, request.Name?.Name, request.Name?.Id);
            var pParentCategory = (request.ParentCategory?.Id > 0) ? DocEntityTermCategory.GetTermCategory(request.ParentCategory.Id) : null;
            var pScope = (request.Scope?.Id > 0) ? DocEntityScope.GetScope(request.Scope.Id) : null;
            var pTerms = request.Terms?.ToList();

            DocEntityTermCategory entity = null;
            if(permission == DocConstantPermission.ADD)
            {
                var now = DateTime.UtcNow;
                entity = new DocEntityTermCategory(session)
                {
                    Created = now,
                    Updated = now
                };
            }
            else
            {
                entity = DocEntityTermCategory.GetTermCategory(request.Id);
                if(null == entity)
                    throw new HttpError(HttpStatusCode.NotFound, $"No record");
            }

            //Special case for Archived
            var pArchived = true == request.Archived;
            if (DocPermissionFactory.IsRequestedHasPermission<bool>(currentUser, request, pArchived, permission, DocConstantModelName.TERMCATEGORY, nameof(request.Archived)))
            {
                if(DocPermissionFactory.IsRequested(request, pArchived, entity.Archived, nameof(request.Archived)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.TERMCATEGORY, nameof(request.Archived)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Archived)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pArchived) && DocResources.Metadata.IsRequired(DocConstantModelName.TERMCATEGORY, nameof(request.Archived))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Archived)} requires a value.");
                    entity.Archived = pArchived;
                if(DocPermissionFactory.IsRequested<bool>(request, pArchived, nameof(request.Archived)) && !request.VisibleFields.Matches(nameof(request.Archived), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Archived));
                }
            }

            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityLookupTable>(currentUser, request, pName, permission, DocConstantModelName.TERMCATEGORY, nameof(request.Name)))
            {
                if(DocPermissionFactory.IsRequested(request, pName, entity.Name, nameof(request.Name)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.TERMCATEGORY, nameof(request.Name)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Name)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pName) && DocResources.Metadata.IsRequired(DocConstantModelName.TERMCATEGORY, nameof(request.Name))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Name)} requires a value.");
                    entity.Name = pName;
                if(DocPermissionFactory.IsRequested<DocEntityLookupTable>(request, pName, nameof(request.Name)) && !request.VisibleFields.Matches(nameof(request.Name), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Name));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityTermCategory>(currentUser, request, pParentCategory, permission, DocConstantModelName.TERMCATEGORY, nameof(request.ParentCategory)))
            {
                if(DocPermissionFactory.IsRequested(request, pParentCategory, entity.ParentCategory, nameof(request.ParentCategory)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.TERMCATEGORY, nameof(request.ParentCategory)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.ParentCategory)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pParentCategory) && DocResources.Metadata.IsRequired(DocConstantModelName.TERMCATEGORY, nameof(request.ParentCategory))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.ParentCategory)} requires a value.");
                    entity.ParentCategory = pParentCategory;
                if(DocPermissionFactory.IsRequested<DocEntityTermCategory>(request, pParentCategory, nameof(request.ParentCategory)) && !request.VisibleFields.Matches(nameof(request.ParentCategory), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.ParentCategory));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityScope>(currentUser, request, pScope, permission, DocConstantModelName.TERMCATEGORY, nameof(request.Scope)))
            {
                if(DocPermissionFactory.IsRequested(request, pScope, entity.Scope, nameof(request.Scope)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.TERMCATEGORY, nameof(request.Scope)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Scope)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pScope) && DocResources.Metadata.IsRequired(DocConstantModelName.TERMCATEGORY, nameof(request.Scope))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Scope)} requires a value.");
                    entity.Scope = pScope;
                if(DocPermissionFactory.IsRequested<DocEntityScope>(request, pScope, nameof(request.Scope)) && !request.VisibleFields.Matches(nameof(request.Scope), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Scope));
                }
            }

            if (request.Locked) entity.Locked = request.Locked;

            entity.SaveChanges(permission);

            if (DocPermissionFactory.IsRequestedHasPermission<List<Reference>>(currentUser, request, pTerms, permission, DocConstantModelName.TERMCATEGORY, nameof(request.Terms)))
            {
                if (true == pTerms?.Any() )
                {
                    var requestedTerms = pTerms.Select(p => p.Id).Distinct().ToList();
                    var existsTerms = Execute.SelectAll<DocEntityTermMaster>().Where(e => e.Id.In(requestedTerms)).Select( e => e.Id ).ToList();
                    if (existsTerms.Count != requestedTerms.Count)
                    {
                        var nonExists = requestedTerms.Where(id => existsTerms.All(eId => eId != id));
                        throw new HttpError(HttpStatusCode.NotFound, $"Cannot patch collection Terms with objects that do not exist. No matching Terms(s) could be found for Ids: {nonExists.ToDelimitedString()}.");
                    }
                    var toAdd = requestedTerms.Where(id => entity.Terms.All(e => e.Id != id)).ToList(); 
                    toAdd?.ForEach(id =>
                    {
                        var target = DocEntityTermMaster.GetTermMaster(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD, targetEntity: target, targetName: nameof(TermCategory), columnName: nameof(request.Terms)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to add {nameof(request.Terms)} to {nameof(TermCategory)}");
                        entity.Terms.Add(target);
                    });
                    var toRemove = entity.Terms.Where(e => requestedTerms.All(id => e.Id != id)).Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityTermMaster.GetTermMaster(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(TermCategory), columnName: nameof(request.Terms)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Terms)} from {nameof(TermCategory)}");
                        entity.Terms.Remove(target);
                    });
                }
                else
                {
                    var toRemove = entity.Terms.Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityTermMaster.GetTermMaster(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(TermCategory), columnName: nameof(request.Terms)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Terms)} from {nameof(TermCategory)}");
                        entity.Terms.Remove(target);
                    });
                }
                if(DocPermissionFactory.IsRequested<List<Reference>>(request, pTerms, nameof(request.Terms)) && !request.VisibleFields.Matches(nameof(request.Terms), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Terms));
                }
            }
            DocPermissionFactory.SetVisibleFields<TermCategory>(currentUser, nameof(TermCategory), request.VisibleFields);
            ret = entity.ToDto();

            var cacheExpires = DocResources.Metadata.GetCacheExpiration(DocConstantModelName.TERMCATEGORY);
            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.TERMCATEGORY, cacheExpires);

            return ret;
        }
        public TermCategory Post(TermCategory request)
        {
            if(request == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            TermCategory ret = null;

            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "TermCategory")) 
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                    ret = _AssignValues(request, DocConstantPermission.ADD, ssn);
                });
            }
            return ret;
        }
   
        public List<TermCategory> Post(TermCategoryBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<TermCategory>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Post(dto) as TermCategory;
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

        public TermCategory Post(TermCategoryCopy request)
        {
            TermCategory ret = null;
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    var entity = DocEntityTermCategory.GetTermCategory(request?.Id);
                    if(null == entity) throw new HttpError(HttpStatusCode.NoContent, "The COPY request did not succeed.");
                    if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD))
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                    var pName = entity.Name;
                    var pParentCategory = entity.ParentCategory;
                    var pScope = entity.Scope;
                    var pTerms = entity.Terms.ToList();
                    #region Custom Before copyTermCategory
                    #endregion Custom Before copyTermCategory
                    var copy = new DocEntityTermCategory(ssn)
                    {
                        Hash = Guid.NewGuid()
                                , Name = pName
                                , ParentCategory = pParentCategory
                                , Scope = pScope
                    };
                            foreach(var item in pTerms)
                            {
                                entity.Terms.Add(item);
                            }

                    #region Custom After copyTermCategory
                    #endregion Custom After copyTermCategory
                    copy.SaveChanges(DocConstantPermission.ADD);
                    ret = copy.ToDto();
                });
            }
            return ret;
        }

        public List<TermCategory> Put(TermCategoryBatch request)
        {
            return Patch(request);
        }

        public TermCategory Put(TermCategory request)
        {
            return Patch(request);
        }
        public List<TermCategory> Patch(TermCategoryBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<TermCategory>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Patch(dto) as TermCategory;
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

        public TermCategory Patch(TermCategory request)
        {
            if(true != (request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the TermCategory to patch.");
            
            request.VisibleFields = request.VisibleFields ?? new List<string>();
            
            TermCategory ret = null;
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    ret = _AssignValues(request, DocConstantPermission.EDIT, ssn);
                });
            }
            return ret;
        }
        public void Delete(TermCategoryBatch request)
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

        public void Delete(TermCategory request)
        {
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    if(!(request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, $"No Id provided for delete.");

                    var en = DocEntityTermCategory.GetTermCategory(request?.Id);
                    if(null == en) throw new HttpError(HttpStatusCode.NotFound, $"No TermCategory could be found for Id {request?.Id}.");
                    if(en.IsRemoved) return;
                
                    if(!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.DELETE))
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have DELETE permission for this route.");
                
                    en.Remove();

                    DocCacheClient.RemoveSearch(DocConstantModelName.TERMCATEGORY);
                    DocCacheClient.RemoveById(request.Id);
                });
            }
        }

        public void Delete(TermCategorySearch request)
        {
            var matches = Get(request) as List<TermCategory>;
            if(true != matches?.Any()) throw new HttpError(HttpStatusCode.NotFound, "No matches for request");
            matches.ForEach(match =>
            {
                Delete(match);
            });
        }
        public object Get(TermCategoryJunction request)
        {
            switch(request.Junction.ToLower().TrimAndPruneSpaces())
            {
                    case "tag":
                        return GetJunctionSearchResult<TermCategory, DocEntityTermCategory, DocEntityTag, Tag, TagSearch>((int)request.Id, DocConstantModelName.TAG, "Tags", request, (ss) => HostContext.ResolveService<TagService>(Request)?.Get(ss));
                    case "termmaster":
                        return GetJunctionSearchResult<TermCategory, DocEntityTermCategory, DocEntityTermMaster, TermMaster, TermMasterSearch>((int)request.Id, DocConstantModelName.TERMMASTER, "Terms", request, (ss) => HostContext.ResolveService<TermMasterService>(Request)?.Get(ss));
                default:
                    throw new HttpError(HttpStatusCode.NotFound, $"Route for termcategory/{request.Id}/{request.Junction} was not found");
            }
        }
        public object Post(TermCategoryJunction request)
        {
            switch(request.Junction.ToLower().TrimAndPruneSpaces())
            {
                    case "tag":
                        return AddJunction<TermCategory, DocEntityTermCategory, DocEntityTag, Tag, TagSearch>((int)request.Id, DocConstantModelName.TAG, "Tags", request);
                    case "termmaster":
                        return AddJunction<TermCategory, DocEntityTermCategory, DocEntityTermMaster, TermMaster, TermMasterSearch>((int)request.Id, DocConstantModelName.TERMMASTER, "Terms", request);
                default:
                    throw new HttpError(HttpStatusCode.NotFound, $"Route for termcategory/{request.Id}/{request.Junction} was not found");
            }
        }

        public object Delete(TermCategoryJunction request)
        {    
            switch(request.Junction.ToLower().TrimAndPruneSpaces())
            {
                    case "tag":
                        return RemoveJunction<TermCategory, DocEntityTermCategory, DocEntityTag, Tag, TagSearch>((int)request.Id, DocConstantModelName.TAG, "Tags", request);
                    case "termmaster":
                        return RemoveJunction<TermCategory, DocEntityTermCategory, DocEntityTermMaster, TermMaster, TermMasterSearch>((int)request.Id, DocConstantModelName.TERMMASTER, "Terms", request);
                default:
                    throw new HttpError(HttpStatusCode.NotFound, $"Route for termcategory/{request.Id}/{request.Junction} was not found");
            }
        }
        private TermCategory GetTermCategory(TermCategory request)
        {
            var id = request?.Id;
            TermCategory ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetVisibleFields<TermCategory>(currentUser, "TermCategory", request.VisibleFields);

            DocEntityTermCategory entity = null;
            if(id.HasValue)
            {
                entity = DocEntityTermCategory.GetTermCategory(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No TermCategory found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }
    }
}
