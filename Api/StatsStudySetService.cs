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
    public partial class StatsStudySetService : DocServiceBase
    {

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private IQueryable<DocEntityStatsStudySet> _ExecSearch(StatsStudySetSearch request, DocQuery query)
        {
            request = InitSearch<StatsStudySet, StatsStudySetSearch>(request);
            IQueryable<DocEntityStatsStudySet> entities = null;
            query.Run( session => 
            {
                entities = query.SelectAll<DocEntityStatsStudySet>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new StatsStudySetFullTextSearch(request);
                    entities = GetFullTextSearch<DocEntityStatsStudySet,StatsStudySetFullTextSearch>(fts, entities);
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
                if(true == request.Archived?.Any() && currentUser.HasProperty(DocConstantModelName.STATSSTUDYSET, nameof(Reference.Archived), DocConstantPermission.VIEW))
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
                if(request.BoundTerms.HasValue)
                    entities = entities.Where(en => request.BoundTerms.Value == en.BoundTerms);
                if(request.Characteristics.HasValue)
                    entities = entities.Where(en => request.Characteristics.Value == en.Characteristics);
                if(request.DataPoints.HasValue)
                    entities = entities.Where(en => request.DataPoints.Value == en.DataPoints);
                if(request.DesignCount.HasValue)
                    entities = entities.Where(en => request.DesignCount.Value == en.DesignCount);
                if(!DocTools.IsNullOrEmpty(request.DesignList))
                    entities = entities.Where(en => en.DesignList.Contains(request.DesignList));
                if(!DocTools.IsNullOrEmpty(request.DesignLists))
                    entities = entities.Where(en => en.DesignList.In(request.DesignLists));
                if(!DocTools.IsNullOrEmpty(request.DocumentSet) && !DocTools.IsNullOrEmpty(request.DocumentSet.Id))
                {
                    entities = entities.Where(en => en.DocumentSet.Id == request.DocumentSet.Id );
                }
                if(true == request.DocumentSetIds?.Any())
                {
                    entities = entities.Where(en => en.DocumentSet.Id.In(request.DocumentSetIds));
                }
                if(request.Interventions.HasValue)
                    entities = entities.Where(en => request.Interventions.Value == en.Interventions);
                if(request.Outcomes.HasValue)
                    entities = entities.Where(en => request.Outcomes.Value == en.Outcomes);
                if(request.OutcomesReported.HasValue)
                    entities = entities.Where(en => request.OutcomesReported.Value == en.OutcomesReported);
                if(true == request.RecordsIds?.Any())
                {
                    entities = entities.Where(en => en.Records.Any(r => r.Id.In(request.RecordsIds)));
                }
                if(!DocTools.IsNullOrEmpty(request.Stat) && !DocTools.IsNullOrEmpty(request.Stat.Id))
                {
                    entities = entities.Where(en => en.Stat.Id == request.Stat.Id );
                }
                if(true == request.StatIds?.Any())
                {
                    entities = entities.Where(en => en.Stat.Id.In(request.StatIds));
                }
                if(request.Studies.HasValue)
                    entities = entities.Where(en => request.Studies.Value == en.Studies);
                if(request.TypeCount.HasValue)
                    entities = entities.Where(en => request.TypeCount.Value == en.TypeCount);
                if(!DocTools.IsNullOrEmpty(request.TypeList))
                    entities = entities.Where(en => en.TypeList.Contains(request.TypeList));
                if(!DocTools.IsNullOrEmpty(request.TypeLists))
                    entities = entities.Where(en => en.TypeList.In(request.TypeLists));
                if(request.UnboundTerms.HasValue)
                    entities = entities.Where(en => request.UnboundTerms.Value == en.UnboundTerms);

                entities = ApplyFilters<DocEntityStatsStudySet,StatsStudySetSearch>(request, entities);

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
        public object Post(StatsStudySetSearch request) => Get(request);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Get(StatsStudySetSearch request) => GetSearchResultWithCache<StatsStudySet,DocEntityStatsStudySet,StatsStudySetSearch>(DocConstantModelName.STATSSTUDYSET, request, _ExecSearch);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Get(StatsStudySet request) => GetEntityWithCache<StatsStudySet>(DocConstantModelName.STATSSTUDYSET, request, GetStatsStudySet);








        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Get(StatsStudySetJunction request)
        {
            switch(request.Junction.ToLower().TrimAndPruneSpaces())
            {
                    case "comment":
                        return GetJunctionSearchResult<StatsStudySet, DocEntityStatsStudySet, DocEntityComment, Comment, CommentSearch>((int)request.Id, DocConstantModelName.COMMENT, "Comments", request, (ss) => HostContext.ResolveService<CommentService>(Request)?.Get(ss));
                    case "favorite":
                        return GetJunctionSearchResult<StatsStudySet, DocEntityStatsStudySet, DocEntityFavorite, Favorite, FavoriteSearch>((int)request.Id, DocConstantModelName.FAVORITE, "Favorites", request, (ss) => HostContext.ResolveService<FavoriteService>(Request)?.Get(ss));
                    case "statsrecord":
                        return GetJunctionSearchResult<StatsStudySet, DocEntityStatsStudySet, DocEntityStatsRecord, StatsRecord, StatsRecordSearch>((int)request.Id, DocConstantModelName.STATSRECORD, "Records", request, (ss) => HostContext.ResolveService<StatsRecordService>(Request)?.Get(ss));
                    case "tag":
                        return GetJunctionSearchResult<StatsStudySet, DocEntityStatsStudySet, DocEntityTag, Tag, TagSearch>((int)request.Id, DocConstantModelName.TAG, "Tags", request, (ss) => HostContext.ResolveService<TagService>(Request)?.Get(ss));
                default:
                    throw new HttpError(HttpStatusCode.NotFound, $"Route for statsstudyset/{request.Id}/{request.Junction} was not found");
            }
        }



        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private StatsStudySet GetStatsStudySet(StatsStudySet request)
        {
            var id = request?.Id;
            StatsStudySet ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetSelect<StatsStudySet>(currentUser, "StatsStudySet", request.Select);

            DocEntityStatsStudySet entity = null;
            if(id.HasValue)
            {
                entity = DocEntityStatsStudySet.Get(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No StatsStudySet found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }

    }
}
