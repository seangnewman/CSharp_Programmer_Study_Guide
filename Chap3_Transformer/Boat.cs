using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap3_Transformer
{
    public class Boat : TransformerBase
    {
        public Boat(int duration) : base(landScape.water)
        {
            Console.WriteLine($"The distance is {returnDistance(duration)}");
        }
    }
}
