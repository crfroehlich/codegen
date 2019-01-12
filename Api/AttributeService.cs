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
    public partial class AttributeService : DocServiceBase
    {
        public const string CACHE_KEY_PREFIX = DocEntityAttribute.CACHE_KEY_PREFIX;
        private void _ExecSearch(AttributeSearch request, Action<IQueryable<DocEntityAttribute>> callBack)
        {
            request = InitSearch(request);
            
            DocPermissionFactory.SetVisibleFields<Attribute>(currentUser, "Attribute", request.VisibleFields);

            var entities = Execute.SelectAll<DocEntityAttribute>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new AttributeFullTextSearch(request);
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
                if(request.IsCharacteristic.HasValue)
                    entities = entities.Where(en => request.IsCharacteristic.Value == en.IsCharacteristic);
                if(request.IsOutcome.HasValue)
                    entities = entities.Where(en => request.IsOutcome.Value == en.IsOutcome);
                if(request.IsPositive.HasValue)
                    entities = entities.Where(en => request.IsPositive.Value == en.IsPositive);
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
        
        public object Post(AttributeSearch request)
        {
            object tryRet = null;
            Execute.Run(s =>
            {
                using (var cancellableRequest = base.Request.CreateCancellableRequest())
                {
                    var requestCancel = new DocRequestCancellation(HttpContext.Current.Response, cancellableRequest);
                    try 
                    {
                        var ret = new List<Attribute>();
                        _ExecSearch(request, (entities) => entities.ConvertFromEntityList<DocEntityAttribute,Attribute>(ret, Execute, requestCancel));
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

        public object Get(AttributeSearch request)
        {
            object tryRet = null;
            Execute.Run(s =>
            {
                using (var cancellableRequest = base.Request.CreateCancellableRequest())
                {
                    var requestCancel = new DocRequestCancellation(HttpContext.Current.Response, cancellableRequest);
                    try 
                    {
                        var ret = new List<Attribute>();
                        _ExecSearch(request, (entities) => entities.ConvertFromEntityList<DocEntityAttribute,Attribute>(ret, Execute, requestCancel));
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

        public object Post(AttributeVersion request) 
        {
            return Get(request);
        }

        public object Get(AttributeVersion request) 
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

        public object Get(Attribute request)
        {
            object ret = null;
            
            if(!(request.Id > 0))
                throw new HttpError(HttpStatusCode.NotFound, "Valid Id required.");

            Execute.Run(s =>
            {
                DocPermissionFactory.SetVisibleFields<Attribute>(currentUser, "Attribute", request.VisibleFields);
                ret = GetAttribute(request);
            });
            return ret;
        }

        private Attribute _AssignValues(Attribute dtoSource, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (dtoSource == null || dtoSource.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "Attribute"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            dtoSource.VisibleFields = dtoSource.VisibleFields ?? new List<string>();

            Attribute ret = null;
            dtoSource = _InitAssignValues(dtoSource, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && dtoSource.Id > 0) return dtoSource;
            
            //First, assign all the variables, do database lookups and conversions
            DocEntityLookupTable pAttributeName = GetLookup(DocConstantLookupTable.ATTRIBUTENAME, dtoSource.AttributeName?.Name, dtoSource.AttributeName?.Id);
            DocEntityLookupTable pAttributeType = GetLookup(DocConstantLookupTable.ATTRIBUTETYPE, dtoSource.AttributeType?.Name, dtoSource.AttributeType?.Id);
            var pInterval = (dtoSource.Interval?.Id > 0) ? DocEntityAttributeInterval.GetAttributeInterval(dtoSource.Interval.Id) : null;
            var pIsCharacteristic = dtoSource.IsCharacteristic;
            var pIsOutcome = dtoSource.IsOutcome;
            var pIsPositive = dtoSource.IsPositive;
            var pUniqueKey = dtoSource.UniqueKey;
            var pValueType = DocEntityValueType.GetValueType(dtoSource.ValueType);

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
                entity = DocEntityAttribute.GetAttribute(dtoSource.Id);
                if(null == entity)
                    throw new HttpError(HttpStatusCode.NotFound, $"No record");
            }

            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityLookupTable>(currentUser, dtoSource, pAttributeName, permission, DocConstantModelName.ATTRIBUTE, nameof(dtoSource.AttributeName)))
            {
                if(DocPermissionFactory.IsRequested(dtoSource, pAttributeName, entity.AttributeName, nameof(dtoSource.AttributeName)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(dtoSource.AttributeName)} cannot be modified once set.");
                    entity.AttributeName = pAttributeName;
                if(DocPermissionFactory.IsRequested<DocEntityLookupTable>(dtoSource, pAttributeName, nameof(dtoSource.AttributeName)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.AttributeName), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.AttributeName));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityLookupTable>(currentUser, dtoSource, pAttributeType, permission, DocConstantModelName.ATTRIBUTE, nameof(dtoSource.AttributeType)))
            {
                if(DocPermissionFactory.IsRequested(dtoSource, pAttributeType, entity.AttributeType, nameof(dtoSource.AttributeType)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(dtoSource.AttributeType)} cannot be modified once set.");
                    entity.AttributeType = pAttributeType;
                if(DocPermissionFactory.IsRequested<DocEntityLookupTable>(dtoSource, pAttributeType, nameof(dtoSource.AttributeType)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.AttributeType), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.AttributeType));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityAttributeInterval>(currentUser, dtoSource, pInterval, permission, DocConstantModelName.ATTRIBUTE, nameof(dtoSource.Interval)))
            {
                if(DocPermissionFactory.IsRequested(dtoSource, pInterval, entity.Interval, nameof(dtoSource.Interval)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(dtoSource.Interval)} cannot be modified once set.");
                    entity.Interval = pInterval;
                if(DocPermissionFactory.IsRequested<DocEntityAttributeInterval>(dtoSource, pInterval, nameof(dtoSource.Interval)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.Interval), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.Interval));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<bool>(currentUser, dtoSource, pIsCharacteristic, permission, DocConstantModelName.ATTRIBUTE, nameof(dtoSource.IsCharacteristic)))
            {
                if(DocPermissionFactory.IsRequested(dtoSource, pIsCharacteristic, entity.IsCharacteristic, nameof(dtoSource.IsCharacteristic)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(dtoSource.IsCharacteristic)} cannot be modified once set.");
                    entity.IsCharacteristic = pIsCharacteristic;
                if(DocPermissionFactory.IsRequested<bool>(dtoSource, pIsCharacteristic, nameof(dtoSource.IsCharacteristic)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.IsCharacteristic), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.IsCharacteristic));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<bool>(currentUser, dtoSource, pIsOutcome, permission, DocConstantModelName.ATTRIBUTE, nameof(dtoSource.IsOutcome)))
            {
                if(DocPermissionFactory.IsRequested(dtoSource, pIsOutcome, entity.IsOutcome, nameof(dtoSource.IsOutcome)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(dtoSource.IsOutcome)} cannot be modified once set.");
                    entity.IsOutcome = pIsOutcome;
                if(DocPermissionFactory.IsRequested<bool>(dtoSource, pIsOutcome, nameof(dtoSource.IsOutcome)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.IsOutcome), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.IsOutcome));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<bool?>(currentUser, dtoSource, pIsPositive, permission, DocConstantModelName.ATTRIBUTE, nameof(dtoSource.IsPositive)))
            {
                if(DocPermissionFactory.IsRequested(dtoSource, pIsPositive, entity.IsPositive, nameof(dtoSource.IsPositive)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(dtoSource.IsPositive)} cannot be modified once set.");
                    entity.IsPositive = pIsPositive;
                if(DocPermissionFactory.IsRequested<bool?>(dtoSource, pIsPositive, nameof(dtoSource.IsPositive)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.IsPositive), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.IsPositive));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, dtoSource, pUniqueKey, permission, DocConstantModelName.ATTRIBUTE, nameof(dtoSource.UniqueKey)))
            {
                if(DocPermissionFactory.IsRequested(dtoSource, pUniqueKey, entity.UniqueKey, nameof(dtoSource.UniqueKey)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(dtoSource.UniqueKey)} cannot be modified once set.");
                    entity.UniqueKey = pUniqueKey;
                if(DocPermissionFactory.IsRequested<string>(dtoSource, pUniqueKey, nameof(dtoSource.UniqueKey)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.UniqueKey), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.UniqueKey));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityValueType>(currentUser, dtoSource, pValueType, permission, DocConstantModelName.ATTRIBUTE, nameof(dtoSource.ValueType)))
            {
                if(DocPermissionFactory.IsRequested(dtoSource, pValueType, entity.ValueType, nameof(dtoSource.ValueType)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(dtoSource.ValueType)} cannot be modified once set.");
                    entity.ValueType = pValueType;
                if(DocPermissionFactory.IsRequested<DocEntityValueType>(dtoSource, pValueType, nameof(dtoSource.ValueType)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.ValueType), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.ValueType));
                }
            }
            
            if (dtoSource.Locked) entity.Locked = dtoSource.Locked;

            entity.SaveChanges(permission);
            
            DocPermissionFactory.SetVisibleFields<Attribute>(currentUser, nameof(Attribute), dtoSource.VisibleFields);
            ret = entity.ToDto();

            return ret;
        }
        public Attribute Post(Attribute dtoSource)
        {
            if(dtoSource == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            dtoSource.VisibleFields = dtoSource.VisibleFields ?? new List<string>();

            Attribute ret = null;

            Execute.Run(ssn =>
            {
                if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "Attribute")) 
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                ret = _AssignValues(dtoSource, DocConstantPermission.ADD, ssn);
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
                copy.SaveChanges(DocConstantPermission.ADD);
                ret = copy.ToDto();
            });
            return ret;
        }


        public List<Attribute> Put(AttributeBatch request)
        {
            return Patch(request);
        }

        public Attribute Put(Attribute dtoSource)
        {
            return Patch(dtoSource);
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

        public Attribute Patch(Attribute dtoSource)
        {
            if(true != (dtoSource?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the Attribute to patch.");
            
            dtoSource.VisibleFields = dtoSource.VisibleFields ?? new List<string>();
            
            Attribute ret = null;
            Execute.Run(ssn =>
            {
                ret = _AssignValues(dtoSource, DocConstantPermission.EDIT, ssn);
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

        public List<int> Any(AttributeIds request)
        {
            List<int> ret = null;
            if (currentUser.IsSuperAdmin)
            {
                Execute.Run(s => { ret = Execute.SelectAll<DocEntityAttribute>().Select(d => d.Id).ToList(); });
            }
            else
            {
                throw new HttpError(HttpStatusCode.Forbidden);
            }
            return ret;
        }
    }
}