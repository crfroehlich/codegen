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
    public partial class WorkflowCommentService : DocServiceBase
    {
        public const string CACHE_KEY_PREFIX = DocEntityWorkflowComment.CACHE_KEY_PREFIX;
        private void _ExecSearch(WorkflowCommentSearch request, Action<IQueryable<DocEntityWorkflowComment>> callBack)
        {
            request = InitSearch(request);
            
            DocPermissionFactory.SetVisibleFields<WorkflowComment>(currentUser, "WorkflowComment", request.VisibleFields);

            var entities = Execute.SelectAll<DocEntityWorkflowComment>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new WorkflowCommentFullTextSearch(request);
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
        }
        
        public object Post(WorkflowCommentSearch request)
        {
            object tryRet = null;
            Execute.Run(s =>
            {
                using (var cancellableRequest = base.Request.CreateCancellableRequest())
                {
                    var requestCancel = new DocRequestCancellation(HttpContext.Current.Response, cancellableRequest);
                    try 
                    {
                        var ret = new List<WorkflowComment>();
                        _ExecSearch(request, (entities) => entities.ConvertFromEntityList<DocEntityWorkflowComment,WorkflowComment>(ret, Execute, requestCancel));
                        tryRet = ret;
                    }
                    catch(Exception) { throw; }
                    finally
                    {
                        requestCancel?.CloseRequest();
                    }
                }
            });
            return tryRet;
        }

        public object Get(WorkflowCommentSearch request)
        {
            object tryRet = null;
            Execute.Run(s =>
            {
                using (var cancellableRequest = base.Request.CreateCancellableRequest())
                {
                    var requestCancel = new DocRequestCancellation(HttpContext.Current.Response, cancellableRequest);
                    try 
                    {
                        var ret = new List<WorkflowComment>();
                        _ExecSearch(request, (entities) => entities.ConvertFromEntityList<DocEntityWorkflowComment,WorkflowComment>(ret, Execute, requestCancel));
                        tryRet = ret;
                    }
                    catch(Exception) { throw; }
                    finally
                    {
                        requestCancel?.CloseRequest();
                    }
                }
            });
            return tryRet;
        }

        public object Post(WorkflowCommentVersion request) 
        {
            return Get(request);
        }

        public object Get(WorkflowCommentVersion request) 
        {
            var ret = new List<Version>();
            Execute.Run(s =>
            {
                _ExecSearch(request, (entities) => 
                {
                    ret = entities.Select(e => new Version(e.Id, e.VersionNo)).ToList();
                });
            });
            return ret;
        }

        public object Get(WorkflowComment request)
        {
            object ret = null;
            
            if(!(request.Id > 0))
                throw new HttpError(HttpStatusCode.NotFound, "Valid Id required.");

            Execute.Run(s =>
            {
                DocPermissionFactory.SetVisibleFields<WorkflowComment>(currentUser, "WorkflowComment", request.VisibleFields);
                ret = GetWorkflowComment(request);
            });
            return ret;
        }

        private WorkflowComment _AssignValues(WorkflowComment dtoSource, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (dtoSource == null || dtoSource.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "WorkflowComment"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            dtoSource.VisibleFields = dtoSource.VisibleFields ?? new List<string>();

            WorkflowComment ret = null;
            dtoSource = _InitAssignValues(dtoSource, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && dtoSource.Id > 0) return dtoSource;
            
            //First, assign all the variables, do database lookups and conversions
            var pChildren = dtoSource.Children?.ToList();
            var pParent = (dtoSource.Parent?.Id > 0) ? DocEntityWorkflowComment.GetWorkflowComment(dtoSource.Parent.Id) : null;
            var pText = dtoSource.Text;
            var pUser = (dtoSource.User?.Id > 0) ? DocEntityUser.GetUser(dtoSource.User.Id) : null;
            var pWorkflow = (dtoSource.Workflow?.Id > 0) ? DocEntityWorkflow.GetWorkflow(dtoSource.Workflow.Id) : null;

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
                entity = DocEntityWorkflowComment.GetWorkflowComment(dtoSource.Id);
                if(null == entity)
                    throw new HttpError(HttpStatusCode.NotFound, $"No record");
            }

            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityWorkflowComment>(currentUser, dtoSource, pParent, permission, DocConstantModelName.WORKFLOWCOMMENT, nameof(dtoSource.Parent)))
            {
                if(DocPermissionFactory.IsRequested(dtoSource, pParent, entity.Parent, nameof(dtoSource.Parent)))
                    entity.Parent = pParent;
                if(DocPermissionFactory.IsRequested<DocEntityWorkflowComment>(dtoSource, pParent, nameof(dtoSource.Parent)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.Parent), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.Parent));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, dtoSource, pText, permission, DocConstantModelName.WORKFLOWCOMMENT, nameof(dtoSource.Text)))
            {
                if(DocPermissionFactory.IsRequested(dtoSource, pText, entity.Text, nameof(dtoSource.Text)))
                    entity.Text = pText;
                if(DocPermissionFactory.IsRequested<string>(dtoSource, pText, nameof(dtoSource.Text)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.Text), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.Text));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityUser>(currentUser, dtoSource, pUser, permission, DocConstantModelName.WORKFLOWCOMMENT, nameof(dtoSource.User)))
            {
                if(DocPermissionFactory.IsRequested(dtoSource, pUser, entity.User, nameof(dtoSource.User)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(dtoSource.User)} cannot be modified once set.");
                    entity.User = pUser;
                if(DocPermissionFactory.IsRequested<DocEntityUser>(dtoSource, pUser, nameof(dtoSource.User)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.User), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.User));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityWorkflow>(currentUser, dtoSource, pWorkflow, permission, DocConstantModelName.WORKFLOWCOMMENT, nameof(dtoSource.Workflow)))
            {
                if(DocPermissionFactory.IsRequested(dtoSource, pWorkflow, entity.Workflow, nameof(dtoSource.Workflow)))
                    entity.Workflow = pWorkflow;
                if(DocPermissionFactory.IsRequested<DocEntityWorkflow>(dtoSource, pWorkflow, nameof(dtoSource.Workflow)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.Workflow), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.Workflow));
                }
            }
            
            if (dtoSource.Locked) entity.Locked = dtoSource.Locked;

            entity.SaveChanges(permission);
            
            if (DocPermissionFactory.IsRequestedHasPermission<List<Reference>>(currentUser, dtoSource, pChildren, permission, DocConstantModelName.WORKFLOWCOMMENT, nameof(dtoSource.Children)))
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
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD, targetEntity: target, targetName: nameof(WorkflowComment), columnName: nameof(dtoSource.Children)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to add {nameof(dtoSource.Children)} to {nameof(WorkflowComment)}");
                        entity.Children.Add(target);
                    });
                    var toRemove = entity.Children.Where(e => requestedChildren.All(id => e.Id != id)).Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityWorkflowComment.GetWorkflowComment(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(WorkflowComment), columnName: nameof(dtoSource.Children)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(dtoSource.Children)} from {nameof(WorkflowComment)}");
                        entity.Children.Remove(target);
                    });
                }
                else
                {
                    var toRemove = entity.Children.Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityWorkflowComment.GetWorkflowComment(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(WorkflowComment), columnName: nameof(dtoSource.Children)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(dtoSource.Children)} from {nameof(WorkflowComment)}");
                        entity.Children.Remove(target);
                    });
                }
                if(DocPermissionFactory.IsRequested<List<Reference>>(dtoSource, pChildren, nameof(dtoSource.Children)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.Children), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.Children));
                }
            }
            DocPermissionFactory.SetVisibleFields<WorkflowComment>(currentUser, nameof(WorkflowComment), dtoSource.VisibleFields);
            ret = entity.ToDto();

            return ret;
        }
        public WorkflowComment Post(WorkflowComment dtoSource)
        {
            if(dtoSource == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            dtoSource.VisibleFields = dtoSource.VisibleFields ?? new List<string>();

            WorkflowComment ret = null;

            Execute.Run(ssn =>
            {
                if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "WorkflowComment")) 
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                ret = _AssignValues(dtoSource, DocConstantPermission.ADD, ssn);
            });

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

                copy.SaveChanges(DocConstantPermission.ADD);
                ret = copy.ToDto();
            });
            return ret;
        }


        public List<WorkflowComment> Put(WorkflowCommentBatch request)
        {
            return Patch(request);
        }

        public WorkflowComment Put(WorkflowComment dtoSource)
        {
            return Patch(dtoSource);
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

        public WorkflowComment Patch(WorkflowComment dtoSource)
        {
            if(true != (dtoSource?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the WorkflowComment to patch.");
            
            dtoSource.VisibleFields = dtoSource.VisibleFields ?? new List<string>();
            
            WorkflowComment ret = null;
            Execute.Run(ssn =>
            {
                ret = _AssignValues(dtoSource, DocConstantPermission.EDIT, ssn);
            });
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
            Execute.Run(ssn =>
            {
                var en = DocEntityWorkflowComment.GetWorkflowComment(request?.Id);

                if(null == en) throw new HttpError(HttpStatusCode.NotFound, $"No WorkflowComment could be found for Id {request?.Id}.");
                if(en.IsRemoved) return;
                
                if(!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.DELETE))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have DELETE permission for this route.");
                
                en.Remove();
            });
        }

        public void Delete(WorkflowCommentSearch request)
        {
            var matches = Get(request) as List<WorkflowComment>;
            if(true != matches?.Any()) throw new HttpError(HttpStatusCode.NotFound, "No matches for request");

            Execute.Run(ssn =>
            {
                matches.ForEach(match =>
                {
                    Delete(match);
                });
            });
        }
        public object Get(WorkflowCommentJunction request)
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
                case "workflowcomment":
                    ret = _GetWorkflowCommentWorkflowComment(request, skip, take);
                    break;
                }
            });
            return ret;
        }
        
        public object Get(WorkflowCommentJunctionVersion request)
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
                case "workflowcomment":
                    ret = GetWorkflowCommentWorkflowCommentVersion(request);
                    break;
                }
            });
            return ret;
        }
        

        private object _GetWorkflowCommentWorkflowComment(WorkflowCommentJunction request, int skip, int take)
        {
             DocPermissionFactory.SetVisibleFields<WorkflowComment>(currentUser, "WorkflowComment", request.VisibleFields);
             var en = DocEntityWorkflowComment.GetWorkflowComment(request.Id);
             if (!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.VIEW, targetName: DocConstantModelName.WORKFLOWCOMMENT, columnName: "Children", targetEntity: null))
                 throw new HttpError(HttpStatusCode.Forbidden, "You do not have View permission to relationships between WorkflowComment and WorkflowComment");
             return en?.Children.Take(take).Skip(skip).ConvertFromEntityList<DocEntityWorkflowComment,WorkflowComment>(new List<WorkflowComment>());
        }

        private List<Version> GetWorkflowCommentWorkflowCommentVersion(WorkflowCommentJunctionVersion request)
        { 
            if(!(request.Id > 0))
                throw new HttpError(HttpStatusCode.NotFound, "Valid Id required.");
            var ret = new List<Version>();
             Execute.Run((ssn) =>
             {
                var en = DocEntityWorkflowComment.GetWorkflowComment(request.Id);
                ret = en?.Children.Select(e => new Version(e.Id, e.VersionNo)).ToList();
             });
            return ret;
        }
        
        public object Post(WorkflowCommentJunction request)
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
                case "workflowcomment":
                    ret = _PostWorkflowCommentWorkflowComment(request);
                    break;
                }
            });
            return ret;
        }


        private object _PostWorkflowCommentWorkflowComment(WorkflowCommentJunction request)
        {
            var entity = DocEntityWorkflowComment.GetWorkflowComment(request.Id);

            if (null == entity) throw new HttpError(HttpStatusCode.NotFound, $"No WorkflowComment found for Id {request.Id}");

            if (!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.EDIT))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have Edit permission to WorkflowComment");

            foreach (var id in request.Ids)
            {
                var relationship = DocEntityWorkflowComment.GetWorkflowComment(id);
                if (!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD, targetEntity: relationship, targetName: DocConstantModelName.WORKFLOWCOMMENT, columnName: "Children")) 
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have Add permission to the Children property.");
                if (null == relationship) throw new HttpError(HttpStatusCode.NotFound, $"Cannot post to collection of WorkflowComment with objects that do not exist. No matching WorkflowComment could be found for {id}.");
                entity.Children.Add(relationship);
            }
            entity.SaveChanges();
            return entity.ToDto();
        }

        public object Delete(WorkflowCommentJunction request)
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
                case "workflowcomment":
                    ret = _DeleteWorkflowCommentWorkflowComment(request);
                    break;
                }
            });
            return ret;
        }


        private object _DeleteWorkflowCommentWorkflowComment(WorkflowCommentJunction request)
        {
            var entity = DocEntityWorkflowComment.GetWorkflowComment(request.Id);

            if (null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No WorkflowComment found for Id {request.Id}");
            if (!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.EDIT))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have Edit permission to WorkflowComment");
            foreach (var id in request.Ids)
            {
                var relationship = DocEntityWorkflowComment.GetWorkflowComment(id);
                if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: relationship, targetName: DocConstantModelName.WORKFLOWCOMMENT, columnName: "Children"))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have Edit permission to relationships between WorkflowComment and WorkflowComment");
                if(null != relationship && false == relationship.IsRemoved) entity.Children.Remove(relationship);
            }
            entity.SaveChanges();
            return entity.ToDto();
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

        public List<int> Any(WorkflowCommentIds request)
        {
            List<int> ret = null;
            if (currentUser.IsSuperAdmin)
            {
                Execute.Run(s => { ret = Execute.SelectAll<DocEntityWorkflowComment>().Select(d => d.Id).ToList(); });
            }
            else
            {
                throw new HttpError(HttpStatusCode.Forbidden);
            }
            return ret;
        }
    }
}