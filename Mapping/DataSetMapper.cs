//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated by a T4 template. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System.Collections.Generic;

using AutoMapper;

using Services.Core;
using Services.Dto;
namespace Services.Schema
{
    public partial class DataSetMapper : DocMapperBase
    {
        protected IMappingExpression<DocEntityDataSet,DataSet> _EntityToDto;
        protected IMappingExpression<DataSet,DocEntityDataSet> _DtoToEntity;

        public DataSetMapper()
        {
            CreateMap<DocEntitySet<DocEntityDataSet>,List<Reference>>()
                .ConvertUsing(s => s.ToReferences());
            CreateMap<DocEntityDataSet,Reference>()
                .ConstructUsing(s => null == s || !(s.Id > 0) ? null : s.ToReference());
            CreateMap<Reference,DocEntityDataSet>()
                .ForMember(dest => dest.Id, opt => opt.Condition(src => null != src && src.Id > 0))
                .ConstructUsing(c => DocEntityDataSet.Get(c));
            _EntityToDto = CreateMap<DocEntityDataSet,DataSet>()
                .ForMember(dest => dest.Created, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataSet>(c, "Created")))
                .ForMember(dest => dest.Updated, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataSet>(c, "Updated")))
                .ForMember(dest => dest.AdditionalCriteria, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataSet>(c, nameof(DocEntityDataSet.AdditionalCriteria))))
                .ForMember(dest => dest.Characteristics, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataSet>(c, nameof(DocEntityDataSet.Characteristics))))
                .ForMember(dest => dest.CharacteristicsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataSet>(c, nameof(DocEntityDataSet.CharacteristicsCount))))
                .ForMember(dest => dest.CharacteristicsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataSet>(c, nameof(DocEntityDataSet.CharacteristicsIds))))
                .ForMember(dest => dest.Comparators, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataSet>(c, nameof(DocEntityDataSet.Comparators))))
                .ForMember(dest => dest.ComparatorsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataSet>(c, nameof(DocEntityDataSet.ComparatorsCount))))
                .ForMember(dest => dest.ComparatorsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataSet>(c, nameof(DocEntityDataSet.ComparatorsIds))))
                .ForMember(dest => dest.DataCollection, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataSet>(c, nameof(DocEntityDataSet.DataCollection))))
                .ForMember(dest => dest.EvidencePortalId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataSet>(c, nameof(DocEntityDataSet.EvidencePortalId))))
                .ForMember(dest => dest.ExtractionProtocol, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataSet>(c, nameof(DocEntityDataSet.ExtractionProtocol))))
                .ForMember(dest => dest.FqId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataSet>(c, nameof(DocEntityDataSet.FqId))))
                .ForMember(dest => dest.FramedQuestionId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataSet>(c, nameof(DocEntityDataSet.FramedQuestionId))))
                .ForMember(dest => dest.GeneralScope, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataSet>(c, nameof(DocEntityDataSet.GeneralScope))))
                .ForMember(dest => dest.Imports, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataSet>(c, nameof(DocEntityDataSet.Imports))))
                .ForMember(dest => dest.ImportsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataSet>(c, nameof(DocEntityDataSet.ImportsCount))))
                .ForMember(dest => dest.ImportsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataSet>(c, nameof(DocEntityDataSet.ImportsIds))))
                .ForMember(dest => dest.Indications, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataSet>(c, nameof(DocEntityDataSet.Indications))))
                .ForMember(dest => dest.Interventions, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataSet>(c, nameof(DocEntityDataSet.Interventions))))
                .ForMember(dest => dest.InterventionsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataSet>(c, nameof(DocEntityDataSet.InterventionsCount))))
                .ForMember(dest => dest.InterventionsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataSet>(c, nameof(DocEntityDataSet.InterventionsIds))))
                .ForMember(dest => dest.Notes, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataSet>(c, nameof(DocEntityDataSet.Notes))))
                .ForMember(dest => dest.OriginalComparators, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataSet>(c, nameof(DocEntityDataSet.OriginalComparators))))
                .ForMember(dest => dest.OriginalDatabase, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataSet>(c, nameof(DocEntityDataSet.OriginalDatabase))))
                .ForMember(dest => dest.OriginalDesigns, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataSet>(c, nameof(DocEntityDataSet.OriginalDesigns))))
                .ForMember(dest => dest.OriginalInterventions, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataSet>(c, nameof(DocEntityDataSet.OriginalInterventions))))
                .ForMember(dest => dest.OriginalOutcomes, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataSet>(c, nameof(DocEntityDataSet.OriginalOutcomes))))
                .ForMember(dest => dest.Outcomes, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataSet>(c, nameof(DocEntityDataSet.Outcomes))))
                .ForMember(dest => dest.OutcomesCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataSet>(c, nameof(DocEntityDataSet.OutcomesCount))))
                .ForMember(dest => dest.OutcomesCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataSet>(c, nameof(DocEntityDataSet.OutcomesIds))))
                .ForMember(dest => dest.Participants, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataSet>(c, nameof(DocEntityDataSet.Participants))))
                .ForMember(dest => dest.PrismaWorkflow, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataSet>(c, nameof(DocEntityDataSet.PrismaWorkflow))))
                .ForMember(dest => dest.PrismaWorkflowId, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataSet>(c, nameof(DocEntityDataSet.PrismaWorkflowId))))
                .ForMember(dest => dest.Projects, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataSet>(c, nameof(DocEntityDataSet.Projects))))
                .ForMember(dest => dest.ProjectsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataSet>(c, nameof(DocEntityDataSet.ProjectsCount))))
                .ForMember(dest => dest.ProjectsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataSet>(c, nameof(DocEntityDataSet.ProjectsIds))))
                .ForMember(dest => dest.ShowEtw, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataSet>(c, nameof(DocEntityDataSet.ShowEtw))))
                .ForMember(dest => dest.ShowPublicationType, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataSet>(c, nameof(DocEntityDataSet.ShowPublicationType))))
                .ForMember(dest => dest.StudyDesigns, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataSet>(c, nameof(DocEntityDataSet.StudyDesigns))))
                .ForMember(dest => dest.StudyDesignsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataSet>(c, nameof(DocEntityDataSet.StudyDesignsCount))))
                .ForMember(dest => dest.StudyDesignsCount, opt => opt.PreCondition(c => DocMapperConfig.ShouldBeMapped<DataSet>(c, nameof(DocEntityDataSet.StudyDesignsIds))))
                .MaxDepth(2);
            _DtoToEntity = CreateMap<DataSet,DocEntityDataSet>()
                .MaxDepth(2);
            ApplyCustomMaps();
        }
    }
}
