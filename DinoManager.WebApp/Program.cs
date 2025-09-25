using DinoManager.WebApp.Domain.Entities;
using DinoManager.WebApp.Domain.Repositories;
using DinoManager.WebApp.Domain.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<IList<Dino>>(sp => new List<Dino>()
{
    new Dino(1, "Tyrannosaurus Rex", 8000, 12),
    new Dino(2, "Triceratops", 6000, 9),
    new Dino(3, "Velociraptor", 15, 2),
    new Dino(4, "Brachiosaurus", 30000, 22),
    new Dino(5, "Stegosaurus", 5000, 9)
});
builder.Services.AddScoped<IDinoRepository, DinoFakeService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
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
