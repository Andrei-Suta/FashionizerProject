using FashionizerProject.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FashionizerProject.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Edition> Editions { get; set; }
        public DbSet<Stats> Stats { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductVariant>()
                .HasKey(p => new { p.ProductId, p.EditionId });

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Phones", Url = "phones", Icon = "phone" },
                new Category { Id = 2, Name = "Smartwatches", Url = "smartwatches", Icon = "watch" },
                new Category { Id = 3, Name = "Earphones", Url = "ear-phones", Icon = "aperture" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    CategoryId = 1,
                    Title = "Apple iPhone 12 Red 128GB",
                    Description = "The iPhone 12 and iPhone 12 Mini (stylized and marketed as iPhone 12 mini) are smartphones designed, developed, and marketed by Apple Inc.",
                    Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ8Qrz_OM7sCi3Rj_Z6i1uiVKpcAn1Oss5iviR2FkUQ9w1xnNlLbIPRY9povLrspM6xNqUVoE7q&usqp=CAc",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 2,
                    CategoryId = 1,
                    Title = "Apple iPhone 12 Blue 128GB",
                    Description = "The iPhone 12 and iPhone 12 Mini (stylized and marketed as iPhone 12 mini) are smartphones designed, developed, and marketed by Apple Inc.",
                    Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR8OTZkRMoSQMPy8Non_tDaKgZAysx3Lm67To0xpvVxNgbFLgfalvQrsB0s9aG3coUhjSGPPCg&usqp=CAc",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 3,
                    CategoryId = 1,
                    Title = "Apple iPhone 12 Gold 64GB",
                    Description = "The iPhone 12 and iPhone 12 Mini (stylized and marketed as iPhone 12 mini) are smartphones designed, developed, and marketed by Apple Inc.",
                    Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQD3ODxjJaqY11RN31VZkuG9xyHRehQgW-jo5XAJfw6zDEHAV9tcARWtrgr1xQbi3yJDm6RoV8&usqp=CAc",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 4,
                    CategoryId = 2,
                    Title = "AppleWatch S6",
                    Description = "The sixth generation of the Apple Watch was revealed during the September 15, 2020 Time Flies Apple Event. Additional new features include a new S6 processor (that is up to 20% faster than the S4 and S5),[98] a brighter always-on display, a blood oxygen app that works with a new in-watch sensor and an always-on altimeter.",
                    Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRhQRINSKm8QQsa92OWjg0RVSEvdoGieYhsKqX9mJbuDbidnxsB1W611GwqDA&usqp=CAc",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 5,
                    CategoryId = 2,
                    Title = "AppleWatch Special Edition Nude",
                    Description = "The Apple Watch SE only uses the S5 processor, does not have the ECG app and Blood Oxygen Sensor, and only comes with the 2nd generation Optical Heart Rate Sensor.",
                    Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRvzbfgTdpER5-rcDxRNb-wgfTDybd0U08fTy1NUpIGFLYCe8HFfZT9bnGSpd2COBFbPWvgIZk&usqp=CAc",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 6,
                    CategoryId = 2,
                    Title = "AppleWatch Special Edition Black",
                    Description = "The Apple Watch SE only uses the S5 processor, does not have the ECG app and Blood Oxygen Sensor, and only comes with the 2nd generation Optical Heart Rate Sensor.",
                    Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcStNAwkZtftUGIGQg0iMxVJkUq8uQ9_QlOokhRzOW9VVAg479qciaSF8MoivMU&usqp=CAc",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 7,
                    CategoryId = 3,
                    Title = "Apple Airpods 2",
                    Description = " They are the same design as the first generation, but have updated features.[21] They include an H1 processor which supports hands-free 'Hey Siri', Bluetooth 5 connectivity. Apple also claims 50% more talk time and faster device connection times.",
                    Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRZgMnY0Hoxn1DiEq8iAGTdDnz81KD8Lnocml2CMAmb-e5ydSm4gDOQMGZ-C4lXHukcgsXpWxE&usqp=CAc",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 8,
                    CategoryId = 3,
                    Title = "Apple AirPods Pro",
                    Description = "The AirPods Pro use the H1 chip also found in second-generation AirPods that supports hands-free 'Hey Siri'. They have active noise cancellation, accomplished by microphones detecting outside sound and speakers producing precisely opposite 'anti - noise'.",
                    Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRjzRbltmbqjR3qvPHNPw0T6F53tttudpBly67ceHs4_7_cB7vUQOX2xvPk0cwntolBYy23vAc&usqp=CAc",
                    DateCreated = new DateTime(2021, 1, 1)
                }
               
            );
            
            modelBuilder.Entity<Edition>().HasData(
                    new Edition { Id = 1, Name = "64GB" },
                    new Edition { Id = 2, Name = "128GB" },
                    new Edition { Id = 3, Name = "256GB" },
                    new Edition { Id = 4, Name = "White" },
                    new Edition { Id = 5, Name = "Black" },
                    new Edition { Id = 6, Name = "Nude" }
                );

            modelBuilder.Entity<ProductVariant>().HasData(
                new ProductVariant
                {
                    ProductId = 1,
                    EditionId = 1,
                    Price = 3899.99m,
                    OriginalPrice = 3899.99m
                },
                new ProductVariant
                {
                    ProductId = 1,
                    EditionId = 2,
                    Price = 4499.99m
                },
                new ProductVariant
                {
                    ProductId = 1,
                    EditionId = 3,
                    Price = 5299.99m,
                    OriginalPrice = 5599.99m
                },
                new ProductVariant
                {
                    ProductId = 2,
                    EditionId = 1,
                    Price = 3899.99m,
                    OriginalPrice = 3899.99m
                },
                new ProductVariant
                {
                    ProductId = 2,
                    EditionId = 2,
                    Price = 4499.99m
                },
                new ProductVariant
                {
                    ProductId = 2,
                    EditionId = 3,
                    Price = 5299.66m,
                    OriginalPrice = 5599.00m
                },
                new ProductVariant
                {
                    ProductId = 3,
                    EditionId = 1,
                    Price = 3899.99m,
                    OriginalPrice = 3899.99m
                },
                new ProductVariant
                {
                    ProductId = 3,
                    EditionId = 2,
                    Price = 4499.99m,
                    //OriginalPrice = 400m
                },
                new ProductVariant
                {
                    ProductId = 3,
                    EditionId = 3,
                    Price = 5299.99m,
                    OriginalPrice = 5599.99m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    EditionId = 5,
                    Price = 1999.99m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    EditionId = 6,
                    Price = 1999.99m
                    
                },
                new ProductVariant
                {
                    ProductId = 5,
                    EditionId = 6,
                    Price = 999.99m,
                    OriginalPrice = 1499.99m
                },
                new ProductVariant
                {
                    ProductId = 6,
                    EditionId = 5,
                    Price = 1499.99m
                },
                new ProductVariant
                {
                    ProductId = 7,
                    EditionId = 4,
                    Price = 649.99m
                },
                new ProductVariant
                {
                    ProductId = 7,
                    EditionId = 5,
                    Price = 649.99m
                },
                new ProductVariant
                {
                    ProductId = 8,
                    EditionId = 4,
                    Price = 1099.99m
                },
                new ProductVariant
                {
                    ProductId = 8,
                    EditionId = 5,
                    Price = 1099.99m
                }
            );
            
        }
    }
}