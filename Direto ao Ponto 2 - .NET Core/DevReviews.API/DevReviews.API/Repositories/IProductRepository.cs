﻿using DevReviews.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevReviews.API.Repositories
{
    public interface IProductRepository
    {
        Task AddAsync(Product product);
        Task<Product> GetDetailsByIdAsync(int id);
        Task<Product> GetByIdAsync(int id);
        Task<List<Product>> GetAllAsync();
        Task UpdateAsync(Product product);

        Task<ProductReview> GetReviewByIdAsync(int id);
        Task AddReviewAsync(ProductReview productReview); 
    }
}