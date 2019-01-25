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
    public partial class UnitConversionRulesService : DocServiceBase
    {
        private IQueryable<DocEntityUnitConversionRules> _ExecSearch(UnitConversionRulesSearch request)
        {
            request = InitSearch<UnitConversionRules, UnitConversionRulesSearch>(request);
            IQueryable<DocEntityUnitConversionRules> entities = null;
            Execute.Run( session => 
            {
                entities = Execute.SelectAll<DocEntityUnitConversionRules>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new UnitConversionRulesFullTextSearch(request);
                    entities = GetFullTextSearch<DocEntityUnitConversionRules,UnitConversionRulesFullTextSearch>(fts, entities);
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

                if(!DocTools.IsNullOrEmpty(request.DestinationUnit) && !DocTools.IsNullOrEmpty(request.DestinationUnit.Id))
                {
                    entities = entities.Where(en => en.DestinationUnit.Id == request.DestinationUnit.Id );
                }
                if(true == request.DestinationUnitIds?.Any())
                {
                    entities = entities.Where(en => en.DestinationUnit.Id.In(request.DestinationUnitIds));
                }
                if(request.IsDefault.HasValue)
                    entities = entities.Where(en => request.IsDefault.Value == en.IsDefault);
                if(request.IsDestinationSi.HasValue)
                    entities = entities.Where(en => request.IsDestinationSi.Value == en.IsDestinationSi);
                if(!DocTools.IsNullOrEmpty(request.ModifierTerm) && !DocTools.IsNullOrEmpty(request.ModifierTerm.Id))
                {
                    entities = entities.Where(en => en.ModifierTerm.Id == request.ModifierTerm.Id );
                }
                if(true == request.ModifierTermIds?.Any())
                {
                    entities = entities.Where(en => en.ModifierTerm.Id.In(request.ModifierTermIds));
                }
                if(request.Multiplier.HasValue)
                    entities = entities.Where(en => request.Multiplier.Value == en.Multiplier);
                if(!DocTools.IsNullOrEmpty(request.Parent) && !DocTools.IsNullOrEmpty(request.Parent.Id))
                {
                    entities = entities.Where(en => en.Parent.Id == request.Parent.Id );
                }
                if(true == request.ParentIds?.Any())
                {
                    entities = entities.Where(en => en.Parent.Id.In(request.ParentIds));
                }
                else if(!DocTools.IsNullOrEmpty(request.Parent) && !DocTools.IsNullOrEmpty(request.Parent.Name))
                {
                    entities = entities.Where(en => en.Parent.Name == request.Parent.Name );
                }
                if(true == request.ParentNames?.Any())
                {
                    entities = entities.Where(en => en.Parent.Name.In(request.ParentNames));
                }
                if(!DocTools.IsNullOrEmpty(request.RootTerm) && !DocTools.IsNullOrEmpty(request.RootTerm.Id))
                {
                    entities = entities.Where(en => en.RootTerm.Id == request.RootTerm.Id );
                }
                if(true == request.RootTermIds?.Any())
                {
                    entities = entities.Where(en => en.RootTerm.Id.In(request.RootTermIds));
                }
                if(!DocTools.IsNullOrEmpty(request.SourceUnit) && !DocTools.IsNullOrEmpty(request.SourceUnit.Id))
                {
                    entities = entities.Where(en => en.SourceUnit.Id == request.SourceUnit.Id );
                }
                if(true == request.SourceUnitIds?.Any())
                {
                    entities = entities.Where(en => en.SourceUnit.Id.In(request.SourceUnitIds));
                }

                entities = ApplyFilters<DocEntityUnitConversionRules,UnitConversionRulesSearch>(request, entities);

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

        public object Post(UnitConversionRulesSearch request) => Get(request);

        public object Get(UnitConversionRulesSearch request) => GetSearchResultWithCache<UnitConversionRules,DocEntityUnitConversionRules,UnitConversionRulesSearch>(DocConstantModelName.UNITCONVERSIONRULES, request, _ExecSearch);

        public object Post(UnitConversionRulesVersion request) => Get(request);

        public object Get(UnitConversionRulesVersion request) 
        {
            List<Version> ret = null;
            Execute.Run(s=>
            {
                ret = _ExecSearch(request).Select(e => new Version(e.Id, e.VersionNo)).ToList();
            });
            return ret;
        }

        public object Get(UnitConversionRules request) => GetEntityWithCache<UnitConversionRules>(DocConstantModelName.UNITCONVERSIONRULES, request, GetUnitConversionRules);
        private UnitConversionRules _AssignValues(UnitConversionRules request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "UnitConversionRules"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            UnitConversionRules ret = null;
            request = _InitAssignValues<UnitConversionRules>(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            var cacheKey = GetApiCacheKey<UnitConversionRules>(DocConstantModelName.UNITCONVERSIONRULES, nameof(UnitConversionRules), request);
            
            //First, assign all the variables, do database lookups and conversions
            var pDestinationUnit = (request.DestinationUnit?.Id > 0) ? DocEntityUnitOfMeasure.GetUnitOfMeasure(request.DestinationUnit.Id) : null;
            var pIsDefault = request.IsDefault;
            var pIsDestinationSi = request.IsDestinationSi;
            var pModifierTerm = (request.ModifierTerm?.Id > 0) ? DocEntityTermMaster.GetTermMaster(request.ModifierTerm.Id) : null;
            var pMultiplier = request.Multiplier;
            DocEntityLookupTable pParent = GetLookup(DocConstantLookupTable.UNITCONVERSIONRULEPARENT, request.Parent?.Name, request.Parent?.Id);
            var pRootTerm = (request.RootTerm?.Id > 0) ? DocEntityTermMaster.GetTermMaster(request.RootTerm.Id) : null;
            var pSourceUnit = (request.SourceUnit?.Id > 0) ? DocEntityUnitOfMeasure.GetUnitOfMeasure(request.SourceUnit.Id) : null;

            DocEntityUnitConversionRules entity = null;
            if(permission == DocConstantPermission.ADD)
            {
                var now = DateTime.UtcNow;
                entity = new DocEntityUnitConversionRules(session)
                {
                    Created = now,
                    Updated = now
                };
            }
            else
            {
                entity = DocEntityUnitConversionRules.GetUnitConversionRules(request.Id);
                if(null == entity)
                    throw new HttpError(HttpStatusCode.NotFound, $"No record");
            }

            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityUnitOfMeasure>(currentUser, request, pDestinationUnit, permission, DocConstantModelName.UNITCONVERSIONRULES, nameof(request.DestinationUnit)))
            {
                if(DocPermissionFactory.IsRequested(request, pDestinationUnit, entity.DestinationUnit, nameof(request.DestinationUnit)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.DestinationUnit)} cannot be modified once set.");
                    entity.DestinationUnit = pDestinationUnit;
                if(DocPermissionFactory.IsRequested<DocEntityUnitOfMeasure>(request, pDestinationUnit, nameof(request.DestinationUnit)) && !request.VisibleFields.Matches(nameof(request.DestinationUnit), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.DestinationUnit));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<bool>(currentUser, request, pIsDefault, permission, DocConstantModelName.UNITCONVERSIONRULES, nameof(request.IsDefault)))
            {
                if(DocPermissionFactory.IsRequested(request, pIsDefault, entity.IsDefault, nameof(request.IsDefault)))
                    entity.IsDefault = pIsDefault;
                if(DocPermissionFactory.IsRequested<bool>(request, pIsDefault, nameof(request.IsDefault)) && !request.VisibleFields.Matches(nameof(request.IsDefault), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.IsDefault));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<bool>(currentUser, request, pIsDestinationSi, permission, DocConstantModelName.UNITCONVERSIONRULES, nameof(request.IsDestinationSi)))
            {
                if(DocPermissionFactory.IsRequested(request, pIsDestinationSi, entity.IsDestinationSi, nameof(request.IsDestinationSi)))
                    entity.IsDestinationSi = pIsDestinationSi;
                if(DocPermissionFactory.IsRequested<bool>(request, pIsDestinationSi, nameof(request.IsDestinationSi)) && !request.VisibleFields.Matches(nameof(request.IsDestinationSi), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.IsDestinationSi));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityTermMaster>(currentUser, request, pModifierTerm, permission, DocConstantModelName.UNITCONVERSIONRULES, nameof(request.ModifierTerm)))
            {
                if(DocPermissionFactory.IsRequested(request, pModifierTerm, entity.ModifierTerm, nameof(request.ModifierTerm)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.ModifierTerm)} cannot be modified once set.");
                    entity.ModifierTerm = pModifierTerm;
                if(DocPermissionFactory.IsRequested<DocEntityTermMaster>(request, pModifierTerm, nameof(request.ModifierTerm)) && !request.VisibleFields.Matches(nameof(request.ModifierTerm), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.ModifierTerm));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<decimal>(currentUser, request, pMultiplier, permission, DocConstantModelName.UNITCONVERSIONRULES, nameof(request.Multiplier)))
            {
                if(DocPermissionFactory.IsRequested(request, pMultiplier, entity.Multiplier, nameof(request.Multiplier)))
                    entity.Multiplier = pMultiplier;
                if(DocPermissionFactory.IsRequested<decimal>(request, pMultiplier, nameof(request.Multiplier)) && !request.VisibleFields.Matches(nameof(request.Multiplier), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Multiplier));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityLookupTable>(currentUser, request, pParent, permission, DocConstantModelName.UNITCONVERSIONRULES, nameof(request.Parent)))
            {
                if(DocPermissionFactory.IsRequested(request, pParent, entity.Parent, nameof(request.Parent)))
                    entity.Parent = pParent;
                if(DocPermissionFactory.IsRequested<DocEntityLookupTable>(request, pParent, nameof(request.Parent)) && !request.VisibleFields.Matches(nameof(request.Parent), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.Parent));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityTermMaster>(currentUser, request, pRootTerm, permission, DocConstantModelName.UNITCONVERSIONRULES, nameof(request.RootTerm)))
            {
                if(DocPermissionFactory.IsRequested(request, pRootTerm, entity.RootTerm, nameof(request.RootTerm)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.RootTerm)} cannot be modified once set.");
                    entity.RootTerm = pRootTerm;
                if(DocPermissionFactory.IsRequested<DocEntityTermMaster>(request, pRootTerm, nameof(request.RootTerm)) && !request.VisibleFields.Matches(nameof(request.RootTerm), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.RootTerm));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityUnitOfMeasure>(currentUser, request, pSourceUnit, permission, DocConstantModelName.UNITCONVERSIONRULES, nameof(request.SourceUnit)))
            {
                if(DocPermissionFactory.IsRequested(request, pSourceUnit, entity.SourceUnit, nameof(request.SourceUnit)))
                    if (DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.SourceUnit)} cannot be modified once set.");
                    entity.SourceUnit = pSourceUnit;
                if(DocPermissionFactory.IsRequested<DocEntityUnitOfMeasure>(request, pSourceUnit, nameof(request.SourceUnit)) && !request.VisibleFields.Matches(nameof(request.SourceUnit), ignoreSpaces: true))
                {
                    request.VisibleFields.Add(nameof(request.SourceUnit));
                }
            }
            
            if (request.Locked) entity.Locked = request.Locked;

            entity.SaveChanges(permission);
            
            DocPermissionFactory.SetVisibleFields<UnitConversionRules>(currentUser, nameof(UnitConversionRules), request.VisibleFields);
            ret = entity.ToDto();

            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.UNITCONVERSIONRULES);

            return ret;
        }
        public UnitConversionRules Post(UnitConversionRules request)
        {
            if(request == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            request.VisibleFields = request.VisibleFields ?? new List<string>();

            UnitConversionRules ret = null;

            Execute.Run(ssn =>
            {
                if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "UnitConversionRules")) 
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                ret = _AssignValues(request, DocConstantPermission.ADD, ssn);
            });

            return ret;
        }
   
        public List<UnitConversionRules> Post(UnitConversionRulesBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<UnitConversionRules>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Post(dto) as UnitConversionRules;
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

        public UnitConversionRules Post(UnitConversionRulesCopy request)
        {
            UnitConversionRules ret = null;
            Execute.Run(ssn =>
            {
                var entity = DocEntityUnitConversionRules.GetUnitConversionRules(request?.Id);
                if(null == entity) throw new HttpError(HttpStatusCode.NoContent, "The COPY request did not succeed.");
                if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");
                
                    var pDestinationUnit = entity.DestinationUnit;
                    var pIsDefault = entity.IsDefault;
                    var pIsDestinationSi = entity.IsDestinationSi;
                    var pModifierTerm = entity.ModifierTerm;
                    var pMultiplier = entity.Multiplier;
                    var pParent = entity.Parent;
                    var pRootTerm = entity.RootTerm;
                    var pSourceUnit = entity.SourceUnit;
                #region Custom Before copyUnitConversionRules
                #endregion Custom Before copyUnitConversionRules
                var copy = new DocEntityUnitConversionRules(ssn)
                {
                    Hash = Guid.NewGuid()
                                , DestinationUnit = pDestinationUnit
                                , IsDefault = pIsDefault
                                , IsDestinationSi = pIsDestinationSi
                                , ModifierTerm = pModifierTerm
                                , Multiplier = pMultiplier
                                , Parent = pParent
                                , RootTerm = pRootTerm
                                , SourceUnit = pSourceUnit
                };
                #region Custom After copyUnitConversionRules
                #endregion Custom After copyUnitConversionRules
                copy.SaveChanges(DocConstantPermission.ADD);
                ret = copy.ToDto();
            });
            return ret;
        }


        public List<UnitConversionRules> Put(UnitConversionRulesBatch request)
        {
            return Patch(request);
        }

        public UnitConversionRules Put(UnitConversionRules request)
        {
            return Patch(request);
        }

        public List<UnitConversionRules> Patch(UnitConversionRulesBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<UnitConversionRules>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Patch(dto) as UnitConversionRules;
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

        public UnitConversionRules Patch(UnitConversionRules request)
        {
            if(true != (request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the UnitConversionRules to patch.");
            
            request.VisibleFields = request.VisibleFields ?? new List<string>();
            
            UnitConversionRules ret = null;
            Execute.Run(ssn =>
            {
                ret = _AssignValues(request, DocConstantPermission.EDIT, ssn);
            });
            return ret;
        }

        public void Delete(UnitConversionRulesBatch request)
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

        public void Delete(UnitConversionRules request)
        {
            Execute.Run(ssn =>
            {
                if(!(request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, $"No Id provided for delete.");

                DocCacheClient.RemoveSearch(DocConstantModelName.UNITCONVERSIONRULES);
                DocCacheClient.RemoveById(request.Id);
                var en = DocEntityUnitConversionRules.GetUnitConversionRules(request?.Id);

                if(null == en) throw new HttpError(HttpStatusCode.NotFound, $"No UnitConversionRules could be found for Id {request?.Id}.");
                if(en.IsRemoved) return;
                
                if(!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.DELETE))
                    throw new HttpError(HttpStatusCode.Forbidden, "You do not have DELETE permission for this route.");
                
                en.Remove();
            });
        }

        public void Delete(UnitConversionRulesSearch request)
        {
            var matches = Get(request) as List<UnitConversionRules>;
            if(true != matches?.Any()) throw new HttpError(HttpStatusCode.NotFound, "No matches for request");

            Execute.Run(ssn =>
            {
                matches.ForEach(match =>
                {
                    Delete(match);
                });
            });
        }

        private UnitConversionRules GetUnitConversionRules(UnitConversionRules request)
        {
            var id = request?.Id;
            UnitConversionRules ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetVisibleFields<UnitConversionRules>(currentUser, "UnitConversionRules", request.VisibleFields);

            DocEntityUnitConversionRules entity = null;
            if(id.HasValue)
            {
                entity = DocEntityUnitConversionRules.GetUnitConversionRules(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No UnitConversionRules found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }

        public List<int> Any(UnitConversionRulesIds request)
        {
            List<int> ret = null;
            if (currentUser.IsSuperAdmin)
            {
                Execute.Run(s => { ret = Execute.SelectAll<DocEntityUnitConversionRules>().Select(d => d.Id).ToList(); });
            }
            else
            {
                throw new HttpError(HttpStatusCode.Forbidden);
            }

            return ret;
        }
    }
}