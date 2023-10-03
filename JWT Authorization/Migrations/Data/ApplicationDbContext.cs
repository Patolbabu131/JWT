using JWT_Authorization.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace JWT_Authorization.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public virtual DbSet<User> User { get; set; }
        public  DbSet<Students> Students { get; set; }
    }
}
