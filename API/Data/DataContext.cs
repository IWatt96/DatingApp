using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class DataContext : DbContext
{ // BASE REFERS TO DbContext, OPTIONS LEFT OPEN TO BE PROVIDED LATER.
    public DataContext (DbContextOptions options) : base(options)
    {
    }

    
    public DbSet<AppUser> Users { get; set; }
}
