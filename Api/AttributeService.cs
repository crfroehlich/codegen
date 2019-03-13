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
    public partial class AttributeService : DocServiceBase
    {
        private IQueryable<DocEntityAttribute> _ExecSearch(AttributeSearch request)
        {
            request = InitSearch<Attribute, AttributeSearch>(request);
            IQueryable<DocEntityAttribute> entities = null;
            Execute.Run( session => 
            {
                entities = Execute.SelectAll<DocEntityAttribute>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new AttributeFullTextSearch(request);
                    entities = GetFullTextSearch<DocEntityAttribute,AttributeFullTextSearch>(fts, entities);
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
                if(true == request.Archived?.Any() && currentUser.HasProperty(DocConstantModelName.ATTRIBUTE, nameof(Reference.Archived), DocConstantPermission.VIEW))
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

                if(!DocTools.IsNullOrEmpty(request.AttributeName) && !DocTools.IsNullOrEmpty(request.AttributeName.Id))
                {
                    entities = entities.Where(en => en.AttributeName.Id == request.AttributeName.Id );
                }
                if(true == request.AttributeNameIds?.Any())
                {
                    entities = entities.Where(en => en.AttributeName.Id.In(request.AttributeNameIds));
                }
                else if(!DocTools.IsNullOrEmpty(request.AttributeName) && !DocTools.IsNullOrEmpty(request.AttributeName.Name))
                {
                    entities = entities.Where(en => en.AttributeName.Name == request.AttributeName.Name );
                }
                if(true == request.AttributeNameNames?.Any())
                {
                    entities = entities.Where(en => en.AttributeName.Name.In(request.AttributeNameNames));
                }
                if(!DocTools.IsNullOrEmpty(request.AttributeType) && !DocTools.IsNullOrEmpty(request.AttributeType.Id))
                {
                    entities = entities.Where(en => en.AttributeType.Id == request.AttributeType.Id );
                }
                if(true == request.AttributeTypeIds?.Any())
                {
                    entities = entities.Where(en => en.AttributeType.Id.In(request.AttributeTypeIds));
                }
                else if(!DocTools.IsNullOrEmpty(request.AttributeType) && !DocTools.IsNullOrEmpty(request.AttributeType.Name))
                {
                    entities = entities.Where(en => en.AttributeType.Name == request.AttributeType.Name );
                }
                if(true == request.AttributeTypeNames?.Any())
                {
                    entities = entities.Where(en => en.AttributeType.Name.In(request.AttributeTypeNames));
                }
                if(!DocTools.IsNullOrEmpty(request.Interval) && !DocTools.IsNullOrEmpty(request.Interval.Id))
                {
                    entities = entities.Where(en => en.Interval.Id == request.Interval.Id );
                }
                if(true == request.IntervalIds?.Any())
                {
                    entities = entities.Where(en => en.Interval.Id.In(request.IntervalIds));
                }
                if(true == request.IsCharacteristic?.Any())
                {
                    if(request.IsCharacteristic.Any(v => v == null)) entities = entities.Where(en => en.IsCharacteristic.In(request.IsCharacteristic) || en.IsCharacteristic == null);
                    else entities = entities.Where(en => en.IsCharacteristic.In(request.IsCharacteristic));
                }
                if(true == request.IsOutcome?.Any())
                {
                    if(request.IsOutcome.Any(v => v == null)) entities = entities.Where(en => en.IsOutcome.In(request.IsOutcome) || en.IsOutcome == null);
                    else entities = entities.Where(en => en.IsOutcome.In(request.IsOutcome));
                }
                if(true == request.IsPositive?.Any())
                {
                    if(request.IsPositive.Any(v => v == null)) entities = entities.Where(en => en.IsPositive.In(request.IsPositive) || en.IsPositive == null);
                    else entities = entities.Where(en => en.IsPositive.In(request.IsPositive));
                }
                if(!DocTools.IsNullOrEmpty(request.UniqueKey))
                    entities = entities.Where(en => en.UniqueKey.Contains(request.UniqueKey));
                if(!DocTools.IsNullOrEmpty(request.ValueType) && !DocTools.IsNullOrEmpty(request.ValueType.Id))
                {
                    entities = entities.Where(en => en.ValueType.Id == request.ValueType.Id );
                }
                if(true == request.ValueTypeIds?.Any())
                {
                    entities = entities.Where(en => en.ValueType.Id.In(request.ValueTypeIds));
                }

                entities = ApplyFilters<DocEntityAttribute,AttributeSearch>(request, entities);

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

        public object Post(AttributeSearch request) => Get(request);

        public object Get(AttributeSearch request) => GetSearchResultWithCache<Attribute,DocEntityAttribute,AttributeSearch>(DocConstantModelName.ATTRIBUTE, request, _ExecSearch);

        public object Get(Attribute request) => GetEntityWithCache<Attribute>(DocConstantModelName.ATTRIBUTE, request, GetAttribute);

        private Attribute _AssignValues(Attribute request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "Attribute"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            Attribute ret = null;
            request = _InitAssignValues<Attribute>(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            var cacheKey = GetApiCacheKey<Attribute>(DocConstantModelName.ATTRIBUTE, nameof(Attribute), request);
            
            //First, assign all the variables, do database lookups and conversions
            DocEntityLookupTable pAttributeName = GetLookup(DocConstantLookupTable.ATTRIBUTENAME, request.AttributeName?.Name, request.AttributeName?.Id);
            DocEntityLookupTable pAttributeType = GetLookup(DocConstantLookupTable.ATTRIBUTETYPE, request.AttributeType?.Name, request.AttributeType?.Id);
            var pInterval = (request.Interval?.Id > 0) ? DocEntityAttributeInterval.GetAttributeInterval(request.Interval.Id) : null;
            var pIsCharacteristic = request.IsCharacteristic;
            var pIsOutcome = request.IsOutcome;
            var pIsPositive = request.IsPositive;
            var pUniqueKey = request.UniqueKey;
            var pValueType = DocEntityValueType.GetValueType(request.ValueType);

            DocEntityAttribute entity = null;
            if(permission == DocConstantPermission.ADD)
            {
                var now = DateTime.UtcNow;
                entity = new DocEntityAttribute(session)
                {
                    Created = now,
                    Updated = now
                };
            }
            else
            {
                entity = DocEntityAttribute.GetAttribute(request.Id);
                if(null == entity)
                    throw new HttpError(HttpStatusCode.NotFound, $"No record");
            }

            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityLookupTable>(currentUser, request, pAttributeName, permission, DocConstantModelName.ATTRIBUTE, nameof(request.AttributeName)))
            {
                if(DocPermissionFactory.IsRequested(request, pAttributeName, entity.AttributeName, nameof(request.AttributeName)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.AttributeName)} cannot be modified once set.");
                    entity.AttributeName = pAttributeName;
                if(DocPermissionFactory.IsRequested<DocEntityLookupTable>(request, pAttributeName, nameof(request.AttributeName)) && !request.VisibleFields.Matches(nameof(request.AttributeName), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.AttributeName));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityLookupTable>(currentUser, request, pAttributeType, permission, DocConstantModelName.ATTRIBUTE, nameof(request.AttributeType)))
            {
                if(DocPermissionFactory.IsRequested(request, pAttributeType, entity.AttributeType, nameof(request.AttributeType)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.AttributeType)} cannot be modified once set.");
                    entity.AttributeType = pAttributeType;
                if(DocPermissionFactory.IsRequested<DocEntityLookupTable>(request, pAttributeType, nameof(request.AttributeType)) && !request.VisibleFields.Matches(nameof(request.AttributeType), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.AttributeType));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityAttributeInterval>(currentUser, request, pInterval, permission, DocConstantModelName.ATTRIBUTE, nameof(request.Interval)))
            {
                if(DocPermissionFactory.IsRequested(request, pInterval, entity.Interval, nameof(request.Interval)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Interval)} cannot be modified once set.");
                    entity.Interval = pInterval;
                if(DocPermissionFactory.IsRequested<DocEntityAttributeInterval>(request, pInterval, nameof(request.Interval)) && !request.VisibleFields.Matches(nameof(request.Interval), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Interval));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<bool>(currentUser, request, pIsCharacteristic, permission, DocConstantModelName.ATTRIBUTE, nameof(request.IsCharacteristic)))
            {
                if(DocPermissionFactory.IsRequested(request, pIsCharacteristic, entity.IsCharacteristic, nameof(request.IsCharacteristic)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.IsCharacteristic)} cannot be modified once set.");
                    entity.IsCharacteristic = pIsCharacteristic;
                if(DocPermissionFactory.IsRequested<bool>(request, pIsCharacteristic, nameof(request.IsCharacteristic)) && !request.VisibleFields.Matches(nameof(request.IsCharacteristic), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.IsCharacteristic));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<bool>(currentUser, request, pIsOutcome, permission, DocConstantModelName.ATTRIBUTE, nameof(request.IsOutcome)))
            {
                if(DocPermissionFactory.IsRequested(request, pIsOutcome, entity.IsOutcome, nameof(request.IsOutcome)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.IsOutcome)} cannot be modified once set.");
                    entity.IsOutcome = pIsOutcome;
                if(DocPermissionFactory.IsRequested<bool>(request, pIsOutcome, nameof(request.IsOutcome)) && !request.VisibleFields.Matches(nameof(request.IsOutcome), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.IsOutcome));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<bool?>(currentUser, request, pIsPositive, permission, DocConstantModelName.ATTRIBUTE, nameof(request.IsPositive)))
            {
                if(DocPermissionFactory.IsRequested(request, pIsPositive, entity.IsPositive, nameof(request.IsPositive)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.IsPositive)} cannot be modified once set.");
                    entity.IsPositive = pIsPositive;
                if(DocPermissionFactory.IsRequested<bool?>(request, pIsPositive, nameof(request.IsPositive)) && !request.VisibleFields.Matches(nameof(request.IsPositive), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.IsPositive));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pUniqueKey, permission, DocConstantModelName.ATTRIBUTE, nameof(request.UniqueKey)))
            {
                if(DocPermissionFactory.IsRequested(request, pUniqueKey, entity.UniqueKey, nameof(request.UniqueKey)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.UniqueKey)} cannot be modified once set.");
                    entity.UniqueKey = pUniqueKey;
                if(DocPermissionFactory.IsRequested<string>(request, pUniqueKey, nameof(request.UniqueKey)) && !request.VisibleFields.Matches(nameof(request.UniqueKey), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.UniqueKey));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityValueType>(currentUser, request, pValueType, permission, DocConstantModelName.ATTRIBUTE, nameof(request.ValueType)))
            {
                if(DocPermissionFactory.IsRequested(request, pValueType, entity.ValueType, nameof(request.ValueType)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.ValueType)} cannot be modified once set.");
                    entity.ValueType = pValueType;
                if(DocPermissionFactory.IsRequested<DocEntityValueType>(request, pValueType, nameof(request.ValueType)) && !request.VisibleFields.Matches(nameof(request.ValueType), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.ValueType));
                }
            }

            if (request.Locked) entity.Locked = request.Locked;

            entity.SaveChanges(permission);


            DocPermissionFactory.SetVisibleFields<Attribute>(currentUser, nameof(Attribute), request.VisibleFields);
            ret = entity.ToDto();

            var cacheExpires = DocResources.Metadata.GetCacheExpiration(DocConstantModelName.ATTRIBUTE);
            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.ATTRIBUTE, cacheExpires);

            return ret;
        }
        public Attribute Post(Attribute request)
        {
            if(request == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            Attribute ret = null;

            Execute.Run(ssn =>
            {
                if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "Attribute")) 
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                ret = _AssignValues(request, DocConstantPermission.ADD, ssn);
            });

            return ret;
        }
   
        public List<Attribute> Post(AttributeBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<Attribute>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Post(dto) as Attribute;
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

        public Attribute Post(AttributeCopy request)
        {
            Attribute ret = null;
            Execute.Run(ssn =>
            {
                var entity = DocEntityAttribute.GetAttribute(request?.Id);
                if(null == entity) throw new HttpError(HttpStatusCode.NoContent, "The COPY request did not succeed.");
                if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                    var pAttributeName = entity.AttributeName;
                    var pAttributeType = entity.AttributeType;
                    var pInterval = entity.Interval;
                    var pIsCharacteristic = entity.IsCharacteristic;
                    var pIsOutcome = entity.IsOutcome;
                    var pIsPositive = entity.IsPositive;
                    var pUniqueKey = entity.UniqueKey;
                    if(!DocTools.IsNullOrEmpty(pUniqueKey))
                        pUniqueKey += " (Copy)";
                    var pValueType = entity.ValueType;
                #region Custom Before copyAttribute
                #endregion Custom Before copyAttribute
                var copy = new DocEntityAttribute(ssn)
                {
                    Hash = Guid.NewGuid()
                                , AttributeName = pAttributeName
                                , AttributeType = pAttributeType
                                , Interval = pInterval
                                , IsCharacteristic = pIsCharacteristic
                                , IsOutcome = pIsOutcome
                                , IsPositive = pIsPositive
                                , UniqueKey = pUniqueKey
                                , ValueType = pValueType
                };

                #region Custom After copyAttribute
                #endregion Custom After copyAttribute
                copy.SaveChanges(DocConstantPermission.ADD);
                ret = copy.ToDto();
            });
            return ret;
        }

        public List<Attribute> Put(AttributeBatch request)
        {
            return Patch(request);
        }

        public Attribute Put(Attribute request)
        {
            return Patch(request);
        }
        public List<Attribute> Patch(AttributeBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<Attribute>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Patch(dto) as Attribute;
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

        public Attribute Patch(Attribute request)
        {
            if(true != (request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the Attribute to patch.");
            
            request.VisibleFields = request.VisibleFields ?? new List<string>();
            
            Attribute ret = null;
            Execute.Run(ssn =>
            {
                ret = _AssignValues(request, DocConstantPermission.EDIT, ssn);
            });
            return ret;
        }
        public void Delete(AttributeBatch request)
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

        public void Delete(Attribute request)
        {
            Execute.Run(ssn =>
            {
                if(!(request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, $"No Id provided for delete.");

                DocCacheClient.RemoveSearch(DocConstantModelName.ATTRIBUTE);
                DocCacheClient.RemoveById(request.Id);
                var en = DocEntityAttribute.GetAttribute(request?.Id);

                if(null == en) throw new HttpError(HttpStatusCode.NotFound, $"No Attribute could be found for Id {request?.Id}.");
                if(en.IsRemoved) return;
                
                if(!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.DELETE))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have DELETE permission for this route.");
                
                en.Remove();
            });
        }

        public void Delete(AttributeSearch request)
        {
            var matches = Get(request) as List<Attribute>;
            if(true != matches?.Any()) throw new HttpError(HttpStatusCode.NotFound, "No matches for request");

            Execute.Run(ssn =>
            {
                matches.ForEach(match =>
                {
                    Delete(match);
                });
            });
        }
        private Attribute GetAttribute(Attribute request)
        {
            var id = request?.Id;
            Attribute ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetVisibleFields<Attribute>(currentUser, "Attribute", request.VisibleFields);

            DocEntityAttribute entity = null;
            if(id.HasValue)
            {
                entity = DocEntityAttribute.GetAttribute(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No Attribute found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }
    }
}
