//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated by a T4 template. This class can be only customized modifying the corresponding partial class.
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
    public abstract partial class DataTabBase : Dto<DataTab>
    {
        public DataTabBase() {}

        public DataTabBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        public DataTabBase(int? id) : this(DocConvert.ToInt(id)) {}

        [ApiMember(Name = nameof(Class), Description = "DataClass", IsRequired = true)]
        public Reference Class { get; set; }
        [ApiMember(Name = nameof(ClassId), Description = "Primary Key of DataClass", IsRequired = false)]
        public int? ClassId { get; set; }


        [ApiMember(Name = nameof(Description), Description = "string", IsRequired = false)]
        public string Description { get; set; }


        [ApiMember(Name = nameof(Name), Description = "string", IsRequired = true)]
        public string Name { get; set; }


        [ApiMember(Name = nameof(Order), Description = "int?", IsRequired = false)]
        public int? Order { get; set; }


    }

    [Route("/datatab/{Id}", "GET, PATCH, PUT")]
    public partial class DataTab : DataTabBase, IReturn<DataTab>, IDto
    {
        public DataTab()
        {
            _Constructor();
        }

        public DataTab(int? id) : base(DocConvert.ToInt(id)) {}
        public DataTab(int id) : base(id) {}
        
        #region Fields
        
        public bool? ShouldSerialize(string field)
        {
            if (IgnoredVisibleFields.Matches(field, true)) return false;
            var ret = MandatoryVisibleFields.Matches(field, true) || true == VisibleFields?.Matches(field, true);
            return ret;
        }

        public static List<string> Fields => DocTools.Fields<DataTab>();

        private List<string> _VisibleFields;
        [ApiMember(Name = "VisibleFields", Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Class),nameof(ClassId),nameof(Created),nameof(CreatorId),nameof(Description),nameof(Gestalt),nameof(Locked),nameof(Name),nameof(Order),nameof(Updated),nameof(VersionNo)})]
        public new List<string> VisibleFields
        {
            get
            {
                if(null == this) return new List<string>();
                if(null == _VisibleFields)
                {
                    _VisibleFields = DocPermissionFactory.RemoveNonEssentialFields(Fields);
                }
                return _VisibleFields;
            }
            set
            {
                _VisibleFields = Fields;
            }
        }

        #endregion Fields
    }
    
    public partial class DataTabSearchBase : Search<DataTab>
    {
        public int? Id { get; set; }
        public Reference Class { get; set; }
        public List<int> ClassIds { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public int? Order { get; set; }
    }

    [Route("/datatab", "GET")]
    [Route("/datatab/version", "GET, POST")]
    [Route("/datatab/search", "GET, POST, DELETE")]
    public partial class DataTabSearch : DataTabSearchBase
    {
    }

    public class DataTabFullTextSearch
    {
        public DataTabFullTextSearch() {}
        private DataTabSearch _request;
        public DataTabFullTextSearch(DataTabSearch request) => _request = request;

        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        public bool doCreated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataTab.Created))); }
        public bool doUpdated { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataTab.Updated))); }

        public bool doClass { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataTab.Class))); }
        public bool doDescription { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataTab.Description))); }
        public bool doName { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataTab.Name))); }
        public bool doOrder { get => true == _request.VisibleFields?.Any(v => DocTools.AreEqual(v, nameof(DataTab.Order))); }
    }

    [Route("/datatab/batch", "DELETE, PATCH, POST, PUT")]
    public partial class DataTabBatch : List<DataTab> { }

}
