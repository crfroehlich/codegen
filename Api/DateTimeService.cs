
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
    public partial class DateTimeService : DocServiceBase
    {

        private IQueryable<DocEntityDateTime> _ExecSearch(DateTimeSearch request, DocQuery query)
        {
            request = InitSearch<DateTimeDto, DateTimeSearch>(request);
            IQueryable<DocEntityDateTime> entities = null;
            query.Run( session => 
            {
                entities = query.SelectAll<DocEntityDateTime>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new DateTimeFullTextSearch(request);
                    entities = GetFullTextSearch<DocEntityDateTime,DateTimeFullTextSearch>(fts, entities);
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
                if(true == request.Archived?.Any() && currentUser.HasProperty(DocConstantModelName.DATETIME, nameof(Reference.Archived), DocConstantPermission.VIEW))
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

                if(request.DateDay.HasValue)
                    entities = entities.Where(en => request.DateDay.Value == en.DateDay);
                if(request.DateMonth.HasValue)
                    entities = entities.Where(en => request.DateMonth.Value == en.DateMonth);
                if(!DocTools.IsNullOrEmpty(request.DateTime))
                    entities = entities.Where(en => null != en.DateTime && request.DateTime.Value.Date == en.DateTime.Value.Date);
                if(!DocTools.IsNullOrEmpty(request.DateTimeBefore))
                    entities = entities.Where(en => en.DateTime <= request.DateTimeBefore);
                if(!DocTools.IsNullOrEmpty(request.DateTimeAfter))
                    entities = entities.Where(en => en.DateTime >= request.DateTimeAfter);
                if(request.DateYear.HasValue)
                    entities = entities.Where(en => request.DateYear.Value == en.DateYear);

                entities = ApplyFilters<DocEntityDateTime,DateTimeSearch>(request, entities);

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

        public object Post(DateTimeSearch request) => Get(request);

        public object Get(DateTimeSearch request) => GetSearchResultWithCache<DateTimeDto,DocEntityDateTime,DateTimeSearch>(DocConstantModelName.DATETIME, request, _ExecSearch);

        public object Get(DateTimeDto request) => GetEntityWithCache<DateTimeDto>(DocConstantModelName.DATETIME, request, GetDateTime);



        private DateTimeDto _AssignValues(DateTimeDto request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "DateTime"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            DateTimeDto ret = null;
            request = _InitAssignValues<DateTimeDto>(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            var cacheKey = GetApiCacheKey<DateTimeDto>(DocConstantModelName.DATETIME, nameof(DateTimeDto), request);
            
            //First, assign all the variables, do database lookups and conversions
            var pDateDay = request.DateDay;
            var pDateMonth = request.DateMonth;
            var pDateTime = request.DateTime;
            var pDateYear = request.DateYear;

            DocEntityDateTime entity = null;
            if(permission == DocConstantPermission.ADD)
            {
                var now = DateTime.UtcNow;
                entity = new DocEntityDateTime(session)
                {
                    Created = now,
                    Updated = now
                };
            }
            else
            {
                entity = DocEntityDateTime.GetDateTime(request.Id);
                if(null == entity)
                    throw new HttpError(HttpStatusCode.NotFound, $"No record");
            }

            //Special case for Archived
            var pArchived = true == request.Archived;
            if (DocPermissionFactory.IsRequestedHasPermission<bool>(currentUser, request, pArchived, permission, DocConstantModelName.DATETIME, nameof(request.Archived)))
            {
                if(DocPermissionFactory.IsRequested(request, pArchived, entity.Archived, nameof(request.Archived)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.DATETIME, nameof(request.Archived)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Archived)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pArchived) && DocResources.Metadata.IsRequired(DocConstantModelName.DATETIME, nameof(request.Archived))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Archived)} requires a value.");
                    entity.Archived = pArchived;
                if(DocPermissionFactory.IsRequested<bool>(request, pArchived, nameof(request.Archived)) && !request.VisibleFields.Matches(nameof(request.Archived), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Archived));
                }
            }

            if (DocPermissionFactory.IsRequestedHasPermission<int?>(currentUser, request, pDateDay, permission, DocConstantModelName.DATETIME, nameof(request.DateDay)))
            {
                if(DocPermissionFactory.IsRequested(request, pDateDay, entity.DateDay, nameof(request.DateDay)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.DATETIME, nameof(request.DateDay)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.DateDay)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pDateDay) && DocResources.Metadata.IsRequired(DocConstantModelName.DATETIME, nameof(request.DateDay))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.DateDay)} requires a value.");
                    entity.DateDay = pDateDay;
                if(DocPermissionFactory.IsRequested<int?>(request, pDateDay, nameof(request.DateDay)) && !request.VisibleFields.Matches(nameof(request.DateDay), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.DateDay));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<int?>(currentUser, request, pDateMonth, permission, DocConstantModelName.DATETIME, nameof(request.DateMonth)))
            {
                if(DocPermissionFactory.IsRequested(request, pDateMonth, entity.DateMonth, nameof(request.DateMonth)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.DATETIME, nameof(request.DateMonth)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.DateMonth)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pDateMonth) && DocResources.Metadata.IsRequired(DocConstantModelName.DATETIME, nameof(request.DateMonth))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.DateMonth)} requires a value.");
                    entity.DateMonth = pDateMonth;
                if(DocPermissionFactory.IsRequested<int?>(request, pDateMonth, nameof(request.DateMonth)) && !request.VisibleFields.Matches(nameof(request.DateMonth), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.DateMonth));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DateTime?>(currentUser, request, pDateTime, permission, DocConstantModelName.DATETIME, nameof(request.DateTime)))
            {
                if(DocPermissionFactory.IsRequested(request, pDateTime, entity.DateTime, nameof(request.DateTime)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.DATETIME, nameof(request.DateTime)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.DateTime)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pDateTime) && DocResources.Metadata.IsRequired(DocConstantModelName.DATETIME, nameof(request.DateTime))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.DateTime)} requires a value.");
                    entity.DateTime = pDateTime;
                if(DocPermissionFactory.IsRequested<DateTime?>(request, pDateTime, nameof(request.DateTime)) && !request.VisibleFields.Matches(nameof(request.DateTime), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.DateTime));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<int?>(currentUser, request, pDateYear, permission, DocConstantModelName.DATETIME, nameof(request.DateYear)))
            {
                if(DocPermissionFactory.IsRequested(request, pDateYear, entity.DateYear, nameof(request.DateYear)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.DATETIME, nameof(request.DateYear)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.DateYear)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pDateYear) && DocResources.Metadata.IsRequired(DocConstantModelName.DATETIME, nameof(request.DateYear))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.DateYear)} requires a value.");
                    entity.DateYear = pDateYear;
                if(DocPermissionFactory.IsRequested<int?>(request, pDateYear, nameof(request.DateYear)) && !request.VisibleFields.Matches(nameof(request.DateYear), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.DateYear));
                }
            }

            if (request.Locked) entity.Locked = request.Locked;

            entity.SaveChanges(permission);


            DocPermissionFactory.SetVisibleFields<DateTimeDto>(currentUser, nameof(DateTimeDto), request.VisibleFields);
            ret = entity.ToDto();

            var cacheExpires = DocResources.Metadata.GetCacheExpiration(DocConstantModelName.DATETIME);
            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.DATETIME, cacheExpires);

            return ret;
        }


        public DateTimeDto Post(DateTimeDto request)
        {
            if(request == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            DateTimeDto ret = null;

            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "DateTime")) 
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                    ret = _AssignValues(request, DocConstantPermission.ADD, ssn);
                });
            }
            return ret;
        }
   
        public List<DateTimeDto> Post(DateTimeBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<DateTimeDto>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Post(dto) as DateTimeDto;
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

        public DateTimeDto Post(DateTimeDtoCopy request)
        {
            DateTimeDto ret = null;
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    var entity = DocEntityDateTime.GetDateTime(request?.Id);
                    if(null == entity) throw new HttpError(HttpStatusCode.NoContent, "The COPY request did not succeed.");
                    if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD))
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                    var pDateDay = entity.DateDay;
                    var pDateMonth = entity.DateMonth;
                    var pDateTime = entity.DateTime;
                    var pDateYear = entity.DateYear;
                    #region Custom Before copyDateTime
                    #endregion Custom Before copyDateTime
                    var copy = new DocEntityDateTime(ssn)
                    {
                        Hash = Guid.NewGuid()
                                , DateDay = pDateDay
                                , DateMonth = pDateMonth
                                , DateTime = pDateTime
                                , DateYear = pDateYear
                    };

                    #region Custom After copyDateTime
                    #endregion Custom After copyDateTime
                    copy.SaveChanges(DocConstantPermission.ADD);
                    ret = copy.ToDto();
                });
            }
            return ret;
        }



        public List<DateTimeDto> Put(DateTimeBatch request)
        {
            return Patch(request);
        }

        public DateTimeDto Put(DateTimeDto request)
        {
            return Patch(request);
        }


        public List<DateTimeDto> Patch(DateTimeBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<DateTimeDto>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Patch(dto) as DateTimeDto;
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

        public DateTimeDto Patch(DateTimeDto request)
        {
            if(true != (request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the DateTime to patch.");
            
            request.VisibleFields = request.VisibleFields ?? new List<string>();
            
            DateTimeDto ret = null;
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    ret = _AssignValues(request, DocConstantPermission.EDIT, ssn);
                });
            }
            return ret;
        }


        public void Delete(DateTimeBatch request)
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

        public void Delete(DateTimeDto request)
        {
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    if(!(request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, $"No Id provided for delete.");

                    var en = DocEntityDateTime.GetDateTime(request?.Id);
                    if(null == en) throw new HttpError(HttpStatusCode.NotFound, $"No DateTime could be found for Id {request?.Id}.");
                    if(en.IsRemoved) return;
                
                    if(!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.DELETE))
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have DELETE permission for this route.");
                
                    en.Remove();

                    DocCacheClient.RemoveSearch(DocConstantModelName.DATETIME);
                    DocCacheClient.RemoveById(request.Id);
                });
            }
        }

        public void Delete(DateTimeSearch request)
        {
            var matches = Get(request) as List<DateTimeDto>;
            if(true != matches?.Any()) throw new HttpError(HttpStatusCode.NotFound, "No matches for request");
            matches.ForEach(match =>
            {
                Delete(match);
            });
        }




        private DateTimeDto GetDateTime(DateTimeDto request)
        {
            var id = request?.Id;
            DateTimeDto ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetVisibleFields<DateTimeDto>(currentUser, "DateTime", request.VisibleFields);

            DocEntityDateTime entity = null;
            if(id.HasValue)
            {
                entity = DocEntityDateTime.GetDateTime(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No DateTime found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }

    }
}
