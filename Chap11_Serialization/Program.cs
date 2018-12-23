using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Chap11_Serialization
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create and instance and initialize
            Students cody = new Students()
            {
                Name = "Cody",
                Computer = 100,
                Math = 100,
                English = 95
            };

            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream("student.bin", FileMode.Create))
            {
                bf.Serialize(fs, cody);
                
            }

            Console.WriteLine("Serialization Complete");

          using (FileStream fs = new FileStream("student.bin", FileMode.Open))
            {
                Students bStudent = (Students)bf.Deserialize(fs);
            }

            Console.WriteLine("Deserialization Complete");

        }
    }
}
