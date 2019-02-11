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
    public partial class HelpService : DocServiceBase
    {
        private IQueryable<DocEntityHelp> _ExecSearch(HelpSearch request)
        {
            request = InitSearch<Help, HelpSearch>(request);
            IQueryable<DocEntityHelp> entities = null;
            Execute.Run( session => 
            {
                entities = Execute.SelectAll<DocEntityHelp>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new HelpFullTextSearch(request);
                    entities = GetFullTextSearch<DocEntityHelp,HelpFullTextSearch>(fts, entities);
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

                if(!DocTools.IsNullOrEmpty(request.ConfluenceId))
                    entities = entities.Where(en => en.ConfluenceId.Contains(request.ConfluenceId));
                if(!DocTools.IsNullOrEmpty(request.Description))
                    entities = entities.Where(en => en.Description.Contains(request.Description));
                if(!DocTools.IsNullOrEmpty(request.Icon))
                    entities = entities.Where(en => en.Icon.Contains(request.Icon));
                if(request.Order.HasValue)
                    entities = entities.Where(en => request.Order.Value == en.Order);
                if(true == request.PagesIds?.Any())
                {
                    entities = entities.Where(en => en.Pages.Any(r => r.Id.In(request.PagesIds)));
                }
                if(true == request.ScopesIds?.Any())
                {
                    entities = entities.Where(en => en.Scopes.Any(r => r.Id.In(request.ScopesIds)));
                }
                if(!DocTools.IsNullOrEmpty(request.Title))
                    entities = entities.Where(en => en.Title.Contains(request.Title));
                if(!DocTools.IsNullOrEmpty(request.Type) && !DocTools.IsNullOrEmpty(request.Type.Id))
                {
                    entities = entities.Where(en => en.Type.Id == request.Type.Id );
                }
                if(true == request.TypeIds?.Any())
                {
                    entities = entities.Where(en => en.Type.Id.In(request.TypeIds));
                }
                else if(!DocTools.IsNullOrEmpty(request.Type) && !DocTools.IsNullOrEmpty(request.Type.Name))
                {
                    entities = entities.Where(en => en.Type.Name == request.Type.Name );
                }
                if(true == request.TypeNames?.Any())
                {
                    entities = entities.Where(en => en.Type.Name.In(request.TypeNames));
                }

                entities = ApplyFilters<DocEntityHelp,HelpSearch>(request, entities);

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

        public object Post(HelpSearch request) => Get(request);

        public object Get(HelpSearch request) => GetSearchResultWithCache<Help,DocEntityHelp,HelpSearch>(DocConstantModelName.HELP, request, _ExecSearch);

        public object Get(Help request) => GetEntityWithCache<Help>(DocConstantModelName.HELP, request, GetHelp);
        private Help _AssignValues(Help request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "Help"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            Help ret = null;
            request = _InitAssignValues<Help>(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            var cacheKey = GetApiCacheKey<Help>(DocConstantModelName.HELP, nameof(Help), request);
            
            //First, assign all the variables, do database lookups and conversions
            var pConfluenceId = request.ConfluenceId;
            var pDescription = request.Description;
            var pIcon = request.Icon;
            var pOrder = request.Order;
            var pPages = request.Pages?.ToList();
            var pScopes = request.Scopes?.ToList();
            var pTitle = request.Title;
            DocEntityLookupTable pType = GetLookup(DocConstantLookupTable.HELP, request.Type?.Name, request.Type?.Id);

            DocEntityHelp entity = null;
            if(permission == DocConstantPermission.ADD)
            {
                var now = DateTime.UtcNow;
                entity = new DocEntityHelp(session)
                {
                    Created = now,
                    Updated = now
                };
            }
            else
            {
                entity = DocEntityHelp.GetHelp(request.Id);
                if(null == entity)
                    throw new HttpError(HttpStatusCode.NotFound, $"No record");
            }

            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pConfluenceId, permission, DocConstantModelName.HELP, nameof(request.ConfluenceId)))
            {
                if(DocPermissionFactory.IsRequested(request, pConfluenceId, entity.ConfluenceId, nameof(request.ConfluenceId)))
                    entity.ConfluenceId = pConfluenceId;
                if(DocPermissionFactory.IsRequested<string>(request, pConfluenceId, nameof(request.ConfluenceId)) && !request.VisibleFields.Matches(nameof(request.ConfluenceId), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.ConfluenceId));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pDescription, permission, DocConstantModelName.HELP, nameof(request.Description)))
            {
                if(DocPermissionFactory.IsRequested(request, pDescription, entity.Description, nameof(request.Description)))
                    entity.Description = pDescription;
                if(DocPermissionFactory.IsRequested<string>(request, pDescription, nameof(request.Description)) && !request.VisibleFields.Matches(nameof(request.Description), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Description));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pIcon, permission, DocConstantModelName.HELP, nameof(request.Icon)))
            {
                if(DocPermissionFactory.IsRequested(request, pIcon, entity.Icon, nameof(request.Icon)))
                    entity.Icon = pIcon;
                if(DocPermissionFactory.IsRequested<string>(request, pIcon, nameof(request.Icon)) && !request.VisibleFields.Matches(nameof(request.Icon), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Icon));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<int?>(currentUser, request, pOrder, permission, DocConstantModelName.HELP, nameof(request.Order)))
            {
                if(DocPermissionFactory.IsRequested(request, pOrder, entity.Order, nameof(request.Order)))
                    entity.Order = pOrder;
                if(DocPermissionFactory.IsRequested<int?>(request, pOrder, nameof(request.Order)) && !request.VisibleFields.Matches(nameof(request.Order), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Order));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pTitle, permission, DocConstantModelName.HELP, nameof(request.Title)))
            {
                if(DocPermissionFactory.IsRequested(request, pTitle, entity.Title, nameof(request.Title)))
                    entity.Title = pTitle;
                if(DocPermissionFactory.IsRequested<string>(request, pTitle, nameof(request.Title)) && !request.VisibleFields.Matches(nameof(request.Title), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Title));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityLookupTable>(currentUser, request, pType, permission, DocConstantModelName.HELP, nameof(request.Type)))
            {
                if(DocPermissionFactory.IsRequested(request, pType, entity.Type, nameof(request.Type)))
                    entity.Type = pType;
                if(DocPermissionFactory.IsRequested<DocEntityLookupTable>(request, pType, nameof(request.Type)) && !request.VisibleFields.Matches(nameof(request.Type), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Type));
                }
            }
            
            if (request.Locked) entity.Locked = request.Locked;

            entity.SaveChanges(permission);
            
            if (DocPermissionFactory.IsRequestedHasPermission<List<Reference>>(currentUser, request, pPages, permission, DocConstantModelName.HELP, nameof(request.Pages)))
            {
                if (true == pPages?.Any() )
                {
                    var requestedPages = pPages.Select(p => p.Id).Distinct().ToList();
                    var existsPages = Execute.SelectAll<DocEntityPage>().Where(e => e.Id.In(requestedPages)).Select( e => e.Id ).ToList();
                    if (existsPages.Count != requestedPages.Count)
                    {
                        var nonExists = requestedPages.Where(id => existsPages.All(eId => eId != id));
                        throw new HttpError(HttpStatusCode.NotFound, $"Cannot patch collection Pages with objects that do not exist. No matching Pages(s) could be found for Ids: {nonExists.ToDelimitedString()}.");
                    }
                    var toAdd = requestedPages.Where(id => entity.Pages.All(e => e.Id != id)).ToList(); 
                    toAdd?.ForEach(id =>
                    {
                        var target = DocEntityPage.GetPage(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD, targetEntity: target, targetName: nameof(Help), columnName: nameof(request.Pages)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to add {nameof(request.Pages)} to {nameof(Help)}");
                        entity.Pages.Add(target);
                    });
                    var toRemove = entity.Pages.Where(e => requestedPages.All(id => e.Id != id)).Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityPage.GetPage(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(Help), columnName: nameof(request.Pages)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Pages)} from {nameof(Help)}");
                        entity.Pages.Remove(target);
                    });
                }
                else
                {
                    var toRemove = entity.Pages.Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityPage.GetPage(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(Help), columnName: nameof(request.Pages)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Pages)} from {nameof(Help)}");
                        entity.Pages.Remove(target);
                    });
                }
                if(DocPermissionFactory.IsRequested<List<Reference>>(request, pPages, nameof(request.Pages)) && !request.VisibleFields.Matches(nameof(request.Pages), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Pages));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<List<Reference>>(currentUser, request, pScopes, permission, DocConstantModelName.HELP, nameof(request.Scopes)))
            {
                if (true == pScopes?.Any() )
                {
                    var requestedScopes = pScopes.Select(p => p.Id).Distinct().ToList();
                    var existsScopes = Execute.SelectAll<DocEntityScope>().Where(e => e.Id.In(requestedScopes)).Select( e => e.Id ).ToList();
                    if (existsScopes.Count != requestedScopes.Count)
                    {
                        var nonExists = requestedScopes.Where(id => existsScopes.All(eId => eId != id));
                        throw new HttpError(HttpStatusCode.NotFound, $"Cannot patch collection Scopes with objects that do not exist. No matching Scopes(s) could be found for Ids: {nonExists.ToDelimitedString()}.");
                    }
                    var toAdd = requestedScopes.Where(id => entity.Scopes.All(e => e.Id != id)).ToList(); 
                    toAdd?.ForEach(id =>
                    {
                        var target = DocEntityScope.GetScope(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD, targetEntity: target, targetName: nameof(Help), columnName: nameof(request.Scopes)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to add {nameof(request.Scopes)} to {nameof(Help)}");
                        entity.Scopes.Add(target);
                    });
                    var toRemove = entity.Scopes.Where(e => requestedScopes.All(id => e.Id != id)).Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityScope.GetScope(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(Help), columnName: nameof(request.Scopes)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Scopes)} from {nameof(Help)}");
                        entity.Scopes.Remove(target);
                    });
                }
                else
                {
                    var toRemove = entity.Scopes.Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityScope.GetScope(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(Help), columnName: nameof(request.Scopes)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Scopes)} from {nameof(Help)}");
                        entity.Scopes.Remove(target);
                    });
                }
                if(DocPermissionFactory.IsRequested<List<Reference>>(request, pScopes, nameof(request.Scopes)) && !request.VisibleFields.Matches(nameof(request.Scopes), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Scopes));
                }
            }
            DocPermissionFactory.SetVisibleFields<Help>(currentUser, nameof(Help), request.VisibleFields);
            ret = entity.ToDto();

            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.HELP);

            return ret;
        }
        public Help Post(Help request)
        {
            if(request == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            Help ret = null;

            Execute.Run(ssn =>
            {
                if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "Help")) 
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                ret = _AssignValues(request, DocConstantPermission.ADD, ssn);
            });

            return ret;
        }
   
        public List<Help> Post(HelpBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<Help>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Post(dto) as Help;
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

        public Help Post(HelpCopy request)
        {
            Help ret = null;
            Execute.Run(ssn =>
            {
                var entity = DocEntityHelp.GetHelp(request?.Id);
                if(null == entity) throw new HttpError(HttpStatusCode.NoContent, "The COPY request did not succeed.");
                if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");
                
                    var pConfluenceId = entity.ConfluenceId;
                    if(!DocTools.IsNullOrEmpty(pConfluenceId))
                        pConfluenceId += " (Copy)";
                    var pDescription = entity.Description;
                    if(!DocTools.IsNullOrEmpty(pDescription))
                        pDescription += " (Copy)";
                    var pIcon = entity.Icon;
                    if(!DocTools.IsNullOrEmpty(pIcon))
                        pIcon += " (Copy)";
                    var pOrder = entity.Order;
                    var pPages = entity.Pages.ToList();
                    var pScopes = entity.Scopes.ToList();
                    var pTitle = entity.Title;
                    if(!DocTools.IsNullOrEmpty(pTitle))
                        pTitle += " (Copy)";
                    var pType = entity.Type;
                #region Custom Before copyHelp
                #endregion Custom Before copyHelp
                var copy = new DocEntityHelp(ssn)
                {
                    Hash = Guid.NewGuid()
                                , ConfluenceId = pConfluenceId
                                , Description = pDescription
                                , Icon = pIcon
                                , Order = pOrder
                                , Title = pTitle
                                , Type = pType
                };
                            foreach(var item in pPages)
                            {
                                entity.Pages.Add(item);
                            }

                            foreach(var item in pScopes)
                            {
                                entity.Scopes.Add(item);
                            }

                #region Custom After copyHelp
                #endregion Custom After copyHelp
                copy.SaveChanges(DocConstantPermission.ADD);
                ret = copy.ToDto();
            });
            return ret;
        }


        public List<Help> Put(HelpBatch request)
        {
            return Patch(request);
        }

        public Help Put(Help request)
        {
            return Patch(request);
        }

        public List<Help> Patch(HelpBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<Help>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Patch(dto) as Help;
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

        public Help Patch(Help request)
        {
            if(true != (request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the Help to patch.");
            
            request.VisibleFields = request.VisibleFields ?? new List<string>();
            
            Help ret = null;
            Execute.Run(ssn =>
            {
                ret = _AssignValues(request, DocConstantPermission.EDIT, ssn);
            });
            return ret;
        }

        public void Delete(HelpBatch request)
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

        public void Delete(Help request)
        {
            Execute.Run(ssn =>
            {
                if(!(request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, $"No Id provided for delete.");

                DocCacheClient.RemoveSearch(DocConstantModelName.HELP);
                DocCacheClient.RemoveById(request.Id);
                var en = DocEntityHelp.GetHelp(request?.Id);

                if(null == en) throw new HttpError(HttpStatusCode.NotFound, $"No Help could be found for Id {request?.Id}.");
                if(en.IsRemoved) return;
                
                if(!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.DELETE))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have DELETE permission for this route.");
                
                en.Remove();
            });
        }

        public void Delete(HelpSearch request)
        {
            var matches = Get(request) as List<Help>;
            if(true != matches?.Any()) throw new HttpError(HttpStatusCode.NotFound, "No matches for request");

            Execute.Run(ssn =>
            {
                matches.ForEach(match =>
                {
                    Delete(match);
                });
            });
        }
        public object Get(HelpJunction request)
        {
            if(!(request.Id > 0))
                throw new HttpError(HttpStatusCode.NotFound, "Valid Id required.");
            object ret = null;
            Execute.Run( s => 
            {
                switch(request.Junction)
                {
                case "page":
                    ret =     GetJunctionSearchResult<Help, DocEntityHelp, DocEntityPage, Page, PageSearch>((int)request.Id, DocConstantModelName.PAGE, "Pages", request,
                            (ss) =>
                            { 
                                var service = HostContext.ResolveService<PageService>(Request);
                                return service.Get(ss);
                            });
                    break;
                case "scope":
                    ret =     GetJunctionSearchResult<Help, DocEntityHelp, DocEntityScope, Scope, ScopeSearch>((int)request.Id, DocConstantModelName.SCOPE, "Scopes", request,
                            (ss) =>
                            { 
                                var service = HostContext.ResolveService<ScopeService>(Request);
                                return service.Get(ss);
                            });
                    break;
                    default:
                        throw new HttpError(HttpStatusCode.NotFound, $"Route for help/{request.Id}/{request.Junction} was not found");
                }
            });
            return ret;
        }


        public object Post(HelpJunction request)
        {
            if (request == null)
                throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");
            if (!(request.Id > 0))
                throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the {className} to update.");
            if (request.Ids == null || request.Ids.Count < 1)
                throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid list of {type} Ids.");

            object ret = null;

            Execute.Run( ssn =>
            {
                switch(request.Junction)
                {
                case "page":
                    ret = _PostHelpPage(request);
                    break;
                case "scope":
                    ret = _PostHelpScope(request);
                    break;
                    default:
                        throw new HttpError(HttpStatusCode.NotFound, $"Route for help/{request.Id}/{request.Junction} was not found");
                }
            });
            return ret;
        }


        private object _PostHelpPage(HelpJunction request)
        {
            var entity = DocEntityHelp.GetHelp(request.Id);

            if (null == entity) throw new HttpError(HttpStatusCode.NotFound, $"No Help found for Id {request.Id}");

            if (!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.EDIT))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have Edit permission to Help");

            foreach (var id in request.Ids)
            {
                var relationship = DocEntityPage.GetPage(id);
                if (!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD, targetEntity: relationship, targetName: DocConstantModelName.PAGE, columnName: "Pages")) 
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have Add permission to the Pages property.");
                if (null == relationship) throw new HttpError(HttpStatusCode.NotFound, $"Cannot post to collection of Help with objects that do not exist. No matching Page could be found for {id}.");
                entity.Pages.Add(relationship);
            }
            entity.SaveChanges();
            return entity.ToDto();
        }

        private object _PostHelpScope(HelpJunction request)
        {
            var entity = DocEntityHelp.GetHelp(request.Id);

            if (null == entity) throw new HttpError(HttpStatusCode.NotFound, $"No Help found for Id {request.Id}");

            if (!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.EDIT))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have Edit permission to Help");

            foreach (var id in request.Ids)
            {
                var relationship = DocEntityScope.GetScope(id);
                if (!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD, targetEntity: relationship, targetName: DocConstantModelName.SCOPE, columnName: "Scopes")) 
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have Add permission to the Scopes property.");
                if (null == relationship) throw new HttpError(HttpStatusCode.NotFound, $"Cannot post to collection of Help with objects that do not exist. No matching Scope could be found for {id}.");
                entity.Scopes.Add(relationship);
            }
            entity.SaveChanges();
            return entity.ToDto();
        }

        public object Delete(HelpJunction request)
        {
            if (request == null)
                throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");
            if (!(request.Id > 0))
                throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the {className} to update.");
            if (request.Ids == null || request.Ids.Count < 1)
                throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid list of {type} Ids.");

            object ret = null;

            Execute.Run( ssn =>
            {
                switch(request.Junction)
                {
                case "page":
                    ret = _DeleteHelpPage(request);
                    break;
                case "scope":
                    ret = _DeleteHelpScope(request);
                    break;
                    default:
                        throw new HttpError(HttpStatusCode.NotFound, $"Route for help/{request.Id}/{request.Junction} was not found");
                }
            });
            return ret;
        }


        private object _DeleteHelpPage(HelpJunction request)
        {
            var entity = DocEntityHelp.GetHelp(request.Id);

            if (null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No Help found for Id {request.Id}");
            if (!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.EDIT))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have Edit permission to Help");
            foreach (var id in request.Ids)
            {
                var relationship = DocEntityPage.GetPage(id);
                if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: relationship, targetName: DocConstantModelName.PAGE, columnName: "Pages"))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have Edit permission to relationships between Help and Page");
                if(null != relationship && false == relationship.IsRemoved) entity.Pages.Remove(relationship);
            }
            entity.SaveChanges();
            return entity.ToDto();
        }

        private object _DeleteHelpScope(HelpJunction request)
        {
            var entity = DocEntityHelp.GetHelp(request.Id);

            if (null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No Help found for Id {request.Id}");
            if (!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.EDIT))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have Edit permission to Help");
            foreach (var id in request.Ids)
            {
                var relationship = DocEntityScope.GetScope(id);
                if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: relationship, targetName: DocConstantModelName.SCOPE, columnName: "Scopes"))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have Edit permission to relationships between Help and Scope");
                if(null != relationship && false == relationship.IsRemoved) entity.Scopes.Remove(relationship);
            }
            entity.SaveChanges();
            return entity.ToDto();
        }

        private Help GetHelp(Help request)
        {
            var id = request?.Id;
            Help ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetVisibleFields<Help>(currentUser, "Help", request.VisibleFields);

            DocEntityHelp entity = null;
            if(id.HasValue)
            {
                entity = DocEntityHelp.GetHelp(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No Help found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }
    }
}