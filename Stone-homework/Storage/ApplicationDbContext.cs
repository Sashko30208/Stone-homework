using Microsoft.EntityFrameworkCore;
using Stone_homework.Models;

namespace Stone_homework.Storage
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        { }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        public DbSet<Department> Departments { get; set; }
        public DbSet<HireStage> HireStages { get; set; }
        public DbSet<HireStageType> HireStageTypes { get; set; }
        public DbSet<Vacancy> Vacancies { get; set; }
        public DbSet<WorkerStatus> WorkerStatuses { get; set; }
        public DbSet<WorkerTag> WorkerTags { get; set; }

        public DbSet<Worker> Workers { get; set; }
        public DbSet<Aspirant> Aspirants { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<ReservedWorker> ReservedWorkers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<HireStage>().HasOne(s => s.StageType);

            modelBuilder.Entity<Vacancy>().HasOne(v => v.Department);
            modelBuilder.Entity<Vacancy>().HasOne(v => v.ResponsiblePerson);

            modelBuilder.Entity<Worker>().HasOne(e => e.Department).WithMany(d => d.Workers).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Worker>().HasOne(w => w.Status);
            modelBuilder.Entity<Worker>().HasMany(w => w.Tags);
            modelBuilder.Entity<Aspirant>().HasMany(w => w.HireStages);
        }
    }
}
