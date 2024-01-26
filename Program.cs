// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CatWorx.BadgeMaker
{
  class Program
  {
    static List<Employee> GetEmployees()
    {
      List<Employee> employees = new List<Employee>();
      while (true)
      {
        Console.WriteLine("Please enter a first name: (leave empty to exit): ");
        string firstName = Console.ReadLine() ?? "";
        if (firstName == "")
        {
          break;
        }

        Console.Write("Please enter " + firstName + "'s last name ");
        string lastName = Console.ReadLine() ?? "";

        Console.Write("Please enter " + firstName + "'s employee ID ");
        int id = Int32.Parse(Console.ReadLine() ?? "");

        Console.Write("Please enter " + firstName + "'s photo URL ");
        string photoUrl = Console.ReadLine() ?? "";

        Employee currentEmployee = new Employee(firstName, lastName, id, photoUrl);
        // Add currentEmployee, not a string
        employees.Add(currentEmployee);
      }
      return employees;
    }

    async static Task Main(string[] args)
    {
      List<Employee> employees = GetEmployees();
      Util.PrintEmployees(employees);
      Util.MakeCSV(employees);
      await Util.MakeBadges(employees);
    }
  }
}