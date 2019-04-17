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
    public partial class LocaleLookupService : DocServiceBase
    {
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

        public object Post(LocaleLookupSearch request) => Get(request);

        public object Get(LocaleLookupSearch request) => GetSearchResultWithCache<LocaleLookup,DocEntityLocaleLookup,LocaleLookupSearch>(DocConstantModelName.LOCALELOOKUP, request, _ExecSearch);

        public object Get(LocaleLookup request) => GetEntityWithCache<LocaleLookup>(DocConstantModelName.LOCALELOOKUP, request, GetLocaleLookup);

        private LocaleLookup _AssignValues(LocaleLookup request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "LocaleLookup"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            LocaleLookup ret = null;
            request = _InitAssignValues<LocaleLookup>(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            var cacheKey = GetApiCacheKey<LocaleLookup>(DocConstantModelName.LOCALELOOKUP, nameof(LocaleLookup), request);
            
            //First, assign all the variables, do database lookups and conversions
            var pData = request.Data;
            var pIpAddress = request.IpAddress;
            var pLocale = (request.Locale?.Id > 0) ? DocEntityLocale.GetLocale(request.Locale.Id) : null;

            DocEntityLocaleLookup entity = null;
            if(permission == DocConstantPermission.ADD)
            {
                var now = DateTime.UtcNow;
                entity = new DocEntityLocaleLookup(session)
                {
                    Created = now,
                    Updated = now
                };
            }
            else
            {
                entity = DocEntityLocaleLookup.GetLocaleLookup(request.Id);
                if(null == entity)
                    throw new HttpError(HttpStatusCode.NotFound, $"No record");
            }

            //Special case for Archived
            var pArchived = true == request.Archived;
            if (DocPermissionFactory.IsRequestedHasPermission<bool>(currentUser, request, pArchived, permission, DocConstantModelName.LOCALELOOKUP, nameof(request.Archived)))
            {
                if(DocPermissionFactory.IsRequested(request, pArchived, entity.Archived, nameof(request.Archived)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.LOCALELOOKUP, nameof(request.Archived)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Archived)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pArchived) && DocResources.Metadata.IsRequired(DocConstantModelName.LOCALELOOKUP, nameof(request.Archived))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Archived)} requires a value.");
                    entity.Archived = pArchived;
                if(DocPermissionFactory.IsRequested<bool>(request, pArchived, nameof(request.Archived)) && !request.VisibleFields.Matches(nameof(request.Archived), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Archived));
                }
            }

            if (DocPermissionFactory.IsRequestedHasPermission<IpData>(currentUser, request, pData, permission, DocConstantModelName.LOCALELOOKUP, nameof(request.Data)))
            {
                if(DocPermissionFactory.IsRequested(request, pData, entity.Data, nameof(request.Data)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.LOCALELOOKUP, nameof(request.Data)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Data)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pData) && DocResources.Metadata.IsRequired(DocConstantModelName.LOCALELOOKUP, nameof(request.Data))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Data)} requires a value.");
                    entity.Data = DocSerialize<IpData>.ToString(pData);
                if(DocPermissionFactory.IsRequested<IpData>(request, pData, nameof(request.Data)) && !request.VisibleFields.Matches(nameof(request.Data), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Data));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pIpAddress, permission, DocConstantModelName.LOCALELOOKUP, nameof(request.IpAddress)))
            {
                if(DocPermissionFactory.IsRequested(request, pIpAddress, entity.IpAddress, nameof(request.IpAddress)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.LOCALELOOKUP, nameof(request.IpAddress)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.IpAddress)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pIpAddress) && DocResources.Metadata.IsRequired(DocConstantModelName.LOCALELOOKUP, nameof(request.IpAddress))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.IpAddress)} requires a value.");
                    entity.IpAddress = pIpAddress;
                if(DocPermissionFactory.IsRequested<string>(request, pIpAddress, nameof(request.IpAddress)) && !request.VisibleFields.Matches(nameof(request.IpAddress), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.IpAddress));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityLocale>(currentUser, request, pLocale, permission, DocConstantModelName.LOCALELOOKUP, nameof(request.Locale)))
            {
                if(DocPermissionFactory.IsRequested(request, pLocale, entity.Locale, nameof(request.Locale)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.LOCALELOOKUP, nameof(request.Locale)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Locale)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pLocale) && DocResources.Metadata.IsRequired(DocConstantModelName.LOCALELOOKUP, nameof(request.Locale))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Locale)} requires a value.");
                    entity.Locale = pLocale;
                if(DocPermissionFactory.IsRequested<DocEntityLocale>(request, pLocale, nameof(request.Locale)) && !request.VisibleFields.Matches(nameof(request.Locale), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Locale));
                }
            }

            if (request.Locked) entity.Locked = request.Locked;

            entity.SaveChanges(permission);


            DocPermissionFactory.SetVisibleFields<LocaleLookup>(currentUser, nameof(LocaleLookup), request.VisibleFields);
            ret = entity.ToDto();

            var cacheExpires = DocResources.Metadata.GetCacheExpiration(DocConstantModelName.LOCALELOOKUP);
            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.LOCALELOOKUP, cacheExpires);

            return ret;
        }
        public LocaleLookup Post(LocaleLookup request)
        {
            if(request == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

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

        public LocaleLookup Post(LocaleLookupCopy request)
        {
            LocaleLookup ret = null;
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    var entity = DocEntityLocaleLookup.GetLocaleLookup(request?.Id);
                    if(null == entity) throw new HttpError(HttpStatusCode.NoContent, "The COPY request did not succeed.");
                    if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD))
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                    var pData = entity.Data;
                    var pIpAddress = entity.IpAddress;
                    if(!DocTools.IsNullOrEmpty(pIpAddress))
                        pIpAddress += " (Copy)";
                    var pLocale = entity.Locale;
                    #region Custom Before copyLocaleLookup
                    #endregion Custom Before copyLocaleLookup
                    var copy = new DocEntityLocaleLookup(ssn)
                    {
                        Hash = Guid.NewGuid()
                                , Data = pData
                                , IpAddress = pIpAddress
                                , Locale = pLocale
                    };

                    #region Custom After copyLocaleLookup
                    #endregion Custom After copyLocaleLookup
                    copy.SaveChanges(DocConstantPermission.ADD);
                    ret = copy.ToDto();
                });
            }
            return ret;
        }
        private LocaleLookup GetLocaleLookup(LocaleLookup request)
        {
            var id = request?.Id;
            LocaleLookup ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetVisibleFields<LocaleLookup>(currentUser, "LocaleLookup", request.VisibleFields);

            DocEntityLocaleLookup entity = null;
            if(id.HasValue)
            {
                entity = DocEntityLocaleLookup.GetLocaleLookup(id.Value);
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
