using Microsoft.AspNetCore.Http;
using ShopSolution.ViewModels.Catalog.ProductImages;
using ShopSolution.ViewModels.Catalog.Products;
using ShopSolution.ViewModels.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopSolution.Application.Catalog.Products
{
    public interface IProductService
    {
        Task<int> Create(ProductCreateRequest request);
        Task<int> Update(ProductUpdateRequest request);
        Task<int> Delete(int ProductID);
        Task<ProductVm> GetById(int productId, string languageId);
        Task<bool> UpdatePrice(int productId, decimal newPrice);
        Task<bool> UpdateStock(int productId, int addedQuantity);
        Task AddViewCount(int productId);
        Task<PagedResult<ProductVm>> GetAllPaging(GetManageProductPagingRequest request);
        Task<int> AddImage(int productId, ProductImagesCreateRequest request);
        Task<int> RemoveImage(int imageId); 
        Task<int> UpdateImage(int imageId, ProductImagesUpdateRequest request);
        Task<ProductImageViewModel> GetImageById(int imageId);
        Task<List<ProductImageViewModel>> GetListImages(int productId);

        Task<PagedResult<ProductVm>> GetAllByCategoryId(string languageId, GetPublicProductPagingRequest request);
        Task<ApiResult<bool>> CategoryAssign(int id, CategoryAssignRequest request);
        Task<List<ProductVm>> GetFeaturedProducts(string languageId, int take);
        Task<List<ProductVm>> GetLatestProducts(string languageId, int take);
    }
}
