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
    public partial class ImportDataService : DocServiceBase
    {

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private IQueryable<DocEntityImportData> _ExecSearch(ImportDataSearch request, DocQuery query)
        {
            request = InitSearch<ImportData, ImportDataSearch>(request);
            IQueryable<DocEntityImportData> entities = null;
            query.Run( session => 
            {
                entities = query.SelectAll<DocEntityImportData>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new ImportDataFullTextSearch(request);
                    entities = GetFullTextSearch<DocEntityImportData,ImportDataFullTextSearch>(fts, entities);
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
                if(true == request.Archived?.Any() && currentUser.HasProperty(DocConstantModelName.IMPORTDATA, nameof(Reference.Archived), DocConstantPermission.VIEW))
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
                if(!DocTools.IsNullOrEmpty(request.CompletedOn))
                    entities = entities.Where(en => null != en.CompletedOn && request.CompletedOn.Value.Date == en.CompletedOn.Value.Date);
                if(!DocTools.IsNullOrEmpty(request.CompletedOnBefore))
                    entities = entities.Where(en => en.CompletedOn <= request.CompletedOnBefore);
                if(!DocTools.IsNullOrEmpty(request.CompletedOnAfter))
                    entities = entities.Where(en => en.CompletedOn >= request.CompletedOnAfter);
                if(true == request.DataSetsIds?.Any())
                {
                    entities = entities.Where(en => en.DataSets.Any(r => r.Id.In(request.DataSetsIds)));
                }
                if(!DocTools.IsNullOrEmpty(request.Document) && !DocTools.IsNullOrEmpty(request.Document.Id))
                {
                    entities = entities.Where(en => en.Document.Id == request.Document.Id );
                }
                if(true == request.DocumentIds?.Any())
                {
                    entities = entities.Where(en => en.Document.Id.In(request.DocumentIds));
                }
                if(!DocTools.IsNullOrEmpty(request.ErrorData))
                    entities = entities.Where(en => en.ErrorData.Contains(request.ErrorData));
                if(!DocTools.IsNullOrEmpty(request.ErrorDatas))
                    entities = entities.Where(en => en.ErrorData.In(request.ErrorDatas));
                if(!DocTools.IsNullOrEmpty(request.ExtractUrl))
                    entities = entities.Where(en => en.ExtractUrl.Contains(request.ExtractUrl));
                if(!DocTools.IsNullOrEmpty(request.ExtractUrls))
                    entities = entities.Where(en => en.ExtractUrl.In(request.ExtractUrls));
                if(true == request.HighPriority?.Any())
                {
                    entities = entities.Where(en => en.HighPriority.In(request.HighPriority));
                }
                if(true == request.ImportFr?.Any())
                {
                    entities = entities.Where(en => en.ImportFr.In(request.ImportFr));
                }
                if(!DocTools.IsNullOrEmpty(request.ImportLocation) && !DocTools.IsNullOrEmpty(request.ImportLocation.Id))
                {
                    entities = entities.Where(en => en.ImportLocation.Id == request.ImportLocation.Id );
                }
                if(true == request.ImportLocationIds?.Any())
                {
                    entities = entities.Where(en => en.ImportLocation.Id.In(request.ImportLocationIds));
                }
                else if(!DocTools.IsNullOrEmpty(request.ImportLocation) && !DocTools.IsNullOrEmpty(request.ImportLocation.Name))
                {
                    entities = entities.Where(en => en.ImportLocation.Name == request.ImportLocation.Name );
                }
                if(true == request.ImportLocationNames?.Any())
                {
                    entities = entities.Where(en => en.ImportLocation.Name.In(request.ImportLocationNames));
                }
                if(true == request.ImportNewName?.Any())
                {
                    entities = entities.Where(en => en.ImportNewName.In(request.ImportNewName));
                }
                if(true == request.ImportTable?.Any())
                {
                    entities = entities.Where(en => en.ImportTable.In(request.ImportTable));
                }
                if(true == request.ImportText?.Any())
                {
                    entities = entities.Where(en => en.ImportText.In(request.ImportText));
                }
                if(!DocTools.IsNullOrEmpty(request.ImportType) && !DocTools.IsNullOrEmpty(request.ImportType.Id))
                {
                    entities = entities.Where(en => en.ImportType.Id == request.ImportType.Id );
                }
                if(true == request.ImportTypeIds?.Any())
                {
                    entities = entities.Where(en => en.ImportType.Id.In(request.ImportTypeIds));
                }
                else if(!DocTools.IsNullOrEmpty(request.ImportType) && !DocTools.IsNullOrEmpty(request.ImportType.Name))
                {
                    entities = entities.Where(en => en.ImportType.Name == request.ImportType.Name );
                }
                if(true == request.ImportTypeNames?.Any())
                {
                    entities = entities.Where(en => en.ImportType.Name.In(request.ImportTypeNames));
                }
                if(true == request.IsLegacy?.Any())
                {
                    entities = entities.Where(en => en.IsLegacy.In(request.IsLegacy));
                }
                if(request.Order.HasValue)
                    entities = entities.Where(en => request.Order.Value == en.Order);
                if(request.ReferenceId.HasValue)
                    entities = entities.Where(en => request.ReferenceId.Value == en.ReferenceId);
                if(!DocTools.IsNullOrEmpty(request.RequestedBy) && !DocTools.IsNullOrEmpty(request.RequestedBy.Id))
                {
                    entities = entities.Where(en => en.RequestedBy.Id == request.RequestedBy.Id );
                }
                if(true == request.RequestedByIds?.Any())
                {
                    entities = entities.Where(en => en.RequestedBy.Id.In(request.RequestedByIds));
                }
                if(!DocTools.IsNullOrEmpty(request.RequestedOn))
                    entities = entities.Where(en => null != en.RequestedOn && request.RequestedOn.Value.Date == en.RequestedOn.Value.Date);
                if(!DocTools.IsNullOrEmpty(request.RequestedOnBefore))
                    entities = entities.Where(en => en.RequestedOn <= request.RequestedOnBefore);
                if(!DocTools.IsNullOrEmpty(request.RequestedOnAfter))
                    entities = entities.Where(en => en.RequestedOn >= request.RequestedOnAfter);
                if(!DocTools.IsNullOrEmpty(request.StartedOn))
                    entities = entities.Where(en => null != en.StartedOn && request.StartedOn.Value.Date == en.StartedOn.Value.Date);
                if(!DocTools.IsNullOrEmpty(request.StartedOnBefore))
                    entities = entities.Where(en => en.StartedOn <= request.StartedOnBefore);
                if(!DocTools.IsNullOrEmpty(request.StartedOnAfter))
                    entities = entities.Where(en => en.StartedOn >= request.StartedOnAfter);
                if(!DocTools.IsNullOrEmpty(request.Status) && !DocTools.IsNullOrEmpty(request.Status.Id))
                {
                    entities = entities.Where(en => en.Status.Id == request.Status.Id );
                }
                if(true == request.StatusIds?.Any())
                {
                    entities = entities.Where(en => en.Status.Id.In(request.StatusIds));
                }
                else if(!DocTools.IsNullOrEmpty(request.Status) && !DocTools.IsNullOrEmpty(request.Status.Name))
                {
                    entities = entities.Where(en => en.Status.Name == request.Status.Name );
                }
                if(true == request.StatusNames?.Any())
                {
                    entities = entities.Where(en => en.Status.Name.In(request.StatusNames));
                }

                entities = ApplyFilters<DocEntityImportData,ImportDataSearch>(request, entities);

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
        public object Post(ImportDataSearch request) => Get(request);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Get(ImportDataSearch request) => GetSearchResultWithCache<ImportData,DocEntityImportData,ImportDataSearch>(DocConstantModelName.IMPORTDATA, request, _ExecSearch);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Get(ImportData request) => GetEntityWithCache<ImportData>(DocConstantModelName.IMPORTDATA, request, GetImportData);



        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private ImportData _AssignValues(ImportData request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "ImportData"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.Select = request.Select ?? new List<string>();

            ImportData ret = null;
            request = _InitAssignValues<ImportData>(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            var cacheKey = GetApiCacheKey<ImportData>(DocConstantModelName.IMPORTDATA, nameof(ImportData), request);
            
            //First, assign all the variables, do database lookups and conversions
            var pCompletedOn = request.CompletedOn;
            var pDataSets = GetVariable<Reference>(request, nameof(request.DataSets), request.DataSets?.ToList(), request.DataSetsIds?.ToList());
            var pDocument = (request.Document?.Id > 0) ? DocEntityDocument.Get(request.Document.Id) : null;
            var pErrorData = request.ErrorData;
            var pExtractUrl = request.ExtractUrl;
            var pHighPriority = request.HighPriority;
            var pImportFr = request.ImportFr;
            DocEntityLookupTable pImportLocation = GetLookup(DocConstantLookupTable.STUDYIMPORTLOCATION, request.ImportLocation?.Name, request.ImportLocation?.Id);
            var pImportNewName = request.ImportNewName;
            var pImportTable = request.ImportTable;
            var pImportText = request.ImportText;
            DocEntityLookupTable pImportType = GetLookup(DocConstantLookupTable.STUDYIMPORTTYPE, request.ImportType?.Name, request.ImportType?.Id);
            var pIsLegacy = request.IsLegacy;
            var pOrder = request.Order;
            var pReferenceId = request.ReferenceId;
            var pRequestedBy = (request.RequestedBy?.Id > 0) ? DocEntityUser.Get(request.RequestedBy.Id) : null;
            var pRequestedOn = request.RequestedOn;
            var pStartedOn = request.StartedOn;
            DocEntityLookupTable pStatus = GetLookup(DocConstantLookupTable.IMPORTSTATUS, request.Status?.Name, request.Status?.Id);
            var pArchived = true == request.Archived;
            var pLocked = request.Locked;

            var entity = InitEntity<DocEntityImportData,ImportData>(request, permission, session);

            if (AllowPatchValue<ImportData, bool>(request, DocConstantModelName.IMPORTDATA, pArchived, permission, nameof(request.Archived), pArchived != entity.Archived))
            {
                entity.Archived = pArchived;
            }
            if (AllowPatchValue<ImportData, DateTime?>(request, DocConstantModelName.IMPORTDATA, pCompletedOn, permission, nameof(request.CompletedOn), pCompletedOn != entity.CompletedOn))
            {
                entity.CompletedOn = pCompletedOn;
            }
            if (AllowPatchValue<ImportData, DocEntityDocument>(request, DocConstantModelName.IMPORTDATA, pDocument, permission, nameof(request.Document), pDocument != entity.Document))
            {
                entity.Document = pDocument;
            }
            if (AllowPatchValue<ImportData, string>(request, DocConstantModelName.IMPORTDATA, pErrorData, permission, nameof(request.ErrorData), pErrorData != entity.ErrorData))
            {
                entity.ErrorData = pErrorData;
            }
            if (AllowPatchValue<ImportData, string>(request, DocConstantModelName.IMPORTDATA, pExtractUrl, permission, nameof(request.ExtractUrl), pExtractUrl != entity.ExtractUrl))
            {
                entity.ExtractUrl = pExtractUrl;
            }
            if (AllowPatchValue<ImportData, bool>(request, DocConstantModelName.IMPORTDATA, pHighPriority, permission, nameof(request.HighPriority), pHighPriority != entity.HighPriority))
            {
                entity.HighPriority = pHighPriority;
            }
            if (AllowPatchValue<ImportData, bool>(request, DocConstantModelName.IMPORTDATA, pImportFr, permission, nameof(request.ImportFr), pImportFr != entity.ImportFr))
            {
                entity.ImportFr = pImportFr;
            }
            if (AllowPatchValue<ImportData, DocEntityLookupTable>(request, DocConstantModelName.IMPORTDATA, pImportLocation, permission, nameof(request.ImportLocation), pImportLocation != entity.ImportLocation))
            {
                entity.ImportLocation = pImportLocation;
            }
            if (AllowPatchValue<ImportData, bool>(request, DocConstantModelName.IMPORTDATA, pImportNewName, permission, nameof(request.ImportNewName), pImportNewName != entity.ImportNewName))
            {
                entity.ImportNewName = pImportNewName;
            }
            if (AllowPatchValue<ImportData, bool>(request, DocConstantModelName.IMPORTDATA, pImportTable, permission, nameof(request.ImportTable), pImportTable != entity.ImportTable))
            {
                entity.ImportTable = pImportTable;
            }
            if (AllowPatchValue<ImportData, bool>(request, DocConstantModelName.IMPORTDATA, pImportText, permission, nameof(request.ImportText), pImportText != entity.ImportText))
            {
                entity.ImportText = pImportText;
            }
            if (AllowPatchValue<ImportData, DocEntityLookupTable>(request, DocConstantModelName.IMPORTDATA, pImportType, permission, nameof(request.ImportType), pImportType != entity.ImportType))
            {
                entity.ImportType = pImportType;
            }
            if (AllowPatchValue<ImportData, bool>(request, DocConstantModelName.IMPORTDATA, pIsLegacy, permission, nameof(request.IsLegacy), pIsLegacy != entity.IsLegacy))
            {
                entity.IsLegacy = pIsLegacy;
            }
            if (AllowPatchValue<ImportData, int?>(request, DocConstantModelName.IMPORTDATA, pOrder, permission, nameof(request.Order), pOrder != entity.Order))
            {
                entity.Order = pOrder;
            }
            if (AllowPatchValue<ImportData, int?>(request, DocConstantModelName.IMPORTDATA, pReferenceId, permission, nameof(request.ReferenceId), pReferenceId != entity.ReferenceId))
            {
                if(null != pReferenceId) entity.ReferenceId = (int) pReferenceId;
            }
            if (AllowPatchValue<ImportData, DocEntityUser>(request, DocConstantModelName.IMPORTDATA, pRequestedBy, permission, nameof(request.RequestedBy), pRequestedBy != entity.RequestedBy))
            {
                entity.RequestedBy = pRequestedBy;
            }
            if (AllowPatchValue<ImportData, DateTime?>(request, DocConstantModelName.IMPORTDATA, pRequestedOn, permission, nameof(request.RequestedOn), pRequestedOn != entity.RequestedOn))
            {
                entity.RequestedOn = pRequestedOn;
            }
            if (AllowPatchValue<ImportData, DateTime?>(request, DocConstantModelName.IMPORTDATA, pStartedOn, permission, nameof(request.StartedOn), pStartedOn != entity.StartedOn))
            {
                entity.StartedOn = pStartedOn;
            }
            if (AllowPatchValue<ImportData, DocEntityLookupTable>(request, DocConstantModelName.IMPORTDATA, pStatus, permission, nameof(request.Status), pStatus != entity.Status))
            {
                entity.Status = pStatus;
            }
            if (request.Locked && AllowPatchValue<ImportData, bool>(request, DocConstantModelName.IMPORTDATA, pArchived, permission, nameof(request.Locked), pLocked != entity.Locked))
            {
                entity.Archived = pArchived;
            }
            entity.SaveChanges(permission);

            var idsToInvalidate = new List<int>();
            idsToInvalidate.AddRange(PatchCollection<ImportData, DocEntityImportData, Reference, DocEntityDataSet>(request, entity, pDataSets, permission, nameof(request.DataSets)));
            if (idsToInvalidate.Any())
            {
                idsToInvalidate.Add(entity.Id);
                DocCacheClient.RemoveByEntityIds(idsToInvalidate);
                DocCacheClient.RemoveSearch(DocConstantModelName.IMPORTDATA);
            }

            DocPermissionFactory.SetSelect<ImportData>(currentUser, nameof(ImportData), request.Select);
            ret = entity.ToDto();

            var cacheExpires = DocResources.Metadata.GetCacheExpiration(DocConstantModelName.IMPORTDATA);
            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.IMPORTDATA, cacheExpires);

            return ret;
        }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public ImportData Post(ImportData request)
        {
            if(request == null) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be null.");

            request.Select = request.Select ?? new List<string>();

            ImportData ret = null;

            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    if(!DocPermissionFactory.HasPermissionTryAdd(currentUser, "ImportData")) 
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                    ret = _AssignValues(request, DocConstantPermission.ADD, ssn);
                });
            }
            return ret;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<ImportData> Post(ImportDataBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<ImportData>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Post(dto) as ImportData;
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
        public ImportData Post(ImportDataCopy request)
        {
            ImportData ret = null;
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    var entity = DocEntityImportData.Get(request?.Id);
                    if(null == entity) throw new HttpError(HttpStatusCode.NoContent, "The COPY request did not succeed.");
                    if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.ADD))
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

                    var pCompletedOn = entity.CompletedOn;
                    var pDataSets = entity.DataSets.ToList();
                    var pDocument = entity.Document;
                    var pErrorData = entity.ErrorData;
                    var pExtractUrl = entity.ExtractUrl;
                    if(!DocTools.IsNullOrEmpty(pExtractUrl))
                        pExtractUrl += " (Copy)";
                    var pHighPriority = entity.HighPriority;
                    var pImportFr = entity.ImportFr;
                    var pImportLocation = entity.ImportLocation;
                    var pImportNewName = entity.ImportNewName;
                    var pImportTable = entity.ImportTable;
                    var pImportText = entity.ImportText;
                    var pImportType = entity.ImportType;
                    var pIsLegacy = entity.IsLegacy;
                    var pOrder = entity.Order;
                    var pReferenceId = entity.ReferenceId;
                    var pRequestedBy = entity.RequestedBy;
                    var pRequestedOn = entity.RequestedOn;
                    var pStartedOn = entity.StartedOn;
                    var pStatus = entity.Status;
                    var copy = new DocEntityImportData(ssn)
                    {
                        Hash = Guid.NewGuid()
                                , CompletedOn = pCompletedOn
                                , Document = pDocument
                                , ErrorData = pErrorData
                                , ExtractUrl = pExtractUrl
                                , HighPriority = pHighPriority
                                , ImportFr = pImportFr
                                , ImportLocation = pImportLocation
                                , ImportNewName = pImportNewName
                                , ImportTable = pImportTable
                                , ImportText = pImportText
                                , ImportType = pImportType
                                , IsLegacy = pIsLegacy
                                , Order = pOrder
                                , ReferenceId = pReferenceId
                                , RequestedBy = pRequestedBy
                                , RequestedOn = pRequestedOn
                                , StartedOn = pStartedOn
                                , Status = pStatus
                    };
                            foreach(var item in pDataSets)
                            {
                                entity.DataSets.Add(item);
                            }

                    copy.SaveChanges(DocConstantPermission.ADD);
                    ret = copy.ToDto();
                });
            }
            return ret;
        }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<ImportData> Put(ImportDataBatch request)
        {
            return Patch(request);
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public ImportData Put(ImportData request)
        {
            return Patch(request);
        }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<ImportData> Patch(ImportDataBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<ImportData>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Patch(dto) as ImportData;
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
        public ImportData Patch(ImportData request)
        {
            if(true != (request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the ImportData to patch.");
            
            request.Select = request.Select ?? new List<string>();
            
            ImportData ret = null;
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
        public void Delete(ImportDataBatch request)
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
        public void Delete(ImportData request)
        {
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    if(!(request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, $"No Id provided for delete.");

                    var en = DocEntityImportData.Get(request?.Id);
                    if(null == en) throw new HttpError(HttpStatusCode.NotFound, $"No ImportData could be found for Id {request?.Id}.");
                    if(en.IsRemoved) return;
                
                    if(!DocPermissionFactory.HasPermission(en, currentUser, DocConstantPermission.DELETE))
                        throw new HttpError(HttpStatusCode.Forbidden, "You do not have DELETE permission for this route.");
                
                    en.Remove();

                    DocCacheClient.RemoveSearch(DocConstantModelName.IMPORTDATA);
                    DocCacheClient.RemoveById(request.Id);
                });
            }
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public void Delete(ImportDataSearch request)
        {
            var matches = Get(request) as List<ImportData>;
            if(true != matches?.Any()) throw new HttpError(HttpStatusCode.NotFound, "No matches for request");
            matches.ForEach(match =>
            {
                Delete(match);
            });
        }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Get(ImportDataJunction request)
        {
            switch(request.Junction.ToLower().TrimAndPruneSpaces())
            {
                    case "comment":
                        return GetJunctionSearchResult<ImportData, DocEntityImportData, DocEntityComment, Comment, CommentSearch>((int)request.Id, DocConstantModelName.COMMENT, "Comments", request, (ss) => HostContext.ResolveService<CommentService>(Request)?.Get(ss));
                    case "dataset":
                        return GetJunctionSearchResult<ImportData, DocEntityImportData, DocEntityDataSet, DataSet, DataSetSearch>((int)request.Id, DocConstantModelName.DATASET, "DataSets", request, (ss) => HostContext.ResolveService<DataSetService>(Request)?.Get(ss));
                    case "favorite":
                        return GetJunctionSearchResult<ImportData, DocEntityImportData, DocEntityFavorite, Favorite, FavoriteSearch>((int)request.Id, DocConstantModelName.FAVORITE, "Favorites", request, (ss) => HostContext.ResolveService<FavoriteService>(Request)?.Get(ss));
                    case "tag":
                        return GetJunctionSearchResult<ImportData, DocEntityImportData, DocEntityTag, Tag, TagSearch>((int)request.Id, DocConstantModelName.TAG, "Tags", request, (ss) => HostContext.ResolveService<TagService>(Request)?.Get(ss));
                default:
                    throw new HttpError(HttpStatusCode.NotFound, $"Route for importdata/{request.Id}/{request.Junction} was not found");
            }
        }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Post(ImportDataJunction request)
        {
            switch(request.Junction.ToLower().TrimAndPruneSpaces())
            {
                    case "comment":
                        return AddJunction<ImportData, DocEntityImportData, DocEntityComment, Comment, CommentSearch>((int)request.Id, DocConstantModelName.COMMENT, "Comments", request);
                    case "dataset":
                        return AddJunction<ImportData, DocEntityImportData, DocEntityDataSet, DataSet, DataSetSearch>((int)request.Id, DocConstantModelName.DATASET, "DataSets", request);
                    case "favorite":
                        return AddJunction<ImportData, DocEntityImportData, DocEntityFavorite, Favorite, FavoriteSearch>((int)request.Id, DocConstantModelName.FAVORITE, "Favorites", request);
                    case "tag":
                        return AddJunction<ImportData, DocEntityImportData, DocEntityTag, Tag, TagSearch>((int)request.Id, DocConstantModelName.TAG, "Tags", request);
                default:
                    throw new HttpError(HttpStatusCode.NotFound, $"Route for importdata/{request.Id}/{request.Junction} was not found");
            }
        }

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Delete(ImportDataJunction request)
        {    
            switch(request.Junction.ToLower().TrimAndPruneSpaces())
            {
                    case "comment":
                        return RemoveJunction<ImportData, DocEntityImportData, DocEntityComment, Comment, CommentSearch>((int)request.Id, DocConstantModelName.COMMENT, "Comments", request);
                    case "dataset":
                        return RemoveJunction<ImportData, DocEntityImportData, DocEntityDataSet, DataSet, DataSetSearch>((int)request.Id, DocConstantModelName.DATASET, "DataSets", request);
                    case "favorite":
                        return RemoveJunction<ImportData, DocEntityImportData, DocEntityFavorite, Favorite, FavoriteSearch>((int)request.Id, DocConstantModelName.FAVORITE, "Favorites", request);
                    case "tag":
                        return RemoveJunction<ImportData, DocEntityImportData, DocEntityTag, Tag, TagSearch>((int)request.Id, DocConstantModelName.TAG, "Tags", request);
                default:
                    throw new HttpError(HttpStatusCode.NotFound, $"Route for importdata/{request.Id}/{request.Junction} was not found");
            }
        }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private ImportData GetImportData(ImportData request)
        {
            var id = request?.Id;
            ImportData ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetSelect<ImportData>(currentUser, "ImportData", request.Select);

            DocEntityImportData entity = null;
            if(id.HasValue)
            {
                entity = DocEntityImportData.Get(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No ImportData found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }

    }
}
