using Microsoft.EntityFrameworkCore;
using Bogcha.Models;

namespace Bogcha.Data
{
    public class BogchaDbContext : DbContext {
        public BogchaDbContext(DbContextOptions<BogchaDbContext> options)
            :base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Attendance>()
                .HasOne(a=>a.Client)
                .WithMany(c=>c.Attendances)
                .HasForeignKey(a=>a.ClientId)
                .OnDelete(DeleteBehavior.Cascade);
        }

        public DbSet<Client> Clients {get;set;}
        public DbSet<User> Users {get;set;}
        public DbSet<BogchaModel> Bogchas {get;set;}
        public DbSet<Group> Groups {get;set;}
        public DbSet<Attendance> Attendances {get;set;}
    }
}