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
    public partial class VariableInstanceService : DocServiceBase
    {
        private IQueryable<DocEntityVariableInstance> _ExecSearch(VariableInstanceSearch request, DocQuery query)
        {
            request = InitSearch<VariableInstance, VariableInstanceSearch>(request);
            IQueryable<DocEntityVariableInstance> entities = null;
            query.Run( session => 
            {
                entities = query.SelectAll<DocEntityVariableInstance>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new VariableInstanceFullTextSearch(request);
                    entities = GetFullTextSearch<DocEntityVariableInstance,VariableInstanceFullTextSearch>(fts, entities);
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
                if(true == request.Archived?.Any() && currentUser.HasProperty(DocConstantModelName.VARIABLEINSTANCE, nameof(Reference.Archived), DocConstantPermission.VIEW))
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

                if(!DocTools.IsNullOrEmpty(request.Document) && !DocTools.IsNullOrEmpty(request.Document.Id))
                {
                    entities = entities.Where(en => en.Document.Id == request.Document.Id );
                }
                if(true == request.DocumentIds?.Any())
                {
                    entities = entities.Where(en => en.Document.Id.In(request.DocumentIds));
                }
                if(!DocTools.IsNullOrEmpty(request.Rule) && !DocTools.IsNullOrEmpty(request.Rule.Id))
                {
                    entities = entities.Where(en => en.Rule.Id == request.Rule.Id );
                }
                if(true == request.RuleIds?.Any())
                {
                    entities = entities.Where(en => en.Rule.Id.In(request.RuleIds));
                }
                if(true == request.WorkflowsIds?.Any())
                {
                    entities = entities.Where(en => en.Workflows.Any(r => r.Id.In(request.WorkflowsIds)));
                }

                entities = ApplyFilters<DocEntityVariableInstance,VariableInstanceSearch>(request, entities);

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

        public object Post(VariableInstanceSearch request) => Get(request);

        public object Get(VariableInstanceSearch request) => GetSearchResultWithCache<VariableInstance,DocEntityVariableInstance,VariableInstanceSearch>(DocConstantModelName.VARIABLEINSTANCE, request, _ExecSearch);

        public object Get(VariableInstance request) => GetEntityWithCache<VariableInstance>(DocConstantModelName.VARIABLEINSTANCE, request, GetVariableInstance);

        private VariableInstance _AssignValues(VariableInstance request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "VariableInstance"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            VariableInstance ret = null;
            request = _InitAssignValues<VariableInstance>(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            var cacheKey = GetApiCacheKey<VariableInstance>(DocConstantModelName.VARIABLEINSTANCE, nameof(VariableInstance), request);
            
            //First, assign all the variables, do database lookups and conversions
            var pData = request.Data;
            var pDocument = (request.Document?.Id > 0) ? DocEntityDocument.GetDocument(request.Document.Id) : null;
            var pRule = (request.Rule?.Id > 0) ? DocEntityVariableRule.GetVariableRule(request.Rule.Id) : null;
            var pWorkflows = request.Workflows?.ToList();

            DocEntityVariableInstance entity = null;
            if(permission == DocConstantPermission.ADD)
            {
                var now = DateTime.UtcNow;
                entity = new DocEntityVariableInstance(session)
                {
                    Created = now,
                    Updated = now
                };
            }
            else
            {
                entity = DocEntityVariableInstance.GetVariableInstance(request.Id);
                if(null == entity)
                    throw new HttpError(HttpStatusCode.NotFound, $"No record");
            }

            //Special case for Archived
            var pArchived = true == request.Archived;
            if (DocPermissionFactory.IsRequestedHasPermission<bool>(currentUser, request, pArchived, permission, DocConstantModelName.VARIABLEINSTANCE, nameof(request.Archived)))
            {
                if(DocPermissionFactory.IsRequested(request, pArchived, entity.Archived, nameof(request.Archived)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.VARIABLEINSTANCE, nameof(request.Archived)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Archived)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pArchived) && DocResources.Metadata.IsRequired(DocConstantModelName.VARIABLEINSTANCE, nameof(request.Archived))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Archived)} requires a value.");
                    entity.Archived = pArchived;
                if(DocPermissionFactory.IsRequested<bool>(request, pArchived, nameof(request.Archived)) && !request.VisibleFields.Matches(nameof(request.Archived), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Archived));
                }
            }

            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pData, permission, DocConstantModelName.VARIABLEINSTANCE, nameof(request.Data)))
            {
                if(DocPermissionFactory.IsRequested(request, pData, entity.Data, nameof(request.Data)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.VARIABLEINSTANCE, nameof(request.Data)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Data)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pData) && DocResources.Metadata.IsRequired(DocConstantModelName.VARIABLEINSTANCE, nameof(request.Data))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Data)} requires a value.");
                    entity.Data = pData;
                if(DocPermissionFactory.IsRequested<string>(request, pData, nameof(request.Data)) && !request.VisibleFields.Matches(nameof(request.Data), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Data));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityDocument>(currentUser, request, pDocument, permission, DocConstantModelName.VARIABLEINSTANCE, nameof(request.Document)))
            {
                if(DocPermissionFactory.IsRequested(request, pDocument, entity.Document, nameof(request.Document)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.VARIABLEINSTANCE, nameof(request.Document)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Document)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pDocument) && DocResources.Metadata.IsRequired(DocConstantModelName.VARIABLEINSTANCE, nameof(request.Document))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Document)} requires a value.");
                    entity.Document = pDocument;
                if(DocPermissionFactory.IsRequested<DocEntityDocument>(request, pDocument, nameof(request.Document)) && !request.VisibleFields.Matches(nameof(request.Document), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Document));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityVariableRule>(currentUser, request, pRule, permission, DocConstantModelName.VARIABLEINSTANCE, nameof(request.Rule)))
            {
                if(DocPermissionFactory.IsRequested(request, pRule, entity.Rule, nameof(request.Rule)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.VARIABLEINSTANCE, nameof(request.Rule)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Rule)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pRule) && DocResources.Metadata.IsRequired(DocConstantModelName.VARIABLEINSTANCE, nameof(request.Rule))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Rule)} requires a value.");
                    entity.Rule = pRule;
                if(DocPermissionFactory.IsRequested<DocEntityVariableRule>(request, pRule, nameof(request.Rule)) && !request.VisibleFields.Matches(nameof(request.Rule), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Rule));
                }
            }

            if (request.Locked) entity.Locked = request.Locked;

            entity.SaveChanges(permission);

            if (DocPermissionFactory.IsRequestedHasPermission<List<Reference>>(currentUser, request, pWorkflows, permission, DocConstantModelName.VARIABLEINSTANCE, nameof(request.Workflows)))
            {
                if (true == pWorkflows?.Any() )
                {
                    var requestedWorkflows = pWorkflows.Select(p => p.Id).Distinct().ToList();
                    var existsWorkflows = Execute.SelectAll<DocEntityWorkflow>().Where(e => e.Id.In(requestedWorkflows)).Select( e => e.Id ).ToList();
                    if (existsWorkflows.Count != requestedWorkflows.Count)
                    {
                        var nonExists = requestedWorkflows.Where(id => existsWorkflows.All(eId => eId != id));
                        throw new HttpError(HttpStatusCode.NotFound, $"Cannot patch collection Workflows with objects that do not exist. No matching Workflows(s) could be found for Ids: {nonExists.ToDelimitedString()}.");
                    }
                    var toAdd = requestedWorkflows.Where(id => entity.Workflows.All(e => e.Id != id)).ToList(); 
                    toAdd?.ForEach(id =>
                    {
                        var target = DocEntityWorkflow.GetWorkflow(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD, targetEntity: target, targetName: nameof(VariableInstance), columnName: nameof(request.Workflows)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to add {nameof(request.Workflows)} to {nameof(VariableInstance)}");
                        entity.Workflows.Add(target);
                    });
                    var toRemove = entity.Workflows.Where(e => requestedWorkflows.All(id => e.Id != id)).Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityWorkflow.GetWorkflow(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(VariableInstance), columnName: nameof(request.Workflows)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Workflows)} from {nameof(VariableInstance)}");
                        entity.Workflows.Remove(target);
                    });
                }
                else
                {
                    var toRemove = entity.Workflows.Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityWorkflow.GetWorkflow(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(VariableInstance), columnName: nameof(request.Workflows)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Workflows)} from {nameof(VariableInstance)}");
                        entity.Workflows.Remove(target);
                    });
                }
                if(DocPermissionFactory.IsRequested<List<Reference>>(request, pWorkflows, nameof(request.Workflows)) && !request.VisibleFields.Matches(nameof(request.Workflows), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Workflows));
                }
            }
            DocPermissionFactory.SetVisibleFields<VariableInstance>(currentUser, nameof(VariableInstance), request.VisibleFields);
            ret = entity.ToDto();

            var cacheExpires = DocResources.Metadata.GetCacheExpiration(DocConstantModelName.VARIABLEINSTANCE);
            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.VARIABLEINSTANCE, cacheExpires);

            return ret;
        }
        public VariableInstance Post(VariableInstance request)
        {
            if(request == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            VariableInstance ret = null;

            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "VariableInstance")) 
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                    ret = _AssignValues(request, DocConstantPermission.ADD, ssn);
                });
            }
            return ret;
        }
   
        public List<VariableInstance> Post(VariableInstanceBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<VariableInstance>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Post(dto) as VariableInstance;
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

        public VariableInstance Post(VariableInstanceCopy request)
        {
            VariableInstance ret = null;
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    var entity = DocEntityVariableInstance.GetVariableInstance(request?.Id);
                    if(null == entity) throw new HttpError(HttpStatusCode.NoContent, "The COPY request did not succeed.");
                    if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD))
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                    var pData = entity.Data;
                    var pDocument = entity.Document;
                    var pRule = entity.Rule;
                    var pWorkflows = entity.Workflows.ToList();
                    #region Custom Before copyVariableInstance
                    #endregion Custom Before copyVariableInstance
                    var copy = new DocEntityVariableInstance(ssn)
                    {
                        Hash = Guid.NewGuid()
                                , Data = pData
                                , Document = pDocument
                                , Rule = pRule
                    };
                            foreach(var item in pWorkflows)
                            {
                                entity.Workflows.Add(item);
                            }

                    #region Custom After copyVariableInstance
                    #endregion Custom After copyVariableInstance
                    copy.SaveChanges(DocConstantPermission.ADD);
                    ret = copy.ToDto();
                });
            }
            return ret;
        }

        public List<VariableInstance> Put(VariableInstanceBatch request)
        {
            return Patch(request);
        }

        public VariableInstance Put(VariableInstance request)
        {
            return Patch(request);
        }
        public List<VariableInstance> Patch(VariableInstanceBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<VariableInstance>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Patch(dto) as VariableInstance;
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

        public VariableInstance Patch(VariableInstance request)
        {
            if(true != (request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the VariableInstance to patch.");
            
            request.VisibleFields = request.VisibleFields ?? new List<string>();
            
            VariableInstance ret = null;
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    ret = _AssignValues(request, DocConstantPermission.EDIT, ssn);
                });
            }
            return ret;
        }
        public void Delete(VariableInstanceBatch request)
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

        public void Delete(VariableInstance request)
        {
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    if(!(request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, $"No Id provided for delete.");

                    var en = DocEntityVariableInstance.GetVariableInstance(request?.Id);
                    if(null == en) throw new HttpError(HttpStatusCode.NotFound, $"No VariableInstance could be found for Id {request?.Id}.");
                    if(en.IsRemoved) return;
                
                    if(!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.DELETE))
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have DELETE permission for this route.");
                
                    en.Remove();

                    DocCacheClient.RemoveSearch(DocConstantModelName.VARIABLEINSTANCE);
                    DocCacheClient.RemoveById(request.Id);
                });
            }
        }

        public void Delete(VariableInstanceSearch request)
        {
            var matches = Get(request) as List<VariableInstance>;
            if(true != matches?.Any()) throw new HttpError(HttpStatusCode.NotFound, "No matches for request");
            matches.ForEach(match =>
            {
                Delete(match);
            });
        }
        public object Get(VariableInstanceJunction request)
        {
            switch(request.Junction.ToLower().TrimAndPruneSpaces())
            {
                    case "tag":
                        return GetJunctionSearchResult<VariableInstance, DocEntityVariableInstance, DocEntityTag, Tag, TagSearch>((int)request.Id, DocConstantModelName.TAG, "Tags", request, (ss) => HostContext.ResolveService<TagService>(Request)?.Get(ss));
                    case "workflow":
                        return GetJunctionSearchResult<VariableInstance, DocEntityVariableInstance, DocEntityWorkflow, Workflow, WorkflowSearch>((int)request.Id, DocConstantModelName.WORKFLOW, "Workflows", request, (ss) => HostContext.ResolveService<WorkflowService>(Request)?.Get(ss));
                default:
                    throw new HttpError(HttpStatusCode.NotFound, $"Route for variableinstance/{request.Id}/{request.Junction} was not found");
            }
        }
        public object Post(VariableInstanceJunction request)
        {
            switch(request.Junction.ToLower().TrimAndPruneSpaces())
            {
                    case "tag":
                        return AddJunction<VariableInstance, DocEntityVariableInstance, DocEntityTag, Tag, TagSearch>((int)request.Id, DocConstantModelName.TAG, "Tags", request);
                    case "workflow":
                        return AddJunction<VariableInstance, DocEntityVariableInstance, DocEntityWorkflow, Workflow, WorkflowSearch>((int)request.Id, DocConstantModelName.WORKFLOW, "Workflows", request);
                default:
                    throw new HttpError(HttpStatusCode.NotFound, $"Route for variableinstance/{request.Id}/{request.Junction} was not found");
            }
        }

        public object Delete(VariableInstanceJunction request)
        {    
            switch(request.Junction.ToLower().TrimAndPruneSpaces())
            {
                    case "tag":
                        return RemoveJunction<VariableInstance, DocEntityVariableInstance, DocEntityTag, Tag, TagSearch>((int)request.Id, DocConstantModelName.TAG, "Tags", request);
                    case "workflow":
                        return RemoveJunction<VariableInstance, DocEntityVariableInstance, DocEntityWorkflow, Workflow, WorkflowSearch>((int)request.Id, DocConstantModelName.WORKFLOW, "Workflows", request);
                default:
                    throw new HttpError(HttpStatusCode.NotFound, $"Route for variableinstance/{request.Id}/{request.Junction} was not found");
            }
        }
        private VariableInstance GetVariableInstance(VariableInstance request)
        {
            var id = request?.Id;
            VariableInstance ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetVisibleFields<VariableInstance>(currentUser, "VariableInstance", request.VisibleFields);

            DocEntityVariableInstance entity = null;
            if(id.HasValue)
            {
                entity = DocEntityVariableInstance.GetVariableInstance(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No VariableInstance found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }
    }
}
