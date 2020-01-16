using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Laboration3 
{
    public class Registry
    {
        public List<Person> Person { get; }
        public Registry()
        {
            Person = new List<Person>();
        }
        public Person RegisterPerson(double birthday, string sex, string haircolor, string eyecolor, int hairlength)
        {
            Person person = new Person(birthday, sex, haircolor, eyecolor, hairlength);
            Person.Add(person);
            return person;
        }

       

    }
}

