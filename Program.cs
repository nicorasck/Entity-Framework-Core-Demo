using System;
using Entity_Framework_Core_Demo_Data;
using Entity_Framework_Core_Demo.Models;
using Microsoft.EntityFrameworkCore;

var options = new DbContextOptionsBuilder<StudentDbContext>()
.UseSqlite("Data Source = StudentDb.db")
.Options;

using var context = new StudentDbContext(options);

if (!context.Schools.Any())
{
    System.Console.WriteLine("No schools are registered, adding the first.");
    System.Console.WriteLine("Enter the School Name:");
    var newSchoolName = Console.ReadLine();
    context.Schools.Add(new School {Name = newSchoolName, Address = "Malmvaegen 1"});

    context.SaveChanges();
    System.Console.WriteLine("Database is updated.");
}

var schools = context.Schools.ToList();
foreach (var school in schools)
{
    System.Console.WriteLine($"School Name: {school.Name}, Address: {school.Address}");
}

if (!context.Students.Any())
{
    context.Students.Add(new Student {Name = "Jojje", Email = "Jojje99@mail.com"});
    context.Students.Add(new Student {Name = "Nico", Email = "Nico89@mail.com"});

    context.SaveChanges();
    System.Console.WriteLine("Database is updated.");
}

System.Console.WriteLine("Loading students from DB:n\n");
var students = context.Students.ToList();

foreach (var student in students)
{
    System.Console.WriteLine($"Student Name: {student.Name}, Email: {student.Email}, StudentID: {student.StudentID}");
}