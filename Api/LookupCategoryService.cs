﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when
//    the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AutoMapper;

using Services.Core;
using Services.Db;
using Services.Dto;
using Services.Enums;
using Services.Models;
using Services.Schema;

using Typed;
using Typed.Bindings;
using Typed.Notifications;
using Typed.Settings;

using ServiceStack;
using ServiceStack.Text;

using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Dynamic;
using System.Net;
using System.Web;

using Xtensive.Orm;
using Xtensive.Orm.Model;

using Attribute = Services.Dto.Attribute;
using ValueType = Services.Dto.ValueType;
using Version = Services.Dto.Version;

namespace Services.API
{
    public partial class LookupCategoryService : DocServiceBase
    {
        private void _ExecSearch(LookupCategorySearch request, Action<IQueryable<DocEntityLookupCategory>> callBack)
        {
            request = InitSearch(request);
            
            DocPermissionFactory.SetVisibleFields<LookupCategory>(currentUser, "LookupCategory", request.VisibleFields);

            Execute.Run( session => 
            {
                var entities = Execute.SelectAll<DocEntityLookupCategory>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new LookupCategoryFullTextSearch(request);
                    entities = GetFullTextSearch(fts, entities);
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

                if(!DocTools.IsNullOrEmpty(request.Category))
                    entities = entities.Where(en => en.Category.Contains(request.Category));
                if(!DocTools.IsNullOrEmpty(request.Enum) && !DocTools.IsNullOrEmpty(request.Enum.Id))
                {
                    entities = entities.Where(en => en.Enum.Id == request.Enum.Id );
                }
                if(true == request.EnumIds?.Any())
                {
                    entities = entities.Where(en => en.Enum.Id.In(request.EnumIds));
                }
                        if(true == request.LookupsIds?.Any())
                        {
                            entities = entities.Where(en => en.Lookups.Any(r => r.Id.In(request.LookupsIds)));
                        }

                entities = ApplyFilters(request, entities);

                if(request.Skip > 0)
                    entities = entities.Skip(request.Skip.Value);
                if(request.Take > 0)
                    entities = entities.Take(request.Take.Value);
                if(true == request?.OrderBy?.Any())
                    entities = entities.OrderBy(request.OrderBy);
                if(true == request?.OrderByDesc?.Any())
                    entities = entities.OrderByDescending(request.OrderByDesc);
                callBack?.Invoke(entities);
            });
        }
        
        public object Post(LookupCategorySearch request)
        {
            return Get(request);
        }

        public object Get(LookupCategorySearch request)
        {
            object tryRet = null;
            var ret = new List<LookupCategory>();
            var cacheKey = GetApiCacheKey<LookupCategory>(DocConstantModelName.LOOKUPCATEGORY, nameof(LookupCategory), request);
            using (var cancellableRequest = base.Request.CreateCancellableRequest())
            {
                var requestCancel = new DocRequestCancellation(HttpContext.Current.Response, cancellableRequest);
                try 
                {
                    if(true != request.IgnoreCache) 
                    {
                        tryRet = Request.ToOptimizedResultUsingCache(Cache, cacheKey, new TimeSpan(0, DocResources.Settings.SessionTimeout, 0), () =>
                        {
                            _ExecSearch(request, (entities) => entities.ConvertFromEntityList<DocEntityLookupCategory,LookupCategory>(ret, Execute, requestCancel));
                            return ret;
                        });
                    }
                    if (tryRet == null)
                    {
                        _ExecSearch(request, (entities) => entities.ConvertFromEntityList<DocEntityLookupCategory,LookupCategory>(ret, Execute, requestCancel));
                        tryRet = ret;
                        //Go ahead and cache the result for any future consumers
                        DocCacheClient.Set(key: cacheKey, value: ret, entityType: DocConstantModelName.LOOKUPCATEGORY, search: true);
                    }
                }
                catch(Exception) { throw; }
                finally
                {
                    requestCancel?.CloseRequest();
                }
            }
            DocCacheClient.SyncKeys(key: cacheKey, entityType: DocConstantModelName.LOOKUPCATEGORY, search: true);
            return tryRet;
        }

        public object Post(LookupCategoryVersion request) 
        {
            return Get(request);
        }

        public object Get(LookupCategoryVersion request) 
        {
            var ret = new List<Version>();
            _ExecSearch(request, (entities) => 
            {
                ret = entities.Select(e => new Version(e.Id, e.VersionNo)).ToList();
            });
            return ret;
        }

        public object Get(LookupCategory request)
        {
            object ret = null;
            
            if(!(request.Id > 0))
                throw new HttpError(HttpStatusCode.NotFound, "Valid Id required.");

            DocPermissionFactory.SetVisibleFields<LookupCategory>(currentUser, "LookupCategory", request.VisibleFields);
            var cacheKey = GetApiCacheKey<LookupCategory>(DocConstantModelName.LOOKUPCATEGORY, nameof(LookupCategory), request);
            if (true != request.IgnoreCache)
            {
                ret = Request.ToOptimizedResultUsingCache(Cache, cacheKey, new TimeSpan(0, DocResources.Settings.SessionTimeout, 0), () =>
                {
                    object cachedRet = null;
                    Execute.Run(s =>
                    {
                        cachedRet = GetLookupCategory(request);
                    });
                    DocCacheClient.Set(key: cacheKey, value: cachedRet, entityId: request.Id, entityType: DocConstantModelName.LOOKUPCATEGORY);
                    return cachedRet;
                });
            }
            if(null == ret)
            {
                Execute.Run(s =>
                {
                    ret = GetLookupCategory(request);
                    DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.LOOKUPCATEGORY);
                });
            }
            DocCacheClient.SyncKeys(key: cacheKey, entityId: request.Id, entityType: DocConstantModelName.LOOKUPCATEGORY);
            return ret;
        }

        private LookupCategory _AssignValues(LookupCategory request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "LookupCategory"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            LookupCategory ret = null;
            request = _InitAssignValues(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            var cacheKey = GetApiCacheKey<LookupCategory>(DocConstantModelName.LOOKUPCATEGORY, nameof(LookupCategory), request);
            
            //First, assign all the variables, do database lookups and conversions
            var pCategory = request.Category;
            var pEnum = DocEntityLookupTableEnum.GetLookupTableEnum(request.Enum);
            var pLookups = request.Lookups?.ToList();

            DocEntityLookupCategory entity = null;
            if(permission == DocConstantPermission.ADD)
            {
                var now = DateTime.UtcNow;
                entity = new DocEntityLookupCategory(session)
                {
                    Created = now,
                    Updated = now
                };
            }
            else
            {
                entity = DocEntityLookupCategory.GetLookupCategory(request.Id);
                if(null == entity)
                    throw new HttpError(HttpStatusCode.NotFound, $"No record");
            }

            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pCategory, permission, DocConstantModelName.LOOKUPCATEGORY, nameof(request.Category)))
            {
                if(DocPermissionFactory.IsRequested(request, pCategory, entity.Category, nameof(request.Category)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Category)} cannot be modified once set.");
                    entity.Category = pCategory;
                if(DocPermissionFactory.IsRequested<string>(request, pCategory, nameof(request.Category)) && !request.VisibleFields.Matches(nameof(request.Category), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Category));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityLookupTableEnum>(currentUser, request, pEnum, permission, DocConstantModelName.LOOKUPCATEGORY, nameof(request.Enum)))
            {
                if(DocPermissionFactory.IsRequested(request, pEnum, entity.Enum, nameof(request.Enum)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Enum)} cannot be modified once set.");
                    entity.Enum = pEnum;
                if(DocPermissionFactory.IsRequested<DocEntityLookupTableEnum>(request, pEnum, nameof(request.Enum)) && !request.VisibleFields.Matches(nameof(request.Enum), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Enum));
                }
            }
            
            if (request.Locked) entity.Locked = request.Locked;

            entity.SaveChanges(permission);
            
            if (DocPermissionFactory.IsRequestedHasPermission<List<Reference>>(currentUser, request, pLookups, permission, DocConstantModelName.LOOKUPCATEGORY, nameof(request.Lookups)))
            {
                if (true == pLookups?.Any() )
                {
                    var requestedLookups = pLookups.Select(p => p.Id).Distinct().ToList();
                    var existsLookups = Execute.SelectAll<DocEntityLookupTable>().Where(e => e.Id.In(requestedLookups)).Select( e => e.Id ).ToList();
                    if (existsLookups.Count != requestedLookups.Count)
                    {
                        var nonExists = requestedLookups.Where(id => existsLookups.All(eId => eId != id));
                        throw new HttpError(HttpStatusCode.NotFound, $"Cannot patch collection Lookups with objects that do not exist. No matching Lookups(s) could be found for Ids: {nonExists.ToDelimitedString()}.");
                    }
                    var toAdd = requestedLookups.Where(id => entity.Lookups.All(e => e.Id != id)).ToList(); 
                    toAdd?.ForEach(id =>
                    {
                        var target = DocEntityLookupTable.GetLookupTable(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD, targetEntity: target, targetName: nameof(LookupCategory), columnName: nameof(request.Lookups)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to add {nameof(request.Lookups)} to {nameof(LookupCategory)}");
                        entity.Lookups.Add(target);
                    });
                    var toRemove = entity.Lookups.Where(e => requestedLookups.All(id => e.Id != id)).Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityLookupTable.GetLookupTable(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(LookupCategory), columnName: nameof(request.Lookups)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Lookups)} from {nameof(LookupCategory)}");
                        entity.Lookups.Remove(target);
                    });
                }
                else
                {
                    var toRemove = entity.Lookups.Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityLookupTable.GetLookupTable(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(LookupCategory), columnName: nameof(request.Lookups)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Lookups)} from {nameof(LookupCategory)}");
                        entity.Lookups.Remove(target);
                    });
                }
                if(DocPermissionFactory.IsRequested<List<Reference>>(request, pLookups, nameof(request.Lookups)) && !request.VisibleFields.Matches(nameof(request.Lookups), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Lookups));
                }
            }
            DocPermissionFactory.SetVisibleFields<LookupCategory>(currentUser, nameof(LookupCategory), request.VisibleFields);
            ret = entity.ToDto();

            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.LOOKUPCATEGORY);

            return ret;
        }
        public LookupCategory Post(LookupCategory request)
        {
            if(request == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            LookupCategory ret = null;

            Execute.Run(ssn =>
            {
                if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "LookupCategory")) 
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                ret = _AssignValues(request, DocConstantPermission.ADD, ssn);
            });

            return ret;
        }
   
        public List<LookupCategory> Post(LookupCategoryBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<LookupCategory>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Post(dto) as LookupCategory;
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

        public LookupCategory Post(LookupCategoryCopy request)
        {
            LookupCategory ret = null;
            Execute.Run(ssn =>
            {
                var entity = DocEntityLookupCategory.GetLookupCategory(request?.Id);
                if(null == entity) throw new HttpError(HttpStatusCode.NoContent, "The COPY request did not succeed.");
                if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");
                
                    var pCategory = entity.Category;
                    if(!DocTools.IsNullOrEmpty(pCategory))
                        pCategory += " (Copy)";
                    var pEnum = entity.Enum;
                    var pLookups = entity.Lookups.ToList();
                #region Custom Before copyLookupCategory
                #endregion Custom Before copyLookupCategory
                var copy = new DocEntityLookupCategory(ssn)
                {
                    Hash = Guid.NewGuid()
                                , Category = pCategory
                                , Enum = pEnum
                };
                            foreach(var item in pLookups)
                            {
                                entity.Lookups.Add(item);
                            }

                #region Custom After copyLookupCategory
                #endregion Custom After copyLookupCategory
                copy.SaveChanges(DocConstantPermission.ADD);
                ret = copy.ToDto();
            });
            return ret;
        }


        public List<LookupCategory> Put(LookupCategoryBatch request)
        {
            return Patch(request);
        }

        public LookupCategory Put(LookupCategory request)
        {
            return Patch(request);
        }

        public List<LookupCategory> Patch(LookupCategoryBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<LookupCategory>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Patch(dto) as LookupCategory;
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

        public LookupCategory Patch(LookupCategory request)
        {
            if(true != (request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the LookupCategory to patch.");
            
            request.VisibleFields = request.VisibleFields ?? new List<string>();
            
            LookupCategory ret = null;
            Execute.Run(ssn =>
            {
                ret = _AssignValues(request, DocConstantPermission.EDIT, ssn);
            });
            return ret;
        }

        public void Delete(LookupCategoryBatch request)
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

        public void Delete(LookupCategory request)
        {
            Execute.Run(ssn =>
            {
                if(!(request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, $"No Id provided for delete.");

                DocCacheClient.RemoveSearch(DocConstantModelName.LOOKUPCATEGORY);
                DocCacheClient.RemoveById(request.Id);
                var en = DocEntityLookupCategory.GetLookupCategory(request?.Id);

                if(null == en) throw new HttpError(HttpStatusCode.NotFound, $"No LookupCategory could be found for Id {request?.Id}.");
                if(en.IsRemoved) return;
                
                if(!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.DELETE))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have DELETE permission for this route.");
                
                en.Remove();
            });
        }

        public void Delete(LookupCategorySearch request)
        {
            var matches = Get(request) as List<LookupCategory>;
            if(true != matches?.Any()) throw new HttpError(HttpStatusCode.NotFound, "No matches for request");

            Execute.Run(ssn =>
            {
                matches.ForEach(match =>
                {
                    Delete(match);
                });
            });
        }
        public object Get(LookupCategoryJunction request)
        {
            if(!(request.Id > 0))
                throw new HttpError(HttpStatusCode.NotFound, "Valid Id required.");
            object ret = null;
            var skip = (request.Skip > 0) ? request.Skip.Value : 0;
            var take = (request.Take > 0) ? request.Take.Value : int.MaxValue;
                        
            var info = Request.PathInfo.Split('?')[0].Split('/');
            var method = info[info.Length-1]?.ToLower().Trim();
            Execute.Run( s => 
            {
                switch(method)
                {
                case "lookuptable":
                    ret = _GetLookupCategoryLookupTable(request, skip, take);
                    break;
                }
            });
            return ret;
        }
        
        public object Get(LookupCategoryJunctionVersion request)
        {
            if(!(request.Id > 0))
                throw new HttpError(HttpStatusCode.NotFound, "Valid Id required.");
            var ret = new List<Version>();
            
            var info = Request.PathInfo.Split('?')[0].Split('/');
            var method = info[info.Length-2]?.ToLower().Trim();
            Execute.Run( ssn =>
            {
                switch(method)
                {
                case "lookuptable":
                    ret = GetLookupCategoryLookupTableVersion(request);
                    break;
                }
            });
            return ret;
        }
        

        private object _GetLookupCategoryLookupTable(LookupCategoryJunction request, int skip, int take)
        {
             DocPermissionFactory.SetVisibleFields<LookupTable>(currentUser, "LookupTable", request.VisibleFields);
             var en = DocEntityLookupCategory.GetLookupCategory(request.Id);
             if (!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.VIEW, targetName: DocConstantModelName.LOOKUPCATEGORY, columnName: "Lookups", targetEntity: null))
                 throw new HttpError(HttpStatusCode.Forbidden, "You do not have View permission to relationships between LookupCategory and LookupTable");
             return en?.Lookups.Take(take).Skip(skip).ConvertFromEntityList<DocEntityLookupTable,LookupTable>(new List<LookupTable>());
        }

        private List<Version> GetLookupCategoryLookupTableVersion(LookupCategoryJunctionVersion request)
        { 
            if(!(request.Id > 0))
                throw new HttpError(HttpStatusCode.NotFound, "Valid Id required.");
            var ret = new List<Version>();
             Execute.Run((ssn) =>
             {
                var en = DocEntityLookupCategory.GetLookupCategory(request.Id);
                ret = en?.Lookups.Select(e => new Version(e.Id, e.VersionNo)).ToList();
             });
            return ret;
        }
        
        public object Post(LookupCategoryJunction request)
        {
            if (request == null)
                throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");
            if (!(request.Id > 0))
                throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the {className} to update.");
            if (request.Ids == null || request.Ids.Count < 1)
                throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid list of {type} Ids.");

            object ret = null;

            Execute.Run( ssn =>
            {
                var info = Request.PathInfo.Split('/');
                var method = info[info.Length-1];
                switch(method)
                {
                case "lookuptable":
                    ret = _PostLookupCategoryLookupTable(request);
                    break;
                }
            });
            return ret;
        }


        private object _PostLookupCategoryLookupTable(LookupCategoryJunction request)
        {
            var entity = DocEntityLookupCategory.GetLookupCategory(request.Id);

            if (null == entity) throw new HttpError(HttpStatusCode.NotFound, $"No LookupCategory found for Id {request.Id}");

            if (!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.EDIT))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have Edit permission to LookupCategory");

            foreach (var id in request.Ids)
            {
                var relationship = DocEntityLookupTable.GetLookupTable(id);
                if (!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD, targetEntity: relationship, targetName: DocConstantModelName.LOOKUPTABLE, columnName: "Lookups")) 
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have Add permission to the Lookups property.");
                if (null == relationship) throw new HttpError(HttpStatusCode.NotFound, $"Cannot post to collection of LookupCategory with objects that do not exist. No matching LookupTable could be found for {id}.");
                entity.Lookups.Add(relationship);
            }
            entity.SaveChanges();
            return entity.ToDto();
        }

        public object Delete(LookupCategoryJunction request)
        {
            if (request == null)
                throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");
            if (!(request.Id > 0))
                throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the {className} to update.");
            if (request.Ids == null || request.Ids.Count < 1)
                throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid list of {type} Ids.");

            object ret = null;

            Execute.Run( ssn =>
            {
                var info = Request.PathInfo.Split('/');
                var method = info[info.Length-1];
                switch(method)
                {
                case "lookuptable":
                    ret = _DeleteLookupCategoryLookupTable(request);
                    break;
                }
            });
            return ret;
        }


        private object _DeleteLookupCategoryLookupTable(LookupCategoryJunction request)
        {
            var entity = DocEntityLookupCategory.GetLookupCategory(request.Id);

            if (null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No LookupCategory found for Id {request.Id}");
            if (!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.EDIT))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have Edit permission to LookupCategory");
            foreach (var id in request.Ids)
            {
                var relationship = DocEntityLookupTable.GetLookupTable(id);
                if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: relationship, targetName: DocConstantModelName.LOOKUPTABLE, columnName: "Lookups"))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have Edit permission to relationships between LookupCategory and LookupTable");
                if(null != relationship && false == relationship.IsRemoved) entity.Lookups.Remove(relationship);
            }
            entity.SaveChanges();
            return entity.ToDto();
        }

        private LookupCategory GetLookupCategory(LookupCategory request)
        {
            var id = request?.Id;
            LookupCategory ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetVisibleFields<LookupCategory>(currentUser, "LookupCategory", request.VisibleFields);

            DocEntityLookupCategory entity = null;
            if(id.HasValue)
            {
                entity = DocEntityLookupCategory.GetLookupCategory(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No LookupCategory found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }

        public List<int> Any(LookupCategoryIds request)
        {
            List<int> ret = null;
            if (currentUser.IsSuperAdmin)
            {
                Execute.Run(s => { ret = Execute.SelectAll<DocEntityLookupCategory>().Select(d => d.Id).ToList(); });
            }
            else
            {
                throw new HttpError(HttpStatusCode.Forbidden);
            }

            return ret;
        }
    }
}