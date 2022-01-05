using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace API.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext dbContext)
        {
            if (dbContext.Products.Any()) return;

            var products = new List<Product>
            {
                new Product
                {
                    Id = 1, Name = "P001",
                    Description = "Product 001",
                    Price = 100,
                    PictureUrl = "https://picsum.photos/200",
                    Type = "Type 1",
                    Brand = "Brand A",
                    QuantityInStock = 100
                },
                new Product
                {
                    Id = 2, Name = "P002",
                    Description = "Product 002",
                    Price = 200,
                    PictureUrl = "https://picsum.photos/200",
                    Type = "Type 1",
                    Brand = "Brand A",
                    QuantityInStock = 100
                },
                new Product
                {
                    Id = 3, Name = "P003",
                    Description = "Product 003",
                    Price = 300,
                    PictureUrl = "https://picsum.photos/200",
                    Type = "Type 2",
                    Brand = "Brand B",
                    QuantityInStock = 100
                },
                new Product
                {
                    Id = 4, Name = "P004",
                    Description = "Product 004",
                    Price = 400,
                    PictureUrl = "https://picsum.photos/200",
                    Type = "Type 2",
                    Brand = "Brand B",
                    QuantityInStock = 100
                },
                new Product
                {
                    Id = 5, Name = "P005",
                    Description = "Product 005",
                    Price = 500,
                    PictureUrl = "https://picsum.photos/200",
                    Type = "Type 3",
                    Brand = "Brand C",
                    QuantityInStock = 100
                },
                new Product
                {
                    Id = 6,
                    Name = "P006",
                    Description = "Product 006",
                    Price = 600,
                    PictureUrl = "https://picsum.photos/200",
                    Type = "Type 4",
                    Brand = "Brand E",
                    QuantityInStock = 100
                },
                new Product
                {
                    Id = 7,
                    Name = "P007",
                    Description = "Product 007",
                    Price = 700,
                    PictureUrl = "https://picsum.photos/200",
                    Type = "Type 5",
                    Brand = "Brand E",
                    QuantityInStock = 100
                },
                new Product
                {
                    Id = 8,
                    Name = "P008",
                    Description = "Product 008",
                    Price = 800,
                    PictureUrl = "https://picsum.photos/200",
                    Type = "Type G",
                    Brand = "Brand AB",
                    QuantityInStock = 100
                },
                new Product
                {
                    Id = 9, Name = "P0019",
                    Description = "Product 009",
                    Price = 900,
                    PictureUrl = "https://picsum.photos/200",
                    Type = "Type 11",
                    Brand = "Brand AA",
                    QuantityInStock = 100
                },
                new Product
                {
                    Id = 10,
                    Name = "P0010",
                    Description = "Product 0010",
                    Price = 1000,
                    PictureUrl = "https://picsum.photos/200",
                    Type = "Type 12",
                    Brand = "Brand AB",
                    QuantityInStock = 100
                },
            };

            dbContext.Products.AddRange(products);
            dbContext.SaveChanges();
        }

    }
}