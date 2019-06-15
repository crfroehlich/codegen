
//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated by a T4 template. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
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
    public partial class LocaleService : DocServiceBase
    {

        private IQueryable<DocEntityLocale> _ExecSearch(LocaleSearch request, DocQuery query)
        {
            request = InitSearch<Locale, LocaleSearch>(request);
            IQueryable<DocEntityLocale> entities = null;
            query.Run( session => 
            {
                entities = query.SelectAll<DocEntityLocale>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new LocaleFullTextSearch(request);
                    entities = GetFullTextSearch<DocEntityLocale,LocaleFullTextSearch>(fts, entities);
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
                if(true == request.Archived?.Any() && currentUser.HasProperty(DocConstantModelName.LOCALE, nameof(Reference.Archived), DocConstantPermission.VIEW))
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
                if(!DocTools.IsNullOrEmpty(request.Country))
                    entities = entities.Where(en => en.Country.Contains(request.Country));
                if(!DocTools.IsNullOrEmpty(request.Countrys))
                    entities = entities.Where(en => en.Country.In(request.Countrys));
                if(!DocTools.IsNullOrEmpty(request.Language))
                    entities = entities.Where(en => en.Language.Contains(request.Language));
                if(!DocTools.IsNullOrEmpty(request.Languages))
                    entities = entities.Where(en => en.Language.In(request.Languages));
                if(!DocTools.IsNullOrEmpty(request.TimeZone))
                    entities = entities.Where(en => en.TimeZone.Contains(request.TimeZone));
                if(!DocTools.IsNullOrEmpty(request.TimeZones))
                    entities = entities.Where(en => en.TimeZone.In(request.TimeZones));

                entities = ApplyFilters<DocEntityLocale,LocaleSearch>(request, entities);

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

        public object Post(LocaleSearch request) => Get(request);

        public object Get(LocaleSearch request) => GetSearchResultWithCache<Locale,DocEntityLocale,LocaleSearch>(DocConstantModelName.LOCALE, request, _ExecSearch);

        public object Get(Locale request) => GetEntityWithCache<Locale>(DocConstantModelName.LOCALE, request, GetLocale);



        private Locale _AssignValues(Locale request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "Locale"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.Select = request.Select ?? new List<string>();

            Locale ret = null;
            request = _InitAssignValues<Locale>(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            var cacheKey = GetApiCacheKey<Locale>(DocConstantModelName.LOCALE, nameof(Locale), request);
            
            //First, assign all the variables, do database lookups and conversions
            var pCountry = request.Country;
            var pLanguage = request.Language;
            var pTimeZone = request.TimeZone;

            DocEntityLocale entity = null;
            if(permission == DocConstantPermission.ADD)
            {
                var now = DateTime.UtcNow;
                entity = new DocEntityLocale(session)
                {
                    Created = now,
                    Updated = now
                };
            }
            else
            {
                entity = DocEntityLocale.Get(request.Id);
                if(null == entity)
                    throw new HttpError(HttpStatusCode.NotFound, $"No record");
            }

            //Special case for Archived
            var pArchived = true == request.Archived;
            if (PatchValue<Locale, bool>(request, DocConstantModelName.LOCALE, pArchived, entity.Archived, permission, nameof(request.Archived), pArchived != entity.Archived))
            {
                entity.Archived = pArchived;
            }
            if (PatchValue<Locale, string>(request, DocConstantModelName.LOCALE, pCountry, entity.Country, permission, nameof(request.Country), pCountry != entity.Country))
            {
                entity.Country = pCountry;
            }
            if (PatchValue<Locale, string>(request, DocConstantModelName.LOCALE, pLanguage, entity.Language, permission, nameof(request.Language), pLanguage != entity.Language))
            {
                entity.Language = pLanguage;
            }
            if (PatchValue<Locale, string>(request, DocConstantModelName.LOCALE, pTimeZone, entity.TimeZone, permission, nameof(request.TimeZone), pTimeZone != entity.TimeZone))
            {
                entity.TimeZone = pTimeZone;
            }

            if (request.Locked) entity.Locked = request.Locked;

            entity.SaveChanges(permission);

            var idsToInvalidate = new List<int>();

            if (idsToInvalidate.Any())
            {
                idsToInvalidate.Add(entity.Id);
                DocCacheClient.RemoveByEntityIds(idsToInvalidate);
                DocCacheClient.RemoveSearch(DocConstantModelName.LOCALE);
            }

            DocPermissionFactory.SetSelect<Locale>(currentUser, nameof(Locale), request.Select);
            ret = entity.ToDto();

            var cacheExpires = DocResources.Metadata.GetCacheExpiration(DocConstantModelName.LOCALE);
            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.LOCALE, cacheExpires);

            return ret;
        }


        public Locale Post(Locale request)
        {
            if(request == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            request.Select = request.Select ?? new List<string>();

            Locale ret = null;

            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "Locale")) 
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                    ret = _AssignValues(request, DocConstantPermission.ADD, ssn);
                });
            }
            return ret;
        }
   
        public List<Locale> Post(LocaleBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<Locale>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Post(dto) as Locale;
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

        public Locale Post(LocaleCopy request)
        {
            Locale ret = null;
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    var entity = DocEntityLocale.Get(request?.Id);
                    if(null == entity) throw new HttpError(HttpStatusCode.NoContent, "The COPY request did not succeed.");
                    if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD))
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                    var pCountry = entity.Country;
                    if(!DocTools.IsNullOrEmpty(pCountry))
                        pCountry += " (Copy)";
                    var pLanguage = entity.Language;
                    if(!DocTools.IsNullOrEmpty(pLanguage))
                        pLanguage += " (Copy)";
                    var pTimeZone = entity.TimeZone;
                    if(!DocTools.IsNullOrEmpty(pTimeZone))
                        pTimeZone += " (Copy)";
                    var copy = new DocEntityLocale(ssn)
                    {
                        Hash = Guid.NewGuid()
                                , Country = pCountry
                                , Language = pLanguage
                                , TimeZone = pTimeZone
                    };

                    copy.SaveChanges(DocConstantPermission.ADD);
                    ret = copy.ToDto();
                });
            }
            return ret;
        }







        private Locale GetLocale(Locale request)
        {
            var id = request?.Id;
            Locale ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetSelect<Locale>(currentUser, "Locale", request.Select);

            DocEntityLocale entity = null;
            if(id.HasValue)
            {
                entity = DocEntityLocale.Get(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No Locale found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }

    }
}
