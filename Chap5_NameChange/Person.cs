using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap5_NameChange
{
    class Person:INotifyPropertyChanged
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set {
                _name = value;
                // Call OnPropertyChaned when the name is updated
                OnPropertyChanged("Name");
            }
        }

        private void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if(handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        
    }
}
