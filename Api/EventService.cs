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
using Services.Dto.Security;
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
    public partial class EventService : DocServiceBase
    {
        private IQueryable<DocEntityEvent> _ExecSearch(EventSearch request)
        {
            request = InitSearch<Event, EventSearch>(request);
            IQueryable<DocEntityEvent> entities = null;
            Execute.Run( session => 
            {
                entities = Execute.SelectAll<DocEntityEvent>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new EventFullTextSearch(request);
                    entities = GetFullTextSearch<DocEntityEvent,EventFullTextSearch>(fts, entities);
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
                if(true == request.Archived?.Any() && currentUser.HasProperty(DocConstantModelName.EVENT, nameof(Reference.Archived), DocConstantPermission.VIEW))
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

                if(!DocTools.IsNullOrEmpty(request.AuditRecord) && !DocTools.IsNullOrEmpty(request.AuditRecord.Id))
                {
                    entities = entities.Where(en => en.AuditRecord.Id == request.AuditRecord.Id );
                }
                if(true == request.AuditRecordIds?.Any())
                {
                    entities = entities.Where(en => en.AuditRecord.Id.In(request.AuditRecordIds));
                }
                if(!DocTools.IsNullOrEmpty(request.Description))
                    entities = entities.Where(en => en.Description.Contains(request.Description));
                if(!DocTools.IsNullOrEmpty(request.Processed))
                    entities = entities.Where(en => null != en.Processed && request.Processed.Value.Date == en.Processed.Value.Date);
                if(!DocTools.IsNullOrEmpty(request.ProcessedBefore))
                    entities = entities.Where(en => en.Processed <= request.ProcessedBefore);
                if(!DocTools.IsNullOrEmpty(request.ProcessedAfter))
                    entities = entities.Where(en => en.Processed >= request.ProcessedAfter);
                if(!DocTools.IsNullOrEmpty(request.Status))
                    entities = entities.Where(en => en.Status.Contains(request.Status));
                if(true == request.TeamsIds?.Any())
                {
                    entities = entities.Where(en => en.Teams.Any(r => r.Id.In(request.TeamsIds)));
                }
                if(true == request.UpdatesIds?.Any())
                {
                    entities = entities.Where(en => en.Updates.Any(r => r.Id.In(request.UpdatesIds)));
                }
                if(true == request.UsersIds?.Any())
                {
                    entities = entities.Where(en => en.Users.Any(r => r.Id.In(request.UsersIds)));
                }

                entities = ApplyFilters<DocEntityEvent,EventSearch>(request, entities);

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

        public List<Event> Post(EventSearch request) => Get(request);

        public List<Event> Get(EventSearch request) => GetSearchResult<Event,DocEntityEvent,EventSearch>(DocConstantModelName.EVENT, request, _ExecSearch);

        public Event Get(Event request) => GetEntity<Event>(DocConstantModelName.EVENT, request, GetEvent);



        public object Get(EventJunction request) =>
            Execute.Run( s => 
            {
                switch(request.Junction.ToLower().TrimAndPruneSpaces())
                {
                    case "team":
                        return GetJunctionSearchResult<Event, DocEntityEvent, DocEntityTeam, Team, TeamSearch>((int)request.Id, DocConstantModelName.TEAM, "Teams", request, (ss) => HostContext.ResolveService<TeamService>(Request)?.Get(ss));
                    case "update":
                        return GetJunctionSearchResult<Event, DocEntityEvent, DocEntityUpdate, Update, UpdateSearch>((int)request.Id, DocConstantModelName.UPDATE, "Updates", request, (ss) => HostContext.ResolveService<UpdateService>(Request)?.Get(ss));
                    case "user":
                        return GetJunctionSearchResult<Event, DocEntityEvent, DocEntityUser, User, UserSearch>((int)request.Id, DocConstantModelName.USER, "Users", request, (ss) => HostContext.ResolveService<UserService>(Request)?.Get(ss));
                    default:
                        throw new HttpError(HttpStatusCode.NotFound, $"Route for event/{request.Id}/{request.Junction} was not found");
                }
            });

        private Event GetEvent(Event request)
        {
            var id = request?.Id;
            Event ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetVisibleFields<Event>(currentUser, "Event", request.VisibleFields);

            DocEntityEvent entity = null;
            if(id.HasValue)
            {
                entity = DocEntityEvent.GetEvent(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No Event found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }
    }
}