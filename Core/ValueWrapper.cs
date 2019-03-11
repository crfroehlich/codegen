﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated by a CodeSmith Generator project.
//
//    This class can be customized by adding or removing code from supported Custom regions
//    (e.g. Custom Imports, Custom Region 1).
//
//    All other changes to this file will cause incorrect behavior and will be lost if
//    the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using AutoMapper;

using Services.Core;
using Services.Enums;
using Services.Models;

using System;

namespace Services.Dto
{
    /// <summary> A document property wrapper. </summary>
    public class ValueWrapper : Dto<Attribute>
    {
        public ValueWrapper() {}

        public ValueWrapper(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public ValueWrapper(int? id) : this(DocConvert.ToInt(id)) {}
    
        #region Properties

        public TypeMeanBase MeanBaseValue { get; set; }

        public string ValueType { get; set; }

        //public Attribute Attribute { get; set; }

        public SourceDocument Source { get; set; }

        public int Row { get; set; }

        public int Column { get; set; }

        public int? N { get; set; }

        public int Sequence { get; set; }

        public UnitOfMeasure Label { get; set; }

        public bool IsPropertySetValue { get; set; }

        public string ArmPopulation { get; set; }

		public string ArmPopulationType { get; set; }

        public TypeInterval CustomInterval { get; set; }

        public bool IsCrossover { get; set; }

        public bool NonSymmetricalCi { get; set; }

        public string Status { get; set; }

        public TypePValue WithinGroupPval { get; set; }

        public TypeAssociationMeasure AssociationMeasureValue{ get; set; }
        public TypeBoolean BooleanValue{ get; set; }
        public TypeCalendarDate CalendarDateValue{ get; set; }
        public TypeCalendarDates CalendarDatesValue{ get; set; }
        public TypeContact ContactValue{ get; set; }
        public TypeDateTime DateTimeValue{ get; set; }
        public TypeDateTimeRange DateTimeRangeValue{ get; set; }
        public TypeDecimal DecimalValue{ get; set; }
        public TypeDecimalRange DecimalRangeValue{ get; set; }
        public TypeDesignNestedStudyIdLink DesignNestedStudyIdLinkValue{ get; set; }
        public TypeEventCounts EventCountsValue{ get; set; }
        public TypeFacility FacilityValue{ get; set; }
        public TypeFixedDoseIntervention FixedDoseInterventionValue{ get; set; }
        public TypeFlag FlagValue{ get; set; }
        public TypeFunding FundingValue{ get; set; }
        public TypeInteger IntegerValue{ get; set; }
        public TypeInterval IntervalValue{ get; set; }
        public TypeIntervals IntervalsValue{ get; set; }
        public TypeLookup LookupValue{ get; set; }
        public TypeMemo MemoValue{ get; set; }
        public TypeNPersons NPersonsValue{ get; set; }
        public TypeParticipant ParticipantValue{ get; set; }
        public TypeParticipants ParticipantsValue{ get; set; }
        public TypePopulationAnalyzed PopulationAnalyzedValue{ get; set; }
        public TypePValue PValueValue{ get; set; }
        public TypeRate RateValue{ get; set; }
        public TypeSettingLocation SettingLocationValue{ get; set; }
        public TypeSettingLocationTotal SettingLocationTotalValue{ get; set; }
        public TypeStudyDoc StudyDocValue{ get; set; }
        public TypeStudyObjective StudyObjectiveValue{ get; set; }
        public TypeStudyReference StudyReferenceValue{ get; set; }
        public TypeSubgroupDescriptor SubgroupDescriptorValue{ get; set; }
        public TypeTimepoint TimepointValue{ get; set; }
        public TypeTimepoints TimepointsValue{ get; set; }
        public TypeUncollectedValue UncollectedValueValue{ get; set; }
        public TypeUnitRange UnitRangeValue{ get; set; }
        public TypeUnits UnitsValue{ get; set; }
        public TypeUnitsRange UnitsRangeValue{ get; set; }
        public TypeUnitValue UnitValueValue{ get; set; }
        public TypeYesNoNa YesNoNaValue{ get; set; }

        public IDocType GetValue()
        {
            IDocType ret=null;
            switch (ValueType)
            {
                case DocConstantValueType.ASSOCIATIONMEASURE:
                    ret = Mapper.Map<TypeAssociationMeasure, DocTypeAssociationMeasure>(AssociationMeasureValue);
                    break;
                case DocConstantValueType.BOOLEAN:
                    ret = Mapper.Map<TypeBoolean, DocTypeBoolean>(BooleanValue);
                    break;
                case DocConstantValueType.CALENDARDATE:
                    ret = Mapper.Map<TypeCalendarDate, DocTypeCalendarDate>(CalendarDateValue);
                    break;
                case DocConstantValueType.CALENDARDATES:
                    ret = Mapper.Map<TypeCalendarDates, DocTypeCalendarDates>(CalendarDatesValue);
                    break;
                case DocConstantValueType.CONTACT:
                    ret = Mapper.Map<TypeContact, DocTypeContact>(ContactValue);
                    break;
                case DocConstantValueType.DATETIME:
                    ret = Mapper.Map<TypeDateTime, DocTypeDateTime>(DateTimeValue);
                    break;
                case DocConstantValueType.DATETIMERANGE:
                    ret = Mapper.Map<TypeDateTimeRange, DocTypeDateTimeRange>(DateTimeRangeValue);
                    break;
                case DocConstantValueType.DECIMAL:
                    ret = Mapper.Map<TypeDecimal, DocTypeDecimal>(DecimalValue);
                    break;
                case DocConstantValueType.DECIMALRANGE:
                    ret = Mapper.Map<TypeDecimalRange, DocTypeDecimalRange>(DecimalRangeValue);
                    break;
                case DocConstantValueType.DESIGNNESTEDSTUDYIDLINK:
                    ret = Mapper.Map<TypeDesignNestedStudyIdLink, DocTypeDesignNestedStudyIdLink>(DesignNestedStudyIdLinkValue);
                    break;
                case DocConstantValueType.EVENTCOUNTS:
                    ret = Mapper.Map<TypeEventCounts, DocTypeEventCounts>(EventCountsValue);
                    break;
                case DocConstantValueType.FACILITY:
                    ret = Mapper.Map<TypeFacility, DocTypeFacility>(FacilityValue);
                    break;
                case DocConstantValueType.FIXEDDOSEINTERVENTION:
                    ret = Mapper.Map<TypeFixedDoseIntervention, DocTypeFixedDoseIntervention>(FixedDoseInterventionValue);
                    break;
                case DocConstantValueType.FLAG:
                    ret = Mapper.Map<TypeFlag, DocTypeFlag>(FlagValue);
                    break;
                case DocConstantValueType.FUNDING:
                    ret = Mapper.Map<TypeFunding, DocTypeFunding>(FundingValue);
                    break;
                case DocConstantValueType.INTEGER:
                    ret = Mapper.Map<TypeInteger, DocTypeInteger>(IntegerValue);
                    break;
                case DocConstantValueType.INTERVAL:
                    ret = Mapper.Map<TypeInterval, DocTypeInterval>(IntervalValue);
                    break;
                case DocConstantValueType.INTERVALS:
                    ret = Mapper.Map<TypeIntervals, DocTypeIntervals>(IntervalsValue);
                    break;
                case DocConstantValueType.LOOKUP:
                    ret = Mapper.Map<TypeLookup, DocTypeLookup>(LookupValue);
                    break;
                case DocConstantValueType.MEMO:
                    ret = Mapper.Map<TypeMemo, DocTypeMemo>(MemoValue);
                    break;
                case DocConstantValueType.NPERSONS:
                    ret = Mapper.Map<TypeNPersons, DocTypeNPersons>(NPersonsValue);
                    break;
                case DocConstantValueType.PARTICIPANT:
                    ret = Mapper.Map<TypeParticipant, DocTypeParticipant>(ParticipantValue);
                    break;
                case DocConstantValueType.PARTICIPANTS:
                    ret = Mapper.Map<TypeParticipants, DocTypeParticipants>(ParticipantsValue);
                    break;
                case DocConstantValueType.POPULATIONANALYZED:
                    ret = Mapper.Map<TypePopulationAnalyzed, DocTypePopulationAnalyzed>(PopulationAnalyzedValue);
                    break;
                case DocConstantValueType.PVALUE:
                    ret = Mapper.Map<TypePValue, DocTypePValue>(PValueValue);
                    break;
                case DocConstantValueType.RATE:
                    ret = Mapper.Map<TypeRate, DocTypeRate>(RateValue);
                    break;
                case DocConstantValueType.SETTINGLOCATION:
                    ret = Mapper.Map<TypeSettingLocation, DocTypeSettingLocation>(SettingLocationValue);
                    break;
                case DocConstantValueType.SETTINGLOCATIONTOTAL:
                    ret = Mapper.Map<TypeSettingLocationTotal, DocTypeSettingLocationTotal>(SettingLocationTotalValue);
                    break;
                case DocConstantValueType.STUDYDOC:
                    ret = Mapper.Map<TypeStudyDoc, DocTypeStudyDoc>(StudyDocValue);
                    break;
                case DocConstantValueType.STUDYOBJECTIVE:
                    ret = Mapper.Map<TypeStudyObjective, DocTypeStudyObjective>(StudyObjectiveValue);
                    break;
                case DocConstantValueType.STUDYREFERENCE:
                    ret = Mapper.Map<TypeStudyReference, DocTypeStudyReference>(StudyReferenceValue);
                    break;
                case DocConstantValueType.SUBGROUPDESCRIPTOR:
                    ret = Mapper.Map<TypeSubgroupDescriptor, DocTypeSubgroupDescriptor>(SubgroupDescriptorValue);
                    break;
                case DocConstantValueType.TIMEPOINT:
                    ret = Mapper.Map<TypeTimepoint, DocTypeTimepoint>(TimepointValue);
                    break;
                case DocConstantValueType.TIMEPOINTS:
                    ret = Mapper.Map<TypeTimepoints, DocTypeTimepoints>(TimepointsValue);
                    break;
                case DocConstantValueType.UNCOLLECTEDVALUE:
                    ret = Mapper.Map<TypeUncollectedValue, DocTypeUncollectedValue>(UncollectedValueValue);
                    break;
                case DocConstantValueType.UNITRANGE:
                    ret = Mapper.Map<TypeUnitRange, DocTypeUnitRange>(UnitRangeValue);
                    break;
                case DocConstantValueType.UNITS:
                    ret = Mapper.Map<TypeUnits, DocTypeUnits>(UnitsValue);
                    break;
                case DocConstantValueType.UNITSRANGE:
                    ret = Mapper.Map<TypeUnitsRange, DocTypeUnitsRange>(UnitsRangeValue);
                    break;
                case DocConstantValueType.UNITVALUE:
                    ret = Mapper.Map<TypeUnitValue, DocTypeUnitValue>(UnitValueValue);
                    break;
                case DocConstantValueType.YESNONA:
                    ret = Mapper.Map<TypeYesNoNa, DocTypeYesNoNa>(YesNoNaValue);
                    break;
                case DocConstantValueType.AVERAGE:
                case DocConstantValueType.MEAN:
                case DocConstantValueType.MEDIAN:
                case DocConstantValueType.ESTIMATED_PROPORTION:
                case DocConstantValueType.FIXED:
                case DocConstantValueType.FLEX:
                case DocConstantValueType.RATIO:
                    ret = Mapper.Map<TypeMeanBase, DocTypeMeanBase>(MeanBaseValue);
                    break;
                case DocConstantValueType.STATISTICS:
                case DocConstantValueType.GROUP_INTERVENTION:
                case DocConstantValueType.UNCOLLECTED_BINARY:
                case DocConstantValueType.UNCOLLECTED_CONTINUOUS:
                case DocConstantValueType.UNCOLLECTED_INDIVIDUAL:
                case DocConstantValueType.UNCOLLECTED_COUNT:
                case DocConstantValueType.UNCOLLECTED_RATE:
                case DocConstantValueType.UNCOLLECTED_KAPLAN_MEIER:
                case DocConstantValueType.UNCOLLECTED:
                    ret = Mapper.Map<TypeUncollectedValue, DocTypeUncollectedValue>(UncollectedValueValue);
                    break;
                default:
                    throw new NotImplementedException(ValueType.ToString() + " not supported.");
            }
            return ret;
        }

		public StudyStorage.EaValue GetValueFlat()
        {
            StudyStorage.EaValue ret=null;
            switch (ValueType)
            {
                case DocConstantValueType.ASSOCIATIONMEASURE:
                    ret = AssociationMeasureValue.ToValueFlat();
                    break;
                case DocConstantValueType.BOOLEAN:
                    ret = BooleanValue.ToValueFlat();
                    break;
                case DocConstantValueType.CALENDARDATE:
                    ret = CalendarDateValue.ToValueFlat();
                    break;
                case DocConstantValueType.CALENDARDATES:
                    ret = CalendarDatesValue.ToValueFlat();
                    break;
                case DocConstantValueType.CONTACT:
                    ret = ContactValue.ToValueFlat();
                    break;
                case DocConstantValueType.DATETIME:
                    ret = DateTimeValue.ToValueFlat();
                    break;
                case DocConstantValueType.DATETIMERANGE:
                    ret = DateTimeRangeValue.ToValueFlat();
                    break;
                case DocConstantValueType.DECIMAL:
                    ret = DecimalValue.ToValueFlat();
                    break;
                case DocConstantValueType.DECIMALRANGE:
                    ret = DecimalRangeValue.ToValueFlat();
                    break;
                case DocConstantValueType.DESIGNNESTEDSTUDYIDLINK:
                    ret = DesignNestedStudyIdLinkValue.ToValueFlat();
                    break;
                case DocConstantValueType.EVENTCOUNTS:
                    ret = EventCountsValue.ToValueFlat();
                    break;
                case DocConstantValueType.FACILITY:
                    ret = FacilityValue.ToValueFlat();
                    break;
                case DocConstantValueType.FIXEDDOSEINTERVENTION:
                    ret = FixedDoseInterventionValue.ToValueFlat();
                    break;
                case DocConstantValueType.FLAG:
                    ret = FlagValue.ToValueFlat();
                    break;
                case DocConstantValueType.FUNDING:
                    ret = FundingValue.ToValueFlat();
                    break;
                case DocConstantValueType.INTEGER:
                    ret = IntegerValue.ToValueFlat();
                    break;
                case DocConstantValueType.INTERVAL:
                    ret = IntervalValue.ToValueFlat();
                    break;
                case DocConstantValueType.INTERVALS:
                    ret = IntervalsValue.ToValueFlat();
                    break;
                case DocConstantValueType.LOOKUP:
                    ret = LookupValue.ToValueFlat();
                    break;
                case DocConstantValueType.MEMO:
                    ret = MemoValue.ToValueFlat();
                    break;
                case DocConstantValueType.NPERSONS:
                    ret = NPersonsValue.ToValueFlat();
                    break;
                case DocConstantValueType.PARTICIPANT:
                    ret = ParticipantValue.ToValueFlat();
                    break;
                case DocConstantValueType.PARTICIPANTS:
                    ret = ParticipantsValue.ToValueFlat();
                    break;
                case DocConstantValueType.POPULATIONANALYZED:
                    ret = PopulationAnalyzedValue.ToValueFlat();
                    break;
                case DocConstantValueType.PVALUE:
                    ret = PValueValue.ToValueFlat();
                    break;
                case DocConstantValueType.RATE:
                    ret = RateValue.ToValueFlat();
                    break;
                case DocConstantValueType.SETTINGLOCATION:
                    ret = SettingLocationValue.ToValueFlat();
                    break;
                case DocConstantValueType.SETTINGLOCATIONTOTAL:
                    ret = SettingLocationTotalValue.ToValueFlat();
                    break;
                case DocConstantValueType.STUDYDOC:
                    ret = StudyDocValue.ToValueFlat();
                    break;
                case DocConstantValueType.STUDYOBJECTIVE:
                    ret = StudyObjectiveValue.ToValueFlat();
                    break;
                case DocConstantValueType.STUDYREFERENCE:
                    ret = StudyReferenceValue.ToValueFlat();
                    break;
                case DocConstantValueType.SUBGROUPDESCRIPTOR:
                    ret = SubgroupDescriptorValue.ToValueFlat();
                    break;
                case DocConstantValueType.TIMEPOINT:
                    ret = TimepointValue.ToValueFlat();
                    break;
                case DocConstantValueType.TIMEPOINTS:
                    ret = TimepointsValue.ToValueFlat();
                    break;
                case DocConstantValueType.UNCOLLECTEDVALUE:
                    ret = UncollectedValueValue.ToValueFlat();
                    break;
                case DocConstantValueType.UNITRANGE:
                    ret = UnitRangeValue.ToValueFlat();
                    break;
                case DocConstantValueType.UNITS:
                    ret = UnitsValue.ToValueFlat();
                    break;
                case DocConstantValueType.UNITSRANGE:
                    ret = UnitsRangeValue.ToValueFlat();
                    break;
                case DocConstantValueType.UNITVALUE:
                    ret = UnitValueValue.ToValueFlat();
                    break;
                case DocConstantValueType.YESNONA:
                    ret = YesNoNaValue.ToValueFlat();
                    break;
                case DocConstantValueType.AVERAGE:
                case DocConstantValueType.MEAN:
                case DocConstantValueType.MEDIAN:
                case DocConstantValueType.ESTIMATED_PROPORTION:
                case DocConstantValueType.FIXED:
                case DocConstantValueType.FLEX:
                case DocConstantValueType.RATIO:
                    ret = MeanBaseValue.ToValueFlat();
                    break;

                case DocConstantValueType.STATISTICS:
                case DocConstantValueType.GROUP_INTERVENTION:
                case DocConstantValueType.UNCOLLECTED_BINARY:
                case DocConstantValueType.UNCOLLECTED_CONTINUOUS:
                case DocConstantValueType.UNCOLLECTED_INDIVIDUAL:
                case DocConstantValueType.UNCOLLECTED_COUNT:
                case DocConstantValueType.UNCOLLECTED_RATE:
                case DocConstantValueType.UNCOLLECTED_KAPLAN_MEIER:
                case DocConstantValueType.UNCOLLECTED:
                    ret = UncollectedValueValue.ToValueFlat();
                    break;
                default:
                    throw new NotImplementedException(ValueType.ToString() + " not supported.");
            }
            return ret;
        }

        #endregion
    }
}
