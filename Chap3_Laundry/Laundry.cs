using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap3_Laundry
{
    public enum currentLocation
    {
        home, bestLocation
    }

    public enum spokenLanguages
    {
        english, french, spanish
    }
    class Laundry
    {
        public void hailCab()
        {
            Console.WriteLine(spokenLanguage());
            if (Location == currentLocation.home)
            {
                Location = currentLocation.bestLocation;
                Console.WriteLine("Heading to San Francisco");
            }
            else
            {
                Location = currentLocation.home;
                Console.WriteLine("Heading Home!");
            }
                
        }

        public string spokenLanguage()
        {
            switch (Language)
            {
                case spokenLanguages.english:
                    return "I speak English";
                case spokenLanguages.french:
                    return "I speak French";
                case spokenLanguages.spanish:
                    return "I speak Spanish";
                default:
                    return "Unknown";

            }
        }

        public bool IAmBroke()
        {
            return Dollars > 0 ? false : true;
        }

        public currentLocation Location { get; set; } = currentLocation.home;
        public spokenLanguages Language { get; set; } = spokenLanguages.english;
        public int Dollars { get; set; } = 100;
    }
}
