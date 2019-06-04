



















//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated by a T4 template. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;

using Services.Dto;

using ServiceStack;

using Attribute = Services.Dto.Attribute;
using ValueType = Services.Dto.ValueType;
namespace Services.Core
{
    public static partial class DocPermissionFactory
    {
        /// <summary>
        /// Get Visible Fields for classes which bypass standard logic
        /// </summary>
        public static List<string> GetVisibleFieldOverrides(string table, List<string> requestedFields)
        {
            var ret = new List<string>();
            requestedFields = requestedFields ?? new List<string>();

            switch(table.ToLower())
            {
                case "attribute":
                    return requestedFields.Any() ? Attribute.Fields.Intersect(requestedFields, System.StringComparer.InvariantCultureIgnoreCase).ToList() : Attribute.Fields;
                case "attributeinterval":
                    return requestedFields.Any() ? AttributeInterval.Fields.Intersect(requestedFields, System.StringComparer.InvariantCultureIgnoreCase).ToList() : AttributeInterval.Fields;
                case "datetimedto":
                    return requestedFields.Any() ? DateTimeDto.Fields.Intersect(requestedFields, System.StringComparer.InvariantCultureIgnoreCase).ToList() : DateTimeDto.Fields;
                case "importdata":
                    return requestedFields.Any() ? ImportData.Fields.Intersect(requestedFields, System.StringComparer.InvariantCultureIgnoreCase).ToList() : ImportData.Fields;
                case "interval":
                    return requestedFields.Any() ? Interval.Fields.Intersect(requestedFields, System.StringComparer.InvariantCultureIgnoreCase).ToList() : Interval.Fields;
                case "lookupcategory":
                    return requestedFields.Any() ? LookupCategory.Fields.Intersect(requestedFields, System.StringComparer.InvariantCultureIgnoreCase).ToList() : LookupCategory.Fields;
                case "lookuptable":
                    return requestedFields.Any() ? LookupTable.Fields.Intersect(requestedFields, System.StringComparer.InvariantCultureIgnoreCase).ToList() : LookupTable.Fields;
                case "lookuptableenum":
                    return requestedFields.Any() ? LookupTableEnum.Fields.Intersect(requestedFields, System.StringComparer.InvariantCultureIgnoreCase).ToList() : LookupTableEnum.Fields;
                case "meanranges":
                    return requestedFields.Any() ? MeanRanges.Fields.Intersect(requestedFields, System.StringComparer.InvariantCultureIgnoreCase).ToList() : MeanRanges.Fields;
                case "meanrangevalue":
                    return requestedFields.Any() ? MeanRangeValue.Fields.Intersect(requestedFields, System.StringComparer.InvariantCultureIgnoreCase).ToList() : MeanRangeValue.Fields;
                case "meanvariances":
                    return requestedFields.Any() ? MeanVariances.Fields.Intersect(requestedFields, System.StringComparer.InvariantCultureIgnoreCase).ToList() : MeanVariances.Fields;
                case "meanvariancevalue":
                    return requestedFields.Any() ? MeanVarianceValue.Fields.Intersect(requestedFields, System.StringComparer.InvariantCultureIgnoreCase).ToList() : MeanVarianceValue.Fields;
                case "stats":
                    return requestedFields.Any() ? Stats.Fields.Intersect(requestedFields, System.StringComparer.InvariantCultureIgnoreCase).ToList() : Stats.Fields;
                case "statsrecord":
                    return requestedFields.Any() ? StatsRecord.Fields.Intersect(requestedFields, System.StringComparer.InvariantCultureIgnoreCase).ToList() : StatsRecord.Fields;
                case "statsstudyset":
                    return requestedFields.Any() ? StatsStudySet.Fields.Intersect(requestedFields, System.StringComparer.InvariantCultureIgnoreCase).ToList() : StatsStudySet.Fields;
                case "studydesign":
                    return requestedFields.Any() ? StudyDesign.Fields.Intersect(requestedFields, System.StringComparer.InvariantCultureIgnoreCase).ToList() : StudyDesign.Fields;
                case "studytype":
                    return requestedFields.Any() ? StudyType.Fields.Intersect(requestedFields, System.StringComparer.InvariantCultureIgnoreCase).ToList() : StudyType.Fields;
                case "timepoint":
                    return requestedFields.Any() ? TimePoint.Fields.Intersect(requestedFields, System.StringComparer.InvariantCultureIgnoreCase).ToList() : TimePoint.Fields;
                case "unitconversionrules":
                    return requestedFields.Any() ? UnitConversionRules.Fields.Intersect(requestedFields, System.StringComparer.InvariantCultureIgnoreCase).ToList() : UnitConversionRules.Fields;
                case "unitofmeasure":
                    return requestedFields.Any() ? UnitOfMeasure.Fields.Intersect(requestedFields, System.StringComparer.InvariantCultureIgnoreCase).ToList() : UnitOfMeasure.Fields;
                case "unitsdto":
                    return requestedFields.Any() ? UnitsDto.Fields.Intersect(requestedFields, System.StringComparer.InvariantCultureIgnoreCase).ToList() : UnitsDto.Fields;
                case "unitvalue":
                    return requestedFields.Any() ? UnitValue.Fields.Intersect(requestedFields, System.StringComparer.InvariantCultureIgnoreCase).ToList() : UnitValue.Fields;
                case "valuetype":
                    return requestedFields.Any() ? ValueType.Fields.Intersect(requestedFields, System.StringComparer.InvariantCultureIgnoreCase).ToList() : ValueType.Fields;
            }
            return ret;
        }
    }
}
