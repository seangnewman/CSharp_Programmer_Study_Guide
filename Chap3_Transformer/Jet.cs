using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap3_Transformer
{
    public class Jet:TransformerBase
    {
        public Jet(int duration):base(landScape.air)
        {
            Console.WriteLine($"The distance is {returnDistance(duration)}");
        }   
    }
}
