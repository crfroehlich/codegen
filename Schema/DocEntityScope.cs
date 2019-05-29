
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

namespace Services.Schema
{
    [TableMapping(DocConstantModelName.SCOPE)]
    public partial class DocEntityScope : DocEntityBase
    {
        private const string SCOPE_CACHE = "ScopeCache";
        public const string TABLE_NAME = DocConstantModelName.SCOPE;
        
        #region Constructor
        public DocEntityScope(Session session) : base(session) {}

        public DocEntityScope() : base(new DocDbSession(Xtensive.Orm.Session.Current)) {}
        #endregion Constructor

        #region VisibleFields

        protected override List<string> _visibleFields
        {
            get
            {
                if(null == __vf)
                {
                    __vf = DocWebSession.GetTypeVisibleFields(new Scope());
                }
                return __vf;
            }
        }

        #endregion VisibleFields

        #region Static Members
        public static DocEntityScope GetScope(Reference reference)
        {
            return (true == (reference?.Id > 0)) ? GetScope(reference.Id) : null;
        }

        public static DocEntityScope GetScope(int? primaryKey)
        {
            var query = DocQuery.ActiveQuery;
            if(null == primaryKey) return null;
            var ret = DocEntityThreadCache<DocEntityScope>.GetFromCache(primaryKey, SCOPE_CACHE);
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityScope>().Where(e => e.Id == primaryKey.Value).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityScope>.UpdateCache(ret.Id, ret, SCOPE_CACHE);
                    DocEntityThreadCache<DocEntityScope>.UpdateCache(ret.Hash, ret, SCOPE_CACHE);
                }
            }
            return ret;
        }

        public static DocEntityScope GetScope(Guid hash)
        {
            var query = DocQuery.ActiveQuery;
            var ret = DocEntityThreadCache<DocEntityScope>.GetFromCache(hash, SCOPE_CACHE);
            
            if(null == ret)
            {
                ret = query.SelectAll<DocEntityScope>().Where(e => e.Hash == hash).FirstOrDefault();
                if(null != ret) 
                {
                    DocEntityThreadCache<DocEntityScope>.UpdateCache(ret.Id, ret, SCOPE_CACHE);
                    DocEntityThreadCache<DocEntityScope>.UpdateCache(ret.Hash, ret, SCOPE_CACHE);
                }
            }
            return ret;
        }
        #endregion Static Members

        #region Properties
        [Field()]
        [FieldMapping(nameof(App))]
        public DocEntityApp App { get; set; }
        public int? AppId { get { return App?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Bindings))]
        [Association(PairTo = nameof(DocEntityLookupTableBinding.Scope), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityLookupTableBinding> Bindings { get; private set; }
        public List<int> BindingsIds => Bindings.Select(e => e.Id).ToList();




        public int? BindingsCount { get { return Bindings.Count(); } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Broadcasts))]
        [Association(PairTo = nameof(DocEntityBroadcast.Scopes), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityBroadcast> Broadcasts { get; private set; }
        public List<int> BroadcastsIds => Broadcasts.Select(e => e.Id).ToList();




        public int? BroadcastsCount { get { return Broadcasts.Count(); } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Client))]
        public DocEntityClient Client { get; set; }
        public int? ClientId { get { return Client?.Id; } private set { var noid = value; } }


        [Field(DefaultValue = false)]
        [FieldMapping(nameof(Delete))]
        public bool Delete { get; set; }


        [Field()]
        [FieldMapping(nameof(DocumentSet))]
        public DocEntityDocumentSet DocumentSet { get; set; }
        public int? DocumentSetId { get { return DocumentSet?.Id; } private set { var noid = value; } }


        [Field(DefaultValue = false)]
        [FieldMapping(nameof(Edit))]
        public bool Edit { get; set; }


        [Field()]
        [FieldMapping(nameof(Help))]
        [Association(PairTo = nameof(DocEntityHelp.Scopes), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityHelp> Help { get; private set; }
        public List<int> HelpIds => Help.Select(e => e.Id).ToList();




        public int? HelpCount { get { return Help.Count(); } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(IsGlobal))]
        public bool IsGlobal { get; set; }


        [Field()]
        [FieldMapping(nameof(Synonyms))]
        [Association(PairTo = nameof(DocEntityTermSynonym.Scope), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityTermSynonym> Synonyms { get; private set; }
        public List<int> SynonymsIds => Synonyms.Select(e => e.Id).ToList();




        public int? SynonymsCount { get { return Synonyms.Count(); } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(Team))]
        public DocEntityTeam Team { get; set; }
        public int? TeamId { get { return Team?.Id; } private set { var noid = value; } }


        [Field(Nullable = false)]
        [FieldMapping(nameof(Type))]
        public DocEntityLookupTable Type { get; set; }
        public int? TypeId { get { return Type?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(User))]
        public DocEntityUser User { get; set; }
        public int? UserId { get { return User?.Id; } private set { var noid = value; } }


        [Field()]
        [FieldMapping(nameof(VariableRules))]
        [Association(PairTo = nameof(DocEntityVariableRule.Scopes), OnOwnerRemove = OnRemoveAction.Clear, OnTargetRemove = OnRemoveAction.Clear)]
        public DocEntitySet<DocEntityVariableRule> VariableRules { get; private set; }
        public List<int> VariableRulesIds => VariableRules.Select(e => e.Id).ToList();




        public int? VariableRulesCount { get { return VariableRules.Count(); } private set { var noid = value; } }


        [Field(DefaultValue = true)]
        [FieldMapping(nameof(View))]
        public bool View { get; set; }


        [Field()]
        [FieldMapping(nameof(Workflows))]
        public DocEntitySet<DocEntityWorkflow> Workflows { get; private set; }
        public List<int> WorkflowsIds => Workflows.Select(e => e.Id).ToList();




        public int? WorkflowsCount { get { return Workflows.Count(); } private set { var noid = value; } }



        [Field(LazyLoad = false, Length = Int32.MaxValue)]
        public override string Gestalt { get; set; }

        [Field(DefaultValue = 0), Version(VersionMode.Manual)]
        public override int VersionNo { get; set; }

        [Field]
        public override DateTime? Created { get; set; }

        [Field]
        public override DateTime? Updated { get; set; }

        [Field(DefaultValue = false)]
        [FieldMapping(nameof(Locked))]
        public override bool Locked { get; set; }

        [Field(DefaultValue = false)]
        [FieldMapping(nameof(Archived))]
        public override bool Archived { get; set; }

        #endregion Properties

        #region Overrides of DocEntity

        public override DocConstantModelName TableName => TABLE_NAME;

        public const string CACHE_KEY_PREFIX = "FindScopes";

        #endregion Overrides of DocEntity

        #region Entity overrides
        /// <summary>
        ///    Called when entity is about to be removed.
        /// </summary>
        protected override void OnRemoving()
        {
            base.OnRemoving();

            FlushCache();
        }

        /// <summary>
        ///    Called when entity should be validated. Override this method to perform custom object validation.
        /// </summary>
        protected override void OnValidate()
        {
            if (false == ValidationMessage.IsValid)
            {
                throw new HttpError(HttpStatusCode.Conflict, $"Scope requires: {ValidationMessage.Message}.");
            }

            base.OnValidate();
            _validated = true;
        }

        public override IDocEntity SaveChanges(bool ignoreCache, DocConstantPermission permission)
        {

            return base.SaveChanges(ignoreCache, permission);
        }

        public override IDocEntity SaveChanges(bool ignoreCache) => SaveChanges(ignoreCache, DocConstantPermission.EDIT);
        public override IDocEntity SaveChanges(DocConstantPermission permission) => SaveChanges(false, DocConstantPermission.EDIT);
        public override IDocEntity SaveChanges() => SaveChanges(DocConstantPermission.EDIT);

        public override void FlushCache()
        {
            base.FlushCache();
            DocCacheClient.RemoveById(Id);
        }
        #endregion Entity overrides

        #region Validation
        public DocValidationMessage ValidationMessage
        {
            get
            {
                var isValid = true;
                var message = string.Empty;

                if(DocTools.IsNullOrEmpty(Type))
                {
                    isValid = false;
                    message += " Type is a required property.";
                }
                else
                {
                    if(Type.Enum?.Name != "Scope")
                    {
                        isValid = false;
                        message += " Type is a " + Type.Enum.Name + ", but must be a Scope.";
                    }
                }

                var ret = new DocValidationMessage(message, isValid);
                return ret;
            }
        }
        #endregion Validation

        #region Converters

        public Scope ToDto() => Mapper.Map<DocEntityScope, Scope>(this);

        public override IDto ToIDto() => ToDto();
        #endregion Converters
    }

    public static partial class UniqueConstraintFilter
    {
        public static Expression<Func<DocEntityScope, bool>> ScopeIgnoreArchived() => d => d.Archived == false;
    }

    public partial class ScopeMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityScope,Scope> _EntityToDto;
        protected IMappingExpression<Scope,DocEntityScope> _DtoToEntity;

        public ScopeMapper()
        {
            CreateMap<DocEntitySet<DocEntityScope>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityScope,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityScope>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityScope.GetScope(c));
            _EntityToDto = CreateMap<DocEntityScope,Scope>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, "Updated")))
                .ForMember(dest => dest.App, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.App))))
                .ForMember(dest => dest.AppId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.AppId))))
                .ForMember(dest => dest.Bindings, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.Bindings))))
                .ForMember(dest => dest.BindingsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.BindingsCount))))
                .ForMember(dest => dest.Broadcasts, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.Broadcasts))))
                .ForMember(dest => dest.BroadcastsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.BroadcastsCount))))
                .ForMember(dest => dest.Client, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.Client))))
                .ForMember(dest => dest.ClientId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.ClientId))))
                .ForMember(dest => dest.Delete, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.Delete))))
                .ForMember(dest => dest.DocumentSet, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.DocumentSet))))
                .ForMember(dest => dest.DocumentSetId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.DocumentSetId))))
                .ForMember(dest => dest.Edit, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.Edit))))
                .ForMember(dest => dest.Help, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.Help))))
                .ForMember(dest => dest.HelpCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.HelpCount))))
                .ForMember(dest => dest.IsGlobal, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.IsGlobal))))
                .ForMember(dest => dest.Synonyms, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.Synonyms))))
                .ForMember(dest => dest.SynonymsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.SynonymsCount))))
                .ForMember(dest => dest.Team, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.Team))))
                .ForMember(dest => dest.TeamId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.TeamId))))
                .ForMember(dest => dest.Type, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.Type))))
                .ForMember(dest => dest.TypeId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.TypeId))))
                .ForMember(dest => dest.User, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.User))))
                .ForMember(dest => dest.UserId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.UserId))))
                .ForMember(dest => dest.VariableRules, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.VariableRules))))
                .ForMember(dest => dest.VariableRulesCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.VariableRulesCount))))
                .ForMember(dest => dest.View, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.View))))
                .ForMember(dest => dest.Workflows, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.Workflows))))
                .ForMember(dest => dest.WorkflowsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<Scope>(c, nameof(DocEntityScope.WorkflowsCount))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<Scope,DocEntityScope>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
