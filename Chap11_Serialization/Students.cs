using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap11_Serialization
{
    [Serializable]
    class Students
    {
         
            public string Name { get; set; }
            public int English { get; set; }
            public int Math { get; set; }
            public int Computer { get; set; }
            public int Marks => English + Math + Computer;
     
    }
}
