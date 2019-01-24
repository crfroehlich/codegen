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
    public partial class WorkflowTaskService : DocServiceBase
    {
        private IQueryable<DocEntityWorkflowTask> _ExecSearch(WorkflowTaskSearch request)
        {
            request = InitSearch(request);
            IQueryable<DocEntityWorkflowTask> entities = null;
            Execute.Run( session => 
            {
                entities = Execute.SelectAll<DocEntityWorkflowTask>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new WorkflowTaskFullTextSearch(request);
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

                if(!DocTools.IsNullOrEmpty(request.Assignee) && !DocTools.IsNullOrEmpty(request.Assignee.Id))
                {
                    entities = entities.Where(en => en.Assignee.Id == request.Assignee.Id );
                }
                if(true == request.AssigneeIds?.Any())
                {
                    entities = entities.Where(en => en.Assignee.Id.In(request.AssigneeIds));
                }
                if(!DocTools.IsNullOrEmpty(request.Description))
                    entities = entities.Where(en => en.Description.Contains(request.Description));
                if(!DocTools.IsNullOrEmpty(request.DueDate))
                    entities = entities.Where(en => null != en.DueDate && request.DueDate.Value.Date == en.DueDate.Value.Date);
                if(!DocTools.IsNullOrEmpty(request.DueDateBefore))
                    entities = entities.Where(en => en.DueDate <= request.DueDateBefore);
                if(!DocTools.IsNullOrEmpty(request.DueDateAfter))
                    entities = entities.Where(en => en.DueDate >= request.DueDateAfter);
                if(!DocTools.IsNullOrEmpty(request.Reporter) && !DocTools.IsNullOrEmpty(request.Reporter.Id))
                {
                    entities = entities.Where(en => en.Reporter.Id == request.Reporter.Id );
                }
                if(true == request.ReporterIds?.Any())
                {
                    entities = entities.Where(en => en.Reporter.Id.In(request.ReporterIds));
                }
                if(!DocTools.IsNullOrEmpty(request.Status) && !DocTools.IsNullOrEmpty(request.Status.Id))
                {
                    entities = entities.Where(en => en.Status.Id == request.Status.Id );
                }
                if(true == request.StatusIds?.Any())
                {
                    entities = entities.Where(en => en.Status.Id.In(request.StatusIds));
                }
                else if(!DocTools.IsNullOrEmpty(request.Status) && !DocTools.IsNullOrEmpty(request.Status.Name))
                {
                    entities = entities.Where(en => en.Status.Name == request.Status.Name );
                }
                if(true == request.StatusNames?.Any())
                {
                    entities = entities.Where(en => en.Status.Name.In(request.StatusNames));
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
                if(!DocTools.IsNullOrEmpty(request.Workflow) && !DocTools.IsNullOrEmpty(request.Workflow.Id))
                {
                    entities = entities.Where(en => en.Workflow.Id == request.Workflow.Id );
                }
                if(true == request.WorkflowIds?.Any())
                {
                    entities = entities.Where(en => en.Workflow.Id.In(request.WorkflowIds));
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
            });
            return entities;
        }

        public List<WorkflowTask> Post(WorkflowTaskSearch request) => Get(request);

        public List<WorkflowTask> Get(WorkflowTaskSearch request) => GetSearchResult<WorkflowTask,DocEntityWorkflowTask,WorkflowTaskSearch>(DocConstantModelName.WORKFLOWTASK, request, _ExecSearch);

        public object Post(WorkflowTaskVersion request) => Get(request);

        public object Get(WorkflowTaskVersion request) 
        {
            List<Version> ret = null;
            Execute.Run(s=>
            {
                ret = _ExecSearch(request).Select(e => new Version(e.Id, e.VersionNo)).ToList();
            });
            return ret;
        }

        public WorkflowTask Get(WorkflowTask request) => GetEntity<WorkflowTask>(DocConstantModelName.WORKFLOWTASK, request, GetWorkflowTask);
        private WorkflowTask _AssignValues(WorkflowTask request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "WorkflowTask"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            WorkflowTask ret = null;
            request = _InitAssignValues(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            var cacheKey = GetApiCacheKey<WorkflowTask>(DocConstantModelName.WORKFLOWTASK, nameof(WorkflowTask), request);
            
            //First, assign all the variables, do database lookups and conversions
            var pAssignee = (request.Assignee?.Id > 0) ? DocEntityUser.GetUser(request.Assignee.Id) : null;
            var pData = request.Data;
            var pDescription = request.Description;
            var pDueDate = request.DueDate;
            var pReporter = (request.Reporter?.Id > 0) ? DocEntityUser.GetUser(request.Reporter.Id) : null;
            DocEntityLookupTable pStatus = GetLookup(DocConstantLookupTable.WORKFLOWSTATUS, request.Status?.Name, request.Status?.Id);
            DocEntityLookupTable pType = GetLookup(DocConstantLookupTable.WORKFLOWTASKTYPE, request.Type?.Name, request.Type?.Id);
            var pWorkflow = (request.Workflow?.Id > 0) ? DocEntityWorkflow.GetWorkflow(request.Workflow.Id) : null;

            DocEntityWorkflowTask entity = null;
            if(permission == DocConstantPermission.ADD)
            {
                var now = DateTime.UtcNow;
                entity = new DocEntityWorkflowTask(session)
                {
                    Created = now,
                    Updated = now
                };
            }
            else
            {
                entity = DocEntityWorkflowTask.GetWorkflowTask(request.Id);
                if(null == entity)
                    throw new HttpError(HttpStatusCode.NotFound, $"No record");
            }

            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityUser>(currentUser, request, pAssignee, permission, DocConstantModelName.WORKFLOWTASK, nameof(request.Assignee)))
            {
                if(DocPermissionFactory.IsRequested(request, pAssignee, entity.Assignee, nameof(request.Assignee)))
                    entity.Assignee = pAssignee;
                if(DocPermissionFactory.IsRequested<DocEntityUser>(request, pAssignee, nameof(request.Assignee)) && !request.VisibleFields.Matches(nameof(request.Assignee), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Assignee));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pData, permission, DocConstantModelName.WORKFLOWTASK, nameof(request.Data)))
            {
                if(DocPermissionFactory.IsRequested(request, pData, entity.Data, nameof(request.Data)))
                    entity.Data = pData;
                if(DocPermissionFactory.IsRequested<string>(request, pData, nameof(request.Data)) && !request.VisibleFields.Matches(nameof(request.Data), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Data));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pDescription, permission, DocConstantModelName.WORKFLOWTASK, nameof(request.Description)))
            {
                if(DocPermissionFactory.IsRequested(request, pDescription, entity.Description, nameof(request.Description)))
                    entity.Description = pDescription;
                if(DocPermissionFactory.IsRequested<string>(request, pDescription, nameof(request.Description)) && !request.VisibleFields.Matches(nameof(request.Description), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Description));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DateTime?>(currentUser, request, pDueDate, permission, DocConstantModelName.WORKFLOWTASK, nameof(request.DueDate)))
            {
                if(DocPermissionFactory.IsRequested(request, pDueDate, entity.DueDate, nameof(request.DueDate)))
                    entity.DueDate = pDueDate;
                if(DocPermissionFactory.IsRequested<DateTime?>(request, pDueDate, nameof(request.DueDate)) && !request.VisibleFields.Matches(nameof(request.DueDate), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.DueDate));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityUser>(currentUser, request, pReporter, permission, DocConstantModelName.WORKFLOWTASK, nameof(request.Reporter)))
            {
                if(DocPermissionFactory.IsRequested(request, pReporter, entity.Reporter, nameof(request.Reporter)))
                    entity.Reporter = pReporter;
                if(DocPermissionFactory.IsRequested<DocEntityUser>(request, pReporter, nameof(request.Reporter)) && !request.VisibleFields.Matches(nameof(request.Reporter), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Reporter));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityLookupTable>(currentUser, request, pStatus, permission, DocConstantModelName.WORKFLOWTASK, nameof(request.Status)))
            {
                if(DocPermissionFactory.IsRequested(request, pStatus, entity.Status, nameof(request.Status)))
                    entity.Status = pStatus;
                if(DocPermissionFactory.IsRequested<DocEntityLookupTable>(request, pStatus, nameof(request.Status)) && !request.VisibleFields.Matches(nameof(request.Status), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Status));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityLookupTable>(currentUser, request, pType, permission, DocConstantModelName.WORKFLOWTASK, nameof(request.Type)))
            {
                if(DocPermissionFactory.IsRequested(request, pType, entity.Type, nameof(request.Type)))
                    entity.Type = pType;
                if(DocPermissionFactory.IsRequested<DocEntityLookupTable>(request, pType, nameof(request.Type)) && !request.VisibleFields.Matches(nameof(request.Type), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Type));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityWorkflow>(currentUser, request, pWorkflow, permission, DocConstantModelName.WORKFLOWTASK, nameof(request.Workflow)))
            {
                if(DocPermissionFactory.IsRequested(request, pWorkflow, entity.Workflow, nameof(request.Workflow)))
                    entity.Workflow = pWorkflow;
                if(DocPermissionFactory.IsRequested<DocEntityWorkflow>(request, pWorkflow, nameof(request.Workflow)) && !request.VisibleFields.Matches(nameof(request.Workflow), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Workflow));
                }
            }
            
            if (request.Locked) entity.Locked = request.Locked;

            entity.SaveChanges(permission);
            
            DocPermissionFactory.SetVisibleFields<WorkflowTask>(currentUser, nameof(WorkflowTask), request.VisibleFields);
            ret = entity.ToDto();

            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.WORKFLOWTASK);

            return ret;
        }
        public WorkflowTask Post(WorkflowTask request)
        {
            if(request == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            WorkflowTask ret = null;

            Execute.Run(ssn =>
            {
                if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "WorkflowTask")) 
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                ret = _AssignValues(request, DocConstantPermission.ADD, ssn);
            });

            return ret;
        }
   
        public List<WorkflowTask> Post(WorkflowTaskBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<WorkflowTask>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Post(dto) as WorkflowTask;
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

        public WorkflowTask Post(WorkflowTaskCopy request)
        {
            WorkflowTask ret = null;
            Execute.Run(ssn =>
            {
                var entity = DocEntityWorkflowTask.GetWorkflowTask(request?.Id);
                if(null == entity) throw new HttpError(HttpStatusCode.NoContent, "The COPY request did not succeed.");
                if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");
                
                    var pAssignee = entity.Assignee;
                    var pData = entity.Data;
                    var pDescription = entity.Description;
                    if(!DocTools.IsNullOrEmpty(pDescription))
                        pDescription += " (Copy)";
                    var pDueDate = entity.DueDate;
                    var pReporter = entity.Reporter;
                    var pStatus = entity.Status;
                    var pType = entity.Type;
                    var pWorkflow = entity.Workflow;
                #region Custom Before copyWorkflowTask
                #endregion Custom Before copyWorkflowTask
                var copy = new DocEntityWorkflowTask(ssn)
                {
                    Hash = Guid.NewGuid()
                                , Assignee = pAssignee
                                , Data = pData
                                , Description = pDescription
                                , DueDate = pDueDate
                                , Reporter = pReporter
                                , Status = pStatus
                                , Type = pType
                                , Workflow = pWorkflow
                };
                #region Custom After copyWorkflowTask
                #endregion Custom After copyWorkflowTask
                copy.SaveChanges(DocConstantPermission.ADD);
                ret = copy.ToDto();
            });
            return ret;
        }


        public List<WorkflowTask> Put(WorkflowTaskBatch request)
        {
            return Patch(request);
        }

        public WorkflowTask Put(WorkflowTask request)
        {
            return Patch(request);
        }

        public List<WorkflowTask> Patch(WorkflowTaskBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<WorkflowTask>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Patch(dto) as WorkflowTask;
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

        public WorkflowTask Patch(WorkflowTask request)
        {
            if(true != (request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the WorkflowTask to patch.");
            
            request.VisibleFields = request.VisibleFields ?? new List<string>();
            
            WorkflowTask ret = null;
            Execute.Run(ssn =>
            {
                ret = _AssignValues(request, DocConstantPermission.EDIT, ssn);
            });
            return ret;
        }

        public void Delete(WorkflowTaskBatch request)
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

        public void Delete(WorkflowTask request)
        {
            Execute.Run(ssn =>
            {
                if(!(request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, $"No Id provided for delete.");

                DocCacheClient.RemoveSearch(DocConstantModelName.WORKFLOWTASK);
                DocCacheClient.RemoveById(request.Id);
                var en = DocEntityWorkflowTask.GetWorkflowTask(request?.Id);

                if(null == en) throw new HttpError(HttpStatusCode.NotFound, $"No WorkflowTask could be found for Id {request?.Id}.");
                if(en.IsRemoved) return;
                
                if(!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.DELETE))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have DELETE permission for this route.");
                
                en.Remove();
            });
        }

        public void Delete(WorkflowTaskSearch request)
        {
            var matches = Get(request) as List<WorkflowTask>;
            if(true != matches?.Any()) throw new HttpError(HttpStatusCode.NotFound, "No matches for request");

            Execute.Run(ssn =>
            {
                matches.ForEach(match =>
                {
                    Delete(match);
                });
            });
        }

        private WorkflowTask GetWorkflowTask(WorkflowTask request)
        {
            var id = request?.Id;
            WorkflowTask ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetVisibleFields<WorkflowTask>(currentUser, "WorkflowTask", request.VisibleFields);

            DocEntityWorkflowTask entity = null;
            if(id.HasValue)
            {
                entity = DocEntityWorkflowTask.GetWorkflowTask(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No WorkflowTask found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }

        public List<int> Any(WorkflowTaskIds request)
        {
            List<int> ret = null;
            if (currentUser.IsSuperAdmin)
            {
                Execute.Run(s => { ret = Execute.SelectAll<DocEntityWorkflowTask>().Select(d => d.Id).ToList(); });
            }
            else
            {
                throw new HttpError(HttpStatusCode.Forbidden);
            }

            return ret;
        }
    }
}