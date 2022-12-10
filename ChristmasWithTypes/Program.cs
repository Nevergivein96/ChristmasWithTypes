using System;

namespace ChristmasWithTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var xmas = new Christmas();
            
            //it is actually on sunday this year (2022)
            var xmasDay = Christmas.Day.Sunday;

            //Done set Santa's name to Kris Kringle
            xmas.Santa = "Kris Kringle";

            //Done Insert 3 presents you would like for xmas.  They must be strings
            xmas.Presents =  new string[3]{ "Ford Raptor R", "New camping trailer", "Generator" }; 

            //Done Set the TreeHeight to 10
            xmas.TreeHeight = 10;

            Console.WriteLine($"This year christmas falls on {xmasDay} \n");
            Console.WriteLine($"Our tree will be {xmas.TreeHeight} feet high \n");
            Console.WriteLine("Here are the presents we would like:");

            foreach (var present in xmas.Presents)
            {
                Console.WriteLine($"    {present}");
            }

            Console.WriteLine($"\n We like to call Santa, {xmas.Santa}");
        }
    }
}
