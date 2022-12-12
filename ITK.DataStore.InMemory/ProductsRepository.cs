using ITK.Core;
using ITK.UseCases.DataStoreInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITK.DataStore.InMemory
{
    public class ProductsRepository : IProductsRepository
    {
        private List<Product> _products;

        public ProductsRepository()
        {
            _products = new List<Product>()
            {
                new Product { Id = 1,  CategoryId = 1000, Title = "Philips Premium XXL Airfryer", Description = $"Philips Premium XXL Airfryer - 7.3 Litres, 2225 W, Fat Removal Technology, Recipes (NutriU App), Keep Warm Function, Extra Large Size for the Entire Family. ", Price = 299.00m, Image = "Philips-Premium-XXL-Airfryer"},
                new Product { Id = 2,   CategoryId = 1000, Title = "Tefal EasyFry XXL 2-in-1 Digital Air Fryer & Grill", Description = "Tefal EasyFry XXL 2-in-1 Digital Air Fryer & Grill, With Draw Divider, 6.5L Capacity, 8 Programs, Black", Price = 139.00m, Image = "Tefa-EasyFry-XXL-2-in-1.jpg"},
                new Product { Id = 3,   CategoryId = 1000, Title = "Instant Vortex 4-in-1 Digital Air Fryer", Description = "Instant Vortex 4-in-1 Digital Air Fryer, Health Air Fryer, Bake, Roast and Reheat, 1700W of Power with Timer, Non-Stick – 5.7 Litre ", Price = 99.99m, Image = "Instant-Vortex-4-in-1-Digital-Air-Fryer.jpg"},
                new Product { Id = 4,   CategoryId = 1000, Title = "NINJA Foodi 11-in-1 SmartLid Multi-Cooker 6L", Description = "NINJA Foodi 11-in-1 SmartLid Multi-Cooker 6L Electric Pressure Cooker, Air Fryer, Combi-Steam, Slow Cooker, Grill, Bake ", Price = 279.00m, Image = "NINJA-Foodi-11-in-1-SmartLid-Multi-Cooker.jpg"},
                new Product { Id = 5,   CategoryId = 1000, Title = "Sage the Smart Oven Air Fryer Countertop Oven", Description = "Sage the Smart Oven Air Fryer Countertop Oven 22L, Stainless Steel ", Price = 204.00m, Image = "Sage-Smart-Oven-Air-Fryer-Countertop-Oven.jpg"},
                new Product { Id = 6,   CategoryId = 1000, Title = "Instant Vortex Plus Dual Basket 8-in-1 Air Fry", Description = "Instant Vortex Plus Dual Basket with ClearCook - 7.6L Digital Health Air Fryer, Stainless Steel, 8-in-1 Smart Programmes - Air Fry, Bake, Roast, Grill, Dehydrate, Reheat, XL Capacity -1700W ", Price = 220.0m, Image = "Instant-Vortex-Plus-Air-Fryer-8-in-1.jpg"},
                new Product { Id = 7,   CategoryId = 1000, Title = "Instant Pot Duo 7-in-1 Smart Cooker, 5.7L - Pressure Cooker", Description = "Instant Pot Duo 7-in-1 Smart Cooker, 5.7L - Pressure Cooker, Slow Cooker, Rice Cooker, Sauté Pan, Yoghurt Maker, Steamer and Food Warmer, Brushed Stainless Steel ", Price = 83.27m, Image = "Instant-Pot-Duo-7-in-1-Pressure-Cooker-Slow-Cooker.jpg"},
                new Product { Id = 8,   CategoryId = 1002, Title = "Sage the Custom Loaf Pro Bread Maker", Description = "Sage the Custom Loaf Pro Bread Maker - Silver ", Price = 125.00m, Image = "Sage-Custom-Loaf-Pro-Bread-Maker.jpg" },
                new Product { Id = 9,   CategoryId = 1002, Title = "Panasonic Fully Automatic Breadmaker", Description = "Panasonic Fully Automatic Breadmaker, with yeast & nut dispensers, Manual Settings for Bread & Rising, Dual Temperature Sensors, 13 Hours Digital Timer", Price = 179.00m, Image = "Panasonic-Automatic-Breadmaker.jpg" },
                new Product { Id = 10,   CategoryId = 1002, Title = "Automatic Bread Machine, Family Bread Maker", Description = "Automatic Bread Machine, Family Bread Maker Professional Non-Stick Breadmaker with Automatic Fruit Nuts Dispenser, 17 Progammes, 15 Hours Timing, 500g /750g/ 1000g Weight Settings ", Price = 199.00m, Image = "Automatic-Bread-Machine-Breadmaker-Automatic.jpg" },
                new Product { Id = 11,   CategoryId = 1000, Title = "TOKIT Omni Cook Robot All-in-1 Food Processor", Description = "TOKIT Omni Cook Robot All-in-1 Food Processor with 21 Cooking Functions Built-in 7'' Touch Screen Guided Recipes Pre-clean, Chopper, Juicer, Blender, Mixer, Weigh, Sous-Vide, Ice Crush and more ", Price = 1057.89m, Image = "TOKIT-Omni-Cook-Robot-All-in-1.jpg"},
                new Product { Id = 12,   CategoryId = 1007, Title = "Moulinex Cuisine Companion Kitchen Robot", Description = "Moulinex Cuisine Companion Kitchen Robot, 6 Automatic Programmes, Capacity for up to 6 People Cuisine Companion White ", Price = 1599.00m, Image = "Moulinex-Cuisine-Companion-Kitchen-Robot.jpg"},
                new Product { Id = 13,   CategoryId = 1007, Title = "Microplane Zester Grater - Black", Description = "Microplane Zester Grater in Black for Citrus Fruits, Hard Cheese, Ginger, Chocolate and Nutmeg with Fine Stainless Steel Blade - Made in USA ", Price = 17.94m, Image = "Microplane-Zester-Grater-Black.jpg"},
                new Product { Id = 14,   CategoryId = 1007, Title = "Global 19cm Fluted Blade", Description = "Global 35th Anniversary Special Edition Pro Chef’s Knife with 19cm Fluted Blade – Cromova 18 high Carbon Stainless Steel ", Price = 99.95m, Image = "Global-19cm-Fluted-Blade.jpg"},
                new Product { Id = 15,   CategoryId = 1007, Title = "Global 2-Piece Knife and Sharpener Set", Description = "Global 2-Piece Knife and Sharpener Set - Contains G-2 Cook's Knife and Minosharp Knife Sharpener, Silver, (G-220B) ", Price = 139.95m, Image = "Global-2-Piece-Knife-and-Sharpener-Set.jpg"},
                new Product { Id = 16,   CategoryId = 1004, Title = "Sage Barista Express Espresso Machine - Brushed Stainless Steel", Description = "Sage Barista Express Espresso Machine - Espresso and Coffee Maker, Bean to Cup Coffee Machine, BES875UK , Brushed Stainless Steel ", Price = 593.00m, Image = "Sage-Barista-Express-Espresso-Machine.jpg"},
                new Product { Id = 17,   CategoryId = 1004, Title = "Sage Dual Boiler Espresso Machine - Silver ", Description = "Sage BES920UK the Dual Boiler Espresso Machine - Silver ", Price = 1156.96m, Image = "Sage-Dual-Boiler-Espresso-Machine.jpg"},
                new Product { Id = 18,   CategoryId = 1004, Title = "De'Longhi Eletta Cappuccino Machine - White ", Description = "De'Longhi Eletta Cappuccino, Fully Automatic Bean to Cup Machine, Espresso, Coffee Maker, White ", Price = 616.49m, Image = "De'Longhi-Eletta-Bean-to-Cup-Machine.jpg"},
                new Product { Id = 19,   CategoryId = 1004, Title = "Siemens Home Connect Bean to Cup Coffee Machine - Anthracite", Description = "Siemens TP705GB1 EQ700 Home Connect Bean to Cup Fully Automatic Freestanding Coffee Machine - Anthracite ", Price = 799.00m, Image = "Siemens-Freestanding-Coffee-Machine.jpg"},
                new Product { Id = 20,   CategoryId = 1004, Title = "SodaStream Terra Sparkling Water Maker – Black ", Description = "SodaStream Terra Sparkling Water Maker Machine, with 1 Litre Reusable BPA-Free Water Bottle for Carbonating & 60 Litre Quick Connect CO2 Gas Cylinder – Black ", Price = 68.99m, Image = "SodaStream-Terra-Sparkling-Water-Maker–Black.jpg"}*/ /*,
                new Product { Id = 21,   CategoryId = "", Title = "", Description = "", Price = "", Image = ""},
                new Product { Id = 22,   CategoryId = "", Title = "", Description = "", Price = "", Image = ""},
                new Product { Id = 23,   CategoryId = "", Title = "", Description = "", Price = "", Image = ""},
                new Product { Id = 24,   CategoryId = "", Title = "", Description = "", Price = "", Image = ""},
                new Product { Id = 25,   CategoryId = "", Title = "", Description = "", Price = "", Image = ""},*/
            };
        }

        public Task AddProductAsync(Product product)
        {
            //  Prevent duplicate
            if (_products.Any(x => x.Title.Equals(product.Title, StringComparison.OrdinalIgnoreCase)))
                return Task.CompletedTask;

            var maxId = _products.Max(x => x.Id);
            product.Id = maxId + 1;

            _products.Add(product);

            return Task.CompletedTask;
        }

        public Task UpdateProductAsync(Product product)
        {
            var item = _products.FirstOrDefault(x => x.Id == product.Id);
            if (item != null)
            {
                // Use automapper later
                //  The Id we don't update
                item.Title = product.Title;
                item.CategoryId = product.CategoryId;
                item.Description = product.Description;
                item.Price = product.Price;
            }

            return Task.CompletedTask;
        }

        public async Task<IQueryable<Product>> GetAllProductsAsync()
        {
            //  Use .AsQuerable() as opposed to ToList() - which will just creates the query.
            var products = _products.AsQueryable();

            return await Task.FromResult(products);
        }
    }

}
