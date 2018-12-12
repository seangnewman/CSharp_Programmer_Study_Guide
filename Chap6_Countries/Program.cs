using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap6_Countries
{
    class Program
    {
        static void Main(string[] args)
        {
            var countries = new List<Countries>()
            {
                new Countries(){Name = "United States", Continent = "North America"},
                new Countries(){Name = "Mexico", Continent = "North America"},
                new Countries(){Name = "Brazil", Continent = "South America"},
                new Countries(){Name = "Argentina", Continent = "South America"},
                new Countries(){Name = "United Kingdom", Continent = "Europe"},
                new Countries(){Name = "Russia", Continent = "Europe"},
                new Countries(){Name = "China", Continent = "Asia"},
                new Countries(){Name = "Japan", Continent = "Asia"},
                new Countries(){Name = "Egypt", Continent = "Africa"},
                new Countries(){Name = "Kenya", Continent = "Africa"},
                new Countries(){Name = "Australia", Continent = "Australia"},

            };

            // Create new Country
            countries.Add(new Countries() { Name = "India", Continent = "Asia" });

            Console.WriteLine("After adding India (C)");
            foreach (var country in countries)
            {
                Console.WriteLine($"Country:{country.Name,30}  Continent{country.Continent, 40}");
            }

            Console.WriteLine("Searching for European Countries ('R')");
            var europe = countries.Where(c => String.Equals(c.Continent, "Europe", StringComparison.OrdinalIgnoreCase) == true);  

            foreach (var country in europe)
            {
                Console.WriteLine($"Country:{country.Name,30}  Continent{country.Continent,40}");
            }

            Console.WriteLine("Updating Russia to an Asian Country ('U'");
            var UpdRussia = countries.Where(c => String.Equals(c.Name, "Russia", StringComparison.OrdinalIgnoreCase) == true)
                                                                   .Select(c => c.Continent = "Asia")
                                                                   .ToList();

            foreach (var country in countries)
            {
                Console.WriteLine($"Country:{country.Name,30}  Continent{country.Continent,40}");
            }

            Console.WriteLine("Removing North American Countries ('D')");

            var deletions = countries.Where(c => String.Equals(c.Continent,"North America", StringComparison.OrdinalIgnoreCase) == false)
                                                                .Select(c => c)
                                                                .ToList();

            foreach (var country in deletions)
            {
                Console.WriteLine($"Country:{country.Name,30}  Continent{country.Continent,40}");
            }

        }
    }
}
