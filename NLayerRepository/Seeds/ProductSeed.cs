﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Models;

namespace NLayer.Repository.Seeds
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { Id = 1, CategoryId = 1, Name = "Kalme 1", Price = 100, Stock = 20, CreatedDate = DateTime.Now },
                new Product { Id = 2, CategoryId = 1, Name = "Kalme 2", Price = 200, Stock = 30, CreatedDate = DateTime.Now },
                new Product { Id = 3, CategoryId = 2, Name = "Kalme 3", Price = 300, Stock = 40, CreatedDate = DateTime.Now },
                new Product { Id = 4, CategoryId = 1, Name = "Kalme 4", Price = 400, Stock = 50, CreatedDate = DateTime.Now });
        }
    }
}
