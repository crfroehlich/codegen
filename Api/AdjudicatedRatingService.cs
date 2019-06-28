//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated by a T4 template. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.CodeDom.Compiler;
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
    public partial class AdjudicatedRatingService : DocServiceBase
    {

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private IQueryable<DocEntityAdjudicatedRating> _ExecSearch(AdjudicatedRatingSearch request, DocQuery query)
        {
            request = InitSearch<AdjudicatedRating, AdjudicatedRatingSearch>(request);
            IQueryable<DocEntityAdjudicatedRating> entities = null;
            query.Run( session => 
            {
                entities = query.SelectAll<DocEntityAdjudicatedRating>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new AdjudicatedRatingFullTextSearch(request);
                    entities = GetFullTextSearch<DocEntityAdjudicatedRating,AdjudicatedRatingFullTextSearch>(fts, entities);
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
                if(true == request.Archived?.Any() && currentUser.HasProperty(DocConstantModelName.ADJUDICATEDRATING, nameof(Reference.Archived), DocConstantPermission.VIEW))
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
                if(request.Rating.HasValue)
                    entities = entities.Where(en => request.Rating.Value == en.Rating);
                if(!DocTools.IsNullOrEmpty(request.Ratings))
                    entities = entities.Where(en => en.Rating.In(request.Ratings));
                if(request.ReasonRejected.HasValue)
                    entities = entities.Where(en => request.ReasonRejected.Value == en.ReasonRejected);
                if(!DocTools.IsNullOrEmpty(request.ReasonRejecteds))
                    entities = entities.Where(en => en.ReasonRejected.In(request.ReasonRejecteds));
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

                entities = ApplyFilters<DocEntityAdjudicatedRating,AdjudicatedRatingSearch>(request, entities);

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
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Post(AdjudicatedRatingSearch request) => Get(request);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Get(AdjudicatedRatingSearch request) => GetSearchResultWithCache<AdjudicatedRating,DocEntityAdjudicatedRating,AdjudicatedRatingSearch>(DocConstantModelName.ADJUDICATEDRATING, request, _ExecSearch);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Get(AdjudicatedRating request) => GetEntityWithCache<AdjudicatedRating>(DocConstantModelName.ADJUDICATEDRATING, request, GetAdjudicatedRating);



        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private AdjudicatedRating _AssignValues(AdjudicatedRating request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "AdjudicatedRating"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.Select = request.Select ?? new List<string>();

            AdjudicatedRating ret = null;
            request = _InitAssignValues<AdjudicatedRating>(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            var cacheKey = GetApiCacheKey<AdjudicatedRating>(DocConstantModelName.ADJUDICATEDRATING, nameof(AdjudicatedRating), request);
            
            //First, assign all the variables, do database lookups and conversions
            var pAssignee = DocEntityUser.Get(request.Assignee?.Id, true, Execute) ?? DocEntityUser.Get(request.AssigneeId, true, Execute);
            var pData = request.Data;
            var pDescription = request.Description;
            var pDocument = DocEntityDocument.Get(request.Document?.Id, true, Execute) ?? DocEntityDocument.Get(request.DocumentId, true, Execute);
            var pDueDate = request.DueDate;
            var pRating = request.Rating;
            var pReasonRejected = request.ReasonRejected;
            var pReporter = DocEntityUser.Get(request.Reporter?.Id, true, Execute) ?? DocEntityUser.Get(request.ReporterId, true, Execute);
            var pType = request.Type;
            var pWorkflow = DocEntityWorkflow.Get(request.Workflow?.Id, true, Execute) ?? DocEntityWorkflow.Get(request.WorkflowId, true, Execute);
            var pArchived = true == request.Archived;
            var pLocked = request.Locked;

            var entity = InitEntity<DocEntityAdjudicatedRating,AdjudicatedRating>(request, permission, session);

            if (AllowPatchValue<AdjudicatedRating, bool>(request, DocConstantModelName.ADJUDICATEDRATING, pArchived, permission, nameof(request.Archived), pArchived != entity.Archived))
            {
                entity.Archived = pArchived;
            }
            if (AllowPatchValue<AdjudicatedRating, DocEntityUser>(request, DocConstantModelName.ADJUDICATEDRATING, pAssignee, permission, nameof(request.Assignee), pAssignee != entity.Assignee))
            {
                entity.Assignee = pAssignee;
            }
            if (AllowPatchValue<AdjudicatedRating, string>(request, DocConstantModelName.ADJUDICATEDRATING, pData, permission, nameof(request.Data), pData != entity.Data))
            {
                entity.Data = pData;
            }
            if (AllowPatchValue<AdjudicatedRating, string>(request, DocConstantModelName.ADJUDICATEDRATING, pDescription, permission, nameof(request.Description), pDescription != entity.Description))
            {
                entity.Description = pDescription;
            }
            if (AllowPatchValue<AdjudicatedRating, DocEntityDocument>(request, DocConstantModelName.ADJUDICATEDRATING, pDocument, permission, nameof(request.Document), pDocument != entity.Document))
            {
                entity.Document = pDocument;
            }
            if (AllowPatchValue<AdjudicatedRating, DateTime?>(request, DocConstantModelName.ADJUDICATEDRATING, pDueDate, permission, nameof(request.DueDate), pDueDate != entity.DueDate))
            {
                entity.DueDate = pDueDate;
            }
            if (AllowPatchValue<AdjudicatedRating, RatingEnm?>(request, DocConstantModelName.ADJUDICATEDRATING, pRating, permission, nameof(request.Rating), pRating != entity.Rating))
            {
                if(null != pRating) entity.Rating = pRating.Value;
            }
            if (AllowPatchValue<AdjudicatedRating, ReasonRejectedEnm?>(request, DocConstantModelName.ADJUDICATEDRATING, pReasonRejected, permission, nameof(request.ReasonRejected), pReasonRejected != entity.ReasonRejected))
            {
                entity.ReasonRejected = pReasonRejected;
            }
            if (AllowPatchValue<AdjudicatedRating, DocEntityUser>(request, DocConstantModelName.ADJUDICATEDRATING, pReporter, permission, nameof(request.Reporter), pReporter != entity.Reporter))
            {
                entity.Reporter = pReporter;
            }
            if (AllowPatchValue<AdjudicatedRating, TaskTypeEnm?>(request, DocConstantModelName.ADJUDICATEDRATING, pType, permission, nameof(request.Type), pType != entity.Type))
            {
                if(null != pType) entity.Type = pType.Value;
            }
            if (AllowPatchValue<AdjudicatedRating, DocEntityWorkflow>(request, DocConstantModelName.ADJUDICATEDRATING, pWorkflow, permission, nameof(request.Workflow), pWorkflow != entity.Workflow))
            {
                entity.Workflow = pWorkflow;
            }
            if (request.Locked && AllowPatchValue<AdjudicatedRating, bool>(request, DocConstantModelName.ADJUDICATEDRATING, pArchived, permission, nameof(request.Locked), pLocked != entity.Locked))
            {
                entity.Archived = pArchived;
            }
            entity.SaveChanges(permission);

            var idsToInvalidate = new List<int>();

            if (idsToInvalidate.Any())
            {
                idsToInvalidate.Add(entity.Id);
                DocCacheClient.RemoveByEntityIds(idsToInvalidate);
                DocCacheClient.RemoveSearch(DocConstantModelName.ADJUDICATEDRATING);
            }

            entity.SaveChanges(permission);
            DocPermissionFactory.SetSelect<AdjudicatedRating>(currentUser, nameof(AdjudicatedRating), request.Select);
            ret = entity.ToDto();

            var cacheExpires = DocResources.Metadata.GetCacheExpiration(DocConstantModelName.ADJUDICATEDRATING);
            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.ADJUDICATEDRATING, cacheExpires);

            return ret;
        }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public AdjudicatedRating Post(AdjudicatedRating request)
        {
            if(request == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            request.Select = request.Select ?? new List<string>();

            AdjudicatedRating ret = null;

            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "AdjudicatedRating")) 
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                    ret = _AssignValues(request, DocConstantPermission.ADD, ssn);
                });
            }
            return ret;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<AdjudicatedRating> Post(AdjudicatedRatingBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<AdjudicatedRating>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Post(dto) as AdjudicatedRating;
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
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public AdjudicatedRating Post(AdjudicatedRatingCopy request)
        {
            AdjudicatedRating ret = null;
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    var entity = DocEntityAdjudicatedRating.Get(request?.Id);
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
                    var pRating = entity.Rating;
                    var pReasonRejected = entity.ReasonRejected;
                    var pReporter = entity.Reporter;
                    var pType = entity.Type;
                    var pWorkflow = entity.Workflow;
                    var copy = new DocEntityAdjudicatedRating(ssn)
                    {
                        Hash = Guid.NewGuid()
                                , Assignee = pAssignee
                                , Data = pData
                                , Description = pDescription
                                , Document = pDocument
                                , DueDate = pDueDate
                                , Rating = pRating
                                , ReasonRejected = pReasonRejected
                                , Reporter = pReporter
                                , Type = pType
                                , Workflow = pWorkflow
                    };

                    copy.SaveChanges(DocConstantPermission.ADD);
                    ret = copy.ToDto();
                });
            }
            return ret;
        }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<AdjudicatedRating> Put(AdjudicatedRatingBatch request)
        {
            return Patch(request);
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public AdjudicatedRating Put(AdjudicatedRating request)
        {
            return Patch(request);
        }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<AdjudicatedRating> Patch(AdjudicatedRatingBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<AdjudicatedRating>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Patch(dto) as AdjudicatedRating;
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
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public AdjudicatedRating Patch(AdjudicatedRating request)
        {
            if(true != (request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the AdjudicatedRating to patch.");
            
            request.Select = request.Select ?? new List<string>();
            
            AdjudicatedRating ret = null;
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    ret = _AssignValues(request, DocConstantPermission.EDIT, ssn);
                });
            }
            return ret;
        }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public void Delete(AdjudicatedRatingBatch request)
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
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public void Delete(AdjudicatedRating request)
        {
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    if(!(request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, $"No Id provided for delete.");

                    var en = DocEntityAdjudicatedRating.Get(request?.Id);
                    if(null == en) throw new HttpError(HttpStatusCode.NotFound, $"No AdjudicatedRating could be found for Id {request?.Id}.");
                    if(en.IsRemoved) return;
                
                    if(!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.DELETE))
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have DELETE permission for this route.");
                
                    en.Remove();

                    DocCacheClient.RemoveSearch(DocConstantModelName.ADJUDICATEDRATING);
                    DocCacheClient.RemoveById(request.Id);
                });
            }
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public void Delete(AdjudicatedRatingSearch request)
        {
            var matches = Get(request) as List<AdjudicatedRating>;
            if(true != matches?.Any()) throw new HttpError(HttpStatusCode.NotFound, "No matches for request");
            matches.ForEach(match =>
            {
                Delete(match);
            });
        }




        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private AdjudicatedRating GetAdjudicatedRating(AdjudicatedRating request)
        {
            var id = request?.Id;
            AdjudicatedRating ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetSelect<AdjudicatedRating>(currentUser, "AdjudicatedRating", request.Select);

            DocEntityAdjudicatedRating entity = null;
            if(id.HasValue)
            {
                entity = DocEntityAdjudicatedRating.Get(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No AdjudicatedRating found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }

    }
}
