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
    public partial class TimeCardService : DocServiceBase
    {
        public const string CACHE_KEY_PREFIX = DocEntityTimeCard.CACHE_KEY_PREFIX;
        private object _GetIdCache(TimeCard request)
        {
            object ret = null;

            if (true != request.IgnoreCache)
            {
                var key = currentUser.GetApiCacheKey(DocConstantModelName.TIMECARD);
                var cacheKey = $"TimeCard_{key}_{request.Id}_{UrnId.Create<TimeCard>(request.GetMD5Hash())}";
                ret = Request.ToOptimizedResultUsingCache(Cache, cacheKey, new TimeSpan(0, DocResources.Settings.SessionTimeout, 0), () =>
                {
                    object cachedRet = null;
                    cachedRet = GetTimeCard(request);
                    return cachedRet;
                });
            }
            ret = ret ?? GetTimeCard(request);
            return ret;
        }

        private object _GetSearchCache(TimeCardSearch request, DocRequestCancellation requestCancel)
        {
            object tryRet = null;
            var ret = new List<TimeCard>();

            //Keys need to be customized to factor in permissions/scoping. Often, including the current user's Role Id is sufficient in the key
            var key = currentUser.GetApiCacheKey(DocConstantModelName.TIMECARD);
            var cacheKey = $"{CACHE_KEY_PREFIX}_{key}_{UrnId.Create<TimeCardSearch>(request.GetMD5Hash())}";
            tryRet = Request.ToOptimizedResultUsingCache(Cache, cacheKey, new TimeSpan(0, DocResources.Settings.SessionTimeout, 0), () =>
            {
                _ExecSearch(request, (entities) => entities.ConvertFromEntityList<DocEntityTimeCard,TimeCard>(ret, Execute, requestCancel));
                return ret;
            });

            if(tryRet == null)
            {
                ret = new List<TimeCard>();
                _ExecSearch(request, (entities) => entities.ConvertFromEntityList<DocEntityTimeCard,TimeCard>(ret, Execute, requestCancel));
                return ret;
            }
            else
            {
                return tryRet;
            }
        }
        private void _ExecSearch(TimeCardSearch request, Action<IQueryable<DocEntityTimeCard>> callBack)
        {
            request = InitSearch(request);
            
            DocPermissionFactory.SetVisibleFields<TimeCard>(currentUser, "TimeCard", request.VisibleFields);

            var entities = Execute.SelectAll<DocEntityTimeCard>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new TimeCardFullTextSearch(request);
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

                if(!DocTools.IsNullOrEmpty(request.Description))
                    entities = entities.Where(en => en.Description.Contains(request.Description));
                if(!DocTools.IsNullOrEmpty(request.Document) && !DocTools.IsNullOrEmpty(request.Document.Id))
                {
                    entities = entities.Where(en => en.Document.Id == request.Document.Id );
                }
                if(true == request.DocumentIds?.Any())
                {
                    entities = entities.Where(en => en.Document.Id.In(request.DocumentIds));
                }
                if(!DocTools.IsNullOrEmpty(request.End))
                    entities = entities.Where(en => request.End.Value.Date == en.End.Date);
                if(!DocTools.IsNullOrEmpty(request.EndBefore))
                    entities = entities.Where(en => en.End <= request.EndBefore);
                if(!DocTools.IsNullOrEmpty(request.EndAfter))
                    entities = entities.Where(en => en.End >= request.EndAfter);
                if(!DocTools.IsNullOrEmpty(request.PICO) && !DocTools.IsNullOrEmpty(request.PICO.Id))
                {
                    entities = entities.Where(en => en.PICO.Id == request.PICO.Id );
                }
                if(true == request.PICOIds?.Any())
                {
                    entities = entities.Where(en => en.PICO.Id.In(request.PICOIds));
                }
                if(request.ReferenceId.HasValue)
                    entities = entities.Where(en => request.ReferenceId.Value == en.ReferenceId);
                if(!DocTools.IsNullOrEmpty(request.Start))
                    entities = entities.Where(en => request.Start.Value.Date == en.Start.Date);
                if(!DocTools.IsNullOrEmpty(request.StartBefore))
                    entities = entities.Where(en => en.Start <= request.StartBefore);
                if(!DocTools.IsNullOrEmpty(request.StartAfter))
                    entities = entities.Where(en => en.Start >= request.StartAfter);
                if(!DocTools.IsNullOrEmpty(request.Status) && !DocTools.IsNullOrEmpty(request.Status.Id))
                {
                    entities = entities.Where(en => en.Status.Id == request.Status.Id );
                }
                if(true == request.StatusIds?.Any())
                {
                    entities = entities.Where(en => en.Status.Id.In(request.StatusIds));
                }
                else if(!DocTools.IsNullOrEmpty(request.Status) && !DocTools.IsNullOrEmpty(request.Status.Name))
                {
                    entities = entities.Where(en => en.Status.Name == request.Status.Name );
                }
                if(true == request.StatusNames?.Any())
                {
                    entities = entities.Where(en => en.Status.Name.In(request.StatusNames));
                }
                if(!DocTools.IsNullOrEmpty(request.User) && !DocTools.IsNullOrEmpty(request.User.Id))
                {
                    entities = entities.Where(en => en.User.Id == request.User.Id );
                }
                if(true == request.UserIds?.Any())
                {
                    entities = entities.Where(en => en.User.Id.In(request.UserIds));
                }
                if(!DocTools.IsNullOrEmpty(request.WorkType) && !DocTools.IsNullOrEmpty(request.WorkType.Id))
                {
                    entities = entities.Where(en => en.WorkType.Id == request.WorkType.Id );
                }
                if(true == request.WorkTypeIds?.Any())
                {
                    entities = entities.Where(en => en.WorkType.Id.In(request.WorkTypeIds));
                }
                else if(!DocTools.IsNullOrEmpty(request.WorkType) && !DocTools.IsNullOrEmpty(request.WorkType.Name))
                {
                    entities = entities.Where(en => en.WorkType.Name == request.WorkType.Name );
                }
                if(true == request.WorkTypeNames?.Any())
                {
                    entities = entities.Where(en => en.WorkType.Name.In(request.WorkTypeNames));
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
        
        public object Post(TimeCardSearch request)
        {
            object tryRet = null;
            Execute.Run(s =>
            {
                using (var cancellableRequest = base.Request.CreateCancellableRequest())
                {
                    var requestCancel = new DocRequestCancellation(HttpContext.Current.Response, cancellableRequest);
                    try 
                    {
                        var ret = new List<TimeCard>();
                        var settings = DocResources.Settings;
                        if(true != request.IgnoreCache && settings.Cache.CacheWebServices && true != settings.Cache.ExcludedServicesFromCache?.Any(webservice => webservice.ToLower().Trim() == "timecard")) 
                        {
                            tryRet = _GetSearchCache(request, requestCancel);
                        }
                        if (tryRet == null)
                        {
                            _ExecSearch(request, (entities) => entities.ConvertFromEntityList<DocEntityTimeCard,TimeCard>(ret, Execute, requestCancel));
                            tryRet = ret;
                        }
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

        public object Get(TimeCardSearch request)
        {
            object tryRet = null;
            Execute.Run(s =>
            {
                using (var cancellableRequest = base.Request.CreateCancellableRequest())
                {
                    var requestCancel = new DocRequestCancellation(HttpContext.Current.Response, cancellableRequest);
                    try 
                    {
                        var ret = new List<TimeCard>();
                        var settings = DocResources.Settings;
                        if(true != request.IgnoreCache && settings.Cache.CacheWebServices && true != settings.Cache.ExcludedServicesFromCache?.Any(webservice => webservice.ToLower().Trim() == "timecard")) 
                        {
                            tryRet = _GetSearchCache(request, requestCancel);
                        }
                        if (tryRet == null)
                        {
                            _ExecSearch(request, (entities) => entities.ConvertFromEntityList<DocEntityTimeCard,TimeCard>(ret, Execute, requestCancel));
                            tryRet = ret;
                        }
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

        public object Post(TimeCardVersion request) 
        {
            return Get(request);
        }

        public object Get(TimeCardVersion request) 
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

        public object Get(TimeCard request)
        {
            object ret = null;
            
            if(!(request.Id > 0))
                throw new HttpError(HttpStatusCode.NotFound, "Valid Id required.");

            Execute.Run(s =>
            {
                DocPermissionFactory.SetVisibleFields<TimeCard>(currentUser, "TimeCard", request.VisibleFields);
                var settings = DocResources.Settings;
                if(true != request.IgnoreCache && settings.Cache.CacheWebServices && true != settings.Cache.ExcludedServicesFromCache?.Any(webservice => webservice.ToLower().Trim() == "timecard")) 
                {
                    ret = _GetIdCache(request);
                }
                else 
                {
                    ret = GetTimeCard(request);
                }
            });
            return ret;
        }

        private TimeCard _AssignValues(TimeCard dtoSource, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (dtoSource == null || dtoSource.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "TimeCard"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            dtoSource.VisibleFields = dtoSource.VisibleFields ?? new List<string>();

            TimeCard ret = null;
            dtoSource = _InitAssignValues(dtoSource, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && dtoSource.Id > 0) return dtoSource;
            
            //First, assign all the variables, do database lookups and conversions
            var pDescription = dtoSource.Description;
            var pDocument = (dtoSource.Document?.Id > 0) ? DocEntityDocument.GetDocument(dtoSource.Document.Id) : null;
            var pEnd = dtoSource.End;
            var pPICO = (dtoSource.PICO?.Id > 0) ? DocEntityPackage.GetPackage(dtoSource.PICO.Id) : null;
            var pReferenceId = dtoSource.ReferenceId;
            var pStart = dtoSource.Start;
            DocEntityLookupTable pStatus = GetLookup(DocConstantLookupTable.TIMECARDSTATUS, dtoSource.Status?.Name, dtoSource.Status?.Id);
            var pUser = (dtoSource.User?.Id > 0) ? DocEntityUser.GetUser(dtoSource.User.Id) : null;
            DocEntityLookupTable pWorkType = GetLookup(DocConstantLookupTable.WORKTYPE, dtoSource.WorkType?.Name, dtoSource.WorkType?.Id);

            DocEntityTimeCard entity = null;
            if(permission == DocConstantPermission.ADD)
            {
                var now = DateTime.UtcNow;
                entity = new DocEntityTimeCard(session)
                {
                    Created = now,
                    Updated = now
                };
            }
            else
            {
                entity = DocEntityTimeCard.GetTimeCard(dtoSource.Id);
                if(null == entity)
                    throw new HttpError(HttpStatusCode.NotFound, $"No record");
            }

            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, dtoSource, pDescription, permission, DocConstantModelName.TIMECARD, nameof(dtoSource.Description)))
            {
                if(DocPermissionFactory.IsRequested(dtoSource, pDescription, entity.Description, nameof(dtoSource.Description)))
                    entity.Description = pDescription;
                if(DocPermissionFactory.IsRequested<string>(dtoSource, pDescription, nameof(dtoSource.Description)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.Description), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.Description));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityDocument>(currentUser, dtoSource, pDocument, permission, DocConstantModelName.TIMECARD, nameof(dtoSource.Document)))
            {
                if(DocPermissionFactory.IsRequested(dtoSource, pDocument, entity.Document, nameof(dtoSource.Document)))
                    entity.Document = pDocument;
                if(DocPermissionFactory.IsRequested<DocEntityDocument>(dtoSource, pDocument, nameof(dtoSource.Document)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.Document), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.Document));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DateTime?>(currentUser, dtoSource, pEnd, permission, DocConstantModelName.TIMECARD, nameof(dtoSource.End)))
            {
                if(DocPermissionFactory.IsRequested(dtoSource, pEnd, entity.End, nameof(dtoSource.End)))
                        if(null != pEnd)
                    entity.End = (DateTime) pEnd;
                if(DocPermissionFactory.IsRequested<DateTime?>(dtoSource, pEnd, nameof(dtoSource.End)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.End), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.End));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityPackage>(currentUser, dtoSource, pPICO, permission, DocConstantModelName.TIMECARD, nameof(dtoSource.PICO)))
            {
                if(DocPermissionFactory.IsRequested(dtoSource, pPICO, entity.PICO, nameof(dtoSource.PICO)))
                    entity.PICO = pPICO;
                if(DocPermissionFactory.IsRequested<DocEntityPackage>(dtoSource, pPICO, nameof(dtoSource.PICO)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.PICO), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.PICO));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<int?>(currentUser, dtoSource, pReferenceId, permission, DocConstantModelName.TIMECARD, nameof(dtoSource.ReferenceId)))
            {
                if(DocPermissionFactory.IsRequested(dtoSource, pReferenceId, entity.ReferenceId, nameof(dtoSource.ReferenceId)))
                    entity.ReferenceId = pReferenceId;
                if(DocPermissionFactory.IsRequested<int?>(dtoSource, pReferenceId, nameof(dtoSource.ReferenceId)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.ReferenceId), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.ReferenceId));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DateTime?>(currentUser, dtoSource, pStart, permission, DocConstantModelName.TIMECARD, nameof(dtoSource.Start)))
            {
                if(DocPermissionFactory.IsRequested(dtoSource, pStart, entity.Start, nameof(dtoSource.Start)))
                        if(null != pStart)
                    entity.Start = (DateTime) pStart;
                if(DocPermissionFactory.IsRequested<DateTime?>(dtoSource, pStart, nameof(dtoSource.Start)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.Start), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.Start));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityLookupTable>(currentUser, dtoSource, pStatus, permission, DocConstantModelName.TIMECARD, nameof(dtoSource.Status)))
            {
                if(DocPermissionFactory.IsRequested(dtoSource, pStatus, entity.Status, nameof(dtoSource.Status)))
                    entity.Status = pStatus;
                if(DocPermissionFactory.IsRequested<DocEntityLookupTable>(dtoSource, pStatus, nameof(dtoSource.Status)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.Status), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.Status));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityUser>(currentUser, dtoSource, pUser, permission, DocConstantModelName.TIMECARD, nameof(dtoSource.User)))
            {
                if(DocPermissionFactory.IsRequested(dtoSource, pUser, entity.User, nameof(dtoSource.User)))
                    entity.User = pUser;
                if(DocPermissionFactory.IsRequested<DocEntityUser>(dtoSource, pUser, nameof(dtoSource.User)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.User), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.User));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityLookupTable>(currentUser, dtoSource, pWorkType, permission, DocConstantModelName.TIMECARD, nameof(dtoSource.WorkType)))
            {
                if(DocPermissionFactory.IsRequested(dtoSource, pWorkType, entity.WorkType, nameof(dtoSource.WorkType)))
                    entity.WorkType = pWorkType;
                if(DocPermissionFactory.IsRequested<DocEntityLookupTable>(dtoSource, pWorkType, nameof(dtoSource.WorkType)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.WorkType), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.WorkType));
                }
            }
            
            if (dtoSource.Locked) entity.Locked = dtoSource.Locked;

            entity.SaveChanges(permission);
            
            DocPermissionFactory.SetVisibleFields<TimeCard>(currentUser, nameof(TimeCard), dtoSource.VisibleFields);
            ret = entity.ToDto();

            return ret;
        }
        public TimeCard Post(TimeCard dtoSource)
        {
            if(dtoSource == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            dtoSource.VisibleFields = dtoSource.VisibleFields ?? new List<string>();

            TimeCard ret = null;

            Execute.Run(ssn =>
            {
                if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "TimeCard")) 
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                ret = _AssignValues(dtoSource, DocConstantPermission.ADD, ssn);
            });

            return ret;
        }
   
        public List<TimeCard> Post(TimeCardBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<TimeCard>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Post(dto) as TimeCard;
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

        public TimeCard Post(TimeCardCopy request)
        {
            TimeCard ret = null;
            Execute.Run(ssn =>
            {
                var entity = DocEntityTimeCard.GetTimeCard(request?.Id);
                if(null == entity) throw new HttpError(HttpStatusCode.NoContent, "The COPY request did not succeed.");
                if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");
                
                    var pDescription = entity.Description;
                    if(!DocTools.IsNullOrEmpty(pDescription))
                        pDescription += " (Copy)";
                    var pDocument = entity.Document;
                    var pEnd = entity.End;
                    var pPICO = entity.PICO;
                    var pReferenceId = entity.ReferenceId;
                    var pStart = entity.Start;
                    var pStatus = entity.Status;
                    var pUser = entity.User;
                    var pWorkType = entity.WorkType;
                var copy = new DocEntityTimeCard(ssn)
                {
                    Hash = Guid.NewGuid()
                                , Description = pDescription
                                , Document = pDocument
                                , End = pEnd
                                , PICO = pPICO
                                , ReferenceId = pReferenceId
                                , Start = pStart
                                , Status = pStatus
                                , User = pUser
                                , WorkType = pWorkType
                };
                copy.SaveChanges(DocConstantPermission.ADD);
                ret = copy.ToDto();
            });
            return ret;
        }


        public List<TimeCard> Put(TimeCardBatch request)
        {
            return Patch(request);
        }

        public TimeCard Put(TimeCard dtoSource)
        {
            return Patch(dtoSource);
        }

        public List<TimeCard> Patch(TimeCardBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<TimeCard>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Patch(dto) as TimeCard;
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

        public TimeCard Patch(TimeCard dtoSource)
        {
            if(true != (dtoSource?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the TimeCard to patch.");
            
            dtoSource.VisibleFields = dtoSource.VisibleFields ?? new List<string>();
            
            TimeCard ret = null;
            Execute.Run(ssn =>
            {
                ret = _AssignValues(dtoSource, DocConstantPermission.EDIT, ssn);
            });
            return ret;
        }

        public void Delete(TimeCardBatch request)
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

        public void Delete(TimeCard request)
        {
            Execute.Run(ssn =>
            {
                var en = DocEntityTimeCard.GetTimeCard(request?.Id);

                if(null == en) throw new HttpError(HttpStatusCode.NotFound, $"No TimeCard could be found for Id {request?.Id}.");
                if(en.IsRemoved) return;
                
                if(!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.DELETE))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have DELETE permission for this route.");
                
                en.Remove();
            });
        }

        public void Delete(TimeCardSearch request)
        {
            var matches = Get(request) as List<TimeCard>;
            if(true != matches?.Any()) throw new HttpError(HttpStatusCode.NotFound, "No matches for request");

            Execute.Run(ssn =>
            {
                matches.ForEach(match =>
                {
                    Delete(match);
                });
            });
        }

        private TimeCard GetTimeCard(TimeCard request)
        {
            var id = request?.Id;
            TimeCard ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetVisibleFields<TimeCard>(currentUser, "TimeCard", request.VisibleFields);

            DocEntityTimeCard entity = null;
            if(id.HasValue)
            {
                entity = DocEntityTimeCard.GetTimeCard(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No TimeCard found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }

        public List<int> Any(TimeCardIds request)
        {
            List<int> ret = null;
            if (currentUser.IsSuperAdmin)
            {
                Execute.Run(s => { ret = Execute.SelectAll<DocEntityTimeCard>().Select(d => d.Id).ToList(); });
            }
            else
            {
                throw new HttpError(HttpStatusCode.Forbidden);
            }
            return ret;
        }
    }
}