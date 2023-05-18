using Kentico.Content.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XperienceAdapter.Models
{
    public class PageAtthachment
    {
        public int Id { get; set; }

        public Guid Guid { get; set; }

        public string? Title { get; set; }

        public string? FileName { get; set; }

        public string? Extension { get; set; }

        public string? MimeType { get; set; }

        public IPageAttachmentUrl? AttachmentUrl { get; set; }
    }
}
