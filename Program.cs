using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Seician_Aurel_Lab2.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<Seician_Aurel_Lab2.DataNOU.Seician_Aurel_Lab2Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Seician_Aurel_Lab2.DataNOU") ?? throw new InvalidOperationException("Connection string 'Seician_Aurel_Lab2Context' not found.")));

builder.Services.AddDbContext<LibraryIdentityContext>(options =>

options.UseSqlServer(builder.Configuration.GetConnectionString("Seician_Aurel_Lab2.DataNOU") ?? throw new InvalidOperationException("Connectionstring 'Seician_Aurel_Lab2Context>(options =>\r\n    options.UseSqlServer(buildContext' not found.")));
builder.Services.AddDefaultIdentity<IdentityUser>(options =>
options.SignIn.RequireConfirmedAccount = true)
 .AddEntityFrameworkStores <LibraryIdentityContext> ();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();

app.MapRazorPages();

app.Run();
