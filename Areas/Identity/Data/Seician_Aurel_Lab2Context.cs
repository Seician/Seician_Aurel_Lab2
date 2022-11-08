using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Seician_Aurel_Lab2.Areas.Identity.Data;

namespace Seician_Aurel_Lab2.DataNOU;

public class Seician_Aurel_Lab2Context : IdentityDbContext<Seician_Aurel_Lab2User>
{
    public Seician_Aurel_Lab2Context(DbContextOptions<Seician_Aurel_Lab2Context> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
