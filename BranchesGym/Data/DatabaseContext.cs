using BranchesGym.Models;
using Microsoft.EntityFrameworkCore;

namespace BranchesGym.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<TrainingDay> TrainingDays { get; set; }
        public DbSet<PhysicalEvaluation> PhysicalEvaluations { get; set; }
        public DbSet<Nutrition> Nutritions { get; set; }
        public DbSet<EASCycle> EASCycles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=BranchesGym.db");
        }
    }
}
