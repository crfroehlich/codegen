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
    public partial class AuditDeltaService : DocServiceBase
    {
        private IQueryable<DocEntityAuditDelta> _ExecSearch(AuditDeltaSearch request)
        {
            request = InitSearch<AuditDelta, AuditDeltaSearch>(request);
            IQueryable<DocEntityAuditDelta> entities = null;
            Execute.Run( session => 
            {
                entities = Execute.SelectAll<DocEntityAuditDelta>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new AuditDeltaFullTextSearch(request);
                    entities = GetFullTextSearch<DocEntityAuditDelta,AuditDeltaFullTextSearch>(fts, entities);
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
                if(true == request.Archived?.Any() && currentUser.HasProperty(DocConstantModelName.AUDITDELTA, nameof(Reference.Archived), DocConstantPermission.VIEW))
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

                if(!DocTools.IsNullOrEmpty(request.Audit) && !DocTools.IsNullOrEmpty(request.Audit.Id))
                {
                    entities = entities.Where(en => en.Audit.Id == request.Audit.Id );
                }
                if(true == request.AuditIds?.Any())
                {
                    entities = entities.Where(en => en.Audit.Id.In(request.AuditIds));
                }

                entities = ApplyFilters<DocEntityAuditDelta,AuditDeltaSearch>(request, entities);

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

        public List<AuditDelta> Post(AuditDeltaSearch request) => Get(request);

        public List<AuditDelta> Get(AuditDeltaSearch request) => GetSearchResult<AuditDelta,DocEntityAuditDelta,AuditDeltaSearch>(DocConstantModelName.AUDITDELTA, request, _ExecSearch);

        public AuditDelta Get(AuditDelta request) => GetEntity<AuditDelta>(DocConstantModelName.AUDITDELTA, request, GetAuditDelta);
        private AuditDelta _AssignValues(AuditDelta request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "AuditDelta"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            AuditDelta ret = null;
            request = _InitAssignValues<AuditDelta>(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            var cacheKey = GetApiCacheKey<AuditDelta>(DocConstantModelName.AUDITDELTA, nameof(AuditDelta), request);
            
            //First, assign all the variables, do database lookups and conversions
            var pAudit = (request.Audit?.Id > 0) ? DocEntityAuditRecord.GetAuditRecord(request.Audit.Id) : null;
            var pDelta = request.Delta;

            DocEntityAuditDelta entity = null;
            if(permission == DocConstantPermission.ADD)
            {
                var now = DateTime.UtcNow;
                entity = new DocEntityAuditDelta(session)
                {
                    Created = now,
                    Updated = now
                };
            }
            else
            {
                entity = DocEntityAuditDelta.GetAuditDelta(request.Id);
                if(null == entity)
                    throw new HttpError(HttpStatusCode.NotFound, $"No record");
            }

            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityAuditRecord>(currentUser, request, pAudit, permission, DocConstantModelName.AUDITDELTA, nameof(request.Audit)))
            {
                if(DocPermissionFactory.IsRequested(request, pAudit, entity.Audit, nameof(request.Audit)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Audit)} cannot be modified once set.");
                    entity.Audit = pAudit;
                if(DocPermissionFactory.IsRequested<DocEntityAuditRecord>(request, pAudit, nameof(request.Audit)) && !request.VisibleFields.Matches(nameof(request.Audit), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Audit));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pDelta, permission, DocConstantModelName.AUDITDELTA, nameof(request.Delta)))
            {
                if(DocPermissionFactory.IsRequested(request, pDelta, entity.Delta, nameof(request.Delta)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Delta)} cannot be modified once set.");
                    entity.Delta = pDelta;
                if(DocPermissionFactory.IsRequested<string>(request, pDelta, nameof(request.Delta)) && !request.VisibleFields.Matches(nameof(request.Delta), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Delta));
                }
            }
            
            if (request.Locked) entity.Locked = request.Locked;

            entity.SaveChanges(permission);
            
            DocPermissionFactory.SetVisibleFields<AuditDelta>(currentUser, nameof(AuditDelta), request.VisibleFields);
            ret = entity.ToDto();

            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.AUDITDELTA);

            return ret;
        }
        public AuditDelta Post(AuditDelta request)
        {
            if(request == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            AuditDelta ret = null;

            Execute.Run(ssn =>
            {
                if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "AuditDelta")) 
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                ret = _AssignValues(request, DocConstantPermission.ADD, ssn);
            });

            return ret;
        }
   
        public List<AuditDelta> Post(AuditDeltaBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<AuditDelta>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Post(dto) as AuditDelta;
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

        public AuditDelta Post(AuditDeltaCopy request)
        {
            AuditDelta ret = null;
            Execute.Run(ssn =>
            {
                var entity = DocEntityAuditDelta.GetAuditDelta(request?.Id);
                if(null == entity) throw new HttpError(HttpStatusCode.NoContent, "The COPY request did not succeed.");
                if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");
                
                    var pAudit = entity.Audit;
                    var pDelta = entity.Delta;
                #region Custom Before copyAuditDelta
                #endregion Custom Before copyAuditDelta
                var copy = new DocEntityAuditDelta(ssn)
                {
                    Hash = Guid.NewGuid()
                                , Audit = pAudit
                                , Delta = pDelta
                };
                #region Custom After copyAuditDelta
                #endregion Custom After copyAuditDelta
                copy.SaveChanges(DocConstantPermission.ADD);
                ret = copy.ToDto();
            });
            return ret;
        }
        private AuditDelta GetAuditDelta(AuditDelta request)
        {
            var id = request?.Id;
            AuditDelta ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetVisibleFields<AuditDelta>(currentUser, "AuditDelta", request.VisibleFields);

            DocEntityAuditDelta entity = null;
            if(id.HasValue)
            {
                entity = DocEntityAuditDelta.GetAuditDelta(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No AuditDelta found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }
    }
}