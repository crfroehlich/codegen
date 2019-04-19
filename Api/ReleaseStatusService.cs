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
    public partial class ReleaseStatusService : DocServiceBase
    {
        private IQueryable<DocEntityReleaseStatus> _ExecSearch(ReleaseStatusSearch request, DocQuery query)
        {
            request = InitSearch<ReleaseStatus, ReleaseStatusSearch>(request);
            IQueryable<DocEntityReleaseStatus> entities = null;
            query.Run( session => 
            {
                entities = query.SelectAll<DocEntityReleaseStatus>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new ReleaseStatusFullTextSearch(request);
                    entities = GetFullTextSearch<DocEntityReleaseStatus,ReleaseStatusFullTextSearch>(fts, entities);
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
                if(true == request.Archived?.Any() && currentUser.HasProperty(DocConstantModelName.RELEASESTATUS, nameof(Reference.Archived), DocConstantPermission.VIEW))
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

                entities = ApplyFilters<DocEntityReleaseStatus,ReleaseStatusSearch>(request, entities);

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

        public object Post(ReleaseStatusSearch request) => Get(request);

        public object Get(ReleaseStatusSearch request) => GetSearchResultWithCache<ReleaseStatus,DocEntityReleaseStatus,ReleaseStatusSearch>(DocConstantModelName.RELEASESTATUS, request, _ExecSearch);

        public object Get(ReleaseStatus request) => GetEntityWithCache<ReleaseStatus>(DocConstantModelName.RELEASESTATUS, request, GetReleaseStatus);

        private ReleaseStatus _AssignValues(ReleaseStatus request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "ReleaseStatus"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            ReleaseStatus ret = null;
            request = _InitAssignValues<ReleaseStatus>(request, permission, session);
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

            //Special case for Archived
            var pArchived = true == request.Archived;
            if (DocPermissionFactory.IsRequestedHasPermission<bool>(currentUser, request, pArchived, permission, DocConstantModelName.RELEASESTATUS, nameof(request.Archived)))
            {
                if(DocPermissionFactory.IsRequested(request, pArchived, entity.Archived, nameof(request.Archived)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.RELEASESTATUS, nameof(request.Archived)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Archived)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pArchived) && DocResources.Metadata.IsRequired(DocConstantModelName.RELEASESTATUS, nameof(request.Archived))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Archived)} requires a value.");
                    entity.Archived = pArchived;
                if(DocPermissionFactory.IsRequested<bool>(request, pArchived, nameof(request.Archived)) && !request.VisibleFields.Matches(nameof(request.Archived), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Archived));
                }
            }

            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pBranch, permission, DocConstantModelName.RELEASESTATUS, nameof(request.Branch)))
            {
                if(DocPermissionFactory.IsRequested(request, pBranch, entity.Branch, nameof(request.Branch)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.RELEASESTATUS, nameof(request.Branch)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Branch)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pBranch) && DocResources.Metadata.IsRequired(DocConstantModelName.RELEASESTATUS, nameof(request.Branch))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Branch)} requires a value.");
                    entity.Branch = pBranch;
                if(DocPermissionFactory.IsRequested<string>(request, pBranch, nameof(request.Branch)) && !request.VisibleFields.Matches(nameof(request.Branch), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Branch));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pRelease, permission, DocConstantModelName.RELEASESTATUS, nameof(request.Release)))
            {
                if(DocPermissionFactory.IsRequested(request, pRelease, entity.Release, nameof(request.Release)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.RELEASESTATUS, nameof(request.Release)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Release)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pRelease) && DocResources.Metadata.IsRequired(DocConstantModelName.RELEASESTATUS, nameof(request.Release))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Release)} requires a value.");
                    entity.Release = pRelease;
                if(DocPermissionFactory.IsRequested<string>(request, pRelease, nameof(request.Release)) && !request.VisibleFields.Matches(nameof(request.Release), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Release));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pServer, permission, DocConstantModelName.RELEASESTATUS, nameof(request.Server)))
            {
                if(DocPermissionFactory.IsRequested(request, pServer, entity.Server, nameof(request.Server)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.RELEASESTATUS, nameof(request.Server)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Server)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pServer) && DocResources.Metadata.IsRequired(DocConstantModelName.RELEASESTATUS, nameof(request.Server))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Server)} requires a value.");
                    entity.Server = pServer;
                if(DocPermissionFactory.IsRequested<string>(request, pServer, nameof(request.Server)) && !request.VisibleFields.Matches(nameof(request.Server), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Server));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pURL, permission, DocConstantModelName.RELEASESTATUS, nameof(request.URL)))
            {
                if(DocPermissionFactory.IsRequested(request, pURL, entity.URL, nameof(request.URL)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.RELEASESTATUS, nameof(request.URL)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.URL)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pURL) && DocResources.Metadata.IsRequired(DocConstantModelName.RELEASESTATUS, nameof(request.URL))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.URL)} requires a value.");
                    entity.URL = pURL;
                if(DocPermissionFactory.IsRequested<string>(request, pURL, nameof(request.URL)) && !request.VisibleFields.Matches(nameof(request.URL), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.URL));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pVersion, permission, DocConstantModelName.RELEASESTATUS, nameof(request.Version)))
            {
                if(DocPermissionFactory.IsRequested(request, pVersion, entity.Version, nameof(request.Version)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.RELEASESTATUS, nameof(request.Version)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Version)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pVersion) && DocResources.Metadata.IsRequired(DocConstantModelName.RELEASESTATUS, nameof(request.Version))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Version)} requires a value.");
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

            var cacheExpires = DocResources.Metadata.GetCacheExpiration(DocConstantModelName.RELEASESTATUS);
            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.RELEASESTATUS, cacheExpires);

            return ret;
        }
        public ReleaseStatus Post(ReleaseStatus request)
        {
            if(request == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            ReleaseStatus ret = null;

            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "ReleaseStatus")) 
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                    ret = _AssignValues(request, DocConstantPermission.ADD, ssn);
                });
            }
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
            using(Execute)
            {
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
            }
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
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    ret = _AssignValues(request, DocConstantPermission.EDIT, ssn);
                });
            }
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
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    if(!(request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, $"No Id provided for delete.");

                    var en = DocEntityReleaseStatus.GetReleaseStatus(request?.Id);
                    if(null == en) throw new HttpError(HttpStatusCode.NotFound, $"No ReleaseStatus could be found for Id {request?.Id}.");
                    if(en.IsRemoved) return;
                
                    if(!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.DELETE))
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have DELETE permission for this route.");
                
                    en.Remove();

                    DocCacheClient.RemoveSearch(DocConstantModelName.RELEASESTATUS);
                    DocCacheClient.RemoveById(request.Id);
                });
            }
        }

        public void Delete(ReleaseStatusSearch request)
        {
            var matches = Get(request) as List<ReleaseStatus>;
            if(true != matches?.Any()) throw new HttpError(HttpStatusCode.NotFound, "No matches for request");
            matches.ForEach(match =>
            {
                Delete(match);
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
    }
}
