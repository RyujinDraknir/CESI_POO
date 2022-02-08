using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CESI_POO_Ex5.Model
{
    public class Orange : Fruit
    {
        public Orange(string color) : base(color)
        {
        }

        public override void Eat()
        {
            Console.WriteLine("You ate an Orange !");
        }

    }
}
