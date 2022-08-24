using ShopSolution.ViewModels.Catalog.Categories;
using ShopSolution.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopSolution.ApiIntegration
{
    public interface ICategoryApiClient
    {
        Task<List<CategoryVm>> GetAll(string languaeId);
        Task<CategoryVm> GetById(string languageId, int id);
    }
}
