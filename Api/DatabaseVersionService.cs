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
    public partial class DatabaseVersionService : DocServiceBase
    {
        private IQueryable<DocEntityDatabaseVersion> _ExecSearch(DatabaseVersionSearch request)
        {
            request = InitSearch(request);
            
            IQueryable<DocEntityDatabaseVersion> entities = null;
            
            DocPermissionFactory.SetVisibleFields<DatabaseVersion>(currentUser, "DatabaseVersion", request.VisibleFields);

            Execute.Run( session => 
            {
                entities = Execute.SelectAll<DocEntityDatabaseVersion>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new DatabaseVersionFullTextSearch(request);
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

                if(!DocTools.IsNullOrEmpty(request.Description))
                    entities = entities.Where(en => en.Description.Contains(request.Description));
                if(!DocTools.IsNullOrEmpty(request.Release))
                    entities = entities.Where(en => en.Release.Contains(request.Release));
                if(!DocTools.IsNullOrEmpty(request.VersionName))
                    entities = entities.Where(en => en.VersionName.Contains(request.VersionName));

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

        public List<DatabaseVersion> Post(DatabaseVersionSearch request) => Get(request);

        public List<DatabaseVersion> Get(DatabaseVersionSearch request) => GetSearchResult<DatabaseVersion,DocEntityDatabaseVersion,DatabaseVersionSearch>(DocConstantModelName.DATABASEVERSION, request, _ExecSearch);

        public object Post(DatabaseVersionVersion request) => Get(request);

        public object Get(DatabaseVersionVersion request) 
        {
            List<Version> ret = null;
            Execute.Run(s=>
            {
                ret = _ExecSearch(request).Select(e => new Version(e.Id, e.VersionNo)).ToList();
            });
            return ret;
        }

        public DatabaseVersion Get(DatabaseVersion request) => GetEntity<DatabaseVersion>(DocConstantModelName.DATABASEVERSION, request, GetDatabaseVersion);




        private DatabaseVersion GetDatabaseVersion(DatabaseVersion request)
        {
            var id = request?.Id;
            DatabaseVersion ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetVisibleFields<DatabaseVersion>(currentUser, "DatabaseVersion", request.VisibleFields);

            DocEntityDatabaseVersion entity = null;
            if(id.HasValue)
            {
                entity = DocEntityDatabaseVersion.GetDatabaseVersion(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No DatabaseVersion found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }

        public List<int> Any(DatabaseVersionIds request)
        {
            List<int> ret = null;
            if (currentUser.IsSuperAdmin)
            {
                Execute.Run(s => { ret = Execute.SelectAll<DocEntityDatabaseVersion>().Select(d => d.Id).ToList(); });
            }
            else
            {
                throw new HttpError(HttpStatusCode.Forbidden);
            }

            return ret;
        }
    }
}