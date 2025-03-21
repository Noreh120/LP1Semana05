using System;
using Bogus;
using Spectre.Console;

namespace CarStats
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Randomizer.Seed = new Random(int.Parse(args[0]));
           
            for each (args)
            {
                Faker faker = new Faker();
                faker number = new int
                BarChart bc = new BarChart(faker);
                Console.Writeline($"{faker} {bc} {args}")
            }

            Faker faker = new Faker();
            Faker 
            BarChart bc = new BarChart();
        }

        public static class FakeData()
        {
            .RuleFor(c => c.Name, f => f.Bogus.DataSets.CompanyName)
            .RuleFor()
        }
    }
}
