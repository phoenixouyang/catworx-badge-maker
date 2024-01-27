// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CatWorx.BadgeMaker
{
  class Program
  {
    async static Task Main(string[] args)
    {
      // List<Employee> employees = PeopleFetcher.GetEmployees();
      List<Employee> employees = PeopleFetcher.GetFromApi();
      Util.PrintEmployees(employees);
      Util.MakeCSV(employees);
      await Util.MakeBadges(employees);
    }
  }
}