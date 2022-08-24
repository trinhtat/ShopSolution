using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopSolution.Admin.Models;
using ShopSolution.ApiIntegration;
using ShopSolution.Utilities.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopSolution.Admin.Controllers.Components
{
    public class NavigationViewComponent: ViewComponent
    {
        private readonly ILanguageApiClient _languageApiClient;

        public NavigationViewComponent(ILanguageApiClient languageApiClient)
        {
            _languageApiClient = languageApiClient;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var languages = await _languageApiClient.GetAll();
            var navigationVm = new NavigationViewModel()
            {
                CurrenLanguageId = HttpContext.Session.GetString(SystemConstants.AppSettings.DefaultLanguaeId),
                Languaes = languages.ResultObj
            };

            return View("Default", navigationVm);
        }
        
    }
}
