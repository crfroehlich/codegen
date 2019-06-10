
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
    public partial class RatingService : DocServiceBase
    {

        private IQueryable<DocEntityRating> _ExecSearch(RatingSearch request, DocQuery query)
        {
            request = InitSearch<Rating, RatingSearch>(request);
            IQueryable<DocEntityRating> entities = null;
            query.Run( session => 
            {
                entities = query.SelectAll<DocEntityRating>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new RatingFullTextSearch(request);
                    entities = GetFullTextSearch<DocEntityRating,RatingFullTextSearch>(fts, entities);
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
                if(true == request.Archived?.Any() && currentUser.HasProperty(DocConstantModelName.RATING, nameof(Reference.Archived), DocConstantPermission.VIEW))
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
                if(!DocTools.IsNullOrEmpty(request.Document) && !DocTools.IsNullOrEmpty(request.Document.Id))
                {
                    entities = entities.Where(en => en.Document.Id == request.Document.Id );
                }
                if(true == request.DocumentIds?.Any())
                {
                    entities = entities.Where(en => en.Document.Id.In(request.DocumentIds));
                }
                if(request.Rating.HasValue)
                    entities = entities.Where(en => request.Rating.Value == en.Rating);
                if(!DocTools.IsNullOrEmpty(request.Ratings))
                    entities = entities.Where(en => en.Rating.In(request.Ratings));
                if(request.ReasonRejected.HasValue)
                    entities = entities.Where(en => request.ReasonRejected.Value == en.ReasonRejected);
                if(!DocTools.IsNullOrEmpty(request.ReasonRejecteds))
                    entities = entities.Where(en => en.ReasonRejected.In(request.ReasonRejecteds));

                entities = ApplyFilters<DocEntityRating,RatingSearch>(request, entities);

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

        public object Post(RatingSearch request) => Get(request);

        public object Get(RatingSearch request) => GetSearchResultWithCache<Rating,DocEntityRating,RatingSearch>(DocConstantModelName.RATING, request, _ExecSearch);

        public object Get(Rating request) => GetEntityWithCache<Rating>(DocConstantModelName.RATING, request, GetRating);



        private Rating _AssignValues(Rating request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "Rating"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.Select = request.Select ?? new List<string>();

            Rating ret = null;
            request = _InitAssignValues<Rating>(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            var cacheKey = GetApiCacheKey<Rating>(DocConstantModelName.RATING, nameof(Rating), request);
            
            //First, assign all the variables, do database lookups and conversions
            var pDocument = (request.Document?.Id > 0) ? DocEntityDocument.Get(request.Document.Id) : null;
            var pRating = request.Rating;
            var pReasonRejected = request.ReasonRejected;

            DocEntityRating entity = null;
            if(permission == DocConstantPermission.ADD)
            {
                var now = DateTime.UtcNow;
                entity = new DocEntityRating(session)
                {
                    Created = now,
                    Updated = now
                };
            }
            else
            {
                entity = DocEntityRating.Get(request.Id);
                if(null == entity)
                    throw new HttpError(HttpStatusCode.NotFound, $"No record");
            }

            //Special case for Archived
            var pArchived = true == request.Archived;
            if (DocPermissionFactory.IsRequestedHasPermission<bool>(currentUser, request, pArchived, permission, DocConstantModelName.RATING, nameof(request.Archived)))
            {
                if(DocPermissionFactory.IsRequested(request, pArchived, entity.Archived, nameof(request.Archived)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.RATING, nameof(request.Archived)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Archived)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pArchived) && DocResources.Metadata.IsRequired(DocConstantModelName.RATING, nameof(request.Archived))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Archived)} requires a value.");
                    entity.Archived = pArchived;
                if(DocPermissionFactory.IsRequested<bool>(request, pArchived, nameof(request.Archived)) && !request.Select.Matches(nameof(request.Archived), ignoreSpaces: true))
                {
                    request.Select.Add(nameof(request.Archived));
                }
            }

            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityDocument>(currentUser, request, pDocument, permission, DocConstantModelName.RATING, nameof(request.Document)))
            {
                if(DocPermissionFactory.IsRequested(request, pDocument, entity.Document, nameof(request.Document)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.RATING, nameof(request.Document)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Document)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pDocument) && DocResources.Metadata.IsRequired(DocConstantModelName.RATING, nameof(request.Document))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Document)} requires a value.");
                    entity.Document = pDocument;
                if(DocPermissionFactory.IsRequested<DocEntityDocument>(request, pDocument, nameof(request.Document)) && !request.Select.Matches(nameof(request.Document), ignoreSpaces: true))
                {
                    request.Select.Add(nameof(request.Document));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<RatingEnm?>(currentUser, request, pRating, permission, DocConstantModelName.RATING, nameof(request.Rating)))
            {
                if(DocPermissionFactory.IsRequested(request, (int?) pRating, (int) entity.Rating, nameof(request.Rating)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.RATING, nameof(request.Rating)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Rating)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pRating) && DocResources.Metadata.IsRequired(DocConstantModelName.RATING, nameof(request.Rating))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Rating)} requires a value.");
                    if(null != pRating)
                        entity.Rating = pRating.Value;
                if(DocPermissionFactory.IsRequested<RatingEnm?>(request, pRating, nameof(request.Rating)) && !request.Select.Matches(nameof(request.Rating), ignoreSpaces: true))
                {
                    request.Select.Add(nameof(request.Rating));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<ReasonRejectedEnm?>(currentUser, request, pReasonRejected, permission, DocConstantModelName.RATING, nameof(request.ReasonRejected)))
            {
                if(DocPermissionFactory.IsRequested(request, (int?) pReasonRejected, (int?) entity.ReasonRejected, nameof(request.ReasonRejected)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.RATING, nameof(request.ReasonRejected)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.ReasonRejected)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pReasonRejected) && DocResources.Metadata.IsRequired(DocConstantModelName.RATING, nameof(request.ReasonRejected))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.ReasonRejected)} requires a value.");
                    entity.ReasonRejected = pReasonRejected;
                if(DocPermissionFactory.IsRequested<ReasonRejectedEnm?>(request, pReasonRejected, nameof(request.ReasonRejected)) && !request.Select.Matches(nameof(request.ReasonRejected), ignoreSpaces: true))
                {
                    request.Select.Add(nameof(request.ReasonRejected));
                }
            }

            if (request.Locked) entity.Locked = request.Locked;

            entity.SaveChanges(permission);


            DocPermissionFactory.SetSelect<Rating>(currentUser, nameof(Rating), request.Select);
            ret = entity.ToDto();

            var cacheExpires = DocResources.Metadata.GetCacheExpiration(DocConstantModelName.RATING);
            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.RATING, cacheExpires);

            return ret;
        }


        public Rating Post(Rating request)
        {
            if(request == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            request.Select = request.Select ?? new List<string>();

            Rating ret = null;

            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "Rating")) 
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                    ret = _AssignValues(request, DocConstantPermission.ADD, ssn);
                });
            }
            return ret;
        }
   
        public List<Rating> Post(RatingBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<Rating>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Post(dto) as Rating;
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

        public Rating Post(RatingCopy request)
        {
            Rating ret = null;
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    var entity = DocEntityRating.Get(request?.Id);
                    if(null == entity) throw new HttpError(HttpStatusCode.NoContent, "The COPY request did not succeed.");
                    if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD))
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                    var pDocument = entity.Document;
                    var pRating = entity.Rating;
                    var pReasonRejected = entity.ReasonRejected;
                    var copy = new DocEntityRating(ssn)
                    {
                        Hash = Guid.NewGuid()
                                , Document = pDocument
                                , Rating = pRating
                                , ReasonRejected = pReasonRejected
                    };

                    copy.SaveChanges(DocConstantPermission.ADD);
                    ret = copy.ToDto();
                });
            }
            return ret;
        }



        public List<Rating> Put(RatingBatch request)
        {
            return Patch(request);
        }

        public Rating Put(Rating request)
        {
            return Patch(request);
        }


        public List<Rating> Patch(RatingBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<Rating>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Patch(dto) as Rating;
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

        public Rating Patch(Rating request)
        {
            if(true != (request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the Rating to patch.");
            
            request.Select = request.Select ?? new List<string>();
            
            Rating ret = null;
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    ret = _AssignValues(request, DocConstantPermission.EDIT, ssn);
                });
            }
            return ret;
        }


        public void Delete(RatingBatch request)
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

        public void Delete(Rating request)
        {
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    if(!(request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, $"No Id provided for delete.");

                    var en = DocEntityRating.Get(request?.Id);
                    if(null == en) throw new HttpError(HttpStatusCode.NotFound, $"No Rating could be found for Id {request?.Id}.");
                    if(en.IsRemoved) return;
                
                    if(!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.DELETE))
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have DELETE permission for this route.");
                
                    en.Remove();

                    DocCacheClient.RemoveSearch(DocConstantModelName.RATING);
                    DocCacheClient.RemoveById(request.Id);
                });
            }
        }

        public void Delete(RatingSearch request)
        {
            var matches = Get(request) as List<Rating>;
            if(true != matches?.Any()) throw new HttpError(HttpStatusCode.NotFound, "No matches for request");
            matches.ForEach(match =>
            {
                Delete(match);
            });
        }




        private Rating GetRating(Rating request)
        {
            var id = request?.Id;
            Rating ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetSelect<Rating>(currentUser, "Rating", request.Select);

            DocEntityRating entity = null;
            if(id.HasValue)
            {
                entity = DocEntityRating.Get(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No Rating found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }

    }
}
