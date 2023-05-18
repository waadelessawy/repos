﻿using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XperienceAdapter.Extentions;
using XperienceAdapter.Repositories;
using XperienceAdapter.Services;

namespace Business.Repositories
{
    public class HomePageRepository : BasePageRepository<HomePage, CMS.DocumentEngine.Types.MedioClinic.HomePage>
    {
        public override void MapDtoProperties(CMS.DocumentEngine.Types.MedioClinic.HomePage page, HomePage dto)
        {
            dto.Perex = page.Perex;
            dto.Text = page.Text;
            dto.DoctorsLinkButtonText = page.DoctorsLinkButtonText;
            dto.ServicesLinkButtonText = page.ServicesLinkButtonText;
            var doctorsNode = page.Fields.DoctorsLink?.FirstOrDefault();
            var currentCulture = Thread.CurrentThread.CurrentUICulture.ToSiteCulture();

            if (doctorsNode != null && currentCulture != null)
            {
                dto.DoctorsUrl = _repositoryServices.PageUrlRetriever.Retrieve(doctorsNode, currentCulture.IsoCode).RelativePath;
            }
        }

        public HomePageRepository(IRepositoryServices repositoryServices) : base(repositoryServices)
        {
        }
    }
}
