using ShopSolution.ViewModels.System.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopSolution.Admin.Models
{
    public class NavigationViewModel
    {
        public List<LanguageVm> Languaes { get; set; }
        public string CurrenLanguageId { get; set; }

        public string ReturnUrl { set; get; }
    }
}
