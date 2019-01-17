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
    public partial class VariableInstanceService : DocServiceBase
    {
        private void _ExecSearch(VariableInstanceSearch request, Action<IQueryable<DocEntityVariableInstance>> callBack)
        {
            request = InitSearch(request);
            
            DocPermissionFactory.SetVisibleFields<VariableInstance>(currentUser, "VariableInstance", request.VisibleFields);

            Execute.Run( session => 
            {
                var entities = Execute.SelectAll<DocEntityVariableInstance>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new VariableInstanceFullTextSearch(request);
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
        
        public object Post(VariableInstanceSearch request)
        {
            return Get(request);
        }

        public object Get(VariableInstanceSearch request)
        {
            object tryRet = null;
            var ret = new List<VariableInstance>();
            var cacheKey = GetApiCacheKey<VariableInstance>(DocConstantModelName.VARIABLEINSTANCE, nameof(VariableInstance), request);
            using (var cancellableRequest = base.Request.CreateCancellableRequest())
            {
                var requestCancel = new DocRequestCancellation(HttpContext.Current.Response, cancellableRequest);
                try 
                {
                    if (tryRet == null)
                    {
                        _ExecSearch(request, (entities) => entities.ConvertFromEntityList<DocEntityVariableInstance,VariableInstance>(ret, Execute, requestCancel));
                        tryRet = ret;
                        //Go ahead and cache the result for any future consumers
                        DocCacheClient.Set(key: cacheKey, value: ret, entityType: DocConstantModelName.VARIABLEINSTANCE, search: true);
                    }
                }
                catch(Exception) { throw; }
                finally
                {
                    requestCancel?.CloseRequest();
                }
            }
            DocCacheClient.SyncKeys(key: cacheKey, entityType: DocConstantModelName.VARIABLEINSTANCE, search: true);
            return tryRet;
        }

        public object Post(VariableInstanceVersion request) 
        {
            return Get(request);
        }

        public object Get(VariableInstanceVersion request) 
        {
            var ret = new List<Version>();
            _ExecSearch(request, (entities) => 
            {
                ret = entities.Select(e => new Version(e.Id, e.VersionNo)).ToList();
            });
            return ret;
        }

        public object Get(VariableInstance request)
        {
            object ret = null;
            
            if(!(request.Id > 0))
                throw new HttpError(HttpStatusCode.NotFound, "Valid Id required.");

            DocPermissionFactory.SetVisibleFields<VariableInstance>(currentUser, "VariableInstance", request.VisibleFields);
            var cacheKey = GetApiCacheKey<VariableInstance>(DocConstantModelName.VARIABLEINSTANCE, nameof(VariableInstance), request);
            if(null == ret)
            {
                Execute.Run(s =>
                {
                    ret = GetVariableInstance(request);
                    DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.VARIABLEINSTANCE);
                });
            }
            DocCacheClient.SyncKeys(key: cacheKey, entityId: request.Id, entityType: DocConstantModelName.VARIABLEINSTANCE);
            return ret;
        }

        private VariableInstance _AssignValues(VariableInstance request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "VariableInstance"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            VariableInstance ret = null;
            request = _InitAssignValues(request, permission, session);
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

            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pData, permission, DocConstantModelName.VARIABLEINSTANCE, nameof(request.Data)))
            {
                if(DocPermissionFactory.IsRequested(request, pData, entity.Data, nameof(request.Data)))
                    entity.Data = pData;
                if(DocPermissionFactory.IsRequested<string>(request, pData, nameof(request.Data)) && !request.VisibleFields.Matches(nameof(request.Data), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Data));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityDocument>(currentUser, request, pDocument, permission, DocConstantModelName.VARIABLEINSTANCE, nameof(request.Document)))
            {
                if(DocPermissionFactory.IsRequested(request, pDocument, entity.Document, nameof(request.Document)))
                    entity.Document = pDocument;
                if(DocPermissionFactory.IsRequested<DocEntityDocument>(request, pDocument, nameof(request.Document)) && !request.VisibleFields.Matches(nameof(request.Document), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Document));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityVariableRule>(currentUser, request, pRule, permission, DocConstantModelName.VARIABLEINSTANCE, nameof(request.Rule)))
            {
                if(DocPermissionFactory.IsRequested(request, pRule, entity.Rule, nameof(request.Rule)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Rule)} cannot be modified once set.");
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

            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.VARIABLEINSTANCE);

            return ret;
        }
        public VariableInstance Post(VariableInstance request)
        {
            if(request == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            VariableInstance ret = null;

            Execute.Run(ssn =>
            {
                if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "VariableInstance")) 
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                ret = _AssignValues(request, DocConstantPermission.ADD, ssn);
            });

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
            Execute.Run(ssn =>
            {
                ret = _AssignValues(request, DocConstantPermission.EDIT, ssn);
            });
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
            Execute.Run(ssn =>
            {
                if(!(request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, $"No Id provided for delete.");

                DocCacheClient.RemoveSearch(DocConstantModelName.VARIABLEINSTANCE);
                DocCacheClient.RemoveById(request.Id);
                var en = DocEntityVariableInstance.GetVariableInstance(request?.Id);

                if(null == en) throw new HttpError(HttpStatusCode.NotFound, $"No VariableInstance could be found for Id {request?.Id}.");
                if(en.IsRemoved) return;
                
                if(!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.DELETE))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have DELETE permission for this route.");
                
                en.Remove();
            });
        }

        public void Delete(VariableInstanceSearch request)
        {
            var matches = Get(request) as List<VariableInstance>;
            if(true != matches?.Any()) throw new HttpError(HttpStatusCode.NotFound, "No matches for request");

            Execute.Run(ssn =>
            {
                matches.ForEach(match =>
                {
                    Delete(match);
                });
            });
        }
        public object Get(VariableInstanceJunction request)
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
                case "workflow":
                    ret = _GetVariableInstanceWorkflow(request, skip, take);
                    break;
                }
            });
            return ret;
        }
        
        public object Get(VariableInstanceJunctionVersion request)
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
                case "workflow":
                    ret = GetVariableInstanceWorkflowVersion(request);
                    break;
                }
            });
            return ret;
        }
        

        private object _GetVariableInstanceWorkflow(VariableInstanceJunction request, int skip, int take)
        {
             request.VisibleFields = InitVisibleFields<Workflow>(Dto.Workflow.Fields, request.VisibleFields);
             var en = DocEntityVariableInstance.GetVariableInstance(request.Id);
             if (!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.VIEW, targetName: DocConstantModelName.VARIABLEINSTANCE, columnName: "Workflows", targetEntity: null))
                 throw new HttpError(HttpStatusCode.Forbidden, "You do not have View permission to relationships between VariableInstance and Workflow");
             return en?.Workflows.Take(take).Skip(skip).ConvertFromEntityList<DocEntityWorkflow,Workflow>(new List<Workflow>());
        }

        private List<Version> GetVariableInstanceWorkflowVersion(VariableInstanceJunctionVersion request)
        { 
            if(!(request.Id > 0))
                throw new HttpError(HttpStatusCode.NotFound, "Valid Id required.");
            var ret = new List<Version>();
             Execute.Run((ssn) =>
             {
                var en = DocEntityVariableInstance.GetVariableInstance(request.Id);
                ret = en?.Workflows.Select(e => new Version(e.Id, e.VersionNo)).ToList();
             });
            return ret;
        }
        
        public object Post(VariableInstanceJunction request)
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
                case "workflow":
                    ret = _PostVariableInstanceWorkflow(request);
                    break;
                }
            });
            return ret;
        }


        private object _PostVariableInstanceWorkflow(VariableInstanceJunction request)
        {
            var entity = DocEntityVariableInstance.GetVariableInstance(request.Id);

            if (null == entity) throw new HttpError(HttpStatusCode.NotFound, $"No VariableInstance found for Id {request.Id}");

            if (!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.EDIT))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have Edit permission to VariableInstance");

            foreach (var id in request.Ids)
            {
                var relationship = DocEntityWorkflow.GetWorkflow(id);
                if (!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD, targetEntity: relationship, targetName: DocConstantModelName.WORKFLOW, columnName: "Workflows")) 
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have Add permission to the Workflows property.");
                if (null == relationship) throw new HttpError(HttpStatusCode.NotFound, $"Cannot post to collection of VariableInstance with objects that do not exist. No matching Workflow could be found for {id}.");
                entity.Workflows.Add(relationship);
            }
            entity.SaveChanges();
            return entity.ToDto();
        }

        public object Delete(VariableInstanceJunction request)
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
                case "workflow":
                    ret = _DeleteVariableInstanceWorkflow(request);
                    break;
                }
            });
            return ret;
        }


        private object _DeleteVariableInstanceWorkflow(VariableInstanceJunction request)
        {
            var entity = DocEntityVariableInstance.GetVariableInstance(request.Id);

            if (null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No VariableInstance found for Id {request.Id}");
            if (!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.EDIT))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have Edit permission to VariableInstance");
            foreach (var id in request.Ids)
            {
                var relationship = DocEntityWorkflow.GetWorkflow(id);
                if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: relationship, targetName: DocConstantModelName.WORKFLOW, columnName: "Workflows"))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have Edit permission to relationships between VariableInstance and Workflow");
                if(null != relationship && false == relationship.IsRemoved) entity.Workflows.Remove(relationship);
            }
            entity.SaveChanges();
            return entity.ToDto();
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

        public List<int> Any(VariableInstanceIds request)
        {
            List<int> ret = null;
            if (currentUser.IsSuperAdmin)
            {
                Execute.Run(s => { ret = Execute.SelectAll<DocEntityVariableInstance>().Select(d => d.Id).ToList(); });
            }
            else
            {
                throw new HttpError(HttpStatusCode.Forbidden);
            }

            return ret;
        }
    }
}