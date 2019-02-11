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
    public partial class UserRequestService : DocServiceBase
    {
        private IQueryable<DocEntityUserRequest> _ExecSearch(UserRequestSearch request)
        {
            request = InitSearch<UserRequest, UserRequestSearch>(request);
            IQueryable<DocEntityUserRequest> entities = null;
            Execute.Run( session => 
            {
                entities = Execute.SelectAll<DocEntityUserRequest>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new UserRequestFullTextSearch(request);
                    entities = GetFullTextSearch<DocEntityUserRequest,UserRequestFullTextSearch>(fts, entities);
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

                if(!DocTools.IsNullOrEmpty(request.App) && !DocTools.IsNullOrEmpty(request.App.Id))
                {
                    entities = entities.Where(en => en.App.Id == request.App.Id );
                }
                if(true == request.AppIds?.Any())
                {
                    entities = entities.Where(en => en.App.Id.In(request.AppIds));
                }
                if(!DocTools.IsNullOrEmpty(request.Method))
                    entities = entities.Where(en => en.Method.Contains(request.Method));
                if(!DocTools.IsNullOrEmpty(request.Page) && !DocTools.IsNullOrEmpty(request.Page.Id))
                {
                    entities = entities.Where(en => en.Page.Id == request.Page.Id );
                }
                if(true == request.PageIds?.Any())
                {
                    entities = entities.Where(en => en.Page.Id.In(request.PageIds));
                }
                if(!DocTools.IsNullOrEmpty(request.Path))
                    entities = entities.Where(en => en.Path.Contains(request.Path));
                if(!DocTools.IsNullOrEmpty(request.URL))
                    entities = entities.Where(en => en.URL.Contains(request.URL));
                if(!DocTools.IsNullOrEmpty(request.UserSession) && !DocTools.IsNullOrEmpty(request.UserSession.Id))
                {
                    entities = entities.Where(en => en.UserSession.Id == request.UserSession.Id );
                }
                if(true == request.UserSessionIds?.Any())
                {
                    entities = entities.Where(en => en.UserSession.Id.In(request.UserSessionIds));
                }

                entities = ApplyFilters<DocEntityUserRequest,UserRequestSearch>(request, entities);

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

        public List<UserRequest> Post(UserRequestSearch request) => Get(request);

        public List<UserRequest> Get(UserRequestSearch request) => GetSearchResult<UserRequest,DocEntityUserRequest,UserRequestSearch>(DocConstantModelName.USERREQUEST, request, _ExecSearch);

        public UserRequest Get(UserRequest request) => GetEntity<UserRequest>(DocConstantModelName.USERREQUEST, request, GetUserRequest);




        private UserRequest GetUserRequest(UserRequest request)
        {
            var id = request?.Id;
            UserRequest ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetVisibleFields<UserRequest>(currentUser, "UserRequest", request.VisibleFields);

            DocEntityUserRequest entity = null;
            if(id.HasValue)
            {
                entity = DocEntityUserRequest.GetUserRequest(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No UserRequest found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }
    }
}