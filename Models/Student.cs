using System;
using Entity_Framework_Core_Demo.Models;

public class Student
{
    public int StudentID {get; set;}            // Primary Key
    public required string Name {get; set;}
    public required string Email {get; set;}
    
}