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
    public partial class TermSynonymService : DocServiceBase
    {
        private IQueryable<DocEntityTermSynonym> _ExecSearch(TermSynonymSearch request)
        {
            request = InitSearch<TermSynonym, TermSynonymSearch>(request);
            IQueryable<DocEntityTermSynonym> entities = null;
            Execute.Run( session => 
            {
                entities = Execute.SelectAll<DocEntityTermSynonym>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new TermSynonymFullTextSearch(request);
                    entities = GetFullTextSearch<DocEntityTermSynonym,TermSynonymFullTextSearch>(fts, entities);
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

                if(request.Approved.HasValue)
                    entities = entities.Where(en => request.Approved.Value == en.Approved);
                        if(true == request.BindingsIds?.Any())
                        {
                            entities = entities.Where(en => en.Bindings.Any(r => r.Id.In(request.BindingsIds)));
                        }
                if(!DocTools.IsNullOrEmpty(request.Master) && !DocTools.IsNullOrEmpty(request.Master.Id))
                {
                    entities = entities.Where(en => en.Master.Id == request.Master.Id );
                }
                if(true == request.MasterIds?.Any())
                {
                    entities = entities.Where(en => en.Master.Id.In(request.MasterIds));
                }
                if(request.Preferred.HasValue)
                    entities = entities.Where(en => request.Preferred.Value == en.Preferred);
                if(!DocTools.IsNullOrEmpty(request.Scope) && !DocTools.IsNullOrEmpty(request.Scope.Id))
                {
                    entities = entities.Where(en => en.Scope.Id == request.Scope.Id );
                }
                if(true == request.ScopeIds?.Any())
                {
                    entities = entities.Where(en => en.Scope.Id.In(request.ScopeIds));
                }
                if(!DocTools.IsNullOrEmpty(request.Synonym))
                    entities = entities.Where(en => en.Synonym.Contains(request.Synonym));

                entities = ApplyFilters<DocEntityTermSynonym,TermSynonymSearch>(request, entities);

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

        public object Post(TermSynonymSearch request) => Get(request);

        public object Get(TermSynonymSearch request) => GetSearchResultWithCache<TermSynonym,DocEntityTermSynonym,TermSynonymSearch>(DocConstantModelName.TERMSYNONYM, request, _ExecSearch);

        public object Post(TermSynonymVersion request) => Get(request);

        public object Get(TermSynonymVersion request) 
        {
            List<Version> ret = null;
            Execute.Run(s=>
            {
                ret = _ExecSearch(request).Select(e => new Version(e.Id, e.VersionNo)).ToList();
            });
            return ret;
        }

        public object Get(TermSynonym request) => GetEntityWithCache<TermSynonym>(DocConstantModelName.TERMSYNONYM, request, GetTermSynonym);
        private TermSynonym _AssignValues(TermSynonym request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "TermSynonym"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            TermSynonym ret = null;
            request = _InitAssignValues<TermSynonym>(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            var cacheKey = GetApiCacheKey<TermSynonym>(DocConstantModelName.TERMSYNONYM, nameof(TermSynonym), request);
            
            //First, assign all the variables, do database lookups and conversions
            var pApproved = request.Approved;
            var pBindings = request.Bindings?.ToList();
            var pMaster = (request.Master?.Id > 0) ? DocEntityTermMaster.GetTermMaster(request.Master.Id) : null;
            var pPreferred = request.Preferred;
            var pScope = (request.Scope?.Id > 0) ? DocEntityScope.GetScope(request.Scope.Id) : null;
            var pSynonym = request.Synonym;

            DocEntityTermSynonym entity = null;
            if(permission == DocConstantPermission.ADD)
            {
                var now = DateTime.UtcNow;
                entity = new DocEntityTermSynonym(session)
                {
                    Created = now,
                    Updated = now
                };
            }
            else
            {
                entity = DocEntityTermSynonym.GetTermSynonym(request.Id);
                if(null == entity)
                    throw new HttpError(HttpStatusCode.NotFound, $"No record");
            }

            if (DocPermissionFactory.IsRequestedHasPermission<bool>(currentUser, request, pApproved, permission, DocConstantModelName.TERMSYNONYM, nameof(request.Approved)))
            {
                if(DocPermissionFactory.IsRequested(request, pApproved, entity.Approved, nameof(request.Approved)))
                    entity.Approved = pApproved;
                if(DocPermissionFactory.IsRequested<bool>(request, pApproved, nameof(request.Approved)) && !request.VisibleFields.Matches(nameof(request.Approved), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Approved));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityTermMaster>(currentUser, request, pMaster, permission, DocConstantModelName.TERMSYNONYM, nameof(request.Master)))
            {
                if(DocPermissionFactory.IsRequested(request, pMaster, entity.Master, nameof(request.Master)))
                    entity.Master = pMaster;
                if(DocPermissionFactory.IsRequested<DocEntityTermMaster>(request, pMaster, nameof(request.Master)) && !request.VisibleFields.Matches(nameof(request.Master), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Master));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<bool>(currentUser, request, pPreferred, permission, DocConstantModelName.TERMSYNONYM, nameof(request.Preferred)))
            {
                if(DocPermissionFactory.IsRequested(request, pPreferred, entity.Preferred, nameof(request.Preferred)))
                    entity.Preferred = pPreferred;
                if(DocPermissionFactory.IsRequested<bool>(request, pPreferred, nameof(request.Preferred)) && !request.VisibleFields.Matches(nameof(request.Preferred), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Preferred));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityScope>(currentUser, request, pScope, permission, DocConstantModelName.TERMSYNONYM, nameof(request.Scope)))
            {
                if(DocPermissionFactory.IsRequested(request, pScope, entity.Scope, nameof(request.Scope)))
                    entity.Scope = pScope;
                if(DocPermissionFactory.IsRequested<DocEntityScope>(request, pScope, nameof(request.Scope)) && !request.VisibleFields.Matches(nameof(request.Scope), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Scope));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pSynonym, permission, DocConstantModelName.TERMSYNONYM, nameof(request.Synonym)))
            {
                if(DocPermissionFactory.IsRequested(request, pSynonym, entity.Synonym, nameof(request.Synonym)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Synonym)} cannot be modified once set.");
                    entity.Synonym = pSynonym;
                if(DocPermissionFactory.IsRequested<string>(request, pSynonym, nameof(request.Synonym)) && !request.VisibleFields.Matches(nameof(request.Synonym), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Synonym));
                }
            }
            
            if (request.Locked) entity.Locked = request.Locked;

            entity.SaveChanges(permission);
            
            if (DocPermissionFactory.IsRequestedHasPermission<List<Reference>>(currentUser, request, pBindings, permission, DocConstantModelName.TERMSYNONYM, nameof(request.Bindings)))
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
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD, targetEntity: target, targetName: nameof(TermSynonym), columnName: nameof(request.Bindings)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to add {nameof(request.Bindings)} to {nameof(TermSynonym)}");
                        entity.Bindings.Add(target);
                    });
                    var toRemove = entity.Bindings.Where(e => requestedBindings.All(id => e.Id != id)).Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityLookupTableBinding.GetLookupTableBinding(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(TermSynonym), columnName: nameof(request.Bindings)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Bindings)} from {nameof(TermSynonym)}");
                        entity.Bindings.Remove(target);
                    });
                }
                else
                {
                    var toRemove = entity.Bindings.Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityLookupTableBinding.GetLookupTableBinding(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(TermSynonym), columnName: nameof(request.Bindings)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Bindings)} from {nameof(TermSynonym)}");
                        entity.Bindings.Remove(target);
                    });
                }
                if(DocPermissionFactory.IsRequested<List<Reference>>(request, pBindings, nameof(request.Bindings)) && !request.VisibleFields.Matches(nameof(request.Bindings), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Bindings));
                }
            }
            DocPermissionFactory.SetVisibleFields<TermSynonym>(currentUser, nameof(TermSynonym), request.VisibleFields);
            ret = entity.ToDto();

            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.TERMSYNONYM);

            return ret;
        }
        public TermSynonym Post(TermSynonym request)
        {
            if(request == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            TermSynonym ret = null;

            Execute.Run(ssn =>
            {
                if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "TermSynonym")) 
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                ret = _AssignValues(request, DocConstantPermission.ADD, ssn);
            });

            return ret;
        }
   
        public List<TermSynonym> Post(TermSynonymBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<TermSynonym>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Post(dto) as TermSynonym;
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

        public TermSynonym Post(TermSynonymCopy request)
        {
            TermSynonym ret = null;
            Execute.Run(ssn =>
            {
                var entity = DocEntityTermSynonym.GetTermSynonym(request?.Id);
                if(null == entity) throw new HttpError(HttpStatusCode.NoContent, "The COPY request did not succeed.");
                if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");
                
                    var pApproved = entity.Approved;
                    var pBindings = entity.Bindings.ToList();
                    var pMaster = entity.Master;
                    var pPreferred = entity.Preferred;
                    var pScope = entity.Scope;
                    var pSynonym = entity.Synonym;
                    if(!DocTools.IsNullOrEmpty(pSynonym))
                        pSynonym += " (Copy)";
                #region Custom Before copyTermSynonym
                #endregion Custom Before copyTermSynonym
                var copy = new DocEntityTermSynonym(ssn)
                {
                    Hash = Guid.NewGuid()
                                , Approved = pApproved
                                , Master = pMaster
                                , Preferred = pPreferred
                                , Scope = pScope
                                , Synonym = pSynonym
                };
                            foreach(var item in pBindings)
                            {
                                entity.Bindings.Add(item);
                            }

                #region Custom After copyTermSynonym
                #endregion Custom After copyTermSynonym
                copy.SaveChanges(DocConstantPermission.ADD);
                ret = copy.ToDto();
            });
            return ret;
        }


        public List<TermSynonym> Put(TermSynonymBatch request)
        {
            return Patch(request);
        }

        public TermSynonym Put(TermSynonym request)
        {
            return Patch(request);
        }

        public List<TermSynonym> Patch(TermSynonymBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<TermSynonym>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Patch(dto) as TermSynonym;
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

        public TermSynonym Patch(TermSynonym request)
        {
            if(true != (request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the TermSynonym to patch.");
            
            request.VisibleFields = request.VisibleFields ?? new List<string>();
            
            TermSynonym ret = null;
            Execute.Run(ssn =>
            {
                ret = _AssignValues(request, DocConstantPermission.EDIT, ssn);
            });
            return ret;
        }

        public void Delete(TermSynonymBatch request)
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

        public void Delete(TermSynonym request)
        {
            Execute.Run(ssn =>
            {
                if(!(request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, $"No Id provided for delete.");

                DocCacheClient.RemoveSearch(DocConstantModelName.TERMSYNONYM);
                DocCacheClient.RemoveById(request.Id);
                var en = DocEntityTermSynonym.GetTermSynonym(request?.Id);

                if(null == en) throw new HttpError(HttpStatusCode.NotFound, $"No TermSynonym could be found for Id {request?.Id}.");
                if(en.IsRemoved) return;
                
                if(!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.DELETE))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have DELETE permission for this route.");
                
                en.Remove();
            });
        }

        public void Delete(TermSynonymSearch request)
        {
            var matches = Get(request) as List<TermSynonym>;
            if(true != matches?.Any()) throw new HttpError(HttpStatusCode.NotFound, "No matches for request");

            Execute.Run(ssn =>
            {
                matches.ForEach(match =>
                {
                    Delete(match);
                });
            });
        }
        public object Get(TermSynonymJunction request)
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
                case "lookuptablebinding":
                    ret = _GetTermSynonymLookupTableBinding(request, skip, take);
                    break;
                }
            });
            return ret;
        }
        
        public object Get(TermSynonymJunctionVersion request)
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
                case "lookuptablebinding":
                    ret = GetTermSynonymLookupTableBindingVersion(request);
                    break;
                }
            });
            return ret;
        }
        

        private object _GetTermSynonymLookupTableBinding(TermSynonymJunction request, int skip, int take)
        {
             request.VisibleFields = InitVisibleFields<LookupTableBinding>(Dto.LookupTableBinding.Fields, request.VisibleFields);
             var en = DocEntityTermSynonym.GetTermSynonym(request.Id);
             if (!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.VIEW, targetName: DocConstantModelName.TERMSYNONYM, columnName: "Bindings", targetEntity: null))
                 throw new HttpError(HttpStatusCode.Forbidden, "You do not have View permission to relationships between TermSynonym and LookupTableBinding");
             return en?.Bindings.Take(take).Skip(skip).ConvertFromEntityList<DocEntityLookupTableBinding,LookupTableBinding>(new List<LookupTableBinding>());
        }

        private List<Version> GetTermSynonymLookupTableBindingVersion(TermSynonymJunctionVersion request)
        { 
            if(!(request.Id > 0))
                throw new HttpError(HttpStatusCode.NotFound, "Valid Id required.");
            var ret = new List<Version>();
             Execute.Run((ssn) =>
             {
                var en = DocEntityTermSynonym.GetTermSynonym(request.Id);
                ret = en?.Bindings.Select(e => new Version(e.Id, e.VersionNo)).ToList();
             });
            return ret;
        }
        
        public object Post(TermSynonymJunction request)
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
                case "lookuptablebinding":
                    ret = _PostTermSynonymLookupTableBinding(request);
                    break;
                }
            });
            return ret;
        }


        private object _PostTermSynonymLookupTableBinding(TermSynonymJunction request)
        {
            var entity = DocEntityTermSynonym.GetTermSynonym(request.Id);

            if (null == entity) throw new HttpError(HttpStatusCode.NotFound, $"No TermSynonym found for Id {request.Id}");

            if (!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.EDIT))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have Edit permission to TermSynonym");

            foreach (var id in request.Ids)
            {
                var relationship = DocEntityLookupTableBinding.GetLookupTableBinding(id);
                if (!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD, targetEntity: relationship, targetName: DocConstantModelName.LOOKUPTABLEBINDING, columnName: "Bindings")) 
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have Add permission to the Bindings property.");
                if (null == relationship) throw new HttpError(HttpStatusCode.NotFound, $"Cannot post to collection of TermSynonym with objects that do not exist. No matching LookupTableBinding could be found for {id}.");
                entity.Bindings.Add(relationship);
            }
            entity.SaveChanges();
            return entity.ToDto();
        }

        public object Delete(TermSynonymJunction request)
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
                case "lookuptablebinding":
                    ret = _DeleteTermSynonymLookupTableBinding(request);
                    break;
                }
            });
            return ret;
        }


        private object _DeleteTermSynonymLookupTableBinding(TermSynonymJunction request)
        {
            var entity = DocEntityTermSynonym.GetTermSynonym(request.Id);

            if (null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No TermSynonym found for Id {request.Id}");
            if (!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.EDIT))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have Edit permission to TermSynonym");
            foreach (var id in request.Ids)
            {
                var relationship = DocEntityLookupTableBinding.GetLookupTableBinding(id);
                if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: relationship, targetName: DocConstantModelName.LOOKUPTABLEBINDING, columnName: "Bindings"))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have Edit permission to relationships between TermSynonym and LookupTableBinding");
                if(null != relationship && false == relationship.IsRemoved) entity.Bindings.Remove(relationship);
            }
            entity.SaveChanges();
            return entity.ToDto();
        }

        private TermSynonym GetTermSynonym(TermSynonym request)
        {
            var id = request?.Id;
            TermSynonym ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetVisibleFields<TermSynonym>(currentUser, "TermSynonym", request.VisibleFields);

            DocEntityTermSynonym entity = null;
            if(id.HasValue)
            {
                entity = DocEntityTermSynonym.GetTermSynonym(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No TermSynonym found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }

        public List<int> Any(TermSynonymIds request)
        {
            List<int> ret = null;
            if (currentUser.IsSuperAdmin)
            {
                Execute.Run(s => { ret = Execute.SelectAll<DocEntityTermSynonym>().Select(d => d.Id).ToList(); });
            }
            else
            {
                throw new HttpError(HttpStatusCode.Forbidden);
            }

            return ret;
        }
    }
}