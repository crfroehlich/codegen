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
    public partial class LookupTableEnumService : DocServiceBase
    {
        public const string CACHE_KEY_PREFIX = DocEntityLookupTableEnum.CACHE_KEY_PREFIX;
        private object _GetIdCache(LookupTableEnum request)
        {
            object ret = null;

            if (true != request.IgnoreCache)
            {
                var key = currentUser.GetApiCacheKey(DocConstantModelName.LOOKUPTABLEENUM);
                var cacheKey = $"LookupTableEnum_{key}_{request.Id}_{UrnId.Create<LookupTableEnum>(request.GetMD5Hash())}";
                ret = Request.ToOptimizedResultUsingCache(Cache, cacheKey, new TimeSpan(0, DocResources.Settings.SessionTimeout, 0), () =>
                {
                    object cachedRet = null;
                    cachedRet = GetLookupTableEnum(request);
                    return cachedRet;
                });
            }
            ret = ret ?? GetLookupTableEnum(request);
            return ret;
        }

        private object _GetSearchCache(LookupTableEnumSearch request, DocRequestCancellation requestCancel)
        {
            object tryRet = null;
            var ret = new List<LookupTableEnum>();

            //Keys need to be customized to factor in permissions/scoping. Often, including the current user's Role Id is sufficient in the key
            var key = currentUser.GetApiCacheKey(DocConstantModelName.LOOKUPTABLEENUM);
            var cacheKey = $"{CACHE_KEY_PREFIX}_{key}_{UrnId.Create<LookupTableEnumSearch>(request.GetMD5Hash())}";
            tryRet = Request.ToOptimizedResultUsingCache(Cache, cacheKey, new TimeSpan(0, DocResources.Settings.SessionTimeout, 0), () =>
            {
                _ExecSearch(request, (entities) => entities.ConvertFromEntityList<DocEntityLookupTableEnum,LookupTableEnum>(ret, Execute, requestCancel));
                return ret;
            });

            if(tryRet == null)
            {
                ret = new List<LookupTableEnum>();
                _ExecSearch(request, (entities) => entities.ConvertFromEntityList<DocEntityLookupTableEnum,LookupTableEnum>(ret, Execute, requestCancel));
                return ret;
            }
            else
            {
                return tryRet;
            }
        }
        private void _ExecSearch(LookupTableEnumSearch request, Action<IQueryable<DocEntityLookupTableEnum>> callBack)
        {
            request = InitSearch(request);
            
            DocPermissionFactory.SetVisibleFields<LookupTableEnum>(currentUser, "LookupTableEnum", request.VisibleFields);

            var entities = Execute.SelectAll<DocEntityLookupTableEnum>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new LookupTableEnumFullTextSearch(request);
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

                if(request.IsBindable.HasValue)
                    entities = entities.Where(en => request.IsBindable.Value == en.IsBindable);
                if(request.IsGlobal.HasValue)
                    entities = entities.Where(en => request.IsGlobal.Value == en.IsGlobal);
                if(!DocTools.IsNullOrEmpty(request.Name))
                    entities = entities.Where(en => en.Name.Contains(request.Name));

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
        }
        
        public object Post(LookupTableEnumSearch request)
        {
            object tryRet = null;
            Execute.Run(s =>
            {
                using (var cancellableRequest = base.Request.CreateCancellableRequest())
                {
                    var requestCancel = new DocRequestCancellation(HttpContext.Current.Response, cancellableRequest);
                    try 
                    {
                        var ret = new List<LookupTableEnum>();
                        var settings = DocResources.Settings;
                        if(true != request.IgnoreCache && settings.Cache.CacheWebServices && true != settings.Cache.ExcludedServicesFromCache?.Any(webservice => webservice.ToLower().Trim() == "lookuptableenum")) 
                        {
                            tryRet = _GetSearchCache(request, requestCancel);
                        }
                        if (tryRet == null)
                        {
                            _ExecSearch(request, (entities) => entities.ConvertFromEntityList<DocEntityLookupTableEnum,LookupTableEnum>(ret, Execute, requestCancel));
                            tryRet = ret;
                        }
                    }
                    catch(Exception) { throw; }
                    finally
                    {
                        requestCancel?.CloseRequest();
                    }
                }
            });
            return tryRet;
        }

        public object Get(LookupTableEnumSearch request)
        {
            object tryRet = null;
            Execute.Run(s =>
            {
                using (var cancellableRequest = base.Request.CreateCancellableRequest())
                {
                    var requestCancel = new DocRequestCancellation(HttpContext.Current.Response, cancellableRequest);
                    try 
                    {
                        var ret = new List<LookupTableEnum>();
                        var settings = DocResources.Settings;
                        if(true != request.IgnoreCache && settings.Cache.CacheWebServices && true != settings.Cache.ExcludedServicesFromCache?.Any(webservice => webservice.ToLower().Trim() == "lookuptableenum")) 
                        {
                            tryRet = _GetSearchCache(request, requestCancel);
                        }
                        if (tryRet == null)
                        {
                            _ExecSearch(request, (entities) => entities.ConvertFromEntityList<DocEntityLookupTableEnum,LookupTableEnum>(ret, Execute, requestCancel));
                            tryRet = ret;
                        }
                    }
                    catch(Exception) { throw; }
                    finally
                    {
                        requestCancel?.CloseRequest();
                    }
                }
            });
            return tryRet;
        }

        public object Post(LookupTableEnumVersion request) 
        {
            return Get(request);
        }

        public object Get(LookupTableEnumVersion request) 
        {
            var ret = new List<Version>();
            Execute.Run(s =>
            {
                _ExecSearch(request, (entities) => 
                {
                    ret = entities.Select(e => new Version(e.Id, e.VersionNo)).ToList();
                });
            });
            return ret;
        }

        public object Get(LookupTableEnum request)
        {
            object ret = null;
            
            if(!(request.Id > 0))
                throw new HttpError(HttpStatusCode.NotFound, "Valid Id required.");

            Execute.Run(s =>
            {
                DocPermissionFactory.SetVisibleFields<LookupTableEnum>(currentUser, "LookupTableEnum", request.VisibleFields);
                var settings = DocResources.Settings;
                if(true != request.IgnoreCache && settings.Cache.CacheWebServices && true != settings.Cache.ExcludedServicesFromCache?.Any(webservice => webservice.ToLower().Trim() == "lookuptableenum")) 
                {
                    ret = _GetIdCache(request);
                }
                else 
                {
                    ret = GetLookupTableEnum(request);
                }
            });
            return ret;
        }

        private LookupTableEnum _AssignValues(LookupTableEnum dtoSource, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (dtoSource == null || dtoSource.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "LookupTableEnum"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            dtoSource.VisibleFields = dtoSource.VisibleFields ?? new List<string>();

            LookupTableEnum ret = null;
            dtoSource = _InitAssignValues(dtoSource, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && dtoSource.Id > 0) return dtoSource;
            
            //First, assign all the variables, do database lookups and conversions
            var pIsBindable = dtoSource.IsBindable;
            var pIsGlobal = dtoSource.IsGlobal;
            var pName = dtoSource.Name;

            DocEntityLookupTableEnum entity = null;
            if(permission == DocConstantPermission.ADD)
            {
                var now = DateTime.UtcNow;
                entity = new DocEntityLookupTableEnum(session)
                {
                    Created = now,
                    Updated = now
                };
            }
            else
            {
                entity = DocEntityLookupTableEnum.GetLookupTableEnum(dtoSource.Id);
                if(null == entity)
                    throw new HttpError(HttpStatusCode.NotFound, $"No record");
            }

            
            if (dtoSource.Locked) entity.Locked = dtoSource.Locked;

            entity.SaveChanges(permission);
            
            DocPermissionFactory.SetVisibleFields<LookupTableEnum>(currentUser, nameof(LookupTableEnum), dtoSource.VisibleFields);
            ret = entity.ToDto();

            return ret;
        }
        public LookupTableEnum Post(LookupTableEnum dtoSource)
        {
            if(dtoSource == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            dtoSource.VisibleFields = dtoSource.VisibleFields ?? new List<string>();

            LookupTableEnum ret = null;

            Execute.Run(ssn =>
            {
                if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "LookupTableEnum")) 
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                ret = _AssignValues(dtoSource, DocConstantPermission.ADD, ssn);
            });

            return ret;
        }
   
        public List<LookupTableEnum> Post(LookupTableEnumBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<LookupTableEnum>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Post(dto) as LookupTableEnum;
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

        public LookupTableEnum Post(LookupTableEnumCopy request)
        {
            LookupTableEnum ret = null;
            Execute.Run(ssn =>
            {
                var entity = DocEntityLookupTableEnum.GetLookupTableEnum(request?.Id);
                if(null == entity) throw new HttpError(HttpStatusCode.NoContent, "The COPY request did not succeed.");
                if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");
                
                    var pIsBindable = entity.IsBindable;
                    var pIsGlobal = entity.IsGlobal;
                    var pName = entity.Name;
                    if(!DocTools.IsNullOrEmpty(pName))
                        pName += " (Copy)";
                var copy = new DocEntityLookupTableEnum(ssn)
                {
                    Hash = Guid.NewGuid()
                                , IsBindable = pIsBindable
                                , IsGlobal = pIsGlobal
                                , Name = pName
                };
                copy.SaveChanges(DocConstantPermission.ADD);
                ret = copy.ToDto();
            });
            return ret;
        }


        public List<LookupTableEnum> Put(LookupTableEnumBatch request)
        {
            return Patch(request);
        }

        public LookupTableEnum Put(LookupTableEnum dtoSource)
        {
            return Patch(dtoSource);
        }

        public List<LookupTableEnum> Patch(LookupTableEnumBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<LookupTableEnum>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Patch(dto) as LookupTableEnum;
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

        public LookupTableEnum Patch(LookupTableEnum dtoSource)
        {
            if(true != (dtoSource?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the LookupTableEnum to patch.");
            
            dtoSource.VisibleFields = dtoSource.VisibleFields ?? new List<string>();
            
            LookupTableEnum ret = null;
            Execute.Run(ssn =>
            {
                ret = _AssignValues(dtoSource, DocConstantPermission.EDIT, ssn);
            });
            return ret;
        }

        public void Delete(LookupTableEnumBatch request)
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

        public void Delete(LookupTableEnum request)
        {
            Execute.Run(ssn =>
            {
                var en = DocEntityLookupTableEnum.GetLookupTableEnum(request?.Id);

                if(null == en) throw new HttpError(HttpStatusCode.NotFound, $"No LookupTableEnum could be found for Id {request?.Id}.");
                if(en.IsRemoved) return;
                
                if(!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.DELETE))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have DELETE permission for this route.");
                
                en.Remove();
            });
        }

        public void Delete(LookupTableEnumSearch request)
        {
            var matches = Get(request) as List<LookupTableEnum>;
            if(true != matches?.Any()) throw new HttpError(HttpStatusCode.NotFound, "No matches for request");

            Execute.Run(ssn =>
            {
                matches.ForEach(match =>
                {
                    Delete(match);
                });
            });
        }

        private LookupTableEnum GetLookupTableEnum(LookupTableEnum request)
        {
            var id = request?.Id;
            LookupTableEnum ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetVisibleFields<LookupTableEnum>(currentUser, "LookupTableEnum", request.VisibleFields);

            DocEntityLookupTableEnum entity = null;
            if(id.HasValue)
            {
                entity = DocEntityLookupTableEnum.GetLookupTableEnum(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No LookupTableEnum found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }

        public List<int> Any(LookupTableEnumIds request)
        {
            List<int> ret = null;
            if (currentUser.IsSuperAdmin)
            {
                Execute.Run(s => { ret = Execute.SelectAll<DocEntityLookupTableEnum>().Select(d => d.Id).ToList(); });
            }
            else
            {
                throw new HttpError(HttpStatusCode.Forbidden);
            }
            return ret;
        }
    }
}