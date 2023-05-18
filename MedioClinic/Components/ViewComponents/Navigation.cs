#define no_suffix
using Business.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Threading;
using System;
using XperienceAdapter.Extentions;

namespace MedioClinic.Components.ViewComponents
{
    public class Navigation : ViewComponent
    {
        private readonly INavigationRepository _navigationRepository;

        public Navigation(INavigationRepository navigationRepository)
        {
            _navigationRepository = navigationRepository ?? throw new ArgumentNullException(nameof(navigationRepository));
        }

        public async Task<IViewComponentResult> InvokeAsync(string placement)
        {
            var currentCulture = Thread.CurrentThread.CurrentUICulture.ToSiteCulture();
            var navigation = await _navigationRepository.GetNavigationAsync(currentCulture);

            return View(placement, navigation);
        }
    }
}
