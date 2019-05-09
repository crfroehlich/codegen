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
    public partial class AdjudicatedRatingService : DocServiceBase
    {
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
                if(request.ReasonRejected.HasValue)
                    entities = entities.Where(en => request.ReasonRejected.Value == en.ReasonRejected);

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

        public object Post(AdjudicatedRatingSearch request) => Get(request);

        public object Get(AdjudicatedRatingSearch request) => GetSearchResultWithCache<AdjudicatedRating,DocEntityAdjudicatedRating,AdjudicatedRatingSearch>(DocConstantModelName.ADJUDICATEDRATING, request, _ExecSearch);

        public object Get(AdjudicatedRating request) => GetEntityWithCache<AdjudicatedRating>(DocConstantModelName.ADJUDICATEDRATING, request, GetAdjudicatedRating);

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
            var pDocument = (request.Document?.Id > 0) ? DocEntityDocument.Get(request.Document.Id) : null;
            var pRating = request.Rating;
            var pReasonRejected = request.ReasonRejected;

            DocEntityAdjudicatedRating entity = null;
            if(permission == DocConstantPermission.ADD)
            {
                var now = DateTime.UtcNow;
                entity = new DocEntityAdjudicatedRating(session)
                {
                    Created = now,
                    Updated = now
                };
            }
            else
            {
                entity = DocEntityAdjudicatedRating.Get(request.Id);
                if(null == entity)
                    throw new HttpError(HttpStatusCode.NotFound, $"No record");
            }

            //Special case for Archived
            var pArchived = true == request.Archived;
            if (DocPermissionFactory.IsRequestedHasPermission<bool>(currentUser, request, pArchived, permission, DocConstantModelName.ADJUDICATEDRATING, nameof(request.Archived)))
            {
                if(DocPermissionFactory.IsRequested(request, pArchived, entity.Archived, nameof(request.Archived)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.ADJUDICATEDRATING, nameof(request.Archived)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Archived)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pArchived) && DocResources.Metadata.IsRequired(DocConstantModelName.ADJUDICATEDRATING, nameof(request.Archived))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Archived)} requires a value.");
                    entity.Archived = pArchived;
                if(DocPermissionFactory.IsRequested<bool>(request, pArchived, nameof(request.Archived)) && !request.Select.Matches(nameof(request.Archived), ignoreSpaces: true))
                {
                    request.Select.Add(nameof(request.Archived));
                }
            }

            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityDocument>(currentUser, request, pDocument, permission, DocConstantModelName.ADJUDICATEDRATING, nameof(request.Document)))
            {
                if(DocPermissionFactory.IsRequested(request, pDocument, entity.Document, nameof(request.Document)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.ADJUDICATEDRATING, nameof(request.Document)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Document)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pDocument) && DocResources.Metadata.IsRequired(DocConstantModelName.ADJUDICATEDRATING, nameof(request.Document))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Document)} requires a value.");
                    entity.Document = pDocument;
                if(DocPermissionFactory.IsRequested<DocEntityDocument>(request, pDocument, nameof(request.Document)) && !request.Select.Matches(nameof(request.Document), ignoreSpaces: true))
                {
                    request.Select.Add(nameof(request.Document));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<RatingEnm?>(currentUser, request, pRating, permission, DocConstantModelName.ADJUDICATEDRATING, nameof(request.Rating)))
            {
                if(DocPermissionFactory.IsRequested(request, (int?) pRating, (int) entity.Rating, nameof(request.Rating)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.ADJUDICATEDRATING, nameof(request.Rating)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Rating)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pRating) && DocResources.Metadata.IsRequired(DocConstantModelName.ADJUDICATEDRATING, nameof(request.Rating))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Rating)} requires a value.");
                    if(null != pRating)
                        entity.Rating = pRating.Value;
                if(DocPermissionFactory.IsRequested<RatingEnm?>(request, pRating, nameof(request.Rating)) && !request.Select.Matches(nameof(request.Rating), ignoreSpaces: true))
                {
                    request.Select.Add(nameof(request.Rating));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<ReasonRejectedEnm?>(currentUser, request, pReasonRejected, permission, DocConstantModelName.ADJUDICATEDRATING, nameof(request.ReasonRejected)))
            {
                if(DocPermissionFactory.IsRequested(request, (int?) pReasonRejected, (int?) entity.ReasonRejected, nameof(request.ReasonRejected)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.ADJUDICATEDRATING, nameof(request.ReasonRejected)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.ReasonRejected)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pReasonRejected) && DocResources.Metadata.IsRequired(DocConstantModelName.ADJUDICATEDRATING, nameof(request.ReasonRejected))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.ReasonRejected)} requires a value.");
                    entity.ReasonRejected = pReasonRejected;
                if(DocPermissionFactory.IsRequested<ReasonRejectedEnm?>(request, pReasonRejected, nameof(request.ReasonRejected)) && !request.Select.Matches(nameof(request.ReasonRejected), ignoreSpaces: true))
                {
                    request.Select.Add(nameof(request.ReasonRejected));
                }
            }

            if (request.Locked) entity.Locked = request.Locked;

            entity.SaveChanges(permission);


            DocPermissionFactory.SetSelect<AdjudicatedRating>(currentUser, nameof(AdjudicatedRating), request.Select);
            ret = entity.ToDto();

            var cacheExpires = DocResources.Metadata.GetCacheExpiration(DocConstantModelName.ADJUDICATEDRATING);
            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.ADJUDICATEDRATING, cacheExpires);

            return ret;
        }
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

                    var pDocument = entity.Document;
                    var pRating = entity.Rating;
                    var pReasonRejected = entity.ReasonRejected;
                    #region Custom Before copyAdjudicatedRating
                    #endregion Custom Before copyAdjudicatedRating
                    var copy = new DocEntityAdjudicatedRating(ssn)
                    {
                        Hash = Guid.NewGuid()
                                , Document = pDocument
                                , Rating = pRating
                                , ReasonRejected = pReasonRejected
                    };

                    #region Custom After copyAdjudicatedRating
                    #endregion Custom After copyAdjudicatedRating
                    copy.SaveChanges(DocConstantPermission.ADD);
                    ret = copy.ToDto();
                });
            }
            return ret;
        }

        public List<AdjudicatedRating> Put(AdjudicatedRatingBatch request)
        {
            return Patch(request);
        }

        public AdjudicatedRating Put(AdjudicatedRating request)
        {
            return Patch(request);
        }
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

        public void Delete(AdjudicatedRatingSearch request)
        {
            var matches = Get(request) as List<AdjudicatedRating>;
            if(true != matches?.Any()) throw new HttpError(HttpStatusCode.NotFound, "No matches for request");
            matches.ForEach(match =>
            {
                Delete(match);
            });
        }
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