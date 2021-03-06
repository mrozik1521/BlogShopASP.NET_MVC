﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using SklepBlog.Models;
using BlogShopMVC.Migrations;
using System.Data.Entity.Migrations;

namespace BlogShopMVC.DAL
{
    public class ShopInitializer : MigrateDatabaseToLatestVersion<ShopContext, Configuration>
    {
        public static void SeedShopData(ShopContext context)
        {
            var categories = new List<Category>
            {
                new Category (){ CategoryDescription = "Kubki, smycze, wlepy", CategoryId = 1, CategoryName = "Akcesoria", IconFileName = "xyz2", },
                new Category (){ CategoryDescription = "Koszulki, koszulki polo", CategoryId = 2, CategoryName = "Koszulki", IconFileName = "xyz3", },
                new Category (){ CategoryDescription = "Płyty winyle + blueray", CategoryId = 3, CategoryName = "Płyty", IconFileName = "xyz4", },
                new Category (){ CategoryDescription = "Ksiżąki, gazety", CategoryId = 4, CategoryName = "Książki", IconFileName = "xyz2", },
                new Category (){ CategoryDescription = "Upominki", CategoryId = 5, CategoryName = "Upominki", IconFileName = "xyz2",}
            };
            categories.ForEach(k => context.Categories.AddOrUpdate(k));
            context.SaveChanges();

            var products = new List<Product>
            {
                new Product(){ CategoryId = 1, ProductId = 1, ProductMake = "Bloger", ProductModel = "Kubek niebieski", ProductPrice = (decimal) 4.99, IconProductFileName = "xyz2.png"},
                new Product(){ CategoryId = 1, ProductId = 2, ProductMake = "Bloger", ProductModel = "Kubek Szary", ProductPrice = (decimal) 12.99, IconProductFileName = "xyz2.png"},
                new Product(){ CategoryId = 1, ProductId = 3, ProductMake = "Bloger", ProductModel = "Kubek Biały", ProductPrice = (decimal) 12.99, IconProductFileName = "xyz2.png"},
                new Product(){ CategoryId = 1, ProductId = 4, ProductMake = "Bloger", ProductModel = "Kubek Czarny", ProductPrice = (decimal) 8.99, IconProductFileName = "xyz2.png"},
                new Product(){ CategoryId = 2, ProductId = 5, ProductMake = "Bloger", ProductModel = "Koszulka biała", ProductPrice = (decimal) 44.99, IconProductFileName = "xyz3.png"},
                new Product(){ CategoryId = 2, ProductId = 6, ProductMake = "Bloger", ProductModel = "Koszulka czarna", ProductPrice = (decimal) 39.99, IconProductFileName = "xyz3.png"},
                new Product(){ CategoryId = 2, ProductId = 7, ProductMake = "Bloger", ProductModel = "Koszulka Polo", ProductPrice = 77, IconProductFileName = "xyz3.png"},
                new Product(){ CategoryId = 3, ProductId = 8, ProductMake = "Bloger", ProductModel = "Płyta z blogami 2019", ProductPrice = (decimal) 0.99, IconProductFileName = "xyz4.png"},
                new Product(){ CategoryId = 3, ProductId = 9, ProductMake = "Bloger", ProductModel = "Płyta z blogami 2018", ProductPrice = (decimal) 2.09, IconProductFileName = "xyz4.png"},
                new Product(){ CategoryId = 4, ProductId = 10, ProductMake = "Bloger", ProductModel = "Poradnik", ProductPrice = (decimal) 2.99, IconProductFileName = "xyz5.png"},
                new Product(){ CategoryId = 5, ProductId = 11, ProductMake = "Bloger", ProductModel = "Przygody blogera", ProductPrice = (decimal) 22.99, IconProductFileName = "xyz5.png"},
                new Product(){ CategoryId = 5, ProductId = 12, ProductMake = "Bloger", ProductModel = "Album", ProductPrice = (decimal) 52.99, IconProductFileName = "xyz5.png"},
                new Product(){ CategoryId = 5, ProductId = 13, ProductMake = "Bloger", ProductModel = "Płyta z blogami 2017", ProductPrice = (decimal) 5.25, IconProductFileName = "xyz4.png"},

            };
            products.ForEach(p => context.Products.AddOrUpdate(p));
            context.SaveChanges();

            var articles = new List<Article>
            {
                new Article()
                {
                    ArticleId = 1, ArticleContent = "Azdsadcdsaddsfaasd sadf", ArticleImportant = false, ArticleShortcut = "desfbhfjsbfvjsbfjsbfjsbdfjsbdfcjsbdfjsbfujs nfkaessbnfksafbnekesaf" + "dfskjnsfdkjndsknf dsa as",
                    ArticleTitle = "fdsfsf1sfds dsfdsfdfs!!!!!", NameOfImageArticle = "xyz2.png"
                },
                new Article()
                {
                ArticleId = 2, ArticleContent = "Azdsadcdsadfasfa dsfadassadf", ArticleImportant = false, ArticleShortcut = "desfbhfjsbfvjsbfjsbfjsbdfjsbdfcjsbdfjsbfujs nfkaessbnfksafbnekesaf" + "dfskjnsfdkjndsknf dsa as",
                ArticleTitle = "fdsfsfsf2ds dsfdsfdfs!!!!!", NameOfImageArticle = "xyz2.png"
                },
                new Article()
                {
                ArticleId = 3, ArticleContent = "Azdsadc432asfa dsfad asd sadf", ArticleImportant = false, ArticleShortcut = "desfbhfjsbfvjsbfjsbfjsbdfjsbdfcjsbdfjsbfujs nfkaessbnfksafbnekesaf" + "dfskjnsfdkjndsknf dsa as",
                ArticleTitle = "fdsfsfs3fds dsfdsfdfs!!!!!", NameOfImageArticle = "xyz2.png"
                },
                new Article()
                {
                    ArticleId = 4, ArticleContent = "Azdsamjmjdcdsadfasfa dsfad asd sadf", ArticleImportant = false, ArticleShortcut = "desfbhfjsbfvjsbfjsbfjsbdfjsbdfcjsbdfjsbfujs nfkaessbnfksafbnekesaf" + "dfskjnsfdkjndsknf dsa as",
                    ArticleTitle = "fdsf4sfsfds dsfdsfdfs!!!!!", NameOfImageArticle = "xyz2.png"
                },

            };
            articles.ForEach(a => context.Articles.AddOrUpdate(a));
            context.SaveChanges();
        }
    }
}