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
    public partial class QueueChannelService : DocServiceBase
    {
        public const string CACHE_KEY_PREFIX = DocEntityQueueChannel.CACHE_KEY_PREFIX;
        private object _GetIdCache(QueueChannel request)
        {
            object ret = null;

            if (true != request.IgnoreCache)
            {
                var key = currentUser.GetApiCacheKey(DocConstantModelName.QUEUECHANNEL);
                var cacheKey = $"QueueChannel_{key}_{request.Id}_{UrnId.Create<QueueChannel>(request.GetMD5Hash())}";
                ret = Request.ToOptimizedResultUsingCache(Cache, cacheKey, new TimeSpan(0, DocResources.Settings.SessionTimeout, 0), () =>
                {
                    object cachedRet = null;
                    Execute.Run(s =>
                    {
                        cachedRet = GetQueueChannel(request);
                    });
                    return cachedRet;
                });
            }
            if(null == ret)
            {
                Execute.Run(s =>
                {
                    ret = GetQueueChannel(request);
                });
            }
            return ret;
        }

        private object _GetSearchCache(QueueChannelSearch request, DocRequestCancellation requestCancel)
        {
            object tryRet = null;
            var ret = new List<QueueChannel>();

            //Keys need to be customized to factor in permissions/scoping. Often, including the current user's Role Id is sufficient in the key
            var key = currentUser.GetApiCacheKey(DocConstantModelName.QUEUECHANNEL);
            var cacheKey = $"{CACHE_KEY_PREFIX}_{key}_{UrnId.Create<QueueChannelSearch>(request.GetMD5Hash())}";
            tryRet = Request.ToOptimizedResultUsingCache(Cache, cacheKey, new TimeSpan(0, DocResources.Settings.SessionTimeout, 0), () =>
            {
                _ExecSearch(request, (entities) => entities.ConvertFromEntityList<DocEntityQueueChannel,QueueChannel>(ret, Execute, requestCancel));
                return ret;
            });

            if(tryRet == null)
            {
                ret = new List<QueueChannel>();
                _ExecSearch(request, (entities) => entities.ConvertFromEntityList<DocEntityQueueChannel,QueueChannel>(ret, Execute, requestCancel));
                return ret;
            }
            else
            {
                return tryRet;
            }
        }
        private void _ExecSearch(QueueChannelSearch request, Action<IQueryable<DocEntityQueueChannel>> callBack)
        {
            request = InitSearch(request);
            
            DocPermissionFactory.SetVisibleFields<QueueChannel>(currentUser, "QueueChannel", request.VisibleFields);

            Execute.Run( session => 
            {
                var entities = Execute.SelectAll<DocEntityQueueChannel>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new QueueChannelFullTextSearch(request);
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

                if(request.AutoDelete.HasValue)
                    entities = entities.Where(en => request.AutoDelete.Value == en.AutoDelete);
                if(!DocTools.IsNullOrEmpty(request.Description))
                    entities = entities.Where(en => en.Description.Contains(request.Description));
                if(request.Durable.HasValue)
                    entities = entities.Where(en => request.Durable.Value == en.Durable);
                if(request.Enabled.HasValue)
                    entities = entities.Where(en => request.Enabled.Value == en.Enabled);
                if(request.Exclusive.HasValue)
                    entities = entities.Where(en => request.Exclusive.Value == en.Exclusive);
                if(!DocTools.IsNullOrEmpty(request.Name))
                    entities = entities.Where(en => en.Name.Contains(request.Name));

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
            });
        }
        
        public object Post(QueueChannelSearch request)
        {
            object tryRet = null;
            using (var cancellableRequest = base.Request.CreateCancellableRequest())
            {
                var requestCancel = new DocRequestCancellation(HttpContext.Current.Response, cancellableRequest);
                try 
                {
                    var ret = new List<QueueChannel>();
                    var settings = DocResources.Settings;
                    if(true != request.IgnoreCache && settings.Cache.CacheWebServices && true != settings.Cache.ExcludedServicesFromCache?.Any(webservice => webservice.ToLower().Trim() == "queuechannel")) 
                    {
                        tryRet = _GetSearchCache(request, requestCancel);
                    }
                    if (tryRet == null)
                    {
                        _ExecSearch(request, (entities) => entities.ConvertFromEntityList<DocEntityQueueChannel,QueueChannel>(ret, Execute, requestCancel));
                        tryRet = ret;
                    }
                }
                catch(Exception) { throw; }
                finally
                {
                    requestCancel?.CloseRequest();
                }
            }
            return tryRet;
        }

        public object Get(QueueChannelSearch request)
        {
            object tryRet = null;
            using (var cancellableRequest = base.Request.CreateCancellableRequest())
            {
                var requestCancel = new DocRequestCancellation(HttpContext.Current.Response, cancellableRequest);
                try 
                {
                    var ret = new List<QueueChannel>();
                    var settings = DocResources.Settings;
                    if(true != request.IgnoreCache && settings.Cache.CacheWebServices && true != settings.Cache.ExcludedServicesFromCache?.Any(webservice => webservice.ToLower().Trim() == "queuechannel")) 
                    {
                        tryRet = _GetSearchCache(request, requestCancel);
                    }
                    if (tryRet == null)
                    {
                        _ExecSearch(request, (entities) => entities.ConvertFromEntityList<DocEntityQueueChannel,QueueChannel>(ret, Execute, requestCancel));
                        tryRet = ret;
                    }
                }
                catch(Exception) { throw; }
                finally
                {
                    requestCancel?.CloseRequest();
                }
            }
            return tryRet;
        }

        public object Post(QueueChannelVersion request) 
        {
            return Get(request);
        }

        public object Get(QueueChannelVersion request) 
        {
            var ret = new List<Version>();
            _ExecSearch(request, (entities) => 
            {
                ret = entities.Select(e => new Version(e.Id, e.VersionNo)).ToList();
            });
            return ret;
        }

        public object Get(QueueChannel request)
        {
            QueueChannel ret = null;
            
            if(!(request.Id > 0))
                throw new HttpError(HttpStatusCode.NotFound, "Valid Id required.");

            DocPermissionFactory.SetVisibleFields<QueueChannel>(currentUser, "QueueChannel", request.VisibleFields);
            var settings = DocResources.Settings;
            if(true != request.IgnoreCache && settings.Cache.CacheWebServices && true != settings.Cache.ExcludedServicesFromCache?.Any(webservice => webservice.ToLower().Trim() == "queuechannel")) 
            {
                return _GetIdCache(request);
            }
            else 
            {
                Execute.Run((ssn) =>
                {
                    ret = GetQueueChannel(request);
                });
            }
            return ret;
        }

        private QueueChannel _AssignValues(QueueChannel dtoSource, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (dtoSource == null || dtoSource.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "QueueChannel"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            dtoSource.VisibleFields = dtoSource.VisibleFields ?? new List<string>();

            QueueChannel ret = null;
            dtoSource = _InitAssignValues(dtoSource, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && dtoSource.Id > 0) return dtoSource;
            
            //First, assign all the variables, do database lookups and conversions
            var pAutoDelete = dtoSource.AutoDelete;
            var pDescription = dtoSource.Description;
            var pDurable = dtoSource.Durable;
            var pEnabled = dtoSource.Enabled;
            var pExclusive = dtoSource.Exclusive;
            var pName = dtoSource.Name;

            DocEntityQueueChannel entity = null;
            if(permission == DocConstantPermission.ADD)
            {
                var now = DateTime.UtcNow;
                entity = new DocEntityQueueChannel(session)
                {
                    Created = now,
                    Updated = now
                };
            }
            else
            {
                entity = DocEntityQueueChannel.GetQueueChannel(dtoSource.Id);
                if(null == entity)
                    throw new HttpError(HttpStatusCode.NotFound, $"No record");
            }

            if (DocPermissionFactory.IsRequestedHasPermission<bool>(currentUser, dtoSource, pAutoDelete, permission, DocConstantModelName.QUEUECHANNEL, nameof(dtoSource.AutoDelete)))
            {
                if(DocPermissionFactory.IsRequested(dtoSource, pAutoDelete, entity.AutoDelete, nameof(dtoSource.AutoDelete)))
                    entity.AutoDelete = pAutoDelete;
                if(DocPermissionFactory.IsRequested<bool>(dtoSource, pAutoDelete, nameof(dtoSource.AutoDelete)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.AutoDelete), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.AutoDelete));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, dtoSource, pDescription, permission, DocConstantModelName.QUEUECHANNEL, nameof(dtoSource.Description)))
            {
                if(DocPermissionFactory.IsRequested(dtoSource, pDescription, entity.Description, nameof(dtoSource.Description)))
                    entity.Description = pDescription;
                if(DocPermissionFactory.IsRequested<string>(dtoSource, pDescription, nameof(dtoSource.Description)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.Description), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.Description));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<bool>(currentUser, dtoSource, pDurable, permission, DocConstantModelName.QUEUECHANNEL, nameof(dtoSource.Durable)))
            {
                if(DocPermissionFactory.IsRequested(dtoSource, pDurable, entity.Durable, nameof(dtoSource.Durable)))
                    entity.Durable = pDurable;
                if(DocPermissionFactory.IsRequested<bool>(dtoSource, pDurable, nameof(dtoSource.Durable)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.Durable), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.Durable));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<bool>(currentUser, dtoSource, pEnabled, permission, DocConstantModelName.QUEUECHANNEL, nameof(dtoSource.Enabled)))
            {
                if(DocPermissionFactory.IsRequested(dtoSource, pEnabled, entity.Enabled, nameof(dtoSource.Enabled)))
                    entity.Enabled = pEnabled;
                if(DocPermissionFactory.IsRequested<bool>(dtoSource, pEnabled, nameof(dtoSource.Enabled)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.Enabled), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.Enabled));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<bool>(currentUser, dtoSource, pExclusive, permission, DocConstantModelName.QUEUECHANNEL, nameof(dtoSource.Exclusive)))
            {
                if(DocPermissionFactory.IsRequested(dtoSource, pExclusive, entity.Exclusive, nameof(dtoSource.Exclusive)))
                    entity.Exclusive = pExclusive;
                if(DocPermissionFactory.IsRequested<bool>(dtoSource, pExclusive, nameof(dtoSource.Exclusive)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.Exclusive), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.Exclusive));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, dtoSource, pName, permission, DocConstantModelName.QUEUECHANNEL, nameof(dtoSource.Name)))
            {
                if(DocPermissionFactory.IsRequested(dtoSource, pName, entity.Name, nameof(dtoSource.Name)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(dtoSource.Name)} cannot be modified once set.");
                    entity.Name = pName;
                if(DocPermissionFactory.IsRequested<string>(dtoSource, pName, nameof(dtoSource.Name)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.Name), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.Name));
                }
            }
            
            if (dtoSource.Locked) entity.Locked = dtoSource.Locked;

            entity.SaveChanges(permission);
            
            DocPermissionFactory.SetVisibleFields<QueueChannel>(currentUser, nameof(QueueChannel), dtoSource.VisibleFields);
            ret = entity.ToDto();

            return ret;
        }
        public QueueChannel Post(QueueChannel dtoSource)
        {
            if(dtoSource == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            dtoSource.VisibleFields = dtoSource.VisibleFields ?? new List<string>();

            QueueChannel ret = null;

            Execute.Run(ssn =>
            {
                if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "QueueChannel")) 
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                ret = _AssignValues(dtoSource, DocConstantPermission.ADD, ssn);
            });

            return ret;
        }
   
        public List<QueueChannel> Post(QueueChannelBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<QueueChannel>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Post(dto) as QueueChannel;
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

        public QueueChannel Post(QueueChannelCopy request)
        {
            QueueChannel ret = null;
            Execute.Run(ssn =>
            {
                var entity = DocEntityQueueChannel.GetQueueChannel(request?.Id);
                if(null == entity) throw new HttpError(HttpStatusCode.NoContent, "The COPY request did not succeed.");
                if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");
                
                    var pAutoDelete = entity.AutoDelete;
                    var pDescription = entity.Description;
                    if(!DocTools.IsNullOrEmpty(pDescription))
                        pDescription += " (Copy)";
                    var pDurable = entity.Durable;
                    var pEnabled = entity.Enabled;
                    var pExclusive = entity.Exclusive;
                    var pName = entity.Name;
                    if(!DocTools.IsNullOrEmpty(pName))
                        pName += " (Copy)";
                #region Custom Before copyQueueChannel
                #endregion Custom Before copyQueueChannel
                var copy = new DocEntityQueueChannel(ssn)
                {
                    Hash = Guid.NewGuid()
                                , AutoDelete = pAutoDelete
                                , Description = pDescription
                                , Durable = pDurable
                                , Enabled = pEnabled
                                , Exclusive = pExclusive
                                , Name = pName
                };
                #region Custom After copyQueueChannel
                #endregion Custom After copyQueueChannel
                copy.SaveChanges(DocConstantPermission.ADD);
                ret = copy.ToDto();
            });
            return ret;
        }


        public List<QueueChannel> Put(QueueChannelBatch request)
        {
            return Patch(request);
        }

        public QueueChannel Put(QueueChannel dtoSource)
        {
            return Patch(dtoSource);
        }

        public List<QueueChannel> Patch(QueueChannelBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<QueueChannel>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Patch(dto) as QueueChannel;
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

        public QueueChannel Patch(QueueChannel dtoSource)
        {
            if(true != (dtoSource?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the QueueChannel to patch.");
            
            dtoSource.VisibleFields = dtoSource.VisibleFields ?? new List<string>();
            
            QueueChannel ret = null;
            Execute.Run(ssn =>
            {
                ret = _AssignValues(dtoSource, DocConstantPermission.EDIT, ssn);
            });
            return ret;
        }

        public void Delete(QueueChannelBatch request)
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

        public void Delete(QueueChannel request)
        {
            Execute.Run(ssn =>
            {
                var en = DocEntityQueueChannel.GetQueueChannel(request?.Id);

                if(null == en) throw new HttpError(HttpStatusCode.NotFound, $"No QueueChannel could be found for Id {request?.Id}.");
                if(en.IsRemoved) return;
                
                if(!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.DELETE))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have DELETE permission for this route.");
                
                en.Remove();
            });
        }

        public void Delete(QueueChannelSearch request)
        {
            var matches = Get(request) as List<QueueChannel>;
            if(true != matches?.Any()) throw new HttpError(HttpStatusCode.NotFound, "No matches for request");

            Execute.Run(ssn =>
            {
                matches.ForEach(match =>
                {
                    Delete(match);
                });
            });
        }

        private QueueChannel GetQueueChannel(QueueChannel request)
        {
            var id = request?.Id;
            QueueChannel ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetVisibleFields<QueueChannel>(currentUser, "QueueChannel", request.VisibleFields);

            DocEntityQueueChannel entity = null;
            if(id.HasValue)
            {
                entity = DocEntityQueueChannel.GetQueueChannel(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No QueueChannel found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }

        public List<int> Any(QueueChannelIds request)
        {
            List<int> ret = null;
            if (currentUser.IsSuperAdmin)
            {
                Execute.Run(s => { ret = Execute.SelectAll<DocEntityQueueChannel>().Select(d => d.Id).ToList(); });
            }
            else
            {
                throw new HttpError(HttpStatusCode.Forbidden);
            }

            return ret;
        }
    }
}