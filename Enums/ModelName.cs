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
using System.Reflection;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using Services.Core;

using ServiceStack;

using SCDescript = System.ComponentModel.DescriptionAttribute;
using SCDisplay = System.ComponentModel.DataAnnotations.DisplayAttribute;
using SSDescript = ServiceStack.DataAnnotations.DescriptionAttribute;
namespace Services.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ModelNameEnm
    {
        [EnumMember(Value = DocConstantModelName.ADJUDICATEDRATING), SCDescript(DocConstantModelName.ADJUDICATEDRATING), SSDescript(DocConstantModelName.ADJUDICATEDRATING), SCDisplay(Name = DocConstantModelName.ADJUDICATEDRATING)]
        ADJUDICATEDRATING = 20585,
        [EnumMember(Value = DocConstantModelName.APP), SCDescript(DocConstantModelName.APP), SSDescript(DocConstantModelName.APP), SCDisplay(Name = DocConstantModelName.APP)]
        APP = 14173,
        [EnumMember(Value = DocConstantModelName.ATTRIBUTE), SCDescript(DocConstantModelName.ATTRIBUTE), SSDescript(DocConstantModelName.ATTRIBUTE), SCDisplay(Name = DocConstantModelName.ATTRIBUTE)]
        ATTRIBUTE = 102,
        [EnumMember(Value = DocConstantModelName.ATTRIBUTEINTERVAL), SCDescript(DocConstantModelName.ATTRIBUTEINTERVAL), SSDescript(DocConstantModelName.ATTRIBUTEINTERVAL), SCDisplay(Name = DocConstantModelName.ATTRIBUTEINTERVAL)]
        ATTRIBUTEINTERVAL = 104,
        [EnumMember(Value = DocConstantModelName.AUDITDELTA), SCDescript(DocConstantModelName.AUDITDELTA), SSDescript(DocConstantModelName.AUDITDELTA), SCDisplay(Name = DocConstantModelName.AUDITDELTA)]
        AUDITDELTA = 19019,
        [EnumMember(Value = DocConstantModelName.AUDITRECORD), SCDescript(DocConstantModelName.AUDITRECORD), SSDescript(DocConstantModelName.AUDITRECORD), SCDisplay(Name = DocConstantModelName.AUDITRECORD)]
        AUDITRECORD = 108,
        [EnumMember(Value = DocConstantModelName.BACKGROUNDTASK), SCDescript(DocConstantModelName.BACKGROUNDTASK), SSDescript(DocConstantModelName.BACKGROUNDTASK), SCDisplay(Name = DocConstantModelName.BACKGROUNDTASK)]
        BACKGROUNDTASK = 14375,
        [EnumMember(Value = DocConstantModelName.BACKGROUNDTASKHISTORY), SCDescript(DocConstantModelName.BACKGROUNDTASKHISTORY), SSDescript(DocConstantModelName.BACKGROUNDTASKHISTORY), SCDisplay(Name = DocConstantModelName.BACKGROUNDTASKHISTORY)]
        BACKGROUNDTASKHISTORY = 18919,
        [EnumMember(Value = DocConstantModelName.BACKGROUNDTASKITEM), SCDescript(DocConstantModelName.BACKGROUNDTASKITEM), SSDescript(DocConstantModelName.BACKGROUNDTASKITEM), SCDisplay(Name = DocConstantModelName.BACKGROUNDTASKITEM)]
        BACKGROUNDTASKITEM = 19935,
        [EnumMember(Value = DocConstantModelName.BROADCAST), SCDescript(DocConstantModelName.BROADCAST), SSDescript(DocConstantModelName.BROADCAST), SCDisplay(Name = DocConstantModelName.BROADCAST)]
        BROADCAST = 13962,
        [EnumMember(Value = DocConstantModelName.CLIENT), SCDescript(DocConstantModelName.CLIENT), SSDescript(DocConstantModelName.CLIENT), SCDisplay(Name = DocConstantModelName.CLIENT)]
        CLIENT = 111,
        [EnumMember(Value = DocConstantModelName.COMMENT), SCDescript(DocConstantModelName.COMMENT), SSDescript(DocConstantModelName.COMMENT), SCDisplay(Name = DocConstantModelName.COMMENT)]
        COMMENT = 18319,
        [EnumMember(Value = DocConstantModelName.DATABASEVERSION), SCDescript(DocConstantModelName.DATABASEVERSION), SSDescript(DocConstantModelName.DATABASEVERSION), SCDisplay(Name = DocConstantModelName.DATABASEVERSION)]
        DATABASEVERSION = 18819,
        [EnumMember(Value = DocConstantModelName.DATACLASS), SCDescript(DocConstantModelName.DATACLASS), SSDescript(DocConstantModelName.DATACLASS), SCDisplay(Name = DocConstantModelName.DATACLASS)]
        DATACLASS = 20235,
        [EnumMember(Value = DocConstantModelName.DATAPROPERTY), SCDescript(DocConstantModelName.DATAPROPERTY), SSDescript(DocConstantModelName.DATAPROPERTY), SCDisplay(Name = DocConstantModelName.DATAPROPERTY)]
        DATAPROPERTY = 20255,
        [EnumMember(Value = DocConstantModelName.DATASET), SCDescript(DocConstantModelName.DATASET), SSDescript(DocConstantModelName.DATASET), SCDisplay(Name = DocConstantModelName.DATASET)]
        DATASET = 20985,
        [EnumMember(Value = DocConstantModelName.DATATAB), SCDescript(DocConstantModelName.DATATAB), SSDescript(DocConstantModelName.DATATAB), SCDisplay(Name = DocConstantModelName.DATATAB)]
        DATATAB = 20265,
        [EnumMember(Value = DocConstantModelName.DATETIME), SCDescript(DocConstantModelName.DATETIME), SSDescript(DocConstantModelName.DATETIME), SCDisplay(Name = DocConstantModelName.DATETIME)]
        DATETIME = 15278,
        [EnumMember(Value = DocConstantModelName.DEFAULT), SCDescript(DocConstantModelName.DEFAULT), SSDescript(DocConstantModelName.DEFAULT), SCDisplay(Name = DocConstantModelName.DEFAULT)]
        DEFAULT = 19435,
        [EnumMember(Value = DocConstantModelName.DISEASESTATESET), SCDescript(DocConstantModelName.DISEASESTATESET), SSDescript(DocConstantModelName.DISEASESTATESET), SCDisplay(Name = DocConstantModelName.DISEASESTATESET)]
        DISEASESTATESET = 20785,
        [EnumMember(Value = DocConstantModelName.DIVISION), SCDescript(DocConstantModelName.DIVISION), SSDescript(DocConstantModelName.DIVISION), SCDisplay(Name = DocConstantModelName.DIVISION)]
        DIVISION = 112,
        [EnumMember(Value = DocConstantModelName.DOCUMENT), SCDescript(DocConstantModelName.DOCUMENT), SSDescript(DocConstantModelName.DOCUMENT), SCDisplay(Name = DocConstantModelName.DOCUMENT)]
        DOCUMENT = 136,
        [EnumMember(Value = DocConstantModelName.DOCUMENTSET), SCDescript(DocConstantModelName.DOCUMENTSET), SSDescript(DocConstantModelName.DOCUMENTSET), SCDisplay(Name = DocConstantModelName.DOCUMENTSET)]
        DOCUMENTSET = 142,
        [EnumMember(Value = DocConstantModelName.DOCUMENTSETHISTORY), SCDescript(DocConstantModelName.DOCUMENTSETHISTORY), SSDescript(DocConstantModelName.DOCUMENTSETHISTORY), SCDisplay(Name = DocConstantModelName.DOCUMENTSETHISTORY)]
        DOCUMENTSETHISTORY = 13320,
        [EnumMember(Value = DocConstantModelName.ENTITIES), SCDescript(DocConstantModelName.ENTITIES), SSDescript(DocConstantModelName.ENTITIES), SCDisplay(Name = DocConstantModelName.ENTITIES)]
        ENTITIES = 13364,
        [EnumMember(Value = DocConstantModelName.EOD), SCDescript(DocConstantModelName.EOD), SSDescript(DocConstantModelName.EOD), SCDisplay(Name = DocConstantModelName.EOD)]
        EOD = 20385,
        [EnumMember(Value = DocConstantModelName.EVENT), SCDescript(DocConstantModelName.EVENT), SSDescript(DocConstantModelName.EVENT), SCDisplay(Name = DocConstantModelName.EVENT)]
        EVENT = 19219,
        [EnumMember(Value = DocConstantModelName.FAVORITE), SCDescript(DocConstantModelName.FAVORITE), SSDescript(DocConstantModelName.FAVORITE), SCDisplay(Name = DocConstantModelName.FAVORITE)]
        FAVORITE = 20485,
        [EnumMember(Value = DocConstantModelName.FEATURESET), SCDescript(DocConstantModelName.FEATURESET), SSDescript(DocConstantModelName.FEATURESET), SCDisplay(Name = DocConstantModelName.FEATURESET)]
        FEATURESET = 116,
        [EnumMember(Value = DocConstantModelName.FILE), SCDescript(DocConstantModelName.FILE), SSDescript(DocConstantModelName.FILE), SCDisplay(Name = DocConstantModelName.FILE)]
        FILE = 21285,
        [EnumMember(Value = DocConstantModelName.GLOSSARY), SCDescript(DocConstantModelName.GLOSSARY), SSDescript(DocConstantModelName.GLOSSARY), SCDisplay(Name = DocConstantModelName.GLOSSARY)]
        GLOSSARY = 14977,
        [EnumMember(Value = DocConstantModelName.HELP), SCDescript(DocConstantModelName.HELP), SSDescript(DocConstantModelName.HELP), SCDisplay(Name = DocConstantModelName.HELP)]
        HELP = 14978,
        [EnumMember(Value = DocConstantModelName.HISTORY), SCDescript(DocConstantModelName.HISTORY), SSDescript(DocConstantModelName.HISTORY), SCDisplay(Name = DocConstantModelName.HISTORY)]
        HISTORY = 15885,
        [EnumMember(Value = DocConstantModelName.IMPERSONATION), SCDescript(DocConstantModelName.IMPERSONATION), SSDescript(DocConstantModelName.IMPERSONATION), SCDisplay(Name = DocConstantModelName.IMPERSONATION)]
        IMPERSONATION = 19319,
        [EnumMember(Value = DocConstantModelName.IMPORTDATA), SCDescript(DocConstantModelName.IMPORTDATA), SSDescript(DocConstantModelName.IMPORTDATA), SCDisplay(Name = DocConstantModelName.IMPORTDATA)]
        IMPORTDATA = 12600,
        [EnumMember(Value = DocConstantModelName.INTERVAL), SCDescript(DocConstantModelName.INTERVAL), SSDescript(DocConstantModelName.INTERVAL), SCDisplay(Name = DocConstantModelName.INTERVAL)]
        INTERVAL = 15178,
        [EnumMember(Value = DocConstantModelName.JUNCTION), SCDescript(DocConstantModelName.JUNCTION), SSDescript(DocConstantModelName.JUNCTION), SCDisplay(Name = DocConstantModelName.JUNCTION)]
        JUNCTION = 17619,
        [EnumMember(Value = DocConstantModelName.LIBRARYSET), SCDescript(DocConstantModelName.LIBRARYSET), SSDescript(DocConstantModelName.LIBRARYSET), SCDisplay(Name = DocConstantModelName.LIBRARYSET)]
        LIBRARYSET = 20885,
        [EnumMember(Value = DocConstantModelName.LOCALE), SCDescript(DocConstantModelName.LOCALE), SSDescript(DocConstantModelName.LOCALE), SCDisplay(Name = DocConstantModelName.LOCALE)]
        LOCALE = 19335,
        [EnumMember(Value = DocConstantModelName.LOCALELOOKUP), SCDescript(DocConstantModelName.LOCALELOOKUP), SSDescript(DocConstantModelName.LOCALELOOKUP), SCDisplay(Name = DocConstantModelName.LOCALELOOKUP)]
        LOCALELOOKUP = 19325,
        [EnumMember(Value = DocConstantModelName.LOOKUPCATEGORY), SCDescript(DocConstantModelName.LOOKUPCATEGORY), SSDescript(DocConstantModelName.LOOKUPCATEGORY), SCDisplay(Name = DocConstantModelName.LOOKUPCATEGORY)]
        LOOKUPCATEGORY = 17419,
        [EnumMember(Value = DocConstantModelName.LOOKUPTABLE), SCDescript(DocConstantModelName.LOOKUPTABLE), SSDescript(DocConstantModelName.LOOKUPTABLE), SCDisplay(Name = DocConstantModelName.LOOKUPTABLE)]
        LOOKUPTABLE = 127,
        [EnumMember(Value = DocConstantModelName.LOOKUPTABLEBINDING), SCDescript(DocConstantModelName.LOOKUPTABLEBINDING), SSDescript(DocConstantModelName.LOOKUPTABLEBINDING), SCDisplay(Name = DocConstantModelName.LOOKUPTABLEBINDING)]
        LOOKUPTABLEBINDING = 15380,
        [EnumMember(Value = DocConstantModelName.LOOKUPTABLEENUM), SCDescript(DocConstantModelName.LOOKUPTABLEENUM), SSDescript(DocConstantModelName.LOOKUPTABLEENUM), SCDisplay(Name = DocConstantModelName.LOOKUPTABLEENUM)]
        LOOKUPTABLEENUM = 128,
        [EnumMember(Value = DocConstantModelName.MEANRANGES), SCDescript(DocConstantModelName.MEANRANGES), SSDescript(DocConstantModelName.MEANRANGES), SCDisplay(Name = DocConstantModelName.MEANRANGES)]
        MEANRANGES = 130,
        [EnumMember(Value = DocConstantModelName.MEANRANGEVALUE), SCDescript(DocConstantModelName.MEANRANGEVALUE), SSDescript(DocConstantModelName.MEANRANGEVALUE), SCDisplay(Name = DocConstantModelName.MEANRANGEVALUE)]
        MEANRANGEVALUE = 129,
        [EnumMember(Value = DocConstantModelName.MEANVARIANCES), SCDescript(DocConstantModelName.MEANVARIANCES), SSDescript(DocConstantModelName.MEANVARIANCES), SCDisplay(Name = DocConstantModelName.MEANVARIANCES)]
        MEANVARIANCES = 18219,
        [EnumMember(Value = DocConstantModelName.MEANVARIANCEVALUE), SCDescript(DocConstantModelName.MEANVARIANCEVALUE), SSDescript(DocConstantModelName.MEANVARIANCEVALUE), SCDisplay(Name = DocConstantModelName.MEANVARIANCEVALUE)]
        MEANVARIANCEVALUE = 18119,
        [EnumMember(Value = DocConstantModelName.PAGE), SCDescript(DocConstantModelName.PAGE), SSDescript(DocConstantModelName.PAGE), SCDisplay(Name = DocConstantModelName.PAGE)]
        PAGE = 180,
        [EnumMember(Value = DocConstantModelName.PROJECT), SCDescript(DocConstantModelName.PROJECT), SSDescript(DocConstantModelName.PROJECT), SCDisplay(Name = DocConstantModelName.PROJECT)]
        PROJECT = 20135,
        [EnumMember(Value = DocConstantModelName.QUEUECHANNEL), SCDescript(DocConstantModelName.QUEUECHANNEL), SSDescript(DocConstantModelName.QUEUECHANNEL), SCDisplay(Name = DocConstantModelName.QUEUECHANNEL)]
        QUEUECHANNEL = 18519,
        [EnumMember(Value = DocConstantModelName.RATING), SCDescript(DocConstantModelName.RATING), SSDescript(DocConstantModelName.RATING), SCDisplay(Name = DocConstantModelName.RATING)]
        RATING = 20365,
        [EnumMember(Value = DocConstantModelName.RECONCILEDOCUMENT), SCDescript(DocConstantModelName.RECONCILEDOCUMENT), SSDescript(DocConstantModelName.RECONCILEDOCUMENT), SCDisplay(Name = DocConstantModelName.RECONCILEDOCUMENT)]
        RECONCILEDOCUMENT = 21185,
        [EnumMember(Value = DocConstantModelName.ROLE), SCDescript(DocConstantModelName.ROLE), SSDescript(DocConstantModelName.ROLE), SCDisplay(Name = DocConstantModelName.ROLE)]
        ROLE = 133,
        [EnumMember(Value = DocConstantModelName.SCOPE), SCDescript(DocConstantModelName.SCOPE), SSDescript(DocConstantModelName.SCOPE), SCDisplay(Name = DocConstantModelName.SCOPE)]
        SCOPE = 15379,
        [EnumMember(Value = DocConstantModelName.SERVEPORTALSET), SCDescript(DocConstantModelName.SERVEPORTALSET), SSDescript(DocConstantModelName.SERVEPORTALSET), SCDisplay(Name = DocConstantModelName.SERVEPORTALSET)]
        SERVEPORTALSET = 21085,
        [EnumMember(Value = DocConstantModelName.STATS), SCDescript(DocConstantModelName.STATS), SSDescript(DocConstantModelName.STATS), SCDisplay(Name = DocConstantModelName.STATS)]
        STATS = 14273,
        [EnumMember(Value = DocConstantModelName.STATSRECORD), SCDescript(DocConstantModelName.STATSRECORD), SSDescript(DocConstantModelName.STATSRECORD), SCDisplay(Name = DocConstantModelName.STATSRECORD)]
        STATSRECORD = 14275,
        [EnumMember(Value = DocConstantModelName.STATSSTUDYSET), SCDescript(DocConstantModelName.STATSSTUDYSET), SSDescript(DocConstantModelName.STATSSTUDYSET), SCDisplay(Name = DocConstantModelName.STATSSTUDYSET)]
        STATSSTUDYSET = 14274,
        [EnumMember(Value = DocConstantModelName.STUDYDESIGN), SCDescript(DocConstantModelName.STUDYDESIGN), SSDescript(DocConstantModelName.STUDYDESIGN), SCDisplay(Name = DocConstantModelName.STUDYDESIGN)]
        STUDYDESIGN = 137,
        [EnumMember(Value = DocConstantModelName.STUDYTYPE), SCDescript(DocConstantModelName.STUDYTYPE), SSDescript(DocConstantModelName.STUDYTYPE), SCDisplay(Name = DocConstantModelName.STUDYTYPE)]
        STUDYTYPE = 143,
        [EnumMember(Value = DocConstantModelName.TAG), SCDescript(DocConstantModelName.TAG), SSDescript(DocConstantModelName.TAG), SCDisplay(Name = DocConstantModelName.TAG)]
        TAG = 18019,
        [EnumMember(Value = DocConstantModelName.TASK), SCDescript(DocConstantModelName.TASK), SSDescript(DocConstantModelName.TASK), SCDisplay(Name = DocConstantModelName.TASK)]
        TASK = 18719,
        [EnumMember(Value = DocConstantModelName.TEAM), SCDescript(DocConstantModelName.TEAM), SSDescript(DocConstantModelName.TEAM), SCDisplay(Name = DocConstantModelName.TEAM)]
        TEAM = 15881,
        [EnumMember(Value = DocConstantModelName.TERMCATEGORY), SCDescript(DocConstantModelName.TERMCATEGORY), SSDescript(DocConstantModelName.TERMCATEGORY), SCDisplay(Name = DocConstantModelName.TERMCATEGORY)]
        TERMCATEGORY = 146,
        [EnumMember(Value = DocConstantModelName.TERMMASTER), SCDescript(DocConstantModelName.TERMMASTER), SSDescript(DocConstantModelName.TERMMASTER), SCDisplay(Name = DocConstantModelName.TERMMASTER)]
        TERMMASTER = 147,
        [EnumMember(Value = DocConstantModelName.TERMSYNONYM), SCDescript(DocConstantModelName.TERMSYNONYM), SSDescript(DocConstantModelName.TERMSYNONYM), SCDisplay(Name = DocConstantModelName.TERMSYNONYM)]
        TERMSYNONYM = 148,
        [EnumMember(Value = DocConstantModelName.THERAPEUTICAREASET), SCDescript(DocConstantModelName.THERAPEUTICAREASET), SSDescript(DocConstantModelName.THERAPEUTICAREASET), SCDisplay(Name = DocConstantModelName.THERAPEUTICAREASET)]
        THERAPEUTICAREASET = 20685,
        [EnumMember(Value = DocConstantModelName.TIMECARD), SCDescript(DocConstantModelName.TIMECARD), SSDescript(DocConstantModelName.TIMECARD), SCDisplay(Name = DocConstantModelName.TIMECARD)]
        TIMECARD = 17319,
        [EnumMember(Value = DocConstantModelName.TIMEPOINT), SCDescript(DocConstantModelName.TIMEPOINT), SSDescript(DocConstantModelName.TIMEPOINT), SCDisplay(Name = DocConstantModelName.TIMEPOINT)]
        TIMEPOINT = 15078,
        [EnumMember(Value = DocConstantModelName.UNITCONVERSIONRULES), SCDescript(DocConstantModelName.UNITCONVERSIONRULES), SSDescript(DocConstantModelName.UNITCONVERSIONRULES), SCDisplay(Name = DocConstantModelName.UNITCONVERSIONRULES)]
        UNITCONVERSIONRULES = 149,
        [EnumMember(Value = DocConstantModelName.UNITOFMEASURE), SCDescript(DocConstantModelName.UNITOFMEASURE), SSDescript(DocConstantModelName.UNITOFMEASURE), SCDisplay(Name = DocConstantModelName.UNITOFMEASURE)]
        UNITOFMEASURE = 150,
        [EnumMember(Value = DocConstantModelName.UNITS), SCDescript(DocConstantModelName.UNITS), SSDescript(DocConstantModelName.UNITS), SCDisplay(Name = DocConstantModelName.UNITS)]
        UNITS = 152,
        [EnumMember(Value = DocConstantModelName.UNITVALUE), SCDescript(DocConstantModelName.UNITVALUE), SSDescript(DocConstantModelName.UNITVALUE), SCDisplay(Name = DocConstantModelName.UNITVALUE)]
        UNITVALUE = 151,
        [EnumMember(Value = DocConstantModelName.UPDATE), SCDescript(DocConstantModelName.UPDATE), SSDescript(DocConstantModelName.UPDATE), SCDisplay(Name = DocConstantModelName.UPDATE)]
        UPDATE = 19119,
        [EnumMember(Value = DocConstantModelName.USER), SCDescript(DocConstantModelName.USER), SSDescript(DocConstantModelName.USER), SCDisplay(Name = DocConstantModelName.USER)]
        USER = 153,
        [EnumMember(Value = DocConstantModelName.USERREQUEST), SCDescript(DocConstantModelName.USERREQUEST), SSDescript(DocConstantModelName.USERREQUEST), SCDisplay(Name = DocConstantModelName.USERREQUEST)]
        USERREQUEST = 18619,
        [EnumMember(Value = DocConstantModelName.USERSESSION), SCDescript(DocConstantModelName.USERSESSION), SSDescript(DocConstantModelName.USERSESSION), SCDisplay(Name = DocConstantModelName.USERSESSION)]
        USERSESSION = 18419,
        [EnumMember(Value = DocConstantModelName.USERTYPE), SCDescript(DocConstantModelName.USERTYPE), SSDescript(DocConstantModelName.USERTYPE), SCDisplay(Name = DocConstantModelName.USERTYPE)]
        USERTYPE = 17919,
        [EnumMember(Value = DocConstantModelName.VALUETYPE), SCDescript(DocConstantModelName.VALUETYPE), SSDescript(DocConstantModelName.VALUETYPE), SCDisplay(Name = DocConstantModelName.VALUETYPE)]
        VALUETYPE = 171,
        [EnumMember(Value = DocConstantModelName.VARIABLEINSTANCE), SCDescript(DocConstantModelName.VARIABLEINSTANCE), SSDescript(DocConstantModelName.VARIABLEINSTANCE), SCDisplay(Name = DocConstantModelName.VARIABLEINSTANCE)]
        VARIABLEINSTANCE = 15781,
        [EnumMember(Value = DocConstantModelName.VARIABLERULE), SCDescript(DocConstantModelName.VARIABLERULE), SSDescript(DocConstantModelName.VARIABLERULE), SCDisplay(Name = DocConstantModelName.VARIABLERULE)]
        VARIABLERULE = 15680,
        [EnumMember(Value = DocConstantModelName.WORKFLOW), SCDescript(DocConstantModelName.WORKFLOW), SSDescript(DocConstantModelName.WORKFLOW), SCDisplay(Name = DocConstantModelName.WORKFLOW)]
        WORKFLOW = 15378
    }
    
    public static partial class EnumExtensions
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static string ToEnumString(this ModelNameEnm instance)
        {
            switch(instance)
            {
                case ModelNameEnm.ADJUDICATEDRATING:
                    return DocConstantModelName.ADJUDICATEDRATING;
                case ModelNameEnm.APP:
                    return DocConstantModelName.APP;
                case ModelNameEnm.ATTRIBUTE:
                    return DocConstantModelName.ATTRIBUTE;
                case ModelNameEnm.ATTRIBUTEINTERVAL:
                    return DocConstantModelName.ATTRIBUTEINTERVAL;
                case ModelNameEnm.AUDITDELTA:
                    return DocConstantModelName.AUDITDELTA;
                case ModelNameEnm.AUDITRECORD:
                    return DocConstantModelName.AUDITRECORD;
                case ModelNameEnm.BACKGROUNDTASK:
                    return DocConstantModelName.BACKGROUNDTASK;
                case ModelNameEnm.BACKGROUNDTASKHISTORY:
                    return DocConstantModelName.BACKGROUNDTASKHISTORY;
                case ModelNameEnm.BACKGROUNDTASKITEM:
                    return DocConstantModelName.BACKGROUNDTASKITEM;
                case ModelNameEnm.BROADCAST:
                    return DocConstantModelName.BROADCAST;
                case ModelNameEnm.CLIENT:
                    return DocConstantModelName.CLIENT;
                case ModelNameEnm.COMMENT:
                    return DocConstantModelName.COMMENT;
                case ModelNameEnm.DATABASEVERSION:
                    return DocConstantModelName.DATABASEVERSION;
                case ModelNameEnm.DATACLASS:
                    return DocConstantModelName.DATACLASS;
                case ModelNameEnm.DATAPROPERTY:
                    return DocConstantModelName.DATAPROPERTY;
                case ModelNameEnm.DATASET:
                    return DocConstantModelName.DATASET;
                case ModelNameEnm.DATATAB:
                    return DocConstantModelName.DATATAB;
                case ModelNameEnm.DATETIME:
                    return DocConstantModelName.DATETIME;
                case ModelNameEnm.DEFAULT:
                    return DocConstantModelName.DEFAULT;
                case ModelNameEnm.DISEASESTATESET:
                    return DocConstantModelName.DISEASESTATESET;
                case ModelNameEnm.DIVISION:
                    return DocConstantModelName.DIVISION;
                case ModelNameEnm.DOCUMENT:
                    return DocConstantModelName.DOCUMENT;
                case ModelNameEnm.DOCUMENTSET:
                    return DocConstantModelName.DOCUMENTSET;
                case ModelNameEnm.DOCUMENTSETHISTORY:
                    return DocConstantModelName.DOCUMENTSETHISTORY;
                case ModelNameEnm.ENTITIES:
                    return DocConstantModelName.ENTITIES;
                case ModelNameEnm.EOD:
                    return DocConstantModelName.EOD;
                case ModelNameEnm.EVENT:
                    return DocConstantModelName.EVENT;
                case ModelNameEnm.FAVORITE:
                    return DocConstantModelName.FAVORITE;
                case ModelNameEnm.FEATURESET:
                    return DocConstantModelName.FEATURESET;
                case ModelNameEnm.FILE:
                    return DocConstantModelName.FILE;
                case ModelNameEnm.GLOSSARY:
                    return DocConstantModelName.GLOSSARY;
                case ModelNameEnm.HELP:
                    return DocConstantModelName.HELP;
                case ModelNameEnm.HISTORY:
                    return DocConstantModelName.HISTORY;
                case ModelNameEnm.IMPERSONATION:
                    return DocConstantModelName.IMPERSONATION;
                case ModelNameEnm.IMPORTDATA:
                    return DocConstantModelName.IMPORTDATA;
                case ModelNameEnm.INTERVAL:
                    return DocConstantModelName.INTERVAL;
                case ModelNameEnm.JUNCTION:
                    return DocConstantModelName.JUNCTION;
                case ModelNameEnm.LIBRARYSET:
                    return DocConstantModelName.LIBRARYSET;
                case ModelNameEnm.LOCALE:
                    return DocConstantModelName.LOCALE;
                case ModelNameEnm.LOCALELOOKUP:
                    return DocConstantModelName.LOCALELOOKUP;
                case ModelNameEnm.LOOKUPCATEGORY:
                    return DocConstantModelName.LOOKUPCATEGORY;
                case ModelNameEnm.LOOKUPTABLE:
                    return DocConstantModelName.LOOKUPTABLE;
                case ModelNameEnm.LOOKUPTABLEBINDING:
                    return DocConstantModelName.LOOKUPTABLEBINDING;
                case ModelNameEnm.LOOKUPTABLEENUM:
                    return DocConstantModelName.LOOKUPTABLEENUM;
                case ModelNameEnm.MEANRANGES:
                    return DocConstantModelName.MEANRANGES;
                case ModelNameEnm.MEANRANGEVALUE:
                    return DocConstantModelName.MEANRANGEVALUE;
                case ModelNameEnm.MEANVARIANCES:
                    return DocConstantModelName.MEANVARIANCES;
                case ModelNameEnm.MEANVARIANCEVALUE:
                    return DocConstantModelName.MEANVARIANCEVALUE;
                case ModelNameEnm.PAGE:
                    return DocConstantModelName.PAGE;
                case ModelNameEnm.PROJECT:
                    return DocConstantModelName.PROJECT;
                case ModelNameEnm.QUEUECHANNEL:
                    return DocConstantModelName.QUEUECHANNEL;
                case ModelNameEnm.RATING:
                    return DocConstantModelName.RATING;
                case ModelNameEnm.RECONCILEDOCUMENT:
                    return DocConstantModelName.RECONCILEDOCUMENT;
                case ModelNameEnm.ROLE:
                    return DocConstantModelName.ROLE;
                case ModelNameEnm.SCOPE:
                    return DocConstantModelName.SCOPE;
                case ModelNameEnm.SERVEPORTALSET:
                    return DocConstantModelName.SERVEPORTALSET;
                case ModelNameEnm.STATS:
                    return DocConstantModelName.STATS;
                case ModelNameEnm.STATSRECORD:
                    return DocConstantModelName.STATSRECORD;
                case ModelNameEnm.STATSSTUDYSET:
                    return DocConstantModelName.STATSSTUDYSET;
                case ModelNameEnm.STUDYDESIGN:
                    return DocConstantModelName.STUDYDESIGN;
                case ModelNameEnm.STUDYTYPE:
                    return DocConstantModelName.STUDYTYPE;
                case ModelNameEnm.TAG:
                    return DocConstantModelName.TAG;
                case ModelNameEnm.TASK:
                    return DocConstantModelName.TASK;
                case ModelNameEnm.TEAM:
                    return DocConstantModelName.TEAM;
                case ModelNameEnm.TERMCATEGORY:
                    return DocConstantModelName.TERMCATEGORY;
                case ModelNameEnm.TERMMASTER:
                    return DocConstantModelName.TERMMASTER;
                case ModelNameEnm.TERMSYNONYM:
                    return DocConstantModelName.TERMSYNONYM;
                case ModelNameEnm.THERAPEUTICAREASET:
                    return DocConstantModelName.THERAPEUTICAREASET;
                case ModelNameEnm.TIMECARD:
                    return DocConstantModelName.TIMECARD;
                case ModelNameEnm.TIMEPOINT:
                    return DocConstantModelName.TIMEPOINT;
                case ModelNameEnm.UNITCONVERSIONRULES:
                    return DocConstantModelName.UNITCONVERSIONRULES;
                case ModelNameEnm.UNITOFMEASURE:
                    return DocConstantModelName.UNITOFMEASURE;
                case ModelNameEnm.UNITS:
                    return DocConstantModelName.UNITS;
                case ModelNameEnm.UNITVALUE:
                    return DocConstantModelName.UNITVALUE;
                case ModelNameEnm.UPDATE:
                    return DocConstantModelName.UPDATE;
                case ModelNameEnm.USER:
                    return DocConstantModelName.USER;
                case ModelNameEnm.USERREQUEST:
                    return DocConstantModelName.USERREQUEST;
                case ModelNameEnm.USERSESSION:
                    return DocConstantModelName.USERSESSION;
                case ModelNameEnm.USERTYPE:
                    return DocConstantModelName.USERTYPE;
                case ModelNameEnm.VALUETYPE:
                    return DocConstantModelName.VALUETYPE;
                case ModelNameEnm.VARIABLEINSTANCE:
                    return DocConstantModelName.VARIABLEINSTANCE;
                case ModelNameEnm.VARIABLERULE:
                    return DocConstantModelName.VARIABLERULE;
                case ModelNameEnm.WORKFLOW:
                    return DocConstantModelName.WORKFLOW;
                default:
                    return string.Empty;
            }
        }

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static string ToEnumString(this ModelNameEnm? instance)
        {
            if(null == instance) return string.Empty;
            return instance.Value.ToEnumString();
        }
    }

    public sealed partial class DocConstantModelName : IEquatable<DocConstantModelName>, IEqualityComparer<DocConstantModelName>
    {
        public const string ADJUDICATEDRATING = "AdjudicatedRating";
        public const string APP = "App";
        public const string ATTRIBUTE = "Attribute";
        public const string ATTRIBUTEINTERVAL = "AttributeInterval";
        public const string AUDITDELTA = "AuditDelta";
        public const string AUDITRECORD = "AuditRecord";
        public const string BACKGROUNDTASK = "BackgroundTask";
        public const string BACKGROUNDTASKHISTORY = "BackgroundTaskHistory";
        public const string BACKGROUNDTASKITEM = "BackgroundTaskItem";
        public const string BROADCAST = "Broadcast";
        public const string CLIENT = "Client";
        public const string COMMENT = "Comment";
        public const string DATABASEVERSION = "DatabaseVersion";
        public const string DATACLASS = "DataClass";
        public const string DATAPROPERTY = "DataProperty";
        public const string DATASET = "DataSet";
        public const string DATATAB = "DataTab";
        public const string DATETIME = "DateTime";
        public const string DEFAULT = "Default";
        public const string DISEASESTATESET = "DiseaseStateSet";
        public const string DIVISION = "Division";
        public const string DOCUMENT = "Document";
        public const string DOCUMENTSET = "DocumentSet";
        public const string DOCUMENTSETHISTORY = "DocumentSetHistory";
        public const string ENTITIES = "Entities";
        public const string EOD = "EoD";
        public const string EVENT = "Event";
        public const string FAVORITE = "Favorite";
        public const string FEATURESET = "FeatureSet";
        public const string FILE = "File";
        public const string GLOSSARY = "Glossary";
        public const string HELP = "Help";
        public const string HISTORY = "History";
        public const string IMPERSONATION = "Impersonation";
        public const string IMPORTDATA = "ImportData";
        public const string INTERVAL = "Interval";
        public const string JUNCTION = "Junction";
        public const string LIBRARYSET = "LibrarySet";
        public const string LOCALE = "Locale";
        public const string LOCALELOOKUP = "LocaleLookup";
        public const string LOOKUPCATEGORY = "LookupCategory";
        public const string LOOKUPTABLE = "LookupTable";
        public const string LOOKUPTABLEBINDING = "LookupTableBinding";
        public const string LOOKUPTABLEENUM = "LookupTableEnum";
        public const string MEANRANGES = "MeanRanges";
        public const string MEANRANGEVALUE = "MeanRangeValue";
        public const string MEANVARIANCES = "MeanVariances";
        public const string MEANVARIANCEVALUE = "MeanVarianceValue";
        public const string PAGE = "Page";
        public const string PROJECT = "Project";
        public const string QUEUECHANNEL = "QueueChannel";
        public const string RATING = "Rating";
        public const string RECONCILEDOCUMENT = "ReconcileDocument";
        public const string ROLE = "Role";
        public const string SCOPE = "Scope";
        public const string SERVEPORTALSET = "ServePortalSet";
        public const string STATS = "Stats";
        public const string STATSRECORD = "StatsRecord";
        public const string STATSSTUDYSET = "StatsStudySet";
        public const string STUDYDESIGN = "StudyDesign";
        public const string STUDYTYPE = "StudyType";
        public const string TAG = "Tag";
        public const string TASK = "Task";
        public const string TEAM = "Team";
        public const string TERMCATEGORY = "TermCategory";
        public const string TERMMASTER = "TermMaster";
        public const string TERMSYNONYM = "TermSynonym";
        public const string THERAPEUTICAREASET = "TherapeuticAreaSet";
        public const string TIMECARD = "TimeCard";
        public const string TIMEPOINT = "TimePoint";
        public const string UNITCONVERSIONRULES = "UnitConversionRules";
        public const string UNITOFMEASURE = "UnitOfMeasure";
        public const string UNITS = "Units";
        public const string UNITVALUE = "UnitValue";
        public const string UPDATE = "Update";
        public const string USER = "User";
        public const string USERREQUEST = "UserRequest";
        public const string USERSESSION = "UserSession";
        public const string USERTYPE = "UserType";
        public const string VALUETYPE = "ValueType";
        public const string VARIABLEINSTANCE = "VariableInstance";
        public const string VARIABLERULE = "VariableRule";
        public const string WORKFLOW = "Workflow";
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private static List<string> _all;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static List<string> All => _all ?? (_all = typeof(DocConstantModelName).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy).Where(fi => fi.IsLiteral && !fi.IsInitOnly).Select( fi => fi.GetRawConstantValue().ToString() ).OrderBy(n => n).ToList());
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private readonly string Value;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private DocConstantModelName(string ItemName = null)
        {
            ItemName = ItemName ?? string.Empty;
            Value = FirstOrDefault(ItemName) ?? ItemName;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static bool Contains(string name) => All.Any(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static string FirstOrDefault(string name) => All.FirstOrDefault(val => string.Equals(val, name, StringComparison.OrdinalIgnoreCase));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static implicit operator DocConstantModelName(string Val) => new DocConstantModelName(Val);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static implicit operator string(DocConstantModelName item) => item?.Value ?? string.Empty;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static explicit operator DocConstantModelName(ModelNameEnm Val) => new DocConstantModelName(Val.ToEnumString());
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static explicit operator ModelNameEnm(DocConstantModelName item)
        {
            Enum.TryParse<ModelNameEnm>(item.ToString(), true, out var tryRet);
            return tryRet;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override string ToString() => Value;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool Equals(DocConstantModelName obj) => this == obj;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static bool operator ==(DocConstantModelName x, DocConstantModelName y) => DocTools.AreEqual(DocConvert.ToString(x), DocConvert.ToString(y));
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool Equals(DocConstantModelName x, DocConstantModelName y) => x == y;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static bool operator !=(DocConstantModelName x, DocConstantModelName y) => !(x == y);
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override bool Equals(object obj)
        {
            var ret = false;
            if(!(obj is DocConstantModelName))
            {
                ret = false;
            }
            else
            {
                ret = this == (DocConstantModelName) obj;
            }
            return ret;
        }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override int GetHashCode() => 17 * Value?.GetHashCode() ?? -1;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int GetHashCode(DocConstantModelName obj) => obj?.GetHashCode() ?? -17;
    }
}
