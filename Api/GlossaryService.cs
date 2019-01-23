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
    public partial class GlossaryService : DocServiceBase
    {
        private IQueryable<DocEntityGlossary> _ExecSearch(GlossarySearch request)
        {
            request = InitSearch(request);
            
            IQueryable<DocEntityGlossary> entities = null;
            
            DocPermissionFactory.SetVisibleFields<Glossary>(currentUser, "Glossary", request.VisibleFields);

            Execute.Run( session => 
            {
                entities = Execute.SelectAll<DocEntityGlossary>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new GlossaryFullTextSearch(request);
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

                if(!DocTools.IsNullOrEmpty(request.Definition))
                    entities = entities.Where(en => en.Definition.Contains(request.Definition));
                if(!DocTools.IsNullOrEmpty(request.Enum) && !DocTools.IsNullOrEmpty(request.Enum.Id))
                {
                    entities = entities.Where(en => en.Enum.Id == request.Enum.Id );
                }
                if(true == request.EnumIds?.Any())
                {
                    entities = entities.Where(en => en.Enum.Id.In(request.EnumIds));
                }
                if(!DocTools.IsNullOrEmpty(request.Icon))
                    entities = entities.Where(en => en.Icon.Contains(request.Icon));
                if(!DocTools.IsNullOrEmpty(request.Page) && !DocTools.IsNullOrEmpty(request.Page.Id))
                {
                    entities = entities.Where(en => en.Page.Id == request.Page.Id );
                }
                if(true == request.PageIds?.Any())
                {
                    entities = entities.Where(en => en.Page.Id.In(request.PageIds));
                }
                if(!DocTools.IsNullOrEmpty(request.Term) && !DocTools.IsNullOrEmpty(request.Term.Id))
                {
                    entities = entities.Where(en => en.Term.Id == request.Term.Id );
                }
                if(true == request.TermIds?.Any())
                {
                    entities = entities.Where(en => en.Term.Id.In(request.TermIds));
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

        public object Post(GlossarySearch request) => Get(request);

        public object Get(GlossarySearch request) => GetSearchResultWithCache<Glossary,DocEntityGlossary,GlossarySearch>(DocConstantModelName.GLOSSARY, request, _ExecSearch);

        public object Post(GlossaryVersion request) => Get(request);

        public object Get(GlossaryVersion request) 
        {
            List<Version> ret = null;
            Execute.Run(s=>
            {
                ret = _ExecSearch(request).Select(e => new Version(e.Id, e.VersionNo)).ToList();
            });
            return ret;
        }

        public object Get(Glossary request) => GetEntityWithCache<Glossary>(DocConstantModelName.GLOSSARY, request, GetGlossary);
        private Glossary _AssignValues(Glossary request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "Glossary"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            Glossary ret = null;
            request = _InitAssignValues(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            var cacheKey = GetApiCacheKey<Glossary>(DocConstantModelName.GLOSSARY, nameof(Glossary), request);
            
            //First, assign all the variables, do database lookups and conversions
            var pDefinition = request.Definition;
            var pEnum = DocEntityLookupTableEnum.GetLookupTableEnum(request.Enum);
            var pIcon = request.Icon;
            var pPage = (request.Page?.Id > 0) ? DocEntityPage.GetPage(request.Page.Id) : null;
            var pTerm = (request.Term?.Id > 0) ? DocEntityTermMaster.GetTermMaster(request.Term.Id) : null;

            DocEntityGlossary entity = null;
            if(permission == DocConstantPermission.ADD)
            {
                var now = DateTime.UtcNow;
                entity = new DocEntityGlossary(session)
                {
                    Created = now,
                    Updated = now
                };
            }
            else
            {
                entity = DocEntityGlossary.GetGlossary(request.Id);
                if(null == entity)
                    throw new HttpError(HttpStatusCode.NotFound, $"No record");
            }

            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pDefinition, permission, DocConstantModelName.GLOSSARY, nameof(request.Definition)))
            {
                if(DocPermissionFactory.IsRequested(request, pDefinition, entity.Definition, nameof(request.Definition)))
                    entity.Definition = pDefinition;
                if(DocPermissionFactory.IsRequested<string>(request, pDefinition, nameof(request.Definition)) && !request.VisibleFields.Matches(nameof(request.Definition), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Definition));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityLookupTableEnum>(currentUser, request, pEnum, permission, DocConstantModelName.GLOSSARY, nameof(request.Enum)))
            {
                if(DocPermissionFactory.IsRequested(request, pEnum, entity.Enum, nameof(request.Enum)))
                    entity.Enum = pEnum;
                if(DocPermissionFactory.IsRequested<DocEntityLookupTableEnum>(request, pEnum, nameof(request.Enum)) && !request.VisibleFields.Matches(nameof(request.Enum), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Enum));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pIcon, permission, DocConstantModelName.GLOSSARY, nameof(request.Icon)))
            {
                if(DocPermissionFactory.IsRequested(request, pIcon, entity.Icon, nameof(request.Icon)))
                    entity.Icon = pIcon;
                if(DocPermissionFactory.IsRequested<string>(request, pIcon, nameof(request.Icon)) && !request.VisibleFields.Matches(nameof(request.Icon), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Icon));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityPage>(currentUser, request, pPage, permission, DocConstantModelName.GLOSSARY, nameof(request.Page)))
            {
                if(DocPermissionFactory.IsRequested(request, pPage, entity.Page, nameof(request.Page)))
                    entity.Page = pPage;
                if(DocPermissionFactory.IsRequested<DocEntityPage>(request, pPage, nameof(request.Page)) && !request.VisibleFields.Matches(nameof(request.Page), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Page));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityTermMaster>(currentUser, request, pTerm, permission, DocConstantModelName.GLOSSARY, nameof(request.Term)))
            {
                if(DocPermissionFactory.IsRequested(request, pTerm, entity.Term, nameof(request.Term)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Term)} cannot be modified once set.");
                    entity.Term = pTerm;
                if(DocPermissionFactory.IsRequested<DocEntityTermMaster>(request, pTerm, nameof(request.Term)) && !request.VisibleFields.Matches(nameof(request.Term), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Term));
                }
            }
            
            if (request.Locked) entity.Locked = request.Locked;

            entity.SaveChanges(permission);
            
            DocPermissionFactory.SetVisibleFields<Glossary>(currentUser, nameof(Glossary), request.VisibleFields);
            ret = entity.ToDto();

            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.GLOSSARY);

            return ret;
        }
        public Glossary Post(Glossary request)
        {
            if(request == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            Glossary ret = null;

            Execute.Run(ssn =>
            {
                if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "Glossary")) 
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                ret = _AssignValues(request, DocConstantPermission.ADD, ssn);
            });

            return ret;
        }
   
        public List<Glossary> Post(GlossaryBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<Glossary>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Post(dto) as Glossary;
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

        public Glossary Post(GlossaryCopy request)
        {
            Glossary ret = null;
            Execute.Run(ssn =>
            {
                var entity = DocEntityGlossary.GetGlossary(request?.Id);
                if(null == entity) throw new HttpError(HttpStatusCode.NoContent, "The COPY request did not succeed.");
                if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");
                
                    var pDefinition = entity.Definition;
                    var pEnum = entity.Enum;
                    var pIcon = entity.Icon;
                    if(!DocTools.IsNullOrEmpty(pIcon))
                        pIcon += " (Copy)";
                    var pPage = entity.Page;
                    var pTerm = entity.Term;
                #region Custom Before copyGlossary
                #endregion Custom Before copyGlossary
                var copy = new DocEntityGlossary(ssn)
                {
                    Hash = Guid.NewGuid()
                                , Definition = pDefinition
                                , Enum = pEnum
                                , Icon = pIcon
                                , Page = pPage
                                , Term = pTerm
                };
                #region Custom After copyGlossary
                #endregion Custom After copyGlossary
                copy.SaveChanges(DocConstantPermission.ADD);
                ret = copy.ToDto();
            });
            return ret;
        }


        public List<Glossary> Put(GlossaryBatch request)
        {
            return Patch(request);
        }

        public Glossary Put(Glossary request)
        {
            return Patch(request);
        }

        public List<Glossary> Patch(GlossaryBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<Glossary>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Patch(dto) as Glossary;
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

        public Glossary Patch(Glossary request)
        {
            if(true != (request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the Glossary to patch.");
            
            request.VisibleFields = request.VisibleFields ?? new List<string>();
            
            Glossary ret = null;
            Execute.Run(ssn =>
            {
                ret = _AssignValues(request, DocConstantPermission.EDIT, ssn);
            });
            return ret;
        }

        public void Delete(GlossaryBatch request)
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

        public void Delete(Glossary request)
        {
            Execute.Run(ssn =>
            {
                if(!(request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, $"No Id provided for delete.");

                DocCacheClient.RemoveSearch(DocConstantModelName.GLOSSARY);
                DocCacheClient.RemoveById(request.Id);
                var en = DocEntityGlossary.GetGlossary(request?.Id);

                if(null == en) throw new HttpError(HttpStatusCode.NotFound, $"No Glossary could be found for Id {request?.Id}.");
                if(en.IsRemoved) return;
                
                if(!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.DELETE))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have DELETE permission for this route.");
                
                en.Remove();
            });
        }

        public void Delete(GlossarySearch request)
        {
            var matches = Get(request) as List<Glossary>;
            if(true != matches?.Any()) throw new HttpError(HttpStatusCode.NotFound, "No matches for request");

            Execute.Run(ssn =>
            {
                matches.ForEach(match =>
                {
                    Delete(match);
                });
            });
        }

        private Glossary GetGlossary(Glossary request)
        {
            var id = request?.Id;
            Glossary ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetVisibleFields<Glossary>(currentUser, "Glossary", request.VisibleFields);

            DocEntityGlossary entity = null;
            if(id.HasValue)
            {
                entity = DocEntityGlossary.GetGlossary(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No Glossary found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }

        public List<int> Any(GlossaryIds request)
        {
            List<int> ret = null;
            if (currentUser.IsSuperAdmin)
            {
                Execute.Run(s => { ret = Execute.SelectAll<DocEntityGlossary>().Select(d => d.Id).ToList(); });
            }
            else
            {
                throw new HttpError(HttpStatusCode.Forbidden);
            }

            return ret;
        }
    }
}