using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IValueConverterProject.Classes
{
    public class Person : INotifyPropertyChanged
    {

        private string name;

        public string Name
        {
            get { return name; }
            set {
                onPropertyChanged("Name");
                name = value;
            }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set {
                age = value;
                onPropertyChanged("Age");
            }
        }

        private string gender;

        public string Gender
        {
            get { return gender; }
            set {
                gender = value;
                onPropertyChanged("Gender");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void onPropertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
