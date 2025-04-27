var builder = WebApplication.CreateBuilder(args);

// Agregar DbContext con la cadena de conexión desde appsettings.json
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();
app.MapControllers();
app.Run();


// Add services to the container.
builder.Services.AddControllersWithViews();

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

builder.Services.AddScoped<CategoriasRepository>(); 
builder.Services.AddScoped<ICategoriaService, CategoriaService>(); 

builder.Services.AddScoped<GastosRepository>(); 
builder.Services.AddScoped<IGastoService, GastoService>(); 

builder.Services.AddScoped<MonedasRepository>(); 
builder.Services.AddScoped<IMonedaService, MonedaService>(); 

builder.Services.AddScoped<PresupuestosRepository>(); 
builder.Services.AddScoped<IPresupuestoService, PresupuestoService>(); 

builder.Services.AddScoped<UsuariosRepository>(); 
builder.Services.AddScoped<IUsuarioService, UsuarioService>(); 