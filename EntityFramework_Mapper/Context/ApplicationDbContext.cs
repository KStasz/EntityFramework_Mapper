using EntityFramework_Mapper.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_Mapper.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<People> Peoples { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-8JCOPNU\SQLEXPRESS;Database=EntityFrameworkMapperDb;User Id=sa;Password=]89tYM=&;");
        }
    }
}
