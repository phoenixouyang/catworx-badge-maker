// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
  class Program
  {
    static void Main(string[] args)
    {
        // Dictionary<string, int> myScoreBoard = new Dictionary<string, int>(){
        // { "firstInning", 10 },
        // { "secondInning", 20},
        // { "thirdInning", 30},
        // { "fourthInning", 40},
        // { "fifthInning", 50}
        // };


        // string[] favFoods = new string[3]{ "pizza", "doughnuts", "ice cream" };
        // string firstFood = favFoods[0];
        // string secondFood = favFoods[1];
        // string thirdFood = favFoods[2];
        // Console.WriteLine("I like {0}, {1}, and {2}", firstFood, secondFood, thirdFood);
        
        List<string> employees = new List<string>() {
            {"amy"},
            {"adam"},
        };

        employees.Add("barb");
        employees.Add("billy");

        for (int i=0; i < employees.Count; i++) {
            Console.WriteLine(employees[i]);
        }
    }
  }
}