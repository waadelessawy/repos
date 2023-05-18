﻿using Kentico.Content.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public class Doctor : User
    {
        public override IEnumerable<string> SourceColumns => base.SourceColumns.Concat(new[]
    {
        "Degree",
        "EmergencyShift",
        "Biography",
        "Specialty",
        "BackdropPicture"
    });

        /// <summary>
        /// Academic degree.
        /// </summary>
        public string? Degree { get; set; }

        /// <summary>
        /// Day of the doctor's emergency shift.
        /// </summary>
        public DayOfWeek? EmergencyShift { get; set; }

        public string? EmergencyShiftString { get; set; }

        /// <summary>
        /// Doctor's biography.
        /// </summary>
        public string? Biography { get; set; }

        /// <summary>
        /// Doctor's specialty.
        /// </summary>
        public string? Specialty { get; set; }

        /// <summary>
        /// Backdrop picture URL.
        /// </summary>
        public IPageAttachmentUrl? BackdropPictureUrl { get; set; }

        /// <summary>
        /// Doctor detail page URL.
        /// </summary>
        public string? DoctorDetailUrl { get; set; }
    
}
}
