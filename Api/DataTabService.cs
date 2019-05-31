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
    public partial class DataTabService : DocServiceBase
    {
        private IQueryable<DocEntityDataTab> _ExecSearch(DataTabSearch request, DocQuery query)
        {
            request = InitSearch<DataTab, DataTabSearch>(request);
            IQueryable<DocEntityDataTab> entities = null;
            query.Run( session => 
            {
                entities = query.SelectAll<DocEntityDataTab>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new DataTabFullTextSearch(request);
                    entities = GetFullTextSearch<DocEntityDataTab,DataTabFullTextSearch>(fts, entities);
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
                if(true == request.Archived?.Any() && currentUser.HasProperty(DocConstantModelName.DATATAB, nameof(Reference.Archived), DocConstantPermission.VIEW))
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
                if(!DocTools.IsNullOrEmpty(request.Class) && !DocTools.IsNullOrEmpty(request.Class.Id))
                {
                    entities = entities.Where(en => en.Class.Id == request.Class.Id );
                }
                if(true == request.ClassIds?.Any())
                {
                    entities = entities.Where(en => en.Class.Id.In(request.ClassIds));
                }
                if(!DocTools.IsNullOrEmpty(request.Description))
                    entities = entities.Where(en => en.Description.Contains(request.Description));
                if(!DocTools.IsNullOrEmpty(request.Name))
                    entities = entities.Where(en => en.Name.Contains(request.Name));
                if(request.Order.HasValue)
                    entities = entities.Where(en => request.Order.Value == en.Order);

                entities = ApplyFilters<DocEntityDataTab,DataTabSearch>(request, entities);

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

        public object Post(DataTabSearch request) => Get(request);

        public object Get(DataTabSearch request) => GetSearchResultWithCache<DataTab,DocEntityDataTab,DataTabSearch>(DocConstantModelName.DATATAB, request, _ExecSearch);

        public object Get(DataTab request) => GetEntityWithCache<DataTab>(DocConstantModelName.DATATAB, request, GetDataTab);

        private DataTab _AssignValues(DataTab request, DocConstantPermission permission, Session session)
        {
            if(permission != DocConstantPermission.ADD && (request == null || request.Id <= 0))
                throw new HttpError(HttpStatusCode.NotFound, $"No record");

            if(permission == DocConstantPermission.ADD && !DocPermissionFactory.HasPermissionTryAdd(currentUser, "DataTab"))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have ADD permission for this route.");

            request.Select = request.Select ?? new List<string>();

            DataTab ret = null;
            request = _InitAssignValues<DataTab>(request, permission, session);
            //In case init assign handles create for us, return it
            if(permission == DocConstantPermission.ADD && request.Id > 0) return request;
            
            var cacheKey = GetApiCacheKey<DataTab>(DocConstantModelName.DATATAB, nameof(DataTab), request);
            
            //First, assign all the variables, do database lookups and conversions
            var pClass = (request.Class?.Id > 0) ? DocEntityDataClass.Get(request.Class.Id) : null;
            var pDescription = request.Description;
            var pName = request.Name;
            var pOrder = request.Order;

            DocEntityDataTab entity = null;
            if(permission == DocConstantPermission.ADD)
            {
                var now = DateTime.UtcNow;
                entity = new DocEntityDataTab(session)
                {
                    Created = now,
                    Updated = now
                };
            }
            else
            {
                entity = DocEntityDataTab.Get(request.Id);
                if(null == entity)
                    throw new HttpError(HttpStatusCode.NotFound, $"No record");
            }

            //Special case for Archived
            var pArchived = true == request.Archived;
            if (DocPermissionFactory.IsRequestedHasPermission<bool>(currentUser, request, pArchived, permission, DocConstantModelName.DATATAB, nameof(request.Archived)))
            {
                if(DocPermissionFactory.IsRequested(request, pArchived, entity.Archived, nameof(request.Archived)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.DATATAB, nameof(request.Archived)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Archived)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pArchived) && DocResources.Metadata.IsRequired(DocConstantModelName.DATATAB, nameof(request.Archived))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Archived)} requires a value.");
                    entity.Archived = pArchived;
                if(DocPermissionFactory.IsRequested<bool>(request, pArchived, nameof(request.Archived)) && !request.Select.Matches(nameof(request.Archived), ignoreSpaces: true))
                {
                    request.Select.Add(nameof(request.Archived));
                }
            }

            if (DocPermissionFactory.IsRequestedHasPermission<DocEntityDataClass>(currentUser, request, pClass, permission, DocConstantModelName.DATATAB, nameof(request.Class)))
            {
                if(DocPermissionFactory.IsRequested(request, pClass, entity.Class, nameof(request.Class)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.DATATAB, nameof(request.Class)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Class)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pClass) && DocResources.Metadata.IsRequired(DocConstantModelName.DATATAB, nameof(request.Class))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Class)} requires a value.");
                    entity.Class = pClass;
                if(DocPermissionFactory.IsRequested<DocEntityDataClass>(request, pClass, nameof(request.Class)) && !request.Select.Matches(nameof(request.Class), ignoreSpaces: true))
                {
                    request.Select.Add(nameof(request.Class));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pDescription, permission, DocConstantModelName.DATATAB, nameof(request.Description)))
            {
                if(DocPermissionFactory.IsRequested(request, pDescription, entity.Description, nameof(request.Description)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.DATATAB, nameof(request.Description)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Description)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pDescription) && DocResources.Metadata.IsRequired(DocConstantModelName.DATATAB, nameof(request.Description))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Description)} requires a value.");
                    entity.Description = pDescription;
                if(DocPermissionFactory.IsRequested<string>(request, pDescription, nameof(request.Description)) && !request.Select.Matches(nameof(request.Description), ignoreSpaces: true))
                {
                    request.Select.Add(nameof(request.Description));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<string>(currentUser, request, pName, permission, DocConstantModelName.DATATAB, nameof(request.Name)))
            {
                if(DocPermissionFactory.IsRequested(request, pName, entity.Name, nameof(request.Name)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.DATATAB, nameof(request.Name)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Name)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pName) && DocResources.Metadata.IsRequired(DocConstantModelName.DATATAB, nameof(request.Name))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Name)} requires a value.");
                    entity.Name = pName;
                if(DocPermissionFactory.IsRequested<string>(request, pName, nameof(request.Name)) && !request.Select.Matches(nameof(request.Name), ignoreSpaces: true))
                {
                    request.Select.Add(nameof(request.Name));
                }
            }
            if (DocPermissionFactory.IsRequestedHasPermission<int?>(currentUser, request, pOrder, permission, DocConstantModelName.DATATAB, nameof(request.Order)))
            {
                if(DocPermissionFactory.IsRequested(request, pOrder, entity.Order, nameof(request.Order)))
                    if (DocResources.Metadata.IsInsertOnly(DocConstantModelName.DATATAB, nameof(request.Order)) && DocConstantPermission.ADD != permission) throw new HttpError(HttpStatusCode.Forbidden, $"{nameof(request.Order)} cannot be modified once set.");
                    if (DocTools.IsNullOrEmpty(pOrder) && DocResources.Metadata.IsRequired(DocConstantModelName.DATATAB, nameof(request.Order))) throw new HttpError(HttpStatusCode.BadRequest, $"{nameof(request.Order)} requires a value.");
                    if(null != pOrder)
                        entity.Order = (int) pOrder;
                if(DocPermissionFactory.IsRequested<int?>(request, pOrder, nameof(request.Order)) && !request.Select.Matches(nameof(request.Order), ignoreSpaces: true))
                {
                    request.Select.Add(nameof(request.Order));
                }
            }

            if (request.Locked) entity.Locked = request.Locked;

            entity.SaveChanges(permission);


            DocPermissionFactory.SetSelect<DataTab>(currentUser, nameof(DataTab), request.Select);
            ret = entity.ToDto();

            var cacheExpires = DocResources.Metadata.GetCacheExpiration(DocConstantModelName.DATATAB);
            DocCacheClient.Set(key: cacheKey, value: ret, entityId: request.Id, entityType: DocConstantModelName.DATATAB, cacheExpires);

            return ret;
        }

        public List<DataTab> Put(DataTabBatch request)
        {
            return Patch(request);
        }

        public DataTab Put(DataTab request)
        {
            return Patch(request);
        }
        public List<DataTab> Patch(DataTabBatch request)
        {
            if(true != request?.Any()) throw new HttpError(HttpStatusCode.NotFound, "Request cannot be empty.");

            var ret = new List<DataTab>();
            var errors = new List<ResponseError>();
            var errorMap = new Dictionary<string, string>();
            var i = 0;
            request.ForEach(dto =>
            {
                try
                {
                    var obj = Patch(dto) as DataTab;
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

        public DataTab Patch(DataTab request)
        {
            if(true != (request?.Id > 0)) throw new HttpError(HttpStatusCode.NotFound, "Please specify a valid Id of the DataTab to patch.");
            
            request.Select = request.Select ?? new List<string>();
            
            DataTab ret = null;
            using(Execute)
            {
                Execute.Run(ssn =>
                {
                    ret = _AssignValues(request, DocConstantPermission.EDIT, ssn);
                });
            }
            return ret;
        }
        private DataTab GetDataTab(DataTab request)
        {
            var id = request?.Id;
            DataTab ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetSelect<DataTab>(currentUser, "DataTab", request.Select);

            DocEntityDataTab entity = null;
            if(id.HasValue)
            {
                entity = DocEntityDataTab.Get(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No DataTab found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }
    }
}
