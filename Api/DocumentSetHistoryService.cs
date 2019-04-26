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
    public partial class DocumentSetHistoryService : DocServiceBase
    {
        private IQueryable<DocEntityDocumentSetHistory> _ExecSearch(DocumentSetHistorySearch request, DocQuery query)
        {
            request = InitSearch<DocumentSetHistory, DocumentSetHistorySearch>(request);
            IQueryable<DocEntityDocumentSetHistory> entities = null;
            query.Run( session => 
            {
                entities = query.SelectAll<DocEntityDocumentSetHistory>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new DocumentSetHistoryFullTextSearch(request);
                    entities = GetFullTextSearch<DocEntityDocumentSetHistory,DocumentSetHistoryFullTextSearch>(fts, entities);
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
                if(true == request.Archived?.Any() && currentUser.HasProperty(DocConstantModelName.DOCUMENTSETHISTORY, nameof(Reference.Archived), DocConstantPermission.VIEW))
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
                if(!DocTools.IsNullOrEmpty(request.DocumentSet) && !DocTools.IsNullOrEmpty(request.DocumentSet.Id))
                {
                    entities = entities.Where(en => en.DocumentSet.Id == request.DocumentSet.Id );
                }
                if(true == request.DocumentSetIds?.Any())
                {
                    entities = entities.Where(en => en.DocumentSet.Id.In(request.DocumentSetIds));
                }
                if(request.EvidencePortalID.HasValue)
                    entities = entities.Where(en => request.EvidencePortalID.Value == en.EvidencePortalID);
                if(request.FqId.HasValue)
                    entities = entities.Where(en => request.FqId.Value == en.FqId);
                if(request.StudyCount.HasValue)
                    entities = entities.Where(en => request.StudyCount.Value == en.StudyCount);
                if(request.StudyCountFQ.HasValue)
                    entities = entities.Where(en => request.StudyCountFQ.Value == en.StudyCountFQ);

                entities = ApplyFilters<DocEntityDocumentSetHistory,DocumentSetHistorySearch>(request, entities);

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

        public object Post(DocumentSetHistorySearch request) => Get(request);

        public object Get(DocumentSetHistorySearch request) => GetSearchResultWithCache<DocumentSetHistory,DocEntityDocumentSetHistory,DocumentSetHistorySearch>(DocConstantModelName.DOCUMENTSETHISTORY, request, _ExecSearch);

        public object Get(DocumentSetHistory request) => GetEntityWithCache<DocumentSetHistory>(DocConstantModelName.DOCUMENTSETHISTORY, request, GetDocumentSetHistory);

        private DocumentSetHistory GetDocumentSetHistory(DocumentSetHistory request)
        {
            var id = request?.Id;
            DocumentSetHistory ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetVisibleFields<DocumentSetHistory>(currentUser, "DocumentSetHistory", request.VisibleFields);

            DocEntityDocumentSetHistory entity = null;
            if(id.HasValue)
            {
                entity = DocEntityDocumentSetHistory.Get(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No DocumentSetHistory found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }
    }
}
