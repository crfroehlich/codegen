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
    public partial class LocaleLookupService : DocServiceBase
    {
        public const string CACHE_KEY_PREFIX = DocEntityLocaleLookup.CACHE_KEY_PREFIX;
        private void _ExecSearch(LocaleLookupSearch request, Action<IQueryable<DocEntityLocaleLookup>> callBack)
        {
            request = InitSearch(request);
            
            DocPermissionFactory.SetVisibleFields<LocaleLookup>(currentUser, "LocaleLookup", request.VisibleFields);

            var entities = Execute.SelectAll<DocEntityLocaleLookup>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new LocaleLookupFullTextSearch(request);
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
        }
        
        public object Post(LocaleLookupSearch request)
        {
            object tryRet = null;
            Execute.Run(s =>
            {
                using (var cancellableRequest = base.Request.CreateCancellableRequest())
                {
                    var requestCancel = new DocRequestCancellation(HttpContext.Current.Response, cancellableRequest);
                    try 
                    {
                        var ret = new List<LocaleLookup>();
                        _ExecSearch(request, (entities) => entities.ConvertFromEntityList<DocEntityLocaleLookup,LocaleLookup>(ret, Execute, requestCancel));
                        tryRet = ret;
                    }
                    catch(Exception) { throw; }
                    finally
                    {
                        requestCancel?.CloseRequest();
                    }
                }
            });
            return tryRet;
        }

        public object Get(LocaleLookupSearch request)
        {
            object tryRet = null;
            Execute.Run(s =>
            {
                using (var cancellableRequest = base.Request.CreateCancellableRequest())
                {
                    var requestCancel = new DocRequestCancellation(HttpContext.Current.Response, cancellableRequest);
                    try 
                    {
                        var ret = new List<LocaleLookup>();
                        _ExecSearch(request, (entities) => entities.ConvertFromEntityList<DocEntityLocaleLookup,LocaleLookup>(ret, Execute, requestCancel));
                        tryRet = ret;
                    }
                    catch(Exception) { throw; }
                    finally
                    {
                        requestCancel?.CloseRequest();
                    }
                }
            });
            return tryRet;
        }

        public object Post(LocaleLookupVersion request) 
        {
            return Get(request);
        }

        public object Get(LocaleLookupVersion request) 
        {
            var ret = new List<Version>();
            Execute.Run(s =>
            {
                _ExecSearch(request, (entities) => 
                {
                    ret = entities.Select(e => new Version(e.Id, e.VersionNo)).ToList();
                });
            });
            return ret;
        }

        public object Get(LocaleLookup request)
        {
            object ret = null;
            
            if(!(request.Id > 0))
                throw new HttpError(HttpStatusCode.NotFound, "Valid Id required.");

            Execute.Run(s =>
            {
                DocPermissionFactory.SetVisibleFields<LocaleLookup>(currentUser, "LocaleLookup", request.VisibleFields);
                ret = GetLocaleLookup(request);
            });
            return ret;
        }

        private LocaleLookup _AssignValues(LocaleLookup dtoSource, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (dtoSource == null || dtoSource.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "LocaleLookup"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            dtoSource.VisibleFields = dtoSource.VisibleFields ?? new List<string>();

            LocaleLookup ret = null;
            dtoSource = _InitAssignValues(dtoSource, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && dtoSource.Id > 0) return dtoSource;
            
            //First, assign all the variables, do database lookups and conversions
            var pData = dtoSource.Data;
            var pIpAddress = dtoSource.IpAddress;
            var pLocale = (dtoSource.Locale?.Id > 0) ? DocEntityLocale.GetLocale(dtoSource.Locale.Id) : null;

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
                entity = DocEntityLocaleLookup.GetLocaleLookup(dtoSource.Id);
                if(null == entity)
                    throw new HttpError(HttpStatusCode.NotFound, $"No record");
            }

            if (DocPermissionFactory.IsRequestedHasPermission<IpData>(currentUser, dtoSource, pData, permission, DocConstantModelName.LOCALELOOKUP, nameof(dtoSource.Data)))
            {
                if(DocPermissionFactory.IsRequested(dtoSource, pData, entity.Data, nameof(dtoSource.Data)))
                    entity.Data = DocSerialize<IpData>.ToString(pData);
                if(DocPermissionFactory.IsRequested<IpData>(dtoSource, pData, nameof(dtoSource.Data)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.Data), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.Data));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, dtoSource, pIpAddress, permission, DocConstantModelName.LOCALELOOKUP, nameof(dtoSource.IpAddress)))
            {
                if(DocPermissionFactory.IsRequested(dtoSource, pIpAddress, entity.IpAddress, nameof(dtoSource.IpAddress)))
                    entity.IpAddress = pIpAddress;
                if(DocPermissionFactory.IsRequested<string>(dtoSource, pIpAddress, nameof(dtoSource.IpAddress)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.IpAddress), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.IpAddress));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityLocale>(currentUser, dtoSource, pLocale, permission, DocConstantModelName.LOCALELOOKUP, nameof(dtoSource.Locale)))
            {
                if(DocPermissionFactory.IsRequested(dtoSource, pLocale, entity.Locale, nameof(dtoSource.Locale)))
                    entity.Locale = pLocale;
                if(DocPermissionFactory.IsRequested<DocEntityLocale>(dtoSource, pLocale, nameof(dtoSource.Locale)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.Locale), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.Locale));
                }
            }
            
            if (dtoSource.Locked) entity.Locked = dtoSource.Locked;

            entity.SaveChanges(permission);
            
            DocPermissionFactory.SetVisibleFields<LocaleLookup>(currentUser, nameof(LocaleLookup), dtoSource.VisibleFields);
            ret = entity.ToDto();

            return ret;
        }
        public LocaleLookup Post(LocaleLookup dtoSource)
        {
            if(dtoSource == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            dtoSource.VisibleFields = dtoSource.VisibleFields ?? new List<string>();

            LocaleLookup ret = null;

            Execute.Run(ssn =>
            {
                if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "LocaleLookup")) 
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                ret = _AssignValues(dtoSource, DocConstantPermission.ADD, ssn);
            });

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

        public List<int> Any(LocaleLookupIds request)
        {
            List<int> ret = null;
            if (currentUser.IsSuperAdmin)
            {
                Execute.Run(s => { ret = Execute.SelectAll<DocEntityLocaleLookup>().Select(d => d.Id).ToList(); });
            }
            else
            {
                throw new HttpError(HttpStatusCode.Forbidden);
            }
            return ret;
        }
    }
}