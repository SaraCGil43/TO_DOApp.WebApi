using Microsoft.EntityFrameworkCore;

namespace ToDo_SolutionWebApi.Models
{
    public class TODOAppDbContex : DbContext
    {
        public TODOAppDbContex(DbContextOptions<TODOAppDbContex> options) : base(options) { } //Inyección de dependencias

        public DbSet<User> Users { get; set; }
        public DbSet<TODOITEM> TodoItems { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<User>().ToTable("Users");
        //    modelBuilder.Entity<TODOITEM>().ToTable("TodoItems");
        //}

    }
}
