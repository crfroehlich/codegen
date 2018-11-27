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
    public partial class AttributeCategoryService : DocServiceBase
    {
        public const string CACHE_KEY_PREFIX = DocEntityAttributeCategory.CACHE_KEY_PREFIX;
        private object _GetIdCache(AttributeCategory request)
        {
            object ret = null;

            if (true != request.IgnoreCache)
            {
                var key = currentUser.GetApiCacheKey(DocConstantModelName.ATTRIBUTECATEGORY);
                var cacheKey = $"AttributeCategory_{key}_{request.Id}_{UrnId.Create<AttributeCategory>(request.GetMD5Hash())}";
                ret = Request.ToOptimizedResultUsingCache(Cache, cacheKey, new TimeSpan(0, DocResources.Settings.SessionTimeout, 0), () =>
                {
                    object cachedRet = null;
                    Execute.Run(s =>
                    {
                        cachedRet = GetAttributeCategory(request);
                    });
                    return cachedRet;
                });
            }
            if(null == ret)
            {
                Execute.Run(s =>
                {
                    ret = GetAttributeCategory(request);
                });
            }
            return ret;
        }

        private object _GetSearchCache(AttributeCategorySearch request, DocRequestCancellation requestCancel)
        {
            object tryRet = null;
            var ret = new List<AttributeCategory>();

            //Keys need to be customized to factor in permissions/scoping. Often, including the current user's Role Id is sufficient in the key
            var key = currentUser.GetApiCacheKey(DocConstantModelName.ATTRIBUTECATEGORY);
            var cacheKey = $"{CACHE_KEY_PREFIX}_{key}_{UrnId.Create<AttributeCategorySearch>(request.GetMD5Hash())}";
            tryRet = Request.ToOptimizedResultUsingCache(Cache, cacheKey, new TimeSpan(0, DocResources.Settings.SessionTimeout, 0), () =>
            {
                _ExecSearch(request, (entities) => entities.ConvertFromEntityList<DocEntityAttributeCategory,AttributeCategory>(ret, Execute, requestCancel));
                return ret;
            });

            if(tryRet == null)
            {
                ret = new List<AttributeCategory>();
                _ExecSearch(request, (entities) => entities.ConvertFromEntityList<DocEntityAttributeCategory,AttributeCategory>(ret, Execute, requestCancel));
                return ret;
            }
            else
            {
                return tryRet;
            }
        }
        private void _ExecSearch(AttributeCategorySearch request, Action<IQueryable<DocEntityAttributeCategory>> callBack)
        {
            request = InitSearch(request);
            
            DocPermissionFactory.SetVisibleFields<AttributeCategory>(currentUser, "AttributeCategory", request.VisibleFields);

            Execute.Run( session => 
            {
                var entities = Execute.SelectAll<DocEntityAttributeCategory>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new AttributeCategoryFullTextSearch(request);
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

                if(!DocTools.IsNullOrEmpty(request.DocumentSet) && !DocTools.IsNullOrEmpty(request.DocumentSet.Id))
                {
                    entities = entities.Where(en => en.DocumentSet.Id == request.DocumentSet.Id );
                }
                if(true == request.DocumentSetIds?.Any())
                {
                    entities = entities.Where(en => en.DocumentSet.Id.In(request.DocumentSetIds));
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
                if(!DocTools.IsNullOrEmpty(request.ParentAttributeCategory) && !DocTools.IsNullOrEmpty(request.ParentAttributeCategory.Id))
                {
                    entities = entities.Where(en => en.ParentAttributeCategory.Id == request.ParentAttributeCategory.Id );
                }
                if(true == request.ParentAttributeCategoryIds?.Any())
                {
                    entities = entities.Where(en => en.ParentAttributeCategory.Id.In(request.ParentAttributeCategoryIds));
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
        
        public object Post(AttributeCategorySearch request)
        {
            object tryRet = null;
            using (var cancellableRequest = base.Request.CreateCancellableRequest())
            {
                var requestCancel = new DocRequestCancellation(HttpContext.Current.Response, cancellableRequest);
                try 
                {
                    var ret = new List<AttributeCategory>();
                    var settings = DocResources.Settings;
                    if(true != request.IgnoreCache && settings.Cache.CacheWebServices && true != settings.Cache.ExcludedServicesFromCache?.Any(webservice => webservice.ToLower().Trim() == "attributecategory")) 
                    {
                        tryRet = _GetSearchCache(request, requestCancel);
                    }
                    if (tryRet == null)
                    {
                        _ExecSearch(request, (entities) => entities.ConvertFromEntityList<DocEntityAttributeCategory,AttributeCategory>(ret, Execute, requestCancel));
                        tryRet = ret;
                    }
                }
                catch(Exception) { throw; }
                finally
                {
                    requestCancel?.CloseRequest();
                }
            }
            return tryRet;
        }

        public object Get(AttributeCategorySearch request)
        {
            object tryRet = null;
            using (var cancellableRequest = base.Request.CreateCancellableRequest())
            {
                var requestCancel = new DocRequestCancellation(HttpContext.Current.Response, cancellableRequest);
                try 
                {
                    var ret = new List<AttributeCategory>();
                    var settings = DocResources.Settings;
                    if(true != request.IgnoreCache && settings.Cache.CacheWebServices && true != settings.Cache.ExcludedServicesFromCache?.Any(webservice => webservice.ToLower().Trim() == "attributecategory")) 
                    {
                        tryRet = _GetSearchCache(request, requestCancel);
                    }
                    if (tryRet == null)
                    {
                        _ExecSearch(request, (entities) => entities.ConvertFromEntityList<DocEntityAttributeCategory,AttributeCategory>(ret, Execute, requestCancel));
                        tryRet = ret;
                    }
                }
                catch(Exception) { throw; }
                finally
                {
                    requestCancel?.CloseRequest();
                }
            }
            return tryRet;
        }

        public object Post(AttributeCategoryVersion request) 
        {
            return Get(request);
        }

        public object Get(AttributeCategoryVersion request) 
        {
            var ret = new List<Version>();
            _ExecSearch(request, (entities) => 
            {
                ret = entities.Select(e => new Version(e.Id, e.VersionNo)).ToList();
            });
            return ret;
        }

        public object Get(AttributeCategory request)
        {
            AttributeCategory ret = null;
            
            if(!(request.Id > 0))
                throw new HttpError(HttpStatusCode.NotFound, "Valid Id required.");

            DocPermissionFactory.SetVisibleFields<AttributeCategory>(currentUser, "AttributeCategory", request.VisibleFields);
            var settings = DocResources.Settings;
            if(true != request.IgnoreCache && settings.Cache.CacheWebServices && true != settings.Cache.ExcludedServicesFromCache?.Any(webservice => webservice.ToLower().Trim() == "attributecategory")) 
            {
                return _GetIdCache(request);
            }
            else 
            {
                Execute.Run((ssn) =>
                {
                    ret = GetAttributeCategory(request);
                });
            }
            return ret;
        }

        private AttributeCategory _AssignValues(AttributeCategory dtoSource, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (dtoSource == null || dtoSource.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "AttributeCategory"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            dtoSource.VisibleFields = dtoSource.VisibleFields ?? new List<string>();

            AttributeCategory ret = null;
            dtoSource = _InitAssignValues(dtoSource, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && dtoSource.Id > 0) return dtoSource;
            
            //First, assign all the variables, do database lookups and conversions
            var pDocumentSet = (dtoSource.DocumentSet?.Id > 0) ? DocEntityDocumentSet.GetDocumentSet(dtoSource.DocumentSet.Id) : null;
            DocEntityLookupTable pName = GetLookup(DocConstantLookupTable.ATTRIBUTECATEGORY, dtoSource.Name?.Name, dtoSource.Name?.Id);
            var pParentAttributeCategory = (dtoSource.ParentAttributeCategory?.Id > 0) ? DocEntityAttributeCategory.GetAttributeCategory(dtoSource.ParentAttributeCategory.Id) : null;

            DocEntityAttributeCategory entity = null;
            if(permission == DocConstantPermission.ADD)
            {
                var now = DateTime.UtcNow;
                entity = new DocEntityAttributeCategory(session)
                {
                    Created = now,
                    Updated = now
                };
            }
            else
            {
                entity = DocEntityAttributeCategory.GetAttributeCategory(dtoSource.Id);
                if(null == entity)
                    throw new HttpError(HttpStatusCode.NotFound, $"No record");
            }

            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityDocumentSet>(currentUser, dtoSource, pDocumentSet, permission, DocConstantModelName.ATTRIBUTECATEGORY, nameof(dtoSource.DocumentSet)))
            {
                if(DocPermissionFactory.IsRequested(dtoSource, pDocumentSet, entity.DocumentSet, nameof(dtoSource.DocumentSet)))
                    entity.DocumentSet = pDocumentSet;
                if(DocPermissionFactory.IsRequested<DocEntityDocumentSet>(dtoSource, pDocumentSet, nameof(dtoSource.DocumentSet)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.DocumentSet), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.DocumentSet));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityLookupTable>(currentUser, dtoSource, pName, permission, DocConstantModelName.ATTRIBUTECATEGORY, nameof(dtoSource.Name)))
            {
                if(DocPermissionFactory.IsRequested(dtoSource, pName, entity.Name, nameof(dtoSource.Name)))
                    entity.Name = pName;
                if(DocPermissionFactory.IsRequested<DocEntityLookupTable>(dtoSource, pName, nameof(dtoSource.Name)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.Name), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.Name));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityAttributeCategory>(currentUser, dtoSource, pParentAttributeCategory, permission, DocConstantModelName.ATTRIBUTECATEGORY, nameof(dtoSource.ParentAttributeCategory)))
            {
                if(DocPermissionFactory.IsRequested(dtoSource, pParentAttributeCategory, entity.ParentAttributeCategory, nameof(dtoSource.ParentAttributeCategory)))
                    entity.ParentAttributeCategory = pParentAttributeCategory;
                if(DocPermissionFactory.IsRequested<DocEntityAttributeCategory>(dtoSource, pParentAttributeCategory, nameof(dtoSource.ParentAttributeCategory)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.ParentAttributeCategory), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.ParentAttributeCategory));
                }
            }
            
            if (dtoSource.Locked) entity.Locked = dtoSource.Locked;

            entity.SaveChanges(permission);
            
            DocPermissionFactory.SetVisibleFields<AttributeCategory>(currentUser, nameof(AttributeCategory), dtoSource.VisibleFields);
            ret = entity.ToDto();

            return ret;
        }
        public AttributeCategory Post(AttributeCategory dtoSource)
        {
            if(dtoSource == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            dtoSource.VisibleFields = dtoSource.VisibleFields ?? new List<string>();

            AttributeCategory ret = null;

            Execute.Run(ssn =>
            {
                if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "AttributeCategory")) 
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                ret = _AssignValues(dtoSource, DocConstantPermission.ADD, ssn);
            });

            return ret;
        }
   
        public List<AttributeCategory> Post(AttributeCategoryBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<AttributeCategory>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Post(dto) as AttributeCategory;
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

        public AttributeCategory Post(AttributeCategoryCopy request)
        {
            AttributeCategory ret = null;
            Execute.Run(ssn =>
            {
                var entity = DocEntityAttributeCategory.GetAttributeCategory(request?.Id);
                if(null == entity) throw new HttpError(HttpStatusCode.NoContent, "The COPY request did not succeed.");
                if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");
                
                    var pDocumentSet = entity.DocumentSet;
                    var pName = entity.Name;
                    var pParentAttributeCategory = entity.ParentAttributeCategory;
                #region Custom Before copyAttributeCategory
                #endregion Custom Before copyAttributeCategory
                var copy = new DocEntityAttributeCategory(ssn)
                {
                    Hash = Guid.NewGuid()
                                , DocumentSet = pDocumentSet
                                , Name = pName
                                , ParentAttributeCategory = pParentAttributeCategory
                };
                #region Custom After copyAttributeCategory
                #endregion Custom After copyAttributeCategory
                copy.SaveChanges(DocConstantPermission.ADD);
                ret = copy.ToDto();
            });
            return ret;
        }


        public List<AttributeCategory> Put(AttributeCategoryBatch request)
        {
            return Patch(request);
        }

        public AttributeCategory Put(AttributeCategory dtoSource)
        {
            return Patch(dtoSource);
        }

        public List<AttributeCategory> Patch(AttributeCategoryBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<AttributeCategory>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Patch(dto) as AttributeCategory;
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

        public AttributeCategory Patch(AttributeCategory dtoSource)
        {
            if(true != (dtoSource?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the AttributeCategory to patch.");
            
            dtoSource.VisibleFields = dtoSource.VisibleFields ?? new List<string>();
            
            AttributeCategory ret = null;
            Execute.Run(ssn =>
            {
                ret = _AssignValues(dtoSource, DocConstantPermission.EDIT, ssn);
            });
            return ret;
        }

        public void Delete(AttributeCategoryBatch request)
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

        public void Delete(AttributeCategory request)
        {
            Execute.Run(ssn =>
            {
                var en = DocEntityAttributeCategory.GetAttributeCategory(request?.Id);

                if(null == en) throw new HttpError(HttpStatusCode.NotFound, $"No AttributeCategory could be found for Id {request?.Id}.");
                if(en.IsRemoved) return;
                
                if(!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.DELETE))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have DELETE permission for this route.");
                
                en.Remove();
            });
        }

        public void Delete(AttributeCategorySearch request)
        {
            var matches = Get(request) as List<AttributeCategory>;
            if(true != matches?.Any()) throw new HttpError(HttpStatusCode.NotFound, "No matches for request");

            Execute.Run(ssn =>
            {
                matches.ForEach(match =>
                {
                    Delete(match);
                });
            });
        }

        private AttributeCategory GetAttributeCategory(AttributeCategory request)
        {
            var id = request?.Id;
            AttributeCategory ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetVisibleFields<AttributeCategory>(currentUser, "AttributeCategory", request.VisibleFields);

            DocEntityAttributeCategory entity = null;
            if(id.HasValue)
            {
                entity = DocEntityAttributeCategory.GetAttributeCategory(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No AttributeCategory found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }

        public List<int> Any(AttributeCategoryIds request)
        {
            List<int> ret = null;
            if (currentUser.IsSuperAdmin)
            {
                Execute.Run(s => { ret = Execute.SelectAll<DocEntityAttributeCategory>().Select(d => d.Id).ToList(); });
            }
            else
            {
                throw new HttpError(HttpStatusCode.Forbidden);
            }

            return ret;
        }
    }
}