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
    public partial class InterventionService : DocServiceBase
    {
        private IQueryable<DocEntityIntervention> _ExecSearch(InterventionSearch request)
        {
            request = InitSearch<Intervention, InterventionSearch>(request);
            IQueryable<DocEntityIntervention> entities = null;
            Execute.Run( session => 
            {
                entities = Execute.SelectAll<DocEntityIntervention>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new InterventionFullTextSearch(request);
                    entities = GetFullTextSearch<DocEntityIntervention,InterventionFullTextSearch>(fts, entities);
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

                entities = ApplyFilters<DocEntityIntervention,InterventionSearch>(request, entities);

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

        public List<Intervention> Post(InterventionSearch request) => Get(request);

        public List<Intervention> Get(InterventionSearch request) => GetSearchResult<Intervention,DocEntityIntervention,InterventionSearch>(DocConstantModelName.INTERVENTION, request, _ExecSearch);

        public Intervention Get(Intervention request) => GetEntity<Intervention>(DocConstantModelName.INTERVENTION, request, GetIntervention);
        private Intervention _AssignValues(Intervention request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "Intervention"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            Intervention ret = null;
            request = _InitAssignValues<Intervention>(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            var cacheKey = GetApiCacheKey<Intervention>(DocConstantModelName.INTERVENTION, nameof(Intervention), request);
            
            //First, assign all the variables, do database lookups and conversions
            var pDocumentSets = request.DocumentSets?.ToList();
            var pName = request.Name;
            var pURI = request.URI;

            DocEntityIntervention entity = null;
            if(permission == DocConstantPermission.ADD)
            {
                var now = DateTime.UtcNow;
                entity = new DocEntityIntervention(session)
                {
                    Created = now,
                    Updated = now
                };
            }
            else
            {
                entity = DocEntityIntervention.GetIntervention(request.Id);
                if(null == entity)
                    throw new HttpError(HttpStatusCode.NotFound, $"No record");
            }

            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pName, permission, DocConstantModelName.INTERVENTION, nameof(request.Name)))
            {
                if(DocPermissionFactory.IsRequested(request, pName, entity.Name, nameof(request.Name)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Name)} cannot be modified once set.");
                    entity.Name = pName;
                if(DocPermissionFactory.IsRequested<string>(request, pName, nameof(request.Name)) && !request.VisibleFields.Matches(nameof(request.Name), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Name));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pURI, permission, DocConstantModelName.INTERVENTION, nameof(request.URI)))
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
            
            if (DocPermissionFactory.IsRequestedHasPermission<List<Reference>>(currentUser, request, pDocumentSets, permission, DocConstantModelName.INTERVENTION, nameof(request.DocumentSets)))
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
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD, targetEntity: target, targetName: nameof(Intervention), columnName: nameof(request.DocumentSets)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to add {nameof(request.DocumentSets)} to {nameof(Intervention)}");
                        entity.DocumentSets.Add(target);
                    });
                    var toRemove = entity.DocumentSets.Where(e => requestedDocumentSets.All(id => e.Id != id)).Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityDocumentSet.GetDocumentSet(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(Intervention), columnName: nameof(request.DocumentSets)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.DocumentSets)} from {nameof(Intervention)}");
                        entity.DocumentSets.Remove(target);
                    });
                }
                else
                {
                    var toRemove = entity.DocumentSets.Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityDocumentSet.GetDocumentSet(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(Intervention), columnName: nameof(request.DocumentSets)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.DocumentSets)} from {nameof(Intervention)}");
                        entity.DocumentSets.Remove(target);
                    });
                }
                if(DocPermissionFactory.IsRequested<List<Reference>>(request, pDocumentSets, nameof(request.DocumentSets)) && !request.VisibleFields.Matches(nameof(request.DocumentSets), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.DocumentSets));
                }
            }
            DocPermissionFactory.SetVisibleFields<Intervention>(currentUser, nameof(Intervention), request.VisibleFields);
            ret = entity.ToDto();

            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.INTERVENTION);

            return ret;
        }
        public Intervention Post(Intervention request)
        {
            if(request == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            Intervention ret = null;

            Execute.Run(ssn =>
            {
                if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "Intervention")) 
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                ret = _AssignValues(request, DocConstantPermission.ADD, ssn);
            });

            return ret;
        }
   
        public List<Intervention> Post(InterventionBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<Intervention>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Post(dto) as Intervention;
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

        public Intervention Post(InterventionCopy request)
        {
            Intervention ret = null;
            Execute.Run(ssn =>
            {
                var entity = DocEntityIntervention.GetIntervention(request?.Id);
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
                #region Custom Before copyIntervention
                #endregion Custom Before copyIntervention
                var copy = new DocEntityIntervention(ssn)
                {
                    Hash = Guid.NewGuid()
                                , Name = pName
                                , URI = pURI
                };
                            foreach(var item in pDocumentSets)
                            {
                                entity.DocumentSets.Add(item);
                            }

                #region Custom After copyIntervention
                #endregion Custom After copyIntervention
                copy.SaveChanges(DocConstantPermission.ADD);
                ret = copy.ToDto();
            });
            return ret;
        }


        public List<Intervention> Put(InterventionBatch request)
        {
            return Patch(request);
        }

        public Intervention Put(Intervention request)
        {
            return Patch(request);
        }

        public List<Intervention> Patch(InterventionBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<Intervention>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Patch(dto) as Intervention;
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

        public Intervention Patch(Intervention request)
        {
            if(true != (request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the Intervention to patch.");
            
            request.VisibleFields = request.VisibleFields ?? new List<string>();
            
            Intervention ret = null;
            Execute.Run(ssn =>
            {
                ret = _AssignValues(request, DocConstantPermission.EDIT, ssn);
            });
            return ret;
        }

        public void Delete(InterventionBatch request)
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

        public void Delete(Intervention request)
        {
            Execute.Run(ssn =>
            {
                if(!(request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, $"No Id provided for delete.");

                DocCacheClient.RemoveSearch(DocConstantModelName.INTERVENTION);
                DocCacheClient.RemoveById(request.Id);
                var en = DocEntityIntervention.GetIntervention(request?.Id);

                if(null == en) throw new HttpError(HttpStatusCode.NotFound, $"No Intervention could be found for Id {request?.Id}.");
                if(en.IsRemoved) return;
                
                if(!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.DELETE))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have DELETE permission for this route.");
                
                en.Remove();
            });
        }

        public void Delete(InterventionSearch request)
        {
            var matches = Get(request) as List<Intervention>;
            if(true != matches?.Any()) throw new HttpError(HttpStatusCode.NotFound, "No matches for request");

            Execute.Run(ssn =>
            {
                matches.ForEach(match =>
                {
                    Delete(match);
                });
            });
        }
        public object Get(InterventionJunction request)
        {
            if(!(request.Id > 0))
                throw new HttpError(HttpStatusCode.NotFound, "Valid Id required.");
            object ret = null;
            Execute.Run( s => 
            {
                switch(request.Junction)
                {
                case "documentset":
                    ret =     GetJunctionSearchResult<Intervention, DocEntityIntervention, DocEntityDocumentSet, DocumentSet, DocumentSetSearch>((int)request.Id, DocConstantModelName.DOCUMENTSET, "DocumentSets", request,
                            (ss) =>
                            { 
                                var service = HostContext.ResolveService<DocumentSetService>(Request);
                                return service.Get(ss);
                            });
                    break;
                    default:
                        throw new HttpError(HttpStatusCode.NotFound, $"Route for intervention/{request.Id}/{request.Junction} was not found");
                }
            });
            return ret;
        }


        public object Post(InterventionJunction request)
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
                switch(request.Junction)
                {
                case "documentset":
                    ret = _PostInterventionDocumentSet(request);
                    break;
                    default:
                        throw new HttpError(HttpStatusCode.NotFound, $"Route for intervention/{request.Id}/{request.Junction} was not found");
                }
            });
            return ret;
        }


        private object _PostInterventionDocumentSet(InterventionJunction request)
        {
            var entity = DocEntityIntervention.GetIntervention(request.Id);

            if (null == entity) throw new HttpError(HttpStatusCode.NotFound, $"No Intervention found for Id {request.Id}");

            if (!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.EDIT))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have Edit permission to Intervention");

            foreach (var id in request.Ids)
            {
                var relationship = DocEntityDocumentSet.GetDocumentSet(id);
                if (!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD, targetEntity: relationship, targetName: DocConstantModelName.DOCUMENTSET, columnName: "DocumentSets")) 
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have Add permission to the DocumentSets property.");
                if (null == relationship) throw new HttpError(HttpStatusCode.NotFound, $"Cannot post to collection of Intervention with objects that do not exist. No matching DocumentSet could be found for {id}.");
                entity.DocumentSets.Add(relationship);
            }
            entity.SaveChanges();
            return entity.ToDto();
        }

        public object Delete(InterventionJunction request)
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
                switch(request.Junction)
                {
                case "documentset":
                    ret = _DeleteInterventionDocumentSet(request);
                    break;
                    default:
                        throw new HttpError(HttpStatusCode.NotFound, $"Route for intervention/{request.Id}/{request.Junction} was not found");
                }
            });
            return ret;
        }


        private object _DeleteInterventionDocumentSet(InterventionJunction request)
        {
            var entity = DocEntityIntervention.GetIntervention(request.Id);

            if (null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No Intervention found for Id {request.Id}");
            if (!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.EDIT))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have Edit permission to Intervention");
            foreach (var id in request.Ids)
            {
                var relationship = DocEntityDocumentSet.GetDocumentSet(id);
                if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: relationship, targetName: DocConstantModelName.DOCUMENTSET, columnName: "DocumentSets"))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have Edit permission to relationships between Intervention and DocumentSet");
                if(null != relationship && false == relationship.IsRemoved) entity.DocumentSets.Remove(relationship);
            }
            entity.SaveChanges();
            return entity.ToDto();
        }

        private Intervention GetIntervention(Intervention request)
        {
            var id = request?.Id;
            Intervention ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetVisibleFields<Intervention>(currentUser, "Intervention", request.VisibleFields);

            DocEntityIntervention entity = null;
            if(id.HasValue)
            {
                entity = DocEntityIntervention.GetIntervention(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No Intervention found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }
    }
}