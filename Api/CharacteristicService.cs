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
    public partial class CharacteristicService : DocServiceBase
    {
        private void _ExecSearch(CharacteristicSearch request, Action<IQueryable<DocEntityCharacteristic>> callBack)
        {
            request = InitSearch(request);
            
            DocPermissionFactory.SetVisibleFields<Characteristic>(currentUser, "Characteristic", request.VisibleFields);

            Execute.Run( session => 
            {
                var entities = Execute.SelectAll<DocEntityCharacteristic>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new CharacteristicFullTextSearch(request);
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

                        if(true == request.DocumentSetsIds?.Any())
                        {
                            entities = entities.Where(en => en.DocumentSets.Any(r => r.Id.In(request.DocumentSetsIds)));
                        }
                if(!DocTools.IsNullOrEmpty(request.Name))
                    entities = entities.Where(en => en.Name.Contains(request.Name));
                if(!DocTools.IsNullOrEmpty(request.URI))
                    entities = entities.Where(en => en.URI.Contains(request.URI));

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
        
        public object Post(CharacteristicSearch request)
        {
            return Get(request);
        }

        public object Get(CharacteristicSearch request)
        {
            object tryRet = null;
            var ret = new List<Characteristic>();
            var cacheKey = GetApiCacheKey<Characteristic>(DocConstantModelName.CHARACTERISTIC, nameof(Characteristic), request);
            using (var cancellableRequest = base.Request.CreateCancellableRequest())
            {
                var requestCancel = new DocRequestCancellation(HttpContext.Current.Response, cancellableRequest);
                try 
                {
                    if (tryRet == null)
                    {
                        _ExecSearch(request, (entities) => entities.ConvertFromEntityList<DocEntityCharacteristic,Characteristic>(ret, Execute, requestCancel));
                        tryRet = ret;
                        //Go ahead and cache the result for any future consumers
                        DocCacheClient.Set(key: cacheKey, value: ret, entityType: DocConstantModelName.CHARACTERISTIC, search: true);
                    }
                }
                catch(Exception) { throw; }
                finally
                {
                    requestCancel?.CloseRequest();
                }
            }
            DocCacheClient.SyncKeys(key: cacheKey, entityType: DocConstantModelName.CHARACTERISTIC, search: true);
            return tryRet;
        }

        public object Post(CharacteristicVersion request) 
        {
            return Get(request);
        }

        public object Get(CharacteristicVersion request) 
        {
            var ret = new List<Version>();
            _ExecSearch(request, (entities) => 
            {
                ret = entities.Select(e => new Version(e.Id, e.VersionNo)).ToList();
            });
            return ret;
        }

        public object Get(Characteristic request)
        {
            object ret = null;
            
            if(!(request.Id > 0))
                throw new HttpError(HttpStatusCode.NotFound, "Valid Id required.");

            DocPermissionFactory.SetVisibleFields<Characteristic>(currentUser, "Characteristic", request.VisibleFields);
            var cacheKey = GetApiCacheKey<Characteristic>(DocConstantModelName.CHARACTERISTIC, nameof(Characteristic), request);
            if(null == ret)
            {
                Execute.Run(s =>
                {
                    ret = GetCharacteristic(request);
                    DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.CHARACTERISTIC);
                });
            }
            DocCacheClient.SyncKeys(key: cacheKey, entityId: request.Id, entityType: DocConstantModelName.CHARACTERISTIC);
            return ret;
        }

        private Characteristic _AssignValues(Characteristic request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "Characteristic"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            Characteristic ret = null;
            request = _InitAssignValues(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            var cacheKey = GetApiCacheKey<Characteristic>(DocConstantModelName.CHARACTERISTIC, nameof(Characteristic), request);
            
            //First, assign all the variables, do database lookups and conversions
            var pDocumentSets = request.DocumentSets?.ToList();
            var pName = request.Name;
            var pURI = request.URI;

            DocEntityCharacteristic entity = null;
            if(permission == DocConstantPermission.ADD)
            {
                var now = DateTime.UtcNow;
                entity = new DocEntityCharacteristic(session)
                {
                    Created = now,
                    Updated = now
                };
            }
            else
            {
                entity = DocEntityCharacteristic.GetCharacteristic(request.Id);
                if(null == entity)
                    throw new HttpError(HttpStatusCode.NotFound, $"No record");
            }

            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pName, permission, DocConstantModelName.CHARACTERISTIC, nameof(request.Name)))
            {
                if(DocPermissionFactory.IsRequested(request, pName, entity.Name, nameof(request.Name)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Name)} cannot be modified once set.");
                    entity.Name = pName;
                if(DocPermissionFactory.IsRequested<string>(request, pName, nameof(request.Name)) && !request.VisibleFields.Matches(nameof(request.Name), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Name));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pURI, permission, DocConstantModelName.CHARACTERISTIC, nameof(request.URI)))
            {
                if(DocPermissionFactory.IsRequested(request, pURI, entity.URI, nameof(request.URI)))
                    entity.URI = pURI;
                if(DocPermissionFactory.IsRequested<string>(request, pURI, nameof(request.URI)) && !request.VisibleFields.Matches(nameof(request.URI), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.URI));
                }
            }
            
            if (request.Locked) entity.Locked = request.Locked;

            entity.SaveChanges(permission);
            
            if (DocPermissionFactory.IsRequestedHasPermission<List<Reference>>(currentUser, request, pDocumentSets, permission, DocConstantModelName.CHARACTERISTIC, nameof(request.DocumentSets)))
            {
                if (true == pDocumentSets?.Any() )
                {
                    var requestedDocumentSets = pDocumentSets.Select(p => p.Id).Distinct().ToList();
                    var existsDocumentSets = Execute.SelectAll<DocEntityDocumentSet>().Where(e => e.Id.In(requestedDocumentSets)).Select( e => e.Id ).ToList();
                    if (existsDocumentSets.Count != requestedDocumentSets.Count)
                    {
                        var nonExists = requestedDocumentSets.Where(id => existsDocumentSets.All(eId => eId != id));
                        throw new HttpError(HttpStatusCode.NotFound, $"Cannot patch collection DocumentSets with objects that do not exist. No matching DocumentSets(s) could be found for Ids: {nonExists.ToDelimitedString()}.");
                    }
                    var toAdd = requestedDocumentSets.Where(id => entity.DocumentSets.All(e => e.Id != id)).ToList(); 
                    toAdd?.ForEach(id =>
                    {
                        var target = DocEntityDocumentSet.GetDocumentSet(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD, targetEntity: target, targetName: nameof(Characteristic), columnName: nameof(request.DocumentSets)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to add {nameof(request.DocumentSets)} to {nameof(Characteristic)}");
                        entity.DocumentSets.Add(target);
                    });
                    var toRemove = entity.DocumentSets.Where(e => requestedDocumentSets.All(id => e.Id != id)).Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityDocumentSet.GetDocumentSet(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(Characteristic), columnName: nameof(request.DocumentSets)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.DocumentSets)} from {nameof(Characteristic)}");
                        entity.DocumentSets.Remove(target);
                    });
                }
                else
                {
                    var toRemove = entity.DocumentSets.Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityDocumentSet.GetDocumentSet(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(Characteristic), columnName: nameof(request.DocumentSets)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.DocumentSets)} from {nameof(Characteristic)}");
                        entity.DocumentSets.Remove(target);
                    });
                }
                if(DocPermissionFactory.IsRequested<List<Reference>>(request, pDocumentSets, nameof(request.DocumentSets)) && !request.VisibleFields.Matches(nameof(request.DocumentSets), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.DocumentSets));
                }
            }
            DocPermissionFactory.SetVisibleFields<Characteristic>(currentUser, nameof(Characteristic), request.VisibleFields);
            ret = entity.ToDto();

            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.CHARACTERISTIC);

            return ret;
        }
        public Characteristic Post(Characteristic request)
        {
            if(request == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            Characteristic ret = null;

            Execute.Run(ssn =>
            {
                if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "Characteristic")) 
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                ret = _AssignValues(request, DocConstantPermission.ADD, ssn);
            });

            return ret;
        }
   
        public List<Characteristic> Post(CharacteristicBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<Characteristic>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Post(dto) as Characteristic;
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

        public Characteristic Post(CharacteristicCopy request)
        {
            Characteristic ret = null;
            Execute.Run(ssn =>
            {
                var entity = DocEntityCharacteristic.GetCharacteristic(request?.Id);
                if(null == entity) throw new HttpError(HttpStatusCode.NoContent, "The COPY request did not succeed.");
                if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");
                
                    var pDocumentSets = entity.DocumentSets.ToList();
                    var pName = entity.Name;
                    if(!DocTools.IsNullOrEmpty(pName))
                        pName += " (Copy)";
                    var pURI = entity.URI;
                    if(!DocTools.IsNullOrEmpty(pURI))
                        pURI += " (Copy)";
                #region Custom Before copyCharacteristic
                #endregion Custom Before copyCharacteristic
                var copy = new DocEntityCharacteristic(ssn)
                {
                    Hash = Guid.NewGuid()
                                , Name = pName
                                , URI = pURI
                };
                            foreach(var item in pDocumentSets)
                            {
                                entity.DocumentSets.Add(item);
                            }

                #region Custom After copyCharacteristic
                #endregion Custom After copyCharacteristic
                copy.SaveChanges(DocConstantPermission.ADD);
                ret = copy.ToDto();
            });
            return ret;
        }


        public List<Characteristic> Put(CharacteristicBatch request)
        {
            return Patch(request);
        }

        public Characteristic Put(Characteristic request)
        {
            return Patch(request);
        }

        public List<Characteristic> Patch(CharacteristicBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<Characteristic>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Patch(dto) as Characteristic;
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

        public Characteristic Patch(Characteristic request)
        {
            if(true != (request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the Characteristic to patch.");
            
            request.VisibleFields = request.VisibleFields ?? new List<string>();
            
            Characteristic ret = null;
            Execute.Run(ssn =>
            {
                ret = _AssignValues(request, DocConstantPermission.EDIT, ssn);
            });
            return ret;
        }

        public void Delete(CharacteristicBatch request)
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

        public void Delete(Characteristic request)
        {
            Execute.Run(ssn =>
            {
                if(!(request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, $"No Id provided for delete.");

                DocCacheClient.RemoveSearch(DocConstantModelName.CHARACTERISTIC);
                DocCacheClient.RemoveById(request.Id);
                var en = DocEntityCharacteristic.GetCharacteristic(request?.Id);

                if(null == en) throw new HttpError(HttpStatusCode.NotFound, $"No Characteristic could be found for Id {request?.Id}.");
                if(en.IsRemoved) return;
                
                if(!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.DELETE))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have DELETE permission for this route.");
                
                en.Remove();
            });
        }

        public void Delete(CharacteristicSearch request)
        {
            var matches = Get(request) as List<Characteristic>;
            if(true != matches?.Any()) throw new HttpError(HttpStatusCode.NotFound, "No matches for request");

            Execute.Run(ssn =>
            {
                matches.ForEach(match =>
                {
                    Delete(match);
                });
            });
        }
        public object Get(CharacteristicJunction request)
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
                case "documentset":
                    ret = _GetCharacteristicDocumentSet(request, skip, take);
                    break;
                }
            });
            return ret;
        }
        
        public object Get(CharacteristicJunctionVersion request)
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
                case "documentset":
                    ret = GetCharacteristicDocumentSetVersion(request);
                    break;
                }
            });
            return ret;
        }
        

        private object _GetCharacteristicDocumentSet(CharacteristicJunction request, int skip, int take)
        {
             request.VisibleFields = InitVisibleFields<DocumentSet>(Dto.DocumentSet.Fields, request.VisibleFields);
             var en = DocEntityCharacteristic.GetCharacteristic(request.Id);
             if (!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.VIEW, targetName: DocConstantModelName.CHARACTERISTIC, columnName: "DocumentSets", targetEntity: null))
                 throw new HttpError(HttpStatusCode.Forbidden, "You do not have View permission to relationships between Characteristic and DocumentSet");
             return en?.DocumentSets.Take(take).Skip(skip).ConvertFromEntityList<DocEntityDocumentSet,DocumentSet>(new List<DocumentSet>());
        }

        private List<Version> GetCharacteristicDocumentSetVersion(CharacteristicJunctionVersion request)
        { 
            if(!(request.Id > 0))
                throw new HttpError(HttpStatusCode.NotFound, "Valid Id required.");
            var ret = new List<Version>();
             Execute.Run((ssn) =>
             {
                var en = DocEntityCharacteristic.GetCharacteristic(request.Id);
                ret = en?.DocumentSets.Select(e => new Version(e.Id, e.VersionNo)).ToList();
             });
            return ret;
        }
        
        public object Post(CharacteristicJunction request)
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
                case "documentset":
                    ret = _PostCharacteristicDocumentSet(request);
                    break;
                }
            });
            return ret;
        }


        private object _PostCharacteristicDocumentSet(CharacteristicJunction request)
        {
            var entity = DocEntityCharacteristic.GetCharacteristic(request.Id);

            if (null == entity) throw new HttpError(HttpStatusCode.NotFound, $"No Characteristic found for Id {request.Id}");

            if (!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.EDIT))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have Edit permission to Characteristic");

            foreach (var id in request.Ids)
            {
                var relationship = DocEntityDocumentSet.GetDocumentSet(id);
                if (!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD, targetEntity: relationship, targetName: DocConstantModelName.DOCUMENTSET, columnName: "DocumentSets")) 
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have Add permission to the DocumentSets property.");
                if (null == relationship) throw new HttpError(HttpStatusCode.NotFound, $"Cannot post to collection of Characteristic with objects that do not exist. No matching DocumentSet could be found for {id}.");
                entity.DocumentSets.Add(relationship);
            }
            entity.SaveChanges();
            return entity.ToDto();
        }

        public object Delete(CharacteristicJunction request)
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
                case "documentset":
                    ret = _DeleteCharacteristicDocumentSet(request);
                    break;
                }
            });
            return ret;
        }


        private object _DeleteCharacteristicDocumentSet(CharacteristicJunction request)
        {
            var entity = DocEntityCharacteristic.GetCharacteristic(request.Id);

            if (null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No Characteristic found for Id {request.Id}");
            if (!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.EDIT))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have Edit permission to Characteristic");
            foreach (var id in request.Ids)
            {
                var relationship = DocEntityDocumentSet.GetDocumentSet(id);
                if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: relationship, targetName: DocConstantModelName.DOCUMENTSET, columnName: "DocumentSets"))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have Edit permission to relationships between Characteristic and DocumentSet");
                if(null != relationship && false == relationship.IsRemoved) entity.DocumentSets.Remove(relationship);
            }
            entity.SaveChanges();
            return entity.ToDto();
        }

        private Characteristic GetCharacteristic(Characteristic request)
        {
            var id = request?.Id;
            Characteristic ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetVisibleFields<Characteristic>(currentUser, "Characteristic", request.VisibleFields);

            DocEntityCharacteristic entity = null;
            if(id.HasValue)
            {
                entity = DocEntityCharacteristic.GetCharacteristic(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No Characteristic found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }

        public List<int> Any(CharacteristicIds request)
        {
            List<int> ret = null;
            if (currentUser.IsSuperAdmin)
            {
                Execute.Run(s => { ret = Execute.SelectAll<DocEntityCharacteristic>().Select(d => d.Id).ToList(); });
            }
            else
            {
                throw new HttpError(HttpStatusCode.Forbidden);
            }

            return ret;
        }
    }
}