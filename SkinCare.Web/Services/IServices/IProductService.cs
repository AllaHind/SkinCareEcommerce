﻿using SkinCare.Web.Models;
using Microsoft.AspNetCore.Http.Features;

namespace SkinCare.Web.Services.IServices
{
    public interface IProductService:IBaseService
    {
        Task<T>GetAllProductsAsync<T>();
        Task<T> GetProductByIdAsync<T>(int id);   
        Task<T> CreateProductsAsync<T>(ProductDto productDto);
        Task<T> UpdateProductsAsync<T>(ProductDto productDto);
        Task<T> DeleteProductsAsync<T>(int id);

    }
}
