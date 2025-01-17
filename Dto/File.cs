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

using Services.Core;
using Services.Dto.internals;
using Services.Enums;

using ServiceStack;
using ServiceStack.Text;

using Typed;
using Typed.Notifications;
using Typed.Bindings;

using Xtensive.Orm;


namespace Services.Dto
{
    public abstract partial class FileBase : Dto<File>
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public FileBase() {}

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public FileBase(int id) : this()
        {
            if(id > 0) Id = id;
        }

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public FileBase(int? id) : this(DocConvert.ToInt(id)) {}

        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public FileBase(int? pId, decimal? pCost, string pFileLabel, string pFileName, string pOriginalFileName, FileRightsEnm? pRights, List<Reference> pScopes, int? pScopesCount, FileSourceEnm? pSource, FileTypeEnm? pType) : this(DocConvert.ToInt(pId)) 
        {
            Cost = pCost;
            FileLabel = pFileLabel;
            FileName = pFileName;
            OriginalFileName = pOriginalFileName;
            Rights = pRights;
            Scopes = pScopes;
            ScopesCount = pScopesCount;
            Source = pSource;
            Type = pType;
        }

        [ApiMember(Name = nameof(Cost), Description = "decimal?", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public decimal? Cost { get; set; }


        [ApiMember(Name = nameof(FileLabel), Description = "string", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string FileLabel { get; set; }


        [ApiMember(Name = nameof(FileName), Description = "string", IsRequired = true)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string FileName { get; set; }


        [ApiMember(Name = nameof(OriginalFileName), Description = "string", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string OriginalFileName { get; set; }


        [ApiAllowableValues("Includes", Values = new string[] {@"Free",@"Restricted"})]
        [ApiMember(Name = nameof(Rights), Description = "FileRightsEnm?", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public FileRightsEnm? Rights { get; set; }


        [ApiMember(Name = nameof(Scopes), Description = "Scope", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<Reference> Scopes { get; set; }
        [ApiMember(Name = nameof(ScopesIds), Description = "Scope Ids", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public List<int> ScopesIds { get; set; }
        [ApiMember(Name = nameof(ScopesCount), Description = "Scope Count", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? ScopesCount { get; set; }


        [ApiAllowableValues("Includes", Values = new string[] {@"Client Supplied",@"Document Delivery",@"PMC/BMC",@"Publisher",@"Subscription",@"UCLA"})]
        [ApiMember(Name = nameof(Source), Description = "FileSourceEnm?", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public FileSourceEnm? Source { get; set; }


        [ApiAllowableValues("Includes", Values = new string[] {@"Document Set",@"Errata",@"Full Text",@"Protocol",@"Supplemental"})]
        [ApiMember(Name = nameof(Type), Description = "FileTypeEnm?", IsRequired = false)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public FileTypeEnm? Type { get; set; }



        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public void Deconstruct(out decimal? pCost, out string pFileLabel, out string pFileName, out string pOriginalFileName, out FileRightsEnm? pRights, out List<Reference> pScopes, out int? pScopesCount, out FileSourceEnm? pSource, out FileTypeEnm? pType)
        {
            pCost = Cost;
            pFileLabel = FileLabel;
            pFileName = FileName;
            pOriginalFileName = OriginalFileName;
            pRights = Rights;
            pScopes = Scopes;
            pScopesCount = ScopesCount;
            pSource = Source;
            pType = Type;
        }

        //Not ready until C# v8.?
        //[GeneratedCodeAttribute("T4", "1.0.0.0")]
        //public FileBase With(int? pId = Id, decimal? pCost = Cost, string pFileLabel = FileLabel, string pFileName = FileName, string pOriginalFileName = OriginalFileName, FileRightsEnm? pRights = Rights, List<Reference> pScopes = Scopes, int? pScopesCount = ScopesCount, FileSourceEnm? pSource = Source, FileTypeEnm? pType = Type) => 
        //	new FileBase(pId, pCost, pFileLabel, pFileName, pOriginalFileName, pRights, pScopes, pScopesCount, pSource, pType);

    }


    [Route("/file", "POST")]
    [Route("/file/{Id}", "GET, PATCH, PUT, DELETE")]

    public partial class File : FileBase, IReturn<File>, IDto, ICloneable
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public File() => _Constructor();
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public File(int? id) : base(DocConvert.ToInt(id)) {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public File(int id) : base(id) {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public File(int? pId, decimal? pCost, string pFileLabel, string pFileName, string pOriginalFileName, FileRightsEnm? pRights, List<Reference> pScopes, int? pScopesCount, FileSourceEnm? pSource, FileTypeEnm? pType) :
            base(pId, pCost, pFileLabel, pFileName, pOriginalFileName, pRights, pScopes, pScopesCount, pSource, pType) { }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public static List<string> Fields => DocTools.Fields<File>();

        private List<string> _Select;
        [ApiMember(Name = nameof(Select), Description = "The list of fields to include in the response", AllowMultiple = true, IsRequired = true)]
        [ApiAllowableValues("Includes", Values = new string[] {nameof(Cost),nameof(Created),nameof(CreatorId),nameof(FileLabel),nameof(FileName),nameof(Gestalt),nameof(Locked),nameof(OriginalFileName),nameof(Rights),nameof(Scopes),nameof(ScopesCount),nameof(Source),nameof(Type),nameof(Updated),nameof(VersionNo)})]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override List<string> Select
        {
            get
            {
                if(null == this) return new List<string>();
                if(null == _Select)
                {

                    _Select = DocWebSession.GetTypeSelect(this);

                }
                return _Select;
            }
            set
            {

                var requested = value ?? new List<string>();
                var exists = requested.Where( r => Fields.Any( f => DocTools.AreEqual(r, f) ) ).ToList();
                _Select = DocPermissionFactory.SetSelect<File>("File",exists);

            }
        }

        [Obsolete, ApiMember(Name = "VisibleFields", Description = "Deprecated. Use Select instead.", AllowMultiple = true)]
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public override List<string> VisibleFields { get => Select; set => Select = value; }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private List<string> _collections = new List<string>
        {
            nameof(Scopes), nameof(ScopesCount), nameof(ScopesIds)
        };
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private List<string> collections { get { return _collections; } }


        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public object Clone() => this.Copy<File>();

    }
    

    [Route("/file/{Id}/copy", "POST")]
    public partial class FileCopy : File {}

    public partial class FileSearchBase : Search<File>
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public int? Id { get; set; }
        public decimal? Cost { get; set; }
        public string FileLabel { get; set; }
        public List<string> FileLabels { get; set; }
        public string FileName { get; set; }
        public List<string> FileNames { get; set; }
        public string OriginalFileName { get; set; }
        public List<string> OriginalFileNames { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"Free",@"Restricted"})]
        public FileRightsEnm? Rights { get; set; }
        public List<FileRightsEnm?> Rightss { get; set; }
        public List<int> ScopesIds { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"Client Supplied",@"Document Delivery",@"PMC/BMC",@"Publisher",@"Subscription",@"UCLA"})]
        public FileSourceEnm? Source { get; set; }
        public List<FileSourceEnm?> Sources { get; set; }
        [ApiAllowableValues("Includes", Values = new string[] {@"Document Set",@"Errata",@"Full Text",@"Protocol",@"Supplemental"})]
        public FileTypeEnm? Type { get; set; }
        public List<FileTypeEnm> Types { get; set; }
    }


    [Route("/file", "GET")]
    [Route("/file/version", "GET, POST")]
    [Route("/file/search", "GET, POST, DELETE")]

    public partial class FileSearch : FileSearchBase
    {
    }

    public class FileFullTextSearch
    {
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public FileFullTextSearch() {}
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        private FileSearch _request;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public FileFullTextSearch(FileSearch request) => _request = request;
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public string fts { get => _request.FullTextSearch?.TrimAndPruneSpaces(); }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool isBool { get => (fts == "1" || fts == "0" || fts.ToLower() == "true" || fts.ToLower() == "false"); }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool ftsBool { get => DocConvert.ToBool(fts); }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public DateTime ftsDate { get => DocConvert.ToDateTime(fts); }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool isDate { get => ftsDate != DateTime.MinValue; }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool doCreated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(File.Created))); }
        [GeneratedCodeAttribute("T4", "1.0.0.0")]
        public bool doUpdated { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(File.Updated))); }

        public bool doCost { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(File.Cost))); }
        public bool doFileLabel { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(File.FileLabel))); }
        public bool doFileName { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(File.FileName))); }
        public bool doOriginalFileName { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(File.OriginalFileName))); }
        public bool doRights { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(File.Rights))); }
        public bool doScopes { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(File.Scopes))); }
        public bool doSource { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(File.Source))); }
        public bool doType { get => true == _request.Select?.Any(v => DocTools.AreEqual(v, nameof(File.Type))); }
    }


    [Route("/file/batch", "DELETE, PATCH, POST, PUT")]

    public partial class FileBatch : List<File> { }


    [Route("/file/{Id}/{Junction}/version", "GET, POST")]
    [Route("/file/{Id}/{Junction}", "GET, POST, DELETE")]
    public class FileJunction : FileSearchBase {}



}
