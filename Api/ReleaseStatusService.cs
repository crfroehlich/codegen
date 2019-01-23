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
    public partial class ReleaseStatusService : DocServiceBase
    {
        private IQueryable<DocEntityReleaseStatus> _ExecSearch(ReleaseStatusSearch request)
        {
            request = InitSearch(request);
            
            IQueryable<DocEntityReleaseStatus> entities = null;
            
            DocPermissionFactory.SetVisibleFields<ReleaseStatus>(currentUser, "ReleaseStatus", request.VisibleFields);

            Execute.Run( session => 
            {
                entities = Execute.SelectAll<DocEntityReleaseStatus>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new ReleaseStatusFullTextSearch(request);
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

                if(!DocTools.IsNullOrEmpty(request.Branch))
                    entities = entities.Where(en => en.Branch.Contains(request.Branch));
                if(!DocTools.IsNullOrEmpty(request.Release))
                    entities = entities.Where(en => en.Release.Contains(request.Release));
                if(!DocTools.IsNullOrEmpty(request.Server))
                    entities = entities.Where(en => en.Server.Contains(request.Server));
                if(!DocTools.IsNullOrEmpty(request.URL))
                    entities = entities.Where(en => en.URL.Contains(request.URL));
                if(!DocTools.IsNullOrEmpty(request.Version))
                    entities = entities.Where(en => en.Version.Contains(request.Version));

                entities = ApplyFilters(request, entities);

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

        public List<ReleaseStatus> Post(ReleaseStatusSearch request) => Get(request);

        public List<ReleaseStatus> Get(ReleaseStatusSearch request) => GetSearchResult<ReleaseStatus,DocEntityReleaseStatus,ReleaseStatusSearch>(DocConstantModelName.RELEASESTATUS, request, _ExecSearch);

        public object Post(ReleaseStatusVersion request) => Get(request);

        public object Get(ReleaseStatusVersion request) 
        {
            List<Version> ret = null;
            Execute.Run(s=>
            {
                ret = _ExecSearch(request).Select(e => new Version(e.Id, e.VersionNo)).ToList();
            });
            return ret;
        }

        public ReleaseStatus Get(ReleaseStatus request) => GetEntity<ReleaseStatus>(DocConstantModelName.RELEASESTATUS, request, GetReleaseStatus);
        private ReleaseStatus _AssignValues(ReleaseStatus request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "ReleaseStatus"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            ReleaseStatus ret = null;
            request = _InitAssignValues(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            var cacheKey = GetApiCacheKey<ReleaseStatus>(DocConstantModelName.RELEASESTATUS, nameof(ReleaseStatus), request);
            
            //First, assign all the variables, do database lookups and conversions
            var pBranch = request.Branch;
            var pRelease = request.Release;
            var pServer = request.Server;
            var pURL = request.URL;
            var pVersion = request.Version;

            DocEntityReleaseStatus entity = null;
            if(permission == DocConstantPermission.ADD)
            {
                var now = DateTime.UtcNow;
                entity = new DocEntityReleaseStatus(session)
                {
                    Created = now,
                    Updated = now
                };
            }
            else
            {
                entity = DocEntityReleaseStatus.GetReleaseStatus(request.Id);
                if(null == entity)
                    throw new HttpError(HttpStatusCode.NotFound, $"No record");
            }

            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pBranch, permission, DocConstantModelName.RELEASESTATUS, nameof(request.Branch)))
            {
                if(DocPermissionFactory.IsRequested(request, pBranch, entity.Branch, nameof(request.Branch)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Branch)} cannot be modified once set.");
                    entity.Branch = pBranch;
                if(DocPermissionFactory.IsRequested<string>(request, pBranch, nameof(request.Branch)) && !request.VisibleFields.Matches(nameof(request.Branch), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Branch));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pRelease, permission, DocConstantModelName.RELEASESTATUS, nameof(request.Release)))
            {
                if(DocPermissionFactory.IsRequested(request, pRelease, entity.Release, nameof(request.Release)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Release)} cannot be modified once set.");
                    entity.Release = pRelease;
                if(DocPermissionFactory.IsRequested<string>(request, pRelease, nameof(request.Release)) && !request.VisibleFields.Matches(nameof(request.Release), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Release));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pServer, permission, DocConstantModelName.RELEASESTATUS, nameof(request.Server)))
            {
                if(DocPermissionFactory.IsRequested(request, pServer, entity.Server, nameof(request.Server)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Server)} cannot be modified once set.");
                    entity.Server = pServer;
                if(DocPermissionFactory.IsRequested<string>(request, pServer, nameof(request.Server)) && !request.VisibleFields.Matches(nameof(request.Server), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Server));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pURL, permission, DocConstantModelName.RELEASESTATUS, nameof(request.URL)))
            {
                if(DocPermissionFactory.IsRequested(request, pURL, entity.URL, nameof(request.URL)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.URL)} cannot be modified once set.");
                    entity.URL = pURL;
                if(DocPermissionFactory.IsRequested<string>(request, pURL, nameof(request.URL)) && !request.VisibleFields.Matches(nameof(request.URL), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.URL));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pVersion, permission, DocConstantModelName.RELEASESTATUS, nameof(request.Version)))
            {
                if(DocPermissionFactory.IsRequested(request, pVersion, entity.Version, nameof(request.Version)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Version)} cannot be modified once set.");
                    entity.Version = pVersion;
                if(DocPermissionFactory.IsRequested<string>(request, pVersion, nameof(request.Version)) && !request.VisibleFields.Matches(nameof(request.Version), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Version));
                }
            }
            
            if (request.Locked) entity.Locked = request.Locked;

            entity.SaveChanges(permission);
            
            DocPermissionFactory.SetVisibleFields<ReleaseStatus>(currentUser, nameof(ReleaseStatus), request.VisibleFields);
            ret = entity.ToDto();

            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.RELEASESTATUS);

            return ret;
        }
        public ReleaseStatus Post(ReleaseStatus request)
        {
            if(request == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            ReleaseStatus ret = null;

            Execute.Run(ssn =>
            {
                if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "ReleaseStatus")) 
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                ret = _AssignValues(request, DocConstantPermission.ADD, ssn);
            });

            return ret;
        }
   
        public List<ReleaseStatus> Post(ReleaseStatusBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<ReleaseStatus>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Post(dto) as ReleaseStatus;
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

        public ReleaseStatus Post(ReleaseStatusCopy request)
        {
            ReleaseStatus ret = null;
            Execute.Run(ssn =>
            {
                var entity = DocEntityReleaseStatus.GetReleaseStatus(request?.Id);
                if(null == entity) throw new HttpError(HttpStatusCode.NoContent, "The COPY request did not succeed.");
                if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");
                
                    var pBranch = entity.Branch;
                    if(!DocTools.IsNullOrEmpty(pBranch))
                        pBranch += " (Copy)";
                    var pRelease = entity.Release;
                    if(!DocTools.IsNullOrEmpty(pRelease))
                        pRelease += " (Copy)";
                    var pServer = entity.Server;
                    if(!DocTools.IsNullOrEmpty(pServer))
                        pServer += " (Copy)";
                    var pURL = entity.URL;
                    if(!DocTools.IsNullOrEmpty(pURL))
                        pURL += " (Copy)";
                    var pVersion = entity.Version;
                    if(!DocTools.IsNullOrEmpty(pVersion))
                        pVersion += " (Copy)";
                #region Custom Before copyReleaseStatus
                #endregion Custom Before copyReleaseStatus
                var copy = new DocEntityReleaseStatus(ssn)
                {
                    Hash = Guid.NewGuid()
                                , Branch = pBranch
                                , Release = pRelease
                                , Server = pServer
                                , URL = pURL
                                , Version = pVersion
                };
                #region Custom After copyReleaseStatus
                #endregion Custom After copyReleaseStatus
                copy.SaveChanges(DocConstantPermission.ADD);
                ret = copy.ToDto();
            });
            return ret;
        }


        public List<ReleaseStatus> Put(ReleaseStatusBatch request)
        {
            return Patch(request);
        }

        public ReleaseStatus Put(ReleaseStatus request)
        {
            return Patch(request);
        }

        public List<ReleaseStatus> Patch(ReleaseStatusBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<ReleaseStatus>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Patch(dto) as ReleaseStatus;
                    ret.Add(obj);
                    errorMap[$"{i}"] = $"true";
                }
                catch (Exception ex)
                {
                    errorMap[$"{i}"] = $"false";
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

        public ReleaseStatus Patch(ReleaseStatus request)
        {
            if(true != (request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the ReleaseStatus to patch.");
            
            request.VisibleFields = request.VisibleFields ?? new List<string>();
            
            ReleaseStatus ret = null;
            Execute.Run(ssn =>
            {
                ret = _AssignValues(request, DocConstantPermission.EDIT, ssn);
            });
            return ret;
        }

        public void Delete(ReleaseStatusBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    Delete(dto);
                    errorMap[$"{i}"] = $"true";
                }
                catch (Exception ex)
                {
                    errorMap[$"{i}"] = $"false";
                    errors.Add(new ResponseError()
                    {
                        Message = $"{ex.Message}{Environment.NewLine}{ex.InnerException?.Message}",
                        ErrorCode = $"{i}"
                    });
                }
                i += 1;
            });
            base.Response.AddHeader("X-AutoBatch-Completed", $"{request.Count-errors.Count} succeeded");
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
        }

        public void Delete(ReleaseStatus request)
        {
            Execute.Run(ssn =>
            {
                if(!(request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, $"No Id provided for delete.");

                DocCacheClient.RemoveSearch(DocConstantModelName.RELEASESTATUS);
                DocCacheClient.RemoveById(request.Id);
                var en = DocEntityReleaseStatus.GetReleaseStatus(request?.Id);

                if(null == en) throw new HttpError(HttpStatusCode.NotFound, $"No ReleaseStatus could be found for Id {request?.Id}.");
                if(en.IsRemoved) return;
                
                if(!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.DELETE))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have DELETE permission for this route.");
                
                en.Remove();
            });
        }

        public void Delete(ReleaseStatusSearch request)
        {
            var matches = Get(request) as List<ReleaseStatus>;
            if(true != matches?.Any()) throw new HttpError(HttpStatusCode.NotFound, "No matches for request");

            Execute.Run(ssn =>
            {
                matches.ForEach(match =>
                {
                    Delete(match);
                });
            });
        }

        private ReleaseStatus GetReleaseStatus(ReleaseStatus request)
        {
            var id = request?.Id;
            ReleaseStatus ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetVisibleFields<ReleaseStatus>(currentUser, "ReleaseStatus", request.VisibleFields);

            DocEntityReleaseStatus entity = null;
            if(id.HasValue)
            {
                entity = DocEntityReleaseStatus.GetReleaseStatus(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No ReleaseStatus found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }

        public List<int> Any(ReleaseStatusIds request)
        {
            List<int> ret = null;
            if (currentUser.IsSuperAdmin)
            {
                Execute.Run(s => { ret = Execute.SelectAll<DocEntityReleaseStatus>().Select(d => d.Id).ToList(); });
            }
            else
            {
                throw new HttpError(HttpStatusCode.Forbidden);
            }

            return ret;
        }
    }
}