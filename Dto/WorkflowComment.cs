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
using Services.Dto.internals;
using Services.Enums;
using Services.Models;
using Services.Schema;

using Typed;
using Typed.Bindings;
using Typed.Notifications;
using Services.Dto.Security;
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

using Xtensive.Orm;
using Xtensive.Orm.Model;

using Attribute = Services.Dto.Attribute;
using ValueType = Services.Dto.ValueType;

namespace Services.Dto
{
    public abstract partial class WorkflowCommentBase : Dto<WorkflowComment>
    {
        public WorkflowCommentBase() {}

        public WorkflowCommentBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public WorkflowCommentBase(int? id) : this(DocConvert.ToInt(id)) {}

        [ApiMember(Name = nameof(Children), Description = "WorkflowComment", IsRequired = false)]
        public List<Reference> Children { get; set; }
        public int? ChildrenCount { get; set; }


        [ApiMember(Name = nameof(Parent), Description = "WorkflowComment", IsRequired = false)]
        public Reference Parent { get; set; }
        [ApiMember(Name = nameof(ParentId), Description = "Primary Key of WorkflowComment", IsRequired = false)]
        public int? ParentId { get; set; }


        [ApiMember(Name = nameof(Text), Description = "string", IsRequired = false)]
        public string Text { get; set; }


        [ApiMember(Name = nameof(User), Description = "User", IsRequired = true)]
        public Reference User { get; set; }
        [ApiMember(Name = nameof(UserId), Description = "Primary Key of User", IsRequired = false)]
        public int? UserId { get; set; }


        [ApiMember(Name = nameof(Workflow), Description = "Workflow", IsRequired = true)]
        public Reference Workflow { get; set; }
        [ApiMember(Name = nameof(WorkflowId), Description = "Primary Key of Workflow", IsRequired = false)]
        public int? WorkflowId { get; set; }


    }

    [Route("/workflowcomment", "POST")]
    [Route("/workflowcomment/{Id}", "GET, PATCH, PUT, DELETE")]
    public partial class WorkflowComment : WorkflowCommentBase, IReturn<WorkflowComment>, IDto
    {
        public WorkflowComment()
        {
            _Constructor();
        }

        public WorkflowComment(int? id) : base(DocConvert.ToInt(id)) {}
        public WorkflowComment(int id) : base(id) {}
        
        #region Fields
        
        public bool? ShouldSerialize(string field)
        {
            if (IgnoredVisibleFields.Matches(field, true)) return false;
            var ret = MandatoryVisibleFields.Matches(field, true) || true == VisibleFields?.Matches(field, true);
            return ret;
        }

        public static List<string> Fields => DocTools.Fields<WorkflowComment>();

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Children),nameof(ChildrenCount),nameof(Created),nameof(CreatorId),nameof(Gestalt),nameof(Locked),nameof(Parent),nameof(ParentId),nameof(Text),nameof(Updated),nameof(User),nameof(UserId),nameof(VersionNo),nameof(Workflow),nameof(WorkflowId)})]
        public new List<string> VisibleFields
        {
            get
            {
                if(null == this) return new List<string>();
                if(null == _VisibleFields)
                {
                    _VisibleFields = DocWebSession.GetTypeVisibleFields(this);
                }
                return _VisibleFields;
            }
            set
            {
                var requested = value ?? new List<string>();
                var exists = requested.Where( r => Fields.Any( f => DocTools.AreEqual(r, f) ) ).ToList();
                _VisibleFields = DocPermissionFactory.SetVisibleFields<WorkflowComment>("WorkflowComment",exists);
            }
        }

        #endregion Fields
        private List<string> _collections = new List<string>
        {
            nameof(Children), nameof(ChildrenCount)
        };
        private List<string> collections { get { return _collections; } }
    }
    
    [Route("/WorkflowComment/{Id}/copy", "POST")]
    public partial class WorkflowCommentCopy : WorkflowComment {}
    public partial class WorkflowCommentSearchBase : Search<WorkflowComment>
    {
        public int? Id { get; set; }
        public List<int> ChildrenIds { get; set; }
        public Reference Parent { get; set; }
        public List<int> ParentIds { get; set; }
        public string Text { get; set; }
        public Reference User { get; set; }
        public List<int> UserIds { get; set; }
        public Reference Workflow { get; set; }
        public List<int> WorkflowIds { get; set; }
    }

    [Route("/workflowcomment", "GET")]
    [Route("/workflowcomment/version", "GET, POST")]
    [Route("/workflowcomment/search", "GET, POST, DELETE")]
    public partial class WorkflowCommentSearch : WorkflowCommentSearchBase
    {
    }

    public class WorkflowCommentFullTextSearch
    {
        public WorkflowCommentFullTextSearch() {}
        private WorkflowCommentSearch _request;
        public WorkflowCommentFullTextSearch(WorkflowCommentSearch request) => _request = request;

        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(WorkflowComment.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(WorkflowComment.Updated))); }

        public bool doChildren { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(WorkflowComment.Children))); }
        public bool doParent { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(WorkflowComment.Parent))); }
        public bool doText { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(WorkflowComment.Text))); }
        public bool doUser { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(WorkflowComment.User))); }
        public bool doWorkflow { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(WorkflowComment.Workflow))); }
    }

    [Route("/workflowcomment/batch", "DELETE, PATCH, POST, PUT")]
    public partial class WorkflowCommentBatch : List<WorkflowComment> { }

    [Route("/workflowcomment/{Id}/{Junction}/version", "GET, POST")]
    [Route("/workflowcomment/{Id}/{Junction}", "GET, POST, DELETE")]
    public class WorkflowCommentJunction : WorkflowCommentSearchBase {}


}