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
    public partial class UserTypeService : DocServiceBase
    {
        public const string CACHE_KEY_PREFIX = DocEntityUserType.CACHE_KEY_PREFIX;
        private object _GetIdCache(UserType request)
        {
            object ret = null;

            if (true != request.IgnoreCache)
            {
                var key = currentUser.GetApiCacheKey(DocConstantModelName.USERTYPE);
                var cacheKey = $"UserType_{key}_{request.Id}_{UrnId.Create<UserType>(request.GetMD5Hash())}";
                ret = Request.ToOptimizedResultUsingCache(Cache, cacheKey, new TimeSpan(0, DocResources.Settings.SessionTimeout, 0), () =>
                {
                    object cachedRet = null;
                    cachedRet = GetUserType(request);
                    return cachedRet;
                });
            }
            ret = ret ?? GetUserType(request);
            return ret;
        }

        private object _GetSearchCache(UserTypeSearch request, DocRequestCancellation requestCancel)
        {
            object tryRet = null;
            var ret = new List<UserType>();

            //Keys need to be customized to factor in permissions/scoping. Often, including the current user's Role Id is sufficient in the key
            var key = currentUser.GetApiCacheKey(DocConstantModelName.USERTYPE);
            var cacheKey = $"{CACHE_KEY_PREFIX}_{key}_{UrnId.Create<UserTypeSearch>(request.GetMD5Hash())}";
            tryRet = Request.ToOptimizedResultUsingCache(Cache, cacheKey, new TimeSpan(0, DocResources.Settings.SessionTimeout, 0), () =>
            {
                _ExecSearch(request, (entities) => entities.ConvertFromEntityList<DocEntityUserType,UserType>(ret, Execute, requestCancel));
                return ret;
            });

            if(tryRet == null)
            {
                ret = new List<UserType>();
                _ExecSearch(request, (entities) => entities.ConvertFromEntityList<DocEntityUserType,UserType>(ret, Execute, requestCancel));
                return ret;
            }
            else
            {
                return tryRet;
            }
        }
        private void _ExecSearch(UserTypeSearch request, Action<IQueryable<DocEntityUserType>> callBack)
        {
            request = InitSearch(request);
            
            request.VisibleFields = InitVisibleFields<UserType>(Dto.UserType.Fields, request);

            var entities = Execute.SelectAll<DocEntityUserType>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new UserTypeFullTextSearch(request);
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

                if(!DocTools.IsNullOrEmpty(request.PayrollStatus) && !DocTools.IsNullOrEmpty(request.PayrollStatus.Id))
                {
                    entities = entities.Where(en => en.PayrollStatus.Id == request.PayrollStatus.Id );
                }
                if(true == request.PayrollStatusIds?.Any())
                {
                    entities = entities.Where(en => en.PayrollStatus.Id.In(request.PayrollStatusIds));
                }
                else if(!DocTools.IsNullOrEmpty(request.PayrollStatus) && !DocTools.IsNullOrEmpty(request.PayrollStatus.Name))
                {
                    entities = entities.Where(en => en.PayrollStatus.Name == request.PayrollStatus.Name );
                }
                if(true == request.PayrollStatusNames?.Any())
                {
                    entities = entities.Where(en => en.PayrollStatus.Name.In(request.PayrollStatusNames));
                }
                if(!DocTools.IsNullOrEmpty(request.PayrollType) && !DocTools.IsNullOrEmpty(request.PayrollType.Id))
                {
                    entities = entities.Where(en => en.PayrollType.Id == request.PayrollType.Id );
                }
                if(true == request.PayrollTypeIds?.Any())
                {
                    entities = entities.Where(en => en.PayrollType.Id.In(request.PayrollTypeIds));
                }
                else if(!DocTools.IsNullOrEmpty(request.PayrollType) && !DocTools.IsNullOrEmpty(request.PayrollType.Name))
                {
                    entities = entities.Where(en => en.PayrollType.Name == request.PayrollType.Name );
                }
                if(true == request.PayrollTypeNames?.Any())
                {
                    entities = entities.Where(en => en.PayrollType.Name.In(request.PayrollTypeNames));
                }
                if(!DocTools.IsNullOrEmpty(request.Type) && !DocTools.IsNullOrEmpty(request.Type.Id))
                {
                    entities = entities.Where(en => en.Type.Id == request.Type.Id );
                }
                if(true == request.TypeIds?.Any())
                {
                    entities = entities.Where(en => en.Type.Id.In(request.TypeIds));
                }
                else if(!DocTools.IsNullOrEmpty(request.Type) && !DocTools.IsNullOrEmpty(request.Type.Name))
                {
                    entities = entities.Where(en => en.Type.Name == request.Type.Name );
                }
                if(true == request.TypeNames?.Any())
                {
                    entities = entities.Where(en => en.Type.Name.In(request.TypeNames));
                }
                        if(true == request.UsersIds?.Any())
                        {
                            entities = entities.Where(en => en.Users.Any(r => r.Id.In(request.UsersIds)));
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
        
        public object Post(UserTypeSearch request)
        {
            object tryRet = null;
            Execute.Run(s =>
            {
                using (var cancellableRequest = base.Request.CreateCancellableRequest())
                {
                    var requestCancel = new DocRequestCancellation(HttpContext.Current.Response, cancellableRequest);
                    try 
                    {
                        var ret = new List<UserType>();
                        var settings = DocResources.Settings;
                        if(true != request.IgnoreCache && settings.Cache.CacheWebServices && true != settings.Cache.ExcludedServicesFromCache?.Any(webservice => webservice.ToLower().Trim() == "usertype")) 
                        {
                            tryRet = _GetSearchCache(request, requestCancel);
                        }
                        if (tryRet == null)
                        {
                            _ExecSearch(request, (entities) => entities.ConvertFromEntityList<DocEntityUserType,UserType>(ret, Execute, requestCancel));
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

        public object Get(UserTypeSearch request)
        {
            object tryRet = null;
            Execute.Run(s =>
            {
                using (var cancellableRequest = base.Request.CreateCancellableRequest())
                {
                    var requestCancel = new DocRequestCancellation(HttpContext.Current.Response, cancellableRequest);
                    try 
                    {
                        var ret = new List<UserType>();
                        var settings = DocResources.Settings;
                        if(true != request.IgnoreCache && settings.Cache.CacheWebServices && true != settings.Cache.ExcludedServicesFromCache?.Any(webservice => webservice.ToLower().Trim() == "usertype")) 
                        {
                            tryRet = _GetSearchCache(request, requestCancel);
                        }
                        if (tryRet == null)
                        {
                            _ExecSearch(request, (entities) => entities.ConvertFromEntityList<DocEntityUserType,UserType>(ret, Execute, requestCancel));
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

        public object Post(UserTypeVersion request) 
        {
            return Get(request);
        }

        public object Get(UserTypeVersion request) 
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

        public object Get(UserType request)
        {
            object ret = null;
            
            if(!(request.Id > 0))
                throw new HttpError(HttpStatusCode.NotFound, "Valid Id required.");

            Execute.Run(s =>
            {
                request.VisibleFields = InitVisibleFields<UserType>(Dto.UserType.Fields, request);
                var settings = DocResources.Settings;
                if(true != request.IgnoreCache && settings.Cache.CacheWebServices && true != settings.Cache.ExcludedServicesFromCache?.Any(webservice => webservice.ToLower().Trim() == "usertype")) 
                {
                    ret = _GetIdCache(request);
                }
                else 
                {
                    ret = GetUserType(request);
                }
            });
            return ret;
        }

        private UserType _AssignValues(UserType request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "UserType"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            UserType ret = null;
            request = _InitAssignValues(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            //First, assign all the variables, do database lookups and conversions
            DocEntityLookupTable pPayrollStatus = GetLookup(DocConstantLookupTable.USERPAYROLLSTATUS, request.PayrollStatus?.Name, request.PayrollStatus?.Id);
            DocEntityLookupTable pPayrollType = GetLookup(DocConstantLookupTable.USERPAYROLLTYPE, request.PayrollType?.Name, request.PayrollType?.Id);
            DocEntityLookupTable pType = GetLookup(DocConstantLookupTable.USEREMPLOYEETYPE, request.Type?.Name, request.Type?.Id);
            var pUsers = request.Users?.ToList();

            DocEntityUserType entity = null;
            if(permission == DocConstantPermission.ADD)
            {
                var now = DateTime.UtcNow;
                entity = new DocEntityUserType(session)
                {
                    Created = now,
                    Updated = now
                };
            }
            else
            {
                entity = DocEntityUserType.GetUserType(request.Id);
                if(null == entity)
                    throw new HttpError(HttpStatusCode.NotFound, $"No record");
            }

            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityLookupTable>(currentUser, request, pPayrollStatus, permission, DocConstantModelName.USERTYPE, nameof(request.PayrollStatus)))
            {
                if(DocPermissionFactory.IsRequested(request, pPayrollStatus, entity.PayrollStatus, nameof(request.PayrollStatus)))
                    entity.PayrollStatus = pPayrollStatus;
                if(DocPermissionFactory.IsRequested<DocEntityLookupTable>(request, pPayrollStatus, nameof(request.PayrollStatus)) && !request.VisibleFields.Matches(nameof(request.PayrollStatus), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.PayrollStatus));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityLookupTable>(currentUser, request, pPayrollType, permission, DocConstantModelName.USERTYPE, nameof(request.PayrollType)))
            {
                if(DocPermissionFactory.IsRequested(request, pPayrollType, entity.PayrollType, nameof(request.PayrollType)))
                    entity.PayrollType = pPayrollType;
                if(DocPermissionFactory.IsRequested<DocEntityLookupTable>(request, pPayrollType, nameof(request.PayrollType)) && !request.VisibleFields.Matches(nameof(request.PayrollType), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.PayrollType));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityLookupTable>(currentUser, request, pType, permission, DocConstantModelName.USERTYPE, nameof(request.Type)))
            {
                if(DocPermissionFactory.IsRequested(request, pType, entity.Type, nameof(request.Type)))
                    entity.Type = pType;
                if(DocPermissionFactory.IsRequested<DocEntityLookupTable>(request, pType, nameof(request.Type)) && !request.VisibleFields.Matches(nameof(request.Type), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Type));
                }
            }
            
            if (request.Locked) entity.Locked = request.Locked;

            entity.SaveChanges(permission);
            
            if (DocPermissionFactory.IsRequestedHasPermission<List<Reference>>(currentUser, request, pUsers, permission, DocConstantModelName.USERTYPE, nameof(request.Users)))
            {
                if (true == pUsers?.Any() )
                {
                    var requestedUsers = pUsers.Select(p => p.Id).Distinct().ToList();
                    var existsUsers = Execute.SelectAll<DocEntityUser>().Where(e => e.Id.In(requestedUsers)).Select( e => e.Id ).ToList();
                    if (existsUsers.Count != requestedUsers.Count)
                    {
                        var nonExists = requestedUsers.Where(id => existsUsers.All(eId => eId != id));
                        throw new HttpError(HttpStatusCode.NotFound, $"Cannot patch collection Users with objects that do not exist. No matching Users(s) could be found for Ids: {nonExists.ToDelimitedString()}.");
                    }
                    var toAdd = requestedUsers.Where(id => entity.Users.All(e => e.Id != id)).ToList(); 
                    toAdd?.ForEach(id =>
                    {
                        var target = DocEntityUser.GetUser(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD, targetEntity: target, targetName: nameof(UserType), columnName: nameof(request.Users)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to add {nameof(request.Users)} to {nameof(UserType)}");
                        entity.Users.Add(target);
                    });
                    var toRemove = entity.Users.Where(e => requestedUsers.All(id => e.Id != id)).Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityUser.GetUser(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(UserType), columnName: nameof(request.Users)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Users)} from {nameof(UserType)}");
                        entity.Users.Remove(target);
                    });
                }
                else
                {
                    var toRemove = entity.Users.Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityUser.GetUser(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(UserType), columnName: nameof(request.Users)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Users)} from {nameof(UserType)}");
                        entity.Users.Remove(target);
                    });
                }
                if(DocPermissionFactory.IsRequested<List<Reference>>(request, pUsers, nameof(request.Users)) && !request.VisibleFields.Matches(nameof(request.Users), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Users));
                }
            }
            request.VisibleFields = InitVisibleFields<UserType>(Dto.UserType.Fields, request);
            ret = entity.ToDto();

            return ret;
        }
        public UserType Post(UserType request)
        {
            if(request == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            UserType ret = null;

            Execute.Run(ssn =>
            {
                if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "UserType")) 
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                ret = _AssignValues(request, DocConstantPermission.ADD, ssn);
            });

            return ret;
        }
   
        public List<UserType> Post(UserTypeBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<UserType>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Post(dto) as UserType;
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

        public UserType Post(UserTypeCopy request)
        {
            UserType ret = null;
            Execute.Run(ssn =>
            {
                var entity = DocEntityUserType.GetUserType(request?.Id);
                if(null == entity) throw new HttpError(HttpStatusCode.NoContent, "The COPY request did not succeed.");
                if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");
                
                    var pPayrollStatus = entity.PayrollStatus;
                    var pPayrollType = entity.PayrollType;
                    var pType = entity.Type;
                    var pUsers = entity.Users.ToList();
                var copy = new DocEntityUserType(ssn)
                {
                    Hash = Guid.NewGuid()
                                , PayrollStatus = pPayrollStatus
                                , PayrollType = pPayrollType
                                , Type = pType
                };
                            foreach(var item in pUsers)
                            {
                                entity.Users.Add(item);
                            }

                copy.SaveChanges(DocConstantPermission.ADD);
                ret = copy.ToDto();
            });
            return ret;
        }


        public List<UserType> Put(UserTypeBatch request)
        {
            return Patch(request);
        }

        public UserType Put(UserType request)
        {
            return Patch(request);
        }

        public List<UserType> Patch(UserTypeBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<UserType>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Patch(dto) as UserType;
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

        public UserType Patch(UserType request)
        {
            if(true != (request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the UserType to patch.");
            
            request.VisibleFields = request.VisibleFields ?? new List<string>();
            
            UserType ret = null;
            Execute.Run(ssn =>
            {
                ret = _AssignValues(request, DocConstantPermission.EDIT, ssn);
            });
            return ret;
        }

        public void Delete(UserTypeBatch request)
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

        public void Delete(UserType request)
        {
            Execute.Run(ssn =>
            {
                var en = DocEntityUserType.GetUserType(request?.Id);

                if(null == en) throw new HttpError(HttpStatusCode.NotFound, $"No UserType could be found for Id {request?.Id}.");
                if(en.IsRemoved) return;
                
                if(!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.DELETE))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have DELETE permission for this route.");
                
                en.Remove();
            });
        }

        public void Delete(UserTypeSearch request)
        {
            var matches = Get(request) as List<UserType>;
            if(true != matches?.Any()) throw new HttpError(HttpStatusCode.NotFound, "No matches for request");

            Execute.Run(ssn =>
            {
                matches.ForEach(match =>
                {
                    Delete(match);
                });
            });
        }
        public object Get(UserTypeJunction request)
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
                case "user":
                    ret = _GetUserTypeUser(request, skip, take);
                    break;
                }
            });
            return ret;
        }
        
        public object Get(UserTypeJunctionVersion request)
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
                case "user":
                    ret = GetUserTypeUserVersion(request);
                    break;
                }
            });
            return ret;
        }
        

        private object _GetUserTypeUser(UserTypeJunction request, int skip, int take)
        {
             request.VisibleFields = InitVisibleFields<User>(Dto.User.Fields, request.VisibleFields);
             var en = DocEntityUserType.GetUserType(request.Id);
             if (!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.VIEW, targetName: DocConstantModelName.USERTYPE, columnName: "Users", targetEntity: null))
                 throw new HttpError(HttpStatusCode.Forbidden, "You do not have View permission to relationships between UserType and User");
             return en?.Users.Take(take).Skip(skip).ConvertFromEntityList<DocEntityUser,User>(new List<User>());
        }

        private List<Version> GetUserTypeUserVersion(UserTypeJunctionVersion request)
        { 
            if(!(request.Id > 0))
                throw new HttpError(HttpStatusCode.NotFound, "Valid Id required.");
            var ret = new List<Version>();
             Execute.Run((ssn) =>
             {
                var en = DocEntityUserType.GetUserType(request.Id);
                ret = en?.Users.Select(e => new Version(e.Id, e.VersionNo)).ToList();
             });
            return ret;
        }
        
        public object Post(UserTypeJunction request)
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
                case "user":
                    ret = _PostUserTypeUser(request);
                    break;
                }
            });
            return ret;
        }


        private object _PostUserTypeUser(UserTypeJunction request)
        {
            var entity = DocEntityUserType.GetUserType(request.Id);

            if (null == entity) throw new HttpError(HttpStatusCode.NotFound, $"No UserType found for Id {request.Id}");

            if (!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.EDIT))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have Edit permission to UserType");

            foreach (var id in request.Ids)
            {
                var relationship = DocEntityUser.GetUser(id);
                if (!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD, targetEntity: relationship, targetName: DocConstantModelName.USER, columnName: "Users")) 
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have Add permission to the Users property.");
                if (null == relationship) throw new HttpError(HttpStatusCode.NotFound, $"Cannot post to collection of UserType with objects that do not exist. No matching User could be found for {id}.");
                entity.Users.Add(relationship);
            }
            entity.SaveChanges();
            return entity.ToDto();
        }

        public object Delete(UserTypeJunction request)
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
                case "user":
                    ret = _DeleteUserTypeUser(request);
                    break;
                }
            });
            return ret;
        }


        private object _DeleteUserTypeUser(UserTypeJunction request)
        {
            var entity = DocEntityUserType.GetUserType(request.Id);

            if (null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No UserType found for Id {request.Id}");
            if (!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.EDIT))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have Edit permission to UserType");
            foreach (var id in request.Ids)
            {
                var relationship = DocEntityUser.GetUser(id);
                if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: relationship, targetName: DocConstantModelName.USER, columnName: "Users"))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have Edit permission to relationships between UserType and User");
                if(null != relationship && false == relationship.IsRemoved) entity.Users.Remove(relationship);
            }
            entity.SaveChanges();
            return entity.ToDto();
        }

        private UserType GetUserType(UserType request)
        {
            var id = request?.Id;
            UserType ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            request.VisibleFields = InitVisibleFields<UserType>(Dto.UserType.Fields, request);

            DocEntityUserType entity = null;
            if(id.HasValue)
            {
                entity = DocEntityUserType.GetUserType(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No UserType found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }

        public List<int> Any(UserTypeIds request)
        {
            List<int> ret = null;
            if (currentUser.IsSuperAdmin)
            {
                Execute.Run(s => { ret = Execute.SelectAll<DocEntityUserType>().Select(d => d.Id).ToList(); });
            }
            else
            {
                throw new HttpError(HttpStatusCode.Forbidden);
            }
            return ret;
        }
    }
}==================== Orphaned Custom Regions ====================
===== [Custom Before copyUserType] =====
===== [Custom After copyUserType] =====
==================== Orphaned Custom Regions ====================
