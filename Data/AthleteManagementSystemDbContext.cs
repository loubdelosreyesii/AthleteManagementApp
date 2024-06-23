using AthleteManagementApp.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace AthleteManagementApp.Data
{ 
    public class AthleteManagementSystemDbContext :DbContext
    {
        public AthleteManagementSystemDbContext(DbContextOptions<AthleteManagementSystemDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories{ get; set; }
    }
}
