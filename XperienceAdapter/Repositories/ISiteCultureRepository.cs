using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XperienceAdapter.Models;

namespace XperienceAdapter.Repositories
{
    public interface ISiteCultureRepository : IRepository<SiteCulture>
    {
        SiteCulture? DefaultSiteCulture { get; }

        /// <summary>
        /// Gets culture by its RFC 5646 culture (e.g. "en-US").
        /// </summary>
        /// <param name="isoCode"></param>
        /// <returns></returns>
        SiteCulture? GetByExactIsoCode(string isoCode);
    }
}
