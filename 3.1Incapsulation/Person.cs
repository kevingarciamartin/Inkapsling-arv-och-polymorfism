using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1Incapsulation
{
    public class Person
    {
        // Private fields
        private uint _age;
        private string _fName, _lName;
        private double _height, _weight;

        // Public properties
        public uint Age
        {
            get { return _age; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Age must be greater than 0.");

                _age = value;
            }
        }
        public string FName
        {
            get { return _fName; }
            set
            {
                if (value.Length < 2 || value.Length > 10)
                    throw new ArgumentException("First name must be between 2 and 10 characters.");

                _fName = value;
            }
        }
        public string LName
        {
            get { return _lName; }
            set
            {
                if (value.Length < 3 || value.Length > 15)
                    throw new ArgumentException("Last name must be between 3 and 15 characters.");

                _lName = value;
            }
        }
        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }
        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        // Constructors
        public Person(string fName, string lName)
        {
            FName = fName ?? string.Empty;
            LName = lName ?? string.Empty;
        }
    }
}
