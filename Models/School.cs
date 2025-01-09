using System;
namespace Entity_Framework_Core_Demo.Models;

public class School
{
    public int SchoolID {get; set;}             // Primary Key
    public required string Name {get; set;}
    public required string Address {get; set;}

    public ICollection<Student> students {get; set;}

}