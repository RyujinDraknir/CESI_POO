using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CESI_POO_Ex3.Model
{
    public class Teacher : Person
    {
        public Subject Subject { get; private set; }
        public Teacher(string firstName, string lastName, Subject subject) : base(firstName, lastName)
        {
            Subject = subject;
        }

        public override string ToString()
        {
            return base.ToString()
                + "\n" + "Subject : " +  Subject;
        }
    }
}
