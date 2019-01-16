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
    public partial class StatsStudySetService : DocServiceBase
    {
        private void _ExecSearch(StatsStudySetSearch request, Action<IQueryable<DocEntityStatsStudySet>> callBack)
        {
            request = InitSearch(request);
            
            DocPermissionFactory.SetVisibleFields<StatsStudySet>(currentUser, "StatsStudySet", request.VisibleFields);

            Execute.Run( session => 
            {
                var entities = Execute.SelectAll<DocEntityStatsStudySet>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new StatsStudySetFullTextSearch(request);
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
                if(request.UnboundTerms.HasValue)
                    entities = entities.Where(en => request.UnboundTerms.Value == en.UnboundTerms);

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
        
        public object Post(StatsStudySetSearch request)
        {
            return Get(request);
        }

        public object Get(StatsStudySetSearch request)
        {
            object tryRet = null;
            var ret = new List<StatsStudySet>();
            var cacheKey = GetApiCacheKey<StatsStudySet>(DocConstantModelName.STATSSTUDYSET, nameof(StatsStudySet), request);
            using (var cancellableRequest = base.Request.CreateCancellableRequest())
            {
                var requestCancel = new DocRequestCancellation(HttpContext.Current.Response, cancellableRequest);
                try 
                {
                    if (tryRet == null)
                    {
                        _ExecSearch(request, (entities) => entities.ConvertFromEntityList<DocEntityStatsStudySet,StatsStudySet>(ret, Execute, requestCancel));
                        tryRet = ret;
                        //Go ahead and cache the result for any future consumers
                        DocCacheClient.Set(key: cacheKey, value: ret, entityType: DocConstantModelName.STATSSTUDYSET, search: true);
                    }
                }
                catch(Exception) { throw; }
                finally
                {
                    requestCancel?.CloseRequest();
                }
            }
            DocCacheClient.SyncKeys(key: cacheKey, entityType: DocConstantModelName.STATSSTUDYSET, search: true);
            return tryRet;
        }

        public object Post(StatsStudySetVersion request) 
        {
            return Get(request);
        }

        public object Get(StatsStudySetVersion request) 
        {
            var ret = new List<Version>();
            _ExecSearch(request, (entities) => 
            {
                ret = entities.Select(e => new Version(e.Id, e.VersionNo)).ToList();
            });
            return ret;
        }

        public object Get(StatsStudySet request)
        {
            object ret = null;
            
            if(!(request.Id > 0))
                throw new HttpError(HttpStatusCode.NotFound, "Valid Id required.");

            DocPermissionFactory.SetVisibleFields<StatsStudySet>(currentUser, "StatsStudySet", request.VisibleFields);
            var cacheKey = GetApiCacheKey<StatsStudySet>(DocConstantModelName.STATSSTUDYSET, nameof(StatsStudySet), request);
            if(null == ret)
            {
                Execute.Run(s =>
                {
                    ret = GetStatsStudySet(request);
                    DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.STATSSTUDYSET);
                });
            }
            DocCacheClient.SyncKeys(key: cacheKey, entityId: request.Id, entityType: DocConstantModelName.STATSSTUDYSET);
            return ret;
        }




        public object Get(StatsStudySetJunction request)
        {
            if(!(request.Id > 0))
                throw new HttpError(HttpStatusCode.NotFound, "Valid Id required.");
            object ret = null;
            var skip = (request.Skip > 0) ? request.Skip.Value : 0;
            var take = (request.Take > 0) ? request.Take.Value : int.MaxValue;
                        
            var info = Request.PathInfo.Split('?')[0].Split('/');
            var method = info[info.Length-1]?.ToLower().Trim();
            Execute.Run( s => 
            {
                switch(method)
                {
                case "statsrecord":
                    ret = _GetStatsStudySetStatsRecord(request, skip, take);
                    break;
                }
            });
            return ret;
        }
        
        public object Get(StatsStudySetJunctionVersion request)
        {
            if(!(request.Id > 0))
                throw new HttpError(HttpStatusCode.NotFound, "Valid Id required.");
            var ret = new List<Version>();
            
            var info = Request.PathInfo.Split('?')[0].Split('/');
            var method = info[info.Length-2]?.ToLower().Trim();
            Execute.Run( ssn =>
            {
                switch(method)
                {
                }
            });
            return ret;
        }
        

        private object _GetStatsStudySetStatsRecord(StatsStudySetJunction request, int skip, int take)
        {
             DocPermissionFactory.SetVisibleFields<StatsRecord>(currentUser, "StatsRecord", request.VisibleFields);
             var en = DocEntityStatsStudySet.GetStatsStudySet(request.Id);
             if (!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.VIEW, targetName: DocConstantModelName.STATSSTUDYSET, columnName: "Records", targetEntity: null))
                 throw new HttpError(HttpStatusCode.Forbidden, "You do not have View permission to relationships between StatsStudySet and StatsRecord");
             return en?.Records.Take(take).Skip(skip).ConvertFromEntityList<DocEntityStatsRecord,StatsRecord>(new List<StatsRecord>());
        }
        
        public object Post(StatsStudySetJunction request)
        {
            if (request == null)
                throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");
            if (!(request.Id > 0))
                throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the {className} to update.");
            if (request.Ids == null || request.Ids.Count < 1)
                throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid list of {type} Ids.");

            object ret = null;

            Execute.Run( ssn =>
            {
                var info = Request.PathInfo.Split('/');
                var method = info[info.Length-1];
                switch(method)
                {
                }
            });
            return ret;
        }


        public object Delete(StatsStudySetJunction request)
        {
            if (request == null)
                throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");
            if (!(request.Id > 0))
                throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the {className} to update.");
            if (request.Ids == null || request.Ids.Count < 1)
                throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid list of {type} Ids.");

            object ret = null;

            Execute.Run( ssn =>
            {
                var info = Request.PathInfo.Split('/');
                var method = info[info.Length-1];
                switch(method)
                {
                }
            });
            return ret;
        }


        private StatsStudySet GetStatsStudySet(StatsStudySet request)
        {
            var id = request?.Id;
            StatsStudySet ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetVisibleFields<StatsStudySet>(currentUser, "StatsStudySet", request.VisibleFields);

            DocEntityStatsStudySet entity = null;
            if(id.HasValue)
            {
                entity = DocEntityStatsStudySet.GetStatsStudySet(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No StatsStudySet found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }

        public List<int> Any(StatsStudySetIds request)
        {
            List<int> ret = null;
            if (currentUser.IsSuperAdmin)
            {
                Execute.Run(s => { ret = Execute.SelectAll<DocEntityStatsStudySet>().Select(d => d.Id).ToList(); });
            }
            else
            {
                throw new HttpError(HttpStatusCode.Forbidden);
            }

            return ret;
        }
    }
}