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
    public partial class StatsService : DocServiceBase
    {
        private IQueryable<DocEntityStats> _ExecSearch(StatsSearch request, DocQuery query)
        {
            request = InitSearch<Stats, StatsSearch>(request);
            IQueryable<DocEntityStats> entities = null;
            query.Run( session => 
            {
                entities = query.SelectAll<DocEntityStats>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new StatsFullTextSearch(request);
                    entities = GetFullTextSearch<DocEntityStats,StatsFullTextSearch>(fts, entities);
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
                if(true == request.Archived?.Any() && currentUser.HasProperty(DocConstantModelName.STATS, nameof(Reference.Archived), DocConstantPermission.VIEW))
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

                if(!DocTools.IsNullOrEmpty(request.App) && !DocTools.IsNullOrEmpty(request.App.Id))
                {
                    entities = entities.Where(en => en.App.Id == request.App.Id );
                }
                if(true == request.AppIds?.Any())
                {
                    entities = entities.Where(en => en.App.Id.In(request.AppIds));
                }
                if(request.ExternalId.HasValue)
                    entities = entities.Where(en => request.ExternalId.Value == en.ExternalId);
                if(!DocTools.IsNullOrEmpty(request.ExternalType))
                    entities = entities.Where(en => en.ExternalType.Contains(request.ExternalType));
                if(request.ObjectId.HasValue)
                    entities = entities.Where(en => request.ObjectId.Value == en.ObjectId);
                if(!DocTools.IsNullOrEmpty(request.ObjectType))
                    entities = entities.Where(en => en.ObjectType.Contains(request.ObjectType));
                if(!DocTools.IsNullOrEmpty(request.StudySetStats) && !DocTools.IsNullOrEmpty(request.StudySetStats.Id))
                {
                    entities = entities.Where(en => en.StudySetStats.Id == request.StudySetStats.Id );
                }
                if(true == request.StudySetStatsIds?.Any())
                {
                    entities = entities.Where(en => en.StudySetStats.Id.In(request.StudySetStatsIds));
                }

                entities = ApplyFilters<DocEntityStats,StatsSearch>(request, entities);

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

        public object Post(StatsSearch request) => Get(request);

        public object Get(StatsSearch request) => GetSearchResultWithCache<Stats,DocEntityStats,StatsSearch>(DocConstantModelName.STATS, request, _ExecSearch);

        public object Get(Stats request) => GetEntityWithCache<Stats>(DocConstantModelName.STATS, request, GetStats);

        private Stats GetStats(Stats request)
        {
            var id = request?.Id;
            Stats ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetVisibleFields<Stats>(currentUser, "Stats", request.VisibleFields);

            DocEntityStats entity = null;
            if(id.HasValue)
            {
                entity = DocEntityStats.GetStats(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No Stats found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }
    }
}
