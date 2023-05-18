using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XperienceAdapter.Models
{
    public class BasicPage
    {
        public virtual IEnumerable<string> SourceColumns => new List<string>
    {
        "DocumentID",
        "DocumentGUID",
        "DocumentName",
        "DocumentCulture",
        "NodeID",
        "NodeGUID",
        "NodeAliasPath",
        "NodeParentID",
        "NodeSiteID",
        "NodeLevel",
        "NodeOrder"
    };

        public int NodeId { get; set; }

        public Guid Guid { get; set; }

        public string? Name { get; set; }

        public string? NodeAliasPath { get; set; }

        public int? ParentId { get; set; }

        /// <summary>
        /// In the form of RFC 5646 (e.g. "en-US").
        /// </summary>
        public SiteCulture? Culture { get; set; }

        public IList<PageAtthachment> Attachments { get; } = new List<PageAtthachment>();
    }
}
