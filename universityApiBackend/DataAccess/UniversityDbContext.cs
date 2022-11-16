using Microsoft.EntityFrameworkCore;
using UniversityApiBackend.Models.DataModels;

namespace universityApiBackend.DataAccess
{
    public class UniversityDbContext: DbContext
    {
        public UniversityDbContext(DbContextOptions<UniversityDbContext> options) : base(options) { }
    
    // TODO: Add DbSets (Tables of our Data base)
        public DbSet<User>? Users { get; set; }

    }
}
