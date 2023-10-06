using Microsoft.EntityFrameworkCore;
using thuchanh1.Areas.Admin.Models;
using thuchanh1.Models;
namespace thuchanh1.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Class> AdminMenus { get; set; }
    }
}

