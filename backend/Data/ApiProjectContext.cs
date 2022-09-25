using Microsoft.EntityFrameworkCore;
using ApiProject.Models;

namespace ApiProject.Data
{
    public class ApiProjectContext : DbContext
    {
        public ApiProjectContext(DbContextOptions<ApiProjectContext> opt) : base(opt)
        {
            
        }

        public DbSet<Book> Books { get; set; }
    }
}