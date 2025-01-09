using System;
using Entity_Framework_Core_Demo.Models;
using Microsoft.EntityFrameworkCore;

namespace Entity_Framework_Core_Demo_Data;

public class StudentDbContext : DbContext
{
    public DbSet<School> Schools {get; set;} = null;
    public DbSet<Student> Students {get; set;} = null;
    public DbSet<Course> Courses {get; set;} = null;

    public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options) {}

}