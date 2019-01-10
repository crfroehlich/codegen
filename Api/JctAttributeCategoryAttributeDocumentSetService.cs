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
using Typed.Security;
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
    public partial class JctAttributeCategoryAttributeDocumentSetService : DocServiceBase
    {
        public const string CACHE_KEY_PREFIX = DocEntityJctAttributeCategoryAttributeDocumentSet.CACHE_KEY_PREFIX;
        private void _ExecSearch(JctAttributeCategoryAttributeDocumentSetSearch request, Action<IQueryable<DocEntityJctAttributeCategoryAttributeDocumentSet>> callBack)
        {
            request = InitSearch(request);
            
            DocPermissionFactory.SetVisibleFields<JctAttributeCategoryAttributeDocumentSet>(currentUser, "JctAttributeCategoryAttributeDocumentSet", request.VisibleFields);

            var entities = Execute.SelectAll<DocEntityJctAttributeCategoryAttributeDocumentSet>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new JctAttributeCategoryAttributeDocumentSetFullTextSearch(request);
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
                if(!DocTools.IsNullOrEmpty(request.AttributeCategory) && !DocTools.IsNullOrEmpty(request.AttributeCategory.Id))
                {
                    entities = entities.Where(en => en.AttributeCategory.Id == request.AttributeCategory.Id );
                }
                if(true == request.AttributeCategoryIds?.Any())
                {
                    entities = entities.Where(en => en.AttributeCategory.Id.In(request.AttributeCategoryIds));
                }
                if(!DocTools.IsNullOrEmpty(request.DocumentSet) && !DocTools.IsNullOrEmpty(request.DocumentSet.Id))
                {
                    entities = entities.Where(en => en.DocumentSet.Id == request.DocumentSet.Id );
                }
                if(true == request.DocumentSetIds?.Any())
                {
                    entities = entities.Where(en => en.DocumentSet.Id.In(request.DocumentSetIds));
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
        
        public object Post(JctAttributeCategoryAttributeDocumentSetSearch request)
        {
            object tryRet = null;
            Execute.Run(s =>
            {
                using (var cancellableRequest = base.Request.CreateCancellableRequest())
                {
                    var requestCancel = new DocRequestCancellation(HttpContext.Current.Response, cancellableRequest);
                    try 
                    {
                        var ret = new List<JctAttributeCategoryAttributeDocumentSet>();
                        _ExecSearch(request, (entities) => entities.ConvertFromEntityList<DocEntityJctAttributeCategoryAttributeDocumentSet,JctAttributeCategoryAttributeDocumentSet>(ret, Execute, requestCancel));
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

        public object Get(JctAttributeCategoryAttributeDocumentSetSearch request)
        {
            object tryRet = null;
            Execute.Run(s =>
            {
                using (var cancellableRequest = base.Request.CreateCancellableRequest())
                {
                    var requestCancel = new DocRequestCancellation(HttpContext.Current.Response, cancellableRequest);
                    try 
                    {
                        var ret = new List<JctAttributeCategoryAttributeDocumentSet>();
                        _ExecSearch(request, (entities) => entities.ConvertFromEntityList<DocEntityJctAttributeCategoryAttributeDocumentSet,JctAttributeCategoryAttributeDocumentSet>(ret, Execute, requestCancel));
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

        public object Post(JctAttributeCategoryAttributeDocumentSetVersion request) 
        {
            return Get(request);
        }

        public object Get(JctAttributeCategoryAttributeDocumentSetVersion request) 
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

        public object Get(JctAttributeCategoryAttributeDocumentSet request)
        {
            object ret = null;
            
            if(!(request.Id > 0))
                throw new HttpError(HttpStatusCode.NotFound, "Valid Id required.");

            Execute.Run(s =>
            {
                DocPermissionFactory.SetVisibleFields<JctAttributeCategoryAttributeDocumentSet>(currentUser, "JctAttributeCategoryAttributeDocumentSet", request.VisibleFields);
                ret = GetJctAttributeCategoryAttributeDocumentSet(request);
            });
            return ret;
        }

        private JctAttributeCategoryAttributeDocumentSet _AssignValues(JctAttributeCategoryAttributeDocumentSet dtoSource, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (dtoSource == null || dtoSource.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "JctAttributeCategoryAttributeDocumentSet"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            dtoSource.VisibleFields = dtoSource.VisibleFields ?? new List<string>();

            JctAttributeCategoryAttributeDocumentSet ret = null;
            dtoSource = _InitAssignValues(dtoSource, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && dtoSource.Id > 0) return dtoSource;
            
            //First, assign all the variables, do database lookups and conversions
            var pAttribute = (dtoSource.Attribute?.Id > 0) ? DocEntityAttribute.GetAttribute(dtoSource.Attribute.Id) : null;
            var pAttributeCategory = (dtoSource.AttributeCategory?.Id > 0) ? DocEntityAttributeCategory.GetAttributeCategory(dtoSource.AttributeCategory.Id) : null;
            var pDocumentSet = (dtoSource.DocumentSet?.Id > 0) ? DocEntityDocumentSet.GetDocumentSet(dtoSource.DocumentSet.Id) : null;

            DocEntityJctAttributeCategoryAttributeDocumentSet entity = null;
            if(permission == DocConstantPermission.ADD)
            {
                var now = DateTime.UtcNow;
                entity = new DocEntityJctAttributeCategoryAttributeDocumentSet(session)
                {
                    Created = now,
                    Updated = now
                };
            }
            else
            {
                entity = DocEntityJctAttributeCategoryAttributeDocumentSet.GetJctAttributeCategoryAttributeDocumentSet(dtoSource.Id);
                if(null == entity)
                    throw new HttpError(HttpStatusCode.NotFound, $"No record");
            }

            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityAttribute>(currentUser, dtoSource, pAttribute, permission, DocConstantModelName.JCTATTRIBUTECATEGORYATTRIBUTEDOCUMENTSET, nameof(dtoSource.Attribute)))
            {
                if(DocPermissionFactory.IsRequested(dtoSource, pAttribute, entity.Attribute, nameof(dtoSource.Attribute)))
                    entity.Attribute = pAttribute;
                if(DocPermissionFactory.IsRequested<DocEntityAttribute>(dtoSource, pAttribute, nameof(dtoSource.Attribute)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.Attribute), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.Attribute));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityAttributeCategory>(currentUser, dtoSource, pAttributeCategory, permission, DocConstantModelName.JCTATTRIBUTECATEGORYATTRIBUTEDOCUMENTSET, nameof(dtoSource.AttributeCategory)))
            {
                if(DocPermissionFactory.IsRequested(dtoSource, pAttributeCategory, entity.AttributeCategory, nameof(dtoSource.AttributeCategory)))
                    entity.AttributeCategory = pAttributeCategory;
                if(DocPermissionFactory.IsRequested<DocEntityAttributeCategory>(dtoSource, pAttributeCategory, nameof(dtoSource.AttributeCategory)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.AttributeCategory), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.AttributeCategory));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityDocumentSet>(currentUser, dtoSource, pDocumentSet, permission, DocConstantModelName.JCTATTRIBUTECATEGORYATTRIBUTEDOCUMENTSET, nameof(dtoSource.DocumentSet)))
            {
                if(DocPermissionFactory.IsRequested(dtoSource, pDocumentSet, entity.DocumentSet, nameof(dtoSource.DocumentSet)))
                    entity.DocumentSet = pDocumentSet;
                if(DocPermissionFactory.IsRequested<DocEntityDocumentSet>(dtoSource, pDocumentSet, nameof(dtoSource.DocumentSet)) && !dtoSource.VisibleFields.Matches(nameof(dtoSource.DocumentSet), ignoreSpaces: true))
                {
                    dtoSource.VisibleFields.Add(nameof(dtoSource.DocumentSet));
                }
            }
            
            if (dtoSource.Locked) entity.Locked = dtoSource.Locked;

            entity.SaveChanges(permission);
            
            DocPermissionFactory.SetVisibleFields<JctAttributeCategoryAttributeDocumentSet>(currentUser, nameof(JctAttributeCategoryAttributeDocumentSet), dtoSource.VisibleFields);
            ret = entity.ToDto();

            return ret;
        }
        public JctAttributeCategoryAttributeDocumentSet Post(JctAttributeCategoryAttributeDocumentSet dtoSource)
        {
            if(dtoSource == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            dtoSource.VisibleFields = dtoSource.VisibleFields ?? new List<string>();

            JctAttributeCategoryAttributeDocumentSet ret = null;

            Execute.Run(ssn =>
            {
                if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "JctAttributeCategoryAttributeDocumentSet")) 
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                ret = _AssignValues(dtoSource, DocConstantPermission.ADD, ssn);
            });

            return ret;
        }
   
        public List<JctAttributeCategoryAttributeDocumentSet> Post(JctAttributeCategoryAttributeDocumentSetBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<JctAttributeCategoryAttributeDocumentSet>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Post(dto) as JctAttributeCategoryAttributeDocumentSet;
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

        public JctAttributeCategoryAttributeDocumentSet Post(JctAttributeCategoryAttributeDocumentSetCopy request)
        {
            JctAttributeCategoryAttributeDocumentSet ret = null;
            Execute.Run(ssn =>
            {
                var entity = DocEntityJctAttributeCategoryAttributeDocumentSet.GetJctAttributeCategoryAttributeDocumentSet(request?.Id);
                if(null == entity) throw new HttpError(HttpStatusCode.NoContent, "The COPY request did not succeed.");
                if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");
                
                    var pAttribute = entity.Attribute;
                    var pAttributeCategory = entity.AttributeCategory;
                    var pDocumentSet = entity.DocumentSet;
                var copy = new DocEntityJctAttributeCategoryAttributeDocumentSet(ssn)
                {
                    Hash = Guid.NewGuid()
                                , Attribute = pAttribute
                                , AttributeCategory = pAttributeCategory
                                , DocumentSet = pDocumentSet
                };
                copy.SaveChanges(DocConstantPermission.ADD);
                ret = copy.ToDto();
            });
            return ret;
        }


        public List<JctAttributeCategoryAttributeDocumentSet> Put(JctAttributeCategoryAttributeDocumentSetBatch request)
        {
            return Patch(request);
        }

        public JctAttributeCategoryAttributeDocumentSet Put(JctAttributeCategoryAttributeDocumentSet dtoSource)
        {
            return Patch(dtoSource);
        }

        public List<JctAttributeCategoryAttributeDocumentSet> Patch(JctAttributeCategoryAttributeDocumentSetBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<JctAttributeCategoryAttributeDocumentSet>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Patch(dto) as JctAttributeCategoryAttributeDocumentSet;
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

        public JctAttributeCategoryAttributeDocumentSet Patch(JctAttributeCategoryAttributeDocumentSet dtoSource)
        {
            if(true != (dtoSource?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the JctAttributeCategoryAttributeDocumentSet to patch.");
            
            dtoSource.VisibleFields = dtoSource.VisibleFields ?? new List<string>();
            
            JctAttributeCategoryAttributeDocumentSet ret = null;
            Execute.Run(ssn =>
            {
                ret = _AssignValues(dtoSource, DocConstantPermission.EDIT, ssn);
            });
            return ret;
        }

        public void Delete(JctAttributeCategoryAttributeDocumentSetBatch request)
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

        public void Delete(JctAttributeCategoryAttributeDocumentSet request)
        {
            Execute.Run(ssn =>
            {
                var en = DocEntityJctAttributeCategoryAttributeDocumentSet.GetJctAttributeCategoryAttributeDocumentSet(request?.Id);

                if(null == en) throw new HttpError(HttpStatusCode.NotFound, $"No JctAttributeCategoryAttributeDocumentSet could be found for Id {request?.Id}.");
                if(en.IsRemoved) return;
                
                if(!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.DELETE))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have DELETE permission for this route.");
                
                en.Remove();
            });
        }

        public void Delete(JctAttributeCategoryAttributeDocumentSetSearch request)
        {
            var matches = Get(request) as List<JctAttributeCategoryAttributeDocumentSet>;
            if(true != matches?.Any()) throw new HttpError(HttpStatusCode.NotFound, "No matches for request");

            Execute.Run(ssn =>
            {
                matches.ForEach(match =>
                {
                    Delete(match);
                });
            });
        }

        private JctAttributeCategoryAttributeDocumentSet GetJctAttributeCategoryAttributeDocumentSet(JctAttributeCategoryAttributeDocumentSet request)
        {
            var id = request?.Id;
            JctAttributeCategoryAttributeDocumentSet ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetVisibleFields<JctAttributeCategoryAttributeDocumentSet>(currentUser, "JctAttributeCategoryAttributeDocumentSet", request.VisibleFields);

            DocEntityJctAttributeCategoryAttributeDocumentSet entity = null;
            if(id.HasValue)
            {
                entity = DocEntityJctAttributeCategoryAttributeDocumentSet.GetJctAttributeCategoryAttributeDocumentSet(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No JctAttributeCategoryAttributeDocumentSet found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }

        public List<int> Any(JctAttributeCategoryAttributeDocumentSetIds request)
        {
            List<int> ret = null;
            if (currentUser.IsSuperAdmin)
            {
                Execute.Run(s => { ret = Execute.SelectAll<DocEntityJctAttributeCategoryAttributeDocumentSet>().Select(d => d.Id).ToList(); });
            }
            else
            {
                throw new HttpError(HttpStatusCode.Forbidden);
            }
            return ret;
        }
    }
}