using crudapp.Models;
using Microsoft.EntityFrameworkCore;

namespace crudapp.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
        public DbSet<employee> Employee { get; set; }
    }
}
