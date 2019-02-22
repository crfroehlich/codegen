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
    public partial class UserSessionService : DocServiceBase
    {
        private IQueryable<DocEntityUserSession> _ExecSearch(UserSessionSearch request)
        {
            request = InitSearch<UserSession, UserSessionSearch>(request);
            IQueryable<DocEntityUserSession> entities = null;
            Execute.Run( session => 
            {
                entities = Execute.SelectAll<DocEntityUserSession>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new UserSessionFullTextSearch(request);
                    entities = GetFullTextSearch<DocEntityUserSession,UserSessionFullTextSearch>(fts, entities);
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

                if(!DocTools.IsNullOrEmpty(request.ClientId))
                    entities = entities.Where(en => en.ClientId.Contains(request.ClientId));
                if(request.Hits.HasValue)
                    entities = entities.Where(en => request.Hits.Value == en.Hits);
                if(true == request.ImpersonationsIds?.Any())
                {
                    entities = entities.Where(en => en.Impersonations.Any(r => r.Id.In(request.ImpersonationsIds)));
                }
                if(!DocTools.IsNullOrEmpty(request.IpAddress))
                    entities = entities.Where(en => en.IpAddress.Contains(request.IpAddress));
                if(true == request.RequestsIds?.Any())
                {
                    entities = entities.Where(en => en.Requests.Any(r => r.Id.In(request.RequestsIds)));
                }
                if(!DocTools.IsNullOrEmpty(request.SessionId))
                    entities = entities.Where(en => en.SessionId.Contains(request.SessionId));
                if(!DocTools.IsNullOrEmpty(request.TemporarySessionId))
                    entities = entities.Where(en => en.TemporarySessionId.Contains(request.TemporarySessionId));
                if(!DocTools.IsNullOrEmpty(request.User) && !DocTools.IsNullOrEmpty(request.User.Id))
                {
                    entities = entities.Where(en => en.User.Id == request.User.Id );
                }
                if(true == request.UserIds?.Any())
                {
                    entities = entities.Where(en => en.User.Id.In(request.UserIds));
                }
                if(true == request.UserHistoryIds?.Any())
                {
                    entities = entities.Where(en => en.UserHistory.Any(r => r.Id.In(request.UserHistoryIds)));
                }

                entities = ApplyFilters<DocEntityUserSession,UserSessionSearch>(request, entities);

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

        public object Post(UserSessionSearch request) => Get(request);

        public object Get(UserSessionSearch request) => GetSearchResultWithCache<UserSession,DocEntityUserSession,UserSessionSearch>(DocConstantModelName.USERSESSION, request, _ExecSearch);

        public object Get(UserSession request) => GetEntityWithCache<UserSession>(DocConstantModelName.USERSESSION, request, GetUserSession);



        public object Get(UserSessionJunction request) =>
            Execute.Run( s => 
            {
                switch(request.Junction.ToLower().TrimAndPruneSpaces())
                {
                    case "impersonation":
                        return GetJunctionSearchResult<UserSession, DocEntityUserSession, DocEntityImpersonation, Impersonation, ImpersonationSearch>((int)request.Id, DocConstantModelName.IMPERSONATION, "Impersonations", request, (ss) => HostContext.ResolveService<ImpersonationService>(Request)?.Get(ss));
                    case "request":
                        return GetJunctionSearchResult<UserSession, DocEntityUserSession, DocEntityUserRequest, UserRequest, UserRequestSearch>((int)request.Id, DocConstantModelName.USERREQUEST, "Requests", request, (ss) => HostContext.ResolveService<UserRequestService>(Request)?.Get(ss));
                    case "history":
                        return GetJunctionSearchResult<UserSession, DocEntityUserSession, DocEntityHistory, History, HistorySearch>((int)request.Id, DocConstantModelName.HISTORY, "UserHistory", request, (ss) => HostContext.ResolveService<HistoryService>(Request)?.Get(ss));
                    default:
                        throw new HttpError(HttpStatusCode.NotFound, $"Route for usersession/{request.Id}/{request.Junction} was not found");
                }
            });
        public object Post(UserSessionJunction request) =>
            Execute.Run( ssn =>
            {
                switch(request.Junction.ToLower().TrimAndPruneSpaces())
                {
                    case "impersonation":
                        return AddJunction<UserSession, DocEntityUserSession, DocEntityImpersonation, Impersonation, ImpersonationSearch>((int)request.Id, DocConstantModelName.IMPERSONATION, "Impersonations", request);
                    default:
                        throw new HttpError(HttpStatusCode.NotFound, $"Route for usersession/{request.Id}/{request.Junction} was not found");
                }
            });

        public object Delete(UserSessionJunction request) =>
            Execute.Run( ssn =>
            {
                switch(request.Junction.ToLower().TrimAndPruneSpaces())
                {
                    case "impersonation":
                        return RemoveJunction<UserSession, DocEntityUserSession, DocEntityImpersonation, Impersonation, ImpersonationSearch>((int)request.Id, DocConstantModelName.IMPERSONATION, "Impersonations", request);
                    default:
                        throw new HttpError(HttpStatusCode.NotFound, $"Route for usersession/{request.Id}/{request.Junction} was not found");
                }
            });

        private UserSession GetUserSession(UserSession request)
        {
            var id = request?.Id;
            UserSession ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetVisibleFields<UserSession>(currentUser, "UserSession", request.VisibleFields);

            DocEntityUserSession entity = null;
            if(id.HasValue)
            {
                entity = DocEntityUserSession.GetUserSession(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No UserSession found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }
    }
}