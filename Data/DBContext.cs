
using Microsoft.EntityFrameworkCore;
using MuscleLP.Models;

namespace MuscleLP.Data
{
    public class DBContext: DbContext
    {
        public DBContext(DbContextOptions<DBContext> options): base(options)
        {
        }
        public DbSet<User> Users { get; set; }
    }
}