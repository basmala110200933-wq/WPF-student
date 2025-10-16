using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using studentdegree.model;
namespace studentdegree.Data
{
    public class DegreeContext:DbContext
    {
        public DbSet<Students> students { get; set; }
        public DbSet<Courses> course { get; set; }
        public DbSet<Studentcoursedegree> studentcoursedegree { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=COM164-LAB3\\SQLEXPRESS;Initial Catalog=degree;Integrated Security=True;Trust Server Certificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Studentcoursedegree>().HasKey(x =>new { x.cId, x.sId });
        }
    }
}
