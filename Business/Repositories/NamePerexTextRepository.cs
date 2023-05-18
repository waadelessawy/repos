using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XperienceAdapter.Repositories;
using XperienceAdapter.Services;

namespace Business.Repositories
{
    public class NamePerexTextRepository : BasePageRepository<Models.NamePerexText, CMS.DocumentEngine.Types.MedioClinic.NamePerexText>
    {
        public NamePerexTextRepository(IRepositoryServices repositoryServices) : base(repositoryServices)
        {
        }

        public override void MapDtoProperties(CMS.DocumentEngine.Types.MedioClinic.NamePerexText page, Models.NamePerexText dto)
        {
            dto.Perex = page.Perex;
            dto.Text = page.Text;
        }
    }
}
