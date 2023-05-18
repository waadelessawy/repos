using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XperienceAdapter.Repositories;
using XperienceAdapter.Services;

namespace Business.Repositories
{
    public class CompanyRepository : BasePageRepository<Models.Company, CMS.DocumentEngine.Types.MedioClinic.Company>
    {
        public override void MapDtoProperties(CMS.DocumentEngine.Types.MedioClinic.Company page, Models.Company dto)
        {
            dto.City = page.City;
            dto.Country = page.Country;
            dto.EmailAddress = page.EmailAddress;
            dto.PhoneNumber = page.PhoneNumber;
            dto.PostalCode = page.PostalCode;
            dto.Street = page.Street;
        }

        public CompanyRepository(IRepositoryServices repositoryDependencies) : base(repositoryDependencies)
        {
        }
    }
}
