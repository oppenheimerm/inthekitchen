using ITK.DataStore.EFCore;
using ITK.DataStore.EFCore.Repositories;
using ITK.UseCases.Categories;
using ITK.UseCases.DataStoreInterfaces;
using ITK.UseCases.Interfaces;
using ITK.UseCases.Products;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var connectionString = builder.Configuration.GetConnectionString("ITKContext") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

builder.Services.AddDbContext<ITKDbContext>(options =>
    options.UseSqlServer(connectionString));

// Add the database exception filter
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ITKDbContext>();


//  Repositories
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IProductsRepository, ProductsRepository>();


//  Usercases
builder.Services.AddTransient<IViewCategoriesUseCase, ViewCategoriesUseCase>();
builder.Services.AddTransient<IViewProductsByFilterUseCase, ViewProductsByFilterUseCase>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
else
{
    //  MO 20-12-22
    app.UseDeveloperExceptionPage();
    //  MO 20-12-22
    app.UseMigrationsEndPoint();
}

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    var context = services.GetRequiredService<ITK.DataStore.EFCore.ITKDbContext>();
    //   takes no action if a database for the context exists. If no
    //   database exists, it creates the database and schema. 
    context.Database.EnsureCreated();
    DbInitializer.Initialize(context);
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
