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
    public partial class TermCategoryService : DocServiceBase
    {
        public const string CACHE_KEY_PREFIX = DocEntityTermCategory.CACHE_KEY_PREFIX;
        private object _GetIdCache(TermCategory request)
        {
            object ret = null;

            if (true != request.IgnoreCache)
            {
                var key = currentUser.GetApiCacheKey(DocConstantModelName.TERMCATEGORY);
                var cacheKey = $"TermCategory_{key}_{request.Id}_{UrnId.Create<TermCategory>(request.GetMD5Hash())}";
                ret = Request.ToOptimizedResultUsingCache(Cache, cacheKey, new TimeSpan(0, DocResources.Settings.SessionTimeout, 0), () =>
                {
                    object cachedRet = null;
                    Execute.Run(s =>
                    {
                        cachedRet = GetTermCategory(request);
                    });
                    return cachedRet;
                });
            }
            if(null == ret)
            {
                Execute.Run(s =>
                {
                    ret = GetTermCategory(request);
                });
            }
            return ret;
        }

        private object _GetSearchCache(TermCategorySearch request, DocRequestCancellation requestCancel)
        {
            object tryRet = null;
            var ret = new List<TermCategory>();

            //Keys need to be customized to factor in permissions/scoping. Often, including the current user's Role Id is sufficient in the key
            var key = currentUser.GetApiCacheKey(DocConstantModelName.TERMCATEGORY);
            var cacheKey = $"{CACHE_KEY_PREFIX}_{key}_{UrnId.Create<TermCategorySearch>(request.GetMD5Hash())}";
            tryRet = Request.ToOptimizedResultUsingCache(Cache, cacheKey, new TimeSpan(0, DocResources.Settings.SessionTimeout, 0), () =>
            {
                _ExecSearch(request, (entities) => entities.ConvertFromEntityList<DocEntityTermCategory,TermCategory>(ret, Execute, requestCancel));
                return ret;
            });

            if(tryRet == null)
            {
                ret = new List<TermCategory>();
                _ExecSearch(request, (entities) => entities.ConvertFromEntityList<DocEntityTermCategory,TermCategory>(ret, Execute, requestCancel));
                return ret;
            }
            else
            {
                return tryRet;
            }
        }
        private void _ExecSearch(TermCategorySearch request, Action<IQueryable<DocEntityTermCategory>> callBack)
        {
            request = InitSearch(request);
            
            DocPermissionFactory.SetVisibleFields<TermCategory>(currentUser, "TermCategory", request.VisibleFields);

            Execute.Run( session => 
            {
                var entities = Execute.SelectAll<DocEntityTermCategory>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new TermCategoryFullTextSearch(request);
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
                        if(true == request.TermsIds?.Any())
                        {
                            entities = entities.Where(en => en.Terms.Any(r => r.Id.In(request.TermsIds)));
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
        
        public object Post(TermCategorySearch request)
        {
            object tryRet = null;
            using (var cancellableRequest = base.Request.CreateCancellableRequest())
            {
                var requestCancel = new DocRequestCancellation(HttpContext.Current.Response, cancellableRequest);
                try 
                {
                    var ret = new List<TermCategory>();
                    var settings = DocResources.Settings;
                    if(true != request.IgnoreCache && settings.Cache.CacheWebServices && true != settings.Cache.ExcludedServicesFromCache?.Any(webservice => webservice.ToLower().Trim() == "termcategory")) 
                    {
                        tryRet = _GetSearchCache(request, requestCancel);
                    }
                    if (tryRet == null)
                    {
                        _ExecSearch(request, (entities) => entities.ConvertFromEntityList<DocEntityTermCategory,TermCategory>(ret, Execute, requestCancel));
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

        public object Get(TermCategorySearch request)
        {
            object tryRet = null;
            using (var cancellableRequest = base.Request.CreateCancellableRequest())
            {
                var requestCancel = new DocRequestCancellation(HttpContext.Current.Response, cancellableRequest);
                try 
                {
                    var ret = new List<TermCategory>();
                    var settings = DocResources.Settings;
                    if(true != request.IgnoreCache && settings.Cache.CacheWebServices && true != settings.Cache.ExcludedServicesFromCache?.Any(webservice => webservice.ToLower().Trim() == "termcategory")) 
                    {
                        tryRet = _GetSearchCache(request, requestCancel);
                    }
                    if (tryRet == null)
                    {
                        _ExecSearch(request, (entities) => entities.ConvertFromEntityList<DocEntityTermCategory,TermCategory>(ret, Execute, requestCancel));
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

        public object Post(TermCategoryVersion request) 
        {
            return Get(request);
        }

        public object Get(TermCategoryVersion request) 
        {
            var ret = new List<Version>();
            _ExecSearch(request, (entities) => 
            {
                ret = entities.Select(e => new Version(e.Id, e.VersionNo)).ToList();
            });
            return ret;
        }

        public object Get(TermCategory request)
        {
            TermCategory ret = null;
            
            if(!(request.Id > 0))
                throw new HttpError(HttpStatusCode.NotFound, "Valid Id required.");

            DocPermissionFactory.SetVisibleFields<TermCategory>(currentUser, "TermCategory", request.VisibleFields);
            var settings = DocResources.Settings;
            if(true != request.IgnoreCache && settings.Cache.CacheWebServices && true != settings.Cache.ExcludedServicesFromCache?.Any(webservice => webservice.ToLower().Trim() == "termcategory")) 
            {
                return _GetIdCache(request);
            }
            else 
            {
                Execute.Run((ssn) =>
                {
                    ret = GetTermCategory(request);
                });
            }
            return ret;
        }

        private TermCategory _AssignValues(TermCategory dtoSource, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (dtoSource == null || dtoSource.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "TermCategory"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            dtoSource.VisibleFields = dtoSource.VisibleFields ?? new List<string>();

            TermCategory ret = null;
            dtoSource = _InitAssignValues(dtoSource, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && dtoSource.Id > 0) return dtoSource;
            
            //First, assign all the variables, do database lookups and conversions
            DocEntityLookupTable pName = GetLookup(DocConstantLookupTable.TERMCATEGORY, dtoSource.Name?.Name, dtoSource.Name?.Id);
            var pParentCategory = (dtoSource.ParentCategory?.Id > 0) ? DocEntityTermCategory.GetTermCategory(dtoSource.ParentCategory.Id) : null;
            var pTerms = dtoSource.Terms?.ToList();

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
                entity = DocEntityTermCategory.GetTermCategory(dtoSource.Id);
                if(null == entity)
                    throw new HttpError(HttpStatusCode.NotFound, $"No record");
            }

            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityLookupTable>(currentUser, dtoSource, pName, permission, DocConstantModelName.TERMCATEGORY, nameof(dtoSource.Name)))
            {
                if(DocPermissionFactory.IsRequested(dtoSource, pName, entity.Name, nameof(dtoSource.Name)))
                    entity.Name = pName;
                if(DocPermissionFactory.IsRequested<DocEntityLookupTable>(dtoSource, pName, nameof(dtoSource.Name)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.Name), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.Name));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityTermCategory>(currentUser, dtoSource, pParentCategory, permission, DocConstantModelName.TERMCATEGORY, nameof(dtoSource.ParentCategory)))
            {
                if(DocPermissionFactory.IsRequested(dtoSource, pParentCategory, entity.ParentCategory, nameof(dtoSource.ParentCategory)))
                    entity.ParentCategory = pParentCategory;
                if(DocPermissionFactory.IsRequested<DocEntityTermCategory>(dtoSource, pParentCategory, nameof(dtoSource.ParentCategory)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.ParentCategory), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.ParentCategory));
                }
            }
            
            if (dtoSource.Locked) entity.Locked = dtoSource.Locked;

            entity.SaveChanges(permission);
            
            if (DocPermissionFactory.IsRequestedHasPermission<List<Reference>>(currentUser, dtoSource, pTerms, permission, DocConstantModelName.TERMCATEGORY, nameof(dtoSource.Terms)))
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
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD, targetEntity: target, targetName: nameof(TermCategory), columnName: nameof(dtoSource.Terms)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to add {nameof(dtoSource.Terms)} to {nameof(TermCategory)}");
                        entity.Terms.Add(target);
                    });
                    var toRemove = entity.Terms.Where(e => requestedTerms.All(id => e.Id != id)).Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityTermMaster.GetTermMaster(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(TermCategory), columnName: nameof(dtoSource.Terms)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(dtoSource.Terms)} from {nameof(TermCategory)}");
                        entity.Terms.Remove(target);
                    });
                }
                else
                {
                    var toRemove = entity.Terms.Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityTermMaster.GetTermMaster(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(TermCategory), columnName: nameof(dtoSource.Terms)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(dtoSource.Terms)} from {nameof(TermCategory)}");
                        entity.Terms.Remove(target);
                    });
                }
                if(DocPermissionFactory.IsRequested<List<Reference>>(dtoSource, pTerms, nameof(dtoSource.Terms)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.Terms), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.Terms));
                }
            }
            DocPermissionFactory.SetVisibleFields<TermCategory>(currentUser, nameof(TermCategory), dtoSource.VisibleFields);
            ret = entity.ToDto();

            return ret;
        }
        public TermCategory Post(TermCategory dtoSource)
        {
            if(dtoSource == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            dtoSource.VisibleFields = dtoSource.VisibleFields ?? new List<string>();

            TermCategory ret = null;

            Execute.Run(ssn =>
            {
                if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "TermCategory")) 
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                ret = _AssignValues(dtoSource, DocConstantPermission.ADD, ssn);
            });

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
            Execute.Run(ssn =>
            {
                var entity = DocEntityTermCategory.GetTermCategory(request?.Id);
                if(null == entity) throw new HttpError(HttpStatusCode.NoContent, "The COPY request did not succeed.");
                if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");
                
                    var pName = entity.Name;
                    var pParentCategory = entity.ParentCategory;
                    var pTerms = entity.Terms.ToList();
                #region Custom Before copyTermCategory
                #endregion Custom Before copyTermCategory
                var copy = new DocEntityTermCategory(ssn)
                {
                    Hash = Guid.NewGuid()
                                , Name = pName
                                , ParentCategory = pParentCategory
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
            return ret;
        }


        public List<TermCategory> Put(TermCategoryBatch request)
        {
            return Patch(request);
        }

        public TermCategory Put(TermCategory dtoSource)
        {
            return Patch(dtoSource);
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

        public TermCategory Patch(TermCategory dtoSource)
        {
            if(true != (dtoSource?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the TermCategory to patch.");
            
            dtoSource.VisibleFields = dtoSource.VisibleFields ?? new List<string>();
            
            TermCategory ret = null;
            Execute.Run(ssn =>
            {
                ret = _AssignValues(dtoSource, DocConstantPermission.EDIT, ssn);
            });
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
            Execute.Run(ssn =>
            {
                var en = DocEntityTermCategory.GetTermCategory(request?.Id);

                if(null == en) throw new HttpError(HttpStatusCode.NotFound, $"No TermCategory could be found for Id {request?.Id}.");
                if(en.IsRemoved) return;
                
                if(!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.DELETE))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have DELETE permission for this route.");
                
                en.Remove();
            });
        }

        public void Delete(TermCategorySearch request)
        {
            var matches = Get(request) as List<TermCategory>;
            if(true != matches?.Any()) throw new HttpError(HttpStatusCode.NotFound, "No matches for request");

            Execute.Run(ssn =>
            {
                matches.ForEach(match =>
                {
                    Delete(match);
                });
            });
        }
        public object Get(TermCategoryJunction request)
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
                case "termmaster":
                    ret = _GetTermCategoryTermMaster(request, skip, take);
                    break;
                }
            });
            return ret;
        }
        
        public object Get(TermCategoryJunctionVersion request)
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
                case "termmaster":
                    ret = GetTermCategoryTermMasterVersion(request);
                    break;
                }
            });
            return ret;
        }
        

        private object _GetTermCategoryTermMaster(TermCategoryJunction request, int skip, int take)
        {
             DocPermissionFactory.SetVisibleFields<TermMaster>(currentUser, "TermMaster", request.VisibleFields);
             var en = DocEntityTermCategory.GetTermCategory(request.Id);
             if (!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.VIEW, targetName: DocConstantModelName.TERMCATEGORY, columnName: "Terms", targetEntity: null))
                 throw new HttpError(HttpStatusCode.Forbidden, "You do not have View permission to relationships between TermCategory and TermMaster");
             return en?.Terms.Take(take).Skip(skip).ConvertFromEntityList<DocEntityTermMaster,TermMaster>(new List<TermMaster>());
        }

        private List<Version> GetTermCategoryTermMasterVersion(TermCategoryJunctionVersion request)
        { 
            if(!(request.Id > 0))
                throw new HttpError(HttpStatusCode.NotFound, "Valid Id required.");
            var ret = new List<Version>();
             Execute.Run((ssn) =>
             {
                var en = DocEntityTermCategory.GetTermCategory(request.Id);
                ret = en?.Terms.Select(e => new Version(e.Id, e.VersionNo)).ToList();
             });
            return ret;
        }
        
        public object Post(TermCategoryJunction request)
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
                case "termmaster":
                    ret = _PostTermCategoryTermMaster(request);
                    break;
                }
            });
            return ret;
        }


        private object _PostTermCategoryTermMaster(TermCategoryJunction request)
        {
            var entity = DocEntityTermCategory.GetTermCategory(request.Id);

            if (null == entity) throw new HttpError(HttpStatusCode.NotFound, $"No TermCategory found for Id {request.Id}");

            if (!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.EDIT))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have Edit permission to TermCategory");

            foreach (var id in request.Ids)
            {
                var relationship = DocEntityTermMaster.GetTermMaster(id);
                if (!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD, targetEntity: relationship, targetName: DocConstantModelName.TERMMASTER, columnName: "Terms")) 
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have Add permission to the Terms property.");
                if (null == relationship) throw new HttpError(HttpStatusCode.NotFound, $"Cannot post to collection of TermCategory with objects that do not exist. No matching TermMaster could be found for {id}.");
                entity.Terms.Add(relationship);
            }
            entity.SaveChanges();
            return entity.ToDto();
        }

        public object Delete(TermCategoryJunction request)
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
                case "termmaster":
                    ret = _DeleteTermCategoryTermMaster(request);
                    break;
                }
            });
            return ret;
        }


        private object _DeleteTermCategoryTermMaster(TermCategoryJunction request)
        {
            var entity = DocEntityTermCategory.GetTermCategory(request.Id);

            if (null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No TermCategory found for Id {request.Id}");
            if (!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.EDIT))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have Edit permission to TermCategory");
            foreach (var id in request.Ids)
            {
                var relationship = DocEntityTermMaster.GetTermMaster(id);
                if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: relationship, targetName: DocConstantModelName.TERMMASTER, columnName: "Terms"))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have Edit permission to relationships between TermCategory and TermMaster");
                if(null != relationship && false == relationship.IsRemoved) entity.Terms.Remove(relationship);
            }
            entity.SaveChanges();
            return entity.ToDto();
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

        public List<int> Any(TermCategoryIds request)
        {
            List<int> ret = null;
            if (currentUser.IsSuperAdmin)
            {
                Execute.Run(s => { ret = Execute.SelectAll<DocEntityTermCategory>().Select(d => d.Id).ToList(); });
            }
            else
            {
                throw new HttpError(HttpStatusCode.Forbidden);
            }

            return ret;
        }
    }
}