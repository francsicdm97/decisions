using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decisions
{
    internal class Members
    {
        // member - private field
        private string _name;
        private string _jobTitle;
        private int _salary;

        //member - public field
        public int age;

        //member - property - exposes name safely - proporties start with a capital letter
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        //public member Method - can be called from other classes
        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine("Hi my name is {0}, and I am {1} years old", _name, age);
            }
        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine("My salary is {0}", _salary);
        }

        //member cnstructor
        public Members()
        {
            age = 30;
            _name = "Dave";
            _jobTitle = "Dev";
            _salary = 30000;


            Console.WriteLine("Object created");
        }

        //member - finalizer - destructer
        ~Members()
        { 
           //Cleanr up statements
           Console.WriteLine("Deconstruction of Members object");
           Debug.Write("Destrcution of Members object");
        }

    }
}
