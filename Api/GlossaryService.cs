
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
    public partial class GlossaryService : DocServiceBase
    {

        private IQueryable<DocEntityGlossary> _ExecSearch(GlossarySearch request, DocQuery query)
        {
            request = InitSearch<Glossary, GlossarySearch>(request);
            IQueryable<DocEntityGlossary> entities = null;
            query.Run( session => 
            {
                entities = query.SelectAll<DocEntityGlossary>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new GlossaryFullTextSearch(request);
                    entities = GetFullTextSearch<DocEntityGlossary,GlossaryFullTextSearch>(fts, entities);
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
                if(true == request.Archived?.Any() && currentUser.HasProperty(DocConstantModelName.GLOSSARY, nameof(Reference.Archived), DocConstantPermission.VIEW))
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
                if(!DocTools.IsNullOrEmpty(request.Definition))
                    entities = entities.Where(en => en.Definition.Contains(request.Definition));
                if(!DocTools.IsNullOrEmpty(request.Definitions))
                    entities = entities.Where(en => en.Definition.In(request.Definitions));
                if(!DocTools.IsNullOrEmpty(request.Enum) && !DocTools.IsNullOrEmpty(request.Enum.Id))
                {
                    entities = entities.Where(en => en.Enum.Id == request.Enum.Id );
                }
                if(true == request.EnumIds?.Any())
                {
                    entities = entities.Where(en => en.Enum.Id.In(request.EnumIds));
                }
                if(true == request.EnumNames?.Any())
                {
                    entities = entities.Where(en => en.Enum.Name.In(request.EnumNames));
                }
                if(!DocTools.IsNullOrEmpty(request.Icon))
                    entities = entities.Where(en => en.Icon.Contains(request.Icon));
                if(!DocTools.IsNullOrEmpty(request.Icons))
                    entities = entities.Where(en => en.Icon.In(request.Icons));
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

                entities = ApplyFilters<DocEntityGlossary,GlossarySearch>(request, entities);

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

        public object Get(Glossary request) => GetEntityWithCache<Glossary>(DocConstantModelName.GLOSSARY, request, GetGlossary);



        private Glossary _AssignValues(Glossary request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "Glossary"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.Select = request.Select ?? new List<string>();

            Glossary ret = null;
            request = _InitAssignValues<Glossary>(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            var cacheKey = GetApiCacheKey<Glossary>(DocConstantModelName.GLOSSARY, nameof(Glossary), request);
            
            //First, assign all the variables, do database lookups and conversions
            var pDefinition = request.Definition;
            var pEnum = DocEntityLookupTableEnum.Get(request.Enum);
            var pIcon = request.Icon;
            var pPage = (request.Page?.Id > 0) ? DocEntityPage.Get(request.Page.Id) : null;
            var pTerm = (request.Term?.Id > 0) ? DocEntityTermMaster.Get(request.Term.Id) : null;
            var pArchived = true == request.Archived;
            var pLocked = request.Locked;

            var entity = InitEntity<DocEntityGlossary,Glossary>(request, permission, session);

            if (AllowPatchValue<Glossary, bool>(request, DocConstantModelName.GLOSSARY, pArchived, permission, nameof(request.Archived), pArchived != entity.Archived))
            {
                entity.Archived = pArchived;
            }
            if (AllowPatchValue<Glossary, string>(request, DocConstantModelName.GLOSSARY, pDefinition, permission, nameof(request.Definition), pDefinition != entity.Definition))
            {
                entity.Definition = pDefinition;
            }
            if (AllowPatchValue<Glossary, DocEntityLookupTableEnum>(request, DocConstantModelName.GLOSSARY, pEnum, permission, nameof(request.Enum), pEnum != entity.Enum))
            {
                entity.Enum = pEnum;
            }
            if (AllowPatchValue<Glossary, string>(request, DocConstantModelName.GLOSSARY, pIcon, permission, nameof(request.Icon), pIcon != entity.Icon))
            {
                entity.Icon = pIcon;
            }
            if (AllowPatchValue<Glossary, DocEntityPage>(request, DocConstantModelName.GLOSSARY, pPage, permission, nameof(request.Page), pPage != entity.Page))
            {
                entity.Page = pPage;
            }
            if (AllowPatchValue<Glossary, DocEntityTermMaster>(request, DocConstantModelName.GLOSSARY, pTerm, permission, nameof(request.Term), pTerm != entity.Term))
            {
                entity.Term = pTerm;
            }
            if (request.Locked && AllowPatchValue<Glossary, bool>(request, DocConstantModelName.GLOSSARY, pArchived, permission, nameof(request.Locked), pLocked != entity.Locked))
            {
                entity.Archived = pArchived;
            }
            entity.SaveChanges(permission);

            var idsToInvalidate = new List<int>();

            if (idsToInvalidate.Any())
            {
                idsToInvalidate.Add(entity.Id);
                DocCacheClient.RemoveByEntityIds(idsToInvalidate);
                DocCacheClient.RemoveSearch(DocConstantModelName.GLOSSARY);
            }

            DocPermissionFactory.SetSelect<Glossary>(currentUser, nameof(Glossary), request.Select);
            ret = entity.ToDto();

            var cacheExpires = DocResources.Metadata.GetCacheExpiration(DocConstantModelName.GLOSSARY);
            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.GLOSSARY, cacheExpires);

            return ret;
        }


        public Glossary Post(Glossary request)
        {
            if(request == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            request.Select = request.Select ?? new List<string>();

            Glossary ret = null;

            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "Glossary")) 
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                    ret = _AssignValues(request, DocConstantPermission.ADD, ssn);
                });
            }
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
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    var entity = DocEntityGlossary.Get(request?.Id);
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
                    var copy = new DocEntityGlossary(ssn)
                    {
                        Hash = Guid.NewGuid()
                                , Definition = pDefinition
                                , Enum = pEnum
                                , Icon = pIcon
                                , Page = pPage
                                , Term = pTerm
                    };

                    copy.SaveChanges(DocConstantPermission.ADD);
                    ret = copy.ToDto();
                });
            }
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
            
            request.Select = request.Select ?? new List<string>();
            
            Glossary ret = null;
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    ret = _AssignValues(request, DocConstantPermission.EDIT, ssn);
                });
            }
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
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    if(!(request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, $"No Id provided for delete.");

                    var en = DocEntityGlossary.Get(request?.Id);
                    if(null == en) throw new HttpError(HttpStatusCode.NotFound, $"No Glossary could be found for Id {request?.Id}.");
                    if(en.IsRemoved) return;
                
                    if(!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.DELETE))
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have DELETE permission for this route.");
                
                    en.Remove();

                    DocCacheClient.RemoveSearch(DocConstantModelName.GLOSSARY);
                    DocCacheClient.RemoveById(request.Id);
                });
            }
        }

        public void Delete(GlossarySearch request)
        {
            var matches = Get(request) as List<Glossary>;
            if(true != matches?.Any()) throw new HttpError(HttpStatusCode.NotFound, "No matches for request");
            matches.ForEach(match =>
            {
                Delete(match);
            });
        }




        private Glossary GetGlossary(Glossary request)
        {
            var id = request?.Id;
            Glossary ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetSelect<Glossary>(currentUser, "Glossary", request.Select);

            DocEntityGlossary entity = null;
            if(id.HasValue)
            {
                entity = DocEntityGlossary.Get(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No Glossary found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }

    }
}
