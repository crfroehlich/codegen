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
    public partial class UnitOfMeasureService : DocServiceBase
    {
        private IQueryable<DocEntityUnitOfMeasure> _ExecSearch(UnitOfMeasureSearch request)
        {
            request = InitSearch(request);
            IQueryable<DocEntityUnitOfMeasure> entities = null;
            Execute.Run( session => 
            {
                entities = Execute.SelectAll<DocEntityUnitOfMeasure>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new UnitOfMeasureFullTextSearch(request);
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

                if(request.IsSI.HasValue)
                    entities = entities.Where(en => request.IsSI.Value == en.IsSI);
                if(!DocTools.IsNullOrEmpty(request.Name) && !DocTools.IsNullOrEmpty(request.Name.Id))
                {
                    entities = entities.Where(en => en.Name.Id == request.Name.Id );
                }
                if(true == request.NameIds?.Any())
                {
                    entities = entities.Where(en => en.Name.Id.In(request.NameIds));
                }
                else if(!DocTools.IsNullOrEmpty(request.Name) && !DocTools.IsNullOrEmpty(request.Name.Name))
                {
                    entities = entities.Where(en => en.Name.Name == request.Name.Name );
                }
                if(true == request.NameNames?.Any())
                {
                    entities = entities.Where(en => en.Name.Name.In(request.NameNames));
                }
                if(!DocTools.IsNullOrEmpty(request.Type) && !DocTools.IsNullOrEmpty(request.Type.Id))
                {
                    entities = entities.Where(en => en.Type.Id == request.Type.Id );
                }
                if(true == request.TypeIds?.Any())
                {
                    entities = entities.Where(en => en.Type.Id.In(request.TypeIds));
                }
                else if(!DocTools.IsNullOrEmpty(request.Type) && !DocTools.IsNullOrEmpty(request.Type.Name))
                {
                    entities = entities.Where(en => en.Type.Name == request.Type.Name );
                }
                if(true == request.TypeNames?.Any())
                {
                    entities = entities.Where(en => en.Type.Name.In(request.TypeNames));
                }
                if(!DocTools.IsNullOrEmpty(request.Unit) && !DocTools.IsNullOrEmpty(request.Unit.Id))
                {
                    entities = entities.Where(en => en.Unit.Id == request.Unit.Id );
                }
                if(true == request.UnitIds?.Any())
                {
                    entities = entities.Where(en => en.Unit.Id.In(request.UnitIds));
                }
                else if(!DocTools.IsNullOrEmpty(request.Unit) && !DocTools.IsNullOrEmpty(request.Unit.Name))
                {
                    entities = entities.Where(en => en.Unit.Name == request.Unit.Name );
                }
                if(true == request.UnitNames?.Any())
                {
                    entities = entities.Where(en => en.Unit.Name.In(request.UnitNames));
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
            });
            return entities;
        }

        public object Post(UnitOfMeasureSearch request) => Get(request);

        public object Get(UnitOfMeasureSearch request) => GetSearchResultWithCache<UnitOfMeasure,DocEntityUnitOfMeasure,UnitOfMeasureSearch>(DocConstantModelName.UNITOFMEASURE, request, _ExecSearch);

        public object Post(UnitOfMeasureVersion request) => Get(request);

        public object Get(UnitOfMeasureVersion request) 
        {
            List<Version> ret = null;
            Execute.Run(s=>
            {
                ret = _ExecSearch(request).Select(e => new Version(e.Id, e.VersionNo)).ToList();
            });
            return ret;
        }

        public object Get(UnitOfMeasure request) => GetEntityWithCache<UnitOfMeasure>(DocConstantModelName.UNITOFMEASURE, request, GetUnitOfMeasure);
        private UnitOfMeasure _AssignValues(UnitOfMeasure request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "UnitOfMeasure"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            UnitOfMeasure ret = null;
            request = _InitAssignValues(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            var cacheKey = GetApiCacheKey<UnitOfMeasure>(DocConstantModelName.UNITOFMEASURE, nameof(UnitOfMeasure), request);
            
            //First, assign all the variables, do database lookups and conversions
            var pIsSI = request.IsSI;
            DocEntityLookupTable pName = GetLookup(DocConstantLookupTable.UOMNAME, request.Name?.Name, request.Name?.Id);
            DocEntityLookupTable pType = GetLookup(DocConstantLookupTable.UNITTYPE, request.Type?.Name, request.Type?.Id);
            DocEntityLookupTable pUnit = GetLookup(DocConstantLookupTable.UOMUNIT, request.Unit?.Name, request.Unit?.Id);

            DocEntityUnitOfMeasure entity = null;
            if(permission == DocConstantPermission.ADD)
            {
                var now = DateTime.UtcNow;
                entity = new DocEntityUnitOfMeasure(session)
                {
                    Created = now,
                    Updated = now
                };
            }
            else
            {
                entity = DocEntityUnitOfMeasure.GetUnitOfMeasure(request.Id);
                if(null == entity)
                    throw new HttpError(HttpStatusCode.NotFound, $"No record");
            }

            if (DocPermissionFactory.IsRequestedHasPermission<bool>(currentUser, request, pIsSI, permission, DocConstantModelName.UNITOFMEASURE, nameof(request.IsSI)))
            {
                if(DocPermissionFactory.IsRequested(request, pIsSI, entity.IsSI, nameof(request.IsSI)))
                    entity.IsSI = pIsSI;
                if(DocPermissionFactory.IsRequested<bool>(request, pIsSI, nameof(request.IsSI)) && !request.VisibleFields.Matches(nameof(request.IsSI), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.IsSI));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityLookupTable>(currentUser, request, pName, permission, DocConstantModelName.UNITOFMEASURE, nameof(request.Name)))
            {
                if(DocPermissionFactory.IsRequested(request, pName, entity.Name, nameof(request.Name)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Name)} cannot be modified once set.");
                    entity.Name = pName;
                if(DocPermissionFactory.IsRequested<DocEntityLookupTable>(request, pName, nameof(request.Name)) && !request.VisibleFields.Matches(nameof(request.Name), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Name));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityLookupTable>(currentUser, request, pType, permission, DocConstantModelName.UNITOFMEASURE, nameof(request.Type)))
            {
                if(DocPermissionFactory.IsRequested(request, pType, entity.Type, nameof(request.Type)))
                    entity.Type = pType;
                if(DocPermissionFactory.IsRequested<DocEntityLookupTable>(request, pType, nameof(request.Type)) && !request.VisibleFields.Matches(nameof(request.Type), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Type));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityLookupTable>(currentUser, request, pUnit, permission, DocConstantModelName.UNITOFMEASURE, nameof(request.Unit)))
            {
                if(DocPermissionFactory.IsRequested(request, pUnit, entity.Unit, nameof(request.Unit)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Unit)} cannot be modified once set.");
                    entity.Unit = pUnit;
                if(DocPermissionFactory.IsRequested<DocEntityLookupTable>(request, pUnit, nameof(request.Unit)) && !request.VisibleFields.Matches(nameof(request.Unit), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Unit));
                }
            }
            
            if (request.Locked) entity.Locked = request.Locked;

            entity.SaveChanges(permission);
            
            DocPermissionFactory.SetVisibleFields<UnitOfMeasure>(currentUser, nameof(UnitOfMeasure), request.VisibleFields);
            ret = entity.ToDto();

            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.UNITOFMEASURE);

            return ret;
        }
        public UnitOfMeasure Post(UnitOfMeasure request)
        {
            if(request == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            UnitOfMeasure ret = null;

            Execute.Run(ssn =>
            {
                if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "UnitOfMeasure")) 
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                ret = _AssignValues(request, DocConstantPermission.ADD, ssn);
            });

            return ret;
        }
   
        public List<UnitOfMeasure> Post(UnitOfMeasureBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<UnitOfMeasure>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Post(dto) as UnitOfMeasure;
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

        public UnitOfMeasure Post(UnitOfMeasureCopy request)
        {
            UnitOfMeasure ret = null;
            Execute.Run(ssn =>
            {
                var entity = DocEntityUnitOfMeasure.GetUnitOfMeasure(request?.Id);
                if(null == entity) throw new HttpError(HttpStatusCode.NoContent, "The COPY request did not succeed.");
                if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");
                
                    var pIsSI = entity.IsSI;
                    var pName = entity.Name;
                    var pType = entity.Type;
                    var pUnit = entity.Unit;
                #region Custom Before copyUnitOfMeasure
                #endregion Custom Before copyUnitOfMeasure
                var copy = new DocEntityUnitOfMeasure(ssn)
                {
                    Hash = Guid.NewGuid()
                                , IsSI = pIsSI
                                , Name = pName
                                , Type = pType
                                , Unit = pUnit
                };
                #region Custom After copyUnitOfMeasure
                #endregion Custom After copyUnitOfMeasure
                copy.SaveChanges(DocConstantPermission.ADD);
                ret = copy.ToDto();
            });
            return ret;
        }


        public List<UnitOfMeasure> Put(UnitOfMeasureBatch request)
        {
            return Patch(request);
        }

        public UnitOfMeasure Put(UnitOfMeasure request)
        {
            return Patch(request);
        }

        public List<UnitOfMeasure> Patch(UnitOfMeasureBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<UnitOfMeasure>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Patch(dto) as UnitOfMeasure;
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

        public UnitOfMeasure Patch(UnitOfMeasure request)
        {
            if(true != (request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the UnitOfMeasure to patch.");
            
            request.VisibleFields = request.VisibleFields ?? new List<string>();
            
            UnitOfMeasure ret = null;
            Execute.Run(ssn =>
            {
                ret = _AssignValues(request, DocConstantPermission.EDIT, ssn);
            });
            return ret;
        }

        public void Delete(UnitOfMeasureBatch request)
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

        public void Delete(UnitOfMeasure request)
        {
            Execute.Run(ssn =>
            {
                if(!(request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, $"No Id provided for delete.");

                DocCacheClient.RemoveSearch(DocConstantModelName.UNITOFMEASURE);
                DocCacheClient.RemoveById(request.Id);
                var en = DocEntityUnitOfMeasure.GetUnitOfMeasure(request?.Id);

                if(null == en) throw new HttpError(HttpStatusCode.NotFound, $"No UnitOfMeasure could be found for Id {request?.Id}.");
                if(en.IsRemoved) return;
                
                if(!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.DELETE))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have DELETE permission for this route.");
                
                en.Remove();
            });
        }

        public void Delete(UnitOfMeasureSearch request)
        {
            var matches = Get(request) as List<UnitOfMeasure>;
            if(true != matches?.Any()) throw new HttpError(HttpStatusCode.NotFound, "No matches for request");

            Execute.Run(ssn =>
            {
                matches.ForEach(match =>
                {
                    Delete(match);
                });
            });
        }

        private UnitOfMeasure GetUnitOfMeasure(UnitOfMeasure request)
        {
            var id = request?.Id;
            UnitOfMeasure ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetVisibleFields<UnitOfMeasure>(currentUser, "UnitOfMeasure", request.VisibleFields);

            DocEntityUnitOfMeasure entity = null;
            if(id.HasValue)
            {
                entity = DocEntityUnitOfMeasure.GetUnitOfMeasure(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No UnitOfMeasure found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }

        public List<int> Any(UnitOfMeasureIds request)
        {
            List<int> ret = null;
            if (currentUser.IsSuperAdmin)
            {
                Execute.Run(s => { ret = Execute.SelectAll<DocEntityUnitOfMeasure>().Select(d => d.Id).ToList(); });
            }
            else
            {
                throw new HttpError(HttpStatusCode.Forbidden);
            }

            return ret;
        }
    }
}