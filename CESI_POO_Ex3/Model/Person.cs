using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CESI_POO_Ex3.Model
{
    public class Person
    {
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public Person(string firstname, string lastName)
        {
            FirstName = firstname;
            LastName = lastName;
        }
        public override string ToString()
        {
            return "First Name : " + FirstName
                + "\n" + "Last Name : " + LastName;
        }
    }
}
