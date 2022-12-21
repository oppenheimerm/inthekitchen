using ITK.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITK.DataStore.EFCore
{
    /// <summary>
    /// The The EnsureCreated in <see cref="ITK.Web"/> Program.cs
    /// method creates an empty database. This section adds code that 
    /// populates the database with test data.
    /// </summary>
    public class DbInitializer
    {
        public static void Initialize(ITKDbContext context)
        {
            //  Look for any products
            if(context.Products.Any())
            {
                return; // Db has already been seeded
            }

            var categories = new Category[]
            {
                new Category { Id = 1000, Title = "Cook", Code = "COOK" },
                new Category { Id = 1001, Title = "Clean", Code = "CLEN" },
                new Category { Id = 1002, Title = "Bake", Code = "BAKE" },
                new Category { Id = 1003, Title = "Food Prep", Code = "FPRP" },
                new Category { Id = 1004, Title = "Drink", Code = "DRNK" },
                new Category { Id = 1005, Title = "Cookware", Code = "CKWR" },
                new Category { Id = 1006, Title = "Cook Books", Code = "CKBK" },
                new Category { Id = 1007, Title = "Cooking Utensils", Code = "COUT"},
                new Category { Id = 1008, Title = "Organization & Storage", Code = "ONSE"}
            };
            context.Categories.AddRange(categories);
            context.SaveChanges();

            var products = new Product[]
            {
                new Product { CategoryId = 1000, Title = "Philips Premium XXL Airfryer", Description = $"Philips Premium XXL Airfryer - 7.3 Litres, 2225 W, Fat Removal Technology, Recipes (NutriU App), Keep Warm Function, Extra Large Size for the Entire Family. ", Price = 299.00m, Image = "Philips-Premium-XXL-Airfryer", StockQuantity = 13},
                new Product { CategoryId = 1000, Title = "Tefal EasyFry XXL 2-in-1 Digital Air Fryer & Grill", Description = "Tefal EasyFry XXL 2-in-1 Digital Air Fryer & Grill, With Draw Divider, 6.5L Capacity, 8 Programs, Black", Price = 139.00m, Image = "Tefa-EasyFry-XXL-2-in-1.jpg", StockQuantity = 10},
                new Product { CategoryId = 1000, Title = "Instant Vortex 4-in-1 Digital Air Fryer", Description = "Instant Vortex 4-in-1 Digital Air Fryer, Health Air Fryer, Bake, Roast and Reheat, 1700W of Power with Timer, Non-Stick – 5.7 Litre ", Price = 99.99m, Image = "Instant-Vortex-4-in-1-Digital-Air-Fryer.jpg", StockQuantity = 6},
                new Product { CategoryId = 1000, Title = "NINJA Foodi 11-in-1 SmartLid Multi-Cooker 6L", Description = "NINJA Foodi 11-in-1 SmartLid Multi-Cooker 6L Electric Pressure Cooker, Air Fryer, Combi-Steam, Slow Cooker, Grill, Bake ", Price = 279.00m, Image = "NINJA-Foodi-11-in-1-SmartLid-Multi-Cooker.jpg", StockQuantity = 2},
                new Product { CategoryId = 1000, Title = "Sage the Smart Oven Air Fryer Countertop Oven", Description = "Sage the Smart Oven Air Fryer Countertop Oven 22L, Stainless Steel ", Price = 204.00m, Image = "Sage-Smart-Oven-Air-Fryer-Countertop-Oven.jpg", StockQuantity = 3},
                new Product { CategoryId = 1000, Title = "Instant Vortex Plus Dual Basket 8-in-1 Air Fry", Description = "Instant Vortex Plus Dual Basket with ClearCook - 7.6L Digital Health Air Fryer, Stainless Steel, 8-in-1 Smart Programmes - Air Fry, Bake, Roast, Grill, Dehydrate, Reheat, XL Capacity -1700W ", Price = 220.0m, Image = "Instant-Vortex-Plus-Air-Fryer-8-in-1.jpg", StockQuantity = 5},
                new Product { CategoryId = 1000, Title = "Instant Pot Duo 7-in-1 Smart Cooker, 5.7L - Pressure Cooker", Description = "Instant Pot Duo 7-in-1 Smart Cooker, 5.7L - Pressure Cooker, Slow Cooker, Rice Cooker, Sauté Pan, Yoghurt Maker, Steamer and Food Warmer, Brushed Stainless Steel ", Price = 83.27m, Image = "Instant-Pot-Duo-7-in-1-Pressure-Cooker-Slow-Cooker.jpg", StockQuantity = 7},
                new Product { CategoryId = 1002, Title = "Sage the Custom Loaf Pro Bread Maker", Description = "Sage the Custom Loaf Pro Bread Maker - Silver ", Price = 125.00m, Image = "Sage-Custom-Loaf-Pro-Bread-Maker.jpg", StockQuantity = 10},
                new Product { CategoryId = 1002, Title = "Panasonic Fully Automatic Breadmaker", Description = "Panasonic Fully Automatic Breadmaker, with yeast & nut dispensers, Manual Settings for Bread & Rising, Dual Temperature Sensors, 13 Hours Digital Timer", Price = 179.00m, Image = "Panasonic-Automatic-Breadmaker.jpg", StockQuantity = 14 },
                new Product { CategoryId = 1002, Title = "Automatic Bread Machine, Family Bread Maker", Description = "Automatic Bread Machine, Family Bread Maker Professional Non-Stick Breadmaker with Automatic Fruit Nuts Dispenser, 17 Progammes, 15 Hours Timing, 500g /750g/ 1000g Weight Settings ", Price = 199.00m, Image = "Automatic-Bread-Machine-Breadmaker-Automatic.jpg", StockQuantity = 18 },
                new Product { CategoryId = 1000, Title = "TOKIT Omni Cook Robot All-in-1 Food Processor", Description = "TOKIT Omni Cook Robot All-in-1 Food Processor with 21 Cooking Functions Built-in 7'' Touch Screen Guided Recipes Pre-clean, Chopper, Juicer, Blender, Mixer, Weigh, Sous-Vide, Ice Crush and more ", Price = 1057.89m, Image = "TOKIT-Omni-Cook-Robot-All-in-1.jpg", StockQuantity = 23},
                new Product { CategoryId = 1007, Title = "Moulinex Cuisine Companion Kitchen Robot", Description = "Moulinex Cuisine Companion Kitchen Robot, 6 Automatic Programmes, Capacity for up to 6 People Cuisine Companion White ", Price = 1599.00m, Image = "Moulinex-Cuisine-Companion-Kitchen-Robot.jpg", StockQuantity = 29},
                new Product { CategoryId = 1007, Title = "Microplane Zester Grater - Black", Description = "Microplane Zester Grater in Black for Citrus Fruits, Hard Cheese, Ginger, Chocolate and Nutmeg with Fine Stainless Steel Blade - Made in USA ", Price = 17.94m, Image = "Microplane-Zester-Grater-Black.jpg", StockQuantity = 36},
                new Product { CategoryId = 1007, Title = "Global 19cm Fluted Blade", Description = "Global 35th Anniversary Special Edition Pro Chef’s Knife with 19cm Fluted Blade – Cromova 18 high Carbon Stainless Steel ", Price = 99.95m, Image = "Global-19cm-Fluted-Blade.jpg", StockQuantity = 44},
                new Product { CategoryId = 1007, Title = "Global 2-Piece Knife and Sharpener Set", Description = "Global 2-Piece Knife and Sharpener Set - Contains G-2 Cook's Knife and Minosharp Knife Sharpener, Silver, (G-220B) ", Price = 139.95m, Image = "Global-2-Piece-Knife-and-Sharpener-Set.jpg", StockQuantity = 43},
                new Product { CategoryId = 1004, Title = "Sage Barista Express Espresso Machine - Brushed Stainless Steel", Description = "Sage Barista Express Espresso Machine - Espresso and Coffee Maker, Bean to Cup Coffee Machine, BES875UK , Brushed Stainless Steel ", Price = 593.00m, Image = "Sage-Barista-Express-Espresso-Machine.jpg", StockQuantity = 41},
                new Product { CategoryId = 1004, Title = "Sage Dual Boiler Espresso Machine - Silver", Description = "Sage BES920UK the Dual Boiler Espresso Machine - Silver ", Price = 1156.96m, Image = "Sage-Dual-Boiler-Espresso-Machine.jpg", StockQuantity = 38},
                new Product { CategoryId = 1004, Title = "De'Longhi Eletta Cappuccino Machine - White", Description = "De'Longhi Eletta Cappuccino, Fully Automatic Bean to Cup Machine, Espresso, Coffee Maker, White ", Price = 616.49m, Image = "De'Longhi-Eletta-Bean-to-Cup-Machine.jpg", StockQuantity = 34},
                new Product { CategoryId = 1004, Title = "Siemens Home Connect Bean to Cup Coffee Machine - Anthracite", Description = "Siemens TP705GB1 EQ700 Home Connect Bean to Cup Fully Automatic Freestanding Coffee Machine - Anthracite ", Price = 799.00m, Image = "Siemens-Freestanding-Coffee-Machine.jpg", StockQuantity = 29},
                new Product { CategoryId = 1004, Title = "SodaStream Terra Sparkling Water Maker – Black", Description = "SodaStream Terra Sparkling Water Maker Machine, with 1 Litre Reusable BPA-Free Water Bottle for Carbonating & 60 Litre Quick Connect CO2 Gas Cylinder – Black ", Price = 68.99m, Image = "SodaStream-Terra-Sparkling-Water-Maker–Black.jpg", StockQuantity = 23},
                new Product { CategoryId = 1005, Title = "ZUOFENG Non Stick Frying Pans - 24cm", Description = "ZUOFENG Non Stick Granite Frying Pan Stone Pans 24cm, for Induction Hob", Price = 19.37m, Image = "ZUOFENG-Non-Stick-Granite-Frying-Pan.jpg", StockQuantity = 18},
                new Product { CategoryId = 1001, Title = "EVA SOLO - Washing-up Brush", Description = "EVA SOLO - Washing-up Brush. Danish Design, Silicone, Plastic and Steel - Marble Grey ", Price = 24.56m, Image = "EVA-SOLO-Washing-up-Brush.jpg", StockQuantity = 13},
                new Product { CategoryId = 1005, Title = "Dansk - Kobenstyle White Casserole Dish", Description = "Dansk - Kobenstyle White Casserole Dish - Stainless Steel", Price = 165.00m, Image = "Dansk-Kobenstyle-White-Casserole-Dish.jpg ", StockQuantity = 7},
                new Product { CategoryId = 1005, Title = "Joseph Joseph - M-Cuisine 4-Piece Stackable Cooking Set - Stone/Orange", Description = "Joseph Joseph - M-Cuisine 4-Piece Stackable Microwave Cooking Set - Stone/Orange", Price = 39.58m, Image = "Joseph-Joseph-Cooking-Set-Stone-Orange.jpg", StockQuantity = 1},
                new Product { CategoryId = 1005, Title = "Sori Yanagi Nanbu Tekki Iron pan", Description = "Sori Yanagi Nanbu Tekki Iron pan shallow 22cm Tetsufuta(Iron lid) with handle ", Price = 176.59m, Image = "Sori-Yanagi-Nanbu-Tekki-Iron-pan.jpg", StockQuantity = 4},
                new Product { CategoryId = 1004, Title = "Eva Solo - Dzbanek Termiczny Kettle - Silver", Description = "Eva Solo Dzbanek Termiczny Nordic Kitchen 1 Litre ", Price = 75.83m, Image = "Eva-Solo-Dzbanek-Kettle-Silver.jpg", StockQuantity = 8},
                new Product { CategoryId = 1001, Title = "Eva Solo soap Dispenser - Black", Description = "Eva Solo soap Dispenser - Black", Price = 29.98m, Image = "Eva-Solo-soap-Dispenser-Black.jpg", StockQuantity = 9},
                new Product { CategoryId = 1005, Title = "EVA SOLO - Citrus Press Green", Description = "EVA SOLO - Citrus Press Green Tool | Composite (50% Wheat Fiber & 50% PP) and Cast Metal. ", Price = 14.98m, Image = "EVA-SOLO-Citrus-Press-Green.jpg", StockQuantity = 14 },
                new Product { CategoryId = 1003, Title = "Juice Bruce Lemon Squeezer", Description = "Juice Bruce Lemon Squeezer Design By Studio Yaacov Kaufman", Price = 12.98m, Image = "Juice-Bruce-Lemon-Squeezer-Yaacov-Kaufman.jpg", StockQuantity = 11 },
                new Product { CategoryId = 1008, Title = "KUHN RIKON - Herb Saver", Description = "KUHN RIKON - Herb Saver", Price = 23.95m, Image = "KUHN-RIKON-Herb-Saver.jpg", StockQuantity = 8 },
                new Product { CategoryId = 1008, Title = "Cuisipro - Herb Keeper", Description = "Cuisipro - Herb Keeper", Price = 33.02m, Image = "Cuisipro-Herb-Keeper.jpg", StockQuantity = 14 },
                new Product { CategoryId = 1007, Title = "KUHN RIKON 3-Piece Professional Knife Set - Multicolour", Description = "KUHN RIKON 3-Piece Professional Knife Set, Multicolour, Green, Red", Price = 23.03m, Image = "KUHN-RIKON-3-Piece-Multicolour-set.jpg", StockQuantity = 18 },
                new Product { CategoryId = 1008, Title = "Simplehuman Slim Kitchen Sink Caddy", Description = "Simplehuman Slim Kitchen Sink Caddy Organiser Holder Tidy, With Suction Cups, Wire Ledge Hanger, Sponge Storage, Rustproof, Brushed Stainless Steel", Price = 15.95m, Image = "Simplehuman-Kitchen-Sink-Caddy.jpg", StockQuantity = 23},
                new Product { CategoryId = 1008, Title = "Joseph Joseph Nest Chopping Board Set - Opal", Description = "Joseph Joseph Nest Chopping Board Set, Nesting Compact Boards - 3 piece, Opal", Price = 24.99m, Image = "Joseph-Joseph-Nest-Chopping-Board-Set-Opal.jpg", StockQuantity = 29},
                new Product { CategoryId = 1007, Title = "OTOTO Red The Crab Silicone Spoon Rest", Description = "OTOTO Red The Crab Silicone Spoon Rest - Heat-Resistant Utensil Rest for Stove Top - BPA-Free Ladle and Spoon Holder Rest - Non-Slip Wooden Spoon Holder and Steam Releaser", Price = 17.99m, Image = "OTOTO-Red-The-Crab-Silicone-Spoon-Rest.jpg", StockQuantity = 36 }/*,
                new Product { CategoryId = "", Title = "", Description = "", Price = "", Image = "", StockQuantity = },
                new Product { CategoryId = "", Title = "", Description = "", Price = "", Image = "", StockQuantity = },
                new Product { CategoryId = "", Title = "", Description = "", Price = "", Image = "", StockQuantity = },*/
            };

            context.Products.AddRange(products);
            context.SaveChanges();
        }
    }
}
