//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated by a T4 template. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using AutoMapper;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Dynamic;
using System.Linq.Expressions;
using System.Net;
using System.Reflection;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using Services.Core;
using Services.Db;
using Services.Dto;
using Services.Dto.internals;
using Services.Dto.Security;
using Services.Enums;
using Services.Models;
using Services.Schema;

using ServiceStack;
using ServiceStack.Text;

using Typed;
using Typed.Bindings;
using Typed.Notifications;
using Typed.Settings;

using Xtensive.Orm;
using Xtensive.Orm.Model;

using Attribute = Services.Dto.Attribute;
using ValueType = Services.Dto.ValueType;
using Version = Services.Dto.Version;

namespace Services.API
{
    public partial class OutcomeService : DocServiceBase
    {
        private IQueryable<DocEntityOutcome> _ExecSearch(OutcomeSearch request)
        {
            request = InitSearch<Outcome, OutcomeSearch>(request);
            IQueryable<DocEntityOutcome> entities = null;
            Execute.Run( session => 
            {
                entities = Execute.SelectAll<DocEntityOutcome>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new OutcomeFullTextSearch(request);
                    entities = GetFullTextSearch<DocEntityOutcome,OutcomeFullTextSearch>(fts, entities);
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
                if(true == request.Archived?.Any() && currentUser.HasProperty(DocConstantModelName.OUTCOME, nameof(Reference.Archived), DocConstantPermission.VIEW))
                {
                    entities = entities.Where(en => en.Archived.In(request.Archived));
                }
                else
                {
                    entities = entities.Where(en => !en.Archived);
                }
                if(true == request.Locked?.Any())
                {
                    entities = entities.Where(en => en.Locked.In(request.Locked));
                }

                if(true == request.DocumentSetsIds?.Any())
                {
                    entities = entities.Where(en => en.DocumentSets.Any(r => r.Id.In(request.DocumentSetsIds)));
                }
                if(!DocTools.IsNullOrEmpty(request.Name))
                    entities = entities.Where(en => en.Name.Contains(request.Name));
                if(!DocTools.IsNullOrEmpty(request.URI))
                    entities = entities.Where(en => en.URI.Contains(request.URI));

                entities = ApplyFilters<DocEntityOutcome,OutcomeSearch>(request, entities);

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

        public List<Outcome> Post(OutcomeSearch request) => Get(request);

        public List<Outcome> Get(OutcomeSearch request) => GetSearchResult<Outcome,DocEntityOutcome,OutcomeSearch>(DocConstantModelName.OUTCOME, request, _ExecSearch);

        public Outcome Get(Outcome request) => GetEntity<Outcome>(DocConstantModelName.OUTCOME, request, GetOutcome);
        private Outcome _AssignValues(Outcome request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "Outcome"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            Outcome ret = null;
            request = _InitAssignValues<Outcome>(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            var cacheKey = GetApiCacheKey<Outcome>(DocConstantModelName.OUTCOME, nameof(Outcome), request);
            
            //First, assign all the variables, do database lookups and conversions
            var pDocumentSets = request.DocumentSets?.ToList();
            var pName = request.Name;
            var pURI = request.URI;

            DocEntityOutcome entity = null;
            if(permission == DocConstantPermission.ADD)
            {
                var now = DateTime.UtcNow;
                entity = new DocEntityOutcome(session)
                {
                    Created = now,
                    Updated = now
                };
            }
            else
            {
                entity = DocEntityOutcome.GetOutcome(request.Id);
                if(null == entity)
                    throw new HttpError(HttpStatusCode.NotFound, $"No record");
            }

            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pName, permission, DocConstantModelName.OUTCOME, nameof(request.Name)))
            {
                if(DocPermissionFactory.IsRequested(request, pName, entity.Name, nameof(request.Name)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Name)} cannot be modified once set.");
                    entity.Name = pName;
                if(DocPermissionFactory.IsRequested<string>(request, pName, nameof(request.Name)) && !request.VisibleFields.Matches(nameof(request.Name), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Name));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pURI, permission, DocConstantModelName.OUTCOME, nameof(request.URI)))
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

            if (DocPermissionFactory.IsRequestedHasPermission<List<Reference>>(currentUser, request, pDocumentSets, permission, DocConstantModelName.OUTCOME, nameof(request.DocumentSets)))
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
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD, targetEntity: target, targetName: nameof(Outcome), columnName: nameof(request.DocumentSets)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to add {nameof(request.DocumentSets)} to {nameof(Outcome)}");
                        entity.DocumentSets.Add(target);
                    });
                    var toRemove = entity.DocumentSets.Where(e => requestedDocumentSets.All(id => e.Id != id)).Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityDocumentSet.GetDocumentSet(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(Outcome), columnName: nameof(request.DocumentSets)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.DocumentSets)} from {nameof(Outcome)}");
                        entity.DocumentSets.Remove(target);
                    });
                }
                else
                {
                    var toRemove = entity.DocumentSets.Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityDocumentSet.GetDocumentSet(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(Outcome), columnName: nameof(request.DocumentSets)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.DocumentSets)} from {nameof(Outcome)}");
                        entity.DocumentSets.Remove(target);
                    });
                }
                if(DocPermissionFactory.IsRequested<List<Reference>>(request, pDocumentSets, nameof(request.DocumentSets)) && !request.VisibleFields.Matches(nameof(request.DocumentSets), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.DocumentSets));
                }
            }
            DocPermissionFactory.SetVisibleFields<Outcome>(currentUser, nameof(Outcome), request.VisibleFields);
            ret = entity.ToDto();

            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.OUTCOME);

            return ret;
        }
        public Outcome Post(Outcome request)
        {
            if(request == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            Outcome ret = null;

            Execute.Run(ssn =>
            {
                if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "Outcome")) 
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                ret = _AssignValues(request, DocConstantPermission.ADD, ssn);
            });

            return ret;
        }
   
        public List<Outcome> Post(OutcomeBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<Outcome>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Post(dto) as Outcome;
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

        public Outcome Post(OutcomeCopy request)
        {
            Outcome ret = null;
            Execute.Run(ssn =>
            {
                var entity = DocEntityOutcome.GetOutcome(request?.Id);
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
                #region Custom Before copyOutcome
                #endregion Custom Before copyOutcome
                var copy = new DocEntityOutcome(ssn)
                {
                    Hash = Guid.NewGuid()
                                , Name = pName
                                , URI = pURI
                };
                            foreach(var item in pDocumentSets)
                            {
                                entity.DocumentSets.Add(item);
                            }

                #region Custom After copyOutcome
                #endregion Custom After copyOutcome
                copy.SaveChanges(DocConstantPermission.ADD);
                ret = copy.ToDto();
            });
            return ret;
        }

        public List<Outcome> Put(OutcomeBatch request)
        {
            return Patch(request);
        }

        public Outcome Put(Outcome request)
        {
            return Patch(request);
        }
        public List<Outcome> Patch(OutcomeBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<Outcome>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Patch(dto) as Outcome;
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

        public Outcome Patch(Outcome request)
        {
            if(true != (request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the Outcome to patch.");
            
            request.VisibleFields = request.VisibleFields ?? new List<string>();
            
            Outcome ret = null;
            Execute.Run(ssn =>
            {
                ret = _AssignValues(request, DocConstantPermission.EDIT, ssn);
            });
            return ret;
        }
        public void Delete(OutcomeBatch request)
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

        public void Delete(Outcome request)
        {
            Execute.Run(ssn =>
            {
                if(!(request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, $"No Id provided for delete.");

                DocCacheClient.RemoveSearch(DocConstantModelName.OUTCOME);
                DocCacheClient.RemoveById(request.Id);
                var en = DocEntityOutcome.GetOutcome(request?.Id);

                if(null == en) throw new HttpError(HttpStatusCode.NotFound, $"No Outcome could be found for Id {request?.Id}.");
                if(en.IsRemoved) return;
                
                if(!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.DELETE))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have DELETE permission for this route.");
                
                en.Remove();
            });
        }

        public void Delete(OutcomeSearch request)
        {
            var matches = Get(request) as List<Outcome>;
            if(true != matches?.Any()) throw new HttpError(HttpStatusCode.NotFound, "No matches for request");

            Execute.Run(ssn =>
            {
                matches.ForEach(match =>
                {
                    Delete(match);
                });
            });
        }
        public object Get(OutcomeJunction request) =>
            Execute.Run( s => 
            {
                switch(request.Junction.ToLower().TrimAndPruneSpaces())
                {
                    case "documentset":
                        return GetJunctionSearchResult<Outcome, DocEntityOutcome, DocEntityDocumentSet, DocumentSet, DocumentSetSearch>((int)request.Id, DocConstantModelName.DOCUMENTSET, "DocumentSets", request, (ss) => HostContext.ResolveService<DocumentSetService>(Request)?.Get(ss));
                    default:
                        throw new HttpError(HttpStatusCode.NotFound, $"Route for outcome/{request.Id}/{request.Junction} was not found");
                }
            });
        public object Post(OutcomeJunction request) =>
            Execute.Run( ssn =>
            {
                switch(request.Junction.ToLower().TrimAndPruneSpaces())
                {
                    case "documentset":
                        return AddJunction<Outcome, DocEntityOutcome, DocEntityDocumentSet, DocumentSet, DocumentSetSearch>((int)request.Id, DocConstantModelName.DOCUMENTSET, "DocumentSets", request);
                    default:
                        throw new HttpError(HttpStatusCode.NotFound, $"Route for outcome/{request.Id}/{request.Junction} was not found");
                }
            });

        public object Delete(OutcomeJunction request) =>
            Execute.Run( ssn =>
            {
                switch(request.Junction.ToLower().TrimAndPruneSpaces())
                {
                    case "documentset":
                        return RemoveJunction<Outcome, DocEntityOutcome, DocEntityDocumentSet, DocumentSet, DocumentSetSearch>((int)request.Id, DocConstantModelName.DOCUMENTSET, "DocumentSets", request);
                    default:
                        throw new HttpError(HttpStatusCode.NotFound, $"Route for outcome/{request.Id}/{request.Junction} was not found");
                }
            });
        private Outcome GetOutcome(Outcome request)
        {
            var id = request?.Id;
            Outcome ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetVisibleFields<Outcome>(currentUser, "Outcome", request.VisibleFields);

            DocEntityOutcome entity = null;
            if(id.HasValue)
            {
                entity = DocEntityOutcome.GetOutcome(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No Outcome found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }
    }
}
