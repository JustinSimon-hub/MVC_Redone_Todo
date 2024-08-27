using Microsoft.EntityFrameworkCore;
using Testing.Models;

namespace Testing.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }

        //this object is a representation of the all the "ToDo" objects inside the database 
        //this object property allows me to run LINQ or Entityframework methods against this object for things like querying for example
        public DbSet<ToDo> Todos { get; set; }

    }
}