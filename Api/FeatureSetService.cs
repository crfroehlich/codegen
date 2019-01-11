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
using Typed.Security;
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
    public partial class FeatureSetService : DocServiceBase
    {
        public const string CACHE_KEY_PREFIX = DocEntityFeatureSet.CACHE_KEY_PREFIX;
        private object _GetIdCache(FeatureSet request)
        {
            object ret = null;

            if (true != request.IgnoreCache)
            {
                var key = currentUser.GetApiCacheKey(DocConstantModelName.FEATURESET);
                var cacheKey = $"FeatureSet_{key}_{request.Id}_{UrnId.Create<FeatureSet>(request.GetMD5Hash())}";
                ret = Request.ToOptimizedResultUsingCache(Cache, cacheKey, new TimeSpan(0, DocResources.Settings.SessionTimeout, 0), () =>
                {
                    object cachedRet = null;
                    cachedRet = GetFeatureSet(request);
                    return cachedRet;
                });
            }
            ret = ret ?? GetFeatureSet(request);
            return ret;
        }

        private object _GetSearchCache(FeatureSetSearch request, DocRequestCancellation requestCancel)
        {
            object tryRet = null;
            var ret = new List<FeatureSet>();

            //Keys need to be customized to factor in permissions/scoping. Often, including the current user's Role Id is sufficient in the key
            var key = currentUser.GetApiCacheKey(DocConstantModelName.FEATURESET);
            var cacheKey = $"{CACHE_KEY_PREFIX}_{key}_{UrnId.Create<FeatureSetSearch>(request.GetMD5Hash())}";
            tryRet = Request.ToOptimizedResultUsingCache(Cache, cacheKey, new TimeSpan(0, DocResources.Settings.SessionTimeout, 0), () =>
            {
                _ExecSearch(request, (entities) => entities.ConvertFromEntityList<DocEntityFeatureSet,FeatureSet>(ret, Execute, requestCancel));
                return ret;
            });

            if(tryRet == null)
            {
                ret = new List<FeatureSet>();
                _ExecSearch(request, (entities) => entities.ConvertFromEntityList<DocEntityFeatureSet,FeatureSet>(ret, Execute, requestCancel));
                return ret;
            }
            else
            {
                return tryRet;
            }
        }
        private void _ExecSearch(FeatureSetSearch request, Action<IQueryable<DocEntityFeatureSet>> callBack)
        {
            request = InitSearch(request);
            
            request.VisibleFields = InitVisibleFields<FeatureSet>(Dto.FeatureSet.Fields, request);

            var entities = Execute.SelectAll<DocEntityFeatureSet>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new FeatureSetFullTextSearch(request);
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

                if(!DocTools.IsNullOrEmpty(request.Description))
                    entities = entities.Where(en => en.Description.Contains(request.Description));
                if(!DocTools.IsNullOrEmpty(request.Name))
                    entities = entities.Where(en => en.Name.Contains(request.Name));
                        if(true == request.RolesIds?.Any())
                        {
                            entities = entities.Where(en => en.Roles.Any(r => r.Id.In(request.RolesIds)));
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
        }
        
        public object Post(FeatureSetSearch request)
        {
            object tryRet = null;
            Execute.Run(s =>
            {
                using (var cancellableRequest = base.Request.CreateCancellableRequest())
                {
                    var requestCancel = new DocRequestCancellation(HttpContext.Current.Response, cancellableRequest);
                    try 
                    {
                        var ret = new List<FeatureSet>();
                        var settings = DocResources.Settings;
                        if(true != request.IgnoreCache && settings.Cache.CacheWebServices && true != settings.Cache.ExcludedServicesFromCache?.Any(webservice => webservice.ToLower().Trim() == "featureset")) 
                        {
                            tryRet = _GetSearchCache(request, requestCancel);
                        }
                        if (tryRet == null)
                        {
                            _ExecSearch(request, (entities) => entities.ConvertFromEntityList<DocEntityFeatureSet,FeatureSet>(ret, Execute, requestCancel));
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

        public object Get(FeatureSetSearch request)
        {
            object tryRet = null;
            Execute.Run(s =>
            {
                using (var cancellableRequest = base.Request.CreateCancellableRequest())
                {
                    var requestCancel = new DocRequestCancellation(HttpContext.Current.Response, cancellableRequest);
                    try 
                    {
                        var ret = new List<FeatureSet>();
                        var settings = DocResources.Settings;
                        if(true != request.IgnoreCache && settings.Cache.CacheWebServices && true != settings.Cache.ExcludedServicesFromCache?.Any(webservice => webservice.ToLower().Trim() == "featureset")) 
                        {
                            tryRet = _GetSearchCache(request, requestCancel);
                        }
                        if (tryRet == null)
                        {
                            _ExecSearch(request, (entities) => entities.ConvertFromEntityList<DocEntityFeatureSet,FeatureSet>(ret, Execute, requestCancel));
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

        public object Post(FeatureSetVersion request) 
        {
            return Get(request);
        }

        public object Get(FeatureSetVersion request) 
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

        public object Get(FeatureSet request)
        {
            object ret = null;
            
            if(!(request.Id > 0))
                throw new HttpError(HttpStatusCode.NotFound, "Valid Id required.");

            Execute.Run(s =>
            {
                request.VisibleFields = InitVisibleFields<FeatureSet>(Dto.FeatureSet.Fields, request);
                var settings = DocResources.Settings;
                if(true != request.IgnoreCache && settings.Cache.CacheWebServices && true != settings.Cache.ExcludedServicesFromCache?.Any(webservice => webservice.ToLower().Trim() == "featureset")) 
                {
                    ret = _GetIdCache(request);
                }
                else 
                {
                    ret = GetFeatureSet(request);
                }
            });
            return ret;
        }

        private FeatureSet _AssignValues(FeatureSet request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "FeatureSet"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            FeatureSet ret = null;
            request = _InitAssignValues(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            //First, assign all the variables, do database lookups and conversions
            var pDescription = request.Description;
            var pName = request.Name;
            var pPermissionTemplate = request.PermissionTemplate;
            var pRoles = request.Roles?.ToList();

            DocEntityFeatureSet entity = null;
            if(permission == DocConstantPermission.ADD)
            {
                var now = DateTime.UtcNow;
                entity = new DocEntityFeatureSet(session)
                {
                    Created = now,
                    Updated = now
                };
            }
            else
            {
                entity = DocEntityFeatureSet.GetFeatureSet(request.Id);
                if(null == entity)
                    throw new HttpError(HttpStatusCode.NotFound, $"No record");
            }

            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pDescription, permission, DocConstantModelName.FEATURESET, nameof(request.Description)))
            {
                if(DocPermissionFactory.IsRequested(request, pDescription, entity.Description, nameof(request.Description)))
                    entity.Description = pDescription;
                if(DocPermissionFactory.IsRequested<string>(request, pDescription, nameof(request.Description)) && !request.VisibleFields.Matches(nameof(request.Description), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Description));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pName, permission, DocConstantModelName.FEATURESET, nameof(request.Name)))
            {
                if(DocPermissionFactory.IsRequested(request, pName, entity.Name, nameof(request.Name)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Name)} cannot be modified once set.");
                    entity.Name = pName;
                if(DocPermissionFactory.IsRequested<string>(request, pName, nameof(request.Name)) && !request.VisibleFields.Matches(nameof(request.Name), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Name));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pPermissionTemplate, permission, DocConstantModelName.FEATURESET, nameof(request.PermissionTemplate)))
            {
                if(DocPermissionFactory.IsRequested(request, pPermissionTemplate, entity.PermissionTemplate, nameof(request.PermissionTemplate)))
                    entity.PermissionTemplate = pPermissionTemplate;
                if(DocPermissionFactory.IsRequested<string>(request, pPermissionTemplate, nameof(request.PermissionTemplate)) && !request.VisibleFields.Matches(nameof(request.PermissionTemplate), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.PermissionTemplate));
                }
            }
            
            if (request.Locked) entity.Locked = request.Locked;

            entity.SaveChanges(permission);
            
            if (DocPermissionFactory.IsRequestedHasPermission<List<Reference>>(currentUser, request, pRoles, permission, DocConstantModelName.FEATURESET, nameof(request.Roles)))
            {
                if (true == pRoles?.Any() )
                {
                    var requestedRoles = pRoles.Select(p => p.Id).Distinct().ToList();
                    var existsRoles = Execute.SelectAll<DocEntityRole>().Where(e => e.Id.In(requestedRoles)).Select( e => e.Id ).ToList();
                    if (existsRoles.Count != requestedRoles.Count)
                    {
                        var nonExists = requestedRoles.Where(id => existsRoles.All(eId => eId != id));
                        throw new HttpError(HttpStatusCode.NotFound, $"Cannot patch collection Roles with objects that do not exist. No matching Roles(s) could be found for Ids: {nonExists.ToDelimitedString()}.");
                    }
                    var toAdd = requestedRoles.Where(id => entity.Roles.All(e => e.Id != id)).ToList(); 
                    toAdd?.ForEach(id =>
                    {
                        var target = DocEntityRole.GetRole(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD, targetEntity: target, targetName: nameof(FeatureSet), columnName: nameof(request.Roles)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to add {nameof(request.Roles)} to {nameof(FeatureSet)}");
                        entity.Roles.Add(target);
                    });
                    var toRemove = entity.Roles.Where(e => requestedRoles.All(id => e.Id != id)).Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityRole.GetRole(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(FeatureSet), columnName: nameof(request.Roles)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Roles)} from {nameof(FeatureSet)}");
                        entity.Roles.Remove(target);
                    });
                }
                else
                {
                    var toRemove = entity.Roles.Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityRole.GetRole(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(FeatureSet), columnName: nameof(request.Roles)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Roles)} from {nameof(FeatureSet)}");
                        entity.Roles.Remove(target);
                    });
                }
                if(DocPermissionFactory.IsRequested<List<Reference>>(request, pRoles, nameof(request.Roles)) && !request.VisibleFields.Matches(nameof(request.Roles), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Roles));
                }
            }
            request.VisibleFields = InitVisibleFields<FeatureSet>(Dto.FeatureSet.Fields, request);
            ret = entity.ToDto();

            return ret;
        }


        public List<FeatureSet> Put(FeatureSetBatch request)
        {
            return Patch(request);
        }

        public FeatureSet Put(FeatureSet request)
        {
            return Patch(request);
        }

        public List<FeatureSet> Patch(FeatureSetBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<FeatureSet>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Patch(dto) as FeatureSet;
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

        public FeatureSet Patch(FeatureSet request)
        {
            if(true != (request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the FeatureSet to patch.");
            
            request.VisibleFields = request.VisibleFields ?? new List<string>();
            
            FeatureSet ret = null;
            Execute.Run(ssn =>
            {
                ret = _AssignValues(request, DocConstantPermission.EDIT, ssn);
            });
            return ret;
        }

        public object Get(FeatureSetJunction request)
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
                case "role":
                    ret = _GetFeatureSetRole(request, skip, take);
                    break;
                }
            });
            return ret;
        }
        
        public object Get(FeatureSetJunctionVersion request)
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
                case "role":
                    ret = GetFeatureSetRoleVersion(request);
                    break;
                }
            });
            return ret;
        }
        

        private object _GetFeatureSetRole(FeatureSetJunction request, int skip, int take)
        {
             request.VisibleFields = InitVisibleFields<Role>(Dto.Role.Fields, request.VisibleFields);
             var en = DocEntityFeatureSet.GetFeatureSet(request.Id);
             if (!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.VIEW, targetName: DocConstantModelName.FEATURESET, columnName: "Roles", targetEntity: null))
                 throw new HttpError(HttpStatusCode.Forbidden, "You do not have View permission to relationships between FeatureSet and Role");
             return en?.Roles.Take(take).Skip(skip).ConvertFromEntityList<DocEntityRole,Role>(new List<Role>());
        }

        private List<Version> GetFeatureSetRoleVersion(FeatureSetJunctionVersion request)
        { 
            if(!(request.Id > 0))
                throw new HttpError(HttpStatusCode.NotFound, "Valid Id required.");
            var ret = new List<Version>();
             Execute.Run((ssn) =>
             {
                var en = DocEntityFeatureSet.GetFeatureSet(request.Id);
                ret = en?.Roles.Select(e => new Version(e.Id, e.VersionNo)).ToList();
             });
            return ret;
        }
        
        public object Post(FeatureSetJunction request)
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
                case "role":
                    ret = _PostFeatureSetRole(request);
                    break;
                }
            });
            return ret;
        }


        private object _PostFeatureSetRole(FeatureSetJunction request)
        {
            var entity = DocEntityFeatureSet.GetFeatureSet(request.Id);

            if (null == entity) throw new HttpError(HttpStatusCode.NotFound, $"No FeatureSet found for Id {request.Id}");

            if (!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.EDIT))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have Edit permission to FeatureSet");

            foreach (var id in request.Ids)
            {
                var relationship = DocEntityRole.GetRole(id);
                if (!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD, targetEntity: relationship, targetName: DocConstantModelName.ROLE, columnName: "Roles")) 
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have Add permission to the Roles property.");
                if (null == relationship) throw new HttpError(HttpStatusCode.NotFound, $"Cannot post to collection of FeatureSet with objects that do not exist. No matching Role could be found for {id}.");
                entity.Roles.Add(relationship);
            }
            entity.SaveChanges();
            return entity.ToDto();
        }

        public object Delete(FeatureSetJunction request)
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
                case "role":
                    ret = _DeleteFeatureSetRole(request);
                    break;
                }
            });
            return ret;
        }


        private object _DeleteFeatureSetRole(FeatureSetJunction request)
        {
            var entity = DocEntityFeatureSet.GetFeatureSet(request.Id);

            if (null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No FeatureSet found for Id {request.Id}");
            if (!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.EDIT))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have Edit permission to FeatureSet");
            foreach (var id in request.Ids)
            {
                var relationship = DocEntityRole.GetRole(id);
                if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: relationship, targetName: DocConstantModelName.ROLE, columnName: "Roles"))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have Edit permission to relationships between FeatureSet and Role");
                if(null != relationship && false == relationship.IsRemoved) entity.Roles.Remove(relationship);
            }
            entity.SaveChanges();
            return entity.ToDto();
        }

        private FeatureSet GetFeatureSet(FeatureSet request)
        {
            var id = request?.Id;
            FeatureSet ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            request.VisibleFields = InitVisibleFields<FeatureSet>(Dto.FeatureSet.Fields, request);

            DocEntityFeatureSet entity = null;
            if(id.HasValue)
            {
                entity = DocEntityFeatureSet.GetFeatureSet(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No FeatureSet found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }

        public List<int> Any(FeatureSetIds request)
        {
            List<int> ret = null;
            if (currentUser.IsSuperAdmin)
            {
                Execute.Run(s => { ret = Execute.SelectAll<DocEntityFeatureSet>().Select(d => d.Id).ToList(); });
            }
            else
            {
                throw new HttpError(HttpStatusCode.Forbidden);
            }
            return ret;
        }
    }
}