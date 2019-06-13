
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
    public partial class LookupTableEnumService : DocServiceBase
    {

        private IQueryable<DocEntityLookupTableEnum> _ExecSearch(LookupTableEnumSearch request, DocQuery query)
        {
            request = InitSearch<LookupTableEnum, LookupTableEnumSearch>(request);
            IQueryable<DocEntityLookupTableEnum> entities = null;
            query.Run( session => 
            {
                entities = query.SelectAll<DocEntityLookupTableEnum>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new LookupTableEnumFullTextSearch(request);
                    entities = GetFullTextSearch<DocEntityLookupTableEnum,LookupTableEnumFullTextSearch>(fts, entities);
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
                if(true == request.Archived?.Any() && currentUser.HasProperty(DocConstantModelName.LOOKUPTABLEENUM, nameof(Reference.Archived), DocConstantPermission.VIEW))
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
                if(true == request.IsBindable?.Any())
                {
                    if(request.IsBindable.Any(v => v == null)) entities = entities.Where(en => en.IsBindable.In(request.IsBindable) || en.IsBindable == null);
                    else entities = entities.Where(en => en.IsBindable.In(request.IsBindable));
                }
                if(true == request.IsGlobal?.Any())
                {
                    if(request.IsGlobal.Any(v => v == null)) entities = entities.Where(en => en.IsGlobal.In(request.IsGlobal) || en.IsGlobal == null);
                    else entities = entities.Where(en => en.IsGlobal.In(request.IsGlobal));
                }
                if(!DocTools.IsNullOrEmpty(request.Name))
                    entities = entities.Where(en => en.Name.Contains(request.Name));
                if(!DocTools.IsNullOrEmpty(request.Names))
                    entities = entities.Where(en => en.Name.In(request.Names));

                entities = ApplyFilters<DocEntityLookupTableEnum,LookupTableEnumSearch>(request, entities);

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

        public object Post(LookupTableEnumSearch request) => Get(request);

        public object Get(LookupTableEnumSearch request) => GetSearchResultWithCache<LookupTableEnum,DocEntityLookupTableEnum,LookupTableEnumSearch>(DocConstantModelName.LOOKUPTABLEENUM, request, _ExecSearch);

        public object Get(LookupTableEnum request) => GetEntityWithCache<LookupTableEnum>(DocConstantModelName.LOOKUPTABLEENUM, request, GetLookupTableEnum);



        private LookupTableEnum _AssignValues(LookupTableEnum request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "LookupTableEnum"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.Select = request.Select ?? new List<string>();

            LookupTableEnum ret = null;
            request = _InitAssignValues<LookupTableEnum>(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            var cacheKey = GetApiCacheKey<LookupTableEnum>(DocConstantModelName.LOOKUPTABLEENUM, nameof(LookupTableEnum), request);
            
            //First, assign all the variables, do database lookups and conversions
            var pIsBindable = request.IsBindable;
            var pIsGlobal = request.IsGlobal;
            var pName = request.Name;

            DocEntityLookupTableEnum entity = null;
            if(permission == DocConstantPermission.ADD)
            {
                var now = DateTime.UtcNow;
                entity = new DocEntityLookupTableEnum(session)
                {
                    Created = now,
                    Updated = now
                };
            }
            else
            {
                entity = DocEntityLookupTableEnum.Get(request.Id);
                if(null == entity)
                    throw new HttpError(HttpStatusCode.NotFound, $"No record");
            }

            //Special case for Archived
            var pArchived = true == request.Archived;
            if (DocPermissionFactory.IsRequestedHasPermission<bool>(currentUser, request, pArchived, permission, DocConstantModelName.LOOKUPTABLEENUM, nameof(request.Archived)))
            {
                if(DocPermissionFactory.IsRequested(request, pArchived, entity.Archived, nameof(request.Archived)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.LOOKUPTABLEENUM, nameof(request.Archived)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Archived)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pArchived) && DocResources.Metadata.IsRequired(DocConstantModelName.LOOKUPTABLEENUM, nameof(request.Archived))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Archived)} requires a value.");
                    entity.Archived = pArchived;
                if(DocPermissionFactory.IsRequested<bool>(request, pArchived, nameof(request.Archived)) && !request.Select.Matches(nameof(request.Archived), ignoreSpaces: true))
                {
                    request.Select.Add(nameof(request.Archived));
                }
            }



            if (request.Locked) entity.Locked = request.Locked;

            entity.SaveChanges(permission);

            var idsToInvalidate = new List<int>();

            if (idsToInvalidate.Any())
            {
                idsToInvalidate.Add(entity.Id);
                DocCacheClient.RemoveByEntityIds(idsToInvalidate);
                DocCacheClient.RemoveSearch(DocConstantModelName.LOOKUPTABLEENUM);
            }

            DocPermissionFactory.SetSelect<LookupTableEnum>(currentUser, nameof(LookupTableEnum), request.Select);
            ret = entity.ToDto();

            var cacheExpires = DocResources.Metadata.GetCacheExpiration(DocConstantModelName.LOOKUPTABLEENUM);
            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.LOOKUPTABLEENUM, cacheExpires);

            return ret;
        }


        public LookupTableEnum Post(LookupTableEnum request)
        {
            if(request == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            request.Select = request.Select ?? new List<string>();

            LookupTableEnum ret = null;

            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "LookupTableEnum")) 
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                    ret = _AssignValues(request, DocConstantPermission.ADD, ssn);
                });
            }
            return ret;
        }
   
        public List<LookupTableEnum> Post(LookupTableEnumBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<LookupTableEnum>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Post(dto) as LookupTableEnum;
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

        public LookupTableEnum Post(LookupTableEnumCopy request)
        {
            LookupTableEnum ret = null;
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    var entity = DocEntityLookupTableEnum.Get(request?.Id);
                    if(null == entity) throw new HttpError(HttpStatusCode.NoContent, "The COPY request did not succeed.");
                    if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD))
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                    var pIsBindable = entity.IsBindable;
                    var pIsGlobal = entity.IsGlobal;
                    var pName = entity.Name;
                    if(!DocTools.IsNullOrEmpty(pName))
                        pName += " (Copy)";
                    var copy = new DocEntityLookupTableEnum(ssn)
                    {
                        Hash = Guid.NewGuid()
                                , IsBindable = pIsBindable
                                , IsGlobal = pIsGlobal
                                , Name = pName
                    };

                    copy.SaveChanges(DocConstantPermission.ADD);
                    ret = copy.ToDto();
                });
            }
            return ret;
        }



        public List<LookupTableEnum> Put(LookupTableEnumBatch request)
        {
            return Patch(request);
        }

        public LookupTableEnum Put(LookupTableEnum request)
        {
            return Patch(request);
        }


        public List<LookupTableEnum> Patch(LookupTableEnumBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<LookupTableEnum>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Patch(dto) as LookupTableEnum;
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

        public LookupTableEnum Patch(LookupTableEnum request)
        {
            if(true != (request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the LookupTableEnum to patch.");
            
            request.Select = request.Select ?? new List<string>();
            
            LookupTableEnum ret = null;
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    ret = _AssignValues(request, DocConstantPermission.EDIT, ssn);
                });
            }
            return ret;
        }


        public void Delete(LookupTableEnumBatch request)
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

        public void Delete(LookupTableEnum request)
        {
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    if(!(request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, $"No Id provided for delete.");

                    var en = DocEntityLookupTableEnum.Get(request?.Id);
                    if(null == en) throw new HttpError(HttpStatusCode.NotFound, $"No LookupTableEnum could be found for Id {request?.Id}.");
                    if(en.IsRemoved) return;
                
                    if(!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.DELETE))
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have DELETE permission for this route.");
                
                    en.Remove();

                    DocCacheClient.RemoveSearch(DocConstantModelName.LOOKUPTABLEENUM);
                    DocCacheClient.RemoveById(request.Id);
                });
            }
        }

        public void Delete(LookupTableEnumSearch request)
        {
            var matches = Get(request) as List<LookupTableEnum>;
            if(true != matches?.Any()) throw new HttpError(HttpStatusCode.NotFound, "No matches for request");
            matches.ForEach(match =>
            {
                Delete(match);
            });
        }




        private LookupTableEnum GetLookupTableEnum(LookupTableEnum request)
        {
            var id = request?.Id;
            LookupTableEnum ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetSelect<LookupTableEnum>(currentUser, "LookupTableEnum", request.Select);

            DocEntityLookupTableEnum entity = null;
            if(id.HasValue)
            {
                entity = DocEntityLookupTableEnum.Get(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No LookupTableEnum found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }

    }
}
