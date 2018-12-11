using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap3_Laundry
{
    class Clothes:Laundry
    {
        public Clothes():base()
        {
            Console.WriteLine("Hailing Cab");
            hailCab();
            
            whereAreClothes();
            hailCab();
            whereAreClothes();
        }

        public void whereAreClothes()
        {
            // Do I have enough money to launder clothes
            if (!IAmBroke())
            {
                if (Location == currentLocation.bestLocation)
                    Console.WriteLine("Clothes are being laundered");
                else
                    Console.WriteLine("Clothes are being returned");
            }

            
        }
    }
}
