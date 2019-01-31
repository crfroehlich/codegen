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
    public partial class TagService : DocServiceBase
    {
        private IQueryable<DocEntityTag> _ExecSearch(TagSearch request)
        {
            request = InitSearch<Tag, TagSearch>(request);
            IQueryable<DocEntityTag> entities = null;
            Execute.Run( session => 
            {
                entities = Execute.SelectAll<DocEntityTag>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new TagFullTextSearch(request);
                    entities = GetFullTextSearch<DocEntityTag,TagFullTextSearch>(fts, entities);
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

                if(!DocTools.IsNullOrEmpty(request.Name))
                    entities = entities.Where(en => en.Name.Contains(request.Name));
                        if(true == request.WorkflowsIds?.Any())
                        {
                            entities = entities.Where(en => en.Workflows.Any(r => r.Id.In(request.WorkflowsIds)));
                        }

                entities = ApplyFilters<DocEntityTag,TagSearch>(request, entities);

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

        public object Post(TagSearch request) => Get(request);

        public object Get(TagSearch request) => GetSearchResultWithCache<Tag,DocEntityTag,TagSearch>(DocConstantModelName.TAG, request, _ExecSearch);

        public object Get(Tag request) => GetEntityWithCache<Tag>(DocConstantModelName.TAG, request, GetTag);
        private Tag _AssignValues(Tag request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "Tag"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            Tag ret = null;
            request = _InitAssignValues<Tag>(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            var cacheKey = GetApiCacheKey<Tag>(DocConstantModelName.TAG, nameof(Tag), request);
            
            //First, assign all the variables, do database lookups and conversions
            var pName = request.Name;
            var pWorkflows = request.Workflows?.ToList();

            DocEntityTag entity = null;
            if(permission == DocConstantPermission.ADD)
            {
                var now = DateTime.UtcNow;
                entity = new DocEntityTag(session)
                {
                    Created = now,
                    Updated = now
                };
            }
            else
            {
                entity = DocEntityTag.GetTag(request.Id);
                if(null == entity)
                    throw new HttpError(HttpStatusCode.NotFound, $"No record");
            }

            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pName, permission, DocConstantModelName.TAG, nameof(request.Name)))
            {
                if(DocPermissionFactory.IsRequested(request, pName, entity.Name, nameof(request.Name)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Name)} cannot be modified once set.");
                    entity.Name = pName;
                if(DocPermissionFactory.IsRequested<string>(request, pName, nameof(request.Name)) && !request.VisibleFields.Matches(nameof(request.Name), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Name));
                }
            }
            
            if (request.Locked) entity.Locked = request.Locked;

            entity.SaveChanges(permission);
            
            if (DocPermissionFactory.IsRequestedHasPermission<List<Reference>>(currentUser, request, pWorkflows, permission, DocConstantModelName.TAG, nameof(request.Workflows)))
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
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD, targetEntity: target, targetName: nameof(Tag), columnName: nameof(request.Workflows)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to add {nameof(request.Workflows)} to {nameof(Tag)}");
                        entity.Workflows.Add(target);
                    });
                    var toRemove = entity.Workflows.Where(e => requestedWorkflows.All(id => e.Id != id)).Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityWorkflow.GetWorkflow(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(Tag), columnName: nameof(request.Workflows)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Workflows)} from {nameof(Tag)}");
                        entity.Workflows.Remove(target);
                    });
                }
                else
                {
                    var toRemove = entity.Workflows.Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityWorkflow.GetWorkflow(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(Tag), columnName: nameof(request.Workflows)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Workflows)} from {nameof(Tag)}");
                        entity.Workflows.Remove(target);
                    });
                }
                if(DocPermissionFactory.IsRequested<List<Reference>>(request, pWorkflows, nameof(request.Workflows)) && !request.VisibleFields.Matches(nameof(request.Workflows), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Workflows));
                }
            }
            DocPermissionFactory.SetVisibleFields<Tag>(currentUser, nameof(Tag), request.VisibleFields);
            ret = entity.ToDto();

            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.TAG);

            return ret;
        }
        public Tag Post(Tag request)
        {
            if(request == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            Tag ret = null;

            Execute.Run(ssn =>
            {
                if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "Tag")) 
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                ret = _AssignValues(request, DocConstantPermission.ADD, ssn);
            });

            return ret;
        }
   
        public List<Tag> Post(TagBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<Tag>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Post(dto) as Tag;
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

        public Tag Post(TagCopy request)
        {
            Tag ret = null;
            Execute.Run(ssn =>
            {
                var entity = DocEntityTag.GetTag(request?.Id);
                if(null == entity) throw new HttpError(HttpStatusCode.NoContent, "The COPY request did not succeed.");
                if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");
                
                    var pName = entity.Name;
                    if(!DocTools.IsNullOrEmpty(pName))
                        pName += " (Copy)";
                    var pWorkflows = entity.Workflows.ToList();
                #region Custom Before copyTag
                #endregion Custom Before copyTag
                var copy = new DocEntityTag(ssn)
                {
                    Hash = Guid.NewGuid()
                                , Name = pName
                };
                            foreach(var item in pWorkflows)
                            {
                                entity.Workflows.Add(item);
                            }

                #region Custom After copyTag
                #endregion Custom After copyTag
                copy.SaveChanges(DocConstantPermission.ADD);
                ret = copy.ToDto();
            });
            return ret;
        }



        public void Delete(TagBatch request)
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

        public void Delete(Tag request)
        {
            Execute.Run(ssn =>
            {
                if(!(request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, $"No Id provided for delete.");

                DocCacheClient.RemoveSearch(DocConstantModelName.TAG);
                DocCacheClient.RemoveById(request.Id);
                var en = DocEntityTag.GetTag(request?.Id);

                if(null == en) throw new HttpError(HttpStatusCode.NotFound, $"No Tag could be found for Id {request?.Id}.");
                if(en.IsRemoved) return;
                
                if(!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.DELETE))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have DELETE permission for this route.");
                
                en.Remove();
            });
        }

        public void Delete(TagSearch request)
        {
            var matches = Get(request) as List<Tag>;
            if(true != matches?.Any()) throw new HttpError(HttpStatusCode.NotFound, "No matches for request");

            Execute.Run(ssn =>
            {
                matches.ForEach(match =>
                {
                    Delete(match);
                });
            });
        }
        public object Get(TagJunction request)
        {
            if(!(request.Id > 0))
                throw new HttpError(HttpStatusCode.NotFound, "Valid Id required.");
            object ret = null;
            Execute.Run( s => 
            {
                switch(request.Junction)
                {
                case "workflow":
                    ret =     GetJunctionSearchResult<Tag, DocEntityTag, DocEntityWorkflow, Workflow, WorkflowSearch>((int)request.Id, DocConstantModelName.WORKFLOW, "Workflows", request,
                            (ss) =>
                            { 
                                var service = HostContext.ResolveService<WorkflowService>(Request);
                                return service.Get(ss);
                            });
                    break;
                    default:
                        throw new HttpError(HttpStatusCode.NotFound, $"Route for tag/{request.Id}/{request.Junction} was not found");
                }
            });
            return ret;
        }


        public object Post(TagJunction request)
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
                switch(request.Junction)
                {
                case "workflow":
                    ret = _PostTagWorkflow(request);
                    break;
                    default:
                        throw new HttpError(HttpStatusCode.NotFound, $"Route for tag/{request.Id}/{request.Junction} was not found");
                }
            });
            return ret;
        }


        private object _PostTagWorkflow(TagJunction request)
        {
            var entity = DocEntityTag.GetTag(request.Id);

            if (null == entity) throw new HttpError(HttpStatusCode.NotFound, $"No Tag found for Id {request.Id}");

            if (!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.EDIT))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have Edit permission to Tag");

            foreach (var id in request.Ids)
            {
                var relationship = DocEntityWorkflow.GetWorkflow(id);
                if (!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD, targetEntity: relationship, targetName: DocConstantModelName.WORKFLOW, columnName: "Workflows")) 
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have Add permission to the Workflows property.");
                if (null == relationship) throw new HttpError(HttpStatusCode.NotFound, $"Cannot post to collection of Tag with objects that do not exist. No matching Workflow could be found for {id}.");
                entity.Workflows.Add(relationship);
            }
            entity.SaveChanges();
            return entity.ToDto();
        }

        public object Delete(TagJunction request)
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
                switch(request.Junction)
                {
                case "workflow":
                    ret = _DeleteTagWorkflow(request);
                    break;
                    default:
                        throw new HttpError(HttpStatusCode.NotFound, $"Route for tag/{request.Id}/{request.Junction} was not found");
                }
            });
            return ret;
        }


        private object _DeleteTagWorkflow(TagJunction request)
        {
            var entity = DocEntityTag.GetTag(request.Id);

            if (null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No Tag found for Id {request.Id}");
            if (!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.EDIT))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have Edit permission to Tag");
            foreach (var id in request.Ids)
            {
                var relationship = DocEntityWorkflow.GetWorkflow(id);
                if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: relationship, targetName: DocConstantModelName.WORKFLOW, columnName: "Workflows"))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have Edit permission to relationships between Tag and Workflow");
                if(null != relationship && false == relationship.IsRemoved) entity.Workflows.Remove(relationship);
            }
            entity.SaveChanges();
            return entity.ToDto();
        }

        private Tag GetTag(Tag request)
        {
            var id = request?.Id;
            Tag ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetVisibleFields<Tag>(currentUser, "Tag", request.VisibleFields);

            DocEntityTag entity = null;
            if(id.HasValue)
            {
                entity = DocEntityTag.GetTag(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No Tag found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }

        public List<int> Any(TagIds request)
        {
            List<int> ret = null;
            if (currentUser.IsSuperAdmin)
            {
                Execute.Run(s => { ret = Execute.SelectAll<DocEntityTag>().Select(d => d.Id).ToList(); });
            }
            else
            {
                throw new HttpError(HttpStatusCode.Forbidden);
            }

            return ret;
        }
    }
}