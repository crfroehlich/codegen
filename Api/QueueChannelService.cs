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
        private IQueryable<DocEntityQueueChannel> _ExecSearch(QueueChannelSearch request)
        {
            request = InitSearch<QueueChannel, QueueChannelSearch>(request);
            IQueryable<DocEntityQueueChannel> entities = null;
            Execute.Run( session => 
            {
                entities = Execute.SelectAll<DocEntityQueueChannel>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new QueueChannelFullTextSearch(request);
                    entities = GetFullTextSearch<DocEntityQueueChannel,QueueChannelFullTextSearch>(fts, entities);
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
                if(!DocTools.IsNullOrEmpty(request.BackgroundTask) && !DocTools.IsNullOrEmpty(request.BackgroundTask.Id))
                {
                    entities = entities.Where(en => en.BackgroundTask.Id == request.BackgroundTask.Id );
                }
                if(true == request.BackgroundTaskIds?.Any())
                {
                    entities = entities.Where(en => en.BackgroundTask.Id.In(request.BackgroundTaskIds));
                }
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

                entities = ApplyFilters<DocEntityQueueChannel,QueueChannelSearch>(request, entities);

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

        public object Post(QueueChannelSearch request) => Get(request);

        public object Get(QueueChannelSearch request) => GetSearchResultWithCache<QueueChannel,DocEntityQueueChannel,QueueChannelSearch>(DocConstantModelName.QUEUECHANNEL, request, _ExecSearch);

        public object Post(QueueChannelVersion request) => Get(request);

        public object Get(QueueChannelVersion request) 
        {
            List<Version> ret = null;
            Execute.Run(s=>
            {
                ret = _ExecSearch(request).Select(e => new Version(e.Id, e.VersionNo)).ToList();
            });
            return ret;
        }

        public object Get(QueueChannel request) => GetEntityWithCache<QueueChannel>(DocConstantModelName.QUEUECHANNEL, request, GetQueueChannel);
        private QueueChannel _AssignValues(QueueChannel request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "QueueChannel"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            QueueChannel ret = null;
            request = _InitAssignValues<QueueChannel>(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            var cacheKey = GetApiCacheKey<QueueChannel>(DocConstantModelName.QUEUECHANNEL, nameof(QueueChannel), request);
            
            //First, assign all the variables, do database lookups and conversions
            var pAutoDelete = request.AutoDelete;
            var pBackgroundTask = (request.BackgroundTask?.Id > 0) ? DocEntityBackgroundTask.GetBackgroundTask(request.BackgroundTask.Id) : null;
            var pDescription = request.Description;
            var pDurable = request.Durable;
            var pEnabled = request.Enabled;
            var pExclusive = request.Exclusive;
            var pName = request.Name;

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
                entity = DocEntityQueueChannel.GetQueueChannel(request.Id);
                if(null == entity)
                    throw new HttpError(HttpStatusCode.NotFound, $"No record");
            }

            if (DocPermissionFactory.IsRequestedHasPermission<bool>(currentUser, request, pAutoDelete, permission, DocConstantModelName.QUEUECHANNEL, nameof(request.AutoDelete)))
            {
                if(DocPermissionFactory.IsRequested(request, pAutoDelete, entity.AutoDelete, nameof(request.AutoDelete)))
                    entity.AutoDelete = pAutoDelete;
                if(DocPermissionFactory.IsRequested<bool>(request, pAutoDelete, nameof(request.AutoDelete)) && !request.VisibleFields.Matches(nameof(request.AutoDelete), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.AutoDelete));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityBackgroundTask>(currentUser, request, pBackgroundTask, permission, DocConstantModelName.QUEUECHANNEL, nameof(request.BackgroundTask)))
            {
                if(DocPermissionFactory.IsRequested(request, pBackgroundTask, entity.BackgroundTask, nameof(request.BackgroundTask)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.BackgroundTask)} cannot be modified once set.");
                    entity.BackgroundTask = pBackgroundTask;
                if(DocPermissionFactory.IsRequested<DocEntityBackgroundTask>(request, pBackgroundTask, nameof(request.BackgroundTask)) && !request.VisibleFields.Matches(nameof(request.BackgroundTask), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.BackgroundTask));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pDescription, permission, DocConstantModelName.QUEUECHANNEL, nameof(request.Description)))
            {
                if(DocPermissionFactory.IsRequested(request, pDescription, entity.Description, nameof(request.Description)))
                    entity.Description = pDescription;
                if(DocPermissionFactory.IsRequested<string>(request, pDescription, nameof(request.Description)) && !request.VisibleFields.Matches(nameof(request.Description), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Description));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<bool>(currentUser, request, pDurable, permission, DocConstantModelName.QUEUECHANNEL, nameof(request.Durable)))
            {
                if(DocPermissionFactory.IsRequested(request, pDurable, entity.Durable, nameof(request.Durable)))
                    entity.Durable = pDurable;
                if(DocPermissionFactory.IsRequested<bool>(request, pDurable, nameof(request.Durable)) && !request.VisibleFields.Matches(nameof(request.Durable), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Durable));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<bool>(currentUser, request, pEnabled, permission, DocConstantModelName.QUEUECHANNEL, nameof(request.Enabled)))
            {
                if(DocPermissionFactory.IsRequested(request, pEnabled, entity.Enabled, nameof(request.Enabled)))
                    entity.Enabled = pEnabled;
                if(DocPermissionFactory.IsRequested<bool>(request, pEnabled, nameof(request.Enabled)) && !request.VisibleFields.Matches(nameof(request.Enabled), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Enabled));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<bool>(currentUser, request, pExclusive, permission, DocConstantModelName.QUEUECHANNEL, nameof(request.Exclusive)))
            {
                if(DocPermissionFactory.IsRequested(request, pExclusive, entity.Exclusive, nameof(request.Exclusive)))
                    entity.Exclusive = pExclusive;
                if(DocPermissionFactory.IsRequested<bool>(request, pExclusive, nameof(request.Exclusive)) && !request.VisibleFields.Matches(nameof(request.Exclusive), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Exclusive));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pName, permission, DocConstantModelName.QUEUECHANNEL, nameof(request.Name)))
            {
                if(DocPermissionFactory.IsRequested(request, pName, entity.Name, nameof(request.Name)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Name)} cannot be modified once set.");
                    entity.Name = pName;
                if(DocPermissionFactory.IsRequested<string>(request, pName, nameof(request.Name)) && !request.VisibleFields.Matches(nameof(request.Name), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Name));
                }
            }
            
            if (request.Locked) entity.Locked = request.Locked;

            entity.SaveChanges(permission);
            
            DocPermissionFactory.SetVisibleFields<QueueChannel>(currentUser, nameof(QueueChannel), request.VisibleFields);
            ret = entity.ToDto();

            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.QUEUECHANNEL);

            return ret;
        }
        public QueueChannel Post(QueueChannel request)
        {
            if(request == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            QueueChannel ret = null;

            Execute.Run(ssn =>
            {
                if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "QueueChannel")) 
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                ret = _AssignValues(request, DocConstantPermission.ADD, ssn);
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
                    var pBackgroundTask = entity.BackgroundTask;
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
                                , BackgroundTask = pBackgroundTask
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

        public QueueChannel Put(QueueChannel request)
        {
            return Patch(request);
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

        public QueueChannel Patch(QueueChannel request)
        {
            if(true != (request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the QueueChannel to patch.");
            
            request.VisibleFields = request.VisibleFields ?? new List<string>();
            
            QueueChannel ret = null;
            Execute.Run(ssn =>
            {
                ret = _AssignValues(request, DocConstantPermission.EDIT, ssn);
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
                if(!(request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, $"No Id provided for delete.");

                DocCacheClient.RemoveSearch(DocConstantModelName.QUEUECHANNEL);
                DocCacheClient.RemoveById(request.Id);
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