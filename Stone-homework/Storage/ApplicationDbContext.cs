using Microsoft.EntityFrameworkCore;
using Stone_homework.Models;

namespace Stone_homework.Storage
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        public DbSet<Department> Departments { get; set; }
        public DbSet<HireStage> HireStages { get; set; }
        public DbSet<HireStageType> HireStageTypes { get; set; }
        public DbSet<Vacancy> Vacancies { get; set; }
        public DbSet<WorkerStatus> WorkerStatuses { get; set; }
        public DbSet<WorkerTag> WorkerTags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<HireStage>().HasOne(s => s.StageType);
        }
    }
}
