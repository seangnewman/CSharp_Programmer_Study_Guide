using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap3_Transformer
{
    public class Car : TransformerBase
    {
        public Car(int duration) : base(landScape.road)
        {
            Console.WriteLine($"The distance is {returnDistance(duration)}");
        }
    }
}
