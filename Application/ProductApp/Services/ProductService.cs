using Application.ProductApp.Commands;
using Application.ProductApp.Interfaces;
using Application.ProductApp.Queries;
using Application.shared.Interfaces;
using Application.shared.Models;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Models;
using System.Net;

namespace Application.ProductApp.Services
{
    public class ProductService : IproductService
    {
        private IPlatformLogger<ProductService> _logger;
        private IProductRepository _productRepo;
        
        private IProductCategoryRepository _productCategoryRepo;
        private IProductBrandRepository _productBrandRepo;

        public ProductService(
            IPlatformLogger<ProductService> logger, 
            IProductRepository productRepo, 
            IProductCategoryRepository productCategoryRepo, 
            IProductBrandRepository productBrandRepo)
        {
            _logger = logger;
            _productRepo = productRepo;
            _productCategoryRepo = productCategoryRepo;
            _productBrandRepo = productBrandRepo;
        }



        #region CreateProduct
        public async Task<ShopHubResponseModel> CreateProductAsync(CreateProductCommand command)
        {
            var response = new ShopHubResponseModel();
            try
            {

                var matchedCategories = await _productCategoryRepo.GetProductCategoriesAsync(x => command.CategoryIds.Contains(x.ItemId));
                var product = new Product()
                {
                    BrandItemId = command.BrandId,
                    ItemId = Guid.NewGuid().ToString(),
                    ProductCode = command.ProductCode ?? $"{Guid.NewGuid().ToString()}_{command.Title}",
                    Categories = matchedCategories.ToList(),
                    Title = command.Title,
                };
                var isCreated = await _productRepo.InsertProductAsync(product);

                if (isCreated) return response.SetSuccess(HttpStatusCode.Created,"Product created successfully");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                response.SetError();
            }

            return response;
        }

        public async Task<ShopHubResponseModel> CreateProductCategoryAsync(CreateProductCategoryCommand query)
        {
            var response = new ShopHubResponseModel();

            var category = new ProductCategory
            {
                ItemId = Guid.NewGuid().ToString(),
                Title = query.Title,
            };

            var result = await _productCategoryRepo.CreateProductCategoryAsync(category);

            if (result)
            {
                response.SetSuccess(HttpStatusCode.Created, "Category Successfully Created");
            }
            else
            {
                response.SetError();
            }
            return response;
        }
        public async Task<ShopHubResponseModel> CreateProductBrandAsync(CreateProductBrandCommand query)
        {
            var response = new ShopHubResponseModel();

            var brand = new Brand
            {
                ItemId = Guid.NewGuid().ToString(),
                Country = query.Country,
                Name = query.Name,
            };

            var result = await _productBrandRepo.CreateProductBrandAsync(brand);

            if (result)
            {
                response.SetSuccess(HttpStatusCode.Created, "Brand Successfully Created");
            }
            else
            {
                response.SetError();
            }
            return response;
        }

        #endregion

        #region Get Single Product
        public async Task<ShopHubResponseModel> GetProductByIdAsync(string itemId)
        {
            var response = new ShopHubResponseModel();
            var result = await _productRepo.GetProductByIdAsync(itemId);

            return response.SetSuccess(result);
        }
        #endregion

        #region Get Single Category
        public async Task<ShopHubResponseModel> GetProductCategoryByIdAsync(string itemId)
        {
            var response = new ShopHubResponseModel();

            var result = await _productCategoryRepo.GetProductCategoryByIdAsync(itemId);

            return response.SetSuccess(result);
        }

        #endregion


        #region Get Many products
        public async Task<ShopHubResponseModel> GetProductsAsync(GetProductsQuery query)
        {

            var response = new ShopHubResponseModel();

            var dto = new SearchableProductsDto
            {
                BrandIds = query.BrandIds,
                CategoryIds = query.CategoryIds,
                IsAscendingSort = query.IsAscendingSort,
                MaximumPrice = query.MaximumPrice,
                MinimumPrice = query.MinimumPrice,
                PageNo = query.PageNo,
                PageSize = query.PageSize,
                SearchKey = query.SearchKey,
                SortBy = query.SortBy
            };

            var products = await _productRepo.GetProductsAsync(dto);

            return response.SetSuccess(products);
            
        }

        #endregion
    }
}
