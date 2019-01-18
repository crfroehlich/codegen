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
    public partial class DocumentAttributeService : DocServiceBase
    {
        private void _ExecSearch(DocumentAttributeSearch request, Action<IQueryable<DocEntityDocumentAttribute>> callBack)
        {
            request = InitSearch(request);
            
            DocPermissionFactory.SetVisibleFields<DocumentAttribute>(currentUser, "DocumentAttribute", request.VisibleFields);

            Execute.Run( session => 
            {
                var entities = Execute.SelectAll<DocEntityDocumentAttribute>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new DocumentAttributeFullTextSearch(request);
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

                if(!DocTools.IsNullOrEmpty(request.Attribute) && !DocTools.IsNullOrEmpty(request.Attribute.Id))
                {
                    entities = entities.Where(en => en.Attribute.Id == request.Attribute.Id );
                }
                if(true == request.AttributeIds?.Any())
                {
                    entities = entities.Where(en => en.Attribute.Id.In(request.AttributeIds));
                }
                if(!DocTools.IsNullOrEmpty(request.Document) && !DocTools.IsNullOrEmpty(request.Document.Id))
                {
                    entities = entities.Where(en => en.Document.Id == request.Document.Id );
                }
                if(true == request.DocumentIds?.Any())
                {
                    entities = entities.Where(en => en.Document.Id.In(request.DocumentIds));
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
            });
        }
        
        public object Post(DocumentAttributeSearch request)
        {
            return Get(request);
        }

        public object Get(DocumentAttributeSearch request)
        {
            object tryRet = null;
            var ret = new List<DocumentAttribute>();
            var cacheKey = GetApiCacheKey<DocumentAttribute>(DocConstantModelName.DOCUMENTATTRIBUTE, nameof(DocumentAttribute), request);
            using (var cancellableRequest = base.Request.CreateCancellableRequest())
            {
                var requestCancel = new DocRequestCancellation(HttpContext.Current.Response, cancellableRequest);
                try 
                {
                    if (tryRet == null)
                    {
                        _ExecSearch(request, (entities) => entities.ConvertFromEntityList<DocEntityDocumentAttribute,DocumentAttribute>(ret, Execute, requestCancel));
                        tryRet = ret;
                        //Go ahead and cache the result for any future consumers
                        DocCacheClient.Set(key: cacheKey, value: ret, entityType: DocConstantModelName.DOCUMENTATTRIBUTE, search: true);
                    }
                }
                catch(Exception) { throw; }
                finally
                {
                    requestCancel?.CloseRequest();
                }
            }
            DocCacheClient.SyncKeys(key: cacheKey, entityType: DocConstantModelName.DOCUMENTATTRIBUTE, search: true);
            return tryRet;
        }

        public object Post(DocumentAttributeVersion request) 
        {
            return Get(request);
        }

        public object Get(DocumentAttributeVersion request) 
        {
            var ret = new List<Version>();
            _ExecSearch(request, (entities) => 
            {
                ret = entities.Select(e => new Version(e.Id, e.VersionNo)).ToList();
            });
            return ret;
        }

        public object Get(DocumentAttribute request)
        {
            object ret = null;
            
            if(!(request.Id > 0))
                throw new HttpError(HttpStatusCode.NotFound, "Valid Id required.");

            DocPermissionFactory.SetVisibleFields<DocumentAttribute>(currentUser, "DocumentAttribute", request.VisibleFields);
            var cacheKey = GetApiCacheKey<DocumentAttribute>(DocConstantModelName.DOCUMENTATTRIBUTE, nameof(DocumentAttribute), request);
            if(null == ret)
            {
                Execute.Run(s =>
                {
                    ret = GetDocumentAttribute(request);
                    DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.DOCUMENTATTRIBUTE);
                });
            }
            DocCacheClient.SyncKeys(key: cacheKey, entityId: request.Id, entityType: DocConstantModelName.DOCUMENTATTRIBUTE);
            return ret;
        }

        private DocumentAttribute _AssignValues(DocumentAttribute request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "DocumentAttribute"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            DocumentAttribute ret = null;
            request = _InitAssignValues(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            var cacheKey = GetApiCacheKey<DocumentAttribute>(DocConstantModelName.DOCUMENTATTRIBUTE, nameof(DocumentAttribute), request);
            
            //First, assign all the variables, do database lookups and conversions
            var pAttribute = (request.Attribute?.Id > 0) ? DocEntityAttribute.GetAttribute(request.Attribute.Id) : null;
            var pDocument = (request.Document?.Id > 0) ? DocEntityDocument.GetDocument(request.Document.Id) : null;

            DocEntityDocumentAttribute entity = null;
            if(permission == DocConstantPermission.ADD)
            {
                var now = DateTime.UtcNow;
                entity = new DocEntityDocumentAttribute(session)
                {
                    Created = now,
                    Updated = now
                };
            }
            else
            {
                entity = DocEntityDocumentAttribute.GetDocumentAttribute(request.Id);
                if(null == entity)
                    throw new HttpError(HttpStatusCode.NotFound, $"No record");
            }

            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityAttribute>(currentUser, request, pAttribute, permission, DocConstantModelName.DOCUMENTATTRIBUTE, nameof(request.Attribute)))
            {
                if(DocPermissionFactory.IsRequested(request, pAttribute, entity.Attribute, nameof(request.Attribute)))
                    entity.Attribute = pAttribute;
                if(DocPermissionFactory.IsRequested<DocEntityAttribute>(request, pAttribute, nameof(request.Attribute)) && !request.VisibleFields.Matches(nameof(request.Attribute), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Attribute));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityDocument>(currentUser, request, pDocument, permission, DocConstantModelName.DOCUMENTATTRIBUTE, nameof(request.Document)))
            {
                if(DocPermissionFactory.IsRequested(request, pDocument, entity.Document, nameof(request.Document)))
                    entity.Document = pDocument;
                if(DocPermissionFactory.IsRequested<DocEntityDocument>(request, pDocument, nameof(request.Document)) && !request.VisibleFields.Matches(nameof(request.Document), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Document));
                }
            }
            
            if (request.Locked) entity.Locked = request.Locked;

            entity.SaveChanges(permission);
            
            DocPermissionFactory.SetVisibleFields<DocumentAttribute>(currentUser, nameof(DocumentAttribute), request.VisibleFields);
            ret = entity.ToDto();

            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.DOCUMENTATTRIBUTE);

            return ret;
        }
        public DocumentAttribute Post(DocumentAttribute request)
        {
            if(request == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            DocumentAttribute ret = null;

            Execute.Run(ssn =>
            {
                if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "DocumentAttribute")) 
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                ret = _AssignValues(request, DocConstantPermission.ADD, ssn);
            });

            return ret;
        }
   
        public List<DocumentAttribute> Post(DocumentAttributeBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<DocumentAttribute>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Post(dto) as DocumentAttribute;
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

        public DocumentAttribute Post(DocumentAttributeCopy request)
        {
            DocumentAttribute ret = null;
            Execute.Run(ssn =>
            {
                var entity = DocEntityDocumentAttribute.GetDocumentAttribute(request?.Id);
                if(null == entity) throw new HttpError(HttpStatusCode.NoContent, "The COPY request did not succeed.");
                if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");
                
                    var pAttribute = entity.Attribute;
                    var pDocument = entity.Document;
                #region Custom Before copyDocumentAttribute
                #endregion Custom Before copyDocumentAttribute
                var copy = new DocEntityDocumentAttribute(ssn)
                {
                    Hash = Guid.NewGuid()
                                , Attribute = pAttribute
                                , Document = pDocument
                };
                #region Custom After copyDocumentAttribute
                #endregion Custom After copyDocumentAttribute
                copy.SaveChanges(DocConstantPermission.ADD);
                ret = copy.ToDto();
            });
            return ret;
        }


        public List<DocumentAttribute> Put(DocumentAttributeBatch request)
        {
            return Patch(request);
        }

        public DocumentAttribute Put(DocumentAttribute request)
        {
            return Patch(request);
        }

        public List<DocumentAttribute> Patch(DocumentAttributeBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<DocumentAttribute>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Patch(dto) as DocumentAttribute;
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

        public DocumentAttribute Patch(DocumentAttribute request)
        {
            if(true != (request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the DocumentAttribute to patch.");
            
            request.VisibleFields = request.VisibleFields ?? new List<string>();
            
            DocumentAttribute ret = null;
            Execute.Run(ssn =>
            {
                ret = _AssignValues(request, DocConstantPermission.EDIT, ssn);
            });
            return ret;
        }

        public void Delete(DocumentAttributeBatch request)
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

        public void Delete(DocumentAttribute request)
        {
            Execute.Run(ssn =>
            {
                if(!(request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, $"No Id provided for delete.");

                DocCacheClient.RemoveSearch(DocConstantModelName.DOCUMENTATTRIBUTE);
                DocCacheClient.RemoveById(request.Id);
                var en = DocEntityDocumentAttribute.GetDocumentAttribute(request?.Id);

                if(null == en) throw new HttpError(HttpStatusCode.NotFound, $"No DocumentAttribute could be found for Id {request?.Id}.");
                if(en.IsRemoved) return;
                
                if(!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.DELETE))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have DELETE permission for this route.");
                
                en.Remove();
            });
        }

        public void Delete(DocumentAttributeSearch request)
        {
            var matches = Get(request) as List<DocumentAttribute>;
            if(true != matches?.Any()) throw new HttpError(HttpStatusCode.NotFound, "No matches for request");

            Execute.Run(ssn =>
            {
                matches.ForEach(match =>
                {
                    Delete(match);
                });
            });
        }

        private DocumentAttribute GetDocumentAttribute(DocumentAttribute request)
        {
            var id = request?.Id;
            DocumentAttribute ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetVisibleFields<DocumentAttribute>(currentUser, "DocumentAttribute", request.VisibleFields);

            DocEntityDocumentAttribute entity = null;
            if(id.HasValue)
            {
                entity = DocEntityDocumentAttribute.GetDocumentAttribute(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No DocumentAttribute found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }

        public List<int> Any(DocumentAttributeIds request)
        {
            List<int> ret = null;
            if (currentUser.IsSuperAdmin)
            {
                Execute.Run(s => { ret = Execute.SelectAll<DocEntityDocumentAttribute>().Select(d => d.Id).ToList(); });
            }
            else
            {
                throw new HttpError(HttpStatusCode.Forbidden);
            }

            return ret;
        }
    }
}