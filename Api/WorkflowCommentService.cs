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
    public partial class WorkflowCommentService : DocServiceBase
    {
        private IQueryable<DocEntityWorkflowComment> _ExecSearch(WorkflowCommentSearch request, DocQuery query)
        {
            request = InitSearch<WorkflowComment, WorkflowCommentSearch>(request);
            IQueryable<DocEntityWorkflowComment> entities = null;
			query.Run( session => 
			{
				entities = query.SelectAll<DocEntityWorkflowComment>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new WorkflowCommentFullTextSearch(request);
                    entities = GetFullTextSearch<DocEntityWorkflowComment,WorkflowCommentFullTextSearch>(fts, entities);
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
                if(true == request.Archived?.Any() && currentUser.HasProperty(DocConstantModelName.WORKFLOWCOMMENT, nameof(Reference.Archived), DocConstantPermission.VIEW))
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

                if(true == request.ChildrenIds?.Any())
                {
                    entities = entities.Where(en => en.Children.Any(r => r.Id.In(request.ChildrenIds)));
                }
                if(!DocTools.IsNullOrEmpty(request.Parent) && !DocTools.IsNullOrEmpty(request.Parent.Id))
                {
                    entities = entities.Where(en => en.Parent.Id == request.Parent.Id );
                }
                if(true == request.ParentIds?.Any())
                {
                    entities = entities.Where(en => en.Parent.Id.In(request.ParentIds));
                }
                if(!DocTools.IsNullOrEmpty(request.Text))
                    entities = entities.Where(en => en.Text.Contains(request.Text));
                if(!DocTools.IsNullOrEmpty(request.User) && !DocTools.IsNullOrEmpty(request.User.Id))
                {
                    entities = entities.Where(en => en.User.Id == request.User.Id );
                }
                if(true == request.UserIds?.Any())
                {
                    entities = entities.Where(en => en.User.Id.In(request.UserIds));
                }
                if(!DocTools.IsNullOrEmpty(request.Workflow) && !DocTools.IsNullOrEmpty(request.Workflow.Id))
                {
                    entities = entities.Where(en => en.Workflow.Id == request.Workflow.Id );
                }
                if(true == request.WorkflowIds?.Any())
                {
                    entities = entities.Where(en => en.Workflow.Id.In(request.WorkflowIds));
                }

                entities = ApplyFilters<DocEntityWorkflowComment,WorkflowCommentSearch>(request, entities);

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

        public object Post(WorkflowCommentSearch request) => Get(request);

        public object Get(WorkflowCommentSearch request) => GetSearchResultWithCache<WorkflowComment,DocEntityWorkflowComment,WorkflowCommentSearch>(DocConstantModelName.WORKFLOWCOMMENT, request, _ExecSearch);

        public object Get(WorkflowComment request) => GetEntityWithCache<WorkflowComment>(DocConstantModelName.WORKFLOWCOMMENT, request, GetWorkflowComment);

        private WorkflowComment _AssignValues(WorkflowComment request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "WorkflowComment"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            WorkflowComment ret = null;
            request = _InitAssignValues<WorkflowComment>(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            var cacheKey = GetApiCacheKey<WorkflowComment>(DocConstantModelName.WORKFLOWCOMMENT, nameof(WorkflowComment), request);
            
            //First, assign all the variables, do database lookups and conversions
            var pChildren = request.Children?.ToList();
            var pParent = (request.Parent?.Id > 0) ? DocEntityWorkflowComment.GetWorkflowComment(request.Parent.Id) : null;
            var pText = request.Text;
            var pUser = (request.User?.Id > 0) ? DocEntityUser.GetUser(request.User.Id) : null;
            var pWorkflow = (request.Workflow?.Id > 0) ? DocEntityWorkflow.GetWorkflow(request.Workflow.Id) : null;

            DocEntityWorkflowComment entity = null;
            if(permission == DocConstantPermission.ADD)
            {
                var now = DateTime.UtcNow;
                entity = new DocEntityWorkflowComment(session)
                {
                    Created = now,
                    Updated = now
                };
            }
            else
            {
                entity = DocEntityWorkflowComment.GetWorkflowComment(request.Id);
                if(null == entity)
                    throw new HttpError(HttpStatusCode.NotFound, $"No record");
            }

            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityWorkflowComment>(currentUser, request, pParent, permission, DocConstantModelName.WORKFLOWCOMMENT, nameof(request.Parent)))
            {
                if(DocPermissionFactory.IsRequested(request, pParent, entity.Parent, nameof(request.Parent)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.WORKFLOWCOMMENT, nameof(request.Parent)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Parent)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pParent) && DocResources.Metadata.IsRequired(DocConstantModelName.WORKFLOWCOMMENT, nameof(request.Parent))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Parent)} requires a value.");
                    entity.Parent = pParent;
                if(DocPermissionFactory.IsRequested<DocEntityWorkflowComment>(request, pParent, nameof(request.Parent)) && !request.VisibleFields.Matches(nameof(request.Parent), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Parent));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pText, permission, DocConstantModelName.WORKFLOWCOMMENT, nameof(request.Text)))
            {
                if(DocPermissionFactory.IsRequested(request, pText, entity.Text, nameof(request.Text)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.WORKFLOWCOMMENT, nameof(request.Text)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Text)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pText) && DocResources.Metadata.IsRequired(DocConstantModelName.WORKFLOWCOMMENT, nameof(request.Text))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Text)} requires a value.");
                    entity.Text = pText;
                if(DocPermissionFactory.IsRequested<string>(request, pText, nameof(request.Text)) && !request.VisibleFields.Matches(nameof(request.Text), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Text));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityUser>(currentUser, request, pUser, permission, DocConstantModelName.WORKFLOWCOMMENT, nameof(request.User)))
            {
                if(DocPermissionFactory.IsRequested(request, pUser, entity.User, nameof(request.User)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.WORKFLOWCOMMENT, nameof(request.User)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.User)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pUser) && DocResources.Metadata.IsRequired(DocConstantModelName.WORKFLOWCOMMENT, nameof(request.User))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.User)} requires a value.");
                    entity.User = pUser;
                if(DocPermissionFactory.IsRequested<DocEntityUser>(request, pUser, nameof(request.User)) && !request.VisibleFields.Matches(nameof(request.User), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.User));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityWorkflow>(currentUser, request, pWorkflow, permission, DocConstantModelName.WORKFLOWCOMMENT, nameof(request.Workflow)))
            {
                if(DocPermissionFactory.IsRequested(request, pWorkflow, entity.Workflow, nameof(request.Workflow)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.WORKFLOWCOMMENT, nameof(request.Workflow)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Workflow)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pWorkflow) && DocResources.Metadata.IsRequired(DocConstantModelName.WORKFLOWCOMMENT, nameof(request.Workflow))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Workflow)} requires a value.");
                    entity.Workflow = pWorkflow;
                if(DocPermissionFactory.IsRequested<DocEntityWorkflow>(request, pWorkflow, nameof(request.Workflow)) && !request.VisibleFields.Matches(nameof(request.Workflow), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Workflow));
                }
            }

            if (request.Locked) entity.Locked = request.Locked;

            entity.SaveChanges(permission);

            if (DocPermissionFactory.IsRequestedHasPermission<List<Reference>>(currentUser, request, pChildren, permission, DocConstantModelName.WORKFLOWCOMMENT, nameof(request.Children)))
            {
                if (true == pChildren?.Any() )
                {
                    var requestedChildren = pChildren.Select(p => p.Id).Distinct().ToList();
                    var existsChildren = Execute.SelectAll<DocEntityWorkflowComment>().Where(e => e.Id.In(requestedChildren)).Select( e => e.Id ).ToList();
                    if (existsChildren.Count != requestedChildren.Count)
                    {
                        var nonExists = requestedChildren.Where(id => existsChildren.All(eId => eId != id));
                        throw new HttpError(HttpStatusCode.NotFound, $"Cannot patch collection Children with objects that do not exist. No matching Children(s) could be found for Ids: {nonExists.ToDelimitedString()}.");
                    }
                    var toAdd = requestedChildren.Where(id => entity.Children.All(e => e.Id != id)).ToList(); 
                    toAdd?.ForEach(id =>
                    {
                        var target = DocEntityWorkflowComment.GetWorkflowComment(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD, targetEntity: target, targetName: nameof(WorkflowComment), columnName: nameof(request.Children)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to add {nameof(request.Children)} to {nameof(WorkflowComment)}");
                        entity.Children.Add(target);
                    });
                    var toRemove = entity.Children.Where(e => requestedChildren.All(id => e.Id != id)).Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityWorkflowComment.GetWorkflowComment(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(WorkflowComment), columnName: nameof(request.Children)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Children)} from {nameof(WorkflowComment)}");
                        entity.Children.Remove(target);
                    });
                }
                else
                {
                    var toRemove = entity.Children.Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityWorkflowComment.GetWorkflowComment(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(WorkflowComment), columnName: nameof(request.Children)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Children)} from {nameof(WorkflowComment)}");
                        entity.Children.Remove(target);
                    });
                }
                if(DocPermissionFactory.IsRequested<List<Reference>>(request, pChildren, nameof(request.Children)) && !request.VisibleFields.Matches(nameof(request.Children), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Children));
                }
            }
            DocPermissionFactory.SetVisibleFields<WorkflowComment>(currentUser, nameof(WorkflowComment), request.VisibleFields);
            ret = entity.ToDto();

            var cacheExpires = DocResources.Metadata.GetCacheExpiration(DocConstantModelName.WORKFLOWCOMMENT);
            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.WORKFLOWCOMMENT, cacheExpires);

            return ret;
        }
        public WorkflowComment Post(WorkflowComment request)
        {
            if(request == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            WorkflowComment ret = null;

			using(Execute)
			{
				Execute.Run(ssn =>
				{
					if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "WorkflowComment")) 
						throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

					ret = _AssignValues(request, DocConstantPermission.ADD, ssn);
				});
			}
            return ret;
        }
   
        public List<WorkflowComment> Post(WorkflowCommentBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<WorkflowComment>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Post(dto) as WorkflowComment;
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

        public WorkflowComment Post(WorkflowCommentCopy request)
        {
            WorkflowComment ret = null;
            using(Execute)
			{
				Execute.Run(ssn =>
				{
					var entity = DocEntityWorkflowComment.GetWorkflowComment(request?.Id);
					if(null == entity) throw new HttpError(HttpStatusCode.NoContent, "The COPY request did not succeed.");
					if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD))
						throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                    var pChildren = entity.Children.ToList();
                    var pParent = entity.Parent;
                    var pText = entity.Text;
                    var pUser = entity.User;
                    var pWorkflow = entity.Workflow;
					#region Custom Before copyWorkflowComment
					#endregion Custom Before copyWorkflowComment
					var copy = new DocEntityWorkflowComment(ssn)
					{
						Hash = Guid.NewGuid()
                                , Parent = pParent
                                , Text = pText
                                , User = pUser
                                , Workflow = pWorkflow
					};
                            foreach(var item in pChildren)
                            {
                                entity.Children.Add(item);
                            }

					#region Custom After copyWorkflowComment
					#endregion Custom After copyWorkflowComment
					copy.SaveChanges(DocConstantPermission.ADD);
					ret = copy.ToDto();
				});
			}
            return ret;
        }

        public List<WorkflowComment> Put(WorkflowCommentBatch request)
        {
            return Patch(request);
        }

        public WorkflowComment Put(WorkflowComment request)
        {
            return Patch(request);
        }
        public List<WorkflowComment> Patch(WorkflowCommentBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<WorkflowComment>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Patch(dto) as WorkflowComment;
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

        public WorkflowComment Patch(WorkflowComment request)
        {
            if(true != (request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the WorkflowComment to patch.");
            
            request.VisibleFields = request.VisibleFields ?? new List<string>();
            
            WorkflowComment ret = null;
            using(Execute)
			{
				Execute.Run(ssn =>
				{
					ret = _AssignValues(request, DocConstantPermission.EDIT, ssn);
				});
			}
            return ret;
        }
        public void Delete(WorkflowCommentBatch request)
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

        public void Delete(WorkflowComment request)
        {
            using(Execute)
			{
				Execute.Run(ssn =>
				{
					if(!(request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, $"No Id provided for delete.");

					DocCacheClient.RemoveSearch(DocConstantModelName.WORKFLOWCOMMENT);
					DocCacheClient.RemoveById(request.Id);
					var en = DocEntityWorkflowComment.GetWorkflowComment(request?.Id);

					if(null == en) throw new HttpError(HttpStatusCode.NotFound, $"No WorkflowComment could be found for Id {request?.Id}.");
					if(en.IsRemoved) return;
                
					if(!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.DELETE))
						throw new HttpError(HttpStatusCode.Forbidden, "You do not have DELETE permission for this route.");
                
					en.Remove();
				});
			}
        }

        public void Delete(WorkflowCommentSearch request)
        {
            var matches = Get(request) as List<WorkflowComment>;
            if(true != matches?.Any()) throw new HttpError(HttpStatusCode.NotFound, "No matches for request");
			matches.ForEach(match =>
			{
				Delete(match);
			});
        }
        public object Get(WorkflowCommentJunction request)
        {
			switch(request.Junction.ToLower().TrimAndPruneSpaces())
			{
                    case "workflowcomment":
                        return GetJunctionSearchResult<WorkflowComment, DocEntityWorkflowComment, DocEntityWorkflowComment, WorkflowComment, WorkflowCommentSearch>((int)request.Id, DocConstantModelName.WORKFLOWCOMMENT, "Children", request, (ss) => HostContext.ResolveService<WorkflowCommentService>(Request)?.Get(ss));
				default:
					throw new HttpError(HttpStatusCode.NotFound, $"Route for workflowcomment/{request.Id}/{request.Junction} was not found");
			}
		}
        public object Post(WorkflowCommentJunction request)
        {
			switch(request.Junction.ToLower().TrimAndPruneSpaces())
			{
                    case "workflowcomment":
                        return AddJunction<WorkflowComment, DocEntityWorkflowComment, DocEntityWorkflowComment, WorkflowComment, WorkflowCommentSearch>((int)request.Id, DocConstantModelName.WORKFLOWCOMMENT, "Children", request);
				default:
					throw new HttpError(HttpStatusCode.NotFound, $"Route for workflowcomment/{request.Id}/{request.Junction} was not found");
			}
		}

        public object Delete(WorkflowCommentJunction request)
        {    
			switch(request.Junction.ToLower().TrimAndPruneSpaces())
			{
                    case "workflowcomment":
                        return RemoveJunction<WorkflowComment, DocEntityWorkflowComment, DocEntityWorkflowComment, WorkflowComment, WorkflowCommentSearch>((int)request.Id, DocConstantModelName.WORKFLOWCOMMENT, "Children", request);
				default:
					throw new HttpError(HttpStatusCode.NotFound, $"Route for workflowcomment/{request.Id}/{request.Junction} was not found");
			}
		}
        private WorkflowComment GetWorkflowComment(WorkflowComment request)
        {
            var id = request?.Id;
            WorkflowComment ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetVisibleFields<WorkflowComment>(currentUser, "WorkflowComment", request.VisibleFields);

            DocEntityWorkflowComment entity = null;
            if(id.HasValue)
            {
                entity = DocEntityWorkflowComment.GetWorkflowComment(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No WorkflowComment found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }
    }
}
