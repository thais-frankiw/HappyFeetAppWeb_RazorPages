using HappyFeetAppWeb.Data;
using HappyFeetAppWeb.Servicos;
using HappyFeetAppWeb.Servicos.Data;
using Microsoft.EntityFrameworkCore;
using NToastNotify;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages(options => {
                                            options.Conventions.AuthorizeFolder("/Categorias");
                                            options.Conventions.AuthorizeFolder("/Generos");
                                           })
                                           .AddNToastNotifyToastr(new ToastrOptions()
                                           {
                                                ProgressBar = false,
                                                PositionClass = ToastPositions.BottomLeft
                                           });

builder.Services.AddTransient<IProdutoServico, ProdutoServico>();

builder.Services.AddDbContext<HappyFeetDBContext>();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false).AddEntityFrameworkStores<HappyFeetDBContext>();

builder.Services.Configure<IdentityOptions>(options => {
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequiredLength = 3;
    // Lockout settings
    options.Lockout.MaxFailedAccessAttempts = 30;
    options.Lockout.AllowedForNewUsers = true;
    // User settings
    options.User.RequireUniqueEmail = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

var context = new HappyFeetDBContext();
context.Database.Migrate();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.UseNToastNotify();

app.MapRazorPages();

app.Run();
