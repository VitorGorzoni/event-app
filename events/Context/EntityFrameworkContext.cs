using System;
using events.Model;
using Microsoft.EntityFrameworkCore;

namespace events.context
{
    public class EntityFrameworkContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;User Id=sa;Password=myPass123;Database=eventdb;Trusted_Connection=True;Integrated Security = False;");
        }

        public DbSet<EventModel> Events { get; set; }
    }
}
