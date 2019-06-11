
//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated by a T4 template. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Net;

using Services.Core;
using Services.Db;
using Services.Dto;
using Services.Enums;
using Services.Schema;

using ServiceStack;
using ServiceStack.Text;

using Typed;
using Typed.Bindings;
using Typed.Notifications;

using Xtensive.Orm;


namespace Services.API
{
    public partial class EoDService : DocServiceBase
    {

        private IQueryable<DocEntityEoD> _ExecSearch(EoDSearch request, DocQuery query)
        {
            request = InitSearch<EoD, EoDSearch>(request);
            IQueryable<DocEntityEoD> entities = null;
            query.Run( session => 
            {
                entities = query.SelectAll<DocEntityEoD>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new EoDFullTextSearch(request);
                    entities = GetFullTextSearch<DocEntityEoD,EoDFullTextSearch>(fts, entities);
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
                if(true == request.Archived?.Any() && currentUser.HasProperty(DocConstantModelName.EOD, nameof(Reference.Archived), DocConstantPermission.VIEW))
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
                if(!DocTools.IsNullOrEmpty(request.Descriptions))
                    entities = entities.Where(en => en.Description.In(request.Descriptions));
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
                if(request.Type.HasValue)
                    entities = entities.Where(en => request.Type.Value == en.Type);
                if(!DocTools.IsNullOrEmpty(request.Types))
                    entities = entities.Where(en => en.Type.In(request.Types));
                if(!DocTools.IsNullOrEmpty(request.Workflow) && !DocTools.IsNullOrEmpty(request.Workflow.Id))
                {
                    entities = entities.Where(en => en.Workflow.Id == request.Workflow.Id );
                }
                if(true == request.WorkflowIds?.Any())
                {
                    entities = entities.Where(en => en.Workflow.Id.In(request.WorkflowIds));
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
                if(!DocTools.IsNullOrEmpty(request.Descriptions))
                    entities = entities.Where(en => en.Description.In(request.Descriptions));
                if(!DocTools.IsNullOrEmpty(request.Document) && !DocTools.IsNullOrEmpty(request.Document.Id))
                {
                    entities = entities.Where(en => en.Document.Id == request.Document.Id );
                }
                if(true == request.DocumentIds?.Any())
                {
                    entities = entities.Where(en => en.Document.Id.In(request.DocumentIds));
                }
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
                if(request.Status.HasValue)
                    entities = entities.Where(en => request.Status.Value == en.Status);
                if(!DocTools.IsNullOrEmpty(request.Statuss))
                    entities = entities.Where(en => en.Status.In(request.Statuss));
                if(request.Type.HasValue)
                    entities = entities.Where(en => request.Type.Value == en.Type);
                if(!DocTools.IsNullOrEmpty(request.Types))
                    entities = entities.Where(en => en.Type.In(request.Types));
                if(!DocTools.IsNullOrEmpty(request.Workflow) && !DocTools.IsNullOrEmpty(request.Workflow.Id))
                {
                    entities = entities.Where(en => en.Workflow.Id == request.Workflow.Id );
                }
                if(true == request.WorkflowIds?.Any())
                {
                    entities = entities.Where(en => en.Workflow.Id.In(request.WorkflowIds));
                }

                entities = ApplyFilters<DocEntityEoD,EoDSearch>(request, entities);

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

        public object Post(EoDSearch request) => Get(request);

        public object Get(EoDSearch request) => GetSearchResultWithCache<EoD,DocEntityEoD,EoDSearch>(DocConstantModelName.EOD, request, _ExecSearch);

        public object Get(EoD request) => GetEntityWithCache<EoD>(DocConstantModelName.EOD, request, GetEoD);



        private EoD _AssignValues(EoD request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "EoD"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.Select = request.Select ?? new List<string>();

            EoD ret = null;
            request = _InitAssignValues<EoD>(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            var cacheKey = GetApiCacheKey<EoD>(DocConstantModelName.EOD, nameof(EoD), request);
            
            //First, assign all the variables, do database lookups and conversions
            var pAssignee = (request.Assignee?.Id > 0) ? DocEntityUser.Get(request.Assignee.Id) : null;
            var pData = request.Data;
            var pDescription = request.Description;
            var pDocument = (request.Document?.Id > 0) ? DocEntityDocument.Get(request.Document.Id) : null;
            var pDueDate = request.DueDate;
            var pReporter = (request.Reporter?.Id > 0) ? DocEntityUser.Get(request.Reporter.Id) : null;
            var pStatus = request.Status;
            var pType = request.Type;
            var pWorkflow = (request.Workflow?.Id > 0) ? DocEntityWorkflow.Get(request.Workflow.Id) : null;

            DocEntityEoD entity = null;
            if(permission == DocConstantPermission.ADD)
            {
                var now = DateTime.UtcNow;
                entity = new DocEntityEoD(session)
                {
                    Created = now,
                    Updated = now
                };
            }
            else
            {
                entity = DocEntityEoD.Get(request.Id);
                if(null == entity)
                    throw new HttpError(HttpStatusCode.NotFound, $"No record");
            }

            //Special case for Archived
            var pArchived = true == request.Archived;
            if (DocPermissionFactory.IsRequestedHasPermission<bool>(currentUser, request, pArchived, permission, DocConstantModelName.EOD, nameof(request.Archived)))
            {
                if(DocPermissionFactory.IsRequested(request, pArchived, entity.Archived, nameof(request.Archived)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.EOD, nameof(request.Archived)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Archived)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pArchived) && DocResources.Metadata.IsRequired(DocConstantModelName.EOD, nameof(request.Archived))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Archived)} requires a value.");
                    entity.Archived = pArchived;
                if(DocPermissionFactory.IsRequested<bool>(request, pArchived, nameof(request.Archived)) && !request.Select.Matches(nameof(request.Archived), ignoreSpaces: true))
                {
                    request.Select.Add(nameof(request.Archived));
                }
            }

            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityUser>(currentUser, request, pAssignee, permission, DocConstantModelName.EOD, nameof(request.Assignee)))
            {
                if(DocPermissionFactory.IsRequested(request, pAssignee, entity.Assignee, nameof(request.Assignee)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.EOD, nameof(request.Assignee)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Assignee)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pAssignee) && DocResources.Metadata.IsRequired(DocConstantModelName.EOD, nameof(request.Assignee))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Assignee)} requires a value.");
                    entity.Assignee = pAssignee;
                if(DocPermissionFactory.IsRequested<DocEntityUser>(request, pAssignee, nameof(request.Assignee)) && !request.Select.Matches(nameof(request.Assignee), ignoreSpaces: true))
                {
                    request.Select.Add(nameof(request.Assignee));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pData, permission, DocConstantModelName.EOD, nameof(request.Data)))
            {
                if(DocPermissionFactory.IsRequested(request, pData, entity.Data, nameof(request.Data)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.EOD, nameof(request.Data)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Data)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pData) && DocResources.Metadata.IsRequired(DocConstantModelName.EOD, nameof(request.Data))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Data)} requires a value.");
                    entity.Data = pData;
                if(DocPermissionFactory.IsRequested<string>(request, pData, nameof(request.Data)) && !request.Select.Matches(nameof(request.Data), ignoreSpaces: true))
                {
                    request.Select.Add(nameof(request.Data));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pDescription, permission, DocConstantModelName.EOD, nameof(request.Description)))
            {
                if(DocPermissionFactory.IsRequested(request, pDescription, entity.Description, nameof(request.Description)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.EOD, nameof(request.Description)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Description)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pDescription) && DocResources.Metadata.IsRequired(DocConstantModelName.EOD, nameof(request.Description))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Description)} requires a value.");
                    entity.Description = pDescription;
                if(DocPermissionFactory.IsRequested<string>(request, pDescription, nameof(request.Description)) && !request.Select.Matches(nameof(request.Description), ignoreSpaces: true))
                {
                    request.Select.Add(nameof(request.Description));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityDocument>(currentUser, request, pDocument, permission, DocConstantModelName.EOD, nameof(request.Document)))
            {
                if(DocPermissionFactory.IsRequested(request, pDocument, entity.Document, nameof(request.Document)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.EOD, nameof(request.Document)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Document)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pDocument) && DocResources.Metadata.IsRequired(DocConstantModelName.EOD, nameof(request.Document))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Document)} requires a value.");
                    entity.Document = pDocument;
                if(DocPermissionFactory.IsRequested<DocEntityDocument>(request, pDocument, nameof(request.Document)) && !request.Select.Matches(nameof(request.Document), ignoreSpaces: true))
                {
                    request.Select.Add(nameof(request.Document));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DateTime?>(currentUser, request, pDueDate, permission, DocConstantModelName.EOD, nameof(request.DueDate)))
            {
                if(DocPermissionFactory.IsRequested(request, pDueDate, entity.DueDate, nameof(request.DueDate)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.EOD, nameof(request.DueDate)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.DueDate)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pDueDate) && DocResources.Metadata.IsRequired(DocConstantModelName.EOD, nameof(request.DueDate))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.DueDate)} requires a value.");
                    entity.DueDate = pDueDate;
                if(DocPermissionFactory.IsRequested<DateTime?>(request, pDueDate, nameof(request.DueDate)) && !request.Select.Matches(nameof(request.DueDate), ignoreSpaces: true))
                {
                    request.Select.Add(nameof(request.DueDate));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityUser>(currentUser, request, pReporter, permission, DocConstantModelName.EOD, nameof(request.Reporter)))
            {
                if(DocPermissionFactory.IsRequested(request, pReporter, entity.Reporter, nameof(request.Reporter)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.EOD, nameof(request.Reporter)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Reporter)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pReporter) && DocResources.Metadata.IsRequired(DocConstantModelName.EOD, nameof(request.Reporter))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Reporter)} requires a value.");
                    entity.Reporter = pReporter;
                if(DocPermissionFactory.IsRequested<DocEntityUser>(request, pReporter, nameof(request.Reporter)) && !request.Select.Matches(nameof(request.Reporter), ignoreSpaces: true))
                {
                    request.Select.Add(nameof(request.Reporter));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<EoDStatusEnm?>(currentUser, request, pStatus, permission, DocConstantModelName.EOD, nameof(request.Status)))
            {
                if(DocPermissionFactory.IsRequested(request, (int?) pStatus, (int) entity.Status, nameof(request.Status)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.EOD, nameof(request.Status)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Status)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pStatus) && DocResources.Metadata.IsRequired(DocConstantModelName.EOD, nameof(request.Status))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Status)} requires a value.");
                    if(null != pStatus)
                        entity.Status = pStatus.Value;
                if(DocPermissionFactory.IsRequested<EoDStatusEnm?>(request, pStatus, nameof(request.Status)) && !request.Select.Matches(nameof(request.Status), ignoreSpaces: true))
                {
                    request.Select.Add(nameof(request.Status));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<TaskTypeEnm?>(currentUser, request, pType, permission, DocConstantModelName.EOD, nameof(request.Type)))
            {
                if(DocPermissionFactory.IsRequested(request, (int?) pType, (int) entity.Type, nameof(request.Type)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.EOD, nameof(request.Type)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Type)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pType) && DocResources.Metadata.IsRequired(DocConstantModelName.EOD, nameof(request.Type))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Type)} requires a value.");
                    if(null != pType)
                        entity.Type = pType.Value;
                if(DocPermissionFactory.IsRequested<TaskTypeEnm?>(request, pType, nameof(request.Type)) && !request.Select.Matches(nameof(request.Type), ignoreSpaces: true))
                {
                    request.Select.Add(nameof(request.Type));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityWorkflow>(currentUser, request, pWorkflow, permission, DocConstantModelName.EOD, nameof(request.Workflow)))
            {
                if(DocPermissionFactory.IsRequested(request, pWorkflow, entity.Workflow, nameof(request.Workflow)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.EOD, nameof(request.Workflow)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Workflow)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pWorkflow) && DocResources.Metadata.IsRequired(DocConstantModelName.EOD, nameof(request.Workflow))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Workflow)} requires a value.");
                    entity.Workflow = pWorkflow;
                if(DocPermissionFactory.IsRequested<DocEntityWorkflow>(request, pWorkflow, nameof(request.Workflow)) && !request.Select.Matches(nameof(request.Workflow), ignoreSpaces: true))
                {
                    request.Select.Add(nameof(request.Workflow));
                }
            }

            if (request.Locked) entity.Locked = request.Locked;

            entity.SaveChanges(permission);


            DocPermissionFactory.SetSelect<EoD>(currentUser, nameof(EoD), request.Select);
            ret = entity.ToDto();

            var cacheExpires = DocResources.Metadata.GetCacheExpiration(DocConstantModelName.EOD);
            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.EOD, cacheExpires);

            return ret;
        }


        public EoD Post(EoD request)
        {
            if(request == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            request.Select = request.Select ?? new List<string>();

            EoD ret = null;

            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "EoD")) 
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                    ret = _AssignValues(request, DocConstantPermission.ADD, ssn);
                });
            }
            return ret;
        }
   
        public List<EoD> Post(EoDBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<EoD>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Post(dto) as EoD;
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

        public EoD Post(EoDCopy request)
        {
            EoD ret = null;
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    var entity = DocEntityEoD.Get(request?.Id);
                    if(null == entity) throw new HttpError(HttpStatusCode.NoContent, "The COPY request did not succeed.");
                    if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD))
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                    var pAssignee = entity.Assignee;
                    var pData = entity.Data;
                    var pDescription = entity.Description;
                    if(!DocTools.IsNullOrEmpty(pDescription))
                        pDescription += " (Copy)";
                    var pDocument = entity.Document;
                    var pDueDate = entity.DueDate;
                    var pReporter = entity.Reporter;
                    var pStatus = entity.Status;
                    var pType = entity.Type;
                    var pWorkflow = entity.Workflow;
                    var copy = new DocEntityEoD(ssn)
                    {
                        Hash = Guid.NewGuid()
                                , Assignee = pAssignee
                                , Data = pData
                                , Description = pDescription
                                , Document = pDocument
                                , DueDate = pDueDate
                                , Reporter = pReporter
                                , Status = pStatus
                                , Type = pType
                                , Workflow = pWorkflow
                    };

                    copy.SaveChanges(DocConstantPermission.ADD);
                    ret = copy.ToDto();
                });
            }
            return ret;
        }



        public List<EoD> Put(EoDBatch request)
        {
            return Patch(request);
        }

        public EoD Put(EoD request)
        {
            return Patch(request);
        }


        public List<EoD> Patch(EoDBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<EoD>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Patch(dto) as EoD;
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

        public EoD Patch(EoD request)
        {
            if(true != (request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the EoD to patch.");
            
            request.Select = request.Select ?? new List<string>();
            
            EoD ret = null;
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    ret = _AssignValues(request, DocConstantPermission.EDIT, ssn);
                });
            }
            return ret;
        }


        public void Delete(EoDBatch request)
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

        public void Delete(EoD request)
        {
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    if(!(request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, $"No Id provided for delete.");

                    var en = DocEntityEoD.Get(request?.Id);
                    if(null == en) throw new HttpError(HttpStatusCode.NotFound, $"No EoD could be found for Id {request?.Id}.");
                    if(en.IsRemoved) return;
                
                    if(!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.DELETE))
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have DELETE permission for this route.");
                
                    en.Remove();

                    DocCacheClient.RemoveSearch(DocConstantModelName.EOD);
                    DocCacheClient.RemoveById(request.Id);
                });
            }
        }

        public void Delete(EoDSearch request)
        {
            var matches = Get(request) as List<EoD>;
            if(true != matches?.Any()) throw new HttpError(HttpStatusCode.NotFound, "No matches for request");
            matches.ForEach(match =>
            {
                Delete(match);
            });
        }




        private EoD GetEoD(EoD request)
        {
            var id = request?.Id;
            EoD ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetSelect<EoD>(currentUser, "EoD", request.Select);

            DocEntityEoD entity = null;
            if(id.HasValue)
            {
                entity = DocEntityEoD.Get(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No EoD found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }

    }
}
