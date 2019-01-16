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
    public partial class OutcomeService : DocServiceBase
    {
        private void _ExecSearch(OutcomeSearch request, Action<IQueryable<DocEntityOutcome>> callBack)
        {
            request = InitSearch(request);
            
            DocPermissionFactory.SetVisibleFields<OutcomeDto>(currentUser, "Outcome", request.VisibleFields);

            Execute.Run( session => 
            {
                var entities = Execute.SelectAll<DocEntityOutcome>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new OutcomeFullTextSearch(request);
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

                if(!DocTools.IsNullOrEmpty(request.Outcome) && !DocTools.IsNullOrEmpty(request.Outcome.Id))
                {
                    entities = entities.Where(en => en.Outcome.Id == request.Outcome.Id );
                }
                if(true == request.OutcomeIds?.Any())
                {
                    entities = entities.Where(en => en.Outcome.Id.In(request.OutcomeIds));
                }
                else if(!DocTools.IsNullOrEmpty(request.Outcome) && !DocTools.IsNullOrEmpty(request.Outcome.Name))
                {
                    entities = entities.Where(en => en.Outcome.Name == request.Outcome.Name );
                }
                if(true == request.OutcomeNames?.Any())
                {
                    entities = entities.Where(en => en.Outcome.Name.In(request.OutcomeNames));
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
            });
        }
        
        public object Post(OutcomeSearch request)
        {
            return Get(request);
        }

        public object Get(OutcomeSearch request)
        {
            object tryRet = null;
            var ret = new List<OutcomeDto>();
            var cacheKey = GetApiCacheKey<OutcomeDto>(DocConstantModelName.OUTCOME, nameof(OutcomeDto), request);
            using (var cancellableRequest = base.Request.CreateCancellableRequest())
            {
                var requestCancel = new DocRequestCancellation(HttpContext.Current.Response, cancellableRequest);
                try 
                {
                    if (tryRet == null)
                    {
                        _ExecSearch(request, (entities) => entities.ConvertFromEntityList<DocEntityOutcome,OutcomeDto>(ret, Execute, requestCancel));
                        tryRet = ret;
                        //Go ahead and cache the result for any future consumers
                        DocCacheClient.Set(key: cacheKey, value: ret, entityType: DocConstantModelName.OUTCOME, search: true);
                    }
                }
                catch(Exception) { throw; }
                finally
                {
                    requestCancel?.CloseRequest();
                }
            }
            DocCacheClient.SyncKeys(key: cacheKey, entityType: DocConstantModelName.OUTCOME, search: true);
            return tryRet;
        }

        public object Post(OutcomeVersion request) 
        {
            return Get(request);
        }

        public object Get(OutcomeVersion request) 
        {
            var ret = new List<Version>();
            _ExecSearch(request, (entities) => 
            {
                ret = entities.Select(e => new Version(e.Id, e.VersionNo)).ToList();
            });
            return ret;
        }

        public object Get(OutcomeDto request)
        {
            object ret = null;
            
            if(!(request.Id > 0))
                throw new HttpError(HttpStatusCode.NotFound, "Valid Id required.");

            DocPermissionFactory.SetVisibleFields<OutcomeDto>(currentUser, "Outcome", request.VisibleFields);
            var cacheKey = GetApiCacheKey<OutcomeDto>(DocConstantModelName.OUTCOME, nameof(OutcomeDto), request);
            if(null == ret)
            {
                Execute.Run(s =>
                {
                    ret = GetOutcome(request);
                    DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.OUTCOME);
                });
            }
            DocCacheClient.SyncKeys(key: cacheKey, entityId: request.Id, entityType: DocConstantModelName.OUTCOME);
            return ret;
        }

        private OutcomeDto _AssignValues(OutcomeDto request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "Outcome"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            OutcomeDto ret = null;
            request = _InitAssignValues(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            var cacheKey = GetApiCacheKey<OutcomeDto>(DocConstantModelName.OUTCOME, nameof(OutcomeDto), request);
            
            //First, assign all the variables, do database lookups and conversions
            DocEntityLookupTable pOutcome = GetLookup(DocConstantLookupTable.ATTRIBUTENAME, request.Outcome?.Name, request.Outcome?.Id);

            DocEntityOutcome entity = null;
            if(permission == DocConstantPermission.ADD)
            {
                var now = DateTime.UtcNow;
                entity = new DocEntityOutcome(session)
                {
                    Created = now,
                    Updated = now
                };
            }
            else
            {
                entity = DocEntityOutcome.GetOutcome(request.Id);
                if(null == entity)
                    throw new HttpError(HttpStatusCode.NotFound, $"No record");
            }

            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityLookupTable>(currentUser, request, pOutcome, permission, DocConstantModelName.OUTCOME, nameof(request.Outcome)))
            {
                if(DocPermissionFactory.IsRequested(request, pOutcome, entity.Outcome, nameof(request.Outcome)))
                    entity.Outcome = pOutcome;
                if(DocPermissionFactory.IsRequested<DocEntityLookupTable>(request, pOutcome, nameof(request.Outcome)) && !request.VisibleFields.Matches(nameof(request.Outcome), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Outcome));
                }
            }
            
            if (request.Locked) entity.Locked = request.Locked;

            entity.SaveChanges(permission);
            
            DocPermissionFactory.SetVisibleFields<OutcomeDto>(currentUser, nameof(OutcomeDto), request.VisibleFields);
            ret = entity.ToDto();

            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.OUTCOME);

            return ret;
        }
        public OutcomeDto Post(OutcomeDto request)
        {
            if(request == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            OutcomeDto ret = null;

            Execute.Run(ssn =>
            {
                if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "Outcome")) 
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                ret = _AssignValues(request, DocConstantPermission.ADD, ssn);
            });

            return ret;
        }
   
        public List<OutcomeDto> Post(OutcomeBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<OutcomeDto>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Post(dto) as OutcomeDto;
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

        public OutcomeDto Post(OutcomeDtoCopy request)
        {
            OutcomeDto ret = null;
            Execute.Run(ssn =>
            {
                var entity = DocEntityOutcome.GetOutcome(request?.Id);
                if(null == entity) throw new HttpError(HttpStatusCode.NoContent, "The COPY request did not succeed.");
                if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");
                
                    var pOutcome = entity.Outcome;
                #region Custom Before copyOutcome
                #endregion Custom Before copyOutcome
                var copy = new DocEntityOutcome(ssn)
                {
                    Hash = Guid.NewGuid()
                                , Outcome = pOutcome
                };
                #region Custom After copyOutcome
                #endregion Custom After copyOutcome
                copy.SaveChanges(DocConstantPermission.ADD);
                ret = copy.ToDto();
            });
            return ret;
        }


        public List<OutcomeDto> Put(OutcomeBatch request)
        {
            return Patch(request);
        }

        public OutcomeDto Put(OutcomeDto request)
        {
            return Patch(request);
        }

        public List<OutcomeDto> Patch(OutcomeBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<OutcomeDto>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Patch(dto) as OutcomeDto;
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

        public OutcomeDto Patch(OutcomeDto request)
        {
            if(true != (request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the Outcome to patch.");
            
            request.VisibleFields = request.VisibleFields ?? new List<string>();
            
            OutcomeDto ret = null;
            Execute.Run(ssn =>
            {
                ret = _AssignValues(request, DocConstantPermission.EDIT, ssn);
            });
            return ret;
        }

        public void Delete(OutcomeBatch request)
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

        public void Delete(OutcomeDto request)
        {
            Execute.Run(ssn =>
            {
                if(!(request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, $"No Id provided for delete.");

                DocCacheClient.RemoveSearch(DocConstantModelName.OUTCOME);
                DocCacheClient.RemoveById(request.Id);
                var en = DocEntityOutcome.GetOutcome(request?.Id);

                if(null == en) throw new HttpError(HttpStatusCode.NotFound, $"No Outcome could be found for Id {request?.Id}.");
                if(en.IsRemoved) return;
                
                if(!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.DELETE))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have DELETE permission for this route.");
                
                en.Remove();
            });
        }

        public void Delete(OutcomeSearch request)
        {
            var matches = Get(request) as List<OutcomeDto>;
            if(true != matches?.Any()) throw new HttpError(HttpStatusCode.NotFound, "No matches for request");

            Execute.Run(ssn =>
            {
                matches.ForEach(match =>
                {
                    Delete(match);
                });
            });
        }

        private OutcomeDto GetOutcome(OutcomeDto request)
        {
            var id = request?.Id;
            OutcomeDto ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetVisibleFields<OutcomeDto>(currentUser, "Outcome", request.VisibleFields);

            DocEntityOutcome entity = null;
            if(id.HasValue)
            {
                entity = DocEntityOutcome.GetOutcome(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No Outcome found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }

        public List<int> Any(OutcomeIds request)
        {
            List<int> ret = null;
            if (currentUser.IsSuperAdmin)
            {
                Execute.Run(s => { ret = Execute.SelectAll<DocEntityOutcome>().Select(d => d.Id).ToList(); });
            }
            else
            {
                throw new HttpError(HttpStatusCode.Forbidden);
            }

            return ret;
        }
    }
}