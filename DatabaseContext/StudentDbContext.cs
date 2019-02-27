using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCAPP.Models;

namespace MVCAPP.DatabaseContext
{
    public class StudentDbContext:DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-PHFRTLE\\SQLEXPRESS;Database=StudentDb;Integrated Security=true");
        }
    }
}
