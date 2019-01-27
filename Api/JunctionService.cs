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
        private IQueryable<DocEntityJunction> _ExecSearch(JunctionSearch request)
        {
            request = InitSearch<Junction, JunctionSearch>(request);
            IQueryable<DocEntityJunction> entities = null;
            Execute.Run( session => 
            {
                entities = Execute.SelectAll<DocEntityJunction>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new JunctionFullTextSearch(request);
                    entities = GetFullTextSearch<DocEntityJunction,JunctionFullTextSearch>(fts, entities);
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

                entities = ApplyFilters<DocEntityJunction,JunctionSearch>(request, entities);

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

        public List<Junction> Post(JunctionSearch request) => Get(request);

        public List<Junction> Get(JunctionSearch request) => GetSearchResult<Junction,DocEntityJunction,JunctionSearch>(DocConstantModelName.JUNCTION, request, _ExecSearch);

        public Junction Get(Junction request) => GetEntity<Junction>(DocConstantModelName.JUNCTION, request, GetJunction);
        private Junction _AssignValues(Junction request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "Junction"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            Junction ret = null;
            request = _InitAssignValues<Junction>(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            var cacheKey = GetApiCacheKey<Junction>(DocConstantModelName.JUNCTION, nameof(Junction), request);
            
            //First, assign all the variables, do database lookups and conversions
            var pChildren = request.Children?.ToList();
            var pData = request.Data;
            var pOwnerId = request.OwnerId;
            var pOwnerType = request.OwnerType;
            var pParent = (request.Parent?.Id > 0) ? DocEntityJunction.GetJunction(request.Parent.Id) : null;
            var pTargetId = request.TargetId;
            var pTargetType = request.TargetType;
            DocEntityLookupTable pType = GetLookup(DocConstantLookupTable.JUNCTIONTYPE, request.Type?.Name, request.Type?.Id);
            var pUser = (request.User?.Id > 0) ? DocEntityUser.GetUser(request.User.Id) : null;

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
                entity = DocEntityJunction.GetJunction(request.Id);
                if(null == entity)
                    throw new HttpError(HttpStatusCode.NotFound, $"No record");
            }

            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pData, permission, DocConstantModelName.JUNCTION, nameof(request.Data)))
            {
                if(DocPermissionFactory.IsRequested(request, pData, entity.Data, nameof(request.Data)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Data)} cannot be modified once set.");
                    entity.Data = pData;
                if(DocPermissionFactory.IsRequested<string>(request, pData, nameof(request.Data)) && !request.VisibleFields.Matches(nameof(request.Data), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Data));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<int?>(currentUser, request, pOwnerId, permission, DocConstantModelName.JUNCTION, nameof(request.OwnerId)))
            {
                if(DocPermissionFactory.IsRequested(request, pOwnerId, entity.OwnerId, nameof(request.OwnerId)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.OwnerId)} cannot be modified once set.");
                    entity.OwnerId = pOwnerId;
                if(DocPermissionFactory.IsRequested<int?>(request, pOwnerId, nameof(request.OwnerId)) && !request.VisibleFields.Matches(nameof(request.OwnerId), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.OwnerId));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pOwnerType, permission, DocConstantModelName.JUNCTION, nameof(request.OwnerType)))
            {
                if(DocPermissionFactory.IsRequested(request, pOwnerType, entity.OwnerType, nameof(request.OwnerType)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.OwnerType)} cannot be modified once set.");
                    entity.OwnerType = pOwnerType;
                if(DocPermissionFactory.IsRequested<string>(request, pOwnerType, nameof(request.OwnerType)) && !request.VisibleFields.Matches(nameof(request.OwnerType), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.OwnerType));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityJunction>(currentUser, request, pParent, permission, DocConstantModelName.JUNCTION, nameof(request.Parent)))
            {
                if(DocPermissionFactory.IsRequested(request, pParent, entity.Parent, nameof(request.Parent)))
                    entity.Parent = pParent;
                if(DocPermissionFactory.IsRequested<DocEntityJunction>(request, pParent, nameof(request.Parent)) && !request.VisibleFields.Matches(nameof(request.Parent), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Parent));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<int?>(currentUser, request, pTargetId, permission, DocConstantModelName.JUNCTION, nameof(request.TargetId)))
            {
                if(DocPermissionFactory.IsRequested(request, pTargetId, entity.TargetId, nameof(request.TargetId)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.TargetId)} cannot be modified once set.");
                    entity.TargetId = pTargetId;
                if(DocPermissionFactory.IsRequested<int?>(request, pTargetId, nameof(request.TargetId)) && !request.VisibleFields.Matches(nameof(request.TargetId), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.TargetId));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pTargetType, permission, DocConstantModelName.JUNCTION, nameof(request.TargetType)))
            {
                if(DocPermissionFactory.IsRequested(request, pTargetType, entity.TargetType, nameof(request.TargetType)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.TargetType)} cannot be modified once set.");
                    entity.TargetType = pTargetType;
                if(DocPermissionFactory.IsRequested<string>(request, pTargetType, nameof(request.TargetType)) && !request.VisibleFields.Matches(nameof(request.TargetType), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.TargetType));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityLookupTable>(currentUser, request, pType, permission, DocConstantModelName.JUNCTION, nameof(request.Type)))
            {
                if(DocPermissionFactory.IsRequested(request, pType, entity.Type, nameof(request.Type)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Type)} cannot be modified once set.");
                    entity.Type = pType;
                if(DocPermissionFactory.IsRequested<DocEntityLookupTable>(request, pType, nameof(request.Type)) && !request.VisibleFields.Matches(nameof(request.Type), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Type));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityUser>(currentUser, request, pUser, permission, DocConstantModelName.JUNCTION, nameof(request.User)))
            {
                if(DocPermissionFactory.IsRequested(request, pUser, entity.User, nameof(request.User)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.User)} cannot be modified once set.");
                    entity.User = pUser;
                if(DocPermissionFactory.IsRequested<DocEntityUser>(request, pUser, nameof(request.User)) && !request.VisibleFields.Matches(nameof(request.User), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.User));
                }
            }
            
            if (request.Locked) entity.Locked = request.Locked;

            entity.SaveChanges(permission);
            
            if (DocPermissionFactory.IsRequestedHasPermission<List<Reference>>(currentUser, request, pChildren, permission, DocConstantModelName.JUNCTION, nameof(request.Children)))
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
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD, targetEntity: target, targetName: nameof(Junction), columnName: nameof(request.Children)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to add {nameof(request.Children)} to {nameof(Junction)}");
                        entity.Children.Add(target);
                    });
                    var toRemove = entity.Children.Where(e => requestedChildren.All(id => e.Id != id)).Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityJunction.GetJunction(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(Junction), columnName: nameof(request.Children)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Children)} from {nameof(Junction)}");
                        entity.Children.Remove(target);
                    });
                }
                else
                {
                    var toRemove = entity.Children.Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityJunction.GetJunction(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(Junction), columnName: nameof(request.Children)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Children)} from {nameof(Junction)}");
                        entity.Children.Remove(target);
                    });
                }
                if(DocPermissionFactory.IsRequested<List<Reference>>(request, pChildren, nameof(request.Children)) && !request.VisibleFields.Matches(nameof(request.Children), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Children));
                }
            }
            DocPermissionFactory.SetVisibleFields<Junction>(currentUser, nameof(Junction), request.VisibleFields);
            ret = entity.ToDto();

            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.JUNCTION);

            return ret;
        }
        public Junction Post(Junction request)
        {
            if(request == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            Junction ret = null;

            Execute.Run(ssn =>
            {
                if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "Junction")) 
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                ret = _AssignValues(request, DocConstantPermission.ADD, ssn);
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

        public Junction Put(Junction request)
        {
            return Patch(request);
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

        public Junction Patch(Junction request)
        {
            if(true != (request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the Junction to patch.");
            
            request.VisibleFields = request.VisibleFields ?? new List<string>();
            
            Junction ret = null;
            Execute.Run(ssn =>
            {
                ret = _AssignValues(request, DocConstantPermission.EDIT, ssn);
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
                if(!(request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, $"No Id provided for delete.");

                DocCacheClient.RemoveSearch(DocConstantModelName.JUNCTION);
                DocCacheClient.RemoveById(request.Id);
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
                    ret = GetJunctionSearchResult<Junction, DocEntityJunction, DocEntityJunction, Junction, JunctionSearch>((int)request.Id, DocConstantModelName.JUNCTION, "Children", request,
                        (ss) =>
                        { 
                            var service = HostContext.ResolveService<JunctionService>(Request);
                            return service.Get(ss);
                        });
                    break;
                }
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

        public List<int> Any(JunctionIds request)
        {
            List<int> ret = null;
            if (currentUser.IsSuperAdmin)
            {
                Execute.Run(s => { ret = Execute.SelectAll<DocEntityJunction>().Select(d => d.Id).ToList(); });
            }
            else
            {
                throw new HttpError(HttpStatusCode.Forbidden);
            }

            return ret;
        }
    }
}