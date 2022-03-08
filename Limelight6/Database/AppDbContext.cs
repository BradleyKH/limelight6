using Limelight6.Resources.Evaluations;
using Limelight6.Resources.Events.Models;
using Limelight6.Resources.Forms;
using Limelight6.Resources.Payments;
using Limelight6.Resources.Permissions;
using Limelight6.Resources.Registrations;
using Limelight6.Resources.Submissions;
using Limelight6.Resources.Supplements;
using Limelight6.Resources.Users;
using Microsoft.EntityFrameworkCore;

namespace Limelight6.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public virtual DbSet<Evaluation> Evaluations { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Form> Forms { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<Registration> Registrations { get; set; }
        public virtual DbSet<Submission> Submissions { get; set; }
        public virtual DbSet<Supplement> Supplements { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Evaluation>()
                .Property(e => e.Score)
                .HasColumnType("decimal(16,2)");

            modelBuilder
                .Entity<Payment>()
                .Property(p => p.Amount)
                .HasColumnType("decimal(16,2)");
        }
    }
}
