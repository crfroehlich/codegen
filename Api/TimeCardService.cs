//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated by a T4 template. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.CodeDom.Compiler;
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
    public partial class TimeCardService : DocServiceBase
    {

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private IQueryable<DocEntityTimeCard> _ExecSearch(TimeCardSearch request, DocQuery query)
        {
            request = InitSearch<TimeCard, TimeCardSearch>(request);
            IQueryable<DocEntityTimeCard> entities = null;
            query.Run( session => 
            {
                entities = query.SelectAll<DocEntityTimeCard>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new TimeCardFullTextSearch(request);
                    entities = GetFullTextSearch<DocEntityTimeCard,TimeCardFullTextSearch>(fts, entities);
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
                if(true == request.Archived?.Any() && currentUser.HasProperty(DocConstantModelName.TIMECARD, nameof(Reference.Archived), DocConstantPermission.VIEW))
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
                if(!DocTools.IsNullOrEmpty(request.Description))
                    entities = entities.Where(en => en.Description.Contains(request.Description));
                if(!DocTools.IsNullOrEmpty(request.Descriptions))
                    entities = entities.Where(en => en.Description.In(request.Descriptions));
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
                if(!DocTools.IsNullOrEmpty(request.Project) && !DocTools.IsNullOrEmpty(request.Project.Id))
                {
                    entities = entities.Where(en => en.Project.Id == request.Project.Id );
                }
                if(true == request.ProjectIds?.Any())
                {
                    entities = entities.Where(en => en.Project.Id.In(request.ProjectIds));
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

                entities = ApplyFilters<DocEntityTimeCard,TimeCardSearch>(request, entities);

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
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Post(TimeCardSearch request) => Get(request);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Get(TimeCardSearch request) => GetSearchResultWithCache<TimeCard,DocEntityTimeCard,TimeCardSearch>(DocConstantModelName.TIMECARD, request, _ExecSearch);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Get(TimeCard request) => GetEntityWithCache<TimeCard>(DocConstantModelName.TIMECARD, request, GetTimeCard);



        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private TimeCard _AssignValues(TimeCard request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "TimeCard"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.Select = request.Select ?? new List<string>();

            TimeCard ret = null;
            request = _InitAssignValues<TimeCard>(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            var cacheKey = GetApiCacheKey<TimeCard>(DocConstantModelName.TIMECARD, nameof(TimeCard), request);
            
            //First, assign all the variables, do database lookups and conversions
            var pDescription = request.Description;
            var pDocument = DocEntityDocument.Get(request.Document?.Id, true, Execute) ?? DocEntityDocument.Get(request.DocumentId, true, Execute);
            var pEnd = request.End;
            var pProject = DocEntityProject.Get(request.Project?.Id, true, Execute) ?? DocEntityProject.Get(request.ProjectId, true, Execute);
            var pReferenceId = request.ReferenceId;
            var pStart = request.Start;
            DocEntityLookupTable pStatus = GetLookup(DocConstantLookupTable.TIMECARDSTATUS, request.Status?.Name, request.Status?.Id);
            var pUser = DocEntityUser.Get(request.User?.Id, true, Execute) ?? DocEntityUser.Get(request.UserId, true, Execute);
            DocEntityLookupTable pWorkType = GetLookup(DocConstantLookupTable.WORKTYPE, request.WorkType?.Name, request.WorkType?.Id);
            var pArchived = true == request.Archived;
            var pLocked = request.Locked;

            var entity = InitEntity<DocEntityTimeCard,TimeCard>(request, permission, session);

            if (AllowPatchValue<TimeCard, bool>(request, DocConstantModelName.TIMECARD, pArchived, permission, nameof(request.Archived), pArchived != entity.Archived))
            {
                entity.Archived = pArchived;
            }
            if (AllowPatchValue<TimeCard, string>(request, DocConstantModelName.TIMECARD, pDescription, permission, nameof(request.Description), pDescription != entity.Description))
            {
                entity.Description = pDescription;
            }
            if (AllowPatchValue<TimeCard, DocEntityDocument>(request, DocConstantModelName.TIMECARD, pDocument, permission, nameof(request.Document), pDocument != entity.Document))
            {
                entity.Document = pDocument;
            }
            if (AllowPatchValue<TimeCard, DateTime?>(request, DocConstantModelName.TIMECARD, pEnd, permission, nameof(request.End), pEnd != entity.End))
            {
                if(null != pEnd) entity.End = (DateTime) pEnd;
            }
            if (AllowPatchValue<TimeCard, DocEntityProject>(request, DocConstantModelName.TIMECARD, pProject, permission, nameof(request.Project), pProject != entity.Project))
            {
                entity.Project = pProject;
            }
            if (AllowPatchValue<TimeCard, int?>(request, DocConstantModelName.TIMECARD, pReferenceId, permission, nameof(request.ReferenceId), pReferenceId != entity.ReferenceId))
            {
                entity.ReferenceId = pReferenceId;
            }
            if (AllowPatchValue<TimeCard, DateTime?>(request, DocConstantModelName.TIMECARD, pStart, permission, nameof(request.Start), pStart != entity.Start))
            {
                if(null != pStart) entity.Start = (DateTime) pStart;
            }
            if (AllowPatchValue<TimeCard, DocEntityLookupTable>(request, DocConstantModelName.TIMECARD, pStatus, permission, nameof(request.Status), pStatus != entity.Status))
            {
                entity.Status = pStatus;
            }
            if (AllowPatchValue<TimeCard, DocEntityUser>(request, DocConstantModelName.TIMECARD, pUser, permission, nameof(request.User), pUser != entity.User))
            {
                entity.User = pUser;
            }
            if (AllowPatchValue<TimeCard, DocEntityLookupTable>(request, DocConstantModelName.TIMECARD, pWorkType, permission, nameof(request.WorkType), pWorkType != entity.WorkType))
            {
                entity.WorkType = pWorkType;
            }
            if (request.Locked && AllowPatchValue<TimeCard, bool>(request, DocConstantModelName.TIMECARD, pArchived, permission, nameof(request.Locked), pLocked != entity.Locked))
            {
                entity.Archived = pArchived;
            }
            entity.SaveChanges(permission);

            var idsToInvalidate = new List<int>();

            if (idsToInvalidate.Any())
            {
                idsToInvalidate.Add(entity.Id);
                DocCacheClient.RemoveByEntityIds(idsToInvalidate);
                DocCacheClient.RemoveSearch(DocConstantModelName.TIMECARD);
            }

            entity.SaveChanges(permission);
            DocPermissionFactory.SetSelect<TimeCard>(currentUser, nameof(TimeCard), request.Select);
            ret = entity.ToDto();

            var cacheExpires = DocResources.Metadata.GetCacheExpiration(DocConstantModelName.TIMECARD);
            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.TIMECARD, cacheExpires);

            return ret;
        }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public TimeCard Post(TimeCard request)
        {
            if(request == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            request.Select = request.Select ?? new List<string>();

            TimeCard ret = null;

            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "TimeCard")) 
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                    ret = _AssignValues(request, DocConstantPermission.ADD, ssn);
                });
            }
            return ret;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
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
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public TimeCard Post(TimeCardCopy request)
        {
            TimeCard ret = null;
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    var entity = DocEntityTimeCard.Get(request?.Id);
                    if(null == entity) throw new HttpError(HttpStatusCode.NoContent, "The COPY request did not succeed.");
                    if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD))
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                    var pDescription = entity.Description;
                    if(!DocTools.IsNullOrEmpty(pDescription))
                        pDescription += " (Copy)";
                    var pDocument = entity.Document;
                    var pEnd = entity.End;
                    var pProject = entity.Project;
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
                                , Project = pProject
                                , ReferenceId = pReferenceId
                                , Start = pStart
                                , Status = pStatus
                                , User = pUser
                                , WorkType = pWorkType
                    };

                    copy.SaveChanges(DocConstantPermission.ADD);
                    ret = copy.ToDto();
                });
            }
            return ret;
        }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<TimeCard> Put(TimeCardBatch request)
        {
            return Patch(request);
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public TimeCard Put(TimeCard request)
        {
            return Patch(request);
        }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
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
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public TimeCard Patch(TimeCard request)
        {
            if(true != (request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the TimeCard to patch.");
            
            request.Select = request.Select ?? new List<string>();
            
            TimeCard ret = null;
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    ret = _AssignValues(request, DocConstantPermission.EDIT, ssn);
                });
            }
            return ret;
        }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
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
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public void Delete(TimeCard request)
        {
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    if(!(request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, $"No Id provided for delete.");

                    var en = DocEntityTimeCard.Get(request?.Id);
                    if(null == en) throw new HttpError(HttpStatusCode.NotFound, $"No TimeCard could be found for Id {request?.Id}.");
                    if(en.IsRemoved) return;
                
                    if(!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.DELETE))
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have DELETE permission for this route.");
                
                    en.Remove();

                    DocCacheClient.RemoveSearch(DocConstantModelName.TIMECARD);
                    DocCacheClient.RemoveById(request.Id);
                });
            }
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public void Delete(TimeCardSearch request)
        {
            var matches = Get(request) as List<TimeCard>;
            if(true != matches?.Any()) throw new HttpError(HttpStatusCode.NotFound, "No matches for request");
            matches.ForEach(match =>
            {
                Delete(match);
            });
        }




        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private TimeCard GetTimeCard(TimeCard request)
        {
            var id = request?.Id;
            TimeCard ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetSelect<TimeCard>(currentUser, "TimeCard", request.Select);

            DocEntityTimeCard entity = null;
            if(id.HasValue)
            {
                entity = DocEntityTimeCard.Get(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No TimeCard found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }

    }
}
