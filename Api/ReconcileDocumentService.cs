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
    public partial class ReconcileDocumentService : DocServiceBase
    {

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private IQueryable<DocEntityReconcileDocument> _ExecSearch(ReconcileDocumentSearch request, DocQuery query)
        {
            request = InitSearch<ReconcileDocument, ReconcileDocumentSearch>(request);
            IQueryable<DocEntityReconcileDocument> entities = null;
            query.Run( session => 
            {
                entities = query.SelectAll<DocEntityReconcileDocument>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new ReconcileDocumentFullTextSearch(request);
                    entities = GetFullTextSearch<DocEntityReconcileDocument,ReconcileDocumentFullTextSearch>(fts, entities);
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
                if(true == request.Archived?.Any() && currentUser.HasProperty(DocConstantModelName.RECONCILEDOCUMENT, nameof(Reference.Archived), DocConstantPermission.VIEW))
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
                if(!DocTools.IsNullOrEmpty(request.ArticleId))
                    entities = entities.Where(en => en.ArticleId.Contains(request.ArticleId));
                if(!DocTools.IsNullOrEmpty(request.ArticleIds))
                    entities = entities.Where(en => en.ArticleId.In(request.ArticleIds));
                if(!DocTools.IsNullOrEmpty(request.ArticleLink))
                    entities = entities.Where(en => en.ArticleLink.Contains(request.ArticleLink));
                if(!DocTools.IsNullOrEmpty(request.ArticleLinks))
                    entities = entities.Where(en => en.ArticleLink.In(request.ArticleLinks));
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
                if(request.Matches.HasValue)
                    entities = entities.Where(en => request.Matches.Value == en.Matches);
                if(!DocTools.IsNullOrEmpty(request.Reporter) && !DocTools.IsNullOrEmpty(request.Reporter.Id))
                {
                    entities = entities.Where(en => en.Reporter.Id == request.Reporter.Id );
                }
                if(true == request.ReporterIds?.Any())
                {
                    entities = entities.Where(en => en.Reporter.Id.In(request.ReporterIds));
                }
                if(!DocTools.IsNullOrEmpty(request.SearchLink))
                    entities = entities.Where(en => en.SearchLink.Contains(request.SearchLink));
                if(!DocTools.IsNullOrEmpty(request.SearchLinks))
                    entities = entities.Where(en => en.SearchLink.In(request.SearchLinks));
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

                entities = ApplyFilters<DocEntityReconcileDocument,ReconcileDocumentSearch>(request, entities);

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
        public object Post(ReconcileDocumentSearch request) => Get(request);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Get(ReconcileDocumentSearch request) => GetSearchResultWithCache<ReconcileDocument,DocEntityReconcileDocument,ReconcileDocumentSearch>(DocConstantModelName.RECONCILEDOCUMENT, request, _ExecSearch);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Get(ReconcileDocument request) => GetEntityWithCache<ReconcileDocument>(DocConstantModelName.RECONCILEDOCUMENT, request, GetReconcileDocument);



        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private ReconcileDocument _AssignValues(ReconcileDocument request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "ReconcileDocument"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.Select = request.Select ?? new List<string>();

            ReconcileDocument ret = null;
            request = _InitAssignValues<ReconcileDocument>(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            var cacheKey = GetApiCacheKey<ReconcileDocument>(DocConstantModelName.RECONCILEDOCUMENT, nameof(ReconcileDocument), request);
            
            //First, assign all the variables, do database lookups and conversions
            var pArticleId = request.ArticleId;
            var pArticleLink = request.ArticleLink;
            var pAssignee = DocEntityUser.Get(request.Assignee?.Id, true, Execute) ?? DocEntityUser.Get(request.AssigneeId, true, Execute);
            var pData = request.Data;
            var pDescription = request.Description;
            var pDocument = DocEntityDocument.Get(request.Document?.Id, true, Execute) ?? DocEntityDocument.Get(request.DocumentId, true, Execute);
            var pDueDate = request.DueDate;
            var pMatches = request.Matches;
            var pReporter = DocEntityUser.Get(request.Reporter?.Id, true, Execute) ?? DocEntityUser.Get(request.ReporterId, true, Execute);
            var pSearchLink = request.SearchLink;
            var pStatus = request.Status;
            var pType = request.Type;
            var pWorkflow = DocEntityWorkflow.Get(request.Workflow?.Id, true, Execute) ?? DocEntityWorkflow.Get(request.WorkflowId, true, Execute);
            var pArchived = true == request.Archived;
            var pLocked = request.Locked;

            var entity = InitEntity<DocEntityReconcileDocument,ReconcileDocument>(request, permission, session);

            if (AllowPatchValue<ReconcileDocument, bool>(request, DocConstantModelName.RECONCILEDOCUMENT, pArchived, permission, nameof(request.Archived), pArchived != entity.Archived))
            {
                entity.Archived = pArchived;
            }
            if (AllowPatchValue<ReconcileDocument, string>(request, DocConstantModelName.RECONCILEDOCUMENT, pArticleId, permission, nameof(request.ArticleId), pArticleId != entity.ArticleId))
            {
                entity.ArticleId = pArticleId;
            }
            if (AllowPatchValue<ReconcileDocument, string>(request, DocConstantModelName.RECONCILEDOCUMENT, pArticleLink, permission, nameof(request.ArticleLink), pArticleLink != entity.ArticleLink))
            {
                entity.ArticleLink = pArticleLink;
            }
            if (AllowPatchValue<ReconcileDocument, DocEntityUser>(request, DocConstantModelName.RECONCILEDOCUMENT, pAssignee, permission, nameof(request.Assignee), pAssignee != entity.Assignee))
            {
                entity.Assignee = pAssignee;
            }
            if (AllowPatchValue<ReconcileDocument, string>(request, DocConstantModelName.RECONCILEDOCUMENT, pData, permission, nameof(request.Data), pData != entity.Data))
            {
                entity.Data = pData;
            }
            if (AllowPatchValue<ReconcileDocument, string>(request, DocConstantModelName.RECONCILEDOCUMENT, pDescription, permission, nameof(request.Description), pDescription != entity.Description))
            {
                entity.Description = pDescription;
            }
            if (AllowPatchValue<ReconcileDocument, DocEntityDocument>(request, DocConstantModelName.RECONCILEDOCUMENT, pDocument, permission, nameof(request.Document), pDocument != entity.Document))
            {
                entity.Document = pDocument;
            }
            if (AllowPatchValue<ReconcileDocument, DateTime?>(request, DocConstantModelName.RECONCILEDOCUMENT, pDueDate, permission, nameof(request.DueDate), pDueDate != entity.DueDate))
            {
                entity.DueDate = pDueDate;
            }
            if (AllowPatchValue<ReconcileDocument, int?>(request, DocConstantModelName.RECONCILEDOCUMENT, pMatches, permission, nameof(request.Matches), pMatches != entity.Matches))
            {
                if(null != pMatches) entity.Matches = (int) pMatches;
            }
            if (AllowPatchValue<ReconcileDocument, DocEntityUser>(request, DocConstantModelName.RECONCILEDOCUMENT, pReporter, permission, nameof(request.Reporter), pReporter != entity.Reporter))
            {
                entity.Reporter = pReporter;
            }
            if (AllowPatchValue<ReconcileDocument, string>(request, DocConstantModelName.RECONCILEDOCUMENT, pSearchLink, permission, nameof(request.SearchLink), pSearchLink != entity.SearchLink))
            {
                entity.SearchLink = pSearchLink;
            }
            if (AllowPatchValue<ReconcileDocument, ReconciliationStatusEnm?>(request, DocConstantModelName.RECONCILEDOCUMENT, pStatus, permission, nameof(request.Status), pStatus != entity.Status))
            {
                if(null != pStatus) entity.Status = pStatus.Value;
            }
            if (AllowPatchValue<ReconcileDocument, TaskTypeEnm?>(request, DocConstantModelName.RECONCILEDOCUMENT, pType, permission, nameof(request.Type), pType != entity.Type))
            {
                if(null != pType) entity.Type = pType.Value;
            }
            if (AllowPatchValue<ReconcileDocument, DocEntityWorkflow>(request, DocConstantModelName.RECONCILEDOCUMENT, pWorkflow, permission, nameof(request.Workflow), pWorkflow != entity.Workflow))
            {
                entity.Workflow = pWorkflow;
            }
            if (request.Locked && AllowPatchValue<ReconcileDocument, bool>(request, DocConstantModelName.RECONCILEDOCUMENT, pArchived, permission, nameof(request.Locked), pLocked != entity.Locked))
            {
                entity.Archived = pArchived;
            }
            entity.SaveChanges(permission);

            var idsToInvalidate = new List<int>();

            if (idsToInvalidate.Any())
            {
                idsToInvalidate.Add(entity.Id);
                DocCacheClient.RemoveByEntityIds(idsToInvalidate);
                DocCacheClient.RemoveSearch(DocConstantModelName.RECONCILEDOCUMENT);
            }

            entity.SaveChanges(permission);
            DocPermissionFactory.SetSelect<ReconcileDocument>(currentUser, nameof(ReconcileDocument), request.Select);
            ret = entity.ToDto();

            var cacheExpires = DocResources.Metadata.GetCacheExpiration(DocConstantModelName.RECONCILEDOCUMENT);
            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.RECONCILEDOCUMENT, cacheExpires);

            return ret;
        }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public ReconcileDocument Post(ReconcileDocument request)
        {
            if(request == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            request.Select = request.Select ?? new List<string>();

            ReconcileDocument ret = null;

            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "ReconcileDocument")) 
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                    ret = _AssignValues(request, DocConstantPermission.ADD, ssn);
                });
            }
            return ret;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<ReconcileDocument> Post(ReconcileDocumentBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<ReconcileDocument>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Post(dto) as ReconcileDocument;
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
        public ReconcileDocument Post(ReconcileDocumentCopy request)
        {
            ReconcileDocument ret = null;
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    var entity = DocEntityReconcileDocument.Get(request?.Id);
                    if(null == entity) throw new HttpError(HttpStatusCode.NoContent, "The COPY request did not succeed.");
                    if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD))
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                    var pArticleId = entity.ArticleId;
                    if(!DocTools.IsNullOrEmpty(pArticleId))
                        pArticleId += " (Copy)";
                    var pArticleLink = entity.ArticleLink;
                    if(!DocTools.IsNullOrEmpty(pArticleLink))
                        pArticleLink += " (Copy)";
                    var pAssignee = entity.Assignee;
                    var pData = entity.Data;
                    var pDescription = entity.Description;
                    if(!DocTools.IsNullOrEmpty(pDescription))
                        pDescription += " (Copy)";
                    var pDocument = entity.Document;
                    var pDueDate = entity.DueDate;
                    var pMatches = entity.Matches;
                    var pReporter = entity.Reporter;
                    var pSearchLink = entity.SearchLink;
                    if(!DocTools.IsNullOrEmpty(pSearchLink))
                        pSearchLink += " (Copy)";
                    var pStatus = entity.Status;
                    var pType = entity.Type;
                    var pWorkflow = entity.Workflow;
                    var copy = new DocEntityReconcileDocument(ssn)
                    {
                        Hash = Guid.NewGuid()
                                , ArticleId = pArticleId
                                , ArticleLink = pArticleLink
                                , Assignee = pAssignee
                                , Data = pData
                                , Description = pDescription
                                , Document = pDocument
                                , DueDate = pDueDate
                                , Matches = pMatches
                                , Reporter = pReporter
                                , SearchLink = pSearchLink
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


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<ReconcileDocument> Put(ReconcileDocumentBatch request)
        {
            return Patch(request);
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public ReconcileDocument Put(ReconcileDocument request)
        {
            return Patch(request);
        }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<ReconcileDocument> Patch(ReconcileDocumentBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<ReconcileDocument>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Patch(dto) as ReconcileDocument;
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
        public ReconcileDocument Patch(ReconcileDocument request)
        {
            if(true != (request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the ReconcileDocument to patch.");
            
            request.Select = request.Select ?? new List<string>();
            
            ReconcileDocument ret = null;
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
        public void Delete(ReconcileDocumentBatch request)
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
        public void Delete(ReconcileDocument request)
        {
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    if(!(request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, $"No Id provided for delete.");

                    var en = DocEntityReconcileDocument.Get(request?.Id);
                    if(null == en) throw new HttpError(HttpStatusCode.NotFound, $"No ReconcileDocument could be found for Id {request?.Id}.");
                    if(en.IsRemoved) return;
                
                    if(!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.DELETE))
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have DELETE permission for this route.");
                
                    en.Remove();

                    DocCacheClient.RemoveSearch(DocConstantModelName.RECONCILEDOCUMENT);
                    DocCacheClient.RemoveById(request.Id);
                });
            }
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public void Delete(ReconcileDocumentSearch request)
        {
            var matches = Get(request) as List<ReconcileDocument>;
            if(true != matches?.Any()) throw new HttpError(HttpStatusCode.NotFound, "No matches for request");
            matches.ForEach(match =>
            {
                Delete(match);
            });
        }




        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private ReconcileDocument GetReconcileDocument(ReconcileDocument request)
        {
            var id = request?.Id;
            ReconcileDocument ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetSelect<ReconcileDocument>(currentUser, "ReconcileDocument", request.Select);

            DocEntityReconcileDocument entity = null;
            if(id.HasValue)
            {
                entity = DocEntityReconcileDocument.Get(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No ReconcileDocument found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }

    }
}
