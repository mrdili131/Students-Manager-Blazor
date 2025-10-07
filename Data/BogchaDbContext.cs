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
    }
}