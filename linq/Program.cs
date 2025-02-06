using System;
using System.Linq;

class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee { Name = "nish", Age = 25 },
            new Employee { Name = "alish", Age = 30 },
            new Employee { Name = "nihant", Age = 40 },
            new Employee { Name = "niraj", Age = 35 }
        };

        var employeeNames = employees.Where(e => e.Age > 30);
        foreach (var employee in employeeNames)
        {
            Console.WriteLine(employee.Name);
        }

        // create new list of even numbers only
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        var evenNumberList = numbers.Where(n => n % 2 == 0).ToList();
        foreach (var number in evenNumberList)
        {
            Console.WriteLine(number);
        }

        // sort student names by descending order
        List<Student> studentNames = new List<Student> { 
            new Student { Name = "nish", Age = 25 },
            new Student { Name = "sudip", Age = 30 },
            new Student { Name = "bishal", Age = 35 },
            new Student { Name = "raytish", Age = 40 },
            new Student { Name = "alish", Age = 35 }
        };

        var sortedStudentNames = studentNames.OrderBy(s => s.Name).ToList();
        foreach (var student in sortedStudentNames)
        {
            Console.WriteLine(student.Name);
        }
    }
}