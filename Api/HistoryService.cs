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
    public partial class HistoryService : DocServiceBase
    {

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private IQueryable<DocEntityHistory> _ExecSearch(HistorySearch request, DocQuery query)
        {
            request = InitSearch<History, HistorySearch>(request);
            IQueryable<DocEntityHistory> entities = null;
            query.Run( session => 
            {
                entities = query.SelectAll<DocEntityHistory>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new HistoryFullTextSearch(request);
                    entities = GetFullTextSearch<DocEntityHistory,HistoryFullTextSearch>(fts, entities);
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
                if(true == request.Archived?.Any() && currentUser.HasProperty(DocConstantModelName.HISTORY, nameof(Reference.Archived), DocConstantPermission.VIEW))
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
                if(!DocTools.IsNullOrEmpty(request.App) && !DocTools.IsNullOrEmpty(request.App.Id))
                {
                    entities = entities.Where(en => en.App.Id == request.App.Id );
                }
                if(true == request.AppIds?.Any())
                {
                    entities = entities.Where(en => en.App.Id.In(request.AppIds));
                }
                if(!DocTools.IsNullOrEmpty(request.DocumentSet) && !DocTools.IsNullOrEmpty(request.DocumentSet.Id))
                {
                    entities = entities.Where(en => en.DocumentSet.Id == request.DocumentSet.Id );
                }
                if(true == request.DocumentSetIds?.Any())
                {
                    entities = entities.Where(en => en.DocumentSet.Id.In(request.DocumentSetIds));
                }
                if(!DocTools.IsNullOrEmpty(request.Impersonation) && !DocTools.IsNullOrEmpty(request.Impersonation.Id))
                {
                    entities = entities.Where(en => en.Impersonation.Id == request.Impersonation.Id );
                }
                if(true == request.ImpersonationIds?.Any())
                {
                    entities = entities.Where(en => en.Impersonation.Id.In(request.ImpersonationIds));
                }
                if(!DocTools.IsNullOrEmpty(request.Page) && !DocTools.IsNullOrEmpty(request.Page.Id))
                {
                    entities = entities.Where(en => en.Page.Id == request.Page.Id );
                }
                if(true == request.PageIds?.Any())
                {
                    entities = entities.Where(en => en.Page.Id.In(request.PageIds));
                }
                if(!DocTools.IsNullOrEmpty(request.URL))
                    entities = entities.Where(en => en.URL.Contains(request.URL));
                if(!DocTools.IsNullOrEmpty(request.URLs))
                    entities = entities.Where(en => en.URL.In(request.URLs));
                if(!DocTools.IsNullOrEmpty(request.User) && !DocTools.IsNullOrEmpty(request.User.Id))
                {
                    entities = entities.Where(en => en.User.Id == request.User.Id );
                }
                if(true == request.UserIds?.Any())
                {
                    entities = entities.Where(en => en.User.Id.In(request.UserIds));
                }
                if(!DocTools.IsNullOrEmpty(request.UserSession) && !DocTools.IsNullOrEmpty(request.UserSession.Id))
                {
                    entities = entities.Where(en => en.UserSession.Id == request.UserSession.Id );
                }
                if(true == request.UserSessionIds?.Any())
                {
                    entities = entities.Where(en => en.UserSession.Id.In(request.UserSessionIds));
                }
                if(!DocTools.IsNullOrEmpty(request.Workflow) && !DocTools.IsNullOrEmpty(request.Workflow.Id))
                {
                    entities = entities.Where(en => en.Workflow.Id == request.Workflow.Id );
                }
                if(true == request.WorkflowIds?.Any())
                {
                    entities = entities.Where(en => en.Workflow.Id.In(request.WorkflowIds));
                }

                entities = ApplyFilters<DocEntityHistory,HistorySearch>(request, entities);

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
        public object Post(HistorySearch request) => Get(request);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Get(HistorySearch request) => GetSearchResultWithCache<History,DocEntityHistory,HistorySearch>(DocConstantModelName.HISTORY, request, _ExecSearch);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Get(History request) => GetEntityWithCache<History>(DocConstantModelName.HISTORY, request, GetHistory);



        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private History _AssignValues(History request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "History"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.Select = request.Select ?? new List<string>();

            History ret = null;
            request = _InitAssignValues<History>(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            var cacheKey = GetApiCacheKey<History>(DocConstantModelName.HISTORY, nameof(History), request);
            
            //First, assign all the variables, do database lookups and conversions
            var pApp = (request.App?.Id > 0) ? DocEntityApp.Get(request.App.Id) : null;
            var pDocumentSet = (request.DocumentSet?.Id > 0) ? DocEntityDocumentSet.Get(request.DocumentSet.Id) : null;
            var pImpersonation = (request.Impersonation?.Id > 0) ? DocEntityImpersonation.Get(request.Impersonation.Id) : null;
            var pPage = (request.Page?.Id > 0) ? DocEntityPage.Get(request.Page.Id) : null;
            var pURL = request.URL;
            var pUser = (request.User?.Id > 0) ? DocEntityUser.Get(request.User.Id) : null;
            var pUserSession = (request.UserSession?.Id > 0) ? DocEntityUserSession.Get(request.UserSession.Id) : null;
            var pWorkflow = (request.Workflow?.Id > 0) ? DocEntityWorkflow.Get(request.Workflow.Id) : null;
            var pArchived = true == request.Archived;
            var pLocked = request.Locked;

            var entity = InitEntity<DocEntityHistory,History>(request, permission, session);

            if (AllowPatchValue<History, bool>(request, DocConstantModelName.HISTORY, pArchived, permission, nameof(request.Archived), pArchived != entity.Archived))
            {
                entity.Archived = pArchived;
            }
            if (AllowPatchValue<History, DocEntityApp>(request, DocConstantModelName.HISTORY, pApp, permission, nameof(request.App), pApp != entity.App))
            {
                entity.App = pApp;
            }
            if (AllowPatchValue<History, DocEntityDocumentSet>(request, DocConstantModelName.HISTORY, pDocumentSet, permission, nameof(request.DocumentSet), pDocumentSet != entity.DocumentSet))
            {
                entity.DocumentSet = pDocumentSet;
            }
            if (AllowPatchValue<History, DocEntityImpersonation>(request, DocConstantModelName.HISTORY, pImpersonation, permission, nameof(request.Impersonation), pImpersonation != entity.Impersonation))
            {
                entity.Impersonation = pImpersonation;
            }
            if (AllowPatchValue<History, DocEntityPage>(request, DocConstantModelName.HISTORY, pPage, permission, nameof(request.Page), pPage != entity.Page))
            {
                entity.Page = pPage;
            }
            if (AllowPatchValue<History, string>(request, DocConstantModelName.HISTORY, pURL, permission, nameof(request.URL), pURL != entity.URL))
            {
                entity.URL = pURL;
            }
            if (AllowPatchValue<History, DocEntityUser>(request, DocConstantModelName.HISTORY, pUser, permission, nameof(request.User), pUser != entity.User))
            {
                entity.User = pUser;
            }
            if (AllowPatchValue<History, DocEntityUserSession>(request, DocConstantModelName.HISTORY, pUserSession, permission, nameof(request.UserSession), pUserSession != entity.UserSession))
            {
                entity.UserSession = pUserSession;
            }
            if (AllowPatchValue<History, DocEntityWorkflow>(request, DocConstantModelName.HISTORY, pWorkflow, permission, nameof(request.Workflow), pWorkflow != entity.Workflow))
            {
                entity.Workflow = pWorkflow;
            }
            if (request.Locked && AllowPatchValue<History, bool>(request, DocConstantModelName.HISTORY, pArchived, permission, nameof(request.Locked), pLocked != entity.Locked))
            {
                entity.Archived = pArchived;
            }
            entity.SaveChanges(permission);

            var idsToInvalidate = new List<int>();

            if (idsToInvalidate.Any())
            {
                idsToInvalidate.Add(entity.Id);
                DocCacheClient.RemoveByEntityIds(idsToInvalidate);
                DocCacheClient.RemoveSearch(DocConstantModelName.HISTORY);
            }

            entity.SaveChanges(permission);
            DocPermissionFactory.SetSelect<History>(currentUser, nameof(History), request.Select);
            ret = entity.ToDto();

            var cacheExpires = DocResources.Metadata.GetCacheExpiration(DocConstantModelName.HISTORY);
            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.HISTORY, cacheExpires);

            return ret;
        }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public History Post(History request)
        {
            if(request == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            request.Select = request.Select ?? new List<string>();

            History ret = null;

            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "History")) 
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                    ret = _AssignValues(request, DocConstantPermission.ADD, ssn);
                });
            }
            return ret;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<History> Post(HistoryBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<History>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Post(dto) as History;
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
        public History Post(HistoryCopy request)
        {
            History ret = null;
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    var entity = DocEntityHistory.Get(request?.Id);
                    if(null == entity) throw new HttpError(HttpStatusCode.NoContent, "The COPY request did not succeed.");
                    if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD))
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                    var pApp = entity.App;
                    var pDocumentSet = entity.DocumentSet;
                    var pImpersonation = entity.Impersonation;
                    var pPage = entity.Page;
                    var pURL = entity.URL;
                    if(!DocTools.IsNullOrEmpty(pURL))
                        pURL += " (Copy)";
                    var pUser = entity.User;
                    var pUserSession = entity.UserSession;
                    var pWorkflow = entity.Workflow;
                    var copy = new DocEntityHistory(ssn)
                    {
                        Hash = Guid.NewGuid()
                                , App = pApp
                                , DocumentSet = pDocumentSet
                                , Impersonation = pImpersonation
                                , Page = pPage
                                , URL = pURL
                                , User = pUser
                                , UserSession = pUserSession
                                , Workflow = pWorkflow
                    };

                    copy.SaveChanges(DocConstantPermission.ADD);
                    ret = copy.ToDto();
                });
            }
            return ret;
        }







        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private History GetHistory(History request)
        {
            var id = request?.Id;
            History ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetSelect<History>(currentUser, "History", request.Select);

            DocEntityHistory entity = null;
            if(id.HasValue)
            {
                entity = DocEntityHistory.Get(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No History found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }

    }
}
