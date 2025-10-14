using Microsoft.EntityFrameworkCore;
using Bogcha.Models;

namespace Bogcha.Data
{
    public class BogchaDbContext : DbContext {
        public BogchaDbContext(DbContextOptions<BogchaDbContext> options)
            :base(options)
        {

        }

        public DbSet<Client> Clients {get;set;}
        public DbSet<User> Users {get;set;}
        public DbSet<BogchaModel> Bogchas {get;set;}
        public DbSet<Group> Groups {get;set;}
        public DbSet<Attendance> Attendances {get;set;}
    }
}