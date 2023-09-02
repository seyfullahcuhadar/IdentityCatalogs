using Microsoft.EntityFrameworkCore;

namespace IdentityCatalog.Repositories;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
    {
        
    }
}