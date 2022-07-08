using Microsoft.EntityFrameworkCore;
using uppgift1VC.Models.POCO;

namespace uppgift1VC.Models
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext (DbContextOptions<ApplicationDBContext> options) : base(options) { }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Errand> Errands { get; set; }
        public DbSet<ErrandStatus> ErrandStatuses { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Sample> Samples { get; set; }
        public DbSet<Sequence> Sequences { get; set; }

    }
}
