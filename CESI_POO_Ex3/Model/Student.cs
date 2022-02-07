using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CESI_POO_Ex3.Model
{
    public class Student : Person
    {
        public int Score { get; private set; }
        public Student(string firstname, string lastName, int score) : base(firstname, lastName)
        {
            Score = score;
        }

        public override string ToString()
        {
            return base.ToString()
                + "\n" + "Score : " + Score;
        }
    }
}
