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
    public partial class VariableRuleService : DocServiceBase
    {
        private IQueryable<DocEntityVariableRule> _ExecSearch(VariableRuleSearch request)
        {
            request = InitSearch<VariableRule, VariableRuleSearch>(request);
            IQueryable<DocEntityVariableRule> entities = null;
            Execute.Run( session => 
            {
                entities = Execute.SelectAll<DocEntityVariableRule>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new VariableRuleFullTextSearch(request);
                    entities = GetFullTextSearch<DocEntityVariableRule,VariableRuleFullTextSearch>(fts, entities);
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
                if(true == request.Archived?.Any() && currentUser.HasProperty(DocConstantModelName.VARIABLERULE, nameof(Reference.Archived), DocConstantPermission.VIEW))
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

                if(true == request.ChildrenIds?.Any())
                {
                    entities = entities.Where(en => en.Children.Any(r => r.Id.In(request.ChildrenIds)));
                }
                if(true == request.InstancesIds?.Any())
                {
                    entities = entities.Where(en => en.Instances.Any(r => r.Id.In(request.InstancesIds)));
                }
                if(!DocTools.IsNullOrEmpty(request.Name))
                    entities = entities.Where(en => en.Name.Contains(request.Name));
                if(!DocTools.IsNullOrEmpty(request.Owner) && !DocTools.IsNullOrEmpty(request.Owner.Id))
                {
                    entities = entities.Where(en => en.Owner.Id == request.Owner.Id );
                }
                if(true == request.OwnerIds?.Any())
                {
                    entities = entities.Where(en => en.Owner.Id.In(request.OwnerIds));
                }
                if(!DocTools.IsNullOrEmpty(request.Rule) && !DocTools.IsNullOrEmpty(request.Rule.Id))
                {
                    entities = entities.Where(en => en.Rule.Id == request.Rule.Id );
                }
                if(true == request.RuleIds?.Any())
                {
                    entities = entities.Where(en => en.Rule.Id.In(request.RuleIds));
                }
                else if(!DocTools.IsNullOrEmpty(request.Rule) && !DocTools.IsNullOrEmpty(request.Rule.Name))
                {
                    entities = entities.Where(en => en.Rule.Name == request.Rule.Name );
                }
                if(true == request.RuleNames?.Any())
                {
                    entities = entities.Where(en => en.Rule.Name.In(request.RuleNames));
                }
                if(true == request.ScopesIds?.Any())
                {
                    entities = entities.Where(en => en.Scopes.Any(r => r.Id.In(request.ScopesIds)));
                }
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

                entities = ApplyFilters<DocEntityVariableRule,VariableRuleSearch>(request, entities);

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

        public List<VariableRule> Post(VariableRuleSearch request) => Get(request);

        public List<VariableRule> Get(VariableRuleSearch request) => GetSearchResult<VariableRule,DocEntityVariableRule,VariableRuleSearch>(DocConstantModelName.VARIABLERULE, request, _ExecSearch);

        public VariableRule Get(VariableRule request) => GetEntity<VariableRule>(DocConstantModelName.VARIABLERULE, request, GetVariableRule);
        private VariableRule _AssignValues(VariableRule request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "VariableRule"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            VariableRule ret = null;
            request = _InitAssignValues<VariableRule>(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            var cacheKey = GetApiCacheKey<VariableRule>(DocConstantModelName.VARIABLERULE, nameof(VariableRule), request);
            
            //First, assign all the variables, do database lookups and conversions
            var pChildren = request.Children?.ToList();
            var pDefinition = request.Definition;
            var pInstances = request.Instances?.ToList();
            var pName = request.Name;
            var pOwner = (request.Owner?.Id > 0) ? DocEntityVariableRule.GetVariableRule(request.Owner.Id) : null;
            DocEntityLookupTable pRule = GetLookup(DocConstantLookupTable.VARIABLERULE, request.Rule?.Name, request.Rule?.Id);
            var pScopes = request.Scopes?.ToList();
            DocEntityLookupTable pType = GetLookup(DocConstantLookupTable.VARIABLETYPE, request.Type?.Name, request.Type?.Id);

            DocEntityVariableRule entity = null;
            if(permission == DocConstantPermission.ADD)
            {
                var now = DateTime.UtcNow;
                entity = new DocEntityVariableRule(session)
                {
                    Created = now,
                    Updated = now
                };
            }
            else
            {
                entity = DocEntityVariableRule.GetVariableRule(request.Id);
                if(null == entity)
                    throw new HttpError(HttpStatusCode.NotFound, $"No record");
            }

            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pDefinition, permission, DocConstantModelName.VARIABLERULE, nameof(request.Definition)))
            {
                if(DocPermissionFactory.IsRequested(request, pDefinition, entity.Definition, nameof(request.Definition)))
                    entity.Definition = pDefinition;
                if(DocPermissionFactory.IsRequested<string>(request, pDefinition, nameof(request.Definition)) && !request.VisibleFields.Matches(nameof(request.Definition), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Definition));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pName, permission, DocConstantModelName.VARIABLERULE, nameof(request.Name)))
            {
                if(DocPermissionFactory.IsRequested(request, pName, entity.Name, nameof(request.Name)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Name)} cannot be modified once set.");
                    entity.Name = pName;
                if(DocPermissionFactory.IsRequested<string>(request, pName, nameof(request.Name)) && !request.VisibleFields.Matches(nameof(request.Name), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Name));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityVariableRule>(currentUser, request, pOwner, permission, DocConstantModelName.VARIABLERULE, nameof(request.Owner)))
            {
                if(DocPermissionFactory.IsRequested(request, pOwner, entity.Owner, nameof(request.Owner)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Owner)} cannot be modified once set.");
                    entity.Owner = pOwner;
                if(DocPermissionFactory.IsRequested<DocEntityVariableRule>(request, pOwner, nameof(request.Owner)) && !request.VisibleFields.Matches(nameof(request.Owner), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Owner));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityLookupTable>(currentUser, request, pRule, permission, DocConstantModelName.VARIABLERULE, nameof(request.Rule)))
            {
                if(DocPermissionFactory.IsRequested(request, pRule, entity.Rule, nameof(request.Rule)))
                    entity.Rule = pRule;
                if(DocPermissionFactory.IsRequested<DocEntityLookupTable>(request, pRule, nameof(request.Rule)) && !request.VisibleFields.Matches(nameof(request.Rule), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Rule));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityLookupTable>(currentUser, request, pType, permission, DocConstantModelName.VARIABLERULE, nameof(request.Type)))
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
            
            if (DocPermissionFactory.IsRequestedHasPermission<List<Reference>>(currentUser, request, pChildren, permission, DocConstantModelName.VARIABLERULE, nameof(request.Children)))
            {
                if (true == pChildren?.Any() )
                {
                    var requestedChildren = pChildren.Select(p => p.Id).Distinct().ToList();
                    var existsChildren = Execute.SelectAll<DocEntityVariableRule>().Where(e => e.Id.In(requestedChildren)).Select( e => e.Id ).ToList();
                    if (existsChildren.Count != requestedChildren.Count)
                    {
                        var nonExists = requestedChildren.Where(id => existsChildren.All(eId => eId != id));
                        throw new HttpError(HttpStatusCode.NotFound, $"Cannot patch collection Children with objects that do not exist. No matching Children(s) could be found for Ids: {nonExists.ToDelimitedString()}.");
                    }
                    var toAdd = requestedChildren.Where(id => entity.Children.All(e => e.Id != id)).ToList(); 
                    toAdd?.ForEach(id =>
                    {
                        var target = DocEntityVariableRule.GetVariableRule(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD, targetEntity: target, targetName: nameof(VariableRule), columnName: nameof(request.Children)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to add {nameof(request.Children)} to {nameof(VariableRule)}");
                        entity.Children.Add(target);
                    });
                    var toRemove = entity.Children.Where(e => requestedChildren.All(id => e.Id != id)).Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityVariableRule.GetVariableRule(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(VariableRule), columnName: nameof(request.Children)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Children)} from {nameof(VariableRule)}");
                        entity.Children.Remove(target);
                    });
                }
                else
                {
                    var toRemove = entity.Children.Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityVariableRule.GetVariableRule(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(VariableRule), columnName: nameof(request.Children)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Children)} from {nameof(VariableRule)}");
                        entity.Children.Remove(target);
                    });
                }
                if(DocPermissionFactory.IsRequested<List<Reference>>(request, pChildren, nameof(request.Children)) && !request.VisibleFields.Matches(nameof(request.Children), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Children));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<List<Reference>>(currentUser, request, pInstances, permission, DocConstantModelName.VARIABLERULE, nameof(request.Instances)))
            {
                if (true == pInstances?.Any() )
                {
                    var requestedInstances = pInstances.Select(p => p.Id).Distinct().ToList();
                    var existsInstances = Execute.SelectAll<DocEntityVariableInstance>().Where(e => e.Id.In(requestedInstances)).Select( e => e.Id ).ToList();
                    if (existsInstances.Count != requestedInstances.Count)
                    {
                        var nonExists = requestedInstances.Where(id => existsInstances.All(eId => eId != id));
                        throw new HttpError(HttpStatusCode.NotFound, $"Cannot patch collection Instances with objects that do not exist. No matching Instances(s) could be found for Ids: {nonExists.ToDelimitedString()}.");
                    }
                    var toAdd = requestedInstances.Where(id => entity.Instances.All(e => e.Id != id)).ToList(); 
                    toAdd?.ForEach(id =>
                    {
                        var target = DocEntityVariableInstance.GetVariableInstance(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD, targetEntity: target, targetName: nameof(VariableRule), columnName: nameof(request.Instances)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to add {nameof(request.Instances)} to {nameof(VariableRule)}");
                        entity.Instances.Add(target);
                    });
                    var toRemove = entity.Instances.Where(e => requestedInstances.All(id => e.Id != id)).Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityVariableInstance.GetVariableInstance(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(VariableRule), columnName: nameof(request.Instances)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Instances)} from {nameof(VariableRule)}");
                        entity.Instances.Remove(target);
                    });
                }
                else
                {
                    var toRemove = entity.Instances.Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityVariableInstance.GetVariableInstance(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(VariableRule), columnName: nameof(request.Instances)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Instances)} from {nameof(VariableRule)}");
                        entity.Instances.Remove(target);
                    });
                }
                if(DocPermissionFactory.IsRequested<List<Reference>>(request, pInstances, nameof(request.Instances)) && !request.VisibleFields.Matches(nameof(request.Instances), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Instances));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<List<Reference>>(currentUser, request, pScopes, permission, DocConstantModelName.VARIABLERULE, nameof(request.Scopes)))
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
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD, targetEntity: target, targetName: nameof(VariableRule), columnName: nameof(request.Scopes)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to add {nameof(request.Scopes)} to {nameof(VariableRule)}");
                        entity.Scopes.Add(target);
                    });
                    var toRemove = entity.Scopes.Where(e => requestedScopes.All(id => e.Id != id)).Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityScope.GetScope(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(VariableRule), columnName: nameof(request.Scopes)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Scopes)} from {nameof(VariableRule)}");
                        entity.Scopes.Remove(target);
                    });
                }
                else
                {
                    var toRemove = entity.Scopes.Select(e => e.Id).ToList(); 
                    toRemove.ForEach(id =>
                    {
                        var target = DocEntityScope.GetScope(id);
                        if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.REMOVE, targetEntity: target, targetName: nameof(VariableRule), columnName: nameof(request.Scopes)))
                            throw new HttpError(HttpStatusCode.Forbidden, "You do not have permission to remove {nameof(request.Scopes)} from {nameof(VariableRule)}");
                        entity.Scopes.Remove(target);
                    });
                }
                if(DocPermissionFactory.IsRequested<List<Reference>>(request, pScopes, nameof(request.Scopes)) && !request.VisibleFields.Matches(nameof(request.Scopes), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Scopes));
                }
            }
            DocPermissionFactory.SetVisibleFields<VariableRule>(currentUser, nameof(VariableRule), request.VisibleFields);
            ret = entity.ToDto();

            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.VARIABLERULE);

            return ret;
        }
        public VariableRule Post(VariableRule request)
        {
            if(request == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            VariableRule ret = null;

            Execute.Run(ssn =>
            {
                if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "VariableRule")) 
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                ret = _AssignValues(request, DocConstantPermission.ADD, ssn);
            });

            return ret;
        }
   
        public List<VariableRule> Post(VariableRuleBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<VariableRule>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Post(dto) as VariableRule;
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

        public VariableRule Post(VariableRuleCopy request)
        {
            VariableRule ret = null;
            Execute.Run(ssn =>
            {
                var entity = DocEntityVariableRule.GetVariableRule(request?.Id);
                if(null == entity) throw new HttpError(HttpStatusCode.NoContent, "The COPY request did not succeed.");
                if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");
                
                    var pChildren = entity.Children.ToList();
                    var pDefinition = entity.Definition;
                    var pInstances = entity.Instances.ToList();
                    var pName = entity.Name;
                    if(!DocTools.IsNullOrEmpty(pName))
                        pName += " (Copy)";
                    var pOwner = entity.Owner;
                    var pRule = entity.Rule;
                    var pScopes = entity.Scopes.ToList();
                    var pType = entity.Type;
                #region Custom Before copyVariableRule
                #endregion Custom Before copyVariableRule
                var copy = new DocEntityVariableRule(ssn)
                {
                    Hash = Guid.NewGuid()
                                , Definition = pDefinition
                                , Name = pName
                                , Owner = pOwner
                                , Rule = pRule
                                , Type = pType
                };
                            foreach(var item in pChildren)
                            {
                                entity.Children.Add(item);
                            }

                            foreach(var item in pInstances)
                            {
                                entity.Instances.Add(item);
                            }

                            foreach(var item in pScopes)
                            {
                                entity.Scopes.Add(item);
                            }

                #region Custom After copyVariableRule
                #endregion Custom After copyVariableRule
                copy.SaveChanges(DocConstantPermission.ADD);
                ret = copy.ToDto();
            });
            return ret;
        }

        public List<VariableRule> Put(VariableRuleBatch request)
        {
            return Patch(request);
        }

        public VariableRule Put(VariableRule request)
        {
            return Patch(request);
        }
        public List<VariableRule> Patch(VariableRuleBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<VariableRule>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Patch(dto) as VariableRule;
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

        public VariableRule Patch(VariableRule request)
        {
            if(true != (request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the VariableRule to patch.");
            
            request.VisibleFields = request.VisibleFields ?? new List<string>();
            
            VariableRule ret = null;
            Execute.Run(ssn =>
            {
                ret = _AssignValues(request, DocConstantPermission.EDIT, ssn);
            });
            return ret;
        }
        public void Delete(VariableRuleBatch request)
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

        public void Delete(VariableRule request)
        {
            Execute.Run(ssn =>
            {
                if(!(request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, $"No Id provided for delete.");

                DocCacheClient.RemoveSearch(DocConstantModelName.VARIABLERULE);
                DocCacheClient.RemoveById(request.Id);
                var en = DocEntityVariableRule.GetVariableRule(request?.Id);

                if(null == en) throw new HttpError(HttpStatusCode.NotFound, $"No VariableRule could be found for Id {request?.Id}.");
                if(en.IsRemoved) return;
                
                if(!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.DELETE))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have DELETE permission for this route.");
                
                en.Remove();
            });
        }

        public void Delete(VariableRuleSearch request)
        {
            var matches = Get(request) as List<VariableRule>;
            if(true != matches?.Any()) throw new HttpError(HttpStatusCode.NotFound, "No matches for request");

            Execute.Run(ssn =>
            {
                matches.ForEach(match =>
                {
                    Delete(match);
                });
            });
        }
        public object Get(VariableRuleJunction request) =>
            Execute.Run( s => 
            {
                switch(request.Junction.ToLower().TrimAndPruneSpaces())
                {
                    case "variablerule":
                        return GetJunctionSearchResult<VariableRule, DocEntityVariableRule, DocEntityVariableRule, VariableRule, VariableRuleSearch>((int)request.Id, DocConstantModelName.VARIABLERULE, "Children", request, (ss) => HostContext.ResolveService<VariableRuleService>(Request)?.Get(ss));
                    case "variableinstance":
                        return GetJunctionSearchResult<VariableRule, DocEntityVariableRule, DocEntityVariableInstance, VariableInstance, VariableInstanceSearch>((int)request.Id, DocConstantModelName.VARIABLEINSTANCE, "Instances", request, (ss) => HostContext.ResolveService<VariableInstanceService>(Request)?.Get(ss));
                    case "scope":
                        return GetJunctionSearchResult<VariableRule, DocEntityVariableRule, DocEntityScope, Scope, ScopeSearch>((int)request.Id, DocConstantModelName.SCOPE, "Scopes", request, (ss) => HostContext.ResolveService<ScopeService>(Request)?.Get(ss));
                    default:
                        throw new HttpError(HttpStatusCode.NotFound, $"Route for variablerule/{request.Id}/{request.Junction} was not found");
                }
            });
        public object Post(VariableRuleJunction request) =>
            Execute.Run( ssn =>
            {
                switch(request.Junction.ToLower().TrimAndPruneSpaces())
                {
                    case "variablerule":
                        return AddJunction<VariableRule, DocEntityVariableRule, DocEntityVariableRule, VariableRule, VariableRuleSearch>((int)request.Id, DocConstantModelName.VARIABLERULE, "Children", request);
                    case "variableinstance":
                        return AddJunction<VariableRule, DocEntityVariableRule, DocEntityVariableInstance, VariableInstance, VariableInstanceSearch>((int)request.Id, DocConstantModelName.VARIABLEINSTANCE, "Instances", request);
                    case "scope":
                        return AddJunction<VariableRule, DocEntityVariableRule, DocEntityScope, Scope, ScopeSearch>((int)request.Id, DocConstantModelName.SCOPE, "Scopes", request);
                    default:
                        throw new HttpError(HttpStatusCode.NotFound, $"Route for variablerule/{request.Id}/{request.Junction} was not found");
                }
            });

        public object Delete(VariableRuleJunction request) =>
            Execute.Run( ssn =>
            {
                switch(request.Junction.ToLower().TrimAndPruneSpaces())
                {
                    case "variablerule":
                        return RemoveJunction<VariableRule, DocEntityVariableRule, DocEntityVariableRule, VariableRule, VariableRuleSearch>((int)request.Id, DocConstantModelName.VARIABLERULE, "Children", request);
                    case "variableinstance":
                        return RemoveJunction<VariableRule, DocEntityVariableRule, DocEntityVariableInstance, VariableInstance, VariableInstanceSearch>((int)request.Id, DocConstantModelName.VARIABLEINSTANCE, "Instances", request);
                    case "scope":
                        return RemoveJunction<VariableRule, DocEntityVariableRule, DocEntityScope, Scope, ScopeSearch>((int)request.Id, DocConstantModelName.SCOPE, "Scopes", request);
                    default:
                        throw new HttpError(HttpStatusCode.NotFound, $"Route for variablerule/{request.Id}/{request.Junction} was not found");
                }
            });
        private VariableRule GetVariableRule(VariableRule request)
        {
            var id = request?.Id;
            VariableRule ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetVisibleFields<VariableRule>(currentUser, "VariableRule", request.VisibleFields);

            DocEntityVariableRule entity = null;
            if(id.HasValue)
            {
                entity = DocEntityVariableRule.GetVariableRule(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No VariableRule found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }
    }
}