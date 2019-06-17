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
    public partial class UpdateService : DocServiceBase
    {

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private IQueryable<DocEntityUpdate> _ExecSearch(UpdateSearch request, DocQuery query)
        {
            request = InitSearch<Update, UpdateSearch>(request);
            IQueryable<DocEntityUpdate> entities = null;
            query.Run( session => 
            {
                entities = query.SelectAll<DocEntityUpdate>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new UpdateFullTextSearch(request);
                    entities = GetFullTextSearch<DocEntityUpdate,UpdateFullTextSearch>(fts, entities);
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
                if(true == request.Archived?.Any() && currentUser.HasProperty(DocConstantModelName.UPDATE, nameof(Reference.Archived), DocConstantPermission.VIEW))
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
                if(!DocTools.IsNullOrEmpty(request.Body))
                    entities = entities.Where(en => en.Body.Contains(request.Body));
                if(!DocTools.IsNullOrEmpty(request.Bodys))
                    entities = entities.Where(en => en.Body.In(request.Bodys));
                if(!DocTools.IsNullOrEmpty(request.DeliveryStatus))
                    entities = entities.Where(en => en.DeliveryStatus.Contains(request.DeliveryStatus));
                if(!DocTools.IsNullOrEmpty(request.DeliveryStatuss))
                    entities = entities.Where(en => en.DeliveryStatus.In(request.DeliveryStatuss));
                if(request.EmailAttempts.HasValue)
                    entities = entities.Where(en => request.EmailAttempts.Value == en.EmailAttempts);
                if(!DocTools.IsNullOrEmpty(request.EmailSent))
                    entities = entities.Where(en => null != en.EmailSent && request.EmailSent.Value.Date == en.EmailSent.Value.Date);
                if(!DocTools.IsNullOrEmpty(request.EmailSentBefore))
                    entities = entities.Where(en => en.EmailSent <= request.EmailSentBefore);
                if(!DocTools.IsNullOrEmpty(request.EmailSentAfter))
                    entities = entities.Where(en => en.EmailSent >= request.EmailSentAfter);
                if(true == request.EventsIds?.Any())
                {
                    entities = entities.Where(en => en.Events.Any(r => r.Id.In(request.EventsIds)));
                }
                if(!DocTools.IsNullOrEmpty(request.Link))
                    entities = entities.Where(en => en.Link.Contains(request.Link));
                if(!DocTools.IsNullOrEmpty(request.Links))
                    entities = entities.Where(en => en.Link.In(request.Links));
                if(request.Priority.HasValue)
                    entities = entities.Where(en => request.Priority.Value == en.Priority);
                if(!DocTools.IsNullOrEmpty(request.Read))
                    entities = entities.Where(en => null != en.Read && request.Read.Value.Date == en.Read.Value.Date);
                if(!DocTools.IsNullOrEmpty(request.ReadBefore))
                    entities = entities.Where(en => en.Read <= request.ReadBefore);
                if(!DocTools.IsNullOrEmpty(request.ReadAfter))
                    entities = entities.Where(en => en.Read >= request.ReadAfter);
                if(!DocTools.IsNullOrEmpty(request.SlackSent))
                    entities = entities.Where(en => null != en.SlackSent && request.SlackSent.Value.Date == en.SlackSent.Value.Date);
                if(!DocTools.IsNullOrEmpty(request.SlackSentBefore))
                    entities = entities.Where(en => en.SlackSent <= request.SlackSentBefore);
                if(!DocTools.IsNullOrEmpty(request.SlackSentAfter))
                    entities = entities.Where(en => en.SlackSent >= request.SlackSentAfter);
                if(!DocTools.IsNullOrEmpty(request.Subject))
                    entities = entities.Where(en => en.Subject.Contains(request.Subject));
                if(!DocTools.IsNullOrEmpty(request.Subjects))
                    entities = entities.Where(en => en.Subject.In(request.Subjects));
                if(!DocTools.IsNullOrEmpty(request.Team) && !DocTools.IsNullOrEmpty(request.Team.Id))
                {
                    entities = entities.Where(en => en.Team.Id == request.Team.Id );
                }
                if(true == request.TeamIds?.Any())
                {
                    entities = entities.Where(en => en.Team.Id.In(request.TeamIds));
                }
                if(!DocTools.IsNullOrEmpty(request.User) && !DocTools.IsNullOrEmpty(request.User.Id))
                {
                    entities = entities.Where(en => en.User.Id == request.User.Id );
                }
                if(true == request.UserIds?.Any())
                {
                    entities = entities.Where(en => en.User.Id.In(request.UserIds));
                }

                entities = ApplyFilters<DocEntityUpdate,UpdateSearch>(request, entities);

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
        public object Post(UpdateSearch request) => Get(request);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Get(UpdateSearch request) => GetSearchResultWithCache<Update,DocEntityUpdate,UpdateSearch>(DocConstantModelName.UPDATE, request, _ExecSearch);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Get(Update request) => GetEntityWithCache<Update>(DocConstantModelName.UPDATE, request, GetUpdate);



        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private Update _AssignValues(Update request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "Update"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.Select = request.Select ?? new List<string>();

            Update ret = null;
            request = _InitAssignValues<Update>(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            var cacheKey = GetApiCacheKey<Update>(DocConstantModelName.UPDATE, nameof(Update), request);
            
            //First, assign all the variables, do database lookups and conversions
            var pBody = request.Body;
            var pDeliveryStatus = request.DeliveryStatus;
            var pEmailAttempts = request.EmailAttempts;
            var pEmailSent = request.EmailSent;
            var pEvents = GetVariable<Reference>(request, nameof(request.Events), request.Events?.ToList(), request.EventsIds?.ToList());
            var pLink = request.Link;
            var pPriority = request.Priority;
            var pRead = request.Read;
            var pSlackSent = request.SlackSent;
            var pSubject = request.Subject;
            var pTeam = (request.Team?.Id > 0) ? DocEntityTeam.Get(request.Team.Id) : null;
            var pUser = (request.User?.Id > 0) ? DocEntityUser.Get(request.User.Id) : null;
            var pArchived = true == request.Archived;
            var pLocked = request.Locked;

            var entity = InitEntity<DocEntityUpdate,Update>(request, permission, session);

            if (AllowPatchValue<Update, bool>(request, DocConstantModelName.UPDATE, pArchived, permission, nameof(request.Archived), pArchived != entity.Archived))
            {
                entity.Archived = pArchived;
            }
            if (AllowPatchValue<Update, string>(request, DocConstantModelName.UPDATE, pBody, permission, nameof(request.Body), pBody != entity.Body))
            {
                entity.Body = pBody;
            }
            if (AllowPatchValue<Update, string>(request, DocConstantModelName.UPDATE, pDeliveryStatus, permission, nameof(request.DeliveryStatus), pDeliveryStatus != entity.DeliveryStatus))
            {
                entity.DeliveryStatus = pDeliveryStatus;
            }
            if (AllowPatchValue<Update, int?>(request, DocConstantModelName.UPDATE, pEmailAttempts, permission, nameof(request.EmailAttempts), pEmailAttempts != entity.EmailAttempts))
            {
                if(null != pEmailAttempts) entity.EmailAttempts = (int) pEmailAttempts;
            }
            if (AllowPatchValue<Update, DateTime?>(request, DocConstantModelName.UPDATE, pEmailSent, permission, nameof(request.EmailSent), pEmailSent != entity.EmailSent))
            {
                entity.EmailSent = pEmailSent;
            }
            if (AllowPatchValue<Update, string>(request, DocConstantModelName.UPDATE, pLink, permission, nameof(request.Link), pLink != entity.Link))
            {
                entity.Link = pLink;
            }
            if (AllowPatchValue<Update, int?>(request, DocConstantModelName.UPDATE, pPriority, permission, nameof(request.Priority), pPriority != entity.Priority))
            {
                if(null != pPriority) entity.Priority = (int) pPriority;
            }
            if (AllowPatchValue<Update, DateTime?>(request, DocConstantModelName.UPDATE, pRead, permission, nameof(request.Read), pRead != entity.Read))
            {
                entity.Read = pRead;
            }
            if (AllowPatchValue<Update, DateTime?>(request, DocConstantModelName.UPDATE, pSlackSent, permission, nameof(request.SlackSent), pSlackSent != entity.SlackSent))
            {
                entity.SlackSent = pSlackSent;
            }
            if (AllowPatchValue<Update, string>(request, DocConstantModelName.UPDATE, pSubject, permission, nameof(request.Subject), pSubject != entity.Subject))
            {
                entity.Subject = pSubject;
            }
            if (AllowPatchValue<Update, DocEntityTeam>(request, DocConstantModelName.UPDATE, pTeam, permission, nameof(request.Team), pTeam != entity.Team))
            {
                entity.Team = pTeam;
            }
            if (AllowPatchValue<Update, DocEntityUser>(request, DocConstantModelName.UPDATE, pUser, permission, nameof(request.User), pUser != entity.User))
            {
                entity.User = pUser;
            }
            if (request.Locked && AllowPatchValue<Update, bool>(request, DocConstantModelName.UPDATE, pArchived, permission, nameof(request.Locked), pLocked != entity.Locked))
            {
                entity.Archived = pArchived;
            }
            entity.SaveChanges(permission);

            var idsToInvalidate = new List<int>();
            idsToInvalidate.AddRange(PatchCollection<Update, DocEntityUpdate, Reference, DocEntityEvent>(request, entity, pEvents, permission, nameof(request.Events)));
            if (idsToInvalidate.Any())
            {
                idsToInvalidate.Add(entity.Id);
                DocCacheClient.RemoveByEntityIds(idsToInvalidate);
                DocCacheClient.RemoveSearch(DocConstantModelName.UPDATE);
            }

            DocPermissionFactory.SetSelect<Update>(currentUser, nameof(Update), request.Select);
            ret = entity.ToDto();

            var cacheExpires = DocResources.Metadata.GetCacheExpiration(DocConstantModelName.UPDATE);
            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.UPDATE, cacheExpires);

            return ret;
        }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public Update Post(Update request)
        {
            if(request == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            request.Select = request.Select ?? new List<string>();

            Update ret = null;

            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "Update")) 
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                    ret = _AssignValues(request, DocConstantPermission.ADD, ssn);
                });
            }
            return ret;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<Update> Post(UpdateBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<Update>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Post(dto) as Update;
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
        public Update Post(UpdateCopy request)
        {
            Update ret = null;
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    var entity = DocEntityUpdate.Get(request?.Id);
                    if(null == entity) throw new HttpError(HttpStatusCode.NoContent, "The COPY request did not succeed.");
                    if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD))
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                    var pBody = entity.Body;
                    var pDeliveryStatus = entity.DeliveryStatus;
                    var pEmailAttempts = entity.EmailAttempts;
                    var pEmailSent = entity.EmailSent;
                    var pEvents = entity.Events.ToList();
                    var pLink = entity.Link;
                    if(!DocTools.IsNullOrEmpty(pLink))
                        pLink += " (Copy)";
                    var pPriority = entity.Priority;
                    var pRead = entity.Read;
                    var pSlackSent = entity.SlackSent;
                    var pSubject = entity.Subject;
                    if(!DocTools.IsNullOrEmpty(pSubject))
                        pSubject += " (Copy)";
                    var pTeam = entity.Team;
                    var pUser = entity.User;
                    var copy = new DocEntityUpdate(ssn)
                    {
                        Hash = Guid.NewGuid()
                                , Body = pBody
                                , DeliveryStatus = pDeliveryStatus
                                , EmailAttempts = pEmailAttempts
                                , EmailSent = pEmailSent
                                , Link = pLink
                                , Priority = pPriority
                                , Read = pRead
                                , SlackSent = pSlackSent
                                , Subject = pSubject
                                , Team = pTeam
                                , User = pUser
                    };
                            foreach(var item in pEvents)
                            {
                                entity.Events.Add(item);
                            }

                    copy.SaveChanges(DocConstantPermission.ADD);
                    ret = copy.ToDto();
                });
            }
            return ret;
        }





        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Get(UpdateJunction request)
        {
            switch(request.Junction.ToLower().TrimAndPruneSpaces())
            {
                    case "comment":
                        return GetJunctionSearchResult<Update, DocEntityUpdate, DocEntityComment, Comment, CommentSearch>((int)request.Id, DocConstantModelName.COMMENT, "Comments", request, (ss) => HostContext.ResolveService<CommentService>(Request)?.Get(ss));
                    case "event":
                        return GetJunctionSearchResult<Update, DocEntityUpdate, DocEntityEvent, Event, EventSearch>((int)request.Id, DocConstantModelName.EVENT, "Events", request, (ss) => HostContext.ResolveService<EventService>(Request)?.Get(ss));
                    case "favorite":
                        return GetJunctionSearchResult<Update, DocEntityUpdate, DocEntityFavorite, Favorite, FavoriteSearch>((int)request.Id, DocConstantModelName.FAVORITE, "Favorites", request, (ss) => HostContext.ResolveService<FavoriteService>(Request)?.Get(ss));
                    case "tag":
                        return GetJunctionSearchResult<Update, DocEntityUpdate, DocEntityTag, Tag, TagSearch>((int)request.Id, DocConstantModelName.TAG, "Tags", request, (ss) => HostContext.ResolveService<TagService>(Request)?.Get(ss));
                default:
                    throw new HttpError(HttpStatusCode.NotFound, $"Route for update/{request.Id}/{request.Junction} was not found");
            }
        }



        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private Update GetUpdate(Update request)
        {
            var id = request?.Id;
            Update ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetSelect<Update>(currentUser, "Update", request.Select);

            DocEntityUpdate entity = null;
            if(id.HasValue)
            {
                entity = DocEntityUpdate.Get(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No Update found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }

    }
}
