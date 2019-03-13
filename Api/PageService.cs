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
    public partial class PageService : DocServiceBase
    {
        private IQueryable<DocEntityPage> _ExecSearch(PageSearch request)
        {
            request = InitSearch<Page, PageSearch>(request);
            IQueryable<DocEntityPage> entities = null;
            Execute.Run( session => 
            {
                entities = Execute.SelectAll<DocEntityPage>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new PageFullTextSearch(request);
                    entities = GetFullTextSearch<DocEntityPage,PageFullTextSearch>(fts, entities);
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
                if(true == request.Archived?.Any() && currentUser.HasProperty(DocConstantModelName.PAGE, nameof(Reference.Archived), DocConstantPermission.VIEW))
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

                if(true == request.AppsIds?.Any())
                {
                    entities = entities.Where(en => en.Apps.Any(r => r.Id.In(request.AppsIds)));
                }
                if(!DocTools.IsNullOrEmpty(request.Description))
                    entities = entities.Where(en => en.Description.Contains(request.Description));
                if(true == request.GlossaryIds?.Any())
                {
                    entities = entities.Where(en => en.Glossary.Any(r => r.Id.In(request.GlossaryIds)));
                }
                if(true == request.HelpIds?.Any())
                {
                    entities = entities.Where(en => en.Help.Any(r => r.Id.In(request.HelpIds)));
                }
                if(!DocTools.IsNullOrEmpty(request.Name))
                    entities = entities.Where(en => en.Name.Contains(request.Name));
                if(true == request.RolesIds?.Any())
                {
                    entities = entities.Where(en => en.Roles.Any(r => r.Id.In(request.RolesIds)));
                }

                entities = ApplyFilters<DocEntityPage,PageSearch>(request, entities);

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

        public object Post(PageSearch request) => Get(request);

        public object Get(PageSearch request) => GetSearchResultWithCache<Page,DocEntityPage,PageSearch>(DocConstantModelName.PAGE, request, _ExecSearch);

        public object Get(Page request) => GetEntityWithCache<Page>(DocConstantModelName.PAGE, request, GetPage);

        private Page _AssignValues(Page request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "Page"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            Page ret = null;
            request = _InitAssignValues<Page>(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            var cacheKey = GetApiCacheKey<Page>(DocConstantModelName.PAGE, nameof(Page), request);
            
            //First, assign all the variables, do database lookups and conversions
            var pApps = request.Apps?.ToList();
            var pDescription = request.Description;
            var pGlossary = request.Glossary?.ToList();
            var pHelp = request.Help?.ToList();
            var pName = request.Name;
            var pRoles = request.Roles?.ToList();

            DocEntityPage entity = null;
            if(permission == DocConstantPermission.ADD)
            {
                var now = DateTime.UtcNow;
                entity = new DocEntityPage(session)
                {
                    Created = now,
                    Updated = now
                };
            }
            else
            {
                entity = DocEntityPage.GetPage(request.Id);
                if(null == entity)
                    throw new HttpError(HttpStatusCode.NotFound, $"No record");
            }

            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pDescription, permission, DocConstantModelName.PAGE, nameof(request.Description)))
            {
                if(DocPermissionFactory.IsRequested(request, pDescription, entity.Description, nameof(request.Description)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.PAGE, nameof(request.Description)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Description)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pDescription) && DocResources.Metadata.IsRequired(DocConstantModelName.PAGE, nameof(request.Description))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Description)} requires a value.");
                    entity.Description = pDescription;
                if(DocPermissionFactory.IsRequested<string>(request, pDescription, nameof(request.Description)) && !request.VisibleFields.Matches(nameof(request.Description), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Description));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pName, permission, DocConstantModelName.PAGE, nameof(request.Name)))
            {
                if(DocPermissionFactory.IsRequested(request, pName, entity.Name, nameof(request.Name)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.PAGE, nameof(request.Name)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Name)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pName) && DocResources.Metadata.IsRequired(DocConstantModelName.PAGE, nameof(request.Name))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Name)} requires a value.");
                    entity.Name = pName;
                if(DocPermissionFactory.IsRequested<string>(request, pName, nameof(request.Name)) && !request.VisibleFields.Matches(nameof(request.Name), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Name));
                }
            }

            if (request.Locked) entity.Locked = request.Locked;

            entity.SaveChanges(permission);

            if (DocPermissionFactory.IsRequestedHasPermission<List<Reference>>(currentUser, request, pApps, permission, DocConstantModelName.PAGE, nameof(request.Apps)))
            {
                if (true == pApps?.Any() )
                {
                    var requestedApps = pApps.Select(p => p.Id).Distinct().ToList();
                    var existsApps = Execute.SelectAll<DocEntityApp>().Where(e => e.Id.In(requestedApps)).Select( e => e.Id ).ToList();
                    if (existsApps.Count != requestedApps.Count)
                    {
                        var nonExists = requestedApps.Where(id => existsApps.All(eId => eId != id));
                        throw new HttpError(HttpStatusCode.NotFound, $"Cannot patch collection Apps with objects that do not exist. No matching Apps(s) could be found for Ids: {nonExists.ToDelimitedString()}.");
                    }
                    var toAdd = requestedApps.Where(id => entity.Apps.All(e => e.Id != id)).ToList(); 
                    toAdd?.ForEach(id =>
                    {
                        var target = DocEntityApp.GetApp(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD, targetEntity: target, targetName: nameof(Page), columnName: nameof(request.Apps)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to add {nameof(request.Apps)} to {nameof(Page)}");
                        entity.Apps.Add(target);
                    });
                    var toRemove = entity.Apps.Where(e => requestedApps.All(id => e.Id != id)).Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityApp.GetApp(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(Page), columnName: nameof(request.Apps)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Apps)} from {nameof(Page)}");
                        entity.Apps.Remove(target);
                    });
                }
                else
                {
                    var toRemove = entity.Apps.Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityApp.GetApp(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(Page), columnName: nameof(request.Apps)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Apps)} from {nameof(Page)}");
                        entity.Apps.Remove(target);
                    });
                }
                if(DocPermissionFactory.IsRequested<List<Reference>>(request, pApps, nameof(request.Apps)) && !request.VisibleFields.Matches(nameof(request.Apps), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Apps));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<List<Reference>>(currentUser, request, pGlossary, permission, DocConstantModelName.PAGE, nameof(request.Glossary)))
            {
                if (true == pGlossary?.Any() )
                {
                    var requestedGlossary = pGlossary.Select(p => p.Id).Distinct().ToList();
                    var existsGlossary = Execute.SelectAll<DocEntityGlossary>().Where(e => e.Id.In(requestedGlossary)).Select( e => e.Id ).ToList();
                    if (existsGlossary.Count != requestedGlossary.Count)
                    {
                        var nonExists = requestedGlossary.Where(id => existsGlossary.All(eId => eId != id));
                        throw new HttpError(HttpStatusCode.NotFound, $"Cannot patch collection Glossary with objects that do not exist. No matching Glossary(s) could be found for Ids: {nonExists.ToDelimitedString()}.");
                    }
                    var toAdd = requestedGlossary.Where(id => entity.Glossary.All(e => e.Id != id)).ToList(); 
                    toAdd?.ForEach(id =>
                    {
                        var target = DocEntityGlossary.GetGlossary(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD, targetEntity: target, targetName: nameof(Page), columnName: nameof(request.Glossary)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to add {nameof(request.Glossary)} to {nameof(Page)}");
                        entity.Glossary.Add(target);
                    });
                    var toRemove = entity.Glossary.Where(e => requestedGlossary.All(id => e.Id != id)).Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityGlossary.GetGlossary(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(Page), columnName: nameof(request.Glossary)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Glossary)} from {nameof(Page)}");
                        entity.Glossary.Remove(target);
                    });
                }
                else
                {
                    var toRemove = entity.Glossary.Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityGlossary.GetGlossary(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(Page), columnName: nameof(request.Glossary)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Glossary)} from {nameof(Page)}");
                        entity.Glossary.Remove(target);
                    });
                }
                if(DocPermissionFactory.IsRequested<List<Reference>>(request, pGlossary, nameof(request.Glossary)) && !request.VisibleFields.Matches(nameof(request.Glossary), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Glossary));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<List<Reference>>(currentUser, request, pHelp, permission, DocConstantModelName.PAGE, nameof(request.Help)))
            {
                if (true == pHelp?.Any() )
                {
                    var requestedHelp = pHelp.Select(p => p.Id).Distinct().ToList();
                    var existsHelp = Execute.SelectAll<DocEntityHelp>().Where(e => e.Id.In(requestedHelp)).Select( e => e.Id ).ToList();
                    if (existsHelp.Count != requestedHelp.Count)
                    {
                        var nonExists = requestedHelp.Where(id => existsHelp.All(eId => eId != id));
                        throw new HttpError(HttpStatusCode.NotFound, $"Cannot patch collection Help with objects that do not exist. No matching Help(s) could be found for Ids: {nonExists.ToDelimitedString()}.");
                    }
                    var toAdd = requestedHelp.Where(id => entity.Help.All(e => e.Id != id)).ToList(); 
                    toAdd?.ForEach(id =>
                    {
                        var target = DocEntityHelp.GetHelp(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD, targetEntity: target, targetName: nameof(Page), columnName: nameof(request.Help)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to add {nameof(request.Help)} to {nameof(Page)}");
                        entity.Help.Add(target);
                    });
                    var toRemove = entity.Help.Where(e => requestedHelp.All(id => e.Id != id)).Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityHelp.GetHelp(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(Page), columnName: nameof(request.Help)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Help)} from {nameof(Page)}");
                        entity.Help.Remove(target);
                    });
                }
                else
                {
                    var toRemove = entity.Help.Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityHelp.GetHelp(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(Page), columnName: nameof(request.Help)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Help)} from {nameof(Page)}");
                        entity.Help.Remove(target);
                    });
                }
                if(DocPermissionFactory.IsRequested<List<Reference>>(request, pHelp, nameof(request.Help)) && !request.VisibleFields.Matches(nameof(request.Help), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Help));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<List<Reference>>(currentUser, request, pRoles, permission, DocConstantModelName.PAGE, nameof(request.Roles)))
            {
                if (true == pRoles?.Any() )
                {
                    var requestedRoles = pRoles.Select(p => p.Id).Distinct().ToList();
                    var existsRoles = Execute.SelectAll<DocEntityRole>().Where(e => e.Id.In(requestedRoles)).Select( e => e.Id ).ToList();
                    if (existsRoles.Count != requestedRoles.Count)
                    {
                        var nonExists = requestedRoles.Where(id => existsRoles.All(eId => eId != id));
                        throw new HttpError(HttpStatusCode.NotFound, $"Cannot patch collection Roles with objects that do not exist. No matching Roles(s) could be found for Ids: {nonExists.ToDelimitedString()}.");
                    }
                    var toAdd = requestedRoles.Where(id => entity.Roles.All(e => e.Id != id)).ToList(); 
                    toAdd?.ForEach(id =>
                    {
                        var target = DocEntityRole.GetRole(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD, targetEntity: target, targetName: nameof(Page), columnName: nameof(request.Roles)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to add {nameof(request.Roles)} to {nameof(Page)}");
                        entity.Roles.Add(target);
                    });
                    var toRemove = entity.Roles.Where(e => requestedRoles.All(id => e.Id != id)).Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityRole.GetRole(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(Page), columnName: nameof(request.Roles)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Roles)} from {nameof(Page)}");
                        entity.Roles.Remove(target);
                    });
                }
                else
                {
                    var toRemove = entity.Roles.Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityRole.GetRole(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(Page), columnName: nameof(request.Roles)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Roles)} from {nameof(Page)}");
                        entity.Roles.Remove(target);
                    });
                }
                if(DocPermissionFactory.IsRequested<List<Reference>>(request, pRoles, nameof(request.Roles)) && !request.VisibleFields.Matches(nameof(request.Roles), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Roles));
                }
            }
            DocPermissionFactory.SetVisibleFields<Page>(currentUser, nameof(Page), request.VisibleFields);
            ret = entity.ToDto();

            var cacheExpires = DocResources.Metadata.GetCacheExpiration(DocConstantModelName.PAGE);
            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.PAGE, cacheExpires);

            return ret;
        }
        public Page Post(Page request)
        {
            if(request == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            Page ret = null;

            Execute.Run(ssn =>
            {
                if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "Page")) 
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                ret = _AssignValues(request, DocConstantPermission.ADD, ssn);
            });

            return ret;
        }
   
        public List<Page> Post(PageBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<Page>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Post(dto) as Page;
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

        public Page Post(PageCopy request)
        {
            Page ret = null;
            Execute.Run(ssn =>
            {
                var entity = DocEntityPage.GetPage(request?.Id);
                if(null == entity) throw new HttpError(HttpStatusCode.NoContent, "The COPY request did not succeed.");
                if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                    var pApps = entity.Apps.ToList();
                    var pDescription = entity.Description;
                    if(!DocTools.IsNullOrEmpty(pDescription))
                        pDescription += " (Copy)";
                    var pGlossary = entity.Glossary.ToList();
                    var pHelp = entity.Help.ToList();
                    var pName = entity.Name;
                    if(!DocTools.IsNullOrEmpty(pName))
                        pName += " (Copy)";
                    var pRoles = entity.Roles.ToList();
                #region Custom Before copyPage
                #endregion Custom Before copyPage
                var copy = new DocEntityPage(ssn)
                {
                    Hash = Guid.NewGuid()
                                , Description = pDescription
                                , Name = pName
                };
                            foreach(var item in pApps)
                            {
                                entity.Apps.Add(item);
                            }

                            foreach(var item in pGlossary)
                            {
                                entity.Glossary.Add(item);
                            }

                            foreach(var item in pHelp)
                            {
                                entity.Help.Add(item);
                            }

                            foreach(var item in pRoles)
                            {
                                entity.Roles.Add(item);
                            }

                #region Custom After copyPage
                #endregion Custom After copyPage
                copy.SaveChanges(DocConstantPermission.ADD);
                ret = copy.ToDto();
            });
            return ret;
        }

        public List<Page> Put(PageBatch request)
        {
            return Patch(request);
        }

        public Page Put(Page request)
        {
            return Patch(request);
        }
        public List<Page> Patch(PageBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<Page>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Patch(dto) as Page;
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

        public Page Patch(Page request)
        {
            if(true != (request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the Page to patch.");
            
            request.VisibleFields = request.VisibleFields ?? new List<string>();
            
            Page ret = null;
            Execute.Run(ssn =>
            {
                ret = _AssignValues(request, DocConstantPermission.EDIT, ssn);
            });
            return ret;
        }
        public void Delete(PageBatch request)
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

        public void Delete(Page request)
        {
            Execute.Run(ssn =>
            {
                if(!(request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, $"No Id provided for delete.");

                DocCacheClient.RemoveSearch(DocConstantModelName.PAGE);
                DocCacheClient.RemoveById(request.Id);
                var en = DocEntityPage.GetPage(request?.Id);

                if(null == en) throw new HttpError(HttpStatusCode.NotFound, $"No Page could be found for Id {request?.Id}.");
                if(en.IsRemoved) return;
                
                if(!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.DELETE))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have DELETE permission for this route.");
                
                en.Remove();
            });
        }

        public void Delete(PageSearch request)
        {
            var matches = Get(request) as List<Page>;
            if(true != matches?.Any()) throw new HttpError(HttpStatusCode.NotFound, "No matches for request");

            Execute.Run(ssn =>
            {
                matches.ForEach(match =>
                {
                    Delete(match);
                });
            });
        }
        public object Get(PageJunction request) =>
            Execute.Run( s => 
            {
                switch(request.Junction.ToLower().TrimAndPruneSpaces())
                {
                    case "app":
                        return GetJunctionSearchResult<Page, DocEntityPage, DocEntityApp, App, AppSearch>((int)request.Id, DocConstantModelName.APP, "Apps", request, (ss) => HostContext.ResolveService<AppService>(Request)?.Get(ss));
                    case "glossary":
                        return GetJunctionSearchResult<Page, DocEntityPage, DocEntityGlossary, Glossary, GlossarySearch>((int)request.Id, DocConstantModelName.GLOSSARY, "Glossary", request, (ss) => HostContext.ResolveService<GlossaryService>(Request)?.Get(ss));
                    case "help":
                        return GetJunctionSearchResult<Page, DocEntityPage, DocEntityHelp, Help, HelpSearch>((int)request.Id, DocConstantModelName.HELP, "Help", request, (ss) => HostContext.ResolveService<HelpService>(Request)?.Get(ss));
                    case "role":
                        return GetJunctionSearchResult<Page, DocEntityPage, DocEntityRole, Role, RoleSearch>((int)request.Id, DocConstantModelName.ROLE, "Roles", request, (ss) => HostContext.ResolveService<RoleService>(Request)?.Get(ss));
                    default:
                        throw new HttpError(HttpStatusCode.NotFound, $"Route for page/{request.Id}/{request.Junction} was not found");
                }
            });
        public object Post(PageJunction request) =>
            Execute.Run( ssn =>
            {
                switch(request.Junction.ToLower().TrimAndPruneSpaces())
                {
                    case "app":
                        return AddJunction<Page, DocEntityPage, DocEntityApp, App, AppSearch>((int)request.Id, DocConstantModelName.APP, "Apps", request);
                    case "glossary":
                        return AddJunction<Page, DocEntityPage, DocEntityGlossary, Glossary, GlossarySearch>((int)request.Id, DocConstantModelName.GLOSSARY, "Glossary", request);
                    case "help":
                        return AddJunction<Page, DocEntityPage, DocEntityHelp, Help, HelpSearch>((int)request.Id, DocConstantModelName.HELP, "Help", request);
                    case "role":
                        return AddJunction<Page, DocEntityPage, DocEntityRole, Role, RoleSearch>((int)request.Id, DocConstantModelName.ROLE, "Roles", request);
                    default:
                        throw new HttpError(HttpStatusCode.NotFound, $"Route for page/{request.Id}/{request.Junction} was not found");
                }
            });

        public object Delete(PageJunction request) =>
            Execute.Run( ssn =>
            {
                switch(request.Junction.ToLower().TrimAndPruneSpaces())
                {
                    case "app":
                        return RemoveJunction<Page, DocEntityPage, DocEntityApp, App, AppSearch>((int)request.Id, DocConstantModelName.APP, "Apps", request);
                    case "glossary":
                        return RemoveJunction<Page, DocEntityPage, DocEntityGlossary, Glossary, GlossarySearch>((int)request.Id, DocConstantModelName.GLOSSARY, "Glossary", request);
                    case "help":
                        return RemoveJunction<Page, DocEntityPage, DocEntityHelp, Help, HelpSearch>((int)request.Id, DocConstantModelName.HELP, "Help", request);
                    case "role":
                        return RemoveJunction<Page, DocEntityPage, DocEntityRole, Role, RoleSearch>((int)request.Id, DocConstantModelName.ROLE, "Roles", request);
                    default:
                        throw new HttpError(HttpStatusCode.NotFound, $"Route for page/{request.Id}/{request.Junction} was not found");
                }
            });
        private Page GetPage(Page request)
        {
            var id = request?.Id;
            Page ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetVisibleFields<Page>(currentUser, "Page", request.VisibleFields);

            DocEntityPage entity = null;
            if(id.HasValue)
            {
                entity = DocEntityPage.GetPage(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No Page found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }
    }
}
