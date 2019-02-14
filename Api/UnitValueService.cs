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
    public partial class UnitValueService : DocServiceBase
    {
        private IQueryable<DocEntityUnitValue> _ExecSearch(UnitValueSearch request)
        {
            request = InitSearch<UnitValue, UnitValueSearch>(request);
            IQueryable<DocEntityUnitValue> entities = null;
            Execute.Run( session => 
            {
                entities = Execute.SelectAll<DocEntityUnitValue>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new UnitValueFullTextSearch(request);
                    entities = GetFullTextSearch<DocEntityUnitValue,UnitValueFullTextSearch>(fts, entities);
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

                if(!DocTools.IsNullOrEmpty(request.EqualityOperator) && !DocTools.IsNullOrEmpty(request.EqualityOperator.Id))
                {
                    entities = entities.Where(en => en.EqualityOperator.Id == request.EqualityOperator.Id );
                }
                if(true == request.EqualityOperatorIds?.Any())
                {
                    entities = entities.Where(en => en.EqualityOperator.Id.In(request.EqualityOperatorIds));
                }
                else if(!DocTools.IsNullOrEmpty(request.EqualityOperator) && !DocTools.IsNullOrEmpty(request.EqualityOperator.Name))
                {
                    entities = entities.Where(en => en.EqualityOperator.Name == request.EqualityOperator.Name );
                }
                if(true == request.EqualityOperatorNames?.Any())
                {
                    entities = entities.Where(en => en.EqualityOperator.Name.In(request.EqualityOperatorNames));
                }
                if(request.Multiplier.HasValue)
                    entities = entities.Where(en => request.Multiplier.Value == en.Multiplier);
                if(request.Number.HasValue)
                    entities = entities.Where(en => request.Number.Value == en.Number);
                if(request.Order.HasValue)
                    entities = entities.Where(en => request.Order.Value == en.Order);
                if(true == request.OwnersIds?.Any())
                {
                    entities = entities.Where(en => en.Owners.Any(r => r.Id.In(request.OwnersIds)));
                }
                if(!DocTools.IsNullOrEmpty(request.Unit) && !DocTools.IsNullOrEmpty(request.Unit.Id))
                {
                    entities = entities.Where(en => en.Unit.Id == request.Unit.Id );
                }
                if(true == request.UnitIds?.Any())
                {
                    entities = entities.Where(en => en.Unit.Id.In(request.UnitIds));
                }

                entities = ApplyFilters<DocEntityUnitValue,UnitValueSearch>(request, entities);

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

        public List<UnitValue> Post(UnitValueSearch request) => Get(request);

        public List<UnitValue> Get(UnitValueSearch request) => GetSearchResult<UnitValue,DocEntityUnitValue,UnitValueSearch>(DocConstantModelName.UNITVALUE, request, _ExecSearch);

        public UnitValue Get(UnitValue request) => GetEntity<UnitValue>(DocConstantModelName.UNITVALUE, request, GetUnitValue);
        private UnitValue _AssignValues(UnitValue request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "UnitValue"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            UnitValue ret = null;
            request = _InitAssignValues<UnitValue>(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            var cacheKey = GetApiCacheKey<UnitValue>(DocConstantModelName.UNITVALUE, nameof(UnitValue), request);
            
            //First, assign all the variables, do database lookups and conversions
            DocEntityLookupTable pEqualityOperator = GetLookup(DocConstantLookupTable.EQUALITYOPERATOR, request.EqualityOperator?.Name, request.EqualityOperator?.Id);
            var pMultiplier = request.Multiplier;
            var pNumber = request.Number;
            var pOrder = request.Order;
            var pOwners = request.Owners?.ToList();
            var pUnit = (request.Unit?.Id > 0) ? DocEntityUnitOfMeasure.GetUnitOfMeasure(request.Unit.Id) : null;

            DocEntityUnitValue entity = null;
            if(permission == DocConstantPermission.ADD)
            {
                var now = DateTime.UtcNow;
                entity = new DocEntityUnitValue(session)
                {
                    Created = now,
                    Updated = now
                };
            }
            else
            {
                entity = DocEntityUnitValue.GetUnitValue(request.Id);
                if(null == entity)
                    throw new HttpError(HttpStatusCode.NotFound, $"No record");
            }

            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityLookupTable>(currentUser, request, pEqualityOperator, permission, DocConstantModelName.UNITVALUE, nameof(request.EqualityOperator)))
            {
                if(DocPermissionFactory.IsRequested(request, pEqualityOperator, entity.EqualityOperator, nameof(request.EqualityOperator)))
                    entity.EqualityOperator = pEqualityOperator;
                if(DocPermissionFactory.IsRequested<DocEntityLookupTable>(request, pEqualityOperator, nameof(request.EqualityOperator)) && !request.VisibleFields.Matches(nameof(request.EqualityOperator), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.EqualityOperator));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<int?>(currentUser, request, pMultiplier, permission, DocConstantModelName.UNITVALUE, nameof(request.Multiplier)))
            {
                if(DocPermissionFactory.IsRequested(request, pMultiplier, entity.Multiplier, nameof(request.Multiplier)))
                    if(null != pMultiplier)
                        entity.Multiplier = (int) pMultiplier;
                if(DocPermissionFactory.IsRequested<int?>(request, pMultiplier, nameof(request.Multiplier)) && !request.VisibleFields.Matches(nameof(request.Multiplier), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Multiplier));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<decimal?>(currentUser, request, pNumber, permission, DocConstantModelName.UNITVALUE, nameof(request.Number)))
            {
                if(DocPermissionFactory.IsRequested(request, pNumber, entity.Number, nameof(request.Number)))
                    entity.Number = pNumber;
                if(DocPermissionFactory.IsRequested<decimal?>(request, pNumber, nameof(request.Number)) && !request.VisibleFields.Matches(nameof(request.Number), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Number));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<int?>(currentUser, request, pOrder, permission, DocConstantModelName.UNITVALUE, nameof(request.Order)))
            {
                if(DocPermissionFactory.IsRequested(request, pOrder, entity.Order, nameof(request.Order)))
                    if(null != pOrder)
                        entity.Order = (int) pOrder;
                if(DocPermissionFactory.IsRequested<int?>(request, pOrder, nameof(request.Order)) && !request.VisibleFields.Matches(nameof(request.Order), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Order));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityUnitOfMeasure>(currentUser, request, pUnit, permission, DocConstantModelName.UNITVALUE, nameof(request.Unit)))
            {
                if(DocPermissionFactory.IsRequested(request, pUnit, entity.Unit, nameof(request.Unit)))
                    entity.Unit = pUnit;
                if(DocPermissionFactory.IsRequested<DocEntityUnitOfMeasure>(request, pUnit, nameof(request.Unit)) && !request.VisibleFields.Matches(nameof(request.Unit), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Unit));
                }
            }
            
            if (request.Locked) entity.Locked = request.Locked;

            entity.SaveChanges(permission);
            
            DocPermissionFactory.SetVisibleFields<UnitValue>(currentUser, nameof(UnitValue), request.VisibleFields);
            ret = entity.ToDto();

            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.UNITVALUE);

            return ret;
        }
        public UnitValue Post(UnitValue request)
        {
            if(request == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            UnitValue ret = null;

            Execute.Run(ssn =>
            {
                if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "UnitValue")) 
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                ret = _AssignValues(request, DocConstantPermission.ADD, ssn);
            });

            return ret;
        }
   
        public List<UnitValue> Post(UnitValueBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<UnitValue>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Post(dto) as UnitValue;
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

        public UnitValue Post(UnitValueCopy request)
        {
            UnitValue ret = null;
            Execute.Run(ssn =>
            {
                var entity = DocEntityUnitValue.GetUnitValue(request?.Id);
                if(null == entity) throw new HttpError(HttpStatusCode.NoContent, "The COPY request did not succeed.");
                if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");
                
                    var pEqualityOperator = entity.EqualityOperator;
                    var pMultiplier = entity.Multiplier;
                    var pNumber = entity.Number;
                    var pOrder = entity.Order;
                    var pOwners = entity.Owners.ToList();
                    var pUnit = entity.Unit;
                #region Custom Before copyUnitValue
                #endregion Custom Before copyUnitValue
                var copy = new DocEntityUnitValue(ssn)
                {
                    Hash = Guid.NewGuid()
                                , EqualityOperator = pEqualityOperator
                                , Multiplier = pMultiplier
                                , Number = pNumber
                                , Order = pOrder
                                , Unit = pUnit
                };
                            foreach(var item in pOwners)
                            {
                                entity.Owners.Add(item);
                            }

                #region Custom After copyUnitValue
                #endregion Custom After copyUnitValue
                copy.SaveChanges(DocConstantPermission.ADD);
                ret = copy.ToDto();
            });
            return ret;
        }


        public List<UnitValue> Put(UnitValueBatch request)
        {
            return Patch(request);
        }

        public UnitValue Put(UnitValue request)
        {
            return Patch(request);
        }

        public List<UnitValue> Patch(UnitValueBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<UnitValue>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Patch(dto) as UnitValue;
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

        public UnitValue Patch(UnitValue request)
        {
            if(true != (request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the UnitValue to patch.");
            
            request.VisibleFields = request.VisibleFields ?? new List<string>();
            
            UnitValue ret = null;
            Execute.Run(ssn =>
            {
                ret = _AssignValues(request, DocConstantPermission.EDIT, ssn);
            });
            return ret;
        }

        public void Delete(UnitValueBatch request)
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

        public void Delete(UnitValue request)
        {
            Execute.Run(ssn =>
            {
                if(!(request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, $"No Id provided for delete.");

                DocCacheClient.RemoveSearch(DocConstantModelName.UNITVALUE);
                DocCacheClient.RemoveById(request.Id);
                var en = DocEntityUnitValue.GetUnitValue(request?.Id);

                if(null == en) throw new HttpError(HttpStatusCode.NotFound, $"No UnitValue could be found for Id {request?.Id}.");
                if(en.IsRemoved) return;
                
                if(!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.DELETE))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have DELETE permission for this route.");
                
                en.Remove();
            });
        }

        public void Delete(UnitValueSearch request)
        {
            var matches = Get(request) as List<UnitValue>;
            if(true != matches?.Any()) throw new HttpError(HttpStatusCode.NotFound, "No matches for request");

            Execute.Run(ssn =>
            {
                matches.ForEach(match =>
                {
                    Delete(match);
                });
            });
        }
        public object Get(UnitValueJunction request) =>
            Execute.Run( s => 
            {
                switch(request.Junction.ToLower().TrimAndPruneSpaces())
                {
                    case "units":
                        return GetJunctionSearchResult<UnitValue, DocEntityUnitValue, DocEntityUnits, Units, UnitsSearch>((int)request.Id, DocConstantModelName.UNITS, "Owners", request, (ss) => HostContext.ResolveService<UnitsService>(Request)?.Get(ss));
                    default:
                        throw new HttpError(HttpStatusCode.NotFound, $"Route for unitvalue/{request.Id}/{request.Junction} was not found");
                }
            });
        public object Post(UnitValueJunction request) =>
            Execute.Run( ssn =>
            {
                switch(request.Junction.ToLower().TrimAndPruneSpaces())
                {
                    case "units":
                        return AddJunction<UnitValue, DocEntityUnitValue, DocEntityUnits, Units, UnitsSearch>((int)request.Id, DocConstantModelName.UNITS, "Owners", request);
                    default:
                        throw new HttpError(HttpStatusCode.NotFound, $"Route for unitvalue/{request.Id}/{request.Junction} was not found");
                }
            });

        public object Delete(UnitValueJunction request) =>
            Execute.Run( ssn =>
            {
                switch(request.Junction.ToLower().TrimAndPruneSpaces())
                {
                    case "units":
                        return RemoveJunction<UnitValue, DocEntityUnitValue, DocEntityUnits, Units, UnitsSearch>((int)request.Id, DocConstantModelName.UNITS, "Owners", request);
                    default:
                        throw new HttpError(HttpStatusCode.NotFound, $"Route for unitvalue/{request.Id}/{request.Junction} was not found");
                }
            });

        private UnitValue GetUnitValue(UnitValue request)
        {
            var id = request?.Id;
            UnitValue ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetVisibleFields<UnitValue>(currentUser, "UnitValue", request.VisibleFields);

            DocEntityUnitValue entity = null;
            if(id.HasValue)
            {
                entity = DocEntityUnitValue.GetUnitValue(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No UnitValue found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }
    }
}