using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_2024C2_12C_EF_CF
{
    internal class EscuelaDBContext : DbContext
    {
        public DbSet<Estudiante> Estudiantes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { 
            optionsBuilder.UseSqlServer(@"Server=A-PROFH-360;Database=1234EscuelaDB;Trusted_Connection=True;Trust Server Certificate=true"); 
        }
    }
}
