
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
    public partial class HistoryService : DocServiceBase
    {

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

        public object Post(HistorySearch request) => Get(request);

        public object Get(HistorySearch request) => GetSearchResultWithCache<History,DocEntityHistory,HistorySearch>(DocConstantModelName.HISTORY, request, _ExecSearch);

        public object Get(History request) => GetEntityWithCache<History>(DocConstantModelName.HISTORY, request, GetHistory);



        private History _AssignValues(History request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "History"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            History ret = null;
            request = _InitAssignValues<History>(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            var cacheKey = GetApiCacheKey<History>(DocConstantModelName.HISTORY, nameof(History), request);
            
            //First, assign all the variables, do database lookups and conversions
            var pApp = (request.App?.Id > 0) ? DocEntityApp.GetApp(request.App.Id) : null;
            var pDocumentSet = (request.DocumentSet?.Id > 0) ? DocEntityDocumentSet.GetDocumentSet(request.DocumentSet.Id) : null;
            var pImpersonation = (request.Impersonation?.Id > 0) ? DocEntityImpersonation.GetImpersonation(request.Impersonation.Id) : null;
            var pPage = (request.Page?.Id > 0) ? DocEntityPage.GetPage(request.Page.Id) : null;
            var pURL = request.URL;
            var pUser = (request.User?.Id > 0) ? DocEntityUser.GetUser(request.User.Id) : null;
            var pUserSession = (request.UserSession?.Id > 0) ? DocEntityUserSession.GetUserSession(request.UserSession.Id) : null;
            var pWorkflow = (request.Workflow?.Id > 0) ? DocEntityWorkflow.GetWorkflow(request.Workflow.Id) : null;

            DocEntityHistory entity = null;
            if(permission == DocConstantPermission.ADD)
            {
                var now = DateTime.UtcNow;
                entity = new DocEntityHistory(session)
                {
                    Created = now,
                    Updated = now
                };
            }
            else
            {
                entity = DocEntityHistory.GetHistory(request.Id);
                if(null == entity)
                    throw new HttpError(HttpStatusCode.NotFound, $"No record");
            }

            //Special case for Archived
            var pArchived = true == request.Archived;
            if (DocPermissionFactory.IsRequestedHasPermission<bool>(currentUser, request, pArchived, permission, DocConstantModelName.HISTORY, nameof(request.Archived)))
            {
                if(DocPermissionFactory.IsRequested(request, pArchived, entity.Archived, nameof(request.Archived)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.HISTORY, nameof(request.Archived)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Archived)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pArchived) && DocResources.Metadata.IsRequired(DocConstantModelName.HISTORY, nameof(request.Archived))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Archived)} requires a value.");
                    entity.Archived = pArchived;
                if(DocPermissionFactory.IsRequested<bool>(request, pArchived, nameof(request.Archived)) && !request.VisibleFields.Matches(nameof(request.Archived), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Archived));
                }
            }

            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityApp>(currentUser, request, pApp, permission, DocConstantModelName.HISTORY, nameof(request.App)))
            {
                if(DocPermissionFactory.IsRequested(request, pApp, entity.App, nameof(request.App)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.HISTORY, nameof(request.App)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.App)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pApp) && DocResources.Metadata.IsRequired(DocConstantModelName.HISTORY, nameof(request.App))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.App)} requires a value.");
                    entity.App = pApp;
                if(DocPermissionFactory.IsRequested<DocEntityApp>(request, pApp, nameof(request.App)) && !request.VisibleFields.Matches(nameof(request.App), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.App));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityDocumentSet>(currentUser, request, pDocumentSet, permission, DocConstantModelName.HISTORY, nameof(request.DocumentSet)))
            {
                if(DocPermissionFactory.IsRequested(request, pDocumentSet, entity.DocumentSet, nameof(request.DocumentSet)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.HISTORY, nameof(request.DocumentSet)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.DocumentSet)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pDocumentSet) && DocResources.Metadata.IsRequired(DocConstantModelName.HISTORY, nameof(request.DocumentSet))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.DocumentSet)} requires a value.");
                    entity.DocumentSet = pDocumentSet;
                if(DocPermissionFactory.IsRequested<DocEntityDocumentSet>(request, pDocumentSet, nameof(request.DocumentSet)) && !request.VisibleFields.Matches(nameof(request.DocumentSet), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.DocumentSet));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityImpersonation>(currentUser, request, pImpersonation, permission, DocConstantModelName.HISTORY, nameof(request.Impersonation)))
            {
                if(DocPermissionFactory.IsRequested(request, pImpersonation, entity.Impersonation, nameof(request.Impersonation)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.HISTORY, nameof(request.Impersonation)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Impersonation)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pImpersonation) && DocResources.Metadata.IsRequired(DocConstantModelName.HISTORY, nameof(request.Impersonation))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Impersonation)} requires a value.");
                    entity.Impersonation = pImpersonation;
                if(DocPermissionFactory.IsRequested<DocEntityImpersonation>(request, pImpersonation, nameof(request.Impersonation)) && !request.VisibleFields.Matches(nameof(request.Impersonation), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Impersonation));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityPage>(currentUser, request, pPage, permission, DocConstantModelName.HISTORY, nameof(request.Page)))
            {
                if(DocPermissionFactory.IsRequested(request, pPage, entity.Page, nameof(request.Page)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.HISTORY, nameof(request.Page)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Page)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pPage) && DocResources.Metadata.IsRequired(DocConstantModelName.HISTORY, nameof(request.Page))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Page)} requires a value.");
                    entity.Page = pPage;
                if(DocPermissionFactory.IsRequested<DocEntityPage>(request, pPage, nameof(request.Page)) && !request.VisibleFields.Matches(nameof(request.Page), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Page));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pURL, permission, DocConstantModelName.HISTORY, nameof(request.URL)))
            {
                if(DocPermissionFactory.IsRequested(request, pURL, entity.URL, nameof(request.URL)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.HISTORY, nameof(request.URL)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.URL)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pURL) && DocResources.Metadata.IsRequired(DocConstantModelName.HISTORY, nameof(request.URL))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.URL)} requires a value.");
                    entity.URL = pURL;
                if(DocPermissionFactory.IsRequested<string>(request, pURL, nameof(request.URL)) && !request.VisibleFields.Matches(nameof(request.URL), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.URL));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityUser>(currentUser, request, pUser, permission, DocConstantModelName.HISTORY, nameof(request.User)))
            {
                if(DocPermissionFactory.IsRequested(request, pUser, entity.User, nameof(request.User)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.HISTORY, nameof(request.User)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.User)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pUser) && DocResources.Metadata.IsRequired(DocConstantModelName.HISTORY, nameof(request.User))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.User)} requires a value.");
                    entity.User = pUser;
                if(DocPermissionFactory.IsRequested<DocEntityUser>(request, pUser, nameof(request.User)) && !request.VisibleFields.Matches(nameof(request.User), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.User));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityUserSession>(currentUser, request, pUserSession, permission, DocConstantModelName.HISTORY, nameof(request.UserSession)))
            {
                if(DocPermissionFactory.IsRequested(request, pUserSession, entity.UserSession, nameof(request.UserSession)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.HISTORY, nameof(request.UserSession)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.UserSession)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pUserSession) && DocResources.Metadata.IsRequired(DocConstantModelName.HISTORY, nameof(request.UserSession))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.UserSession)} requires a value.");
                    entity.UserSession = pUserSession;
                if(DocPermissionFactory.IsRequested<DocEntityUserSession>(request, pUserSession, nameof(request.UserSession)) && !request.VisibleFields.Matches(nameof(request.UserSession), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.UserSession));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityWorkflow>(currentUser, request, pWorkflow, permission, DocConstantModelName.HISTORY, nameof(request.Workflow)))
            {
                if(DocPermissionFactory.IsRequested(request, pWorkflow, entity.Workflow, nameof(request.Workflow)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.HISTORY, nameof(request.Workflow)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Workflow)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pWorkflow) && DocResources.Metadata.IsRequired(DocConstantModelName.HISTORY, nameof(request.Workflow))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Workflow)} requires a value.");
                    entity.Workflow = pWorkflow;
                if(DocPermissionFactory.IsRequested<DocEntityWorkflow>(request, pWorkflow, nameof(request.Workflow)) && !request.VisibleFields.Matches(nameof(request.Workflow), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Workflow));
                }
            }

            if (request.Locked) entity.Locked = request.Locked;

            entity.SaveChanges(permission);


            DocPermissionFactory.SetVisibleFields<History>(currentUser, nameof(History), request.VisibleFields);
            ret = entity.ToDto();

            var cacheExpires = DocResources.Metadata.GetCacheExpiration(DocConstantModelName.HISTORY);
            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.HISTORY, cacheExpires);

            return ret;
        }


        public History Post(History request)
        {
            if(request == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

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

        public History Post(HistoryCopy request)
        {
            History ret = null;
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    var entity = DocEntityHistory.GetHistory(request?.Id);
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
                    #region Custom Before copyHistory
                    #endregion Custom Before copyHistory
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

                    #region Custom After copyHistory
                    #endregion Custom After copyHistory
                    copy.SaveChanges(DocConstantPermission.ADD);
                    ret = copy.ToDto();
                });
            }
            return ret;
        }







        private History GetHistory(History request)
        {
            var id = request?.Id;
            History ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetVisibleFields<History>(currentUser, "History", request.VisibleFields);

            DocEntityHistory entity = null;
            if(id.HasValue)
            {
                entity = DocEntityHistory.GetHistory(id.Value);
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
