
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
    public partial class DefaultService : DocServiceBase
    {

        private IQueryable<DocEntityDefault> _ExecSearch(DefaultSearch request, DocQuery query)
        {
            request = InitSearch<Default, DefaultSearch>(request);
            IQueryable<DocEntityDefault> entities = null;
            query.Run( session => 
            {
                entities = query.SelectAll<DocEntityDefault>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new DefaultFullTextSearch(request);
                    entities = GetFullTextSearch<DocEntityDefault,DefaultFullTextSearch>(fts, entities);
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
                if(true == request.Archived?.Any() && currentUser.HasProperty(DocConstantModelName.DEFAULT, nameof(Reference.Archived), DocConstantPermission.VIEW))
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
                if(!DocTools.IsNullOrEmpty(request.DiseaseState) && !DocTools.IsNullOrEmpty(request.DiseaseState.Id))
                {
                    entities = entities.Where(en => en.DiseaseState.Id == request.DiseaseState.Id );
                }
                if(true == request.DiseaseStateIds?.Any())
                {
                    entities = entities.Where(en => en.DiseaseState.Id.In(request.DiseaseStateIds));
                }
                if(!DocTools.IsNullOrEmpty(request.Role) && !DocTools.IsNullOrEmpty(request.Role.Id))
                {
                    entities = entities.Where(en => en.Role.Id == request.Role.Id );
                }
                if(true == request.RoleIds?.Any())
                {
                    entities = entities.Where(en => en.Role.Id.In(request.RoleIds));
                }
                if(!DocTools.IsNullOrEmpty(request.Scope) && !DocTools.IsNullOrEmpty(request.Scope.Id))
                {
                    entities = entities.Where(en => en.Scope.Id == request.Scope.Id );
                }
                if(true == request.ScopeIds?.Any())
                {
                    entities = entities.Where(en => en.Scope.Id.In(request.ScopeIds));
                }
                if(!DocTools.IsNullOrEmpty(request.TherapeuticArea) && !DocTools.IsNullOrEmpty(request.TherapeuticArea.Id))
                {
                    entities = entities.Where(en => en.TherapeuticArea.Id == request.TherapeuticArea.Id );
                }
                if(true == request.TherapeuticAreaIds?.Any())
                {
                    entities = entities.Where(en => en.TherapeuticArea.Id.In(request.TherapeuticAreaIds));
                }

                entities = ApplyFilters<DocEntityDefault,DefaultSearch>(request, entities);

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

        public object Post(DefaultSearch request) => Get(request);

        public object Get(DefaultSearch request) => GetSearchResultWithCache<Default,DocEntityDefault,DefaultSearch>(DocConstantModelName.DEFAULT, request, _ExecSearch);

        public object Get(Default request) => GetEntityWithCache<Default>(DocConstantModelName.DEFAULT, request, GetDefault);



        private Default _AssignValues(Default request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "Default"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.Select = request.Select ?? new List<string>();

            Default ret = null;
            request = _InitAssignValues<Default>(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            var cacheKey = GetApiCacheKey<Default>(DocConstantModelName.DEFAULT, nameof(Default), request);
            
            //First, assign all the variables, do database lookups and conversions
            var pDiseaseState = (request.DiseaseState?.Id > 0) ? DocEntityDiseaseStateSet.Get(request.DiseaseState.Id) : null;
            var pRole = (request.Role?.Id > 0) ? DocEntityRole.Get(request.Role.Id) : null;
            var pScope = (request.Scope?.Id > 0) ? DocEntityScope.Get(request.Scope.Id) : null;
            var pTherapeuticArea = (request.TherapeuticArea?.Id > 0) ? DocEntityTherapeuticAreaSet.Get(request.TherapeuticArea.Id) : null;

            DocEntityDefault entity = null;
            if(permission == DocConstantPermission.ADD)
            {
                var now = DateTime.UtcNow;
                entity = new DocEntityDefault(session)
                {
                    Created = now,
                    Updated = now
                };
            }
            else
            {
                entity = DocEntityDefault.Get(request.Id);
                if(null == entity)
                    throw new HttpError(HttpStatusCode.NotFound, $"No record");
            }

            //Special case for Archived
            var pArchived = true == request.Archived;
            if (DocPermissionFactory.IsRequestedHasPermission<bool>(currentUser, request, pArchived, permission, DocConstantModelName.DEFAULT, nameof(request.Archived)))
            {
                if(DocPermissionFactory.IsRequested(request, pArchived, entity.Archived, nameof(request.Archived)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.DEFAULT, nameof(request.Archived)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Archived)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pArchived) && DocResources.Metadata.IsRequired(DocConstantModelName.DEFAULT, nameof(request.Archived))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Archived)} requires a value.");
                    entity.Archived = pArchived;
                if(DocPermissionFactory.IsRequested<bool>(request, pArchived, nameof(request.Archived)) && !request.Select.Matches(nameof(request.Archived), ignoreSpaces: true))
                {
                    request.Select.Add(nameof(request.Archived));
                }
            }

            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityDiseaseStateSet>(currentUser, request, pDiseaseState, permission, DocConstantModelName.DEFAULT, nameof(request.DiseaseState)))
            {
                if(DocPermissionFactory.IsRequested(request, pDiseaseState, entity.DiseaseState, nameof(request.DiseaseState)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.DEFAULT, nameof(request.DiseaseState)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.DiseaseState)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pDiseaseState) && DocResources.Metadata.IsRequired(DocConstantModelName.DEFAULT, nameof(request.DiseaseState))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.DiseaseState)} requires a value.");
                    entity.DiseaseState = pDiseaseState;
                if(DocPermissionFactory.IsRequested<DocEntityDiseaseStateSet>(request, pDiseaseState, nameof(request.DiseaseState)) && !request.Select.Matches(nameof(request.DiseaseState), ignoreSpaces: true))
                {
                    request.Select.Add(nameof(request.DiseaseState));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityRole>(currentUser, request, pRole, permission, DocConstantModelName.DEFAULT, nameof(request.Role)))
            {
                if(DocPermissionFactory.IsRequested(request, pRole, entity.Role, nameof(request.Role)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.DEFAULT, nameof(request.Role)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Role)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pRole) && DocResources.Metadata.IsRequired(DocConstantModelName.DEFAULT, nameof(request.Role))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Role)} requires a value.");
                    entity.Role = pRole;
                if(DocPermissionFactory.IsRequested<DocEntityRole>(request, pRole, nameof(request.Role)) && !request.Select.Matches(nameof(request.Role), ignoreSpaces: true))
                {
                    request.Select.Add(nameof(request.Role));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityScope>(currentUser, request, pScope, permission, DocConstantModelName.DEFAULT, nameof(request.Scope)))
            {
                if(DocPermissionFactory.IsRequested(request, pScope, entity.Scope, nameof(request.Scope)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.DEFAULT, nameof(request.Scope)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Scope)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pScope) && DocResources.Metadata.IsRequired(DocConstantModelName.DEFAULT, nameof(request.Scope))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Scope)} requires a value.");
                    entity.Scope = pScope;
                if(DocPermissionFactory.IsRequested<DocEntityScope>(request, pScope, nameof(request.Scope)) && !request.Select.Matches(nameof(request.Scope), ignoreSpaces: true))
                {
                    request.Select.Add(nameof(request.Scope));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityTherapeuticAreaSet>(currentUser, request, pTherapeuticArea, permission, DocConstantModelName.DEFAULT, nameof(request.TherapeuticArea)))
            {
                if(DocPermissionFactory.IsRequested(request, pTherapeuticArea, entity.TherapeuticArea, nameof(request.TherapeuticArea)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.DEFAULT, nameof(request.TherapeuticArea)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.TherapeuticArea)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pTherapeuticArea) && DocResources.Metadata.IsRequired(DocConstantModelName.DEFAULT, nameof(request.TherapeuticArea))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.TherapeuticArea)} requires a value.");
                    entity.TherapeuticArea = pTherapeuticArea;
                if(DocPermissionFactory.IsRequested<DocEntityTherapeuticAreaSet>(request, pTherapeuticArea, nameof(request.TherapeuticArea)) && !request.Select.Matches(nameof(request.TherapeuticArea), ignoreSpaces: true))
                {
                    request.Select.Add(nameof(request.TherapeuticArea));
                }
            }

            if (request.Locked) entity.Locked = request.Locked;

            entity.SaveChanges(permission);

            var idsToInvalidate = new List<int>();

            if (idsToInvalidate.Any())
            {
                idsToInvalidate.Add(entity.Id);
                DocCacheClient.RemoveByEntityIds(idsToInvalidate);
                DocCacheClient.RemoveSearch(DocConstantModelName.DEFAULT);
            }

            DocPermissionFactory.SetSelect<Default>(currentUser, nameof(Default), request.Select);
            ret = entity.ToDto();

            var cacheExpires = DocResources.Metadata.GetCacheExpiration(DocConstantModelName.DEFAULT);
            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.DEFAULT, cacheExpires);

            return ret;
        }


        public Default Post(Default request)
        {
            if(request == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            request.Select = request.Select ?? new List<string>();

            Default ret = null;

            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "Default")) 
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                    ret = _AssignValues(request, DocConstantPermission.ADD, ssn);
                });
            }
            return ret;
        }
   
        public List<Default> Post(DefaultBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<Default>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Post(dto) as Default;
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

        public Default Post(DefaultCopy request)
        {
            Default ret = null;
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    var entity = DocEntityDefault.Get(request?.Id);
                    if(null == entity) throw new HttpError(HttpStatusCode.NoContent, "The COPY request did not succeed.");
                    if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD))
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                    var pDiseaseState = entity.DiseaseState;
                    var pRole = entity.Role;
                    var pScope = entity.Scope;
                    var pTherapeuticArea = entity.TherapeuticArea;
                    var copy = new DocEntityDefault(ssn)
                    {
                        Hash = Guid.NewGuid()
                                , DiseaseState = pDiseaseState
                                , Role = pRole
                                , Scope = pScope
                                , TherapeuticArea = pTherapeuticArea
                    };

                    copy.SaveChanges(DocConstantPermission.ADD);
                    ret = copy.ToDto();
                });
            }
            return ret;
        }



        public List<Default> Put(DefaultBatch request)
        {
            return Patch(request);
        }

        public Default Put(Default request)
        {
            return Patch(request);
        }


        public List<Default> Patch(DefaultBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<Default>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Patch(dto) as Default;
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

        public Default Patch(Default request)
        {
            if(true != (request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the Default to patch.");
            
            request.Select = request.Select ?? new List<string>();
            
            Default ret = null;
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    ret = _AssignValues(request, DocConstantPermission.EDIT, ssn);
                });
            }
            return ret;
        }





        private Default GetDefault(Default request)
        {
            var id = request?.Id;
            Default ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetSelect<Default>(currentUser, "Default", request.Select);

            DocEntityDefault entity = null;
            if(id.HasValue)
            {
                entity = DocEntityDefault.Get(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No Default found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }

    }
}
