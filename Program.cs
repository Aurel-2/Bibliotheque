using Microsoft.EntityFrameworkCore;
using Bibliotheque.Data; 

var builder = WebApplication.CreateBuilder(args);

// Ajoute les services pour les contrôleurs et les vues
builder.Services.AddControllersWithViews();

// Ajoute le DbContext avec PostgreSQL
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure le pipeline HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles(); // Pour servir les fichiers statiques (CSS, JS, images)
app.UseRouting();
app.UseAuthorization(); // Active l'autorisation

// Configuration des routes
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();