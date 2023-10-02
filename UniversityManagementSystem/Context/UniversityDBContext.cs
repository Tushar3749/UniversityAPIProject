using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using static UniversityManagementSystem.Data.Model.UniversityDBModel;

namespace UniversityManagementSystem.Data.Context
{
    
    public class UniversityDBContext : DbContext
    {
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options) : base(options)
        {

        }



        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }



        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server={192.168.42.6};Database={MyReadingDB};UserId={sa};Password={e0LZ0G*#%B9)G9}P95};");
        //}


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().Property(s => s.DepartmentID).HasDefaultValue("D-000");
            modelBuilder.Entity<Student>().Property(s => s.StudentId).IsRequired();
            modelBuilder.Entity<Student>().HasKey(s => s.StudentId);
            modelBuilder.Entity<Department>().HasKey(s => s.DepartmentID);
        }



    }
}
