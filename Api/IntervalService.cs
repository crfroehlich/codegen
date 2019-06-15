
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
    public partial class IntervalService : DocServiceBase
    {

        private IQueryable<DocEntityInterval> _ExecSearch(IntervalSearch request, DocQuery query)
        {
            request = InitSearch<Interval, IntervalSearch>(request);
            IQueryable<DocEntityInterval> entities = null;
            query.Run( session => 
            {
                entities = query.SelectAll<DocEntityInterval>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new IntervalFullTextSearch(request);
                    entities = GetFullTextSearch<DocEntityInterval,IntervalFullTextSearch>(fts, entities);
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
                if(true == request.Archived?.Any() && currentUser.HasProperty(DocConstantModelName.INTERVAL, nameof(Reference.Archived), DocConstantPermission.VIEW))
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
                if(!DocTools.IsNullOrEmpty(request.CalendarDateEnd) && !DocTools.IsNullOrEmpty(request.CalendarDateEnd.Id))
                {
                    entities = entities.Where(en => en.CalendarDateEnd.Id == request.CalendarDateEnd.Id );
                }
                if(true == request.CalendarDateEndIds?.Any())
                {
                    entities = entities.Where(en => en.CalendarDateEnd.Id.In(request.CalendarDateEndIds));
                }
                if(!DocTools.IsNullOrEmpty(request.CalendarDateStart) && !DocTools.IsNullOrEmpty(request.CalendarDateStart.Id))
                {
                    entities = entities.Where(en => en.CalendarDateStart.Id == request.CalendarDateStart.Id );
                }
                if(true == request.CalendarDateStartIds?.Any())
                {
                    entities = entities.Where(en => en.CalendarDateStart.Id.In(request.CalendarDateStartIds));
                }
                if(!DocTools.IsNullOrEmpty(request.CalendarType))
                    entities = entities.Where(en => en.CalendarType.Contains(request.CalendarType));
                if(!DocTools.IsNullOrEmpty(request.CalendarTypes))
                    entities = entities.Where(en => en.CalendarType.In(request.CalendarTypes));
                if(!DocTools.IsNullOrEmpty(request.FollowUp) && !DocTools.IsNullOrEmpty(request.FollowUp.Id))
                {
                    entities = entities.Where(en => en.FollowUp.Id == request.FollowUp.Id );
                }
                if(true == request.FollowUpIds?.Any())
                {
                    entities = entities.Where(en => en.FollowUp.Id.In(request.FollowUpIds));
                }
                if(!DocTools.IsNullOrEmpty(request.TimeOfDay) && !DocTools.IsNullOrEmpty(request.TimeOfDay.Id))
                {
                    entities = entities.Where(en => en.TimeOfDay.Id == request.TimeOfDay.Id );
                }
                if(true == request.TimeOfDayIds?.Any())
                {
                    entities = entities.Where(en => en.TimeOfDay.Id.In(request.TimeOfDayIds));
                }

                entities = ApplyFilters<DocEntityInterval,IntervalSearch>(request, entities);

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

        public object Post(IntervalSearch request) => Get(request);

        public object Get(IntervalSearch request) => GetSearchResultWithCache<Interval,DocEntityInterval,IntervalSearch>(DocConstantModelName.INTERVAL, request, _ExecSearch);

        public object Get(Interval request) => GetEntityWithCache<Interval>(DocConstantModelName.INTERVAL, request, GetInterval);



        private Interval _AssignValues(Interval request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "Interval"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.Select = request.Select ?? new List<string>();

            Interval ret = null;
            request = _InitAssignValues<Interval>(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            var cacheKey = GetApiCacheKey<Interval>(DocConstantModelName.INTERVAL, nameof(Interval), request);
            
            //First, assign all the variables, do database lookups and conversions
            var pCalendarDateEnd = (request.CalendarDateEnd?.Id > 0) ? DocEntityDateTime.Get(request.CalendarDateEnd.Id) : null;
            var pCalendarDateStart = (request.CalendarDateStart?.Id > 0) ? DocEntityDateTime.Get(request.CalendarDateStart.Id) : null;
            var pCalendarType = request.CalendarType;
            var pFollowUp = (request.FollowUp?.Id > 0) ? DocEntityTimePoint.Get(request.FollowUp.Id) : null;
            var pTimeOfDay = (request.TimeOfDay?.Id > 0) ? DocEntityTimePoint.Get(request.TimeOfDay.Id) : null;

            DocEntityInterval entity = null;
            if(permission == DocConstantPermission.ADD)
            {
                var now = DateTime.UtcNow;
                entity = new DocEntityInterval(session)
                {
                    Created = now,
                    Updated = now
                };
            }
            else
            {
                entity = DocEntityInterval.Get(request.Id);
                if(null == entity)
                    throw new HttpError(HttpStatusCode.NotFound, $"No record");
            }

            //Special case for Archived
            var pArchived = true == request.Archived;
            if (PatchValue<Interval, bool>(request, DocConstantModelName.INTERVAL, pArchived, entity.Archived, permission, nameof(request.Archived), pArchived != entity.Archived))
            {
                entity.Archived = pArchived;
            }
            if (PatchValue<Interval, DocEntityDateTime>(request, DocConstantModelName.INTERVAL, pCalendarDateEnd, entity.CalendarDateEnd, permission, nameof(request.CalendarDateEnd), pCalendarDateEnd != entity.CalendarDateEnd))
            {
                entity.CalendarDateEnd = pCalendarDateEnd;
            }
            if (PatchValue<Interval, DocEntityDateTime>(request, DocConstantModelName.INTERVAL, pCalendarDateStart, entity.CalendarDateStart, permission, nameof(request.CalendarDateStart), pCalendarDateStart != entity.CalendarDateStart))
            {
                entity.CalendarDateStart = pCalendarDateStart;
            }
            if (PatchValue<Interval, string>(request, DocConstantModelName.INTERVAL, pCalendarType, entity.CalendarType, permission, nameof(request.CalendarType), pCalendarType != entity.CalendarType))
            {
                entity.CalendarType = pCalendarType;
            }
            if (PatchValue<Interval, DocEntityTimePoint>(request, DocConstantModelName.INTERVAL, pFollowUp, entity.FollowUp, permission, nameof(request.FollowUp), pFollowUp != entity.FollowUp))
            {
                entity.FollowUp = pFollowUp;
            }
            if (PatchValue<Interval, DocEntityTimePoint>(request, DocConstantModelName.INTERVAL, pTimeOfDay, entity.TimeOfDay, permission, nameof(request.TimeOfDay), pTimeOfDay != entity.TimeOfDay))
            {
                entity.TimeOfDay = pTimeOfDay;
            }

            if (request.Locked) entity.Locked = request.Locked;

            entity.SaveChanges(permission);

            var idsToInvalidate = new List<int>();

            if (idsToInvalidate.Any())
            {
                idsToInvalidate.Add(entity.Id);
                DocCacheClient.RemoveByEntityIds(idsToInvalidate);
                DocCacheClient.RemoveSearch(DocConstantModelName.INTERVAL);
            }

            DocPermissionFactory.SetSelect<Interval>(currentUser, nameof(Interval), request.Select);
            ret = entity.ToDto();

            var cacheExpires = DocResources.Metadata.GetCacheExpiration(DocConstantModelName.INTERVAL);
            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.INTERVAL, cacheExpires);

            return ret;
        }


        public Interval Post(Interval request)
        {
            if(request == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            request.Select = request.Select ?? new List<string>();

            Interval ret = null;

            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "Interval")) 
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                    ret = _AssignValues(request, DocConstantPermission.ADD, ssn);
                });
            }
            return ret;
        }
   
        public List<Interval> Post(IntervalBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<Interval>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Post(dto) as Interval;
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

        public Interval Post(IntervalCopy request)
        {
            Interval ret = null;
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    var entity = DocEntityInterval.Get(request?.Id);
                    if(null == entity) throw new HttpError(HttpStatusCode.NoContent, "The COPY request did not succeed.");
                    if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD))
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                    var pCalendarDateEnd = entity.CalendarDateEnd;
                    var pCalendarDateStart = entity.CalendarDateStart;
                    var pCalendarType = entity.CalendarType;
                    if(!DocTools.IsNullOrEmpty(pCalendarType))
                        pCalendarType += " (Copy)";
                    var pFollowUp = entity.FollowUp;
                    var pTimeOfDay = entity.TimeOfDay;
                    var copy = new DocEntityInterval(ssn)
                    {
                        Hash = Guid.NewGuid()
                                , CalendarDateEnd = pCalendarDateEnd
                                , CalendarDateStart = pCalendarDateStart
                                , CalendarType = pCalendarType
                                , FollowUp = pFollowUp
                                , TimeOfDay = pTimeOfDay
                    };

                    copy.SaveChanges(DocConstantPermission.ADD);
                    ret = copy.ToDto();
                });
            }
            return ret;
        }



        public List<Interval> Put(IntervalBatch request)
        {
            return Patch(request);
        }

        public Interval Put(Interval request)
        {
            return Patch(request);
        }


        public List<Interval> Patch(IntervalBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<Interval>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Patch(dto) as Interval;
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

        public Interval Patch(Interval request)
        {
            if(true != (request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the Interval to patch.");
            
            request.Select = request.Select ?? new List<string>();
            
            Interval ret = null;
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    ret = _AssignValues(request, DocConstantPermission.EDIT, ssn);
                });
            }
            return ret;
        }


        public void Delete(IntervalBatch request)
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

        public void Delete(Interval request)
        {
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    if(!(request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, $"No Id provided for delete.");

                    var en = DocEntityInterval.Get(request?.Id);
                    if(null == en) throw new HttpError(HttpStatusCode.NotFound, $"No Interval could be found for Id {request?.Id}.");
                    if(en.IsRemoved) return;
                
                    if(!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.DELETE))
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have DELETE permission for this route.");
                
                    en.Remove();

                    DocCacheClient.RemoveSearch(DocConstantModelName.INTERVAL);
                    DocCacheClient.RemoveById(request.Id);
                });
            }
        }

        public void Delete(IntervalSearch request)
        {
            var matches = Get(request) as List<Interval>;
            if(true != matches?.Any()) throw new HttpError(HttpStatusCode.NotFound, "No matches for request");
            matches.ForEach(match =>
            {
                Delete(match);
            });
        }




        private Interval GetInterval(Interval request)
        {
            var id = request?.Id;
            Interval ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetSelect<Interval>(currentUser, "Interval", request.Select);

            DocEntityInterval entity = null;
            if(id.HasValue)
            {
                entity = DocEntityInterval.Get(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No Interval found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }

    }
}
