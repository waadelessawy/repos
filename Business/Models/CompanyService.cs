using Kentico.Content.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XperienceAdapter.Models;

namespace Business.Models
{
    public class CompanyService : BasicPage
    {
        public override IEnumerable<string> SourceColumns => base.SourceColumns.Concat(new[] { "ServiceDescription", "Icon" });

        /// <summary>
        /// Textual service description.
        /// </summary>
        public string? ServiceDescription { get; set; }

        /// <summary>
        /// URL of the service icon file.
        /// </summary>
        public IPageAttachmentUrl? IconUrl { get; set; }
    }
}
