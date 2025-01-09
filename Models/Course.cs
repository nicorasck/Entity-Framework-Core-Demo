using System;
using System.ComponentModel.DataAnnotations.Schema;
using Entity_Framework_Core_Demo.Models;

public class Course
{
    public int CourseID {get; set;}             // Primary Key
    public required string Name { get; set; }
    public int Year { get; set; }

    [ForeignKey("School")]
    public int SchoolID { get; set; }           // Foreign Key => references to the entity of School.
    public School School { get; set; }
}