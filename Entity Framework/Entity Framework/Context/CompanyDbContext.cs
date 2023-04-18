using Entity_Framework.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework.Context
{
    public class CompanyDbContext:DbContext
    {
        //create  database  CompanyDb in sql server
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       => optionsBuilder.UseSqlServer("server=.;database=CompanyDb;trusted_connection=true");


        //create table Departments in database  CompanyDb   by flunt api 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().ToTable("Departments");
           
            modelBuilder.Entity<Department>().HasKey(d=>d.IdDept);//primary key for id dept

            modelBuilder.Entity<Department>().Property(d => d.IdDept).UseIdentityColumn(10,10);//Identity for IdDept

            modelBuilder.Entity<Department>()
                .Property(d => d.Name)
                .IsRequired(true)//not allow null
                .HasMaxLength(50)
                .IsUnicode(false);//varchar datatype for name

            modelBuilder.Entity<Department>()
            .Property(d => d.YearOfCreation)
            .HasDefaultValue(DateTime.Now);//defult value for date

            //for one to many relationShip
            modelBuilder.Entity<Employee>() // //add primary key (IdDept) table Department  in  table Employee (forgin key ) /for  one to many relationship
                .HasOne<Department>(d => d.Department)
                .WithOne(e => e.Employee)
                .HasForeignKey<Employee>(d => d.DeptId);

            //for many to many relationship
            modelBuilder.Entity<StudentCourse>().HasKey(sc => new { sc.StudentId, sc.CourseId });//composite primary key StudentId and  CourseId
            base.OnModelCreating(modelBuilder);
        }

        //create table Employees in database  CompanyDb  by data annotation 
        public DbSet<Employee> Employees { get; set; } //create table Employees  in data base CompanyDb in sql server 

        public DbSet<Course> Courses { get; set; } 
        public DbSet<Student> Students { get; set; }

        public DbSet<StudentCourse> StudentCourses { get; set; }

    }
}
