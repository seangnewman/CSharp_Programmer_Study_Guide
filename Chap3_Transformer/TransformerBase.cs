using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap3_Transformer
{
    public class TransformerBase
    {
        public enum landScape
        {
            air, road, water
        }


        public TransformerBase()
        {

        }
        public TransformerBase(landScape landscape)
        {
            switch (landscape)
            {
                case (landScape.air):
                    Wheels = 0;
                    TopSpeed = 900;
                    break;

                case (landScape.road):
                    Wheels = 4;
                    TopSpeed = 350;
                    break;

                case (landScape.water):
                    Wheels = 0;
                    TopSpeed = 250;
                    break;

                default:
                    break;
              
            }
        }

        public virtual double returnDistance(int duration)
        {
            return duration * TopSpeed;
        }

        public int Wheels { get; set; }
        public int TopSpeed { get; set; }
        public int Distance { get; set; }
        
    }
}
