using DataContextt.Models;
using Microsoft.EntityFrameworkCore;

namespace DataContextt.DAL
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context>options):base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
    }
}
