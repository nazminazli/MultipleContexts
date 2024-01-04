using MultipleContexts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var productConnectionString = builder.Configuration.GetConnectionString("ProductSqlDb");

var customerConnectionString = builder.Configuration.GetConnectionString("CustomerSqlDb");

builder.Services.AddServices(productConnectionString, customerConnectionString);

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
