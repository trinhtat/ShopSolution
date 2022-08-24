using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using ShopSolution.ViewModels.Catalog.Categories;
using ShopSolution.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ShopSolution.ApiIntegration
{
    public class CategoryApiClient :BaseApiClient, ICategoryApiClient
    {
        public CategoryApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
        }

        public async Task<List<CategoryVm>> GetAll(string languaeId)
        {
            return await GetListAsync<CategoryVm>("/api/categories?languageId=" + languaeId);
        }

        public async Task<CategoryVm> GetById(string languageId, int id)
        {
            return await GetAsync<CategoryVm>($"/api/categories/{id}/{languageId}");
        }
    }
}
