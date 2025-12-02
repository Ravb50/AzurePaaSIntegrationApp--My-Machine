namespace AzurePaaSIntegrationApp.Data;
using AzurePaaSIntegrationApp.Model;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }
}
