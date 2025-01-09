using System;
using Microsoft.EntityFrameworkCore.Design;
using Entity_Framework_Core_Demo_Data;
using Microsoft.EntityFrameworkCore;

public class StudentContextFactory : IDesignTimeDbContextFactory<StudentDbContext>
{
    public StudentDbContext CreateDbContext(string[] args) 
    {
        var optionsBuilder = new DbContextOptionsBuilder<StudentDbContext>();
        optionsBuilder.UseSqlite("Data Source=StudentDb.db");
        return new StudentDbContext (optionsBuilder.Options);
    }
}