//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated by a T4 template. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.CodeDom.Compiler;
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
    public partial class DocumentSetService : DocServiceBase
    {

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private IQueryable<DocEntityDocumentSet> _ExecSearch(DocumentSetSearch request, DocQuery query)
        {
            request = InitSearch<DocumentSet, DocumentSetSearch>(request);
            IQueryable<DocEntityDocumentSet> entities = null;
            query.Run( session => 
            {
                entities = query.SelectAll<DocEntityDocumentSet>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new DocumentSetFullTextSearch(request);
                    entities = GetFullTextSearch<DocEntityDocumentSet,DocumentSetFullTextSearch>(fts, entities);
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
                if(true == request.Archived?.Any() && currentUser.HasProperty(DocConstantModelName.DOCUMENTSET, nameof(Reference.Archived), DocConstantPermission.VIEW))
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
                if(true == request.ClientsIds?.Any())
                {
                    entities = entities.Where(en => en.Clients.Any(r => r.Id.In(request.ClientsIds)));
                }
                if(true == request.Confidential?.Any())
                {
                    entities = entities.Where(en => en.Confidential.In(request.Confidential));
                }
                if(true == request.DivisionsIds?.Any())
                {
                    entities = entities.Where(en => en.Divisions.Any(r => r.Id.In(request.DivisionsIds)));
                }
                if(true == request.DocumentsIds?.Any())
                {
                    entities = entities.Where(en => en.Documents.Any(r => r.Id.In(request.DocumentsIds)));
                }
                if(true == request.DocumentSetsIds?.Any())
                {
                    entities = entities.Where(en => en.DocumentSets.Any(r => r.Id.In(request.DocumentSetsIds)));
                }
                if(true == request.HistoriesIds?.Any())
                {
                    entities = entities.Where(en => en.Histories.Any(r => r.Id.In(request.HistoriesIds)));
                }
                if(request.LegacyDocumentSetId.HasValue)
                    entities = entities.Where(en => request.LegacyDocumentSetId.Value == en.LegacyDocumentSetId);
                if(!DocTools.IsNullOrEmpty(request.Name))
                    entities = entities.Where(en => en.Name.Contains(request.Name));
                if(!DocTools.IsNullOrEmpty(request.Names))
                    entities = entities.Where(en => en.Name.In(request.Names));
                if(!DocTools.IsNullOrEmpty(request.Owner) && !DocTools.IsNullOrEmpty(request.Owner.Id))
                {
                    entities = entities.Where(en => en.Owner.Id == request.Owner.Id );
                }
                if(true == request.OwnerIds?.Any())
                {
                    entities = entities.Where(en => en.Owner.Id.In(request.OwnerIds));
                }
                if(!DocTools.IsNullOrEmpty(request.ProjectTeam) && !DocTools.IsNullOrEmpty(request.ProjectTeam.Id))
                {
                    entities = entities.Where(en => en.ProjectTeam.Id == request.ProjectTeam.Id );
                }
                if(true == request.ProjectTeamIds?.Any())
                {
                    entities = entities.Where(en => en.ProjectTeam.Id.In(request.ProjectTeamIds));
                }
                if(true == request.ScopesIds?.Any())
                {
                    entities = entities.Where(en => en.Scopes.Any(r => r.Id.In(request.ScopesIds)));
                }
                if(true == request.StatsIds?.Any())
                {
                    entities = entities.Where(en => en.Stats.Any(r => r.Id.In(request.StatsIds)));
                }
                if(request.Type.HasValue)
                    entities = entities.Where(en => request.Type.Value == en.Type);
                if(!DocTools.IsNullOrEmpty(request.Types))
                    entities = entities.Where(en => en.Type.In(request.Types));
                if(true == request.UsersIds?.Any())
                {
                    entities = entities.Where(en => en.Users.Any(r => r.Id.In(request.UsersIds)));
                }

                entities = ApplyFilters<DocEntityDocumentSet,DocumentSetSearch>(request, entities);

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
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Post(DocumentSetSearch request) => Get(request);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Get(DocumentSetSearch request) => GetSearchResultWithCache<DocumentSet,DocEntityDocumentSet,DocumentSetSearch>(DocConstantModelName.DOCUMENTSET, request, _ExecSearch);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Get(DocumentSet request) => GetEntityWithCache<DocumentSet>(DocConstantModelName.DOCUMENTSET, request, GetDocumentSet);



        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private DocumentSet _AssignValues(DocumentSet request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "DocumentSet"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.Select = request.Select ?? new List<string>();

            DocumentSet ret = null;
            request = _InitAssignValues<DocumentSet>(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            var cacheKey = GetApiCacheKey<DocumentSet>(DocConstantModelName.DOCUMENTSET, nameof(DocumentSet), request);
            
            //First, assign all the variables, do database lookups and conversions
            var pClients = GetVariable<Reference>(request, nameof(request.Clients), request.Clients?.ToList(), request.ClientsIds?.ToList());
            var pConfidential = request.Confidential;
            var pDivisions = GetVariable<Reference>(request, nameof(request.Divisions), request.Divisions?.ToList(), request.DivisionsIds?.ToList());
            var pDocuments = GetVariable<Reference>(request, nameof(request.Documents), request.Documents?.ToList(), request.DocumentsIds?.ToList());
            var pDocumentSets = GetVariable<Reference>(request, nameof(request.DocumentSets), request.DocumentSets?.ToList(), request.DocumentSetsIds?.ToList());
            var pHistories = GetVariable<Reference>(request, nameof(request.Histories), request.Histories?.ToList(), request.HistoriesIds?.ToList());
            var pLegacyDocumentSetId = request.LegacyDocumentSetId;
            var pName = request.Name;
            var pOwner = DocEntityDocumentSet.Get(request.Owner?.Id, true, Execute) ?? DocEntityDocumentSet.Get(request.OwnerId, true, Execute);
            var pProjectTeam = DocEntityTeam.Get(request.ProjectTeam?.Id, true, Execute) ?? DocEntityTeam.Get(request.ProjectTeamId, true, Execute);
            var pScopes = GetVariable<Reference>(request, nameof(request.Scopes), request.Scopes?.ToList(), request.ScopesIds?.ToList());
            var pSettings = request.Settings;
            var pStats = GetVariable<Reference>(request, nameof(request.Stats), request.Stats?.ToList(), request.StatsIds?.ToList());
            var pType = request.Type;
            var pUsers = GetVariable<Reference>(request, nameof(request.Users), request.Users?.ToList(), request.UsersIds?.ToList());
            var pArchived = true == request.Archived;
            var pLocked = request.Locked;

            var entity = InitEntity<DocEntityDocumentSet,DocumentSet>(request, permission, session);

            if (AllowPatchValue<DocumentSet, bool>(request, DocConstantModelName.DOCUMENTSET, pArchived, permission, nameof(request.Archived), pArchived != entity.Archived))
            {
                entity.Archived = pArchived;
            }
            if (AllowPatchValue<DocumentSet, bool>(request, DocConstantModelName.DOCUMENTSET, pConfidential, permission, nameof(request.Confidential), pConfidential != entity.Confidential))
            {
                entity.Confidential = pConfidential;
            }
            if (AllowPatchValue<DocumentSet, int?>(request, DocConstantModelName.DOCUMENTSET, pLegacyDocumentSetId, permission, nameof(request.LegacyDocumentSetId), pLegacyDocumentSetId != entity.LegacyDocumentSetId))
            {
                entity.LegacyDocumentSetId = pLegacyDocumentSetId;
            }
            if (AllowPatchValue<DocumentSet, string>(request, DocConstantModelName.DOCUMENTSET, pName, permission, nameof(request.Name), pName != entity.Name))
            {
                entity.Name = pName;
            }
            if (AllowPatchValue<DocumentSet, DocEntityDocumentSet>(request, DocConstantModelName.DOCUMENTSET, pOwner, permission, nameof(request.Owner), pOwner != entity.Owner))
            {
                entity.Owner = pOwner;
            }
            if (AllowPatchValue<DocumentSet, DocEntityTeam>(request, DocConstantModelName.DOCUMENTSET, pProjectTeam, permission, nameof(request.ProjectTeam), pProjectTeam != entity.ProjectTeam))
            {
                entity.ProjectTeam = pProjectTeam;
            }
            if (AllowPatchValue<DocumentSet, string>(request, DocConstantModelName.DOCUMENTSET, pSettings, permission, nameof(request.Settings), pSettings != entity.Settings))
            {
                entity.Settings = pSettings;
            }
            if (AllowPatchValue<DocumentSet, DocumentSetTypeEnm?>(request, DocConstantModelName.DOCUMENTSET, pType, permission, nameof(request.Type), pType != entity.Type))
            {
                if(null != pType) entity.Type = pType.Value;
            }
            if (request.Locked && AllowPatchValue<DocumentSet, bool>(request, DocConstantModelName.DOCUMENTSET, pArchived, permission, nameof(request.Locked), pLocked != entity.Locked))
            {
                entity.Archived = pArchived;
            }
            entity.SaveChanges(permission);

            var idsToInvalidate = new List<int>();
            idsToInvalidate.AddRange(PatchCollection<DocumentSet, DocEntityDocumentSet, Reference, DocEntityClient>(request, entity, pClients, permission, nameof(request.Clients)));
            idsToInvalidate.AddRange(PatchCollection<DocumentSet, DocEntityDocumentSet, Reference, DocEntityDivision>(request, entity, pDivisions, permission, nameof(request.Divisions)));
            idsToInvalidate.AddRange(PatchCollection<DocumentSet, DocEntityDocumentSet, Reference, DocEntityDocument>(request, entity, pDocuments, permission, nameof(request.Documents)));
            idsToInvalidate.AddRange(PatchCollection<DocumentSet, DocEntityDocumentSet, Reference, DocEntityDocumentSet>(request, entity, pDocumentSets, permission, nameof(request.DocumentSets)));
            idsToInvalidate.AddRange(PatchCollection<DocumentSet, DocEntityDocumentSet, Reference, DocEntityDocumentSetHistory>(request, entity, pHistories, permission, nameof(request.Histories)));
            idsToInvalidate.AddRange(PatchCollection<DocumentSet, DocEntityDocumentSet, Reference, DocEntityScope>(request, entity, pScopes, permission, nameof(request.Scopes)));
            idsToInvalidate.AddRange(PatchCollection<DocumentSet, DocEntityDocumentSet, Reference, DocEntityStatsStudySet>(request, entity, pStats, permission, nameof(request.Stats)));
            idsToInvalidate.AddRange(PatchCollection<DocumentSet, DocEntityDocumentSet, Reference, DocEntityUser>(request, entity, pUsers, permission, nameof(request.Users)));
            if (idsToInvalidate.Any())
            {
                idsToInvalidate.Add(entity.Id);
                DocCacheClient.RemoveByEntityIds(idsToInvalidate);
                DocCacheClient.RemoveSearch(DocConstantModelName.DOCUMENTSET);
            }

            entity.SaveChanges(permission);
            DocPermissionFactory.SetSelect<DocumentSet>(currentUser, nameof(DocumentSet), request.Select);
            ret = entity.ToDto();

            var cacheExpires = DocResources.Metadata.GetCacheExpiration(DocConstantModelName.DOCUMENTSET);
            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.DOCUMENTSET, cacheExpires);

            return ret;
        }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocumentSet Post(DocumentSet request)
        {
            if(request == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            request.Select = request.Select ?? new List<string>();

            DocumentSet ret = null;

            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "DocumentSet")) 
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                    ret = _AssignValues(request, DocConstantPermission.ADD, ssn);
                });
            }
            return ret;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<DocumentSet> Post(DocumentSetBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<DocumentSet>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Post(dto) as DocumentSet;
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
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocumentSet Post(DocumentSetCopy request)
        {
            DocumentSet ret = null;
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    var entity = DocEntityDocumentSet.Get(request?.Id);
                    if(null == entity) throw new HttpError(HttpStatusCode.NoContent, "The COPY request did not succeed.");
                    if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD))
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                    var pClients = entity.Clients.ToList();
                    var pConfidential = entity.Confidential;
                    var pDivisions = entity.Divisions.ToList();
                    var pDocuments = entity.Documents.ToList();
                    var pDocumentSets = entity.DocumentSets.ToList();
                    var pHistories = entity.Histories.ToList();
                    var pLegacyDocumentSetId = entity.LegacyDocumentSetId;
                    var pName = entity.Name;
                    if(!DocTools.IsNullOrEmpty(pName))
                        pName += " (Copy)";
                    var pOwner = entity.Owner;
                    var pProjectTeam = entity.ProjectTeam;
                    var pScopes = entity.Scopes.ToList();
                    var pSettings = entity.Settings;
                    var pStats = entity.Stats.ToList();
                    var pType = entity.Type;
                    var pUsers = entity.Users.ToList();
                    var copy = new DocEntityDocumentSet(ssn)
                    {
                        Hash = Guid.NewGuid()
                                , Confidential = pConfidential
                                , LegacyDocumentSetId = pLegacyDocumentSetId
                                , Name = pName
                                , Owner = pOwner
                                , ProjectTeam = pProjectTeam
                                , Settings = pSettings
                                , Type = pType
                    };
                            foreach(var item in pClients)
                            {
                                entity.Clients.Add(item);
                            }

                            foreach(var item in pDivisions)
                            {
                                entity.Divisions.Add(item);
                            }

                            foreach(var item in pDocuments)
                            {
                                entity.Documents.Add(item);
                            }

                            foreach(var item in pDocumentSets)
                            {
                                entity.DocumentSets.Add(item);
                            }

                            foreach(var item in pHistories)
                            {
                                entity.Histories.Add(item);
                            }

                            foreach(var item in pScopes)
                            {
                                entity.Scopes.Add(item);
                            }

                            foreach(var item in pStats)
                            {
                                entity.Stats.Add(item);
                            }

                            foreach(var item in pUsers)
                            {
                                entity.Users.Add(item);
                            }

                    copy.SaveChanges(DocConstantPermission.ADD);
                    ret = copy.ToDto();
                });
            }
            return ret;
        }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<DocumentSet> Put(DocumentSetBatch request)
        {
            return Patch(request);
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocumentSet Put(DocumentSet request)
        {
            return Patch(request);
        }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<DocumentSet> Patch(DocumentSetBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<DocumentSet>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Patch(dto) as DocumentSet;
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
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DocumentSet Patch(DocumentSet request)
        {
            if(true != (request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the DocumentSet to patch.");
            
            request.Select = request.Select ?? new List<string>();
            
            DocumentSet ret = null;
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    ret = _AssignValues(request, DocConstantPermission.EDIT, ssn);
                });
            }
            return ret;
        }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public void Delete(DocumentSetBatch request)
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
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public void Delete(DocumentSet request)
        {
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    if(!(request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, $"No Id provided for delete.");

                    var en = DocEntityDocumentSet.Get(request?.Id);
                    if(null == en) throw new HttpError(HttpStatusCode.NotFound, $"No DocumentSet could be found for Id {request?.Id}.");
                    if(en.IsRemoved) return;
                
                    if(!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.DELETE))
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have DELETE permission for this route.");
                
                    en.Remove();

                    DocCacheClient.RemoveSearch(DocConstantModelName.DOCUMENTSET);
                    DocCacheClient.RemoveById(request.Id);
                });
            }
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public void Delete(DocumentSetSearch request)
        {
            var matches = Get(request) as List<DocumentSet>;
            if(true != matches?.Any()) throw new HttpError(HttpStatusCode.NotFound, "No matches for request");
            matches.ForEach(match =>
            {
                Delete(match);
            });
        }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Get(DocumentSetJunction request)
        {
            switch(request.Junction.ToLower().TrimAndPruneSpaces())
            {
                    case "lookuptablebinding":
                        return GetJunctionSearchResult<DocumentSet, DocEntityDocumentSet, DocEntityLookupTableBinding, LookupTableBinding, LookupTableBindingSearch>((int)request.Id, DocConstantModelName.LOOKUPTABLEBINDING, "Bindings", request, (ss) => HostContext.ResolveService<LookupTableBindingService>(Request)?.Get(ss));
                    case "client":
                        return GetJunctionSearchResult<DocumentSet, DocEntityDocumentSet, DocEntityClient, Client, ClientSearch>((int)request.Id, DocConstantModelName.CLIENT, "Clients", request, (ss) => HostContext.ResolveService<ClientService>(Request)?.Get(ss));
                    case "comment":
                        return GetJunctionSearchResult<DocumentSet, DocEntityDocumentSet, DocEntityComment, Comment, CommentSearch>((int)request.Id, DocConstantModelName.COMMENT, "Comments", request, (ss) => HostContext.ResolveService<CommentService>(Request)?.Get(ss));
                    case "division":
                        return GetJunctionSearchResult<DocumentSet, DocEntityDocumentSet, DocEntityDivision, Division, DivisionSearch>((int)request.Id, DocConstantModelName.DIVISION, "Divisions", request, (ss) => HostContext.ResolveService<DivisionService>(Request)?.Get(ss));
                    case "document":
                        return GetJunctionSearchResult<DocumentSet, DocEntityDocumentSet, DocEntityDocument, Document, DocumentSearch>((int)request.Id, DocConstantModelName.DOCUMENT, "Documents", request, (ss) => HostContext.ResolveService<DocumentService>(Request)?.Get(ss));
                    case "documentset":
                        return GetJunctionSearchResult<DocumentSet, DocEntityDocumentSet, DocEntityDocumentSet, DocumentSet, DocumentSetSearch>((int)request.Id, DocConstantModelName.DOCUMENTSET, "DocumentSets", request, (ss) => HostContext.ResolveService<DocumentSetService>(Request)?.Get(ss));
                    case "favorite":
                        return GetJunctionSearchResult<DocumentSet, DocEntityDocumentSet, DocEntityFavorite, Favorite, FavoriteSearch>((int)request.Id, DocConstantModelName.FAVORITE, "Favorites", request, (ss) => HostContext.ResolveService<FavoriteService>(Request)?.Get(ss));
                    case "file":
                        return GetJunctionSearchResult<DocumentSet, DocEntityDocumentSet, DocEntityFile, File, FileSearch>((int)request.Id, DocConstantModelName.FILE, "Files", request, (ss) => HostContext.ResolveService<FileService>(Request)?.Get(ss));
                    case "documentsethistory":
                        return GetJunctionSearchResult<DocumentSet, DocEntityDocumentSet, DocEntityDocumentSetHistory, DocumentSetHistory, DocumentSetHistorySearch>((int)request.Id, DocConstantModelName.DOCUMENTSETHISTORY, "Histories", request, (ss) => HostContext.ResolveService<DocumentSetHistoryService>(Request)?.Get(ss));
                    case "scope":
                        return GetJunctionSearchResult<DocumentSet, DocEntityDocumentSet, DocEntityScope, Scope, ScopeSearch>((int)request.Id, DocConstantModelName.SCOPE, "Scopes", request, (ss) => HostContext.ResolveService<ScopeService>(Request)?.Get(ss));
                    case "statsstudyset":
                        return GetJunctionSearchResult<DocumentSet, DocEntityDocumentSet, DocEntityStatsStudySet, StatsStudySet, StatsStudySetSearch>((int)request.Id, DocConstantModelName.STATSSTUDYSET, "Stats", request, (ss) => HostContext.ResolveService<StatsStudySetService>(Request)?.Get(ss));
                    case "tag":
                        return GetJunctionSearchResult<DocumentSet, DocEntityDocumentSet, DocEntityTag, Tag, TagSearch>((int)request.Id, DocConstantModelName.TAG, "Tags", request, (ss) => HostContext.ResolveService<TagService>(Request)?.Get(ss));
                    case "user":
                        return GetJunctionSearchResult<DocumentSet, DocEntityDocumentSet, DocEntityUser, User, UserSearch>((int)request.Id, DocConstantModelName.USER, "Users", request, (ss) => HostContext.ResolveService<UserService>(Request)?.Get(ss));
                    case "workflow":
                        return GetJunctionSearchResult<DocumentSet, DocEntityDocumentSet, DocEntityWorkflow, Workflow, WorkflowSearch>((int)request.Id, DocConstantModelName.WORKFLOW, "Workflows", request, (ss) => HostContext.ResolveService<WorkflowService>(Request)?.Get(ss));
                default:
                    throw new HttpError(HttpStatusCode.NotFound, $"Route for documentset/{request.Id}/{request.Junction} was not found");
            }
        }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Post(DocumentSetJunction request)
        {
            switch(request.Junction.ToLower().TrimAndPruneSpaces())
            {
                    case "client":
                        return AddJunction<DocumentSet, DocEntityDocumentSet, DocEntityClient, Client, ClientSearch>((int)request.Id, DocConstantModelName.CLIENT, "Clients", request);
                    case "comment":
                        return AddJunction<DocumentSet, DocEntityDocumentSet, DocEntityComment, Comment, CommentSearch>((int)request.Id, DocConstantModelName.COMMENT, "Comments", request);
                    case "division":
                        return AddJunction<DocumentSet, DocEntityDocumentSet, DocEntityDivision, Division, DivisionSearch>((int)request.Id, DocConstantModelName.DIVISION, "Divisions", request);
                    case "document":
                        return AddJunction<DocumentSet, DocEntityDocumentSet, DocEntityDocument, Document, DocumentSearch>((int)request.Id, DocConstantModelName.DOCUMENT, "Documents", request);
                    case "favorite":
                        return AddJunction<DocumentSet, DocEntityDocumentSet, DocEntityFavorite, Favorite, FavoriteSearch>((int)request.Id, DocConstantModelName.FAVORITE, "Favorites", request);
                    case "file":
                        return AddJunction<DocumentSet, DocEntityDocumentSet, DocEntityFile, File, FileSearch>((int)request.Id, DocConstantModelName.FILE, "Files", request);
                    case "scope":
                        return AddJunction<DocumentSet, DocEntityDocumentSet, DocEntityScope, Scope, ScopeSearch>((int)request.Id, DocConstantModelName.SCOPE, "Scopes", request);
                    case "tag":
                        return AddJunction<DocumentSet, DocEntityDocumentSet, DocEntityTag, Tag, TagSearch>((int)request.Id, DocConstantModelName.TAG, "Tags", request);
                    case "user":
                        return AddJunction<DocumentSet, DocEntityDocumentSet, DocEntityUser, User, UserSearch>((int)request.Id, DocConstantModelName.USER, "Users", request);
                default:
                    throw new HttpError(HttpStatusCode.NotFound, $"Route for documentset/{request.Id}/{request.Junction} was not found");
            }
        }

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Delete(DocumentSetJunction request)
        {    
            switch(request.Junction.ToLower().TrimAndPruneSpaces())
            {
                    case "client":
                        return RemoveJunction<DocumentSet, DocEntityDocumentSet, DocEntityClient, Client, ClientSearch>((int)request.Id, DocConstantModelName.CLIENT, "Clients", request);
                    case "comment":
                        return RemoveJunction<DocumentSet, DocEntityDocumentSet, DocEntityComment, Comment, CommentSearch>((int)request.Id, DocConstantModelName.COMMENT, "Comments", request);
                    case "division":
                        return RemoveJunction<DocumentSet, DocEntityDocumentSet, DocEntityDivision, Division, DivisionSearch>((int)request.Id, DocConstantModelName.DIVISION, "Divisions", request);
                    case "document":
                        return RemoveJunction<DocumentSet, DocEntityDocumentSet, DocEntityDocument, Document, DocumentSearch>((int)request.Id, DocConstantModelName.DOCUMENT, "Documents", request);
                    case "favorite":
                        return RemoveJunction<DocumentSet, DocEntityDocumentSet, DocEntityFavorite, Favorite, FavoriteSearch>((int)request.Id, DocConstantModelName.FAVORITE, "Favorites", request);
                    case "file":
                        return RemoveJunction<DocumentSet, DocEntityDocumentSet, DocEntityFile, File, FileSearch>((int)request.Id, DocConstantModelName.FILE, "Files", request);
                    case "scope":
                        return RemoveJunction<DocumentSet, DocEntityDocumentSet, DocEntityScope, Scope, ScopeSearch>((int)request.Id, DocConstantModelName.SCOPE, "Scopes", request);
                    case "tag":
                        return RemoveJunction<DocumentSet, DocEntityDocumentSet, DocEntityTag, Tag, TagSearch>((int)request.Id, DocConstantModelName.TAG, "Tags", request);
                    case "user":
                        return RemoveJunction<DocumentSet, DocEntityDocumentSet, DocEntityUser, User, UserSearch>((int)request.Id, DocConstantModelName.USER, "Users", request);
                default:
                    throw new HttpError(HttpStatusCode.NotFound, $"Route for documentset/{request.Id}/{request.Junction} was not found");
            }
        }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private DocumentSet GetDocumentSet(DocumentSet request)
        {
            var id = request?.Id;
            DocumentSet ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetSelect<DocumentSet>(currentUser, "DocumentSet", request.Select);

            DocEntityDocumentSet entity = null;
            if(id.HasValue)
            {
                entity = DocEntityDocumentSet.Get(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No DocumentSet found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }

    }
}
