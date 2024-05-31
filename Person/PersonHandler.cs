using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkapsling__arv_och_polymorfism.Inkapsling
{
    public class PersonHandler
    {
        public Person CreatePerson(uint age, string fName, string lName, double height, double weight)
        {
            Person person = new(fName, lName);
            SetAge(person, age);
            SetHeight(person, height);
            SetWeight(person, weight);

            return person;
        }

        public void SetAge(Person pers, uint age)
        {
            pers.Age = age;
        }
        public void SetHeight(Person pers, double height)
        {
            pers.Height = height;
        }
        public void SetWeight(Person pers, double weight)
        {
            pers.Weight = weight;
        }
    }
}
