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
using Typed.Security;
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
    public partial class ImpersonationService : DocServiceBase
    {
        public const string CACHE_KEY_PREFIX = DocEntityImpersonation.CACHE_KEY_PREFIX;
        private void _ExecSearch(ImpersonationSearch request, Action<IQueryable<DocEntityImpersonation>> callBack)
        {
            request = InitSearch(request);
            
            DocPermissionFactory.SetVisibleFields<Impersonation>(currentUser, "Impersonation", request.VisibleFields);

            var entities = Execute.SelectAll<DocEntityImpersonation>();
                if(!DocTools.IsNullOrEmpty(request.FullTextSearch))
                {
                    var fts = new ImpersonationFullTextSearch(request);
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

                if(!DocTools.IsNullOrEmpty(request.AuthenticatedUser) && !DocTools.IsNullOrEmpty(request.AuthenticatedUser.Id))
                {
                    entities = entities.Where(en => en.AuthenticatedUser.Id == request.AuthenticatedUser.Id );
                }
                if(true == request.AuthenticatedUserIds?.Any())
                {
                    entities = entities.Where(en => en.AuthenticatedUser.Id.In(request.AuthenticatedUserIds));
                }
                if(!DocTools.IsNullOrEmpty(request.ImpersonatedUser) && !DocTools.IsNullOrEmpty(request.ImpersonatedUser.Id))
                {
                    entities = entities.Where(en => en.ImpersonatedUser.Id == request.ImpersonatedUser.Id );
                }
                if(true == request.ImpersonatedUserIds?.Any())
                {
                    entities = entities.Where(en => en.ImpersonatedUser.Id.In(request.ImpersonatedUserIds));
                }
                if(!DocTools.IsNullOrEmpty(request.UserSession) && !DocTools.IsNullOrEmpty(request.UserSession.Id))
                {
                    entities = entities.Where(en => en.UserSession.Id == request.UserSession.Id );
                }
                if(true == request.UserSessionIds?.Any())
                {
                    entities = entities.Where(en => en.UserSession.Id.In(request.UserSessionIds));
                }

                entities = ApplyFilters(request, entities);

                if(request.Skip > 0)
                    entities = entities.Skip(request.Skip.Value);
                if(request.Take > 0)
                    entities = entities.Take(request.Take.Value);
                if(true == request?.OrderBy?.Any())
                    entities = entities.OrderBy(request.OrderBy);
                if(true == request?.OrderByDesc?.Any())
                    entities = entities.OrderByDescending(request.OrderByDesc);
            callBack?.Invoke(entities);
        }
        
        public object Post(ImpersonationSearch request)
        {
            object tryRet = null;
            Execute.Run(s =>
            {
                using (var cancellableRequest = base.Request.CreateCancellableRequest())
                {
                    var requestCancel = new DocRequestCancellation(HttpContext.Current.Response, cancellableRequest);
                    try 
                    {
                        var ret = new List<Impersonation>();
                        _ExecSearch(request, (entities) => entities.ConvertFromEntityList<DocEntityImpersonation,Impersonation>(ret, Execute, requestCancel));
                        tryRet = ret;
                    }
                    catch(Exception) { throw; }
                    finally
                    {
                        requestCancel?.CloseRequest();
                    }
                }
            });
            return tryRet;
        }

        public object Get(ImpersonationSearch request)
        {
            object tryRet = null;
            Execute.Run(s =>
            {
                using (var cancellableRequest = base.Request.CreateCancellableRequest())
                {
                    var requestCancel = new DocRequestCancellation(HttpContext.Current.Response, cancellableRequest);
                    try 
                    {
                        var ret = new List<Impersonation>();
                        _ExecSearch(request, (entities) => entities.ConvertFromEntityList<DocEntityImpersonation,Impersonation>(ret, Execute, requestCancel));
                        tryRet = ret;
                    }
                    catch(Exception) { throw; }
                    finally
                    {
                        requestCancel?.CloseRequest();
                    }
                }
            });
            return tryRet;
        }

        public object Post(ImpersonationVersion request) 
        {
            return Get(request);
        }

        public object Get(ImpersonationVersion request) 
        {
            var ret = new List<Version>();
            Execute.Run(s =>
            {
                _ExecSearch(request, (entities) => 
                {
                    ret = entities.Select(e => new Version(e.Id, e.VersionNo)).ToList();
                });
            });
            return ret;
        }

        public object Get(Impersonation request)
        {
            object ret = null;
            
            if(!(request.Id > 0))
                throw new HttpError(HttpStatusCode.NotFound, "Valid Id required.");

            Execute.Run(s =>
            {
                DocPermissionFactory.SetVisibleFields<Impersonation>(currentUser, "Impersonation", request.VisibleFields);
                ret = GetImpersonation(request);
            });
            return ret;
        }





        private Impersonation GetImpersonation(Impersonation request)
        {
            var id = request?.Id;
            Impersonation ret = null;
            var query = DocQuery.ActiveQuery ?? Execute;

            DocPermissionFactory.SetVisibleFields<Impersonation>(currentUser, "Impersonation", request.VisibleFields);

            DocEntityImpersonation entity = null;
            if(id.HasValue)
            {
                entity = DocEntityImpersonation.GetImpersonation(id.Value);
            }
            if(null == entity)
                throw new HttpError(HttpStatusCode.NotFound, $"No Impersonation found for Id {id.Value}");

            if(!DocPermissionFactory.HasPermission(entity, currentUser, DocConstantPermission.VIEW))
                throw new HttpError(HttpStatusCode.Forbidden, "You do not have VIEW permission for this route.");
            
            ret = entity?.ToDto();
            return ret;
        }

        public List<int> Any(ImpersonationIds request)
        {
            List<int> ret = null;
            if (currentUser.IsSuperAdmin)
            {
                Execute.Run(s => { ret = Execute.SelectAll<DocEntityImpersonation>().Select(d => d.Id).ToList(); });
            }
            else
            {
                throw new HttpError(HttpStatusCode.Forbidden);
            }
            return ret;
        }
    }
}