using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap5_NameChange
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person()
            {
                Name = "Cody Newman"
            };

            person.PropertyChanged += OnPropertyChanged;

            person.Name = "Connor Newman";
        }

        private static void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            Person person = (Person)sender;
            Console.WriteLine($"{e.PropertyName} changed to {person.Name}");
            
        }
    }
}
