using IdentityCatalog.Models;
using Microsoft.EntityFrameworkCore;

namespace IdentityCatalog.Repositories;

public class ApplicationDbContext:DbContext
{
    public ApplicationDbContext(): base()
    {}
    public DbSet<User> Users { get; set; }
}