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
    public partial class JunctionService : DocServiceBase
    {
        public const string CACHE_KEY_PREFIX = DocEntityJunction.CACHE_KEY_PREFIX;
        private void _ExecSearch(JunctionSearch request, Action<IQueryable<DocEntityJunction>> callBack)
        {
            request = InitSearch(request);
            
            DocPermissionFactory.SetVisibleFields<Junction>(currentUser, "Junction", request.VisibleFields);

            Execute.Run( session => 
            {
                var entities = Execute.SelectAll<DocEntityJunction>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new JunctionFullTextSearch(request);
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

                        if(true == request.ChildrenIds?.Any())
                        {
                            entities = entities.Where(en => en.Children.Any(r => r.Id.In(request.ChildrenIds)));
                        }
                if(request.OwnerId.HasValue)
                    entities = entities.Where(en => request.OwnerId.Value == en.OwnerId);
                if(!DocTools.IsNullOrEmpty(request.OwnerType))
                    entities = entities.Where(en => en.OwnerType.Contains(request.OwnerType));
                if(!DocTools.IsNullOrEmpty(request.Parent) && !DocTools.IsNullOrEmpty(request.Parent.Id))
                {
                    entities = entities.Where(en => en.Parent.Id == request.Parent.Id );
                }
                if(true == request.ParentIds?.Any())
                {
                    entities = entities.Where(en => en.Parent.Id.In(request.ParentIds));
                }
                if(request.TargetId.HasValue)
                    entities = entities.Where(en => request.TargetId.Value == en.TargetId);
                if(!DocTools.IsNullOrEmpty(request.TargetType))
                    entities = entities.Where(en => en.TargetType.Contains(request.TargetType));
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
                if(!DocTools.IsNullOrEmpty(request.User) && !DocTools.IsNullOrEmpty(request.User.Id))
                {
                    entities = entities.Where(en => en.User.Id == request.User.Id );
                }
                if(true == request.UserIds?.Any())
                {
                    entities = entities.Where(en => en.User.Id.In(request.UserIds));
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
        
        public object Post(JunctionSearch request)
        {
            object tryRet = null;
            using (var cancellableRequest = base.Request.CreateCancellableRequest())
            {
                var requestCancel = new DocRequestCancellation(HttpContext.Current.Response, cancellableRequest);
                try 
                {
                    var ret = new List<Junction>();
                    _ExecSearch(request, (entities) => entities.ConvertFromEntityList<DocEntityJunction,Junction>(ret, Execute, requestCancel));
                    tryRet = ret;
                }
                catch(Exception) { throw; }
                finally
                {
                    requestCancel?.CloseRequest();
                }
            }
            return tryRet;
        }

        public object Get(JunctionSearch request)
        {
            object tryRet = null;
            using (var cancellableRequest = base.Request.CreateCancellableRequest())
            {
                var requestCancel = new DocRequestCancellation(HttpContext.Current.Response, cancellableRequest);
                try 
                {
                    var ret = new List<Junction>();
                    _ExecSearch(request, (entities) => entities.ConvertFromEntityList<DocEntityJunction,Junction>(ret, Execute, requestCancel));
                    tryRet = ret;
                }
                catch(Exception) { throw; }
                finally
                {
                    requestCancel?.CloseRequest();
                }
            }
            return tryRet;
        }

        public object Post(JunctionVersion request) 
        {
            return Get(request);
        }

        public object Get(JunctionVersion request) 
        {
            var ret = new List<Version>();
            _ExecSearch(request, (entities) => 
            {
                ret = entities.Select(e => new Version(e.Id, e.VersionNo)).ToList();
            });
            return ret;
        }

        public object Get(Junction request)
        {
            Junction ret = null;
            
            if(!(request.Id > 0))
                throw new HttpError(HttpStatusCode.NotFound, "Valid Id required.");

            DocPermissionFactory.SetVisibleFields<Junction>(currentUser, "Junction", request.VisibleFields);
            Execute.Run((ssn) =>
            {
                ret = GetJunction(request);
            });
            return ret;
        }

        private Junction _AssignValues(Junction dtoSource, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (dtoSource == null || dtoSource.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "Junction"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            dtoSource.VisibleFields = dtoSource.VisibleFields ?? new List<string>();

            Junction ret = null;
            dtoSource = _InitAssignValues(dtoSource, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && dtoSource.Id > 0) return dtoSource;
            
            //First, assign all the variables, do database lookups and conversions
            var pChildren = dtoSource.Children?.ToList();
            var pData = dtoSource.Data;
            var pOwnerId = dtoSource.OwnerId;
            var pOwnerType = dtoSource.OwnerType;
            var pParent = (dtoSource.Parent?.Id > 0) ? DocEntityJunction.GetJunction(dtoSource.Parent.Id) : null;
            var pTargetId = dtoSource.TargetId;
            var pTargetType = dtoSource.TargetType;
            DocEntityLookupTable pType = GetLookup(DocConstantLookupTable.JUNCTIONTYPE, dtoSource.Type?.Name, dtoSource.Type?.Id);
            var pUser = (dtoSource.User?.Id > 0) ? DocEntityUser.GetUser(dtoSource.User.Id) : null;

            DocEntityJunction entity = null;
            if(permission == DocConstantPermission.ADD)
            {
                var now = DateTime.UtcNow;
                entity = new DocEntityJunction(session)
                {
                    Created = now,
                    Updated = now
                };
            }
            else
            {
                entity = DocEntityJunction.GetJunction(dtoSource.Id);
                if(null == entity)
                    throw new HttpError(HttpStatusCode.NotFound, $"No record");
            }

            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, dtoSource, pData, permission, DocConstantModelName.JUNCTION, nameof(dtoSource.Data)))
            {
                if(DocPermissionFactory.IsRequested(dtoSource, pData, entity.Data, nameof(dtoSource.Data)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(dtoSource.Data)} cannot be modified once set.");
                    entity.Data = pData;
                if(DocPermissionFactory.IsRequested<string>(dtoSource, pData, nameof(dtoSource.Data)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.Data), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.Data));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<int?>(currentUser, dtoSource, pOwnerId, permission, DocConstantModelName.JUNCTION, nameof(dtoSource.OwnerId)))
            {
                if(DocPermissionFactory.IsRequested(dtoSource, pOwnerId, entity.OwnerId, nameof(dtoSource.OwnerId)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(dtoSource.OwnerId)} cannot be modified once set.");
                    entity.OwnerId = pOwnerId;
                if(DocPermissionFactory.IsRequested<int?>(dtoSource, pOwnerId, nameof(dtoSource.OwnerId)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.OwnerId), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.OwnerId));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, dtoSource, pOwnerType, permission, DocConstantModelName.JUNCTION, nameof(dtoSource.OwnerType)))
            {
                if(DocPermissionFactory.IsRequested(dtoSource, pOwnerType, entity.OwnerType, nameof(dtoSource.OwnerType)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(dtoSource.OwnerType)} cannot be modified once set.");
                    entity.OwnerType = pOwnerType;
                if(DocPermissionFactory.IsRequested<string>(dtoSource, pOwnerType, nameof(dtoSource.OwnerType)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.OwnerType), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.OwnerType));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityJunction>(currentUser, dtoSource, pParent, permission, DocConstantModelName.JUNCTION, nameof(dtoSource.Parent)))
            {
                if(DocPermissionFactory.IsRequested(dtoSource, pParent, entity.Parent, nameof(dtoSource.Parent)))
                    entity.Parent = pParent;
                if(DocPermissionFactory.IsRequested<DocEntityJunction>(dtoSource, pParent, nameof(dtoSource.Parent)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.Parent), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.Parent));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<int?>(currentUser, dtoSource, pTargetId, permission, DocConstantModelName.JUNCTION, nameof(dtoSource.TargetId)))
            {
                if(DocPermissionFactory.IsRequested(dtoSource, pTargetId, entity.TargetId, nameof(dtoSource.TargetId)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(dtoSource.TargetId)} cannot be modified once set.");
                    entity.TargetId = pTargetId;
                if(DocPermissionFactory.IsRequested<int?>(dtoSource, pTargetId, nameof(dtoSource.TargetId)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.TargetId), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.TargetId));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, dtoSource, pTargetType, permission, DocConstantModelName.JUNCTION, nameof(dtoSource.TargetType)))
            {
                if(DocPermissionFactory.IsRequested(dtoSource, pTargetType, entity.TargetType, nameof(dtoSource.TargetType)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(dtoSource.TargetType)} cannot be modified once set.");
                    entity.TargetType = pTargetType;
                if(DocPermissionFactory.IsRequested<string>(dtoSource, pTargetType, nameof(dtoSource.TargetType)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.TargetType), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.TargetType));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityLookupTable>(currentUser, dtoSource, pType, permission, DocConstantModelName.JUNCTION, nameof(dtoSource.Type)))
            {
                if(DocPermissionFactory.IsRequested(dtoSource, pType, entity.Type, nameof(dtoSource.Type)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(dtoSource.Type)} cannot be modified once set.");
                    entity.Type = pType;
                if(DocPermissionFactory.IsRequested<DocEntityLookupTable>(dtoSource, pType, nameof(dtoSource.Type)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.Type), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.Type));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityUser>(currentUser, dtoSource, pUser, permission, DocConstantModelName.JUNCTION, nameof(dtoSource.User)))
            {
                if(DocPermissionFactory.IsRequested(dtoSource, pUser, entity.User, nameof(dtoSource.User)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(dtoSource.User)} cannot be modified once set.");
                    entity.User = pUser;
                if(DocPermissionFactory.IsRequested<DocEntityUser>(dtoSource, pUser, nameof(dtoSource.User)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.User), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.User));
                }
            }
            
            if (dtoSource.Locked) entity.Locked = dtoSource.Locked;

            entity.SaveChanges(permission);
            
            if (DocPermissionFactory.IsRequestedHasPermission<List<Reference>>(currentUser, dtoSource, pChildren, permission, DocConstantModelName.JUNCTION, nameof(dtoSource.Children)))
            {
                if (true == pChildren?.Any() )
                {
                    var requestedChildren = pChildren.Select(p => p.Id).Distinct().ToList();
                    var existsChildren = Execute.SelectAll<DocEntityJunction>().Where(e => e.Id.In(requestedChildren)).Select( e => e.Id ).ToList();
                    if (existsChildren.Count != requestedChildren.Count)
                    {
                        var nonExists = requestedChildren.Where(id => existsChildren.All(eId => eId != id));
                        throw new HttpError(HttpStatusCode.NotFound, $"Cannot patch collection Children with objects that do not exist. No matching Children(s) could be found for Ids: {nonExists.ToDelimitedString()}.");
                    }
                    var toAdd = requestedChildren.Where(id => entity.Children.All(e => e.Id != id)).ToList(); 
                    toAdd?.ForEach(id =>
                    {
                        var target = DocEntityJunction.GetJunction(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD, targetEntity: target, targetName: nameof(Junction), columnName: nameof(dtoSource.Children)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to add {nameof(dtoSource.Children)} to {nameof(Junction)}");
                        entity.Children.Add(target);
                    });
                    var toRemove = entity.Children.Where(e => requestedChildren.All(id => e.Id != id)).Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityJunction.GetJunction(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(Junction), columnName: nameof(dtoSource.Children)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(dtoSource.Children)} from {nameof(Junction)}");
                        entity.Children.Remove(target);
                    });
                }
                else
                {
                    var toRemove = entity.Children.Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityJunction.GetJunction(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(Junction), columnName: nameof(dtoSource.Children)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(dtoSource.Children)} from {nameof(Junction)}");
                        entity.Children.Remove(target);
                    });
                }
                if(DocPermissionFactory.IsRequested<List<Reference>>(dtoSource, pChildren, nameof(dtoSource.Children)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.Children), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.Children));
                }
            }
            DocPermissionFactory.SetVisibleFields<Junction>(currentUser, nameof(Junction), dtoSource.VisibleFields);
            ret = entity.ToDto();

            return ret;
        }
        public Junction Post(Junction dtoSource)
        {
            if(dtoSource == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            dtoSource.VisibleFields = dtoSource.VisibleFields ?? new List<string>();

            Junction ret = null;

            Execute.Run(ssn =>
            {
                if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "Junction")) 
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                ret = _AssignValues(dtoSource, DocConstantPermission.ADD, ssn);
            });

            return ret;
        }
   
        public List<Junction> Post(JunctionBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<Junction>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Post(dto) as Junction;
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

        public Junction Post(JunctionCopy request)
        {
            Junction ret = null;
            Execute.Run(ssn =>
            {
                var entity = DocEntityJunction.GetJunction(request?.Id);
                if(null == entity) throw new HttpError(HttpStatusCode.NoContent, "The COPY request did not succeed.");
                if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");
                
                    var pChildren = entity.Children.ToList();
                    var pData = entity.Data;
                    var pOwnerId = entity.OwnerId;
                    var pOwnerType = entity.OwnerType;
                    if(!DocTools.IsNullOrEmpty(pOwnerType))
                        pOwnerType += " (Copy)";
                    var pParent = entity.Parent;
                    var pTargetId = entity.TargetId;
                    var pTargetType = entity.TargetType;
                    if(!DocTools.IsNullOrEmpty(pTargetType))
                        pTargetType += " (Copy)";
                    var pType = entity.Type;
                    var pUser = entity.User;
                #region Custom Before copyJunction
                #endregion Custom Before copyJunction
                var copy = new DocEntityJunction(ssn)
                {
                    Hash = Guid.NewGuid()
                                , Data = pData
                                , OwnerId = pOwnerId
                                , OwnerType = pOwnerType
                                , Parent = pParent
                                , TargetId = pTargetId
                                , TargetType = pTargetType
                                , Type = pType
                                , User = pUser
                };
                            foreach(var item in pChildren)
                            {
                                entity.Children.Add(item);
                            }

                #region Custom After copyJunction
                #endregion Custom After copyJunction
                copy.SaveChanges(DocConstantPermission.ADD);
                ret = copy.ToDto();
            });
            return ret;
        }


        public List<Junction> Put(JunctionBatch request)
        {
            return Patch(request);
        }

        public Junction Put(Junction dtoSource)
        {
            return Patch(dtoSource);
        }

        public List<Junction> Patch(JunctionBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<Junction>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Patch(dto) as Junction;
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

        public Junction Patch(Junction dtoSource)
        {
            if(true != (dtoSource?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the Junction to patch.");
            
            dtoSource.VisibleFields = dtoSource.VisibleFields ?? new List<string>();
            
            Junction ret = null;
            Execute.Run(ssn =>
            {
                ret = _AssignValues(dtoSource, DocConstantPermission.EDIT, ssn);
            });
            return ret;
        }

        public void Delete(JunctionBatch request)
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

        public void Delete(Junction request)
        {
            Execute.Run(ssn =>
            {
                var en = DocEntityJunction.GetJunction(request?.Id);

                if(null == en) throw new HttpError(HttpStatusCode.NotFound, $"No Junction could be found for Id {request?.Id}.");
                if(en.IsRemoved) return;
                
                if(!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.DELETE))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have DELETE permission for this route.");
                
                en.Remove();
            });
        }

        public void Delete(JunctionSearch request)
        {
            var matches = Get(request) as List<Junction>;
            if(true != matches?.Any()) throw new HttpError(HttpStatusCode.NotFound, "No matches for request");

            Execute.Run(ssn =>
            {
                matches.ForEach(match =>
                {
                    Delete(match);
                });
            });
        }
        public object Get(JunctionJunction request)
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
                case "junction":
                    ret = _GetJunctionJunction(request, skip, take);
                    break;
                }
            });
            return ret;
        }
        
        public object Get(JunctionJunctionVersion request)
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
                case "junction":
                    ret = GetJunctionJunctionVersion(request);
                    break;
                }
            });
            return ret;
        }
        

        private object _GetJunctionJunction(JunctionJunction request, int skip, int take)
        {
             DocPermissionFactory.SetVisibleFields<Junction>(currentUser, "Junction", request.VisibleFields);
             var en = DocEntityJunction.GetJunction(request.Id);
             if (!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.VIEW, targetName: DocConstantModelName.JUNCTION, columnName: "Children", targetEntity: null))
                 throw new HttpError(HttpStatusCode.Forbidden, "You do not have View permission to relationships between Junction and Junction");
             return en?.Children.Take(take).Skip(skip).ConvertFromEntityList<DocEntityJunction,Junction>(new List<Junction>());
        }

        private List<Version> GetJunctionJunctionVersion(JunctionJunctionVersion request)
        { 
            if(!(request.Id > 0))
                throw new HttpError(HttpStatusCode.NotFound, "Valid Id required.");
            var ret = new List<Version>();
             Execute.Run((ssn) =>
             {
                var en = DocEntityJunction.GetJunction(request.Id);
                ret = en?.Children.Select(e => new Version(e.Id, e.VersionNo)).ToList();
             });
            return ret;
        }
        
        public object Post(JunctionJunction request)
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
                case "junction":
                    ret = _PostJunctionJunction(request);
                    break;
                }
            });
            return ret;
        }


        private object _PostJunctionJunction(JunctionJunction request)
        {
            var entity = DocEntityJunction.GetJunction(request.Id);

            if (null == entity) throw new HttpError(HttpStatusCode.NotFound, $"No Junction found for Id {request.Id}");

            if (!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.EDIT))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have Edit permission to Junction");

            foreach (var id in request.Ids)
            {
                var relationship = DocEntityJunction.GetJunction(id);
                if (!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD, targetEntity: relationship, targetName: DocConstantModelName.JUNCTION, columnName: "Children")) 
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have Add permission to the Children property.");
                if (null == relationship) throw new HttpError(HttpStatusCode.NotFound, $"Cannot post to collection of Junction with objects that do not exist. No matching Junction could be found for {id}.");
                entity.Children.Add(relationship);
            }
            entity.SaveChanges();
            return entity.ToDto();
        }

        public object Delete(JunctionJunction request)
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
                case "junction":
                    ret = _DeleteJunctionJunction(request);
                    break;
                }
            });
            return ret;
        }


        private object _DeleteJunctionJunction(JunctionJunction request)
        {
            var entity = DocEntityJunction.GetJunction(request.Id);

            if (null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No Junction found for Id {request.Id}");
            if (!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.EDIT))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have Edit permission to Junction");
            foreach (var id in request.Ids)
            {
                var relationship = DocEntityJunction.GetJunction(id);
                if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: relationship, targetName: DocConstantModelName.JUNCTION, columnName: "Children"))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have Edit permission to relationships between Junction and Junction");
                if(null != relationship && false == relationship.IsRemoved) entity.Children.Remove(relationship);
            }
            entity.SaveChanges();
            return entity.ToDto();
        }

        private Junction GetJunction(Junction request)
        {
            var id = request?.Id;
            Junction ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetVisibleFields<Junction>(currentUser, "Junction", request.VisibleFields);

            DocEntityJunction entity = null;
            if(id.HasValue)
            {
                entity = DocEntityJunction.GetJunction(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No Junction found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }
    }
}