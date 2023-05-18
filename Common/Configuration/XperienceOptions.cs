using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Configuration
{
    public class XperienceOptions
    {
        /// <summary>
        /// Friendly name of the company.
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// Site code name.
        /// </summary>
        public string SiteCodeName { get; set; }

        public MediaLibraryOptions MediaLibraryOptions { get; set; }
    }

    public class MediaLibraryOptions
    {
        /// Image formats allowed in the site.
        /// </summary>
        public string[] AllowedImageExtensions { get; set; }

        /// <summary>
        /// File size limit.
        /// </summary>
        public long FileSizeLimit { get; set; }
    }
}
