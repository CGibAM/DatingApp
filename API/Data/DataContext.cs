using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) //Conecction to the database
        {
        }
        
        public DbSet<AppUser> Users { get; set; } //Tables inside the database, name of the table
    }
}