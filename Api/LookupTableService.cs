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
    public partial class LookupTableService : DocServiceBase
    {
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
                if(!DocTools.IsNullOrEmpty(request.Name))
                    entities = entities.Where(en => en.Name.Contains(request.Name));

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

        public object Post(LookupTableSearch request) => Get(request);

        public object Get(LookupTableSearch request) => GetSearchResultWithCache<LookupTable,DocEntityLookupTable,LookupTableSearch>(DocConstantModelName.LOOKUPTABLE, request, _ExecSearch);

        public object Get(LookupTable request) => GetEntityWithCache<LookupTable>(DocConstantModelName.LOOKUPTABLE, request, GetLookupTable);

        private LookupTable _AssignValues(LookupTable request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "LookupTable"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            LookupTable ret = null;
            request = _InitAssignValues<LookupTable>(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            var cacheKey = GetApiCacheKey<LookupTable>(DocConstantModelName.LOOKUPTABLE, nameof(LookupTable), request);
            
            //First, assign all the variables, do database lookups and conversions
            var pBindings = request.Bindings?.ToList();
            var pCategories = request.Categories?.ToList();
            var pDocuments = request.Documents?.ToList();
            var pEnum = DocEntityLookupTableEnum.GetLookupTableEnum(request.Enum);
            var pName = request.Name;

            DocEntityLookupTable entity = null;
            if(permission == DocConstantPermission.ADD)
            {
                var now = DateTime.UtcNow;
                entity = new DocEntityLookupTable(session)
                {
                    Created = now,
                    Updated = now
                };
            }
            else
            {
                entity = DocEntityLookupTable.GetLookupTable(request.Id);
                if(null == entity)
                    throw new HttpError(HttpStatusCode.NotFound, $"No record");
            }

            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityLookupTableEnum>(currentUser, request, pEnum, permission, DocConstantModelName.LOOKUPTABLE, nameof(request.Enum)))
            {
                if(DocPermissionFactory.IsRequested(request, pEnum, entity.Enum, nameof(request.Enum)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.LOOKUPTABLE, nameof(request.Enum)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Enum)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pEnum) && DocResources.Metadata.IsRequired(DocConstantModelName.LOOKUPTABLE, nameof(request.Enum))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Enum)} requires a value.");
                    entity.Enum = pEnum;
                if(DocPermissionFactory.IsRequested<DocEntityLookupTableEnum>(request, pEnum, nameof(request.Enum)) && !request.VisibleFields.Matches(nameof(request.Enum), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Enum));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pName, permission, DocConstantModelName.LOOKUPTABLE, nameof(request.Name)))
            {
                if(DocPermissionFactory.IsRequested(request, pName, entity.Name, nameof(request.Name)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.LOOKUPTABLE, nameof(request.Name)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Name)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pName) && DocResources.Metadata.IsRequired(DocConstantModelName.LOOKUPTABLE, nameof(request.Name))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Name)} requires a value.");
                    entity.Name = pName;
                if(DocPermissionFactory.IsRequested<string>(request, pName, nameof(request.Name)) && !request.VisibleFields.Matches(nameof(request.Name), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Name));
                }
            }

            if (request.Locked) entity.Locked = request.Locked;

            entity.SaveChanges(permission);

            if (DocPermissionFactory.IsRequestedHasPermission<List<Reference>>(currentUser, request, pBindings, permission, DocConstantModelName.LOOKUPTABLE, nameof(request.Bindings)))
            {
                if (true == pBindings?.Any() )
                {
                    var requestedBindings = pBindings.Select(p => p.Id).Distinct().ToList();
                    var existsBindings = Execute.SelectAll<DocEntityLookupTableBinding>().Where(e => e.Id.In(requestedBindings)).Select( e => e.Id ).ToList();
                    if (existsBindings.Count != requestedBindings.Count)
                    {
                        var nonExists = requestedBindings.Where(id => existsBindings.All(eId => eId != id));
                        throw new HttpError(HttpStatusCode.NotFound, $"Cannot patch collection Bindings with objects that do not exist. No matching Bindings(s) could be found for Ids: {nonExists.ToDelimitedString()}.");
                    }
                    var toAdd = requestedBindings.Where(id => entity.Bindings.All(e => e.Id != id)).ToList(); 
                    toAdd?.ForEach(id =>
                    {
                        var target = DocEntityLookupTableBinding.GetLookupTableBinding(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD, targetEntity: target, targetName: nameof(LookupTable), columnName: nameof(request.Bindings)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to add {nameof(request.Bindings)} to {nameof(LookupTable)}");
                        entity.Bindings.Add(target);
                    });
                    var toRemove = entity.Bindings.Where(e => requestedBindings.All(id => e.Id != id)).Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityLookupTableBinding.GetLookupTableBinding(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(LookupTable), columnName: nameof(request.Bindings)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Bindings)} from {nameof(LookupTable)}");
                        entity.Bindings.Remove(target);
                    });
                }
                else
                {
                    var toRemove = entity.Bindings.Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityLookupTableBinding.GetLookupTableBinding(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(LookupTable), columnName: nameof(request.Bindings)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Bindings)} from {nameof(LookupTable)}");
                        entity.Bindings.Remove(target);
                    });
                }
                if(DocPermissionFactory.IsRequested<List<Reference>>(request, pBindings, nameof(request.Bindings)) && !request.VisibleFields.Matches(nameof(request.Bindings), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Bindings));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<List<Reference>>(currentUser, request, pCategories, permission, DocConstantModelName.LOOKUPTABLE, nameof(request.Categories)))
            {
                if (true == pCategories?.Any() )
                {
                    var requestedCategories = pCategories.Select(p => p.Id).Distinct().ToList();
                    var existsCategories = Execute.SelectAll<DocEntityLookupCategory>().Where(e => e.Id.In(requestedCategories)).Select( e => e.Id ).ToList();
                    if (existsCategories.Count != requestedCategories.Count)
                    {
                        var nonExists = requestedCategories.Where(id => existsCategories.All(eId => eId != id));
                        throw new HttpError(HttpStatusCode.NotFound, $"Cannot patch collection Categories with objects that do not exist. No matching Categories(s) could be found for Ids: {nonExists.ToDelimitedString()}.");
                    }
                    var toAdd = requestedCategories.Where(id => entity.Categories.All(e => e.Id != id)).ToList(); 
                    toAdd?.ForEach(id =>
                    {
                        var target = DocEntityLookupCategory.GetLookupCategory(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD, targetEntity: target, targetName: nameof(LookupTable), columnName: nameof(request.Categories)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to add {nameof(request.Categories)} to {nameof(LookupTable)}");
                        entity.Categories.Add(target);
                    });
                    var toRemove = entity.Categories.Where(e => requestedCategories.All(id => e.Id != id)).Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityLookupCategory.GetLookupCategory(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(LookupTable), columnName: nameof(request.Categories)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Categories)} from {nameof(LookupTable)}");
                        entity.Categories.Remove(target);
                    });
                }
                else
                {
                    var toRemove = entity.Categories.Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityLookupCategory.GetLookupCategory(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(LookupTable), columnName: nameof(request.Categories)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Categories)} from {nameof(LookupTable)}");
                        entity.Categories.Remove(target);
                    });
                }
                if(DocPermissionFactory.IsRequested<List<Reference>>(request, pCategories, nameof(request.Categories)) && !request.VisibleFields.Matches(nameof(request.Categories), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Categories));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<List<Reference>>(currentUser, request, pDocuments, permission, DocConstantModelName.LOOKUPTABLE, nameof(request.Documents)))
            {
                if (true == pDocuments?.Any() )
                {
                    var requestedDocuments = pDocuments.Select(p => p.Id).Distinct().ToList();
                    var existsDocuments = Execute.SelectAll<DocEntityDocument>().Where(e => e.Id.In(requestedDocuments)).Select( e => e.Id ).ToList();
                    if (existsDocuments.Count != requestedDocuments.Count)
                    {
                        var nonExists = requestedDocuments.Where(id => existsDocuments.All(eId => eId != id));
                        throw new HttpError(HttpStatusCode.NotFound, $"Cannot patch collection Documents with objects that do not exist. No matching Documents(s) could be found for Ids: {nonExists.ToDelimitedString()}.");
                    }
                    var toAdd = requestedDocuments.Where(id => entity.Documents.All(e => e.Id != id)).ToList(); 
                    toAdd?.ForEach(id =>
                    {
                        var target = DocEntityDocument.GetDocument(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD, targetEntity: target, targetName: nameof(LookupTable), columnName: nameof(request.Documents)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to add {nameof(request.Documents)} to {nameof(LookupTable)}");
                        entity.Documents.Add(target);
                    });
                    var toRemove = entity.Documents.Where(e => requestedDocuments.All(id => e.Id != id)).Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityDocument.GetDocument(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(LookupTable), columnName: nameof(request.Documents)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Documents)} from {nameof(LookupTable)}");
                        entity.Documents.Remove(target);
                    });
                }
                else
                {
                    var toRemove = entity.Documents.Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityDocument.GetDocument(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(LookupTable), columnName: nameof(request.Documents)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Documents)} from {nameof(LookupTable)}");
                        entity.Documents.Remove(target);
                    });
                }
                if(DocPermissionFactory.IsRequested<List<Reference>>(request, pDocuments, nameof(request.Documents)) && !request.VisibleFields.Matches(nameof(request.Documents), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Documents));
                }
            }
            DocPermissionFactory.SetVisibleFields<LookupTable>(currentUser, nameof(LookupTable), request.VisibleFields);
            ret = entity.ToDto();

            var cacheExpires = DocResources.Metadata.GetCacheExpiration(DocConstantModelName.LOOKUPTABLE);
            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.LOOKUPTABLE, cacheExpires);

            return ret;
        }
        public LookupTable Post(LookupTable request)
        {
            if(request == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

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

        public LookupTable Post(LookupTableCopy request)
        {
            LookupTable ret = null;
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    var entity = DocEntityLookupTable.GetLookupTable(request?.Id);
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
                    #region Custom Before copyLookupTable
                    #endregion Custom Before copyLookupTable
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

                    #region Custom After copyLookupTable
                    #endregion Custom After copyLookupTable
                    copy.SaveChanges(DocConstantPermission.ADD);
                    ret = copy.ToDto();
                });
            }
            return ret;
        }

        public List<LookupTable> Put(LookupTableBatch request)
        {
            return Patch(request);
        }

        public LookupTable Put(LookupTable request)
        {
            return Patch(request);
        }
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

        public LookupTable Patch(LookupTable request)
        {
            if(true != (request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the LookupTable to patch.");
            
            request.VisibleFields = request.VisibleFields ?? new List<string>();
            
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

        public void Delete(LookupTable request)
        {
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    if(!(request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, $"No Id provided for delete.");

                    DocCacheClient.RemoveSearch(DocConstantModelName.LOOKUPTABLE);
                    DocCacheClient.RemoveById(request.Id);
                    var en = DocEntityLookupTable.GetLookupTable(request?.Id);

                    if(null == en) throw new HttpError(HttpStatusCode.NotFound, $"No LookupTable could be found for Id {request?.Id}.");
                    if(en.IsRemoved) return;
                
                    if(!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.DELETE))
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have DELETE permission for this route.");
                
                    en.Remove();
                });
            }
        }

        public void Delete(LookupTableSearch request)
        {
            var matches = Get(request) as List<LookupTable>;
            if(true != matches?.Any()) throw new HttpError(HttpStatusCode.NotFound, "No matches for request");
            matches.ForEach(match =>
            {
                Delete(match);
            });
        }
        public object Get(LookupTableJunction request)
        {
            switch(request.Junction.ToLower().TrimAndPruneSpaces())
            {
                    case "lookuptablebinding":
                        return GetJunctionSearchResult<LookupTable, DocEntityLookupTable, DocEntityLookupTableBinding, LookupTableBinding, LookupTableBindingSearch>((int)request.Id, DocConstantModelName.LOOKUPTABLEBINDING, "Bindings", request, (ss) => HostContext.ResolveService<LookupTableBindingService>(Request)?.Get(ss));
                    case "lookupcategory":
                        return GetJunctionSearchResult<LookupTable, DocEntityLookupTable, DocEntityLookupCategory, LookupCategory, LookupCategorySearch>((int)request.Id, DocConstantModelName.LOOKUPCATEGORY, "Categories", request, (ss) => HostContext.ResolveService<LookupCategoryService>(Request)?.Get(ss));
                    case "document":
                        return GetJunctionSearchResult<LookupTable, DocEntityLookupTable, DocEntityDocument, Document, DocumentSearch>((int)request.Id, DocConstantModelName.DOCUMENT, "Documents", request, (ss) => HostContext.ResolveService<DocumentService>(Request)?.Get(ss));
                default:
                    throw new HttpError(HttpStatusCode.NotFound, $"Route for lookuptable/{request.Id}/{request.Junction} was not found");
            }
        }
        public object Post(LookupTableJunction request)
        {
            switch(request.Junction.ToLower().TrimAndPruneSpaces())
            {
                    case "lookuptablebinding":
                        return AddJunction<LookupTable, DocEntityLookupTable, DocEntityLookupTableBinding, LookupTableBinding, LookupTableBindingSearch>((int)request.Id, DocConstantModelName.LOOKUPTABLEBINDING, "Bindings", request);
                    case "lookupcategory":
                        return AddJunction<LookupTable, DocEntityLookupTable, DocEntityLookupCategory, LookupCategory, LookupCategorySearch>((int)request.Id, DocConstantModelName.LOOKUPCATEGORY, "Categories", request);
                    case "document":
                        return AddJunction<LookupTable, DocEntityLookupTable, DocEntityDocument, Document, DocumentSearch>((int)request.Id, DocConstantModelName.DOCUMENT, "Documents", request);
                default:
                    throw new HttpError(HttpStatusCode.NotFound, $"Route for lookuptable/{request.Id}/{request.Junction} was not found");
            }
        }

        public object Delete(LookupTableJunction request)
        {    
            switch(request.Junction.ToLower().TrimAndPruneSpaces())
            {
                    case "lookuptablebinding":
                        return RemoveJunction<LookupTable, DocEntityLookupTable, DocEntityLookupTableBinding, LookupTableBinding, LookupTableBindingSearch>((int)request.Id, DocConstantModelName.LOOKUPTABLEBINDING, "Bindings", request);
                    case "lookupcategory":
                        return RemoveJunction<LookupTable, DocEntityLookupTable, DocEntityLookupCategory, LookupCategory, LookupCategorySearch>((int)request.Id, DocConstantModelName.LOOKUPCATEGORY, "Categories", request);
                    case "document":
                        return RemoveJunction<LookupTable, DocEntityLookupTable, DocEntityDocument, Document, DocumentSearch>((int)request.Id, DocConstantModelName.DOCUMENT, "Documents", request);
                default:
                    throw new HttpError(HttpStatusCode.NotFound, $"Route for lookuptable/{request.Id}/{request.Junction} was not found");
            }
        }
        private LookupTable GetLookupTable(LookupTable request)
        {
            var id = request?.Id;
            LookupTable ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetVisibleFields<LookupTable>(currentUser, "LookupTable", request.VisibleFields);

            DocEntityLookupTable entity = null;
            if(id.HasValue)
            {
                entity = DocEntityLookupTable.GetLookupTable(id.Value);
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
