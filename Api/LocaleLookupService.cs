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
    public partial class LocaleLookupService : DocServiceBase
    {

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private IQueryable<DocEntityLocaleLookup> _ExecSearch(LocaleLookupSearch request, DocQuery query)
        {
            request = InitSearch<LocaleLookup, LocaleLookupSearch>(request);
            IQueryable<DocEntityLocaleLookup> entities = null;
            query.Run( session => 
            {
                entities = query.SelectAll<DocEntityLocaleLookup>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new LocaleLookupFullTextSearch(request);
                    entities = GetFullTextSearch<DocEntityLocaleLookup,LocaleLookupFullTextSearch>(fts, entities);
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
                if(true == request.Archived?.Any() && currentUser.HasProperty(DocConstantModelName.LOCALELOOKUP, nameof(Reference.Archived), DocConstantPermission.VIEW))
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
                if(!DocTools.IsNullOrEmpty(request.IpAddress))
                    entities = entities.Where(en => en.IpAddress.Contains(request.IpAddress));
                if(!DocTools.IsNullOrEmpty(request.IpAddresss))
                    entities = entities.Where(en => en.IpAddress.In(request.IpAddresss));
                if(!DocTools.IsNullOrEmpty(request.Locale) && !DocTools.IsNullOrEmpty(request.Locale.Id))
                {
                    entities = entities.Where(en => en.Locale.Id == request.Locale.Id );
                }
                if(true == request.LocaleIds?.Any())
                {
                    entities = entities.Where(en => en.Locale.Id.In(request.LocaleIds));
                }

                entities = ApplyFilters<DocEntityLocaleLookup,LocaleLookupSearch>(request, entities);

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
        public object Post(LocaleLookupSearch request) => Get(request);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Get(LocaleLookupSearch request) => GetSearchResultWithCache<LocaleLookup,DocEntityLocaleLookup,LocaleLookupSearch>(DocConstantModelName.LOCALELOOKUP, request, _ExecSearch);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Get(LocaleLookup request) => GetEntityWithCache<LocaleLookup>(DocConstantModelName.LOCALELOOKUP, request, GetLocaleLookup);



        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private LocaleLookup _AssignValues(LocaleLookup request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "LocaleLookup"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.Select = request.Select ?? new List<string>();

            LocaleLookup ret = null;
            request = _InitAssignValues<LocaleLookup>(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            var cacheKey = GetApiCacheKey<LocaleLookup>(DocConstantModelName.LOCALELOOKUP, nameof(LocaleLookup), request);
            
            //First, assign all the variables, do database lookups and conversions
            var pData = (DocTools.IsNullOrEmpty(request.Data)) ? null : DocSerialize<IpData>.ToString(request.Data);
            var pIpAddress = request.IpAddress;
            var pLocale = (request.Locale?.Id > 0) ? DocEntityLocale.Get(request.Locale.Id) : null;
            var pArchived = true == request.Archived;
            var pLocked = request.Locked;

            var entity = InitEntity<DocEntityLocaleLookup,LocaleLookup>(request, permission, session);

            if (AllowPatchValue<LocaleLookup, bool>(request, DocConstantModelName.LOCALELOOKUP, pArchived, permission, nameof(request.Archived), pArchived != entity.Archived))
            {
                entity.Archived = pArchived;
            }
            if (AllowPatchValue<LocaleLookup, string>(request, DocConstantModelName.LOCALELOOKUP, pData, permission, nameof(request.Data), pData != entity.Data))
            {
                entity.Data = pData;
            }
            if (AllowPatchValue<LocaleLookup, string>(request, DocConstantModelName.LOCALELOOKUP, pIpAddress, permission, nameof(request.IpAddress), pIpAddress != entity.IpAddress))
            {
                entity.IpAddress = pIpAddress;
            }
            if (AllowPatchValue<LocaleLookup, DocEntityLocale>(request, DocConstantModelName.LOCALELOOKUP, pLocale, permission, nameof(request.Locale), pLocale != entity.Locale))
            {
                entity.Locale = pLocale;
            }
            if (request.Locked && AllowPatchValue<LocaleLookup, bool>(request, DocConstantModelName.LOCALELOOKUP, pArchived, permission, nameof(request.Locked), pLocked != entity.Locked))
            {
                entity.Archived = pArchived;
            }
            entity.SaveChanges(permission);

            var idsToInvalidate = new List<int>();

            if (idsToInvalidate.Any())
            {
                idsToInvalidate.Add(entity.Id);
                DocCacheClient.RemoveByEntityIds(idsToInvalidate);
                DocCacheClient.RemoveSearch(DocConstantModelName.LOCALELOOKUP);
            }

            entity.SaveChanges(permission);
            DocPermissionFactory.SetSelect<LocaleLookup>(currentUser, nameof(LocaleLookup), request.Select);
            ret = entity.ToDto();

            var cacheExpires = DocResources.Metadata.GetCacheExpiration(DocConstantModelName.LOCALELOOKUP);
            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.LOCALELOOKUP, cacheExpires);

            return ret;
        }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public LocaleLookup Post(LocaleLookup request)
        {
            if(request == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            request.Select = request.Select ?? new List<string>();

            LocaleLookup ret = null;

            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "LocaleLookup")) 
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                    ret = _AssignValues(request, DocConstantPermission.ADD, ssn);
                });
            }
            return ret;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<LocaleLookup> Post(LocaleLookupBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<LocaleLookup>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Post(dto) as LocaleLookup;
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
        public LocaleLookup Post(LocaleLookupCopy request)
        {
            LocaleLookup ret = null;
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    var entity = DocEntityLocaleLookup.Get(request?.Id);
                    if(null == entity) throw new HttpError(HttpStatusCode.NoContent, "The COPY request did not succeed.");
                    if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD))
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                    var pData = entity.Data;
                    var pIpAddress = entity.IpAddress;
                    if(!DocTools.IsNullOrEmpty(pIpAddress))
                        pIpAddress += " (Copy)";
                    var pLocale = entity.Locale;
                    var copy = new DocEntityLocaleLookup(ssn)
                    {
                        Hash = Guid.NewGuid()
                                , Data = pData
                                , IpAddress = pIpAddress
                                , Locale = pLocale
                    };

                    copy.SaveChanges(DocConstantPermission.ADD);
                    ret = copy.ToDto();
                });
            }
            return ret;
        }







        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private LocaleLookup GetLocaleLookup(LocaleLookup request)
        {
            var id = request?.Id;
            LocaleLookup ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetSelect<LocaleLookup>(currentUser, "LocaleLookup", request.Select);

            DocEntityLocaleLookup entity = null;
            if(id.HasValue)
            {
                entity = DocEntityLocaleLookup.Get(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No LocaleLookup found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }

    }
}
