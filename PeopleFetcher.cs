using System;
using System.Collections.Generic;

namespace  CatWorx.BadgeMaker 
{
  class PeopleFetcher 
  {
    public static List<Employee> GetEmployees()
    {
        {
            List<Employee> employees = new List<Employee>();
            while (true)
            {
                // terminal input to get employee information
                Console.WriteLine("Please enter a first name: (leave empty to exit): ");
                string firstName = Console.ReadLine() ?? "";
                if (firstName == "")
                {
                    // leave blank to exit application
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
    }

    public static List<Employee> GetFromApi()
    {
        List<Employee> employees = new List<Employee>();
        return employees;
    }
  }
}